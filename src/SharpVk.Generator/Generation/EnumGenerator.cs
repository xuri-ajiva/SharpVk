using Microsoft.Extensions.DependencyInjection;
using SharpVk.Generator.Collation;
using SharpVk.Generator.Pipeline;
using System.Collections.Generic;

using System.Linq;

namespace SharpVk.Generator.Generation
{
    public class EnumGenerator
        : IWorker
    {
        private readonly IEnumerable<EnumDeclaration> enums;

        public EnumGenerator(IEnumerable<EnumDeclaration> enums)
        {
            this.enums = enums;
        }

        public void Execute(IServiceCollection services)
        {
            foreach (var enumeration in this.enums)
            {
                services.AddSingleton(new EnumDefinition
                {
                    Name = enumeration.Name
                });

                services.AddSingleton(TypeNameMapping.FromEnumDeclaration(enumeration));

                if (enumeration.BitmaskAlias != null)
                {
                    services.AddSingleton(new TypeNameMapping
                    {
                        VkName = enumeration.BitmaskAlias,
                        OutputName = enumeration.Name
                    });
                }
            }
        }
    }
}
