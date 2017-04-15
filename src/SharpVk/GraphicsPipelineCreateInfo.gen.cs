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
    /// 
    /// </summary>
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
        public uint StageCount
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
        public PipelineTessellationStateCreateInfo TessellationState
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public PipelineViewportStateCreateInfo ViewportState
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
        public PipelineMultisampleStateCreateInfo MultisampleState
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public PipelineDepthStencilStateCreateInfo DepthStencilState
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public PipelineColorBlendStateCreateInfo ColorBlendState
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public PipelineDynamicStateCreateInfo DynamicState
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
            pointer->StageCount = this.StageCount;
            this.VertexInputState.MarshalTo(pointer->VertexInputState);
            this.InputAssemblyState.MarshalTo(pointer->InputAssemblyState);
            this.TessellationState.MarshalTo(pointer->TessellationState);
            this.ViewportState.MarshalTo(pointer->ViewportState);
            this.RasterizationState.MarshalTo(pointer->RasterizationState);
            this.MultisampleState.MarshalTo(pointer->MultisampleState);
            this.DepthStencilState.MarshalTo(pointer->DepthStencilState);
            this.ColorBlendState.MarshalTo(pointer->ColorBlendState);
            this.DynamicState.MarshalTo(pointer->DynamicState);
            pointer->Layout = this.Layout.handle;
            pointer->RenderPass = this.RenderPass.handle;
            pointer->Subpass = this.Subpass;
            pointer->BasePipelineHandle = this.BasePipelineHandle.handle;
            pointer->BasePipelineIndex = this.BasePipelineIndex;
        }
    }
}
