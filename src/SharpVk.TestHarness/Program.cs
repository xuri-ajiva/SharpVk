using System;
using System.Linq;
using System.Runtime.InteropServices;

namespace SharpVk.TestHarness
{
    class Program
    {
        static void Main(string[] args)
        {
            var instance = Instance.Create(new InstanceCreateInfo
            {
            }, null);
            
            var physicalDevice = instance.EnumeratePhysicalDevices().First();
            
            uint hostVisibleMemory = physicalDevice.GetMemoryProperties().MemoryTypes.Select((x, index) => (x, (uint)index)).First(x => x.Item1.PropertyFlags.HasFlag(MemoryPropertyFlags.HostVisible | MemoryPropertyFlags.HostCoherent)).Item2;

            var device = physicalDevice.CreateDevice(new DeviceCreateInfo
            {
                QueueCreateInfos = new[]
                {
                    new DeviceQueueCreateInfo
                    {
                        QueueFamilyIndex = 0,
                        QueuePriorities = new float[]{ 0 }
                    }
                }
            });

            var sharedMemory = device.AllocateMemory(new MemoryAllocateInfo
            {
                MemoryTypeIndex = hostVisibleMemory,
                AllocationSize = 1 << 20
            });

            var inBuffer = device.CreateBuffer(new BufferCreateInfo
            {
                QueueFamilyIndices = new uint[] { 0 },
                SharingMode = SharingMode.Exclusive,
                Usage = BufferUsageFlags.TransferSource,
                Flags = BufferCreateFlags.None,
                Size = 1024
            });

            inBuffer.BindMemory(sharedMemory, 0);

            var outBuffer = device.CreateBuffer(new BufferCreateInfo
            {
                QueueFamilyIndices = new uint[] { 0 },
                SharingMode = SharingMode.Exclusive,
                Usage = BufferUsageFlags.TransferDestination,
                Flags = BufferCreateFlags.None,
                Size = 1024
            });

            outBuffer.BindMemory(sharedMemory, 2048);

            IntPtr inBufferPtr = sharedMemory.Map(0, 1024, MemoryMapFlags.None);

            Marshal.Copy(Enumerable.Range(0, 256).Select(x => x).ToArray(), 0, inBufferPtr, 256);

            sharedMemory.Unmap();
            
            var commandPool = device.CreateCommandPool(new CommandPoolCreateInfo
            {
                Flags = CommandPoolCreateFlags.Transient,
                QueueFamilyIndex = 0
            });

            var transferCommandBuffer = device.AllocateCommandBuffers(new CommandBufferAllocateInfo
            {
                CommandBufferCount = 1,
                CommandPool = commandPool,
                Level = CommandBufferLevel.Primary
            }).First();

            transferCommandBuffer.Begin(new CommandBufferBeginInfo { Flags = CommandBufferUsageFlags.OneTimeSubmit });

            transferCommandBuffer.CopyBuffer(inBuffer, outBuffer, new[] { new BufferCopy(0, 0, 1024) });

            transferCommandBuffer.End();

            var transferQueue = device.GetQueue(0, 0);

            transferQueue.Submit(new[] { new SubmitInfo { CommandBuffers = new[] { transferCommandBuffer } } }, null);

            transferQueue.WaitIdle();

            IntPtr outBufferPtr = sharedMemory.Map(2048, 1024, MemoryMapFlags.None);

            for (int index = 0; index < 256; index++)
            {
                Console.WriteLine(Marshal.ReadInt32(outBufferPtr, index * 4));
            }

            Console.ReadLine();

            sharedMemory.Unmap();

            commandPool.FreeCommandBuffers(new[] { transferCommandBuffer });

            commandPool.Destroy();

            outBuffer.Destroy();

            inBuffer.Destroy();

            sharedMemory.Free();

            device.Destroy();

            instance.Destroy();
        }
    }
}