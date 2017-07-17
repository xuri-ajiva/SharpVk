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
using System.Runtime.InteropServices;

namespace SharpVk
{
    /// <summary>
    /// Structure specifying command buffer inheritance info.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CommandBufferInheritanceInfo
    {
        /// <summary>
        /// pname:renderPass is a sname:VkRenderPass object defining which
        /// render passes the sname:VkCommandBuffer will be
        /// &lt;&lt;renderpass-compatibility, compatible&gt;&gt; with and can:
        /// be executed within. If the sname:VkCommandBuffer will not be
        /// executed within a render pass instance, pname:renderPass is
        /// ignored.
        /// </summary>
        public SharpVk.RenderPass RenderPass
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:subpass is the index of the subpass within the render pass
        /// instance that the sname:VkCommandBuffer will be executed within. If
        /// the sname:VkCommandBuffer will not be executed within a render pass
        /// instance, pname:subpass is ignored.
        /// </summary>
        public uint Subpass
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:framebuffer optionally refers to the sname:VkFramebuffer
        /// object that the sname:VkCommandBuffer will be rendering to if it is
        /// executed within a render pass instance. It can: be
        /// dlink:VK_NULL_HANDLE if the framebuffer is not known, or if the
        /// sname:VkCommandBuffer will not be executed within a render pass
        /// instance. + [NOTE] .Note ==== Specifying the exact framebuffer that
        /// the secondary command buffer will be executed with may: result in
        /// better performance at command buffer execution time. ====
        /// </summary>
        public SharpVk.Framebuffer Framebuffer
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:occlusionQueryEnable indicates whether the command buffer
        /// can: be executed while an occlusion query is active in the primary
        /// command buffer. If this is ename:VK_TRUE, then this command buffer
        /// can: be executed whether the primary command buffer has an
        /// occlusion query active or not. If this is ename:VK_FALSE, then the
        /// primary command buffer must: not have an occlusion query active.
        /// </summary>
        public bool OcclusionQueryEnable
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:queryFlags indicates the query flags that can: be used by an
        /// active occlusion query in the primary command buffer when this
        /// secondary command buffer is executed. If this value includes the
        /// ename:VK_QUERY_CONTROL_PRECISE_BIT bit, then the active query can:
        /// return boolean results or actual sample counts. If this bit is not
        /// set, then the active query must: not use the
        /// ename:VK_QUERY_CONTROL_PRECISE_BIT bit.
        /// </summary>
        public SharpVk.QueryControlFlags? QueryFlags
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:pipelineStatistics indicates the set of pipeline statistics
        /// that can: be counted by an active query in the primary command
        /// buffer when this secondary command buffer is executed. If this
        /// value includes a given bit, then this command buffer can: be
        /// executed whether the primary command buffer has a pipeline
        /// statistics query active that includes this bit or not. If this
        /// value excludes a given bit, then the active pipeline statistics
        /// query must: not be from a query pool that counts that statistic.
        /// </summary>
        public SharpVk.QueryPipelineStatisticFlags? PipelineStatistics
        {
            get;
            set;
        }
        
        internal unsafe void MarshalTo(SharpVk.Interop.CommandBufferInheritanceInfo* pointer)
        {
            pointer->SType = StructureType.CommandBufferInheritanceInfo;
            pointer->Next = null;
            pointer->RenderPass = this.RenderPass?.handle ?? default(SharpVk.Interop.RenderPass);
            pointer->Subpass = this.Subpass;
            pointer->Framebuffer = this.Framebuffer?.handle ?? default(SharpVk.Interop.Framebuffer);
            pointer->OcclusionQueryEnable = this.OcclusionQueryEnable;
            if (this.QueryFlags != null)
            {
                pointer->QueryFlags = this.QueryFlags.Value;
            }
            else
            {
                pointer->QueryFlags = default(SharpVk.QueryControlFlags);
            }
            if (this.PipelineStatistics != null)
            {
                pointer->PipelineStatistics = this.PipelineStatistics.Value;
            }
            else
            {
                pointer->PipelineStatistics = default(SharpVk.QueryPipelineStatisticFlags);
            }
        }
    }
}
