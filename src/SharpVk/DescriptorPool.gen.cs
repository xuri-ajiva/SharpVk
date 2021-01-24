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
    /// Opaque handle to a descriptor pool object.
    /// </summary>
    public partial class DescriptorPool
        : IDisposable
    {
        internal readonly SharpVk.Interop.DescriptorPool Handle; 
        
        internal readonly CommandCache commandCache; 
        
        internal readonly Device parent; 
        
        internal DescriptorPool(Device parent, SharpVk.Interop.DescriptorPool handle)
        {
            Handle = handle;
            this.parent = parent;
            commandCache = parent.commandCache;
        }
        
        /// <summary>
        /// The raw handle for this instance.
        /// </summary>
        public SharpVk.Interop.DescriptorPool RawHandle => Handle;
        
        /// <summary>
        /// Destroy a descriptor pool object.
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
                Interop.VkDescriptorPoolDestroyDelegate commandDelegate = commandCache.Cache.vkDestroyDescriptorPool;
                commandDelegate(parent.Handle, Handle, marshalledAllocator);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Resets a descriptor pool object.
        /// </summary>
        /// <param name="flags">
        /// </param>
        public unsafe void Reset(DescriptorPoolResetFlags? flags = default)
        {
            try
            {
                DescriptorPoolResetFlags marshalledFlags = default;
                if (flags != null)
                {
                    marshalledFlags = flags.Value;
                }
                else
                {
                    marshalledFlags = default;
                }
                Interop.VkDescriptorPoolResetDelegate commandDelegate = commandCache.Cache.vkResetDescriptorPool;
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
        /// Free one or more descriptor sets.
        /// </summary>
        /// <param name="descriptorSets">
        /// </param>
        public unsafe void FreeDescriptorSets(ArrayProxy<DescriptorSet>? descriptorSets)
        {
            try
            {
                SharpVk.Interop.DescriptorSet* marshalledDescriptorSets = default;
                if (descriptorSets.IsNull())
                {
                    marshalledDescriptorSets = null;
                }
                else
                {
                    if (descriptorSets.Value.Contents == ProxyContents.Single)
                    {
                        marshalledDescriptorSets = (SharpVk.Interop.DescriptorSet*)(Interop.HeapUtil.Allocate<SharpVk.Interop.DescriptorSet>());
                        *(SharpVk.Interop.DescriptorSet*)(marshalledDescriptorSets) = descriptorSets.Value.GetSingleValue()?.Handle ?? default;
                    }
                    else
                    {
                        var fieldPointer = (SharpVk.Interop.DescriptorSet*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.DescriptorSet>(Interop.HeapUtil.GetLength(descriptorSets.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(descriptorSets.Value)); index++)
                        {
                            fieldPointer[index] = descriptorSets.Value[index]?.Handle ?? default;
                        }
                        marshalledDescriptorSets = fieldPointer;
                    }
                }
                Interop.VkDescriptorPoolFreeDescriptorSetsDelegate commandDelegate = commandCache.Cache.vkFreeDescriptorSets;
                Result methodResult = commandDelegate(parent.Handle, Handle, (uint)(Interop.HeapUtil.GetLength(descriptorSets)), marshalledDescriptorSets);
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
        /// Destroys the handles and releases any unmanaged resources
        /// associated with it.
        /// </summary>
        public void Dispose()
        {
            Destroy();
        }
    }
}
