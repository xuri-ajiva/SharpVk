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
    /// Specify the bind point of a pipeline object to a command buffer.
    /// </para>
    /// <para>
    /// Once bound, a pipeline binding affects subsequent graphics or compute
    /// commands in the command buffer until a different pipeline is bound to
    /// the bind point. The pipeline bound to
    /// ename:VK_PIPELINE_BIND_POINT_COMPUTE controls the behavior of
    /// flink:vkCmdDispatch and flink:vkCmdDispatchIndirect. The pipeline bound
    /// to ename:VK_PIPELINE_BIND_POINT_GRAPHICS controls the behavior of
    /// flink:vkCmdDraw, flink:vkCmdDrawIndexed, flink:vkCmdDrawIndirect, and
    /// flink:vkCmdDrawIndexedIndirect. No other commands are affected by the
    /// pipeline state.
    /// </para>
    /// </summary>
    public enum PipelineBindPoint
    {
        /// <summary>
        /// -
        /// </summary>
        Graphics = 0, 
        
        /// <summary>
        /// -
        /// </summary>
        Compute = 1, 
    }
}
