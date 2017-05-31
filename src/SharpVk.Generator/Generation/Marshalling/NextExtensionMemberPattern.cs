using SharpVk.Generator.Collation;
using System.Collections.Generic;
using static SharpVk.Emit.ExpressionBuilder;

namespace SharpVk.Generator.Generation.Marshalling
{
    public class NextExtensionMemberPattern
        : IMemberPatternRule
    {
        private readonly NameLookup nameLookup;

        public NextExtensionMemberPattern(NameLookup nameLookup)
        {
            this.nameLookup = nameLookup;
        }

        public bool Apply(IEnumerable<ITypedDeclaration> others, ITypedDeclaration source, MemberPatternInfo info)
        {
            if (source.Name == "Next")
            {
                info.MarshalTo.Add((getTarget, getValue) => new AssignAction
                {
                    ValueExpression = Null,
                    TargetExpression = getTarget(source.Name)
                });

                string typeName = this.nameLookup.Lookup(source.Type, true);

                info.Interop = new TypedDefinition
                {
                    Name = source.Name,
                    Type = typeName
                };

                info.InteropFullType = typeName;

                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
