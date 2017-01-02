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
    /// Enum specifying.
    /// </para>
    /// <para>
    /// .Supported indirect command tokens
    /// [width="80%",cols="67%,33%",options="header",align="center"] |====
    /// |Token type | Equivalent command
    /// |ename:VK_INDIRECT_COMMANDS_TOKEN_PIPELINE_NVX |
    /// fname:vkCmdBindPipeline |ename:VK_INDIRECT_COMMANDS_TOKEN_DESCRIPTOR_SET_NVX
    /// | fname:vkCmdBindDescriptorSets
    /// |ename:VK_INDIRECT_COMMANDS_TOKEN_INDEX_BUFFER_NVX |
    /// fname:vkCmdBindIndexBuffer |ename:VK_INDIRECT_COMMANDS_TOKEN_VERTEX_BUFFER_NVX
    /// | fname:vkCmdBindVertexBuffers
    /// |ename:VK_INDIRECT_COMMANDS_TOKEN_PUSH_CONSTANT_NVX |
    /// fname:vkCmdPushConstants |ename:VK_INDIRECT_COMMANDS_TOKEN_DRAW_INDEXED_NVX
    /// | fname:vkCmdDrawIndexedIndirect
    /// |ename:VK_INDIRECT_COMMANDS_TOKEN_DRAW_NVX | fname:vkCmdDrawIndirect
    /// |ename:VK_INDIRECT_COMMANDS_TOKEN_DISPATCH_NVX |
    /// fname:vkCmdDispatchIndirect |====
    /// </para>
    /// </summary>
    public enum IndirectCommandsTokenType
    {
        /// <summary>
        /// -
        /// </summary>
        PipelineNvx = 0, 
        
        /// <summary>
        /// -
        /// </summary>
        DescriptorSetNvx = 1, 
        
        /// <summary>
        /// -
        /// </summary>
        IndexBufferNvx = 2, 
        
        /// <summary>
        /// -
        /// </summary>
        VertexBufferNvx = 3, 
        
        /// <summary>
        /// -
        /// </summary>
        PushConstantNvx = 4, 
        
        /// <summary>
        /// -
        /// </summary>
        DrawIndexedNvx = 5, 
        
        /// <summary>
        /// -
        /// </summary>
        DrawNvx = 6, 
        
        /// <summary>
        /// -
        /// </summary>
        DispatchNvx = 7, 
    }
}
