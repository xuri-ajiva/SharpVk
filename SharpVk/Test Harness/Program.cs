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

            var spec = parser.Run();

            var generator = new TypeGenerator();

            generator.Generate(spec);

            Console.WriteLine("Done");
            Console.ReadLine();
        }
    }
}