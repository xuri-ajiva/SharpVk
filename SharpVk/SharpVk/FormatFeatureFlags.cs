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
    /// Bitmask specifying features supported by a buffer.
    /// </para>
    /// <para>
    /// The pname:linearTilingFeatures and pname:optimalTilingFeatures members
    /// of the sname:VkFormatProperties structure describe what features are
    /// supported by ename:VK_IMAGE_TILING_LINEAR and
    /// ename:VK_IMAGE_TILING_OPTIMAL images, respectively.
    /// </para>
    /// <para>
    /// The following bits may: be set in pname:linearTilingFeatures and
    /// pname:optimalTilingFeatures, indicating they are supported by images or
    /// image views created with the queried
    /// flink:vkGetPhysicalDeviceFormatProperties::pname:format:
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_FEATURE_SAMPLED_IMAGE_BIT:: sname:VkImageView can: be
    /// sampled from. See &lt;&lt;descriptorsets-sampledimage, sampled
    /// images&gt;&gt; section.
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_FEATURE_STORAGE_IMAGE_BIT:: sname:VkImageView can: be
    /// used as storage image. See &lt;&lt;descriptorsets-storageimage, storage
    /// images&gt;&gt; section.
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_FEATURE_STORAGE_IMAGE_ATOMIC_BIT:: sname:VkImageView
    /// can: be used as storage image that supports atomic operations.
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_FEATURE_COLOR_ATTACHMENT_BIT:: sname:VkImageView can:
    /// be used as a framebuffer color attachment and as an input attachment.
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_FEATURE_COLOR_ATTACHMENT_BLEND_BIT:: sname:VkImageView
    /// can: be used as a framebuffer color attachment that supports blending
    /// and as an input attachment.
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_FEATURE_DEPTH_STENCIL_ATTACHMENT_BIT::
    /// sname:VkImageView can: be used as a framebuffer depth/stencil
    /// attachment and as an input attachment.
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_FEATURE_BLIT_SRC_BIT:: sname:VkImage can: be used as
    /// pname:srcImage for the fname:vkCmdBlitImage command.
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_FEATURE_BLIT_DST_BIT:: sname:VkImage can: be used as
    /// pname:dstImage for the fname:vkCmdBlitImage command.
    /// </para>
    /// </summary>
    [Flags]
    public enum FormatFeatureFlags
    {
        /// <summary>
        /// -
        /// </summary>
        None = 0, 
        
        /// <summary>
        /// Format can be used for sampled images (SAMPLED_IMAGE and
        /// COMBINED_IMAGE_SAMPLER descriptor types)
        /// </summary>
        SampledImage = 1 << 0, 
        
        /// <summary>
        /// Format can be used for storage images (STORAGE_IMAGE descriptor
        /// type)
        /// </summary>
        StorageImage = 1 << 1, 
        
        /// <summary>
        /// Format supports atomic operations in case it is used for storage
        /// images
        /// </summary>
        StorageImageAtomic = 1 << 2, 
        
        /// <summary>
        /// Format can be used for uniform texel buffers (TBOs)
        /// </summary>
        UniformTexelBuffer = 1 << 3, 
        
        /// <summary>
        /// Format can be used for storage texel buffers (IBOs)
        /// </summary>
        StorageTexelBuffer = 1 << 4, 
        
        /// <summary>
        /// Format supports atomic operations in case it is used for storage
        /// texel buffers
        /// </summary>
        StorageTexelBufferAtomic = 1 << 5, 
        
        /// <summary>
        /// Format can be used for vertex buffers (VBOs)
        /// </summary>
        VertexBuffer = 1 << 6, 
        
        /// <summary>
        /// Format can be used for color attachment images
        /// </summary>
        ColorAttachment = 1 << 7, 
        
        /// <summary>
        /// Format supports blending in case it is used for color attachment
        /// images
        /// </summary>
        ColorAttachmentBlend = 1 << 8, 
        
        /// <summary>
        /// Format can be used for depth/stencil attachment images
        /// </summary>
        DepthStencilAttachment = 1 << 9, 
        
        /// <summary>
        /// Format can be used as the source image of blits with vkCmdBlitImage
        /// </summary>
        BlitSource = 1 << 10, 
        
        /// <summary>
        /// Format can be used as the destination image of blits with
        /// vkCmdBlitImage
        /// </summary>
        BlitDestination = 1 << 11, 
        
        /// <summary>
        /// Format can be filtered with VK_FILTER_LINEAR when being sampled
        /// </summary>
        SampledImageFilterLinear = 1 << 12, 
        
        /// <summary>
        /// -
        /// </summary>
        SampledImageFilterCubicBitImg = 13, 
    }
}
