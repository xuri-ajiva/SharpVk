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
    /// Structure specifying a buffer image copy operation.
    /// </para>
    /// <para>
    /// When copying to or from a depth or stencil aspect, the data in buffer
    /// memory uses a layout that is a (mostly) tightly packed representation
    /// of the depth or stencil data. Specifically:
    /// </para>
    /// <para>
    /// * data copied to or from the stencil aspect of any depth/stencil format
    /// is tightly packed with one ename:VK_FORMAT_S8_UINT value per texel. *
    /// data copied to or from the depth aspect of a ename:VK_FORMAT_D16_UNORM
    /// or ename:VK_FORMAT_D16_UNORM_S8_UINT format is tightly packed with one
    /// ename:VK_FORMAT_D16_UNORM value per texel. * data copied to or from the
    /// depth aspect of a ename:VK_FORMAT_D32_SFLOAT or
    /// ename:VK_FORMAT_D32_SFLOAT_S8_UINT format is tightly packed with one
    /// ename:VK_FORMAT_D32_SFLOAT value per texel. * data copied to or from
    /// the depth aspect of a ename:VK_FORMAT_X8_D24_UNORM_PACK32 or
    /// ename:VK_FORMAT_D24_UNORM_S8_UINT format is packed with one 32-bit word
    /// per texel with the D24 value in the LSBs of the word, and undefined
    /// values in the eight MSBs.
    /// </para>
    /// <para>
    /// [NOTE] .Note ==== To copy both the depth and stencil aspects of a
    /// depth/stencil format, two entries in pname:pRegions can: be used, where
    /// one specifies the depth aspect in pname:imageSubresource, and the other
    /// specifies the stencil aspect. ====
    /// </para>
    /// <para>
    /// Because depth or stencil aspect buffer to image copies may: require
    /// format conversions on some implementations, they are not supported on
    /// queues that do not support graphics. When copying to a depth aspect,
    /// the data in buffer memory must: be in the the range [eq]#[0,1]# or
    /// undefined results occur.
    /// </para>
    /// <para>
    /// Copies are done layer by layer starting with image layer
    /// pname:baseArrayLayer member of pname:imageSubresource. pname:layerCount
    /// layers are copied from the source image or to the destination image.
    /// </para>
    /// <para>
    /// .Valid Usage **** * pname:bufferOffset must: be a multiple of the
    /// calling command's sname:VkImage parameter's format's element size *
    /// pname:bufferOffset must: be a multiple of `4` * pname:bufferRowLength
    /// must: be `0`, or greater than or equal to the pname:width member of
    /// pname:imageExtent * pname:bufferImageHeight must: be `0`, or greater
    /// than or equal to the pname:height member of pname:imageExtent *
    /// pname:imageOffset.x and (pname:imageExtent.width + pname:imageOffset.x)
    /// must: both be greater than or equal to `0` and less than or equal to
    /// the image subresource width * pname:imageOffset.y and
    /// (imageExtent.height + pname:imageOffset.y) must: both be greater than
    /// or equal to `0` and less than or equal to the image subresource height
    /// ** If the calling command's pname:srcImage
    /// (flink:vkCmdCopyImageToBuffer) or pname:dstImage
    /// (flink:vkCmdCopyBufferToImage) is of type ename:VK_IMAGE_TYPE_1D, then
    /// pname:imageOffset.y must: be `0` and pname:imageExtent.height must: be
    /// `1`. * pname:imageOffset.z and (imageExtent.depth +
    /// pname:imageOffset.z) must: both be greater than or equal to `0` and
    /// less than or equal to the image subresource depth ** If the calling
    /// command's pname:srcImage (flink:vkCmdCopyImageToBuffer) or
    /// pname:dstImage (flink:vkCmdCopyBufferToImage) is of type
    /// ename:VK_IMAGE_TYPE_1D or ename:VK_IMAGE_TYPE_2D, then
    /// pname:imageOffset.z must: be `0` and pname:imageExtent.depth must: be
    /// `1`. * If the calling command's sname:VkImage parameter is a compressed
    /// format image: ** pname:bufferRowLength must: be a multiple of the
    /// compressed texel block width ** pname:bufferImageHeight must: be a
    /// multiple of the compressed texel block height ** all members of
    /// pname:imageOffset must: be a multiple of the corresponding dimensions
    /// of the compressed texel block ** pname:bufferOffset must: be a multiple
    /// of the compressed texel block size in bytes ** pname:imageExtent.width
    /// must: be a multiple of the compressed texel block width or
    /// (pname:imageExtent.width + pname:imageOffset.x) must: equal the image
    /// subresource width ** pname:imageExtent.height must: be a multiple of
    /// the compressed texel block height or (pname:imageExtent.height +
    /// pname:imageOffset.y) must: equal the image subresource height **
    /// pname:imageExtent.depth must: be a multiple of the compressed texel
    /// block depth or (pname:imageExtent.depth + pname:imageOffset.z) must:
    /// equal the image subresource depth * pname:bufferOffset,
    /// pname:bufferRowLength, pname:bufferImageHeight and all members of
    /// pname:imageOffset and pname:imageExtent must: respect the image
    /// transfer granularity requirements of the queue family that it will be
    /// submitted against, as described in
    /// &lt;&lt;devsandqueues-physical-device-enumeration,Physical Device
    /// Enumeration&gt;&gt; * The pname:aspectMask member of
    /// pname:imageSubresource must: specify aspects present in the calling
    /// command's sname:VkImage parameter * The pname:aspectMask member of
    /// pname:imageSubresource must: only have a single bit set * If the
    /// calling command's sname:VkImage parameter is of elink:VkImageType
    /// ename:VK_IMAGE_TYPE_3D, the pname:baseArrayLayer and pname:layerCount
    /// members of pname:imageSubresource must: be `0` and `1`, respectively *
    /// When copying to the depth aspect of an image subresource, the data in
    /// the source buffer must: be in the range [eq]#[0,1]# ****
    /// </para>
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct BufferImageCopy
    {
        /// <summary>
        /// pname:bufferOffset is the offset in bytes from the start of the
        /// buffer object where the image data is copied from or to.
        /// </summary>
        public DeviceSize BufferOffset; 
        
        /// <summary>
        /// pname:bufferRowLength and pname:bufferImageHeight specify the data
        /// in buffer memory as a subregion of a larger two- or
        /// three-dimensional image, and control the addressing calculations of
        /// data in buffer memory. If either of these values is zero, that
        /// aspect of the buffer memory is considered to be tightly packed
        /// according to the pname:imageExtent.
        /// </summary>
        public uint BufferRowLength; 
        
        /// <summary>
        /// -
        /// </summary>
        public uint BufferImageHeight; 
        
        /// <summary>
        /// pname:imageSubresource is a slink:VkImageSubresourceLayers used to
        /// specify the specific image subresources of the image used for the
        /// source or destination image data.
        /// </summary>
        public ImageSubresourceLayers ImageSubresource; 
        
        /// <summary>
        /// pname:imageOffset selects the initial x, y, z offsets in texels of
        /// the sub-region of the source or destination image data.
        /// </summary>
        public Offset3D ImageOffset; 
        
        /// <summary>
        /// pname:imageExtent is the size in texels of the image to copy in
        /// pname:width, pname:height and pname:depth.
        /// </summary>
        public Extent3D ImageExtent; 
        
        /// <summary>
        /// 
        /// </summary>
        public override string ToString()
        {
            var builder = new StringBuilder();
            builder.AppendLine("BufferImageCopy");
            builder.AppendLine("{");
            builder.AppendLine($"BufferOffset: {this.BufferOffset}");
            builder.AppendLine($"BufferRowLength: {this.BufferRowLength}");
            builder.AppendLine($"BufferImageHeight: {this.BufferImageHeight}");
            builder.AppendLine($"ImageSubresource: {this.ImageSubresource}");
            builder.AppendLine($"ImageOffset: {this.ImageOffset}");
            builder.AppendLine($"ImageExtent: {this.ImageExtent}");
            builder.Append("}");
            return builder.ToString();
        }
    }
}
