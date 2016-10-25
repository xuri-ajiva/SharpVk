using SharpVk.VkXml;
using System.Threading.Tasks;

using static SharpVk.Generator.Emit.AccessModifier;
using static SharpVk.Generator.Emit.ExpressionBuilder;

namespace SharpVk.Generator.Generators
{
    public class VkEnumGenerator
        : ModelGenerator<TypeSet>
    {
        public override void Run(TypeSet types, FileGenerator fileGenerator)
        {
            Parallel.ForEach(types.Enumerations, @enum =>
            {
                fileGenerator.Generate(null, @enum.Name, builder =>
                {
                    builder.EmitUsing("System");

                    builder.EmitNamespace("SharpVk", namespaceBuilder =>
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
                    });
                });
            });
        }
    }
}
