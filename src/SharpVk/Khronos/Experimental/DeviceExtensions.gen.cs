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

namespace SharpVk.Khronos.Experimental
{
    /// <summary>
    /// 
    /// </summary>
    public static class DeviceExtensions
    {
        /// <summary>
        /// 
        /// </summary>
        public static unsafe SharpVk.Khronos.Experimental.MemoryWin32HandleProperties GetMemoryWin32HandleProperties(this SharpVk.Device extendedHandle, SharpVk.Khronos.Experimental.ExternalMemoryHandleTypeFlags handleType, IntPtr handle)
        {
            try
            {
                SharpVk.Khronos.Experimental.MemoryWin32HandleProperties result = default(SharpVk.Khronos.Experimental.MemoryWin32HandleProperties);
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Khronos.Experimental.MemoryWin32HandleProperties marshalledMemoryWin32HandleProperties = default(SharpVk.Interop.Khronos.Experimental.MemoryWin32HandleProperties);
                commandCache = extendedHandle.commandCache;
                SharpVk.Interop.Khronos.Experimental.VkDeviceGetMemoryWin32HandlePropertiesDelegate commandDelegate = commandCache.GetCommandDelegate<SharpVk.Interop.Khronos.Experimental.VkDeviceGetMemoryWin32HandlePropertiesDelegate>("vkGetMemoryWin32HandlePropertiesKHX", "instance");
                Result methodResult = commandDelegate(extendedHandle.handle, handleType, handle, &marshalledMemoryWin32HandleProperties);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = SharpVk.Khronos.Experimental.MemoryWin32HandleProperties.MarshalFrom(&marshalledMemoryWin32HandleProperties);
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
        public static unsafe SharpVk.Khronos.Experimental.MemoryFileDescriptorProperties GetMemoryFileDescriptorProperties(this SharpVk.Device extendedHandle, SharpVk.Khronos.Experimental.ExternalMemoryHandleTypeFlags handleType, int fileDescriptor)
        {
            try
            {
                SharpVk.Khronos.Experimental.MemoryFileDescriptorProperties result = default(SharpVk.Khronos.Experimental.MemoryFileDescriptorProperties);
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Khronos.Experimental.MemoryFileDescriptorProperties marshalledMemoryFileDescriptorProperties = default(SharpVk.Interop.Khronos.Experimental.MemoryFileDescriptorProperties);
                commandCache = extendedHandle.commandCache;
                SharpVk.Interop.Khronos.Experimental.VkDeviceGetMemoryFileDescriptorPropertiesDelegate commandDelegate = commandCache.GetCommandDelegate<SharpVk.Interop.Khronos.Experimental.VkDeviceGetMemoryFileDescriptorPropertiesDelegate>("vkGetMemoryFdPropertiesKHX", "instance");
                Result methodResult = commandDelegate(extendedHandle.handle, handleType, fileDescriptor, &marshalledMemoryFileDescriptorProperties);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = SharpVk.Khronos.Experimental.MemoryFileDescriptorProperties.MarshalFrom(&marshalledMemoryFileDescriptorProperties);
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
        public static unsafe void ImportSemaphoreWin32Handle(this SharpVk.Device extendedHandle, SharpVk.Khronos.Experimental.ImportSemaphoreWin32HandleInfo importSemaphoreWin32HandleInfo)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Khronos.Experimental.ImportSemaphoreWin32HandleInfo* marshalledImportSemaphoreWin32HandleInfo = default(SharpVk.Interop.Khronos.Experimental.ImportSemaphoreWin32HandleInfo*);
                commandCache = extendedHandle.commandCache;
                marshalledImportSemaphoreWin32HandleInfo = (SharpVk.Interop.Khronos.Experimental.ImportSemaphoreWin32HandleInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.Experimental.ImportSemaphoreWin32HandleInfo>());
                importSemaphoreWin32HandleInfo.MarshalTo(marshalledImportSemaphoreWin32HandleInfo);
                SharpVk.Interop.Khronos.Experimental.VkDeviceImportSemaphoreWin32HandleDelegate commandDelegate = commandCache.GetCommandDelegate<SharpVk.Interop.Khronos.Experimental.VkDeviceImportSemaphoreWin32HandleDelegate>("vkImportSemaphoreWin32HandleKHX", "instance");
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
        public static unsafe void ImportSemaphoreFileDescriptor(this SharpVk.Device extendedHandle, SharpVk.Khronos.Experimental.ImportSemaphoreFileDescriptorInfo importSemaphoreFileDescriptorInfo)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Khronos.Experimental.ImportSemaphoreFileDescriptorInfo* marshalledImportSemaphoreFileDescriptorInfo = default(SharpVk.Interop.Khronos.Experimental.ImportSemaphoreFileDescriptorInfo*);
                commandCache = extendedHandle.commandCache;
                marshalledImportSemaphoreFileDescriptorInfo = (SharpVk.Interop.Khronos.Experimental.ImportSemaphoreFileDescriptorInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.Experimental.ImportSemaphoreFileDescriptorInfo>());
                importSemaphoreFileDescriptorInfo.MarshalTo(marshalledImportSemaphoreFileDescriptorInfo);
                SharpVk.Interop.Khronos.Experimental.VkDeviceImportSemaphoreFileDescriptorDelegate commandDelegate = commandCache.GetCommandDelegate<SharpVk.Interop.Khronos.Experimental.VkDeviceImportSemaphoreFileDescriptorDelegate>("vkImportSemaphoreFdKHX", "instance");
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
        public static unsafe SharpVk.Khronos.Experimental.PeerMemoryFeatureFlags GetGroupPeerMemoryFeatures(this SharpVk.Device extendedHandle, uint heapIndex, uint localDeviceIndex, uint remoteDeviceIndex)
        {
            try
            {
                SharpVk.Khronos.Experimental.PeerMemoryFeatureFlags result = default(SharpVk.Khronos.Experimental.PeerMemoryFeatureFlags);
                CommandCache commandCache = default(CommandCache);
                SharpVk.Khronos.Experimental.PeerMemoryFeatureFlags marshalledPeerMemoryFeatures = default(SharpVk.Khronos.Experimental.PeerMemoryFeatureFlags);
                commandCache = extendedHandle.commandCache;
                SharpVk.Interop.Khronos.Experimental.VkDeviceGetGroupPeerMemoryFeaturesDelegate commandDelegate = commandCache.GetCommandDelegate<SharpVk.Interop.Khronos.Experimental.VkDeviceGetGroupPeerMemoryFeaturesDelegate>("vkGetDeviceGroupPeerMemoryFeaturesKHX", "instance");
                commandDelegate(extendedHandle.handle, heapIndex, localDeviceIndex, remoteDeviceIndex, &marshalledPeerMemoryFeatures);
                result = marshalledPeerMemoryFeatures;
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
        public static unsafe void BindBufferMemory2(this SharpVk.Device extendedHandle, SharpVk.Khronos.Experimental.BindBufferMemoryInfo[] bindInfos)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Khronos.Experimental.BindBufferMemoryInfo* marshalledBindInfos = default(SharpVk.Interop.Khronos.Experimental.BindBufferMemoryInfo*);
                commandCache = extendedHandle.commandCache;
                if (bindInfos != null)
                {
                    var fieldPointer = (SharpVk.Interop.Khronos.Experimental.BindBufferMemoryInfo*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.Khronos.Experimental.BindBufferMemoryInfo>(bindInfos.Length).ToPointer());
                    for(int index = 0; index < (uint)(bindInfos.Length); index++)
                    {
                        bindInfos[index].MarshalTo(&fieldPointer[index]);
                    }
                    marshalledBindInfos = fieldPointer;
                }
                else
                {
                    marshalledBindInfos = null;
                }
                SharpVk.Interop.Khronos.Experimental.VkDeviceBindBufferMemory2Delegate commandDelegate = commandCache.GetCommandDelegate<SharpVk.Interop.Khronos.Experimental.VkDeviceBindBufferMemory2Delegate>("vkBindBufferMemory2KHX", "instance");
                Result methodResult = commandDelegate(extendedHandle.handle, (uint)(bindInfos?.Length ?? 0), marshalledBindInfos);
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
        public static unsafe void BindImageMemory2(this SharpVk.Device extendedHandle, SharpVk.Khronos.Experimental.BindImageMemoryInfo[] bindInfos)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Khronos.Experimental.BindImageMemoryInfo* marshalledBindInfos = default(SharpVk.Interop.Khronos.Experimental.BindImageMemoryInfo*);
                commandCache = extendedHandle.commandCache;
                if (bindInfos != null)
                {
                    var fieldPointer = (SharpVk.Interop.Khronos.Experimental.BindImageMemoryInfo*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.Khronos.Experimental.BindImageMemoryInfo>(bindInfos.Length).ToPointer());
                    for(int index = 0; index < (uint)(bindInfos.Length); index++)
                    {
                        bindInfos[index].MarshalTo(&fieldPointer[index]);
                    }
                    marshalledBindInfos = fieldPointer;
                }
                else
                {
                    marshalledBindInfos = null;
                }
                SharpVk.Interop.Khronos.Experimental.VkDeviceBindImageMemory2Delegate commandDelegate = commandCache.GetCommandDelegate<SharpVk.Interop.Khronos.Experimental.VkDeviceBindImageMemory2Delegate>("vkBindImageMemory2KHX", "instance");
                Result methodResult = commandDelegate(extendedHandle.handle, (uint)(bindInfos?.Length ?? 0), marshalledBindInfos);
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
        public static unsafe SharpVk.Khronos.Experimental.DeviceGroupPresentCapabilities GetGroupPresentCapabilities(this SharpVk.Device extendedHandle)
        {
            try
            {
                SharpVk.Khronos.Experimental.DeviceGroupPresentCapabilities result = default(SharpVk.Khronos.Experimental.DeviceGroupPresentCapabilities);
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Khronos.Experimental.DeviceGroupPresentCapabilities marshalledDeviceGroupPresentCapabilities = default(SharpVk.Interop.Khronos.Experimental.DeviceGroupPresentCapabilities);
                commandCache = extendedHandle.commandCache;
                SharpVk.Interop.Khronos.Experimental.VkDeviceGetGroupPresentCapabilitiesDelegate commandDelegate = commandCache.GetCommandDelegate<SharpVk.Interop.Khronos.Experimental.VkDeviceGetGroupPresentCapabilitiesDelegate>("vkGetDeviceGroupPresentCapabilitiesKHX", "instance");
                Result methodResult = commandDelegate(extendedHandle.handle, &marshalledDeviceGroupPresentCapabilities);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = SharpVk.Khronos.Experimental.DeviceGroupPresentCapabilities.MarshalFrom(&marshalledDeviceGroupPresentCapabilities);
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
        public static unsafe SharpVk.Khronos.Experimental.DeviceGroupPresentModeFlags GetGroupSurfacePresentModes(this SharpVk.Device extendedHandle, SharpVk.Khronos.Surface surface)
        {
            try
            {
                SharpVk.Khronos.Experimental.DeviceGroupPresentModeFlags result = default(SharpVk.Khronos.Experimental.DeviceGroupPresentModeFlags);
                CommandCache commandCache = default(CommandCache);
                SharpVk.Khronos.Experimental.DeviceGroupPresentModeFlags marshalledModes = default(SharpVk.Khronos.Experimental.DeviceGroupPresentModeFlags);
                commandCache = extendedHandle.commandCache;
                SharpVk.Interop.Khronos.Experimental.VkDeviceGetGroupSurfacePresentModesDelegate commandDelegate = commandCache.GetCommandDelegate<SharpVk.Interop.Khronos.Experimental.VkDeviceGetGroupSurfacePresentModesDelegate>("vkGetDeviceGroupSurfacePresentModesKHX", "instance");
                Result methodResult = commandDelegate(extendedHandle.handle, surface?.handle ?? default(SharpVk.Interop.Khronos.Surface), &marshalledModes);
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
        /// 
        /// </summary>
        public static unsafe uint AcquireNextImage2(this SharpVk.Device extendedHandle, SharpVk.Khronos.Experimental.AcquireNextImageInfo acquireInfo)
        {
            try
            {
                uint result = default(uint);
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Khronos.Experimental.AcquireNextImageInfo* marshalledAcquireInfo = default(SharpVk.Interop.Khronos.Experimental.AcquireNextImageInfo*);
                uint marshalledImageIndex = default(uint);
                commandCache = extendedHandle.commandCache;
                marshalledAcquireInfo = (SharpVk.Interop.Khronos.Experimental.AcquireNextImageInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.Experimental.AcquireNextImageInfo>());
                acquireInfo.MarshalTo(marshalledAcquireInfo);
                SharpVk.Interop.Khronos.Experimental.VkDeviceAcquireNextImage2Delegate commandDelegate = commandCache.GetCommandDelegate<SharpVk.Interop.Khronos.Experimental.VkDeviceAcquireNextImage2Delegate>("vkAcquireNextImage2KHX", "instance");
                Result methodResult = commandDelegate(extendedHandle.handle, marshalledAcquireInfo, &marshalledImageIndex);
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
    }
}
