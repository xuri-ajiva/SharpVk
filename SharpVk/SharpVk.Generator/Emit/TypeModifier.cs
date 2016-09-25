using System;

namespace SharpVk.Generator.Emit
{
    [Flags]
    public enum TypeModifier
    {
        None = 0,
        Static = 1 << 0,
        Unsafe = 1 << 1
    }
}