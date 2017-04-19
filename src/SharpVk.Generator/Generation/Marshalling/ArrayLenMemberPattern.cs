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

        public bool Apply(TypeDeclaration type, MemberDeclaration member, StructDefinition publicStruct, Action<Action> addAction)
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
                            lenExpression.Add(Member(Member(This, otherMember.Name), "Length"));
                        }
                    }
                }
            }

            if (lenExpression.Any())
            {
                addAction(new Action
                {
                    ParamName = "pointer",
                    ParamFieldName = member.Name,
                    ValueExpression = Cast(this.nameLookup.Lookup(member.Type, false), lenExpression.First())
                });
            }

            return lenExpression.Any();
        }
    }
}
