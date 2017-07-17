// The MIT License (MIT)
// 
// Copyright (c) Andrew Armstrong/FacticiusVir 2017
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
using System.Runtime.InteropServices;

namespace SharpVk.Interop
{
    /// <summary>
    /// 
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct WriteDescriptorSet
    {
        /// <summary>
        /// pname:sType is the type of this structure.
        /// </summary>
        public SharpVk.StructureType SType; 
        
        /// <summary>
        /// pname:pNext is `NULL` or a pointer to an extension-specific
        /// structure.
        /// </summary>
        public void* Next; 
        
        /// <summary>
        /// pname:dstSet is the destination descriptor set to update.
        /// </summary>
        public SharpVk.Interop.DescriptorSet DestinationSet; 
        
        /// <summary>
        /// pname:dstBinding is the descriptor binding within that set.
        /// </summary>
        public uint DestinationBinding; 
        
        /// <summary>
        /// pname:dstArrayElement is the starting element in that array.
        /// </summary>
        public uint DestinationArrayElement; 
        
        /// <summary>
        /// pname:descriptorCount is the number of descriptors to update (the
        /// number of elements in pname:pImageInfo, pname:pBufferInfo, or
        /// pname:pTexelBufferView).
        /// </summary>
        public uint DescriptorCount; 
        
        /// <summary>
        /// pname:descriptorType is a elink:VkDescriptorType specifying the
        /// type of each descriptor in pname:pImageInfo, pname:pBufferInfo, or
        /// pname:pTexelBufferView, as described below. It must: be the same
        /// type as that specified in sname:VkDescriptorSetLayoutBinding for
        /// pname:dstSet at pname:dstBinding. The type of the descriptor also
        /// controls which array the descriptors are taken from.
        /// </summary>
        public SharpVk.DescriptorType DescriptorType; 
        
        /// <summary>
        /// pname:pImageInfo points to an array of slink:VkDescriptorImageInfo
        /// structures or is ignored, as described below.
        /// </summary>
        public SharpVk.Interop.DescriptorImageInfo* ImageInfo; 
        
        /// <summary>
        /// pname:pBufferInfo points to an array of
        /// slink:VkDescriptorBufferInfo structures or is ignored, as described
        /// below.
        /// </summary>
        public SharpVk.Interop.DescriptorBufferInfo* BufferInfo; 
        
        /// <summary>
        /// pname:pTexelBufferView points to an array of slink:VkBufferView
        /// handles as described in the &lt;&lt;resources-buffer-views,Buffer
        /// Views&gt;&gt; section or is ignored, as described below.
        /// </summary>
        public SharpVk.Interop.BufferView* TexelBufferView; 
    }
}
