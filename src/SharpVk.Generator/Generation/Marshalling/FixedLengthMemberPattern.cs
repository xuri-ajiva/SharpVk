using SharpVk.Generator.Collation;
using System;

namespace SharpVk.Generator.Generation.Marshalling
{
    public class FixedLengthMemberPattern
        : IMemberPatternRule
    {
        public bool Apply(TypeDeclaration type, MemberDeclaration member, StructDefinition publicStruct, Action<Action> addAction)
        {
            return member.Type.FixedLength.Type != FixedLengthType.None;
        }
    }
}
