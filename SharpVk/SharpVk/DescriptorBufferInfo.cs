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
    /// Structure specifying descriptor buffer info.
    /// </summary>
    public struct DescriptorBufferInfo
    {
        /// <summary>
        /// pname:buffer is the buffer resource.
        /// </summary>
        public Buffer Buffer
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:offset is the offset in bytes from the start of pname:buffer.
        /// Access to buffer memory via this descriptor uses addressing that is
        /// relative to this starting offset.
        /// </summary>
        public ulong Offset
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:range is the size in bytes that is used for this descriptor
        /// update, or ename:VK_WHOLE_SIZE to use the range from pname:offset
        /// to the end of the buffer. + -- [NOTE] .Note ==== When using
        /// ename:VK_WHOLE_SIZE, the effective range must: not be larger than
        /// the maximum range for the descriptor type
        /// (&lt;&lt;features-limits-maxUniformBufferRange, maxUniformBufferRange&gt;&gt;
        /// or &lt;&lt;features-limits-maxStorageBufferRange,
        /// maxStorageBufferRange&gt;&gt;). This means that ename:VK_WHOLE_SIZE
        /// is not typically useful in the common case where uniform buffer
        /// descriptors are suballocated from a buffer that is much larger than
        /// pname:maxUniformBufferRange. ==== -- + For
        /// ename:VK_DESCRIPTOR_TYPE_UNIFORM_BUFFER_DYNAMIC and
        /// ename:VK_DESCRIPTOR_TYPE_STORAGE_BUFFER_DYNAMIC descriptor types,
        /// pname:offset is the base offset from which the dynamic offset is
        /// applied and pname:range is the static size used for all dynamic
        /// offsets.
        /// </summary>
        public ulong Range
        {
            get;
            set;
        }
        
        internal unsafe Interop.DescriptorBufferInfo Pack()
        {
            Interop.DescriptorBufferInfo result = default(Interop.DescriptorBufferInfo);
            result.Buffer = this.Buffer?.Pack() ?? Interop.Buffer.Null;
            result.Offset = this.Offset;
            result.Range = this.Range;
            return result;
        }
        
        internal unsafe Interop.DescriptorBufferInfo* MarshalTo()
        {
            return (Interop.DescriptorBufferInfo*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
        }
    }
}
