using System.Linq;

namespace SharpVk.TestHarness
{
    class Program
    {
        static void Main(string[] args)
        {
            var instance = Instance._Create(new InstanceCreateInfo
            {
                ApplicationInfo = new ApplicationInfo
                {
                    
                }
            });

            var devices = instance._EnumeratePhysicalDevices();

            var properties = devices.Select(x => x._GetProperties()).ToArray();
        }
    }
}