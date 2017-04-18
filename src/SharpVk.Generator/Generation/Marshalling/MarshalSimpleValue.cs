using SharpVk.Emit;
using System;

namespace SharpVk.Generator.Generation.Marshalling
{
    public class MarshalSimpleValue
        : IMarshalValueRule
    {
        private readonly NameLookup nameLookup;

        public MarshalSimpleValue(NameLookup nameLookup)
        {
            this.nameLookup = nameLookup;
        }

        public bool Apply(TypeReference type, out (string, MemberActionType, Func<Action<ExpressionBuilder>, Action<ExpressionBuilder>>) result)
        {
            result = (this.nameLookup.Lookup(type, false), MemberActionType.AssignToDeref, value => value);

            return true;
        }
    }
}
