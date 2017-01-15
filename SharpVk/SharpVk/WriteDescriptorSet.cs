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

namespace SharpVk
{
    /// <summary>
    /// <para>
    /// Structure specifying the parameters of a descriptor set write
    /// operation.
    /// </para>
    /// <para>
    /// Only one of pname:pImageInfo, pname:pBufferInfo, or
    /// pname:pTexelBufferView members is used according to the descriptor type
    /// specified in the pname:descriptorType member of the containing
    /// sname:VkWriteDescriptorSet structure, as specified below.
    /// </para>
    /// <para>
    /// [[descriptorsets-updates-consecutive, consecutive binding updates]] If
    /// the pname:dstBinding has fewer than pname:descriptorCount array
    /// elements remaining starting from pname:dstArrayElement, then the
    /// remainder will be used to update the subsequent binding -
    /// pname:dstBinding+1 starting at array element zero. If a binding has a
    /// pname:descriptorCount of zero, it is skipped. This behavior applies
    /// recursively, with the update affecting consecutive bindings as needed
    /// to update all pname:descriptorCount descriptors. All consecutive
    /// bindings updated via a single sname:VkWriteDescriptorSet structure,
    /// except those with a pname:descriptorCount of zero, must: have identical
    /// pname:descriptorType and pname:stageFlags, and must: all either use
    /// immutable samplers or must: all not use immutable samplers.
    /// </para>
    /// </summary>
    public struct WriteDescriptorSet
    {
        /// <summary>
        /// pname:dstSet is the destination descriptor set to update.
        /// </summary>
        public DescriptorSet DestinationSet
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:dstBinding is the descriptor binding within that set.
        /// </summary>
        public uint DestinationBinding
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:dstArrayElement is the starting element in that array.
        /// </summary>
        public uint DestinationArrayElement
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:descriptorType is a elink:VkDescriptorType specifying the
        /// type of each descriptor in pname:pImageInfo, pname:pBufferInfo, or
        /// pname:pTexelBufferView, as described below. It must: be the same
        /// type as that specified in sname:VkDescriptorSetLayoutBinding for
        /// pname:dstSet at pname:dstBinding. The type of the descriptor also
        /// controls which array the descriptors are taken from.
        /// </summary>
        public DescriptorType DescriptorType
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:pImageInfo points to an array of slink:VkDescriptorImageInfo
        /// structures or is ignored, as described below.
        /// </summary>
        public DescriptorImageInfo[] ImageInfo
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:pBufferInfo points to an array of
        /// slink:VkDescriptorBufferInfo structures or is ignored, as described
        /// below.
        /// </summary>
        public DescriptorBufferInfo[] BufferInfo
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:pTexelBufferView points to an array of slink:VkBufferView
        /// handles as described in the &lt;&lt;resources-buffer-views,Buffer
        /// Views&gt;&gt; section or is ignored, as described below.
        /// </summary>
        public BufferView[] TexelBufferView
        {
            get;
            set;
        }
        
        internal unsafe Interop.WriteDescriptorSet* MarshalTo()
        {
            var result = (Interop.WriteDescriptorSet*)Interop.HeapUtil.AllocateAndClear<Interop.WriteDescriptorSet>().ToPointer();
            this.MarshalTo(result);
            return result;
        }
        
        internal unsafe void MarshalTo(Interop.WriteDescriptorSet* pointer)
        {
            pointer->SType = StructureType.WriteDescriptorSet;
            pointer->Next = null;
            this.DestinationSet?.MarshalTo(&pointer->DestinationSet);
            
            //ImageInfo
            if (this.ImageInfo != null)
            {
                var fieldPointer = (Interop.DescriptorImageInfo*)Interop.HeapUtil.AllocateAndClear<Interop.DescriptorImageInfo>(this.ImageInfo.Length);
                for (int index = 0; index < this.ImageInfo.Length; index++)
                {
                    this.ImageInfo[index].MarshalTo(&fieldPointer[index]);
                }
                pointer->ImageInfo = fieldPointer;
            }
            else
            {
                pointer->ImageInfo = null;
            }
            
            //BufferInfo
            if (this.BufferInfo != null)
            {
                var fieldPointer = (Interop.DescriptorBufferInfo*)Interop.HeapUtil.AllocateAndClear<Interop.DescriptorBufferInfo>(this.BufferInfo.Length);
                for (int index = 0; index < this.BufferInfo.Length; index++)
                {
                    this.BufferInfo[index].MarshalTo(&fieldPointer[index]);
                }
                pointer->BufferInfo = fieldPointer;
            }
            else
            {
                pointer->BufferInfo = null;
            }
            
            //TexelBufferView
            if (this.TexelBufferView != null)
            {
                var fieldPointer = (Interop.BufferView*)Interop.HeapUtil.AllocateAndClear<Interop.BufferView>(this.TexelBufferView.Length);
                for (int index = 0; index < this.TexelBufferView.Length; index++)
                {
                    this.TexelBufferView[index].MarshalTo(&fieldPointer[index]);
                }
                pointer->TexelBufferView = fieldPointer;
            }
            else
            {
                pointer->TexelBufferView = null;
            }
            pointer->DescriptorCount = (uint)(this.ImageInfo?.Length ?? this.BufferInfo?.Length ?? this.TexelBufferView?.Length ?? 0);
            pointer->DestinationBinding = this.DestinationBinding;
            pointer->DestinationArrayElement = this.DestinationArrayElement;
            pointer->DescriptorType = this.DescriptorType;
        }
    }
}
