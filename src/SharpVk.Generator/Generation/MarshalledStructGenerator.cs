using Microsoft.Extensions.DependencyInjection;
using SharpVk.Generator.Collation;
using SharpVk.Generator.Pipeline;
using System.Collections.Generic;
using System.Linq;

namespace SharpVk.Generator.Generation
{
    public class MarshalledStructGenerator
        : IWorker
    {
        private readonly Dictionary<string, TypeDeclaration> typeData;
        private readonly NameLookup nameLookup;

        public MarshalledStructGenerator(Dictionary<string, TypeDeclaration> typeData, NameLookup nameLookup)
        {
            this.typeData = typeData;
            this.nameLookup = nameLookup;
        }

        public void Execute(IServiceCollection services)
        {
            foreach (var type in this.typeData.Values.Where(x => x.Pattern == TypePattern.MarshalledStruct))
            {
                services.AddSingleton(new StructDefinition
                {
                    Name = type.Name,
                    IsInterop = true,
                    Members = type.Members.Select(x => GetInteropMember(x)).ToList()
                });
            }
        }

        private MemberDefinition GetInteropMember(MemberDeclaration member)
        {
            return new MemberDefinition
            {
                Name = NameLookup.Normalise(member.Name),
                Type = this.nameLookup.Lookup(member.Type, true)
            };
        }
    }
}
