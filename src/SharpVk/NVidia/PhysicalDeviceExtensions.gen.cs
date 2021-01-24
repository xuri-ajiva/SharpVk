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

namespace SharpVk.NVidia
{
    /// <summary>
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
        /// <param name="format">
        /// </param>
        /// <param name="type">
        /// </param>
        /// <param name="tiling">
        /// </param>
        /// <param name="usage">
        /// </param>
        /// <param name="flags">
        /// </param>
        /// <param name="externalHandleType">
        /// </param>
        public static unsafe ExternalImageFormatProperties GetExternalImageFormatProperties(this PhysicalDevice extendedHandle, Format format, ImageType type, ImageTiling tiling, ImageUsageFlags usage, ImageCreateFlags? flags = default, ExternalMemoryHandleTypeFlags? externalHandleType = default)
        {
            try
            {
                ExternalImageFormatProperties result = default;
                CommandCache commandCache = default;
                ImageCreateFlags marshalledFlags = default;
                ExternalMemoryHandleTypeFlags marshalledExternalHandleType = default;
                ExternalImageFormatProperties marshalledExternalImageFormatProperties = default;
                commandCache = extendedHandle.commandCache;
                if (flags != null)
                {
                    marshalledFlags = flags.Value;
                }
                else
                {
                    marshalledFlags = default;
                }
                if (externalHandleType != null)
                {
                    marshalledExternalHandleType = externalHandleType.Value;
                }
                else
                {
                    marshalledExternalHandleType = default;
                }
                SharpVk.Interop.NVidia.VkPhysicalDeviceGetExternalImageFormatPropertiesDelegate commandDelegate = commandCache.Cache.vkGetPhysicalDeviceExternalImageFormatPropertiesNV;
                Result methodResult = commandDelegate(extendedHandle.Handle, format, type, tiling, usage, marshalledFlags, marshalledExternalHandleType, &marshalledExternalImageFormatProperties);
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
        public static unsafe CooperativeMatrixProperties[] GetCooperativeMatrixProperties(this PhysicalDevice extendedHandle)
        {
            try
            {
                CooperativeMatrixProperties[] result = default;
                uint marshalledPropertyCount = default;
                CommandCache commandCache = default;
                SharpVk.Interop.NVidia.CooperativeMatrixProperties* marshalledProperties = default;
                commandCache = extendedHandle.commandCache;
                SharpVk.Interop.NVidia.VkPhysicalDeviceGetCooperativeMatrixPropertiesDelegate commandDelegate = commandCache.Cache.vkGetPhysicalDeviceCooperativeMatrixPropertiesNV;
                Result methodResult = commandDelegate(extendedHandle.Handle, &marshalledPropertyCount, marshalledProperties);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                marshalledProperties = (SharpVk.Interop.NVidia.CooperativeMatrixProperties*)(Interop.HeapUtil.Allocate<SharpVk.Interop.NVidia.CooperativeMatrixProperties>((uint)(marshalledPropertyCount)));
                commandDelegate(extendedHandle.Handle, &marshalledPropertyCount, marshalledProperties);
                if (marshalledProperties != null)
                {
                    var fieldPointer = new CooperativeMatrixProperties[(uint)(marshalledPropertyCount)];
                    for(int index = 0; index < (uint)(marshalledPropertyCount); index++)
                    {
                        fieldPointer[index] = CooperativeMatrixProperties.MarshalFrom(&marshalledProperties[index]);
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
        public static unsafe FramebufferMixedSamplesCombination[] GetSupportedFramebufferMixedSamplesCombinations(this PhysicalDevice extendedHandle)
        {
            try
            {
                FramebufferMixedSamplesCombination[] result = default;
                uint marshalledCombinationCount = default;
                CommandCache commandCache = default;
                SharpVk.Interop.NVidia.FramebufferMixedSamplesCombination* marshalledCombinations = default;
                commandCache = extendedHandle.commandCache;
                SharpVk.Interop.NVidia.VkPhysicalDeviceGetSupportedFramebufferMixedSamplesCombinationsDelegate commandDelegate = commandCache.Cache.vkGetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNV;
                Result methodResult = commandDelegate(extendedHandle.Handle, &marshalledCombinationCount, marshalledCombinations);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                marshalledCombinations = (SharpVk.Interop.NVidia.FramebufferMixedSamplesCombination*)(Interop.HeapUtil.Allocate<SharpVk.Interop.NVidia.FramebufferMixedSamplesCombination>((uint)(marshalledCombinationCount)));
                commandDelegate(extendedHandle.Handle, &marshalledCombinationCount, marshalledCombinations);
                if (marshalledCombinations != null)
                {
                    var fieldPointer = new FramebufferMixedSamplesCombination[(uint)(marshalledCombinationCount)];
                    for(int index = 0; index < (uint)(marshalledCombinationCount); index++)
                    {
                        fieldPointer[index] = FramebufferMixedSamplesCombination.MarshalFrom(&marshalledCombinations[index]);
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
