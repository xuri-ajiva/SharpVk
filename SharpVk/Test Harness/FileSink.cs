using SharpVk.Spirv;
using System;
using System.IO;

namespace SharpVk
{
    public class FileSink
        : ISpirvSink, IDisposable
    {
        private StreamWriter file;

        public FileSink(string fileName)
        {
            this.file = new StreamWriter(Path.Combine(".\\", fileName));
        }

        public void AddStatement(ResultId? resultId, SpirvStatement statement)
        {
            if (resultId.HasValue)
            {
                this.file.WriteLine($"{resultId} = {statement}");
            }
            else
            {
                this.file.WriteLine(statement);
            }

            this.file.Flush();
        }

        public void Dispose()
        {
            this.file.Dispose();
            this.file = null;
        }
    }
}
