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

namespace SharpVk
{
    /// <summary>
    /// <para>
    /// Opaque handle to a buffer object.
    /// </para>
    /// <para>
    /// Buffers represent linear arrays of data which are used for various
    /// purposes by binding them to a graphics or compute pipeline via
    /// descriptor sets or via certain commands, or by directly specifying them
    /// as parameters to certain commands.
    /// </para>
    /// </summary>
    public partial class Buffer
        : IDisposable
    {
        internal readonly Interop.Buffer handle; 
        
        internal readonly CommandCache commandCache; 
        
        private readonly Device parent; 
        
        internal AllocationCallbacks? Allocator
        {
            get
            {
                return this.parent.Allocator;
            }
        }
        
        internal Buffer(Interop.Buffer handle, Device parent, CommandCache commandCache)
        {
            this.handle = handle;
            this.parent = parent;
            this.commandCache = commandCache;
        }
        
        /// <summary>
        /// Bind device memory to a buffer object.
        /// </summary>
        public void BindMemory(DeviceMemory memory, DeviceSize memoryOffset)
        {
            unsafe
            {
                try
                {
                    Result commandResult;
                    Interop.DeviceMemory marshalledMemory = default(Interop.DeviceMemory);
                    memory?.MarshalTo(&marshalledMemory);
                    commandResult = Interop.Commands.vkBindBufferMemory(this.parent.handle, this.handle, marshalledMemory, memoryOffset);
                    if (SharpVkException.IsError(commandResult))
                    {
                        throw SharpVkException.Create(commandResult);
                    }
                }
                finally
                {
                    Interop.HeapUtil.FreeLog();
                }
            }
        }
        
        /// <summary>
        /// Returns the memory requirements for specified Vulkan object.
        /// </summary>
        public MemoryRequirements GetMemoryRequirements()
        {
            unsafe
            {
                try
                {
                    MemoryRequirements result = default(MemoryRequirements);
                    Interop.Commands.vkGetBufferMemoryRequirements(this.parent.handle, this.handle, &result);
                    return result;
                }
                finally
                {
                    Interop.HeapUtil.FreeLog();
                }
            }
        }
        
        /// <summary>
        /// Destroy a buffer object.
        /// </summary>
        public void Destroy()
        {
            unsafe
            {
                try
                {
                    Interop.AllocationCallbacks marshalledAllocator;
                    this.parent.Allocator?.MarshalTo(&marshalledAllocator);
                    Interop.Commands.vkDestroyBuffer(this.parent.handle, this.handle, this.parent.Allocator == null ? null : &marshalledAllocator);
                }
                finally
                {
                    Interop.HeapUtil.FreeLog();
                }
            }
        }
        
        internal unsafe void MarshalTo(Interop.Buffer* pointer)
        {
            *pointer = this.handle;
        }
        
        /// <summary>
        /// The interop handle for this Buffer.
        /// </summary>
        public Interop.Buffer RawHandle => this.handle;
        
        /// <summary>
        /// Releases the unmanaged resources associated with this instance and
        /// destroys the underlying Vulkan handle.
        /// </summary>
        public void Dispose()
        {
            this.Destroy();
        }
    }
}
