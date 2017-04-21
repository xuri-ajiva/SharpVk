using SharpVk.Generator.Collation;
using System.Collections.Generic;

namespace SharpVk.Generator.Generation.Marshalling
{
    public class FixedLengthMemberPattern
        : IMemberPatternRule
    {
        private readonly Dictionary<string, TypeDeclaration> typeData;
        private readonly NameLookup nameLookup;

        public FixedLengthMemberPattern(Dictionary<string, TypeDeclaration> typeData, NameLookup nameLookup)
        {
            this.typeData = typeData;
            this.nameLookup = nameLookup;
        }

        public bool Apply(TypeDeclaration type, MemberDeclaration member, MemberPatternInfo info)
        {
            if(member.Type.FixedLength.Type != FixedLengthType.None)
            {
                string name = member.Name;
                string memberType = this.nameLookup.Lookup(member.Type, true);

                if (member.Type.FixedLength.Type != FixedLengthType.None && this.typeData[member.Type.VkName].Pattern == TypePattern.Primitive)
                {
                    string length = "1";

                    if (member.Type.FixedLength.Type == FixedLengthType.IntegerLiteral)
                    {
                        length = member.Type.FixedLength.Value;
                    }

                    name += $"[{length}]";
                    memberType = "fixed " + memberType;
                }

                info.InteropStruct.Fields.Add(new MemberDefinition
                {
                    Name = name,
                    Type = memberType
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
