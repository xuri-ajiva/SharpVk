using System;

namespace SharpVk.Generator.Emit
{
    public class SwitchCaseBuilder
        : BlockBuilder
    {
        public SwitchCaseBuilder(IndentedTextWriter writer)
            : base(writer)
        {
        }

        public void EmitCase(Action<ExpressionBuilder> value, Action<CodeBlockBuilder> caseBlock)
        {
            this.writer.Write("case ");
            value(new ExpressionBuilder(this.writer.GetSubWriter()));
            this.writer.WriteLine(":");
            using (var caseBuilder = new CodeBlockBuilder(this.writer.GetSubWriter(), false))
            {
                caseBlock(caseBuilder);
            }
        }
    }
}