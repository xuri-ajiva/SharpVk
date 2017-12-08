using SharpVk.Emit;
using System;

namespace SharpVk.Generator.Generation.Marshalling
{
    public struct MemberPatternContext
    {
        public MemberPatternContext(string methodVerb, bool isMethod, bool isBatchSingleMethod, bool hasReturnValue, string extension, Func<string, Action<ExpressionBuilder>> getHandle, string vkName)
            : this()
        {
            this.MethodVerb = methodVerb;
            this.IsMethod = isMethod;
            this.IsBatchSingleMethod = isBatchSingleMethod;
            this.HasReturnValue = hasReturnValue;
            this.Extension = extension;
            this.GetHandle = getHandle;
            this.VkName = vkName;
        }

        public string MethodVerb
        {
            get;
            private set;
        }

        public bool IsMethod
        {
            get;
            private set;
        }

        public bool IsBatchSingleMethod
        {
            get;
            private set;
        }

        public bool HasReturnValue
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
