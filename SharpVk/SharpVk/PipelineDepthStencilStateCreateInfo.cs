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
    /// Structure specifying parameters of a newly created pipeline depth
    /// stencil state.
    /// </summary>
    public struct PipelineDepthStencilStateCreateInfo
    {
        /// <summary>
        /// pname:flags is reserved for future use.
        /// </summary>
        public PipelineDepthStencilStateCreateFlags Flags
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:depthTestEnable controls whether &lt;&lt;fragops-depth,depth
        /// testing&gt;&gt; is enabled.
        /// </summary>
        public Bool32 DepthTestEnable
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:depthWriteEnable controls whether
        /// &lt;&lt;fragops-depth-write,depth writes&gt;&gt; are enabled.
        /// </summary>
        public Bool32 DepthWriteEnable
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:depthCompareOp is the comparison operator used in the
        /// &lt;&lt;fragops-depth,depth test&gt;&gt;.
        /// </summary>
        public CompareOp DepthCompareOp
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:depthBoundsTestEnable controls whether
        /// &lt;&lt;fragops-dbt,depth bounds testing&gt;&gt; is enabled.
        /// </summary>
        public Bool32 DepthBoundsTestEnable
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:stencilTestEnable controls whether
        /// &lt;&lt;fragops-stencil,stencil testing&gt;&gt; is enabled.
        /// </summary>
        public Bool32 StencilTestEnable
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:front and pname:back control the parameters of the
        /// &lt;&lt;fragops-stencil,stencil test&gt;&gt;.
        /// </summary>
        public StencilOpState Front
        {
            get;
            set;
        }
        
        /// <summary>
        /// -
        /// </summary>
        public StencilOpState Back
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:minDepthBounds and pname:maxDepthBounds define the range of
        /// values used in the &lt;&lt;fragops-dbt,depth bounds test&gt;&gt;.
        /// </summary>
        public float MinDepthBounds
        {
            get;
            set;
        }
        
        /// <summary>
        /// -
        /// </summary>
        public float MaxDepthBounds
        {
            get;
            set;
        }
        
        internal unsafe Interop.PipelineDepthStencilStateCreateInfo Pack()
        {
            Interop.PipelineDepthStencilStateCreateInfo result = default(Interop.PipelineDepthStencilStateCreateInfo);
            return result;
        }
        
        internal unsafe Interop.PipelineDepthStencilStateCreateInfo* MarshalTo()
        {
            var result = (Interop.PipelineDepthStencilStateCreateInfo*)Interop.HeapUtil.Allocate<Interop.PipelineDepthStencilStateCreateInfo>().ToPointer();
            this.MarshalTo(result);
            return result;
        }
        
        internal unsafe void MarshalTo(Interop.PipelineDepthStencilStateCreateInfo* pointer)
        {
            pointer->SType = StructureType.PipelineDepthStencilStateCreateInfo;
            pointer->Flags = this.Flags;
            pointer->DepthTestEnable = this.DepthTestEnable;
            pointer->DepthWriteEnable = this.DepthWriteEnable;
            pointer->DepthCompareOp = this.DepthCompareOp;
            pointer->DepthBoundsTestEnable = this.DepthBoundsTestEnable;
            pointer->StencilTestEnable = this.StencilTestEnable;
            pointer->Front = this.Front;
            pointer->Back = this.Back;
            pointer->MinDepthBounds = this.MinDepthBounds;
            pointer->MaxDepthBounds = this.MaxDepthBounds;
        }
    }
}
