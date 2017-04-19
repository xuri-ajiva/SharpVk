using Microsoft.Extensions.DependencyInjection;
using SharpVk.Generator.Collation;
using SharpVk.Generator.Generation.Marshalling;
using SharpVk.Generator.Pipeline;
using System.Collections.Generic;
using System.Linq;
using SharpVk.Generator.Rules;

namespace SharpVk.Generator.Generation
{
    public class MarshalledStructGenerator
        : IWorker
    {
        private readonly Dictionary<string, TypeDeclaration> typeData;
        private readonly NameLookup nameLookup;
        private readonly IEnumerable<IMemberPatternRule> patternRules;

        public MarshalledStructGenerator(Dictionary<string, TypeDeclaration> typeData, NameLookup nameLookup, IEnumerable<IMemberPatternRule> patternRules)
        {
            this.typeData = typeData;
            this.nameLookup = nameLookup;
            this.patternRules = patternRules;
        }

        public void Execute(IServiceCollection services)
        {
            foreach (var typeItem in this.typeData.Where(x => x.Value.Pattern == TypePattern.MarshalledStruct))
            {
                var type = typeItem.Value;
                var typeNamespace = new List<string>();

                if (type.Extension != null)
                {
                    typeNamespace.Add(type.Extension);
                }

                var publicStruct = new StructDefinition
                {
                    Name = type.Name,
                    Namespace = typeNamespace.ToArray(),
                    Methods = new List<MethodDefinition>(),
                    Properties = new List<MemberDefinition>()
                };

                var marshalToMethod = new MethodDefinition
                {
                    Name = "MarshalTo",
                    IsUnsafe = true,
                    ParamActions = new List<ParamActionDefinition>
                    {
                        new ParamActionDefinition
                        {
                            Param = new ParamDefinition
                            {
                                Name = "pointer",
                                Type = "Interop." + this.nameLookup.Lookup(new TypeReference
                                {
                                    VkName = typeItem.Key,
                                    PointerType = PointerType.Pointer
                                }, true)
                            }
                        }
                    },
                    MemberActions = new List<Action>()
                };

                publicStruct.Methods.Add(marshalToMethod);

                foreach (var member in type.Members)
                {
                    this.patternRules.ApplyFirst(type, member, publicStruct, marshalToMethod.MemberActions.Add);
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
