using System.Linq;

namespace SharpVk.TestHarness
{
    class Program
    {
        static void Main(string[] args)
        {
            var instance = Instance.Create(new InstanceCreateInfo
            {
            }, null);

            var physicalDevices = instance.EnumeratePhysicalDevices();

            var layers = Instance.EnumerateLayerProperties();

            var extensions = Instance.EnumerateExtensionProperties(null);

            var properties = physicalDevices.Select(x => x.GetProperties()).ToArray();

            var devices = physicalDevices.Select(x => x.CreateDevice(new DeviceCreateInfo
            {
                QueueCreateInfos = new[]
                {
                    new DeviceQueueCreateInfo
                    {
                        QueueFamilyIndex = 0,
                        QueuePriorities = new float[]{ 0 }
                    }
                }
            })).ToArray();
            
            foreach(var device in devices)
            {
                device.Destroy();
            }

            instance.Destroy();
        }
    }
}