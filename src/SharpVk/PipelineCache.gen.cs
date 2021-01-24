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
    /// Opaque handle to a pipeline cache object.
    /// </summary>
    public class PipelineCache
        : IDisposable
    {
        internal readonly SharpVk.Interop.PipelineCache Handle; 
        
        internal readonly CommandCache commandCache; 
        
        internal readonly Device parent; 
        
        internal PipelineCache(Device parent, SharpVk.Interop.PipelineCache handle)
        {
            Handle = handle;
            this.parent = parent;
            commandCache = parent.commandCache;
        }
        
        /// <summary>
        /// The raw handle for this instance.
        /// </summary>
        public SharpVk.Interop.PipelineCache RawHandle => Handle;
        
        /// <summary>
        /// Destroy a pipeline cache object.
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
                Interop.VkPipelineCacheDestroyDelegate commandDelegate = commandCache.Cache.vkDestroyPipelineCache;
                commandDelegate(parent.Handle, Handle, marshalledAllocator);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Get the data store from a pipeline cache.
        /// </summary>
        public unsafe byte[] GetData()
        {
            try
            {
                byte[] result = default;
                HostSize marshalledDataSize = default;
                byte* marshalledData = default;
                Interop.VkPipelineCacheGetDataDelegate commandDelegate = commandCache.Cache.vkGetPipelineCacheData;
                Result methodResult = commandDelegate(parent.Handle, Handle, &marshalledDataSize, marshalledData);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                marshalledData = (byte*)(Interop.HeapUtil.Allocate<byte>((uint)(marshalledDataSize)));
                commandDelegate(parent.Handle, Handle, &marshalledDataSize, marshalledData);
                if (marshalledData != null)
                {
                    var fieldPointer = new byte[(uint)(marshalledDataSize)];
                    for(int index = 0; index < (uint)(marshalledDataSize); index++)
                    {
                        fieldPointer[index] = marshalledData[index];
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
        /// Combine the data stores of pipeline caches.
        /// </summary>
        /// <param name="sourceCaches">
        /// </param>
        public unsafe void MergePipelineCaches(ArrayProxy<PipelineCache>? sourceCaches)
        {
            try
            {
                SharpVk.Interop.PipelineCache* marshalledSourceCaches = default;
                if (sourceCaches.IsNull())
                {
                    marshalledSourceCaches = null;
                }
                else
                {
                    if (sourceCaches.Value.Contents == ProxyContents.Single)
                    {
                        marshalledSourceCaches = (SharpVk.Interop.PipelineCache*)(Interop.HeapUtil.Allocate<SharpVk.Interop.PipelineCache>());
                        *(SharpVk.Interop.PipelineCache*)(marshalledSourceCaches) = sourceCaches.Value.GetSingleValue()?.Handle ?? default;
                    }
                    else
                    {
                        var fieldPointer = (SharpVk.Interop.PipelineCache*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.PipelineCache>(Interop.HeapUtil.GetLength(sourceCaches.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(sourceCaches.Value)); index++)
                        {
                            fieldPointer[index] = sourceCaches.Value[index]?.Handle ?? default;
                        }
                        marshalledSourceCaches = fieldPointer;
                    }
                }
                Interop.VkPipelineCacheMergePipelineCachesDelegate commandDelegate = commandCache.Cache.vkMergePipelineCaches;
                Result methodResult = commandDelegate(parent.Handle, Handle, (uint)(Interop.HeapUtil.GetLength(sourceCaches)), marshalledSourceCaches);
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
