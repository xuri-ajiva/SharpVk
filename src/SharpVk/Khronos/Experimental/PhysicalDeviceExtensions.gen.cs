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
    public static class PhysicalDeviceExtensions
    {
        /// <summary>
        /// 
        /// </summary>
        public static unsafe SharpVk.Khronos.Experimental.ExternalBufferProperties GetExternalBufferProperties(this SharpVk.PhysicalDevice extendedHandle, SharpVk.Khronos.Experimental.PhysicalDeviceExternalBufferInfo externalBufferInfo)
        {
            try
            {
                SharpVk.Khronos.Experimental.ExternalBufferProperties result = default(SharpVk.Khronos.Experimental.ExternalBufferProperties);
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Khronos.Experimental.PhysicalDeviceExternalBufferInfo* marshalledExternalBufferInfo = default(SharpVk.Interop.Khronos.Experimental.PhysicalDeviceExternalBufferInfo*);
                SharpVk.Interop.Khronos.Experimental.ExternalBufferProperties marshalledExternalBufferProperties = default(SharpVk.Interop.Khronos.Experimental.ExternalBufferProperties);
                commandCache = extendedHandle.commandCache;
                marshalledExternalBufferInfo = (SharpVk.Interop.Khronos.Experimental.PhysicalDeviceExternalBufferInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.Experimental.PhysicalDeviceExternalBufferInfo>());
                externalBufferInfo.MarshalTo(marshalledExternalBufferInfo);
                SharpVk.Interop.Khronos.Experimental.VkPhysicalDeviceGetExternalBufferPropertiesDelegate commandDelegate = commandCache.GetCommandDelegate<SharpVk.Interop.Khronos.Experimental.VkPhysicalDeviceGetExternalBufferPropertiesDelegate>("vkGetPhysicalDeviceExternalBufferPropertiesKHX", "instance");
                commandDelegate(extendedHandle.handle, marshalledExternalBufferInfo, &marshalledExternalBufferProperties);
                result = SharpVk.Khronos.Experimental.ExternalBufferProperties.MarshalFrom(&marshalledExternalBufferProperties);
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
        public static unsafe SharpVk.Khronos.Experimental.ExternalSemaphoreProperties GetExternalSemaphoreProperties(this SharpVk.PhysicalDevice extendedHandle, SharpVk.Khronos.Experimental.PhysicalDeviceExternalSemaphoreInfo externalSemaphoreInfo)
        {
            try
            {
                SharpVk.Khronos.Experimental.ExternalSemaphoreProperties result = default(SharpVk.Khronos.Experimental.ExternalSemaphoreProperties);
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Khronos.Experimental.PhysicalDeviceExternalSemaphoreInfo* marshalledExternalSemaphoreInfo = default(SharpVk.Interop.Khronos.Experimental.PhysicalDeviceExternalSemaphoreInfo*);
                SharpVk.Interop.Khronos.Experimental.ExternalSemaphoreProperties marshalledExternalSemaphoreProperties = default(SharpVk.Interop.Khronos.Experimental.ExternalSemaphoreProperties);
                commandCache = extendedHandle.commandCache;
                marshalledExternalSemaphoreInfo = (SharpVk.Interop.Khronos.Experimental.PhysicalDeviceExternalSemaphoreInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.Experimental.PhysicalDeviceExternalSemaphoreInfo>());
                externalSemaphoreInfo.MarshalTo(marshalledExternalSemaphoreInfo);
                SharpVk.Interop.Khronos.Experimental.VkPhysicalDeviceGetExternalSemaphorePropertiesDelegate commandDelegate = commandCache.GetCommandDelegate<SharpVk.Interop.Khronos.Experimental.VkPhysicalDeviceGetExternalSemaphorePropertiesDelegate>("vkGetPhysicalDeviceExternalSemaphorePropertiesKHX", "instance");
                commandDelegate(extendedHandle.handle, marshalledExternalSemaphoreInfo, &marshalledExternalSemaphoreProperties);
                result = SharpVk.Khronos.Experimental.ExternalSemaphoreProperties.MarshalFrom(&marshalledExternalSemaphoreProperties);
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
        public static unsafe SharpVk.Rect2D[] GetPresentRectangles(this SharpVk.PhysicalDevice extendedHandle, SharpVk.Khronos.Surface surface)
        {
            try
            {
                SharpVk.Rect2D[] result = default(SharpVk.Rect2D[]);
                uint rectCount = default(uint);
                CommandCache commandCache = default(CommandCache);
                SharpVk.Rect2D* marshalledRects = default(SharpVk.Rect2D*);
                commandCache = extendedHandle.commandCache;
                SharpVk.Interop.Khronos.Experimental.VkPhysicalDeviceGetPresentRectanglesDelegate commandDelegate = commandCache.GetCommandDelegate<SharpVk.Interop.Khronos.Experimental.VkPhysicalDeviceGetPresentRectanglesDelegate>("vkGetPhysicalDevicePresentRectanglesKHX", "instance");
                Result methodResult = commandDelegate(extendedHandle.handle, surface?.handle ?? default(SharpVk.Interop.Khronos.Surface), &rectCount, marshalledRects);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                marshalledRects = (SharpVk.Rect2D*)(Interop.HeapUtil.Allocate<SharpVk.Rect2D>((uint)(rectCount)));
                commandDelegate(extendedHandle.handle, surface?.handle ?? default(SharpVk.Interop.Khronos.Surface), &rectCount, marshalledRects);
                if (marshalledRects != null)
                {
                    var fieldPointer = new SharpVk.Rect2D[(uint)(rectCount)];
                    for(int index = 0; index < (uint)(rectCount); index++)
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
    }
}
