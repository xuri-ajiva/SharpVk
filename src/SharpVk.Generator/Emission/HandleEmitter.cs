using SharpVk.Emit;
using SharpVk.Generator.Generation;
using SharpVk.Generator.Pipeline;
using System.Collections.Generic;

using static SharpVk.Emit.AccessModifier;

namespace SharpVk.Generator.Emission
{
    class HandleEmitter
        : IOutputWorker
    {
        private readonly IEnumerable<HandleDefinition> handles;
        private readonly FileBuilderFactory builderFactory;

        public HandleEmitter(IEnumerable<HandleDefinition> handles, FileBuilderFactory builderFactory)
        {
            this.handles = handles;
            this.builderFactory = builderFactory;
        }

        public void Execute()
        {
            foreach (var handle in this.handles)
            {
                this.builderFactory.Generate(handle.Name, "Interop", fileBuilder =>
                {
                    fileBuilder.EmitUsing("System");

                    fileBuilder.EmitNamespace("SharpVk.Interop", namespaceBuilder =>
                    {
                        namespaceBuilder.EmitType(TypeKind.Struct, handle.Name, typeBuilder =>
                        {
                        }, Public);
                    });
                });
            }
        }
    }
}
