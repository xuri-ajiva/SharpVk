using SharpVk.Emit;
using SharpVk.Generator.Generation;
using SharpVk.Generator.Pipeline;
using System.Collections.Generic;
using static SharpVk.Emit.AccessModifier;

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
                    fileBuilder.EmitUsing("System");

                    fileBuilder.EmitNamespace("SharpVk", namespaceBuilder =>
                    {
                        namespaceBuilder.EmitType(TypeKind.Enum, @enum.Name, typeBuilder =>
                        {
                        }, Public);
                    });
                }
            }
        }
    }
}
