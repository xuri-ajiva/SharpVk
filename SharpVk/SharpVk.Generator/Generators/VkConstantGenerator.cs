using Microsoft.CSharp;
using SharpVk.Generator.Emit;
using SharpVk.VkXml;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;

using static SharpVk.Generator.Emit.AccessModifier;
using static SharpVk.Generator.Emit.ExpressionBuilder;
using static SharpVk.Generator.Emit.MemberModifier;

namespace SharpVk.Generator.Generators
{
    public class VkConstantGenerator
        : ModelGenerator<TypeSet>
    {
        private static CSharpCodeProvider codeDomCompiler = new CSharpCodeProvider();

        public override void Run(TypeSet types, FileGenerator fileGenerator)
        {
            var subGroups = types.Constants.Select(x => x.SubGroupName).Distinct();

            fileGenerator.Generate(null, "Constants", fileBuilder =>
            {
                fileBuilder.EmitNamespace("SharpVk", namespaceBuilder =>
                {
                    foreach (var subGroup in subGroups.Where(x => x != null))
                    {
                        namespaceBuilder.EmitType(TypeKind.Class, subGroup, typeBuilder =>
                        {
                            EmitConstantSubGroup(typeBuilder, types.Constants.Where(x => x.SubGroupName == subGroup));
                        }, Public, modifiers: TypeModifier.Static);
                    }

                    namespaceBuilder.EmitType(TypeKind.Class, "Constants", typeBuilder =>
                    {
                        EmitConstantSubGroup(typeBuilder, types.Constants.Where(x => x.SubGroupName == null));
                    }, Public, modifiers: TypeModifier.Static | TypeModifier.Partial);
                });
            });
        }

        private static void EmitConstantSubGroup(TypeBuilder typeBuilder, IEnumerable<TypeSet.VkConstant> constants)
        {
            foreach (var constant in constants)
            {
                string typeName = constant.ExplicitType ?? GetTypeName(constant.Type);

                MemberModifier fieldModifiers = constant.IsStaticReadonly
                                                    ? Static | Readonly
                                                    : Const;

                typeBuilder.EmitField(typeName, constant.Name, Public, fieldModifiers, AsIs(constant.Value), summary: constant.Comment);
            }
        }

        private static string GetTypeName(Type type)
        {
            var codeDomType = new CodeTypeReference(type);

            return codeDomCompiler.GetTypeOutput(codeDomType);
        }
    }
}