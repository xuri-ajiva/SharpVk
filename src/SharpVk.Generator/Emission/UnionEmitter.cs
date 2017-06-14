using SharpVk.Emit;
using SharpVk.Generator.Generation;
using SharpVk.Generator.Pipeline;
using System.Collections.Generic;
using static SharpVk.Emit.AccessModifier;

namespace SharpVk.Generator.Emission
{
    public class UnionEmitter
        : IOutputWorker
    {
        private readonly IEnumerable<UnionDefinition> unions;
        private readonly FileBuilderFactory builderFactory;

        public UnionEmitter(IEnumerable<UnionDefinition> unions, FileBuilderFactory builderFactory)
        {
            this.unions = unions;
            this.builderFactory = builderFactory;
        }

        public void Execute()
        {
            foreach (var @struct in this.unions)
            {
                this.builderFactory.Generate(@struct.Name, fileBuilder =>
                {
                    fileBuilder.EmitUsing("System");

                    fileBuilder.EmitNamespace("SharpVk", namespaceBuilder =>
                    {
                        namespaceBuilder.EmitType(TypeKind.Struct, @struct.Name, typeBuilder =>
                        {
                        }, Public);
                    });
                });

                this.builderFactory.Generate("Interop\\" + @struct.Name, fileBuilder =>
                  {
                      fileBuilder.EmitUsing("System");

                      fileBuilder.EmitNamespace("SharpVk.Interop", namespaceBuilder =>
                      {
                          namespaceBuilder.EmitType(TypeKind.Struct, @struct.Name, typeBuilder =>
                          {
                          }, Public);
                      });
                  });
            }
        }
    }
}
