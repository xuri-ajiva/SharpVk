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
    /// Structure specifying an image resolve operation.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct ImageResolve
    {
        /// <summary>
        /// 
        /// </summary>
        public ImageResolve(ImageSubresourceLayers sourceSubresource, Offset3D sourceOffset, ImageSubresourceLayers destinationSubresource, Offset3D destinationOffset, Extent3D extent)
        {
            this.SourceSubresource = sourceSubresource;
            this.SourceOffset = sourceOffset;
            this.DestinationSubresource = destinationSubresource;
            this.DestinationOffset = destinationOffset;
            this.Extent = extent;
        }
        
        /// <summary>
        /// pname:srcSubresource and pname:dstSubresource are
        /// slink:VkImageSubresourceLayers structures specifying the image
        /// subresources of the images used for the source and destination
        /// image data, respectively. Resolve of depth/stencil images is not
        /// supported.
        /// </summary>
        public ImageSubresourceLayers SourceSubresource; 
        
        /// <summary>
        /// pname:srcOffset and pname:dstOffset select the initial x, y, and z
        /// offsets in texels of the sub-regions of the source and destination
        /// image data.
        /// </summary>
        public Offset3D SourceOffset; 
        
        /// <summary>
        /// -
        /// </summary>
        public ImageSubresourceLayers DestinationSubresource; 
        
        /// <summary>
        /// -
        /// </summary>
        public Offset3D DestinationOffset; 
        
        /// <summary>
        /// pname:extent is the size in texels of the source image to resolve
        /// in pname:width, pname:height and pname:depth.
        /// </summary>
        public Extent3D Extent; 
        
        /// <summary>
        /// 
        /// </summary>
        public override string ToString()
        {
            var builder = new StringBuilder();
            builder.AppendLine("ImageResolve");
            builder.AppendLine("{");
            builder.AppendLine($"SourceSubresource: {this.SourceSubresource}");
            builder.AppendLine($"SourceOffset: {this.SourceOffset}");
            builder.AppendLine($"DestinationSubresource: {this.DestinationSubresource}");
            builder.AppendLine($"DestinationOffset: {this.DestinationOffset}");
            builder.AppendLine($"Extent: {this.Extent}");
            builder.Append("}");
            return builder.ToString();
        }
    }
}
