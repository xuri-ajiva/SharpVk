using SharpVk.Generator.Emit;
using SharpVk.VkXml;
using static SharpVk.Generator.Emit.AccessModifier;
using static SharpVk.Generator.Emit.MemberModifier;

namespace SharpVk.Generator.Generators
{
    public class VkCommandsGenerator
        : ModelGenerator
    {
        public override void Run(TypeSet types, FileGenerator fileGenerator)
        {
            fileGenerator.Generate("Interop", "Commands", fileBuilder =>
            {
                fileBuilder.EmitUsing("System");
                fileBuilder.EmitUsing("System.Runtime.InteropServices");

                fileBuilder.EmitNamespace("SharpVk.Interop", namespaceBuilder =>
                {
                    namespaceBuilder.EmitType(TypeKind.Class, "Commands", typeBuilder =>
                    {
                        typeBuilder.EmitField("string", "VulkanDll", Public, Const, expr => expr.EmitLiteral("vulkan-1.dll"));

                        foreach (var command in types.Commands)
                        {
                            typeBuilder.EmitMethod(command.ReturnTypeName, command.Name, null, paramsBuilder =>
                            {
                                foreach (var param in command.Parameters)
                                {
                                    paramsBuilder.EmitParam(param.TypeName, param.Name);
                                }
                            }, Public, Static | Extern, attributes: new[] { "DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)" });
                        }
                    }, Public, modifiers: TypeModifier.Static | TypeModifier.Unsafe);
                });
            });
        }
    }
}