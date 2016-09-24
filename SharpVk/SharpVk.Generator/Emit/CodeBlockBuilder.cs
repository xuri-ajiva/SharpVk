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

        public void EmitVariableDeclaration(string type, string name, Action<ExpressionBuilder> assignment = null)
        {
            this.writer.Write($"{type} {name}");
            if (assignment != null)
            {
                this.writer.Write(" = ");
                assignment(new ExpressionBuilder(this.writer.GetSubWriter()));
            }
            this.writer.WriteLine(";");
        }

        public void EmitReturn(Action<ExpressionBuilder> expression)
        {
            this.writer.Write($"return ");
            expression(new ExpressionBuilder(this.writer.GetSubWriter()));
            this.writer.WriteLine(";");
        }

        public void EmitStatement(string statement)
        {
            this.writer.WriteLine(statement);
        }
    }
}