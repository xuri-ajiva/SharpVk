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
    /// Structure specifying a memory barrier.
    /// </para>
    /// <para>
    /// pname:srcAccessMask and pname:dstAccessMask, along with
    /// pname:srcStageMask and pname:dstStageMask from
    /// flink:vkCmdPipelineBarrier, define the two halves of a memory
    /// dependency and an execution dependency. Memory accesses using the set
    /// of access types in pname:srcAccessMask performed in pipeline stages in
    /// pname:srcStageMask by the first set of commands must: complete and be
    /// available to later commands. The side effects of the first set of
    /// commands will be visible to memory accesses using the set of access
    /// types in pname:dstAccessMask performed in pipeline stages in
    /// pname:dstStageMask by the second set of commands. If the barrier is
    /// by-region, these requirements only apply to invocations within the same
    /// framebuffer-space region, for pipeline stages that perform
    /// framebuffer-space work. The execution dependency guarantees that
    /// execution of work by the destination stages of the second set of
    /// commands will not begin until execution of work by the source stages of
    /// the first set of commands has completed.
    /// </para>
    /// <para>
    /// A common type of memory dependency is to avoid a read-after-write
    /// hazard. In this case, the source access mask and stages will include
    /// writes from a particular stage, and the destination access mask and
    /// stages will indicate how those writes will be read in subsequent
    /// commands. However, barriers can: also express write-after-read
    /// dependencies and write-after-write dependencies, and are even useful to
    /// express read-after-read dependencies across an image layout change.
    /// </para>
    /// </summary>
    public struct MemoryBarrier
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
        
        internal unsafe Interop.MemoryBarrier Pack()
        {
            Interop.MemoryBarrier result = default(Interop.MemoryBarrier);
            result.SType = StructureType.MemoryBarrier;
            result.SourceAccessMask = this.SourceAccessMask;
            result.DestinationAccessMask = this.DestinationAccessMask;
            return result;
        }
        
        internal unsafe Interop.MemoryBarrier* MarshalTo()
        {
            return (Interop.MemoryBarrier*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
        }
    }
}
