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

            var instance = Instance.Create(new[] { "VK_LAYER_LUNARG_standard_validation" }, new[] { "VK_EXT_debug_report" });

            var debugCallback = new DebugReportCallbackDelegate(DebugCallback);

            var callbackHandle = instance.CreateDebugReportCallback(new DebugReportCallbackCreateInfo
            {
                Callback = debugCallback,
                Flags = DebugReportFlags.Error | DebugReportFlags.Warning | DebugReportFlags.PerformanceWarning | DebugReportFlags.Information
            });

            var physicalDevice = instance.EnumeratePhysicalDevices().First();

            uint hostVisibleMemory = physicalDevice.GetMemoryProperties().MemoryTypes.Select((x, index) => (x, (uint)index)).First(x => x.Item1.PropertyFlags.HasFlag(MemoryPropertyFlags.HostVisible | MemoryPropertyFlags.HostCoherent)).Item2;

            var device = physicalDevice.CreateDevice(
                new[]
                {
                    new DeviceQueueCreateInfo
                    {
                        QueueFamilyIndex = 0,
                        QueuePriorities = new float[]{ 0 }
                    }
                },
                null,
                null
            );

            int valueCount = 256;
            int bufferSize = valueCount * sizeof(int);

            var sharedMemory = device.AllocateMemory(1 << 20, hostVisibleMemory);

            var inBuffer = device.CreateBuffer(bufferSize, BufferUsageFlags.TransferSource, SharingMode.Exclusive, new uint[] { 0 });

            inBuffer.BindMemory(sharedMemory, 0);

            int outBufferOffset = (int)inBuffer.GetMemoryRequirements().Size;

            var outBuffer = device.CreateBuffer(bufferSize, BufferUsageFlags.TransferDestination, SharingMode.Exclusive, new uint[] { 0 });

            outBuffer.BindMemory(sharedMemory, outBufferOffset);

            IntPtr inBufferPtr = sharedMemory.Map(0, bufferSize, MemoryMapFlags.None);

            Marshal.Copy(Enumerable.Range(0, valueCount).Select(x => x).ToArray(), 0, inBufferPtr, valueCount);

            sharedMemory.Unmap();

            var commandPool = device.CreateCommandPool(0, CommandPoolCreateFlags.Transient);

            var descriptorPool = device.CreateDescriptorPool(16, new[]
            {
                new DescriptorPoolSize
                {
                    Type = DescriptorType.StorageBuffer,
                    DescriptorCount = 16
                }
            });

            TransferByCommand(device, bufferSize, inBuffer, outBuffer, commandPool);

            //TransferByCompute(device, bufferSize, inBuffer, outBuffer, commandPool, descriptorPool);

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
            Console.WriteLine($"{pLayerPrefix}: {pMessage}");

            return false;
        }

        private static void TransferByCompute(Device device, int bufferSize, Buffer inBuffer, Buffer outBuffer, CommandPool commandPool, DescriptorPool descriptorPool)
        {
            var computeShaderData = LoadShaderData(".\\Shaders\\Shader.comp.spirv", out int codeSize);

            var shader = device.CreateShaderModule(codeSize, computeShaderData);

            var descriptorSetLayout = device.CreateDescriptorSetLayout(new[]
            {
                new DescriptorSetLayoutBinding
                {
                    StageFlags = ShaderStageFlags.Compute,
                    DescriptorType = DescriptorType.StorageBuffer,
                    Binding = 0,
                    ImmutableSamplers = new Sampler[]{null}
                },
                new DescriptorSetLayoutBinding
                {
                    StageFlags = ShaderStageFlags.Compute,
                    DescriptorType = DescriptorType.StorageBuffer,
                    Binding = 1,
                    ImmutableSamplers = new Sampler[]{null}
                }
            });

            var descriptorSets = device.AllocateDescriptorSets(descriptorPool, new[] { descriptorSetLayout });

            var pipelineLayout = device.CreatePipelineLayout(new[] { descriptorSetLayout }, null);

            var pipeline = device.CreateComputePipelines(null, new[]
            {
                new ComputePipelineCreateInfo
                {
                    Layout = pipelineLayout,
                    Stage = new PipelineShaderStageCreateInfo
                    {
                        Stage = ShaderStageFlags.Compute,
                        Module = shader
                    }
                }
            }).Single();



            pipeline.Destroy();

            pipelineLayout.Destroy();

            descriptorPool.FreeDescriptorSets(descriptorSets);

            descriptorSetLayout.Destroy();

            shader.Destroy();
        }

        private static void TransferByCommand(Device device, int bufferSize, Buffer inBuffer, Buffer outBuffer, CommandPool commandPool)
        {
            var transferCommandBuffer = device.AllocateCommandBuffers(commandPool, CommandBufferLevel.Primary, 1).Single();

            transferCommandBuffer.Begin(CommandBufferUsageFlags.OneTimeSubmit);

            transferCommandBuffer.CopyBuffer(inBuffer, outBuffer, new[] { new BufferCopy(0, 0, bufferSize) });

            transferCommandBuffer.End();

            var transferQueue = device.GetQueue(0, 0);

            transferQueue.Submit(new[] { new SubmitInfo { CommandBuffers = new[] { transferCommandBuffer } } }, null);

            transferQueue.WaitIdle();

            commandPool.FreeCommandBuffers(new[] { transferCommandBuffer });
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