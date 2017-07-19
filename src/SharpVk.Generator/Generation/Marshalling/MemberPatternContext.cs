using SharpVk.Emit;
using System;

namespace SharpVk.Generator.Generation.Marshalling
{
    public struct MemberPatternContext
    {
        public MemberPatternContext(string methodVerb, string extension, Func<string, Action<ExpressionBuilder>> getHandle, string vkName)
            : this()
        {
            this.MethodVerb = methodVerb;
            this.Extension = extension;
            this.GetHandle = getHandle;
            this.VkName = vkName;
        }

        public string MethodVerb
        {
            get;
            private set;
        }

        public string Extension
        {
            get;
            private set;
        }

        public Func<string, Action<ExpressionBuilder>> GetHandle
        {
            get;
            private set;
        }

        public string VkName
        {
            get;
            private set;
        }
    }
}
