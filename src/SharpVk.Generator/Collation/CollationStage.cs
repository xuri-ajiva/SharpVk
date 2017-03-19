using Microsoft.Extensions.DependencyInjection;
using SharpVk.Generator.Pipeline;

namespace SharpVk.Generator.Collation
{
    public class CollationStage
        : IStage
    {
        public void Configure(IServiceCollection services)
        {
            services.AddSingleton<NameFormatter>();
            services.AddSingleton<IWorker, TypeCollator>();
            services.AddSingleton<IWorker, CommandCollator>();
        }
    }
}
