using SharpVk.Generator.Generators;
using SharpVk.VkXml;
using System;

using static System.Linq.Expressions.Expression;

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

            foreach (var modelGenerator in new ModelGenerator[]
            {
                new InteropCommandsGenerator(),
                new InteropHandleGenerator(),
                new InteropStructGenerator()
            })
            {
                modelGenerator.Run(types, fileGenerator);
            }

            Console.WriteLine("Done");
            Console.ReadLine();
        }
    }
}