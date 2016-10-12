using SharpVk.Generator.Emit;
using SharpVk.VkXml;

using static SharpVk.Generator.Emit.AccessModifier;
using static SharpVk.Generator.Emit.ExpressionBuilder;
using static SharpVk.Generator.Emit.MemberModifier;

namespace SharpVk.Generator.Generators
{
    public class VkUnionsGenerator
        : ModelGenerator
    {
        public override void Run(TypeSet types, FileGenerator fileGenerator)
        {
            fileGenerator.Generate(null, "Unions", builder =>
            {
                builder.EmitUsing("System");
                builder.EmitUsing("System.Runtime.InteropServices");

                builder.EmitNamespace("SharpVk", namespaceBuilder =>
                {
                    foreach (var union in types.Unions)
                    {
                        namespaceBuilder.EmitType(TypeKind.Struct,
                                                    union.Name,
                                                    typeBuilder =>
                                                    {
                                                        foreach (var member in union.Members)
                                                        {
                                                            string castType = member.TypeName;

                                                            if (member.FixedSize > 0)
                                                            {
                                                                castType += "[]";

                                                                typeBuilder.EmitField(member.TypeName,
                                                                                        member.Name,
                                                                                        Private,
                                                                                        Fixed,
                                                                                        fixedLength: member.FixedSize,
                                                                                        attributes: new[] { $"FieldOffset({member.FieldOffset})" });
                                                            }
                                                            else
                                                            {
                                                                typeBuilder.EmitField(member.TypeName,
                                                                                        member.Name,
                                                                                        Private,
                                                                                        attributes: new[] { $"FieldOffset({member.FieldOffset})" });
                                                            }

                                                            typeBuilder.EmitMethod("operator",
                                                                                    union.Name,
                                                                                    methodBody =>
                                                                                    {
                                                                                        if (member.FixedSize > 0)
                                                                                        {
                                                                                            methodBody.EmitVariableDeclaration(union.Name, "result", New(union.Name));

                                                                                            methodBody.EmitStaticCall("MemUtil", "WriteToPtr", New("IntPtr", Member(Variable("result"), member.Name)), Variable(member.Name), Literal(0), Literal(member.FixedSize));

                                                                                            methodBody.EmitReturn(Variable("result"));
                                                                                        }
                                                                                        else
                                                                                        {
                                                                                            methodBody.EmitReturn(MemberInit(union.Name, members => members.EmitMember(member.Name, Variable(member.Name))));
                                                                                        }
                                                                                    },
                                                                                    parameters => parameters.EmitParam(castType, member.Name),
                                                                                    Public,
                                                                                    Static | Implicit,
                                                                                    summary: new[] { $"Implicit conversion of {castType} to {union.Name}." },
                                                                                    docs: docs => docs.EmitParam(member.Name, member.Comment[0]));
                                                        }
                                                    },
                                                    Public,
                                                    modifiers: TypeModifier.Unsafe | TypeModifier.Partial,
                                                    attributes: new[] { "StructLayout(LayoutKind.Explicit)" },
                                                    summary: union.Comment);
                    }
                });
            });
        }
    }
}