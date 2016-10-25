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
using System.Runtime.InteropServices;

namespace SharpVk.Interop
{
    /// <summary>
    /// 
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct GraphicsPipelineCreateInfo
    {
        /// <summary>
        /// 
        /// </summary>
        public StructureType SType; 
        
        /// <summary>
        /// 
        /// </summary>
        public void* Next; 
        
        /// <summary>
        /// 
        /// </summary>
        public PipelineCreateFlags Flags; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint StageCount; 
        
        /// <summary>
        /// 
        /// </summary>
        public PipelineShaderStageCreateInfo* Stages; 
        
        /// <summary>
        /// 
        /// </summary>
        public PipelineVertexInputStateCreateInfo* VertexInputState; 
        
        /// <summary>
        /// 
        /// </summary>
        public PipelineInputAssemblyStateCreateInfo* InputAssemblyState; 
        
        /// <summary>
        /// 
        /// </summary>
        public PipelineTessellationStateCreateInfo* TessellationState; 
        
        /// <summary>
        /// 
        /// </summary>
        public PipelineViewportStateCreateInfo* ViewportState; 
        
        /// <summary>
        /// 
        /// </summary>
        public PipelineRasterizationStateCreateInfo* RasterizationState; 
        
        /// <summary>
        /// 
        /// </summary>
        public PipelineMultisampleStateCreateInfo* MultisampleState; 
        
        /// <summary>
        /// 
        /// </summary>
        public PipelineDepthStencilStateCreateInfo* DepthStencilState; 
        
        /// <summary>
        /// 
        /// </summary>
        public PipelineColorBlendStateCreateInfo* ColorBlendState; 
        
        /// <summary>
        /// 
        /// </summary>
        public PipelineDynamicStateCreateInfo* DynamicState; 
        
        /// <summary>
        /// 
        /// </summary>
        public PipelineLayout Layout; 
        
        /// <summary>
        /// 
        /// </summary>
        public RenderPass RenderPass; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint Subpass; 
        
        /// <summary>
        /// 
        /// </summary>
        public Pipeline BasePipelineHandle; 
        
        /// <summary>
        /// 
        /// </summary>
        public int BasePipelineIndex; 
    }
}
