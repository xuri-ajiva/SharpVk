using SharpVk.Emit;
using SharpVk.Generator.Generation;
using SharpVk.Generator.Pipeline;
using System.Collections.Generic;

using static SharpVk.Emit.AccessModifier;
using static SharpVk.Emit.ExpressionBuilder;
using static SharpVk.Emit.TypeModifier;

namespace SharpVk.Generator.Emission
{
    public class ConstantEmitter
        : IOutputWorker
    {
        private readonly IEnumerable<ConstantDefinition> constants;
        private readonly FileBuilderFactory builderFactory;

        public ConstantEmitter(IEnumerable<ConstantDefinition> constants, FileBuilderFactory builderFactory)
        {
            this.constants = constants;
            this.builderFactory = builderFactory;
        }

        public void Execute()
        {
            this.builderFactory.Generate("Constants", fileBuilder =>
            {
                fileBuilder.EmitNamespace("SharpVk", namespaceBuilder =>
                {
                    namespaceBuilder.EmitType(TypeKind.Class, "Constants", typeBuilder =>
                    {
                        foreach(var constant in this.constants)
                        {
                            typeBuilder.EmitField(constant.Type, constant.Name, Public, MemberModifier.Const, AsIs(constant.Value));
                        }
                    }, Public, modifiers: Static);
                });
            });
        }
    }
}
