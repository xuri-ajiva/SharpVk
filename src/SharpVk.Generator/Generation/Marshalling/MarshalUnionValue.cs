using SharpVk.Emit;
using SharpVk.Generator.Collation;
using System;
using System.Collections.Generic;
using System.Linq;
using static SharpVk.Emit.ExpressionBuilder;

namespace SharpVk.Generator.Generation.Marshalling
{
    public class MarshalUnionValue
        : IMarshalValueRule
    {
        private readonly Dictionary<string, TypeDeclaration> typeData;
        private readonly NameLookup nameLookup;

        public MarshalUnionValue(NameLookup nameLookup, Dictionary<string, TypeDeclaration> typeData)
        {
            this.nameLookup = nameLookup;
            this.typeData = typeData;
        }

        public bool Apply(TypeReference type, out MarshalInfo info)
        {
            var typeInfo = this.typeData[type.VkName];
            var typePattern = typeInfo.Pattern;

            if (typePattern == TypePattern.Union)
            {
                string memberType = this.nameLookup.Lookup(type, false);
                var interopType = this.nameLookup.Lookup(type, true);

                info = new MarshalInfo
                {
                    MemberType = memberType,
                    InteropType = interopType
                };

                info.BuildMarshalFromValueExpression = (value, getHandle) => Default(memberType);
                info.BuildMarshalToValueExpression = (value, getHandle) => Default(interopType);

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
