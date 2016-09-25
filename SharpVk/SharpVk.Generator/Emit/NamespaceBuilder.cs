using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SharpVk.Generator.Emit
{
    public class NamespaceBuilder
        : BlockBuilder
    {
        private bool hasFirstElement = false;

        public NamespaceBuilder(IndentedTextWriter writer)
            : base(writer)
        {
        }

        public void EmitType(TypeKind kind,
                                string name,
                                Action<TypeBuilder> @type,
                                AccessModifier accessModifier = AccessModifier.Internal,
                                TypeModifier modifiers = TypeModifier.None,
                                IEnumerable<string> summary = null,
                                Action<DocBuilder> docs = null,
                                IEnumerable<string> attributes = null)
        {
            if (this.hasFirstElement)
            {
                this.writer.WriteLine();
            }
            else
            {
                this.hasFirstElement = true;
            }

            var docsBuilder = new DocBuilder(this.writer.GetSubWriter(), summary);

            docs?.Invoke(docsBuilder);

            if (attributes != null)
            {
                foreach (var attributeName in attributes)
                {
                    this.writer.WriteLine($"[{attributeName}]");
                }
            }

            this.writer.WriteLine($"{accessModifier.Emit()} {RenderMemberModifiers(modifiers)}{kind.ToString().ToLowerInvariant()} {name}");
            using (var builder = new TypeBuilder(this.writer.GetSubWriter()))
            {
                @type(builder);
            }
        }

        private string RenderMemberModifiers(TypeModifier modifiers)
        {
            var builder = new StringBuilder();

            foreach (TypeModifier value in Enum.GetValues(typeof(TypeModifier)))
            {
                if (value != TypeModifier.None && modifiers.HasFlag(value))
                {
                    builder.Append(value.ToString().ToLowerInvariant() + " ");
                }
            }

            return builder.ToString();
        }
    }
}