using SharpVk.Emit;
using System;

namespace SharpVk.Generator.Generation
{
    public abstract class MethodAction
    {
    }

    public class AssignAction
        : MethodAction
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

    public class DeclarationAction
        : MethodAction
    {
        public string MemberName;
        public string MemberType;
    }

    public enum AssignActionType
    {
        Assign,
        AllocAndAssign,
        MarshalFrom,
        MarshalFromAddressOf,
        MarshalTo,
        MarshalToAddressOf
    }
}