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
    /// Opaque handle to a fence object.
    /// </para>
    /// <para>
    /// Fences are a synchronization primitive that can: be used to insert a
    /// dependency from a queue to the host. Fences have two states - signaled
    /// and unsignaled. A fence can: be signaled as part of the execution of a
    /// &lt;&lt;devsandqueues-submission, queue submission&gt;&gt; command.
    /// Fences can: be unsignaled on the host with flink:vkResetFences. Fences
    /// can: be waited on by the host with the flink:vkWaitForFences command,
    /// and the current state can: be queried with flink:vkGetFenceStatus.
    /// </para>
    /// </summary>
    public partial class Fence
        : IDisposable
    {
        internal readonly Interop.Fence handle; 
        
        internal readonly CommandCache commandCache; 
        
        private readonly Device parent; 
        
        internal AllocationCallbacks? Allocator
        {
            get
            {
                return this.parent.Allocator;
            }
        }
        
        internal Fence(Interop.Fence handle, Device parent, CommandCache commandCache)
        {
            this.handle = handle;
            this.parent = parent;
            this.commandCache = commandCache;
        }
        
        /// <summary>
        /// Destroy a fence object.
        /// </summary>
        public void Destroy()
        {
            unsafe
            {
                try
                {
                    Interop.AllocationCallbacks marshalledAllocator;
                    this.parent.Allocator?.MarshalTo(&marshalledAllocator);
                    Interop.Commands.vkDestroyFence(this.parent.handle, this.handle, this.parent.Allocator == null ? null : &marshalledAllocator);
                }
                finally
                {
                    Interop.HeapUtil.FreeLog();
                }
            }
        }
        
        /// <summary>
        /// Return the status of a fence.
        /// </summary>
        public Result GetStatus()
        {
            unsafe
            {
                try
                {
                    Result result = default(Result);
                    result = Interop.Commands.vkGetFenceStatus(this.parent.handle, this.handle);
                    if (SharpVkException.IsError(result))
                    {
                        throw SharpVkException.Create(result);
                    }
                    return result;
                }
                finally
                {
                    Interop.HeapUtil.FreeLog();
                }
            }
        }
        
        internal unsafe void MarshalTo(Interop.Fence* pointer)
        {
            *pointer = this.handle;
        }
        
        /// <summary>
        /// The interop handle for this Fence.
        /// </summary>
        public Interop.Fence RawHandle => this.handle;
        
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
