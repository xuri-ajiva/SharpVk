using System;
using System.Linq;
using System.Runtime.InteropServices;

namespace SharpVk.TestHarness
{
    class Program
    {
        static void Main(string[] args)
        {
            var availableExtensions = Instance.EnumerateExtensionProperties(null);

            var instance = Instance.Create(null, null);
            
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

            var sharedMemory = device.AllocateMemory(1 << 20, hostVisibleMemory);

            var inBuffer = device.CreateBuffer(1024, BufferUsageFlags.TransferSource, SharingMode.Exclusive, new uint[] { 0 });

            inBuffer.BindMemory(sharedMemory, 0);

            var outBuffer = device.CreateBuffer(1024, BufferUsageFlags.TransferDestination, SharingMode.Exclusive, new uint[] { 0 });

            outBuffer.BindMemory(sharedMemory, 2048);

            IntPtr inBufferPtr = sharedMemory.Map(0, 1024);

            Marshal.Copy(Enumerable.Range(0, 256).Select(x => x).ToArray(), 0, inBufferPtr, 256);

            sharedMemory.Unmap();
            
            var commandPool = device.CreateCommandPool(0, CommandPoolCreateFlags.Transient);

            var transferCommandBuffer = device.AllocateCommandBuffers(commandPool, CommandBufferLevel.Primary, 1).Single();

            transferCommandBuffer.Begin(CommandBufferUsageFlags.OneTimeSubmit);

            transferCommandBuffer.CopyBuffer(inBuffer, outBuffer, new[] { new BufferCopy(0, 0, 1024) });

            transferCommandBuffer.End();

            var transferQueue = device.GetQueue(0, 0);

            transferQueue.Submit(new[] { new SubmitInfo { CommandBuffers = new[] { transferCommandBuffer } } }, null);

            transferQueue.WaitIdle();

            IntPtr outBufferPtr = sharedMemory.Map(2048, 1024);

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