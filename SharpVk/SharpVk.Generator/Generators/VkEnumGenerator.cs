using SharpVk.VkXml;

using static SharpVk.Generator.Emit.AccessModifier;
using static SharpVk.Generator.Emit.ExpressionBuilder;

namespace SharpVk.Generator.Generators
{
    public class VkEnumGenerator
        : ModelGenerator<TypeSet>
    {
        public override void Run(TypeSet types, FileGenerator fileGenerator)
        {
            fileGenerator.Generate(null, "Enums", builder =>
            {
                builder.EmitUsing("System");

                builder.EmitNamespace("SharpVk", namespaceBuilder =>
                {
                    foreach (var @enum in types.Enumerations)
                    {
                        var attributes = @enum.IsFlags
                                            ? new[] { "Flags" }
                                            : null;

                        namespaceBuilder.EmitEnum(@enum.Name, enumBuilder =>
                        {
                            foreach (var field in @enum.Fields)
                            {
                                enumBuilder.EmitField(field.Name, AsIs(field.Value), field.Comment);
                            }
                        }, Public, @enum.Comment, attributes: attributes);
                    }
                });
            });
        }
    }
}
