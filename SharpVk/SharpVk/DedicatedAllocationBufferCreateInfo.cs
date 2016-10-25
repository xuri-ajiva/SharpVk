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
    /// Specify that a buffer is bound to a dedicated memory resource.
    /// </para>
    /// <para>
    /// If the pname:pNext list includes a
    /// sname:VkDedicatedAllocationBufferCreateInfoNV structure, then that
    /// structure includes an enable controlling whether the buffer will have a
    /// dedicated memory allocation bound to it.
    /// </para>
    /// <para>
    /// .Valid Usage **** * If pname:dedicatedAllocation is ename:VK_TRUE,
    /// sname:VkBufferCreateInfo::pname:flags must: not include
    /// ename:VK_BUFFER_CREATE_SPARSE_BINDING_BIT, ename:VK_BUFFER_CREATE_SPARSE_RESIDENCY_BIT,
    /// or ename:VK_BUFFER_CREATE_SPARSE_ALIASED_BIT ****
    /// </para>
    /// </summary>
    public struct DedicatedAllocationBufferCreateInfo
    {
        /// <summary>
        /// pname:dedicatedAllocation indicates whether the buffer will have a
        /// dedicated allocation bound to it.
        /// </summary>
        public Bool32 DedicatedAllocation
        {
            get;
            set;
        }
        
        internal unsafe Interop.DedicatedAllocationBufferCreateInfo Pack()
        {
            Interop.DedicatedAllocationBufferCreateInfo result = default(Interop.DedicatedAllocationBufferCreateInfo);
            result.SType = StructureType.DedicatedAllocationBufferCreateInfo;
            result.DedicatedAllocation = this.DedicatedAllocation;
            return result;
        }
        
        internal unsafe Interop.DedicatedAllocationBufferCreateInfo* MarshalTo()
        {
            return (Interop.DedicatedAllocationBufferCreateInfo*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
        }
    }
}
