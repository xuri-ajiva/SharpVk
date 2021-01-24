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
    public static class DeviceExtensions
    {
        /// <summary>
        /// Create a swapchain.
        /// </summary>
        /// <param name="extendedHandle">
        /// The Device handle to extend.
        /// </param>
        /// <param name="flags">
        /// A bitmask indicating parameters of swapchain creation. Bits which
        /// can be set include: + --
        /// </param>
        /// <param name="surface">
        /// </param>
        /// <param name="minImageCount">
        /// </param>
        /// <param name="imageFormat">
        /// </param>
        /// <param name="imageColorSpace">
        /// </param>
        /// <param name="imageExtent">
        /// </param>
        /// <param name="imageArrayLayers">
        /// </param>
        /// <param name="imageUsage">
        /// </param>
        /// <param name="imageSharingMode">
        /// </param>
        /// <param name="queueFamilyIndices">
        /// </param>
        /// <param name="preTransform">
        /// </param>
        /// <param name="compositeAlpha">
        /// </param>
        /// <param name="presentMode">
        /// </param>
        /// <param name="clipped">
        /// </param>
        /// <param name="oldSwapchain">
        /// </param>
        /// <param name="swapchainCounterCreateInfoExt">
        /// Extension struct
        /// </param>
        /// <param name="deviceGroupSwapchainCreateInfoKhr">
        /// Extension struct
        /// </param>
        /// <param name="swapchainDisplayNativeHdrCreateInfoAmd">
        /// Extension struct
        /// </param>
        /// <param name="imageFormatListCreateInfo">
        /// Extension struct
        /// </param>
        /// <param name="surfaceFullScreenExclusiveInfoExt">
        /// Extension struct
        /// </param>
        /// <param name="surfaceFullScreenExclusiveWin32InfoExt">
        /// Extension struct
        /// </param>
        /// <param name="allocator">
        /// An optional AllocationCallbacks instance that controls host memory
        /// allocation.
        /// </param>
        public static unsafe Swapchain CreateSwapchain(this Device extendedHandle, Surface surface, uint minImageCount, Format imageFormat, ColorSpace imageColorSpace, Extent2D imageExtent, uint imageArrayLayers, ImageUsageFlags imageUsage, SharingMode imageSharingMode, ArrayProxy<uint>? queueFamilyIndices, SurfaceTransformFlags preTransform, CompositeAlphaFlags compositeAlpha, PresentMode presentMode, bool clipped, Swapchain oldSwapchain, SwapchainCreateFlags? flags = default, Multivendor.SwapchainCounterCreateInfo? swapchainCounterCreateInfoExt = null, DeviceGroupSwapchainCreateInfo? deviceGroupSwapchainCreateInfoKhr = null, Amd.SwapchainDisplayNativeHdrCreateInfo? swapchainDisplayNativeHdrCreateInfoAmd = null, ImageFormatListCreateInfo? imageFormatListCreateInfo = null, Multivendor.SurfaceFullScreenExclusiveInfo? surfaceFullScreenExclusiveInfoExt = null, Multivendor.SurfaceFullScreenExclusiveWin32Info? surfaceFullScreenExclusiveWin32InfoExt = null, AllocationCallbacks? allocator = default)
        {
            try
            {
                Swapchain result = default;
                CommandCache commandCache = default;
                SharpVk.Interop.Khronos.SwapchainCreateInfo* marshalledCreateInfo = default;
                void* vkSwapchainCreateInfoKHRNextPointer = default;
                SharpVk.Interop.AllocationCallbacks* marshalledAllocator = default;
                SharpVk.Interop.Khronos.Swapchain marshalledSwapchain = default;
                if (swapchainCounterCreateInfoExt != null)
                {
                    SharpVk.Interop.Multivendor.SwapchainCounterCreateInfo* extensionPointer = default;
                    extensionPointer = (SharpVk.Interop.Multivendor.SwapchainCounterCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.SwapchainCounterCreateInfo>());
                    swapchainCounterCreateInfoExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkSwapchainCreateInfoKHRNextPointer;
                    vkSwapchainCreateInfoKHRNextPointer = extensionPointer;
                }
                if (deviceGroupSwapchainCreateInfoKhr != null)
                {
                    SharpVk.Interop.Khronos.DeviceGroupSwapchainCreateInfo* extensionPointer = default;
                    extensionPointer = (SharpVk.Interop.Khronos.DeviceGroupSwapchainCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.DeviceGroupSwapchainCreateInfo>());
                    deviceGroupSwapchainCreateInfoKhr.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkSwapchainCreateInfoKHRNextPointer;
                    vkSwapchainCreateInfoKHRNextPointer = extensionPointer;
                }
                if (swapchainDisplayNativeHdrCreateInfoAmd != null)
                {
                    SharpVk.Interop.Amd.SwapchainDisplayNativeHdrCreateInfo* extensionPointer = default;
                    extensionPointer = (SharpVk.Interop.Amd.SwapchainDisplayNativeHdrCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Amd.SwapchainDisplayNativeHdrCreateInfo>());
                    swapchainDisplayNativeHdrCreateInfoAmd.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkSwapchainCreateInfoKHRNextPointer;
                    vkSwapchainCreateInfoKHRNextPointer = extensionPointer;
                }
                if (imageFormatListCreateInfo != null)
                {
                    SharpVk.Interop.ImageFormatListCreateInfo* extensionPointer = default;
                    extensionPointer = (SharpVk.Interop.ImageFormatListCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.ImageFormatListCreateInfo>());
                    imageFormatListCreateInfo.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkSwapchainCreateInfoKHRNextPointer;
                    vkSwapchainCreateInfoKHRNextPointer = extensionPointer;
                }
                if (surfaceFullScreenExclusiveInfoExt != null)
                {
                    SharpVk.Interop.Multivendor.SurfaceFullScreenExclusiveInfo* extensionPointer = default;
                    extensionPointer = (SharpVk.Interop.Multivendor.SurfaceFullScreenExclusiveInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.SurfaceFullScreenExclusiveInfo>());
                    surfaceFullScreenExclusiveInfoExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkSwapchainCreateInfoKHRNextPointer;
                    vkSwapchainCreateInfoKHRNextPointer = extensionPointer;
                }
                if (surfaceFullScreenExclusiveWin32InfoExt != null)
                {
                    SharpVk.Interop.Multivendor.SurfaceFullScreenExclusiveWin32Info* extensionPointer = default;
                    extensionPointer = (SharpVk.Interop.Multivendor.SurfaceFullScreenExclusiveWin32Info*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.SurfaceFullScreenExclusiveWin32Info>());
                    surfaceFullScreenExclusiveWin32InfoExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkSwapchainCreateInfoKHRNextPointer;
                    vkSwapchainCreateInfoKHRNextPointer = extensionPointer;
                }
                commandCache = extendedHandle.commandCache;
                marshalledCreateInfo = (SharpVk.Interop.Khronos.SwapchainCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.SwapchainCreateInfo>());
                marshalledCreateInfo->SType = StructureType.SwapchainCreateInfo;
                marshalledCreateInfo->Next = vkSwapchainCreateInfoKHRNextPointer;
                if (flags != null)
                {
                    marshalledCreateInfo->Flags = flags.Value;
                }
                else
                {
                    marshalledCreateInfo->Flags = default;
                }
                marshalledCreateInfo->Surface = surface?.Handle ?? default;
                marshalledCreateInfo->MinImageCount = minImageCount;
                marshalledCreateInfo->ImageFormat = imageFormat;
                marshalledCreateInfo->ImageColorSpace = imageColorSpace;
                marshalledCreateInfo->ImageExtent = imageExtent;
                marshalledCreateInfo->ImageArrayLayers = imageArrayLayers;
                marshalledCreateInfo->ImageUsage = imageUsage;
                marshalledCreateInfo->ImageSharingMode = imageSharingMode;
                marshalledCreateInfo->QueueFamilyIndexCount = (uint)(Interop.HeapUtil.GetLength(queueFamilyIndices));
                if (queueFamilyIndices.IsNull())
                {
                    marshalledCreateInfo->QueueFamilyIndices = null;
                }
                else
                {
                    if (queueFamilyIndices.Value.Contents == ProxyContents.Single)
                    {
                        marshalledCreateInfo->QueueFamilyIndices = (uint*)(Interop.HeapUtil.Allocate<uint>());
                        *(uint*)(marshalledCreateInfo->QueueFamilyIndices) = queueFamilyIndices.Value.GetSingleValue();
                    }
                    else
                    {
                        var fieldPointer = (uint*)(Interop.HeapUtil.AllocateAndClear<uint>(Interop.HeapUtil.GetLength(queueFamilyIndices.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(queueFamilyIndices.Value)); index++)
                        {
                            fieldPointer[index] = queueFamilyIndices.Value[index];
                        }
                        marshalledCreateInfo->QueueFamilyIndices = fieldPointer;
                    }
                }
                marshalledCreateInfo->PreTransform = preTransform;
                marshalledCreateInfo->CompositeAlpha = compositeAlpha;
                marshalledCreateInfo->PresentMode = presentMode;
                marshalledCreateInfo->Clipped = clipped;
                marshalledCreateInfo->OldSwapchain = oldSwapchain?.Handle ?? default;
                if (allocator != null)
                {
                    marshalledAllocator = (SharpVk.Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<SharpVk.Interop.AllocationCallbacks>());
                    allocator.Value.MarshalTo(marshalledAllocator);
                }
                else
                {
                    marshalledAllocator = default;
                }
                SharpVk.Interop.Khronos.VkDeviceCreateSwapchainDelegate commandDelegate = commandCache.Cache.vkCreateSwapchainKHR;
                Result methodResult = commandDelegate(extendedHandle.Handle, marshalledCreateInfo, marshalledAllocator, &marshalledSwapchain);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = new Swapchain(extendedHandle, marshalledSwapchain);
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
        /// The Device handle to extend.
        /// </param>
        public static unsafe DeviceGroupPresentCapabilities GetGroupPresentCapabilities(this Device extendedHandle)
        {
            try
            {
                DeviceGroupPresentCapabilities result = default;
                CommandCache commandCache = default;
                SharpVk.Interop.Khronos.DeviceGroupPresentCapabilities marshalledDeviceGroupPresentCapabilities = default;
                commandCache = extendedHandle.commandCache;
                SharpVk.Interop.Khronos.VkDeviceGetGroupPresentCapabilitiesDelegate commandDelegate = commandCache.Cache.vkGetDeviceGroupPresentCapabilitiesKHR;
                Result methodResult = commandDelegate(extendedHandle.Handle, &marshalledDeviceGroupPresentCapabilities);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = DeviceGroupPresentCapabilities.MarshalFrom(&marshalledDeviceGroupPresentCapabilities);
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
        /// The Device handle to extend.
        /// </param>
        /// <param name="surface">
        /// </param>
        public static unsafe DeviceGroupPresentModeFlags GetGroupSurfacePresentModes(this Device extendedHandle, Surface surface)
        {
            try
            {
                DeviceGroupPresentModeFlags result = default;
                CommandCache commandCache = default;
                DeviceGroupPresentModeFlags marshalledModes = default;
                commandCache = extendedHandle.commandCache;
                SharpVk.Interop.Khronos.VkDeviceGetGroupSurfacePresentModesDelegate commandDelegate = commandCache.Cache.vkGetDeviceGroupSurfacePresentModesKHR;
                Result methodResult = commandDelegate(extendedHandle.Handle, surface?.Handle ?? default, &marshalledModes);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = marshalledModes;
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Retrieve the index of the next available presentable image.
        /// </summary>
        /// <param name="extendedHandle">
        /// The Device handle to extend.
        /// </param>
        /// <param name="acquireInfo">
        /// </param>
        public static unsafe uint AcquireNextImage2(this Device extendedHandle, AcquireNextImageInfo acquireInfo)
        {
            try
            {
                uint result = default;
                CommandCache commandCache = default;
                SharpVk.Interop.Khronos.AcquireNextImageInfo* marshalledAcquireInfo = default;
                uint marshalledImageIndex = default;
                commandCache = extendedHandle.commandCache;
                marshalledAcquireInfo = (SharpVk.Interop.Khronos.AcquireNextImageInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.AcquireNextImageInfo>());
                acquireInfo.MarshalTo(marshalledAcquireInfo);
                SharpVk.Interop.Khronos.VkDeviceAcquireNextImage2Delegate commandDelegate = commandCache.Cache.vkAcquireNextImage2KHR;
                Result methodResult = commandDelegate(extendedHandle.Handle, marshalledAcquireInfo, &marshalledImageIndex);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = marshalledImageIndex;
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Create multiple swapchains that share presentable images.
        /// </summary>
        /// <param name="extendedHandle">
        /// The Device handle to extend.
        /// </param>
        /// <param name="createInfos">
        /// </param>
        /// <param name="allocator">
        /// An optional AllocationCallbacks instance that controls host memory
        /// allocation.
        /// </param>
        public static unsafe Swapchain[] CreateSharedSwapchains(this Device extendedHandle, ArrayProxy<SwapchainCreateInfo>? createInfos, AllocationCallbacks? allocator = default)
        {
            try
            {
                Swapchain[] result = default;
                CommandCache commandCache = default;
                uint marshalledSwapchainCount = default;
                SharpVk.Interop.Khronos.SwapchainCreateInfo* marshalledCreateInfos = default;
                SharpVk.Interop.AllocationCallbacks* marshalledAllocator = default;
                SharpVk.Interop.Khronos.Swapchain* marshalledSwapchains = default;
                commandCache = extendedHandle.commandCache;
                marshalledSwapchainCount = (uint)(Interop.HeapUtil.GetLength(createInfos));
                if (createInfos.IsNull())
                {
                    marshalledCreateInfos = null;
                }
                else
                {
                    if (createInfos.Value.Contents == ProxyContents.Single)
                    {
                        marshalledCreateInfos = (SharpVk.Interop.Khronos.SwapchainCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.SwapchainCreateInfo>());
                        createInfos.Value.GetSingleValue().MarshalTo(&*(SharpVk.Interop.Khronos.SwapchainCreateInfo*)(marshalledCreateInfos));
                    }
                    else
                    {
                        var fieldPointer = (SharpVk.Interop.Khronos.SwapchainCreateInfo*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.Khronos.SwapchainCreateInfo>(Interop.HeapUtil.GetLength(createInfos.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(createInfos.Value)); index++)
                        {
                            createInfos.Value[index].MarshalTo(&fieldPointer[index]);
                        }
                        marshalledCreateInfos = fieldPointer;
                    }
                }
                if (allocator != null)
                {
                    marshalledAllocator = (SharpVk.Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<SharpVk.Interop.AllocationCallbacks>());
                    allocator.Value.MarshalTo(marshalledAllocator);
                }
                else
                {
                    marshalledAllocator = default;
                }
                marshalledSwapchains = (SharpVk.Interop.Khronos.Swapchain*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.Swapchain>(marshalledSwapchainCount));
                SharpVk.Interop.Khronos.VkDeviceCreateSharedSwapchainsDelegate commandDelegate = commandCache.Cache.vkCreateSharedSwapchainsKHR;
                Result methodResult = commandDelegate(extendedHandle.Handle, marshalledSwapchainCount, marshalledCreateInfos, marshalledAllocator, marshalledSwapchains);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                if (marshalledSwapchains != null)
                {
                    var fieldPointer = new Swapchain[(uint)(marshalledSwapchainCount)];
                    for(int index = 0; index < (uint)(marshalledSwapchainCount); index++)
                    {
                        fieldPointer[index] = new Swapchain(extendedHandle, marshalledSwapchains[index]);
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
        /// Create multiple swapchains that share presentable images.
        /// </summary>
        /// <param name="extendedHandle">
        /// The Device handle to extend.
        /// </param>
        /// <param name="flags">
        /// A bitmask indicating parameters of swapchain creation. Bits which
        /// can be set include: + --
        /// </param>
        /// <param name="surface">
        /// </param>
        /// <param name="minImageCount">
        /// </param>
        /// <param name="imageFormat">
        /// </param>
        /// <param name="imageColorSpace">
        /// </param>
        /// <param name="imageExtent">
        /// </param>
        /// <param name="imageArrayLayers">
        /// </param>
        /// <param name="imageUsage">
        /// </param>
        /// <param name="imageSharingMode">
        /// </param>
        /// <param name="queueFamilyIndices">
        /// </param>
        /// <param name="preTransform">
        /// </param>
        /// <param name="compositeAlpha">
        /// </param>
        /// <param name="presentMode">
        /// </param>
        /// <param name="clipped">
        /// </param>
        /// <param name="oldSwapchain">
        /// </param>
        /// <param name="swapchainCounterCreateInfoExt">
        /// Extension struct
        /// </param>
        /// <param name="deviceGroupSwapchainCreateInfoKhr">
        /// Extension struct
        /// </param>
        /// <param name="swapchainDisplayNativeHdrCreateInfoAmd">
        /// Extension struct
        /// </param>
        /// <param name="imageFormatListCreateInfo">
        /// Extension struct
        /// </param>
        /// <param name="surfaceFullScreenExclusiveInfoExt">
        /// Extension struct
        /// </param>
        /// <param name="surfaceFullScreenExclusiveWin32InfoExt">
        /// Extension struct
        /// </param>
        /// <param name="allocator">
        /// An optional AllocationCallbacks instance that controls host memory
        /// allocation.
        /// </param>
        public static unsafe Swapchain CreateSharedSwapchain(this Device extendedHandle, Surface surface, uint minImageCount, Format imageFormat, ColorSpace imageColorSpace, Extent2D imageExtent, uint imageArrayLayers, ImageUsageFlags imageUsage, SharingMode imageSharingMode, ArrayProxy<uint>? queueFamilyIndices, SurfaceTransformFlags preTransform, CompositeAlphaFlags compositeAlpha, PresentMode presentMode, bool clipped, Swapchain oldSwapchain, SwapchainCreateFlags? flags = default, Multivendor.SwapchainCounterCreateInfo? swapchainCounterCreateInfoExt = null, DeviceGroupSwapchainCreateInfo? deviceGroupSwapchainCreateInfoKhr = null, Amd.SwapchainDisplayNativeHdrCreateInfo? swapchainDisplayNativeHdrCreateInfoAmd = null, ImageFormatListCreateInfo? imageFormatListCreateInfo = null, Multivendor.SurfaceFullScreenExclusiveInfo? surfaceFullScreenExclusiveInfoExt = null, Multivendor.SurfaceFullScreenExclusiveWin32Info? surfaceFullScreenExclusiveWin32InfoExt = null, AllocationCallbacks? allocator = default)
        {
            try
            {
                Swapchain result = default;
                CommandCache commandCache = default;
                uint marshalledSwapchainCount = default;
                SharpVk.Interop.Khronos.SwapchainCreateInfo* marshalledCreateInfos = default;
                void* vkSwapchainCreateInfoKHRNextPointer = default;
                SharpVk.Interop.AllocationCallbacks* marshalledAllocator = default;
                SharpVk.Interop.Khronos.Swapchain* marshalledSwapchains = default;
                if (swapchainCounterCreateInfoExt != null)
                {
                    SharpVk.Interop.Multivendor.SwapchainCounterCreateInfo* extensionPointer = default;
                    extensionPointer = (SharpVk.Interop.Multivendor.SwapchainCounterCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.SwapchainCounterCreateInfo>());
                    swapchainCounterCreateInfoExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkSwapchainCreateInfoKHRNextPointer;
                    vkSwapchainCreateInfoKHRNextPointer = extensionPointer;
                }
                if (deviceGroupSwapchainCreateInfoKhr != null)
                {
                    SharpVk.Interop.Khronos.DeviceGroupSwapchainCreateInfo* extensionPointer = default;
                    extensionPointer = (SharpVk.Interop.Khronos.DeviceGroupSwapchainCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.DeviceGroupSwapchainCreateInfo>());
                    deviceGroupSwapchainCreateInfoKhr.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkSwapchainCreateInfoKHRNextPointer;
                    vkSwapchainCreateInfoKHRNextPointer = extensionPointer;
                }
                if (swapchainDisplayNativeHdrCreateInfoAmd != null)
                {
                    SharpVk.Interop.Amd.SwapchainDisplayNativeHdrCreateInfo* extensionPointer = default;
                    extensionPointer = (SharpVk.Interop.Amd.SwapchainDisplayNativeHdrCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Amd.SwapchainDisplayNativeHdrCreateInfo>());
                    swapchainDisplayNativeHdrCreateInfoAmd.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkSwapchainCreateInfoKHRNextPointer;
                    vkSwapchainCreateInfoKHRNextPointer = extensionPointer;
                }
                if (imageFormatListCreateInfo != null)
                {
                    SharpVk.Interop.ImageFormatListCreateInfo* extensionPointer = default;
                    extensionPointer = (SharpVk.Interop.ImageFormatListCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.ImageFormatListCreateInfo>());
                    imageFormatListCreateInfo.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkSwapchainCreateInfoKHRNextPointer;
                    vkSwapchainCreateInfoKHRNextPointer = extensionPointer;
                }
                if (surfaceFullScreenExclusiveInfoExt != null)
                {
                    SharpVk.Interop.Multivendor.SurfaceFullScreenExclusiveInfo* extensionPointer = default;
                    extensionPointer = (SharpVk.Interop.Multivendor.SurfaceFullScreenExclusiveInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.SurfaceFullScreenExclusiveInfo>());
                    surfaceFullScreenExclusiveInfoExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkSwapchainCreateInfoKHRNextPointer;
                    vkSwapchainCreateInfoKHRNextPointer = extensionPointer;
                }
                if (surfaceFullScreenExclusiveWin32InfoExt != null)
                {
                    SharpVk.Interop.Multivendor.SurfaceFullScreenExclusiveWin32Info* extensionPointer = default;
                    extensionPointer = (SharpVk.Interop.Multivendor.SurfaceFullScreenExclusiveWin32Info*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.SurfaceFullScreenExclusiveWin32Info>());
                    surfaceFullScreenExclusiveWin32InfoExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkSwapchainCreateInfoKHRNextPointer;
                    vkSwapchainCreateInfoKHRNextPointer = extensionPointer;
                }
                commandCache = extendedHandle.commandCache;
                marshalledSwapchainCount = 1;
                marshalledCreateInfos = (SharpVk.Interop.Khronos.SwapchainCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.SwapchainCreateInfo>());
                marshalledCreateInfos->SType = StructureType.SwapchainCreateInfo;
                marshalledCreateInfos->Next = vkSwapchainCreateInfoKHRNextPointer;
                if (flags != null)
                {
                    marshalledCreateInfos->Flags = flags.Value;
                }
                else
                {
                    marshalledCreateInfos->Flags = default;
                }
                marshalledCreateInfos->Surface = surface?.Handle ?? default;
                marshalledCreateInfos->MinImageCount = minImageCount;
                marshalledCreateInfos->ImageFormat = imageFormat;
                marshalledCreateInfos->ImageColorSpace = imageColorSpace;
                marshalledCreateInfos->ImageExtent = imageExtent;
                marshalledCreateInfos->ImageArrayLayers = imageArrayLayers;
                marshalledCreateInfos->ImageUsage = imageUsage;
                marshalledCreateInfos->ImageSharingMode = imageSharingMode;
                marshalledCreateInfos->QueueFamilyIndexCount = (uint)(Interop.HeapUtil.GetLength(queueFamilyIndices));
                if (queueFamilyIndices.IsNull())
                {
                    marshalledCreateInfos->QueueFamilyIndices = null;
                }
                else
                {
                    if (queueFamilyIndices.Value.Contents == ProxyContents.Single)
                    {
                        marshalledCreateInfos->QueueFamilyIndices = (uint*)(Interop.HeapUtil.Allocate<uint>());
                        *(uint*)(marshalledCreateInfos->QueueFamilyIndices) = queueFamilyIndices.Value.GetSingleValue();
                    }
                    else
                    {
                        var fieldPointer = (uint*)(Interop.HeapUtil.AllocateAndClear<uint>(Interop.HeapUtil.GetLength(queueFamilyIndices.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(queueFamilyIndices.Value)); index++)
                        {
                            fieldPointer[index] = queueFamilyIndices.Value[index];
                        }
                        marshalledCreateInfos->QueueFamilyIndices = fieldPointer;
                    }
                }
                marshalledCreateInfos->PreTransform = preTransform;
                marshalledCreateInfos->CompositeAlpha = compositeAlpha;
                marshalledCreateInfos->PresentMode = presentMode;
                marshalledCreateInfos->Clipped = clipped;
                marshalledCreateInfos->OldSwapchain = oldSwapchain?.Handle ?? default;
                if (allocator != null)
                {
                    marshalledAllocator = (SharpVk.Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<SharpVk.Interop.AllocationCallbacks>());
                    allocator.Value.MarshalTo(marshalledAllocator);
                }
                else
                {
                    marshalledAllocator = default;
                }
                marshalledSwapchains = (SharpVk.Interop.Khronos.Swapchain*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.Swapchain>(1));
                SharpVk.Interop.Khronos.VkDeviceCreateSharedSwapchainsDelegate commandDelegate = commandCache.Cache.vkCreateSharedSwapchainsKHR;
                Result methodResult = commandDelegate(extendedHandle.Handle, marshalledSwapchainCount, marshalledCreateInfos, marshalledAllocator, marshalledSwapchains);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = new Swapchain(extendedHandle, *marshalledSwapchains);
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
        /// The Device handle to extend.
        /// </param>
        /// <param name="getWin32HandleInfo">
        /// </param>
        public static unsafe IntPtr GetMemoryWin32Handle(this Device extendedHandle, MemoryGetWin32HandleInfo getWin32HandleInfo)
        {
            try
            {
                IntPtr result = default;
                CommandCache commandCache = default;
                SharpVk.Interop.Khronos.MemoryGetWin32HandleInfo* marshalledGetWin32HandleInfo = default;
                IntPtr marshalledHandle = default;
                commandCache = extendedHandle.commandCache;
                marshalledGetWin32HandleInfo = (SharpVk.Interop.Khronos.MemoryGetWin32HandleInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.MemoryGetWin32HandleInfo>());
                getWin32HandleInfo.MarshalTo(marshalledGetWin32HandleInfo);
                SharpVk.Interop.Khronos.VkDeviceGetMemoryWin32HandleDelegate commandDelegate = commandCache.Cache.vkGetMemoryWin32HandleKHR;
                Result methodResult = commandDelegate(extendedHandle.Handle, marshalledGetWin32HandleInfo, &marshalledHandle);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = marshalledHandle;
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
        /// The Device handle to extend.
        /// </param>
        /// <param name="handleType">
        /// </param>
        /// <param name="handle">
        /// </param>
        public static unsafe MemoryWin32HandleProperties GetMemoryWin32HandleProperties(this Device extendedHandle, SharpVk.ExternalMemoryHandleTypeFlags handleType, IntPtr handle)
        {
            try
            {
                MemoryWin32HandleProperties result = default;
                CommandCache commandCache = default;
                SharpVk.Interop.Khronos.MemoryWin32HandleProperties marshalledMemoryWin32HandleProperties = default;
                commandCache = extendedHandle.commandCache;
                SharpVk.Interop.Khronos.VkDeviceGetMemoryWin32HandlePropertiesDelegate commandDelegate = commandCache.Cache.vkGetMemoryWin32HandlePropertiesKHR;
                Result methodResult = commandDelegate(extendedHandle.Handle, handleType, handle, &marshalledMemoryWin32HandleProperties);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = MemoryWin32HandleProperties.MarshalFrom(&marshalledMemoryWin32HandleProperties);
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
        /// The Device handle to extend.
        /// </param>
        /// <param name="getFileDescriptorInfo">
        /// </param>
        public static unsafe int GetMemoryFileDescriptor(this Device extendedHandle, MemoryGetFileDescriptorInfo getFileDescriptorInfo)
        {
            try
            {
                int result = default;
                CommandCache commandCache = default;
                SharpVk.Interop.Khronos.MemoryGetFileDescriptorInfo* marshalledGetFileDescriptorInfo = default;
                int marshalledFileDescriptor = default;
                commandCache = extendedHandle.commandCache;
                marshalledGetFileDescriptorInfo = (SharpVk.Interop.Khronos.MemoryGetFileDescriptorInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.MemoryGetFileDescriptorInfo>());
                getFileDescriptorInfo.MarshalTo(marshalledGetFileDescriptorInfo);
                SharpVk.Interop.Khronos.VkDeviceGetMemoryFileDescriptorDelegate commandDelegate = commandCache.Cache.vkGetMemoryFdKHR;
                Result methodResult = commandDelegate(extendedHandle.Handle, marshalledGetFileDescriptorInfo, &marshalledFileDescriptor);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = marshalledFileDescriptor;
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
        /// The Device handle to extend.
        /// </param>
        /// <param name="handleType">
        /// </param>
        /// <param name="fileDescriptor">
        /// </param>
        public static unsafe MemoryFileDescriptorProperties GetMemoryFileDescriptorProperties(this Device extendedHandle, SharpVk.ExternalMemoryHandleTypeFlags handleType, int fileDescriptor)
        {
            try
            {
                MemoryFileDescriptorProperties result = default;
                CommandCache commandCache = default;
                SharpVk.Interop.Khronos.MemoryFileDescriptorProperties marshalledMemoryFileDescriptorProperties = default;
                commandCache = extendedHandle.commandCache;
                SharpVk.Interop.Khronos.VkDeviceGetMemoryFileDescriptorPropertiesDelegate commandDelegate = commandCache.Cache.vkGetMemoryFdPropertiesKHR;
                Result methodResult = commandDelegate(extendedHandle.Handle, handleType, fileDescriptor, &marshalledMemoryFileDescriptorProperties);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = MemoryFileDescriptorProperties.MarshalFrom(&marshalledMemoryFileDescriptorProperties);
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
        /// The Device handle to extend.
        /// </param>
        /// <param name="importSemaphoreWin32HandleInfo">
        /// </param>
        public static unsafe void ImportSemaphoreWin32Handle(this Device extendedHandle, ImportSemaphoreWin32HandleInfo importSemaphoreWin32HandleInfo)
        {
            try
            {
                CommandCache commandCache = default;
                SharpVk.Interop.Khronos.ImportSemaphoreWin32HandleInfo* marshalledImportSemaphoreWin32HandleInfo = default;
                commandCache = extendedHandle.commandCache;
                marshalledImportSemaphoreWin32HandleInfo = (SharpVk.Interop.Khronos.ImportSemaphoreWin32HandleInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.ImportSemaphoreWin32HandleInfo>());
                importSemaphoreWin32HandleInfo.MarshalTo(marshalledImportSemaphoreWin32HandleInfo);
                SharpVk.Interop.Khronos.VkDeviceImportSemaphoreWin32HandleDelegate commandDelegate = commandCache.Cache.vkImportSemaphoreWin32HandleKHR;
                Result methodResult = commandDelegate(extendedHandle.Handle, marshalledImportSemaphoreWin32HandleInfo);
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
        /// </summary>
        /// <param name="extendedHandle">
        /// The Device handle to extend.
        /// </param>
        /// <param name="getWin32HandleInfo">
        /// </param>
        public static unsafe IntPtr GetSemaphoreWin32Handle(this Device extendedHandle, SemaphoreGetWin32HandleInfo getWin32HandleInfo)
        {
            try
            {
                IntPtr result = default;
                CommandCache commandCache = default;
                SharpVk.Interop.Khronos.SemaphoreGetWin32HandleInfo* marshalledGetWin32HandleInfo = default;
                IntPtr marshalledHandle = default;
                commandCache = extendedHandle.commandCache;
                marshalledGetWin32HandleInfo = (SharpVk.Interop.Khronos.SemaphoreGetWin32HandleInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.SemaphoreGetWin32HandleInfo>());
                getWin32HandleInfo.MarshalTo(marshalledGetWin32HandleInfo);
                SharpVk.Interop.Khronos.VkDeviceGetSemaphoreWin32HandleDelegate commandDelegate = commandCache.Cache.vkGetSemaphoreWin32HandleKHR;
                Result methodResult = commandDelegate(extendedHandle.Handle, marshalledGetWin32HandleInfo, &marshalledHandle);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = marshalledHandle;
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
        /// The Device handle to extend.
        /// </param>
        /// <param name="importSemaphoreFileDescriptorInfo">
        /// </param>
        public static unsafe void ImportSemaphoreFileDescriptor(this Device extendedHandle, ImportSemaphoreFileDescriptorInfo importSemaphoreFileDescriptorInfo)
        {
            try
            {
                CommandCache commandCache = default;
                SharpVk.Interop.Khronos.ImportSemaphoreFileDescriptorInfo* marshalledImportSemaphoreFileDescriptorInfo = default;
                commandCache = extendedHandle.commandCache;
                marshalledImportSemaphoreFileDescriptorInfo = (SharpVk.Interop.Khronos.ImportSemaphoreFileDescriptorInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.ImportSemaphoreFileDescriptorInfo>());
                importSemaphoreFileDescriptorInfo.MarshalTo(marshalledImportSemaphoreFileDescriptorInfo);
                SharpVk.Interop.Khronos.VkDeviceImportSemaphoreFileDescriptorDelegate commandDelegate = commandCache.Cache.vkImportSemaphoreFdKHR;
                Result methodResult = commandDelegate(extendedHandle.Handle, marshalledImportSemaphoreFileDescriptorInfo);
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
        /// </summary>
        /// <param name="extendedHandle">
        /// The Device handle to extend.
        /// </param>
        /// <param name="getFileDescriptorInfo">
        /// </param>
        public static unsafe int GetSemaphoreFileDescriptor(this Device extendedHandle, SemaphoreGetFileDescriptorInfo getFileDescriptorInfo)
        {
            try
            {
                int result = default;
                CommandCache commandCache = default;
                SharpVk.Interop.Khronos.SemaphoreGetFileDescriptorInfo* marshalledGetFileDescriptorInfo = default;
                int marshalledFileDescriptor = default;
                commandCache = extendedHandle.commandCache;
                marshalledGetFileDescriptorInfo = (SharpVk.Interop.Khronos.SemaphoreGetFileDescriptorInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.SemaphoreGetFileDescriptorInfo>());
                getFileDescriptorInfo.MarshalTo(marshalledGetFileDescriptorInfo);
                SharpVk.Interop.Khronos.VkDeviceGetSemaphoreFileDescriptorDelegate commandDelegate = commandCache.Cache.vkGetSemaphoreFdKHR;
                Result methodResult = commandDelegate(extendedHandle.Handle, marshalledGetFileDescriptorInfo, &marshalledFileDescriptor);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = marshalledFileDescriptor;
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
        /// The Device handle to extend.
        /// </param>
        /// <param name="importFenceWin32HandleInfo">
        /// </param>
        public static unsafe void ImportFenceWin32Handle(this Device extendedHandle, ImportFenceWin32HandleInfo importFenceWin32HandleInfo)
        {
            try
            {
                CommandCache commandCache = default;
                SharpVk.Interop.Khronos.ImportFenceWin32HandleInfo* marshalledImportFenceWin32HandleInfo = default;
                commandCache = extendedHandle.commandCache;
                marshalledImportFenceWin32HandleInfo = (SharpVk.Interop.Khronos.ImportFenceWin32HandleInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.ImportFenceWin32HandleInfo>());
                importFenceWin32HandleInfo.MarshalTo(marshalledImportFenceWin32HandleInfo);
                SharpVk.Interop.Khronos.VkDeviceImportFenceWin32HandleDelegate commandDelegate = commandCache.Cache.vkImportFenceWin32HandleKHR;
                Result methodResult = commandDelegate(extendedHandle.Handle, marshalledImportFenceWin32HandleInfo);
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
        /// </summary>
        /// <param name="extendedHandle">
        /// The Device handle to extend.
        /// </param>
        /// <param name="getWin32HandleInfo">
        /// </param>
        public static unsafe IntPtr GetFenceWin32Handle(this Device extendedHandle, FenceGetWin32HandleInfo getWin32HandleInfo)
        {
            try
            {
                IntPtr result = default;
                CommandCache commandCache = default;
                SharpVk.Interop.Khronos.FenceGetWin32HandleInfo* marshalledGetWin32HandleInfo = default;
                IntPtr marshalledHandle = default;
                commandCache = extendedHandle.commandCache;
                marshalledGetWin32HandleInfo = (SharpVk.Interop.Khronos.FenceGetWin32HandleInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.FenceGetWin32HandleInfo>());
                getWin32HandleInfo.MarshalTo(marshalledGetWin32HandleInfo);
                SharpVk.Interop.Khronos.VkDeviceGetFenceWin32HandleDelegate commandDelegate = commandCache.Cache.vkGetFenceWin32HandleKHR;
                Result methodResult = commandDelegate(extendedHandle.Handle, marshalledGetWin32HandleInfo, &marshalledHandle);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = marshalledHandle;
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
        /// The Device handle to extend.
        /// </param>
        /// <param name="importFenceFileDescriptorInfo">
        /// </param>
        public static unsafe void ImportFenceFileDescriptor(this Device extendedHandle, ImportFenceFileDescriptorInfo importFenceFileDescriptorInfo)
        {
            try
            {
                CommandCache commandCache = default;
                SharpVk.Interop.Khronos.ImportFenceFileDescriptorInfo* marshalledImportFenceFileDescriptorInfo = default;
                commandCache = extendedHandle.commandCache;
                marshalledImportFenceFileDescriptorInfo = (SharpVk.Interop.Khronos.ImportFenceFileDescriptorInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.ImportFenceFileDescriptorInfo>());
                importFenceFileDescriptorInfo.MarshalTo(marshalledImportFenceFileDescriptorInfo);
                SharpVk.Interop.Khronos.VkDeviceImportFenceFileDescriptorDelegate commandDelegate = commandCache.Cache.vkImportFenceFdKHR;
                Result methodResult = commandDelegate(extendedHandle.Handle, marshalledImportFenceFileDescriptorInfo);
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
        /// </summary>
        /// <param name="extendedHandle">
        /// The Device handle to extend.
        /// </param>
        /// <param name="getFileDescriptorInfo">
        /// </param>
        public static unsafe int GetFenceFileDescriptor(this Device extendedHandle, FenceGetFileDescriptorInfo getFileDescriptorInfo)
        {
            try
            {
                int result = default;
                CommandCache commandCache = default;
                SharpVk.Interop.Khronos.FenceGetFileDescriptorInfo* marshalledGetFileDescriptorInfo = default;
                int marshalledFileDescriptor = default;
                commandCache = extendedHandle.commandCache;
                marshalledGetFileDescriptorInfo = (SharpVk.Interop.Khronos.FenceGetFileDescriptorInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.FenceGetFileDescriptorInfo>());
                getFileDescriptorInfo.MarshalTo(marshalledGetFileDescriptorInfo);
                SharpVk.Interop.Khronos.VkDeviceGetFenceFileDescriptorDelegate commandDelegate = commandCache.Cache.vkGetFenceFdKHR;
                Result methodResult = commandDelegate(extendedHandle.Handle, marshalledGetFileDescriptorInfo, &marshalledFileDescriptor);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = marshalledFileDescriptor;
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
        /// The Device handle to extend.
        /// </param>
        /// <param name="info">
        /// </param>
        public static unsafe void AcquireProfilingLock(this Device extendedHandle, AcquireProfilingLockInfo info)
        {
            try
            {
                CommandCache commandCache = default;
                SharpVk.Interop.Khronos.AcquireProfilingLockInfo* marshalledInfo = default;
                commandCache = extendedHandle.commandCache;
                marshalledInfo = (SharpVk.Interop.Khronos.AcquireProfilingLockInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.AcquireProfilingLockInfo>());
                info.MarshalTo(marshalledInfo);
                SharpVk.Interop.Khronos.VkDeviceAcquireProfilingLockDelegate commandDelegate = commandCache.Cache.vkAcquireProfilingLockKHR;
                Result methodResult = commandDelegate(extendedHandle.Handle, marshalledInfo);
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
        /// </summary>
        /// <param name="extendedHandle">
        /// The Device handle to extend.
        /// </param>
        public static unsafe void ReleaseProfilingLock(this Device extendedHandle)
        {
            try
            {
                CommandCache commandCache = default;
                commandCache = extendedHandle.commandCache;
                SharpVk.Interop.Khronos.VkDeviceReleaseProfilingLockDelegate commandDelegate = commandCache.Cache.vkReleaseProfilingLockKHR;
                commandDelegate(extendedHandle.Handle);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// </summary>
        /// <param name="extendedHandle">
        /// The Device handle to extend.
        /// </param>
        /// <param name="compactedSize">
        /// </param>
        /// <param name="type">
        /// </param>
        /// <param name="flags">
        /// </param>
        /// <param name="geometryInfos">
        /// </param>
        /// <param name="deviceAddress">
        /// </param>
        /// <param name="allocator">
        /// </param>
        public static unsafe AccelerationStructure CreateAccelerationStructure(this Device extendedHandle, ulong compactedSize, AccelerationStructureType type, ArrayProxy<AccelerationStructureCreateGeometryTypeInfo>? geometryInfos, BuildAccelerationStructureFlags? flags = default, ulong? deviceAddress = default, AllocationCallbacks? allocator = default)
        {
            try
            {
                AccelerationStructure result = default;
                CommandCache commandCache = default;
                SharpVk.Interop.Khronos.AccelerationStructureCreateInfo* marshalledCreateInfo = default;
                void* vkAccelerationStructureCreateInfoKHRNextPointer = default;
                SharpVk.Interop.AllocationCallbacks* marshalledAllocator = default;
                SharpVk.Interop.Khronos.AccelerationStructure marshalledAccelerationStructure = default;
                commandCache = extendedHandle.commandCache;
                marshalledCreateInfo = (SharpVk.Interop.Khronos.AccelerationStructureCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.AccelerationStructureCreateInfo>());
                marshalledCreateInfo->SType = StructureType.AccelerationStructureCreateInfoKhr;
                marshalledCreateInfo->Next = vkAccelerationStructureCreateInfoKHRNextPointer;
                marshalledCreateInfo->CompactedSize = compactedSize;
                marshalledCreateInfo->Type = type;
                if (flags != null)
                {
                    marshalledCreateInfo->Flags = flags.Value;
                }
                else
                {
                    marshalledCreateInfo->Flags = default;
                }
                marshalledCreateInfo->MaxGeometryCount = (uint)(Interop.HeapUtil.GetLength(geometryInfos));
                if (geometryInfos.IsNull())
                {
                    marshalledCreateInfo->GeometryInfos = null;
                }
                else
                {
                    if (geometryInfos.Value.Contents == ProxyContents.Single)
                    {
                        marshalledCreateInfo->GeometryInfos = (SharpVk.Interop.Khronos.AccelerationStructureCreateGeometryTypeInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.AccelerationStructureCreateGeometryTypeInfo>());
                        geometryInfos.Value.GetSingleValue().MarshalTo(&*(SharpVk.Interop.Khronos.AccelerationStructureCreateGeometryTypeInfo*)(marshalledCreateInfo->GeometryInfos));
                    }
                    else
                    {
                        var fieldPointer = (SharpVk.Interop.Khronos.AccelerationStructureCreateGeometryTypeInfo*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.Khronos.AccelerationStructureCreateGeometryTypeInfo>(Interop.HeapUtil.GetLength(geometryInfos.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(geometryInfos.Value)); index++)
                        {
                            geometryInfos.Value[index].MarshalTo(&fieldPointer[index]);
                        }
                        marshalledCreateInfo->GeometryInfos = fieldPointer;
                    }
                }
                if (deviceAddress != null)
                {
                    marshalledCreateInfo->DeviceAddress = deviceAddress.Value;
                }
                else
                {
                    marshalledCreateInfo->DeviceAddress = default;
                }
                if (allocator != null)
                {
                    marshalledAllocator = (SharpVk.Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<SharpVk.Interop.AllocationCallbacks>());
                    allocator.Value.MarshalTo(marshalledAllocator);
                }
                else
                {
                    marshalledAllocator = default;
                }
                SharpVk.Interop.Khronos.VkDeviceCreateAccelerationStructureDelegate commandDelegate = commandCache.Cache.vkCreateAccelerationStructureKHR;
                Result methodResult = commandDelegate(extendedHandle.Handle, marshalledCreateInfo, marshalledAllocator, &marshalledAccelerationStructure);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = new AccelerationStructure(extendedHandle, marshalledAccelerationStructure);
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
        /// The Device handle to extend.
        /// </param>
        /// <param name="info">
        /// </param>
        public static unsafe MemoryRequirements2 GetAccelerationStructureMemoryRequirements(this Device extendedHandle, AccelerationStructureMemoryRequirementsInfo info)
        {
            try
            {
                MemoryRequirements2 result = default;
                CommandCache commandCache = default;
                SharpVk.Interop.Khronos.AccelerationStructureMemoryRequirementsInfo* marshalledInfo = default;
                SharpVk.Interop.MemoryRequirements2 marshalledMemoryRequirements = default;
                commandCache = extendedHandle.commandCache;
                marshalledInfo = (SharpVk.Interop.Khronos.AccelerationStructureMemoryRequirementsInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.AccelerationStructureMemoryRequirementsInfo>());
                info.MarshalTo(marshalledInfo);
                SharpVk.Interop.Khronos.VkDeviceGetAccelerationStructureMemoryRequirementsDelegate commandDelegate = commandCache.Cache.vkGetAccelerationStructureMemoryRequirementsKHR;
                commandDelegate(extendedHandle.Handle, marshalledInfo, &marshalledMemoryRequirements);
                result = MemoryRequirements2.MarshalFrom(&marshalledMemoryRequirements);
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
        /// The Device handle to extend.
        /// </param>
        /// <param name="bindInfos">
        /// </param>
        public static unsafe void BindAccelerationStructureMemory(this Device extendedHandle, ArrayProxy<BindAccelerationStructureMemoryInfo>? bindInfos)
        {
            try
            {
                CommandCache commandCache = default;
                SharpVk.Interop.Khronos.BindAccelerationStructureMemoryInfo* marshalledBindInfos = default;
                commandCache = extendedHandle.commandCache;
                if (bindInfos.IsNull())
                {
                    marshalledBindInfos = null;
                }
                else
                {
                    if (bindInfos.Value.Contents == ProxyContents.Single)
                    {
                        marshalledBindInfos = (SharpVk.Interop.Khronos.BindAccelerationStructureMemoryInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.BindAccelerationStructureMemoryInfo>());
                        bindInfos.Value.GetSingleValue().MarshalTo(&*(SharpVk.Interop.Khronos.BindAccelerationStructureMemoryInfo*)(marshalledBindInfos));
                    }
                    else
                    {
                        var fieldPointer = (SharpVk.Interop.Khronos.BindAccelerationStructureMemoryInfo*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.Khronos.BindAccelerationStructureMemoryInfo>(Interop.HeapUtil.GetLength(bindInfos.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(bindInfos.Value)); index++)
                        {
                            bindInfos.Value[index].MarshalTo(&fieldPointer[index]);
                        }
                        marshalledBindInfos = fieldPointer;
                    }
                }
                SharpVk.Interop.Khronos.VkDeviceBindAccelerationStructureMemoryDelegate commandDelegate = commandCache.Cache.vkBindAccelerationStructureMemoryKHR;
                Result methodResult = commandDelegate(extendedHandle.Handle, (uint)(Interop.HeapUtil.GetLength(bindInfos)), marshalledBindInfos);
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
        /// </summary>
        /// <param name="extendedHandle">
        /// The Device handle to extend.
        /// </param>
        /// <param name="infos">
        /// </param>
        /// <param name="offsetInfos">
        /// </param>
        public static unsafe Result BuildAccelerationStructure(this Device extendedHandle, ArrayProxy<AccelerationStructureBuildGeometryInfo>? infos, ArrayProxy<AccelerationStructureBuildOffsetInfo>? offsetInfos)
        {
            try
            {
                Result result = default;
                CommandCache commandCache = default;
                SharpVk.Interop.Khronos.AccelerationStructureBuildGeometryInfo* marshalledInfos = default;
                AccelerationStructureBuildOffsetInfo** marshalledOffsetInfos = default;
                AccelerationStructureBuildOffsetInfo* semiMarshalledOffsetInfos = default;
                commandCache = extendedHandle.commandCache;
                if (infos.IsNull())
                {
                    marshalledInfos = null;
                }
                else
                {
                    if (infos.Value.Contents == ProxyContents.Single)
                    {
                        marshalledInfos = (SharpVk.Interop.Khronos.AccelerationStructureBuildGeometryInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.AccelerationStructureBuildGeometryInfo>());
                        infos.Value.GetSingleValue().MarshalTo(&*(SharpVk.Interop.Khronos.AccelerationStructureBuildGeometryInfo*)(marshalledInfos));
                    }
                    else
                    {
                        var fieldPointer = (SharpVk.Interop.Khronos.AccelerationStructureBuildGeometryInfo*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.Khronos.AccelerationStructureBuildGeometryInfo>(Interop.HeapUtil.GetLength(infos.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(infos.Value)); index++)
                        {
                            infos.Value[index].MarshalTo(&fieldPointer[index]);
                        }
                        marshalledInfos = fieldPointer;
                    }
                }
                if (offsetInfos.IsNull())
                {
                    marshalledOffsetInfos = null;
                }
                else
                {
                    if (offsetInfos.Value.Contents == ProxyContents.Single)
                    {
                        semiMarshalledOffsetInfos = (AccelerationStructureBuildOffsetInfo*)(Interop.HeapUtil.Allocate<AccelerationStructureBuildOffsetInfo>());
                        *(AccelerationStructureBuildOffsetInfo*)(semiMarshalledOffsetInfos) = offsetInfos.Value.GetSingleValue();
                    }
                    else
                    {
                        var fieldPointer = (AccelerationStructureBuildOffsetInfo*)(Interop.HeapUtil.AllocateAndClear<AccelerationStructureBuildOffsetInfo>(Interop.HeapUtil.GetLength(offsetInfos.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(offsetInfos.Value)); index++)
                        {
                            fieldPointer[index] = offsetInfos.Value[index];
                        }
                        semiMarshalledOffsetInfos = fieldPointer;
                        var marshalledFieldPointer = (AccelerationStructureBuildOffsetInfo**)(Interop.HeapUtil.AllocateAndClear<IntPtr>(Interop.HeapUtil.GetLength(offsetInfos.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(offsetInfos.Value)); index++)
                        {
                            marshalledFieldPointer[index] = &semiMarshalledOffsetInfos[index];
                        }
                        marshalledOffsetInfos = marshalledFieldPointer;
                    }
                }
                SharpVk.Interop.Khronos.VkDeviceBuildAccelerationStructureDelegate commandDelegate = commandCache.Cache.vkBuildAccelerationStructureKHR;
                result = commandDelegate(extendedHandle.Handle, (uint)(Interop.HeapUtil.GetLength(infos)), marshalledInfos, marshalledOffsetInfos);
                if (SharpVkException.IsError(result))
                {
                    throw SharpVkException.Create(result);
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
        /// The Device handle to extend.
        /// </param>
        /// <param name="info">
        /// </param>
        public static unsafe Result CopyAccelerationStructure(this Device extendedHandle, CopyAccelerationStructureInfo info)
        {
            try
            {
                Result result = default;
                CommandCache commandCache = default;
                SharpVk.Interop.Khronos.CopyAccelerationStructureInfo* marshalledInfo = default;
                commandCache = extendedHandle.commandCache;
                marshalledInfo = (SharpVk.Interop.Khronos.CopyAccelerationStructureInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.CopyAccelerationStructureInfo>());
                info.MarshalTo(marshalledInfo);
                SharpVk.Interop.Khronos.VkDeviceCopyAccelerationStructureDelegate commandDelegate = commandCache.Cache.vkCopyAccelerationStructureKHR;
                result = commandDelegate(extendedHandle.Handle, marshalledInfo);
                if (SharpVkException.IsError(result))
                {
                    throw SharpVkException.Create(result);
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
        /// The Device handle to extend.
        /// </param>
        /// <param name="info">
        /// </param>
        public static unsafe Result CopyAccelerationStructureToMemory(this Device extendedHandle, CopyAccelerationStructureToMemoryInfo info)
        {
            try
            {
                Result result = default;
                CommandCache commandCache = default;
                SharpVk.Interop.Khronos.CopyAccelerationStructureToMemoryInfo* marshalledInfo = default;
                commandCache = extendedHandle.commandCache;
                marshalledInfo = (SharpVk.Interop.Khronos.CopyAccelerationStructureToMemoryInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.CopyAccelerationStructureToMemoryInfo>());
                info.MarshalTo(marshalledInfo);
                SharpVk.Interop.Khronos.VkDeviceCopyAccelerationStructureToMemoryDelegate commandDelegate = commandCache.Cache.vkCopyAccelerationStructureToMemoryKHR;
                result = commandDelegate(extendedHandle.Handle, marshalledInfo);
                if (SharpVkException.IsError(result))
                {
                    throw SharpVkException.Create(result);
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
        /// The Device handle to extend.
        /// </param>
        /// <param name="info">
        /// </param>
        public static unsafe Result CopyMemoryToAccelerationStructure(this Device extendedHandle, CopyMemoryToAccelerationStructureInfo info)
        {
            try
            {
                Result result = default;
                CommandCache commandCache = default;
                SharpVk.Interop.Khronos.CopyMemoryToAccelerationStructureInfo* marshalledInfo = default;
                commandCache = extendedHandle.commandCache;
                marshalledInfo = (SharpVk.Interop.Khronos.CopyMemoryToAccelerationStructureInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.CopyMemoryToAccelerationStructureInfo>());
                info.MarshalTo(marshalledInfo);
                SharpVk.Interop.Khronos.VkDeviceCopyMemoryToAccelerationStructureDelegate commandDelegate = commandCache.Cache.vkCopyMemoryToAccelerationStructureKHR;
                result = commandDelegate(extendedHandle.Handle, marshalledInfo);
                if (SharpVkException.IsError(result))
                {
                    throw SharpVkException.Create(result);
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
        /// The Device handle to extend.
        /// </param>
        /// <param name="accelerationStructures">
        /// </param>
        /// <param name="queryType">
        /// </param>
        /// <param name="data">
        /// </param>
        /// <param name="stride">
        /// </param>
        public static unsafe void WriteAccelerationStructuresProperties(this Device extendedHandle, ArrayProxy<AccelerationStructure>? accelerationStructures, QueryType queryType, ArrayProxy<byte>? data, HostSize stride)
        {
            try
            {
                CommandCache commandCache = default;
                SharpVk.Interop.Khronos.AccelerationStructure* marshalledAccelerationStructures = default;
                byte* marshalledData = default;
                commandCache = extendedHandle.commandCache;
                if (accelerationStructures.IsNull())
                {
                    marshalledAccelerationStructures = null;
                }
                else
                {
                    if (accelerationStructures.Value.Contents == ProxyContents.Single)
                    {
                        marshalledAccelerationStructures = (SharpVk.Interop.Khronos.AccelerationStructure*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.AccelerationStructure>());
                        *(SharpVk.Interop.Khronos.AccelerationStructure*)(marshalledAccelerationStructures) = accelerationStructures.Value.GetSingleValue()?.Handle ?? default;
                    }
                    else
                    {
                        var fieldPointer = (SharpVk.Interop.Khronos.AccelerationStructure*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.Khronos.AccelerationStructure>(Interop.HeapUtil.GetLength(accelerationStructures.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(accelerationStructures.Value)); index++)
                        {
                            fieldPointer[index] = accelerationStructures.Value[index]?.Handle ?? default;
                        }
                        marshalledAccelerationStructures = fieldPointer;
                    }
                }
                if (data.IsNull())
                {
                    marshalledData = null;
                }
                else
                {
                    if (data.Value.Contents == ProxyContents.Single)
                    {
                        marshalledData = (byte*)(Interop.HeapUtil.Allocate<byte>());
                        *(byte*)(marshalledData) = data.Value.GetSingleValue();
                    }
                    else
                    {
                        var fieldPointer = (byte*)(Interop.HeapUtil.AllocateAndClear<byte>(Interop.HeapUtil.GetLength(data.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(data.Value)); index++)
                        {
                            fieldPointer[index] = data.Value[index];
                        }
                        marshalledData = fieldPointer;
                    }
                }
                SharpVk.Interop.Khronos.VkDeviceWriteAccelerationStructuresPropertiesDelegate commandDelegate = commandCache.Cache.vkWriteAccelerationStructuresPropertiesKHR;
                Result methodResult = commandDelegate(extendedHandle.Handle, (uint)(Interop.HeapUtil.GetLength(accelerationStructures)), marshalledAccelerationStructures, queryType, (HostSize)(Interop.HeapUtil.GetLength(data)), marshalledData, stride);
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
        /// </summary>
        /// <param name="extendedHandle">
        /// The Device handle to extend.
        /// </param>
        /// <param name="pipelineCache">
        /// </param>
        /// <param name="createInfos">
        /// </param>
        /// <param name="allocator">
        /// </param>
        public static unsafe Pipeline[] CreateRayTracingPipelines(this Device extendedHandle, PipelineCache pipelineCache, ArrayProxy<RayTracingPipelineCreateInfo>? createInfos, AllocationCallbacks? allocator = default)
        {
            try
            {
                Pipeline[] result = default;
                CommandCache commandCache = default;
                uint marshalledCreateInfoCount = default;
                SharpVk.Interop.Khronos.RayTracingPipelineCreateInfo* marshalledCreateInfos = default;
                SharpVk.Interop.AllocationCallbacks* marshalledAllocator = default;
                SharpVk.Interop.Pipeline* marshalledPipelines = default;
                commandCache = extendedHandle.commandCache;
                marshalledCreateInfoCount = (uint)(Interop.HeapUtil.GetLength(createInfos));
                if (createInfos.IsNull())
                {
                    marshalledCreateInfos = null;
                }
                else
                {
                    if (createInfos.Value.Contents == ProxyContents.Single)
                    {
                        marshalledCreateInfos = (SharpVk.Interop.Khronos.RayTracingPipelineCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.RayTracingPipelineCreateInfo>());
                        createInfos.Value.GetSingleValue().MarshalTo(&*(SharpVk.Interop.Khronos.RayTracingPipelineCreateInfo*)(marshalledCreateInfos));
                    }
                    else
                    {
                        var fieldPointer = (SharpVk.Interop.Khronos.RayTracingPipelineCreateInfo*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.Khronos.RayTracingPipelineCreateInfo>(Interop.HeapUtil.GetLength(createInfos.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(createInfos.Value)); index++)
                        {
                            createInfos.Value[index].MarshalTo(&fieldPointer[index]);
                        }
                        marshalledCreateInfos = fieldPointer;
                    }
                }
                if (allocator != null)
                {
                    marshalledAllocator = (SharpVk.Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<SharpVk.Interop.AllocationCallbacks>());
                    allocator.Value.MarshalTo(marshalledAllocator);
                }
                else
                {
                    marshalledAllocator = default;
                }
                marshalledPipelines = (SharpVk.Interop.Pipeline*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Pipeline>(marshalledCreateInfoCount));
                SharpVk.Interop.Khronos.VkDeviceCreateRayTracingPipelinesDelegate commandDelegate = commandCache.Cache.vkCreateRayTracingPipelinesKHR;
                Result methodResult = commandDelegate(extendedHandle.Handle, pipelineCache?.Handle ?? default, marshalledCreateInfoCount, marshalledCreateInfos, marshalledAllocator, marshalledPipelines);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                if (marshalledPipelines != null)
                {
                    var fieldPointer = new Pipeline[(uint)(marshalledCreateInfoCount)];
                    for(int index = 0; index < (uint)(marshalledCreateInfoCount); index++)
                    {
                        fieldPointer[index] = new Pipeline(extendedHandle, marshalledPipelines[index]);
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
        /// The Device handle to extend.
        /// </param>
        /// <param name="pipelineCache">
        /// </param>
        /// <param name="flags">
        /// </param>
        /// <param name="stages">
        /// </param>
        /// <param name="groups">
        /// </param>
        /// <param name="maxRecursionDepth">
        /// </param>
        /// <param name="libraries">
        /// </param>
        /// <param name="libraryInterface">
        /// </param>
        /// <param name="layout">
        /// </param>
        /// <param name="basePipelineHandle">
        /// </param>
        /// <param name="basePipelineIndex">
        /// </param>
        /// <param name="pipelineCreationFeedbackCreateInfoExt">
        /// Extension struct
        /// </param>
        /// <param name="deferredOperationInfoKhr">
        /// Extension struct
        /// </param>
        /// <param name="allocator">
        /// </param>
        public static unsafe Pipeline CreateRayTracingPipeline(this Device extendedHandle, PipelineCache pipelineCache, ArrayProxy<PipelineShaderStageCreateInfo>? stages, ArrayProxy<RayTracingShaderGroupCreateInfo>? groups, uint maxRecursionDepth, PipelineLibraryCreateInfo libraries, PipelineLayout layout, Pipeline basePipelineHandle, int basePipelineIndex, PipelineCreateFlags? flags = default, RayTracingPipelineInterfaceCreateInfo? libraryInterface = default, Multivendor.PipelineCreationFeedbackCreateInfo? pipelineCreationFeedbackCreateInfoExt = null, DeferredOperationInfo? deferredOperationInfoKhr = null, AllocationCallbacks? allocator = default)
        {
            try
            {
                Pipeline result = default;
                CommandCache commandCache = default;
                uint marshalledCreateInfoCount = default;
                SharpVk.Interop.Khronos.RayTracingPipelineCreateInfo* marshalledCreateInfos = default;
                void* vkRayTracingPipelineCreateInfoKHRNextPointer = default;
                SharpVk.Interop.AllocationCallbacks* marshalledAllocator = default;
                SharpVk.Interop.Pipeline* marshalledPipelines = default;
                if (pipelineCreationFeedbackCreateInfoExt != null)
                {
                    SharpVk.Interop.Multivendor.PipelineCreationFeedbackCreateInfo* extensionPointer = default;
                    extensionPointer = (SharpVk.Interop.Multivendor.PipelineCreationFeedbackCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.PipelineCreationFeedbackCreateInfo>());
                    pipelineCreationFeedbackCreateInfoExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkRayTracingPipelineCreateInfoKHRNextPointer;
                    vkRayTracingPipelineCreateInfoKHRNextPointer = extensionPointer;
                }
                if (deferredOperationInfoKhr != null)
                {
                    SharpVk.Interop.Khronos.DeferredOperationInfo* extensionPointer = default;
                    extensionPointer = (SharpVk.Interop.Khronos.DeferredOperationInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.DeferredOperationInfo>());
                    deferredOperationInfoKhr.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkRayTracingPipelineCreateInfoKHRNextPointer;
                    vkRayTracingPipelineCreateInfoKHRNextPointer = extensionPointer;
                }
                commandCache = extendedHandle.commandCache;
                marshalledCreateInfoCount = 1;
                marshalledCreateInfos = (SharpVk.Interop.Khronos.RayTracingPipelineCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.RayTracingPipelineCreateInfo>());
                marshalledCreateInfos->SType = StructureType.RayTracingPipelineCreateInfoKhr;
                marshalledCreateInfos->Next = vkRayTracingPipelineCreateInfoKHRNextPointer;
                if (flags != null)
                {
                    marshalledCreateInfos->Flags = flags.Value;
                }
                else
                {
                    marshalledCreateInfos->Flags = default;
                }
                marshalledCreateInfos->StageCount = (uint)(Interop.HeapUtil.GetLength(stages));
                if (stages.IsNull())
                {
                    marshalledCreateInfos->Stages = null;
                }
                else
                {
                    if (stages.Value.Contents == ProxyContents.Single)
                    {
                        marshalledCreateInfos->Stages = (SharpVk.Interop.PipelineShaderStageCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.PipelineShaderStageCreateInfo>());
                        stages.Value.GetSingleValue().MarshalTo(&*(SharpVk.Interop.PipelineShaderStageCreateInfo*)(marshalledCreateInfos->Stages));
                    }
                    else
                    {
                        var fieldPointer = (SharpVk.Interop.PipelineShaderStageCreateInfo*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.PipelineShaderStageCreateInfo>(Interop.HeapUtil.GetLength(stages.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(stages.Value)); index++)
                        {
                            stages.Value[index].MarshalTo(&fieldPointer[index]);
                        }
                        marshalledCreateInfos->Stages = fieldPointer;
                    }
                }
                marshalledCreateInfos->GroupCount = (uint)(Interop.HeapUtil.GetLength(groups));
                if (groups.IsNull())
                {
                    marshalledCreateInfos->Groups = null;
                }
                else
                {
                    if (groups.Value.Contents == ProxyContents.Single)
                    {
                        marshalledCreateInfos->Groups = (SharpVk.Interop.Khronos.RayTracingShaderGroupCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.RayTracingShaderGroupCreateInfo>());
                        groups.Value.GetSingleValue().MarshalTo(&*(SharpVk.Interop.Khronos.RayTracingShaderGroupCreateInfo*)(marshalledCreateInfos->Groups));
                    }
                    else
                    {
                        var fieldPointer = (SharpVk.Interop.Khronos.RayTracingShaderGroupCreateInfo*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.Khronos.RayTracingShaderGroupCreateInfo>(Interop.HeapUtil.GetLength(groups.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(groups.Value)); index++)
                        {
                            groups.Value[index].MarshalTo(&fieldPointer[index]);
                        }
                        marshalledCreateInfos->Groups = fieldPointer;
                    }
                }
                marshalledCreateInfos->MaxRecursionDepth = maxRecursionDepth;
                libraries.MarshalTo(&marshalledCreateInfos->Libraries);
                if (libraryInterface != null)
                {
                    marshalledCreateInfos->LibraryInterface = (SharpVk.Interop.Khronos.RayTracingPipelineInterfaceCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.RayTracingPipelineInterfaceCreateInfo>());
                    libraryInterface.Value.MarshalTo(marshalledCreateInfos->LibraryInterface);
                }
                else
                {
                    marshalledCreateInfos->LibraryInterface = default;
                }
                marshalledCreateInfos->Layout = layout?.Handle ?? default;
                marshalledCreateInfos->BasePipelineHandle = basePipelineHandle?.Handle ?? default;
                marshalledCreateInfos->BasePipelineIndex = basePipelineIndex;
                if (allocator != null)
                {
                    marshalledAllocator = (SharpVk.Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<SharpVk.Interop.AllocationCallbacks>());
                    allocator.Value.MarshalTo(marshalledAllocator);
                }
                else
                {
                    marshalledAllocator = default;
                }
                marshalledPipelines = (SharpVk.Interop.Pipeline*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Pipeline>(1));
                SharpVk.Interop.Khronos.VkDeviceCreateRayTracingPipelinesDelegate commandDelegate = commandCache.Cache.vkCreateRayTracingPipelinesKHR;
                Result methodResult = commandDelegate(extendedHandle.Handle, pipelineCache?.Handle ?? default, marshalledCreateInfoCount, marshalledCreateInfos, marshalledAllocator, marshalledPipelines);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = new Pipeline(extendedHandle, *marshalledPipelines);
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
        /// The Device handle to extend.
        /// </param>
        /// <param name="info">
        /// </param>
        public static unsafe void GetAccelerationStructureDeviceAddress(this Device extendedHandle, AccelerationStructureDeviceAddressInfo info)
        {
            try
            {
                CommandCache commandCache = default;
                SharpVk.Interop.Khronos.AccelerationStructureDeviceAddressInfo* marshalledInfo = default;
                commandCache = extendedHandle.commandCache;
                marshalledInfo = (SharpVk.Interop.Khronos.AccelerationStructureDeviceAddressInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.AccelerationStructureDeviceAddressInfo>());
                info.MarshalTo(marshalledInfo);
                SharpVk.Interop.Khronos.VkDeviceGetAccelerationStructureDeviceAddressDelegate commandDelegate = commandCache.Cache.vkGetAccelerationStructureDeviceAddressKHR;
                commandDelegate(extendedHandle.Handle, marshalledInfo);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// </summary>
        /// <param name="extendedHandle">
        /// The Device handle to extend.
        /// </param>
        /// <param name="version">
        /// </param>
        public static unsafe void GetAccelerationStructureCompatibility(this Device extendedHandle, AccelerationStructureVersion version)
        {
            try
            {
                CommandCache commandCache = default;
                SharpVk.Interop.Khronos.AccelerationStructureVersion* marshalledVersion = default;
                commandCache = extendedHandle.commandCache;
                marshalledVersion = (SharpVk.Interop.Khronos.AccelerationStructureVersion*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.AccelerationStructureVersion>());
                version.MarshalTo(marshalledVersion);
                SharpVk.Interop.Khronos.VkDeviceGetAccelerationStructureCompatibilityDelegate commandDelegate = commandCache.Cache.vkGetDeviceAccelerationStructureCompatibilityKHR;
                Result methodResult = commandDelegate(extendedHandle.Handle, marshalledVersion);
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
        /// </summary>
        /// <param name="extendedHandle">
        /// The Device handle to extend.
        /// </param>
        /// <param name="allocator">
        /// </param>
        public static unsafe DeferredOperation CreateDeferredOperation(this Device extendedHandle, AllocationCallbacks? allocator = default)
        {
            try
            {
                DeferredOperation result = default;
                CommandCache commandCache = default;
                SharpVk.Interop.AllocationCallbacks* marshalledAllocator = default;
                SharpVk.Interop.Khronos.DeferredOperation marshalledDeferredOperation = default;
                commandCache = extendedHandle.commandCache;
                if (allocator != null)
                {
                    marshalledAllocator = (SharpVk.Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<SharpVk.Interop.AllocationCallbacks>());
                    allocator.Value.MarshalTo(marshalledAllocator);
                }
                else
                {
                    marshalledAllocator = default;
                }
                SharpVk.Interop.Khronos.VkDeviceCreateDeferredOperationDelegate commandDelegate = commandCache.Cache.vkCreateDeferredOperationKHR;
                Result methodResult = commandDelegate(extendedHandle.Handle, marshalledAllocator, &marshalledDeferredOperation);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = new DeferredOperation(extendedHandle, marshalledDeferredOperation);
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
        /// The Device handle to extend.
        /// </param>
        /// <param name="pipelineInfo">
        /// </param>
        public static unsafe PipelineExecutableProperties[] GetPipelineExecutableProperties(this Device extendedHandle, PipelineInfo pipelineInfo)
        {
            try
            {
                PipelineExecutableProperties[] result = default;
                uint marshalledExecutableCount = default;
                CommandCache commandCache = default;
                SharpVk.Interop.Khronos.PipelineInfo* marshalledPipelineInfo = default;
                SharpVk.Interop.Khronos.PipelineExecutableProperties* marshalledProperties = default;
                commandCache = extendedHandle.commandCache;
                marshalledPipelineInfo = (SharpVk.Interop.Khronos.PipelineInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.PipelineInfo>());
                pipelineInfo.MarshalTo(marshalledPipelineInfo);
                SharpVk.Interop.Khronos.VkDeviceGetPipelineExecutablePropertiesDelegate commandDelegate = commandCache.Cache.vkGetPipelineExecutablePropertiesKHR;
                Result methodResult = commandDelegate(extendedHandle.Handle, marshalledPipelineInfo, &marshalledExecutableCount, marshalledProperties);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                marshalledProperties = (SharpVk.Interop.Khronos.PipelineExecutableProperties*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.PipelineExecutableProperties>((uint)(marshalledExecutableCount)));
                commandDelegate(extendedHandle.Handle, marshalledPipelineInfo, &marshalledExecutableCount, marshalledProperties);
                if (marshalledProperties != null)
                {
                    var fieldPointer = new PipelineExecutableProperties[(uint)(marshalledExecutableCount)];
                    for(int index = 0; index < (uint)(marshalledExecutableCount); index++)
                    {
                        fieldPointer[index] = PipelineExecutableProperties.MarshalFrom(&marshalledProperties[index]);
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
        /// The Device handle to extend.
        /// </param>
        /// <param name="executableInfo">
        /// </param>
        public static unsafe PipelineExecutableStatistic[] GetPipelineExecutableStatistics(this Device extendedHandle, PipelineExecutableInfo executableInfo)
        {
            try
            {
                PipelineExecutableStatistic[] result = default;
                uint marshalledStatisticCount = default;
                CommandCache commandCache = default;
                SharpVk.Interop.Khronos.PipelineExecutableInfo* marshalledExecutableInfo = default;
                SharpVk.Interop.Khronos.PipelineExecutableStatistic* marshalledStatistics = default;
                commandCache = extendedHandle.commandCache;
                marshalledExecutableInfo = (SharpVk.Interop.Khronos.PipelineExecutableInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.PipelineExecutableInfo>());
                executableInfo.MarshalTo(marshalledExecutableInfo);
                SharpVk.Interop.Khronos.VkDeviceGetPipelineExecutableStatisticsDelegate commandDelegate = commandCache.Cache.vkGetPipelineExecutableStatisticsKHR;
                Result methodResult = commandDelegate(extendedHandle.Handle, marshalledExecutableInfo, &marshalledStatisticCount, marshalledStatistics);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                marshalledStatistics = (SharpVk.Interop.Khronos.PipelineExecutableStatistic*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.PipelineExecutableStatistic>((uint)(marshalledStatisticCount)));
                commandDelegate(extendedHandle.Handle, marshalledExecutableInfo, &marshalledStatisticCount, marshalledStatistics);
                if (marshalledStatistics != null)
                {
                    var fieldPointer = new PipelineExecutableStatistic[(uint)(marshalledStatisticCount)];
                    for(int index = 0; index < (uint)(marshalledStatisticCount); index++)
                    {
                        fieldPointer[index] = PipelineExecutableStatistic.MarshalFrom(&marshalledStatistics[index]);
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
        /// The Device handle to extend.
        /// </param>
        /// <param name="executableInfo">
        /// </param>
        public static unsafe PipelineExecutableInternalRepresentation[] GetPipelineExecutableInternalRepresentations(this Device extendedHandle, PipelineExecutableInfo executableInfo)
        {
            try
            {
                PipelineExecutableInternalRepresentation[] result = default;
                uint marshalledInternalRepresentationCount = default;
                CommandCache commandCache = default;
                SharpVk.Interop.Khronos.PipelineExecutableInfo* marshalledExecutableInfo = default;
                SharpVk.Interop.Khronos.PipelineExecutableInternalRepresentation* marshalledInternalRepresentations = default;
                commandCache = extendedHandle.commandCache;
                marshalledExecutableInfo = (SharpVk.Interop.Khronos.PipelineExecutableInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.PipelineExecutableInfo>());
                executableInfo.MarshalTo(marshalledExecutableInfo);
                SharpVk.Interop.Khronos.VkDeviceGetPipelineExecutableInternalRepresentationsDelegate commandDelegate = commandCache.Cache.vkGetPipelineExecutableInternalRepresentationsKHR;
                Result methodResult = commandDelegate(extendedHandle.Handle, marshalledExecutableInfo, &marshalledInternalRepresentationCount, marshalledInternalRepresentations);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                marshalledInternalRepresentations = (SharpVk.Interop.Khronos.PipelineExecutableInternalRepresentation*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.PipelineExecutableInternalRepresentation>((uint)(marshalledInternalRepresentationCount)));
                commandDelegate(extendedHandle.Handle, marshalledExecutableInfo, &marshalledInternalRepresentationCount, marshalledInternalRepresentations);
                if (marshalledInternalRepresentations != null)
                {
                    var fieldPointer = new PipelineExecutableInternalRepresentation[(uint)(marshalledInternalRepresentationCount)];
                    for(int index = 0; index < (uint)(marshalledInternalRepresentationCount); index++)
                    {
                        fieldPointer[index] = PipelineExecutableInternalRepresentation.MarshalFrom(&marshalledInternalRepresentations[index]);
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
