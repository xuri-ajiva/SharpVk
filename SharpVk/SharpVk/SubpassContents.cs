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
    /// Specify how commands in the first subpass of a render pass are
    /// provided.
    /// </para>
    /// <para>
    /// After beginning a render pass instance, the command buffer is ready to
    /// record the commands for the first subpass of that render pass.
    /// </para>
    /// <para>
    /// .Valid Usage **** * If any of the pname:initialLayout or
    /// pname:finalLayout member of the sname:VkAttachmentDescription
    /// structures or the pname:layout member of the
    /// sname:VkAttachmentReference structures specified when creating the
    /// render pass specified in the pname:renderPass member of
    /// pname:pRenderPassBegin is
    /// ename:VK_IMAGE_LAYOUT_COLOR_ATTACHMENT_OPTIMAL then the corresponding
    /// attachment image subresource of the framebuffer specified in the
    /// pname:framebuffer member of pname:pRenderPassBegin must: have been
    /// created with ename:VK_IMAGE_USAGE_COLOR_ATTACHMENT_BIT set * If any of
    /// the pname:initialLayout or pname:finalLayout member of the
    /// sname:VkAttachmentDescription structures or the pname:layout member of
    /// the sname:VkAttachmentReference structures specified when creating the
    /// render pass specified in the pname:renderPass member of
    /// pname:pRenderPassBegin is
    /// ename:VK_IMAGE_LAYOUT_DEPTH_STENCIL_ATTACHMENT_OPTIMAL or
    /// ename:VK_IMAGE_LAYOUT_DEPTH_STENCIL_READ_ONLY_OPTIMAL then the
    /// corresponding attachment image subresource of the framebuffer specified
    /// in the pname:framebuffer member of pname:pRenderPassBegin must: have
    /// been created with ename:VK_IMAGE_USAGE_DEPTH_STENCIL_ATTACHMENT_BIT set
    /// * If any of the pname:initialLayout or pname:finalLayout member of the
    /// sname:VkAttachmentDescription structures or the pname:layout member of
    /// the sname:VkAttachmentReference structures specified when creating the
    /// render pass specified in the pname:renderPass member of
    /// pname:pRenderPassBegin is
    /// ename:VK_IMAGE_LAYOUT_SHADER_READ_ONLY_OPTIMAL then the corresponding
    /// attachment image subresource of the framebuffer specified in the
    /// pname:framebuffer member of pname:pRenderPassBegin must: have been
    /// created with ename:VK_IMAGE_USAGE_SAMPLED_BIT or
    /// ename:VK_IMAGE_USAGE_INPUT_ATTACHMENT_BIT set * If any of the
    /// pname:initialLayout or pname:finalLayout member of the
    /// sname:VkAttachmentDescription structures or the pname:layout member of
    /// the sname:VkAttachmentReference structures specified when creating the
    /// render pass specified in the pname:renderPass member of
    /// pname:pRenderPassBegin is ename:VK_IMAGE_LAYOUT_TRANSFER_SRC_OPTIMAL
    /// then the corresponding attachment image subresource of the framebuffer
    /// specified in the pname:framebuffer member of pname:pRenderPassBegin
    /// must: have been created with ename:VK_IMAGE_USAGE_TRANSFER_SRC_BIT set
    /// * If any of the pname:initialLayout or pname:finalLayout member of the
    /// sname:VkAttachmentDescription structures or the pname:layout member of
    /// the sname:VkAttachmentReference structures specified when creating the
    /// render pass specified in the pname:renderPass member of
    /// pname:pRenderPassBegin is ename:VK_IMAGE_LAYOUT_TRANSFER_DST_OPTIMAL
    /// then the corresponding attachment image subresource of the framebuffer
    /// specified in the pname:framebuffer member of pname:pRenderPassBegin
    /// must: have been created with ename:VK_IMAGE_USAGE_TRANSFER_DST_BIT set
    /// * If any of the pname:initialLayout members of the
    /// sname:VkAttachmentDescription structures specified when creating the
    /// render pass specified in the pname:renderPass member of
    /// pname:pRenderPassBegin is not ename:VK_IMAGE_LAYOUT_UNDEFINED, then
    /// each such pname:initialLayout must: be equal to the current layout of
    /// the corresponding attachment image subresource of the framebuffer
    /// specified in the pname:framebuffer member of pname:pRenderPassBegin
    /// ****
    /// </para>
    /// </summary>
    public enum SubpassContents
    {
        /// <summary>
        /// -
        /// </summary>
        Inline = 0, 
        
        /// <summary>
        /// -
        /// </summary>
        SecondaryCommandBuffers = 1, 
    }
}
