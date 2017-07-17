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

namespace SharpVk.Interop.NVidia.Experimental
{
    /// <summary>
    /// 
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct ObjectTableCreateInfo
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
        /// pname:objectCount is the number of entry configurations that the
        /// object table supports. The following array parameters must match
        /// the size provided here.
        /// </summary>
        public uint ObjectCount; 
        
        /// <summary>
        /// pname:pObjectEntryTypes is an array of elink:VkObjectEntryTypeNVX
        /// providing the entry type of a given configuration.
        /// </summary>
        public SharpVk.NVidia.Experimental.ObjectEntryType* ObjectEntryTypes; 
        
        /// <summary>
        /// pname:pObjectEntryCounts is an array of counts how many objects can
        /// be registered in the table.
        /// </summary>
        public uint* ObjectEntryCounts; 
        
        /// <summary>
        /// pname:pObjectEntryUsageFlags is an array of bitmasks describing the
        /// binding usage of the entry. See elink:VkObjectEntryUsageFlagBitsNVX
        /// below for a description of the supported bits.
        /// </summary>
        public SharpVk.NVidia.Experimental.ObjectEntryUsageFlags* ObjectEntryUsageFlags; 
        
        /// <summary>
        /// pname:maxUniformBuffersPerDescriptor is the maximum number of
        /// ename:VK_DESCRIPTOR_TYPE_UNIFORM_BUFFER or
        /// ename:VK_DESCRIPTOR_TYPE_UNIFORM_BUFFER_DYNAMIC used by any single
        /// registered sname:VkDescriptorSet in this table.
        /// </summary>
        public uint MaxUniformBuffersPerDescriptor; 
        
        /// <summary>
        /// pname:maxStorageBuffersPerDescriptor is the maximum number of
        /// ename:VK_DESCRIPTOR_TYPE_STORAGE_BUFFER or
        /// ename:VK_DESCRIPTOR_TYPE_STORAGE_BUFFER_DYNAMIC used by any single
        /// registered sname:VkDescriptorSet in this table.
        /// </summary>
        public uint MaxStorageBuffersPerDescriptor; 
        
        /// <summary>
        /// pname:maxStorageImagesPerDescriptor is the maximum number of
        /// ename:VK_DESCRIPTOR_TYPE_STORAGE_IMAGE or
        /// ename:VK_DESCRIPTOR_TYPE_STORAGE_TEXEL_BUFFER used by any single
        /// registered sname:VkDescriptorSet in this table.
        /// </summary>
        public uint MaxStorageImagesPerDescriptor; 
        
        /// <summary>
        /// pname:maxSampledImagesPerDescriptor is the maximum number of
        /// ename:VK_DESCRIPTOR_TYPE_SAMPLER, ename:VK_DESCRIPTOR_TYPE_COMBINED_IMAGE_SAMPLER,
        /// ename:VK_DESCRIPTOR_TYPE_UNIFORM_TEXEL_BUFFER or
        /// ename:VK_DESCRIPTOR_TYPE_INPUT_ATTACHMENT used by any single
        /// registered sname:VkDescriptorSet in this table.
        /// </summary>
        public uint MaxSampledImagesPerDescriptor; 
        
        /// <summary>
        /// pname:maxPipelineLayouts is the maximum number of unique
        /// sname:VkPipelineLayout used by any registered sname:VkDescriptorSet
        /// or sname:VkPipeline in this table.
        /// </summary>
        public uint MaxPipelineLayouts; 
    }
}
