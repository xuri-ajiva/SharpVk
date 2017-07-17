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
    /// Structure specifying how to bind a buffer to memory.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct BindBufferMemoryInfo
    {
        /// <summary>
        /// The buffer to be attached to memory.
        /// </summary>
        public SharpVk.Buffer Buffer
        {
            get;
            set;
        }
        
        /// <summary>
        /// A DeviceMemory object describing the device memory to attach.
        /// </summary>
        public SharpVk.DeviceMemory Memory
        {
            get;
            set;
        }
        
        /// <summary>
        /// The start offset of the region of memory which is to be bound to
        /// the buffer. The number of bytes returned in the
        /// MemoryRequirements.size member in memory, starting from
        /// memoryOffset bytes, will be bound to the specified buffer.
        /// </summary>
        public DeviceSize MemoryOffset
        {
            get;
            set;
        }
        
        /// <summary>
        /// An array of device indices.
        /// </summary>
        public uint[] DeviceIndices
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        internal unsafe void MarshalTo(SharpVk.Interop.Khronos.Experimental.BindBufferMemoryInfo* pointer)
        {
            pointer->SType = StructureType.BindBufferMemoryInfoKhx;
            pointer->Next = null;
            pointer->Buffer = this.Buffer?.handle ?? default(SharpVk.Interop.Buffer);
            pointer->Memory = this.Memory?.handle ?? default(SharpVk.Interop.DeviceMemory);
            pointer->MemoryOffset = this.MemoryOffset;
            pointer->DeviceIndexCount = (uint)(Interop.HeapUtil.GetLength(this.DeviceIndices));
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
        }
    }
}
