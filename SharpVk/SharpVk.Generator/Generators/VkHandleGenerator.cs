using SharpVk.Generator.Emit;
using SharpVk.VkXml;

using static SharpVk.Generator.Emit.AccessModifier;
using static SharpVk.Generator.Emit.ExpressionBuilder;

namespace SharpVk.Generator.Generators
{
    public class VkHandleGenerator
        : ModelGenerator
    {
        public override void Run(TypeSet types, FileGenerator fileGenerator)
        {
            fileGenerator.Generate("Interop", "Structs", fileBuilder =>
            {
                fileBuilder.EmitUsing("System");

                fileBuilder.EmitNamespace("SharpVk.Interop", namespaceBuilder =>
                {
                    foreach (var handle in types.Handles)
                    {
                        namespaceBuilder.EmitType(TypeKind.Struct, handle.Name, typeBuilder =>
                        {
                            const string handleFieldName = "handle";

                            string internalHandleType = handle.IsDispatch
                                                            ? "IntPtr"
                                                            : "ulong";

                            typeBuilder.EmitField(internalHandleType, handleFieldName, Internal);

                            typeBuilder.EmitProperty(handle.Name, "Null", Public, MemberModifier.Static, getBuilder =>
                            {
                                getBuilder.EmitReturn(MemberInit(handle.Name, member =>
                                {
                                    member.EmitMember(handleFieldName, Default(internalHandleType));
                                }));
                            });
                        }, Public);
                    }
                });
            });
        }
    }
}