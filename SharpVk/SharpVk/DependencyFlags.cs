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
