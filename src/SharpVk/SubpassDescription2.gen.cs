// The MIT License (MIT)
// 
// Copyright (c) Andrew Armstrong/FacticiusVir 2020
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
    public partial struct SubpassDescription2
    {
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.SubpassDescriptionFlags? Flags
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.PipelineBindPoint PipelineBindPoint
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint ViewMask
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.AttachmentReference2[] InputAttachments
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.AttachmentReference2[] ColorAttachments
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.AttachmentReference2[] ResolveAttachments
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.AttachmentReference2? DepthStencilAttachment
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
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal unsafe void MarshalTo(SharpVk.Interop.SubpassDescription2* pointer)
        {
            pointer->Next = null;
            if (this.Flags != null)
            {
                pointer->Flags = this.Flags.Value;
            }
            else
            {
                pointer->Flags = default(SharpVk.SubpassDescriptionFlags);
            }
            pointer->PipelineBindPoint = this.PipelineBindPoint;
            pointer->ViewMask = this.ViewMask;
            pointer->InputAttachmentCount = (uint)(Interop.HeapUtil.GetLength(this.InputAttachments));
            if (this.InputAttachments != null)
            {
                var fieldPointer = (SharpVk.Interop.AttachmentReference2*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.AttachmentReference2>(this.InputAttachments.Length).ToPointer());
                for(int index = 0; index < (uint)(this.InputAttachments.Length); index++)
                {
                    this.InputAttachments[index].MarshalTo(&fieldPointer[index]);
                }
                pointer->InputAttachments = fieldPointer;
            }
            else
            {
                pointer->InputAttachments = null;
            }
            pointer->ColorAttachmentCount = (uint)(Interop.HeapUtil.GetLength(this.ColorAttachments));
            if (this.ColorAttachments != null)
            {
                var fieldPointer = (SharpVk.Interop.AttachmentReference2*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.AttachmentReference2>(this.ColorAttachments.Length).ToPointer());
                for(int index = 0; index < (uint)(this.ColorAttachments.Length); index++)
                {
                    this.ColorAttachments[index].MarshalTo(&fieldPointer[index]);
                }
                pointer->ColorAttachments = fieldPointer;
            }
            else
            {
                pointer->ColorAttachments = null;
            }
            if (this.ResolveAttachments != null)
            {
                var fieldPointer = (SharpVk.Interop.AttachmentReference2*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.AttachmentReference2>(this.ResolveAttachments.Length).ToPointer());
                for(int index = 0; index < (uint)(this.ResolveAttachments.Length); index++)
                {
                    this.ResolveAttachments[index].MarshalTo(&fieldPointer[index]);
                }
                pointer->ResolveAttachments = fieldPointer;
            }
            else
            {
                pointer->ResolveAttachments = null;
            }
            if (this.DepthStencilAttachment != null)
            {
                pointer->DepthStencilAttachment = (SharpVk.Interop.AttachmentReference2*)(Interop.HeapUtil.Allocate<SharpVk.Interop.AttachmentReference2>());
                this.DepthStencilAttachment.Value.MarshalTo(pointer->DepthStencilAttachment);
            }
            else
            {
                pointer->DepthStencilAttachment = default(SharpVk.Interop.AttachmentReference2*);
            }
            pointer->PreserveAttachmentCount = (uint)(Interop.HeapUtil.GetLength(this.PreserveAttachments));
            if (this.PreserveAttachments != null)
            {
                var fieldPointer = (uint*)(Interop.HeapUtil.AllocateAndClear<uint>(this.PreserveAttachments.Length).ToPointer());
                for(int index = 0; index < (uint)(this.PreserveAttachments.Length); index++)
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
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal static unsafe SubpassDescription2 MarshalFrom(SharpVk.Interop.SubpassDescription2* pointer)
        {
            SubpassDescription2 result = default(SubpassDescription2);
            result.Flags = pointer->Flags;
            result.PipelineBindPoint = pointer->PipelineBindPoint;
            result.ViewMask = pointer->ViewMask;
            if (pointer->InputAttachments != null)
            {
                var fieldPointer = new SharpVk.AttachmentReference2[(uint)(pointer->InputAttachmentCount)];
                for(int index = 0; index < (uint)(pointer->InputAttachmentCount); index++)
                {
                    fieldPointer[index] = SharpVk.AttachmentReference2.MarshalFrom(&pointer->InputAttachments[index]);
                }
                result.InputAttachments = fieldPointer;
            }
            else
            {
                result.InputAttachments = null;
            }
            if (pointer->ColorAttachments != null)
            {
                var fieldPointer = new SharpVk.AttachmentReference2[(uint)(pointer->ColorAttachmentCount)];
                for(int index = 0; index < (uint)(pointer->ColorAttachmentCount); index++)
                {
                    fieldPointer[index] = SharpVk.AttachmentReference2.MarshalFrom(&pointer->ColorAttachments[index]);
                }
                result.ColorAttachments = fieldPointer;
            }
            else
            {
                result.ColorAttachments = null;
            }
            if (pointer->ResolveAttachments != null)
            {
                var fieldPointer = new SharpVk.AttachmentReference2[(uint)(pointer->ColorAttachmentCount)];
                for(int index = 0; index < (uint)(pointer->ColorAttachmentCount); index++)
                {
                    fieldPointer[index] = SharpVk.AttachmentReference2.MarshalFrom(&pointer->ResolveAttachments[index]);
                }
                result.ResolveAttachments = fieldPointer;
            }
            else
            {
                result.ResolveAttachments = null;
            }
            if (pointer->DepthStencilAttachment != null)
            {
                result.DepthStencilAttachment = SharpVk.AttachmentReference2.MarshalFrom(pointer->DepthStencilAttachment);
            }
            else
            {
                result.DepthStencilAttachment = null;
            }
            if (pointer->PreserveAttachments != null)
            {
                var fieldPointer = new uint[(uint)(pointer->PreserveAttachmentCount)];
                for(int index = 0; index < (uint)(pointer->PreserveAttachmentCount); index++)
                {
                    fieldPointer[index] = pointer->PreserveAttachments[index];
                }
                result.PreserveAttachments = fieldPointer;
            }
            else
            {
                result.PreserveAttachments = null;
            }
            return result;
        }
    }
}
