using SharpVk.VkXml;
using System;

namespace SharpVk.Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            var xmlCache = new VkXmlCache(".\\VkTemplates");

            var parser = new SpecParser(xmlCache);
            var generator = new TypeGenerator();

            var types = generator.Generate(parser.Run());

            Console.WriteLine("Done");
            Console.ReadLine();
        }
    }
}