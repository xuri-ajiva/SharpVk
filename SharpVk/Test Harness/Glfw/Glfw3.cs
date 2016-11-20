using System;
using System.Runtime.InteropServices;

namespace SharpVk.Glfw
{
    public static class Glfw3
    {
        public const string GlfwDll = "glfw3.dll";
        
        [DllImport(GlfwDll, CallingConvention = CallingConvention.Cdecl)]
        public static extern int glfwInit();

        [DllImport(GlfwDll, CallingConvention = CallingConvention.Cdecl)]
        public static extern void glfwTerminate();

        [DllImport(GlfwDll, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr glfwCreateWindow(int width, int height, [MarshalAs(UnmanagedType.LPStr)] string title, IntPtr monitor, IntPtr share);

        [DllImport(GlfwDll, CallingConvention = CallingConvention.Cdecl)]
        public static extern void glfwPollEvents();

        [DllImport(GlfwDll, CallingConvention = CallingConvention.Cdecl)]
        public static extern void glfwWindowHint(int target, int hint);

        [DllImport(GlfwDll, CallingConvention = CallingConvention.Cdecl)]
        public static extern int glfwWindowShouldClose(IntPtr window);

        [DllImport(GlfwDll, CallingConvention = CallingConvention.Cdecl)]
        public static extern Result glfwCreateWindowSurface(IntPtr instance, IntPtr window, IntPtr pAllocator, ref ulong surface);
    }
}
