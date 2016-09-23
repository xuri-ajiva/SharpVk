using System;

namespace SharpVk.Generator.Emit
{
    public class ExpressionBuilder
    {
        private readonly IndentedTextWriter writer;

        public ExpressionBuilder(IndentedTextWriter writer)
        {
            this.writer = writer;
        }

        public void EmitLiteral(string literal)
        {
            this.writer.Write('"');
            this.writer.Write(literal);
            this.writer.Write('"');
        }

        public void EmitMemberInit(string name, Action<MemberInitBuilder> members)
        {
            this.writer.WriteLine($"new {name}");
            this.writer.Write("{");
            this.writer.IncreaseIndent();
            members(new MemberInitBuilder(this.writer.GetSubWriter()));
            this.writer.DecreaseIndent();
            this.writer.WriteLine();
            this.writer.Write("}");
        }

        public void EmitDefault(string type)
        {
            this.writer.Write($"default({type})");
        }

        public static Action<ExpressionBuilder> MemberInit(string name, Action<MemberInitBuilder> members)
        {
            return builder => builder.EmitMemberInit(name, members);
        }

        public static Action<ExpressionBuilder> Default(string type)
        {
            return builder => builder.EmitDefault(type);
        }
    }
}
