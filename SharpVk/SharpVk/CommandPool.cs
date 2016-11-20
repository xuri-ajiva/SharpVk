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
    /// Opaque handle to a command pool object.
    /// </para>
    /// <para>
    /// Command pools are opaque objects that command buffer memory is
    /// allocated from, and which allow the implementation to amortize the cost
    /// of resource creation across multiple command buffers. Command pools are
    /// application-synchronized, meaning that a command pool must: not be used
    /// concurrently in multiple threads. That includes use via recording
    /// commands on any command buffers allocated from the pool, as well as
    /// operations that allocate, free, and reset command buffers or the pool
    /// itself.
    /// </para>
    /// </summary>
    public partial class CommandPool
        : IDisposable
    {
        internal readonly Interop.CommandPool handle; 
        
        internal readonly CommandCache commandCache; 
        
        private readonly Device parent; 
        
        internal AllocationCallbacks? Allocator
        {
            get
            {
                return this.parent.Allocator;
            }
        }
        
        internal CommandPool(Interop.CommandPool handle, Device parent, CommandCache commandCache)
        {
            this.handle = handle;
            this.parent = parent;
            this.commandCache = commandCache;
        }
        
        /// <summary>
        /// Destroy a command pool object.
        /// </summary>
        public void Destroy()
        {
            unsafe
            {
                try
                {
                    Interop.AllocationCallbacks marshalledAllocator;
                    if(this.parent.Allocator != null) marshalledAllocator = this.parent.Allocator.Value.Pack();
                    Interop.Commands.vkDestroyCommandPool(this.parent.handle, this.handle, this.parent.Allocator == null ? null : &marshalledAllocator);
                }
                finally
                {
                    Interop.HeapUtil.FreeLog();
                }
            }
        }
        
        /// <summary>
        /// Reset a command pool.
        /// </summary>
        public void Reset(CommandPoolResetFlags flags)
        {
            unsafe
            {
                try
                {
                    Result commandResult;
                    commandResult = Interop.Commands.vkResetCommandPool(this.parent.handle, this.handle, flags);
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
        /// Free command buffers.
        /// </summary>
        public void FreeCommandBuffers(ArrayProxy<CommandBuffer> commandBuffers)
        {
            unsafe
            {
                try
                {
                    Interop.CommandBuffer* marshalledCommandBuffers = null;
                    if (commandBuffers.Contents != ProxyContents.Null)
                    {
                        Interop.CommandBuffer* arrayPointer = stackalloc Interop.CommandBuffer[commandBuffers.Length];
                        if(commandBuffers.Contents == ProxyContents.Single)
                        {
                            *arrayPointer = commandBuffers.GetSingleValue().Pack();
                        }
                        else
                        {
                            var arrayValue  = commandBuffers.GetArrayValue();
                            for (int index = 0; index < commandBuffers.Length; index++)
                            {
                                arrayPointer[index] = arrayValue.Array[arrayValue.Offset + index].Pack();
                            }
                        }
                        marshalledCommandBuffers = arrayPointer;
                    }
                    else
                    {
                        marshalledCommandBuffers = null;
                    }
                    Interop.Commands.vkFreeCommandBuffers(this.parent.handle, this.handle, (uint)(commandBuffers.Length), marshalledCommandBuffers);
                }
                finally
                {
                    Interop.HeapUtil.FreeLog();
                }
            }
        }
        
        internal Interop.CommandPool Pack()
        {
            return this.handle;
        }
        
        /// <summary>
        /// The interop handle for this CommandPool.
        /// </summary>
        public Interop.CommandPool RawHandle => this.handle;
        
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
