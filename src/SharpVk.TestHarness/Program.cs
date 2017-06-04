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

            var devices = instance.EnumeratePhysicalDevices();

            var layers = Instance.EnumerateLayerProperties();

            var extensions = Instance.EnumerateExtensionProperties(null);

            var properties = devices.Select(x => x.GetProperties()).ToArray();
        }
    }
}