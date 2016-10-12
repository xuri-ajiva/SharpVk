
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

    /// <summary>
    /// -
    /// </summary>
    public struct Bool32
    {
        private uint value;

        /// <summary>
        /// -
        /// </summary>
        public Bool32(bool value)
        {
            this.value = value
                            ? Constants.True
                            : Constants.False;
        }

        /// <summary>
        /// -
        /// </summary>
        public static implicit operator Bool32(bool value)
        {
            return new Bool32(value);
        }

        /// <summary>
        /// -
        /// </summary>
        public static implicit operator bool(Bool32 value)
        {
            return value.value != Constants.False;
        }

        /// <summary>
        /// -
        /// </summary>
        public override string ToString()
        {
            return ((bool)this).ToString();
        }
    }

    /// <summary>
    /// -
    /// </summary>
    public struct DeviceSize
    {
        private ulong value;

        /// <summary>
        /// -
        /// </summary>
        public static implicit operator DeviceSize(int value)
        {
            return new DeviceSize { value = (ulong)value };
        }

        /// <summary>
        /// -
        /// </summary>
        public static implicit operator DeviceSize(ulong value)
        {
            return new DeviceSize { value = value };
        }

        /// <summary>
        /// -
        /// </summary>
        public static implicit operator ulong(DeviceSize size)
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

    /// <summary>
    /// -
    /// </summary>
    public struct Size
    {
        private UIntPtr value;

        /// <summary>
        /// -
        /// </summary>
        public static implicit operator Size(int value)
        {
            return new Size { value = (UIntPtr)value };
        }

        /// <summary>
        /// -
        /// </summary>
        public static implicit operator Size(uint value)
        {
            return new Size { value = (UIntPtr)value };
        }

        /// <summary>
        /// -
        /// </summary>
        public static implicit operator Size(ulong value)
        {
            return new Size { value = (UIntPtr)value };
        }

        /// <summary>
        /// -
        /// </summary>
        public static explicit operator uint(Size size)
        {
            return size.value.ToUInt32();
        }

        /// <summary>
        /// -
        /// </summary>
        public static explicit operator ulong(Size size)
        {
            return size.value.ToUInt64();
        }

        /// <summary>
        /// -
        /// </summary>
        public override string ToString()
        {
            return this.value.ToString();
        }
    }

    public partial struct ComponentMapping
    {
        /// <summary>
        /// Returns a default ComponentMapping of Identity for all components.
        /// </summary>
        public static ComponentMapping Identity
        {
            get
            {
                return new ComponentMapping
                {
                    R = ComponentSwizzle.Identity,
                    G = ComponentSwizzle.Identity,
                    B = ComponentSwizzle.Identity,
                    A = ComponentSwizzle.Identity
                };
            }
        }
    }
}