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

namespace SharpVk.Multivendor
{
    /// <summary>
    /// </summary>
    public static class PhysicalDeviceExtensions
    {
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
        public static unsafe void AcquireXlibDisplay(this PhysicalDevice extendedHandle, IntPtr dpy, Khronos.Display display)
        {
            try
            {
                CommandCache commandCache = default;
                IntPtr* marshalledDpy = default;
                commandCache = extendedHandle.commandCache;
                marshalledDpy = (IntPtr*)(Interop.HeapUtil.Allocate<IntPtr>());
                *marshalledDpy = dpy;
                SharpVk.Interop.Multivendor.VkPhysicalDeviceAcquireXlibDisplayDelegate commandDelegate = commandCache.Cache.vkAcquireXlibDisplayEXT;
                Result methodResult = commandDelegate(extendedHandle.Handle, marshalledDpy, display?.Handle ?? default);
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
        /// <param name="dpy">
        /// </param>
        /// <param name="rrOutput">
        /// </param>
        public static unsafe Khronos.Display GetRandROutputDisplay(this PhysicalDevice extendedHandle, IntPtr dpy, IntPtr rrOutput)
        {
            try
            {
                Khronos.Display result = default;
                CommandCache commandCache = default;
                IntPtr* marshalledDpy = default;
                SharpVk.Interop.Khronos.Display marshalledDisplay = default;
                commandCache = extendedHandle.commandCache;
                marshalledDpy = (IntPtr*)(Interop.HeapUtil.Allocate<IntPtr>());
                *marshalledDpy = dpy;
                SharpVk.Interop.Multivendor.VkPhysicalDeviceGetRandROutputDisplayDelegate commandDelegate = commandCache.Cache.vkGetRandROutputDisplayEXT;
                Result methodResult = commandDelegate(extendedHandle.Handle, marshalledDpy, rrOutput, &marshalledDisplay);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = new Khronos.Display(extendedHandle, marshalledDisplay);
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
        public static unsafe SurfaceCapabilities2 GetSurfaceCapabilities2(this PhysicalDevice extendedHandle, Khronos.Surface surface)
        {
            try
            {
                SurfaceCapabilities2 result = default;
                CommandCache commandCache = default;
                SharpVk.Interop.Multivendor.SurfaceCapabilities2 marshalledSurfaceCapabilities = default;
                commandCache = extendedHandle.commandCache;
                SharpVk.Interop.Multivendor.VkPhysicalDeviceGetSurfaceCapabilities2Delegate commandDelegate = commandCache.Cache.vkGetPhysicalDeviceSurfaceCapabilities2EXT;
                Result methodResult = commandDelegate(extendedHandle.Handle, surface?.Handle ?? default, &marshalledSurfaceCapabilities);
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
        /// <param name="samples">
        /// </param>
        public static unsafe MultisampleProperties GetMultisampleProperties(this PhysicalDevice extendedHandle, SampleCountFlags samples)
        {
            try
            {
                MultisampleProperties result = default;
                CommandCache commandCache = default;
                SharpVk.Interop.Multivendor.MultisampleProperties marshalledMultisampleProperties = default;
                commandCache = extendedHandle.commandCache;
                SharpVk.Interop.Multivendor.VkPhysicalDeviceGetMultisamplePropertiesDelegate commandDelegate = commandCache.Cache.vkGetPhysicalDeviceMultisamplePropertiesEXT;
                commandDelegate(extendedHandle.Handle, samples, &marshalledMultisampleProperties);
                result = MultisampleProperties.MarshalFrom(&marshalledMultisampleProperties);
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
        public static unsafe TimeDomain[] GetCalibrateableTimeDomains(this PhysicalDevice extendedHandle)
        {
            try
            {
                TimeDomain[] result = default;
                uint marshalledTimeDomainCount = default;
                CommandCache commandCache = default;
                TimeDomain* marshalledTimeDomains = default;
                commandCache = extendedHandle.commandCache;
                SharpVk.Interop.Multivendor.VkPhysicalDeviceGetCalibrateableTimeDomainsDelegate commandDelegate = commandCache.Cache.vkGetPhysicalDeviceCalibrateableTimeDomainsEXT;
                Result methodResult = commandDelegate(extendedHandle.Handle, &marshalledTimeDomainCount, marshalledTimeDomains);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                marshalledTimeDomains = (TimeDomain*)(Interop.HeapUtil.Allocate<TimeDomain>((uint)(marshalledTimeDomainCount)));
                commandDelegate(extendedHandle.Handle, &marshalledTimeDomainCount, marshalledTimeDomains);
                if (marshalledTimeDomains != null)
                {
                    var fieldPointer = new TimeDomain[(uint)(marshalledTimeDomainCount)];
                    for(int index = 0; index < (uint)(marshalledTimeDomainCount); index++)
                    {
                        fieldPointer[index] = marshalledTimeDomains[index];
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
        public static unsafe PhysicalDeviceToolProperties[] GetToolProperties(this PhysicalDevice extendedHandle)
        {
            try
            {
                PhysicalDeviceToolProperties[] result = default;
                uint marshalledToolCount = default;
                CommandCache commandCache = default;
                SharpVk.Interop.Multivendor.PhysicalDeviceToolProperties* marshalledToolProperties = default;
                commandCache = extendedHandle.commandCache;
                SharpVk.Interop.Multivendor.VkPhysicalDeviceGetToolPropertiesDelegate commandDelegate = commandCache.Cache.vkGetPhysicalDeviceToolPropertiesEXT;
                Result methodResult = commandDelegate(extendedHandle.Handle, &marshalledToolCount, marshalledToolProperties);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                marshalledToolProperties = (SharpVk.Interop.Multivendor.PhysicalDeviceToolProperties*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.PhysicalDeviceToolProperties>((uint)(marshalledToolCount)));
                commandDelegate(extendedHandle.Handle, &marshalledToolCount, marshalledToolProperties);
                if (marshalledToolProperties != null)
                {
                    var fieldPointer = new PhysicalDeviceToolProperties[(uint)(marshalledToolCount)];
                    for(int index = 0; index < (uint)(marshalledToolCount); index++)
                    {
                        fieldPointer[index] = PhysicalDeviceToolProperties.MarshalFrom(&marshalledToolProperties[index]);
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
        /// Query supported presentation modes
        /// </summary>
        /// <param name="extendedHandle">
        /// The PhysicalDevice handle to extend.
        /// </param>
        /// <param name="surfaceInfo">
        /// An instance of the VkPhysicalDeviceSurfaceInfo2KHR structure,
        /// describing the surface and other fixed parameters that would be
        /// consumed by vkCreateSwapchainKHR.
        /// </param>
        public static unsafe Khronos.PresentMode[] GetSurfacePresentModes2(this PhysicalDevice extendedHandle, Khronos.PhysicalDeviceSurfaceInfo2 surfaceInfo)
        {
            try
            {
                Khronos.PresentMode[] result = default;
                uint marshalledPresentModeCount = default;
                CommandCache commandCache = default;
                SharpVk.Interop.Khronos.PhysicalDeviceSurfaceInfo2* marshalledSurfaceInfo = default;
                Khronos.PresentMode* marshalledPresentModes = default;
                commandCache = extendedHandle.commandCache;
                marshalledSurfaceInfo = (SharpVk.Interop.Khronos.PhysicalDeviceSurfaceInfo2*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.PhysicalDeviceSurfaceInfo2>());
                surfaceInfo.MarshalTo(marshalledSurfaceInfo);
                SharpVk.Interop.Multivendor.VkPhysicalDeviceGetSurfacePresentModes2Delegate commandDelegate = commandCache.Cache.vkGetPhysicalDeviceSurfacePresentModes2EXT;
                Result methodResult = commandDelegate(extendedHandle.Handle, marshalledSurfaceInfo, &marshalledPresentModeCount, marshalledPresentModes);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                marshalledPresentModes = (Khronos.PresentMode*)(Interop.HeapUtil.Allocate<Khronos.PresentMode>((uint)(marshalledPresentModeCount)));
                commandDelegate(extendedHandle.Handle, marshalledSurfaceInfo, &marshalledPresentModeCount, marshalledPresentModes);
                if (marshalledPresentModes != null)
                {
                    var fieldPointer = new Khronos.PresentMode[(uint)(marshalledPresentModeCount)];
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
        /// <param name="queueFamilyIndex">
        /// </param>
        /// <param name="dfb">
        /// </param>
        public static unsafe void GetDirectFBPresentationSupport(this PhysicalDevice extendedHandle, uint queueFamilyIndex, IDirectFB dfb)
        {
            try
            {
                CommandCache commandCache = default;
                IDirectFB* marshalledDfb = default;
                commandCache = extendedHandle.commandCache;
                marshalledDfb = (IDirectFB*)(Interop.HeapUtil.Allocate<IDirectFB>());
                *marshalledDfb = dfb;
                SharpVk.Interop.Multivendor.VkPhysicalDeviceGetDirectFBPresentationSupportDelegate commandDelegate = commandCache.Cache.vkGetPhysicalDeviceDirectFBPresentationSupportEXT;
                commandDelegate(extendedHandle.Handle, queueFamilyIndex, marshalledDfb);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
    }
}
