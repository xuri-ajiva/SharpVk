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
    /// Structure specifying parameters of a newly created framebuffer.
    /// </para>
    /// <para>
    /// Image subresources used as attachments must: not be used via any
    /// non-attachment usage for the duration of a render pass instance.
    /// </para>
    /// <para>
    /// [NOTE] .Note ==== This restriction means that the render pass has full
    /// knowledge of all uses of all of the attachments, so that the
    /// implementation is able to make correct decisions about when and how to
    /// perform layout transitions, when to overlap execution of subpasses,
    /// etc. ====
    /// </para>
    /// <para>
    /// It is legal for a subpass to use no color or depth/stencil attachments,
    /// and rather use shader side effects such as image stores and atomics to
    /// produce an output. In this case, the subpass continues to use the
    /// pname:width, pname:height, and pname:layers of the framebuffer to
    /// define the dimensions of the rendering area, and the
    /// pname:rasterizationSamples from each pipeline's
    /// slink:VkPipelineMultisampleStateCreateInfo to define the number of
    /// samples used in rasterization; however, if
    /// slink:VkPhysicalDeviceFeatures::pname:variableMultisampleRate is
    /// code:VK_FALSE, then all pipelines to be bound with a given
    /// zero-attachment subpass must: have the same value for
    /// slink:VkPipelineMultisampleStateCreateInfo::pname:rasterizationSamples.
    /// </para>
    /// </summary>
    public struct FramebufferCreateInfo
    {
        /// <summary>
        /// pname:flags is reserved for future use.
        /// </summary>
        public FramebufferCreateFlags Flags
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:renderPass is a render pass that defines what render passes
        /// the framebuffer will be compatible with. See
        /// &lt;&lt;renderpass-compatibility,Render Pass Compatibility&gt;&gt;
        /// for details.
        /// </summary>
        public RenderPass RenderPass
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:pAttachments is an array of sname:VkImageView handles, each
        /// of which will be used as the corresponding attachment in a render
        /// pass instance.
        /// </summary>
        public ImageView[] Attachments
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:width, pname:height and pname:layers define the dimensions of
        /// the framebuffer.
        /// </summary>
        public uint Width
        {
            get;
            set;
        }
        
        /// <summary>
        /// -
        /// </summary>
        public uint Height
        {
            get;
            set;
        }
        
        /// <summary>
        /// -
        /// </summary>
        public uint Layers
        {
            get;
            set;
        }
        
        internal unsafe Interop.FramebufferCreateInfo Pack()
        {
            Interop.FramebufferCreateInfo result = default(Interop.FramebufferCreateInfo);
            return result;
        }
        
        internal unsafe Interop.FramebufferCreateInfo* MarshalTo()
        {
            var result = (Interop.FramebufferCreateInfo*)Interop.HeapUtil.Allocate<Interop.FramebufferCreateInfo>().ToPointer();
            this.MarshalTo(result);
            return result;
        }
        
        internal unsafe void MarshalTo(Interop.FramebufferCreateInfo* pointer)
        {
            pointer->SType = StructureType.FramebufferCreateInfo;
            pointer->RenderPass = this.RenderPass?.Pack() ?? Interop.RenderPass.Null;
            
            //Attachments
            if (this.Attachments != null)
            {
                int size = System.Runtime.InteropServices.Marshal.SizeOf<Interop.ImageView>();
                IntPtr fieldPointer = Interop.HeapUtil.Allocate<Interop.ImageView>(this.Attachments.Length);
                for (int index = 0; index < this.Attachments.Length; index++)
                {
                    System.Runtime.InteropServices.Marshal.StructureToPtr(this.Attachments[index].Pack(), fieldPointer + (size * index), false);
                }
                pointer->Attachments = (Interop.ImageView*)fieldPointer.ToPointer();
            }
            else
            {
                pointer->Attachments = null;
            }
            pointer->AttachmentCount = (uint)(this.Attachments?.Length ?? 0);
            pointer->Flags = this.Flags;
            pointer->Width = this.Width;
            pointer->Height = this.Height;
            pointer->Layers = this.Layers;
        }
    }
}
