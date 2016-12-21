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
    /// Structure specifying parameters of a newly created graphics pipeline.
    /// </para>
    /// <para>
    /// The parameters pname:basePipelineHandle and pname:basePipelineIndex are
    /// described in more detail in
    /// &lt;&lt;pipelines-pipeline-derivatives,Pipeline Derivatives&gt;&gt;.
    /// </para>
    /// <para>
    /// pname:pStages points to an array of
    /// slink:VkPipelineShaderStageCreateInfo structures, which were previously
    /// described in &lt;&lt;pipelines-compute,Compute Pipelines&gt;&gt;.
    /// </para>
    /// <para>
    /// Bits which can: be set in pname:flags are:
    /// </para>
    /// </summary>
    public struct GraphicsPipelineCreateInfo
    {
        /// <summary>
        /// pname:flags is a bitmask of elink:VkPipelineCreateFlagBits
        /// controlling how the pipeline will be generated, as described below.
        /// </summary>
        public PipelineCreateFlags Flags
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:pStages is an array of size pname:stageCount structures of
        /// type slink:VkPipelineShaderStageCreateInfo describing the set of
        /// the shader stages to be included in the graphics pipeline.
        /// </summary>
        public PipelineShaderStageCreateInfo[] Stages
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:pVertexInputState is a pointer to an instance of the
        /// slink:VkPipelineVertexInputStateCreateInfo structure.
        /// </summary>
        public PipelineVertexInputStateCreateInfo? VertexInputState
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:pInputAssemblyState is a pointer to an instance of the
        /// slink:VkPipelineInputAssemblyStateCreateInfo structure which
        /// determines input assembly behavior, as described in
        /// &lt;&lt;drawing, Drawing Commands&gt;&gt;.
        /// </summary>
        public PipelineInputAssemblyStateCreateInfo? InputAssemblyState
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:pTessellationState is a pointer to an instance of the
        /// slink:VkPipelineTessellationStateCreateInfo structure, or `NULL` if
        /// the pipeline does not include a tessellation control shader stage
        /// and tessellation evaluation shader stage.
        /// </summary>
        public PipelineTessellationStateCreateInfo? TessellationState
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:pViewportState is a pointer to an instance of the
        /// slink:VkPipelineViewportStateCreateInfo structure, or `NULL` if the
        /// pipeline has rasterization disabled.
        /// </summary>
        public PipelineViewportStateCreateInfo? ViewportState
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:pRasterizationState is a pointer to an instance of the
        /// slink:VkPipelineRasterizationStateCreateInfo structure.
        /// </summary>
        public PipelineRasterizationStateCreateInfo? RasterizationState
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:pMultisampleState is a pointer to an instance of the
        /// slink:VkPipelineMultisampleStateCreateInfo, or `NULL` if the
        /// pipeline has rasterization disabled.
        /// </summary>
        public PipelineMultisampleStateCreateInfo? MultisampleState
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:pDepthStencilState is a pointer to an instance of the
        /// slink:VkPipelineDepthStencilStateCreateInfo structure, or `NULL` if
        /// the pipeline has rasterization disabled or if the subpass of the
        /// render pass the pipeline is created against does not use a
        /// depth/stencil attachment.
        /// </summary>
        public PipelineDepthStencilStateCreateInfo? DepthStencilState
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:pColorBlendState is a pointer to an instance of the
        /// slink:VkPipelineColorBlendStateCreateInfo structure, or `NULL` if
        /// the pipeline has rasterization disabled or if the subpass of the
        /// render pass the pipeline is created against does not use any color
        /// attachments.
        /// </summary>
        public PipelineColorBlendStateCreateInfo? ColorBlendState
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:pDynamicState is a pointer to
        /// slink:VkPipelineDynamicStateCreateInfo and is used to indicate
        /// which properties of the pipeline state object are dynamic and can:
        /// be changed independently of the pipeline state. This can: be
        /// `NULL`, which means no state in the pipeline is considered dynamic.
        /// </summary>
        public PipelineDynamicStateCreateInfo? DynamicState
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:layout is the description of binding locations used by both
        /// the pipeline and descriptor sets used with the pipeline.
        /// </summary>
        public PipelineLayout Layout
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:renderPass is a handle to a render pass object describing the
        /// environment in which the pipeline will be used; the pipeline must:
        /// only be used with an instance of any render pass compatible with
        /// the one provided. See &lt;&lt;renderpass-compatibility,Render Pass
        /// Compatibility&gt;&gt; for more information.
        /// </summary>
        public RenderPass RenderPass
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:subpass is the index of the subpass in the render pass where
        /// this pipeline will be used.
        /// </summary>
        public uint Subpass
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:basePipelineHandle is a pipeline to derive from.
        /// </summary>
        public Pipeline BasePipelineHandle
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:basePipelineIndex is an index into the pname:pCreateInfos
        /// parameter to use as a pipeline to derive from.
        /// </summary>
        public int BasePipelineIndex
        {
            get;
            set;
        }
        
        internal unsafe Interop.GraphicsPipelineCreateInfo* MarshalTo()
        {
            var result = (Interop.GraphicsPipelineCreateInfo*)Interop.HeapUtil.AllocateAndClear<Interop.GraphicsPipelineCreateInfo>().ToPointer();
            this.MarshalTo(result);
            return result;
        }
        
        internal unsafe void MarshalTo(Interop.GraphicsPipelineCreateInfo* pointer)
        {
            pointer->SType = StructureType.GraphicsPipelineCreateInfo;
            
            //Stages
            if (this.Stages != null)
            {
                var fieldPointer = (Interop.PipelineShaderStageCreateInfo*)Interop.HeapUtil.AllocateAndClear<Interop.PipelineShaderStageCreateInfo>(this.Stages.Length);
                for (int index = 0; index < this.Stages.Length; index++)
                {
                    this.Stages[index].MarshalTo(&fieldPointer[index]);
                }
                pointer->Stages = fieldPointer;
            }
            else
            {
                pointer->Stages = null;
            }
            pointer->VertexInputState = this.VertexInputState == null ? null : this.VertexInputState.Value.MarshalTo();
            pointer->InputAssemblyState = this.InputAssemblyState == null ? null : this.InputAssemblyState.Value.MarshalTo();
            pointer->TessellationState = this.TessellationState == null ? null : this.TessellationState.Value.MarshalTo();
            pointer->ViewportState = this.ViewportState == null ? null : this.ViewportState.Value.MarshalTo();
            pointer->RasterizationState = this.RasterizationState == null ? null : this.RasterizationState.Value.MarshalTo();
            pointer->MultisampleState = this.MultisampleState == null ? null : this.MultisampleState.Value.MarshalTo();
            pointer->DepthStencilState = this.DepthStencilState == null ? null : this.DepthStencilState.Value.MarshalTo();
            pointer->ColorBlendState = this.ColorBlendState == null ? null : this.ColorBlendState.Value.MarshalTo();
            pointer->DynamicState = this.DynamicState == null ? null : this.DynamicState.Value.MarshalTo();
            this.Layout?.MarshalTo(&pointer->Layout);
            this.RenderPass?.MarshalTo(&pointer->RenderPass);
            this.BasePipelineHandle?.MarshalTo(&pointer->BasePipelineHandle);
            pointer->StageCount = (uint)(this.Stages?.Length ?? 0);
            pointer->Flags = this.Flags;
            pointer->Subpass = this.Subpass;
            pointer->BasePipelineIndex = this.BasePipelineIndex;
        }
    }
}
