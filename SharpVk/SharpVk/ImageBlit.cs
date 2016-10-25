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

namespace SharpVk
{
    /// <summary>
    /// <para>
    /// Structure specifying an image blit operation.
    /// </para>
    /// <para>
    /// For each element of the pname:pRegions array, a blit operation is
    /// performed the specified source and destination regions.
    /// </para>
    /// <para>
    /// .Valid Usage **** * The pname:aspectMask member of pname:srcSubresource
    /// and pname:dstSubresource must: match * The pname:layerCount member of
    /// pname:srcSubresource and pname:dstSubresource must: match * If either
    /// of the calling command's pname:srcImage or pname:dstImage parameters
    /// are of elink:VkImageType ename:VK_IMAGE_TYPE_3D, the
    /// pname:baseArrayLayer and pname:layerCount members of both
    /// pname:srcSubresource and pname:dstSubresource must: be `0` and `1`,
    /// respectively * The pname:aspectMask member of pname:srcSubresource
    /// must: specify aspects present in the calling command's pname:srcImage *
    /// The pname:aspectMask member of pname:dstSubresource must: specify
    /// aspects present in the calling command's pname:dstImage * The
    /// pname:layerCount member of pname:dstSubresource must: be equal to the
    /// pname:layerCount member of pname:srcSubresource *
    /// pname:srcOffset[0].pname:x and pname:srcOffset[1].pname:x must: both be
    /// greater than or equal to `0` and less than or equal to the source image
    /// subresource width * pname:srcOffset[0].pname:y and
    /// pname:srcOffset[1].pname:y must: both be greater than or equal to `0`
    /// and less than or equal to the source image subresource height ** If the
    /// calling command's pname:srcImage is of type ename:VK_IMAGE_TYPE_1D,
    /// then pname:srcOffset[0].y must: be `0` and pname:srcOffset[1].y must:
    /// be `1`. * pname:srcOffset[0].pname:z and pname:srcOffset[1].pname:z
    /// must: both be greater than or equal to `0` and less than or equal to
    /// the source image subresource depth ** If the calling command's
    /// pname:srcImage is of type ename:VK_IMAGE_TYPE_1D or
    /// ename:VK_IMAGE_TYPE_2D, then pname:srcOffset[0].z must: be `0` and
    /// pname:srcOffset[1].z must: be `1`. * pname:dstOffset[0].pname:x and
    /// pname:dstOffset[1].pname:x must: both be greater than or equal to `0`
    /// and less than or equal to the destination image subresource width *
    /// pname:dstOffset[0].pname:y and pname:dstOffset[1].pname:y must: both be
    /// greater than or equal to `0` and less than or equal to the destination
    /// image subresource height ** If the calling command's pname:dstImage is
    /// of type ename:VK_IMAGE_TYPE_1D, then pname:dstOffset[0].y must: be `0`
    /// and pname:dstOffset[1].y must: be `1`. * pname:dstOffset[0].pname:z and
    /// pname:dstOffset[1].pname:z must: both be greater than or equal to `0`
    /// and less than or equal to the destination image subresource depth ** If
    /// the calling command's pname:dstImage is of type ename:VK_IMAGE_TYPE_1D
    /// or ename:VK_IMAGE_TYPE_2D, then pname:dstOffset[0].z must: be `0` and
    /// pname:dstOffset[1].z must: be `1`. ****
    /// </para>
    /// </summary>
    public struct ImageBlit
    {
        /// <summary>
        /// pname:srcSubresource is the subresource to blit from.
        /// </summary>
        public ImageSubresourceLayers SourceSubresource
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:srcOffsets is an array of two slink:VkOffset3D structures
        /// specifying the bounds of the source region within
        /// pname:srcSubresource.
        /// </summary>
        public Offset3D[] SourceOffsets
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:dstSubresource is the subresource to blit into.
        /// </summary>
        public ImageSubresourceLayers DestinationSubresource
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:dstOffsets is an array of two slink:VkOffset3D structures
        /// specifying the bounds of the destination region within
        /// pname:dstSubresource.
        /// </summary>
        public Offset3D[] DestinationOffsets
        {
            get;
            set;
        }
        
        internal unsafe Interop.ImageBlit Pack()
        {
            Interop.ImageBlit result = default(Interop.ImageBlit);
            Validate.CheckLength(this.SourceOffsets, 2, "SourceOffsets");
            MemUtil.WriteToPtr((IntPtr)(&result.SourceOffsets), this.SourceOffsets, 0, 2);
            Validate.CheckLength(this.DestinationOffsets, 2, "DestinationOffsets");
            MemUtil.WriteToPtr((IntPtr)(&result.DestinationOffsets), this.DestinationOffsets, 0, 2);
            result.SourceSubresource = this.SourceSubresource;
            result.DestinationSubresource = this.DestinationSubresource;
            return result;
        }
        
        internal unsafe Interop.ImageBlit* MarshalTo()
        {
            return (Interop.ImageBlit*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
        }
    }
}
