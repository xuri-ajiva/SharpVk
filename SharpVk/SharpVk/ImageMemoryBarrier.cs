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
    /// Structure specifying the parameters of an image memory barrier.
    /// </para>
    /// <para>
    /// If pname:oldLayout differs from pname:newLayout, a layout transition
    /// occurs as part of the image memory barrier, affecting the data
    /// contained in the region of the image defined by the
    /// pname:subresourceRange. If pname:oldLayout is
    /// ename:VK_IMAGE_LAYOUT_UNDEFINED, then the data is undefined after the
    /// layout transition. This may: allow a more efficient transition, since
    /// the data may: be discarded. The layout transition must: occur after all
    /// operations using the old layout are completed and before all operations
    /// using the new layout are started. This is achieved by ensuring that
    /// there is a memory dependency between previous accesses and the layout
    /// transition, as well as between the layout transition and subsequent
    /// accesses, where the layout transition occurs between the two halves of
    /// a memory dependency in an image memory barrier.
    /// </para>
    /// <para>
    /// Layout transitions that are performed via image memory barriers are
    /// automatically ordered against other layout transitions, including those
    /// that occur as part of a render pass instance.
    /// </para>
    /// <para>
    /// [NOTE] .Note ==== See &lt;&lt;resources-image-layouts&gt;&gt; for
    /// details on available image layouts and their usages. ====
    /// </para>
    /// <para>
    /// .Valid Usage **** * pname:oldLayout must: be
    /// ename:VK_IMAGE_LAYOUT_UNDEFINED or the current layout of the image
    /// subresources affected by the barrier * pname:newLayout must: not be
    /// ename:VK_IMAGE_LAYOUT_UNDEFINED or ename:VK_IMAGE_LAYOUT_PREINITIALIZED
    /// * If pname:image was created with a sharing mode of
    /// ename:VK_SHARING_MODE_CONCURRENT, pname:srcQueueFamilyIndex and
    /// pname:dstQueueFamilyIndex must: both be ename:VK_QUEUE_FAMILY_IGNORED *
    /// If pname:image was created with a sharing mode of
    /// ename:VK_SHARING_MODE_EXCLUSIVE, pname:srcQueueFamilyIndex and
    /// pname:dstQueueFamilyIndex must: either both be
    /// ename:VK_QUEUE_FAMILY_IGNORED, or both be a valid queue family (see
    /// &lt;&lt;devsandqueues-queueprops&gt;&gt;) * If pname:image was created
    /// with a sharing mode of ename:VK_SHARING_MODE_EXCLUSIVE, and
    /// pname:srcQueueFamilyIndex and pname:dstQueueFamilyIndex are valid queue
    /// families, at least one of them must: be the same as the family of the
    /// queue that will execute this barrier * pname:subresourceRange must: be
    /// a valid image subresource range for the image (see
    /// &lt;&lt;resources-image-views&gt;&gt;) * If pname:image has a
    /// depth/stencil format with both depth and stencil components, then
    /// pname:aspectMask member of pname:subresourceRange must: include both
    /// ename:VK_IMAGE_ASPECT_DEPTH_BIT and ename:VK_IMAGE_ASPECT_STENCIL_BIT *
    /// If either pname:oldLayout or pname:newLayout is
    /// ename:VK_IMAGE_LAYOUT_COLOR_ATTACHMENT_OPTIMAL then pname:image must:
    /// have been created with ename:VK_IMAGE_USAGE_COLOR_ATTACHMENT_BIT set *
    /// If either pname:oldLayout or pname:newLayout is
    /// ename:VK_IMAGE_LAYOUT_DEPTH_STENCIL_ATTACHMENT_OPTIMAL then pname:image
    /// must: have been created with
    /// ename:VK_IMAGE_USAGE_DEPTH_STENCIL_ATTACHMENT_BIT set * If either
    /// pname:oldLayout or pname:newLayout is
    /// ename:VK_IMAGE_LAYOUT_DEPTH_STENCIL_READ_ONLY_OPTIMAL then pname:image
    /// must: have been created with
    /// ename:VK_IMAGE_USAGE_DEPTH_STENCIL_ATTACHMENT_BIT set * If either
    /// pname:oldLayout or pname:newLayout is
    /// ename:VK_IMAGE_LAYOUT_SHADER_READ_ONLY_OPTIMAL then pname:image must:
    /// have been created with ename:VK_IMAGE_USAGE_SAMPLED_BIT or
    /// ename:VK_IMAGE_USAGE_INPUT_ATTACHMENT_BIT set * If either
    /// pname:oldLayout or pname:newLayout is
    /// ename:VK_IMAGE_LAYOUT_TRANSFER_SRC_OPTIMAL then pname:image must: have
    /// been created with ename:VK_IMAGE_USAGE_TRANSFER_SRC_BIT set * If either
    /// pname:oldLayout or pname:newLayout is
    /// ename:VK_IMAGE_LAYOUT_TRANSFER_DST_OPTIMAL then pname:image must: have
    /// been created with ename:VK_IMAGE_USAGE_TRANSFER_DST_BIT set ****
    /// </para>
    /// </summary>
    public struct ImageMemoryBarrier
    {
        /// <summary>
        /// pname:srcAccessMask is a bitmask of the classes of memory accesses
        /// performed by the first set of commands that will participate in the
        /// dependency.
        /// </summary>
        public AccessFlags SourceAccessMask
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:dstAccessMask is a bitmask of the classes of memory accesses
        /// performed by the second set of commands that will participate in
        /// the dependency.
        /// </summary>
        public AccessFlags DestinationAccessMask
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:oldLayout describes the current layout of the image
        /// subresource(s).
        /// </summary>
        public ImageLayout OldLayout
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:newLayout describes the new layout of the image
        /// subresource(s).
        /// </summary>
        public ImageLayout NewLayout
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:srcQueueFamilyIndex is the queue family that is relinquishing
        /// ownership of the image subresource(s) to another queue, or
        /// ename:VK_QUEUE_FAMILY_IGNORED if there is no transfer of
        /// ownership).
        /// </summary>
        public uint SourceQueueFamilyIndex
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:dstQueueFamilyIndex is the queue family that is acquiring
        /// ownership of the image subresource(s) from another queue, or
        /// ename:VK_QUEUE_FAMILY_IGNORED if there is no transfer of
        /// ownership).
        /// </summary>
        public uint DestinationQueueFamilyIndex
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:image is a handle to the image whose backing memory is
        /// affected by the barrier.
        /// </summary>
        public Image Image
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:subresourceRange describes an area of the backing memory for
        /// pname:image (see &lt;&lt;resources-image-views&gt;&gt; for the
        /// description of sname:VkImageSubresourceRange), as well as the set
        /// of image subresources whose image layouts are modified.
        /// </summary>
        public ImageSubresourceRange SubresourceRange
        {
            get;
            set;
        }
        
        internal unsafe Interop.ImageMemoryBarrier Pack()
        {
            Interop.ImageMemoryBarrier result = default(Interop.ImageMemoryBarrier);
            result.SType = StructureType.ImageMemoryBarrier;
            result.Image = this.Image?.Pack() ?? Interop.Image.Null;
            result.SourceAccessMask = this.SourceAccessMask;
            result.DestinationAccessMask = this.DestinationAccessMask;
            result.OldLayout = this.OldLayout;
            result.NewLayout = this.NewLayout;
            result.SourceQueueFamilyIndex = this.SourceQueueFamilyIndex;
            result.DestinationQueueFamilyIndex = this.DestinationQueueFamilyIndex;
            result.SubresourceRange = this.SubresourceRange;
            return result;
        }
        
        internal unsafe Interop.ImageMemoryBarrier* MarshalTo()
        {
            return (Interop.ImageMemoryBarrier*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
        }
    }
}
