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
    /// Structure specifying a mapped memory range.
    /// </para>
    /// <para>
    /// .Valid Usage **** * pname:memory must: currently be mapped * If
    /// pname:size is not equal to ename:VK_WHOLE_SIZE, pname:offset and
    /// pname:size must: specify a range contained within the currently mapped
    /// range of pname:memory * If pname:size is equal to ename:VK_WHOLE_SIZE,
    /// pname:offset must: be within the currently mapped range of pname:memory
    /// * pname:offset must: be a multiple of
    /// sname:VkPhysicalDeviceLimits::pname:nonCoherentAtomSize * If pname:size
    /// is not equal to ename:VK_WHOLE_SIZE, pname:size must: be a multiple of
    /// sname:VkPhysicalDeviceLimits::pname:nonCoherentAtomSize ****
    /// </para>
    /// </summary>
    public struct MappedMemoryRange
    {
        /// <summary>
        /// pname:memory is the memory object to which this range belongs.
        /// </summary>
        public DeviceMemory Memory
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:offset is the zero-based byte offset from the beginning of
        /// the memory object.
        /// </summary>
        public ulong Offset
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:size is either the size of range, or ename:VK_WHOLE_SIZE to
        /// affect the range from pname:offset to the end of the current
        /// mapping of the allocation.
        /// </summary>
        public ulong Size
        {
            get;
            set;
        }
        
        internal unsafe Interop.MappedMemoryRange Pack()
        {
            Interop.MappedMemoryRange result = default(Interop.MappedMemoryRange);
            result.SType = StructureType.MappedMemoryRange;
            result.Memory = this.Memory?.Pack() ?? Interop.DeviceMemory.Null;
            result.Offset = this.Offset;
            result.Size = this.Size;
            return result;
        }
        
        internal unsafe Interop.MappedMemoryRange* MarshalTo()
        {
            return (Interop.MappedMemoryRange*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
        }
    }
}
