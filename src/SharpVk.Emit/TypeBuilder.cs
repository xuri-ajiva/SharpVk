using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;

namespace SharpVk.Emit
{
    public class TypeBuilder
        : BlockBuilder
    {
        private readonly string name;

        private bool hasFirstMember = false;

        public TypeBuilder(IndentedTextWriter writer, string name)
            : base(writer)
        {
            this.name = name;
        }

        public void EmitField(string type,
                                string name,
                                AccessModifier accessModifier = AccessModifier.Private,
                                MemberModifier methodModifers = MemberModifier.None,
                                Action<ExpressionBuilder> initialiser = null,
                                int? fixedLength = null,
                                IEnumerable<string> summary = null,
                                Action<DocBuilder> docs = null,
                                IEnumerable<string> attributes = null)
        {
            this.EmitMemberSpacing();

            this.EmitMemberComments(accessModifier, summary, docs);

            if (attributes != null)
            {
                foreach (var attributeName in attributes)
                {
                    this.writer.WriteLine($"[{attributeName}]");
                }
            }

            string fixedLengthSuffix = fixedLength.HasValue ? $"[{fixedLength.Value}]" : "";

            this.writer.Write($"{accessModifier.Emit()} {RenderMemberModifiers(methodModifers)}{type} {name}{fixedLengthSuffix}");
            if (initialiser != null)
            {
                writer.Write(" = ");
                initialiser(new ExpressionBuilder(this.writer.GetSubWriter()));
            }
            this.writer.WriteLine("; ");
        }

        public void EmitConstructor(Action<CodeBlockBuilder> methodBody,
                                    Action<ParameterBuilder> parameters,
                                    AccessModifier accessModifier = AccessModifier.Private,
                                    MemberModifier methodModifers = MemberModifier.None,
                                    IEnumerable<Action<ExpressionBuilder>> baseArguments = null,
                                    IEnumerable<string> summary = null,
                                    Action<DocBuilder> docs = null,
                                    IEnumerable<string> attributes = null)
        {
            this.EmitMemberSpacing();

            this.EmitMemberComments(accessModifier, summary, docs);

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

            this.writer.WriteLine($"{accessModifier.Emit()} {RenderMemberModifiers(methodModifers)}{this.name}({parameterList})");

            if (baseArguments != null)
            {
                this.writer.IncreaseIndent();
                this.writer.Write(": base(");
                ExpressionBuilder.EmitArguments(this.writer, baseArguments);
                this.writer.WriteLine(")");
                this.writer.DecreaseIndent();
            }

            using (var bodyEmitter = new CodeBlockBuilder(this.writer.GetSubWriter()))
            {
                methodBody(bodyEmitter);
            }
        }

        public void EmitMethod(string returnType,
                                string name,
                                Action<CodeBlockBuilder> methodBody,
                                Action<ParameterBuilder> parameters,
                                AccessModifier accessModifier = AccessModifier.Private,
                                MemberModifier methodModifers = MemberModifier.None,
                                IEnumerable<string> summary = null,
                                Action<DocBuilder> docs = null,
                                IEnumerable<string> attributes = null)
        {
            this.EmitMemberSpacing();

            this.EmitMemberComments(accessModifier, summary, docs);

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
                                    AccessModifier? getter = null,
                                    AccessModifier? setter = null,
                                    IEnumerable<string> summary = null,
                                    Action<DocBuilder> docs = null)
        {
            this.EmitMemberSpacing();

            this.EmitMemberComments(accessModifier, summary, docs);

            this.writer.WriteLine($"{accessModifier.Emit()} {RenderMemberModifiers(methodModifers)}{type} {name}");
            this.writer.WriteLine("{");
            this.writer.IncreaseIndent();

            if (getter != null)
            {
                if (getter.HasValue && getter.Value != accessModifier)
                {
                    this.writer.Write(getter.Value.Emit() + " ");
                }
                this.writer.WriteLine("get;");
            }

            if (setter != null)
            {
                if (setter.HasValue && setter.Value != accessModifier)
                {
                    this.writer.Write(setter.Value.Emit() + " ");
                }
                this.writer.WriteLine("set;");
            }

            this.writer.DecreaseIndent();
            this.writer.WriteLine("}");
        }

        public void EmitProperty(string type,
                                    string name,
                                    AccessModifier accessModifier = AccessModifier.Private,
                                    MemberModifier methodModifers = MemberModifier.None,
                                    Action<CodeBlockBuilder> getter = null,
                                    Action<CodeBlockBuilder> setter = null,
                                    IEnumerable<string> summary = null,
                                    Action<DocBuilder> docs = null)
        {
            this.EmitMemberSpacing();

            this.EmitMemberComments(accessModifier, summary, docs);

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

            if (setter != null)
            {
                this.writer.WriteLine("set");
                using (var setBuilder = new CodeBlockBuilder(this.writer))
                {
                    setter(setBuilder);
                }
            }

            this.writer.DecreaseIndent();
            this.writer.WriteLine("}");
        }

        public void EmitProperty(string type,
                                    string name,
                                    Action<ExpressionBuilder> getter,
                                    AccessModifier accessModifier = AccessModifier.Private,
                                    MemberModifier methodModifers = MemberModifier.None,
                                    IEnumerable<string> summary = null,
                                    Action<DocBuilder> docs = null)
        {
            this.EmitMemberSpacing();

            this.EmitMemberComments(accessModifier, summary, docs);

            this.writer.Write($"{accessModifier.Emit()} {RenderMemberModifiers(methodModifers)}{type} {name} => ");
            getter(new ExpressionBuilder(this.writer.GetSubWriter()));
            this.writer.WriteLine(";");
        }

        private void EmitMemberComments(AccessModifier accessModifier, IEnumerable<string> summary, Action<DocBuilder> docs)
        {
            if (accessModifier == AccessModifier.Public || summary != null || docs != null)
            {
                var docBuilder = new DocBuilder(this.writer.GetSubWriter(), summary);

                docs?.Invoke(docBuilder);
            }
        }

        private string RenderMemberModifiers(MemberModifier modifiers)
        {
            var builder = new StringBuilder();

            foreach (MemberModifier value in Enum.GetValues(typeof(MemberModifier)))
            {
                if (value != MemberModifier.None && modifiers.HasFlag(value))
                {
                    builder.Append(value.ToString().ToLowerInvariant() + " ");
                }
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
