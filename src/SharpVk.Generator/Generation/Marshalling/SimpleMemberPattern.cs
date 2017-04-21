using SharpVk.Generator.Collation;
using SharpVk.Generator.Rules;
using System;
using System.Collections.Generic;

using static SharpVk.Emit.ExpressionBuilder;

namespace SharpVk.Generator.Generation.Marshalling
{
    public class SimpleMemberPattern
        : IMemberPatternRule
    {
        private readonly IEnumerable<IMarshalValueRule> marshallingRules;
        private readonly NameLookup nameLookup;

        public SimpleMemberPattern(IEnumerable<IMarshalValueRule> marshallingRules, NameLookup nameLookup)
        {
            this.marshallingRules = marshallingRules;
            this.nameLookup = nameLookup;
        }

        public bool Apply(TypeDeclaration type, MemberDeclaration member, MemberPatternInfo info)
        {
            var marshalling = this.marshallingRules.ApplyFirst(member.Type);

            info.PublicStruct.Properties.Add(new MemberDefinition
            {
                Name = member.Name,
                Type = marshalling.MemberType
            });

            info.InteropStruct.Fields.Add(new MemberDefinition
            {
                Name = member.Name,
                Type = this.nameLookup.Lookup(member.Type, true)
            });

            info.MarshalTo.MemberActions.Add(new Action
            {
                ValueExpression = marshalling.BuildMarshalToValueExpression(Member(This, member.Name)),
                TargetExpression = DerefMember(Variable("pointer"), member.Name),
                MemberType = marshalling.InteropType,
                Type = marshalling.MarshalToActionType
            });

            info.MarshalFrom.MemberActions.Add(new Action
            {
                ValueExpression = marshalling.BuildMarshalFromValueExpression(DerefMember(Variable("pointer"), member.Name)),
                TargetExpression = Member(Variable("result"), member.Name),
                MemberType = marshalling.MemberType,
                Type = marshalling.MarshalFromActionType
            });

            return true;
        }
    }
}
