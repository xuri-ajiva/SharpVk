using Microsoft.Extensions.DependencyInjection;
using SharpVk.Generator.Pipeline;
using SharpVk.Generator.Specification.Rules;

namespace SharpVk.Generator.Specification
{
    public class SpecParserSetup
        : IStage
    {
        public void Configure(IServiceCollection services)
        {
            services.AddSingleton<ExtensionSet>();
            services.AddSingleton<NameParser>();
            services.AddSingleton<ITypeExtensionRule, FunctionPointerTypeRule>();
            services.AddSingleton<ITypeExtensionRule, MemberTypeRule>();
            services.AddSingleton<TypeElementReader>();
            services.AddSingleton<EnumElementReader>();
            services.AddSingleton<CommandElementReader>();
        }
    }
}
