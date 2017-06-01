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
    /// 
    /// </summary>
    public partial class QueryPool
    {
        internal readonly SharpVk.Interop.QueryPool handle; 
        
        internal QueryPool(SharpVk.Interop.QueryPool handle)
        {
            this.handle = handle;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public unsafe void Destroy(AllocationCallbacks? allocator)
        {
            try
            {
                Interop.AllocationCallbacks* marshalledAllocator = default(Interop.AllocationCallbacks*);
                if (allocator != null)
                {
                    marshalledAllocator = (Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<Interop.AllocationCallbacks>());
                    allocator.Value.MarshalTo(marshalledAllocator);
                }
                Interop.Commands.vkDestroyQueryPool(default(Interop.Device), this.handle, marshalledAllocator);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        public unsafe void GetResults(uint firstQuery, uint queryCount, byte[] data, DeviceSize stride, QueryResultFlags flags)
        {
            try
            {
                uint marshalledFirstQuery = default(uint);
                uint marshalledQueryCount = default(uint);
                HostSize marshalledDataSize = default(HostSize);
                byte* marshalledData = default(byte*);
                DeviceSize marshalledStride = default(DeviceSize);
                QueryResultFlags marshalledFlags = default(QueryResultFlags);
                marshalledFirstQuery = firstQuery;
                marshalledQueryCount = queryCount;
                marshalledDataSize = (HostSize)(data?.Length ?? 0);
                if (data != null)
                {
                    var fieldPointer = (byte*)(Interop.HeapUtil.AllocateAndClear<byte>(data.Length).ToPointer());
                    for(int index = 0; index < data.Length; index++)
                    {
                        fieldPointer[index] = data[index];
                    }
                    marshalledData = fieldPointer;
                }
                else
                {
                    marshalledData = null;
                }
                marshalledStride = stride;
                marshalledFlags = flags;
                Interop.Commands.vkGetQueryPoolResults(default(Interop.Device), this.handle, marshalledFirstQuery, marshalledQueryCount, marshalledDataSize, marshalledData, marshalledStride, marshalledFlags);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
    }
}
