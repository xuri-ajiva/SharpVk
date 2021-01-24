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

namespace SharpVk.NVidia.Experimental
{
    /// <summary>
    /// </summary>
    public static class DeviceExtensions
    {
        /// <summary>
        /// Get the handle for an image view for a specific descriptor type
        /// </summary>
        /// <param name="extendedHandle">
        /// The Device handle to extend.
        /// </param>
        /// <param name="info">
        /// Describes the image view to query and type of handle.
        /// </param>
        public static unsafe void GetImageViewHandle(this Device extendedHandle, ImageViewHandleInfo info)
        {
            try
            {
                CommandCache commandCache = default;
                SharpVk.Interop.NVidia.Experimental.ImageViewHandleInfo* marshalledInfo = default;
                commandCache = extendedHandle.commandCache;
                marshalledInfo = (SharpVk.Interop.NVidia.Experimental.ImageViewHandleInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.NVidia.Experimental.ImageViewHandleInfo>());
                info.MarshalTo(marshalledInfo);
                SharpVk.Interop.NVidia.Experimental.VkDeviceGetImageViewHandleDelegate commandDelegate = commandCache.Cache.vkGetImageViewHandleNVX;
                commandDelegate(extendedHandle.Handle, marshalledInfo);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
    }
}
