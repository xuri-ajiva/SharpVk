using static SharpVk.Emit.ExpressionBuilder;

namespace SharpVk.Generator.Generation.Marshalling
{
    public class MarshalVoidPointerValue
        : IMarshalValueRule
    {
        public bool Apply(TypeReference type, out MarshalInfo info)
        {
            if (type.VkName == "void" && type.PointerType.IsPointer())
            {
                info = new MarshalInfo
                {
                    MemberType = "IntPtr",
                    InteropType = "byte",
                    ActionType = MemberActionType.AssignToDeref,
                    BuildValueExpression = value => Call(value, "ToPointer")
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
