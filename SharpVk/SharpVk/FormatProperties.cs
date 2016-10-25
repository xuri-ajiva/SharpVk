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
    /// Structure specifying image format properties.
    /// </para>
    /// <para>
    /// Supported features are described as a set of
    /// elink:VkFormatFeatureFlagBits:
    /// </para>
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct FormatProperties
    {
        /// <summary>
        /// pname:linearTilingFeatures describes the features supported by
        /// ename:VK_IMAGE_TILING_LINEAR.
        /// </summary>
        public FormatFeatureFlags LinearTilingFeatures; 
        
        /// <summary>
        /// pname:optimalTilingFeatures describes the features supported by
        /// ename:VK_IMAGE_TILING_OPTIMAL.
        /// </summary>
        public FormatFeatureFlags OptimalTilingFeatures; 
        
        /// <summary>
        /// pname:bufferFeatures describes the features supported by buffers.
        /// </summary>
        public FormatFeatureFlags BufferFeatures; 
        
        /// <summary>
        /// 
        /// </summary>
        public override string ToString()
        {
            var builder = new StringBuilder();
            builder.AppendLine("FormatProperties");
            builder.AppendLine("{");
            builder.AppendLine($"LinearTilingFeatures: {this.LinearTilingFeatures}");
            builder.AppendLine($"OptimalTilingFeatures: {this.OptimalTilingFeatures}");
            builder.AppendLine($"BufferFeatures: {this.BufferFeatures}");
            builder.Append("}");
            return builder.ToString();
        }
    }
}
