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
        private readonly IServiceProvider provider;

        private IEnumerable<IMemberPatternRule> patternRules;

        public VerbInfoMemberPattern(Dictionary<string, TypeDeclaration> typeData, NameLookup nameLookup, IServiceProvider provider)
        {
            this.typeData = typeData;
            this.nameLookup = nameLookup;
            this.provider = provider;
        }

        public bool Apply(IEnumerable<ITypedDeclaration> others, ITypedDeclaration source, MemberPatternContext context, MemberPatternInfo info)
        {
            if (this.patternRules == null)
            {
                this.patternRules = this.provider.GetServices<IMemberPatternRule>();
            }

            if (context.MethodVerb != null && source.Dimensions == null && source.Type.VkName.ToLower().EndsWith(context.MethodVerb + "info"))
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

                    this.patternRules.ApplyFirst(infoTypeData.Members, member, new MemberPatternContext(null, context.GetHandle), subPatternInfo);

                    foreach(var subAction in subPatternInfo.MarshalTo)
                    {
                        info.MarshalTo.Add((getTarget, getValue) =>
                        {
                            return subAction(target => DerefMember(getTarget(source.Name), target), value => getValue(value.FirstToLower()));
                        });
                    }

                    foreach(var lookup in subPatternInfo.HandleLookup)
                    {
                        info.HandleLookup.Add((lookup.Item1, x => lookup.Item2(value => x(value.FirstToLower()))));
                    }

                    info.Public.AddRange(subPatternInfo.Public.Select(x=>
                        new TypedDefinition
                        {
                            Name = x.Name.FirstToLower(),
                            Type = x.Type,
                            DefaultValue = x.DefaultValue
                        }));
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
