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
    /// Bitmask specifying pipeline stages.
    /// </para>
    /// <para>
    /// [NOTE] .Note ==== The ename:VK_PIPELINE_STAGE_ALL_COMMANDS_BIT and
    /// ename:VK_PIPELINE_STAGE_ALL_GRAPHICS_BIT differ from
    /// ename:VK_PIPELINE_STAGE_BOTTOM_OF_PIPE_BIT in that they correspond to
    /// all (or all graphics) stages, rather than to a specific stage at the
    /// end of the pipeline. An execution dependency with only
    /// ename:VK_PIPELINE_STAGE_BOTTOM_OF_PIPE_BIT in pname:dstStageMask will
    /// not delay subsequent commands, while including either of the other two
    /// bits will. Similarly, when defining a memory dependency, if the stage
    /// mask(s) refer to all stages, then the indicated access types from all
    /// stages will be made available and/or visible, but using only
    /// ename:VK_PIPELINE_STAGE_BOTTOM_OF_PIPE_BIT would not make any accesses
    /// available and/or visible because this stage does not access memory. The
    /// ename:VK_PIPELINE_STAGE_BOTTOM_OF_PIPE_BIT is useful for accomplishing
    /// memory barriers and layout transitions when the next accesses will be
    /// done in a different queue or by a presentation engine; in these cases
    /// subsequent commands in the same queue do not need to wait, but the
    /// barrier or transition must: complete before semaphores associated with
    /// the batch signal. ====
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
        /// where commands are initially received by the queue.
        /// </summary>
        TopOfPipe = 1 << 0, 
        
        /// <summary>
        /// ename:VK_PIPELINE_STAGE_DRAW_INDIRECT_BIT: Stage of the pipeline
        /// where Draw/DispatchIndirect data structures are consumed.
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
        /// fragment shading) are performed.
        /// </summary>
        EarlyFragmentTests = 1 << 8, 
        
        /// <summary>
        /// ename:VK_PIPELINE_STAGE_LATE_FRAGMENT_TESTS_BIT: Stage of the
        /// pipeline where late fragment tests (depth and stencil tests after
        /// fragment shading) are performed.
        /// </summary>
        LateFragmentTests = 1 << 9, 
        
        /// <summary>
        /// ename:VK_PIPELINE_STAGE_COLOR_ATTACHMENT_OUTPUT_BIT: Stage of the
        /// pipeline after blending where the final color values are output
        /// from the pipeline. This stage also includes resolve operations that
        /// occur at the end of a subpass. Note that this does not necessarily
        /// indicate that the values have been committed to memory.
        /// </summary>
        ColorAttachmentOutput = 1 << 10, 
        
        /// <summary>
        /// ename:VK_PIPELINE_STAGE_COMPUTE_SHADER_BIT: Execution of a compute
        /// shader.
        /// </summary>
        ComputeShader = 1 << 11, 
        
        /// <summary>
        /// ename:VK_PIPELINE_STAGE_TRANSFER_BIT: Execution of copy commands.
        /// This includes the operations resulting from all transfer commands.
        /// The set of transfer commands comprises fname:vkCmdCopyBuffer,
        /// fname:vkCmdCopyImage, fname:vkCmdBlitImage,
        /// fname:vkCmdCopyBufferToImage, fname:vkCmdCopyImageToBuffer,
        /// fname:vkCmdUpdateBuffer, fname:vkCmdFillBuffer,
        /// fname:vkCmdClearColorImage, fname:vkCmdClearDepthStencilImage,
        /// fname:vkCmdResolveImage, and fname:vkCmdCopyQueryPoolResults.
        /// </summary>
        Transfer = 1 << 12, 
        
        /// <summary>
        /// ename:VK_PIPELINE_STAGE_BOTTOM_OF_PIPE_BIT: Final stage in the
        /// pipeline where commands complete execution.
        /// </summary>
        BottomOfPipe = 1 << 13, 
        
        /// <summary>
        /// ename:VK_PIPELINE_STAGE_HOST_BIT: A pseudo-stage indicating
        /// execution on the host of reads/writes of device memory.
        /// </summary>
        Host = 1 << 14, 
        
        /// <summary>
        /// ename:VK_PIPELINE_STAGE_ALL_GRAPHICS_BIT: Execution of all graphics
        /// pipeline stages.
        /// </summary>
        AllGraphics = 1 << 15, 
        
        /// <summary>
        /// ename:VK_PIPELINE_STAGE_ALL_COMMANDS_BIT: Execution of all stages
        /// supported on the queue.
        /// </summary>
        AllCommands = 1 << 16, 
        
        /// <summary>
        /// -
        /// </summary>
        CommandProcessBitNvx = 17, 
    }
}
