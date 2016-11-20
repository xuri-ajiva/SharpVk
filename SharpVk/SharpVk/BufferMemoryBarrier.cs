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
    /// Structure specifying the parameters of a buffer memory barrier.
    /// </summary>
    public struct BufferMemoryBarrier
    {
        /// <summary>
        /// pname:srcAccessMask is a bitmask of the classes of memory accesses
        /// performed by the first set of commands that will participate in the
        /// dependency.
        /// </summary>
        public AccessFlags SourceAccessMask
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:dstAccessMask is a bitmask of the classes of memory accesses
        /// performed by the second set of commands that will participate in
        /// the dependency.
        /// </summary>
        public AccessFlags DestinationAccessMask
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:srcQueueFamilyIndex is the queue family that is relinquishing
        /// ownership of the range of pname:buffer to another queue, or
        /// ename:VK_QUEUE_FAMILY_IGNORED if there is no transfer of ownership.
        /// </summary>
        public uint SourceQueueFamilyIndex
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:dstQueueFamilyIndex is the queue family that is acquiring
        /// ownership of the range of pname:buffer from another queue, or
        /// ename:VK_QUEUE_FAMILY_IGNORED if there is no transfer of ownership.
        /// </summary>
        public uint DestinationQueueFamilyIndex
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:buffer is a handle to the buffer whose backing memory is
        /// affected by the barrier.
        /// </summary>
        public Buffer Buffer
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:offset is an offset in bytes into the backing memory for
        /// pname:buffer; this is relative to the base offset as bound to the
        /// buffer (see flink:vkBindBufferMemory).
        /// </summary>
        public ulong Offset
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:size is a size in bytes of the affected area of backing
        /// memory for pname:buffer, or ename:VK_WHOLE_SIZE to use the range
        /// from pname:offset to the end of the buffer.
        /// </summary>
        public ulong Size
        {
            get;
            set;
        }
        
        internal unsafe Interop.BufferMemoryBarrier Pack()
        {
            Interop.BufferMemoryBarrier result = default(Interop.BufferMemoryBarrier);
            result.SType = StructureType.BufferMemoryBarrier;
            result.Buffer = this.Buffer?.Pack() ?? Interop.Buffer.Null;
            result.SourceAccessMask = this.SourceAccessMask;
            result.DestinationAccessMask = this.DestinationAccessMask;
            result.SourceQueueFamilyIndex = this.SourceQueueFamilyIndex;
            result.DestinationQueueFamilyIndex = this.DestinationQueueFamilyIndex;
            result.Offset = this.Offset;
            result.Size = this.Size;
            return result;
        }
        
        internal unsafe Interop.BufferMemoryBarrier* MarshalTo()
        {
            return (Interop.BufferMemoryBarrier*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
        }
    }
}
