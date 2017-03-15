using Microsoft.Extensions.DependencyInjection;
using SharpVk.Generator.Pipeline;
using System;

namespace SharpVk.Generator.Generation
{
    public class GenerationStage
        : IStage
    {
        private PInvokeGenerator pInvokeGenerator;

        public GenerationStage(IServiceProvider provider)
        {
            this.pInvokeGenerator = provider.CreateInstance<PInvokeGenerator>();
        }

        public void Configure(IServiceCollection services)
        {
            this.pInvokeGenerator.GenerateTo(services);
        }
    }
}
