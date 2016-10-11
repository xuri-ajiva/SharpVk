using System;

namespace SharpVk.Generator.Emit
{
    public class BlockBuilder
        : IDisposable
    {
        protected readonly IndentedTextWriter writer;
        private readonly bool hasBraces;

        public BlockBuilder(IndentedTextWriter writer, bool hasBraces = true)
        {
            this.hasBraces = hasBraces;

            this.writer = writer;
            if (this.hasBraces)
            {
                this.writer.WriteLine("{");
            }
            this.writer.IncreaseIndent();
        }

        public void Dispose()
        {
            this.writer.DecreaseIndent();
            if (this.hasBraces)
            {
                this.writer.WriteLine("}");
            }
        }
    }
}
