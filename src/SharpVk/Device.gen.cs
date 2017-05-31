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
            try
            {
                byte* marshalledName = default(byte*);
                marshalledName = Interop.HeapUtil.MarshalTo(name);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        internal unsafe void Destroy(AllocationCallbacks allocator)
        {
            try
            {
                Interop.AllocationCallbacks* marshalledAllocator = default(Interop.AllocationCallbacks*);
                marshalledAllocator = (Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<Interop.AllocationCallbacks>());
                allocator.MarshalTo(marshalledAllocator);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        internal unsafe Queue GetQueue(uint queueFamilyIndex, uint queueIndex)
        {
            try
            {
                Queue result = default(Queue);
                uint marshalledQueueFamilyIndex = default(uint);
                uint marshalledQueueIndex = default(uint);
                Interop.Queue* marshalledQueue = default(Interop.Queue*);
                marshalledQueueFamilyIndex = queueFamilyIndex;
                marshalledQueueIndex = queueIndex;
                result = new Queue(*marshalledQueue);
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        internal unsafe void WaitIdle()
        {
            try
            {
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        internal unsafe DeviceMemory AllocateMemory(MemoryAllocateInfo allocateInfo, AllocationCallbacks allocator)
        {
            try
            {
                DeviceMemory result = default(DeviceMemory);
                Interop.MemoryAllocateInfo* marshalledAllocateInfo = default(Interop.MemoryAllocateInfo*);
                Interop.AllocationCallbacks* marshalledAllocator = default(Interop.AllocationCallbacks*);
                Interop.DeviceMemory* marshalledMemory = default(Interop.DeviceMemory*);
                marshalledAllocateInfo = (Interop.MemoryAllocateInfo*)(Interop.HeapUtil.Allocate<Interop.MemoryAllocateInfo>());
                allocateInfo.MarshalTo(marshalledAllocateInfo);
                marshalledAllocator = (Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<Interop.AllocationCallbacks>());
                allocator.MarshalTo(marshalledAllocator);
                result = new DeviceMemory(*marshalledMemory);
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        internal unsafe void FlushMappedMemoryRanges(MappedMemoryRange[] memoryRanges)
        {
            try
            {
                uint marshalledMemoryRangeCount = default(uint);
                Interop.MappedMemoryRange* marshalledMemoryRanges = default(Interop.MappedMemoryRange*);
                marshalledMemoryRangeCount = (uint)(memoryRanges?.Length ?? 0);
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
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        internal unsafe void InvalidateMappedMemoryRanges(MappedMemoryRange[] memoryRanges)
        {
            try
            {
                uint marshalledMemoryRangeCount = default(uint);
                Interop.MappedMemoryRange* marshalledMemoryRanges = default(Interop.MappedMemoryRange*);
                marshalledMemoryRangeCount = (uint)(memoryRanges?.Length ?? 0);
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
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        internal unsafe Fence CreateFence(FenceCreateInfo createInfo, AllocationCallbacks allocator)
        {
            try
            {
                Fence result = default(Fence);
                Interop.FenceCreateInfo* marshalledCreateInfo = default(Interop.FenceCreateInfo*);
                Interop.AllocationCallbacks* marshalledAllocator = default(Interop.AllocationCallbacks*);
                Interop.Fence* marshalledFence = default(Interop.Fence*);
                marshalledCreateInfo = (Interop.FenceCreateInfo*)(Interop.HeapUtil.Allocate<Interop.FenceCreateInfo>());
                createInfo.MarshalTo(marshalledCreateInfo);
                marshalledAllocator = (Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<Interop.AllocationCallbacks>());
                allocator.MarshalTo(marshalledAllocator);
                result = new Fence(*marshalledFence);
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        internal unsafe void ResetFences(Fence[] fences)
        {
            try
            {
                uint marshalledFenceCount = default(uint);
                Interop.Fence* marshalledFences = default(Interop.Fence*);
                marshalledFenceCount = (uint)(fences?.Length ?? 0);
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
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        internal unsafe void WaitForFences(Fence[] fences, Bool32 waitAll, ulong timeout)
        {
            try
            {
                uint marshalledFenceCount = default(uint);
                Interop.Fence* marshalledFences = default(Interop.Fence*);
                Bool32 marshalledWaitAll = default(Bool32);
                ulong marshalledTimeout = default(ulong);
                marshalledFenceCount = (uint)(fences?.Length ?? 0);
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
                marshalledWaitAll = waitAll;
                marshalledTimeout = timeout;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        internal unsafe Semaphore CreateSemaphore(SemaphoreCreateInfo createInfo, AllocationCallbacks allocator)
        {
            try
            {
                Semaphore result = default(Semaphore);
                Interop.SemaphoreCreateInfo* marshalledCreateInfo = default(Interop.SemaphoreCreateInfo*);
                Interop.AllocationCallbacks* marshalledAllocator = default(Interop.AllocationCallbacks*);
                Interop.Semaphore* marshalledSemaphore = default(Interop.Semaphore*);
                marshalledCreateInfo = (Interop.SemaphoreCreateInfo*)(Interop.HeapUtil.Allocate<Interop.SemaphoreCreateInfo>());
                createInfo.MarshalTo(marshalledCreateInfo);
                marshalledAllocator = (Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<Interop.AllocationCallbacks>());
                allocator.MarshalTo(marshalledAllocator);
                result = new Semaphore(*marshalledSemaphore);
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        internal unsafe Event CreateEvent(EventCreateInfo createInfo, AllocationCallbacks allocator)
        {
            try
            {
                Event result = default(Event);
                Interop.EventCreateInfo* marshalledCreateInfo = default(Interop.EventCreateInfo*);
                Interop.AllocationCallbacks* marshalledAllocator = default(Interop.AllocationCallbacks*);
                Interop.Event* marshalledEvent = default(Interop.Event*);
                marshalledCreateInfo = (Interop.EventCreateInfo*)(Interop.HeapUtil.Allocate<Interop.EventCreateInfo>());
                createInfo.MarshalTo(marshalledCreateInfo);
                marshalledAllocator = (Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<Interop.AllocationCallbacks>());
                allocator.MarshalTo(marshalledAllocator);
                result = new Event(*marshalledEvent);
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        internal unsafe QueryPool CreateQueryPool(QueryPoolCreateInfo createInfo, AllocationCallbacks allocator)
        {
            try
            {
                QueryPool result = default(QueryPool);
                Interop.QueryPoolCreateInfo* marshalledCreateInfo = default(Interop.QueryPoolCreateInfo*);
                Interop.AllocationCallbacks* marshalledAllocator = default(Interop.AllocationCallbacks*);
                Interop.QueryPool* marshalledQueryPool = default(Interop.QueryPool*);
                marshalledCreateInfo = (Interop.QueryPoolCreateInfo*)(Interop.HeapUtil.Allocate<Interop.QueryPoolCreateInfo>());
                createInfo.MarshalTo(marshalledCreateInfo);
                marshalledAllocator = (Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<Interop.AllocationCallbacks>());
                allocator.MarshalTo(marshalledAllocator);
                result = new QueryPool(*marshalledQueryPool);
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        internal unsafe Buffer CreateBuffer(BufferCreateInfo createInfo, AllocationCallbacks allocator)
        {
            try
            {
                Buffer result = default(Buffer);
                Interop.BufferCreateInfo* marshalledCreateInfo = default(Interop.BufferCreateInfo*);
                Interop.AllocationCallbacks* marshalledAllocator = default(Interop.AllocationCallbacks*);
                Interop.Buffer* marshalledBuffer = default(Interop.Buffer*);
                marshalledCreateInfo = (Interop.BufferCreateInfo*)(Interop.HeapUtil.Allocate<Interop.BufferCreateInfo>());
                createInfo.MarshalTo(marshalledCreateInfo);
                marshalledAllocator = (Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<Interop.AllocationCallbacks>());
                allocator.MarshalTo(marshalledAllocator);
                result = new Buffer(*marshalledBuffer);
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        internal unsafe BufferView CreateBufferView(BufferViewCreateInfo createInfo, AllocationCallbacks allocator)
        {
            try
            {
                BufferView result = default(BufferView);
                Interop.BufferViewCreateInfo* marshalledCreateInfo = default(Interop.BufferViewCreateInfo*);
                Interop.AllocationCallbacks* marshalledAllocator = default(Interop.AllocationCallbacks*);
                Interop.BufferView* marshalledView = default(Interop.BufferView*);
                marshalledCreateInfo = (Interop.BufferViewCreateInfo*)(Interop.HeapUtil.Allocate<Interop.BufferViewCreateInfo>());
                createInfo.MarshalTo(marshalledCreateInfo);
                marshalledAllocator = (Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<Interop.AllocationCallbacks>());
                allocator.MarshalTo(marshalledAllocator);
                result = new BufferView(*marshalledView);
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        internal unsafe Image CreateImage(ImageCreateInfo createInfo, AllocationCallbacks allocator)
        {
            try
            {
                Image result = default(Image);
                Interop.ImageCreateInfo* marshalledCreateInfo = default(Interop.ImageCreateInfo*);
                Interop.AllocationCallbacks* marshalledAllocator = default(Interop.AllocationCallbacks*);
                Interop.Image* marshalledImage = default(Interop.Image*);
                marshalledCreateInfo = (Interop.ImageCreateInfo*)(Interop.HeapUtil.Allocate<Interop.ImageCreateInfo>());
                createInfo.MarshalTo(marshalledCreateInfo);
                marshalledAllocator = (Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<Interop.AllocationCallbacks>());
                allocator.MarshalTo(marshalledAllocator);
                result = new Image(*marshalledImage);
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        internal unsafe ImageView CreateImageView(ImageViewCreateInfo createInfo, AllocationCallbacks allocator)
        {
            try
            {
                ImageView result = default(ImageView);
                Interop.ImageViewCreateInfo* marshalledCreateInfo = default(Interop.ImageViewCreateInfo*);
                Interop.AllocationCallbacks* marshalledAllocator = default(Interop.AllocationCallbacks*);
                Interop.ImageView* marshalledView = default(Interop.ImageView*);
                marshalledCreateInfo = (Interop.ImageViewCreateInfo*)(Interop.HeapUtil.Allocate<Interop.ImageViewCreateInfo>());
                createInfo.MarshalTo(marshalledCreateInfo);
                marshalledAllocator = (Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<Interop.AllocationCallbacks>());
                allocator.MarshalTo(marshalledAllocator);
                result = new ImageView(*marshalledView);
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        internal unsafe ShaderModule CreateShaderModule(ShaderModuleCreateInfo createInfo, AllocationCallbacks allocator)
        {
            try
            {
                ShaderModule result = default(ShaderModule);
                Interop.ShaderModuleCreateInfo* marshalledCreateInfo = default(Interop.ShaderModuleCreateInfo*);
                Interop.AllocationCallbacks* marshalledAllocator = default(Interop.AllocationCallbacks*);
                Interop.ShaderModule* marshalledShaderModule = default(Interop.ShaderModule*);
                marshalledCreateInfo = (Interop.ShaderModuleCreateInfo*)(Interop.HeapUtil.Allocate<Interop.ShaderModuleCreateInfo>());
                createInfo.MarshalTo(marshalledCreateInfo);
                marshalledAllocator = (Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<Interop.AllocationCallbacks>());
                allocator.MarshalTo(marshalledAllocator);
                result = new ShaderModule(*marshalledShaderModule);
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        internal unsafe PipelineCache CreatePipelineCache(PipelineCacheCreateInfo createInfo, AllocationCallbacks allocator)
        {
            try
            {
                PipelineCache result = default(PipelineCache);
                Interop.PipelineCacheCreateInfo* marshalledCreateInfo = default(Interop.PipelineCacheCreateInfo*);
                Interop.AllocationCallbacks* marshalledAllocator = default(Interop.AllocationCallbacks*);
                Interop.PipelineCache* marshalledPipelineCache = default(Interop.PipelineCache*);
                marshalledCreateInfo = (Interop.PipelineCacheCreateInfo*)(Interop.HeapUtil.Allocate<Interop.PipelineCacheCreateInfo>());
                createInfo.MarshalTo(marshalledCreateInfo);
                marshalledAllocator = (Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<Interop.AllocationCallbacks>());
                allocator.MarshalTo(marshalledAllocator);
                result = new PipelineCache(*marshalledPipelineCache);
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        internal unsafe PipelineLayout CreatePipelineLayout(PipelineLayoutCreateInfo createInfo, AllocationCallbacks allocator)
        {
            try
            {
                PipelineLayout result = default(PipelineLayout);
                Interop.PipelineLayoutCreateInfo* marshalledCreateInfo = default(Interop.PipelineLayoutCreateInfo*);
                Interop.AllocationCallbacks* marshalledAllocator = default(Interop.AllocationCallbacks*);
                Interop.PipelineLayout* marshalledPipelineLayout = default(Interop.PipelineLayout*);
                marshalledCreateInfo = (Interop.PipelineLayoutCreateInfo*)(Interop.HeapUtil.Allocate<Interop.PipelineLayoutCreateInfo>());
                createInfo.MarshalTo(marshalledCreateInfo);
                marshalledAllocator = (Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<Interop.AllocationCallbacks>());
                allocator.MarshalTo(marshalledAllocator);
                result = new PipelineLayout(*marshalledPipelineLayout);
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        internal unsafe Sampler CreateSampler(SamplerCreateInfo createInfo, AllocationCallbacks allocator)
        {
            try
            {
                Sampler result = default(Sampler);
                Interop.SamplerCreateInfo* marshalledCreateInfo = default(Interop.SamplerCreateInfo*);
                Interop.AllocationCallbacks* marshalledAllocator = default(Interop.AllocationCallbacks*);
                Interop.Sampler* marshalledSampler = default(Interop.Sampler*);
                marshalledCreateInfo = (Interop.SamplerCreateInfo*)(Interop.HeapUtil.Allocate<Interop.SamplerCreateInfo>());
                createInfo.MarshalTo(marshalledCreateInfo);
                marshalledAllocator = (Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<Interop.AllocationCallbacks>());
                allocator.MarshalTo(marshalledAllocator);
                result = new Sampler(*marshalledSampler);
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        internal unsafe DescriptorSetLayout CreateDescriptorSetLayout(DescriptorSetLayoutCreateInfo createInfo, AllocationCallbacks allocator)
        {
            try
            {
                DescriptorSetLayout result = default(DescriptorSetLayout);
                Interop.DescriptorSetLayoutCreateInfo* marshalledCreateInfo = default(Interop.DescriptorSetLayoutCreateInfo*);
                Interop.AllocationCallbacks* marshalledAllocator = default(Interop.AllocationCallbacks*);
                Interop.DescriptorSetLayout* marshalledSetLayout = default(Interop.DescriptorSetLayout*);
                marshalledCreateInfo = (Interop.DescriptorSetLayoutCreateInfo*)(Interop.HeapUtil.Allocate<Interop.DescriptorSetLayoutCreateInfo>());
                createInfo.MarshalTo(marshalledCreateInfo);
                marshalledAllocator = (Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<Interop.AllocationCallbacks>());
                allocator.MarshalTo(marshalledAllocator);
                result = new DescriptorSetLayout(*marshalledSetLayout);
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        internal unsafe DescriptorPool CreateDescriptorPool(DescriptorPoolCreateInfo createInfo, AllocationCallbacks allocator)
        {
            try
            {
                DescriptorPool result = default(DescriptorPool);
                Interop.DescriptorPoolCreateInfo* marshalledCreateInfo = default(Interop.DescriptorPoolCreateInfo*);
                Interop.AllocationCallbacks* marshalledAllocator = default(Interop.AllocationCallbacks*);
                Interop.DescriptorPool* marshalledDescriptorPool = default(Interop.DescriptorPool*);
                marshalledCreateInfo = (Interop.DescriptorPoolCreateInfo*)(Interop.HeapUtil.Allocate<Interop.DescriptorPoolCreateInfo>());
                createInfo.MarshalTo(marshalledCreateInfo);
                marshalledAllocator = (Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<Interop.AllocationCallbacks>());
                allocator.MarshalTo(marshalledAllocator);
                result = new DescriptorPool(*marshalledDescriptorPool);
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        internal unsafe DescriptorSet[] AllocateDescriptorSets(DescriptorSetAllocateInfo allocateInfo)
        {
            try
            {
                DescriptorSet[] result = default(DescriptorSet[]);
                Interop.DescriptorSetAllocateInfo* marshalledAllocateInfo = default(Interop.DescriptorSetAllocateInfo*);
                marshalledAllocateInfo = (Interop.DescriptorSetAllocateInfo*)(Interop.HeapUtil.Allocate<Interop.DescriptorSetAllocateInfo>());
                allocateInfo.MarshalTo(marshalledAllocateInfo);
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        internal unsafe void UpdateDescriptorSets(WriteDescriptorSet[] descriptorWrites, CopyDescriptorSet[] descriptorCopies)
        {
            try
            {
                uint marshalledDescriptorWriteCount = default(uint);
                Interop.WriteDescriptorSet* marshalledDescriptorWrites = default(Interop.WriteDescriptorSet*);
                uint marshalledDescriptorCopyCount = default(uint);
                Interop.CopyDescriptorSet* marshalledDescriptorCopies = default(Interop.CopyDescriptorSet*);
                marshalledDescriptorWriteCount = (uint)(descriptorWrites?.Length ?? 0);
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
                marshalledDescriptorCopyCount = (uint)(descriptorCopies?.Length ?? 0);
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
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        internal unsafe Framebuffer CreateFramebuffer(FramebufferCreateInfo createInfo, AllocationCallbacks allocator)
        {
            try
            {
                Framebuffer result = default(Framebuffer);
                Interop.FramebufferCreateInfo* marshalledCreateInfo = default(Interop.FramebufferCreateInfo*);
                Interop.AllocationCallbacks* marshalledAllocator = default(Interop.AllocationCallbacks*);
                Interop.Framebuffer* marshalledFramebuffer = default(Interop.Framebuffer*);
                marshalledCreateInfo = (Interop.FramebufferCreateInfo*)(Interop.HeapUtil.Allocate<Interop.FramebufferCreateInfo>());
                createInfo.MarshalTo(marshalledCreateInfo);
                marshalledAllocator = (Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<Interop.AllocationCallbacks>());
                allocator.MarshalTo(marshalledAllocator);
                result = new Framebuffer(*marshalledFramebuffer);
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        internal unsafe RenderPass CreateRenderPass(RenderPassCreateInfo createInfo, AllocationCallbacks allocator)
        {
            try
            {
                RenderPass result = default(RenderPass);
                Interop.RenderPassCreateInfo* marshalledCreateInfo = default(Interop.RenderPassCreateInfo*);
                Interop.AllocationCallbacks* marshalledAllocator = default(Interop.AllocationCallbacks*);
                Interop.RenderPass* marshalledRenderPass = default(Interop.RenderPass*);
                marshalledCreateInfo = (Interop.RenderPassCreateInfo*)(Interop.HeapUtil.Allocate<Interop.RenderPassCreateInfo>());
                createInfo.MarshalTo(marshalledCreateInfo);
                marshalledAllocator = (Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<Interop.AllocationCallbacks>());
                allocator.MarshalTo(marshalledAllocator);
                result = new RenderPass(*marshalledRenderPass);
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        internal unsafe CommandPool CreateCommandPool(CommandPoolCreateInfo createInfo, AllocationCallbacks allocator)
        {
            try
            {
                CommandPool result = default(CommandPool);
                Interop.CommandPoolCreateInfo* marshalledCreateInfo = default(Interop.CommandPoolCreateInfo*);
                Interop.AllocationCallbacks* marshalledAllocator = default(Interop.AllocationCallbacks*);
                Interop.CommandPool* marshalledCommandPool = default(Interop.CommandPool*);
                marshalledCreateInfo = (Interop.CommandPoolCreateInfo*)(Interop.HeapUtil.Allocate<Interop.CommandPoolCreateInfo>());
                createInfo.MarshalTo(marshalledCreateInfo);
                marshalledAllocator = (Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<Interop.AllocationCallbacks>());
                allocator.MarshalTo(marshalledAllocator);
                result = new CommandPool(*marshalledCommandPool);
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        internal unsafe CommandBuffer[] AllocateCommandBuffers(CommandBufferAllocateInfo allocateInfo)
        {
            try
            {
                CommandBuffer[] result = default(CommandBuffer[]);
                Interop.CommandBufferAllocateInfo* marshalledAllocateInfo = default(Interop.CommandBufferAllocateInfo*);
                marshalledAllocateInfo = (Interop.CommandBufferAllocateInfo*)(Interop.HeapUtil.Allocate<Interop.CommandBufferAllocateInfo>());
                allocateInfo.MarshalTo(marshalledAllocateInfo);
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
    }
}
