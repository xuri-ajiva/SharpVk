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
    /// Opaque handle to a descriptor pool object.
    /// </para>
    /// <para>
    /// A _descriptor pool_ maintains a pool of descriptors, from which
    /// descriptor sets are allocated. Descriptor pools are externally
    /// synchronized, meaning that the application must: not allocate and/or
    /// free descriptor sets from the same pool in multiple threads
    /// simultaneously.
    /// </para>
    /// </summary>
    public class DescriptorPool
        : IDisposable
    {
        internal readonly Interop.DescriptorPool handle; 
        
        internal readonly CommandCache commandCache; 
        
        private readonly Device parent; 
        
        internal AllocationCallbacks? Allocator
        {
            get
            {
                return this.parent.Allocator;
            }
        }
        
        internal DescriptorPool(Interop.DescriptorPool handle, Device parent, CommandCache commandCache)
        {
            this.handle = handle;
            this.parent = parent;
            this.commandCache = commandCache;
        }
        
        /// <summary>
        /// Destroy a descriptor pool object.
        /// </summary>
        public void Destroy()
        {
            unsafe
            {
                try
                {
                    Interop.AllocationCallbacks marshalledAllocator;
                    if(this.parent.Allocator != null) marshalledAllocator = this.parent.Allocator.Value.Pack();
                    Interop.Commands.vkDestroyDescriptorPool(this.parent.handle, this.handle, this.parent.Allocator == null ? null : &marshalledAllocator);
                }
                finally
                {
                    Interop.HeapUtil.FreeLog();
                }
            }
        }
        
        /// <summary>
        /// Resets a descriptor pool object.
        /// </summary>
        public void Reset(DescriptorPoolResetFlags flags)
        {
            unsafe
            {
                try
                {
                    Result commandResult;
                    commandResult = Interop.Commands.vkResetDescriptorPool(this.parent.handle, this.handle, flags);
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
        /// Free one or more descriptor sets.
        /// </summary>
        public void FreeDescriptorSets(ArrayProxy<DescriptorSet> descriptorSets)
        {
            unsafe
            {
                try
                {
                    Result commandResult;
                    Interop.DescriptorSet* marshalledDescriptorSets = null;
                    if (descriptorSets.Contents != ProxyContents.Null)
                    {
                        Interop.DescriptorSet* arrayPointer = stackalloc Interop.DescriptorSet[descriptorSets.Length];
                        if(descriptorSets.Contents == ProxyContents.Single)
                        {
                            *arrayPointer = descriptorSets.GetSingleValue().Pack();
                        }
                        else
                        {
                            var arrayValue  = descriptorSets.GetArrayValue();
                            for (int index = 0; index < descriptorSets.Length; index++)
                            {
                                arrayPointer[index] = arrayValue.Array[arrayValue.Offset + index].Pack();
                            }
                        }
                        marshalledDescriptorSets = arrayPointer;
                    }
                    else
                    {
                        marshalledDescriptorSets = null;
                    }
                    commandResult = Interop.Commands.vkFreeDescriptorSets(this.parent.handle, this.handle, (uint)(descriptorSets.Length), marshalledDescriptorSets);
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
        
        internal Interop.DescriptorPool Pack()
        {
            return this.handle;
        }
        
        /// <summary>
        /// The interop handle for this DescriptorPool.
        /// </summary>
        public Interop.DescriptorPool RawHandle => this.handle;
        
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
