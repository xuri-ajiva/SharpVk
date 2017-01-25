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
    /// -
    /// </summary>
    public partial class Swapchain
        : IDisposable
    {
        internal readonly Interop.Swapchain handle; 
        
        internal readonly CommandCache commandCache; 
        
        private readonly Surface parent; 
        
        internal AllocationCallbacks? Allocator
        {
            get
            {
                return this.parent.Allocator;
            }
        }
        
        private readonly Device associated; 
        
        internal Swapchain(Interop.Swapchain handle, Surface parent, Device associated, CommandCache commandCache)
        {
            this.handle = handle;
            this.parent = parent;
            this.associated = associated;
            this.commandCache = commandCache;
        }
        
        /// <summary>
        /// Destroy a swapchain object.
        /// </summary>
        public void Destroy()
        {
            unsafe
            {
                try
                {
                    var commandDelegate = this.commandCache.GetCommandDelegate<Interop.vkDestroySwapchainKHR>("vkDestroySwapchainKHR", "device");
                    Interop.AllocationCallbacks marshalledAllocator;
                    this.parent.Allocator?.MarshalTo(&marshalledAllocator);
                    commandDelegate(this.associated.handle, this.handle, this.parent.Allocator == null ? null : &marshalledAllocator);
                }
                finally
                {
                    Interop.HeapUtil.FreeLog();
                }
            }
        }
        
        /// <summary>
        /// Obtain the array of presentable images associated with a swapchain.
        /// </summary>
        public Image[] GetImages()
        {
            unsafe
            {
                try
                {
                    var commandDelegate = this.commandCache.GetCommandDelegate<Interop.vkGetSwapchainImagesKHR>("vkGetSwapchainImagesKHR", "device");
                    Image[] result = default(Image[]);
                    Result commandResult;
                    uint swapchainImageCount;
                    Interop.Image* marshalledSwapchainImages = null;
                    commandResult = commandDelegate(this.associated.handle, this.handle, &swapchainImageCount, null);
                    if (SharpVkException.IsError(commandResult))
                    {
                        throw SharpVkException.Create(commandResult);
                    }
                    marshalledSwapchainImages = (Interop.Image*)Interop.HeapUtil.Allocate<Interop.Image>((uint)swapchainImageCount);
                    commandResult = commandDelegate(this.associated.handle, this.handle, &swapchainImageCount, marshalledSwapchainImages);
                    if (SharpVkException.IsError(commandResult))
                    {
                        throw SharpVkException.Create(commandResult);
                    }
                    result = new Image[(uint)swapchainImageCount];
                    for(int index = 0; index < (uint)swapchainImageCount; index++)
                    {
                    	result[index] = new Image(marshalledSwapchainImages[index], this.associated, this.commandCache);
                    }
                    return result;
                }
                finally
                {
                    Interop.HeapUtil.FreeLog();
                }
            }
        }
        
        /// <summary>
        /// Retrieve the index of the next available presentable image.
        /// </summary>
        public uint AcquireNextImage(ulong timeout, Semaphore semaphore, Fence fence)
        {
            unsafe
            {
                try
                {
                    var commandDelegate = this.commandCache.GetCommandDelegate<Interop.vkAcquireNextImageKHR>("vkAcquireNextImageKHR", "device");
                    uint result = default(uint);
                    Result commandResult;
                    Interop.Semaphore marshalledSemaphore = default(Interop.Semaphore);
                    semaphore?.MarshalTo(&marshalledSemaphore);
                    Interop.Fence marshalledFence = default(Interop.Fence);
                    fence?.MarshalTo(&marshalledFence);
                    commandResult = commandDelegate(this.associated.handle, this.handle, timeout, marshalledSemaphore, marshalledFence, &result);
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
        
        /// <summary>
        /// Query the current value of a surface counter.
        /// </summary>
        public ulong GetCounter(SurfaceCounterFlags counter)
        {
            unsafe
            {
                try
                {
                    var commandDelegate = this.commandCache.GetCommandDelegate<Interop.vkGetSwapchainCounterEXT>("vkGetSwapchainCounterEXT", "device");
                    ulong result = default(ulong);
                    Result commandResult;
                    commandResult = commandDelegate(this.associated.handle, this.handle, counter, &result);
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
        
        internal unsafe void MarshalTo(Interop.Swapchain* pointer)
        {
            *pointer = this.handle;
        }
        
        /// <summary>
        /// The interop handle for this Swapchain.
        /// </summary>
        public Interop.Swapchain RawHandle => this.handle;
        
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
