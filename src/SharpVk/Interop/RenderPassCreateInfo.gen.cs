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
    public unsafe struct RenderPassCreateInfo
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
        public SharpVk.RenderPassCreateFlags Flags; 
        
        /// <summary>
        /// pname:attachmentCount is the number of attachments used by this
        /// render pass, or zero indicating no attachments. Attachments are
        /// referred to by zero-based indices in the range
        /// [0,pname:attachmentCount).
        /// </summary>
        public uint AttachmentCount; 
        
        /// <summary>
        /// pname:pAttachments points to an array of pname:attachmentCount
        /// number of slink:VkAttachmentDescription structures describing
        /// properties of the attachments, or `NULL` if pname:attachmentCount
        /// is zero.
        /// </summary>
        public SharpVk.AttachmentDescription* Attachments; 
        
        /// <summary>
        /// pname:subpassCount is the number of subpasses to create for this
        /// render pass. Subpasses are referred to by zero-based indices in the
        /// range [0,pname:subpassCount). A render pass must: have at least one
        /// subpass.
        /// </summary>
        public uint SubpassCount; 
        
        /// <summary>
        /// pname:pSubpasses points to an array of pname:subpassCount number of
        /// slink:VkSubpassDescription structures describing properties of the
        /// subpasses.
        /// </summary>
        public SharpVk.Interop.SubpassDescription* Subpasses; 
        
        /// <summary>
        /// pname:dependencyCount is the number of dependencies between pairs
        /// of subpasses, or zero indicating no dependencies.
        /// </summary>
        public uint DependencyCount; 
        
        /// <summary>
        /// pname:pDependencies points to an array of pname:dependencyCount
        /// number of slink:VkSubpassDependency structures describing
        /// dependencies between pairs of subpasses, or `NULL` if
        /// pname:dependencyCount is zero.
        /// </summary>
        public SharpVk.SubpassDependency* Dependencies; 
    }
}
