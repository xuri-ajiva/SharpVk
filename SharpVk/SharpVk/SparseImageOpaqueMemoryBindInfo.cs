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
    /// Structure specifying sparse image opaque memory bind info.
    /// </para>
    /// <para>
    /// .Valid Usage **** * For any given element of pname:pBinds, if the
    /// pname:flags member of that element contains
    /// ename:VK_SPARSE_MEMORY_BIND_METADATA_BIT, the binding range defined
    /// must: be within the mip tail region of the metadata aspect of
    /// pname:image ****
    /// </para>
    /// </summary>
    public struct SparseImageOpaqueMemoryBindInfo
    {
        /// <summary>
        /// pname:image is the sname:VkImage object to be bound.
        /// </summary>
        public Image Image
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:pBinds is a pointer to array of sname:VkSparseMemoryBind
        /// structures.
        /// </summary>
        public SparseMemoryBind[] Binds
        {
            get;
            set;
        }
        
        internal unsafe Interop.SparseImageOpaqueMemoryBindInfo Pack()
        {
            Interop.SparseImageOpaqueMemoryBindInfo result = default(Interop.SparseImageOpaqueMemoryBindInfo);
            result.Image = this.Image?.Pack() ?? Interop.Image.Null;
            
            //Binds
            if (this.Binds != null)
            {
                int size = System.Runtime.InteropServices.Marshal.SizeOf<Interop.SparseMemoryBind>();
                IntPtr pointer = Interop.HeapUtil.Allocate<Interop.SparseMemoryBind>(this.Binds.Length);
                for (int index = 0; index < this.Binds.Length; index++)
                {
                    System.Runtime.InteropServices.Marshal.StructureToPtr(this.Binds[index].Pack(), pointer + (size * index), false);
                }
                result.Binds = (Interop.SparseMemoryBind*)pointer.ToPointer();
            }
            else
            {
                result.Binds = null;
            }
            result.BindCount = (uint)(this.Binds?.Length ?? 0);
            return result;
        }
        
        internal unsafe Interop.SparseImageOpaqueMemoryBindInfo* MarshalTo()
        {
            return (Interop.SparseImageOpaqueMemoryBindInfo*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
        }
    }
}
