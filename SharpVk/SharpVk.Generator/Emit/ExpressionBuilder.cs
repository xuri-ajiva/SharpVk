using System;
using System.Collections.Generic;

namespace SharpVk.Generator.Emit
{
    public class ExpressionBuilder
    {
        private readonly IndentedTextWriter writer;

        public ExpressionBuilder(IndentedTextWriter writer)
        {
            this.writer = writer;
        }

        public void EmitAsIs(string expression)
        {
            this.writer.Write(expression);
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

        public void EmitNew(string name, params Action<ExpressionBuilder>[] arguments)
        {
            this.writer.Write($"new {name}(");
            this.EmitArguments(arguments);
            this.writer.Write(")");
        }

        public void EmitDefault(string type)
        {
            this.writer.Write($"default({type})");
        }

        public void EmitNull()
        {
            this.writer.Write("null");
        }

        public void EmitThis()
        {
            this.writer.Write("this");
        }

        public void EmitVariable(string name)
        {
            this.writer.Write(name);
        }

        public void EmitCast(string type, Action<ExpressionBuilder> target)
        {
            this.writer.Write($"({type})");
            target(this.GetSubBuilder());
        }

        public void EmitStaticCall(string type, string method, params Action<ExpressionBuilder>[] arguments)
        {
            this.writer.Write($"{type}.{method}(");

            this.EmitArguments(arguments);

            this.writer.Write(")");
        }

        public void EmitCall(Action<ExpressionBuilder> target, string method, params Action<ExpressionBuilder>[] arguments)
        {
            target(this.GetSubBuilder());

            this.writer.Write($".{method}(");

            this.EmitArguments(arguments);

            this.writer.Write(")");
        }

        private void EmitArguments(IEnumerable<Action<ExpressionBuilder>>arguments)
        {
            bool isFirstArgument = true;

            foreach (var argument in arguments)
            {
                if (isFirstArgument)
                {
                    isFirstArgument = false;
                }
                else
                {
                    this.writer.Write(", ");
                }

                argument(this.GetSubBuilder());
            }
        }

        private ExpressionBuilder GetSubBuilder()
        {
            return new ExpressionBuilder(this.writer.GetSubWriter());
        }

        public static Action<ExpressionBuilder> AsIs(string expression)
        {
            return builder => builder.EmitAsIs(expression);
        }

        public static Action<ExpressionBuilder> MemberInit(string name, Action<MemberInitBuilder> members)
        {
            return builder => builder.EmitMemberInit(name, members);
        }

        public static Action<ExpressionBuilder> New(string name, params Action<ExpressionBuilder>[] arguments)
        {
            return builder => builder.EmitNew(name, arguments);
        }

        public static Action<ExpressionBuilder> Default(string type)
        {
            return builder => builder.EmitDefault(type);
        }

        public static Action<ExpressionBuilder> Null
        {
            get
            {
                return builder => builder.EmitNull();
            }
        }

        public static Action<ExpressionBuilder> This
        {
            get
            {
                return builder => builder.EmitThis();
            }
        }

        public static Action<ExpressionBuilder> Variable(string name)
        {
            return builder => builder.EmitVariable(name);
        }

        public static Action<ExpressionBuilder> Cast(string type, Action<ExpressionBuilder> target)
        {
            return builder => builder.EmitCast(type, target);
        }

        public static Action<ExpressionBuilder> StaticCall(string type, string method, params Action<ExpressionBuilder>[] arguments)
        {
            return builder => builder.EmitStaticCall(type, method, arguments);
        }

        public static Action<ExpressionBuilder> Call(Action<ExpressionBuilder> target, string method, params Action<ExpressionBuilder>[] arguments)
        {
            return builder => builder.EmitCall(target, method, arguments);
        }
    }
}
