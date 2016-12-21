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
    /// Structure specifying an image blit operation.
    /// </para>
    /// <para>
    /// For each element of the pname:pRegions array, a blit operation is
    /// performed the specified source and destination regions.
    /// </para>
    /// </summary>
    public struct ImageBlit
    {
        /// <summary>
        /// pname:srcSubresource is the subresource to blit from.
        /// </summary>
        public ImageSubresourceLayers SourceSubresource
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:srcOffsets is an array of two slink:VkOffset3D structures
        /// specifying the bounds of the source region within
        /// pname:srcSubresource.
        /// </summary>
        public Offset3D[] SourceOffsets
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:dstSubresource is the subresource to blit into.
        /// </summary>
        public ImageSubresourceLayers DestinationSubresource
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:dstOffsets is an array of two slink:VkOffset3D structures
        /// specifying the bounds of the destination region within
        /// pname:dstSubresource.
        /// </summary>
        public Offset3D[] DestinationOffsets
        {
            get;
            set;
        }
        
        internal unsafe Interop.ImageBlit* MarshalTo()
        {
            var result = (Interop.ImageBlit*)Interop.HeapUtil.AllocateAndClear<Interop.ImageBlit>().ToPointer();
            this.MarshalTo(result);
            return result;
        }
        
        internal unsafe void MarshalTo(Interop.ImageBlit* pointer)
        {
            Validate.CheckLength(this.SourceOffsets, 2, "SourceOffsets");
            MemUtil.WriteToPtr((IntPtr)(&pointer->SourceOffsets), this.SourceOffsets, 0, 2);
            Validate.CheckLength(this.DestinationOffsets, 2, "DestinationOffsets");
            MemUtil.WriteToPtr((IntPtr)(&pointer->DestinationOffsets), this.DestinationOffsets, 0, 2);
            pointer->SourceSubresource = this.SourceSubresource;
            pointer->DestinationSubresource = this.DestinationSubresource;
        }
    }
}
