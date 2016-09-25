using SharpVk.Generator.Generators;
using SharpVk.VkXml;

namespace SharpVk.Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            var xmlCache = new VkXmlCache(".\\VkTemplates");

            var parser = new SpecParser(xmlCache, ".\\VkTemplates");
            var generator = new VkXml.TypeGenerator();

            var types = generator.Generate(parser.Run());

            var fileGenerator = new FileGenerator("..\\..\\..\\SharpVk");

            foreach (var modelGenerator in new ModelGenerator[]
            {
                new VkCommandsGenerator(),
                new VkHandleGenerator(),
                new VkClassGenerator()
            })
            {
                modelGenerator.Run(types, fileGenerator);
            }
        }
    }
}