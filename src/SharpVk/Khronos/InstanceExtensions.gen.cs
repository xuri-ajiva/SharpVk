// The MIT License (MIT)
// 
// Copyright (c) Andrew Armstrong/FacticiusVir & xuri 2021
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

namespace SharpVk.Khronos
{
    /// <summary>
    /// </summary>
    public static class InstanceExtensions
    {
        /// <summary>
        /// Create a SurfaceKHR structure representing a display plane and
        /// mode.
        /// </summary>
        /// <param name="extendedHandle">
        /// The Instance handle to extend.
        /// </param>
        /// <param name="flags">
        /// Reserved for future use, and must be zero.
        /// </param>
        /// <param name="displayMode">
        /// The mode to use when displaying this surface.
        /// </param>
        /// <param name="planeIndex">
        /// The plane on which this surface appears.
        /// </param>
        /// <param name="planeStackIndex">
        /// The z-order of the plane.
        /// </param>
        /// <param name="transform">
        /// The transform to apply to the images as part of the scanout
        /// operation.
        /// </param>
        /// <param name="globalAlpha">
        /// The global alpha value. This value is ignored if alphaMode is not
        /// VK_DISPLAY_PLANE_ALPHA_GLOBAL_BIT_KHR.
        /// </param>
        /// <param name="alphaMode">
        /// The type of alpha blending to use.
        /// </param>
        /// <param name="imageExtent">
        /// </param>
        /// <param name="allocator">
        /// An optional AllocationCallbacks instance that controls host memory
        /// allocation.
        /// </param>
        public static unsafe Surface CreateDisplayPlaneSurface(this Instance extendedHandle, DisplayMode displayMode, uint planeIndex, uint planeStackIndex, SurfaceTransformFlags transform, float globalAlpha, DisplayPlaneAlphaFlags alphaMode, Extent2D imageExtent, DisplaySurfaceCreateFlags? flags = default, AllocationCallbacks? allocator = default)
        {
            try
            {
                Surface result = default;
                CommandCache commandCache = default;
                SharpVk.Interop.Khronos.DisplaySurfaceCreateInfo* marshalledCreateInfo = default;
                void* vkDisplaySurfaceCreateInfoKHRNextPointer = default;
                SharpVk.Interop.AllocationCallbacks* marshalledAllocator = default;
                SharpVk.Interop.Khronos.Surface marshalledSurface = default;
                commandCache = extendedHandle.commandCache;
                marshalledCreateInfo = (SharpVk.Interop.Khronos.DisplaySurfaceCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.DisplaySurfaceCreateInfo>());
                marshalledCreateInfo->SType = StructureType.DisplaySurfaceCreateInfo;
                marshalledCreateInfo->Next = vkDisplaySurfaceCreateInfoKHRNextPointer;
                if (flags != null)
                {
                    marshalledCreateInfo->Flags = flags.Value;
                }
                else
                {
                    marshalledCreateInfo->Flags = default;
                }
                marshalledCreateInfo->DisplayMode = displayMode?.Handle ?? default;
                marshalledCreateInfo->PlaneIndex = planeIndex;
                marshalledCreateInfo->PlaneStackIndex = planeStackIndex;
                marshalledCreateInfo->Transform = transform;
                marshalledCreateInfo->GlobalAlpha = globalAlpha;
                marshalledCreateInfo->AlphaMode = alphaMode;
                marshalledCreateInfo->ImageExtent = imageExtent;
                if (allocator != null)
                {
                    marshalledAllocator = (SharpVk.Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<SharpVk.Interop.AllocationCallbacks>());
                    allocator.Value.MarshalTo(marshalledAllocator);
                }
                else
                {
                    marshalledAllocator = default;
                }
                SharpVk.Interop.Khronos.VkInstanceCreateDisplayPlaneSurfaceDelegate commandDelegate = commandCache.Cache.vkCreateDisplayPlaneSurfaceKHR;
                Result methodResult = commandDelegate(extendedHandle.Handle, marshalledCreateInfo, marshalledAllocator, &marshalledSurface);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = new Surface(extendedHandle, marshalledSurface);
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Create a SurfaceKHR object for an X11 window, using the Xlib
        /// client-side library.
        /// </summary>
        /// <param name="extendedHandle">
        /// The Instance handle to extend.
        /// </param>
        /// <param name="flags">
        /// Reserved for future use.
        /// </param>
        /// <param name="dpy">
        /// An Xlib Display connection to the X server.
        /// </param>
        /// <param name="window">
        /// An Xlib Window to associate the surface with.
        /// </param>
        /// <param name="allocator">
        /// An optional AllocationCallbacks instance that controls host memory
        /// allocation.
        /// </param>
        public static unsafe Surface CreateXlibSurface(this Instance extendedHandle, IntPtr dpy, IntPtr window, XlibSurfaceCreateFlags? flags = default, AllocationCallbacks? allocator = default)
        {
            try
            {
                Surface result = default;
                CommandCache commandCache = default;
                SharpVk.Interop.Khronos.XlibSurfaceCreateInfo* marshalledCreateInfo = default;
                void* vkXlibSurfaceCreateInfoKHRNextPointer = default;
                SharpVk.Interop.AllocationCallbacks* marshalledAllocator = default;
                SharpVk.Interop.Khronos.Surface marshalledSurface = default;
                commandCache = extendedHandle.commandCache;
                marshalledCreateInfo = (SharpVk.Interop.Khronos.XlibSurfaceCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.XlibSurfaceCreateInfo>());
                marshalledCreateInfo->SType = StructureType.XlibSurfaceCreateInfo;
                marshalledCreateInfo->Next = vkXlibSurfaceCreateInfoKHRNextPointer;
                if (flags != null)
                {
                    marshalledCreateInfo->Flags = flags.Value;
                }
                else
                {
                    marshalledCreateInfo->Flags = default;
                }
                marshalledCreateInfo->Dpy = (IntPtr*)(Interop.HeapUtil.Allocate<IntPtr>());
                *marshalledCreateInfo->Dpy = dpy;
                marshalledCreateInfo->Window = window;
                if (allocator != null)
                {
                    marshalledAllocator = (SharpVk.Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<SharpVk.Interop.AllocationCallbacks>());
                    allocator.Value.MarshalTo(marshalledAllocator);
                }
                else
                {
                    marshalledAllocator = default;
                }
                SharpVk.Interop.Khronos.VkInstanceCreateXlibSurfaceDelegate commandDelegate = commandCache.Cache.vkCreateXlibSurfaceKHR;
                Result methodResult = commandDelegate(extendedHandle.Handle, marshalledCreateInfo, marshalledAllocator, &marshalledSurface);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = new Surface(extendedHandle, marshalledSurface);
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Create a SurfaceKHR object for a X11 window, using the XCB
        /// client-side library.
        /// </summary>
        /// <param name="extendedHandle">
        /// The Instance handle to extend.
        /// </param>
        /// <param name="flags">
        /// Reserved for future use.
        /// </param>
        /// <param name="connection">
        /// An xcb_connection_t to the X server.
        /// </param>
        /// <param name="window">
        /// The xcb_window_t for the X11 window to associate the surface with.
        /// </param>
        /// <param name="allocator">
        /// An optional AllocationCallbacks instance that controls host memory
        /// allocation.
        /// </param>
        public static unsafe Surface CreateXcbSurface(this Instance extendedHandle, IntPtr connection, IntPtr window, XcbSurfaceCreateFlags? flags = default, AllocationCallbacks? allocator = default)
        {
            try
            {
                Surface result = default;
                CommandCache commandCache = default;
                SharpVk.Interop.Khronos.XcbSurfaceCreateInfo* marshalledCreateInfo = default;
                void* vkXcbSurfaceCreateInfoKHRNextPointer = default;
                SharpVk.Interop.AllocationCallbacks* marshalledAllocator = default;
                SharpVk.Interop.Khronos.Surface marshalledSurface = default;
                commandCache = extendedHandle.commandCache;
                marshalledCreateInfo = (SharpVk.Interop.Khronos.XcbSurfaceCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.XcbSurfaceCreateInfo>());
                marshalledCreateInfo->SType = StructureType.XcbSurfaceCreateInfo;
                marshalledCreateInfo->Next = vkXcbSurfaceCreateInfoKHRNextPointer;
                if (flags != null)
                {
                    marshalledCreateInfo->Flags = flags.Value;
                }
                else
                {
                    marshalledCreateInfo->Flags = default;
                }
                marshalledCreateInfo->Connection = (IntPtr*)(Interop.HeapUtil.Allocate<IntPtr>());
                *marshalledCreateInfo->Connection = connection;
                marshalledCreateInfo->Window = window;
                if (allocator != null)
                {
                    marshalledAllocator = (SharpVk.Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<SharpVk.Interop.AllocationCallbacks>());
                    allocator.Value.MarshalTo(marshalledAllocator);
                }
                else
                {
                    marshalledAllocator = default;
                }
                SharpVk.Interop.Khronos.VkInstanceCreateXcbSurfaceDelegate commandDelegate = commandCache.Cache.vkCreateXcbSurfaceKHR;
                Result methodResult = commandDelegate(extendedHandle.Handle, marshalledCreateInfo, marshalledAllocator, &marshalledSurface);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = new Surface(extendedHandle, marshalledSurface);
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Create a SurfaceKHR object for a Wayland window.
        /// </summary>
        /// <param name="extendedHandle">
        /// The Instance handle to extend.
        /// </param>
        /// <param name="flags">
        /// Reserved for future use.
        /// </param>
        /// <param name="display">
        /// display and surface are pointers to the Wayland wl_display and
        /// wl_surface to associate the surface with.
        /// </param>
        /// <param name="surface">
        /// </param>
        /// <param name="allocator">
        /// An optional AllocationCallbacks instance that controls host memory
        /// allocation.
        /// </param>
        public static unsafe Surface CreateWaylandSurface(this Instance extendedHandle, IntPtr display, IntPtr surface, WaylandSurfaceCreateFlags? flags = default, AllocationCallbacks? allocator = default)
        {
            try
            {
                Surface result = default;
                CommandCache commandCache = default;
                SharpVk.Interop.Khronos.WaylandSurfaceCreateInfo* marshalledCreateInfo = default;
                void* vkWaylandSurfaceCreateInfoKHRNextPointer = default;
                SharpVk.Interop.AllocationCallbacks* marshalledAllocator = default;
                SharpVk.Interop.Khronos.Surface marshalledSurface = default;
                commandCache = extendedHandle.commandCache;
                marshalledCreateInfo = (SharpVk.Interop.Khronos.WaylandSurfaceCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.WaylandSurfaceCreateInfo>());
                marshalledCreateInfo->SType = StructureType.WaylandSurfaceCreateInfo;
                marshalledCreateInfo->Next = vkWaylandSurfaceCreateInfoKHRNextPointer;
                if (flags != null)
                {
                    marshalledCreateInfo->Flags = flags.Value;
                }
                else
                {
                    marshalledCreateInfo->Flags = default;
                }
                marshalledCreateInfo->Display = (IntPtr*)(Interop.HeapUtil.Allocate<IntPtr>());
                *marshalledCreateInfo->Display = display;
                marshalledCreateInfo->Surface = (IntPtr*)(Interop.HeapUtil.Allocate<IntPtr>());
                *marshalledCreateInfo->Surface = surface;
                if (allocator != null)
                {
                    marshalledAllocator = (SharpVk.Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<SharpVk.Interop.AllocationCallbacks>());
                    allocator.Value.MarshalTo(marshalledAllocator);
                }
                else
                {
                    marshalledAllocator = default;
                }
                SharpVk.Interop.Khronos.VkInstanceCreateWaylandSurfaceDelegate commandDelegate = commandCache.Cache.vkCreateWaylandSurfaceKHR;
                Result methodResult = commandDelegate(extendedHandle.Handle, marshalledCreateInfo, marshalledAllocator, &marshalledSurface);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = new Surface(extendedHandle, marshalledSurface);
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Create a SurfaceKHR object for an Android native window.
        /// </summary>
        /// <param name="extendedHandle">
        /// The Instance handle to extend.
        /// </param>
        /// <param name="flags">
        /// Reserved for future use.
        /// </param>
        /// <param name="window">
        /// A pointer to the ANativeWindow to associate the surface with.
        /// </param>
        /// <param name="allocator">
        /// An optional AllocationCallbacks instance that controls host memory
        /// allocation.
        /// </param>
        public static unsafe Surface CreateAndroidSurface(this Instance extendedHandle, IntPtr window, AndroidSurfaceCreateFlags? flags = default, AllocationCallbacks? allocator = default)
        {
            try
            {
                Surface result = default;
                CommandCache commandCache = default;
                SharpVk.Interop.Khronos.AndroidSurfaceCreateInfo* marshalledCreateInfo = default;
                void* vkAndroidSurfaceCreateInfoKHRNextPointer = default;
                SharpVk.Interop.AllocationCallbacks* marshalledAllocator = default;
                SharpVk.Interop.Khronos.Surface marshalledSurface = default;
                commandCache = extendedHandle.commandCache;
                marshalledCreateInfo = (SharpVk.Interop.Khronos.AndroidSurfaceCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.AndroidSurfaceCreateInfo>());
                marshalledCreateInfo->SType = StructureType.AndroidSurfaceCreateInfo;
                marshalledCreateInfo->Next = vkAndroidSurfaceCreateInfoKHRNextPointer;
                if (flags != null)
                {
                    marshalledCreateInfo->Flags = flags.Value;
                }
                else
                {
                    marshalledCreateInfo->Flags = default;
                }
                marshalledCreateInfo->Window = (IntPtr*)(Interop.HeapUtil.Allocate<IntPtr>());
                *marshalledCreateInfo->Window = window;
                if (allocator != null)
                {
                    marshalledAllocator = (SharpVk.Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<SharpVk.Interop.AllocationCallbacks>());
                    allocator.Value.MarshalTo(marshalledAllocator);
                }
                else
                {
                    marshalledAllocator = default;
                }
                SharpVk.Interop.Khronos.VkInstanceCreateAndroidSurfaceDelegate commandDelegate = commandCache.Cache.vkCreateAndroidSurfaceKHR;
                Result methodResult = commandDelegate(extendedHandle.Handle, marshalledCreateInfo, marshalledAllocator, &marshalledSurface);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = new Surface(extendedHandle, marshalledSurface);
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Create a SurfaceKHR object for an Win32 native window.
        /// </summary>
        /// <param name="extendedHandle">
        /// The Instance handle to extend.
        /// </param>
        /// <param name="flags">
        /// Reserved for future use.
        /// </param>
        /// <param name="hinstance">
        /// Win32 HINSTANCE for the window to associate the surface with.
        /// </param>
        /// <param name="hwnd">
        /// Win32 HWND for the window to associate the surface with.
        /// </param>
        /// <param name="allocator">
        /// An optional AllocationCallbacks instance that controls host memory
        /// allocation.
        /// </param>
        public static unsafe Surface CreateWin32Surface(this Instance extendedHandle, IntPtr hinstance, IntPtr hwnd, Win32SurfaceCreateFlags? flags = default, AllocationCallbacks? allocator = default)
        {
            try
            {
                Surface result = default;
                CommandCache commandCache = default;
                SharpVk.Interop.Khronos.Win32SurfaceCreateInfo* marshalledCreateInfo = default;
                void* vkWin32SurfaceCreateInfoKHRNextPointer = default;
                SharpVk.Interop.AllocationCallbacks* marshalledAllocator = default;
                SharpVk.Interop.Khronos.Surface marshalledSurface = default;
                commandCache = extendedHandle.commandCache;
                marshalledCreateInfo = (SharpVk.Interop.Khronos.Win32SurfaceCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.Win32SurfaceCreateInfo>());
                marshalledCreateInfo->SType = StructureType.Win32SurfaceCreateInfo;
                marshalledCreateInfo->Next = vkWin32SurfaceCreateInfoKHRNextPointer;
                if (flags != null)
                {
                    marshalledCreateInfo->Flags = flags.Value;
                }
                else
                {
                    marshalledCreateInfo->Flags = default;
                }
                marshalledCreateInfo->Hinstance = hinstance;
                marshalledCreateInfo->Hwnd = hwnd;
                if (allocator != null)
                {
                    marshalledAllocator = (SharpVk.Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<SharpVk.Interop.AllocationCallbacks>());
                    allocator.Value.MarshalTo(marshalledAllocator);
                }
                else
                {
                    marshalledAllocator = default;
                }
                SharpVk.Interop.Khronos.VkInstanceCreateWin32SurfaceDelegate commandDelegate = commandCache.Cache.vkCreateWin32SurfaceKHR;
                Result methodResult = commandDelegate(extendedHandle.Handle, marshalledCreateInfo, marshalledAllocator, &marshalledSurface);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = new Surface(extendedHandle, marshalledSurface);
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
    }
}
