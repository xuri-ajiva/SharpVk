using Microsoft.Extensions.DependencyInjection;
using SharpVk.Generator.Pipeline;

namespace SharpVk.Generator.Emission
{
    public class EmissionStage
        : IStage
    {
        public void Configure(IServiceCollection services)
        {
            services.AddSingleton<FileBuilderFactory>();
            services.AddSingleton<MethodEmitter>();

            services.AddSingleton<IOutputWorker, PInvokeEmitter>();
            services.AddSingleton<IOutputWorker, HandleEmitter>();
            services.AddSingleton<IOutputWorker, StructEmitter>();
            services.AddSingleton<IOutputWorker, EnumEmitter>();
            services.AddSingleton<IOutputWorker, UnionEmitter>();
            services.AddSingleton<IOutputWorker, DelegateEmitter>();
            services.AddSingleton<IOutputWorker, ConstantEmitter>();
        }
    }
}
