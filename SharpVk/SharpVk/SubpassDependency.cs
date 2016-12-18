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
using System.Runtime.InteropServices;
using System.Text;

namespace SharpVk
{
    /// <summary>
    /// <para>
    /// Structure specifying a subpass dependency.
    /// </para>
    /// <para>
    /// If pname:srcSubpass is equal to pname:dstSubpass then the
    /// slink:VkSubpassDependency describes a
    /// &lt;&lt;synchronization-pipeline-barriers-subpass-self-dependencies, subpass
    /// self-dependency&gt;&gt;, and only constrains the pipeline barriers
    /// allowed within a subpass instance. Otherwise, when a render pass
    /// instance which includes a subpass dependency is submitted to a queue,
    /// it defines a memory dependency between the subpasses identified by
    /// pname:srcSubpass and pname:dstSubpass.
    /// </para>
    /// <para>
    /// If pname:srcSubpass is equal to ename:VK_SUBPASS_EXTERNAL, the first
    /// &lt;&lt;synchronization-dependencies-scopes, synchronization
    /// scope&gt;&gt; includes commands submitted to the queue before the
    /// render pass instance began. Otherwise, the first set of commands
    /// includes all commands submitted as part of the subpass instance
    /// identified by pname:srcSubpass and any load, store or multisample
    /// resolve operations on attachments used in pname:srcSubpass. In either
    /// case, the first synchronization scope is limited to operations on the
    /// pipeline stages determined by the
    /// &lt;&lt;synchronization-pipeline-stages-masks, source stage
    /// mask&gt;&gt; specified by pname:srcStageMask.
    /// </para>
    /// <para>
    /// If pname:dstSubpass is equal to ename:VK_SUBPASS_EXTERNAL, the second
    /// &lt;&lt;synchronization-dependencies-scopes, synchronization
    /// scope&gt;&gt; includes commands submitted after the render pass
    /// instance is ended. Otherwise, the second set of commands includes all
    /// commands submitted as part of the subpass instance identified by
    /// pname:dstSubpass and any load, store or multisample resolve operations
    /// on attachments used in pname:dstSubpass. In either case, the second
    /// synchronization scope is limited to operations on the pipeline stages
    /// determined by the &lt;&lt;synchronization-pipeline-stages-masks,
    /// destination stage mask&gt;&gt; specified by pname:dstStageMask.
    /// </para>
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct SubpassDependency
    {
        /// <summary>
        /// 
        /// </summary>
        public SubpassDependency(uint sourceSubpass, uint destinationSubpass, PipelineStageFlags sourceStageMask, PipelineStageFlags destinationStageMask, AccessFlags sourceAccessMask, AccessFlags destinationAccessMask, DependencyFlags dependencyFlags)
        {
            this.SourceSubpass = sourceSubpass;
            this.DestinationSubpass = destinationSubpass;
            this.SourceStageMask = sourceStageMask;
            this.DestinationStageMask = destinationStageMask;
            this.SourceAccessMask = sourceAccessMask;
            this.DestinationAccessMask = destinationAccessMask;
            this.DependencyFlags = dependencyFlags;
        }
        
        /// <summary>
        /// pname:srcSubpass is the subpass index of the first subpass in the
        /// dependency, or ename:VK_SUBPASS_EXTERNAL.
        /// </summary>
        public uint SourceSubpass; 
        
        /// <summary>
        /// pname:dstSubpass is the subpass index of the second subpass in the
        /// dependency, or ename:VK_SUBPASS_EXTERNAL.
        /// </summary>
        public uint DestinationSubpass; 
        
        /// <summary>
        /// pname:srcStageMask defines a
        /// &lt;&lt;synchronization-pipeline-stages-masks, source stage
        /// mask&gt;&gt;.
        /// </summary>
        public PipelineStageFlags SourceStageMask; 
        
        /// <summary>
        /// pname:dstStageMask defines a
        /// &lt;&lt;synchronization-pipeline-stages-masks, destination stage
        /// mask&gt;&gt;.
        /// </summary>
        public PipelineStageFlags DestinationStageMask; 
        
        /// <summary>
        /// pname:srcAccessMask defines a &lt;&lt;synchronization-access-masks,
        /// source access mask&gt;&gt;.
        /// </summary>
        public AccessFlags SourceAccessMask; 
        
        /// <summary>
        /// pname:dstAccessMask defines a &lt;&lt;synchronization-access-masks,
        /// destination access mask&gt;&gt;.
        /// </summary>
        public AccessFlags DestinationAccessMask; 
        
        /// <summary>
        /// pname:dependencyFlags is a bitmask of elink:VkDependencyFlagBits.
        /// </summary>
        public DependencyFlags DependencyFlags; 
        
        /// <summary>
        /// 
        /// </summary>
        public override string ToString()
        {
            var builder = new StringBuilder();
            builder.AppendLine("SubpassDependency");
            builder.AppendLine("{");
            builder.AppendLine($"SourceSubpass: {this.SourceSubpass}");
            builder.AppendLine($"DestinationSubpass: {this.DestinationSubpass}");
            builder.AppendLine($"SourceStageMask: {this.SourceStageMask}");
            builder.AppendLine($"DestinationStageMask: {this.DestinationStageMask}");
            builder.AppendLine($"SourceAccessMask: {this.SourceAccessMask}");
            builder.AppendLine($"DestinationAccessMask: {this.DestinationAccessMask}");
            builder.AppendLine($"DependencyFlags: {this.DependencyFlags}");
            builder.Append("}");
            return builder.ToString();
        }
    }
}
