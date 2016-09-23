using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;

namespace SharpVk.Generator.Emit
{
    public class TypeBuilder
        : BlockBuilder
    {
        private bool hasFirstMember = false;

        public TypeBuilder(IndentedTextWriter writer)
            : base(writer)
        {
        }

        public void EmitField(string type,
                                string name,
                                AccessModifier accessModifier = AccessModifier.Private,
                                MemberModifier methodModifers = MemberModifier.None,
                                Action<ExpressionBuilder> initialiser = null)
        {
            this.EmitMemberSpacing();

            this.writer.Write($"{accessModifier.Emit()} {RenderMemberModifiers(methodModifers)}{type} {name}");
            if (initialiser != null)
            {
                writer.Write(" = ");
                initialiser(new ExpressionBuilder(this.writer.GetSubWriter()));
            }
            this.writer.WriteLine("; ");
        }

        public void EmitMethod(string returnType,
                                string name, Action<CodeBlockBuilder> methodBody,
                                Action<ParameterBuilder> parameters,
                                AccessModifier accessModifier = AccessModifier.Private,
                                MemberModifier methodModifers = MemberModifier.None,
                                IEnumerable<string> attributes = null)
        {
            this.EmitMemberSpacing();

            if (attributes != null)
            {
                foreach (var attributeName in attributes)
                {
                    this.writer.WriteLine($"[{attributeName}]");
                }
            }

            string parameterList = parameters != null
                                    ? ParameterBuilder.Apply(parameters)
                                    : "";

            this.writer.Write($"{accessModifier.Emit()} {RenderMemberModifiers(methodModifers)}{returnType} {name}({parameterList})");

            if (methodBody == null)
            {
                this.writer.WriteLine(";");
            }
            else
            {
                this.writer.WriteLine();

                using (var bodyEmitter = new CodeBlockBuilder(this.writer.GetSubWriter()))
                {
                    methodBody(bodyEmitter);
                }
            }
        }

        public void EmitProperty(string type,
                                    string name,
                                    AccessModifier accessModifier = AccessModifier.Private,
                                    MemberModifier methodModifers = MemberModifier.None,
                                    Action<CodeBlockBuilder> getter = null,
                                    Action<CodeBlockBuilder> setter = null)
        {
            this.EmitMemberSpacing();

            this.writer.WriteLine($"{accessModifier.Emit()} {RenderMemberModifiers(methodModifers)}{type} {name}");
            this.writer.WriteLine("{");
            this.writer.IncreaseIndent();
            if (getter != null)
            {
                this.writer.WriteLine("get");
                using (var getBuilder = new CodeBlockBuilder(this.writer))
                {
                    getter(getBuilder);
                }
            }
            this.writer.DecreaseIndent();
            this.writer.WriteLine("}");
        }

        private string RenderMemberModifiers(MemberModifier modifiers)
        {
            var builder = new StringBuilder();

            if (modifiers.HasFlag(MemberModifier.Const))
            {
                builder.Append("const ");
            }
            else if (modifiers.HasFlag(MemberModifier.Static))
            {
                builder.Append("static ");
            }

            return builder.ToString();
        }

        private void EmitMemberSpacing()
        {
            if (this.hasFirstMember)
            {
                this.writer.WriteLine();
            }
            else
            {
                this.hasFirstMember = true;
            }
        }
    }
}
