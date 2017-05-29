using SharpVk.Generator.Collation;
using System;
using System.Collections.Generic;

using static SharpVk.Emit.ExpressionBuilder;

namespace SharpVk.Generator.Generation.Marshalling
{
    public class FixedValueMemberPattern
        : IMemberPatternRule
    {
        private readonly NameLookup nameLookup;
        private readonly Dictionary<string, EnumMapping> enumLookup;

        public FixedValueMemberPattern(NameLookup nameLookup, Dictionary<string, EnumMapping> enumLookup)
        {
            this.nameLookup = nameLookup;
            this.enumLookup = enumLookup;
        }

        public bool Apply(IEnumerable<ITypedDeclaration> others, ITypedDeclaration source, MemberPatternInfo info)
        {
            if (source.FixedValue != null)
            {
                if (this.enumLookup.ContainsKey(source.FixedValue))
                {
                    var enumInfo = this.enumLookup[source.FixedValue];
                    var enumTypeName = this.nameLookup.Lookup(enumInfo.TypeVkName);

                    info.MarshalTo.Add(new Action
                    {
                        ValueExpression = EnumField(enumTypeName, enumInfo.FieldName),
                        TargetExpression = DerefMember(Variable("pointer"), source.Name)
                    });
                }

                info.Interop = new TypedDefinition
                {
                    Name = source.Name,
                    Type = this.nameLookup.Lookup(source.Type, true)
                };

                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
