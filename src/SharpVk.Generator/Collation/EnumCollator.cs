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
                bitmaskTypes.Add((bitmaskType));

                if (bitmaskType.Requires != null)
                {
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

                string name = this.nameFormatter.FormatName(enumeration);

                services.AddSingleton(new EnumDeclaration
                {
                    Name = name,
                    Fields = this.DeclareFields(enumeration, false)
                });

                services.AddSingleton(new TypeNameMapping
                {
                    VkName = enumeration.VkName,
                    OutputName = name
                });
            }

            foreach (var bitmaskType in this.bitmaskTypes)
            {
                var enumeration = bitmaskType.Requires != null
                                        ? this.enums[bitmaskType.Requires]
                                        : null;

                string name = this.nameFormatter.FormatName(bitmaskType);

                services.AddSingleton(new EnumDeclaration
                {
                    Name = name,
                    Fields = this.DeclareFields(enumeration, true)
                });

                if (enumeration != null)
                {
                    services.AddSingleton(new TypeNameMapping
                    {
                        VkName = enumeration.VkName,
                        OutputName = name,
                        Priority = 1
                    });
                }

                services.AddSingleton(new TypeNameMapping
                {
                    VkName = bitmaskType.VkName,
                    OutputName = name,
                    Priority = 1
                });
            }
        }

        private List<FieldDeclaration> DeclareFields(EnumElement enumeration, bool isBitmask)
        {
            var result = new List<FieldDeclaration>();

            if (enumeration != null)
            {
                if (isBitmask && !enumeration.Fields.Values.Any(x => x.Value == "0" && !x.IsBitmask))
                {
                    AddNoneField(result);
                }

                foreach (var field in enumeration.Fields.Values)
                {
                    string value = field.Value;

                    if (field.IsBitmask)
                    {
                        value = $"1 << {value}";
                    }

                    result.Add(new FieldDeclaration
                    {
                        Name = this.nameFormatter.FormatName(enumeration, field, field.IsBitmask),
                        Value = value
                    });
                }
            }
            else
            {
                AddNoneField(result);
            }

            return result;
        }

        private static void AddNoneField(List<FieldDeclaration> result)
        {
            result.Add(new FieldDeclaration
            {
                Name = "None",
                Value = "0"
            });
        }
    }
}
