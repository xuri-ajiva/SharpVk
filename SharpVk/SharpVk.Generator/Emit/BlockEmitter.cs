using System;

namespace SharpVk.Generator.Emit
{
    public class BlockEmitter
        : IDisposable
    {
        protected readonly IndentedTextWriter writer;

        public BlockEmitter(IndentedTextWriter writer)
        {
            this.writer = writer;
            this.writer.WriteLine("{");
            this.writer.IncreaseIndent();
        }

        public void Dispose()
        {
            this.writer.DecreaseIndent();
            this.writer.WriteLine("}");
        }
    }
}
