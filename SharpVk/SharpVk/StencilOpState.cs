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
    /// Structure specifying stencil operation state.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct StencilOpState
    {
        /// <summary>
        /// 
        /// </summary>
        public StencilOpState(StencilOp failOp, StencilOp passOp, StencilOp depthFailOp, CompareOp compareOp, uint compareMask, uint writeMask, uint reference)
        {
            this.FailOp = failOp;
            this.PassOp = passOp;
            this.DepthFailOp = depthFailOp;
            this.CompareOp = compareOp;
            this.CompareMask = compareMask;
            this.WriteMask = writeMask;
            this.Reference = reference;
        }
        
        /// <summary>
        /// pname:failOp is the action performed on samples that fail the
        /// stencil test.
        /// </summary>
        public StencilOp FailOp; 
        
        /// <summary>
        /// pname:passOp is the action performed on samples that pass both the
        /// depth and stencil tests.
        /// </summary>
        public StencilOp PassOp; 
        
        /// <summary>
        /// pname:depthFailOp is the action performed on samples that pass the
        /// stencil test and fail the depth test.
        /// </summary>
        public StencilOp DepthFailOp; 
        
        /// <summary>
        /// pname:compareOp is the comparison operator used in the stencil
        /// test.
        /// </summary>
        public CompareOp CompareOp; 
        
        /// <summary>
        /// pname:compareMask selects the bits of the unsigned integer stencil
        /// values participating in the stencil test.
        /// </summary>
        public uint CompareMask; 
        
        /// <summary>
        /// pname:writeMask selects the bits of the unsigned integer stencil
        /// values updated by the stencil test in the stencil framebuffer
        /// attachment.
        /// </summary>
        public uint WriteMask; 
        
        /// <summary>
        /// pname:reference is an integer reference value that is used in the
        /// unsigned stencil comparison.
        /// </summary>
        public uint Reference; 
        
        /// <summary>
        /// 
        /// </summary>
        public override string ToString()
        {
            var builder = new StringBuilder();
            builder.AppendLine("StencilOpState");
            builder.AppendLine("{");
            builder.AppendLine($"FailOp: {this.FailOp}");
            builder.AppendLine($"PassOp: {this.PassOp}");
            builder.AppendLine($"DepthFailOp: {this.DepthFailOp}");
            builder.AppendLine($"CompareOp: {this.CompareOp}");
            builder.AppendLine($"CompareMask: {this.CompareMask}");
            builder.AppendLine($"WriteMask: {this.WriteMask}");
            builder.AppendLine($"Reference: {this.Reference}");
            builder.Append("}");
            return builder.ToString();
        }
    }
}
