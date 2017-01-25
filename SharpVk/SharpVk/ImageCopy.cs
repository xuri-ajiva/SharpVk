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
using System.Text;

namespace SharpVk
{
    /// <summary>
    /// <para>
    /// Structure specifying an image copy operation.
    /// </para>
    /// <para>
    /// ifdef::VK_KHR_maintenance1[] For ename:VK_IMAGE_TYPE_3D images, copies
    /// are performed slice by slice starting with the pname:z member of the
    /// pname:srcOffset or pname:dstOffset, and copying pname:depth slices. For
    /// images with multiple layers, copies are performed layer by layer
    /// starting with the pname:baseArrayLayer member of the
    /// pname:srcSubresource or pname:dstSubresource and copying
    /// pname:layerCount layers. Image data can: be copied between images with
    /// different image types. If one image is ename:VK_IMAGE_TYPE_3D and the
    /// other image is ename:VK_IMAGE_TYPE_2D with multiple layers, then each
    /// slice is copied to or from a different layer.
    /// endif::VK_KHR_maintenance1[] ifndef::VK_KHR_maintenance1[] Copies are
    /// done layer by layer starting with pname:baseArrayLayer member of
    /// pname:srcSubresource for the source and pname:dstSubresource for the
    /// destination. pname:layerCount layers are copied to the destination
    /// image. endif::VK_KHR_maintenance1[]
    /// </para>
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct ImageCopy
    {
        /// <summary>
        /// 
        /// </summary>
        public ImageCopy(ImageSubresourceLayers sourceSubresource, Offset3D sourceOffset, ImageSubresourceLayers destinationSubresource, Offset3D destinationOffset, Extent3D extent)
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
        /// image data, respectively.
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
        /// pname:extent is the size in texels of the source image to copy in
        /// pname:width, pname:height and pname:depth.
        /// </summary>
        public Extent3D Extent; 
        
        /// <summary>
        /// 
        /// </summary>
        public override string ToString()
        {
            var builder = new StringBuilder();
            builder.AppendLine("ImageCopy");
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
