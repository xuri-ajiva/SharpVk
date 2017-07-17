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
        private readonly CommentGenerator commentGenerator;

        public ArrayLenMemberPattern(ParsedExpressionTokenCheck tokenCheck, NameLookup nameLookup, CommentGenerator commentGenerator)
        {
            this.tokenCheck = tokenCheck;
            this.nameLookup = nameLookup;
            this.commentGenerator = commentGenerator;
        }

        public bool Apply(IEnumerable<ITypedDeclaration> others, ITypedDeclaration source, MemberPatternContext context, MemberPatternInfo info)
        {
            var lenExpressions = new List<(Func<Func<string, Action<ExpressionBuilder>>, Action<ExpressionBuilder>>, bool, bool)>();

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
                                lenExpressions.Add((getValue => StaticCall("Interop.HeapUtil", "GetLength", getValue(otherMember.Name)), otherMember.NoAutoValidity, otherMember.IsOptional));
                            }
                        }
                    }
                }
                else if (otherMember.Type.FixedLength.Type != FixedLengthType.None && source.VkName == otherMember.VkName.TrimEnd('s') + "Count")
                {
                    lenExpressions.Add((getValue => StaticCall("Interop.HeapUtil", "GetLength", getValue(otherMember.Name)), otherMember.NoAutoValidity, otherMember.IsOptional));
                }
            }

            bool isArrayLenMember = lenExpressions.Any() && !(source.VkName == "descriptorCount" && context.VkName == "VkWriteDescriptorSet");

            if (isArrayLenMember)
            {
                var lenExpression = lenExpressions.Any(x => !x.Item2)
                                        ? lenExpressions.FirstOrDefault(x => !x.Item2)
                                        : lenExpressions.First();

                MethodAction assign(Func<string, Action<ExpressionBuilder>> getTarget, Func<string, Action<ExpressionBuilder>> getValue) =>
                    new AssignAction
                    {
                        TargetExpression = getTarget(source.Name),
                        ValueExpression = Cast(this.nameLookup.Lookup(source.Type, false), lenExpression.Item1(getValue))
                    };

                string typeName = this.nameLookup.Lookup(source.Type, true);

                if (source.IsOptional && (lenExpressions.All(x => x.Item2 && x.Item3)))
                {
                    info.Public.Add(new TypedDefinition
                    {
                        Name = source.Name,
                        Comment = this.commentGenerator.Lookup(context.VkName, source.VkName),
                        Type = typeName + "?",
                        DefaultValue = Null
                    });

                    MethodAction optionalAssign(Func<string, Action<ExpressionBuilder>> getTarget, Func<string, Action<ExpressionBuilder>> getValue)
                    {
                        var result = new OptionalAction
                        {
                            CheckExpression = IsNotEqual(getValue(source.Name), Null)
                        };

                        result.Actions.Add(new AssignAction
                        {
                            TargetExpression = getTarget(source.Name),
                            ValueExpression = Member(getValue(source.Name), "Value")
                        });

                        result.ElseActions.Add(assign(getTarget, getValue));

                        return result;
                    }

                    info.MarshalTo.Add(optionalAssign);
                }
                else
                {
                    info.MarshalTo.Add(assign);
                }

                info.Interop = new TypedDefinition
                {
                    Name = source.Name,
                    Type = typeName
                };

                info.InteropFullType = typeName;
            }

            return isArrayLenMember;
        }
    }
}
