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
    public static class DeviceExtensions
    {
        /// <summary>
        /// Set the power state of a display.
        /// </summary>
        /// <param name="extendedHandle">
        /// The Device handle to extend.
        /// </param>
        /// <param name="display">
        /// </param>
        /// <param name="displayPowerInfo">
        /// </param>
        public static unsafe void DisplayPowerControl(this Device extendedHandle, Khronos.Display display, DisplayPowerInfo displayPowerInfo)
        {
            try
            {
                CommandCache commandCache = default;
                SharpVk.Interop.Multivendor.DisplayPowerInfo* marshalledDisplayPowerInfo = default;
                commandCache = extendedHandle.commandCache;
                marshalledDisplayPowerInfo = (SharpVk.Interop.Multivendor.DisplayPowerInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.DisplayPowerInfo>());
                displayPowerInfo.MarshalTo(marshalledDisplayPowerInfo);
                SharpVk.Interop.Multivendor.VkDeviceDisplayPowerControlDelegate commandDelegate = commandCache.Cache.vkDisplayPowerControlEXT;
                Result methodResult = commandDelegate(extendedHandle.Handle, display?.Handle ?? default, marshalledDisplayPowerInfo);
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
        /// Signal a fence when a device event occurs.
        /// </summary>
        /// <param name="extendedHandle">
        /// The Device handle to extend.
        /// </param>
        /// <param name="deviceEventInfo">
        /// </param>
        /// <param name="allocator">
        /// An optional AllocationCallbacks instance that controls host memory
        /// allocation.
        /// </param>
        public static unsafe Fence RegisterEvent(this Device extendedHandle, DeviceEventInfo deviceEventInfo, AllocationCallbacks? allocator = default)
        {
            try
            {
                Fence result = default;
                CommandCache commandCache = default;
                SharpVk.Interop.Multivendor.DeviceEventInfo* marshalledDeviceEventInfo = default;
                SharpVk.Interop.AllocationCallbacks* marshalledAllocator = default;
                SharpVk.Interop.Fence marshalledFence = default;
                commandCache = extendedHandle.commandCache;
                marshalledDeviceEventInfo = (SharpVk.Interop.Multivendor.DeviceEventInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.DeviceEventInfo>());
                deviceEventInfo.MarshalTo(marshalledDeviceEventInfo);
                if (allocator != null)
                {
                    marshalledAllocator = (SharpVk.Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<SharpVk.Interop.AllocationCallbacks>());
                    allocator.Value.MarshalTo(marshalledAllocator);
                }
                else
                {
                    marshalledAllocator = default;
                }
                SharpVk.Interop.Multivendor.VkDeviceRegisterEventDelegate commandDelegate = commandCache.Cache.vkRegisterDeviceEventEXT;
                Result methodResult = commandDelegate(extendedHandle.Handle, marshalledDeviceEventInfo, marshalledAllocator, &marshalledFence);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = new Fence(extendedHandle, marshalledFence);
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Signal a fence when a display event occurs.
        /// </summary>
        /// <param name="extendedHandle">
        /// The Device handle to extend.
        /// </param>
        /// <param name="display">
        /// </param>
        /// <param name="displayEventInfo">
        /// </param>
        /// <param name="allocator">
        /// An optional AllocationCallbacks instance that controls host memory
        /// allocation.
        /// </param>
        public static unsafe Fence RegisterDisplayEvent(this Device extendedHandle, Khronos.Display display, DisplayEventInfo displayEventInfo, AllocationCallbacks? allocator = default)
        {
            try
            {
                Fence result = default;
                CommandCache commandCache = default;
                SharpVk.Interop.Multivendor.DisplayEventInfo* marshalledDisplayEventInfo = default;
                SharpVk.Interop.AllocationCallbacks* marshalledAllocator = default;
                SharpVk.Interop.Fence marshalledFence = default;
                commandCache = extendedHandle.commandCache;
                marshalledDisplayEventInfo = (SharpVk.Interop.Multivendor.DisplayEventInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.DisplayEventInfo>());
                displayEventInfo.MarshalTo(marshalledDisplayEventInfo);
                if (allocator != null)
                {
                    marshalledAllocator = (SharpVk.Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<SharpVk.Interop.AllocationCallbacks>());
                    allocator.Value.MarshalTo(marshalledAllocator);
                }
                else
                {
                    marshalledAllocator = default;
                }
                SharpVk.Interop.Multivendor.VkDeviceRegisterDisplayEventDelegate commandDelegate = commandCache.Cache.vkRegisterDisplayEventEXT;
                Result methodResult = commandDelegate(extendedHandle.Handle, display?.Handle ?? default, marshalledDisplayEventInfo, marshalledAllocator, &marshalledFence);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = new Fence(extendedHandle, marshalledFence);
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
        /// <param name="swapchains">
        /// </param>
        /// <param name="metadata">
        /// </param>
        public static unsafe void SetHdrMetadata(this Device extendedHandle, ArrayProxy<Khronos.Swapchain>? swapchains, ArrayProxy<HdrMetadata>? metadata)
        {
            try
            {
                CommandCache commandCache = default;
                SharpVk.Interop.Khronos.Swapchain* marshalledSwapchains = default;
                SharpVk.Interop.Multivendor.HdrMetadata* marshalledMetadata = default;
                commandCache = extendedHandle.commandCache;
                if (swapchains.IsNull())
                {
                    marshalledSwapchains = null;
                }
                else
                {
                    if (swapchains.Value.Contents == ProxyContents.Single)
                    {
                        marshalledSwapchains = (SharpVk.Interop.Khronos.Swapchain*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.Swapchain>());
                        *(SharpVk.Interop.Khronos.Swapchain*)(marshalledSwapchains) = swapchains.Value.GetSingleValue()?.Handle ?? default;
                    }
                    else
                    {
                        var fieldPointer = (SharpVk.Interop.Khronos.Swapchain*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.Khronos.Swapchain>(Interop.HeapUtil.GetLength(swapchains.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(swapchains.Value)); index++)
                        {
                            fieldPointer[index] = swapchains.Value[index]?.Handle ?? default;
                        }
                        marshalledSwapchains = fieldPointer;
                    }
                }
                if (metadata.IsNull())
                {
                    marshalledMetadata = null;
                }
                else
                {
                    if (metadata.Value.Contents == ProxyContents.Single)
                    {
                        marshalledMetadata = (SharpVk.Interop.Multivendor.HdrMetadata*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.HdrMetadata>());
                        metadata.Value.GetSingleValue().MarshalTo(&*(SharpVk.Interop.Multivendor.HdrMetadata*)(marshalledMetadata));
                    }
                    else
                    {
                        var fieldPointer = (SharpVk.Interop.Multivendor.HdrMetadata*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.Multivendor.HdrMetadata>(Interop.HeapUtil.GetLength(metadata.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(metadata.Value)); index++)
                        {
                            metadata.Value[index].MarshalTo(&fieldPointer[index]);
                        }
                        marshalledMetadata = fieldPointer;
                    }
                }
                SharpVk.Interop.Multivendor.VkDeviceSetHdrMetadataDelegate commandDelegate = commandCache.Cache.vkSetHdrMetadataEXT;
                commandDelegate(extendedHandle.Handle, (uint)(Interop.HeapUtil.GetLength(swapchains)), marshalledSwapchains, marshalledMetadata);
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
        /// <param name="nameInfo">
        /// </param>
        public static unsafe void SetDebugUtilsObjectName(this Device extendedHandle, DebugUtilsObjectNameInfo nameInfo)
        {
            try
            {
                CommandCache commandCache = default;
                SharpVk.Interop.Multivendor.DebugUtilsObjectNameInfo* marshalledNameInfo = default;
                commandCache = extendedHandle.commandCache;
                marshalledNameInfo = (SharpVk.Interop.Multivendor.DebugUtilsObjectNameInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.DebugUtilsObjectNameInfo>());
                nameInfo.MarshalTo(marshalledNameInfo);
                SharpVk.Interop.Multivendor.VkDeviceSetDebugUtilsObjectNameDelegate commandDelegate = commandCache.Cache.vkSetDebugUtilsObjectNameEXT;
                Result methodResult = commandDelegate(extendedHandle.Handle, marshalledNameInfo);
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
        /// <param name="tagInfo">
        /// </param>
        public static unsafe void SetDebugUtilsObjectTag(this Device extendedHandle, DebugUtilsObjectTagInfo tagInfo)
        {
            try
            {
                CommandCache commandCache = default;
                SharpVk.Interop.Multivendor.DebugUtilsObjectTagInfo* marshalledTagInfo = default;
                commandCache = extendedHandle.commandCache;
                marshalledTagInfo = (SharpVk.Interop.Multivendor.DebugUtilsObjectTagInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.DebugUtilsObjectTagInfo>());
                tagInfo.MarshalTo(marshalledTagInfo);
                SharpVk.Interop.Multivendor.VkDeviceSetDebugUtilsObjectTagDelegate commandDelegate = commandCache.Cache.vkSetDebugUtilsObjectTagEXT;
                Result methodResult = commandDelegate(extendedHandle.Handle, marshalledTagInfo);
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
        /// <param name="flags">
        /// </param>
        /// <param name="initialData">
        /// </param>
        /// <param name="allocator">
        /// </param>
        public static unsafe ValidationCache CreateValidationCache(this Device extendedHandle, ArrayProxy<byte>? initialData, ValidationCacheCreateFlags? flags = default, AllocationCallbacks? allocator = default)
        {
            try
            {
                ValidationCache result = default;
                CommandCache commandCache = default;
                SharpVk.Interop.Multivendor.ValidationCacheCreateInfo* marshalledCreateInfo = default;
                void* vkValidationCacheCreateInfoEXTNextPointer = default;
                SharpVk.Interop.AllocationCallbacks* marshalledAllocator = default;
                SharpVk.Interop.Multivendor.ValidationCache marshalledValidationCache = default;
                commandCache = extendedHandle.commandCache;
                marshalledCreateInfo = (SharpVk.Interop.Multivendor.ValidationCacheCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.ValidationCacheCreateInfo>());
                marshalledCreateInfo->SType = StructureType.ValidationCacheCreateInfo;
                marshalledCreateInfo->Next = vkValidationCacheCreateInfoEXTNextPointer;
                if (flags != null)
                {
                    marshalledCreateInfo->Flags = flags.Value;
                }
                else
                {
                    marshalledCreateInfo->Flags = default;
                }
                marshalledCreateInfo->InitialDataSize = (HostSize)(Interop.HeapUtil.GetLength(initialData));
                if (initialData.IsNull())
                {
                    marshalledCreateInfo->InitialData = null;
                }
                else
                {
                    if (initialData.Value.Contents == ProxyContents.Single)
                    {
                        marshalledCreateInfo->InitialData = (byte*)(Interop.HeapUtil.Allocate<byte>());
                        *(byte*)(marshalledCreateInfo->InitialData) = initialData.Value.GetSingleValue();
                    }
                    else
                    {
                        var fieldPointer = (byte*)(Interop.HeapUtil.AllocateAndClear<byte>(Interop.HeapUtil.GetLength(initialData.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(initialData.Value)); index++)
                        {
                            fieldPointer[index] = initialData.Value[index];
                        }
                        marshalledCreateInfo->InitialData = fieldPointer;
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
                SharpVk.Interop.Multivendor.VkDeviceCreateValidationCacheDelegate commandDelegate = commandCache.Cache.vkCreateValidationCacheEXT;
                Result methodResult = commandDelegate(extendedHandle.Handle, marshalledCreateInfo, marshalledAllocator, &marshalledValidationCache);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = new ValidationCache(extendedHandle, marshalledValidationCache);
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
        /// <param name="hostPointer">
        /// </param>
        public static unsafe MemoryHostPointerProperties GetMemoryHostPointerProperties(this Device extendedHandle, ExternalMemoryHandleTypeFlags handleType, IntPtr hostPointer)
        {
            try
            {
                MemoryHostPointerProperties result = default;
                CommandCache commandCache = default;
                SharpVk.Interop.Multivendor.MemoryHostPointerProperties marshalledMemoryHostPointerProperties = default;
                commandCache = extendedHandle.commandCache;
                SharpVk.Interop.Multivendor.VkDeviceGetMemoryHostPointerPropertiesDelegate commandDelegate = commandCache.Cache.vkGetMemoryHostPointerPropertiesEXT;
                Result methodResult = commandDelegate(extendedHandle.Handle, handleType, hostPointer.ToPointer(), &marshalledMemoryHostPointerProperties);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = MemoryHostPointerProperties.MarshalFrom(&marshalledMemoryHostPointerProperties);
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
        /// <param name="timestampInfos">
        /// </param>
        /// <param name="timestamps">
        /// </param>
        public static unsafe ulong GetCalibratedTimestamps(this Device extendedHandle, ArrayProxy<CalibratedTimestampInfo>? timestampInfos, ArrayProxy<ulong>? timestamps)
        {
            try
            {
                ulong result = default;
                CommandCache commandCache = default;
                SharpVk.Interop.Multivendor.CalibratedTimestampInfo* marshalledTimestampInfos = default;
                ulong* marshalledTimestamps = default;
                ulong marshalledMaxDeviation = default;
                commandCache = extendedHandle.commandCache;
                if (timestampInfos.IsNull())
                {
                    marshalledTimestampInfos = null;
                }
                else
                {
                    if (timestampInfos.Value.Contents == ProxyContents.Single)
                    {
                        marshalledTimestampInfos = (SharpVk.Interop.Multivendor.CalibratedTimestampInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.CalibratedTimestampInfo>());
                        timestampInfos.Value.GetSingleValue().MarshalTo(&*(SharpVk.Interop.Multivendor.CalibratedTimestampInfo*)(marshalledTimestampInfos));
                    }
                    else
                    {
                        var fieldPointer = (SharpVk.Interop.Multivendor.CalibratedTimestampInfo*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.Multivendor.CalibratedTimestampInfo>(Interop.HeapUtil.GetLength(timestampInfos.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(timestampInfos.Value)); index++)
                        {
                            timestampInfos.Value[index].MarshalTo(&fieldPointer[index]);
                        }
                        marshalledTimestampInfos = fieldPointer;
                    }
                }
                if (timestamps.IsNull())
                {
                    marshalledTimestamps = null;
                }
                else
                {
                    if (timestamps.Value.Contents == ProxyContents.Single)
                    {
                        marshalledTimestamps = (ulong*)(Interop.HeapUtil.Allocate<ulong>());
                        *(ulong*)(marshalledTimestamps) = timestamps.Value.GetSingleValue();
                    }
                    else
                    {
                        var fieldPointer = (ulong*)(Interop.HeapUtil.AllocateAndClear<ulong>(Interop.HeapUtil.GetLength(timestamps.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(timestamps.Value)); index++)
                        {
                            fieldPointer[index] = timestamps.Value[index];
                        }
                        marshalledTimestamps = fieldPointer;
                    }
                }
                SharpVk.Interop.Multivendor.VkDeviceGetCalibratedTimestampsDelegate commandDelegate = commandCache.Cache.vkGetCalibratedTimestampsEXT;
                Result methodResult = commandDelegate(extendedHandle.Handle, (uint)(Interop.HeapUtil.GetLength(timestampInfos)), marshalledTimestampInfos, marshalledTimestamps, &marshalledMaxDeviation);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = marshalledMaxDeviation;
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Query device group present capabilities for a surface
        /// </summary>
        /// <param name="extendedHandle">
        /// The Device handle to extend.
        /// </param>
        /// <param name="surfaceInfo">
        /// An instance of the VkPhysicalDeviceSurfaceInfo2KHR structure,
        /// describing the surface and other fixed parameters that would be
        /// consumed by vkCreateSwapchainKHR.
        /// </param>
        public static unsafe Khronos.DeviceGroupPresentModeFlags GetGroupSurfacePresentModes2(this Device extendedHandle, Khronos.PhysicalDeviceSurfaceInfo2 surfaceInfo)
        {
            try
            {
                Khronos.DeviceGroupPresentModeFlags result = default;
                CommandCache commandCache = default;
                SharpVk.Interop.Khronos.PhysicalDeviceSurfaceInfo2* marshalledSurfaceInfo = default;
                Khronos.DeviceGroupPresentModeFlags marshalledModes = default;
                commandCache = extendedHandle.commandCache;
                marshalledSurfaceInfo = (SharpVk.Interop.Khronos.PhysicalDeviceSurfaceInfo2*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.PhysicalDeviceSurfaceInfo2>());
                surfaceInfo.MarshalTo(marshalledSurfaceInfo);
                SharpVk.Interop.Multivendor.VkDeviceGetGroupSurfacePresentModes2Delegate commandDelegate = commandCache.Cache.vkGetDeviceGroupSurfacePresentModes2EXT;
                Result methodResult = commandDelegate(extendedHandle.Handle, marshalledSurfaceInfo, &marshalledModes);
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
        /// </summary>
        /// <param name="extendedHandle">
        /// The Device handle to extend.
        /// </param>
        /// <param name="flags">
        /// </param>
        /// <param name="allocator">
        /// </param>
        public static unsafe PrivateDataSlot CreatePrivateDataSlot(this Device extendedHandle, PrivateDataSlotCreateFlags flags, AllocationCallbacks? allocator = default)
        {
            try
            {
                PrivateDataSlot result = default;
                CommandCache commandCache = default;
                SharpVk.Interop.Multivendor.PrivateDataSlotCreateInfo* marshalledCreateInfo = default;
                void* vkPrivateDataSlotCreateInfoEXTNextPointer = default;
                SharpVk.Interop.AllocationCallbacks* marshalledAllocator = default;
                SharpVk.Interop.Multivendor.PrivateDataSlot marshalledPrivateDataSlot = default;
                commandCache = extendedHandle.commandCache;
                marshalledCreateInfo = (SharpVk.Interop.Multivendor.PrivateDataSlotCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.PrivateDataSlotCreateInfo>());
                marshalledCreateInfo->SType = StructureType.PrivateDataSlotCreateInfo;
                marshalledCreateInfo->Next = vkPrivateDataSlotCreateInfoEXTNextPointer;
                marshalledCreateInfo->Flags = flags;
                if (allocator != null)
                {
                    marshalledAllocator = (SharpVk.Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<SharpVk.Interop.AllocationCallbacks>());
                    allocator.Value.MarshalTo(marshalledAllocator);
                }
                else
                {
                    marshalledAllocator = default;
                }
                SharpVk.Interop.Multivendor.VkDeviceCreatePrivateDataSlotDelegate commandDelegate = commandCache.Cache.vkCreatePrivateDataSlotEXT;
                Result methodResult = commandDelegate(extendedHandle.Handle, marshalledCreateInfo, marshalledAllocator, &marshalledPrivateDataSlot);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = new PrivateDataSlot(extendedHandle, marshalledPrivateDataSlot);
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
        /// <param name="objectType">
        /// </param>
        /// <param name="objectHandle">
        /// </param>
        /// <param name="privateDataSlot">
        /// </param>
        /// <param name="data">
        /// </param>
        public static unsafe void SetPrivateData(this Device extendedHandle, ObjectType objectType, ulong objectHandle, PrivateDataSlot privateDataSlot, ulong data)
        {
            try
            {
                CommandCache commandCache = default;
                commandCache = extendedHandle.commandCache;
                SharpVk.Interop.Multivendor.VkDeviceSetPrivateDataDelegate commandDelegate = commandCache.Cache.vkSetPrivateDataEXT;
                Result methodResult = commandDelegate(extendedHandle.Handle, objectType, objectHandle, privateDataSlot?.Handle ?? default, data);
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
        /// <param name="objectType">
        /// </param>
        /// <param name="objectHandle">
        /// </param>
        /// <param name="privateDataSlot">
        /// </param>
        public static unsafe ulong GetPrivateData(this Device extendedHandle, ObjectType objectType, ulong objectHandle, PrivateDataSlot privateDataSlot)
        {
            try
            {
                ulong result = default;
                CommandCache commandCache = default;
                ulong marshalledData = default;
                commandCache = extendedHandle.commandCache;
                SharpVk.Interop.Multivendor.VkDeviceGetPrivateDataDelegate commandDelegate = commandCache.Cache.vkGetPrivateDataEXT;
                commandDelegate(extendedHandle.Handle, objectType, objectHandle, privateDataSlot?.Handle ?? default, &marshalledData);
                result = marshalledData;
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
    }
}
