using System;

namespace SharpVk.Generator.Emit
{
    [Flags]
    public enum MemberModifier
    {
        None = 0,
        Static = 1 << 0,
        Const = 1 << 1,
        Extern = 1 << 2,
        Unsafe = 1 << 3
    }
}