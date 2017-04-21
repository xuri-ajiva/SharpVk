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
                ValueExpression = marshalling.BuildValueExpression(Member(This, member.Name)),
                ParamName = "pointer",
                ParamFieldName = member.Name,
                MemberType = marshalling.InteropType,
                Type = marshalling.ActionType
            });

            return true;
        }
    }
}
