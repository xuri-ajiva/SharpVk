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

        public bool Apply(IEnumerable<ITypedDeclaration> others, ITypedDeclaration source, MemberPatternInfo info)
        {
            if (source.Type.FixedLength.Type != FixedLengthType.None)
            {
                string name = source.Name;
                string memberType = this.nameLookup.Lookup(source.Type, true);

                if (this.typeData[source.Type.VkName].Pattern == TypePattern.Primitive)
                {
                    string length = "1";

                    if (source.Type.FixedLength.Type == FixedLengthType.IntegerLiteral)
                    {
                        length = source.Type.FixedLength.Value;
                    }
                    else
                    {
                        var constant = this.constantsLookup[source.Type.FixedLength.Value];

                        length = $"Constants.{constant.Name}";
                    }

                    name += $"[{length}]";
                    memberType = "fixed " + memberType;

                    info.Interop = new TypedDefinition
                    {
                        Name = name,
                        Type = memberType
                    };

                    switch(source.Type.VkName)
                    {
                        case "char":
                            info.Public = new TypedDefinition
                            {
                                Name = source.Name,
                                Type = "string"
                            };

                            info.MarshalFrom.Add(new Action
                            {
                                TargetExpression = Member(Variable("result"), source.Name),
                                ValueExpression = StaticCall("Interop.HeapUtil", "MarshalStringFrom", DerefMember(Variable("pointer"), source.Name), AsIs(length), Literal(true))
                            });

                            break;
                    }
                }
                else
                {
                    int count = 1;

                    if (source.Type.FixedLength.Type == FixedLengthType.IntegerLiteral)
                    {
                        count = int.Parse(source.Type.FixedLength.Value);
                    }
                    else
                    {
                        var constant = this.constantsLookup[source.Type.FixedLength.Value];

                        count = int.Parse(constant.Value);
                    }
                    
                        info.Interop = new TypedDefinition
                        {
                            Name = name,
                            Type = memberType,
                            Repeats = count
                        };
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
