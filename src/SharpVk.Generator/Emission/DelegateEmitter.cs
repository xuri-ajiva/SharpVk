using SharpVk.Emit;
using SharpVk.Generator.Generation;
using SharpVk.Generator.Pipeline;
using System.Collections.Generic;
using static SharpVk.Emit.AccessModifier;
using static SharpVk.Emit.TypeModifier;

namespace SharpVk.Generator.Emission
{
    public class DelegateEmitter
        : IOutputWorker
    {
        private readonly IEnumerable<DelegateDefinition> delegates;
        private readonly FileBuilderFactory builderFactory;

        public DelegateEmitter(IEnumerable<DelegateDefinition> delegates, FileBuilderFactory builderFactory)
        {
            this.delegates = delegates;
            this.builderFactory = builderFactory;
        }

        public void Execute()
        {
            foreach (var @delegate in this.delegates)
            {
                this.builderFactory.Generate(@delegate.Name, fileBuilder =>
                {
                    fileBuilder.EmitUsing("System");

                    fileBuilder.EmitNamespace("SharpVk", namespaceBuilder =>
                    {
                        namespaceBuilder.EmitDelegate(@delegate.ReturnType,
                                                        @delegate.Name,
                                                        Public,
                                                        None,
                                                        parameters =>
                                                        {
                                                            //foreach (var param in @delegate.Parameters)
                                                            //{
                                                            //    parameters.EmitParam(param.TypeName, param.Name);
                                                            //}
                                                        },
                                                        @delegate.Comment);
                    });
                });
            }
        }
    }
}
