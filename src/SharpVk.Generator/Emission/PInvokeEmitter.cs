using SharpVk.Emit;
using SharpVk.Generator.Generation;
using SharpVk.Generator.Pipeline;
using System.Collections.Generic;
using static SharpVk.Emit.AccessModifier;
using static SharpVk.Emit.MemberModifier;

namespace SharpVk.Generator.Emission
{
    public class PInvokeEmitter
        : IOutputWorker
    {
        private readonly IEnumerable<PInvokeDefinition> pInvokes;
        private readonly FileBuilderFactory builderFactory;

        public PInvokeEmitter(IEnumerable<PInvokeDefinition> pInvokes, FileBuilderFactory builderFactory)
        {
            this.pInvokes = pInvokes;
            this.builderFactory = builderFactory;
        }

        public void Execute()
        {
            this.builderFactory.Generate("Commands", "Interop", fileBuilder =>
            {
                fileBuilder.EmitUsing("System");
                fileBuilder.EmitUsing("System.Runtime.InteropServices");

                fileBuilder.EmitNamespace("SharpVk.Interop", namespaceBuilder =>
                {
                    namespaceBuilder.EmitType(TypeKind.Class, "Commands", typeBuilder =>
                    {
                        typeBuilder.EmitField("string", "VulkanDll", Public, Const, expr => expr.EmitLiteral("vulkan-1.dll"));

                        foreach (var pInvoke in this.pInvokes)
                        {
                            typeBuilder.EmitMethod(pInvoke.ReturnType, pInvoke.Name, null, paramsBuilder =>
                            {
                                foreach (var param in pInvoke.Parameters)
                                {
                                    paramsBuilder.EmitParam(param.Type, param.Name);
                                }
                            }, Public, Static | Extern, attributes: new[] { "DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)" });
                        }
                    }, Public, modifiers: TypeModifier.Static | TypeModifier.Unsafe);
                });
            });
        }
    }
}
