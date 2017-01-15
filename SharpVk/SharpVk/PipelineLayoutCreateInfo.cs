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
    /// Structure specifying the parameters of a newly created pipeline layout
    /// object.
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
        
        internal unsafe Interop.PipelineLayoutCreateInfo* MarshalTo()
        {
            var result = (Interop.PipelineLayoutCreateInfo*)Interop.HeapUtil.AllocateAndClear<Interop.PipelineLayoutCreateInfo>().ToPointer();
            this.MarshalTo(result);
            return result;
        }
        
        internal unsafe void MarshalTo(Interop.PipelineLayoutCreateInfo* pointer)
        {
            pointer->SType = StructureType.PipelineLayoutCreateInfo;
            pointer->Next = null;
            
            //SetLayouts
            if (this.SetLayouts != null)
            {
                var fieldPointer = (Interop.DescriptorSetLayout*)Interop.HeapUtil.AllocateAndClear<Interop.DescriptorSetLayout>(this.SetLayouts.Length);
                for (int index = 0; index < this.SetLayouts.Length; index++)
                {
                    this.SetLayouts[index].MarshalTo(&fieldPointer[index]);
                }
                pointer->SetLayouts = fieldPointer;
            }
            else
            {
                pointer->SetLayouts = null;
            }
            
            //PushConstantRanges
            if (this.PushConstantRanges != null)
            {
                pointer->PushConstantRanges = (PushConstantRange*)Interop.HeapUtil.Allocate<PushConstantRange>(this.PushConstantRanges.Length).ToPointer();
                for (int index = 0; index < this.PushConstantRanges.Length; index++)
                {
                    pointer->PushConstantRanges[index] = this.PushConstantRanges[index];
                }
            }
            else
            {
                pointer->PushConstantRanges = null;
            }
            pointer->SetLayoutCount = (uint)(this.SetLayouts?.Length ?? 0);
            pointer->PushConstantRangeCount = (uint)(this.PushConstantRanges?.Length ?? 0);
            pointer->Flags = this.Flags;
        }
    }
}
