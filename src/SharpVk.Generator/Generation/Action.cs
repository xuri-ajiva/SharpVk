using SharpVk.Emit;
using System;
using System.Collections.Generic;

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
        public bool IsArray;
        public bool IsOptional;
    }

    public class DeclarationAction
        : MethodAction
    {
        public string MemberName;
        public string MemberType;
    }

    public class InvokeAction
        : MethodAction
    {
        public string TypeName;
        public string MethodName;
        public string ReturnName;
        public string ReturnType;
        public Action<ExpressionBuilder>[] Parameters;
    }

    public class OptionalAction
        : MethodAction
    {
        public Action<ExpressionBuilder> NullCheckExpression;
        public readonly List<MethodAction> Actions = new List<MethodAction>();
    }

    public class ValidateAction
        : MethodAction
    {
        public string VariableName;
    }

    public enum AssignActionType
    {
        Assign,
        Alloc,
        AllocAndAssign,
        MarshalFrom,
        MarshalFromAddressOf,
        MarshalTo,
        MarshalToAddressOf
    }
}