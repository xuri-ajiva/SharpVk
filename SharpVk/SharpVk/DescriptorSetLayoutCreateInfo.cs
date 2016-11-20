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
    /// Structure specifying parameters of a newly created descriptor set
    /// layout.
    /// </summary>
    public struct DescriptorSetLayoutCreateInfo
    {
        /// <summary>
        /// pname:flags is reserved for future use.
        /// </summary>
        public DescriptorSetLayoutCreateFlags Flags
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:pBindings is a pointer to an array of
        /// slink:VkDescriptorSetLayoutBinding structures.
        /// </summary>
        public DescriptorSetLayoutBinding[] Bindings
        {
            get;
            set;
        }
        
        internal unsafe Interop.DescriptorSetLayoutCreateInfo Pack()
        {
            Interop.DescriptorSetLayoutCreateInfo result = default(Interop.DescriptorSetLayoutCreateInfo);
            result.SType = StructureType.DescriptorSetLayoutCreateInfo;
            
            //Bindings
            if (this.Bindings != null)
            {
                int size = System.Runtime.InteropServices.Marshal.SizeOf<Interop.DescriptorSetLayoutBinding>();
                IntPtr pointer = Interop.HeapUtil.Allocate<Interop.DescriptorSetLayoutBinding>(this.Bindings.Length);
                for (int index = 0; index < this.Bindings.Length; index++)
                {
                    System.Runtime.InteropServices.Marshal.StructureToPtr(this.Bindings[index].Pack(), pointer + (size * index), false);
                }
                result.Bindings = (Interop.DescriptorSetLayoutBinding*)pointer.ToPointer();
            }
            else
            {
                result.Bindings = null;
            }
            result.BindingCount = (uint)(this.Bindings?.Length ?? 0);
            result.Flags = this.Flags;
            return result;
        }
        
        internal unsafe Interop.DescriptorSetLayoutCreateInfo* MarshalTo()
        {
            return (Interop.DescriptorSetLayoutCreateInfo*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
        }
    }
}
