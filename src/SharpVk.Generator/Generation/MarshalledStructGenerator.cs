using Microsoft.Extensions.DependencyInjection;
using SharpVk.Generator.Collation;
using SharpVk.Generator.Pipeline;
using System.Collections.Generic;
using System.Linq;
using System;

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
                var typeNamespace = new List<string>();

                if (type.Extension != null)
                {
                    typeNamespace.Add(type.Extension);
                }

                var publicStruct = new StructDefinition
                {
                    Name = type.Name,
                    Namespace = typeNamespace.ToArray(),
                    Properties = new List<MemberDefinition>()
                };

                foreach (var member in type.Members)
                {
                    if (member.FixedValue != null)
                    {

                    }
                    else
                    {
                        publicStruct.Properties.Add(GetPublicMember(member));
                    }
                }

                typeNamespace.Insert(0, "Interop");

                services.AddSingleton(publicStruct);

                services.AddSingleton(new StructDefinition
                {
                    Name = type.Name,
                    Namespace = typeNamespace.ToArray(),
                    IsUnsafe = true,
                    Fields = type.Members.Select(this.GetInteropMember).ToList()
                });
            }
        }

        private MemberDefinition GetPublicMember(MemberDeclaration member)
        {
            return new MemberDefinition
            {
                Name = member.Name,
                Type = this.nameLookup.Lookup(member.Type, false)
            };
        }

        private MemberDefinition GetInteropMember(MemberDeclaration member)
        {
            return new MemberDefinition
            {
                Name = member.Name,
                Type = this.nameLookup.Lookup(member.Type, true)
            };
        }
    }
}
