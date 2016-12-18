using System;

namespace SharpVk.Glfw
{
    public static class InstanceExtensions
    {
        /// <summary>
        /// Create a Surface object for a GLFW3 window.
        /// </summary>
        /// <param name="instance"></param>
        /// <param name="window"></param>
        /// <returns></returns>
        public unsafe static Surface CreateGlfwSurface(this Instance instance, WindowHandle window)
        {
            ulong surfaceHandle;

            Result result = Glfw3.glfwCreateWindowSurface(instance.RawHandle, window, null, out surfaceHandle);

            if (SharpVkException.IsError(result))
            {
                throw SharpVkException.Create(result);
            }
            
            return Surface.CreateFromHandle(instance, surfaceHandle);
        }
    }
}
