using Microsoft.Extensions.DependencyInjection;
using SharpVk.Generator.Pipeline;
using SharpVk.Generator.Specification.Elements;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SharpVk.Generator.Collation
{
    public class EnumCollator
        : IWorker
    {
        private readonly Dictionary<string, EnumElement> enums;
        private readonly Dictionary<string, TypeElement> types;
        private readonly NameFormatter nameFormatter;
        private readonly IEnumerable<string> enumTypes;
        private readonly IEnumerable<TypeElement> bitmaskTypes;

        public EnumCollator(IEnumerable<EnumElement> enums, IEnumerable<TypeElement> types, NameFormatter nameFormatter)
        {
            this.enums = enums.ToDictionary(x => x.VkName);
            this.types = types.ToDictionary(x => x.VkName);

            this.nameFormatter = nameFormatter;

            var enumTypes = this.enums.Select(x => x.Key).ToList();

            var bitmaskTypes = new List<TypeElement>();

            foreach (var bitmaskType in types.Where(x => x.Category == TypeCategory.bitmask))
            {
                if (bitmaskType.Requires != null)
                {
                    bitmaskTypes.Add((bitmaskType));

                    enumTypes.Remove(bitmaskType.Requires);
                }
            }

            enumTypes.Remove("API Constants");

            this.enumTypes = enumTypes;
            this.bitmaskTypes = bitmaskTypes;
        }

        public void Execute(IServiceCollection services)
        {
            foreach (var enumType in this.enumTypes)
            {
                var enumeration = this.enums[enumType];

                services.AddSingleton(new EnumDeclaration
                {
                    VkName = enumeration.VkName,
                    Name = this.nameFormatter.FormatName(enumeration)
                });
            }

            foreach (var bitmaskType in this.bitmaskTypes)
            {
                var enumeration = this.enums[bitmaskType.Requires];

                services.AddSingleton(new EnumDeclaration
                {
                    VkName = bitmaskType.VkName,
                    Name = this.nameFormatter.FormatName(bitmaskType),
                    BitmaskAlias = enumeration.VkName
                });
            }
        }
    }
}
