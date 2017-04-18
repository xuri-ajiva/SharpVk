using SharpVk.Emit;
using System;

namespace SharpVk.Generator.Generation.Marshalling
{
    public class MarshalPointerValue
        : IMarshalValueRule
    {
        private readonly NameLookup nameLookup;

        public MarshalPointerValue(NameLookup nameLookup)
        {
            this.nameLookup = nameLookup;
        }

        public bool Apply(TypeReference type, out (string, MemberActionType, Func<Action<ExpressionBuilder>, Action<ExpressionBuilder>>) result)
        {
            if (type.PointerType.IsPointer())
            {
                result = (this.nameLookup.Lookup(type, false),
                            MemberActionType.AllocAndAssign,
                            value => value);

                return true;
            }
            else
            {
                result = (null, MemberActionType.AssignToDeref, null);

                return false;
            }
        }
    }
}
