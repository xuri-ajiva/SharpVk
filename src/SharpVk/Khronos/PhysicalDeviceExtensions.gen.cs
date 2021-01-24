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
    public static class PhysicalDeviceExtensions
    {
        /// <summary>
        /// Query if presentation is supported.
        /// </summary>
        /// <param name="extendedHandle">
        /// The PhysicalDevice handle to extend.
        /// </param>
        /// <param name="queueFamilyIndex">
        /// </param>
        /// <param name="surface">
        /// </param>
        public static unsafe bool GetSurfaceSupport(this PhysicalDevice extendedHandle, uint queueFamilyIndex, Surface surface)
        {
            try
            {
                bool result = default;
                CommandCache commandCache = default;
                Bool32 marshalledSupported = default;
                commandCache = extendedHandle.commandCache;
                SharpVk.Interop.Khronos.VkPhysicalDeviceGetSurfaceSupportDelegate commandDelegate = commandCache.Cache.vkGetPhysicalDeviceSurfaceSupportKHR;
                Result methodResult = commandDelegate(extendedHandle.Handle, queueFamilyIndex, surface?.Handle ?? default, &marshalledSupported);
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
        /// <param name="surface">
        /// </param>
        public static unsafe SurfaceCapabilities GetSurfaceCapabilities(this PhysicalDevice extendedHandle, Surface surface)
        {
            try
            {
                SurfaceCapabilities result = default;
                CommandCache commandCache = default;
                SurfaceCapabilities marshalledSurfaceCapabilities = default;
                commandCache = extendedHandle.commandCache;
                SharpVk.Interop.Khronos.VkPhysicalDeviceGetSurfaceCapabilitiesDelegate commandDelegate = commandCache.Cache.vkGetPhysicalDeviceSurfaceCapabilitiesKHR;
                Result methodResult = commandDelegate(extendedHandle.Handle, surface?.Handle ?? default, &marshalledSurfaceCapabilities);
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
        /// <param name="surface">
        /// </param>
        public static unsafe SurfaceFormat[] GetSurfaceFormats(this PhysicalDevice extendedHandle, Surface surface)
        {
            try
            {
                SurfaceFormat[] result = default;
                uint marshalledSurfaceFormatCount = default;
                CommandCache commandCache = default;
                SurfaceFormat* marshalledSurfaceFormats = default;
                commandCache = extendedHandle.commandCache;
                SharpVk.Interop.Khronos.VkPhysicalDeviceGetSurfaceFormatsDelegate commandDelegate = commandCache.Cache.vkGetPhysicalDeviceSurfaceFormatsKHR;
                Result methodResult = commandDelegate(extendedHandle.Handle, surface?.Handle ?? default, &marshalledSurfaceFormatCount, marshalledSurfaceFormats);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                marshalledSurfaceFormats = (SurfaceFormat*)(Interop.HeapUtil.Allocate<SurfaceFormat>((uint)(marshalledSurfaceFormatCount)));
                commandDelegate(extendedHandle.Handle, surface?.Handle ?? default, &marshalledSurfaceFormatCount, marshalledSurfaceFormats);
                if (marshalledSurfaceFormats != null)
                {
                    var fieldPointer = new SurfaceFormat[(uint)(marshalledSurfaceFormatCount)];
                    for(int index = 0; index < (uint)(marshalledSurfaceFormatCount); index++)
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
        /// <param name="surface">
        /// </param>
        public static unsafe PresentMode[] GetSurfacePresentModes(this PhysicalDevice extendedHandle, Surface surface)
        {
            try
            {
                PresentMode[] result = default;
                uint marshalledPresentModeCount = default;
                CommandCache commandCache = default;
                PresentMode* marshalledPresentModes = default;
                commandCache = extendedHandle.commandCache;
                SharpVk.Interop.Khronos.VkPhysicalDeviceGetSurfacePresentModesDelegate commandDelegate = commandCache.Cache.vkGetPhysicalDeviceSurfacePresentModesKHR;
                Result methodResult = commandDelegate(extendedHandle.Handle, surface?.Handle ?? default, &marshalledPresentModeCount, marshalledPresentModes);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                marshalledPresentModes = (PresentMode*)(Interop.HeapUtil.Allocate<PresentMode>((uint)(marshalledPresentModeCount)));
                commandDelegate(extendedHandle.Handle, surface?.Handle ?? default, &marshalledPresentModeCount, marshalledPresentModes);
                if (marshalledPresentModes != null)
                {
                    var fieldPointer = new PresentMode[(uint)(marshalledPresentModeCount)];
                    for(int index = 0; index < (uint)(marshalledPresentModeCount); index++)
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
        /// </summary>
        /// <param name="extendedHandle">
        /// The PhysicalDevice handle to extend.
        /// </param>
        /// <param name="surface">
        /// </param>
        public static unsafe Rect2D[] GetPresentRectangles(this PhysicalDevice extendedHandle, Surface surface)
        {
            try
            {
                Rect2D[] result = default;
                uint marshalledRectCount = default;
                CommandCache commandCache = default;
                Rect2D* marshalledRects = default;
                commandCache = extendedHandle.commandCache;
                SharpVk.Interop.Khronos.VkPhysicalDeviceGetPresentRectanglesDelegate commandDelegate = commandCache.Cache.vkGetPhysicalDevicePresentRectanglesKHR;
                Result methodResult = commandDelegate(extendedHandle.Handle, surface?.Handle ?? default, &marshalledRectCount, marshalledRects);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                marshalledRects = (Rect2D*)(Interop.HeapUtil.Allocate<Rect2D>((uint)(marshalledRectCount)));
                commandDelegate(extendedHandle.Handle, surface?.Handle ?? default, &marshalledRectCount, marshalledRects);
                if (marshalledRects != null)
                {
                    var fieldPointer = new Rect2D[(uint)(marshalledRectCount)];
                    for(int index = 0; index < (uint)(marshalledRectCount); index++)
                    {
                        fieldPointer[index] = marshalledRects[index];
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
        public static unsafe DisplayProperties[] GetDisplayProperties(this PhysicalDevice extendedHandle)
        {
            try
            {
                DisplayProperties[] result = default;
                uint marshalledPropertyCount = default;
                CommandCache commandCache = default;
                SharpVk.Interop.Khronos.DisplayProperties* marshalledProperties = default;
                commandCache = extendedHandle.commandCache;
                SharpVk.Interop.Khronos.VkPhysicalDeviceGetDisplayPropertiesDelegate commandDelegate = commandCache.Cache.vkGetPhysicalDeviceDisplayPropertiesKHR;
                Result methodResult = commandDelegate(extendedHandle.Handle, &marshalledPropertyCount, marshalledProperties);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                marshalledProperties = (SharpVk.Interop.Khronos.DisplayProperties*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.DisplayProperties>((uint)(marshalledPropertyCount)));
                commandDelegate(extendedHandle.Handle, &marshalledPropertyCount, marshalledProperties);
                if (marshalledProperties != null)
                {
                    var fieldPointer = new DisplayProperties[(uint)(marshalledPropertyCount)];
                    for(int index = 0; index < (uint)(marshalledPropertyCount); index++)
                    {
                        fieldPointer[index] = DisplayProperties.MarshalFrom(&marshalledProperties[index]);
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
        public static unsafe DisplayPlaneProperties[] GetDisplayPlaneProperties(this PhysicalDevice extendedHandle)
        {
            try
            {
                DisplayPlaneProperties[] result = default;
                uint marshalledPropertyCount = default;
                CommandCache commandCache = default;
                SharpVk.Interop.Khronos.DisplayPlaneProperties* marshalledProperties = default;
                commandCache = extendedHandle.commandCache;
                SharpVk.Interop.Khronos.VkPhysicalDeviceGetDisplayPlanePropertiesDelegate commandDelegate = commandCache.Cache.vkGetPhysicalDeviceDisplayPlanePropertiesKHR;
                Result methodResult = commandDelegate(extendedHandle.Handle, &marshalledPropertyCount, marshalledProperties);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                marshalledProperties = (SharpVk.Interop.Khronos.DisplayPlaneProperties*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.DisplayPlaneProperties>((uint)(marshalledPropertyCount)));
                commandDelegate(extendedHandle.Handle, &marshalledPropertyCount, marshalledProperties);
                if (marshalledProperties != null)
                {
                    var fieldPointer = new DisplayPlaneProperties[(uint)(marshalledPropertyCount)];
                    for(int index = 0; index < (uint)(marshalledPropertyCount); index++)
                    {
                        fieldPointer[index] = DisplayPlaneProperties.MarshalFrom(&marshalledProperties[index]);
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
        /// <param name="planeIndex">
        /// </param>
        public static unsafe Display[] GetDisplayPlaneSupportedDisplays(this PhysicalDevice extendedHandle, uint planeIndex)
        {
            try
            {
                Display[] result = default;
                uint marshalledDisplayCount = default;
                CommandCache commandCache = default;
                SharpVk.Interop.Khronos.Display* marshalledDisplays = default;
                commandCache = extendedHandle.commandCache;
                SharpVk.Interop.Khronos.VkPhysicalDeviceGetDisplayPlaneSupportedDisplaysDelegate commandDelegate = commandCache.Cache.vkGetDisplayPlaneSupportedDisplaysKHR;
                Result methodResult = commandDelegate(extendedHandle.Handle, planeIndex, &marshalledDisplayCount, marshalledDisplays);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                marshalledDisplays = (SharpVk.Interop.Khronos.Display*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.Display>((uint)(marshalledDisplayCount)));
                commandDelegate(extendedHandle.Handle, planeIndex, &marshalledDisplayCount, marshalledDisplays);
                if (marshalledDisplays != null)
                {
                    var fieldPointer = new Display[(uint)(marshalledDisplayCount)];
                    for(int index = 0; index < (uint)(marshalledDisplayCount); index++)
                    {
                        fieldPointer[index] = new Display(extendedHandle, marshalledDisplays[index]);
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
        /// Query physical device for presentation to X11 server using Xlib.
        /// </summary>
        /// <param name="extendedHandle">
        /// The PhysicalDevice handle to extend.
        /// </param>
        /// <param name="queueFamilyIndex">
        /// </param>
        /// <param name="dpy">
        /// </param>
        /// <param name="visualID">
        /// </param>
        public static unsafe void GetXlibPresentationSupport(this PhysicalDevice extendedHandle, uint queueFamilyIndex, IntPtr dpy, IntPtr visualID)
        {
            try
            {
                CommandCache commandCache = default;
                IntPtr* marshalledDpy = default;
                commandCache = extendedHandle.commandCache;
                marshalledDpy = (IntPtr*)(Interop.HeapUtil.Allocate<IntPtr>());
                *marshalledDpy = dpy;
                SharpVk.Interop.Khronos.VkPhysicalDeviceGetXlibPresentationSupportDelegate commandDelegate = commandCache.Cache.vkGetPhysicalDeviceXlibPresentationSupportKHR;
                commandDelegate(extendedHandle.Handle, queueFamilyIndex, marshalledDpy, visualID);
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
        /// <param name="queueFamilyIndex">
        /// </param>
        /// <param name="connection">
        /// </param>
        /// <param name="visualId">
        /// </param>
        public static unsafe void GetXcbPresentationSupport(this PhysicalDevice extendedHandle, uint queueFamilyIndex, IntPtr connection, IntPtr visualId)
        {
            try
            {
                CommandCache commandCache = default;
                IntPtr* marshalledConnection = default;
                commandCache = extendedHandle.commandCache;
                marshalledConnection = (IntPtr*)(Interop.HeapUtil.Allocate<IntPtr>());
                *marshalledConnection = connection;
                SharpVk.Interop.Khronos.VkPhysicalDeviceGetXcbPresentationSupportDelegate commandDelegate = commandCache.Cache.vkGetPhysicalDeviceXcbPresentationSupportKHR;
                commandDelegate(extendedHandle.Handle, queueFamilyIndex, marshalledConnection, visualId);
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
        /// <param name="queueFamilyIndex">
        /// </param>
        /// <param name="display">
        /// </param>
        public static unsafe void GetWaylandPresentationSupport(this PhysicalDevice extendedHandle, uint queueFamilyIndex, IntPtr display)
        {
            try
            {
                CommandCache commandCache = default;
                IntPtr* marshalledDisplay = default;
                commandCache = extendedHandle.commandCache;
                marshalledDisplay = (IntPtr*)(Interop.HeapUtil.Allocate<IntPtr>());
                *marshalledDisplay = display;
                SharpVk.Interop.Khronos.VkPhysicalDeviceGetWaylandPresentationSupportDelegate commandDelegate = commandCache.Cache.vkGetPhysicalDeviceWaylandPresentationSupportKHR;
                commandDelegate(extendedHandle.Handle, queueFamilyIndex, marshalledDisplay);
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
        /// <param name="queueFamilyIndex">
        /// </param>
        public static unsafe void GetWin32PresentationSupport(this PhysicalDevice extendedHandle, uint queueFamilyIndex)
        {
            try
            {
                CommandCache commandCache = default;
                commandCache = extendedHandle.commandCache;
                SharpVk.Interop.Khronos.VkPhysicalDeviceGetWin32PresentationSupportDelegate commandDelegate = commandCache.Cache.vkGetPhysicalDeviceWin32PresentationSupportKHR;
                commandDelegate(extendedHandle.Handle, queueFamilyIndex);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// </summary>
        /// <param name="extendedHandle">
        /// The PhysicalDevice handle to extend.
        /// </param>
        /// <param name="queueFamilyIndex">
        /// </param>
        /// <param name="counters">
        /// </param>
        /// <param name="counterDescriptions">
        /// </param>
        public static unsafe Result EnumerateQueueFamilyPerformanceQueryCounters(this PhysicalDevice extendedHandle, uint queueFamilyIndex, out PerformanceCounter[] counters, out PerformanceCounterDescription[] counterDescriptions)
        {
            try
            {
                Result result = default;
                uint marshalledCounterCount = default;
                CommandCache commandCache = default;
                SharpVk.Interop.Khronos.PerformanceCounter* marshalledCounters = default;
                SharpVk.Interop.Khronos.PerformanceCounterDescription* marshalledCounterDescriptions = default;
                commandCache = extendedHandle.commandCache;
                SharpVk.Interop.Khronos.VkPhysicalDeviceEnumerateQueueFamilyPerformanceQueryCountersDelegate commandDelegate = commandCache.Cache.vkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR;
                result = commandDelegate(extendedHandle.Handle, queueFamilyIndex, &marshalledCounterCount, marshalledCounters, marshalledCounterDescriptions);
                if (SharpVkException.IsError(result))
                {
                    throw SharpVkException.Create(result);
                }
                marshalledCounterDescriptions = (SharpVk.Interop.Khronos.PerformanceCounterDescription*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.PerformanceCounterDescription>((uint)(marshalledCounterCount)));
                marshalledCounters = (SharpVk.Interop.Khronos.PerformanceCounter*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.PerformanceCounter>((uint)(marshalledCounterCount)));
                commandDelegate(extendedHandle.Handle, queueFamilyIndex, &marshalledCounterCount, marshalledCounters, marshalledCounterDescriptions);
                if (marshalledCounters != null)
                {
                    var fieldPointer = new PerformanceCounter[(uint)(marshalledCounterCount)];
                    for(int index = 0; index < (uint)(marshalledCounterCount); index++)
                    {
                        fieldPointer[index] = PerformanceCounter.MarshalFrom(&marshalledCounters[index]);
                    }
                    counters = fieldPointer;
                }
                else
                {
                    counters = null;
                }
                if (marshalledCounterDescriptions != null)
                {
                    var fieldPointer = new PerformanceCounterDescription[(uint)(marshalledCounterCount)];
                    for(int index = 0; index < (uint)(marshalledCounterCount); index++)
                    {
                        fieldPointer[index] = PerformanceCounterDescription.MarshalFrom(&marshalledCounterDescriptions[index]);
                    }
                    counterDescriptions = fieldPointer;
                }
                else
                {
                    counterDescriptions = null;
                }
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// </summary>
        /// <param name="extendedHandle">
        /// The PhysicalDevice handle to extend.
        /// </param>
        /// <param name="performanceQueryCreateInfo">
        /// </param>
        public static unsafe uint GetQueueFamilyPerformanceQueryPasses(this PhysicalDevice extendedHandle, QueryPoolPerformanceCreateInfo performanceQueryCreateInfo)
        {
            try
            {
                uint result = default;
                CommandCache commandCache = default;
                SharpVk.Interop.Khronos.QueryPoolPerformanceCreateInfo* marshalledPerformanceQueryCreateInfo = default;
                uint marshalledNumPasses = default;
                commandCache = extendedHandle.commandCache;
                marshalledPerformanceQueryCreateInfo = (SharpVk.Interop.Khronos.QueryPoolPerformanceCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.QueryPoolPerformanceCreateInfo>());
                performanceQueryCreateInfo.MarshalTo(marshalledPerformanceQueryCreateInfo);
                SharpVk.Interop.Khronos.VkPhysicalDeviceGetQueueFamilyPerformanceQueryPassesDelegate commandDelegate = commandCache.Cache.vkGetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHR;
                commandDelegate(extendedHandle.Handle, marshalledPerformanceQueryCreateInfo, &marshalledNumPasses);
                result = marshalledNumPasses;
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// </summary>
        /// <param name="extendedHandle">
        /// The PhysicalDevice handle to extend.
        /// </param>
        /// <param name="surfaceInfo">
        /// </param>
        public static unsafe SurfaceCapabilities2 GetSurfaceCapabilities2(this PhysicalDevice extendedHandle, PhysicalDeviceSurfaceInfo2 surfaceInfo)
        {
            try
            {
                SurfaceCapabilities2 result = default;
                CommandCache commandCache = default;
                SharpVk.Interop.Khronos.PhysicalDeviceSurfaceInfo2* marshalledSurfaceInfo = default;
                SharpVk.Interop.Khronos.SurfaceCapabilities2 marshalledSurfaceCapabilities = default;
                commandCache = extendedHandle.commandCache;
                marshalledSurfaceInfo = (SharpVk.Interop.Khronos.PhysicalDeviceSurfaceInfo2*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.PhysicalDeviceSurfaceInfo2>());
                surfaceInfo.MarshalTo(marshalledSurfaceInfo);
                SharpVk.Interop.Khronos.VkPhysicalDeviceGetSurfaceCapabilities2Delegate commandDelegate = commandCache.Cache.vkGetPhysicalDeviceSurfaceCapabilities2KHR;
                Result methodResult = commandDelegate(extendedHandle.Handle, marshalledSurfaceInfo, &marshalledSurfaceCapabilities);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = SurfaceCapabilities2.MarshalFrom(&marshalledSurfaceCapabilities);
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// </summary>
        /// <param name="extendedHandle">
        /// The PhysicalDevice handle to extend.
        /// </param>
        /// <param name="surfaceInfo">
        /// </param>
        public static unsafe SurfaceFormat2[] GetSurfaceFormats2(this PhysicalDevice extendedHandle, PhysicalDeviceSurfaceInfo2 surfaceInfo)
        {
            try
            {
                SurfaceFormat2[] result = default;
                uint marshalledSurfaceFormatCount = default;
                CommandCache commandCache = default;
                SharpVk.Interop.Khronos.PhysicalDeviceSurfaceInfo2* marshalledSurfaceInfo = default;
                SharpVk.Interop.Khronos.SurfaceFormat2* marshalledSurfaceFormats = default;
                commandCache = extendedHandle.commandCache;
                marshalledSurfaceInfo = (SharpVk.Interop.Khronos.PhysicalDeviceSurfaceInfo2*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.PhysicalDeviceSurfaceInfo2>());
                surfaceInfo.MarshalTo(marshalledSurfaceInfo);
                SharpVk.Interop.Khronos.VkPhysicalDeviceGetSurfaceFormats2Delegate commandDelegate = commandCache.Cache.vkGetPhysicalDeviceSurfaceFormats2KHR;
                Result methodResult = commandDelegate(extendedHandle.Handle, marshalledSurfaceInfo, &marshalledSurfaceFormatCount, marshalledSurfaceFormats);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                marshalledSurfaceFormats = (SharpVk.Interop.Khronos.SurfaceFormat2*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.SurfaceFormat2>((uint)(marshalledSurfaceFormatCount)));
                commandDelegate(extendedHandle.Handle, marshalledSurfaceInfo, &marshalledSurfaceFormatCount, marshalledSurfaceFormats);
                if (marshalledSurfaceFormats != null)
                {
                    var fieldPointer = new SurfaceFormat2[(uint)(marshalledSurfaceFormatCount)];
                    for(int index = 0; index < (uint)(marshalledSurfaceFormatCount); index++)
                    {
                        fieldPointer[index] = SurfaceFormat2.MarshalFrom(&marshalledSurfaceFormats[index]);
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
        /// </summary>
        /// <param name="extendedHandle">
        /// The PhysicalDevice handle to extend.
        /// </param>
        public static unsafe DisplayProperties2[] GetDisplayProperties2(this PhysicalDevice extendedHandle)
        {
            try
            {
                DisplayProperties2[] result = default;
                uint marshalledPropertyCount = default;
                CommandCache commandCache = default;
                SharpVk.Interop.Khronos.DisplayProperties2* marshalledProperties = default;
                commandCache = extendedHandle.commandCache;
                SharpVk.Interop.Khronos.VkPhysicalDeviceGetDisplayProperties2Delegate commandDelegate = commandCache.Cache.vkGetPhysicalDeviceDisplayProperties2KHR;
                Result methodResult = commandDelegate(extendedHandle.Handle, &marshalledPropertyCount, marshalledProperties);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                marshalledProperties = (SharpVk.Interop.Khronos.DisplayProperties2*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.DisplayProperties2>((uint)(marshalledPropertyCount)));
                commandDelegate(extendedHandle.Handle, &marshalledPropertyCount, marshalledProperties);
                if (marshalledProperties != null)
                {
                    var fieldPointer = new DisplayProperties2[(uint)(marshalledPropertyCount)];
                    for(int index = 0; index < (uint)(marshalledPropertyCount); index++)
                    {
                        fieldPointer[index] = DisplayProperties2.MarshalFrom(&marshalledProperties[index]);
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
        /// </summary>
        /// <param name="extendedHandle">
        /// The PhysicalDevice handle to extend.
        /// </param>
        public static unsafe DisplayPlaneProperties2[] GetDisplayPlaneProperties2(this PhysicalDevice extendedHandle)
        {
            try
            {
                DisplayPlaneProperties2[] result = default;
                uint marshalledPropertyCount = default;
                CommandCache commandCache = default;
                SharpVk.Interop.Khronos.DisplayPlaneProperties2* marshalledProperties = default;
                commandCache = extendedHandle.commandCache;
                SharpVk.Interop.Khronos.VkPhysicalDeviceGetDisplayPlaneProperties2Delegate commandDelegate = commandCache.Cache.vkGetPhysicalDeviceDisplayPlaneProperties2KHR;
                Result methodResult = commandDelegate(extendedHandle.Handle, &marshalledPropertyCount, marshalledProperties);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                marshalledProperties = (SharpVk.Interop.Khronos.DisplayPlaneProperties2*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.DisplayPlaneProperties2>((uint)(marshalledPropertyCount)));
                commandDelegate(extendedHandle.Handle, &marshalledPropertyCount, marshalledProperties);
                if (marshalledProperties != null)
                {
                    var fieldPointer = new DisplayPlaneProperties2[(uint)(marshalledPropertyCount)];
                    for(int index = 0; index < (uint)(marshalledPropertyCount); index++)
                    {
                        fieldPointer[index] = DisplayPlaneProperties2.MarshalFrom(&marshalledProperties[index]);
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
        /// </summary>
        /// <param name="extendedHandle">
        /// The PhysicalDevice handle to extend.
        /// </param>
        /// <param name="displayPlaneInfo">
        /// </param>
        public static unsafe DisplayPlaneCapabilities2 GetDisplayPlaneCapabilities2(this PhysicalDevice extendedHandle, DisplayPlaneInfo2 displayPlaneInfo)
        {
            try
            {
                DisplayPlaneCapabilities2 result = default;
                CommandCache commandCache = default;
                SharpVk.Interop.Khronos.DisplayPlaneInfo2* marshalledDisplayPlaneInfo = default;
                SharpVk.Interop.Khronos.DisplayPlaneCapabilities2 marshalledCapabilities = default;
                commandCache = extendedHandle.commandCache;
                marshalledDisplayPlaneInfo = (SharpVk.Interop.Khronos.DisplayPlaneInfo2*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.DisplayPlaneInfo2>());
                displayPlaneInfo.MarshalTo(marshalledDisplayPlaneInfo);
                SharpVk.Interop.Khronos.VkPhysicalDeviceGetDisplayPlaneCapabilities2Delegate commandDelegate = commandCache.Cache.vkGetDisplayPlaneCapabilities2KHR;
                Result methodResult = commandDelegate(extendedHandle.Handle, marshalledDisplayPlaneInfo, &marshalledCapabilities);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = DisplayPlaneCapabilities2.MarshalFrom(&marshalledCapabilities);
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
    }
}
