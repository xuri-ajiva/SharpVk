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
    /// 
    /// </summary>
    public partial class DeviceMemory
    {
        internal readonly SharpVk.Interop.DeviceMemory handle; 
        
        private readonly SharpVk.Interop.Device parent; 
        
        internal DeviceMemory(SharpVk.Interop.Device parent, SharpVk.Interop.DeviceMemory handle)
        {
            this.handle = handle;
            this.parent = parent;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public unsafe void Free(AllocationCallbacks? allocator = null)
        {
            try
            {
                Interop.AllocationCallbacks* marshalledAllocator = default(Interop.AllocationCallbacks*);
                if (allocator != null)
                {
                    marshalledAllocator = (Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<Interop.AllocationCallbacks>());
                    allocator.Value.MarshalTo(marshalledAllocator);
                }
                Interop.Commands.vkFreeMemory(this.parent, this.handle, marshalledAllocator);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        public unsafe IntPtr Map(DeviceSize offset, DeviceSize size, MemoryMapFlags flags)
        {
            try
            {
                IntPtr result = default(IntPtr);
                void* marshalledData = default(void*);
                Interop.Commands.vkMapMemory(this.parent, this.handle, offset, size, flags, &marshalledData);
                result = new IntPtr(marshalledData);
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        public unsafe void Unmap()
        {
            try
            {
                Interop.Commands.vkUnmapMemory(this.parent, this.handle);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        public unsafe DeviceSize GetCommitment()
        {
            try
            {
                DeviceSize result = default(DeviceSize);
                DeviceSize marshalledCommittedMemoryInBytes = default(DeviceSize);
                Interop.Commands.vkGetDeviceMemoryCommitment(this.parent, this.handle, &marshalledCommittedMemoryInBytes);
                result = marshalledCommittedMemoryInBytes;
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
    }
}
