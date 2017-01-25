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
    /// Structure specifying sparse image format inputs.
    /// </summary>
    public struct PhysicalDeviceSparseImageFormatInfo2
    {
        /// <summary>
        /// pname:format is the image format.
        /// </summary>
        public Format Format
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:type is the dimensionality of image.
        /// </summary>
        public ImageType Type
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:samples is the number of samples per pixel as defined in
        /// elink:VkSampleCountFlagBits.
        /// </summary>
        public SampleCountFlags Samples
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:usage is a bitmask describing the intended usage of the
        /// image.
        /// </summary>
        public ImageUsageFlags Usage
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:tiling is the tiling arrangement of the data elements in
        /// memory.
        /// </summary>
        public ImageTiling Tiling
        {
            get;
            set;
        }
        
        internal unsafe Interop.PhysicalDeviceSparseImageFormatInfo2* MarshalTo()
        {
            var result = (Interop.PhysicalDeviceSparseImageFormatInfo2*)Interop.HeapUtil.AllocateAndClear<Interop.PhysicalDeviceSparseImageFormatInfo2>().ToPointer();
            this.MarshalTo(result);
            return result;
        }
        
        internal unsafe void MarshalTo(Interop.PhysicalDeviceSparseImageFormatInfo2* pointer)
        {
            pointer->SType = StructureType.PhysicalDeviceSparseImageFormatInfo2;
            pointer->Next = null;
            pointer->Format = this.Format;
            pointer->Type = this.Type;
            pointer->Samples = this.Samples;
            pointer->Usage = this.Usage;
            pointer->Tiling = this.Tiling;
        }
    }
}
