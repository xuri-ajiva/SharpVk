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
    /// <para>
    /// ename:VK_FORMAT_FEATURE_SAMPLED_IMAGE_FILTER_LINEAR_BIT:: If
    /// ename:VK_FORMAT_FEATURE_SAMPLED_IMAGE_BIT is also set,
    /// sname:VkImageView can: be used with a sampler that has either of
    /// pname:magFilter or pname:minFilter set to ename:VK_FILTER_LINEAR, or
    /// pname:mipmapMode set to ename:VK_SAMPLER_MIPMAP_MODE_LINEAR. If
    /// ename:VK_FORMAT_FEATURE_BLIT_SRC_BIT is also set, sname:VkImage can be
    /// used as the pname:srcImage to flink:vkCmdBlitImage with a pname:filter
    /// of ename:VK_FILTER_LINEAR. This bit must: only be exposed for formats
    /// that also support the ename:VK_FORMAT_FEATURE_SAMPLED_IMAGE_BIT or
    /// ename:VK_FORMAT_FEATURE_BLIT_SRC_BIT. + If the format being queried is
    /// a depth/stencil format, this bit only indicates that the depth aspect
    /// (not the stencil aspect) of an image of this format supports linear
    /// filtering, and that linear filtering of the depth aspect is supported
    /// whether depth compare is enabled in the sampler or not. If this bit is
    /// not present, linear filtering with depth compare disabled is
    /// unsupported and linear filtering with depth compare enabled is
    /// supported, but may: compute the filtered value in an
    /// implementation-dependent manner which differs from the normal rules of
    /// linear filtering. The resulting value must: be in the range [eq]#[0,1]#
    /// and should: be proportional to, or a weighted average of, the number of
    /// comparison passes or failures.
    /// </para>
    /// <para>
    /// ifdef::VK_IMG_filter_cubic[]
    /// include::VK_IMG_filter_cubic/filter_cubic_sampled_bit_description.txt[] endif::VK_IMG_filter_cubic[]
    /// </para>
    /// <para>
    /// The following features may: appear in pname:bufferFeatures, indicating
    /// they are supported by buffers or buffer views created with the queried
    /// flink:vkGetPhysicalDeviceFormatProperties::pname:format:
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_FEATURE_UNIFORM_TEXEL_BUFFER_BIT:: Format can: be used
    /// to create a sname:VkBufferView that can: be bound to a
    /// ename:VK_DESCRIPTOR_TYPE_UNIFORM_TEXEL_BUFFER descriptor.
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_FEATURE_STORAGE_TEXEL_BUFFER_BIT:: Format can: be used
    /// to create a sname:VkBufferView that can: be bound to a
    /// ename:VK_DESCRIPTOR_TYPE_STORAGE_TEXEL_BUFFER descriptor.
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_FEATURE_STORAGE_TEXEL_BUFFER_ATOMIC_BIT:: Atomic
    /// operations are supported on
    /// ename:VK_DESCRIPTOR_TYPE_STORAGE_TEXEL_BUFFER with this format.
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_FEATURE_VERTEX_BUFFER_BIT:: Format can: be used as a
    /// vertex attribute format
    /// (sname:VkVertexInputAttributeDescription::pname:format).
    /// </para>
    /// <para>
    /// [NOTE] .Note ==== If no format feature flags are supported, then the
    /// only possible use would be image transfers - which alone are not
    /// useful. As such, if no format feature flags are supported, the format
    /// itself is not supported, and images of that format cannot be created.
    /// ====
    /// </para>
    /// <para>
    /// If pname:format is a block-compression format, then buffers must: not
    /// support any features for the format.
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
