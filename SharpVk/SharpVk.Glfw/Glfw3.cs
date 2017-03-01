using System;
using System.Runtime.InteropServices;

namespace SharpVk.Glfw
{
    public unsafe static class Glfw3
    {
        public const string GlfwDll = "glfw3.dll";

        [DllImport(GlfwDll, CallingConvention = CallingConvention.Cdecl)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool glfwInit();

        [DllImport(GlfwDll, CallingConvention = CallingConvention.Cdecl)]
        public static extern void glfwTerminate();

        [DllImport(GlfwDll, CallingConvention = CallingConvention.Cdecl)]
        public static extern void glfwGetVersion(out int major, out int minor, out int rev);

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

        [DllImport(GlfwDll, CallingConvention = CallingConvention.Cdecl)]
        public static extern WindowSizeDelegate glfwSetWindowSizeCallback(WindowHandle window, WindowSizeDelegate callback);

        [DllImport(GlfwDll, CallingConvention = CallingConvention.Cdecl)]
        public static extern ErrorDelegate glfwSetErrorCallback(ErrorDelegate callback);

        [DllImport(GlfwDll, CallingConvention = CallingConvention.Cdecl)]
        public static extern MonitorHandle* glfwGetMonitors(out int count);

        [DllImport(GlfwDll, CallingConvention = CallingConvention.Cdecl)]
        public static extern MonitorHandle glfwGetPrimaryMonitor();

        [DllImport(GlfwDll, CallingConvention = CallingConvention.Cdecl)]
        public static extern void glfwGetMonitorPos(MonitorHandle monitor, out int xPos, out int yPos);

        [DllImport(GlfwDll, CallingConvention = CallingConvention.Cdecl)]
        public static extern void glfwGetMonitorPhysicalSize(MonitorHandle monitor, out int widthMm, out int heightMm);

        [DllImport(GlfwDll, CallingConvention = CallingConvention.Cdecl)]
        [return: MarshalAs(UnmanagedType.LPStr)]
        public static extern string glfwGetMonitorName(MonitorHandle monitor);

        [DllImport(GlfwDll, CallingConvention = CallingConvention.Cdecl)]
        public static extern MonitorEventDelegate glfwSetMonitorCallback(MonitorEventDelegate callback);

        [DllImport(GlfwDll, CallingConvention = CallingConvention.Cdecl)]
        public static extern VideoMode* glfwGetVideoModes(MonitorHandle monitor, out int count);

        [DllImport(GlfwDll, CallingConvention = CallingConvention.Cdecl)]
        public static extern VideoModePointer glfwGetVideoMode(MonitorHandle monitor);

        [DllImport(GlfwDll, CallingConvention = CallingConvention.Cdecl)]
        public static extern void glfwSetGamma(MonitorHandle monitor, float gamma);

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

        public static MonitorHandle[] glfwGetMonitors()
        {
            int count;

            MonitorHandle* monitorPointer = glfwGetMonitors(out count);

            var result = new MonitorHandle[count];

            for (int i = 0; i < count; i++)
            {
                result[i] = monitorPointer[i];
            }

            return result;
        }

        public static VideoMode[] glfwGetVideoModes(MonitorHandle monitor)
        {
            int count;

            VideoMode* videoModePointer = glfwGetVideoModes(monitor, out count);

            var result = new VideoMode[count];

            for (int i = 0; i < count; i++)
            {
                result[i] = videoModePointer[i];
            }

            return result;
        }
    }
}
