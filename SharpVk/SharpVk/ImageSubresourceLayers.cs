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
    /// Structure specifying a image subresource layers.
    /// </para>
    /// <para>
    /// .Valid Usage **** * If pname:aspectMask contains
    /// ename:VK_IMAGE_ASPECT_COLOR_BIT, it must: not contain either of
    /// ename:VK_IMAGE_ASPECT_DEPTH_BIT or ename:VK_IMAGE_ASPECT_STENCIL_BIT *
    /// pname:aspectMask must: not contain ename:VK_IMAGE_ASPECT_METADATA_BIT *
    /// pname:mipLevel must: be less than the pname:mipLevels specified in
    /// slink:VkImageCreateInfo when the image was created *
    /// [eq]#(pname:baseArrayLayer + pname:layerCount)# must: be less than or
    /// equal to the pname:arrayLayers specified in slink:VkImageCreateInfo
    /// when the image was created ****
    /// </para>
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct ImageSubresourceLayers
    {
        /// <summary>
        /// pname:aspectMask is a combination of elink:VkImageAspectFlagBits,
        /// selecting the color, depth and/or stencil aspects to be copied.
        /// </summary>
        public ImageAspectFlags AspectMask; 
        
        /// <summary>
        /// pname:mipLevel is the mipmap level to copy from.
        /// </summary>
        public uint MipLevel; 
        
        /// <summary>
        /// pname:baseArrayLayer and pname:layerCount are the starting layer
        /// and number of layers to copy.
        /// </summary>
        public uint BaseArrayLayer; 
        
        /// <summary>
        /// -
        /// </summary>
        public uint LayerCount; 
        
        /// <summary>
        /// 
        /// </summary>
        public override string ToString()
        {
            var builder = new StringBuilder();
            builder.AppendLine("ImageSubresourceLayers");
            builder.AppendLine("{");
            builder.AppendLine($"AspectMask: {this.AspectMask}");
            builder.AppendLine($"MipLevel: {this.MipLevel}");
            builder.AppendLine($"BaseArrayLayer: {this.BaseArrayLayer}");
            builder.AppendLine($"LayerCount: {this.LayerCount}");
            builder.Append("}");
            return builder.ToString();
        }
    }
}
