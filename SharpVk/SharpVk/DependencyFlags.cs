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
    /// Bitmask specifying how execution and memory dependencies are formed.
    /// </para>
    /// <para>
    /// When flink:vkCmdPipelineBarrier is submitted to a queue, it defines a
    /// memory dependency between commands that were submitted before it, and
    /// those submitted after it.
    /// </para>
    /// <para>
    /// If flink:vkCmdPipelineBarrier was recorded outside a render pass
    /// instance, the first &lt;&lt;synchronization-dependencies-scopes,
    /// synchronization scope&gt;&gt; includes every command submitted to the
    /// same queue before it, including those in the same command buffer and
    /// batch. If flink:vkCmdPipelineBarrier was recorded inside a render pass
    /// instance, the first synchronization scope includes only commands
    /// submitted before it within the same subpass. In either case, the first
    /// synchronization scope is limited to operations on the pipeline stages
    /// determined by the &lt;&lt;synchronization-pipeline-stages-masks, source
    /// stage mask&gt;&gt; specified by pname:srcStageMask.
    /// </para>
    /// <para>
    /// If flink:vkCmdPipelineBarrier was recorded outside a render pass
    /// instance, the second &lt;&lt;synchronization-dependencies-scopes,
    /// synchronization scope&gt;&gt; includes every command submitted to the
    /// same queue after it, including those in the same command buffer and
    /// batch. If flink:vkCmdPipelineBarrier was recorded inside a render pass
    /// instance, the second synchronization scope includes only commands
    /// submitted after it within the same subpass. In either case, the second
    /// synchronization scope is limited to operations on the pipeline stages
    /// determined by the &lt;&lt;synchronization-pipeline-stages-masks,
    /// destination stage mask&gt;&gt; specified by pname:dstStageMask.
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
