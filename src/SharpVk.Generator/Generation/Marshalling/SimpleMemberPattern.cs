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

        public bool Apply(IEnumerable<ITypedDeclaration> others, ITypedDeclaration source, MemberPatternInfo info)
        {
            var marshalling = this.marshallingRules.ApplyFirst(source.Type);

            info.Public = new TypedDefinition
            {
                Name = source.Name,
                Type = marshalling.MemberType
            };

            string typeName = this.nameLookup.Lookup(source.Type, true);

            info.Interop = new TypedDefinition
            {
                Name = source.Name,
                Type = typeName
            };

            info.InteropFullType = marshalling.InteropType;

            if(source.Type.PointerType.IsPointer())
            {
                info.InteropFullType += "*";
            }

            info.MarshalTo.Add((getTarget, getValue) => new AssignAction
            {
                ValueExpression = marshalling.BuildMarshalToValueExpression(getValue(source.Name)),
                TargetExpression = getTarget(source.Name),
                MemberType = marshalling.InteropType,
                Type = marshalling.MarshalToActionType
            });

            info.MarshalFrom.Add(new AssignAction
            {
                ValueExpression = marshalling.BuildMarshalFromValueExpression(DerefMember(Variable("pointer"), source.Name)),
                TargetExpression = Member(Variable("result"), source.Name),
                MemberType = marshalling.MemberType,
                Type = marshalling.MarshalFromActionType
            });

            return true;
        }
    }
}
