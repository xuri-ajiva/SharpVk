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
    /// Opaque handle to a image object.
    /// </summary>
    public partial class Image
        : IDisposable
    {
        internal readonly SharpVk.Interop.Image Handle; 
        
        internal readonly CommandCache commandCache; 
        
        internal readonly Device parent; 
        
        internal Image(Device parent, SharpVk.Interop.Image handle)
        {
            Handle = handle;
            this.parent = parent;
            commandCache = parent.commandCache;
        }
        
        /// <summary>
        /// The raw handle for this instance.
        /// </summary>
        public SharpVk.Interop.Image RawHandle => Handle;
        
        /// <summary>
        /// Bind device memory to an image object.
        /// </summary>
        /// <param name="memory">
        /// </param>
        /// <param name="memoryOffset">
        /// </param>
        public unsafe void BindMemory(DeviceMemory memory, ulong memoryOffset)
        {
            try
            {
                Interop.VkImageBindMemoryDelegate commandDelegate = commandCache.Cache.vkBindImageMemory;
                Result methodResult = commandDelegate(parent.Handle, Handle, memory?.Handle ?? default, memoryOffset);
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
        /// Returns the memory requirements for specified Vulkan object.
        /// </summary>
        public unsafe MemoryRequirements GetMemoryRequirements()
        {
            try
            {
                MemoryRequirements result = default;
                MemoryRequirements marshalledMemoryRequirements = default;
                Interop.VkImageGetMemoryRequirementsDelegate commandDelegate = commandCache.Cache.vkGetImageMemoryRequirements;
                commandDelegate(parent.Handle, Handle, &marshalledMemoryRequirements);
                result = marshalledMemoryRequirements;
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Query the memory requirements for a sparse image.
        /// </summary>
        public unsafe SparseImageMemoryRequirements[] GetSparseMemoryRequirements()
        {
            try
            {
                SparseImageMemoryRequirements[] result = default;
                uint marshalledSparseMemoryRequirementCount = default;
                SparseImageMemoryRequirements* marshalledSparseMemoryRequirements = default;
                Interop.VkImageGetSparseMemoryRequirementsDelegate commandDelegate = commandCache.Cache.vkGetImageSparseMemoryRequirements;
                commandDelegate(parent.Handle, Handle, &marshalledSparseMemoryRequirementCount, marshalledSparseMemoryRequirements);
                marshalledSparseMemoryRequirements = (SparseImageMemoryRequirements*)(Interop.HeapUtil.Allocate<SparseImageMemoryRequirements>((uint)(marshalledSparseMemoryRequirementCount)));
                commandDelegate(parent.Handle, Handle, &marshalledSparseMemoryRequirementCount, marshalledSparseMemoryRequirements);
                if (marshalledSparseMemoryRequirements != null)
                {
                    var fieldPointer = new SparseImageMemoryRequirements[(uint)(marshalledSparseMemoryRequirementCount)];
                    for(int index = 0; index < (uint)(marshalledSparseMemoryRequirementCount); index++)
                    {
                        fieldPointer[index] = marshalledSparseMemoryRequirements[index];
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
        /// Destroy an image object.
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
                Interop.VkImageDestroyDelegate commandDelegate = commandCache.Cache.vkDestroyImage;
                commandDelegate(parent.Handle, Handle, marshalledAllocator);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Retrieve information about an image subresource.
        /// </summary>
        /// <param name="subresource">
        /// </param>
        public unsafe SubresourceLayout GetSubresourceLayout(ImageSubresource subresource)
        {
            try
            {
                SubresourceLayout result = default;
                ImageSubresource* marshalledSubresource = default;
                SubresourceLayout marshalledLayout = default;
                marshalledSubresource = (ImageSubresource*)(Interop.HeapUtil.Allocate<ImageSubresource>());
                *marshalledSubresource = subresource;
                Interop.VkImageGetSubresourceLayoutDelegate commandDelegate = commandCache.Cache.vkGetImageSubresourceLayout;
                commandDelegate(parent.Handle, Handle, marshalledSubresource, &marshalledLayout);
                result = marshalledLayout;
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
