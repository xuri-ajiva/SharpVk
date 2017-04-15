using Microsoft.Extensions.DependencyInjection;
using SharpVk.Generator.Collation;
using SharpVk.Generator.Pipeline;
using System.Collections.Generic;
using System.Linq;

using static SharpVk.Emit.ExpressionBuilder;

namespace SharpVk.Generator.Generation
{
    public class MarshalledStructGenerator
        : IWorker
    {
        private readonly Dictionary<string, TypeDeclaration> typeData;
        private readonly NameLookup nameLookup;
        private readonly Dictionary<string, EnumMapping> enumLookup;

        public MarshalledStructGenerator(Dictionary<string, TypeDeclaration> typeData, NameLookup nameLookup, Dictionary<string, EnumMapping> enumLookup)
        {
            this.typeData = typeData;
            this.nameLookup = nameLookup;
            this.enumLookup = enumLookup;
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
                    MemberActions = new List<MemberActionDefinition>()
                };

                publicStruct.Methods.Add(marshalToMethod);

                foreach (var member in type.Members)
                {
                    var memberTypeName = this.nameLookup.Lookup(member.Type, false);
                    var memberTypePattern = this.typeData[member.Type.VkName].Pattern;

                    if (member.FixedValue != null)
                    {
                        if (this.enumLookup.ContainsKey(member.FixedValue))
                        {
                            var enumInfo = this.enumLookup[member.FixedValue];
                            var enumTypeName = this.nameLookup.Lookup(enumInfo.TypeVkName);

                            marshalToMethod.MemberActions.Add(new MemberActionDefinition
                            {
                                ValueExpression = EnumField(enumTypeName, enumInfo.FieldName),
                                ParamName = "pointer",
                                ParamFieldName = member.Name
                            });
                        }
                    }
                    else if (member.Name == "Next")
                    {
                        marshalToMethod.MemberActions.Add(new MemberActionDefinition
                        {
                            ValueExpression = Null,
                            ParamName = "pointer",
                            ParamFieldName = member.Name
                        });
                    }
                    else if (member.Name.EndsWith("Version") && memberTypeName == "uint")
                    {
                        publicStruct.Properties.Add(new MemberDefinition
                        {
                            Name = member.Name,
                            Type = "Version"
                        });
                    }
                    else if (member.Type.VkName == "void" && member.Type.PointerType.IsPointer())
                    {
                        publicStruct.Properties.Add(new MemberDefinition
                        {
                            Name = member.Name,
                            Type = "IntPtr"
                        });

                        marshalToMethod.MemberActions.Add(new MemberActionDefinition
                        {
                            ValueExpression = Call(Member(This, member.Name), "ToPointer"),
                            ParamName = "pointer",
                            ParamFieldName = member.Name
                        });
                    }
                    else if (member.Dimensions != null)
                    {

                    }
                    else if (memberTypePattern == TypePattern.Delegate)
                    {
                        publicStruct.Properties.Add(GetPublicMember(member));

                        marshalToMethod.MemberActions.Add(new MemberActionDefinition
                        {
                            ValueExpression = StaticCall("System.Runtime.InteropServices.Marshal", "GetFunctionPointerForDelegate", Member(This, member.Name)),
                            ParamName = "pointer",
                            ParamFieldName = member.Name
                        });
                    }
                    else if (memberTypePattern == TypePattern.Handle)
                    {
                        publicStruct.Properties.Add(GetPublicMember(member));

                        marshalToMethod.MemberActions.Add(new MemberActionDefinition
                        {
                            ValueExpression = Member(Member(This, member.Name), "handle"),
                            ParamName = "pointer",
                            ParamFieldName = member.Name
                        });
                    }
                    else if (memberTypePattern == TypePattern.MarshalledStruct)
                    {
                        publicStruct.Properties.Add(GetPublicMember(member));

                        bool shouldAddressOf = !member.Type.PointerType.IsPointer();

                        marshalToMethod.MemberActions.Add(new MemberActionDefinition
                        {
                            ValueExpression = Member(This, member.Name),
                            ParamName = "pointer",
                            ParamFieldName = member.Name,
                            AddressOfParamField = shouldAddressOf,
                            Type = MemberActionType.MarshalTo
                        });
                    }
                    else if (member.Type.PointerType.IsPointer())
                    {
                        publicStruct.Properties.Add(GetPublicMember(member));

                        marshalToMethod.MemberActions.Add(new MemberActionDefinition
                        {
                            ValueExpression = Member(This, member.Name),
                            ParamName = "pointer",
                            ParamFieldName = member.Name,
                            MemberType = memberTypeName,
                            Type = MemberActionType.AllocAndAssign
                        });
                    }
                    else
                    {
                        publicStruct.Properties.Add(GetPublicMember(member));

                        marshalToMethod.MemberActions.Add(new MemberActionDefinition
                        {
                            ValueExpression = Member(This, member.Name),
                            ParamName = "pointer",
                            ParamFieldName = member.Name
                        });
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
