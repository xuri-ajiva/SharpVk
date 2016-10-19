using SharpVk.Generator.Emit;
using SharpVk.SpirvJson;
using System.Linq;

using static SharpVk.Generator.Emit.AccessModifier;
using static SharpVk.Generator.Emit.ExpressionBuilder;
using static SharpVk.Generator.Emit.MemberModifier;

namespace SharpVk.Generator.Generators.Spirv
{
    public class SpirvOperandKindGenerator
        : ModelGenerator<SpirvGrammarModel>
    {
        public override void Run(SpirvGrammarModel model, FileGenerator fileGenerator)
        {
            fileGenerator.Generate("Spirv", "OperandKind", fileBuilder =>
            {
                fileBuilder.EmitNamespace("SharpVk.Spirv", namespaceBuilder =>
                {
                    namespaceBuilder.EmitType(TypeKind.Struct, "OperandKind", typeBuilder =>
                    {
                        foreach (var kind in model.Operand_Kinds)
                        {
                            typeBuilder.EmitField("OperandKind",
                                                    kind.Kind,
                                                    Public,
                                                    Static | Readonly,
                                                    New("OperandKind"));
                        }
                    }, Public, modifiers: TypeModifier.Partial);
                });
            });
        }
    }
}
