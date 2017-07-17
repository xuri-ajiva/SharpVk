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

namespace SharpVk.Interop
{
    /// <summary>
    /// 
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct GraphicsPipelineCreateInfo
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
        /// pname:flags is a bitmask of elink:VkPipelineCreateFlagBits
        /// controlling how the pipeline will be generated, as described below.
        /// </summary>
        public SharpVk.PipelineCreateFlags Flags; 
        
        /// <summary>
        /// pname:stageCount is the number of entries in the pname:pStages
        /// array.
        /// </summary>
        public uint StageCount; 
        
        /// <summary>
        /// pname:pStages is an array of size pname:stageCount structures of
        /// type slink:VkPipelineShaderStageCreateInfo describing the set of
        /// the shader stages to be included in the graphics pipeline.
        /// </summary>
        public SharpVk.Interop.PipelineShaderStageCreateInfo* Stages; 
        
        /// <summary>
        /// pname:pVertexInputState is a pointer to an instance of the
        /// slink:VkPipelineVertexInputStateCreateInfo structure.
        /// </summary>
        public SharpVk.Interop.PipelineVertexInputStateCreateInfo* VertexInputState; 
        
        /// <summary>
        /// pname:pInputAssemblyState is a pointer to an instance of the
        /// slink:VkPipelineInputAssemblyStateCreateInfo structure which
        /// determines input assembly behavior, as described in
        /// &lt;&lt;drawing, Drawing Commands&gt;&gt;.
        /// </summary>
        public SharpVk.Interop.PipelineInputAssemblyStateCreateInfo* InputAssemblyState; 
        
        /// <summary>
        /// pname:pTessellationState is a pointer to an instance of the
        /// slink:VkPipelineTessellationStateCreateInfo structure, or `NULL` if
        /// the pipeline does not include a tessellation control shader stage
        /// and tessellation evaluation shader stage.
        /// </summary>
        public SharpVk.Interop.PipelineTessellationStateCreateInfo* TessellationState; 
        
        /// <summary>
        /// pname:pViewportState is a pointer to an instance of the
        /// slink:VkPipelineViewportStateCreateInfo structure, or `NULL` if the
        /// pipeline has rasterization disabled.
        /// </summary>
        public SharpVk.Interop.PipelineViewportStateCreateInfo* ViewportState; 
        
        /// <summary>
        /// pname:pRasterizationState is a pointer to an instance of the
        /// slink:VkPipelineRasterizationStateCreateInfo structure.
        /// </summary>
        public SharpVk.Interop.PipelineRasterizationStateCreateInfo* RasterizationState; 
        
        /// <summary>
        /// pname:pMultisampleState is a pointer to an instance of the
        /// slink:VkPipelineMultisampleStateCreateInfo, or `NULL` if the
        /// pipeline has rasterization disabled.
        /// </summary>
        public SharpVk.Interop.PipelineMultisampleStateCreateInfo* MultisampleState; 
        
        /// <summary>
        /// pname:pDepthStencilState is a pointer to an instance of the
        /// slink:VkPipelineDepthStencilStateCreateInfo structure, or `NULL` if
        /// the pipeline has rasterization disabled or if the subpass of the
        /// render pass the pipeline is created against does not use a
        /// depth/stencil attachment.
        /// </summary>
        public SharpVk.Interop.PipelineDepthStencilStateCreateInfo* DepthStencilState; 
        
        /// <summary>
        /// pname:pColorBlendState is a pointer to an instance of the
        /// slink:VkPipelineColorBlendStateCreateInfo structure, or `NULL` if
        /// the pipeline has rasterization disabled or if the subpass of the
        /// render pass the pipeline is created against does not use any color
        /// attachments.
        /// </summary>
        public SharpVk.Interop.PipelineColorBlendStateCreateInfo* ColorBlendState; 
        
        /// <summary>
        /// pname:pDynamicState is a pointer to
        /// slink:VkPipelineDynamicStateCreateInfo and is used to indicate
        /// which properties of the pipeline state object are dynamic and can:
        /// be changed independently of the pipeline state. This can: be
        /// `NULL`, which means no state in the pipeline is considered dynamic.
        /// </summary>
        public SharpVk.Interop.PipelineDynamicStateCreateInfo* DynamicState; 
        
        /// <summary>
        /// pname:layout is the description of binding locations used by both
        /// the pipeline and descriptor sets used with the pipeline.
        /// </summary>
        public SharpVk.Interop.PipelineLayout Layout; 
        
        /// <summary>
        /// pname:renderPass is a handle to a render pass object describing the
        /// environment in which the pipeline will be used; the pipeline must:
        /// only be used with an instance of any render pass compatible with
        /// the one provided. See &lt;&lt;renderpass-compatibility,Render Pass
        /// Compatibility&gt;&gt; for more information.
        /// </summary>
        public SharpVk.Interop.RenderPass RenderPass; 
        
        /// <summary>
        /// pname:subpass is the index of the subpass in the render pass where
        /// this pipeline will be used.
        /// </summary>
        public uint Subpass; 
        
        /// <summary>
        /// pname:basePipelineHandle is a pipeline to derive from.
        /// </summary>
        public SharpVk.Interop.Pipeline BasePipelineHandle; 
        
        /// <summary>
        /// pname:basePipelineIndex is an index into the pname:pCreateInfos
        /// parameter to use as a pipeline to derive from.
        /// </summary>
        public int BasePipelineIndex; 
    }
}
