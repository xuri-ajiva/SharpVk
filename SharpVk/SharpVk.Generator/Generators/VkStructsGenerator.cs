using SharpVk.Generator.Emit;
using SharpVk.VkXml;
using System.Threading.Tasks;

using static SharpVk.Generator.Emit.AccessModifier;
using static SharpVk.Generator.Emit.ExpressionBuilder;
using static SharpVk.Generator.Emit.MemberModifier;

namespace SharpVk.Generator.Generators
{
    public class VkStructsGenerator
        : ModelGenerator<TypeSet>
    {
        public override void Run(TypeSet types, FileGenerator fileGenerator)
        {
            Parallel.ForEach(types.Structs, @struct =>
            {
                fileGenerator.Generate(null, @struct.Name, builder =>
                {
                    builder.EmitUsing("System");
                    builder.EmitUsing("System.Runtime.InteropServices");
                    builder.EmitUsing("System.Text");

                    builder.EmitNamespace("SharpVk", namespaceBuilder =>
                    {
                        namespaceBuilder.EmitType(TypeKind.Struct,
                                                    @struct.Name,
                                                    typeBuilder =>
                                                    {
                                                        typeBuilder.EmitConstructor(body =>
                                                                                    {
                                                                                        foreach (var member in @struct.Members)
                                                                                        {
                                                                                            string paramName = char.ToLower(member.Name[0]) + member.Name.Substring(1);

                                                                                            body.EmitAssignment(Member(This, member.Name), Variable(paramName));
                                                                                        }
                                                                                    },
                                                                                    parameters =>
                                                                                    {
                                                                                        foreach(var member in @struct.Members)
                                                                                        {
                                                                                            string paramName = char.ToLower(member.Name[0]) + member.Name.Substring(1);

                                                                                            parameters.EmitParam(member.TypeName, paramName);
                                                                                        }
                                                                                    }, Public);

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
                    });
                });
            });
        }
    }
}