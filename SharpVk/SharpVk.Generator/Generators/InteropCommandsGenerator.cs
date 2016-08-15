using SharpVk.VkXml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpVk.Generator.Generators
{
    public class InteropCommandsGenerator
    {
        public void Run(TypeSet types, string basePath)
        {
            using (var generatedFile = File.CreateText(Path.Combine(basePath, "Interop", "Commands.cs")))
            {
                generatedFile.WriteLine("Test");
            }
        }
    }
}
