using Microsoft.Extensions.DependencyInjection;
using SharpVk.Generator.Pipeline;

namespace SharpVk.Generator.Generation
{
    public class GenerationStage
        : IStage
    {
        public void Configure(IServiceCollection services)
        {
            services.AddSingleton<IWorker, PInvokeGenerator>();
            services.AddSingleton<IWorker, StructGenerator>();
            services.AddSingleton<IWorker, EnumGenerator>();
            services.AddSingleton<IWorker, PrimitiveGenerator>();
            services.AddSingleton<IWorker, UnionGenerator>();
            services.AddSingleton<IWorker, DelegateGenerator>();
        }
    }
}
