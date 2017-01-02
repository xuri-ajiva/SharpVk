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

namespace SharpVk
{
    /// <summary>
    /// Structure specifying parameters of a newly created render pass.
    /// </summary>
    public struct RenderPassCreateInfo
    {
        /// <summary>
        /// pname:flags is reserved for future use.
        /// </summary>
        public RenderPassCreateFlags Flags
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:pAttachments points to an array of pname:attachmentCount
        /// number of slink:VkAttachmentDescription structures describing
        /// properties of the attachments, or `NULL` if pname:attachmentCount
        /// is zero.
        /// </summary>
        public AttachmentDescription[] Attachments
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:pSubpasses points to an array of pname:subpassCount number of
        /// slink:VkSubpassDescription structures describing properties of the
        /// subpasses.
        /// </summary>
        public SubpassDescription[] Subpasses
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:pDependencies points to an array of pname:dependencyCount
        /// number of slink:VkSubpassDependency structures describing
        /// dependencies between pairs of subpasses, or `NULL` if
        /// pname:dependencyCount is zero.
        /// </summary>
        public SubpassDependency[] Dependencies
        {
            get;
            set;
        }
        
        internal unsafe Interop.RenderPassCreateInfo* MarshalTo()
        {
            var result = (Interop.RenderPassCreateInfo*)Interop.HeapUtil.AllocateAndClear<Interop.RenderPassCreateInfo>().ToPointer();
            this.MarshalTo(result);
            return result;
        }
        
        internal unsafe void MarshalTo(Interop.RenderPassCreateInfo* pointer)
        {
            pointer->SType = StructureType.RenderPassCreateInfo;
            
            //Attachments
            if (this.Attachments != null)
            {
                pointer->Attachments = (AttachmentDescription*)Interop.HeapUtil.Allocate<AttachmentDescription>(this.Attachments.Length).ToPointer();
                for (int index = 0; index < this.Attachments.Length; index++)
                {
                    pointer->Attachments[index] = this.Attachments[index];
                }
            }
            else
            {
                pointer->Attachments = null;
            }
            
            //Subpasses
            if (this.Subpasses != null)
            {
                var fieldPointer = (Interop.SubpassDescription*)Interop.HeapUtil.AllocateAndClear<Interop.SubpassDescription>(this.Subpasses.Length);
                for (int index = 0; index < this.Subpasses.Length; index++)
                {
                    this.Subpasses[index].MarshalTo(&fieldPointer[index]);
                }
                pointer->Subpasses = fieldPointer;
            }
            else
            {
                pointer->Subpasses = null;
            }
            
            //Dependencies
            if (this.Dependencies != null)
            {
                pointer->Dependencies = (SubpassDependency*)Interop.HeapUtil.Allocate<SubpassDependency>(this.Dependencies.Length).ToPointer();
                for (int index = 0; index < this.Dependencies.Length; index++)
                {
                    pointer->Dependencies[index] = this.Dependencies[index];
                }
            }
            else
            {
                pointer->Dependencies = null;
            }
            pointer->AttachmentCount = (uint)(this.Attachments?.Length ?? 0);
            pointer->SubpassCount = (uint)(this.Subpasses?.Length ?? 0);
            pointer->DependencyCount = (uint)(this.Dependencies?.Length ?? 0);
            pointer->Flags = this.Flags;
        }
    }
}
