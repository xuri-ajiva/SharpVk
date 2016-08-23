using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpVk.Generator
{
    public class IndentedTextWriter
        : TextWriter
    {
        private readonly StreamWriter baseWriter;
        private int indent;
        private bool beginningOfLine;

        public IndentedTextWriter(StreamWriter baseWriter)
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

        public override void Write(char value)
        {
            if (this.beginningOfLine)
            {
                this.baseWriter.Write(Enumerable.Repeat('\t', indent).ToArray());
                this.beginningOfLine = false;
            }

            this.baseWriter.Write(value);

            if (value == '\n')
            {
                this.beginningOfLine = true;
            }
        }

        public override Encoding Encoding
        {
            get
            {
                return this.baseWriter.Encoding;
            }
        }
    }
}
