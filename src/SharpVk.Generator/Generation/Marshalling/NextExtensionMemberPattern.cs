using SharpVk.Generator.Collation;

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

        public bool Apply(TypeDeclaration type, MemberDeclaration member, MemberPatternInfo info)
        {
            if (member.Name == "Next")
            {
                info.MarshalTo.MemberActions.Add(new Action
                {
                    ValueExpression = Null,
                    TargetExpression = DerefMember(Variable("pointer"), member.Name)
                });

                info.InteropStruct.Fields.Add(new MemberDefinition
                {
                    Name = member.Name,
                    Type = this.nameLookup.Lookup(member.Type, true)
                });

                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
