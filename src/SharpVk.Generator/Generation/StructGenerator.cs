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

        public StructGenerator(Dictionary<string, TypeDeclaration> typeData)
        {
            this.typeData = typeData;
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
                        Name = x.Name,
                        Type = x.Type
                    }).ToList()
                });

                services.AddSingleton(TypeNameMapping.FromTypeDeclaration(type));
            }
        }
    }
}
