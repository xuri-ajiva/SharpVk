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
    /// Structure specifying the parameters of a newly created pipeline layout
    /// object.
    /// </para>
    /// <para>
    /// .Valid Usage **** * pname:setLayoutCount must: be less than or equal to
    /// sname:VkPhysicalDeviceLimits::pname:maxBoundDescriptorSets * The total
    /// number of descriptors of the type ename:VK_DESCRIPTOR_TYPE_SAMPLER and
    /// ename:VK_DESCRIPTOR_TYPE_COMBINED_IMAGE_SAMPLER accessible to any given
    /// shader stage across all elements of pname:pSetLayouts must: be less
    /// than or equal to
    /// sname:VkPhysicalDeviceLimits::pname:maxPerStageDescriptorSamplers * The
    /// total number of descriptors of the type
    /// ename:VK_DESCRIPTOR_TYPE_UNIFORM_BUFFER and
    /// ename:VK_DESCRIPTOR_TYPE_UNIFORM_BUFFER_DYNAMIC accessible to any given
    /// shader stage across all elements of pname:pSetLayouts must: be less
    /// than or equal to
    /// sname:VkPhysicalDeviceLimits::pname:maxPerStageDescriptorUniformBuffers *
    /// The total number of descriptors of the type
    /// ename:VK_DESCRIPTOR_TYPE_STORAGE_BUFFER and
    /// ename:VK_DESCRIPTOR_TYPE_STORAGE_BUFFER_DYNAMIC accessible to any given
    /// shader stage across all elements of pname:pSetLayouts must: be less
    /// than or equal to
    /// sname:VkPhysicalDeviceLimits::pname:maxPerStageDescriptorStorageBuffers *
    /// The total number of descriptors of the type
    /// ename:VK_DESCRIPTOR_TYPE_COMBINED_IMAGE_SAMPLER, ename:VK_DESCRIPTOR_TYPE_SAMPLED_IMAGE,
    /// and ename:VK_DESCRIPTOR_TYPE_UNIFORM_TEXEL_BUFFER accessible to any
    /// given shader stage across all elements of pname:pSetLayouts must: be
    /// less than or equal to
    /// sname:VkPhysicalDeviceLimits::pname:maxPerStageDescriptorSampledImages *
    /// The total number of descriptors of the type
    /// ename:VK_DESCRIPTOR_TYPE_STORAGE_IMAGE, and
    /// ename:VK_DESCRIPTOR_TYPE_STORAGE_TEXEL_BUFFER accessible to any given
    /// shader stage across all elements of pname:pSetLayouts must: be less
    /// than or equal to
    /// sname:VkPhysicalDeviceLimits::pname:maxPerStageDescriptorStorageImages *
    /// Any two elements of pname:pPushConstantRanges must: not include the
    /// same stage in pname:stageFlags ****
    /// </para>
    /// </summary>
    public struct PipelineLayoutCreateInfo
    {
        /// <summary>
        /// pname:flags is reserved for future use.
        /// </summary>
        public PipelineLayoutCreateFlags Flags
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:pSetLayouts is a pointer to an array of
        /// sname:VkDescriptorSetLayout objects.
        /// </summary>
        public DescriptorSetLayout[] SetLayouts
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:pPushConstantRanges is a pointer to an array of
        /// sname:VkPushConstantRange structures defining a set of push
        /// constant ranges for use in a single pipeline layout. In addition to
        /// descriptor set layouts, a pipeline layout also describes how many
        /// push constants can: be accessed by each stage of the pipeline. +
        /// [NOTE] .Note ==== Push constants represent a high speed path to
        /// modify constant data in pipelines that is expected to outperform
        /// memory-backed resource updates. ====
        /// </summary>
        public PushConstantRange[] PushConstantRanges
        {
            get;
            set;
        }
        
        internal unsafe Interop.PipelineLayoutCreateInfo Pack()
        {
            Interop.PipelineLayoutCreateInfo result = default(Interop.PipelineLayoutCreateInfo);
            result.SType = StructureType.PipelineLayoutCreateInfo;
            
            //SetLayouts
            if (this.SetLayouts != null)
            {
                int size = System.Runtime.InteropServices.Marshal.SizeOf<Interop.DescriptorSetLayout>();
                IntPtr pointer = Interop.HeapUtil.Allocate<Interop.DescriptorSetLayout>(this.SetLayouts.Length);
                for (int index = 0; index < this.SetLayouts.Length; index++)
                {
                    System.Runtime.InteropServices.Marshal.StructureToPtr(this.SetLayouts[index].Pack(), pointer + (size * index), false);
                }
                result.SetLayouts = (Interop.DescriptorSetLayout*)pointer.ToPointer();
            }
            else
            {
                result.SetLayouts = null;
            }
            
            //PushConstantRanges
            if (this.PushConstantRanges != null)
            {
                result.PushConstantRanges = (PushConstantRange*)Interop.HeapUtil.Allocate<PushConstantRange>(this.PushConstantRanges.Length).ToPointer();
                for (int index = 0; index < this.PushConstantRanges.Length; index++)
                {
                    result.PushConstantRanges[index] = this.PushConstantRanges[index];
                }
            }
            else
            {
                result.PushConstantRanges = null;
            }
            result.SetLayoutCount = (uint)(this.SetLayouts?.Length ?? 0);
            result.PushConstantRangeCount = (uint)(this.PushConstantRanges?.Length ?? 0);
            result.Flags = this.Flags;
            return result;
        }
        
        internal unsafe Interop.PipelineLayoutCreateInfo* MarshalTo()
        {
            return (Interop.PipelineLayoutCreateInfo*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
        }
    }
}
