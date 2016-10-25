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
    /// Structure specifying parameters of a newly created pipeline viewport
    /// state.
    /// </para>
    /// <para>
    /// .Valid Usage **** * If the
    /// &lt;&lt;features-features-multiViewport,multiple viewports&gt;&gt;
    /// feature is not enabled, pname:viewportCount must: be `1` * If the
    /// &lt;&lt;features-features-multiViewport,multiple viewports&gt;&gt;
    /// feature is not enabled, pname:scissorCount must: be `1` *
    /// pname:viewportCount must: be between `1` and
    /// sname:VkPhysicalDeviceLimits::pname:maxViewports, inclusive *
    /// pname:scissorCount must: be between `1` and
    /// sname:VkPhysicalDeviceLimits::pname:maxViewports, inclusive *
    /// pname:scissorCount and pname:viewportCount must: be identical ****
    /// </para>
    /// </summary>
    public struct PipelineViewportStateCreateInfo
    {
        /// <summary>
        /// pname:flags is reserved for future use.
        /// </summary>
        public PipelineViewportStateCreateFlags Flags
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:pViewports is a pointer to an array of slink:VkViewport
        /// structures, defining the viewport transforms. If the viewport state
        /// is dynamic, this member is ignored.
        /// </summary>
        public Viewport[] Viewports
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:pScissors is a pointer to an array of sname:VkRect2D
        /// structures which define the rectangular bounds of the scissor for
        /// the corresponding viewport. If the scissor state is dynamic, this
        /// member is ignored.
        /// </summary>
        public Rect2D[] Scissors
        {
            get;
            set;
        }
        
        internal unsafe Interop.PipelineViewportStateCreateInfo Pack()
        {
            Interop.PipelineViewportStateCreateInfo result = default(Interop.PipelineViewportStateCreateInfo);
            result.SType = StructureType.PipelineViewportStateCreateInfo;
            
            //Viewports
            if (this.Viewports != null)
            {
                result.Viewports = (Viewport*)Interop.HeapUtil.Allocate<Viewport>(this.Viewports.Length).ToPointer();
                for (int index = 0; index < this.Viewports.Length; index++)
                {
                    result.Viewports[index] = this.Viewports[index];
                }
            }
            else
            {
                result.Viewports = null;
            }
            
            //Scissors
            if (this.Scissors != null)
            {
                result.Scissors = (Rect2D*)Interop.HeapUtil.Allocate<Rect2D>(this.Scissors.Length).ToPointer();
                for (int index = 0; index < this.Scissors.Length; index++)
                {
                    result.Scissors[index] = this.Scissors[index];
                }
            }
            else
            {
                result.Scissors = null;
            }
            result.ViewportCount = (uint)(this.Viewports?.Length ?? 0);
            result.ScissorCount = (uint)(this.Scissors?.Length ?? 0);
            result.Flags = this.Flags;
            return result;
        }
        
        internal unsafe Interop.PipelineViewportStateCreateInfo* MarshalTo()
        {
            return (Interop.PipelineViewportStateCreateInfo*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
        }
    }
}
