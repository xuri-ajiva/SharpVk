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
    public struct ImageMemoryBarrier
    {
        /// <summary>
        /// 
        /// </summary>
        public AccessFlags SourceAccessMask
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public AccessFlags DestinationAccessMask
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public ImageLayout OldLayout
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public ImageLayout NewLayout
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint SourceQueueFamilyIndex
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint DestinationQueueFamilyIndex
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public Image Image
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public ImageSubresourceRange SubresourceRange
        {
            get;
            set;
        }
        
        internal unsafe void MarshalTo(Interop.ImageMemoryBarrier* pointer)
        {
            pointer->SType = StructureType.ImageMemoryBarrier;
            pointer->Next = null;
            pointer->SourceAccessMask = this.SourceAccessMask;
            pointer->DestinationAccessMask = this.DestinationAccessMask;
            pointer->OldLayout = this.OldLayout;
            pointer->NewLayout = this.NewLayout;
            pointer->SourceQueueFamilyIndex = this.SourceQueueFamilyIndex;
            pointer->DestinationQueueFamilyIndex = this.DestinationQueueFamilyIndex;
            pointer->Image = this.Image.handle;
            pointer->SubresourceRange = this.SubresourceRange;
        }
    }
}
