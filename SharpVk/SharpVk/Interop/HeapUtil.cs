using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SharpVk.Interop
{
    internal static unsafe class HeapUtil
    {
        internal static void* AllocateAndClear<T>()
        {
            int size = Marshal.SizeOf<T>();

            IntPtr pointer = Marshal.AllocHGlobal(size);

            var bytePointer = (byte*)pointer.ToPointer();

            for (int offset = 0; offset < size; offset++)
            {
                bytePointer[offset] = 0;
            }

            return pointer.ToPointer();
        }

        internal static void Free(void* pointer)
        {
            Marshal.FreeHGlobal(new IntPtr(pointer));
        }

        internal static char* MarshalStringToPointer(string value)
        {
            return (char*)Marshal.StringToHGlobalAnsi(value).ToPointer();
        }

        internal static string MarshalPointerToString(char* pointer)
        {
            return Marshal.PtrToStringAnsi(new IntPtr(pointer));
        }

        internal static string MarshalPointerToString(char* pointer, int length)
        {
            return Marshal.PtrToStringAnsi(new IntPtr(pointer), length);
        }

        internal static byte[] MarshalPointerToArray(byte* pointer, int length)
        {
            var newArray = new byte[length];

            Marshal.Copy(new IntPtr(pointer), newArray, 0, length);

            return newArray;
        }

        internal static float[] MarshalPointerToArray(float* pointer, int length)
        {
            var newArray = new float[length];

            Marshal.Copy(new IntPtr(pointer), newArray, 0, length);

            return newArray;
        }

        internal static uint[] MarshalPointerToArray(uint* pointer, int length)
        {
            var newArray = new uint[length];

            // Marshal.Copy doesn't support uints for some reason...
            for (int index = 0; index < length; index++)
            {
                newArray[index] = *(pointer + length);
            }

            return newArray;
        }

        internal static byte* MarshalArrayToPointer(byte[] value)
        {
            byte* pointer = (byte*)Marshal.AllocHGlobal(value.Length).ToPointer();

            MarshalArrayToPointer(value, value.Length, pointer);

            return pointer;
        }

        internal static float* MarshalArrayToPointer(float[] value)
        {
            float* pointer = (float*)Marshal.AllocHGlobal(value.Length * sizeof(float)).ToPointer();

            MarshalArrayToPointer(value, value.Length, pointer);

            return pointer;
        }

        internal static uint* MarshalArrayToPointer(uint[] value)
        {
            uint* pointer = (uint*)Marshal.AllocHGlobal(value.Length * sizeof(uint)).ToPointer();

            MarshalArrayToPointer(value, value.Length, pointer);

            return pointer;
        }

        internal static void* MarshalArrayToPointer<T>(IEnumerable<T> value, int length)
            where T : struct
        {
            int size = Marshal.SizeOf<T>();

            T[] valueArray = value.ToArray();

            IntPtr pointer = Marshal.AllocHGlobal(length * size);

            for (int index = 0; index < length; index++)
            {
                Marshal.StructureToPtr(valueArray[index], pointer + (size * index), false);
            }

            return pointer.ToPointer();
        }

        internal static void MarshalArrayToPointer(byte[] value, int length, byte* pointer)
        {
            Marshal.Copy(value, 0, new IntPtr(pointer), length);
        }

        internal static void MarshalArrayToPointer(float[] value, int length, float* pointer)
        {
            Marshal.Copy(value, 0, new IntPtr(pointer), length);
        }

        internal static void MarshalArrayToPointer(uint[] value, int length, uint* pointer)
        {
            //Marshal.Copy doesn't support uints for some reason...
            for (int index = 0; index < length; index++)
            {
                *(pointer + length) = value[index];
            }
        }

        internal static void MarshalArrayToPointer(string[] value, int length, char** pointer)
        {
            //Marshal.Copy doesn't support uints for some reason...
            for (int index = 0; index < length; index++)
            {
                *(pointer + length) = MarshalStringToPointer(value[index]);
            }
        }
    }
}
