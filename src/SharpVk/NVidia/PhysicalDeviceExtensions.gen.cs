// The MIT License (MIT)
// 
// Copyright (c) Andrew Armstrong/FacticiusVir 2020
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

namespace SharpVk.NVidia
{
    /// <summary>
    /// 
    /// </summary>
    public static class PhysicalDeviceExtensions
    {
        /// <summary>
        /// Determine image capabilities compatible with external memory handle
        /// types.
        /// </summary>
        /// <param name="extendedHandle">
        /// The PhysicalDevice handle to extend.
        /// </param>
        public static unsafe SharpVk.NVidia.ExternalImageFormatProperties GetExternalImageFormatProperties(this SharpVk.PhysicalDevice extendedHandle, SharpVk.Format format, SharpVk.ImageType type, SharpVk.ImageTiling tiling, SharpVk.ImageUsageFlags usage, SharpVk.ImageCreateFlags? flags = default(SharpVk.ImageCreateFlags?), SharpVk.NVidia.ExternalMemoryHandleTypeFlags? externalHandleType = default(SharpVk.NVidia.ExternalMemoryHandleTypeFlags?))
        {
            try
            {
                SharpVk.NVidia.ExternalImageFormatProperties result = default(SharpVk.NVidia.ExternalImageFormatProperties);
                CommandCache commandCache = default(CommandCache);
                SharpVk.ImageCreateFlags marshalledFlags = default(SharpVk.ImageCreateFlags);
                SharpVk.NVidia.ExternalMemoryHandleTypeFlags marshalledExternalHandleType = default(SharpVk.NVidia.ExternalMemoryHandleTypeFlags);
                SharpVk.NVidia.ExternalImageFormatProperties marshalledExternalImageFormatProperties = default(SharpVk.NVidia.ExternalImageFormatProperties);
                commandCache = extendedHandle.commandCache;
                if (flags != null)
                {
                    marshalledFlags = flags.Value;
                }
                else
                {
                    marshalledFlags = default(SharpVk.ImageCreateFlags);
                }
                if (externalHandleType != null)
                {
                    marshalledExternalHandleType = externalHandleType.Value;
                }
                else
                {
                    marshalledExternalHandleType = default(SharpVk.NVidia.ExternalMemoryHandleTypeFlags);
                }
                SharpVk.Interop.NVidia.VkPhysicalDeviceGetExternalImageFormatPropertiesDelegate commandDelegate = commandCache.Cache.vkGetPhysicalDeviceExternalImageFormatPropertiesNV;
                Result methodResult = commandDelegate(extendedHandle.handle, format, type, tiling, usage, marshalledFlags, marshalledExternalHandleType, &marshalledExternalImageFormatProperties);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = marshalledExternalImageFormatProperties;
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Returns properties describing what cooperative matrix types are
        /// supported
        /// </summary>
        /// <param name="extendedHandle">
        /// The PhysicalDevice handle to extend.
        /// </param>
        public static unsafe SharpVk.NVidia.CooperativeMatrixProperties[] GetCooperativeMatrixProperties(this SharpVk.PhysicalDevice extendedHandle)
        {
            try
            {
                SharpVk.NVidia.CooperativeMatrixProperties[] result = default(SharpVk.NVidia.CooperativeMatrixProperties[]);
                uint marshalledPropertyCount = default(uint);
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.NVidia.CooperativeMatrixProperties* marshalledProperties = default(SharpVk.Interop.NVidia.CooperativeMatrixProperties*);
                commandCache = extendedHandle.commandCache;
                SharpVk.Interop.NVidia.VkPhysicalDeviceGetCooperativeMatrixPropertiesDelegate commandDelegate = commandCache.Cache.vkGetPhysicalDeviceCooperativeMatrixPropertiesNV;
                Result methodResult = commandDelegate(extendedHandle.handle, &marshalledPropertyCount, marshalledProperties);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                marshalledProperties = (SharpVk.Interop.NVidia.CooperativeMatrixProperties*)(Interop.HeapUtil.Allocate<SharpVk.Interop.NVidia.CooperativeMatrixProperties>((uint)(marshalledPropertyCount)));
                commandDelegate(extendedHandle.handle, &marshalledPropertyCount, marshalledProperties);
                if (marshalledProperties != null)
                {
                    var fieldPointer = new SharpVk.NVidia.CooperativeMatrixProperties[(uint)(marshalledPropertyCount)];
                    for(int index = 0; index < (uint)(marshalledPropertyCount); index++)
                    {
                        fieldPointer[index] = SharpVk.NVidia.CooperativeMatrixProperties.MarshalFrom(&marshalledProperties[index]);
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
        /// Query supported sample count combinations
        /// </summary>
        /// <param name="extendedHandle">
        /// The PhysicalDevice handle to extend.
        /// </param>
        public static unsafe SharpVk.NVidia.FramebufferMixedSamplesCombination[] GetSupportedFramebufferMixedSamplesCombinations(this SharpVk.PhysicalDevice extendedHandle)
        {
            try
            {
                SharpVk.NVidia.FramebufferMixedSamplesCombination[] result = default(SharpVk.NVidia.FramebufferMixedSamplesCombination[]);
                uint marshalledCombinationCount = default(uint);
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.NVidia.FramebufferMixedSamplesCombination* marshalledCombinations = default(SharpVk.Interop.NVidia.FramebufferMixedSamplesCombination*);
                commandCache = extendedHandle.commandCache;
                SharpVk.Interop.NVidia.VkPhysicalDeviceGetSupportedFramebufferMixedSamplesCombinationsDelegate commandDelegate = commandCache.Cache.vkGetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNV;
                Result methodResult = commandDelegate(extendedHandle.handle, &marshalledCombinationCount, marshalledCombinations);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                marshalledCombinations = (SharpVk.Interop.NVidia.FramebufferMixedSamplesCombination*)(Interop.HeapUtil.Allocate<SharpVk.Interop.NVidia.FramebufferMixedSamplesCombination>((uint)(marshalledCombinationCount)));
                commandDelegate(extendedHandle.handle, &marshalledCombinationCount, marshalledCombinations);
                if (marshalledCombinations != null)
                {
                    var fieldPointer = new SharpVk.NVidia.FramebufferMixedSamplesCombination[(uint)(marshalledCombinationCount)];
                    for(int index = 0; index < (uint)(marshalledCombinationCount); index++)
                    {
                        fieldPointer[index] = SharpVk.NVidia.FramebufferMixedSamplesCombination.MarshalFrom(&marshalledCombinations[index]);
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
