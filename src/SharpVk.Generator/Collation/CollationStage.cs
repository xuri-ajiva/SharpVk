using Microsoft.Extensions.DependencyInjection;
using SharpVk.Generator.Pipeline;
using System;

namespace SharpVk.Generator.Collation
{
    public class CollationStage
        : IStage
    {
        private TypeCollator typeCollator;
        private CommandCollator commandCollator;

        public CollationStage(IServiceProvider provider)
        {
            this.typeCollator = provider.CreateInstance<TypeCollator>();
            this.commandCollator = provider.CreateInstance<CommandCollator>();
        }

        public void Configure(IServiceCollection services)
        {
            this.typeCollator.CollateTo(services);
            this.commandCollator.CollateTo(services);
        }
    }
}
