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
    /// Opaque handle to a image object.
    /// </para>
    /// <para>
    /// Images represent multidimensional - up to 3 - arrays of data which can:
    /// be used for various purposes (e.g. attachments, textures), by binding
    /// them to a graphics or compute pipeline via descriptor sets, or by
    /// directly specifying them as parameters to certain commands.
    /// </para>
    /// </summary>
    public partial class Image
        : IDisposable
    {
        internal readonly Interop.Image handle; 
        
        internal readonly CommandCache commandCache; 
        
        private readonly Device parent; 
        
        internal AllocationCallbacks? Allocator
        {
            get
            {
                return this.parent.Allocator;
            }
        }
        
        internal Image(Interop.Image handle, Device parent, CommandCache commandCache)
        {
            this.handle = handle;
            this.parent = parent;
            this.commandCache = commandCache;
        }
        
        /// <summary>
        /// Bind device memory to an image object.
        /// </summary>
        public void BindMemory(DeviceMemory memory, DeviceSize memoryOffset)
        {
            unsafe
            {
                try
                {
                    Result commandResult;
                    Interop.DeviceMemory marshalledMemory = memory.Pack();
                    commandResult = Interop.Commands.vkBindImageMemory(this.parent.handle, this.handle, marshalledMemory, memoryOffset);
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
                    Interop.Commands.vkGetImageMemoryRequirements(this.parent.handle, this.handle, &result);
                    return result;
                }
                finally
                {
                    Interop.HeapUtil.FreeLog();
                }
            }
        }
        
        /// <summary>
        /// Query the memory requirements for a sparse image.
        /// </summary>
        public SparseImageMemoryRequirements[] GetSparseMemoryRequirements()
        {
            unsafe
            {
                try
                {
                    SparseImageMemoryRequirements[] result = default(SparseImageMemoryRequirements[]);
                    uint sparseMemoryRequirementCount;
                    SparseImageMemoryRequirements* marshalledSparseMemoryRequirements = null;
                    Interop.Commands.vkGetImageSparseMemoryRequirements(this.parent.handle, this.handle, &sparseMemoryRequirementCount, null);
                    marshalledSparseMemoryRequirements = (SparseImageMemoryRequirements*)Interop.HeapUtil.Allocate<SparseImageMemoryRequirements>((uint)sparseMemoryRequirementCount);
                    Interop.Commands.vkGetImageSparseMemoryRequirements(this.parent.handle, this.handle, &sparseMemoryRequirementCount, marshalledSparseMemoryRequirements);
                    result = new SparseImageMemoryRequirements[(uint)sparseMemoryRequirementCount];
                    for(int index = 0; index < (uint)sparseMemoryRequirementCount; index++)
                    {
                    	result[index] = marshalledSparseMemoryRequirements[index];
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
        /// Destroy an image object.
        /// </summary>
        public void Destroy()
        {
            unsafe
            {
                try
                {
                    Interop.AllocationCallbacks marshalledAllocator;
                    if(this.parent.Allocator != null) marshalledAllocator = this.parent.Allocator.Value.Pack();
                    Interop.Commands.vkDestroyImage(this.parent.handle, this.handle, this.parent.Allocator == null ? null : &marshalledAllocator);
                }
                finally
                {
                    Interop.HeapUtil.FreeLog();
                }
            }
        }
        
        /// <summary>
        /// Retrieve information about an image subresource.
        /// </summary>
        public SubresourceLayout GetSubresourceLayout(ImageSubresource subresource)
        {
            unsafe
            {
                try
                {
                    SubresourceLayout result = default(SubresourceLayout);
                    Interop.Commands.vkGetImageSubresourceLayout(this.parent.handle, this.handle, &subresource, &result);
                    return result;
                }
                finally
                {
                    Interop.HeapUtil.FreeLog();
                }
            }
        }
        
        internal Interop.Image Pack()
        {
            return this.handle;
        }
        
        /// <summary>
        /// The interop handle for this Image.
        /// </summary>
        public Interop.Image RawHandle => this.handle;
        
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
