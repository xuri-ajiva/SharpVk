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

        public bool Apply(TypeDeclaration type, MemberDeclaration member, StructDefinition publicStruct, Action<Action> addAction)
        {
            var marshalling = this.marshallingRules.ApplyFirst(member.Type);

            publicStruct.Properties.Add(new MemberDefinition
            {
                Name = member.Name,
                Type = marshalling.MemberType
            });

            addAction(new Action
            {
                ValueExpression = marshalling.BuildValueExpression(Member(This, member.Name)),
                ParamName = "pointer",
                ParamFieldName = member.Name,
                MemberType = this.nameLookup.Lookup(member.Type, false),
                Type = marshalling.ActionType
            });

            return true;
        }
    }
}
