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

namespace SharpVk.Interop
{
    /// <summary>
    /// 
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct FramebufferCreateInfo
    {
        /// <summary>
        /// pname:sType is the type of this structure.
        /// </summary>
        public SharpVk.StructureType SType; 
        
        /// <summary>
        /// pname:pNext is `NULL` or a pointer to an extension-specific
        /// structure.
        /// </summary>
        public void* Next; 
        
        /// <summary>
        /// pname:flags is reserved for future use.
        /// </summary>
        public SharpVk.FramebufferCreateFlags Flags; 
        
        /// <summary>
        /// pname:renderPass is a render pass that defines what render passes
        /// the framebuffer will be compatible with. See
        /// &lt;&lt;renderpass-compatibility,Render Pass Compatibility&gt;&gt;
        /// for details.
        /// </summary>
        public SharpVk.Interop.RenderPass RenderPass; 
        
        /// <summary>
        /// pname:attachmentCount is the number of attachments.
        /// </summary>
        public uint AttachmentCount; 
        
        /// <summary>
        /// pname:pAttachments is an array of sname:VkImageView handles, each
        /// of which will be used as the corresponding attachment in a render
        /// pass instance.
        /// </summary>
        public SharpVk.Interop.ImageView* Attachments; 
        
        /// <summary>
        /// pname:width, pname:height and pname:layers define the dimensions of
        /// the framebuffer. If the render pass uses multiview, then
        /// pname:layers must: be one and each attachment requires a number of
        /// layers that is greater than the maximum bit index set in the view
        /// mask in the subpasses in which it is used.
        /// </summary>
        public uint Width; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint Height; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint Layers; 
    }
}
