using SharpVk.Generator.Emit;
using SharpVk.VkXml;

using static SharpVk.Generator.Emit.AccessModifier;
using static SharpVk.Generator.Emit.TypeModifier;

namespace SharpVk.Generator.Generators
{
    public class VkDelegateGenerator
        : ModelGenerator
    {
        public override void Run(TypeSet types, FileGenerator fileGenerator)
        {
            fileGenerator.Generate("Interop", "Delegates", builder =>
            {
                builder.EmitUsing("System");

                builder.EmitNamespace("SharpVk.Interop", namespaceBuilder =>
                {
                    foreach (var @delegate in types.Delegates)
                    {
                        namespaceBuilder.EmitDelegate(@delegate.ReturnTypeName,
                                                        @delegate.Name,
                                                        Public,
                                                        Unsafe,
                                                        parameters =>
                                                        {
                                                            foreach (var param in @delegate.Parameters)
                                                            {
                                                                parameters.EmitParam(param.TypeName, param.Name);
                                                            }
                                                        },
                                                        @delegate.Comment);
                    }
                });
            });
        }
    }
}
