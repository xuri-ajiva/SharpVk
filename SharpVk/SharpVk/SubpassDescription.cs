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
    /// Structure specifying a subpass description.
    /// </para>
    /// <para>
    /// The contents of an attachment within the render area become undefined
    /// at the start of a subpass S if all of the following conditions are
    /// true:
    /// </para>
    /// <para>
    /// * The attachment is used as a color, depth/stencil, or resolve
    /// attachment in any subpass in the render pass. * There is a subpass S1
    /// that uses or preserves the attachment, and a subpass dependency from S1
    /// to S. * The attachment is not used or preserved in subpass S.
    /// </para>
    /// <para>
    /// Once the contents of an attachment become undefined in subpass S, they
    /// remain undefined for subpasses in subpass dependency chains starting
    /// with subpass S until they are written again. However, they remain valid
    /// for subpasses in other subpass dependency chains starting with subpass
    /// S1 if those subpasses use or preserve the attachment.
    /// </para>
    /// </summary>
    public struct SubpassDescription
    {
        /// <summary>
        /// pname:flags is reserved for future use.
        /// </summary>
        public SubpassDescriptionFlags Flags
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:pipelineBindPoint is a elink:VkPipelineBindPoint value
        /// specifying whether this is a compute or graphics subpass.
        /// Currently, only graphics subpasses are supported.
        /// </summary>
        public PipelineBindPoint PipelineBindPoint
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:pInputAttachments is an array of slink:VkAttachmentReference
        /// structures (defined below) that lists which of the render pass's
        /// attachments can: be read in the shader during the subpass, and what
        /// layout each attachment will be in during the subpass. Each element
        /// of the array corresponds to an input attachment unit number in the
        /// shader, i.e. if the shader declares an input variable
        /// `layout(input_attachment_index=X, set=Y, binding=Z)` then it uses
        /// the attachment provided in pname:pInputAttachments[X]. Input
        /// attachments must: also be bound to the pipeline with a descriptor
        /// set, with the input attachment descriptor written in the location
        /// (set=Y, binding=Z).
        /// </summary>
        public AttachmentReference[] InputAttachments
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:pColorAttachments is an array of pname:colorAttachmentCount
        /// slink:VkAttachmentReference structures that lists which of the
        /// render pass's attachments will be used as color attachments in the
        /// subpass, and what layout each attachment will be in during the
        /// subpass. Each element of the array corresponds to a fragment shader
        /// output location, i.e. if the shader declared an output variable
        /// `layout(location=X)` then it uses the attachment provided in
        /// pname:pColorAttachments[X].
        /// </summary>
        public AttachmentReference[] ColorAttachments
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:pResolveAttachments is `NULL` or an array of
        /// pname:colorAttachmentCount slink:VkAttachmentReference structures
        /// that lists which of the render pass's attachments are resolved to
        /// at the end of the subpass, and what layout each attachment will be
        /// in during the resolve. If pname:pResolveAttachments is not `NULL`,
        /// each of its elements corresponds to a color attachment (the element
        /// in pname:pColorAttachments at the same index). At the end of each
        /// subpass, the subpass's color attachments are resolved to
        /// corresponding resolve attachments, unless the resolve attachment
        /// index is ename:VK_ATTACHMENT_UNUSED or pname:pResolveAttachments is
        /// `NULL`. If the first use of an attachment in a render pass is as a
        /// resolve attachment, then the pname:loadOp is effectively ignored as
        /// the resolve is guaranteed to overwrite all pixels in the render
        /// area.
        /// </summary>
        public AttachmentReference[] ResolveAttachments
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:pDepthStencilAttachment is a pointer to a
        /// slink:VkAttachmentReference specifying which attachment will be
        /// used for depth/stencil data and the layout it will be in during the
        /// subpass. Setting the attachment index to ename:VK_ATTACHMENT_UNUSED
        /// or leaving this pointer as `NULL` indicates that no depth/stencil
        /// attachment will be used in the subpass.
        /// </summary>
        public AttachmentReference DepthStencilAttachment
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:pPreserveAttachments is an array of
        /// pname:preserveAttachmentCount render pass attachment indices
        /// describing the attachments that are not used by a subpass, but
        /// whose contents must: be preserved throughout the subpass.
        /// </summary>
        public uint[] PreserveAttachments
        {
            get;
            set;
        }
        
        internal unsafe Interop.SubpassDescription Pack()
        {
            Interop.SubpassDescription result = default(Interop.SubpassDescription);
            
            //InputAttachments
            if (this.InputAttachments != null)
            {
                result.InputAttachments = (AttachmentReference*)Interop.HeapUtil.Allocate<AttachmentReference>(this.InputAttachments.Length).ToPointer();
                for (int index = 0; index < this.InputAttachments.Length; index++)
                {
                    result.InputAttachments[index] = this.InputAttachments[index];
                }
            }
            else
            {
                result.InputAttachments = null;
            }
            
            //ColorAttachments
            if (this.ColorAttachments != null)
            {
                result.ColorAttachments = (AttachmentReference*)Interop.HeapUtil.Allocate<AttachmentReference>(this.ColorAttachments.Length).ToPointer();
                for (int index = 0; index < this.ColorAttachments.Length; index++)
                {
                    result.ColorAttachments[index] = this.ColorAttachments[index];
                }
            }
            else
            {
                result.ColorAttachments = null;
            }
            
            //ResolveAttachments
            if (this.ResolveAttachments != null)
            {
                result.ResolveAttachments = (AttachmentReference*)Interop.HeapUtil.Allocate<AttachmentReference>(this.ResolveAttachments.Length).ToPointer();
                for (int index = 0; index < this.ResolveAttachments.Length; index++)
                {
                    result.ResolveAttachments[index] = this.ResolveAttachments[index];
                }
            }
            else
            {
                result.ResolveAttachments = null;
            }
            result.DepthStencilAttachment = (AttachmentReference*)Interop.HeapUtil.AllocateAndMarshal(this.DepthStencilAttachment);
            result.PreserveAttachments = this.PreserveAttachments == null ? null : Interop.HeapUtil.MarshalTo(this.PreserveAttachments);
            result.InputAttachmentCount = (uint)(this.InputAttachments?.Length ?? 0);
            result.ColorAttachmentCount = (uint)(this.ColorAttachments?.Length ?? 0);
            result.PreserveAttachmentCount = (uint)(this.PreserveAttachments?.Length ?? 0);
            result.Flags = this.Flags;
            result.PipelineBindPoint = this.PipelineBindPoint;
            return result;
        }
        
        internal unsafe Interop.SubpassDescription* MarshalTo()
        {
            return (Interop.SubpassDescription*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
        }
    }
}
