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
    public partial class PipelineCache
    {
        internal readonly SharpVk.Interop.PipelineCache handle; 
        
        internal PipelineCache(SharpVk.Interop.PipelineCache handle)
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
                Interop.Commands.vkDestroyPipelineCache(default(Interop.Device), this.handle, marshalledAllocator);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        public unsafe byte[] GetData()
        {
            try
            {
                byte[] result = default(byte[]);
                HostSize dataSize = default(HostSize);
                byte marshalledData = default(byte);
                Interop.Commands.vkGetPipelineCacheData(default(Interop.Device), this.handle, &dataSize, &marshalledData);
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
        public unsafe void MergePipelineCaches(PipelineCache[] sourceCaches)
        {
            try
            {
                uint marshalledSourceCacheCount = default(uint);
                Interop.PipelineCache* marshalledSourceCaches = default(Interop.PipelineCache*);
                marshalledSourceCacheCount = (uint)(sourceCaches?.Length ?? 0);
                if (sourceCaches != null)
                {
                    var fieldPointer = (Interop.PipelineCache*)(Interop.HeapUtil.AllocateAndClear<Interop.PipelineCache>(sourceCaches.Length).ToPointer());
                    for(int index = 0; index < sourceCaches.Length; index++)
                    {
                        fieldPointer[index] = sourceCaches[index].handle;
                    }
                    marshalledSourceCaches = fieldPointer;
                }
                else
                {
                    marshalledSourceCaches = null;
                }
                Interop.Commands.vkMergePipelineCaches(default(Interop.Device), this.handle, marshalledSourceCacheCount, marshalledSourceCaches);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        public unsafe Pipeline[] CreateGraphicsPipelines(GraphicsPipelineCreateInfo[] createInfos, AllocationCallbacks? allocator)
        {
            try
            {
                Pipeline[] result = default(Pipeline[]);
                uint marshalledCreateInfoCount = default(uint);
                Interop.GraphicsPipelineCreateInfo* marshalledCreateInfos = default(Interop.GraphicsPipelineCreateInfo*);
                Interop.AllocationCallbacks* marshalledAllocator = default(Interop.AllocationCallbacks*);
                Interop.Pipeline marshalledPipelines = default(Interop.Pipeline);
                marshalledCreateInfoCount = (uint)(createInfos?.Length ?? 0);
                if (createInfos != null)
                {
                    var fieldPointer = (Interop.GraphicsPipelineCreateInfo*)(Interop.HeapUtil.AllocateAndClear<Interop.GraphicsPipelineCreateInfo>(createInfos.Length).ToPointer());
                    for(int index = 0; index < createInfos.Length; index++)
                    {
                        createInfos[index].MarshalTo(&fieldPointer[index]);
                    }
                    marshalledCreateInfos = fieldPointer;
                }
                else
                {
                    marshalledCreateInfos = null;
                }
                if (allocator != null)
                {
                    marshalledAllocator = (Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<Interop.AllocationCallbacks>());
                    allocator.Value.MarshalTo(marshalledAllocator);
                }
                Interop.Commands.vkCreateGraphicsPipelines(default(Interop.Device), this.handle, marshalledCreateInfoCount, marshalledCreateInfos, marshalledAllocator, &marshalledPipelines);
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
        public unsafe Pipeline[] CreateComputePipelines(ComputePipelineCreateInfo[] createInfos, AllocationCallbacks? allocator)
        {
            try
            {
                Pipeline[] result = default(Pipeline[]);
                uint marshalledCreateInfoCount = default(uint);
                Interop.ComputePipelineCreateInfo* marshalledCreateInfos = default(Interop.ComputePipelineCreateInfo*);
                Interop.AllocationCallbacks* marshalledAllocator = default(Interop.AllocationCallbacks*);
                Interop.Pipeline marshalledPipelines = default(Interop.Pipeline);
                marshalledCreateInfoCount = (uint)(createInfos?.Length ?? 0);
                if (createInfos != null)
                {
                    var fieldPointer = (Interop.ComputePipelineCreateInfo*)(Interop.HeapUtil.AllocateAndClear<Interop.ComputePipelineCreateInfo>(createInfos.Length).ToPointer());
                    for(int index = 0; index < createInfos.Length; index++)
                    {
                        createInfos[index].MarshalTo(&fieldPointer[index]);
                    }
                    marshalledCreateInfos = fieldPointer;
                }
                else
                {
                    marshalledCreateInfos = null;
                }
                if (allocator != null)
                {
                    marshalledAllocator = (Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<Interop.AllocationCallbacks>());
                    allocator.Value.MarshalTo(marshalledAllocator);
                }
                Interop.Commands.vkCreateComputePipelines(default(Interop.Device), this.handle, marshalledCreateInfoCount, marshalledCreateInfos, marshalledAllocator, &marshalledPipelines);
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
    }
}
