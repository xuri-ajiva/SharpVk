using SharpVk.Generator.Collation;
using System;

using static SharpVk.Emit.ExpressionBuilder;

namespace SharpVk.Generator.Generation.Marshalling
{
    public class NextExtensionMemberPattern
        : IMemberPatternRule
    {
        public bool Apply(TypeDeclaration type, MemberDeclaration member, StructDefinition publicStruct, Action<Action> addAction)
        {
            if (member.Name == "Next")
            {
                addAction(new Action
                {
                    ValueExpression = Null,
                    ParamName = "pointer",
                    ParamFieldName = member.Name
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
