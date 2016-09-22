using System;
using System.Collections.Generic;
using System.Reflection;

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

        public void EmitField(string type, string name, AccessModifier accessModifier = AccessModifier.Private)
        {
            this.EmitMemberSpacing();

            this.writer.WriteLine($"{accessModifier.Emit()} {type} {name};");
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

            this.writer.Write($"{accessModifier.Emit()} {returnType} {name}()");

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

        private void EmitMemberSpacing()
        {
            if(!this.hasFirstMember)
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
