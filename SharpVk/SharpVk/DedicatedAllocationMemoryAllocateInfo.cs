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
    /// Specify a dedicated memory allocation resource.
    /// </para>
    /// <para>
    /// If the pname:pNext list includes a
    /// sname:VkDedicatedAllocationMemoryAllocateInfoNV structure, then that
    /// structure includes a handle of the sole buffer or image resource that
    /// the memory can: be bound to.
    /// </para>
    /// </summary>
    public struct DedicatedAllocationMemoryAllocateInfo
    {
        /// <summary>
        /// pname:image is sname:VK_NULL_HANDLE or a handle of an image which
        /// this memory will be bound to.
        /// </summary>
        public Image Image
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:buffer is sname:VK_NULL_HANDLE or a handle of a buffer which
        /// this memory will be bound to.
        /// </summary>
        public Buffer Buffer
        {
            get;
            set;
        }
        
        internal unsafe Interop.DedicatedAllocationMemoryAllocateInfo Pack()
        {
            Interop.DedicatedAllocationMemoryAllocateInfo result = default(Interop.DedicatedAllocationMemoryAllocateInfo);
            result.SType = StructureType.DedicatedAllocationMemoryAllocateInfo;
            result.Image = this.Image?.Pack() ?? Interop.Image.Null;
            result.Buffer = this.Buffer?.Pack() ?? Interop.Buffer.Null;
            return result;
        }
        
        internal unsafe Interop.DedicatedAllocationMemoryAllocateInfo* MarshalTo()
        {
            return (Interop.DedicatedAllocationMemoryAllocateInfo*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
        }
    }
}
