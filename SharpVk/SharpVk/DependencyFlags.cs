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
    /// Bitmask specifying dependencies between subpasses.
    /// </para>
    /// <para>
    /// Each subpass dependency defines an execution and memory dependency
    /// between two sets of commands, with the second set depending on the
    /// first set. When pname:srcSubpass does not equal pname:dstSubpass then
    /// the first set of commands is:
    /// </para>
    /// <para>
    /// * All commands in the subpass indicated by pname:srcSubpass, if
    /// pname:srcSubpass is not ename:VK_SUBPASS_EXTERNAL. * All commands
    /// before the render pass instance, if pname:srcSubpass is
    /// ename:VK_SUBPASS_EXTERNAL.
    /// </para>
    /// <para>
    /// While the corresponding second set of commands is:
    /// </para>
    /// <para>
    /// * All commands in the subpass indicated by pname:dstSubpass, if
    /// pname:dstSubpass is not ename:VK_SUBPASS_EXTERNAL. * All commands after
    /// the render pass instance, if pname:dstSubpass is
    /// ename:VK_SUBPASS_EXTERNAL.
    /// </para>
    /// <para>
    /// When pname:srcSubpass equals pname:dstSubpass then the first set
    /// consists of commands in the subpass before a call to
    /// flink:vkCmdPipelineBarrier and the second set consists of commands in
    /// the subpass following that same call as described in the
    /// &lt;&lt;synchronization-pipeline-barriers-subpass-self-dependencies, Subpass
    /// Self-dependency&gt;&gt; section.
    /// </para>
    /// <para>
    /// The pname:srcStageMask, pname:dstStageMask, pname:srcAccessMask,
    /// pname:dstAccessMask, and pname:dependencyFlags parameters of the
    /// dependency are interpreted the same way as for other dependencies, as
    /// described in &lt;&lt;synchronization, Synchronization and Cache
    /// Control&gt;&gt;.
    /// </para>
    /// <para>
    /// .Valid Usage **** * If the
    /// &lt;&lt;features-features-geometryShader,geometry shaders&gt;&gt;
    /// feature is not enabled, pname:srcStageMask must: not contain
    /// ename:VK_PIPELINE_STAGE_GEOMETRY_SHADER_BIT * If the
    /// &lt;&lt;features-features-geometryShader,geometry shaders&gt;&gt;
    /// feature is not enabled, pname:dstStageMask must: not contain
    /// ename:VK_PIPELINE_STAGE_GEOMETRY_SHADER_BIT * If the
    /// &lt;&lt;features-features-tessellationShader,tessellation shaders&gt;&gt;
    /// feature is not enabled, pname:srcStageMask must: not contain
    /// ename:VK_PIPELINE_STAGE_TESSELLATION_CONTROL_SHADER_BIT or
    /// ename:VK_PIPELINE_STAGE_TESSELLATION_EVALUATION_SHADER_BIT * If the
    /// &lt;&lt;features-features-tessellationShader,tessellation shaders&gt;&gt;
    /// feature is not enabled, pname:dstStageMask must: not contain
    /// ename:VK_PIPELINE_STAGE_TESSELLATION_CONTROL_SHADER_BIT or
    /// ename:VK_PIPELINE_STAGE_TESSELLATION_EVALUATION_SHADER_BIT *
    /// pname:srcSubpass must: be less than or equal to pname:dstSubpass,
    /// unless one of them is ename:VK_SUBPASS_EXTERNAL, to avoid cyclic
    /// dependencies and ensure a valid execution order * pname:srcSubpass and
    /// pname:dstSubpass must: not both be equal to ename:VK_SUBPASS_EXTERNAL *
    /// If pname:srcSubpass is equal to pname:dstSubpass, pname:srcStageMask
    /// and pname:dstStageMask must: only contain one of
    /// ename:VK_PIPELINE_STAGE_TOP_OF_PIPE_BIT, ename:VK_PIPELINE_STAGE_DRAW_INDIRECT_BIT,
    /// ename:VK_PIPELINE_STAGE_VERTEX_INPUT_BIT,
    /// ename:VK_PIPELINE_STAGE_VERTEX_SHADER_BIT, ename:VK_PIPELINE_STAGE_TESSELLATION_CONTROL_SHADER_BIT,
    /// ename:VK_PIPELINE_STAGE_TESSELLATION_EVALUATION_SHADER_BIT,
    /// ename:VK_PIPELINE_STAGE_GEOMETRY_SHADER_BIT, ename:VK_PIPELINE_STAGE_FRAGMENT_SHADER_BIT,
    /// ename:VK_PIPELINE_STAGE_EARLY_FRAGMENT_TESTS_BIT,
    /// ename:VK_PIPELINE_STAGE_LATE_FRAGMENT_TESTS_BIT, ename:VK_PIPELINE_STAGE_COLOR_ATTACHMENT_OUTPUT_BIT,
    /// ename:VK_PIPELINE_STAGE_BOTTOM_OF_PIPE_BIT, or
    /// ename:VK_PIPELINE_STAGE_ALL_GRAPHICS_BIT * If pname:srcSubpass is equal
    /// to pname:dstSubpass, the highest bit value included in
    /// pname:srcStageMask must: be less than or equal to the lowest bit value
    /// in pname:dstStageMask ****
    /// </para>
    /// </summary>
    [Flags]
    public enum DependencyFlags
    {
        /// <summary>
        /// -
        /// </summary>
        None = 0, 
        
        /// <summary>
        /// Dependency is per pixel region 
        /// </summary>
        ByRegion = 1 << 0, 
    }
}
