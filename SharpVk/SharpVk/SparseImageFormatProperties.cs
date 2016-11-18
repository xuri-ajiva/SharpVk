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
    /// Structure specifying sparse image format properties.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct SparseImageFormatProperties
    {
        /// <summary>
        /// 
        /// </summary>
        public SparseImageFormatProperties(ImageAspectFlags aspectMask, Extent3D imageGranularity, SparseImageFormatFlags flags)
        {
            this.AspectMask = aspectMask;
            this.ImageGranularity = imageGranularity;
            this.Flags = flags;
        }
        
        /// <summary>
        /// pname:aspectMask is a bitmask of elink:VkImageAspectFlagBits
        /// specifying which aspects of the image the properties apply to.
        /// </summary>
        public ImageAspectFlags AspectMask; 
        
        /// <summary>
        /// pname:imageGranularity is the width, height, and depth of the
        /// sparse image block in texels or compressed texel blocks.
        /// </summary>
        public Extent3D ImageGranularity; 
        
        /// <summary>
        /// pname:flags is a bitmask specifying additional information about
        /// the sparse resource. Bits which can: be set include: + --
        /// </summary>
        public SparseImageFormatFlags Flags; 
        
        /// <summary>
        /// 
        /// </summary>
        public override string ToString()
        {
            var builder = new StringBuilder();
            builder.AppendLine("SparseImageFormatProperties");
            builder.AppendLine("{");
            builder.AppendLine($"AspectMask: {this.AspectMask}");
            builder.AppendLine($"ImageGranularity: {this.ImageGranularity}");
            builder.AppendLine($"Flags: {this.Flags}");
            builder.Append("}");
            return builder.ToString();
        }
    }
}
