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

namespace SharpVk.Khronos
{
    /// <summary>
    /// </summary>
    public class Swapchain
        : IDisposable
    {
        internal readonly SharpVk.Interop.Khronos.Swapchain Handle; 
        
        internal readonly CommandCache commandCache; 
        
        internal readonly Device parent; 
        
        internal Swapchain(Device parent, SharpVk.Interop.Khronos.Swapchain handle)
        {
            Handle = handle;
            this.parent = parent;
            commandCache = parent.commandCache;
        }
        
        /// <summary>
        /// The raw handle for this instance.
        /// </summary>
        public SharpVk.Interop.Khronos.Swapchain RawHandle => Handle;
        
        /// <summary>
        /// Destroy a swapchain object.
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
                SharpVk.Interop.Khronos.VkSwapchainKHRDestroyDelegate commandDelegate = commandCache.Cache.vkDestroySwapchainKHR;
                commandDelegate(parent.Handle, Handle, marshalledAllocator);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Obtain the array of presentable images associated with a swapchain.
        /// </summary>
        public unsafe Image[] GetImages()
        {
            try
            {
                Image[] result = default;
                uint marshalledSwapchainImageCount = default;
                SharpVk.Interop.Image* marshalledSwapchainImages = default;
                SharpVk.Interop.Khronos.VkSwapchainKHRGetImagesDelegate commandDelegate = commandCache.Cache.vkGetSwapchainImagesKHR;
                Result methodResult = commandDelegate(parent.Handle, Handle, &marshalledSwapchainImageCount, marshalledSwapchainImages);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                marshalledSwapchainImages = (SharpVk.Interop.Image*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Image>((uint)(marshalledSwapchainImageCount)));
                commandDelegate(parent.Handle, Handle, &marshalledSwapchainImageCount, marshalledSwapchainImages);
                if (marshalledSwapchainImages != null)
                {
                    var fieldPointer = new Image[(uint)(marshalledSwapchainImageCount)];
                    for(int index = 0; index < (uint)(marshalledSwapchainImageCount); index++)
                    {
                        fieldPointer[index] = new Image(parent, marshalledSwapchainImages[index]);
                    }
                    result = fieldPointer;
                }
                else
                {
                    result = null;
                }
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Retrieve the index of the next available presentable image.
        /// </summary>
        /// <param name="timeout">
        /// Indicates how long the function waits, in nanoseconds, if no image
        /// is available.
        /// </param>
        /// <param name="semaphore">
        /// Null or a semaphore to signal.
        /// </param>
        /// <param name="fence">
        /// Null or a fence to signal.
        /// </param>
        public unsafe uint AcquireNextImage(ulong timeout, Semaphore semaphore, Fence fence)
        {
            try
            {
                uint result = default;
                uint marshalledImageIndex = default;
                SharpVk.Interop.Khronos.VkSwapchainKHRAcquireNextImageDelegate commandDelegate = commandCache.Cache.vkAcquireNextImageKHR;
                Result methodResult = commandDelegate(parent.Handle, Handle, timeout, semaphore?.Handle ?? default, fence?.Handle ?? default, &marshalledImageIndex);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = marshalledImageIndex;
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// </summary>
        public unsafe Result GetStatus()
        {
            try
            {
                Result result = default;
                SharpVk.Interop.Khronos.VkSwapchainKHRGetStatusDelegate commandDelegate = commandCache.Cache.vkGetSwapchainStatusKHR;
                result = commandDelegate(parent.Handle, Handle);
                if (SharpVkException.IsError(result))
                {
                    throw SharpVkException.Create(result);
                }
                return result;
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
