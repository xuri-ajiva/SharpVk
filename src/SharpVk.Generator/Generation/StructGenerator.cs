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
                    Constructor = new MethodDefinition
                    {
                        Params = type.Members.Select(this.GetConstructorParam).ToList()
                    },
                    Members = type.Members.Select(x => new MemberDefinition
                    {
                        Name = x.Name,
                        Type = this.nameLookup.Lookup(x.Type, false)
                    }).ToList()
                });
            }
        }

        private ParamActionDefinition GetConstructorParam(MemberDeclaration member)
        {
            return new ParamActionDefinition
            {
                MemberName = member.Name,
                Param = new ParamDefinition
                {
                    Name = member.ParamName,
                    Type = this.nameLookup.Lookup(member.Type, true)
                }
            };
        }
    }
}
