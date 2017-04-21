using SharpVk.Emit;
using SharpVk.Generator.Collation;
using System;
using System.Collections.Generic;

using static SharpVk.Emit.ExpressionBuilder;

namespace SharpVk.Generator.Generation.Marshalling
{
    public class MarshalStructValue
        : IMarshalValueRule
    {
        private readonly Dictionary<string, TypeDeclaration> typeData;
        private readonly NameLookup nameLookup;

        public MarshalStructValue(NameLookup nameLookup, Dictionary<string, TypeDeclaration> typeData)
        {
            this.nameLookup = nameLookup;
            this.typeData = typeData;
        }

        public bool Apply(TypeReference type, out MarshalInfo info)
        {
            var typePattern = this.typeData[type.VkName].Pattern;

            if (typePattern == TypePattern.MarshalledStruct)
            {
                MemberActionType toAction = type.PointerType.IsPointer()
                                                ? MemberActionType.MarshalTo
                                                : MemberActionType.MarshalToAddressOf;

                MemberActionType fromAction = type.PointerType.IsPointer()
                                                    ? MemberActionType.MarshalFrom
                                                    : MemberActionType.MarshalFromAddressOf;

                info = new MarshalInfo
                {
                    MemberType = this.nameLookup.Lookup(type, false),
                    InteropType = "Interop." + this.nameLookup.Lookup(type, false),
                    MarshalToActionType = toAction,
                    MarshalFromActionType = fromAction,
                    BuildMarshalToValueExpression = value => value,
                    BuildMarshalFromValueExpression = value => value
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
