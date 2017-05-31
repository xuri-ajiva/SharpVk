using SharpVk.Emit;
using System;
using System.Collections.Generic;

namespace SharpVk.Generator.Generation.Marshalling
{
    public class MemberPatternInfo
    {
        public TypedDefinition? Public;
        public TypedDefinition Interop;
        public List<Func<Func<string, Action<ExpressionBuilder>>, Func<string, Action<ExpressionBuilder>>, MethodAction>> MarshalTo = new List<Func<Func<string, Action<ExpressionBuilder>>, Func<string, Action<ExpressionBuilder>>, MethodAction>>();
        public List<Func<Func<string, Action<ExpressionBuilder>>, Func<string, Action<ExpressionBuilder>>, MethodAction>> MarshalFrom = new List<Func<Func<string, Action<ExpressionBuilder>>, Func<string, Action<ExpressionBuilder>>, MethodAction>>();
        public string InteropFullType;
    }
}