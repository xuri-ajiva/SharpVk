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
    /// Bitmask controlling how a pipeline is generated.
    /// </para>
    /// <para>
    /// It is valid to set both ename:VK_PIPELINE_CREATE_ALLOW_DERIVATIVES_BIT
    /// and ename:VK_PIPELINE_CREATE_DERIVATIVE_BIT. This allows a pipeline to
    /// be both a parent and possibly a child in a pipeline hierarchy. See
    /// &lt;&lt;pipelines-pipeline-derivatives,Pipeline Derivatives&gt;&gt; for
    /// more information.
    /// </para>
    /// <para>
    /// pname:pDynamicState points to a structure of type
    /// sname:VkPipelineDynamicStateCreateInfo.
    /// </para>
    /// <para>
    /// ifdef::VK_NV_glsl_shader[] If any shader stage fails to compile,
    /// ifdef::VK_EXT_debug_report[] the compile log will be reported back to
    /// the application, and endif::VK_EXT_debug_report[]
    /// ename:VK_ERROR_INVALID_SHADER_NV will be generated.
    /// endif::VK_NV_glsl_shader[]
    /// </para>
    /// <para>
    /// .Valid Usage **** * If pname:flags contains the
    /// ename:VK_PIPELINE_CREATE_DERIVATIVE_BIT flag, and
    /// pname:basePipelineIndex is not `-1`, pname:basePipelineHandle must: be
    /// dlink:VK_NULL_HANDLE * If pname:flags contains the
    /// ename:VK_PIPELINE_CREATE_DERIVATIVE_BIT flag, and
    /// pname:basePipelineIndex is not `-1`, it must: be a valid index into the
    /// calling command's pname:pCreateInfos parameter * If pname:flags
    /// contains the ename:VK_PIPELINE_CREATE_DERIVATIVE_BIT flag, and
    /// pname:basePipelineHandle is not dlink:VK_NULL_HANDLE,
    /// pname:basePipelineIndex must: be `-1` * If pname:flags contains the
    /// ename:VK_PIPELINE_CREATE_DERIVATIVE_BIT flag, and
    /// pname:basePipelineHandle is not dlink:VK_NULL_HANDLE,
    /// pname:basePipelineHandle must: be a valid sname:VkPipeline handle * If
    /// pname:flags contains the ename:VK_PIPELINE_CREATE_DERIVATIVE_BIT flag,
    /// and pname:basePipelineHandle is not dlink:VK_NULL_HANDLE, it must: be a
    /// valid handle to a graphics sname:VkPipeline * The pname:stage member of
    /// each element of pname:pStages must: be unique * The pname:stage member
    /// of one element of pname:pStages must: be
    /// ename:VK_SHADER_STAGE_VERTEX_BIT * The pname:stage member of any given
    /// element of pname:pStages must: not be ename:VK_SHADER_STAGE_COMPUTE_BIT
    /// * If pname:pStages includes a tessellation control shader stage, it
    /// must: include a tessellation evaluation shader stage * If pname:pStages
    /// includes a tessellation evaluation shader stage, it must: include a
    /// tessellation control shader stage * If pname:pStages includes a
    /// tessellation control shader stage and a tessellation evaluation shader
    /// stage, pname:pTessellationState must: not be `NULL` * If pname:pStages
    /// includes tessellation shader stages, the shader code of at least one
    /// stage must: contain an code:OpExecutionMode instruction that specifies
    /// the type of subdivision in the pipeline * If pname:pStages includes
    /// tessellation shader stages, and the shader code of both stages contain
    /// an code:OpExecutionMode instruction that specifies the type of
    /// subdivision in the pipeline, they must: both specify the same
    /// subdivision mode * If pname:pStages includes tessellation shader
    /// stages, the shader code of at least one stage must: contain an
    /// code:OpExecutionMode instruction that specifies the output patch size
    /// in the pipeline * If pname:pStages includes tessellation shader stages,
    /// and the shader code of both contain an code:OpExecutionMode instruction
    /// that specifies the out patch size in the pipeline, they must: both
    /// specify the same patch size * If pname:pStages includes tessellation
    /// shader stages, the pname:topology member of pname:pInputAssembly must:
    /// be ename:VK_PRIMITIVE_TOPOLOGY_PATCH_LIST * If the pname:topology
    /// member of pname:pInputAssembly is
    /// ename:VK_PRIMITIVE_TOPOLOGY_PATCH_LIST, pname:pStages must: include
    /// tessellation shader stages * If pname:pStages includes a geometry
    /// shader stage, and does not include any tessellation shader stages, its
    /// shader code must: contain an code:OpExecutionMode instruction that
    /// specifies an input primitive type that is
    /// &lt;&lt;shaders-geometry-execution, compatible&gt;&gt; with the
    /// primitive topology specified in pname:pInputAssembly * If pname:pStages
    /// includes a geometry shader stage, and also includes tessellation shader
    /// stages, its shader code must: contain an code:OpExecutionMode
    /// instruction that specifies an input primitive type that is
    /// &lt;&lt;shaders-geometry-execution, compatible&gt;&gt; with the
    /// primitive topology that is output by the tessellation stages * If
    /// pname:pStages includes a fragment shader stage and a geometry shader
    /// stage, and the fragment shader code reads from an input variable that
    /// is decorated with code:PrimitiveID, then the geometry shader code must:
    /// write to a matching output variable, decorated with code:PrimitiveID,
    /// in all execution paths * If pname:pStages includes a fragment shader
    /// stage, its shader code must: not read from any input attachment that is
    /// defined as ename:VK_ATTACHMENT_UNUSED in pname:subpass * The shader
    /// code for the entry points identified by pname:pStages, and the rest of
    /// the state identified by this structure must: adhere to the pipeline
    /// linking rules described in the &lt;&lt;interfaces,Shader
    /// Interfaces&gt;&gt; chapter * If pname:subpass uses a depth/stencil
    /// attachment in pname:renderpass that has a layout of
    /// ename:VK_IMAGE_LAYOUT_DEPTH_STENCIL_READ_ONLY_OPTIMAL in the
    /// sname:VkAttachmentReference defined by pname:subpass, and
    /// pname:pDepthStencilState is not `NULL`, the pname:depthWriteEnable
    /// member of pname:pDepthStencilState must: be ename:VK_FALSE * If
    /// pname:subpass uses a depth/stencil attachment in pname:renderpass that
    /// has a layout of ename:VK_IMAGE_LAYOUT_DEPTH_STENCIL_READ_ONLY_OPTIMAL
    /// in the sname:VkAttachmentReference defined by pname:subpass, and
    /// pname:pDepthStencilState is not `NULL`, the pname:failOp, pname:passOp
    /// and pname:depthFailOp members of each of the pname:front and pname:back
    /// members of pname:pDepthStencilState must: be ename:VK_STENCIL_OP_KEEP *
    /// If pname:pColorBlendState is not `NULL`, the pname:blendEnable member
    /// of each element of the pname:pAttachment member of
    /// pname:pColorBlendState must: be ename:VK_FALSE if the pname:format of
    /// the attachment referred to in pname:subpass of pname:renderPass does
    /// not support color blend operations, as specified by the
    /// ename:VK_FORMAT_FEATURE_COLOR_ATTACHMENT_BLEND_BIT flag in
    /// sname:VkFormatProperties::pname:linearTilingFeatures or
    /// sname:VkFormatProperties::pname:optimalTilingFeatures returned by
    /// fname:vkGetPhysicalDeviceFormatProperties * If pname:pColorBlendState
    /// is not `NULL`, The pname:attachmentCount member of
    /// pname:pColorBlendState must: be equal to the pname:colorAttachmentCount
    /// used to create pname:subpass * If no element of the
    /// pname:pDynamicStates member of pname:pDynamicState is
    /// ename:VK_DYNAMIC_STATE_VIEWPORT, the pname:pViewports member of
    /// pname:pViewportState must: be a pointer to an array of
    /// pname:pViewportState::pname:viewportCount sname:VkViewport structures *
    /// If no element of the pname:pDynamicStates member of pname:pDynamicState
    /// is ename:VK_DYNAMIC_STATE_SCISSOR, the pname:pScissors member of
    /// pname:pViewportState must: be a pointer to an array of
    /// pname:pViewportState::pname:scissorCount sname:VkRect2D structures * If
    /// the wide lines feature is not enabled, and no element of the
    /// pname:pDynamicStates member of pname:pDynamicState is
    /// ename:VK_DYNAMIC_STATE_LINE_WIDTH, the pname:lineWidth member of
    /// pname:pRasterizationState must: be `1.0` * If the
    /// pname:rasterizerDiscardEnable member of pname:pRasterizationState is
    /// ename:VK_FALSE, pname:pViewportState must: be a pointer to a valid
    /// sname:VkPipelineViewportStateCreateInfo structure * If the
    /// pname:rasterizerDiscardEnable member of pname:pRasterizationState is
    /// ename:VK_FALSE, pname:pMultisampleState must: be a pointer to a valid
    /// sname:VkPipelineMultisampleStateCreateInfo structure * If the
    /// pname:rasterizerDiscardEnable member of pname:pRasterizationState is
    /// ename:VK_FALSE, and pname:subpass uses a depth/stencil attachment,
    /// pname:pDepthStencilState must: be a pointer to a valid
    /// sname:VkPipelineDepthStencilStateCreateInfo structure * If the
    /// pname:rasterizerDiscardEnable member of pname:pRasterizationState is
    /// ename:VK_FALSE, and pname:subpass uses color attachments,
    /// pname:pColorBlendState must: be a pointer to a valid
    /// sname:VkPipelineColorBlendStateCreateInfo structure * If the depth bias
    /// clamping feature is not enabled, no element of the pname:pDynamicStates
    /// member of pname:pDynamicState is ename:VK_DYNAMIC_STATE_DEPTH_BIAS, and
    /// the pname:depthBiasEnable member of pname:pDepthStencil is
    /// ename:VK_TRUE, the pname:depthBiasClamp member of pname:pDepthStencil
    /// must: be `0.0` * If no element of the pname:pDynamicStates member of
    /// pname:pDynamicState is ename:VK_DYNAMIC_STATE_DEPTH_BOUNDS, and the
    /// pname:depthBoundsTestEnable member of pname:pDepthStencil is
    /// ename:VK_TRUE, the pname:minDepthBounds and pname:maxDepthBounds
    /// members of pname:pDepthStencil must: be between `0.0` and `1.0`,
    /// inclusive * pname:layout must: be
    /// &lt;&lt;descriptorsets-pipelinelayout-consistency,consistent&gt;&gt; with
    /// all shaders specified in pname:pStages * If pname:subpass uses color
    /// and/or depth/stencil attachments, then the pname:rasterizationSamples
    /// member of pname:pMultisampleState must: be the same as the sample count
    /// for those subpass attachments * If pname:subpass does not use any color
    /// and/or depth/stencil attachments, then the pname:rasterizationSamples
    /// member of pname:pMultisampleState must: follow the rules for a
    /// &lt;&lt;renderpass-noattachments, zero-attachment subpass&gt;&gt; *
    /// pname:subpass must: be a valid subpass within pname:renderpass ****
    /// </para>
    /// </summary>
    [Flags]
    public enum PipelineCreateFlags
    {
        /// <summary>
        /// -
        /// </summary>
        None = 0, 
        
        /// <summary>
        /// ename:VK_PIPELINE_CREATE_DISABLE_OPTIMIZATION_BIT specifies that
        /// the created pipeline will not be optimized. Using this flag may:
        /// reduce the time taken to create the pipeline.
        /// </summary>
        DisableOptimization = 1 << 0, 
        
        /// <summary>
        /// ename:VK_PIPELINE_CREATE_ALLOW_DERIVATIVES_BIT specifies that the
        /// pipeline to be created is allowed to be the parent of a pipeline
        /// that will be created in a subsequent call to
        /// flink:vkCreateGraphicsPipelines.
        /// </summary>
        AllowDerivatives = 1 << 1, 
        
        /// <summary>
        /// ename:VK_PIPELINE_CREATE_DERIVATIVE_BIT specifies that the pipeline
        /// to be created will be a child of a previously created parent
        /// pipeline.
        /// </summary>
        Derivative = 1 << 2, 
    }
}
