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
        
        /// <summary>
        /// 
        /// </summary>
        public void GetProcedureAddress(string name)
        {
        }
        
        /// <summary>
        /// 
        /// </summary>
        public void Destroy(AllocationCallbacks allocator)
        {
        }
        
        /// <summary>
        /// 
        /// </summary>
        public void GetQueue(uint queueFamilyIndex, uint queueIndex, Queue queue)
        {
        }
        
        /// <summary>
        /// 
        /// </summary>
        public void WaitIdle()
        {
        }
        
        /// <summary>
        /// 
        /// </summary>
        public void AllocateMemory(MemoryAllocateInfo allocateInfo, AllocationCallbacks allocator, DeviceMemory memory)
        {
        }
        
        /// <summary>
        /// 
        /// </summary>
        public void FlushMappedMemoryRanges(MappedMemoryRange[] memoryRanges)
        {
        }
        
        /// <summary>
        /// 
        /// </summary>
        public void InvalidateMappedMemoryRanges(MappedMemoryRange[] memoryRanges)
        {
        }
        
        /// <summary>
        /// 
        /// </summary>
        public void CreateFence(FenceCreateInfo createInfo, AllocationCallbacks allocator, Fence fence)
        {
        }
        
        /// <summary>
        /// 
        /// </summary>
        public void ResetFences(Fence[] fences)
        {
        }
        
        /// <summary>
        /// 
        /// </summary>
        public void WaitForFences(Fence[] fences, Bool32 waitAll, ulong timeout)
        {
        }
        
        /// <summary>
        /// 
        /// </summary>
        public void CreateSemaphore(SemaphoreCreateInfo createInfo, AllocationCallbacks allocator, Semaphore semaphore)
        {
        }
        
        /// <summary>
        /// 
        /// </summary>
        public void CreateEvent(EventCreateInfo createInfo, AllocationCallbacks allocator, Event @event)
        {
        }
        
        /// <summary>
        /// 
        /// </summary>
        public void CreateQueryPool(QueryPoolCreateInfo createInfo, AllocationCallbacks allocator, QueryPool queryPool)
        {
        }
        
        /// <summary>
        /// 
        /// </summary>
        public void CreateBuffer(BufferCreateInfo createInfo, AllocationCallbacks allocator, Buffer buffer)
        {
        }
        
        /// <summary>
        /// 
        /// </summary>
        public void CreateBufferView(BufferViewCreateInfo createInfo, AllocationCallbacks allocator, BufferView view)
        {
        }
        
        /// <summary>
        /// 
        /// </summary>
        public void CreateImage(ImageCreateInfo createInfo, AllocationCallbacks allocator, Image image)
        {
        }
        
        /// <summary>
        /// 
        /// </summary>
        public void CreateImageView(ImageViewCreateInfo createInfo, AllocationCallbacks allocator, ImageView view)
        {
        }
        
        /// <summary>
        /// 
        /// </summary>
        public void CreateShaderModule(ShaderModuleCreateInfo createInfo, AllocationCallbacks allocator, ShaderModule shaderModule)
        {
        }
        
        /// <summary>
        /// 
        /// </summary>
        public void CreatePipelineCache(PipelineCacheCreateInfo createInfo, AllocationCallbacks allocator, PipelineCache pipelineCache)
        {
        }
        
        /// <summary>
        /// 
        /// </summary>
        public void CreatePipelineLayout(PipelineLayoutCreateInfo createInfo, AllocationCallbacks allocator, PipelineLayout pipelineLayout)
        {
        }
        
        /// <summary>
        /// 
        /// </summary>
        public void CreateSampler(SamplerCreateInfo createInfo, AllocationCallbacks allocator, Sampler sampler)
        {
        }
        
        /// <summary>
        /// 
        /// </summary>
        public void CreateDescriptorSetLayout(DescriptorSetLayoutCreateInfo createInfo, AllocationCallbacks allocator, DescriptorSetLayout setLayout)
        {
        }
        
        /// <summary>
        /// 
        /// </summary>
        public void CreateDescriptorPool(DescriptorPoolCreateInfo createInfo, AllocationCallbacks allocator, DescriptorPool descriptorPool)
        {
        }
        
        /// <summary>
        /// 
        /// </summary>
        public void AllocateDescriptorSets(DescriptorSet[] descriptorSets)
        {
        }
        
        /// <summary>
        /// 
        /// </summary>
        public void UpdateDescriptorSets(WriteDescriptorSet[] descriptorWrites, CopyDescriptorSet[] descriptorCopies)
        {
        }
        
        /// <summary>
        /// 
        /// </summary>
        public void CreateFramebuffer(FramebufferCreateInfo createInfo, AllocationCallbacks allocator, Framebuffer framebuffer)
        {
        }
        
        /// <summary>
        /// 
        /// </summary>
        public void CreateRenderPass(RenderPassCreateInfo createInfo, AllocationCallbacks allocator, RenderPass renderPass)
        {
        }
        
        /// <summary>
        /// 
        /// </summary>
        public void CreateCommandPool(CommandPoolCreateInfo createInfo, AllocationCallbacks allocator, CommandPool commandPool)
        {
        }
        
        /// <summary>
        /// 
        /// </summary>
        public void AllocateCommandBuffers(CommandBuffer[] commandBuffers)
        {
        }
    }
}
