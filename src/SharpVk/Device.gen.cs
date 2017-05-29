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
    public partial class Device
    {
        internal readonly SharpVk.Interop.Device handle; 
        
        internal Device(SharpVk.Interop.Device handle)
        {
            this.handle = handle;
        }
        
        internal unsafe void GetProcedureAddress(string name)
        {
            byte* marshalledName;
            marshalledName = Interop.HeapUtil.MarshalTo(name);
        }
        
        internal unsafe void Destroy(AllocationCallbacks allocator)
        {
            Interop.AllocationCallbacks* marshalledAllocator;
            marshalledAllocator = (Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<Interop.AllocationCallbacks>());
            allocator.MarshalTo(marshalledAllocator);
        }
        
        internal unsafe void GetQueue(uint queueFamilyIndex, uint queueIndex)
        {
            uint marshalledQueueFamilyIndex;
            marshalledQueueFamilyIndex = queueFamilyIndex;
            uint marshalledQueueIndex;
            marshalledQueueIndex = queueIndex;
        }
        
        internal unsafe void WaitIdle()
        {
        }
        
        internal unsafe void AllocateMemory(MemoryAllocateInfo allocateInfo, AllocationCallbacks allocator)
        {
            Interop.MemoryAllocateInfo* marshalledAllocateInfo;
            marshalledAllocateInfo = (Interop.MemoryAllocateInfo*)(Interop.HeapUtil.Allocate<Interop.MemoryAllocateInfo>());
            allocateInfo.MarshalTo(marshalledAllocateInfo);
            Interop.AllocationCallbacks* marshalledAllocator;
            marshalledAllocator = (Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<Interop.AllocationCallbacks>());
            allocator.MarshalTo(marshalledAllocator);
        }
        
        internal unsafe void FlushMappedMemoryRanges(MappedMemoryRange[] memoryRanges)
        {
            uint marshalledMemoryRangeCount;
            marshalledMemoryRangeCount = (uint)(memoryRanges?.Length ?? 0);
            Interop.MappedMemoryRange* marshalledMemoryRanges;
            if (memoryRanges != null)
            {
                var fieldPointer = (Interop.MappedMemoryRange*)(Interop.HeapUtil.AllocateAndClear<Interop.MappedMemoryRange>(memoryRanges.Length).ToPointer());
                for(int index = 0; index < memoryRanges.Length; index++)
                {
                    memoryRanges[index].MarshalTo(&fieldPointer[index]);
                }
                marshalledMemoryRanges = fieldPointer;
            }
            else
            {
                marshalledMemoryRanges = null;
            }
        }
        
        internal unsafe void InvalidateMappedMemoryRanges(MappedMemoryRange[] memoryRanges)
        {
            uint marshalledMemoryRangeCount;
            marshalledMemoryRangeCount = (uint)(memoryRanges?.Length ?? 0);
            Interop.MappedMemoryRange* marshalledMemoryRanges;
            if (memoryRanges != null)
            {
                var fieldPointer = (Interop.MappedMemoryRange*)(Interop.HeapUtil.AllocateAndClear<Interop.MappedMemoryRange>(memoryRanges.Length).ToPointer());
                for(int index = 0; index < memoryRanges.Length; index++)
                {
                    memoryRanges[index].MarshalTo(&fieldPointer[index]);
                }
                marshalledMemoryRanges = fieldPointer;
            }
            else
            {
                marshalledMemoryRanges = null;
            }
        }
        
        internal unsafe void CreateFence(FenceCreateInfo createInfo, AllocationCallbacks allocator)
        {
            Interop.FenceCreateInfo* marshalledCreateInfo;
            marshalledCreateInfo = (Interop.FenceCreateInfo*)(Interop.HeapUtil.Allocate<Interop.FenceCreateInfo>());
            createInfo.MarshalTo(marshalledCreateInfo);
            Interop.AllocationCallbacks* marshalledAllocator;
            marshalledAllocator = (Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<Interop.AllocationCallbacks>());
            allocator.MarshalTo(marshalledAllocator);
        }
        
        internal unsafe void ResetFences(Fence[] fences)
        {
            uint marshalledFenceCount;
            marshalledFenceCount = (uint)(fences?.Length ?? 0);
            Interop.Fence* marshalledFences;
            if (fences != null)
            {
                var fieldPointer = (Interop.Fence*)(Interop.HeapUtil.AllocateAndClear<Interop.Fence>(fences.Length).ToPointer());
                for(int index = 0; index < fences.Length; index++)
                {
                    fieldPointer[index] = fences[index].handle;
                }
                marshalledFences = fieldPointer;
            }
            else
            {
                marshalledFences = null;
            }
        }
        
        internal unsafe void WaitForFences(Fence[] fences, Bool32 waitAll, ulong timeout)
        {
            uint marshalledFenceCount;
            marshalledFenceCount = (uint)(fences?.Length ?? 0);
            Interop.Fence* marshalledFences;
            if (fences != null)
            {
                var fieldPointer = (Interop.Fence*)(Interop.HeapUtil.AllocateAndClear<Interop.Fence>(fences.Length).ToPointer());
                for(int index = 0; index < fences.Length; index++)
                {
                    fieldPointer[index] = fences[index].handle;
                }
                marshalledFences = fieldPointer;
            }
            else
            {
                marshalledFences = null;
            }
            Bool32 marshalledWaitAll;
            marshalledWaitAll = waitAll;
            ulong marshalledTimeout;
            marshalledTimeout = timeout;
        }
        
        internal unsafe void CreateSemaphore(SemaphoreCreateInfo createInfo, AllocationCallbacks allocator)
        {
            Interop.SemaphoreCreateInfo* marshalledCreateInfo;
            marshalledCreateInfo = (Interop.SemaphoreCreateInfo*)(Interop.HeapUtil.Allocate<Interop.SemaphoreCreateInfo>());
            createInfo.MarshalTo(marshalledCreateInfo);
            Interop.AllocationCallbacks* marshalledAllocator;
            marshalledAllocator = (Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<Interop.AllocationCallbacks>());
            allocator.MarshalTo(marshalledAllocator);
        }
        
        internal unsafe void CreateEvent(EventCreateInfo createInfo, AllocationCallbacks allocator)
        {
            Interop.EventCreateInfo* marshalledCreateInfo;
            marshalledCreateInfo = (Interop.EventCreateInfo*)(Interop.HeapUtil.Allocate<Interop.EventCreateInfo>());
            createInfo.MarshalTo(marshalledCreateInfo);
            Interop.AllocationCallbacks* marshalledAllocator;
            marshalledAllocator = (Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<Interop.AllocationCallbacks>());
            allocator.MarshalTo(marshalledAllocator);
        }
        
        internal unsafe void CreateQueryPool(QueryPoolCreateInfo createInfo, AllocationCallbacks allocator)
        {
            Interop.QueryPoolCreateInfo* marshalledCreateInfo;
            marshalledCreateInfo = (Interop.QueryPoolCreateInfo*)(Interop.HeapUtil.Allocate<Interop.QueryPoolCreateInfo>());
            createInfo.MarshalTo(marshalledCreateInfo);
            Interop.AllocationCallbacks* marshalledAllocator;
            marshalledAllocator = (Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<Interop.AllocationCallbacks>());
            allocator.MarshalTo(marshalledAllocator);
        }
        
        internal unsafe void CreateBuffer(BufferCreateInfo createInfo, AllocationCallbacks allocator)
        {
            Interop.BufferCreateInfo* marshalledCreateInfo;
            marshalledCreateInfo = (Interop.BufferCreateInfo*)(Interop.HeapUtil.Allocate<Interop.BufferCreateInfo>());
            createInfo.MarshalTo(marshalledCreateInfo);
            Interop.AllocationCallbacks* marshalledAllocator;
            marshalledAllocator = (Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<Interop.AllocationCallbacks>());
            allocator.MarshalTo(marshalledAllocator);
        }
        
        internal unsafe void CreateBufferView(BufferViewCreateInfo createInfo, AllocationCallbacks allocator)
        {
            Interop.BufferViewCreateInfo* marshalledCreateInfo;
            marshalledCreateInfo = (Interop.BufferViewCreateInfo*)(Interop.HeapUtil.Allocate<Interop.BufferViewCreateInfo>());
            createInfo.MarshalTo(marshalledCreateInfo);
            Interop.AllocationCallbacks* marshalledAllocator;
            marshalledAllocator = (Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<Interop.AllocationCallbacks>());
            allocator.MarshalTo(marshalledAllocator);
        }
        
        internal unsafe void CreateImage(ImageCreateInfo createInfo, AllocationCallbacks allocator)
        {
            Interop.ImageCreateInfo* marshalledCreateInfo;
            marshalledCreateInfo = (Interop.ImageCreateInfo*)(Interop.HeapUtil.Allocate<Interop.ImageCreateInfo>());
            createInfo.MarshalTo(marshalledCreateInfo);
            Interop.AllocationCallbacks* marshalledAllocator;
            marshalledAllocator = (Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<Interop.AllocationCallbacks>());
            allocator.MarshalTo(marshalledAllocator);
        }
        
        internal unsafe void CreateImageView(ImageViewCreateInfo createInfo, AllocationCallbacks allocator)
        {
            Interop.ImageViewCreateInfo* marshalledCreateInfo;
            marshalledCreateInfo = (Interop.ImageViewCreateInfo*)(Interop.HeapUtil.Allocate<Interop.ImageViewCreateInfo>());
            createInfo.MarshalTo(marshalledCreateInfo);
            Interop.AllocationCallbacks* marshalledAllocator;
            marshalledAllocator = (Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<Interop.AllocationCallbacks>());
            allocator.MarshalTo(marshalledAllocator);
        }
        
        internal unsafe void CreateShaderModule(ShaderModuleCreateInfo createInfo, AllocationCallbacks allocator)
        {
            Interop.ShaderModuleCreateInfo* marshalledCreateInfo;
            marshalledCreateInfo = (Interop.ShaderModuleCreateInfo*)(Interop.HeapUtil.Allocate<Interop.ShaderModuleCreateInfo>());
            createInfo.MarshalTo(marshalledCreateInfo);
            Interop.AllocationCallbacks* marshalledAllocator;
            marshalledAllocator = (Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<Interop.AllocationCallbacks>());
            allocator.MarshalTo(marshalledAllocator);
        }
        
        internal unsafe void CreatePipelineCache(PipelineCacheCreateInfo createInfo, AllocationCallbacks allocator)
        {
            Interop.PipelineCacheCreateInfo* marshalledCreateInfo;
            marshalledCreateInfo = (Interop.PipelineCacheCreateInfo*)(Interop.HeapUtil.Allocate<Interop.PipelineCacheCreateInfo>());
            createInfo.MarshalTo(marshalledCreateInfo);
            Interop.AllocationCallbacks* marshalledAllocator;
            marshalledAllocator = (Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<Interop.AllocationCallbacks>());
            allocator.MarshalTo(marshalledAllocator);
        }
        
        internal unsafe void CreatePipelineLayout(PipelineLayoutCreateInfo createInfo, AllocationCallbacks allocator)
        {
            Interop.PipelineLayoutCreateInfo* marshalledCreateInfo;
            marshalledCreateInfo = (Interop.PipelineLayoutCreateInfo*)(Interop.HeapUtil.Allocate<Interop.PipelineLayoutCreateInfo>());
            createInfo.MarshalTo(marshalledCreateInfo);
            Interop.AllocationCallbacks* marshalledAllocator;
            marshalledAllocator = (Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<Interop.AllocationCallbacks>());
            allocator.MarshalTo(marshalledAllocator);
        }
        
        internal unsafe void CreateSampler(SamplerCreateInfo createInfo, AllocationCallbacks allocator)
        {
            Interop.SamplerCreateInfo* marshalledCreateInfo;
            marshalledCreateInfo = (Interop.SamplerCreateInfo*)(Interop.HeapUtil.Allocate<Interop.SamplerCreateInfo>());
            createInfo.MarshalTo(marshalledCreateInfo);
            Interop.AllocationCallbacks* marshalledAllocator;
            marshalledAllocator = (Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<Interop.AllocationCallbacks>());
            allocator.MarshalTo(marshalledAllocator);
        }
        
        internal unsafe void CreateDescriptorSetLayout(DescriptorSetLayoutCreateInfo createInfo, AllocationCallbacks allocator)
        {
            Interop.DescriptorSetLayoutCreateInfo* marshalledCreateInfo;
            marshalledCreateInfo = (Interop.DescriptorSetLayoutCreateInfo*)(Interop.HeapUtil.Allocate<Interop.DescriptorSetLayoutCreateInfo>());
            createInfo.MarshalTo(marshalledCreateInfo);
            Interop.AllocationCallbacks* marshalledAllocator;
            marshalledAllocator = (Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<Interop.AllocationCallbacks>());
            allocator.MarshalTo(marshalledAllocator);
        }
        
        internal unsafe void CreateDescriptorPool(DescriptorPoolCreateInfo createInfo, AllocationCallbacks allocator)
        {
            Interop.DescriptorPoolCreateInfo* marshalledCreateInfo;
            marshalledCreateInfo = (Interop.DescriptorPoolCreateInfo*)(Interop.HeapUtil.Allocate<Interop.DescriptorPoolCreateInfo>());
            createInfo.MarshalTo(marshalledCreateInfo);
            Interop.AllocationCallbacks* marshalledAllocator;
            marshalledAllocator = (Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<Interop.AllocationCallbacks>());
            allocator.MarshalTo(marshalledAllocator);
        }
        
        internal unsafe void AllocateDescriptorSets(DescriptorSetAllocateInfo allocateInfo)
        {
            Interop.DescriptorSetAllocateInfo* marshalledAllocateInfo;
            marshalledAllocateInfo = (Interop.DescriptorSetAllocateInfo*)(Interop.HeapUtil.Allocate<Interop.DescriptorSetAllocateInfo>());
            allocateInfo.MarshalTo(marshalledAllocateInfo);
        }
        
        internal unsafe void UpdateDescriptorSets(WriteDescriptorSet[] descriptorWrites, CopyDescriptorSet[] descriptorCopies)
        {
            uint marshalledDescriptorWriteCount;
            marshalledDescriptorWriteCount = (uint)(descriptorWrites?.Length ?? 0);
            Interop.WriteDescriptorSet* marshalledDescriptorWrites;
            if (descriptorWrites != null)
            {
                var fieldPointer = (Interop.WriteDescriptorSet*)(Interop.HeapUtil.AllocateAndClear<Interop.WriteDescriptorSet>(descriptorWrites.Length).ToPointer());
                for(int index = 0; index < descriptorWrites.Length; index++)
                {
                    descriptorWrites[index].MarshalTo(&fieldPointer[index]);
                }
                marshalledDescriptorWrites = fieldPointer;
            }
            else
            {
                marshalledDescriptorWrites = null;
            }
            uint marshalledDescriptorCopyCount;
            marshalledDescriptorCopyCount = (uint)(descriptorCopies?.Length ?? 0);
            Interop.CopyDescriptorSet* marshalledDescriptorCopies;
            if (descriptorCopies != null)
            {
                var fieldPointer = (Interop.CopyDescriptorSet*)(Interop.HeapUtil.AllocateAndClear<Interop.CopyDescriptorSet>(descriptorCopies.Length).ToPointer());
                for(int index = 0; index < descriptorCopies.Length; index++)
                {
                    descriptorCopies[index].MarshalTo(&fieldPointer[index]);
                }
                marshalledDescriptorCopies = fieldPointer;
            }
            else
            {
                marshalledDescriptorCopies = null;
            }
        }
        
        internal unsafe void CreateFramebuffer(FramebufferCreateInfo createInfo, AllocationCallbacks allocator)
        {
            Interop.FramebufferCreateInfo* marshalledCreateInfo;
            marshalledCreateInfo = (Interop.FramebufferCreateInfo*)(Interop.HeapUtil.Allocate<Interop.FramebufferCreateInfo>());
            createInfo.MarshalTo(marshalledCreateInfo);
            Interop.AllocationCallbacks* marshalledAllocator;
            marshalledAllocator = (Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<Interop.AllocationCallbacks>());
            allocator.MarshalTo(marshalledAllocator);
        }
        
        internal unsafe void CreateRenderPass(RenderPassCreateInfo createInfo, AllocationCallbacks allocator)
        {
            Interop.RenderPassCreateInfo* marshalledCreateInfo;
            marshalledCreateInfo = (Interop.RenderPassCreateInfo*)(Interop.HeapUtil.Allocate<Interop.RenderPassCreateInfo>());
            createInfo.MarshalTo(marshalledCreateInfo);
            Interop.AllocationCallbacks* marshalledAllocator;
            marshalledAllocator = (Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<Interop.AllocationCallbacks>());
            allocator.MarshalTo(marshalledAllocator);
        }
        
        internal unsafe void CreateCommandPool(CommandPoolCreateInfo createInfo, AllocationCallbacks allocator)
        {
            Interop.CommandPoolCreateInfo* marshalledCreateInfo;
            marshalledCreateInfo = (Interop.CommandPoolCreateInfo*)(Interop.HeapUtil.Allocate<Interop.CommandPoolCreateInfo>());
            createInfo.MarshalTo(marshalledCreateInfo);
            Interop.AllocationCallbacks* marshalledAllocator;
            marshalledAllocator = (Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<Interop.AllocationCallbacks>());
            allocator.MarshalTo(marshalledAllocator);
        }
        
        internal unsafe void AllocateCommandBuffers(CommandBufferAllocateInfo allocateInfo)
        {
            Interop.CommandBufferAllocateInfo* marshalledAllocateInfo;
            marshalledAllocateInfo = (Interop.CommandBufferAllocateInfo*)(Interop.HeapUtil.Allocate<Interop.CommandBufferAllocateInfo>());
            allocateInfo.MarshalTo(marshalledAllocateInfo);
        }
    }
}
