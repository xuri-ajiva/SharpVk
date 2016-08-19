using SharpVk.VkXml;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace SharpVk
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            var xmlCache = new VkXmlCache(".\\TempFiles");

            var parser = new SpecParser(xmlCache, ".\\TempFiles");
            //var generator = new TypeGenerator();

            //var types = generator.Generate(parser.Run());

            foreach (var handleType in parser.Run().Types.Values.Where(x => x.Category == TypeCategory.@struct && x.Extension == null))
            {
                var docFile = new DownloadedFileCache(".\\TempFiles", $"https://raw.githubusercontent.com/KhronosGroup/Vulkan-Docs/1.0/doc/specs/vulkan/man/{handleType.VkName}.txt");

                var docLines = File.ReadAllLines(docFile.GetFileLocation());

                int lineIndex;

                for (lineIndex = 0; docLines[lineIndex] != "Description"; lineIndex++) ;

                lineIndex += 3;

                var descriptionLines = docLines.Skip(lineIndex).AsEnumerable().TakeWhile(x => x != "See Also");

                descriptionLines = descriptionLines.Take(descriptionLines.Count() - 3).Where(x => !string.IsNullOrWhiteSpace(x));

                Console.WriteLine(handleType.VkName);
                Console.WriteLine();
                Console.WriteLine(string.Join("\n", descriptionLines));
                Console.WriteLine();
            }

            Console.WriteLine("Done");
            Console.ReadLine();
        }
    }
}