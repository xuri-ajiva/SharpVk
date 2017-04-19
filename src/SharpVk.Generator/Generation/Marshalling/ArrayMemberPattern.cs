using SharpVk.Generator.Collation;
using SharpVk.Generator.Rules;
using System;
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

        public bool Apply(TypeDeclaration type, MemberDeclaration member, StructDefinition publicStruct, Action<Action> addAction)
        {
            if (member.Dimensions != null)
            {
                if (member.Dimensions.Length == 2)
                {
                    publicStruct.Properties.Add(new MemberDefinition
                    {
                        Name = member.Name,
                        Type = "string[]"
                    });
                }
                if (member.Dimensions.Length == 1)
                {
                    switch (member.Dimensions[0].Type)
                    {
                        case LenType.NullTerminated:
                            publicStruct.Properties.Add(new MemberDefinition
                            {
                                Name = member.Name,
                                Type = "string"
                            });
                            //memberDesc.PublicTypeName = "string";

                            //newClass.MarshalToStatements.Add(string.Format("pointer->{0} = Interop.HeapUtil.MarshalTo(this.{0});", memberName));
                            //newClass.MarshalFromStatements.Add(string.Format("result.{0} = Interop.HeapUtil.MarshalFrom(value->{0});", memberName));
                            break;
                        case LenType.Expression:
                            var elementType = new TypeReference
                            {
                                VkName = member.Type.VkName
                            };

                            if (elementType.VkName == "void")
                            {
                                elementType.VkName = "uint8_t";
                            }

                            var marshalling = this.marshallingRules.ApplyFirst(elementType);

                            publicStruct.Properties.Add(new MemberDefinition
                            {
                                Name = member.Name,
                                Type = marshalling.MemberType + "[]"
                            });

                            addAction(new Action
                            {
                                ParamName = "pointer",
                                ParamFieldName = member.Name,
                                MemberType = marshalling.InteropType,
                                IsLoop = true,
                                IndexName = "index",
                                Type = marshalling.ActionType,
                                NullCheckExpression = IsNotEqual(Member(This, member.Name), Null),
                                LengthExpression = Member(Member(This, member.Name), "Length"),
                                ValueExpression = marshalling.BuildValueExpression(Index(Member(This, member.Name), Variable("index")))
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
