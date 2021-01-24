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

namespace SharpVk.Android
{
    /// <summary>
    /// </summary>
    public static class DeviceExtensions
    {
        /// <summary>
        /// </summary>
        /// <param name="extendedHandle">
        /// The Device handle to extend.
        /// </param>
        /// <param name="buffer">
        /// </param>
        public static unsafe AndroidHardwareBufferProperties GetAndroidHardwareBufferProperties(this Device extendedHandle, IntPtr buffer)
        {
            try
            {
                AndroidHardwareBufferProperties result = default;
                CommandCache commandCache = default;
                IntPtr* marshalledBuffer = default;
                SharpVk.Interop.Android.AndroidHardwareBufferProperties marshalledProperties = default;
                commandCache = extendedHandle.commandCache;
                marshalledBuffer = (IntPtr*)(Interop.HeapUtil.Allocate<IntPtr>());
                *marshalledBuffer = buffer;
                SharpVk.Interop.Android.VkDeviceGetAndroidHardwareBufferPropertiesDelegate commandDelegate = commandCache.Cache.vkGetAndroidHardwareBufferPropertiesANDROID;
                Result methodResult = commandDelegate(extendedHandle.Handle, marshalledBuffer, &marshalledProperties);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = AndroidHardwareBufferProperties.MarshalFrom(&marshalledProperties);
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
        /// <param name="buffer">
        /// </param>
        public static unsafe void GetMemoryAndroidHardwareBuffer(this Device extendedHandle, MemoryGetAndroidHardwareBufferInfo info, IntPtr buffer)
        {
            try
            {
                CommandCache commandCache = default;
                SharpVk.Interop.Android.MemoryGetAndroidHardwareBufferInfo* marshalledInfo = default;
                IntPtr* marshalledBuffer = default;
                commandCache = extendedHandle.commandCache;
                marshalledInfo = (SharpVk.Interop.Android.MemoryGetAndroidHardwareBufferInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Android.MemoryGetAndroidHardwareBufferInfo>());
                info.MarshalTo(marshalledInfo);
                marshalledBuffer = (IntPtr*)(Interop.HeapUtil.Allocate<IntPtr>());
                *marshalledBuffer = buffer;
                SharpVk.Interop.Android.VkDeviceGetMemoryAndroidHardwareBufferDelegate commandDelegate = commandCache.Cache.vkGetMemoryAndroidHardwareBufferANDROID;
                Result methodResult = commandDelegate(extendedHandle.Handle, marshalledInfo, marshalledBuffer);
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
