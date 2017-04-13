using SharpVk.Emit;
using SharpVk.Generator.Generation;
using SharpVk.Generator.Pipeline;
using System.Collections.Generic;
using System.Linq;
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
                string path = null;
                string @namespace = "SharpVk";

                string interopPath = "Interop";
                string interopNamespace = "SharpVk.Interop";

                if (handle.Namespace?.Any() ?? false)
                {
                    path = string.Join("\\", handle.Namespace);
                    @namespace += "." + string.Join(".", handle.Namespace);

                    interopPath += "\\" + string.Join("\\", handle.Namespace);
                    interopNamespace += "." + string.Join(".", handle.Namespace);
                }

                this.builderFactory.Generate(handle.Name, interopPath, fileBuilder =>
                {
                    fileBuilder.EmitUsing("System");

                    fileBuilder.EmitNamespace(interopNamespace, namespaceBuilder =>
                    {
                        namespaceBuilder.EmitType(TypeKind.Struct, handle.Name, typeBuilder =>
                        {
                        }, Public);
                    });
                });

                this.builderFactory.Generate(handle.Name, path, fileBuilder =>
                {
                    fileBuilder.EmitUsing("System");

                    fileBuilder.EmitNamespace(@namespace, namespaceBuilder =>
                    {
                        namespaceBuilder.EmitType(TypeKind.Class, handle.Name, typeBuilder =>
                        {
                        }, Public);
                    });
                });
            }
        }
    }
}
