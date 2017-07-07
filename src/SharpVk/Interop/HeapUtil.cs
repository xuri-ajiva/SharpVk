using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace SharpVk.Interop
{
    internal static unsafe class HeapUtil
    {
        private const int perThreadSpace = 1 << 20;

        [ThreadStatic]
        private static IntPtr allocateSpace;

        [ThreadStatic]
        private static uint allocatedCount;

        private static IntPtr AllocateSpace
        {
            get
            {
                if (allocateSpace == IntPtr.Zero)
                {
                    allocateSpace = Marshal.AllocHGlobal(perThreadSpace);

                    allocatedCount = 0;
                }

                return allocateSpace;
            }
        }

        internal static IntPtr Allocate<T>(int count)
        {
            return Allocate<T>((uint)count);
        }

        internal static IntPtr Allocate<T>(uint count = 1)
        {
            uint requiredSize = SizeOfCache<T>.Value * (uint)count;

            uint tailBytes = requiredSize % (uint)IntPtr.Size;

            if (tailBytes > 0)
            {
                requiredSize += ((uint)IntPtr.Size - tailBytes);
            }

            if (allocatedCount + requiredSize > perThreadSpace)
            {
                throw new Exception("Out of interop heap memory");
            }

            IntPtr pointer = AllocateSpace + (int)allocatedCount;

            allocatedCount += requiredSize;

            return pointer;
        }

        internal static IntPtr AllocateAndClear<T>(int count = 1)
        {
            uint size = SizeOfCache<T>.Value;

            IntPtr pointer = Allocate<T>(count);

            var bytePointer = (byte*)pointer.ToPointer();

            for (int offset = 0; offset < count; offset++)
            {
                bytePointer[offset] = 0;
            }

            return pointer;
        }

        internal static void FreeAll()
        {
            allocatedCount = 0;
        }

        internal static byte* MarshalTo(string value)
        {
            if (value != null)
            {
                int size = Encoding.UTF8.GetByteCount(value) + 1;

                IntPtr pointer = AllocateAndClear<byte>(size);

                var chars = stackalloc char[value.Length];

                Marshal.Copy(value.ToCharArray(), 0, new IntPtr(chars), value.Length);

                Encoding.UTF8.GetBytes(chars, value.Length, (byte*)pointer.ToPointer(), size);

                return (byte*)pointer.ToPointer();
            }
            else
            {
                return null;
            }
        }

        internal static byte** MarshalTo(string[] value)
        {
            IntPtr pointer = Allocate<IntPtr>(value.Length);

            byte** typedPointer = (byte**)pointer.ToPointer();

            MarshalTo(value, value.Length, typedPointer);

            return typedPointer;
        }

        internal static string MarshalStringFrom(byte* pointer)
        {
            return Marshal.PtrToStringAnsi(new IntPtr(pointer));
        }

        internal static string MarshalStringFrom(byte* pointer, int length, bool isNullTerminated = false)
        {
            int actualLength;

            if (isNullTerminated)
            {
                actualLength = 0;

                while (actualLength < length && pointer[actualLength] != 0)
                {
                    actualLength++;
                }

                length = actualLength;
            }
            else
            {
                actualLength = length;
            }

            return Marshal.PtrToStringAnsi(new IntPtr(pointer), actualLength);
        }

        internal static byte[] MarshalFrom(byte* pointer, int length)
        {
            return MarshalFrom(pointer, length, out int actualLength);
        }

        internal static byte[] MarshalFrom(byte* pointer, int length, out int actualLength, bool isNullTerminated = false)
        {
            if (isNullTerminated)
            {
                actualLength = 0;

                while (actualLength < length && pointer[actualLength] != 0)
                {
                    actualLength++;
                }

                length = actualLength;
            }
            else
            {
                actualLength = length;
            }

            var newArray = new byte[length];

            Marshal.Copy(new IntPtr(pointer), newArray, 0, length);

            return newArray;
        }

        internal static float[] MarshalFrom(float* pointer, int length)
        {
            var newArray = new float[length];

            Marshal.Copy(new IntPtr(pointer), newArray, 0, length);

            return newArray;
        }

        internal static uint[] MarshalFrom(uint* pointer, int length)
        {
            var newArray = new uint[length];

            // Marshal.Copy doesn't support uints for some reason...
            for (int index = 0; index < length; index++)
            {
                newArray[index] = *(pointer + length);
            }

            return newArray;
        }

        internal static byte* MarshalTo(byte[] value)
        {
            byte* pointer = (byte*)Allocate<byte>(value.Length).ToPointer();

            MarshalTo(value, value.Length, pointer);

            return pointer;
        }

        internal static float* MarshalTo(float[] value)
        {
            float* pointer = (float*)Allocate<float>(value.Length).ToPointer();

            MarshalTo(value, value.Length, pointer);

            return pointer;
        }

        internal static int* MarshalTo(int[] value)
        {
            int* pointer = (int*)Allocate<int>(value.Length).ToPointer();

            MarshalTo(value, value.Length, pointer);

            return pointer;
        }

        internal static uint* MarshalTo(uint[] value)
        {
            uint* pointer = (uint*)Allocate<uint>(value.Length).ToPointer();

            MarshalTo(value, value.Length, pointer);

            return pointer;
        }

        internal static ulong* MarshalTo(ulong[] value)
        {
            ulong* pointer = (ulong*)Allocate<ulong>(value.Length).ToPointer();

            MarshalTo(value, value.Length, pointer);

            return pointer;
        }

        //internal static void* MarshalTo<T>(IEnumerable<T> value, int length)
        //    where T : struct
        //{
        //    uint size = MemUtil.SizeOf<T>();

        //    T[] valueArray = value.ToArray();

        //    IntPtr pointer = Allocate<T>(valueArray.Length);

        //    for (int index = 0; index < length; index++)
        //    {
        //        Marshal.StructureToPtr(valueArray[index], pointer + ((int)size * index), false);
        //    }

        //    return pointer.ToPointer();
        //}

        internal static void MarshalTo(byte[] value, int length, byte* pointer)
        {
            Marshal.Copy(value, 0, new IntPtr(pointer), length);
        }

        internal static void MarshalTo(float[] value, int length, float* pointer)
        {
            Marshal.Copy(value, 0, new IntPtr(pointer), length);
        }

        internal static void MarshalTo(int[] value, int length, int* pointer)
        {
            Marshal.Copy(value, 0, new IntPtr(pointer), length);
        }

        internal static void MarshalTo(uint[] value, int length, uint* pointer)
        {
            //Marshal.Copy doesn't support uints for some reason...
            for (int index = 0; index < length; index++)
            {
                pointer[index] = value[index];
            }
        }

        internal static void MarshalTo(ulong[] value, int length, ulong* pointer)
        {
            //Marshal.Copy doesn't support ulongs for some reason...
            for (int index = 0; index < length; index++)
            {
                pointer[index] = value[index];
            }
        }

        internal static void MarshalTo(string[] value, int length, byte** pointer)
        {
            for (int index = 0; index < length; index++)
            {
                pointer[index] = MarshalTo(value[index]);
            }
        }

        private static class SizeOfCache<T>
        {
            public static readonly uint Value;

            static SizeOfCache()
            {
                Value = (uint)Unsafe.SizeOf<T>();
            }
        }
    }
}
