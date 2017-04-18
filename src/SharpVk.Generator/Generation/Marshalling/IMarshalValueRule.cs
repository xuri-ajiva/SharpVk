using SharpVk.Emit;
using SharpVk.Generator.Rules;
using System;

namespace SharpVk.Generator.Generation.Marshalling
{
    public interface IMarshalValueRule
        : IFuncRule<TypeReference, (string, MemberActionType, Func<Action<ExpressionBuilder>, Action<ExpressionBuilder>>)>
    {
    }
}
