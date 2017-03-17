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
        private IEnumerable<StructDefinition> structs;
        private IEnumerable<EnumDefinition> enums;

        public EmitterStage(IEnumerable<PInvokeDefinition> pInvokes, IEnumerable<StructDefinition> structs, IEnumerable<EnumDefinition> enums)
        {
            this.pInvokes = pInvokes;
            this.structs = structs;
            this.enums = enums;
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
                            typeBuilder.EmitMethod(/*pInvoke.ReturnType*/ "void", pInvoke.Name, null, paramsBuilder =>
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

            foreach (var @struct in this.structs)
            {
                using (var fileBuilder = new FileBuilder("..\\SharpVk", $"{@struct.Name}.cs"))
                {
                    fileBuilder.EmitUsing("System");

                    fileBuilder.EmitNamespace("SharpVk", namespaceBuilder =>
                    {
                        namespaceBuilder.EmitType(TypeKind.Class, @struct.Name, typeBuilder =>
                        {
                        }, Public);
                    });
                }
            }

            foreach (var @enum in this.enums)
            {
                //using (var fileBuilder = new FileBuilder("..\\SharpVk", $"{@enum.Name}.cs"))
                //{
                //    fileBuilder.EmitUsing("System");

                //    fileBuilder.EmitNamespace("SharpVk", namespaceBuilder =>
                //    {
                //        namespaceBuilder.EmitType(TypeKind.Enum, @enum.Name, typeBuilder =>
                //        {
                //        }, Public);
                //    });
                //}
                System.Console.WriteLine(@enum.Name);
            }
        }
    }
}
