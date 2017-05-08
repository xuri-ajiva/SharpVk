using SharpVk.Generator.Collation;
using System.Collections.Generic;
using System.Linq;

using static SharpVk.Emit.ExpressionBuilder;

namespace SharpVk.Generator.Generation.Marshalling
{
    public class FixedLengthMemberPattern
        : IMemberPatternRule
    {
        private readonly Dictionary<string, TypeDeclaration> typeData;
        private readonly NameLookup nameLookup;
        private readonly Dictionary<string, ConstantDeclaration> constantsLookup;

        public FixedLengthMemberPattern(Dictionary<string, TypeDeclaration> typeData, NameLookup nameLookup, IEnumerable<ConstantDeclaration> constants)
        {
            this.typeData = typeData;
            this.nameLookup = nameLookup;
            this.constantsLookup = constants.ToDictionary(x => x.VkName);
        }

        public bool Apply(TypeDeclaration type, MemberDeclaration member, MemberPatternInfo info)
        {
            if (member.Type.FixedLength.Type != FixedLengthType.None)
            {
                string name = member.Name;
                string memberType = this.nameLookup.Lookup(member.Type, true);

                if (this.typeData[member.Type.VkName].Pattern == TypePattern.Primitive)
                {
                    string length = "1";

                    if (member.Type.FixedLength.Type == FixedLengthType.IntegerLiteral)
                    {
                        length = member.Type.FixedLength.Value;
                    }
                    else
                    {
                        var constant = this.constantsLookup[member.Type.FixedLength.Value];

                        length = $"Constants.{constant.Name}";
                    }

                    name += $"[{length}]";
                    memberType = "fixed " + memberType;

                    info.InteropStruct.Fields.Add(new MemberDefinition
                    {
                        Name = name,
                        Type = memberType
                    });

                    switch(member.Type.VkName)
                    {
                        case "char":
                            info.PublicStruct.Properties.Add(new MemberDefinition
                            {
                                Name = member.Name,
                                Type = "string"
                            });

                            info.MarshalFrom.MemberActions.Add(new Action
                            {
                                TargetExpression = Member(Variable("result"), member.Name),
                                ValueExpression = StaticCall("Interop.HeapUtil", "MarshalStringFrom", DerefMember(Variable("pointer"), member.Name), AsIs(length), Literal(true))
                            });

                            break;
                    }
                }
                else
                {
                    int count = 1;

                    if (member.Type.FixedLength.Type == FixedLengthType.IntegerLiteral)
                    {
                        count = int.Parse(member.Type.FixedLength.Value);
                    }
                    else
                    {
                        var constant = this.constantsLookup[member.Type.FixedLength.Value];

                        count = int.Parse(constant.Value);
                    }

                    for (int index = 0; index < count; index++)
                    {
                        info.InteropStruct.Fields.Add(new MemberDefinition
                        {
                            Name = name + "_" + index,
                            Type = memberType
                        });
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
