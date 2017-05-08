using System.Linq;

namespace SharpVk.TestHarness
{
    class Program
    {
        static void Main(string[] args)
        {
            var instance = Instance.Create(new InstanceCreateInfo { });

            var devices = instance._EnumeratePhysicalDevices();

            var properties = devices.Select(x => x._GetProperties()).ToArray();
        }
    }
}