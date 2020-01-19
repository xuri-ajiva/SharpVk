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

namespace SharpVk.Khronos
{
    /// <summary>
    /// 
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct SubpassDescriptionDepthStencilResolve
    {
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Khronos.ResolveModeFlags DepthResolveMode
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Khronos.ResolveModeFlags StencilResolveMode
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Khronos.AttachmentReference2? DepthStencilResolveAttachment
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        internal unsafe void MarshalTo(SharpVk.Interop.Khronos.SubpassDescriptionDepthStencilResolve* pointer)
        {
            pointer->SType = StructureType.SubpassDescriptionDepthStencilResolve;
            pointer->Next = null;
            pointer->DepthResolveMode = this.DepthResolveMode;
            pointer->StencilResolveMode = this.StencilResolveMode;
            if (this.DepthStencilResolveAttachment != null)
            {
                pointer->DepthStencilResolveAttachment = (SharpVk.Interop.Khronos.AttachmentReference2*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.AttachmentReference2>());
                this.DepthStencilResolveAttachment.Value.MarshalTo(pointer->DepthStencilResolveAttachment);
            }
            else
            {
                pointer->DepthStencilResolveAttachment = default(SharpVk.Interop.Khronos.AttachmentReference2*);
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        internal static unsafe SubpassDescriptionDepthStencilResolve MarshalFrom(SharpVk.Interop.Khronos.SubpassDescriptionDepthStencilResolve* pointer)
        {
            SubpassDescriptionDepthStencilResolve result = default(SubpassDescriptionDepthStencilResolve);
            result.DepthResolveMode = pointer->DepthResolveMode;
            result.StencilResolveMode = pointer->StencilResolveMode;
            if (pointer->DepthStencilResolveAttachment != null)
            {
                result.DepthStencilResolveAttachment = SharpVk.Khronos.AttachmentReference2.MarshalFrom(pointer->DepthStencilResolveAttachment);
            }
            else
            {
                result.DepthStencilResolveAttachment = null;
            }
            return result;
        }
    }
}
