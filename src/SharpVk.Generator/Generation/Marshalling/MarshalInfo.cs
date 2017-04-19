using SharpVk.Emit;
using System;

namespace SharpVk.Generator.Generation.Marshalling
{
    public struct MarshalInfo
    {
        public string MemberType;
        public string InteropType;
        public MemberActionType ActionType;
        public Func<Action<ExpressionBuilder>, Action<ExpressionBuilder>> BuildValueExpression;
    }
}
