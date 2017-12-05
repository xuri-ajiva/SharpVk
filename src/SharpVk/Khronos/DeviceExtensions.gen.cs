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
        /// <param name="allocator">
        /// An optional AllocationCallbacks instance that controls host memory
        /// allocation.
        /// </param>
        public static unsafe SharpVk.Khronos.Swapchain CreateSwapchain(this SharpVk.Device extendedHandle, SharpVk.Khronos.Surface surface, uint minImageCount, SharpVk.Format imageFormat, SharpVk.Khronos.ColorSpace imageColorSpace, SharpVk.Extent2D imageExtent, uint imageArrayLayers, SharpVk.ImageUsageFlags imageUsage, SharpVk.SharingMode imageSharingMode, ArrayProxy<uint>? queueFamilyIndices, SharpVk.Khronos.SurfaceTransformFlags preTransform, SharpVk.Khronos.CompositeAlphaFlags compositeAlpha, SharpVk.Khronos.PresentMode presentMode, bool clipped, SharpVk.Khronos.Swapchain oldSwapchain, SharpVk.Khronos.SwapchainCreateFlags? flags = default(SharpVk.Khronos.SwapchainCreateFlags?), SharpVk.Multivendor.SwapchainCounterCreateInfo? swapchainCounterCreateInfoExt = null, SharpVk.Khronos.Experimental.DeviceGroupSwapchainCreateInfo? deviceGroupSwapchainCreateInfoKhx = null, SharpVk.AllocationCallbacks? allocator = default(SharpVk.AllocationCallbacks?))
        {
            try
            {
                SharpVk.Khronos.Swapchain result = default(SharpVk.Khronos.Swapchain);
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Khronos.SwapchainCreateInfo* marshalledCreateInfo = default(SharpVk.Interop.Khronos.SwapchainCreateInfo*);
                SharpVk.Interop.AllocationCallbacks* marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                SharpVk.Interop.Khronos.Swapchain marshalledSwapchain = default(SharpVk.Interop.Khronos.Swapchain);
                commandCache = extendedHandle.commandCache;
                marshalledCreateInfo = (SharpVk.Interop.Khronos.SwapchainCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.SwapchainCreateInfo>());
                marshalledCreateInfo->SType = StructureType.SwapchainCreateInfo;
                marshalledCreateInfo->Next = null;
                if (flags != null)
                {
                    marshalledCreateInfo->Flags = flags.Value;
                }
                else
                {
                    marshalledCreateInfo->Flags = default(SharpVk.Khronos.SwapchainCreateFlags);
                }
                marshalledCreateInfo->Surface = surface?.handle ?? default(SharpVk.Interop.Khronos.Surface);
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
                marshalledCreateInfo->OldSwapchain = oldSwapchain?.handle ?? default(SharpVk.Interop.Khronos.Swapchain);
                if (allocator != null)
                {
                    marshalledAllocator = (SharpVk.Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<SharpVk.Interop.AllocationCallbacks>());
                    allocator.Value.MarshalTo(marshalledAllocator);
                }
                else
                {
                    marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                }
                SharpVk.Interop.Khronos.VkDeviceCreateSwapchainDelegate commandDelegate = commandCache.GetCommandDelegate<SharpVk.Interop.Khronos.VkDeviceCreateSwapchainDelegate>("vkCreateSwapchainKHR", "device");
                Result methodResult = commandDelegate(extendedHandle.handle, marshalledCreateInfo, marshalledAllocator, &marshalledSwapchain);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = new SharpVk.Khronos.Swapchain(extendedHandle, marshalledSwapchain);
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
        /// <param name="allocator">
        /// An optional AllocationCallbacks instance that controls host memory
        /// allocation.
        /// </param>
        public static unsafe SharpVk.Khronos.Swapchain[] CreateSharedSwapchains(this SharpVk.Device extendedHandle, ArrayProxy<SharpVk.Khronos.SwapchainCreateInfo>? createInfos, SharpVk.AllocationCallbacks? allocator = default(SharpVk.AllocationCallbacks?))
        {
            try
            {
                SharpVk.Khronos.Swapchain[] result = default(SharpVk.Khronos.Swapchain[]);
                CommandCache commandCache = default(CommandCache);
                uint swapchainCount = default(uint);
                SharpVk.Interop.Khronos.SwapchainCreateInfo* marshalledCreateInfos = default(SharpVk.Interop.Khronos.SwapchainCreateInfo*);
                SharpVk.Interop.AllocationCallbacks* marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                SharpVk.Interop.Khronos.Swapchain* marshalledSwapchains = default(SharpVk.Interop.Khronos.Swapchain*);
                commandCache = extendedHandle.commandCache;
                swapchainCount = (uint)(Interop.HeapUtil.GetLength(createInfos));
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
                    marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                }
                marshalledSwapchains = (SharpVk.Interop.Khronos.Swapchain*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.Swapchain>(swapchainCount));
                SharpVk.Interop.Khronos.VkDeviceCreateSharedSwapchainsDelegate commandDelegate = commandCache.GetCommandDelegate<SharpVk.Interop.Khronos.VkDeviceCreateSharedSwapchainsDelegate>("vkCreateSharedSwapchainsKHR", "device");
                Result methodResult = commandDelegate(extendedHandle.handle, swapchainCount, marshalledCreateInfos, marshalledAllocator, marshalledSwapchains);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                if (marshalledSwapchains != null)
                {
                    var fieldPointer = new SharpVk.Khronos.Swapchain[(uint)(swapchainCount)];
                    for(int index = 0; index < (uint)(swapchainCount); index++)
                    {
                        fieldPointer[index] = new SharpVk.Khronos.Swapchain(extendedHandle, marshalledSwapchains[index]);
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
        /// The Device handle to extend.
        /// </param>
        public static unsafe IntPtr GetMemoryWin32Handle(this SharpVk.Device extendedHandle, SharpVk.Khronos.MemoryGetWin32HandleInfo getWin32HandleInfo)
        {
            try
            {
                IntPtr result = default(IntPtr);
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Khronos.MemoryGetWin32HandleInfo* marshalledGetWin32HandleInfo = default(SharpVk.Interop.Khronos.MemoryGetWin32HandleInfo*);
                IntPtr marshalledHandle = default(IntPtr);
                commandCache = extendedHandle.commandCache;
                marshalledGetWin32HandleInfo = (SharpVk.Interop.Khronos.MemoryGetWin32HandleInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.MemoryGetWin32HandleInfo>());
                getWin32HandleInfo.MarshalTo(marshalledGetWin32HandleInfo);
                SharpVk.Interop.Khronos.VkDeviceGetMemoryWin32HandleDelegate commandDelegate = commandCache.GetCommandDelegate<SharpVk.Interop.Khronos.VkDeviceGetMemoryWin32HandleDelegate>("vkGetMemoryWin32HandleKHR", "device");
                Result methodResult = commandDelegate(extendedHandle.handle, marshalledGetWin32HandleInfo, &marshalledHandle);
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
        /// 
        /// </summary>
        /// <param name="extendedHandle">
        /// The Device handle to extend.
        /// </param>
        public static unsafe SharpVk.Khronos.MemoryWin32HandleProperties GetMemoryWin32HandleProperties(this SharpVk.Device extendedHandle, SharpVk.Khronos.ExternalMemoryHandleTypeFlags handleType, IntPtr handle)
        {
            try
            {
                SharpVk.Khronos.MemoryWin32HandleProperties result = default(SharpVk.Khronos.MemoryWin32HandleProperties);
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Khronos.MemoryWin32HandleProperties marshalledMemoryWin32HandleProperties = default(SharpVk.Interop.Khronos.MemoryWin32HandleProperties);
                commandCache = extendedHandle.commandCache;
                SharpVk.Interop.Khronos.VkDeviceGetMemoryWin32HandlePropertiesDelegate commandDelegate = commandCache.GetCommandDelegate<SharpVk.Interop.Khronos.VkDeviceGetMemoryWin32HandlePropertiesDelegate>("vkGetMemoryWin32HandlePropertiesKHR", "device");
                Result methodResult = commandDelegate(extendedHandle.handle, handleType, handle, &marshalledMemoryWin32HandleProperties);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = SharpVk.Khronos.MemoryWin32HandleProperties.MarshalFrom(&marshalledMemoryWin32HandleProperties);
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
        /// The Device handle to extend.
        /// </param>
        public static unsafe int GetMemoryFileDescriptor(this SharpVk.Device extendedHandle, SharpVk.Khronos.MemoryGetFileDescriptorInfo getFileDescriptorInfo)
        {
            try
            {
                int result = default(int);
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Khronos.MemoryGetFileDescriptorInfo* marshalledGetFileDescriptorInfo = default(SharpVk.Interop.Khronos.MemoryGetFileDescriptorInfo*);
                int marshalledFileDescriptor = default(int);
                commandCache = extendedHandle.commandCache;
                marshalledGetFileDescriptorInfo = (SharpVk.Interop.Khronos.MemoryGetFileDescriptorInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.MemoryGetFileDescriptorInfo>());
                getFileDescriptorInfo.MarshalTo(marshalledGetFileDescriptorInfo);
                SharpVk.Interop.Khronos.VkDeviceGetMemoryFileDescriptorDelegate commandDelegate = commandCache.GetCommandDelegate<SharpVk.Interop.Khronos.VkDeviceGetMemoryFileDescriptorDelegate>("vkGetMemoryFdKHR", "device");
                Result methodResult = commandDelegate(extendedHandle.handle, marshalledGetFileDescriptorInfo, &marshalledFileDescriptor);
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
        /// 
        /// </summary>
        /// <param name="extendedHandle">
        /// The Device handle to extend.
        /// </param>
        public static unsafe SharpVk.Khronos.MemoryFileDescriptorProperties GetMemoryFileDescriptorProperties(this SharpVk.Device extendedHandle, SharpVk.Khronos.ExternalMemoryHandleTypeFlags handleType, int fileDescriptor)
        {
            try
            {
                SharpVk.Khronos.MemoryFileDescriptorProperties result = default(SharpVk.Khronos.MemoryFileDescriptorProperties);
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Khronos.MemoryFileDescriptorProperties marshalledMemoryFileDescriptorProperties = default(SharpVk.Interop.Khronos.MemoryFileDescriptorProperties);
                commandCache = extendedHandle.commandCache;
                SharpVk.Interop.Khronos.VkDeviceGetMemoryFileDescriptorPropertiesDelegate commandDelegate = commandCache.GetCommandDelegate<SharpVk.Interop.Khronos.VkDeviceGetMemoryFileDescriptorPropertiesDelegate>("vkGetMemoryFdPropertiesKHR", "device");
                Result methodResult = commandDelegate(extendedHandle.handle, handleType, fileDescriptor, &marshalledMemoryFileDescriptorProperties);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = SharpVk.Khronos.MemoryFileDescriptorProperties.MarshalFrom(&marshalledMemoryFileDescriptorProperties);
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
        /// The Device handle to extend.
        /// </param>
        public static unsafe void ImportSemaphoreWin32Handle(this SharpVk.Device extendedHandle, SharpVk.Khronos.ImportSemaphoreWin32HandleInfo importSemaphoreWin32HandleInfo)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Khronos.ImportSemaphoreWin32HandleInfo* marshalledImportSemaphoreWin32HandleInfo = default(SharpVk.Interop.Khronos.ImportSemaphoreWin32HandleInfo*);
                commandCache = extendedHandle.commandCache;
                marshalledImportSemaphoreWin32HandleInfo = (SharpVk.Interop.Khronos.ImportSemaphoreWin32HandleInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.ImportSemaphoreWin32HandleInfo>());
                importSemaphoreWin32HandleInfo.MarshalTo(marshalledImportSemaphoreWin32HandleInfo);
                SharpVk.Interop.Khronos.VkDeviceImportSemaphoreWin32HandleDelegate commandDelegate = commandCache.GetCommandDelegate<SharpVk.Interop.Khronos.VkDeviceImportSemaphoreWin32HandleDelegate>("vkImportSemaphoreWin32HandleKHR", "device");
                Result methodResult = commandDelegate(extendedHandle.handle, marshalledImportSemaphoreWin32HandleInfo);
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
        /// 
        /// </summary>
        /// <param name="extendedHandle">
        /// The Device handle to extend.
        /// </param>
        public static unsafe IntPtr GetSemaphoreWin32Handle(this SharpVk.Device extendedHandle, SharpVk.Khronos.SemaphoreGetWin32HandleInfo getWin32HandleInfo)
        {
            try
            {
                IntPtr result = default(IntPtr);
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Khronos.SemaphoreGetWin32HandleInfo* marshalledGetWin32HandleInfo = default(SharpVk.Interop.Khronos.SemaphoreGetWin32HandleInfo*);
                IntPtr marshalledHandle = default(IntPtr);
                commandCache = extendedHandle.commandCache;
                marshalledGetWin32HandleInfo = (SharpVk.Interop.Khronos.SemaphoreGetWin32HandleInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.SemaphoreGetWin32HandleInfo>());
                getWin32HandleInfo.MarshalTo(marshalledGetWin32HandleInfo);
                SharpVk.Interop.Khronos.VkDeviceGetSemaphoreWin32HandleDelegate commandDelegate = commandCache.GetCommandDelegate<SharpVk.Interop.Khronos.VkDeviceGetSemaphoreWin32HandleDelegate>("vkGetSemaphoreWin32HandleKHR", "device");
                Result methodResult = commandDelegate(extendedHandle.handle, marshalledGetWin32HandleInfo, &marshalledHandle);
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
        /// 
        /// </summary>
        /// <param name="extendedHandle">
        /// The Device handle to extend.
        /// </param>
        public static unsafe void ImportSemaphoreFileDescriptor(this SharpVk.Device extendedHandle, SharpVk.Khronos.ImportSemaphoreFileDescriptorInfo importSemaphoreFileDescriptorInfo)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Khronos.ImportSemaphoreFileDescriptorInfo* marshalledImportSemaphoreFileDescriptorInfo = default(SharpVk.Interop.Khronos.ImportSemaphoreFileDescriptorInfo*);
                commandCache = extendedHandle.commandCache;
                marshalledImportSemaphoreFileDescriptorInfo = (SharpVk.Interop.Khronos.ImportSemaphoreFileDescriptorInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.ImportSemaphoreFileDescriptorInfo>());
                importSemaphoreFileDescriptorInfo.MarshalTo(marshalledImportSemaphoreFileDescriptorInfo);
                SharpVk.Interop.Khronos.VkDeviceImportSemaphoreFileDescriptorDelegate commandDelegate = commandCache.GetCommandDelegate<SharpVk.Interop.Khronos.VkDeviceImportSemaphoreFileDescriptorDelegate>("vkImportSemaphoreFdKHR", "device");
                Result methodResult = commandDelegate(extendedHandle.handle, marshalledImportSemaphoreFileDescriptorInfo);
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
        /// 
        /// </summary>
        /// <param name="extendedHandle">
        /// The Device handle to extend.
        /// </param>
        public static unsafe int GetSemaphoreFileDescriptor(this SharpVk.Device extendedHandle, SharpVk.Khronos.SemaphoreGetFileDescriptorInfo getFileDescriptorInfo)
        {
            try
            {
                int result = default(int);
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Khronos.SemaphoreGetFileDescriptorInfo* marshalledGetFileDescriptorInfo = default(SharpVk.Interop.Khronos.SemaphoreGetFileDescriptorInfo*);
                int marshalledFileDescriptor = default(int);
                commandCache = extendedHandle.commandCache;
                marshalledGetFileDescriptorInfo = (SharpVk.Interop.Khronos.SemaphoreGetFileDescriptorInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.SemaphoreGetFileDescriptorInfo>());
                getFileDescriptorInfo.MarshalTo(marshalledGetFileDescriptorInfo);
                SharpVk.Interop.Khronos.VkDeviceGetSemaphoreFileDescriptorDelegate commandDelegate = commandCache.GetCommandDelegate<SharpVk.Interop.Khronos.VkDeviceGetSemaphoreFileDescriptorDelegate>("vkGetSemaphoreFdKHR", "device");
                Result methodResult = commandDelegate(extendedHandle.handle, marshalledGetFileDescriptorInfo, &marshalledFileDescriptor);
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
        /// Create a new descriptor update template.
        /// </summary>
        /// <param name="extendedHandle">
        /// The Device handle to extend.
        /// </param>
        /// <param name="flags">
        /// Reserved for future use.
        /// </param>
        /// <param name="templateType">
        /// Specifies the type of the descriptor update template. If set to
        /// VK_DESCRIPTOR_UPDATE_TEMPLATE_TYPE_DESCRIPTOR_SET_KHR it can only
        /// be used to update descriptor sets with a fixed descriptorSetLayout.
        /// If set to VK_DESCRIPTOR_UPDATE_TEMPLATE_TYPE_PUSH_DESCRIPTORS_KHR
        /// it can only be used to push descriptor sets using the provided
        /// pipelineBindPoint, pipelineLayout, and set number.
        /// </param>
        /// <param name="descriptorSetLayout">
        /// The descriptor set layout the parameter update template will be
        /// used with. All descriptor sets which are going to be updated
        /// through the newly created descriptor update template must be
        /// created with this layout. descriptorSetLayout is the descriptor set
        /// layout used to build the descriptor update template. All descriptor
        /// sets which are going to be updated through the newly created
        /// descriptor update template must be created with a layout that
        /// matches (is the same as, or defined identically to) this layout.
        /// This parameter is ignored if templateType is not
        /// VK_DESCRIPTOR_UPDATE_TEMPLATE_TYPE_DESCRIPTOR_SET_KHR.
        /// </param>
        /// <param name="pipelineBindPoint">
        /// A PipelineBindPoint indicating whether the descriptors will be used
        /// by graphics pipelines or compute pipelines. This parameter is
        /// ignored if templateType is not
        /// VK_DESCRIPTOR_UPDATE_TEMPLATE_TYPE_PUSH_DESCRIPTORS_KHR
        /// </param>
        /// <param name="pipelineLayout">
        /// A PipelineLayout object used to program the bindings. This
        /// parameter is ignored if templateType is not
        /// VK_DESCRIPTOR_UPDATE_TEMPLATE_TYPE_PUSH_DESCRIPTORS_KHR
        /// </param>
        /// <param name="set">
        /// The set number of the descriptor set in the pipeline layout that
        /// will be updated. This parameter is ignored if templateType is not
        /// VK_DESCRIPTOR_UPDATE_TEMPLATE_TYPE_PUSH_DESCRIPTORS_KHR ifndef::VK_KHR_push_descriptor[]
        /// </param>
        /// <param name="allocator">
        /// An optional AllocationCallbacks instance that controls host memory
        /// allocation.
        /// </param>
        public static unsafe SharpVk.Khronos.DescriptorUpdateTemplate CreateDescriptorUpdateTemplate(this SharpVk.Device extendedHandle, ArrayProxy<SharpVk.Khronos.DescriptorUpdateTemplateEntry>? descriptorUpdateEntries, SharpVk.Khronos.DescriptorUpdateTemplateType templateType, SharpVk.DescriptorSetLayout descriptorSetLayout, SharpVk.PipelineLayout pipelineLayout, SharpVk.Khronos.DescriptorUpdateTemplateCreateFlags? flags = default(SharpVk.Khronos.DescriptorUpdateTemplateCreateFlags?), SharpVk.PipelineBindPoint? pipelineBindPoint = default(SharpVk.PipelineBindPoint?), uint? set = default(uint?), SharpVk.AllocationCallbacks? allocator = default(SharpVk.AllocationCallbacks?))
        {
            try
            {
                SharpVk.Khronos.DescriptorUpdateTemplate result = default(SharpVk.Khronos.DescriptorUpdateTemplate);
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Khronos.DescriptorUpdateTemplateCreateInfo* marshalledCreateInfo = default(SharpVk.Interop.Khronos.DescriptorUpdateTemplateCreateInfo*);
                SharpVk.Interop.AllocationCallbacks* marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                SharpVk.Interop.Khronos.DescriptorUpdateTemplate marshalledDescriptorUpdateTemplate = default(SharpVk.Interop.Khronos.DescriptorUpdateTemplate);
                commandCache = extendedHandle.commandCache;
                marshalledCreateInfo = (SharpVk.Interop.Khronos.DescriptorUpdateTemplateCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.DescriptorUpdateTemplateCreateInfo>());
                marshalledCreateInfo->SType = StructureType.DescriptorUpdateTemplateCreateInfo;
                marshalledCreateInfo->Next = null;
                if (flags != null)
                {
                    marshalledCreateInfo->Flags = flags.Value;
                }
                else
                {
                    marshalledCreateInfo->Flags = default(SharpVk.Khronos.DescriptorUpdateTemplateCreateFlags);
                }
                marshalledCreateInfo->DescriptorUpdateEntryCount = (uint)(Interop.HeapUtil.GetLength(descriptorUpdateEntries));
                if (descriptorUpdateEntries.IsNull())
                {
                    marshalledCreateInfo->DescriptorUpdateEntries = null;
                }
                else
                {
                    if (descriptorUpdateEntries.Value.Contents == ProxyContents.Single)
                    {
                        marshalledCreateInfo->DescriptorUpdateEntries = (SharpVk.Khronos.DescriptorUpdateTemplateEntry*)(Interop.HeapUtil.Allocate<SharpVk.Khronos.DescriptorUpdateTemplateEntry>());
                        *(SharpVk.Khronos.DescriptorUpdateTemplateEntry*)(marshalledCreateInfo->DescriptorUpdateEntries) = descriptorUpdateEntries.Value.GetSingleValue();
                    }
                    else
                    {
                        var fieldPointer = (SharpVk.Khronos.DescriptorUpdateTemplateEntry*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Khronos.DescriptorUpdateTemplateEntry>(Interop.HeapUtil.GetLength(descriptorUpdateEntries.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(descriptorUpdateEntries.Value)); index++)
                        {
                            fieldPointer[index] = descriptorUpdateEntries.Value[index];
                        }
                        marshalledCreateInfo->DescriptorUpdateEntries = fieldPointer;
                    }
                }
                marshalledCreateInfo->TemplateType = templateType;
                marshalledCreateInfo->DescriptorSetLayout = descriptorSetLayout?.handle ?? default(SharpVk.Interop.DescriptorSetLayout);
                if (pipelineBindPoint != null)
                {
                    marshalledCreateInfo->PipelineBindPoint = pipelineBindPoint.Value;
                }
                else
                {
                    marshalledCreateInfo->PipelineBindPoint = default(SharpVk.PipelineBindPoint);
                }
                marshalledCreateInfo->PipelineLayout = pipelineLayout?.handle ?? default(SharpVk.Interop.PipelineLayout);
                if (set != null)
                {
                    marshalledCreateInfo->Set = set.Value;
                }
                else
                {
                    marshalledCreateInfo->Set = default(uint);
                }
                if (allocator != null)
                {
                    marshalledAllocator = (SharpVk.Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<SharpVk.Interop.AllocationCallbacks>());
                    allocator.Value.MarshalTo(marshalledAllocator);
                }
                else
                {
                    marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                }
                SharpVk.Interop.Khronos.VkDeviceCreateDescriptorUpdateTemplateDelegate commandDelegate = commandCache.GetCommandDelegate<SharpVk.Interop.Khronos.VkDeviceCreateDescriptorUpdateTemplateDelegate>("vkCreateDescriptorUpdateTemplateKHR", "device");
                Result methodResult = commandDelegate(extendedHandle.handle, marshalledCreateInfo, marshalledAllocator, &marshalledDescriptorUpdateTemplate);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = new SharpVk.Khronos.DescriptorUpdateTemplate(extendedHandle, marshalledDescriptorUpdateTemplate);
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
        /// The Device handle to extend.
        /// </param>
        public static unsafe void UpdateDescriptorSetWithTemplate(this SharpVk.Device extendedHandle, SharpVk.DescriptorSet descriptorSet, SharpVk.Khronos.DescriptorUpdateTemplate descriptorUpdateTemplate, IntPtr data)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                commandCache = extendedHandle.commandCache;
                SharpVk.Interop.Khronos.VkDeviceUpdateDescriptorSetWithTemplateDelegate commandDelegate = commandCache.GetCommandDelegate<SharpVk.Interop.Khronos.VkDeviceUpdateDescriptorSetWithTemplateDelegate>("vkUpdateDescriptorSetWithTemplateKHR", "device");
                commandDelegate(extendedHandle.handle, descriptorSet?.handle ?? default(SharpVk.Interop.DescriptorSet), descriptorUpdateTemplate?.handle ?? default(SharpVk.Interop.Khronos.DescriptorUpdateTemplate), data.ToPointer());
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
        /// The Device handle to extend.
        /// </param>
        public static unsafe void ImportFenceWin32Handle(this SharpVk.Device extendedHandle, SharpVk.Khronos.ImportFenceWin32HandleInfo importFenceWin32HandleInfo)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Khronos.ImportFenceWin32HandleInfo* marshalledImportFenceWin32HandleInfo = default(SharpVk.Interop.Khronos.ImportFenceWin32HandleInfo*);
                commandCache = extendedHandle.commandCache;
                marshalledImportFenceWin32HandleInfo = (SharpVk.Interop.Khronos.ImportFenceWin32HandleInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.ImportFenceWin32HandleInfo>());
                importFenceWin32HandleInfo.MarshalTo(marshalledImportFenceWin32HandleInfo);
                SharpVk.Interop.Khronos.VkDeviceImportFenceWin32HandleDelegate commandDelegate = commandCache.GetCommandDelegate<SharpVk.Interop.Khronos.VkDeviceImportFenceWin32HandleDelegate>("vkImportFenceWin32HandleKHR", "device");
                Result methodResult = commandDelegate(extendedHandle.handle, marshalledImportFenceWin32HandleInfo);
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
        /// 
        /// </summary>
        /// <param name="extendedHandle">
        /// The Device handle to extend.
        /// </param>
        public static unsafe IntPtr GetFenceWin32Handle(this SharpVk.Device extendedHandle, SharpVk.Khronos.FenceGetWin32HandleInfo getWin32HandleInfo)
        {
            try
            {
                IntPtr result = default(IntPtr);
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Khronos.FenceGetWin32HandleInfo* marshalledGetWin32HandleInfo = default(SharpVk.Interop.Khronos.FenceGetWin32HandleInfo*);
                IntPtr marshalledHandle = default(IntPtr);
                commandCache = extendedHandle.commandCache;
                marshalledGetWin32HandleInfo = (SharpVk.Interop.Khronos.FenceGetWin32HandleInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.FenceGetWin32HandleInfo>());
                getWin32HandleInfo.MarshalTo(marshalledGetWin32HandleInfo);
                SharpVk.Interop.Khronos.VkDeviceGetFenceWin32HandleDelegate commandDelegate = commandCache.GetCommandDelegate<SharpVk.Interop.Khronos.VkDeviceGetFenceWin32HandleDelegate>("vkGetFenceWin32HandleKHR", "device");
                Result methodResult = commandDelegate(extendedHandle.handle, marshalledGetWin32HandleInfo, &marshalledHandle);
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
        /// 
        /// </summary>
        /// <param name="extendedHandle">
        /// The Device handle to extend.
        /// </param>
        public static unsafe void ImportFenceFileDescriptor(this SharpVk.Device extendedHandle, SharpVk.Khronos.ImportFenceFileDescriptorInfo importFenceFileDescriptorInfo)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Khronos.ImportFenceFileDescriptorInfo* marshalledImportFenceFileDescriptorInfo = default(SharpVk.Interop.Khronos.ImportFenceFileDescriptorInfo*);
                commandCache = extendedHandle.commandCache;
                marshalledImportFenceFileDescriptorInfo = (SharpVk.Interop.Khronos.ImportFenceFileDescriptorInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.ImportFenceFileDescriptorInfo>());
                importFenceFileDescriptorInfo.MarshalTo(marshalledImportFenceFileDescriptorInfo);
                SharpVk.Interop.Khronos.VkDeviceImportFenceFileDescriptorDelegate commandDelegate = commandCache.GetCommandDelegate<SharpVk.Interop.Khronos.VkDeviceImportFenceFileDescriptorDelegate>("vkImportFenceFdKHR", "device");
                Result methodResult = commandDelegate(extendedHandle.handle, marshalledImportFenceFileDescriptorInfo);
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
        /// 
        /// </summary>
        /// <param name="extendedHandle">
        /// The Device handle to extend.
        /// </param>
        public static unsafe int GetFenceFileDescriptor(this SharpVk.Device extendedHandle, SharpVk.Khronos.FenceGetFileDescriptorInfo getFileDescriptorInfo)
        {
            try
            {
                int result = default(int);
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Khronos.FenceGetFileDescriptorInfo* marshalledGetFileDescriptorInfo = default(SharpVk.Interop.Khronos.FenceGetFileDescriptorInfo*);
                int marshalledFileDescriptor = default(int);
                commandCache = extendedHandle.commandCache;
                marshalledGetFileDescriptorInfo = (SharpVk.Interop.Khronos.FenceGetFileDescriptorInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.FenceGetFileDescriptorInfo>());
                getFileDescriptorInfo.MarshalTo(marshalledGetFileDescriptorInfo);
                SharpVk.Interop.Khronos.VkDeviceGetFenceFileDescriptorDelegate commandDelegate = commandCache.GetCommandDelegate<SharpVk.Interop.Khronos.VkDeviceGetFenceFileDescriptorDelegate>("vkGetFenceFdKHR", "device");
                Result methodResult = commandDelegate(extendedHandle.handle, marshalledGetFileDescriptorInfo, &marshalledFileDescriptor);
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
        /// 
        /// </summary>
        /// <param name="extendedHandle">
        /// The Device handle to extend.
        /// </param>
        public static unsafe SharpVk.Khronos.MemoryRequirements2 GetImageMemoryRequirements2(this SharpVk.Device extendedHandle, SharpVk.Khronos.ImageMemoryRequirementsInfo2 info)
        {
            try
            {
                SharpVk.Khronos.MemoryRequirements2 result = default(SharpVk.Khronos.MemoryRequirements2);
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Khronos.ImageMemoryRequirementsInfo2* marshalledInfo = default(SharpVk.Interop.Khronos.ImageMemoryRequirementsInfo2*);
                SharpVk.Interop.Khronos.MemoryRequirements2 marshalledMemoryRequirements = default(SharpVk.Interop.Khronos.MemoryRequirements2);
                commandCache = extendedHandle.commandCache;
                marshalledInfo = (SharpVk.Interop.Khronos.ImageMemoryRequirementsInfo2*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.ImageMemoryRequirementsInfo2>());
                info.MarshalTo(marshalledInfo);
                SharpVk.Interop.Khronos.VkDeviceGetImageMemoryRequirements2Delegate commandDelegate = commandCache.GetCommandDelegate<SharpVk.Interop.Khronos.VkDeviceGetImageMemoryRequirements2Delegate>("vkGetImageMemoryRequirements2KHR", "device");
                commandDelegate(extendedHandle.handle, marshalledInfo, &marshalledMemoryRequirements);
                result = SharpVk.Khronos.MemoryRequirements2.MarshalFrom(&marshalledMemoryRequirements);
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
        /// The Device handle to extend.
        /// </param>
        public static unsafe SharpVk.Khronos.MemoryRequirements2 GetBufferMemoryRequirements2(this SharpVk.Device extendedHandle, SharpVk.Khronos.BufferMemoryRequirementsInfo2 info)
        {
            try
            {
                SharpVk.Khronos.MemoryRequirements2 result = default(SharpVk.Khronos.MemoryRequirements2);
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Khronos.BufferMemoryRequirementsInfo2* marshalledInfo = default(SharpVk.Interop.Khronos.BufferMemoryRequirementsInfo2*);
                SharpVk.Interop.Khronos.MemoryRequirements2 marshalledMemoryRequirements = default(SharpVk.Interop.Khronos.MemoryRequirements2);
                commandCache = extendedHandle.commandCache;
                marshalledInfo = (SharpVk.Interop.Khronos.BufferMemoryRequirementsInfo2*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.BufferMemoryRequirementsInfo2>());
                info.MarshalTo(marshalledInfo);
                SharpVk.Interop.Khronos.VkDeviceGetBufferMemoryRequirements2Delegate commandDelegate = commandCache.GetCommandDelegate<SharpVk.Interop.Khronos.VkDeviceGetBufferMemoryRequirements2Delegate>("vkGetBufferMemoryRequirements2KHR", "device");
                commandDelegate(extendedHandle.handle, marshalledInfo, &marshalledMemoryRequirements);
                result = SharpVk.Khronos.MemoryRequirements2.MarshalFrom(&marshalledMemoryRequirements);
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
        /// The Device handle to extend.
        /// </param>
        public static unsafe SharpVk.Khronos.SparseImageMemoryRequirements2[] GetImageSparseMemoryRequirements2(this SharpVk.Device extendedHandle, SharpVk.Khronos.ImageSparseMemoryRequirementsInfo2 info)
        {
            try
            {
                SharpVk.Khronos.SparseImageMemoryRequirements2[] result = default(SharpVk.Khronos.SparseImageMemoryRequirements2[]);
                uint sparseMemoryRequirementCount = default(uint);
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Khronos.ImageSparseMemoryRequirementsInfo2* marshalledInfo = default(SharpVk.Interop.Khronos.ImageSparseMemoryRequirementsInfo2*);
                SharpVk.Interop.Khronos.SparseImageMemoryRequirements2* marshalledSparseMemoryRequirements = default(SharpVk.Interop.Khronos.SparseImageMemoryRequirements2*);
                commandCache = extendedHandle.commandCache;
                marshalledInfo = (SharpVk.Interop.Khronos.ImageSparseMemoryRequirementsInfo2*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.ImageSparseMemoryRequirementsInfo2>());
                info.MarshalTo(marshalledInfo);
                SharpVk.Interop.Khronos.VkDeviceGetImageSparseMemoryRequirements2Delegate commandDelegate = commandCache.GetCommandDelegate<SharpVk.Interop.Khronos.VkDeviceGetImageSparseMemoryRequirements2Delegate>("vkGetImageSparseMemoryRequirements2KHR", "device");
                commandDelegate(extendedHandle.handle, marshalledInfo, &sparseMemoryRequirementCount, marshalledSparseMemoryRequirements);
                marshalledSparseMemoryRequirements = (SharpVk.Interop.Khronos.SparseImageMemoryRequirements2*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.SparseImageMemoryRequirements2>((uint)(sparseMemoryRequirementCount)));
                commandDelegate(extendedHandle.handle, marshalledInfo, &sparseMemoryRequirementCount, marshalledSparseMemoryRequirements);
                if (marshalledSparseMemoryRequirements != null)
                {
                    var fieldPointer = new SharpVk.Khronos.SparseImageMemoryRequirements2[(uint)(sparseMemoryRequirementCount)];
                    for(int index = 0; index < (uint)(sparseMemoryRequirementCount); index++)
                    {
                        fieldPointer[index] = SharpVk.Khronos.SparseImageMemoryRequirements2.MarshalFrom(&marshalledSparseMemoryRequirements[index]);
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
        /// The Device handle to extend.
        /// </param>
        public static unsafe SharpVk.Khronos.SamplerYcbcrConversion CreateSamplerYcbcrConversion(this SharpVk.Device extendedHandle, SharpVk.Format format, SharpVk.Khronos.SamplerYcbcrModelConversion ycbcrModel, SharpVk.Khronos.SamplerYcbcrRange ycbcrRange, SharpVk.ComponentMapping components, SharpVk.Khronos.ChromaLocation xChromaOffset, SharpVk.Khronos.ChromaLocation yChromaOffset, SharpVk.Filter chromaFilter, bool forceExplicitReconstruction, SharpVk.AllocationCallbacks? allocator = default(SharpVk.AllocationCallbacks?))
        {
            try
            {
                SharpVk.Khronos.SamplerYcbcrConversion result = default(SharpVk.Khronos.SamplerYcbcrConversion);
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Khronos.SamplerYcbcrConversionCreateInfo* marshalledCreateInfo = default(SharpVk.Interop.Khronos.SamplerYcbcrConversionCreateInfo*);
                SharpVk.Interop.AllocationCallbacks* marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                SharpVk.Interop.Khronos.SamplerYcbcrConversion marshalledYcbcrConversion = default(SharpVk.Interop.Khronos.SamplerYcbcrConversion);
                commandCache = extendedHandle.commandCache;
                marshalledCreateInfo = (SharpVk.Interop.Khronos.SamplerYcbcrConversionCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.SamplerYcbcrConversionCreateInfo>());
                marshalledCreateInfo->SType = StructureType.SamplerYcbcrConversionCreateInfo;
                marshalledCreateInfo->Next = null;
                marshalledCreateInfo->Format = format;
                marshalledCreateInfo->YcbcrModel = ycbcrModel;
                marshalledCreateInfo->YcbcrRange = ycbcrRange;
                marshalledCreateInfo->Components = components;
                marshalledCreateInfo->XChromaOffset = xChromaOffset;
                marshalledCreateInfo->YChromaOffset = yChromaOffset;
                marshalledCreateInfo->ChromaFilter = chromaFilter;
                marshalledCreateInfo->ForceExplicitReconstruction = forceExplicitReconstruction;
                if (allocator != null)
                {
                    marshalledAllocator = (SharpVk.Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<SharpVk.Interop.AllocationCallbacks>());
                    allocator.Value.MarshalTo(marshalledAllocator);
                }
                else
                {
                    marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                }
                SharpVk.Interop.Khronos.VkDeviceCreateSamplerYcbcrConversionDelegate commandDelegate = commandCache.GetCommandDelegate<SharpVk.Interop.Khronos.VkDeviceCreateSamplerYcbcrConversionDelegate>("vkCreateSamplerYcbcrConversionKHR", "device");
                Result methodResult = commandDelegate(extendedHandle.handle, marshalledCreateInfo, marshalledAllocator, &marshalledYcbcrConversion);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = new SharpVk.Khronos.SamplerYcbcrConversion(extendedHandle, marshalledYcbcrConversion);
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Bind device memory to buffer objects.
        /// </summary>
        /// <param name="extendedHandle">
        /// The Device handle to extend.
        /// </param>
        public static unsafe void BindBufferMemory2(this SharpVk.Device extendedHandle, ArrayProxy<SharpVk.Khronos.BindBufferMemoryInfo>? bindInfos)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Khronos.BindBufferMemoryInfo* marshalledBindInfos = default(SharpVk.Interop.Khronos.BindBufferMemoryInfo*);
                commandCache = extendedHandle.commandCache;
                if (bindInfos.IsNull())
                {
                    marshalledBindInfos = null;
                }
                else
                {
                    if (bindInfos.Value.Contents == ProxyContents.Single)
                    {
                        marshalledBindInfos = (SharpVk.Interop.Khronos.BindBufferMemoryInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.BindBufferMemoryInfo>());
                        bindInfos.Value.GetSingleValue().MarshalTo(&*(SharpVk.Interop.Khronos.BindBufferMemoryInfo*)(marshalledBindInfos));
                    }
                    else
                    {
                        var fieldPointer = (SharpVk.Interop.Khronos.BindBufferMemoryInfo*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.Khronos.BindBufferMemoryInfo>(Interop.HeapUtil.GetLength(bindInfos.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(bindInfos.Value)); index++)
                        {
                            bindInfos.Value[index].MarshalTo(&fieldPointer[index]);
                        }
                        marshalledBindInfos = fieldPointer;
                    }
                }
                SharpVk.Interop.Khronos.VkDeviceBindBufferMemory2Delegate commandDelegate = commandCache.GetCommandDelegate<SharpVk.Interop.Khronos.VkDeviceBindBufferMemory2Delegate>("vkBindBufferMemory2KHR", "device");
                Result methodResult = commandDelegate(extendedHandle.handle, (uint)(Interop.HeapUtil.GetLength(bindInfos)), marshalledBindInfos);
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
        /// Bind device memory to image objects.
        /// </summary>
        /// <param name="extendedHandle">
        /// The Device handle to extend.
        /// </param>
        public static unsafe void BindImageMemory2(this SharpVk.Device extendedHandle, ArrayProxy<SharpVk.Khronos.BindImageMemoryInfo>? bindInfos)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Khronos.BindImageMemoryInfo* marshalledBindInfos = default(SharpVk.Interop.Khronos.BindImageMemoryInfo*);
                commandCache = extendedHandle.commandCache;
                if (bindInfos.IsNull())
                {
                    marshalledBindInfos = null;
                }
                else
                {
                    if (bindInfos.Value.Contents == ProxyContents.Single)
                    {
                        marshalledBindInfos = (SharpVk.Interop.Khronos.BindImageMemoryInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.BindImageMemoryInfo>());
                        bindInfos.Value.GetSingleValue().MarshalTo(&*(SharpVk.Interop.Khronos.BindImageMemoryInfo*)(marshalledBindInfos));
                    }
                    else
                    {
                        var fieldPointer = (SharpVk.Interop.Khronos.BindImageMemoryInfo*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.Khronos.BindImageMemoryInfo>(Interop.HeapUtil.GetLength(bindInfos.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(bindInfos.Value)); index++)
                        {
                            bindInfos.Value[index].MarshalTo(&fieldPointer[index]);
                        }
                        marshalledBindInfos = fieldPointer;
                    }
                }
                SharpVk.Interop.Khronos.VkDeviceBindImageMemory2Delegate commandDelegate = commandCache.GetCommandDelegate<SharpVk.Interop.Khronos.VkDeviceBindImageMemory2Delegate>("vkBindImageMemory2KHR", "device");
                Result methodResult = commandDelegate(extendedHandle.handle, (uint)(Interop.HeapUtil.GetLength(bindInfos)), marshalledBindInfos);
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
    }
}
