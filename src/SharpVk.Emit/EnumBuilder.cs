using System;
using System.Collections.Generic;
using System.Text;

namespace SharpVk.Emit
{
    public class EnumBuilder
        : BlockBuilder
    {
        private bool hasFirstMember = false;

        public EnumBuilder(IndentedTextWriter writer)
            : base(writer)
        {
        }

        public void EmitField(string name,
                                Action<ExpressionBuilder> initialiser = null,
                                IEnumerable<string> summary = null,
                                Action<DocBuilder> docs = null,
                                IEnumerable<string> attributes = null)
        {
            if (this.hasFirstMember)
            {
                this.writer.WriteLine();
            }
            else
            {
                this.hasFirstMember = true;
            }

            var docBuilder = new DocBuilder(this.writer.GetSubWriter(), summary);

            docs?.Invoke(docBuilder);

            this.writer.Write($"{name}");
            if (initialiser != null)
            {
                writer.Write(" = ");
                initialiser(new ExpressionBuilder(this.writer.GetSubWriter()));
            }
            this.writer.WriteLine(", ");
        }
    }
}