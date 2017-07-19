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

namespace SharpVk
{
    /// <summary>
    /// Opaque handle to a descriptor pool object.
    /// </summary>
    public partial class DescriptorPool
    {
        internal readonly SharpVk.Interop.DescriptorPool handle; 
        
        internal readonly CommandCache commandCache; 
        
        internal readonly SharpVk.Device parent; 
        
        internal DescriptorPool(SharpVk.Device parent, SharpVk.Interop.DescriptorPool handle)
        {
            this.handle = handle;
            this.parent = parent;
            this.commandCache = parent.commandCache;
        }
        
        /// <summary>
        /// Destroy a descriptor pool object.
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
                Interop.Commands.vkDestroyDescriptorPool(this.parent.handle, this.handle, marshalledAllocator);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Resets a descriptor pool object.
        /// </summary>
        public unsafe void Reset(SharpVk.DescriptorPoolResetFlags? flags = default(SharpVk.DescriptorPoolResetFlags?))
        {
            try
            {
                SharpVk.DescriptorPoolResetFlags marshalledFlags = default(SharpVk.DescriptorPoolResetFlags);
                if (flags != null)
                {
                    marshalledFlags = flags.Value;
                }
                else
                {
                    marshalledFlags = default(SharpVk.DescriptorPoolResetFlags);
                }
                Result methodResult = Interop.Commands.vkResetDescriptorPool(this.parent.handle, this.handle, marshalledFlags);
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
        public unsafe void FreeDescriptorSets(SharpVk.DescriptorSet[] descriptorSets)
        {
            try
            {
                SharpVk.Interop.DescriptorSet* marshalledDescriptorSets = default(SharpVk.Interop.DescriptorSet*);
                if (descriptorSets != null)
                {
                    var fieldPointer = (SharpVk.Interop.DescriptorSet*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.DescriptorSet>(descriptorSets.Length).ToPointer());
                    for(int index = 0; index < (uint)(descriptorSets.Length); index++)
                    {
                        fieldPointer[index] = descriptorSets[index]?.handle ?? default(SharpVk.Interop.DescriptorSet);
                    }
                    marshalledDescriptorSets = fieldPointer;
                }
                else
                {
                    marshalledDescriptorSets = null;
                }
                Result methodResult = Interop.Commands.vkFreeDescriptorSets(this.parent.handle, this.handle, (uint)(descriptorSets?.Length ?? 0), marshalledDescriptorSets);
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
