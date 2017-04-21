using SharpVk.Generator.Collation;
using System.Collections.Generic;

using static SharpVk.Emit.ExpressionBuilder;

namespace SharpVk.Generator.Generation.Marshalling
{
    public class MarshalHandleValue
        : IMarshalValueRule
    {
        private readonly Dictionary<string, TypeDeclaration> typeData;
        private readonly NameLookup nameLookup;

        public MarshalHandleValue(NameLookup nameLookup, Dictionary<string, TypeDeclaration> typeData)
        {
            this.nameLookup = nameLookup;
            this.typeData = typeData;
        }

        public bool Apply(TypeReference type, out MarshalInfo info)
        {
            var typePattern = this.typeData[type.VkName].Pattern;

            if (typePattern == TypePattern.Handle)
            {
                string memberType = this.nameLookup.Lookup(type, false);

                info = new MarshalInfo
                {
                    MemberType = memberType,
                    InteropType = "Interop." + memberType,
                    BuildMarshalToValueExpression = value => Member(value, "handle"),
                    BuildMarshalFromValueExpression = value => New(memberType, value)
                };

                return true;
            }
            else
            {
                info = new MarshalInfo();

                return false;
            }
        }
    }
}
