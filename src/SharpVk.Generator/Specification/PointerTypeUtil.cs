using System;

namespace SharpVk.Generator.Specification
{
    public static class PointerTypeUtil
    {
        public static PointerType Map(string typeString)
        {
            switch (typeString)
            {
                case "@":
                    return PointerType.Value;
                case "const @":
                case "struct @*":
                    // struct {type}* is a syntactic quirk of C structs with no
                    // typedef; treat them like regular const pointers.
                    return PointerType.ConstValue;
                case "@*":
                    return PointerType.Pointer;
                case "@**":
                    return PointerType.DoublePointer;
                case "const @*":
                    return PointerType.ConstPointer;
                case "const @* const*":
                    return PointerType.DoubleConstPointer;
                default:
                    throw new NotSupportedException(string.Format("Unknown pointer type string '{0}'.", typeString));
            }
        }
    }
}
