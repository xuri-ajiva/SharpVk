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
            var lenExpression = new List<Func<Func<string, Action<ExpressionBuilder>>, Action<ExpressionBuilder>>>();

            foreach (var otherMember in others)
            {
                if (otherMember.Dimensions != null)
                {
                    foreach (var dimension in otherMember.Dimensions)
                    {
                        if (dimension.Type == LenType.Expression && tokenCheck.Check(dimension.Value, source.VkName))
                        {
                            if (dimension.Value is LenExpressionToken)
                            {
                                lenExpression.Add(getValue => Coalesce(CoalesceMember(getValue(otherMember.Name), "Length"), Literal(0)));
                            }
                        }
                    }
                }
            }

            if (lenExpression.Any())
            {
                info.MarshalTo.Add((getTarget, getValue) => new AssignAction
                {
                    TargetExpression = getTarget(source.Name),
                    ValueExpression = Cast(this.nameLookup.Lookup(source.Type, false), lenExpression.First()(getValue))
                });

                string typeName = this.nameLookup.Lookup(source.Type, true);

                info.Interop = new TypedDefinition
                {
                    Name = source.Name,
                    Type = typeName
                };

                info.InteropFullType = typeName;
            }

            return lenExpression.Any();
        }
    }
}
