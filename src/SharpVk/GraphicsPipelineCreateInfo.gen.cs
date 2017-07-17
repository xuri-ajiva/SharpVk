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
    /// Structure specifying parameters of a newly created graphics pipeline.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct GraphicsPipelineCreateInfo
    {
        /// <summary>
        /// pname:flags is a bitmask of elink:VkPipelineCreateFlagBits
        /// controlling how the pipeline will be generated, as described below.
        /// </summary>
        public SharpVk.PipelineCreateFlags? Flags
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:pStages is an array of size pname:stageCount structures of
        /// type slink:VkPipelineShaderStageCreateInfo describing the set of
        /// the shader stages to be included in the graphics pipeline.
        /// </summary>
        public SharpVk.PipelineShaderStageCreateInfo[] Stages
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:pVertexInputState is a pointer to an instance of the
        /// slink:VkPipelineVertexInputStateCreateInfo structure.
        /// </summary>
        public SharpVk.PipelineVertexInputStateCreateInfo VertexInputState
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
        public SharpVk.PipelineInputAssemblyStateCreateInfo InputAssemblyState
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
        public SharpVk.PipelineTessellationStateCreateInfo? TessellationState
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:pViewportState is a pointer to an instance of the
        /// slink:VkPipelineViewportStateCreateInfo structure, or `NULL` if the
        /// pipeline has rasterization disabled.
        /// </summary>
        public SharpVk.PipelineViewportStateCreateInfo? ViewportState
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:pRasterizationState is a pointer to an instance of the
        /// slink:VkPipelineRasterizationStateCreateInfo structure.
        /// </summary>
        public SharpVk.PipelineRasterizationStateCreateInfo RasterizationState
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:pMultisampleState is a pointer to an instance of the
        /// slink:VkPipelineMultisampleStateCreateInfo, or `NULL` if the
        /// pipeline has rasterization disabled.
        /// </summary>
        public SharpVk.PipelineMultisampleStateCreateInfo? MultisampleState
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
        public SharpVk.PipelineDepthStencilStateCreateInfo? DepthStencilState
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
        public SharpVk.PipelineColorBlendStateCreateInfo? ColorBlendState
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
        public SharpVk.PipelineDynamicStateCreateInfo? DynamicState
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:layout is the description of binding locations used by both
        /// the pipeline and descriptor sets used with the pipeline.
        /// </summary>
        public SharpVk.PipelineLayout Layout
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
        public SharpVk.RenderPass RenderPass
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
        public SharpVk.Pipeline BasePipelineHandle
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
        
        internal unsafe void MarshalTo(SharpVk.Interop.GraphicsPipelineCreateInfo* pointer)
        {
            pointer->SType = StructureType.GraphicsPipelineCreateInfo;
            pointer->Next = null;
            if (this.Flags != null)
            {
                pointer->Flags = this.Flags.Value;
            }
            else
            {
                pointer->Flags = default(SharpVk.PipelineCreateFlags);
            }
            pointer->StageCount = (uint)(this.Stages?.Length ?? 0);
            if (this.Stages != null)
            {
                var fieldPointer = (SharpVk.Interop.PipelineShaderStageCreateInfo*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.PipelineShaderStageCreateInfo>(this.Stages.Length).ToPointer());
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
            pointer->VertexInputState = (SharpVk.Interop.PipelineVertexInputStateCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.PipelineVertexInputStateCreateInfo>());
            this.VertexInputState.MarshalTo(pointer->VertexInputState);
            pointer->InputAssemblyState = (SharpVk.Interop.PipelineInputAssemblyStateCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.PipelineInputAssemblyStateCreateInfo>());
            this.InputAssemblyState.MarshalTo(pointer->InputAssemblyState);
            if (this.TessellationState != null)
            {
                pointer->TessellationState = (SharpVk.Interop.PipelineTessellationStateCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.PipelineTessellationStateCreateInfo>());
                this.TessellationState.Value.MarshalTo(pointer->TessellationState);
            }
            else
            {
                pointer->TessellationState = default(SharpVk.Interop.PipelineTessellationStateCreateInfo*);
            }
            if (this.ViewportState != null)
            {
                pointer->ViewportState = (SharpVk.Interop.PipelineViewportStateCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.PipelineViewportStateCreateInfo>());
                this.ViewportState.Value.MarshalTo(pointer->ViewportState);
            }
            else
            {
                pointer->ViewportState = default(SharpVk.Interop.PipelineViewportStateCreateInfo*);
            }
            pointer->RasterizationState = (SharpVk.Interop.PipelineRasterizationStateCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.PipelineRasterizationStateCreateInfo>());
            this.RasterizationState.MarshalTo(pointer->RasterizationState);
            if (this.MultisampleState != null)
            {
                pointer->MultisampleState = (SharpVk.Interop.PipelineMultisampleStateCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.PipelineMultisampleStateCreateInfo>());
                this.MultisampleState.Value.MarshalTo(pointer->MultisampleState);
            }
            else
            {
                pointer->MultisampleState = default(SharpVk.Interop.PipelineMultisampleStateCreateInfo*);
            }
            if (this.DepthStencilState != null)
            {
                pointer->DepthStencilState = (SharpVk.Interop.PipelineDepthStencilStateCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.PipelineDepthStencilStateCreateInfo>());
                this.DepthStencilState.Value.MarshalTo(pointer->DepthStencilState);
            }
            else
            {
                pointer->DepthStencilState = default(SharpVk.Interop.PipelineDepthStencilStateCreateInfo*);
            }
            if (this.ColorBlendState != null)
            {
                pointer->ColorBlendState = (SharpVk.Interop.PipelineColorBlendStateCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.PipelineColorBlendStateCreateInfo>());
                this.ColorBlendState.Value.MarshalTo(pointer->ColorBlendState);
            }
            else
            {
                pointer->ColorBlendState = default(SharpVk.Interop.PipelineColorBlendStateCreateInfo*);
            }
            if (this.DynamicState != null)
            {
                pointer->DynamicState = (SharpVk.Interop.PipelineDynamicStateCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.PipelineDynamicStateCreateInfo>());
                this.DynamicState.Value.MarshalTo(pointer->DynamicState);
            }
            else
            {
                pointer->DynamicState = default(SharpVk.Interop.PipelineDynamicStateCreateInfo*);
            }
            pointer->Layout = this.Layout?.handle ?? default(SharpVk.Interop.PipelineLayout);
            pointer->RenderPass = this.RenderPass?.handle ?? default(SharpVk.Interop.RenderPass);
            pointer->Subpass = this.Subpass;
            pointer->BasePipelineHandle = this.BasePipelineHandle?.handle ?? default(SharpVk.Interop.Pipeline);
            pointer->BasePipelineIndex = this.BasePipelineIndex;
        }
    }
}
