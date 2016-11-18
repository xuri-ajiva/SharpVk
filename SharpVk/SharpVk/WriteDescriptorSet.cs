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
    /// <para>
    /// .Valid Usage **** * pname:dstBinding must: be less than or equal to the
    /// maximum value of pname:binding of all
    /// slink:VkDescriptorSetLayoutBinding structures specified when
    /// pname:dstSet's descriptor set layout was created * pname:dstBinding
    /// must: be a binding with a non-zero pname:descriptorCount *
    /// pname:descriptorType must: match the type of pname:dstBinding within
    /// pname:dstSet * The sum of pname:dstArrayElement and
    /// pname:descriptorCount must: be less than or equal to the number of
    /// array elements in the descriptor set binding specified by
    /// pname:dstBinding, and all applicable consecutive bindings, as described
    /// by &lt;&lt;descriptorsets-updates-consecutive&gt;&gt; * If
    /// pname:descriptorType is ename:VK_DESCRIPTOR_TYPE_SAMPLER,
    /// ename:VK_DESCRIPTOR_TYPE_COMBINED_IMAGE_SAMPLER, ename:VK_DESCRIPTOR_TYPE_SAMPLED_IMAGE,
    /// ename:VK_DESCRIPTOR_TYPE_STORAGE_IMAGE, or
    /// ename:VK_DESCRIPTOR_TYPE_INPUT_ATTACHMENT, pname:pImageInfo must: be a
    /// pointer to an array of pname:descriptorCount valid
    /// sname:VkDescriptorImageInfo structures * If pname:descriptorType is
    /// ename:VK_DESCRIPTOR_TYPE_UNIFORM_TEXEL_BUFFER or
    /// ename:VK_DESCRIPTOR_TYPE_STORAGE_TEXEL_BUFFER, pname:pTexelBufferView
    /// must: be a pointer to an array of pname:descriptorCount valid
    /// sname:VkBufferView handles * If pname:descriptorType is
    /// ename:VK_DESCRIPTOR_TYPE_UNIFORM_BUFFER, ename:VK_DESCRIPTOR_TYPE_STORAGE_BUFFER,
    /// ename:VK_DESCRIPTOR_TYPE_UNIFORM_BUFFER_DYNAMIC, or
    /// ename:VK_DESCRIPTOR_TYPE_STORAGE_BUFFER_DYNAMIC, pname:pBufferInfo
    /// must: be a pointer to an array of pname:descriptorCount valid
    /// sname:VkDescriptorBufferInfo structures * If pname:descriptorType is
    /// ename:VK_DESCRIPTOR_TYPE_SAMPLER or
    /// ename:VK_DESCRIPTOR_TYPE_COMBINED_IMAGE_SAMPLER, and pname:dstSet was
    /// not allocated with a layout that included immutable samplers for
    /// pname:dstBinding with pname:descriptorType, the pname:sampler member of
    /// any given element of pname:pImageInfo must: be a valid sname:VkSampler
    /// object * If pname:descriptorType is
    /// ename:VK_DESCRIPTOR_TYPE_COMBINED_IMAGE_SAMPLER, ename:VK_DESCRIPTOR_TYPE_SAMPLED_IMAGE,
    /// ename:VK_DESCRIPTOR_TYPE_STORAGE_IMAGE, or
    /// ename:VK_DESCRIPTOR_TYPE_INPUT_ATTACHMENT, the pname:imageView and
    /// pname:imageLayout members of any given element of pname:pImageInfo
    /// must: be a valid sname:VkImageView and elink:VkImageLayout,
    /// respectively * If pname:descriptorType is
    /// ename:VK_DESCRIPTOR_TYPE_UNIFORM_BUFFER or
    /// ename:VK_DESCRIPTOR_TYPE_UNIFORM_BUFFER_DYNAMIC, the pname:offset
    /// member of any given element of pname:pBufferInfo must: be a multiple of
    /// sname:VkPhysicalDeviceLimits::pname:minUniformBufferOffsetAlignment *
    /// If pname:descriptorType is ename:VK_DESCRIPTOR_TYPE_STORAGE_BUFFER or
    /// ename:VK_DESCRIPTOR_TYPE_STORAGE_BUFFER_DYNAMIC, the pname:offset
    /// member of any given element of pname:pBufferInfo must: be a multiple of
    /// sname:VkPhysicalDeviceLimits::pname:minStorageBufferOffsetAlignment *
    /// If pname:descriptorType is ename:VK_DESCRIPTOR_TYPE_UNIFORM_BUFFER or
    /// ename:VK_DESCRIPTOR_TYPE_UNIFORM_BUFFER_DYNAMIC, the pname:buffer
    /// member of any given element of pname:pBufferInfo must: have been
    /// created with ename:VK_BUFFER_USAGE_UNIFORM_BUFFER_BIT set * If
    /// pname:descriptorType is ename:VK_DESCRIPTOR_TYPE_STORAGE_BUFFER or
    /// ename:VK_DESCRIPTOR_TYPE_STORAGE_BUFFER_DYNAMIC, the pname:buffer
    /// member of any given element of pname:pBufferInfo must: have been
    /// created with ename:VK_BUFFER_USAGE_STORAGE_BUFFER_BIT set * If
    /// pname:descriptorType is ename:VK_DESCRIPTOR_TYPE_UNIFORM_BUFFER or
    /// ename:VK_DESCRIPTOR_TYPE_UNIFORM_BUFFER_DYNAMIC, the pname:range member
    /// of any given element of pname:pBufferInfo, or the effective range if
    /// pname:range is ename:VK_WHOLE_SIZE, must: be less than or equal to
    /// sname:VkPhysicalDeviceLimits::pname:maxUniformBufferRange * If
    /// pname:descriptorType is ename:VK_DESCRIPTOR_TYPE_STORAGE_BUFFER or
    /// ename:VK_DESCRIPTOR_TYPE_STORAGE_BUFFER_DYNAMIC, the pname:range member
    /// of any given element of pname:pBufferInfo, or the effective range if
    /// pname:range is ename:VK_WHOLE_SIZE, must: be less than or equal to
    /// sname:VkPhysicalDeviceLimits::pname:maxStorageBufferRange * If
    /// pname:descriptorType is ename:VK_DESCRIPTOR_TYPE_UNIFORM_TEXEL_BUFFER,
    /// the sname:VkBuffer that any given element of pname:pTexelBufferView was
    /// created from must: have been created with
    /// ename:VK_BUFFER_USAGE_UNIFORM_TEXEL_BUFFER_BIT set * If
    /// pname:descriptorType is ename:VK_DESCRIPTOR_TYPE_STORAGE_TEXEL_BUFFER,
    /// the sname:VkBuffer that any given element of pname:pTexelBufferView was
    /// created from must: have been created with
    /// ename:VK_BUFFER_USAGE_STORAGE_TEXEL_BUFFER_BIT set * If
    /// pname:descriptorType is ename:VK_DESCRIPTOR_TYPE_STORAGE_IMAGE or
    /// ename:VK_DESCRIPTOR_TYPE_INPUT_ATTACHMENT, the pname:imageView member
    /// of any given element of pname:pImageInfo must: have been created with
    /// the identity swizzle ****
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
        
        internal unsafe Interop.WriteDescriptorSet Pack()
        {
            Interop.WriteDescriptorSet result = default(Interop.WriteDescriptorSet);
            result.SType = StructureType.WriteDescriptorSet;
            result.DestinationSet = this.DestinationSet?.Pack() ?? Interop.DescriptorSet.Null;
            
            //ImageInfo
            if (this.ImageInfo != null)
            {
                int size = System.Runtime.InteropServices.Marshal.SizeOf<Interop.DescriptorImageInfo>();
                IntPtr pointer = Interop.HeapUtil.Allocate<Interop.DescriptorImageInfo>(this.ImageInfo.Length);
                for (int index = 0; index < this.ImageInfo.Length; index++)
                {
                    System.Runtime.InteropServices.Marshal.StructureToPtr(this.ImageInfo[index].Pack(), pointer + (size * index), false);
                }
                result.ImageInfo = (Interop.DescriptorImageInfo*)pointer.ToPointer();
            }
            else
            {
                result.ImageInfo = null;
            }
            
            //BufferInfo
            if (this.BufferInfo != null)
            {
                int size = System.Runtime.InteropServices.Marshal.SizeOf<Interop.DescriptorBufferInfo>();
                IntPtr pointer = Interop.HeapUtil.Allocate<Interop.DescriptorBufferInfo>(this.BufferInfo.Length);
                for (int index = 0; index < this.BufferInfo.Length; index++)
                {
                    System.Runtime.InteropServices.Marshal.StructureToPtr(this.BufferInfo[index].Pack(), pointer + (size * index), false);
                }
                result.BufferInfo = (Interop.DescriptorBufferInfo*)pointer.ToPointer();
            }
            else
            {
                result.BufferInfo = null;
            }
            
            //TexelBufferView
            if (this.TexelBufferView != null)
            {
                int size = System.Runtime.InteropServices.Marshal.SizeOf<Interop.BufferView>();
                IntPtr pointer = Interop.HeapUtil.Allocate<Interop.BufferView>(this.TexelBufferView.Length);
                for (int index = 0; index < this.TexelBufferView.Length; index++)
                {
                    System.Runtime.InteropServices.Marshal.StructureToPtr(this.TexelBufferView[index].Pack(), pointer + (size * index), false);
                }
                result.TexelBufferView = (Interop.BufferView*)pointer.ToPointer();
            }
            else
            {
                result.TexelBufferView = null;
            }
            result.DescriptorCount = (uint)(this.ImageInfo?.Length ?? this.BufferInfo?.Length ?? this.TexelBufferView?.Length ?? 0);
            result.DestinationBinding = this.DestinationBinding;
            result.DestinationArrayElement = this.DestinationArrayElement;
            result.DescriptorType = this.DescriptorType;
            return result;
        }
        
        internal unsafe Interop.WriteDescriptorSet* MarshalTo()
        {
            return (Interop.WriteDescriptorSet*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
        }
    }
}
