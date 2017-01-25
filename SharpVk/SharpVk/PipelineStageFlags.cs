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
    /// <para>
    /// Bitmask specifying pipeline stages.
    /// </para>
    /// <para>
    /// Several of the &lt;&lt;fundamentals-queueoperation-commandorder,
    /// synchronization commands&gt;&gt; include pipeline stage parameters,
    /// restricting the &lt;&lt;synchronization-dependencies-scopes,
    /// synchronization scopes&gt;&gt; for that command to those stages. This
    /// allows fine grained control over the exact execution dependencies and
    /// accesses performed by action commands. Implementations should: use
    /// these pipeline stages to avoid unnecessary stalls or cache flushing.
    /// </para>
    /// <para>
    /// ** ename:VK_PIPELINE_STAGE_TOP_OF_PIPE_BIT **
    /// ename:VK_PIPELINE_STAGE_DRAW_INDIRECT_BIT **
    /// ename:VK_PIPELINE_STAGE_VERTEX_INPUT_BIT **
    /// ename:VK_PIPELINE_STAGE_VERTEX_SHADER_BIT **
    /// ename:VK_PIPELINE_STAGE_TESSELLATION_CONTROL_SHADER_BIT **
    /// ename:VK_PIPELINE_STAGE_TESSELLATION_EVALUATION_SHADER_BIT **
    /// ename:VK_PIPELINE_STAGE_GEOMETRY_SHADER_BIT **
    /// ename:VK_PIPELINE_STAGE_FRAGMENT_SHADER_BIT **
    /// ename:VK_PIPELINE_STAGE_EARLY_FRAGMENT_TESTS_BIT **
    /// ename:VK_PIPELINE_STAGE_LATE_FRAGMENT_TESTS_BIT **
    /// ename:VK_PIPELINE_STAGE_COLOR_ATTACHMENT_OUTPUT_BIT **
    /// ename:VK_PIPELINE_STAGE_BOTTOM_OF_PIPE_BIT
    /// </para>
    /// <para>
    /// * ename:VK_PIPELINE_STAGE_ALL_COMMANDS_BIT: Equivalent to the logical
    /// or of every other pipeline stage flag that is supported on the queue it
    /// is used with.
    /// </para>
    /// <para>
    /// [NOTE] .Note ==== An execution dependency with only
    /// ename:VK_PIPELINE_STAGE_BOTTOM_OF_PIPE_BIT in the destination stage
    /// mask will only prevent that stage from executing in subsequently
    /// submitted commands. As this stage doesn't perform any actual execution,
    /// this is not observable - in effect, it does not delay processing of
    /// subsequent commands. Similarly an execution dependency with only
    /// ename:VK_PIPELINE_STAGE_TOP_OF_PIPE_BIT in the source stage mask will
    /// effectively not wait for any prior commands to complete.
    /// </para>
    /// <para>
    /// When defining a memory dependency, using only
    /// ename:VK_PIPELINE_STAGE_BOTTOM_OF_PIPE_BIT or
    /// ename:VK_PIPELINE_STAGE_TOP_OF_PIPE_BIT would never make any accesses
    /// available and/or visible because these stages do not access memory.
    /// </para>
    /// </summary>
    [Flags]
    public enum PipelineStageFlags
    {
        /// <summary>
        /// -
        /// </summary>
        None = 0, 
        
        /// <summary>
        /// ename:VK_PIPELINE_STAGE_TOP_OF_PIPE_BIT: Stage of the pipeline
        /// where any commands are initially received by the queue.
        /// ifdef::VK_NVX_device_generated_commands[]
        /// </summary>
        TopOfPipe = 1 << 0, 
        
        /// <summary>
        /// ename:VK_PIPELINE_STAGE_DRAW_INDIRECT_BIT: Stage of the pipeline
        /// where Draw/DispatchIndirect data structures are consumed.
        /// ifdef::VK_NVX_device_generated_commands[] This stage also includes
        /// reading commands written by flink:vkCmdProcessCommandsNVX.
        /// endif::VK_NVX_device_generated_commands[]
        /// </summary>
        DrawIndirect = 1 << 1, 
        
        /// <summary>
        /// ename:VK_PIPELINE_STAGE_VERTEX_INPUT_BIT: Stage of the pipeline
        /// where vertex and index buffers are consumed.
        /// </summary>
        VertexInput = 1 << 2, 
        
        /// <summary>
        /// ename:VK_PIPELINE_STAGE_VERTEX_SHADER_BIT: Vertex shader stage.
        /// </summary>
        VertexShader = 1 << 3, 
        
        /// <summary>
        /// ename:VK_PIPELINE_STAGE_TESSELLATION_CONTROL_SHADER_BIT:
        /// Tessellation control shader stage.
        /// </summary>
        TessellationControlShader = 1 << 4, 
        
        /// <summary>
        /// ename:VK_PIPELINE_STAGE_TESSELLATION_EVALUATION_SHADER_BIT:
        /// Tessellation evaluation shader stage.
        /// </summary>
        TessellationEvaluationShader = 1 << 5, 
        
        /// <summary>
        /// ename:VK_PIPELINE_STAGE_GEOMETRY_SHADER_BIT: Geometry shader stage.
        /// </summary>
        GeometryShader = 1 << 6, 
        
        /// <summary>
        /// ename:VK_PIPELINE_STAGE_FRAGMENT_SHADER_BIT: Fragment shader stage.
        /// </summary>
        FragmentShader = 1 << 7, 
        
        /// <summary>
        /// ename:VK_PIPELINE_STAGE_EARLY_FRAGMENT_TESTS_BIT: Stage of the
        /// pipeline where early fragment tests (depth and stencil tests before
        /// fragment shading) are performed. This stage also includes
        /// &lt;&lt;renderpass-load-store-ops, subpass load operations&gt;&gt;
        /// for framebuffer attachments with a depth/stencil format.
        /// </summary>
        EarlyFragmentTests = 1 << 8, 
        
        /// <summary>
        /// ename:VK_PIPELINE_STAGE_LATE_FRAGMENT_TESTS_BIT: Stage of the
        /// pipeline where late fragment tests (depth and stencil tests after
        /// fragment shading) are performed. This stage also includes
        /// &lt;&lt;renderpass-load-store-ops, subpass store operations&gt;&gt;
        /// for framebuffer attachments with a depth/stencil format.
        /// </summary>
        LateFragmentTests = 1 << 9, 
        
        /// <summary>
        /// ename:VK_PIPELINE_STAGE_COLOR_ATTACHMENT_OUTPUT_BIT: Stage of the
        /// pipeline after blending where the final color values are output
        /// from the pipeline. This stage also includes
        /// &lt;&lt;renderpass-load-store-ops, subpass load and store
        /// operations&gt;&gt; and multisample resolve operations for
        /// framebuffer attachments with a color format.
        /// </summary>
        ColorAttachmentOutput = 1 << 10, 
        
        /// <summary>
        /// ename:VK_PIPELINE_STAGE_COMPUTE_SHADER_BIT: Execution of a compute
        /// shader.
        /// </summary>
        ComputeShader = 1 << 11, 
        
        /// <summary>
        /// ename:VK_PIPELINE_STAGE_TRANSFER_BIT: Execution of copy commands.
        /// This includes the operations resulting from all &lt;&lt;copies,copy
        /// commands&gt;&gt;, &lt;&lt;clears,clear commands&gt;&gt; (with the
        /// exception of flink:vkCmdClearAttachments), and
        /// flink:vkCmdCopyQueryPoolResults.
        /// </summary>
        Transfer = 1 << 12, 
        
        /// <summary>
        /// ename:VK_PIPELINE_STAGE_BOTTOM_OF_PIPE_BIT: Final stage in the
        /// pipeline where operations generated by all commands complete
        /// execution.
        /// </summary>
        BottomOfPipe = 1 << 13, 
        
        /// <summary>
        /// ename:VK_PIPELINE_STAGE_HOST_BIT: A pseudo-stage indicating
        /// execution on the host of reads/writes of device memory. This stage
        /// is not invoked by any commands recorded in a command buffer.
        /// </summary>
        Host = 1 << 14, 
        
        /// <summary>
        /// ename:VK_PIPELINE_STAGE_ALL_GRAPHICS_BIT: Execution of all graphics
        /// pipeline stages. Equivalent to the logical or of:
        /// </summary>
        AllGraphics = 1 << 15, 
        
        /// <summary>
        /// All stages supported on the queue
        /// </summary>
        AllCommands = 1 << 16, 
        
        /// <summary>
        /// ename:VK_PIPELINE_STAGE_COMMAND_PROCESS_BIT_NVX: Stage of the
        /// pipeline where device-side generation of commands via
        /// flink:vkCmdProcessCommandsNVX is handled.
        /// endif::VK_NVX_device_generated_commands[]
        /// </summary>
        CommandProcessBit = 17, 
    }
}
