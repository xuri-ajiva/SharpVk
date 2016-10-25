using SharpVk.Generator.Emit;
using SharpVk.VkXml;
using System.Threading.Tasks;

using static SharpVk.Generator.Emit.AccessModifier;
using static SharpVk.Generator.Emit.ExpressionBuilder;
using static SharpVk.Generator.Emit.MemberModifier;

namespace SharpVk.Generator.Generators
{
    public class VkInteropStructsGenerator
        : ModelGenerator<TypeSet>
    {
        public override void Run(TypeSet types, FileGenerator fileGenerator)
        {
            Parallel.ForEach(types.InteropStructs, @struct =>
            {
                fileGenerator.Generate("Interop", @struct.Name, builder =>
                {
                    builder.EmitUsing("System");
                    builder.EmitUsing("System.Runtime.InteropServices");

                    builder.EmitNamespace("SharpVk.Interop", namespaceBuilder =>
                    {
                        namespaceBuilder.EmitType(TypeKind.Struct, @struct.Name, typeBuilder =>
                        {
                            foreach (var member in @struct.Members)
                            {
                                typeBuilder.EmitField(member.TypeName, member.Name, member.IsPrivate ? Private : Public);
                            }
                        }, Public, modifiers: TypeModifier.Unsafe, attributes: new[] { "StructLayout(LayoutKind.Sequential)" });
                    });
                });
            });

            Parallel.ForEach(types.Classes, @class =>
            {
                fileGenerator.Generate(null, @class.Name, fileBuilder =>
                {
                    fileBuilder.EmitUsing("System");

                    fileBuilder.EmitNamespace("SharpVk", namespaceBuilder =>
                    {
                        namespaceBuilder.EmitType(TypeKind.Struct, @class.Name, builder =>
                            {
                                foreach (var member in @class.Properties)
                                {
                                    builder.EmitProperty(member.TypeName, member.Name, Public, getter: Public, setter: Public, summary: member.Comment);
                                }

                                string interopTypeName = $"Interop.{@class.Name}";
                                string interopPointerName = interopTypeName + "*";

                                if (!@class.IsOutput)
                                {
                                    builder.EmitMethod(interopTypeName, "Pack", body =>
                                    {
                                        const string resultVariableName = "result";

                                        body.EmitVariableDeclaration(interopTypeName, resultVariableName, Default(interopTypeName));

                                        foreach (var statement in @class.MarshalToStatements)
                                        {
                                            body.EmitStatement(statement);
                                        }

                                        body.EmitReturn(Variable(resultVariableName));
                                    }, null, Internal, Unsafe);

                                    builder.EmitMethod(interopPointerName, "MarshalTo", body =>
                                    {
                                        body.EmitReturn(Cast(interopPointerName, Call(StaticCall("Interop.HeapUtil", "AllocateAndMarshal", Call(This, "Pack")), "ToPointer")));
                                    }, null, Internal, Unsafe);
                                }
                                else
                                {
                                    builder.EmitMethod(@class.Name, "MarshalFrom", body =>
                                    {
                                        const string resultVariableName = "result";

                                        body.EmitVariableDeclaration(@class.Name, resultVariableName, New(@class.Name));

                                        foreach (var statement in @class.MarshalFromStatements)
                                        {
                                            body.EmitStatement(statement);
                                        }

                                        body.EmitReturn(Variable(resultVariableName));
                                    }, parameters =>
                                    {
                                        parameters.EmitParam(interopPointerName, "value");
                                    }, Internal, Static | Unsafe);
                                }
                            }, Public, summary: @class.Comment);
                    });
                });
            });
        }
    }
}