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

namespace SharpVk
{
    /// <summary>
    /// 
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct GraphicsPipelineCreateInfo
    {
        /// <summary>
        /// 
        /// </summary>
        public PipelineCreateFlags Flags
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public PipelineShaderStageCreateInfo[] Stages
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public PipelineVertexInputStateCreateInfo VertexInputState
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public PipelineInputAssemblyStateCreateInfo InputAssemblyState
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public PipelineTessellationStateCreateInfo? TessellationState
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public PipelineViewportStateCreateInfo? ViewportState
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public PipelineRasterizationStateCreateInfo RasterizationState
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public PipelineMultisampleStateCreateInfo? MultisampleState
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public PipelineDepthStencilStateCreateInfo? DepthStencilState
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public PipelineColorBlendStateCreateInfo? ColorBlendState
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public PipelineDynamicStateCreateInfo? DynamicState
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public PipelineLayout Layout
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public RenderPass RenderPass
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint Subpass
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public Pipeline BasePipelineHandle
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public int BasePipelineIndex
        {
            get;
            set;
        }
        
        internal unsafe void MarshalTo(Interop.GraphicsPipelineCreateInfo* pointer)
        {
            pointer->SType = StructureType.GraphicsPipelineCreateInfo;
            pointer->Next = null;
            pointer->Flags = this.Flags;
            pointer->StageCount = (uint)(this.Stages?.Length ?? 0);
            if (this.Stages != null)
            {
                var fieldPointer = (Interop.PipelineShaderStageCreateInfo*)(Interop.HeapUtil.AllocateAndClear<Interop.PipelineShaderStageCreateInfo>(this.Stages.Length).ToPointer());
                for(int index = 0; index < (uint)(this.Stages.Length); index++)
                {
                    this.Stages[index].MarshalTo(&fieldPointer[index]);
                }
                pointer->Stages = fieldPointer;
            }
            else
            {
                pointer->Stages = null;
            }
            pointer->VertexInputState = (Interop.PipelineVertexInputStateCreateInfo*)(Interop.HeapUtil.Allocate<Interop.PipelineVertexInputStateCreateInfo>());
            this.VertexInputState.MarshalTo(pointer->VertexInputState);
            pointer->InputAssemblyState = (Interop.PipelineInputAssemblyStateCreateInfo*)(Interop.HeapUtil.Allocate<Interop.PipelineInputAssemblyStateCreateInfo>());
            this.InputAssemblyState.MarshalTo(pointer->InputAssemblyState);
            if (this.TessellationState != null)
            {
                pointer->TessellationState = (Interop.PipelineTessellationStateCreateInfo*)(Interop.HeapUtil.Allocate<Interop.PipelineTessellationStateCreateInfo>());
                this.TessellationState.Value.MarshalTo(pointer->TessellationState);
            }
            if (this.ViewportState != null)
            {
                pointer->ViewportState = (Interop.PipelineViewportStateCreateInfo*)(Interop.HeapUtil.Allocate<Interop.PipelineViewportStateCreateInfo>());
                this.ViewportState.Value.MarshalTo(pointer->ViewportState);
            }
            pointer->RasterizationState = (Interop.PipelineRasterizationStateCreateInfo*)(Interop.HeapUtil.Allocate<Interop.PipelineRasterizationStateCreateInfo>());
            this.RasterizationState.MarshalTo(pointer->RasterizationState);
            if (this.MultisampleState != null)
            {
                pointer->MultisampleState = (Interop.PipelineMultisampleStateCreateInfo*)(Interop.HeapUtil.Allocate<Interop.PipelineMultisampleStateCreateInfo>());
                this.MultisampleState.Value.MarshalTo(pointer->MultisampleState);
            }
            if (this.DepthStencilState != null)
            {
                pointer->DepthStencilState = (Interop.PipelineDepthStencilStateCreateInfo*)(Interop.HeapUtil.Allocate<Interop.PipelineDepthStencilStateCreateInfo>());
                this.DepthStencilState.Value.MarshalTo(pointer->DepthStencilState);
            }
            if (this.ColorBlendState != null)
            {
                pointer->ColorBlendState = (Interop.PipelineColorBlendStateCreateInfo*)(Interop.HeapUtil.Allocate<Interop.PipelineColorBlendStateCreateInfo>());
                this.ColorBlendState.Value.MarshalTo(pointer->ColorBlendState);
            }
            if (this.DynamicState != null)
            {
                pointer->DynamicState = (Interop.PipelineDynamicStateCreateInfo*)(Interop.HeapUtil.Allocate<Interop.PipelineDynamicStateCreateInfo>());
                this.DynamicState.Value.MarshalTo(pointer->DynamicState);
            }
            pointer->Layout = this.Layout?.handle ?? default(Interop.PipelineLayout);
            pointer->RenderPass = this.RenderPass?.handle ?? default(Interop.RenderPass);
            pointer->Subpass = this.Subpass;
            pointer->BasePipelineHandle = this.BasePipelineHandle?.handle ?? default(Interop.Pipeline);
            pointer->BasePipelineIndex = this.BasePipelineIndex;
        }
    }
}
