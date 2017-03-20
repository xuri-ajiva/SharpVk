
using System;
using System.Runtime.InteropServices;

namespace SharpVk
{
    /// <summary>
    /// -
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct SECURITY_ATTRIBUTES
    {
        /// <summary>
        /// -
        /// </summary>
        public int nLength;

        /// <summary>
        /// -
        /// </summary>
        public IntPtr lpSecurityDescriptor;

        /// <summary>
        /// -
        /// </summary>
        public int bInheritHandle;
    }

    /// <summary>
    /// -
    /// </summary>
    public struct SampleMask
    {
        private uint value;

        /// <summary>
        /// -
        /// </summary>
        public static implicit operator SampleMask(uint value)
        {
            return new SampleMask { value = value };
        }

        /// <summary>
        /// -
        /// </summary>
        public static implicit operator uint(SampleMask size)
        {
            return size.value;
        }

        /// <summary>
        /// -
        /// </summary>
        public override string ToString()
        {
            return this.value.ToString();
        }
    }
}