using SharpVk.Emit;
using System;

using static SharpVk.Emit.ExpressionBuilder;

namespace SharpVk.Generator.Generation.Marshalling
{
    public class MarshalVoidPointerValue
        : IMarshalValueRule
    {
        public bool Apply(TypeReference type, out (string, MemberActionType, Func<Action<ExpressionBuilder>, Action<ExpressionBuilder>>) result)
        {
            if (type.VkName == "void" && type.PointerType.IsPointer())
            {
                result = ("IntPtr", MemberActionType.AssignToDeref, value => Call(value, "ToPointer"));

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
