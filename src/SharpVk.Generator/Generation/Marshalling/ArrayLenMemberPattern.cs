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

        public bool Apply(IEnumerable<ITypedDeclaration> others, ITypedDeclaration source, MemberPatternInfo info)
        {
            var lenExpression = new List<Action<ExpressionBuilder>>();

            foreach (var otherMember in others)
            {
                if (otherMember.Dimensions != null)
                {
                    foreach (var dimension in otherMember.Dimensions)
                    {
                        if (dimension.Type == LenType.Expression && tokenCheck.Check(dimension.Value, source.VkName))
                        {
                            lenExpression.Add(Coalesce(CoalesceMember(Member(This, otherMember.Name), "Length"), Literal(0)));
                        }
                    }
                }
            }

            if (lenExpression.Any())
            {
                info.MarshalTo.Add(new Action
                {
                    TargetExpression = DerefMember(Variable("pointer"), source.Name),
                    ValueExpression = Cast(this.nameLookup.Lookup(source.Type, false), lenExpression.First())
                });

                info.Interop = new TypedDefinition
                {
                    Name = source.Name,
                    Type = this.nameLookup.Lookup(source.Type, true)
                };
            }

            return lenExpression.Any();
        }
    }
}
