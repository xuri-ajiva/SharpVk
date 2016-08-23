using SharpVk.VkXml;
using System;

namespace SharpVk
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            var xmlCache = new VkXmlCache(".\\TempFiles");

            var parser = new SpecParser(xmlCache, ".\\TempFiles");
            var generator = new TypeGenerator();

            var types = generator.Generate(parser.Run());

            Console.WriteLine("Done");
            Console.ReadLine();
        }
    }
}