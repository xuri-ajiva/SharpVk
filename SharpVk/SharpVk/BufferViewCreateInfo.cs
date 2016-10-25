// The MIT License (MIT)
// 
// Copyright (c) Andrew Armstrong/FacticiusVir 2016
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

namespace SharpVk
{
    /// <summary>
    /// <para>
    /// Structure specifying parameters of a newly created buffer view.
    /// </para>
    /// <para>
    /// .Valid Usage **** * pname:offset must: be less than the size of
    /// pname:buffer * pname:offset must: be a multiple of
    /// sname:VkPhysicalDeviceLimits::pname:minTexelBufferOffsetAlignment * If
    /// pname:range is not equal to ename:VK_WHOLE_SIZE: ** pname:range must:
    /// be greater than `0` ** pname:range must: be a multiple of the element
    /// size of pname:format ** pname:range divided by the element size of
    /// pname:format, must: be less than or equal to
    /// sname:VkPhysicalDeviceLimits::pname:maxTexelBufferElements ** the sum
    /// of pname:offset and pname:range must: be less than or equal to the size
    /// of pname:buffer * pname:buffer must: have been created with a
    /// pname:usage value containing at least one of
    /// ename:VK_BUFFER_USAGE_UNIFORM_TEXEL_BUFFER_BIT or
    /// ename:VK_BUFFER_USAGE_STORAGE_TEXEL_BUFFER_BIT * If pname:buffer was
    /// created with pname:usage containing
    /// ename:VK_BUFFER_USAGE_UNIFORM_TEXEL_BUFFER_BIT, pname:format must: be
    /// supported for uniform texel buffers, as specified by the
    /// ename:VK_FORMAT_FEATURE_UNIFORM_TEXEL_BUFFER_BIT flag in
    /// sname:VkFormatProperties::pname:bufferFeatures returned by
    /// fname:vkGetPhysicalDeviceFormatProperties * If pname:buffer was created
    /// with pname:usage containing
    /// ename:VK_BUFFER_USAGE_STORAGE_TEXEL_BUFFER_BIT, pname:format must: be
    /// supported for storage texel buffers, as specified by the
    /// ename:VK_FORMAT_FEATURE_STORAGE_TEXEL_BUFFER_BIT flag in
    /// sname:VkFormatProperties::pname:bufferFeatures returned by
    /// fname:vkGetPhysicalDeviceFormatProperties ****
    /// </para>
    /// </summary>
    public struct BufferViewCreateInfo
    {
        /// <summary>
        /// pname:flags is reserved for future use.
        /// </summary>
        public BufferViewCreateFlags Flags
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:buffer is a sname:VkBuffer on which the view will be created.
        /// </summary>
        public Buffer Buffer
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:format is a elink:VkFormat describing the format of the data
        /// elements in the buffer.
        /// </summary>
        public Format Format
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:offset is an offset in bytes from the base address of the
        /// buffer. Accesses to the buffer view from shaders use addressing
        /// that is relative to this starting offset.
        /// </summary>
        public ulong Offset
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:range is a size in bytes of the buffer view. If pname:range
        /// is equal to ename:VK_WHOLE_SIZE, the range from pname:offset to the
        /// end of the buffer is used. If ename:VK_WHOLE_SIZE is used and the
        /// remaining size of the buffer is not a multiple of the element size
        /// of pname:format, then the nearest smaller multiple is used.
        /// </summary>
        public ulong Range
        {
            get;
            set;
        }
        
        internal unsafe Interop.BufferViewCreateInfo Pack()
        {
            Interop.BufferViewCreateInfo result = default(Interop.BufferViewCreateInfo);
            result.SType = StructureType.BufferViewCreateInfo;
            result.Buffer = this.Buffer?.Pack() ?? Interop.Buffer.Null;
            result.Flags = this.Flags;
            result.Format = this.Format;
            result.Offset = this.Offset;
            result.Range = this.Range;
            return result;
        }
        
        internal unsafe Interop.BufferViewCreateInfo* MarshalTo()
        {
            return (Interop.BufferViewCreateInfo*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
        }
    }
}
