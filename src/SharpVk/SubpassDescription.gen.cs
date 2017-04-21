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

namespace SharpVk
{
    /// <summary>
    /// 
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct SubpassDescription
    {
        /// <summary>
        /// 
        /// </summary>
        public SubpassDescriptionFlags Flags
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public PipelineBindPoint PipelineBindPoint
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public AttachmentReference[] InputAttachments
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public AttachmentReference[] ColorAttachments
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public AttachmentReference[] ResolveAttachments
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public AttachmentReference DepthStencilAttachment
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint[] PreserveAttachments
        {
            get;
            set;
        }
        
        internal unsafe void MarshalTo(Interop.SubpassDescription* pointer)
        {
            pointer->Flags = this.Flags;
            pointer->PipelineBindPoint = this.PipelineBindPoint;
            pointer->InputAttachmentCount = (uint)(this.InputAttachments?.Length ?? 0);
            if (this.InputAttachments != null)
            {
                var fieldPointer = (AttachmentReference*)(Interop.HeapUtil.AllocateAndClear<AttachmentReference>(this.InputAttachments.Length).ToPointer());
                for(int index = 0; index < this.InputAttachments.Length; index++)
                {
                    fieldPointer[index] = this.InputAttachments[index];
                }
                pointer->InputAttachments = fieldPointer;
            }
            else
            {
                pointer->InputAttachments = null;
            }
            pointer->ColorAttachmentCount = (uint)(this.ColorAttachments?.Length ?? 0);
            if (this.ColorAttachments != null)
            {
                var fieldPointer = (AttachmentReference*)(Interop.HeapUtil.AllocateAndClear<AttachmentReference>(this.ColorAttachments.Length).ToPointer());
                for(int index = 0; index < this.ColorAttachments.Length; index++)
                {
                    fieldPointer[index] = this.ColorAttachments[index];
                }
                pointer->ColorAttachments = fieldPointer;
            }
            else
            {
                pointer->ColorAttachments = null;
            }
            if (this.ResolveAttachments != null)
            {
                var fieldPointer = (AttachmentReference*)(Interop.HeapUtil.AllocateAndClear<AttachmentReference>(this.ResolveAttachments.Length).ToPointer());
                for(int index = 0; index < this.ResolveAttachments.Length; index++)
                {
                    fieldPointer[index] = this.ResolveAttachments[index];
                }
                pointer->ResolveAttachments = fieldPointer;
            }
            else
            {
                pointer->ResolveAttachments = null;
            }
            pointer->DepthStencilAttachment = (AttachmentReference*)(Interop.HeapUtil.Allocate<AttachmentReference>());
            *pointer->DepthStencilAttachment = this.DepthStencilAttachment;
            pointer->PreserveAttachmentCount = (uint)(this.PreserveAttachments?.Length ?? 0);
            if (this.PreserveAttachments != null)
            {
                var fieldPointer = (uint*)(Interop.HeapUtil.AllocateAndClear<uint>(this.PreserveAttachments.Length).ToPointer());
                for(int index = 0; index < this.PreserveAttachments.Length; index++)
                {
                    fieldPointer[index] = this.PreserveAttachments[index];
                }
                pointer->PreserveAttachments = fieldPointer;
            }
            else
            {
                pointer->PreserveAttachments = null;
            }
        }
    }
}
