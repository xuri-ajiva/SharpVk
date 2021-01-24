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
    /// Opaque handle to a command pool object.
    /// </summary>
    public class CommandPool
        : IDisposable
    {
        internal readonly SharpVk.Interop.CommandPool Handle; 
        
        internal readonly CommandCache commandCache; 
        
        internal readonly Device parent; 
        
        internal CommandPool(Device parent, SharpVk.Interop.CommandPool handle)
        {
            Handle = handle;
            this.parent = parent;
            commandCache = parent.commandCache;
        }
        
        /// <summary>
        /// The raw handle for this instance.
        /// </summary>
        public SharpVk.Interop.CommandPool RawHandle => Handle;
        
        /// <summary>
        /// Destroy a command pool object.
        /// </summary>
        /// <param name="allocator">
        /// An optional AllocationCallbacks instance that controls host memory
        /// allocation.
        /// </param>
        public unsafe void Destroy(AllocationCallbacks? allocator = default)
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
                Interop.VkCommandPoolDestroyDelegate commandDelegate = commandCache.Cache.vkDestroyCommandPool;
                commandDelegate(parent.Handle, Handle, marshalledAllocator);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Reset a command pool.
        /// </summary>
        /// <param name="flags">
        /// </param>
        public unsafe void Reset(CommandPoolResetFlags? flags = default)
        {
            try
            {
                CommandPoolResetFlags marshalledFlags = default;
                if (flags != null)
                {
                    marshalledFlags = flags.Value;
                }
                else
                {
                    marshalledFlags = default;
                }
                Interop.VkCommandPoolResetDelegate commandDelegate = commandCache.Cache.vkResetCommandPool;
                Result methodResult = commandDelegate(parent.Handle, Handle, marshalledFlags);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Free command buffers.
        /// </summary>
        /// <param name="commandBuffers">
        /// </param>
        public unsafe void FreeCommandBuffers(ArrayProxy<CommandBuffer>? commandBuffers)
        {
            try
            {
                SharpVk.Interop.CommandBuffer* marshalledCommandBuffers = default;
                if (commandBuffers.IsNull())
                {
                    marshalledCommandBuffers = null;
                }
                else
                {
                    if (commandBuffers.Value.Contents == ProxyContents.Single)
                    {
                        marshalledCommandBuffers = (SharpVk.Interop.CommandBuffer*)(Interop.HeapUtil.Allocate<SharpVk.Interop.CommandBuffer>());
                        *(SharpVk.Interop.CommandBuffer*)(marshalledCommandBuffers) = commandBuffers.Value.GetSingleValue()?.Handle ?? default;
                    }
                    else
                    {
                        var fieldPointer = (SharpVk.Interop.CommandBuffer*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.CommandBuffer>(Interop.HeapUtil.GetLength(commandBuffers.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(commandBuffers.Value)); index++)
                        {
                            fieldPointer[index] = commandBuffers.Value[index]?.Handle ?? default;
                        }
                        marshalledCommandBuffers = fieldPointer;
                    }
                }
                Interop.VkCommandPoolFreeCommandBuffersDelegate commandDelegate = commandCache.Cache.vkFreeCommandBuffers;
                commandDelegate(parent.Handle, Handle, (uint)(Interop.HeapUtil.GetLength(commandBuffers)), marshalledCommandBuffers);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// </summary>
        /// <param name="flags">
        /// </param>
        public unsafe void Trim(CommandPoolTrimFlags? flags = default)
        {
            try
            {
                CommandPoolTrimFlags marshalledFlags = default;
                if (flags != null)
                {
                    marshalledFlags = flags.Value;
                }
                else
                {
                    marshalledFlags = default;
                }
                Interop.VkCommandPoolTrimDelegate commandDelegate = commandCache.Cache.vkTrimCommandPool;
                commandDelegate(parent.Handle, Handle, marshalledFlags);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Destroys the handles and releases any unmanaged resources
        /// associated with it.
        /// </summary>
        public void Dispose()
        {
            Destroy();
        }
    }
}
