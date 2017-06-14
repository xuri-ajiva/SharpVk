using SharpVk.Spirv;
using System;

namespace SharpVk.Shanq
{
    [AttributeUsage(AttributeTargets.Field)]
    public class BuiltInAttribute
        : Attribute
    {
        public BuiltInAttribute(BuiltIn builtIn)
        {
            this.BuiltIn = builtIn;
        }

        public BuiltIn BuiltIn
        {
            get;
            private set;
        }
    }
}
