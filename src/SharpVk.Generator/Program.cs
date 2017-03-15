using SharpVk.Generator.Collation;
using SharpVk.Generator.Emission;
using SharpVk.Generator.Generation;
using SharpVk.Generator.Pipeline;
using SharpVk.Generator.Specification;
using System;

namespace SharpVk.Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            var pipeline = PipelineBuilder.Create<LoadXmlStage>()
                                            .Extend<SpecParserSetup, SpecParseStage>()
                                            .Extend<CollationSetup, CollationStage>()
                                            .Extend<GenerationStage>()
                                            .Build<EmitterStage>();

            pipeline.Run();

            Console.WriteLine("Done");
            Console.ReadLine();
        }
    }
}