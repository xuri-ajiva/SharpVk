using Microsoft.Extensions.DependencyInjection;
using SharpVk.Generator.Pipeline;

namespace SharpVk.Generator.Specification
{
    public class SpecParseStage
        : IStage
    {
        private readonly TypeElementReader typeReader;
        private readonly EnumElementReader enumReader;
        private readonly CommandElementReader commandReader;

        public SpecParseStage(TypeElementReader typeReader, EnumElementReader enumReader, CommandElementReader commandReader)
        {
            this.typeReader = typeReader;
            this.enumReader = enumReader;
            this.commandReader = commandReader;
        }

        public void Configure(IServiceCollection services)
        {
            this.typeReader.ReadTo(services);
            this.enumReader.ReadTo(services);
            this.commandReader.ReadTo(services);
        }
    }
}
