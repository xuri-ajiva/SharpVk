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
        
        internal unsafe Interop.RenderPassCreateInfo Pack()
        {
            Interop.RenderPassCreateInfo result = default(Interop.RenderPassCreateInfo);
            result.SType = StructureType.RenderPassCreateInfo;
            
            //Attachments
            if (this.Attachments != null)
            {
                result.Attachments = (AttachmentDescription*)Interop.HeapUtil.Allocate<AttachmentDescription>(this.Attachments.Length).ToPointer();
                for (int index = 0; index < this.Attachments.Length; index++)
                {
                    result.Attachments[index] = this.Attachments[index];
                }
            }
            else
            {
                result.Attachments = null;
            }
            
            //Subpasses
            if (this.Subpasses != null)
            {
                int size = System.Runtime.InteropServices.Marshal.SizeOf<Interop.SubpassDescription>();
                IntPtr pointer = Interop.HeapUtil.Allocate<Interop.SubpassDescription>(this.Subpasses.Length);
                for (int index = 0; index < this.Subpasses.Length; index++)
                {
                    System.Runtime.InteropServices.Marshal.StructureToPtr(this.Subpasses[index].Pack(), pointer + (size * index), false);
                }
                result.Subpasses = (Interop.SubpassDescription*)pointer.ToPointer();
            }
            else
            {
                result.Subpasses = null;
            }
            
            //Dependencies
            if (this.Dependencies != null)
            {
                result.Dependencies = (SubpassDependency*)Interop.HeapUtil.Allocate<SubpassDependency>(this.Dependencies.Length).ToPointer();
                for (int index = 0; index < this.Dependencies.Length; index++)
                {
                    result.Dependencies[index] = this.Dependencies[index];
                }
            }
            else
            {
                result.Dependencies = null;
            }
            result.AttachmentCount = (uint)(this.Attachments?.Length ?? 0);
            result.SubpassCount = (uint)(this.Subpasses?.Length ?? 0);
            result.DependencyCount = (uint)(this.Dependencies?.Length ?? 0);
            result.Flags = this.Flags;
            return result;
        }
        
        internal unsafe Interop.RenderPassCreateInfo* MarshalTo()
        {
            return (Interop.RenderPassCreateInfo*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
        }
    }
}
