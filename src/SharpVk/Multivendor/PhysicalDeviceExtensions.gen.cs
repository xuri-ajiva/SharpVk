// The MIT License (MIT)
// 
// Copyright (c) Andrew Armstrong/FacticiusVir 2017
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.

// This file was automatically generated and should not be edited directly.

using System;

namespace SharpVk.Multivendor
{
    /// <summary>
    /// 
    /// </summary>
    public static class PhysicalDeviceExtensions
    {
        /// <summary>
        /// Release access to an acquired Display.
        /// </summary>
        /// <param name="extendedHandle">
        /// The PhysicalDevice handle to extend.
        /// </param>
        public static unsafe void ReleaseDisplay(this SharpVk.PhysicalDevice extendedHandle, SharpVk.Khronos.Display display)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                commandCache = extendedHandle.commandCache;
                SharpVk.Interop.Multivendor.VkPhysicalDeviceReleaseDisplayDelegate commandDelegate = commandCache.GetCommandDelegate<SharpVk.Interop.Multivendor.VkPhysicalDeviceReleaseDisplayDelegate>("vkReleaseDisplayEXT", "instance");
                Result methodResult = commandDelegate(extendedHandle.handle, display?.handle ?? default(SharpVk.Interop.Khronos.Display));
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Acquire access to a Display using Xlib.
        /// </summary>
        /// <param name="extendedHandle">
        /// The PhysicalDevice handle to extend.
        /// </param>
        /// <param name="dpy">
        /// A connection to the X11 server that currently owns the display.
        /// </param>
        /// <param name="display">
        /// The display the caller wishes to control in Vulkan.
        /// </param>
        public static unsafe void AcquireXlibDisplay(this SharpVk.PhysicalDevice extendedHandle, IntPtr dpy, SharpVk.Khronos.Display display)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                IntPtr* marshalledDpy = default(IntPtr*);
                commandCache = extendedHandle.commandCache;
                marshalledDpy = (IntPtr*)(Interop.HeapUtil.Allocate<IntPtr>());
                *marshalledDpy = dpy;
                SharpVk.Interop.Multivendor.VkPhysicalDeviceAcquireXlibDisplayDelegate commandDelegate = commandCache.GetCommandDelegate<SharpVk.Interop.Multivendor.VkPhysicalDeviceAcquireXlibDisplayDelegate>("vkAcquireXlibDisplayEXT", "instance");
                Result methodResult = commandDelegate(extendedHandle.handle, marshalledDpy, display?.handle ?? default(SharpVk.Interop.Khronos.Display));
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Query the DisplayKHR corresponding to an X11 RandR Output.
        /// </summary>
        /// <param name="extendedHandle">
        /// The PhysicalDevice handle to extend.
        /// </param>
        public static unsafe SharpVk.Khronos.Display GetRandROutputDisplay(this SharpVk.PhysicalDevice extendedHandle, IntPtr dpy, IntPtr rrOutput)
        {
            try
            {
                SharpVk.Khronos.Display result = default(SharpVk.Khronos.Display);
                CommandCache commandCache = default(CommandCache);
                IntPtr* marshalledDpy = default(IntPtr*);
                SharpVk.Interop.Khronos.Display marshalledDisplay = default(SharpVk.Interop.Khronos.Display);
                commandCache = extendedHandle.commandCache;
                marshalledDpy = (IntPtr*)(Interop.HeapUtil.Allocate<IntPtr>());
                *marshalledDpy = dpy;
                SharpVk.Interop.Multivendor.VkPhysicalDeviceGetRandROutputDisplayDelegate commandDelegate = commandCache.GetCommandDelegate<SharpVk.Interop.Multivendor.VkPhysicalDeviceGetRandROutputDisplayDelegate>("vkGetRandROutputDisplayEXT", "instance");
                Result methodResult = commandDelegate(extendedHandle.handle, marshalledDpy, rrOutput, &marshalledDisplay);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = new SharpVk.Khronos.Display(marshalledDisplay);
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Query surface capabilities.
        /// </summary>
        /// <param name="extendedHandle">
        /// The PhysicalDevice handle to extend.
        /// </param>
        public static unsafe SharpVk.Multivendor.SurfaceCapabilities2 GetSurfaceCapabilities2(this SharpVk.PhysicalDevice extendedHandle, SharpVk.Khronos.Surface surface)
        {
            try
            {
                SharpVk.Multivendor.SurfaceCapabilities2 result = default(SharpVk.Multivendor.SurfaceCapabilities2);
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Multivendor.SurfaceCapabilities2 marshalledSurfaceCapabilities = default(SharpVk.Interop.Multivendor.SurfaceCapabilities2);
                commandCache = extendedHandle.commandCache;
                SharpVk.Interop.Multivendor.VkPhysicalDeviceGetSurfaceCapabilities2Delegate commandDelegate = commandCache.GetCommandDelegate<SharpVk.Interop.Multivendor.VkPhysicalDeviceGetSurfaceCapabilities2Delegate>("vkGetPhysicalDeviceSurfaceCapabilities2EXT", "instance");
                Result methodResult = commandDelegate(extendedHandle.handle, surface?.handle ?? default(SharpVk.Interop.Khronos.Surface), &marshalledSurfaceCapabilities);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = SharpVk.Multivendor.SurfaceCapabilities2.MarshalFrom(&marshalledSurfaceCapabilities);
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
    }
}
