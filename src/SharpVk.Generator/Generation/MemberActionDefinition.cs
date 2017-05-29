using SharpVk.Emit;
using System;

namespace SharpVk.Generator.Generation
{
    public class Action
    {
        public Action<ExpressionBuilder> NullCheckExpression;
        public Action<ExpressionBuilder> LengthExpression;
        public Action<ExpressionBuilder> ValueExpression;
        public Action<ExpressionBuilder> TargetExpression;
        public string IndexName;
        public string MemberName;
        public string MemberType;
        public MemberActionType Type;
        public bool IsLoop;
    }
}

namespace SharpVk.Generator.Generation
{
    public enum MemberActionType
    {
        Assign,
        AllocAndAssign,
        Declaration,
        MarshalFrom,
        MarshalFromAddressOf,
        MarshalTo,
        MarshalToAddressOf
    }
}