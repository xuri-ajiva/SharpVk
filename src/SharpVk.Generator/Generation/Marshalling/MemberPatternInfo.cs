using SharpVk.Emit;
using System;
using System.Collections.Generic;

namespace SharpVk.Generator.Generation.Marshalling
{
    public class MemberPatternInfo
    {
        public readonly List<TypedDefinition> Public = new List<TypedDefinition>();
        public TypedDefinition Interop;
        public readonly List<Func<Func<string, Action<ExpressionBuilder>>, Func<string, Action<ExpressionBuilder>>, MethodAction>> MarshalTo = new List<Func<Func<string, Action<ExpressionBuilder>>, Func<string, Action<ExpressionBuilder>>, MethodAction>>();
        public readonly List<Func<Func<string, Action<ExpressionBuilder>>, Func<string, Action<ExpressionBuilder>>, MethodAction>> MarshalFrom = new List<Func<Func<string, Action<ExpressionBuilder>>, Func<string, Action<ExpressionBuilder>>, MethodAction>>();
        public string InteropFullType;
    }
}