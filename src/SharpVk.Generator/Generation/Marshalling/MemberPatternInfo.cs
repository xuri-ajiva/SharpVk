using SharpVk.Emit;
using System;
using System.Collections.Generic;

namespace SharpVk.Generator.Generation.Marshalling
{
    public class MemberPatternInfo
    {
        public TypedDefinition? Public;
        public TypedDefinition Interop;
        public List<Func<Func<string, Action<ExpressionBuilder>>, Func<string, Action<ExpressionBuilder>>, Action>> MarshalTo = new List<Func<Func<string, Action<ExpressionBuilder>>, Func<string, Action<ExpressionBuilder>>, Action>>();
        public List<Action> MarshalFrom;
        public string InteropFullType;
    }
}