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
    /// Structure specifying the parameters of a newly created object table.
    /// </summary>
    public struct ObjectTableCreateInfo
    {
        /// <summary>
        /// pname:pObjectEntryTypes is an array of elink:VkObjectEntryTypeNVX
        /// providing the entry type of a given configuration.
        /// </summary>
        public ObjectEntryType[] ObjectEntryTypes
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:pObjectEntryCounts is an array of counts how many objects can
        /// be registered in the table.
        /// </summary>
        public uint[] ObjectEntryCounts
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:pObjectEntryUsageFlags is an array of bitmasks describing the
        /// binding usage of the entry. See elink:VkObjectEntryUsageFlagBitsNVX
        /// below for a description of the supported bits.
        /// </summary>
        public ObjectEntryUsageFlags[] ObjectEntryUsageFlags
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:maxUniformBuffersPerDescriptor is the maximum number of
        /// ename:VK_DESCRIPTOR_TYPE_UNIFORM_BUFFER or
        /// ename:VK_DESCRIPTOR_TYPE_UNIFORM_BUFFER_DYNAMIC used by any single
        /// registered sname:VkDescriptorSet in this table.
        /// </summary>
        public uint MaxUniformBuffersPerDescriptor
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:maxStorageBuffersPerDescriptor is the maximum number of
        /// ename:VK_DESCRIPTOR_TYPE_STORAGE_BUFFER or
        /// ename:VK_DESCRIPTOR_TYPE_STORAGE_BUFFER_DYNAMIC used by any single
        /// registered sname:VkDescriptorSet in this table.
        /// </summary>
        public uint MaxStorageBuffersPerDescriptor
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:maxStorageImagesPerDescriptor is the maximum number of
        /// ename:VK_DESCRIPTOR_TYPE_STORAGE_IMAGE or
        /// ename:VK_DESCRIPTOR_TYPE_STORAGE_TEXEL_BUFFER used by any single
        /// registered sname:VkDescriptorSet in this table.
        /// </summary>
        public uint MaxStorageImagesPerDescriptor
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:maxSampledImagesPerDescriptor is the maximum number of
        /// ename:VK_DESCRIPTOR_TYPE_SAMPLER, ename:VK_DESCRIPTOR_TYPE_COMBINED_IMAGE_SAMPLER,
        /// ename:VK_DESCRIPTOR_TYPE_UNIFORM_TEXEL_BUFFER or
        /// ename:VK_DESCRIPTOR_TYPE_INPUT_ATTACHMENT used by any single
        /// registered sname:VkDescriptorSet in this table.
        /// </summary>
        public uint MaxSampledImagesPerDescriptor
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:maxPipelineLayouts is the maximum number of unique
        /// sname:VkPipelineLayout used by any registered sname:VkDescriptorSet
        /// or sname:VkPipeline in this table.
        /// </summary>
        public uint MaxPipelineLayouts
        {
            get;
            set;
        }
        
        internal unsafe Interop.ObjectTableCreateInfo Pack()
        {
            Interop.ObjectTableCreateInfo result = default(Interop.ObjectTableCreateInfo);
            result.SType = StructureType.ObjectTableCreateInfoNvx;
            
            //ObjectEntryTypes
            if (this.ObjectEntryTypes != null)
            {
                result.ObjectEntryTypes = (ObjectEntryType*)Interop.HeapUtil.Allocate<int>(this.ObjectEntryTypes.Length).ToPointer();
                for (int index = 0; index < this.ObjectEntryTypes.Length; index++)
                {
                    result.ObjectEntryTypes[index] = this.ObjectEntryTypes[index];
                }
            }
            else
            {
                result.ObjectEntryTypes = null;
            }
            result.ObjectEntryCounts = this.ObjectEntryCounts == null ? null : Interop.HeapUtil.MarshalTo(this.ObjectEntryCounts);
            
            //ObjectEntryUsageFlags
            if (this.ObjectEntryUsageFlags != null)
            {
                result.ObjectEntryUsageFlags = (ObjectEntryUsageFlags*)Interop.HeapUtil.Allocate<int>(this.ObjectEntryUsageFlags.Length).ToPointer();
                for (int index = 0; index < this.ObjectEntryUsageFlags.Length; index++)
                {
                    result.ObjectEntryUsageFlags[index] = this.ObjectEntryUsageFlags[index];
                }
            }
            else
            {
                result.ObjectEntryUsageFlags = null;
            }
            result.ObjectCount = (uint)(this.ObjectEntryUsageFlags?.Length ?? 0);
            result.MaxUniformBuffersPerDescriptor = this.MaxUniformBuffersPerDescriptor;
            result.MaxStorageBuffersPerDescriptor = this.MaxStorageBuffersPerDescriptor;
            result.MaxStorageImagesPerDescriptor = this.MaxStorageImagesPerDescriptor;
            result.MaxSampledImagesPerDescriptor = this.MaxSampledImagesPerDescriptor;
            result.MaxPipelineLayouts = this.MaxPipelineLayouts;
            return result;
        }
        
        internal unsafe Interop.ObjectTableCreateInfo* MarshalTo()
        {
            return (Interop.ObjectTableCreateInfo*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
        }
    }
}
