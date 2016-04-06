using SharpVk.VkXml;
using System;

namespace SharpVk
{
    class Program
    {
        static void Main(string[] args)
        {
            //var instance = new Instance(new InstanceCreateInfo
            //{
            //    ApplicationInfo = new ApplicationInfo
            //    {
            //        ApplicationName = "Example Application",
            //        EngineName = "SharpVK"
            //    }
            //}, null);

            var parser = new SpecParser(new VkXmlCache("./vkXml.xml"));

            parser.Run();

            Console.WriteLine("Done");
            Console.ReadLine();
        }
    }
}
