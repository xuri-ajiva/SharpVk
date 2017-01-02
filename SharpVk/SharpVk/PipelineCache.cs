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
    /// <para>
    /// Opaque handle to a pipeline cache object.
    /// </para>
    /// <para>
    /// Pipeline cache objects allow the result of pipeline construction to be
    /// reused between pipelines and between runs of an application. Reuse
    /// between pipelines is achieved by passing the same pipeline cache object
    /// when creating multiple related pipelines. Reuse across runs of an
    /// application is achieved by retrieving pipeline cache contents in one
    /// run of an application, saving the contents, and using them to
    /// preinitialize a pipeline cache on a subsequent run. The contents of the
    /// pipeline cache objects are managed by the implementation. Applications
    /// can: manage the host memory consumed by a pipeline cache object and
    /// control the amount of data retrieved from a pipeline cache object.
    /// </para>
    /// </summary>
    public partial class PipelineCache
        : IDisposable
    {
        internal readonly Interop.PipelineCache handle; 
        
        internal readonly CommandCache commandCache; 
        
        private readonly Device parent; 
        
        internal AllocationCallbacks? Allocator
        {
            get
            {
                return this.parent.Allocator;
            }
        }
        
        internal PipelineCache(Interop.PipelineCache handle, Device parent, CommandCache commandCache)
        {
            this.handle = handle;
            this.parent = parent;
            this.commandCache = commandCache;
        }
        
        /// <summary>
        /// Destroy a pipeline cache object.
        /// </summary>
        public void Destroy()
        {
            unsafe
            {
                try
                {
                    Interop.AllocationCallbacks marshalledAllocator;
                    this.parent.Allocator?.MarshalTo(&marshalledAllocator);
                    Interop.Commands.vkDestroyPipelineCache(this.parent.handle, this.handle, this.parent.Allocator == null ? null : &marshalledAllocator);
                }
                finally
                {
                    Interop.HeapUtil.FreeLog();
                }
            }
        }
        
        /// <summary>
        /// Get the data store from a pipeline cache.
        /// </summary>
        public byte[] GetData()
        {
            unsafe
            {
                try
                {
                    byte[] result = default(byte[]);
                    Result commandResult;
                    Size dataSize;
                    byte* marshalledData = null;
                    commandResult = Interop.Commands.vkGetPipelineCacheData(this.parent.handle, this.handle, &dataSize, null);
                    if (SharpVkException.IsError(commandResult))
                    {
                        throw SharpVkException.Create(commandResult);
                    }
                    marshalledData = (byte*)Interop.HeapUtil.Allocate<byte>((uint)dataSize);
                    commandResult = Interop.Commands.vkGetPipelineCacheData(this.parent.handle, this.handle, &dataSize, marshalledData);
                    if (SharpVkException.IsError(commandResult))
                    {
                        throw SharpVkException.Create(commandResult);
                    }
                    result = new byte[(uint)dataSize];
                    for(int index = 0; index < (uint)dataSize; index++)
                    {
                    	result[index] = marshalledData[index];
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
        /// Combine the data stores of pipeline caches.
        /// </summary>
        public void MergePipelineCaches(ArrayProxy<PipelineCache> sourceCaches)
        {
            unsafe
            {
                try
                {
                    Result commandResult;
                    Interop.PipelineCache* marshalledSourceCaches = null;
                    if (sourceCaches.Contents != ProxyContents.Null)
                    {
                        Interop.PipelineCache* arrayPointer = stackalloc Interop.PipelineCache[sourceCaches.Length];
                        if(sourceCaches.Contents == ProxyContents.Single)
                        {
                            sourceCaches.GetSingleValue().MarshalTo(arrayPointer);
                        }
                        else
                        {
                            var arrayValue  = sourceCaches.GetArrayValue();
                            for (int index = 0; index < sourceCaches.Length; index++)
                            {
                                arrayValue.Array[arrayValue.Offset + index].MarshalTo(&arrayPointer[index]);
                            }
                        }
                        marshalledSourceCaches = arrayPointer;
                    }
                    else
                    {
                        marshalledSourceCaches = null;
                    }
                    commandResult = Interop.Commands.vkMergePipelineCaches(this.parent.handle, this.handle, (uint)(sourceCaches.Length), marshalledSourceCaches);
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
        
        internal unsafe void MarshalTo(Interop.PipelineCache* pointer)
        {
            *pointer = this.handle;
        }
        
        /// <summary>
        /// The interop handle for this PipelineCache.
        /// </summary>
        public Interop.PipelineCache RawHandle => this.handle;
        
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
