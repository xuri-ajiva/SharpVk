using System;
using System.Runtime.InteropServices;

namespace SharpVk.Glfw
{
    public unsafe static class Glfw3
    {
        public const string GlfwDll = "glfw3.dll";

        [DllImport(GlfwDll, CallingConvention = CallingConvention.Cdecl)]
        public static extern int glfwInit();

        [DllImport(GlfwDll, CallingConvention = CallingConvention.Cdecl)]
        public static extern void glfwTerminate();

        [DllImport(GlfwDll, CallingConvention = CallingConvention.Cdecl)]
        public static extern WindowHandle glfwCreateWindow(int width, int height, [MarshalAs(UnmanagedType.LPStr)] string title, IntPtr monitor, IntPtr share);

        [DllImport(GlfwDll, CallingConvention = CallingConvention.Cdecl)]
        public static extern void glfwPollEvents();

        [DllImport(GlfwDll, CallingConvention = CallingConvention.Cdecl)]
        public static extern void glfwWindowHint(int target, int hint);

        [DllImport(GlfwDll, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool glfwWindowShouldClose(WindowHandle window);

        [DllImport(GlfwDll, CallingConvention = CallingConvention.Cdecl)]
        public static extern Result glfwCreateWindowSurface(Interop.Instance instance, WindowHandle window, Interop.AllocationCallbacks* pAllocator, out ulong surface);

        [DllImport(GlfwDll, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte** glfwGetRequiredInstanceExtensions(out int count);

        public static string[] glfwGetRequiredInstanceExtensions()
        {
            int count = 0;

            byte** namePointer = glfwGetRequiredInstanceExtensions(out count);

            var result = new string[count];

            for (int nameIndex = 0; nameIndex < count; nameIndex++)
            {
                result[nameIndex] = Marshal.PtrToStringAnsi(new IntPtr(namePointer[nameIndex]));
            }

            return result;
        }
    }
}
