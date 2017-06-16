using SharpVk.Emit;
using System;

namespace SharpVk.Generator.Generation.Marshalling
{
    public struct MemberPatternContext
    {
        public MemberPatternContext(string methodVerb, Func<string, Action<ExpressionBuilder>> getHandle)
            : this()
        {
            this.MethodVerb = methodVerb;
            this.GetHandle = getHandle;
        }

        public string MethodVerb
        {
            get;
            private set;
        }

        public Func<string, Action<ExpressionBuilder>> GetHandle
        {
            get;
            private set;
        }
    }
}
