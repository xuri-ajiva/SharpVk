using SharpVk.VkXml;
using System;
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

            var devices = instance.EnumeratePhysicalDevices();

            foreach (var device in devices)
            {
                var features = device.GetPhysicalDeviceFeatures();

                Enumerate(features);

                var formatProps = device.GetPhysicalDeviceFormatProperties(Format.A8b8g8r8UnormPack32);

                Enumerate(formatProps);
            }

            Console.WriteLine("Done");
            Console.ReadLine();

            instance.DestroyInstance(null);

            //var parser = new SpecParser(new VkXmlCache("./vkXml.xml"));

            //var spec = parser.Run();

            //var generator = new TypeGenerator();

            //generator.Generate(spec);
        }

        private static void Enumerate<T>(T features)
        {
            foreach (var field in typeof(T).GetFields(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public))
            {
                Console.WriteLine("{0} = {1}", field.Name, field.GetValue(features));
            }
        }
    }
}