using SharpVk.Emit;
using SharpVk.Generator.Generation;
using SharpVk.Generator.Pipeline;
using System.Collections.Generic;

using static SharpVk.Emit.AccessModifier;
using static SharpVk.Emit.MemberModifier;

namespace SharpVk.Generator.Emission
{
    public class EmitterStage
        : IOutput
    {
        private IEnumerable<PInvokeDefinition> pInvokes;

        public EmitterStage(IEnumerable<PInvokeDefinition> pInvokes)
        {
            this.pInvokes = pInvokes;
        }

        public void Run()
        {
            using (var fileBuilder = new FileBuilder("..\\SharpVk\\Interop", "Commands.cs"))
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
                            typeBuilder.EmitMethod("void", pInvoke.Name, null, paramsBuilder =>
                            {
                                //foreach (var param in pInvoke.Parameters)
                                //{
                                //    paramsBuilder.EmitParam(param.TypeName, param.Name);
                                //}
                            }, Public, Static | Extern, attributes: new[] { "DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)" });
                        }
                    }, Public, modifiers: TypeModifier.Static | TypeModifier.Unsafe);
                });
            }
        }
    }
}
