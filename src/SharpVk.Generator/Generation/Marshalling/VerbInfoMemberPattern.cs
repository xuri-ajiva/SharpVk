using Microsoft.Extensions.DependencyInjection;
using SharpVk.Generator.Collation;
using SharpVk.Generator.Rules;
using System;
using System.Collections.Generic;
using System.Linq;
using static SharpVk.Emit.ExpressionBuilder;

namespace SharpVk.Generator.Generation.Marshalling
{
    public class VerbInfoMemberPattern
        : IMemberPatternRule
    {
        private readonly Dictionary<string, TypeDeclaration> typeData;
        private readonly NameLookup nameLookup;
        private readonly NamespaceMap namespaceMap;
        private readonly IServiceProvider provider;

        private IEnumerable<IMemberPatternRule> patternRules;

        public VerbInfoMemberPattern(Dictionary<string, TypeDeclaration> typeData, NameLookup nameLookup, NamespaceMap namespaceMap, IServiceProvider provider)
        {
            this.typeData = typeData;
            this.nameLookup = nameLookup;
            this.namespaceMap = namespaceMap;
            this.provider = provider;
        }

        public bool Apply(IEnumerable<ITypedDeclaration> others, ITypedDeclaration source, MemberPatternContext context, MemberPatternInfo info)
        {
            if (this.patternRules == null)
            {
                this.patternRules = this.provider.GetServices<IMemberPatternRule>();
            }

            string verbInfoPattern = context.MethodVerb + "info";

            if (context.Extension != null)
            {
                verbInfoPattern += context.Extension;
            }

            verbInfoPattern = verbInfoPattern.ToLower();

            if (context.MethodVerb != null && source.Dimensions == null && source.Type.VkName.ToLower().EndsWith(verbInfoPattern))
            {
                var infoTypeData = this.typeData[source.Type.VkName];
                var interopType = this.nameLookup.Lookup(source.Type, true);
                var interopBaseType = this.nameLookup.Lookup(source.Type, true, false);

                bool isPointer = source.Type.PointerType.IsPointer();

                info.Interop = new TypedDefinition
                {
                    Name = source.Name.FirstToLower(),
                    Type = interopType
                };

                info.InteropFullType = interopType;

                info.MarshalTo.Add((getTarget, getValue) => new AssignAction
                {
                    ValueExpression = New(interopBaseType),
                    TargetExpression = getTarget(source.Name),
                    MemberType = interopBaseType,
                    Type = isPointer ? AssignActionType.Alloc : AssignActionType.Assign
                });

                foreach (var member in infoTypeData.Members)
                {
                    var subPatternInfo = new MemberPatternInfo();

                    this.patternRules.ApplyFirst(infoTypeData.Members, member, new MemberPatternContext(null, true, infoTypeData.Extension, context.GetHandle, source.Type.VkName), subPatternInfo);

                    foreach (var subAction in subPatternInfo.MarshalTo)
                    {
                        info.MarshalTo.Add((getTarget, getValue) =>
                        {
                            return subAction(target => DerefMember(getTarget(source.Name), target), value => getValue(value.FirstToLower()));
                        });
                    }

                    foreach (var lookup in subPatternInfo.HandleLookup)
                    {
                        info.HandleLookup.Add((lookup.Item1, x => lookup.Item2(value => x(value.FirstToLower()))));
                    }

                    info.Public.AddRange(subPatternInfo.Public.Select(x =>
                        new TypedDefinition
                        {
                            Name = x.Name.FirstToLower(),
                            Comment = x.Comment,
                            Type = x.Type,
                            DefaultValue = x.DefaultValue
                        }));
                }

                foreach (var extendStruct in infoTypeData.ExtendTypes)
                {
                    var extendType = this.typeData[extendStruct];

                    string typeNamespace = "";

                    if (extendType.Extension != null)
                    {
                        typeNamespace += "." + string.Join(".", this.namespaceMap.Map(extendType.Extension));
                    }

                    string paramName = extendType.Name.FirstToLower() + extendType.Extension;

                    info.Public.Add(new TypedDefinition
                    {
                        Name = paramName,
                        Type = $"SharpVk{typeNamespace}.{extendType.Name}?",
                        DefaultValue = Null
                    });


                    info.MarshalTo.Add((getTarget, getValue) =>
                    {
                        var extendMarshalAction = new OptionalAction
                        {
                            CheckExpression = IsNotEqual(Variable(paramName), Null),
                            Priority = -1
                        };

                        extendMarshalAction.Actions.AddRange(new MethodAction[]
                        {
                            new DeclarationAction
                            {
                                MemberType = $"SharpVk.Interop{typeNamespace}.{extendType.Name}*",
                                MemberName = "extensionPointer"
                            },
                            new AssignAction
                            {
                                TargetExpression = Variable("extensionPointer"),
                                ValueExpression = Member(Variable(paramName), "Value"),
                                MemberType = $"SharpVk.Interop{typeNamespace}.{extendType.Name}",
                                Type = AssignActionType.MarshalTo
                            },
                            new AssignAction
                            {
                                TargetExpression = DerefMember(Variable("extensionPointer"), "Next"),
                                ValueExpression = Variable("nextPointer")
                            },
                            new AssignAction
                            {
                                ValueExpression = Variable("extensionPointer"),
                                TargetExpression = Variable("nextPointer")
                            }
                        });

                        return extendMarshalAction;
                    });
                }

                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
