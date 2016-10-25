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
    /// Structure specifying subresource layout.
    /// </para>
    /// <para>
    /// For images created with linear tiling, pname:rowPitch, pname:arrayPitch
    /// and pname:depthPitch describe the layout of the image subresource in
    /// linear memory. For uncompressed formats, pname:rowPitch is the number
    /// of bytes between texels with the same x coordinate in adjacent rows (y
    /// coordinates differ by one). pname:arrayPitch is the number of bytes
    /// between texels with the same x and y coordinate in adjacent array
    /// layers of the image (array layer values differ by one).
    /// pname:depthPitch is the number of bytes between texels with the same x
    /// and y coordinate in adjacent slices of a 3D image (z coordinates differ
    /// by one). Expressed as an addressing formula, the starting byte of a
    /// texel in the image subresource has address:
    /// </para>
    /// <para>
    /// [source,c] --------------------------------------------------- //
    /// (x,y,z,layer) are in texel coordinates address(x,y,z,layer) =
    /// layer*arrayPitch + z*depthPitch + y*rowPitch + x*elementSize + offset
    /// ---------------------------------------------------
    /// </para>
    /// <para>
    /// For compressed formats, the pname:rowPitch is the number of bytes
    /// between compressed texel blocks in adjacent rows. pname:arrayPitch is
    /// the number of bytes between compressed texel blocks in adjacent array
    /// layers. pname:depthPitch is the number of bytes between compressed
    /// texel blocks in adjacent slices of a 3D image.
    /// </para>
    /// <para>
    /// [source,c] --------------------------------------------------- //
    /// (x,y,z,layer) are in compressed texel block coordinates
    /// address(x,y,z,layer) = layer*arrayPitch + z*depthPitch + y*rowPitch +
    /// x*compressedTexelBlockByteSize + offset;
    /// ---------------------------------------------------
    /// </para>
    /// <para>
    /// pname:arrayPitch is undefined for images that were not created as
    /// arrays. pname:depthPitch is defined only for 3D images.
    /// </para>
    /// <para>
    /// For color formats, the pname:aspectMask member of
    /// sname:VkImageSubresource must: be ename:VK_IMAGE_ASPECT_COLOR_BIT. For
    /// depth/stencil formats, pname:aspectMask must: be either
    /// ename:VK_IMAGE_ASPECT_DEPTH_BIT or ename:VK_IMAGE_ASPECT_STENCIL_BIT.
    /// On implementations that store depth and stencil aspects separately,
    /// querying each of these image subresource layouts will return a
    /// different pname:offset and pname:size representing the region of memory
    /// used for that aspect. On implementations that store depth and stencil
    /// aspects interleaved, the same pname:offset and pname:size are returned
    /// and represent the interleaved memory allocation.
    /// </para>
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct SubresourceLayout
    {
        /// <summary>
        /// pname:offset is the byte offset from the start of the image where
        /// the image subresource begins.
        /// </summary>
        public DeviceSize Offset; 
        
        /// <summary>
        /// pname:size is the size in bytes of the image subresource.
        /// pname:size includes any extra memory that is required based on
        /// pname:rowPitch.
        /// </summary>
        public DeviceSize Size; 
        
        /// <summary>
        /// pname:rowPitch describes the number of bytes between each row of
        /// texels in an image.
        /// </summary>
        public DeviceSize RowPitch; 
        
        /// <summary>
        /// pname:arrayPitch describes the number of bytes between each array
        /// layer of an image.
        /// </summary>
        public DeviceSize ArrayPitch; 
        
        /// <summary>
        /// pname:depthPitch describes the number of bytes between each slice
        /// of 3D image.
        /// </summary>
        public DeviceSize DepthPitch; 
        
        /// <summary>
        /// 
        /// </summary>
        public override string ToString()
        {
            var builder = new StringBuilder();
            builder.AppendLine("SubresourceLayout");
            builder.AppendLine("{");
            builder.AppendLine($"Offset: {this.Offset}");
            builder.AppendLine($"Size: {this.Size}");
            builder.AppendLine($"RowPitch: {this.RowPitch}");
            builder.AppendLine($"ArrayPitch: {this.ArrayPitch}");
            builder.AppendLine($"DepthPitch: {this.DepthPitch}");
            builder.Append("}");
            return builder.ToString();
        }
    }
}
