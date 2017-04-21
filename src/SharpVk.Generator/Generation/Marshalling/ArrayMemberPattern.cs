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

        public bool Apply(TypeDeclaration type, MemberDeclaration member, MemberPatternInfo info)
        {
            if (member.Dimensions != null)
            {
                info.InteropStruct.Fields.Add(new MemberDefinition
                {
                    Name = member.Name,
                    Type = this.nameLookup.Lookup(member.Type, true)
                });

                if (member.Dimensions.Length == 2)
                {
                    info.PublicStruct.Properties.Add(new MemberDefinition
                    {
                        Name = member.Name,
                        Type = "string[]"
                    });
                }
                else if (member.Dimensions.Length == 1)
                {
                    switch (member.Dimensions[0].Type)
                    {
                        case LenType.NullTerminated:
                            info.PublicStruct.Properties.Add(new MemberDefinition
                            {
                                Name = member.Name,
                                Type = "string"
                            });

                            info.MarshalTo.MemberActions.Add(new Action
                            {
                                ValueExpression = StaticCall("Interop.HeapUtil", "MarshalTo", Member(This, member.Name)),
                                TargetExpression = DerefMember(Variable("pointer"), member.Name),
                                MemberType = this.nameLookup.Lookup(member.Type, false),
                                Type = MemberActionType.Assign
                            });

                            break;
                        case LenType.Expression:
                            var elementType = member.Type.Deref();

                            if (elementType.VkName == "void")
                            {
                                elementType.VkName = "uint8_t";
                            }

                            var marshalling = this.marshallingRules.ApplyFirst(elementType);

                            info.PublicStruct.Properties.Add(new MemberDefinition
                            {
                                Name = member.Name,
                                Type = marshalling.MemberType + "[]"
                            });

                            info.MarshalTo.MemberActions.Add(new Action
                            {
                                TargetExpression = DerefMember(Variable("pointer"), member.Name),
                                MemberType = marshalling.InteropType,
                                IsLoop = true,
                                IndexName = "index",
                                Type = marshalling.MarshalToActionType,
                                NullCheckExpression = IsNotEqual(Member(This, member.Name), Null),
                                LengthExpression = Member(Member(This, member.Name), "Length"),
                                ValueExpression = marshalling.BuildMarshalToValueExpression(Index(Member(This, member.Name), Variable("index")))
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
