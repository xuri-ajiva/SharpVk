using SharpVk.Generator.Generators;
using SharpVk.VkXml;
using System;

namespace SharpVk.Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            var xmlCache = new VkXmlCache(".\\VkTemplates");

            var parser = new SpecParser(xmlCache, ".\\VkTemplates");
            var generator = new TypeGenerator();

            var types = generator.Generate(parser.Run());

            var fileGenerator = new FileGenerator(".\\Generated");

            new InteropCommandsGenerator().Run(types, fileGenerator);
            new InteropHandleGenerator().Run(types, fileGenerator);

            Console.WriteLine("Done");
            Console.ReadLine();
        }
    }
}