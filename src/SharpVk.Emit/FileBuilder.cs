using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace SharpVk.Emit
{
    public class FileBuilder
        : IDisposable
    {
        private readonly IndentedTextWriter fileWriter;

        private bool hasFirstParagraph = false;
        private bool previousParagraphWasNamespace = false;

        private static List<string> paths = new List<string>();

        public FileBuilder(string folderPath, string fileName)
        {
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            var filePath = Path.Combine(folderPath, fileName);

            Debug.Assert(!paths.Contains(filePath), "File should not be written twice.");

            paths.Add(filePath);

            if (File.Exists(filePath))
            {
                try
                {
                    File.Delete(filePath);
                }
                catch
                {
                    //HACK Getting intermittent file-lock errors
                }
            }

            this.fileWriter = new IndentedTextWriter(new StreamWriter(File.OpenWrite(filePath)));
        }

        public void EmitComment(string comment)
        {
            this.EmitParagraphSpacing();

            foreach (var line in comment.Split('\n'))
            {
                this.fileWriter.WriteLine("// " + line.Trim());
            }
        }

        public void EmitUsing(string @namespace)
        {
            this.EmitParagraphSpacing(true);

            this.fileWriter.WriteLine($"using {@namespace};");
        }

        public void EmitNamespace(string name, Action<NamespaceBuilder> @namespace)
        {
            this.EmitParagraphSpacing();

            this.fileWriter.WriteLine($"namespace {name}");
            using (var builder = new NamespaceBuilder(this.fileWriter.GetSubWriter()))
            {
                @namespace(builder);
            }
        }

        private void EmitParagraphSpacing(bool isNamespace = false)
        {
            if (hasFirstParagraph && !(isNamespace && this.previousParagraphWasNamespace))
            {
                this.fileWriter.WriteLine();
            }
            else
            {
                hasFirstParagraph = true;
            }

            this.previousParagraphWasNamespace = isNamespace;
        }

        public void Dispose()
        {
            this.fileWriter.Flush();
            this.fileWriter.Dispose();
        }
    }
}
