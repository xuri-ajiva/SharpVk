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
    /// Structure specifying a subpass dependency.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct SubpassDependency
    {
        /// <summary>
        /// pname:srcSubpass and pname:dstSubpass are the subpass indices of
        /// the producer and consumer subpasses, respectively. pname:srcSubpass
        /// and pname:dstSubpass can: also have the special value
        /// ename:VK_SUBPASS_EXTERNAL. The source subpass must: always be a
        /// lower numbered subpass than the destination subpass (excluding
        /// external subpasses and
        /// &lt;&lt;synchronization-pipeline-barriers-subpass-self-dependencies, self-dependencies&gt;&gt;),
        /// so that the order of subpass descriptions is a valid execution
        /// ordering, avoiding cycles in the dependency graph.
        /// </summary>
        public uint SourceSubpass; 
        
        /// <summary>
        /// -
        /// </summary>
        public uint DestinationSubpass; 
        
        /// <summary>
        /// pname:srcStageMask, pname:dstStageMask, pname:srcAccessMask,
        /// pname:dstAccessMask, and pname:dependencyFlags describe an
        /// &lt;&lt;synchronization-execution-and-memory-dependencies,execution and
        /// memory dependency&gt;&gt; between subpasses. The bits that can: be
        /// included in pname:dependencyFlags are: + --
        /// </summary>
        public PipelineStageFlags SourceStageMask; 
        
        /// <summary>
        /// -
        /// </summary>
        public PipelineStageFlags DestinationStageMask; 
        
        /// <summary>
        /// -
        /// </summary>
        public AccessFlags SourceAccessMask; 
        
        /// <summary>
        /// -
        /// </summary>
        public AccessFlags DestinationAccessMask; 
        
        /// <summary>
        /// -
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
