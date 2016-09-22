using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace SharpVk.Generator.Emit
{
    public class TypeBuilder
        : BlockEmitter
    {
        private bool hasFirstMember = true;

        public TypeBuilder(IndentedTextWriter writer)
            : base(writer)
        {
        }

        public void EmitField(string type, string name, AccessModifier accessModifier = AccessModifier.Private, MemberModifier methodModifers = MemberModifier.None)
        {
            this.EmitMemberSpacing();

            this.writer.WriteLine($"{accessModifier.Emit()} {RenderMemberModifiers(methodModifers)}{type} {name};");
        }

        public void EmitMethod(string returnType,
                                string name, Action<CodeBlockEmitter> methodBody,
                                Action<ParameterEmitter> parameters,
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

            this.writer.Write($"{accessModifier.Emit()} {RenderMemberModifiers(methodModifers)}{returnType} {name}()");

            if (methodBody == null)
            {
                this.writer.WriteLine(";");
            }
            else
            {
                this.writer.WriteLine();

                using (var bodyEmitter = new CodeBlockEmitter(this.writer.GetSubWriter()))
                {
                    methodBody(bodyEmitter);
                }
            }
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
            if (!this.hasFirstMember)
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
