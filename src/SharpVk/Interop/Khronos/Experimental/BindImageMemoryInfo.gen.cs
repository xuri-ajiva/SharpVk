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

namespace SharpVk.Interop.Khronos.Experimental
{
    /// <summary>
    /// 
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct BindImageMemoryInfo
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
        /// pname:image is the image to be attached to memory.
        /// </summary>
        public SharpVk.Interop.Image Image; 
        
        /// <summary>
        /// pname:memory is a sname:VkDeviceMemory object describing the device
        /// memory to attach.
        /// </summary>
        public SharpVk.Interop.DeviceMemory Memory; 
        
        /// <summary>
        /// pname:memoryOffset is the start offset of the region of
        /// pname:memory which is to be bound to the image. If
        /// pname:SFRRectCount is zero, the number of bytes returned in the
        /// sname:VkMemoryRequirements::pname:size member in pname:memory,
        /// starting from pname:memoryOffset bytes, will be bound to the
        /// specified image.
        /// </summary>
        public DeviceSize MemoryOffset; 
        
        /// <summary>
        /// pname:deviceIndexCount is the number of elements in
        /// pname:pDeviceIndices.
        /// </summary>
        public uint DeviceIndexCount; 
        
        /// <summary>
        /// pname:pDeviceIndices is a pointer to an array of device indices.
        /// </summary>
        public uint* DeviceIndices; 
        
        /// <summary>
        /// pname:SFRRectCount is the number of elements in pname:pSFRRects.
        /// </summary>
        public uint SFRRectCount; 
        
        /// <summary>
        /// pname:pSFRRects is a pointer to an array of rectangles describing
        /// which regions of the image are attached to each instance of memory.
        /// </summary>
        public SharpVk.Rect2D* SFRRects; 
    }
}
