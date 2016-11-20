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
    /// Opaque handle to a query pool object.
    /// </para>
    /// <para>
    /// Queries are managed using _query pool_ objects. Each query pool is a
    /// collection of a specific number of queries of a particular type.
    /// </para>
    /// </summary>
    public partial class QueryPool
        : IDisposable
    {
        internal readonly Interop.QueryPool handle; 
        
        internal readonly CommandCache commandCache; 
        
        private readonly Device parent; 
        
        internal AllocationCallbacks? Allocator
        {
            get
            {
                return this.parent.Allocator;
            }
        }
        
        internal QueryPool(Interop.QueryPool handle, Device parent, CommandCache commandCache)
        {
            this.handle = handle;
            this.parent = parent;
            this.commandCache = commandCache;
        }
        
        /// <summary>
        /// Destroy a query pool object.
        /// </summary>
        public void Destroy()
        {
            unsafe
            {
                try
                {
                    Interop.AllocationCallbacks marshalledAllocator;
                    if(this.parent.Allocator != null) marshalledAllocator = this.parent.Allocator.Value.Pack();
                    Interop.Commands.vkDestroyQueryPool(this.parent.handle, this.handle, this.parent.Allocator == null ? null : &marshalledAllocator);
                }
                finally
                {
                    Interop.HeapUtil.FreeLog();
                }
            }
        }
        
        /// <summary>
        /// Copy results of queries in a query pool to a host memory region.
        /// </summary>
        public void GetResults(uint firstQuery, uint queryCount, ArrayProxy<byte> data, DeviceSize stride, QueryResultFlags flags)
        {
            unsafe
            {
                try
                {
                    Result commandResult;
                    GCHandle dataHandle = default(GCHandle);
                    byte* marshalledData = null;
                    if (data.Contents != ProxyContents.Null)
                    {
                        if(data.Contents == ProxyContents.Single)
                        {
                            byte* dataPointer = stackalloc byte[1];
                            *dataPointer = data.GetSingleValue();
                            marshalledData = dataPointer;
                        }
                        else
                        {
                            var arrayValue = data.GetArrayValue(); 
                            dataHandle = GCHandle.Alloc(arrayValue.Array); 
                            marshalledData = (byte*)(dataHandle.AddrOfPinnedObject() + (int)(MemUtil.SizeOf<byte>() * arrayValue.Offset)).ToPointer(); 
                        }
                    }
                    else
                    {
                        marshalledData = null;
                    }
                    commandResult = Interop.Commands.vkGetQueryPoolResults(this.parent.handle, this.handle, firstQuery, queryCount, (Size)(data.Length), marshalledData, stride, flags);
                    if (SharpVkException.IsError(commandResult))
                    {
                        throw SharpVkException.Create(commandResult);
                    }
                    if (dataHandle.IsAllocated) dataHandle.Free();
                }
                finally
                {
                    Interop.HeapUtil.FreeLog();
                }
            }
        }
        
        internal Interop.QueryPool Pack()
        {
            return this.handle;
        }
        
        /// <summary>
        /// The interop handle for this QueryPool.
        /// </summary>
        public Interop.QueryPool RawHandle => this.handle;
        
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
