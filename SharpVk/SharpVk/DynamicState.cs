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
    /// Indicate which dynamic state is taken from dynamic state commands.
    /// </summary>
    public enum DynamicState
    {
        /// <summary>
        /// ename:VK_DYNAMIC_STATE_VIEWPORT indicates that the pname:pViewports
        /// state in sname:VkPipelineViewportStateCreateInfo will be ignored
        /// and must: be set dynamically with flink:vkCmdSetViewport before any
        /// draw commands. The number of viewports used by a pipeline is still
        /// specified by the pname:viewportCount member of
        /// sname:VkPipelineViewportStateCreateInfo.
        /// </summary>
        Viewport = 0, 
        
        /// <summary>
        /// ename:VK_DYNAMIC_STATE_SCISSOR indicates that the pname:pScissors
        /// state in sname:VkPipelineViewportStateCreateInfo will be ignored
        /// and must: be set dynamically with flink:vkCmdSetScissor before any
        /// draw commands. The number of scissor rectangles used by a pipeline
        /// is still specified by the pname:scissorCount member of
        /// sname:VkPipelineViewportStateCreateInfo.
        /// </summary>
        Scissor = 1, 
        
        /// <summary>
        /// ename:VK_DYNAMIC_STATE_LINE_WIDTH indicates that the
        /// pname:lineWidth state in
        /// sname:VkPipelineRasterizationStateCreateInfo will be ignored and
        /// must: be set dynamically with flink:vkCmdSetLineWidth before any
        /// draw commands that generate line primitives for the rasterizer.
        /// </summary>
        LineWidth = 2, 
        
        /// <summary>
        /// ename:VK_DYNAMIC_STATE_DEPTH_BIAS indicates that the
        /// pname:depthBiasConstantFactor, pname:depthBiasClamp and
        /// pname:depthBiasSlopeFactor states in
        /// sname:VkPipelineRasterizationStateCreateInfo will be ignored and
        /// must: be set dynamically with flink:vkCmdSetDepthBias before any
        /// draws are performed with pname:depthBiasEnable in
        /// sname:VkPipelineRasterizationStateCreateInfo set to ename:VK_TRUE.
        /// </summary>
        DepthBias = 3, 
        
        /// <summary>
        /// ename:VK_DYNAMIC_STATE_BLEND_CONSTANTS indicates that the
        /// pname:blendConstants state in
        /// sname:VkPipelineColorBlendStateCreateInfo will be ignored and must:
        /// be set dynamically with flink:vkCmdSetBlendConstants before any
        /// draws are performed with a pipeline state with
        /// sname:VkPipelineColorBlendAttachmentState member pname:blendEnable
        /// set to ename:VK_TRUE and any of the blend functions using a
        /// constant blend color.
        /// </summary>
        BlendConstants = 4, 
        
        /// <summary>
        /// ename:VK_DYNAMIC_STATE_DEPTH_BOUNDS indicates that the
        /// pname:minDepthBounds and pname:maxDepthBounds states of
        /// slink:VkPipelineDepthStencilStateCreateInfo will be ignored and
        /// must: be set dynamically with flink:vkCmdSetDepthBounds before any
        /// draws are performed with a pipeline state with
        /// sname:VkPipelineDepthStencilStateCreateInfo member
        /// pname:depthBoundsTestEnable set to ename:VK_TRUE.
        /// </summary>
        DepthBounds = 5, 
        
        /// <summary>
        /// ename:VK_DYNAMIC_STATE_STENCIL_COMPARE_MASK indicates that the
        /// pname:compareMask state in
        /// sname:VkPipelineDepthStencilStateCreateInfo for both pname:front
        /// and pname:back will be ignored and must: be set dynamically with
        /// flink:vkCmdSetStencilCompareMask before any draws are performed
        /// with a pipeline state with
        /// sname:VkPipelineDepthStencilStateCreateInfo member
        /// pname:stencilTestEnable set to ename:VK_TRUE
        /// </summary>
        StencilCompareMask = 6, 
        
        /// <summary>
        /// ename:VK_DYNAMIC_STATE_STENCIL_WRITE_MASK indicates that the
        /// pname:writeMask state in
        /// sname:VkPipelineDepthStencilStateCreateInfo for both pname:front
        /// and pname:back will be ignored and must: be set dynamically with
        /// flink:vkCmdSetStencilWriteMask before any draws are performed with
        /// a pipeline state with sname:VkPipelineDepthStencilStateCreateInfo
        /// member pname:stencilTestEnable set to ename:VK_TRUE
        /// </summary>
        StencilWriteMask = 7, 
        
        /// <summary>
        /// ename:VK_DYNAMIC_STATE_STENCIL_REFERENCE indicates that the
        /// pname:reference state in
        /// sname:VkPipelineDepthStencilStateCreateInfo for both pname:front
        /// and pname:back will be ignored and must: be set dynamically with
        /// flink:vkCmdSetStencilReference before any draws are performed with
        /// a pipeline state with sname:VkPipelineDepthStencilStateCreateInfo
        /// member pname:stencilTestEnable set to ename:VK_TRUE
        /// </summary>
        StencilReference = 8, 
    }
}
