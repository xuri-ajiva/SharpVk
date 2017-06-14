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
        private readonly NamespaceMap namespaceMap;

        public EnumGenerator(IEnumerable<EnumDeclaration> enums, NamespaceMap namespaceMap)
        {
            this.enums = enums;
            this.namespaceMap = namespaceMap;
        }

        public void Execute(IServiceCollection services)
        {
            foreach (var enumeration in this.enums)
            {
                services.AddSingleton(new EnumDefinition
                {
                    Name = enumeration.Name,
                    Namespace = enumeration.Extension != null ? this.namespaceMap.Map(enumeration.Extension).ToArray() : null,
                    IsFlags = enumeration.IsFlags,
                    Fields = enumeration.Fields.Select(x => new FieldDefinition
                    {
                        Name = x.Name,
                        Value = x.Value
                    }).ToList()
                });
            }
        }
    }
}
