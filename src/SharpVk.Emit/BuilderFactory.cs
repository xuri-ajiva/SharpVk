using System.Collections.Generic;
using System.IO;

namespace SharpVk.Emit
{
    public class BuilderFactory
    {
        private readonly string outputFolder;

        public BuilderFactory(string outputFolder)
        {
            this.outputFolder = outputFolder;
        }

        public FileBuilder CreateFile(string subFolder, string fileName)
        {
            return new FileBuilder(Path.Combine(this.outputFolder, subFolder ?? "."), fileName);
        }
    }
}
