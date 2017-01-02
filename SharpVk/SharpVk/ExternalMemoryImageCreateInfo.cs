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
    /// <para>
    /// Specify that an image may be backed by external memory.
    /// </para>
    /// <para>
    /// If the pname:pNext list includes a
    /// sname:VkExternalMemoryImageCreateInfoNV structure, then that structure
    /// defines a set of external memory handle types that may: be used as
    /// backing store for the image.
    /// </para>
    /// </summary>
    public struct ExternalMemoryImageCreateInfo
    {
        /// <summary>
        /// pname:handleTypes is a bitmask of
        /// elink:VkExternalMemoryHandleTypeFlagBitsNV specifying one or more
        /// external memory handle types. The types must: all be compatible
        /// with each other and the other image creation parameters, as
        /// reported by
        /// flink:vkGetPhysicalDeviceExternalImageFormatPropertiesNV.
        /// </summary>
        public ExternalMemoryHandleTypeFlags HandleTypes
        {
            get;
            set;
        }
        
        internal unsafe Interop.ExternalMemoryImageCreateInfo* MarshalTo()
        {
            var result = (Interop.ExternalMemoryImageCreateInfo*)Interop.HeapUtil.AllocateAndClear<Interop.ExternalMemoryImageCreateInfo>().ToPointer();
            this.MarshalTo(result);
            return result;
        }
        
        internal unsafe void MarshalTo(Interop.ExternalMemoryImageCreateInfo* pointer)
        {
            pointer->SType = StructureType.ExternalMemoryImageCreateInfo;
            pointer->HandleTypes = this.HandleTypes;
        }
    }
}
