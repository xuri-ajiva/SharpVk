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
    /// 
    /// </summary>
    public struct PipelineDepthStencilStateCreateInfo
    {
        /// <summary>
        /// 
        /// </summary>
        public PipelineDepthStencilStateCreateFlags Flags
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 DepthTestEnable
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 DepthWriteEnable
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public CompareOp DepthCompareOp
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 DepthBoundsTestEnable
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 StencilTestEnable
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public StencilOpState Front
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public StencilOpState Back
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public float MinDepthBounds
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public float MaxDepthBounds
        {
            get;
            set;
        }
        
        internal unsafe void MarshalTo(Interop.PipelineDepthStencilStateCreateInfo* pointer)
        {
            pointer->SType = StructureType.PipelineDepthStencilStateCreateInfo;
            pointer->Next = null;
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
