using SharpVk.Emit;
using SharpVk.Generator.Collation;
using System;
using System.Collections.Generic;
using System.Linq;
using static SharpVk.Emit.ExpressionBuilder;

namespace SharpVk.Generator.Generation.Marshalling
{
    public class ArrayLenMemberPattern
        : IMemberPatternRule
    {
        private readonly ParsedExpressionTokenCheck tokenCheck;
        private readonly NameLookup nameLookup;

        public ArrayLenMemberPattern(ParsedExpressionTokenCheck tokenCheck, NameLookup nameLookup)
        {
            this.tokenCheck = tokenCheck;
            this.nameLookup = nameLookup;
        }

        public bool Apply(TypeDeclaration type, MemberDeclaration member, MemberPatternInfo info)
        {
            var lenExpression = new List<Action<ExpressionBuilder>>();

            foreach (var otherMember in type.Members)
            {
                if (otherMember.Dimensions != null)
                {
                    foreach (var dimension in otherMember.Dimensions)
                    {
                        if (dimension.Type == LenType.Expression && tokenCheck.Check(dimension.Value, member.VkName))
                        {
                            lenExpression.Add(Coalesce(CoalesceMember(Member(This, otherMember.Name), "Length"), Literal(0)));
                        }
                    }
                }
            }

            if (lenExpression.Any())
            {
                info.MarshalTo.MemberActions.Add(new Action
                {
                    TargetExpression = DerefMember(Variable("pointer"), member.Name),
                    ValueExpression = Cast(this.nameLookup.Lookup(member.Type, false), lenExpression.First())
                });

                info.InteropStruct.Fields.Add(new MemberDefinition
                {
                    Name = member.Name,
                    Type = this.nameLookup.Lookup(member.Type, true)
                });
            }

            return lenExpression.Any();
        }
    }
}
