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
    /// Structure specifying image creation parameters.
    /// </para>
    /// <para>
    /// The members of sname:VkPhysicalDeviceImageFormatInfo2KHR correspond to
    /// the arguments to flink:vkGetPhysicalDeviceImageFormatProperties, with
    /// pname:sType and pname:pNext added for extensibility.
    /// </para>
    /// </summary>
    public struct PhysicalDeviceImageFormatInfo2
    {
        /// <summary>
        /// pname:format is the image format, corresponding to
        /// slink:VkImageCreateInfo::pname:format.
        /// </summary>
        public Format Format
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:type is the image type, corresponding to
        /// slink:VkImageCreateInfo::pname:imageType.
        /// </summary>
        public ImageType Type
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:tiling is the image tiling, corresponding to
        /// slink:VkImageCreateInfo::pname:tiling.
        /// </summary>
        public ImageTiling Tiling
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:usage is the intended usage of the image, corresponding to
        /// slink:VkImageCreateInfo::pname:usage.
        /// </summary>
        public ImageUsageFlags Usage
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:flags is a bitmask describing additional parameters of the
        /// image, corresponding to slink:VkImageCreateInfo::pname:flags.
        /// </summary>
        public ImageCreateFlags Flags
        {
            get;
            set;
        }
        
        internal unsafe Interop.PhysicalDeviceImageFormatInfo2* MarshalTo()
        {
            var result = (Interop.PhysicalDeviceImageFormatInfo2*)Interop.HeapUtil.AllocateAndClear<Interop.PhysicalDeviceImageFormatInfo2>().ToPointer();
            this.MarshalTo(result);
            return result;
        }
        
        internal unsafe void MarshalTo(Interop.PhysicalDeviceImageFormatInfo2* pointer)
        {
            pointer->SType = StructureType.PhysicalDeviceImageFormatInfo2;
            pointer->Next = null;
            pointer->Format = this.Format;
            pointer->Type = this.Type;
            pointer->Tiling = this.Tiling;
            pointer->Usage = this.Usage;
            pointer->Flags = this.Flags;
        }
    }
}
