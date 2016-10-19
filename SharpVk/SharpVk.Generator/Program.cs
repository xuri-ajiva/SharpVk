using SharpVk.Generator.Generators;
using SharpVk.Generator.Generators.Spirv;
using SharpVk.SpirvJson;
using SharpVk.VkXml;

namespace SharpVk.Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            var xmlCache = new VkXmlCache(".\\VkTemplates");
            var jsonCache = new SpirvJsonCache(".\\VkTemplates");

            var parser = new SpecParser(xmlCache, ".\\VkTemplates");
            var generator = new TypeGenerator();

            var types = generator.Generate(parser.Run());

            var fileGenerator = new FileGenerator("..\\..\\..\\SharpVk");

            foreach (var modelGenerator in new ModelGenerator<TypeSet>[]
            {
                new VkCommandsGenerator(),
                new VkHandleGenerator(),
                new VkDelegateGenerator(),
                new VkEnumGenerator(),
                new VkStructsGenerator(),
                new VkUnionsGenerator(),
                new VkExceptionGenerator(),
                new VkConstantGenerator(),
                new VkInteropStructsGenerator()
            })
            {
                modelGenerator.Run(types, fileGenerator);
            }

            new SpirvEnumGenerator().Run(jsonCache.GetSpirvModel(), fileGenerator);

            var grammarModel = jsonCache.GetSpirvGrammar();
            new SpirvOpCodeGenerator().Run(grammarModel, fileGenerator);
            new SpirvOperandKindGenerator().Run(grammarModel, fileGenerator);
        }
    }
}