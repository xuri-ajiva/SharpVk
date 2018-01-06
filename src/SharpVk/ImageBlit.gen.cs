// The MIT License (MIT)
// 
// Copyright (c) Andrew Armstrong/FacticiusVir 2018
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
    /// Structure specifying an image blit operation.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct ImageBlit
    {
        /// <summary>
        /// The subresource to blit from.
        /// </summary>
        public SharpVk.ImageSubresourceLayers SourceSubresource
        {
            get;
            set;
        }
        
        /// <summary>
        /// An array of two Offset3D structures specifying the bounds of the
        /// source region within srcSubresource.
        /// </summary>
        public SharpVk.Offset3D[] SourceOffsets
        {
            get;
            set;
        }
        
        /// <summary>
        /// The subresource to blit into.
        /// </summary>
        public SharpVk.ImageSubresourceLayers DestinationSubresource
        {
            get;
            set;
        }
        
        /// <summary>
        /// An array of two Offset3D structures specifying the bounds of the
        /// destination region within dstSubresource.
        /// </summary>
        public SharpVk.Offset3D[] DestinationOffsets
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        internal unsafe void MarshalTo(SharpVk.Interop.ImageBlit* pointer)
        {
            pointer->SourceSubresource = this.SourceSubresource;
            pointer->DestinationSubresource = this.DestinationSubresource;
        }
    }
}
