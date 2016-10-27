// The MIT License (MIT)
// 
// Copyright (c) Andrew Armstrong/FacticiusVir 2016
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

namespace SharpVk
{
    /// <summary>
    /// <para>
    /// Opaque handle to a device memory object.
    /// </para>
    /// <para>
    /// A Vulkan device operates on data in device memory via memory objects
    /// that are represented in the API by a sname:VkDeviceMemory handle.
    /// </para>
    /// </summary>
    public class DeviceMemory
    {
        internal readonly Interop.DeviceMemory handle; 
        
        internal readonly CommandCache commandCache; 
        
        private readonly Device parent; 
        
        internal AllocationCallbacks? Allocator
        {
            get
            {
                return this.parent.Allocator;
            }
        }
        
        internal DeviceMemory(Interop.DeviceMemory handle, Device parent, CommandCache commandCache)
        {
            this.handle = handle;
            this.parent = parent;
            this.commandCache = commandCache;
        }
        
        /// <summary>
        /// Map a memory object into application address space.
        /// </summary>
        public void MapMemory(DeviceSize offset, DeviceSize size, MemoryMapFlags flags, ref IntPtr ppData)
        {
            unsafe
            {
                try
                {
                    Result commandResult;
                    void* marshalledPpData;
                    commandResult = Interop.Commands.vkMapMemory(this.parent.handle, this.handle, offset, size, flags, &marshalledPpData);
                    if (SharpVkException.IsError(commandResult))
                    {
                        throw SharpVkException.Create(commandResult);
                    }
                    ppData = new IntPtr(marshalledPpData);
                }
                finally
                {
                    Interop.HeapUtil.FreeLog();
                }
            }
        }
        
        /// <summary>
        /// Unmap a previously mapped memory object.
        /// </summary>
        public void UnmapMemory()
        {
            unsafe
            {
                try
                {
                    Interop.Commands.vkUnmapMemory(this.parent.handle, this.handle);
                }
                finally
                {
                    Interop.HeapUtil.FreeLog();
                }
            }
        }
        
        /// <summary>
        /// Query the current commitment for a VkDeviceMemory.
        /// </summary>
        public DeviceSize GetCommitment()
        {
            unsafe
            {
                try
                {
                    DeviceSize result = default(DeviceSize);
                    Interop.Commands.vkGetDeviceMemoryCommitment(this.parent.handle, this.handle, &result);
                    return result;
                }
                finally
                {
                    Interop.HeapUtil.FreeLog();
                }
            }
        }
        
        /// <summary>
        /// Retrieve Win32 handle to a device memory object.
        /// </summary>
        public IntPtr GetMemoryWin32Handle(ExternalMemoryHandleTypeFlags handleType)
        {
            unsafe
            {
                try
                {
                    var commandDelegate = this.commandCache.GetCommandDelegate<Interop.vkGetMemoryWin32HandleNV>("vkGetMemoryWin32HandleNV", "device");
                    IntPtr result = default(IntPtr);
                    Result commandResult;
                    commandResult = commandDelegate(this.parent.handle, this.handle, handleType, &result);
                    if (SharpVkException.IsError(commandResult))
                    {
                        throw SharpVkException.Create(commandResult);
                    }
                    return result;
                }
                finally
                {
                    Interop.HeapUtil.FreeLog();
                }
            }
        }
        
        internal Interop.DeviceMemory Pack()
        {
            return this.handle;
        }
        
        /// <summary>
        /// The interop handle for this DeviceMemory.
        /// </summary>
        public Interop.DeviceMemory RawHandle => this.handle;
    }
}
