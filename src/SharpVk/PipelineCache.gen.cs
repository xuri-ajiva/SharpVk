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
        
        internal unsafe void Destroy(AllocationCallbacks allocator)
        {
            Interop.AllocationCallbacks* marshalledAllocator;
            marshalledAllocator = (Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<Interop.AllocationCallbacks>());
            allocator.MarshalTo(marshalledAllocator);
        }
        
        internal unsafe void GetData()
        {
            HostSize dataSize;
        }
        
        internal unsafe void MergePipelineCaches(PipelineCache[] sourceCaches)
        {
            uint marshalledSourceCacheCount;
            marshalledSourceCacheCount = (uint)(sourceCaches?.Length ?? 0);
            Interop.PipelineCache* marshalledSourceCaches;
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
        }
        
        internal unsafe void CreateGraphicsPipelines(GraphicsPipelineCreateInfo[] createInfos, AllocationCallbacks allocator)
        {
            uint marshalledCreateInfoCount;
            marshalledCreateInfoCount = (uint)(createInfos?.Length ?? 0);
            Interop.GraphicsPipelineCreateInfo* marshalledCreateInfos;
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
            Interop.AllocationCallbacks* marshalledAllocator;
            marshalledAllocator = (Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<Interop.AllocationCallbacks>());
            allocator.MarshalTo(marshalledAllocator);
        }
        
        internal unsafe void CreateComputePipelines(ComputePipelineCreateInfo[] createInfos, AllocationCallbacks allocator)
        {
            uint marshalledCreateInfoCount;
            marshalledCreateInfoCount = (uint)(createInfos?.Length ?? 0);
            Interop.ComputePipelineCreateInfo* marshalledCreateInfos;
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
            Interop.AllocationCallbacks* marshalledAllocator;
            marshalledAllocator = (Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<Interop.AllocationCallbacks>());
            allocator.MarshalTo(marshalledAllocator);
        }
    }
}
