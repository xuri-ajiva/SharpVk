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
        private IEnumerable<EnumDefinition> enums;

        public EnumEmitter(IEnumerable<EnumDefinition> enums)
        {
            this.enums = enums;
        }

        public void Execute()
        {
            foreach (var @enum in this.enums)
            {
                using (var fileBuilder = new FileBuilder("..\\SharpVk", $"{@enum.Name}.cs"))
                {
                    fileBuilder.EmitNamespace("SharpVk", namespaceBuilder =>
                    {
                        namespaceBuilder.EmitEnum(@enum.Name, enumBuilder =>
                        {
                            foreach(var field in @enum.Fields)
                            {
                                enumBuilder.EmitField(field.Name, AsIs(field.Value));
                            }
                        }, Public);
                    });
                }
            }
        }
    }
}
