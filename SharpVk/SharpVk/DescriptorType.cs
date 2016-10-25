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
    /// Specifies the type of a descriptor in a descriptor set.
    /// </para>
    /// <para>
    /// If pname:descriptorType is ename:VK_DESCRIPTOR_TYPE_UNIFORM_BUFFER,
    /// ename:VK_DESCRIPTOR_TYPE_STORAGE_BUFFER, ename:VK_DESCRIPTOR_TYPE_UNIFORM_BUFFER_DYNAMIC,
    /// or ename:VK_DESCRIPTOR_TYPE_STORAGE_BUFFER_DYNAMIC, the elements of the
    /// slink:VkWriteDescriptorSet::pname:pBufferInfo array of
    /// slink:VkDescriptorBufferInfo structures will be used to update the
    /// descriptors, and other arrays will be ignored.
    /// </para>
    /// <para>
    /// If pname:descriptorType is
    /// ename:VK_DESCRIPTOR_TYPE_UNIFORM_TEXEL_BUFFER or
    /// ename:VK_DESCRIPTOR_TYPE_STORAGE_TEXEL_BUFFER, the
    /// slink:VkWriteDescriptorSet::pname:pTexelBufferView array will be used
    /// to update the descriptors, and other arrays will be ignored.
    /// </para>
    /// <para>
    /// If pname:descriptorType is ename:VK_DESCRIPTOR_TYPE_SAMPLER,
    /// ename:VK_DESCRIPTOR_TYPE_COMBINED_IMAGE_SAMPLER, ename:VK_DESCRIPTOR_TYPE_SAMPLED_IMAGE,
    /// ename:VK_DESCRIPTOR_TYPE_STORAGE_IMAGE, or
    /// ename:VK_DESCRIPTOR_TYPE_INPUT_ATTACHMENT, the elements of the
    /// slink:VkWriteDescriptorSet::pname:pImageInfo array of
    /// slink:VkDescriptorImageInfo structures will be used to update the
    /// descriptors, and other arrays will be ignored.
    /// </para>
    /// </summary>
    public enum DescriptorType
    {
        /// <summary>
        /// -
        /// </summary>
        Sampler = 0, 
        
        /// <summary>
        /// -
        /// </summary>
        CombinedImageSampler = 1, 
        
        /// <summary>
        /// -
        /// </summary>
        SampledImage = 2, 
        
        /// <summary>
        /// -
        /// </summary>
        StorageImage = 3, 
        
        /// <summary>
        /// -
        /// </summary>
        UniformTexelBuffer = 4, 
        
        /// <summary>
        /// -
        /// </summary>
        StorageTexelBuffer = 5, 
        
        /// <summary>
        /// -
        /// </summary>
        UniformBuffer = 6, 
        
        /// <summary>
        /// -
        /// </summary>
        StorageBuffer = 7, 
        
        /// <summary>
        /// -
        /// </summary>
        UniformBufferDynamic = 8, 
        
        /// <summary>
        /// -
        /// </summary>
        StorageBufferDynamic = 9, 
        
        /// <summary>
        /// -
        /// </summary>
        InputAttachment = 10, 
    }
}
