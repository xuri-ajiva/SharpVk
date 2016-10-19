using SharpVk.Generator.Emit;
using SharpVk.SpirvJson;
using System.Linq;

using static SharpVk.Generator.Emit.AccessModifier;
using static SharpVk.Generator.Emit.ExpressionBuilder;

namespace SharpVk.Generator.Generators.Spirv
{
    public class SpirvOpCodeGenerator
        : ModelGenerator<SpirvGrammarModel>
    {
        public override void Run(SpirvGrammarModel model, FileGenerator fileGenerator)
        {
            fileGenerator.Generate("Spirv", "Opcode", fileBuilder =>
            {
                fileBuilder.EmitNamespace("SharpVk.Spirv", namespaceBuilder =>
                {
                    namespaceBuilder.EmitType(TypeKind.Struct, "OpCode", typeBuilder =>
                    {
                        foreach (var instruction in model.Instructions)
                        {
                            typeBuilder.EmitField("OpCode",
                                                    instruction.OpName,
                                                    Public,
                                                    MemberModifier.Static | MemberModifier.Readonly,
                                                    MemberInit("OpCode", members =>
                                                        {
                                                            members.EmitMember("Op", EnumField("Op", instruction.OpName));
                                                            if (instruction.Operands != null)
                                                            {
                                                                var operands = instruction.Operands.Select(operand =>
                                                                    MemberInit("Operand", operandMembers =>
                                                                    {
                                                                        string quantifier = operand.Quantifier == "*" ? "Multiple" : operand.Quantifier == "?" ? "Optional" : "None";
                                                                        operandMembers.EmitMember("Kind", Member(Variable("OperandKind"), operand.Kind));
                                                                        operandMembers.EmitMember("Quantifier", EnumField("Quantifier", quantifier));
                                                                        operandMembers.EmitMember("Name", Literal((operand.Name ?? "").Replace("\n", "")));
                                                                    })).ToArray();

                                                                members.EmitMember("Operands", ArrayInit("Operand", operands));
                                                            }
                                                        }));
                        }
                    }, Public, modifiers: TypeModifier.Partial);
                });
            });
        }
    }
}
