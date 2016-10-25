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
    /// Structure specifying a image subresource range.
    /// </para>
    /// <para>
    /// The number of mipmap levels and array layers must: be a subset of the
    /// image subresources in the image. If an application wants to use all mip
    /// levels or layers in an image after the pname:baseMipLevel or
    /// pname:baseArrayLayer, it can: set pname:levelCount and pname:layerCount
    /// to the special values ename:VK_REMAINING_MIP_LEVELS and
    /// ename:VK_REMAINING_ARRAY_LAYERS without knowing the exact number of mip
    /// levels or layers.
    /// </para>
    /// <para>
    /// For cube and cube array image views, the layers of the image view
    /// starting at pname:baseArrayLayer correspond to faces in the order +X,
    /// -X, +Y, -Y, +Z, -Z. For cube arrays, each set of six sequential layers
    /// is a single cube, so the number of cube maps in a cube map array view
    /// is _pname:layerCount / 6_, and image array layer _pname:baseArrayLayer
    /// + i_ is face index _i mod 6_ of cube _i / 6_. If the number of layers
    /// in the view, whether set explicitly in pname:layerCount or implied by
    /// ename:VK_REMAINING_ARRAY_LAYERS, is not a multiple of 6, behavior when
    /// indexing the last cube is undefined.
    /// </para>
    /// <para>
    /// pname:aspectMask is a bitmask indicating the format being used. Bits
    /// which may: be set include:
    /// </para>
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct ImageSubresourceRange
    {
        /// <summary>
        /// pname:aspectMask is a bitmask indicating which aspect(s) of the
        /// image are included in the view. See elink:VkImageAspectFlagBits.
        /// </summary>
        public ImageAspectFlags AspectMask; 
        
        /// <summary>
        /// pname:baseMipLevel is the first mipmap level accessible to the
        /// view.
        /// </summary>
        public uint BaseMipLevel; 
        
        /// <summary>
        /// pname:levelCount is the number of mipmap levels (starting from
        /// pname:baseMipLevel) accessible to the view.
        /// </summary>
        public uint LevelCount; 
        
        /// <summary>
        /// pname:baseArrayLayer is the first array layer accessible to the
        /// view.
        /// </summary>
        public uint BaseArrayLayer; 
        
        /// <summary>
        /// pname:layerCount is the number of array layers (starting from
        /// pname:baseArrayLayer) accessible to the view.
        /// </summary>
        public uint LayerCount; 
        
        /// <summary>
        /// 
        /// </summary>
        public override string ToString()
        {
            var builder = new StringBuilder();
            builder.AppendLine("ImageSubresourceRange");
            builder.AppendLine("{");
            builder.AppendLine($"AspectMask: {this.AspectMask}");
            builder.AppendLine($"BaseMipLevel: {this.BaseMipLevel}");
            builder.AppendLine($"LevelCount: {this.LevelCount}");
            builder.AppendLine($"BaseArrayLayer: {this.BaseArrayLayer}");
            builder.AppendLine($"LayerCount: {this.LayerCount}");
            builder.Append("}");
            return builder.ToString();
        }
    }
}
