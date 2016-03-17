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
    }
}
