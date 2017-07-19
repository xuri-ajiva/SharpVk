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
        /// Create multiple swapchains that share presentable images.
        /// </summary>
        public static unsafe SharpVk.Khronos.Swapchain[] CreateSharedSwapchains(this SharpVk.Device extendedHandle, SharpVk.Khronos.SwapchainCreateInfo[] createInfos, SharpVk.AllocationCallbacks? allocator = default(SharpVk.AllocationCallbacks?))
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
                swapchainCount = (uint)(createInfos?.Length ?? 0);
                if (createInfos != null)
                {
                    var fieldPointer = (SharpVk.Interop.Khronos.SwapchainCreateInfo*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.Khronos.SwapchainCreateInfo>(createInfos.Length).ToPointer());
                    for(int index = 0; index < (uint)(createInfos.Length); index++)
                    {
                        createInfos[index].MarshalTo(&fieldPointer[index]);
                    }
                    marshalledCreateInfos = fieldPointer;
                }
                else
                {
                    marshalledCreateInfos = null;
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
                SharpVk.Interop.Khronos.VkDeviceCreateSharedSwapchainsDelegate commandDelegate = commandCache.GetCommandDelegate<SharpVk.Interop.Khronos.VkDeviceCreateSharedSwapchainsDelegate>("vkCreateSharedSwapchainsKHR", "instance");
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
        /// Create a swapchain.
        /// </summary>
        public static unsafe SharpVk.Khronos.Swapchain CreateSwapchain(this SharpVk.Device extendedHandle, SharpVk.Khronos.Surface surface, uint minImageCount, SharpVk.Format imageFormat, SharpVk.Khronos.ColorSpace imageColorSpace, SharpVk.Extent2D imageExtent, uint imageArrayLayers, SharpVk.ImageUsageFlags imageUsage, SharpVk.SharingMode imageSharingMode, uint[] queueFamilyIndices, SharpVk.Khronos.SurfaceTransformFlags preTransform, SharpVk.Khronos.CompositeAlphaFlags compositeAlpha, SharpVk.Khronos.PresentMode presentMode, bool clipped, SharpVk.Khronos.Swapchain oldSwapchain, SharpVk.Khronos.SwapchainCreateFlags? flags = default(SharpVk.Khronos.SwapchainCreateFlags?), SharpVk.AllocationCallbacks? allocator = default(SharpVk.AllocationCallbacks?))
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
                marshalledCreateInfo->SType = StructureType.SwapchainCreateInfoKhr;
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
                marshalledCreateInfo->QueueFamilyIndexCount = (uint)(queueFamilyIndices?.Length ?? 0);
                if (queueFamilyIndices != null)
                {
                    var fieldPointer = (uint*)(Interop.HeapUtil.AllocateAndClear<uint>(queueFamilyIndices.Length).ToPointer());
                    for(int index = 0; index < (uint)(queueFamilyIndices.Length); index++)
                    {
                        fieldPointer[index] = queueFamilyIndices[index];
                    }
                    marshalledCreateInfo->QueueFamilyIndices = fieldPointer;
                }
                else
                {
                    marshalledCreateInfo->QueueFamilyIndices = null;
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
                SharpVk.Interop.Khronos.VkDeviceCreateSwapchainDelegate commandDelegate = commandCache.GetCommandDelegate<SharpVk.Interop.Khronos.VkDeviceCreateSwapchainDelegate>("vkCreateSwapchainKHR", "instance");
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
        /// 
        /// </summary>
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
                SharpVk.Interop.Khronos.VkDeviceGetMemoryWin32HandleDelegate commandDelegate = commandCache.GetCommandDelegate<SharpVk.Interop.Khronos.VkDeviceGetMemoryWin32HandleDelegate>("vkGetMemoryWin32HandleKHR", "instance");
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
        public static unsafe SharpVk.Khronos.MemoryWin32HandleProperties GetMemoryWin32HandleProperties(this SharpVk.Device extendedHandle, SharpVk.Khronos.ExternalMemoryHandleTypeFlags handleType, IntPtr handle)
        {
            try
            {
                SharpVk.Khronos.MemoryWin32HandleProperties result = default(SharpVk.Khronos.MemoryWin32HandleProperties);
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Khronos.MemoryWin32HandleProperties marshalledMemoryWin32HandleProperties = default(SharpVk.Interop.Khronos.MemoryWin32HandleProperties);
                commandCache = extendedHandle.commandCache;
                SharpVk.Interop.Khronos.VkDeviceGetMemoryWin32HandlePropertiesDelegate commandDelegate = commandCache.GetCommandDelegate<SharpVk.Interop.Khronos.VkDeviceGetMemoryWin32HandlePropertiesDelegate>("vkGetMemoryWin32HandlePropertiesKHR", "instance");
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
                SharpVk.Interop.Khronos.VkDeviceGetMemoryFileDescriptorDelegate commandDelegate = commandCache.GetCommandDelegate<SharpVk.Interop.Khronos.VkDeviceGetMemoryFileDescriptorDelegate>("vkGetMemoryFdKHR", "instance");
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
        public static unsafe SharpVk.Khronos.MemoryFileDescriptorProperties GetMemoryFileDescriptorProperties(this SharpVk.Device extendedHandle, SharpVk.Khronos.ExternalMemoryHandleTypeFlags handleType, int fileDescriptor)
        {
            try
            {
                SharpVk.Khronos.MemoryFileDescriptorProperties result = default(SharpVk.Khronos.MemoryFileDescriptorProperties);
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Khronos.MemoryFileDescriptorProperties marshalledMemoryFileDescriptorProperties = default(SharpVk.Interop.Khronos.MemoryFileDescriptorProperties);
                commandCache = extendedHandle.commandCache;
                SharpVk.Interop.Khronos.VkDeviceGetMemoryFileDescriptorPropertiesDelegate commandDelegate = commandCache.GetCommandDelegate<SharpVk.Interop.Khronos.VkDeviceGetMemoryFileDescriptorPropertiesDelegate>("vkGetMemoryFdPropertiesKHR", "instance");
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
                SharpVk.Interop.Khronos.VkDeviceGetSemaphoreWin32HandleDelegate commandDelegate = commandCache.GetCommandDelegate<SharpVk.Interop.Khronos.VkDeviceGetSemaphoreWin32HandleDelegate>("vkGetSemaphoreWin32HandleKHR", "instance");
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
        public static unsafe void ImportSemaphoreWin32Handle(this SharpVk.Device extendedHandle, SharpVk.Khronos.ImportSemaphoreWin32HandleInfo importSemaphoreWin32HandleInfo)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Khronos.ImportSemaphoreWin32HandleInfo* marshalledImportSemaphoreWin32HandleInfo = default(SharpVk.Interop.Khronos.ImportSemaphoreWin32HandleInfo*);
                commandCache = extendedHandle.commandCache;
                marshalledImportSemaphoreWin32HandleInfo = (SharpVk.Interop.Khronos.ImportSemaphoreWin32HandleInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.ImportSemaphoreWin32HandleInfo>());
                importSemaphoreWin32HandleInfo.MarshalTo(marshalledImportSemaphoreWin32HandleInfo);
                SharpVk.Interop.Khronos.VkDeviceImportSemaphoreWin32HandleDelegate commandDelegate = commandCache.GetCommandDelegate<SharpVk.Interop.Khronos.VkDeviceImportSemaphoreWin32HandleDelegate>("vkImportSemaphoreWin32HandleKHR", "instance");
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
                SharpVk.Interop.Khronos.VkDeviceGetSemaphoreFileDescriptorDelegate commandDelegate = commandCache.GetCommandDelegate<SharpVk.Interop.Khronos.VkDeviceGetSemaphoreFileDescriptorDelegate>("vkGetSemaphoreFdKHR", "instance");
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
        public static unsafe void ImportSemaphoreFileDescriptor(this SharpVk.Device extendedHandle, SharpVk.Khronos.ImportSemaphoreFileDescriptorInfo importSemaphoreFileDescriptorInfo)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Khronos.ImportSemaphoreFileDescriptorInfo* marshalledImportSemaphoreFileDescriptorInfo = default(SharpVk.Interop.Khronos.ImportSemaphoreFileDescriptorInfo*);
                commandCache = extendedHandle.commandCache;
                marshalledImportSemaphoreFileDescriptorInfo = (SharpVk.Interop.Khronos.ImportSemaphoreFileDescriptorInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.ImportSemaphoreFileDescriptorInfo>());
                importSemaphoreFileDescriptorInfo.MarshalTo(marshalledImportSemaphoreFileDescriptorInfo);
                SharpVk.Interop.Khronos.VkDeviceImportSemaphoreFileDescriptorDelegate commandDelegate = commandCache.GetCommandDelegate<SharpVk.Interop.Khronos.VkDeviceImportSemaphoreFileDescriptorDelegate>("vkImportSemaphoreFdKHR", "instance");
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
                SharpVk.Interop.Khronos.VkDeviceGetFenceWin32HandleDelegate commandDelegate = commandCache.GetCommandDelegate<SharpVk.Interop.Khronos.VkDeviceGetFenceWin32HandleDelegate>("vkGetFenceWin32HandleKHR", "instance");
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
        public static unsafe void ImportFenceWin32Handle(this SharpVk.Device extendedHandle, SharpVk.Khronos.ImportFenceWin32HandleInfo importFenceWin32HandleInfo)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Khronos.ImportFenceWin32HandleInfo* marshalledImportFenceWin32HandleInfo = default(SharpVk.Interop.Khronos.ImportFenceWin32HandleInfo*);
                commandCache = extendedHandle.commandCache;
                marshalledImportFenceWin32HandleInfo = (SharpVk.Interop.Khronos.ImportFenceWin32HandleInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.ImportFenceWin32HandleInfo>());
                importFenceWin32HandleInfo.MarshalTo(marshalledImportFenceWin32HandleInfo);
                SharpVk.Interop.Khronos.VkDeviceImportFenceWin32HandleDelegate commandDelegate = commandCache.GetCommandDelegate<SharpVk.Interop.Khronos.VkDeviceImportFenceWin32HandleDelegate>("vkImportFenceWin32HandleKHR", "instance");
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
                SharpVk.Interop.Khronos.VkDeviceGetFenceFileDescriptorDelegate commandDelegate = commandCache.GetCommandDelegate<SharpVk.Interop.Khronos.VkDeviceGetFenceFileDescriptorDelegate>("vkGetFenceFdKHR", "instance");
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
        public static unsafe void ImportFenceFileDescriptor(this SharpVk.Device extendedHandle, SharpVk.Khronos.ImportFenceFileDescriptorInfo importFenceFileDescriptorInfo)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Khronos.ImportFenceFileDescriptorInfo* marshalledImportFenceFileDescriptorInfo = default(SharpVk.Interop.Khronos.ImportFenceFileDescriptorInfo*);
                commandCache = extendedHandle.commandCache;
                marshalledImportFenceFileDescriptorInfo = (SharpVk.Interop.Khronos.ImportFenceFileDescriptorInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.ImportFenceFileDescriptorInfo>());
                importFenceFileDescriptorInfo.MarshalTo(marshalledImportFenceFileDescriptorInfo);
                SharpVk.Interop.Khronos.VkDeviceImportFenceFileDescriptorDelegate commandDelegate = commandCache.GetCommandDelegate<SharpVk.Interop.Khronos.VkDeviceImportFenceFileDescriptorDelegate>("vkImportFenceFdKHR", "instance");
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
        /// Create a new descriptor update template.
        /// </summary>
        public static unsafe SharpVk.Khronos.DescriptorUpdateTemplate CreateDescriptorUpdateTemplate(this SharpVk.Device extendedHandle, SharpVk.Khronos.DescriptorUpdateTemplateEntry[] descriptorUpdateEntries, SharpVk.Khronos.DescriptorUpdateTemplateType templateType, SharpVk.DescriptorSetLayout descriptorSetLayout, SharpVk.PipelineLayout pipelineLayout, SharpVk.Khronos.DescriptorUpdateTemplateCreateFlags? flags = default(SharpVk.Khronos.DescriptorUpdateTemplateCreateFlags?), SharpVk.PipelineBindPoint? pipelineBindPoint = default(SharpVk.PipelineBindPoint?), uint? set = default(uint?), SharpVk.AllocationCallbacks? allocator = default(SharpVk.AllocationCallbacks?))
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
                marshalledCreateInfo->SType = StructureType.DescriptorUpdateTemplateCreateInfoKhr;
                marshalledCreateInfo->Next = null;
                if (flags != null)
                {
                    marshalledCreateInfo->Flags = flags.Value;
                }
                else
                {
                    marshalledCreateInfo->Flags = default(SharpVk.Khronos.DescriptorUpdateTemplateCreateFlags);
                }
                marshalledCreateInfo->DescriptorUpdateEntryCount = (uint)(descriptorUpdateEntries?.Length ?? 0);
                if (descriptorUpdateEntries != null)
                {
                    var fieldPointer = (SharpVk.Khronos.DescriptorUpdateTemplateEntry*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Khronos.DescriptorUpdateTemplateEntry>(descriptorUpdateEntries.Length).ToPointer());
                    for(int index = 0; index < (uint)(descriptorUpdateEntries.Length); index++)
                    {
                        fieldPointer[index] = descriptorUpdateEntries[index];
                    }
                    marshalledCreateInfo->DescriptorUpdateEntries = fieldPointer;
                }
                else
                {
                    marshalledCreateInfo->DescriptorUpdateEntries = null;
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
                SharpVk.Interop.Khronos.VkDeviceCreateDescriptorUpdateTemplateDelegate commandDelegate = commandCache.GetCommandDelegate<SharpVk.Interop.Khronos.VkDeviceCreateDescriptorUpdateTemplateDelegate>("vkCreateDescriptorUpdateTemplateKHR", "instance");
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
        public static unsafe void UpdateDescriptorSetWithTemplate(this SharpVk.Device extendedHandle, SharpVk.DescriptorSet descriptorSet, SharpVk.Khronos.DescriptorUpdateTemplate descriptorUpdateTemplate, IntPtr data)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                commandCache = extendedHandle.commandCache;
                SharpVk.Interop.Khronos.VkDeviceUpdateDescriptorSetWithTemplateDelegate commandDelegate = commandCache.GetCommandDelegate<SharpVk.Interop.Khronos.VkDeviceUpdateDescriptorSetWithTemplateDelegate>("vkUpdateDescriptorSetWithTemplateKHR", "instance");
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
                SharpVk.Interop.Khronos.VkDeviceGetBufferMemoryRequirements2Delegate commandDelegate = commandCache.GetCommandDelegate<SharpVk.Interop.Khronos.VkDeviceGetBufferMemoryRequirements2Delegate>("vkGetBufferMemoryRequirements2KHR", "instance");
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
                SharpVk.Interop.Khronos.VkDeviceGetImageMemoryRequirements2Delegate commandDelegate = commandCache.GetCommandDelegate<SharpVk.Interop.Khronos.VkDeviceGetImageMemoryRequirements2Delegate>("vkGetImageMemoryRequirements2KHR", "instance");
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
                SharpVk.Interop.Khronos.VkDeviceGetImageSparseMemoryRequirements2Delegate commandDelegate = commandCache.GetCommandDelegate<SharpVk.Interop.Khronos.VkDeviceGetImageSparseMemoryRequirements2Delegate>("vkGetImageSparseMemoryRequirements2KHR", "instance");
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
    }
}
