using Microsoft.Extensions.DependencyInjection;
using SharpVk.Generator.Pipeline;
using System;

namespace SharpVk.Generator.Generation
{
    public class GenerationStage
        : IStage
    {
        private PInvokeGenerator pInvokeGenerator;
        private StructGenerator structGenerator;
        private EnumGenerator enumGenerator;

        public GenerationStage(IServiceProvider provider)
        {
            this.pInvokeGenerator = provider.CreateInstance<PInvokeGenerator>();
            this.structGenerator = provider.CreateInstance<StructGenerator>();
            this.enumGenerator = provider.CreateInstance<EnumGenerator>();
        }

        public void Configure(IServiceCollection services)
        {
            this.pInvokeGenerator.GenerateTo(services);
            this.structGenerator.GenerateTo(services);
            this.enumGenerator.GenerateTo(services);
        }
    }
}
