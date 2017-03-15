using Microsoft.Extensions.DependencyInjection;
using SharpVk.Generator.Pipeline;

namespace SharpVk.Generator.Collation
{
    public class CollationSetup
        : IStage
    {
        public void Configure(IServiceCollection services)
        {
            services.AddSingleton<NameFormatter>();
        }
    }
}
