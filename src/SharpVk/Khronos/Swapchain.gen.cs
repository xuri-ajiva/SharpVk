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

namespace SharpVk.Khronos
{
    /// <summary>
    /// 
    /// </summary>
    public partial class Swapchain
    {
        internal readonly SharpVk.Interop.Khronos.Swapchain handle; 
        
        private readonly SharpVk.Interop.Khronos.Surface parent; 
        
        internal Swapchain(SharpVk.Interop.Khronos.Surface parent, SharpVk.Interop.Khronos.Swapchain handle)
        {
            this.handle = handle;
            this.parent = parent;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public unsafe void Destroy(SharpVk.AllocationCallbacks? allocator = default(SharpVk.AllocationCallbacks?))
        {
            try
            {
                SharpVk.Interop.AllocationCallbacks* marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                if (allocator != null)
                {
                    marshalledAllocator = (SharpVk.Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<SharpVk.Interop.AllocationCallbacks>());
                    allocator.Value.MarshalTo(marshalledAllocator);
                }
                else
                {
                    marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                }
                Interop.Commands.vkDestroySwapchainKHR(default(Interop.Device), this.handle, marshalledAllocator);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        public unsafe SharpVk.Image[] GetImages()
        {
            try
            {
                SharpVk.Image[] result = default(SharpVk.Image[]);
                uint swapchainImageCount = default(uint);
                SharpVk.Interop.Image* marshalledSwapchainImages = default(SharpVk.Interop.Image*);
                Result methodResult = Interop.Commands.vkGetSwapchainImagesKHR(default(Interop.Device), this.handle, &swapchainImageCount, marshalledSwapchainImages);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                marshalledSwapchainImages = (SharpVk.Interop.Image*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Image>((uint)(swapchainImageCount)));
                Interop.Commands.vkGetSwapchainImagesKHR(default(Interop.Device), this.handle, &swapchainImageCount, marshalledSwapchainImages);
                if (marshalledSwapchainImages != null)
                {
                    var fieldPointer = new SharpVk.Image[(uint)(swapchainImageCount)];
                    for(int index = 0; index < (uint)(swapchainImageCount); index++)
                    {
                        fieldPointer[index] = new SharpVk.Image(default(Interop.Device), marshalledSwapchainImages[index]);
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
        /// 
        /// </summary>
        public unsafe uint AcquireNextImage(ulong timeout, SharpVk.Semaphore semaphore, SharpVk.Fence fence)
        {
            try
            {
                uint result = default(uint);
                uint marshalledImageIndex = default(uint);
                Result methodResult = Interop.Commands.vkAcquireNextImageKHR(default(Interop.Device), this.handle, timeout, semaphore?.handle ?? default(SharpVk.Interop.Semaphore), fence?.handle ?? default(SharpVk.Interop.Fence), &marshalledImageIndex);
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
        /// 
        /// </summary>
        public unsafe void GetStatus()
        {
            try
            {
                Result methodResult = Interop.Commands.vkGetSwapchainStatusKHR(default(Interop.Device), this.handle);
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
    }
}
