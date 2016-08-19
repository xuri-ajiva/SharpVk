using System.Runtime.InteropServices;

namespace SharpVk.Shanq
{
    [StructLayout(LayoutKind.Explicit)]
    public struct ShanqOperand
    {
        [FieldOffset(0)]
        public float Float32;

        [FieldOffset(0)]
        public int Int32;

        public static implicit operator ShanqOperand(float value)
        {
            return new ShanqOperand
            {
                Float32 = value
            };
        }

        public static implicit operator ShanqOperand(int value)
        {
            return new ShanqOperand
            {
                Int32 = value
            };
        }
    }
}
