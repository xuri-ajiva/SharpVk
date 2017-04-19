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

        public bool Apply(TypeDeclaration type, MemberDeclaration member, StructDefinition publicStruct, Action<Action> addAction)
        {
            if (member.FixedValue != null)
            {
                if (this.enumLookup.ContainsKey(member.FixedValue))
                {
                    var enumInfo = this.enumLookup[member.FixedValue];
                    var enumTypeName = this.nameLookup.Lookup(enumInfo.TypeVkName);

                    addAction(new Action
                    {
                        ValueExpression = EnumField(enumTypeName, enumInfo.FieldName),
                        ParamName = "pointer",
                        ParamFieldName = member.Name
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
