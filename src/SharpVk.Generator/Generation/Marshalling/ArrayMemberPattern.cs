using SharpVk.Generator.Collation;
using SharpVk.Generator.Rules;
using System.Collections.Generic;

using static SharpVk.Emit.ExpressionBuilder;

namespace SharpVk.Generator.Generation.Marshalling
{
    public class ArrayMemberPattern
        : IMemberPatternRule
    {
        private readonly IEnumerable<IMarshalValueRule> marshallingRules;
        private readonly NameLookup nameLookup;

        public ArrayMemberPattern(IEnumerable<IMarshalValueRule> marshallingRules, NameLookup nameLookup)
        {
            this.marshallingRules = marshallingRules;
            this.nameLookup = nameLookup;
        }

        public bool Apply(IEnumerable<ITypedDeclaration> others, ITypedDeclaration source, MemberPatternInfo info)
        {
            if (source.Dimensions != null)
            {
                info.Interop = new TypedDefinition
                {
                    Name = source.Name,
                    Type = this.nameLookup.Lookup(source.Type, true)
                };

                if (source.Dimensions.Length == 2)
                {
                    info.Public = new TypedDefinition
                    {
                        Name = source.Name,
                        Type = "string[]"
                    };
                }
                else if (source.Dimensions.Length == 1)
                {
                    switch (source.Dimensions[0].Type)
                    {
                        case LenType.NullTerminated:
                            info.Public = new TypedDefinition
                            {
                                Name = source.Name,
                                Type = "string"
                            };

                            info.MarshalTo.Add(new Action
                            {
                                ValueExpression = StaticCall("Interop.HeapUtil", "MarshalTo", Member(This, source.Name)),
                                TargetExpression = DerefMember(Variable("pointer"), source.Name),
                                MemberType = this.nameLookup.Lookup(source.Type, false),
                                Type = MemberActionType.Assign
                            });

                            info.MarshalFrom.Add(new Action
                            {
                                ValueExpression = StaticCall("Interop.HeapUtil", "MarshalStringFrom", DerefMember(Variable("pointer"), source.Name)),
                                TargetExpression = Member(Variable("result"), source.Name),
                                MemberType = this.nameLookup.Lookup(source.Type, false),
                                Type = MemberActionType.Assign
                            });

                            break;
                        case LenType.Expression:
                            var elementType = source.Type.Deref();

                            if (elementType.VkName == "void")
                            {
                                elementType.VkName = "uint8_t";
                            }

                            var marshalling = this.marshallingRules.ApplyFirst(elementType);

                            info.Public = new TypedDefinition
                            {
                                Name = source.Name,
                                Type = marshalling.MemberType + "[]"
                            };

                            info.MarshalTo.Add(new Action
                            {
                                TargetExpression = DerefMember(Variable("pointer"), source.Name),
                                MemberType = marshalling.InteropType,
                                IsLoop = true,
                                IndexName = "index",
                                Type = marshalling.MarshalToActionType,
                                NullCheckExpression = IsNotEqual(Member(This, source.Name), Null),
                                LengthExpression = Member(Member(This, source.Name), "Length"),
                                ValueExpression = marshalling.BuildMarshalToValueExpression(Index(Member(This, source.Name), Variable("index")))
                            });
                            break;
                    }
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
