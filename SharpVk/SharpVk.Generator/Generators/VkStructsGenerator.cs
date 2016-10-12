using SharpVk.Generator.Emit;
using SharpVk.VkXml;

using static SharpVk.Generator.Emit.AccessModifier;
using static SharpVk.Generator.Emit.ExpressionBuilder;
using static SharpVk.Generator.Emit.MemberModifier;

namespace SharpVk.Generator.Generators
{
    public class VkStructsGenerator
        : ModelGenerator
    {
        public override void Run(TypeSet types, FileGenerator fileGenerator)
        {
            fileGenerator.Generate(null, "Structs", builder =>
            {
                builder.EmitUsing("System");
                builder.EmitUsing("System.Runtime.InteropServices");
                builder.EmitUsing("System.Text");

                builder.EmitNamespace("SharpVk", namespaceBuilder =>
                {
                    foreach (var @struct in types.Structs)
                    {
                        namespaceBuilder.EmitType(TypeKind.Struct,
                                                    @struct.Name,
                                                    typeBuilder =>
                                                    {
                                                        foreach (var member in @struct.Members)
                                                        {
                                                            typeBuilder.EmitField(member.TypeName,
                                                                                    member.Name,
                                                                                    member.IsPrivate ? Private : Public,
                                                                                    summary: member.Comment);
                                                        }

                                                        typeBuilder.EmitMethod("string",
                                                                                "ToString",
                                                                                methodBody =>
                                                                                {
                                                                                    methodBody.EmitVariableDeclaration("var", "builder", New("StringBuilder"));

                                                                                    methodBody.EmitCall(Variable("builder"), "AppendLine", Literal(@struct.Name));
                                                                                    methodBody.EmitCall(Variable("builder"), "AppendLine", Literal("{"));
                                                                                    foreach (var member in @struct.Members)
                                                                                    {
                                                                                        methodBody.EmitCall(Variable("builder"), "AppendLine", Literal('$', $"{member.Name}: {{this.{member.Name}}}"));
                                                                                    }
                                                                                    methodBody.EmitCall(Variable("builder"), "Append", Literal("}"));

                                                                                    methodBody.EmitReturn(Call(Variable("builder"), "ToString"));
                                                                                },
                                                                                null,
                                                                                Public,
                                                                                Override);
                                                    },
                                                    Public,
                                                    modifiers: TypeModifier.Partial,
                                                    attributes: new[] { "StructLayout(LayoutKind.Sequential)" },
                                                    summary: @struct.Comment);
                    }
                });
            });
        }
    }
}