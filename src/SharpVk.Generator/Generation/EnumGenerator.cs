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
        private readonly Dictionary<string, TypeDeclaration> typeData;

        public EnumGenerator(IEnumerable<EnumDeclaration> enums, Dictionary<string, TypeDeclaration> typeData)
        {
            this.enums = enums;
            this.typeData = typeData;
        }

        public void Execute(IServiceCollection services)
        {
            foreach (var enumeration in this.enums)
            {
                services.AddSingleton(new EnumDefinition
                {
                    Name = enumeration.Name,
                    Namespace = enumeration.Extension != null ? new[] { enumeration.Extension } : null,
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
