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
    /// Structure specifying a clear attachment.
    /// </para>
    /// <para>
    /// No memory barriers are needed between fname:vkCmdClearAttachments and
    /// preceding or subsequent draw or attachment clear commands in the same
    /// subpass.
    /// </para>
    /// <para>
    /// The fname:vkCmdClearAttachments command is not affected by the bound
    /// pipeline state.
    /// </para>
    /// <para>
    /// Attachments can: also be cleared at the beginning of a render pass
    /// instance by setting pname:loadOp (or pname:stencilLoadOp) of
    /// slink:VkAttachmentDescription to ename:VK_ATTACHMENT_LOAD_OP_CLEAR, as
    /// described for flink:vkCreateRenderPass.
    /// </para>
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct ClearAttachment
    {
        /// <summary>
        /// 
        /// </summary>
        public ClearAttachment(ImageAspectFlags aspectMask, uint colorAttachment, ClearValue clearValue)
        {
            this.AspectMask = aspectMask;
            this.ColorAttachment = colorAttachment;
            this.ClearValue = clearValue;
        }
        
        /// <summary>
        /// pname:aspectMask is a mask selecting the color, depth and/or
        /// stencil aspects of the attachment to be cleared. pname:aspectMask
        /// can: include ename:VK_IMAGE_ASPECT_COLOR_BIT for color attachments,
        /// ename:VK_IMAGE_ASPECT_DEPTH_BIT for depth/stencil attachments with
        /// a depth component, and ename:VK_IMAGE_ASPECT_STENCIL_BIT for
        /// depth/stencil attachments with a stencil component. If the
        /// subpass's depth/stencil attachment is ename:VK_ATTACHMENT_UNUSED,
        /// then the clear has no effect.
        /// </summary>
        public ImageAspectFlags AspectMask; 
        
        /// <summary>
        /// pname:colorAttachment is only meaningful if
        /// ename:VK_IMAGE_ASPECT_COLOR_BIT is set in pname:aspectMask, in
        /// which case it is an index to the pname:pColorAttachments array in
        /// the slink:VkSubpassDescription structure of the current subpass
        /// which selects the color attachment to clear. If
        /// pname:colorAttachment is ename:VK_ATTACHMENT_UNUSED then the clear
        /// has no effect.
        /// </summary>
        public uint ColorAttachment; 
        
        /// <summary>
        /// pname:clearValue is the color or depth/stencil value to clear the
        /// attachment to, as described in &lt;&lt;clears-values,Clear
        /// Values&gt;&gt; below.
        /// </summary>
        public ClearValue ClearValue; 
        
        /// <summary>
        /// 
        /// </summary>
        public override string ToString()
        {
            var builder = new StringBuilder();
            builder.AppendLine("ClearAttachment");
            builder.AppendLine("{");
            builder.AppendLine($"AspectMask: {this.AspectMask}");
            builder.AppendLine($"ColorAttachment: {this.ColorAttachment}");
            builder.AppendLine($"ClearValue: {this.ClearValue}");
            builder.Append("}");
            return builder.ToString();
        }
    }
}
