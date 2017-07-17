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

namespace SharpVk.Interop.Khronos
{
    /// <summary>
    /// 
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct PhysicalDeviceImageFormatInfo2
    {
        /// <summary>
        /// pname:sType is the type of this structure.
        /// </summary>
        public SharpVk.StructureType SType; 
        
        /// <summary>
        /// pname:pNext is `NULL` or a pointer to an extension-specific
        /// structure.
        /// </summary>
        public void* Next; 
        
        /// <summary>
        /// pname:format is the image format, corresponding to
        /// slink:VkImageCreateInfo::pname:format.
        /// </summary>
        public SharpVk.Format Format; 
        
        /// <summary>
        /// pname:type is the image type, corresponding to
        /// slink:VkImageCreateInfo::pname:imageType.
        /// </summary>
        public SharpVk.ImageType Type; 
        
        /// <summary>
        /// pname:tiling is the image tiling, corresponding to
        /// slink:VkImageCreateInfo::pname:tiling.
        /// </summary>
        public SharpVk.ImageTiling Tiling; 
        
        /// <summary>
        /// pname:usage is the intended usage of the image, corresponding to
        /// slink:VkImageCreateInfo::pname:usage.
        /// </summary>
        public SharpVk.ImageUsageFlags Usage; 
        
        /// <summary>
        /// pname:flags is a bitmask describing additional parameters of the
        /// image, corresponding to slink:VkImageCreateInfo::pname:flags.
        /// </summary>
        public SharpVk.ImageCreateFlags Flags; 
    }
}
