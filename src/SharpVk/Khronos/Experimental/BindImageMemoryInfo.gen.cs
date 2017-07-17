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

namespace SharpVk.Khronos.Experimental
{
    /// <summary>
    /// Structure specifying how to bind an image to memory.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct BindImageMemoryInfo
    {
        /// <summary>
        /// pname:image is the image to be attached to memory.
        /// </summary>
        public SharpVk.Image Image
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:memory is a sname:VkDeviceMemory object describing the device
        /// memory to attach.
        /// </summary>
        public SharpVk.DeviceMemory Memory
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:memoryOffset is the start offset of the region of
        /// pname:memory which is to be bound to the image. If
        /// pname:SFRRectCount is zero, the number of bytes returned in the
        /// sname:VkMemoryRequirements::pname:size member in pname:memory,
        /// starting from pname:memoryOffset bytes, will be bound to the
        /// specified image.
        /// </summary>
        public DeviceSize MemoryOffset
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:pDeviceIndices is a pointer to an array of device indices.
        /// </summary>
        public uint[] DeviceIndices
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:pSFRRects is a pointer to an array of rectangles describing
        /// which regions of the image are attached to each instance of memory.
        /// </summary>
        public SharpVk.Rect2D[] SFRRects
        {
            get;
            set;
        }
        
        internal unsafe void MarshalTo(SharpVk.Interop.Khronos.Experimental.BindImageMemoryInfo* pointer)
        {
            pointer->SType = StructureType.BindImageMemoryInfoKhx;
            pointer->Next = null;
            pointer->Image = this.Image?.handle ?? default(SharpVk.Interop.Image);
            pointer->Memory = this.Memory?.handle ?? default(SharpVk.Interop.DeviceMemory);
            pointer->MemoryOffset = this.MemoryOffset;
            pointer->DeviceIndexCount = (uint)(this.DeviceIndices?.Length ?? 0);
            if (this.DeviceIndices != null)
            {
                var fieldPointer = (uint*)(Interop.HeapUtil.AllocateAndClear<uint>(this.DeviceIndices.Length).ToPointer());
                for(int index = 0; index < (uint)(this.DeviceIndices.Length); index++)
                {
                    fieldPointer[index] = this.DeviceIndices[index];
                }
                pointer->DeviceIndices = fieldPointer;
            }
            else
            {
                pointer->DeviceIndices = null;
            }
            pointer->SFRRectCount = (uint)(this.SFRRects?.Length ?? 0);
            if (this.SFRRects != null)
            {
                var fieldPointer = (SharpVk.Rect2D*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Rect2D>(this.SFRRects.Length).ToPointer());
                for(int index = 0; index < (uint)(this.SFRRects.Length); index++)
                {
                    fieldPointer[index] = this.SFRRects[index];
                }
                pointer->SFRRects = fieldPointer;
            }
            else
            {
                pointer->SFRRects = null;
            }
        }
    }
}
