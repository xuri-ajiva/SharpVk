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
        private IEnumerable<DelegateDefinition> delegates;

        public DelegateEmitter(IEnumerable<DelegateDefinition> delegates)
        {
            this.delegates = delegates;
        }

        public void Execute()
        {
            foreach (var @delegate in this.delegates)
            {
                using (var fileBuilder = new FileBuilder("..\\SharpVk", $"{@delegate.Name}.cs"))
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
                }
            }
        }
    }
}
