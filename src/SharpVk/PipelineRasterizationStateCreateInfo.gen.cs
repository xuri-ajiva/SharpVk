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
    /// 
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct PipelineRasterizationStateCreateInfo
    {
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.PipelineRasterizationStateCreateFlags? Flags
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool DepthClampEnable
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool RasterizerDiscardEnable
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.PolygonMode PolygonMode
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.CullModeFlags? CullMode
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.FrontFace FrontFace
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool DepthBiasEnable
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public float DepthBiasConstantFactor
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public float DepthBiasClamp
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public float DepthBiasSlopeFactor
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public float LineWidth
        {
            get;
            set;
        }
        
        internal unsafe void MarshalTo(SharpVk.Interop.PipelineRasterizationStateCreateInfo* pointer)
        {
            pointer->SType = StructureType.PipelineRasterizationStateCreateInfo;
            pointer->Next = null;
            if (this.Flags != null)
            {
                pointer->Flags = this.Flags.Value;
            }
            else
            {
                pointer->Flags = default(SharpVk.PipelineRasterizationStateCreateFlags);
            }
            pointer->DepthClampEnable = this.DepthClampEnable;
            pointer->RasterizerDiscardEnable = this.RasterizerDiscardEnable;
            pointer->PolygonMode = this.PolygonMode;
            if (this.CullMode != null)
            {
                pointer->CullMode = this.CullMode.Value;
            }
            else
            {
                pointer->CullMode = default(SharpVk.CullModeFlags);
            }
            pointer->FrontFace = this.FrontFace;
            pointer->DepthBiasEnable = this.DepthBiasEnable;
            pointer->DepthBiasConstantFactor = this.DepthBiasConstantFactor;
            pointer->DepthBiasClamp = this.DepthBiasClamp;
            pointer->DepthBiasSlopeFactor = this.DepthBiasSlopeFactor;
            pointer->LineWidth = this.LineWidth;
        }
    }
}
