using SharpVk.Emit;
using SharpVk.Generator.Collation;
using SharpVk.Generator.Rules;
using System;
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
        private readonly IEnumerable<IMarshalValueRule> marshallingRules;

        public FixedLengthMemberPattern(Dictionary<string, TypeDeclaration> typeData, NameLookup nameLookup, IEnumerable<ConstantDeclaration> constants, IEnumerable<IMarshalValueRule> marshallingRules)
        {
            this.typeData = typeData;
            this.nameLookup = nameLookup;
            this.constantsLookup = constants.ToDictionary(x => x.VkName);
            this.marshallingRules = marshallingRules;
        }

        public bool Apply(IEnumerable<ITypedDeclaration> others, ITypedDeclaration source, MemberPatternContext context, MemberPatternInfo info)
        {
            if (source.Type.FixedLength.Type != FixedLengthType.None)
            {
                string name = source.Name;
                string memberType = this.nameLookup.Lookup(source.Type, false);
                string interopType = this.nameLookup.Lookup(source.Type, true);

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

                    info.InteropFullType = interopType;

                    name += $"[{length}]";
                    interopType = "fixed " + interopType;

                    info.Interop = new TypedDefinition
                    {
                        Name = name,
                        Type = interopType
                    };

                    switch (source.Type.VkName)
                    {
                        case "char":
                            info.Public.Add(new TypedDefinition
                            {
                                Name = source.Name,
                                Type = "string"
                            });

                            info.MarshalFrom.Add((getTarget, getValue) => new AssignAction
                            {
                                TargetExpression = getTarget(source.Name),
                                ValueExpression = StaticCall("Interop.HeapUtil", "MarshalStringFrom", getValue(source.Name), AsIs(length), Literal(true))
                            });

                            break;
                    }
                }
                else
                {
                    var elementType = source.Type.Deref();

                    var marshalling = this.marshallingRules.ApplyFirst(elementType);

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

                    info.InteropFullType = interopType;

                    info.Interop = new TypedDefinition
                    {
                        Name = name,
                        Type = interopType,
                        Repeats = count
                    };

                    info.Public.Add(new TypedDefinition
                    {
                        Name = name,
                        Type = memberType + "[]"
                    });

                    string countMemberName = source.Name.TrimEnd('s') + "Count";

                    info.MarshalFrom.Add((getTarget, getValue) => new AssignAction
                    {
                        TargetExpression = getTarget(source.Name),
                        MemberType = memberType,
                        IsLoop = true,
                        IsArray = true,
                        IndexName = "index",
                        Type = marshalling.MarshalFromActionType,
                        NullCheckExpression = IsNotEqual(getValue(countMemberName), Literal(0)),
                        LengthExpression = getValue(countMemberName),
                        ValueExpression = marshalling.BuildMarshalFromValueExpression(Index(Brackets(AddressOf(Brackets(getValue(source.Name + "_0")))), Variable("index")), context.GetHandle)
                    });
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
