using System;

namespace SharpVk.Generator.Emit
{
    [Flags]
    public enum MemberModifier
    {
        None = 0,
        Static = 1 << 0,
        Const = 2 << 0
    }
}