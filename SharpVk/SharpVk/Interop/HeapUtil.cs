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
    }
}
