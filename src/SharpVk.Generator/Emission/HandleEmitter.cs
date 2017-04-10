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
        private IEnumerable<HandleDefinition> handles;

        public HandleEmitter(IEnumerable<HandleDefinition> handles)
        {
            this.handles = handles;
        }

        public void Execute()
        {
            foreach (var handle in this.handles)
            {
                using (var fileBuilder = new FileBuilder("..\\SharpVk\\Interop", $"{handle.Name}.cs"))
                {
                    fileBuilder.EmitUsing("System");

                    fileBuilder.EmitNamespace("SharpVk.Interop", namespaceBuilder =>
                    {
                        namespaceBuilder.EmitType(TypeKind.Struct, handle.Name, typeBuilder =>
                        {
                        }, Public);
                    });
                }
            }
        }
    }
}
