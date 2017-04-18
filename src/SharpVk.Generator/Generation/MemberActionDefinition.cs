using SharpVk.Emit;
using System;

namespace SharpVk.Generator.Generation
{
    public class Action
    {
        public Action<ExpressionBuilder> ValueExpression;
        public string ParamName;
        public string ParamFieldName;
        public string MemberType;
        public MemberActionType Type;
    }
}

namespace SharpVk.Generator.Generation
{
    public enum MemberActionType
    {
        AssignToDeref,
        AllocAndAssign,
        MarshalTo,
        MarshalToAddressOf
    }
}