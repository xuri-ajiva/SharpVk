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
    /// Bitmask specifying intended usage of an image.
    /// </summary>
    [Flags]
    public enum ImageUsageFlags
    {
        /// <summary>
        /// -
        /// </summary>
        None = 0, 
        
        /// <summary>
        /// ename:VK_IMAGE_USAGE_TRANSFER_SRC_BIT indicates that the image can:
        /// be used as the source of a transfer command.
        /// </summary>
        TransferSource = 1 << 0, 
        
        /// <summary>
        /// ename:VK_IMAGE_USAGE_TRANSFER_DST_BIT indicates that the image can:
        /// be used as the destination of a transfer command.
        /// </summary>
        TransferDestination = 1 << 1, 
        
        /// <summary>
        /// ename:VK_IMAGE_USAGE_SAMPLED_BIT indicates that the image can: be
        /// used to create a sname:VkImageView suitable for occupying a
        /// sname:VkDescriptorSet slot either of type
        /// ename:VK_DESCRIPTOR_TYPE_SAMPLED_IMAGE or
        /// ename:VK_DESCRIPTOR_TYPE_COMBINED_IMAGE_SAMPLER, and be sampled by
        /// a shader.
        /// </summary>
        Sampled = 1 << 2, 
        
        /// <summary>
        /// ename:VK_IMAGE_USAGE_STORAGE_BIT indicates that the image can: be
        /// used to create a sname:VkImageView suitable for occupying a
        /// sname:VkDescriptorSet slot of type
        /// ename:VK_DESCRIPTOR_TYPE_STORAGE_IMAGE.
        /// </summary>
        Storage = 1 << 3, 
        
        /// <summary>
        /// ename:VK_IMAGE_USAGE_COLOR_ATTACHMENT_BIT indicates that the image
        /// can: be used to create a sname:VkImageView suitable for use as a
        /// color or resolve attachment in a sname:VkFramebuffer.
        /// </summary>
        ColorAttachment = 1 << 4, 
        
        /// <summary>
        /// ename:VK_IMAGE_USAGE_DEPTH_STENCIL_ATTACHMENT_BIT indicates that
        /// the image can: be used to create a sname:VkImageView suitable for
        /// use as a depth/stencil attachment in a sname:VkFramebuffer.
        /// </summary>
        DepthStencilAttachment = 1 << 5, 
        
        /// <summary>
        /// ename:VK_IMAGE_USAGE_TRANSIENT_ATTACHMENT_BIT indicates that the
        /// memory bound to this image will have been allocated with the
        /// ename:VK_MEMORY_PROPERTY_LAZILY_ALLOCATED_BIT (see
        /// &lt;&lt;memory&gt;&gt; for more detail). This bit can: be set for
        /// any image that can: be used to create a sname:VkImageView suitable
        /// for use as a color, resolve, depth/stencil, or input attachment.
        /// </summary>
        TransientAttachment = 1 << 6, 
        
        /// <summary>
        /// ename:VK_IMAGE_USAGE_INPUT_ATTACHMENT_BIT indicates that the image
        /// can: be used to create a sname:VkImageView suitable for occupying
        /// sname:VkDescriptorSet slot of type
        /// ename:VK_DESCRIPTOR_TYPE_INPUT_ATTACHMENT; be read from a shader as
        /// an input attachment; and be used as an input attachment in a
        /// framebuffer.
        /// </summary>
        InputAttachment = 1 << 7, 
    }
}
