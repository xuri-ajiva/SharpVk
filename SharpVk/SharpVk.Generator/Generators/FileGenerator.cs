using SharpVk.Generator.Emit;
using SharpVk.VkXml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpVk.Generator.Generators
{
    public class FileGenerator
    {
        private readonly string basePath;

        public FileGenerator(string basePath)
        {
            this.basePath = basePath;
        }

        public void Run(string outputFolder, string filename, IEnumerable<ClassGenerator> classGenerators)
        {
            string outputPath = Path.Combine(this.basePath, outputFolder);

            if (!Directory.Exists(outputPath))
            {
                Directory.CreateDirectory(outputPath);
            }

            using (var generatedFile = File.CreateText(Path.Combine(outputPath, filename + ".cs")))
            {
                var indentedWriter = new IndentedTextWriter(generatedFile);

                foreach (var requirement in classGenerators.SelectMany(x => x.RequiredNamespaces).Distinct())
                {
                    indentedWriter.WriteLine($"using {requirement};");
                }
                indentedWriter.WriteLine();
                indentedWriter.WriteLine($"namespace SharpVk.{outputFolder}");
                indentedWriter.WriteLine("{");
                indentedWriter.IncreaseIndent();
                indentedWriter.WriteLine("public class Temp");
                foreach (var classGenerator in classGenerators)
                {
                    using (var builder = new TypeBuilder(indentedWriter.GetSubWriter()))
                    {
                        classGenerator.Run(builder);
                    }
                }
                indentedWriter.DecreaseIndent();
                indentedWriter.WriteLine("}");
            }
        }
    }
}
