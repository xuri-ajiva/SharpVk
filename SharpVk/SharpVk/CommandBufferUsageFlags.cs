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
    /// Bitmask specifying usage behavior for command buffer.
    /// </para>
    /// <para>
    /// .Valid Usage **** * If pname:flags contains
    /// ename:VK_COMMAND_BUFFER_USAGE_RENDER_PASS_CONTINUE_BIT, the
    /// pname:renderPass member of pname:pInheritanceInfo must: be a valid
    /// sname:VkRenderPass * If pname:flags contains
    /// ename:VK_COMMAND_BUFFER_USAGE_RENDER_PASS_CONTINUE_BIT, the
    /// pname:subpass member of pname:pInheritanceInfo must: be a valid subpass
    /// index within the pname:renderPass member of pname:pInheritanceInfo * If
    /// pname:flags contains
    /// ename:VK_COMMAND_BUFFER_USAGE_RENDER_PASS_CONTINUE_BIT, the
    /// pname:framebuffer member of pname:pInheritanceInfo must: be either
    /// dlink:VK_NULL_HANDLE, or a valid sname:VkFramebuffer that is compatible
    /// with the pname:renderPass member of pname:pInheritanceInfo ****
    /// </para>
    /// </summary>
    [Flags]
    public enum CommandBufferUsageFlags
    {
        /// <summary>
        /// -
        /// </summary>
        None = 0, 
        
        /// <summary>
        /// -
        /// </summary>
        OneTimeSubmit = 1 << 0, 
        
        /// <summary>
        /// -
        /// </summary>
        RenderPassContinue = 1 << 1, 
        
        /// <summary>
        /// Command buffer may be submitted/executed more than once
        /// simultaneously
        /// </summary>
        SimultaneousUse = 1 << 2, 
    }
}
