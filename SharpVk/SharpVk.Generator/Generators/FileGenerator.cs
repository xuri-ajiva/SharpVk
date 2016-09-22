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

                indentedWriter.WriteLine($@"// The MIT License (MIT)
//
// Copyright (c) Andrew Armstrong/FacticiusVir {DateTime.UtcNow.Year}
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the ""Software""), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED ""AS IS"", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.");
                indentedWriter.WriteLine();
                indentedWriter.WriteLine("// This file was automatically generated and should not be editted directly.");
                indentedWriter.WriteLine();

                foreach (var requirement in classGenerators.SelectMany(x => x.RequiredNamespaces).Distinct())
                {
                    indentedWriter.WriteLine($"using {requirement};");
                }

                indentedWriter.WriteLine();
                indentedWriter.WriteLine($"namespace SharpVk.{outputFolder}");
                indentedWriter.WriteLine("{");
                indentedWriter.IncreaseIndent();

                bool isFirstClass = true;

                foreach (var classGenerator in classGenerators)
                {
                    if (!isFirstClass)
                    {
                        indentedWriter.WriteLine();
                    }
                    else
                    {
                        isFirstClass = false;
                    }

                    string typeDeclaration = classGenerator.IsStruct
                                                ? "struct"
                                                : "class";

                    if (!string.IsNullOrEmpty(classGenerator.Modifiers))
                    {
                        typeDeclaration = classGenerator.Modifiers + " " + typeDeclaration;
                    }

                    indentedWriter.WriteLine($"public {typeDeclaration} {classGenerator.Name}");
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
