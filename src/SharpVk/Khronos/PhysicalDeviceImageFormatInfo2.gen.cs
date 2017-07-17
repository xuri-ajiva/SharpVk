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
    /// Structure specifying image creation parameters.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct PhysicalDeviceImageFormatInfo2
    {
        /// <summary>
        /// pname:format is the image format, corresponding to
        /// slink:VkImageCreateInfo::pname:format.
        /// </summary>
        public SharpVk.Format Format
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:type is the image type, corresponding to
        /// slink:VkImageCreateInfo::pname:imageType.
        /// </summary>
        public SharpVk.ImageType Type
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:tiling is the image tiling, corresponding to
        /// slink:VkImageCreateInfo::pname:tiling.
        /// </summary>
        public SharpVk.ImageTiling Tiling
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:usage is the intended usage of the image, corresponding to
        /// slink:VkImageCreateInfo::pname:usage.
        /// </summary>
        public SharpVk.ImageUsageFlags Usage
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:flags is a bitmask describing additional parameters of the
        /// image, corresponding to slink:VkImageCreateInfo::pname:flags.
        /// </summary>
        public SharpVk.ImageCreateFlags? Flags
        {
            get;
            set;
        }
        
        internal unsafe void MarshalTo(SharpVk.Interop.Khronos.PhysicalDeviceImageFormatInfo2* pointer)
        {
            pointer->SType = StructureType.PhysicalDeviceImageFormatInfo2Khr;
            pointer->Next = null;
            pointer->Format = this.Format;
            pointer->Type = this.Type;
            pointer->Tiling = this.Tiling;
            pointer->Usage = this.Usage;
            if (this.Flags != null)
            {
                pointer->Flags = this.Flags.Value;
            }
            else
            {
                pointer->Flags = default(SharpVk.ImageCreateFlags);
            }
        }
        
        internal static unsafe PhysicalDeviceImageFormatInfo2 MarshalFrom(SharpVk.Interop.Khronos.PhysicalDeviceImageFormatInfo2* pointer)
        {
            PhysicalDeviceImageFormatInfo2 result = default(PhysicalDeviceImageFormatInfo2);
            result.Format = pointer->Format;
            result.Type = pointer->Type;
            result.Tiling = pointer->Tiling;
            result.Usage = pointer->Usage;
            result.Flags = pointer->Flags;
            return result;
        }
    }
}
