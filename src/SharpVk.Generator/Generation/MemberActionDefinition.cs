using SharpVk.Emit;
using System;

namespace SharpVk.Generator.Generation
{
    public class Action
    {
        public Action<ExpressionBuilder> NullCheckExpression;
        public Action<ExpressionBuilder> LengthExpression;
        public Action<ExpressionBuilder> ValueExpression;
        public string ParamName;
        public string ParamFieldName;
        public string IndexName;
        public string MemberType;
        public MemberActionType Type;
        public bool IsLoop;
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