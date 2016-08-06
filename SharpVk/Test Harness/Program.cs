using SharpVk.VkXml;
using System;
using System.Linq;
using System.Reflection;

namespace SharpVk
{
    class Program
    {
        static void Main(string[] args)
        {
            var instance = Instance.CreateInstance(new InstanceCreateInfo
            {
                ApplicationInfo = new ApplicationInfo
                {
                    ApplicationName = "Example Application",
                    EngineName = "SharpVK"
                },
                EnabledExtensionNames = new[] { "VK_KHR_surface", "VK_KHR_win32_surface" }
            }, null);

            var physicalDevices = instance.EnumeratePhysicalDevices();

            var deviceCreateInfo = new DeviceCreateInfo
            {
                QueueCreateInfos = new[]
                {
                    new DeviceQueueCreateInfo
                    {
                        QueueFamilyIndex = 0,
                        QueuePriorities = new float[] { 1 }
                    }
                }
            };

            foreach (var physicalDevice in physicalDevices)
            {
                Enumerate(physicalDevice.GetPhysicalDeviceProperties());

                uint memoryTypeIndex = (uint)physicalDevice.GetPhysicalDeviceMemoryProperties()
                                                                                        .MemoryTypes
                                                                                        .Select((mem, index) => Tuple.Create(mem, index))
                                                                                        .First(x => x.Item1.PropertyFlags.HasFlag(MemoryPropertyFlags.HostVisible)).Item2;

                var device = physicalDevice.CreateDevice(deviceCreateInfo, null);

                var memoryAllocateInfo = new MemoryAllocateInfo
                {
                    MemoryTypeIndex = memoryTypeIndex,
                    AllocationSize = 1 << 20
                };

                var memBlock = device.AllocateMemory(memoryAllocateInfo, null);

                IntPtr dataPointer = IntPtr.Zero;

                memBlock.MapMemory(0, 1024, MemoryMapFlags.None, ref dataPointer);
                
                memBlock.UnmapMemory();

                ulong size = memBlock.GetDeviceMemoryCommitment();

                memBlock.FreeMemory(null);

                device.DestroyDevice(null);
            }

            Console.WriteLine("Done");
            Console.ReadLine();

            instance.DestroyInstance(null);
        }

        private static void Enumerate<T>(T target)
        {
            foreach (var field in typeof(T).GetFields(BindingFlags.Instance | BindingFlags.Public))
            {
                Console.WriteLine("{0} = {1}", field.Name, field.GetValue(target));
            }

            foreach (var property in typeof(T).GetProperties(BindingFlags.Instance | BindingFlags.Public))
            {
                Console.WriteLine("{0} = {1}", property.Name, property.GetValue(target));
            }
        }
    }
}