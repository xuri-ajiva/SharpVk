using System;

namespace SharpVk.Emit
{
    public class MemberInitBuilder
    {
        private IndentedTextWriter writer;
        private bool hasFirstBinding = false;

        public MemberInitBuilder(IndentedTextWriter writer)
        {
            this.writer = writer;
        }

        public void EmitMember(string memberName, Action<ExpressionBuilder> expression)
        {
            if (this.hasFirstBinding)
            {
                this.writer.WriteLine(",");
            }
            else
            {
                this.writer.WriteLine();

                this.hasFirstBinding = true;
            }

            this.writer.Write($"{memberName} = ");
            expression(new ExpressionBuilder(this.writer.GetSubWriter()));
        }
    }
}