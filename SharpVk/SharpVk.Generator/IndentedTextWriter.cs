using System.IO;
using System.Linq;
using System.Text;

namespace SharpVk.Generator
{
    public class IndentedTextWriter
        : TextWriter
    {
        private readonly TextWriter baseWriter;
        private int indent;
        private bool beginningOfLine;

        public IndentedTextWriter(TextWriter baseWriter)
            : base(baseWriter.FormatProvider)
        {
            this.baseWriter = baseWriter;
            this.beginningOfLine = true;
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

                if(baseIndentWriter != null)
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

        public IndentedTextWriter GetSubWriter()
        {
            return new IndentedTextWriter(this);
        }

        public override Encoding Encoding
        {
            get
            {
                return this.baseWriter.Encoding;
            }
        }

        public override void Close()
        {
            this.baseWriter.Close();
            base.Close();
        }
    }
}
