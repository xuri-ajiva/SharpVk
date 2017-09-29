using SharpVk.Multivendor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace SharpVk.TestHarness
{
    class Program
    {
        static void Main(string[] args)
        {
            var availableExtensions = Instance.EnumerateExtensionProperties(null);

            var availableLayers = Instance.EnumerateLayerProperties();

            var instance = Instance.Create("VK_LAYER_LUNARG_standard_validation", ExtExtensions.DebugReport);

            var debugCallback = new DebugReportCallbackDelegate(DebugCallback);

            var callbackHandle = instance.CreateDebugReportCallback(debugCallback, DebugReportFlags.Error | DebugReportFlags.Warning | DebugReportFlags.PerformanceWarning | DebugReportFlags.Information);

            var physicalDevice = instance.EnumeratePhysicalDevices().First();

            var physicalDeviceProperties = physicalDevice.GetProperties();

            var features = physicalDevice.GetFeatures();

            uint hostVisibleMemory = physicalDevice.GetMemoryProperties().MemoryTypes.Select((x, index) => (Type: x, Index: (uint)index)).First(x => x.Type.PropertyFlags.HasFlag(MemoryPropertyFlags.HostVisible | MemoryPropertyFlags.HostCoherent)).Index;

            var device = physicalDevice.CreateDevice(
                new DeviceQueueCreateInfo
                {
                    QueueFamilyIndex = 0,
                    QueuePriorities = new float[] { 0 }
                },
                null,
                null
            );

            const int valueCount = 256;
            const int bufferSize = valueCount * sizeof(int);

            var sharedMemory = device.AllocateMemory(1 << 20, hostVisibleMemory);

            var inBuffer = device.CreateBuffer(bufferSize, BufferUsageFlags.TransferSource | BufferUsageFlags.StorageBuffer, SharingMode.Exclusive, 0);

            inBuffer.BindMemory(sharedMemory, 0);

            int outBufferOffset = (int)inBuffer.GetMemoryRequirements().Size;

            var outBuffer = device.CreateBuffer(bufferSize, BufferUsageFlags.TransferDestination | BufferUsageFlags.StorageBuffer, SharingMode.Exclusive, 0);

            outBuffer.BindMemory(sharedMemory, outBufferOffset);

            IntPtr inBufferPtr = sharedMemory.Map(0, bufferSize, MemoryMapFlags.None);

            Marshal.Copy(Enumerable.Range(0, valueCount).Select(x => x).ToArray(), 0, inBufferPtr, valueCount);

            sharedMemory.Unmap();

            var commandPool = device.CreateCommandPool(0, CommandPoolCreateFlags.Transient);

            var descriptorPool = device.CreateDescriptorPool(16, new DescriptorPoolSize(DescriptorType.StorageBuffer, 16));

            //TransferByCommand(device, bufferSize, inBuffer, outBuffer, commandPool);

            TransferByCompute(device, bufferSize, inBuffer, outBuffer, commandPool, descriptorPool);

            IntPtr outBufferPtr = sharedMemory.Map(outBufferOffset, bufferSize, MemoryMapFlags.None);

            var values = new List<int>();

            for (int index = 0; index < valueCount; index++)
            {
                values.Add(Marshal.ReadInt32(outBufferPtr, index * sizeof(int)));
            }

            sharedMemory.Unmap();

            Console.WriteLine(string.Join(", ", values));

            descriptorPool.Destroy();

            commandPool.Destroy();

            outBuffer.Destroy();

            inBuffer.Destroy();

            sharedMemory.Free();

            device.Destroy();

            callbackHandle.Destroy();

            instance.Destroy();

            Console.WriteLine("Done");

            Console.ReadLine();
        }

        private static Bool32 DebugCallback(DebugReportFlags flags, DebugReportObjectType objectType, ulong @object, HostSize location, int messageCode, string pLayerPrefix, string pMessage, IntPtr pUserData)
        {
            string logMessage = $"{pLayerPrefix}: {pMessage}";

            Console.WriteLine(logMessage);
            System.Diagnostics.Debug.WriteLine(logMessage);

            return false;
        }

        private static void TransferByCompute(Device device, int bufferSize, Buffer inBuffer, Buffer outBuffer, CommandPool commandPool, DescriptorPool descriptorPool)
        {
            var computeShaderData = LoadShaderData(".\\Shaders\\Shader.comp.spv", out int codeSize);

            var shader = device.CreateShaderModule(codeSize, computeShaderData);

            var descriptorSetLayout = device.CreateDescriptorSetLayout(new[]
            {
                new DescriptorSetLayoutBinding
                {
                    StageFlags = ShaderStageFlags.Compute,
                    DescriptorType = DescriptorType.StorageBuffer,
                    Binding = 0,
                    DescriptorCount = 1
                },
                new DescriptorSetLayoutBinding
                {
                    StageFlags = ShaderStageFlags.Compute,
                    DescriptorType = DescriptorType.StorageBuffer,
                    Binding = 1,
                    DescriptorCount = 1
                }
            });

            var descriptorSet = device.AllocateDescriptorSets(descriptorPool, descriptorSetLayout).Single();

            device.UpdateDescriptorSets(new[]
            {
                new WriteDescriptorSet
                {
                    DestinationSet = descriptorSet,
                    DescriptorType = DescriptorType.StorageBuffer,
                    DestinationBinding = 0,
                    DescriptorCount = 1,
                    BufferInfo = new []
                    {
                        new DescriptorBufferInfo
                        {
                            Buffer = inBuffer,
                            Range = Constants.WholeSize
                        }
                    }
                },
                new WriteDescriptorSet
                {
                    DestinationSet = descriptorSet,
                    DescriptorType = DescriptorType.StorageBuffer,
                    DestinationBinding = 1,
                    DescriptorCount = 1,
                    BufferInfo = new []
                    {
                        new DescriptorBufferInfo
                        {
                            Buffer = outBuffer,
                            Range = Constants.WholeSize
                        }
                    }
                }
            }, null);

            var pipelineLayout = device.CreatePipelineLayout(descriptorSetLayout, null);

            var pipeline = device.CreateComputePipelines(null,
                new ComputePipelineCreateInfo
                {
                    Layout = pipelineLayout,
                    Stage = new PipelineShaderStageCreateInfo
                    {
                        Stage = ShaderStageFlags.Compute,
                        Module = shader,
                        Name = "main"
                    }
                }).Single();

            var transferCommandBuffer = device.AllocateCommandBuffers(commandPool, CommandBufferLevel.Primary, 1).Single();

            transferCommandBuffer.Begin(CommandBufferUsageFlags.OneTimeSubmit);

            transferCommandBuffer.BindDescriptorSets(PipelineBindPoint.Compute, pipelineLayout, 0, descriptorSet, null);

            transferCommandBuffer.BindPipeline(PipelineBindPoint.Compute, pipeline);

            transferCommandBuffer.Dispatch(1, 1, 1);

            transferCommandBuffer.End();

            var transferQueue = device.GetQueue(0, 0);

            transferQueue.Submit(new SubmitInfo { CommandBuffers = new[] { transferCommandBuffer } }, null);

            transferQueue.WaitIdle();

            pipeline.Destroy();

            pipelineLayout.Destroy();

            descriptorSetLayout.Destroy();

            shader.Destroy();
        }

        private static void TransferByCommand(Device device, int bufferSize, Buffer inBuffer, Buffer outBuffer, CommandPool commandPool)
        {
            var transferCommandBuffer = device.AllocateCommandBuffers(commandPool, CommandBufferLevel.Primary, 1).Single();

            transferCommandBuffer.Begin(CommandBufferUsageFlags.OneTimeSubmit);

            transferCommandBuffer.CopyBuffer(inBuffer, outBuffer, new BufferCopy(0, 0, bufferSize));

            transferCommandBuffer.End();

            var transferQueue = device.GetQueue(0, 0);

            transferQueue.Submit(new SubmitInfo { CommandBuffers = new[] { transferCommandBuffer } }, null);

            transferQueue.WaitIdle();

            commandPool.FreeCommandBuffers(transferCommandBuffer);
        }

        private static uint[] LoadShaderData(string filePath, out int codeSize)
        {
            var fileBytes = System.IO.File.ReadAllBytes(filePath);
            var shaderData = new uint[(int)Math.Ceiling(fileBytes.Length / 4f)];

            System.Buffer.BlockCopy(fileBytes, 0, shaderData, 0, fileBytes.Length);

            codeSize = fileBytes.Length;

            return shaderData;
        }
    }
}