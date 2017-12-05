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

namespace SharpVk.Khronos
{
    /// <summary>
    /// 
    /// </summary>
    public static class PhysicalDeviceExtensions
    {
        /// <summary>
        /// Query if presentation is supported.
        /// </summary>
        /// <param name="extendedHandle">
        /// The PhysicalDevice handle to extend.
        /// </param>
        public static unsafe bool GetSurfaceSupport(this SharpVk.PhysicalDevice extendedHandle, uint queueFamilyIndex, SharpVk.Khronos.Surface surface)
        {
            try
            {
                bool result = default(bool);
                CommandCache commandCache = default(CommandCache);
                Bool32 marshalledSupported = default(Bool32);
                commandCache = extendedHandle.commandCache;
                SharpVk.Interop.Khronos.VkPhysicalDeviceGetSurfaceSupportDelegate commandDelegate = commandCache.GetCommandDelegate<SharpVk.Interop.Khronos.VkPhysicalDeviceGetSurfaceSupportDelegate>("vkGetPhysicalDeviceSurfaceSupportKHR", "instance");
                Result methodResult = commandDelegate(extendedHandle.handle, queueFamilyIndex, surface?.handle ?? default(SharpVk.Interop.Khronos.Surface), &marshalledSupported);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = marshalledSupported;
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
        public static unsafe SharpVk.Khronos.SurfaceCapabilities GetSurfaceCapabilities(this SharpVk.PhysicalDevice extendedHandle, SharpVk.Khronos.Surface surface)
        {
            try
            {
                SharpVk.Khronos.SurfaceCapabilities result = default(SharpVk.Khronos.SurfaceCapabilities);
                CommandCache commandCache = default(CommandCache);
                SharpVk.Khronos.SurfaceCapabilities marshalledSurfaceCapabilities = default(SharpVk.Khronos.SurfaceCapabilities);
                commandCache = extendedHandle.commandCache;
                SharpVk.Interop.Khronos.VkPhysicalDeviceGetSurfaceCapabilitiesDelegate commandDelegate = commandCache.GetCommandDelegate<SharpVk.Interop.Khronos.VkPhysicalDeviceGetSurfaceCapabilitiesDelegate>("vkGetPhysicalDeviceSurfaceCapabilitiesKHR", "instance");
                Result methodResult = commandDelegate(extendedHandle.handle, surface?.handle ?? default(SharpVk.Interop.Khronos.Surface), &marshalledSurfaceCapabilities);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = marshalledSurfaceCapabilities;
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Query color formats supported by surface.
        /// </summary>
        /// <param name="extendedHandle">
        /// The PhysicalDevice handle to extend.
        /// </param>
        public static unsafe SharpVk.Khronos.SurfaceFormat[] GetSurfaceFormats(this SharpVk.PhysicalDevice extendedHandle, SharpVk.Khronos.Surface surface)
        {
            try
            {
                SharpVk.Khronos.SurfaceFormat[] result = default(SharpVk.Khronos.SurfaceFormat[]);
                uint surfaceFormatCount = default(uint);
                CommandCache commandCache = default(CommandCache);
                SharpVk.Khronos.SurfaceFormat* marshalledSurfaceFormats = default(SharpVk.Khronos.SurfaceFormat*);
                commandCache = extendedHandle.commandCache;
                SharpVk.Interop.Khronos.VkPhysicalDeviceGetSurfaceFormatsDelegate commandDelegate = commandCache.GetCommandDelegate<SharpVk.Interop.Khronos.VkPhysicalDeviceGetSurfaceFormatsDelegate>("vkGetPhysicalDeviceSurfaceFormatsKHR", "instance");
                Result methodResult = commandDelegate(extendedHandle.handle, surface?.handle ?? default(SharpVk.Interop.Khronos.Surface), &surfaceFormatCount, marshalledSurfaceFormats);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                marshalledSurfaceFormats = (SharpVk.Khronos.SurfaceFormat*)(Interop.HeapUtil.Allocate<SharpVk.Khronos.SurfaceFormat>((uint)(surfaceFormatCount)));
                commandDelegate(extendedHandle.handle, surface?.handle ?? default(SharpVk.Interop.Khronos.Surface), &surfaceFormatCount, marshalledSurfaceFormats);
                if (marshalledSurfaceFormats != null)
                {
                    var fieldPointer = new SharpVk.Khronos.SurfaceFormat[(uint)(surfaceFormatCount)];
                    for(int index = 0; index < (uint)(surfaceFormatCount); index++)
                    {
                        fieldPointer[index] = marshalledSurfaceFormats[index];
                    }
                    result = fieldPointer;
                }
                else
                {
                    result = null;
                }
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Query supported presentation modes.
        /// </summary>
        /// <param name="extendedHandle">
        /// The PhysicalDevice handle to extend.
        /// </param>
        public static unsafe SharpVk.Khronos.PresentMode[] GetSurfacePresentModes(this SharpVk.PhysicalDevice extendedHandle, SharpVk.Khronos.Surface surface)
        {
            try
            {
                SharpVk.Khronos.PresentMode[] result = default(SharpVk.Khronos.PresentMode[]);
                uint presentModeCount = default(uint);
                CommandCache commandCache = default(CommandCache);
                SharpVk.Khronos.PresentMode* marshalledPresentModes = default(SharpVk.Khronos.PresentMode*);
                commandCache = extendedHandle.commandCache;
                SharpVk.Interop.Khronos.VkPhysicalDeviceGetSurfacePresentModesDelegate commandDelegate = commandCache.GetCommandDelegate<SharpVk.Interop.Khronos.VkPhysicalDeviceGetSurfacePresentModesDelegate>("vkGetPhysicalDeviceSurfacePresentModesKHR", "instance");
                Result methodResult = commandDelegate(extendedHandle.handle, surface?.handle ?? default(SharpVk.Interop.Khronos.Surface), &presentModeCount, marshalledPresentModes);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                marshalledPresentModes = (SharpVk.Khronos.PresentMode*)(Interop.HeapUtil.Allocate<SharpVk.Khronos.PresentMode>((uint)(presentModeCount)));
                commandDelegate(extendedHandle.handle, surface?.handle ?? default(SharpVk.Interop.Khronos.Surface), &presentModeCount, marshalledPresentModes);
                if (marshalledPresentModes != null)
                {
                    var fieldPointer = new SharpVk.Khronos.PresentMode[(uint)(presentModeCount)];
                    for(int index = 0; index < (uint)(presentModeCount); index++)
                    {
                        fieldPointer[index] = marshalledPresentModes[index];
                    }
                    result = fieldPointer;
                }
                else
                {
                    result = null;
                }
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Query information about the available displays.
        /// </summary>
        /// <param name="extendedHandle">
        /// The PhysicalDevice handle to extend.
        /// </param>
        public static unsafe SharpVk.Khronos.DisplayProperties[] GetDisplayProperties(this SharpVk.PhysicalDevice extendedHandle)
        {
            try
            {
                SharpVk.Khronos.DisplayProperties[] result = default(SharpVk.Khronos.DisplayProperties[]);
                uint propertyCount = default(uint);
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Khronos.DisplayProperties* marshalledProperties = default(SharpVk.Interop.Khronos.DisplayProperties*);
                commandCache = extendedHandle.commandCache;
                SharpVk.Interop.Khronos.VkPhysicalDeviceGetDisplayPropertiesDelegate commandDelegate = commandCache.GetCommandDelegate<SharpVk.Interop.Khronos.VkPhysicalDeviceGetDisplayPropertiesDelegate>("vkGetPhysicalDeviceDisplayPropertiesKHR", "instance");
                Result methodResult = commandDelegate(extendedHandle.handle, &propertyCount, marshalledProperties);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                marshalledProperties = (SharpVk.Interop.Khronos.DisplayProperties*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.DisplayProperties>((uint)(propertyCount)));
                commandDelegate(extendedHandle.handle, &propertyCount, marshalledProperties);
                if (marshalledProperties != null)
                {
                    var fieldPointer = new SharpVk.Khronos.DisplayProperties[(uint)(propertyCount)];
                    for(int index = 0; index < (uint)(propertyCount); index++)
                    {
                        fieldPointer[index] = SharpVk.Khronos.DisplayProperties.MarshalFrom(&marshalledProperties[index]);
                    }
                    result = fieldPointer;
                }
                else
                {
                    result = null;
                }
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Query the plane properties.
        /// </summary>
        /// <param name="extendedHandle">
        /// The PhysicalDevice handle to extend.
        /// </param>
        public static unsafe SharpVk.Khronos.DisplayPlaneProperties[] GetDisplayPlaneProperties(this SharpVk.PhysicalDevice extendedHandle)
        {
            try
            {
                SharpVk.Khronos.DisplayPlaneProperties[] result = default(SharpVk.Khronos.DisplayPlaneProperties[]);
                uint propertyCount = default(uint);
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Khronos.DisplayPlaneProperties* marshalledProperties = default(SharpVk.Interop.Khronos.DisplayPlaneProperties*);
                commandCache = extendedHandle.commandCache;
                SharpVk.Interop.Khronos.VkPhysicalDeviceGetDisplayPlanePropertiesDelegate commandDelegate = commandCache.GetCommandDelegate<SharpVk.Interop.Khronos.VkPhysicalDeviceGetDisplayPlanePropertiesDelegate>("vkGetPhysicalDeviceDisplayPlanePropertiesKHR", "instance");
                Result methodResult = commandDelegate(extendedHandle.handle, &propertyCount, marshalledProperties);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                marshalledProperties = (SharpVk.Interop.Khronos.DisplayPlaneProperties*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.DisplayPlaneProperties>((uint)(propertyCount)));
                commandDelegate(extendedHandle.handle, &propertyCount, marshalledProperties);
                if (marshalledProperties != null)
                {
                    var fieldPointer = new SharpVk.Khronos.DisplayPlaneProperties[(uint)(propertyCount)];
                    for(int index = 0; index < (uint)(propertyCount); index++)
                    {
                        fieldPointer[index] = SharpVk.Khronos.DisplayPlaneProperties.MarshalFrom(&marshalledProperties[index]);
                    }
                    result = fieldPointer;
                }
                else
                {
                    result = null;
                }
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Query the list of displays a plane supports.
        /// </summary>
        /// <param name="extendedHandle">
        /// The PhysicalDevice handle to extend.
        /// </param>
        public static unsafe SharpVk.Khronos.Display[] GetDisplayPlaneSupportedDisplays(this SharpVk.PhysicalDevice extendedHandle, uint planeIndex)
        {
            try
            {
                SharpVk.Khronos.Display[] result = default(SharpVk.Khronos.Display[]);
                uint displayCount = default(uint);
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Khronos.Display* marshalledDisplays = default(SharpVk.Interop.Khronos.Display*);
                commandCache = extendedHandle.commandCache;
                SharpVk.Interop.Khronos.VkPhysicalDeviceGetDisplayPlaneSupportedDisplaysDelegate commandDelegate = commandCache.GetCommandDelegate<SharpVk.Interop.Khronos.VkPhysicalDeviceGetDisplayPlaneSupportedDisplaysDelegate>("vkGetDisplayPlaneSupportedDisplaysKHR", "instance");
                Result methodResult = commandDelegate(extendedHandle.handle, planeIndex, &displayCount, marshalledDisplays);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                marshalledDisplays = (SharpVk.Interop.Khronos.Display*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.Display>((uint)(displayCount)));
                commandDelegate(extendedHandle.handle, planeIndex, &displayCount, marshalledDisplays);
                if (marshalledDisplays != null)
                {
                    var fieldPointer = new SharpVk.Khronos.Display[(uint)(displayCount)];
                    for(int index = 0; index < (uint)(displayCount); index++)
                    {
                        fieldPointer[index] = new SharpVk.Khronos.Display(marshalledDisplays[index]);
                    }
                    result = fieldPointer;
                }
                else
                {
                    result = null;
                }
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Query the set of mode properties supported by the display.
        /// </summary>
        /// <param name="extendedHandle">
        /// The PhysicalDevice handle to extend.
        /// </param>
        public static unsafe SharpVk.Khronos.DisplayModeProperties[] GetDisplayModeProperties(this SharpVk.PhysicalDevice extendedHandle, SharpVk.Khronos.Display display)
        {
            try
            {
                SharpVk.Khronos.DisplayModeProperties[] result = default(SharpVk.Khronos.DisplayModeProperties[]);
                uint propertyCount = default(uint);
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Khronos.DisplayModeProperties* marshalledProperties = default(SharpVk.Interop.Khronos.DisplayModeProperties*);
                commandCache = extendedHandle.commandCache;
                SharpVk.Interop.Khronos.VkPhysicalDeviceGetDisplayModePropertiesDelegate commandDelegate = commandCache.GetCommandDelegate<SharpVk.Interop.Khronos.VkPhysicalDeviceGetDisplayModePropertiesDelegate>("vkGetDisplayModePropertiesKHR", "instance");
                Result methodResult = commandDelegate(extendedHandle.handle, display?.handle ?? default(SharpVk.Interop.Khronos.Display), &propertyCount, marshalledProperties);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                marshalledProperties = (SharpVk.Interop.Khronos.DisplayModeProperties*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.DisplayModeProperties>((uint)(propertyCount)));
                commandDelegate(extendedHandle.handle, display?.handle ?? default(SharpVk.Interop.Khronos.Display), &propertyCount, marshalledProperties);
                if (marshalledProperties != null)
                {
                    var fieldPointer = new SharpVk.Khronos.DisplayModeProperties[(uint)(propertyCount)];
                    for(int index = 0; index < (uint)(propertyCount); index++)
                    {
                        fieldPointer[index] = SharpVk.Khronos.DisplayModeProperties.MarshalFrom(&marshalledProperties[index]);
                    }
                    result = fieldPointer;
                }
                else
                {
                    result = null;
                }
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Create a display mode.
        /// </summary>
        /// <param name="extendedHandle">
        /// The PhysicalDevice handle to extend.
        /// </param>
        /// <param name="flags">
        /// Reserved for future use, and must be zero.
        /// </param>
        /// <param name="parameters">
        /// A DisplayModeParametersKHR structure describing the display
        /// parameters to use in creating the new mode. If the parameters are
        /// not compatible with the specified display, the implementation must
        /// return Result.ErrorINITIALIZATION_FAILED.
        /// </param>
        /// <param name="allocator">
        /// An optional AllocationCallbacks instance that controls host memory
        /// allocation.
        /// </param>
        public static unsafe SharpVk.Khronos.DisplayMode CreateDisplayMode(this SharpVk.PhysicalDevice extendedHandle, SharpVk.Khronos.Display display, SharpVk.Khronos.DisplayModeParameters parameters, SharpVk.Khronos.DisplayModeCreateFlags? flags = default(SharpVk.Khronos.DisplayModeCreateFlags?), SharpVk.AllocationCallbacks? allocator = default(SharpVk.AllocationCallbacks?))
        {
            try
            {
                SharpVk.Khronos.DisplayMode result = default(SharpVk.Khronos.DisplayMode);
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Khronos.DisplayModeCreateInfo* marshalledCreateInfo = default(SharpVk.Interop.Khronos.DisplayModeCreateInfo*);
                void* nextPointer = default(void*);
                SharpVk.Interop.AllocationCallbacks* marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                SharpVk.Interop.Khronos.DisplayMode marshalledMode = default(SharpVk.Interop.Khronos.DisplayMode);
                commandCache = extendedHandle.commandCache;
                marshalledCreateInfo = (SharpVk.Interop.Khronos.DisplayModeCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.DisplayModeCreateInfo>());
                marshalledCreateInfo->SType = StructureType.DisplayModeCreateInfo;
                marshalledCreateInfo->Next = nextPointer;
                if (flags != null)
                {
                    marshalledCreateInfo->Flags = flags.Value;
                }
                else
                {
                    marshalledCreateInfo->Flags = default(SharpVk.Khronos.DisplayModeCreateFlags);
                }
                marshalledCreateInfo->Parameters = parameters;
                if (allocator != null)
                {
                    marshalledAllocator = (SharpVk.Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<SharpVk.Interop.AllocationCallbacks>());
                    allocator.Value.MarshalTo(marshalledAllocator);
                }
                else
                {
                    marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                }
                SharpVk.Interop.Khronos.VkPhysicalDeviceCreateDisplayModeDelegate commandDelegate = commandCache.GetCommandDelegate<SharpVk.Interop.Khronos.VkPhysicalDeviceCreateDisplayModeDelegate>("vkCreateDisplayModeKHR", "instance");
                Result methodResult = commandDelegate(extendedHandle.handle, display?.handle ?? default(SharpVk.Interop.Khronos.Display), marshalledCreateInfo, marshalledAllocator, &marshalledMode);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = new SharpVk.Khronos.DisplayMode(extendedHandle, marshalledMode);
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Query physical device for presentation to X11 server using Xlib.
        /// </summary>
        /// <param name="extendedHandle">
        /// The PhysicalDevice handle to extend.
        /// </param>
        public static unsafe void GetXlibPresentationSupport(this SharpVk.PhysicalDevice extendedHandle, uint queueFamilyIndex, IntPtr dpy, IntPtr visualID)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                IntPtr* marshalledDpy = default(IntPtr*);
                commandCache = extendedHandle.commandCache;
                marshalledDpy = (IntPtr*)(Interop.HeapUtil.Allocate<IntPtr>());
                *marshalledDpy = dpy;
                SharpVk.Interop.Khronos.VkPhysicalDeviceGetXlibPresentationSupportDelegate commandDelegate = commandCache.GetCommandDelegate<SharpVk.Interop.Khronos.VkPhysicalDeviceGetXlibPresentationSupportDelegate>("vkGetPhysicalDeviceXlibPresentationSupportKHR", "instance");
                commandDelegate(extendedHandle.handle, queueFamilyIndex, marshalledDpy, visualID);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Query physical device for presentation to X11 server using XCB.
        /// </summary>
        /// <param name="extendedHandle">
        /// The PhysicalDevice handle to extend.
        /// </param>
        public static unsafe void GetXcbPresentationSupport(this SharpVk.PhysicalDevice extendedHandle, uint queueFamilyIndex, IntPtr connection, IntPtr visualId)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                IntPtr* marshalledConnection = default(IntPtr*);
                commandCache = extendedHandle.commandCache;
                marshalledConnection = (IntPtr*)(Interop.HeapUtil.Allocate<IntPtr>());
                *marshalledConnection = connection;
                SharpVk.Interop.Khronos.VkPhysicalDeviceGetXcbPresentationSupportDelegate commandDelegate = commandCache.GetCommandDelegate<SharpVk.Interop.Khronos.VkPhysicalDeviceGetXcbPresentationSupportDelegate>("vkGetPhysicalDeviceXcbPresentationSupportKHR", "instance");
                commandDelegate(extendedHandle.handle, queueFamilyIndex, marshalledConnection, visualId);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Query physical device for presentation to Wayland.
        /// </summary>
        /// <param name="extendedHandle">
        /// The PhysicalDevice handle to extend.
        /// </param>
        public static unsafe void GetWaylandPresentationSupport(this SharpVk.PhysicalDevice extendedHandle, uint queueFamilyIndex, IntPtr display)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                commandCache = extendedHandle.commandCache;
                SharpVk.Interop.Khronos.VkPhysicalDeviceGetWaylandPresentationSupportDelegate commandDelegate = commandCache.GetCommandDelegate<SharpVk.Interop.Khronos.VkPhysicalDeviceGetWaylandPresentationSupportDelegate>("vkGetPhysicalDeviceWaylandPresentationSupportKHR", "instance");
                commandDelegate(extendedHandle.handle, queueFamilyIndex, display);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Query physical device for presentation to Mir.
        /// </summary>
        /// <param name="extendedHandle">
        /// The PhysicalDevice handle to extend.
        /// </param>
        public static unsafe void GetMirPresentationSupport(this SharpVk.PhysicalDevice extendedHandle, uint queueFamilyIndex, IntPtr connection)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                IntPtr* marshalledConnection = default(IntPtr*);
                commandCache = extendedHandle.commandCache;
                marshalledConnection = (IntPtr*)(Interop.HeapUtil.Allocate<IntPtr>());
                *marshalledConnection = connection;
                SharpVk.Interop.Khronos.VkPhysicalDeviceGetMirPresentationSupportDelegate commandDelegate = commandCache.GetCommandDelegate<SharpVk.Interop.Khronos.VkPhysicalDeviceGetMirPresentationSupportDelegate>("vkGetPhysicalDeviceMirPresentationSupportKHR", "instance");
                commandDelegate(extendedHandle.handle, queueFamilyIndex, marshalledConnection);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Query queue family support for presentation on a Win32 display.
        /// </summary>
        /// <param name="extendedHandle">
        /// The PhysicalDevice handle to extend.
        /// </param>
        public static unsafe void GetWin32PresentationSupport(this SharpVk.PhysicalDevice extendedHandle, uint queueFamilyIndex)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                commandCache = extendedHandle.commandCache;
                SharpVk.Interop.Khronos.VkPhysicalDeviceGetWin32PresentationSupportDelegate commandDelegate = commandCache.GetCommandDelegate<SharpVk.Interop.Khronos.VkPhysicalDeviceGetWin32PresentationSupportDelegate>("vkGetPhysicalDeviceWin32PresentationSupportKHR", "instance");
                commandDelegate(extendedHandle.handle, queueFamilyIndex);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Reports capabilities of a physical device.
        /// </summary>
        /// <param name="extendedHandle">
        /// The PhysicalDevice handle to extend.
        /// </param>
        public static unsafe SharpVk.Khronos.PhysicalDeviceFeatures2 GetFeatures2(this SharpVk.PhysicalDevice extendedHandle)
        {
            try
            {
                SharpVk.Khronos.PhysicalDeviceFeatures2 result = default(SharpVk.Khronos.PhysicalDeviceFeatures2);
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Khronos.PhysicalDeviceFeatures2 marshalledFeatures = default(SharpVk.Interop.Khronos.PhysicalDeviceFeatures2);
                commandCache = extendedHandle.commandCache;
                SharpVk.Interop.Khronos.VkPhysicalDeviceGetFeatures2Delegate commandDelegate = commandCache.GetCommandDelegate<SharpVk.Interop.Khronos.VkPhysicalDeviceGetFeatures2Delegate>("vkGetPhysicalDeviceFeatures2KHR", "instance");
                commandDelegate(extendedHandle.handle, &marshalledFeatures);
                result = SharpVk.Khronos.PhysicalDeviceFeatures2.MarshalFrom(&marshalledFeatures);
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Returns properties of a physical device.
        /// </summary>
        /// <param name="extendedHandle">
        /// The PhysicalDevice handle to extend.
        /// </param>
        public static unsafe SharpVk.Khronos.PhysicalDeviceProperties2 GetProperties2(this SharpVk.PhysicalDevice extendedHandle)
        {
            try
            {
                SharpVk.Khronos.PhysicalDeviceProperties2 result = default(SharpVk.Khronos.PhysicalDeviceProperties2);
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Khronos.PhysicalDeviceProperties2 marshalledProperties = default(SharpVk.Interop.Khronos.PhysicalDeviceProperties2);
                commandCache = extendedHandle.commandCache;
                SharpVk.Interop.Khronos.VkPhysicalDeviceGetProperties2Delegate commandDelegate = commandCache.GetCommandDelegate<SharpVk.Interop.Khronos.VkPhysicalDeviceGetProperties2Delegate>("vkGetPhysicalDeviceProperties2KHR", "instance");
                commandDelegate(extendedHandle.handle, &marshalledProperties);
                result = SharpVk.Khronos.PhysicalDeviceProperties2.MarshalFrom(&marshalledProperties);
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Lists physical device's format capabilities.
        /// </summary>
        /// <param name="extendedHandle">
        /// The PhysicalDevice handle to extend.
        /// </param>
        public static unsafe SharpVk.Khronos.FormatProperties2 GetFormatProperties2(this SharpVk.PhysicalDevice extendedHandle, SharpVk.Format format)
        {
            try
            {
                SharpVk.Khronos.FormatProperties2 result = default(SharpVk.Khronos.FormatProperties2);
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Khronos.FormatProperties2 marshalledFormatProperties = default(SharpVk.Interop.Khronos.FormatProperties2);
                commandCache = extendedHandle.commandCache;
                SharpVk.Interop.Khronos.VkPhysicalDeviceGetFormatProperties2Delegate commandDelegate = commandCache.GetCommandDelegate<SharpVk.Interop.Khronos.VkPhysicalDeviceGetFormatProperties2Delegate>("vkGetPhysicalDeviceFormatProperties2KHR", "instance");
                commandDelegate(extendedHandle.handle, format, &marshalledFormatProperties);
                result = SharpVk.Khronos.FormatProperties2.MarshalFrom(&marshalledFormatProperties);
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Lists physical device's image format capabilities.
        /// </summary>
        /// <param name="extendedHandle">
        /// The PhysicalDevice handle to extend.
        /// </param>
        public static unsafe SharpVk.Khronos.ImageFormatProperties2 GetImageFormatProperties2(this SharpVk.PhysicalDevice extendedHandle, SharpVk.Khronos.PhysicalDeviceImageFormatInfo2 imageFormatInfo)
        {
            try
            {
                SharpVk.Khronos.ImageFormatProperties2 result = default(SharpVk.Khronos.ImageFormatProperties2);
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Khronos.PhysicalDeviceImageFormatInfo2* marshalledImageFormatInfo = default(SharpVk.Interop.Khronos.PhysicalDeviceImageFormatInfo2*);
                SharpVk.Interop.Khronos.ImageFormatProperties2 marshalledImageFormatProperties = default(SharpVk.Interop.Khronos.ImageFormatProperties2);
                commandCache = extendedHandle.commandCache;
                marshalledImageFormatInfo = (SharpVk.Interop.Khronos.PhysicalDeviceImageFormatInfo2*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.PhysicalDeviceImageFormatInfo2>());
                imageFormatInfo.MarshalTo(marshalledImageFormatInfo);
                SharpVk.Interop.Khronos.VkPhysicalDeviceGetImageFormatProperties2Delegate commandDelegate = commandCache.GetCommandDelegate<SharpVk.Interop.Khronos.VkPhysicalDeviceGetImageFormatProperties2Delegate>("vkGetPhysicalDeviceImageFormatProperties2KHR", "instance");
                Result methodResult = commandDelegate(extendedHandle.handle, marshalledImageFormatInfo, &marshalledImageFormatProperties);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = SharpVk.Khronos.ImageFormatProperties2.MarshalFrom(&marshalledImageFormatProperties);
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Reports properties of the queues of the specified physical device.
        /// </summary>
        /// <param name="extendedHandle">
        /// The PhysicalDevice handle to extend.
        /// </param>
        public static unsafe SharpVk.Khronos.QueueFamilyProperties2[] GetQueueFamilyProperties2(this SharpVk.PhysicalDevice extendedHandle)
        {
            try
            {
                SharpVk.Khronos.QueueFamilyProperties2[] result = default(SharpVk.Khronos.QueueFamilyProperties2[]);
                uint queueFamilyPropertyCount = default(uint);
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Khronos.QueueFamilyProperties2* marshalledQueueFamilyProperties = default(SharpVk.Interop.Khronos.QueueFamilyProperties2*);
                commandCache = extendedHandle.commandCache;
                SharpVk.Interop.Khronos.VkPhysicalDeviceGetQueueFamilyProperties2Delegate commandDelegate = commandCache.GetCommandDelegate<SharpVk.Interop.Khronos.VkPhysicalDeviceGetQueueFamilyProperties2Delegate>("vkGetPhysicalDeviceQueueFamilyProperties2KHR", "instance");
                commandDelegate(extendedHandle.handle, &queueFamilyPropertyCount, marshalledQueueFamilyProperties);
                marshalledQueueFamilyProperties = (SharpVk.Interop.Khronos.QueueFamilyProperties2*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.QueueFamilyProperties2>((uint)(queueFamilyPropertyCount)));
                commandDelegate(extendedHandle.handle, &queueFamilyPropertyCount, marshalledQueueFamilyProperties);
                if (marshalledQueueFamilyProperties != null)
                {
                    var fieldPointer = new SharpVk.Khronos.QueueFamilyProperties2[(uint)(queueFamilyPropertyCount)];
                    for(int index = 0; index < (uint)(queueFamilyPropertyCount); index++)
                    {
                        fieldPointer[index] = SharpVk.Khronos.QueueFamilyProperties2.MarshalFrom(&marshalledQueueFamilyProperties[index]);
                    }
                    result = fieldPointer;
                }
                else
                {
                    result = null;
                }
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Reports memory information for the specified physical device.
        /// </summary>
        /// <param name="extendedHandle">
        /// The PhysicalDevice handle to extend.
        /// </param>
        public static unsafe SharpVk.Khronos.PhysicalDeviceMemoryProperties2 GetMemoryProperties2(this SharpVk.PhysicalDevice extendedHandle)
        {
            try
            {
                SharpVk.Khronos.PhysicalDeviceMemoryProperties2 result = default(SharpVk.Khronos.PhysicalDeviceMemoryProperties2);
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Khronos.PhysicalDeviceMemoryProperties2 marshalledMemoryProperties = default(SharpVk.Interop.Khronos.PhysicalDeviceMemoryProperties2);
                commandCache = extendedHandle.commandCache;
                SharpVk.Interop.Khronos.VkPhysicalDeviceGetMemoryProperties2Delegate commandDelegate = commandCache.GetCommandDelegate<SharpVk.Interop.Khronos.VkPhysicalDeviceGetMemoryProperties2Delegate>("vkGetPhysicalDeviceMemoryProperties2KHR", "instance");
                commandDelegate(extendedHandle.handle, &marshalledMemoryProperties);
                result = SharpVk.Khronos.PhysicalDeviceMemoryProperties2.MarshalFrom(&marshalledMemoryProperties);
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Retrieve properties of an image format applied to sparse images.
        /// </summary>
        /// <param name="extendedHandle">
        /// The PhysicalDevice handle to extend.
        /// </param>
        public static unsafe SharpVk.Khronos.SparseImageFormatProperties2[] GetSparseImageFormatProperties2(this SharpVk.PhysicalDevice extendedHandle, SharpVk.Khronos.PhysicalDeviceSparseImageFormatInfo2 formatInfo)
        {
            try
            {
                SharpVk.Khronos.SparseImageFormatProperties2[] result = default(SharpVk.Khronos.SparseImageFormatProperties2[]);
                uint propertyCount = default(uint);
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Khronos.PhysicalDeviceSparseImageFormatInfo2* marshalledFormatInfo = default(SharpVk.Interop.Khronos.PhysicalDeviceSparseImageFormatInfo2*);
                SharpVk.Interop.Khronos.SparseImageFormatProperties2* marshalledProperties = default(SharpVk.Interop.Khronos.SparseImageFormatProperties2*);
                commandCache = extendedHandle.commandCache;
                marshalledFormatInfo = (SharpVk.Interop.Khronos.PhysicalDeviceSparseImageFormatInfo2*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.PhysicalDeviceSparseImageFormatInfo2>());
                formatInfo.MarshalTo(marshalledFormatInfo);
                SharpVk.Interop.Khronos.VkPhysicalDeviceGetSparseImageFormatProperties2Delegate commandDelegate = commandCache.GetCommandDelegate<SharpVk.Interop.Khronos.VkPhysicalDeviceGetSparseImageFormatProperties2Delegate>("vkGetPhysicalDeviceSparseImageFormatProperties2KHR", "instance");
                commandDelegate(extendedHandle.handle, marshalledFormatInfo, &propertyCount, marshalledProperties);
                marshalledProperties = (SharpVk.Interop.Khronos.SparseImageFormatProperties2*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.SparseImageFormatProperties2>((uint)(propertyCount)));
                commandDelegate(extendedHandle.handle, marshalledFormatInfo, &propertyCount, marshalledProperties);
                if (marshalledProperties != null)
                {
                    var fieldPointer = new SharpVk.Khronos.SparseImageFormatProperties2[(uint)(propertyCount)];
                    for(int index = 0; index < (uint)(propertyCount); index++)
                    {
                        fieldPointer[index] = SharpVk.Khronos.SparseImageFormatProperties2.MarshalFrom(&marshalledProperties[index]);
                    }
                    result = fieldPointer;
                }
                else
                {
                    result = null;
                }
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="extendedHandle">
        /// The PhysicalDevice handle to extend.
        /// </param>
        public static unsafe SharpVk.Khronos.ExternalBufferProperties GetExternalBufferProperties(this SharpVk.PhysicalDevice extendedHandle, SharpVk.Khronos.PhysicalDeviceExternalBufferInfo externalBufferInfo)
        {
            try
            {
                SharpVk.Khronos.ExternalBufferProperties result = default(SharpVk.Khronos.ExternalBufferProperties);
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Khronos.PhysicalDeviceExternalBufferInfo* marshalledExternalBufferInfo = default(SharpVk.Interop.Khronos.PhysicalDeviceExternalBufferInfo*);
                SharpVk.Interop.Khronos.ExternalBufferProperties marshalledExternalBufferProperties = default(SharpVk.Interop.Khronos.ExternalBufferProperties);
                commandCache = extendedHandle.commandCache;
                marshalledExternalBufferInfo = (SharpVk.Interop.Khronos.PhysicalDeviceExternalBufferInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.PhysicalDeviceExternalBufferInfo>());
                externalBufferInfo.MarshalTo(marshalledExternalBufferInfo);
                SharpVk.Interop.Khronos.VkPhysicalDeviceGetExternalBufferPropertiesDelegate commandDelegate = commandCache.GetCommandDelegate<SharpVk.Interop.Khronos.VkPhysicalDeviceGetExternalBufferPropertiesDelegate>("vkGetPhysicalDeviceExternalBufferPropertiesKHR", "instance");
                commandDelegate(extendedHandle.handle, marshalledExternalBufferInfo, &marshalledExternalBufferProperties);
                result = SharpVk.Khronos.ExternalBufferProperties.MarshalFrom(&marshalledExternalBufferProperties);
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="extendedHandle">
        /// The PhysicalDevice handle to extend.
        /// </param>
        public static unsafe SharpVk.Khronos.ExternalSemaphoreProperties GetExternalSemaphoreProperties(this SharpVk.PhysicalDevice extendedHandle, SharpVk.Khronos.PhysicalDeviceExternalSemaphoreInfo externalSemaphoreInfo)
        {
            try
            {
                SharpVk.Khronos.ExternalSemaphoreProperties result = default(SharpVk.Khronos.ExternalSemaphoreProperties);
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Khronos.PhysicalDeviceExternalSemaphoreInfo* marshalledExternalSemaphoreInfo = default(SharpVk.Interop.Khronos.PhysicalDeviceExternalSemaphoreInfo*);
                SharpVk.Interop.Khronos.ExternalSemaphoreProperties marshalledExternalSemaphoreProperties = default(SharpVk.Interop.Khronos.ExternalSemaphoreProperties);
                commandCache = extendedHandle.commandCache;
                marshalledExternalSemaphoreInfo = (SharpVk.Interop.Khronos.PhysicalDeviceExternalSemaphoreInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.PhysicalDeviceExternalSemaphoreInfo>());
                externalSemaphoreInfo.MarshalTo(marshalledExternalSemaphoreInfo);
                SharpVk.Interop.Khronos.VkPhysicalDeviceGetExternalSemaphorePropertiesDelegate commandDelegate = commandCache.GetCommandDelegate<SharpVk.Interop.Khronos.VkPhysicalDeviceGetExternalSemaphorePropertiesDelegate>("vkGetPhysicalDeviceExternalSemaphorePropertiesKHR", "instance");
                commandDelegate(extendedHandle.handle, marshalledExternalSemaphoreInfo, &marshalledExternalSemaphoreProperties);
                result = SharpVk.Khronos.ExternalSemaphoreProperties.MarshalFrom(&marshalledExternalSemaphoreProperties);
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="extendedHandle">
        /// The PhysicalDevice handle to extend.
        /// </param>
        public static unsafe SharpVk.Khronos.ExternalFenceProperties GetExternalFenceProperties(this SharpVk.PhysicalDevice extendedHandle, SharpVk.Khronos.PhysicalDeviceExternalFenceInfo externalFenceInfo)
        {
            try
            {
                SharpVk.Khronos.ExternalFenceProperties result = default(SharpVk.Khronos.ExternalFenceProperties);
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Khronos.PhysicalDeviceExternalFenceInfo* marshalledExternalFenceInfo = default(SharpVk.Interop.Khronos.PhysicalDeviceExternalFenceInfo*);
                SharpVk.Interop.Khronos.ExternalFenceProperties marshalledExternalFenceProperties = default(SharpVk.Interop.Khronos.ExternalFenceProperties);
                commandCache = extendedHandle.commandCache;
                marshalledExternalFenceInfo = (SharpVk.Interop.Khronos.PhysicalDeviceExternalFenceInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.PhysicalDeviceExternalFenceInfo>());
                externalFenceInfo.MarshalTo(marshalledExternalFenceInfo);
                SharpVk.Interop.Khronos.VkPhysicalDeviceGetExternalFencePropertiesDelegate commandDelegate = commandCache.GetCommandDelegate<SharpVk.Interop.Khronos.VkPhysicalDeviceGetExternalFencePropertiesDelegate>("vkGetPhysicalDeviceExternalFencePropertiesKHR", "instance");
                commandDelegate(extendedHandle.handle, marshalledExternalFenceInfo, &marshalledExternalFenceProperties);
                result = SharpVk.Khronos.ExternalFenceProperties.MarshalFrom(&marshalledExternalFenceProperties);
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="extendedHandle">
        /// The PhysicalDevice handle to extend.
        /// </param>
        public static unsafe SharpVk.Khronos.SurfaceCapabilities2 GetSurfaceCapabilities2(this SharpVk.PhysicalDevice extendedHandle, SharpVk.Khronos.PhysicalDeviceSurfaceInfo2 surfaceInfo)
        {
            try
            {
                SharpVk.Khronos.SurfaceCapabilities2 result = default(SharpVk.Khronos.SurfaceCapabilities2);
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Khronos.PhysicalDeviceSurfaceInfo2* marshalledSurfaceInfo = default(SharpVk.Interop.Khronos.PhysicalDeviceSurfaceInfo2*);
                SharpVk.Interop.Khronos.SurfaceCapabilities2 marshalledSurfaceCapabilities = default(SharpVk.Interop.Khronos.SurfaceCapabilities2);
                commandCache = extendedHandle.commandCache;
                marshalledSurfaceInfo = (SharpVk.Interop.Khronos.PhysicalDeviceSurfaceInfo2*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.PhysicalDeviceSurfaceInfo2>());
                surfaceInfo.MarshalTo(marshalledSurfaceInfo);
                SharpVk.Interop.Khronos.VkPhysicalDeviceGetSurfaceCapabilities2Delegate commandDelegate = commandCache.GetCommandDelegate<SharpVk.Interop.Khronos.VkPhysicalDeviceGetSurfaceCapabilities2Delegate>("vkGetPhysicalDeviceSurfaceCapabilities2KHR", "instance");
                Result methodResult = commandDelegate(extendedHandle.handle, marshalledSurfaceInfo, &marshalledSurfaceCapabilities);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = SharpVk.Khronos.SurfaceCapabilities2.MarshalFrom(&marshalledSurfaceCapabilities);
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="extendedHandle">
        /// The PhysicalDevice handle to extend.
        /// </param>
        public static unsafe SharpVk.Khronos.SurfaceFormat2[] GetSurfaceFormats2(this SharpVk.PhysicalDevice extendedHandle, SharpVk.Khronos.PhysicalDeviceSurfaceInfo2 surfaceInfo)
        {
            try
            {
                SharpVk.Khronos.SurfaceFormat2[] result = default(SharpVk.Khronos.SurfaceFormat2[]);
                uint surfaceFormatCount = default(uint);
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Khronos.PhysicalDeviceSurfaceInfo2* marshalledSurfaceInfo = default(SharpVk.Interop.Khronos.PhysicalDeviceSurfaceInfo2*);
                SharpVk.Interop.Khronos.SurfaceFormat2* marshalledSurfaceFormats = default(SharpVk.Interop.Khronos.SurfaceFormat2*);
                commandCache = extendedHandle.commandCache;
                marshalledSurfaceInfo = (SharpVk.Interop.Khronos.PhysicalDeviceSurfaceInfo2*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.PhysicalDeviceSurfaceInfo2>());
                surfaceInfo.MarshalTo(marshalledSurfaceInfo);
                SharpVk.Interop.Khronos.VkPhysicalDeviceGetSurfaceFormats2Delegate commandDelegate = commandCache.GetCommandDelegate<SharpVk.Interop.Khronos.VkPhysicalDeviceGetSurfaceFormats2Delegate>("vkGetPhysicalDeviceSurfaceFormats2KHR", "instance");
                Result methodResult = commandDelegate(extendedHandle.handle, marshalledSurfaceInfo, &surfaceFormatCount, marshalledSurfaceFormats);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                marshalledSurfaceFormats = (SharpVk.Interop.Khronos.SurfaceFormat2*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.SurfaceFormat2>((uint)(surfaceFormatCount)));
                commandDelegate(extendedHandle.handle, marshalledSurfaceInfo, &surfaceFormatCount, marshalledSurfaceFormats);
                if (marshalledSurfaceFormats != null)
                {
                    var fieldPointer = new SharpVk.Khronos.SurfaceFormat2[(uint)(surfaceFormatCount)];
                    for(int index = 0; index < (uint)(surfaceFormatCount); index++)
                    {
                        fieldPointer[index] = SharpVk.Khronos.SurfaceFormat2.MarshalFrom(&marshalledSurfaceFormats[index]);
                    }
                    result = fieldPointer;
                }
                else
                {
                    result = null;
                }
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
    }
}
