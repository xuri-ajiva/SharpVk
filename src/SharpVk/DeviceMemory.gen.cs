// The MIT License (MIT)
// 
// Copyright (c) Andrew Armstrong/FacticiusVir & xuri 2021
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
    /// Opaque handle to a device memory object.
    /// </summary>
    public class DeviceMemory
    {
        internal readonly SharpVk.Interop.DeviceMemory Handle; 
        
        internal readonly CommandCache commandCache; 
        
        internal readonly Device parent; 
        
        internal DeviceMemory(Device parent, SharpVk.Interop.DeviceMemory handle)
        {
            Handle = handle;
            this.parent = parent;
            commandCache = parent.commandCache;
        }
        
        /// <summary>
        /// The raw handle for this instance.
        /// </summary>
        public SharpVk.Interop.DeviceMemory RawHandle => Handle;
        
        /// <summary>
        /// Free GPU memory.
        /// </summary>
        /// <param name="allocator">
        /// An optional AllocationCallbacks instance that controls host memory
        /// allocation.
        /// </param>
        public unsafe void Free(AllocationCallbacks? allocator = default)
        {
            try
            {
                SharpVk.Interop.AllocationCallbacks* marshalledAllocator = default;
                if (allocator != null)
                {
                    marshalledAllocator = (SharpVk.Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<SharpVk.Interop.AllocationCallbacks>());
                    allocator.Value.MarshalTo(marshalledAllocator);
                }
                else
                {
                    marshalledAllocator = default;
                }
                Interop.VkDeviceMemoryFreeDelegate commandDelegate = commandCache.Cache.vkFreeMemory;
                commandDelegate(parent.Handle, Handle, marshalledAllocator);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Map a memory object into application address space.
        /// </summary>
        /// <param name="offset">
        /// </param>
        /// <param name="size">
        /// </param>
        /// <param name="flags">
        /// </param>
        public unsafe IntPtr Map(ulong offset, ulong size, MemoryMapFlags? flags = default)
        {
            try
            {
                IntPtr result = default;
                MemoryMapFlags marshalledFlags = default;
                void* marshalledData = default;
                if (flags != null)
                {
                    marshalledFlags = flags.Value;
                }
                else
                {
                    marshalledFlags = default;
                }
                Interop.VkDeviceMemoryMapDelegate commandDelegate = commandCache.Cache.vkMapMemory;
                Result methodResult = commandDelegate(parent.Handle, Handle, offset, size, marshalledFlags, &marshalledData);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = new IntPtr(marshalledData);
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Unmap a previously mapped memory object.
        /// </summary>
        public unsafe void Unmap()
        {
            try
            {
                Interop.VkDeviceMemoryUnmapDelegate commandDelegate = commandCache.Cache.vkUnmapMemory;
                commandDelegate(parent.Handle, Handle);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Query the current commitment for a DeviceMemory.
        /// </summary>
        public unsafe ulong GetCommitment()
        {
            try
            {
                ulong result = default;
                ulong marshalledCommittedMemoryInBytes = default;
                Interop.VkDeviceMemoryGetCommitmentDelegate commandDelegate = commandCache.Cache.vkGetDeviceMemoryCommitment;
                commandDelegate(parent.Handle, Handle, &marshalledCommittedMemoryInBytes);
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
