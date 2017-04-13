using SharpVk.Emit;
using SharpVk.Generator.Generation;
using SharpVk.Generator.Pipeline;
using System.Collections.Generic;

using static SharpVk.Emit.AccessModifier;
using static SharpVk.Emit.ExpressionBuilder;

namespace SharpVk.Generator.Emission
{
    class EnumEmitter
        : IOutputWorker
    {
        private readonly IEnumerable<EnumDefinition> enums;
        private readonly FileBuilderFactory builderFactory;

        public EnumEmitter(IEnumerable<EnumDefinition> enums, FileBuilderFactory builderFactory)
        {
            this.enums = enums;
            this.builderFactory = builderFactory;
        }

        public void Execute()
        {
            foreach (var @enum in this.enums)
            {
                this.builderFactory.Generate(@enum.Name, fileBuilder =>
                {
                    fileBuilder.EmitNamespace("SharpVk", namespaceBuilder =>
                    {
                        namespaceBuilder.EmitEnum(@enum.Name, enumBuilder =>
                        {
                            foreach (var field in @enum.Fields)
                            {
                                enumBuilder.EmitField(field.Name, AsIs(field.Value));
                            }
                        }, Public);
                    });
                });
            }
        }
    }
}
