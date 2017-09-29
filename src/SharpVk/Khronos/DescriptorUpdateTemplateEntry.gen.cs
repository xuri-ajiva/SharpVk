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

namespace SharpVk.Khronos
{
    /// <summary>
    /// Describes a single descriptor update of the descriptor update template.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct DescriptorUpdateTemplateEntry
    {
        /// <summary>
        /// 
        /// </summary>
        public DescriptorUpdateTemplateEntry(uint destinationBinding, uint destinationArrayElement, uint descriptorCount, SharpVk.DescriptorType descriptorType, HostSize offset, HostSize stride)
        {
            this.DestinationBinding = destinationBinding;
            this.DestinationArrayElement = destinationArrayElement;
            this.DescriptorCount = descriptorCount;
            this.DescriptorType = descriptorType;
            this.Offset = offset;
            this.Stride = stride;
        }
        
        /// <summary>
        /// The descriptor binding to update when using this descriptor update
        /// template.
        /// </summary>
        public uint DestinationBinding; 
        
        /// <summary>
        /// The starting element in the array belonging to dstBinding.
        /// </summary>
        public uint DestinationArrayElement; 
        
        /// <summary>
        /// The number of descriptors to update. If descriptorCount is greater
        /// than the number of remaining array elements in the destination
        /// binding, those affect consecutive bindings in a manner similar to
        /// WriteDescriptorSet above.
        /// </summary>
        public uint DescriptorCount; 
        
        /// <summary>
        /// A DescriptorType specifying the type of the descriptor.
        /// </summary>
        public SharpVk.DescriptorType DescriptorType; 
        
        /// <summary>
        /// The offset in bytes of the first binding in the raw data structure.
        /// </summary>
        public HostSize Offset; 
        
        /// <summary>
        /// The stride in bytes between two consecutive array elements of the
        /// descriptor update informations in the raw data structure. The
        /// actual pointer ptr for each array element j of update entry i is
        /// computed using the following formula: [source,c++]
        /// --------------------------------------------------- const char *ptr
        /// = (const char *)pData + pDescriptorUpdateEntries[i].offset + j *
        /// pDescriptorUpdateEntries[i].stride ---------------------------------------------------
        /// The stride is useful in case the bindings are stored in structs
        /// along with other data.
        /// </summary>
        public HostSize Stride; 
    }
}
