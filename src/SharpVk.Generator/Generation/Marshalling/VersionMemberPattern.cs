using SharpVk.Generator.Collation;
using System;

using static SharpVk.Emit.ExpressionBuilder;

namespace SharpVk.Generator.Generation.Marshalling
{
    public class VersionMemberPattern
        : IMemberPatternRule
    {
        public bool Apply(MemberDeclaration member, StructDefinition publicStruct, Action<Action> addAction)
        {
            if (member.Name.EndsWith("Version") && member.Type.VkName.StartsWith("uint32"))
            {
                publicStruct.Properties.Add(new MemberDefinition
                {
                    Name = member.Name,
                    Type = "Version"
                });

                addAction(new Action
                {
                    ValueExpression = Cast("uint", Member(This, member.Name)),
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
