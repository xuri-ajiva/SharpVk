using SharpVk.Emit;
using System;

namespace SharpVk.Generator.Generation
{
    public abstract class Action
    {
    }

    public class AssignAction
        : Action
    {
        public Action<ExpressionBuilder> NullCheckExpression;
        public Action<ExpressionBuilder> LengthExpression;
        public Action<ExpressionBuilder> ValueExpression;
        public Action<ExpressionBuilder> TargetExpression;
        public string IndexName;
        public string MemberName;
        public string MemberType;
        public AssignActionType Type;
        public bool IsLoop;
    }

    public enum AssignActionType
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