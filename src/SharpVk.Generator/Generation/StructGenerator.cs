using Microsoft.Extensions.DependencyInjection;
using SharpVk.Generator.Collation;
using SharpVk.Generator.Pipeline;
using System.Collections.Generic;
using System.Linq;

namespace SharpVk.Generator.Generation
{
    public class StructGenerator
        : IWorker
    {
        private readonly Dictionary<string, TypeDeclaration> typeData;
        private readonly NameLookup nameLookup;

        public StructGenerator(Dictionary<string, TypeDeclaration> typeData, NameLookup nameLookup)
        {
            this.typeData = typeData;
            this.nameLookup = nameLookup;
        }

        public void Execute(IServiceCollection services)
        {
            foreach (var type in this.typeData.Values.Where(x => x.Pattern == TypePattern.NonMarshalledStruct))
            {
                services.AddSingleton(new StructDefinition
                {
                    Name = type.Name,
                    Members = type.Members.Select(x => new MemberDefinition
                    {
                        Name = NameLookup.Normalise(x.Name),
                        Type = this.nameLookup.Lookup(x.Type, false)
                    }).ToList()
                });
            }
        }
    }
}
