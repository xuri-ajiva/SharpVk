using System.IO;
using System.Linq;
using System.Text;

namespace SharpVk.Emit
{
    public class IndentedTextWriter
        : TextWriter
    {
        private readonly TextWriter baseWriter;
        private int indent;
        private bool beginningOfLine;

        public IndentedTextWriter(TextWriter baseWriter, bool beginningOfLine = true)
            : base(baseWriter.FormatProvider)
        {
            this.baseWriter = baseWriter;
            this.beginningOfLine = beginningOfLine;
            this.indent = 0;
        }

        public void IncreaseIndent()
        {
            this.indent++;
        }

        public void DecreaseIndent()
        {
            this.indent--;
        }

        public int IndentCharacters
        {
            get
            {
                int result = this.indent * 4;

                var baseIndentWriter = this.baseWriter as IndentedTextWriter;

                if (baseIndentWriter != null)
                {
                    result += baseIndentWriter.IndentCharacters;
                }

                return result;
            }
        }

        public override void Write(char value)
        {
            if (this.beginningOfLine)
            {
                this.baseWriter.Write(Enumerable.Repeat(' ', indent * 4).ToArray());
                this.beginningOfLine = false;
            }

            this.baseWriter.Write(value);

            if (value == '\n')
            {
                this.beginningOfLine = true;
            }
        }

        public IndentedTextWriter GetSubWriter(bool beginningOfLine = true)
        {
            return new IndentedTextWriter(this, beginningOfLine);
        }

        public override Encoding Encoding
        {
            get
            {
                return this.baseWriter.Encoding;
            }
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                this.baseWriter.Flush();
                this.baseWriter.Dispose();
            }

            base.Dispose(disposing);
        }
    }
}
