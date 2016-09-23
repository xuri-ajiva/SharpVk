using System;

namespace SharpVk.Generator.Emit
{
    public class CodeBlockBuilder
        : BlockBuilder
    {
        public CodeBlockBuilder(IndentedTextWriter writer)
            : base(writer)
        {
        }

        internal void EmitReturn(Action<ExpressionBuilder> expression)
        {
            this.writer.Write($"return ");
            expression(new ExpressionBuilder(this.writer.GetSubWriter()));
            this.writer.WriteLine(";");
        }
    }
}