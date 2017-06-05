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
        
        private readonly SharpVk.Interop.PhysicalDevice parent; 
        
        internal Device(SharpVk.Interop.PhysicalDevice parent, SharpVk.Interop.Device handle)
        {
            this.handle = handle;
            this.parent = parent;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public unsafe void GetProcedureAddress(string name)
        {
            try
            {
                Interop.Commands.vkGetDeviceProcAddr(this.handle, Interop.HeapUtil.MarshalTo(name));
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        public unsafe void Destroy(AllocationCallbacks? allocator = null)
        {
            try
            {
                Interop.AllocationCallbacks* marshalledAllocator = default(Interop.AllocationCallbacks*);
                if (allocator != null)
                {
                    marshalledAllocator = (Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<Interop.AllocationCallbacks>());
                    allocator.Value.MarshalTo(marshalledAllocator);
                }
                Interop.Commands.vkDestroyDevice(this.handle, marshalledAllocator);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        public unsafe Queue GetQueue(uint queueFamilyIndex, uint queueIndex)
        {
            try
            {
                Queue result = default(Queue);
                Interop.Queue marshalledQueue = default(Interop.Queue);
                Interop.Commands.vkGetDeviceQueue(this.handle, queueFamilyIndex, queueIndex, &marshalledQueue);
                result = new Queue(this.handle, marshalledQueue);
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
        public unsafe void WaitIdle()
        {
            try
            {
                Interop.Commands.vkDeviceWaitIdle(this.handle);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        public unsafe DeviceMemory AllocateMemory(MemoryAllocateInfo allocateInfo, AllocationCallbacks? allocator = null)
        {
            try
            {
                DeviceMemory result = default(DeviceMemory);
                Interop.MemoryAllocateInfo* marshalledAllocateInfo = default(Interop.MemoryAllocateInfo*);
                Interop.AllocationCallbacks* marshalledAllocator = default(Interop.AllocationCallbacks*);
                Interop.DeviceMemory marshalledMemory = default(Interop.DeviceMemory);
                marshalledAllocateInfo = (Interop.MemoryAllocateInfo*)(Interop.HeapUtil.Allocate<Interop.MemoryAllocateInfo>());
                allocateInfo.MarshalTo(marshalledAllocateInfo);
                if (allocator != null)
                {
                    marshalledAllocator = (Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<Interop.AllocationCallbacks>());
                    allocator.Value.MarshalTo(marshalledAllocator);
                }
                Interop.Commands.vkAllocateMemory(this.handle, marshalledAllocateInfo, marshalledAllocator, &marshalledMemory);
                result = new DeviceMemory(this.handle, marshalledMemory);
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
        public unsafe void FlushMappedMemoryRanges(MappedMemoryRange[] memoryRanges)
        {
            try
            {
                Interop.MappedMemoryRange* marshalledMemoryRanges = default(Interop.MappedMemoryRange*);
                if (memoryRanges != null)
                {
                    var fieldPointer = (Interop.MappedMemoryRange*)(Interop.HeapUtil.AllocateAndClear<Interop.MappedMemoryRange>(memoryRanges.Length).ToPointer());
                    for(int index = 0; index < (uint)(memoryRanges.Length); index++)
                    {
                        memoryRanges[index].MarshalTo(&fieldPointer[index]);
                    }
                    marshalledMemoryRanges = fieldPointer;
                }
                else
                {
                    marshalledMemoryRanges = null;
                }
                Interop.Commands.vkFlushMappedMemoryRanges(this.handle, (uint)(memoryRanges?.Length ?? 0), marshalledMemoryRanges);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        public unsafe void InvalidateMappedMemoryRanges(MappedMemoryRange[] memoryRanges)
        {
            try
            {
                Interop.MappedMemoryRange* marshalledMemoryRanges = default(Interop.MappedMemoryRange*);
                if (memoryRanges != null)
                {
                    var fieldPointer = (Interop.MappedMemoryRange*)(Interop.HeapUtil.AllocateAndClear<Interop.MappedMemoryRange>(memoryRanges.Length).ToPointer());
                    for(int index = 0; index < (uint)(memoryRanges.Length); index++)
                    {
                        memoryRanges[index].MarshalTo(&fieldPointer[index]);
                    }
                    marshalledMemoryRanges = fieldPointer;
                }
                else
                {
                    marshalledMemoryRanges = null;
                }
                Interop.Commands.vkInvalidateMappedMemoryRanges(this.handle, (uint)(memoryRanges?.Length ?? 0), marshalledMemoryRanges);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        public unsafe Fence CreateFence(FenceCreateInfo createInfo, AllocationCallbacks? allocator = null)
        {
            try
            {
                Fence result = default(Fence);
                Interop.FenceCreateInfo* marshalledCreateInfo = default(Interop.FenceCreateInfo*);
                Interop.AllocationCallbacks* marshalledAllocator = default(Interop.AllocationCallbacks*);
                Interop.Fence marshalledFence = default(Interop.Fence);
                marshalledCreateInfo = (Interop.FenceCreateInfo*)(Interop.HeapUtil.Allocate<Interop.FenceCreateInfo>());
                createInfo.MarshalTo(marshalledCreateInfo);
                if (allocator != null)
                {
                    marshalledAllocator = (Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<Interop.AllocationCallbacks>());
                    allocator.Value.MarshalTo(marshalledAllocator);
                }
                Interop.Commands.vkCreateFence(this.handle, marshalledCreateInfo, marshalledAllocator, &marshalledFence);
                result = new Fence(this.handle, marshalledFence);
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
        public unsafe void ResetFences(Fence[] fences)
        {
            try
            {
                Interop.Fence* marshalledFences = default(Interop.Fence*);
                if (fences != null)
                {
                    var fieldPointer = (Interop.Fence*)(Interop.HeapUtil.AllocateAndClear<Interop.Fence>(fences.Length).ToPointer());
                    for(int index = 0; index < (uint)(fences.Length); index++)
                    {
                        fieldPointer[index] = fences[index].handle;
                    }
                    marshalledFences = fieldPointer;
                }
                else
                {
                    marshalledFences = null;
                }
                Interop.Commands.vkResetFences(this.handle, (uint)(fences?.Length ?? 0), marshalledFences);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        public unsafe void WaitForFences(Fence[] fences, Bool32 waitAll, ulong timeout)
        {
            try
            {
                Interop.Fence* marshalledFences = default(Interop.Fence*);
                if (fences != null)
                {
                    var fieldPointer = (Interop.Fence*)(Interop.HeapUtil.AllocateAndClear<Interop.Fence>(fences.Length).ToPointer());
                    for(int index = 0; index < (uint)(fences.Length); index++)
                    {
                        fieldPointer[index] = fences[index].handle;
                    }
                    marshalledFences = fieldPointer;
                }
                else
                {
                    marshalledFences = null;
                }
                Interop.Commands.vkWaitForFences(this.handle, (uint)(fences?.Length ?? 0), marshalledFences, waitAll, timeout);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        public unsafe Semaphore CreateSemaphore(SemaphoreCreateInfo createInfo, AllocationCallbacks? allocator = null)
        {
            try
            {
                Semaphore result = default(Semaphore);
                Interop.SemaphoreCreateInfo* marshalledCreateInfo = default(Interop.SemaphoreCreateInfo*);
                Interop.AllocationCallbacks* marshalledAllocator = default(Interop.AllocationCallbacks*);
                Interop.Semaphore marshalledSemaphore = default(Interop.Semaphore);
                marshalledCreateInfo = (Interop.SemaphoreCreateInfo*)(Interop.HeapUtil.Allocate<Interop.SemaphoreCreateInfo>());
                createInfo.MarshalTo(marshalledCreateInfo);
                if (allocator != null)
                {
                    marshalledAllocator = (Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<Interop.AllocationCallbacks>());
                    allocator.Value.MarshalTo(marshalledAllocator);
                }
                Interop.Commands.vkCreateSemaphore(this.handle, marshalledCreateInfo, marshalledAllocator, &marshalledSemaphore);
                result = new Semaphore(this.handle, marshalledSemaphore);
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
        public unsafe Event CreateEvent(EventCreateInfo createInfo, AllocationCallbacks? allocator = null)
        {
            try
            {
                Event result = default(Event);
                Interop.EventCreateInfo* marshalledCreateInfo = default(Interop.EventCreateInfo*);
                Interop.AllocationCallbacks* marshalledAllocator = default(Interop.AllocationCallbacks*);
                Interop.Event marshalledEvent = default(Interop.Event);
                marshalledCreateInfo = (Interop.EventCreateInfo*)(Interop.HeapUtil.Allocate<Interop.EventCreateInfo>());
                createInfo.MarshalTo(marshalledCreateInfo);
                if (allocator != null)
                {
                    marshalledAllocator = (Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<Interop.AllocationCallbacks>());
                    allocator.Value.MarshalTo(marshalledAllocator);
                }
                Interop.Commands.vkCreateEvent(this.handle, marshalledCreateInfo, marshalledAllocator, &marshalledEvent);
                result = new Event(this.handle, marshalledEvent);
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
        public unsafe QueryPool CreateQueryPool(QueryPoolCreateInfo createInfo, AllocationCallbacks? allocator = null)
        {
            try
            {
                QueryPool result = default(QueryPool);
                Interop.QueryPoolCreateInfo* marshalledCreateInfo = default(Interop.QueryPoolCreateInfo*);
                Interop.AllocationCallbacks* marshalledAllocator = default(Interop.AllocationCallbacks*);
                Interop.QueryPool marshalledQueryPool = default(Interop.QueryPool);
                marshalledCreateInfo = (Interop.QueryPoolCreateInfo*)(Interop.HeapUtil.Allocate<Interop.QueryPoolCreateInfo>());
                createInfo.MarshalTo(marshalledCreateInfo);
                if (allocator != null)
                {
                    marshalledAllocator = (Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<Interop.AllocationCallbacks>());
                    allocator.Value.MarshalTo(marshalledAllocator);
                }
                Interop.Commands.vkCreateQueryPool(this.handle, marshalledCreateInfo, marshalledAllocator, &marshalledQueryPool);
                result = new QueryPool(this.handle, marshalledQueryPool);
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
        public unsafe Buffer CreateBuffer(BufferCreateInfo createInfo, AllocationCallbacks? allocator = null)
        {
            try
            {
                Buffer result = default(Buffer);
                Interop.BufferCreateInfo* marshalledCreateInfo = default(Interop.BufferCreateInfo*);
                Interop.AllocationCallbacks* marshalledAllocator = default(Interop.AllocationCallbacks*);
                Interop.Buffer marshalledBuffer = default(Interop.Buffer);
                marshalledCreateInfo = (Interop.BufferCreateInfo*)(Interop.HeapUtil.Allocate<Interop.BufferCreateInfo>());
                createInfo.MarshalTo(marshalledCreateInfo);
                if (allocator != null)
                {
                    marshalledAllocator = (Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<Interop.AllocationCallbacks>());
                    allocator.Value.MarshalTo(marshalledAllocator);
                }
                Interop.Commands.vkCreateBuffer(this.handle, marshalledCreateInfo, marshalledAllocator, &marshalledBuffer);
                result = new Buffer(this.handle, marshalledBuffer);
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
        public unsafe BufferView CreateBufferView(BufferViewCreateInfo createInfo, AllocationCallbacks? allocator = null)
        {
            try
            {
                BufferView result = default(BufferView);
                Interop.BufferViewCreateInfo* marshalledCreateInfo = default(Interop.BufferViewCreateInfo*);
                Interop.AllocationCallbacks* marshalledAllocator = default(Interop.AllocationCallbacks*);
                Interop.BufferView marshalledView = default(Interop.BufferView);
                marshalledCreateInfo = (Interop.BufferViewCreateInfo*)(Interop.HeapUtil.Allocate<Interop.BufferViewCreateInfo>());
                createInfo.MarshalTo(marshalledCreateInfo);
                if (allocator != null)
                {
                    marshalledAllocator = (Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<Interop.AllocationCallbacks>());
                    allocator.Value.MarshalTo(marshalledAllocator);
                }
                Interop.Commands.vkCreateBufferView(this.handle, marshalledCreateInfo, marshalledAllocator, &marshalledView);
                result = new BufferView(this.handle, marshalledView);
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
        public unsafe Image CreateImage(ImageCreateInfo createInfo, AllocationCallbacks? allocator = null)
        {
            try
            {
                Image result = default(Image);
                Interop.ImageCreateInfo* marshalledCreateInfo = default(Interop.ImageCreateInfo*);
                Interop.AllocationCallbacks* marshalledAllocator = default(Interop.AllocationCallbacks*);
                Interop.Image marshalledImage = default(Interop.Image);
                marshalledCreateInfo = (Interop.ImageCreateInfo*)(Interop.HeapUtil.Allocate<Interop.ImageCreateInfo>());
                createInfo.MarshalTo(marshalledCreateInfo);
                if (allocator != null)
                {
                    marshalledAllocator = (Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<Interop.AllocationCallbacks>());
                    allocator.Value.MarshalTo(marshalledAllocator);
                }
                Interop.Commands.vkCreateImage(this.handle, marshalledCreateInfo, marshalledAllocator, &marshalledImage);
                result = new Image(this.handle, marshalledImage);
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
        public unsafe ImageView CreateImageView(ImageViewCreateInfo createInfo, AllocationCallbacks? allocator = null)
        {
            try
            {
                ImageView result = default(ImageView);
                Interop.ImageViewCreateInfo* marshalledCreateInfo = default(Interop.ImageViewCreateInfo*);
                Interop.AllocationCallbacks* marshalledAllocator = default(Interop.AllocationCallbacks*);
                Interop.ImageView marshalledView = default(Interop.ImageView);
                marshalledCreateInfo = (Interop.ImageViewCreateInfo*)(Interop.HeapUtil.Allocate<Interop.ImageViewCreateInfo>());
                createInfo.MarshalTo(marshalledCreateInfo);
                if (allocator != null)
                {
                    marshalledAllocator = (Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<Interop.AllocationCallbacks>());
                    allocator.Value.MarshalTo(marshalledAllocator);
                }
                Interop.Commands.vkCreateImageView(this.handle, marshalledCreateInfo, marshalledAllocator, &marshalledView);
                result = new ImageView(this.handle, marshalledView);
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
        public unsafe ShaderModule CreateShaderModule(ShaderModuleCreateInfo createInfo, AllocationCallbacks? allocator = null)
        {
            try
            {
                ShaderModule result = default(ShaderModule);
                Interop.ShaderModuleCreateInfo* marshalledCreateInfo = default(Interop.ShaderModuleCreateInfo*);
                Interop.AllocationCallbacks* marshalledAllocator = default(Interop.AllocationCallbacks*);
                Interop.ShaderModule marshalledShaderModule = default(Interop.ShaderModule);
                marshalledCreateInfo = (Interop.ShaderModuleCreateInfo*)(Interop.HeapUtil.Allocate<Interop.ShaderModuleCreateInfo>());
                createInfo.MarshalTo(marshalledCreateInfo);
                if (allocator != null)
                {
                    marshalledAllocator = (Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<Interop.AllocationCallbacks>());
                    allocator.Value.MarshalTo(marshalledAllocator);
                }
                Interop.Commands.vkCreateShaderModule(this.handle, marshalledCreateInfo, marshalledAllocator, &marshalledShaderModule);
                result = new ShaderModule(this.handle, marshalledShaderModule);
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
        public unsafe PipelineCache CreatePipelineCache(PipelineCacheCreateInfo createInfo, AllocationCallbacks? allocator = null)
        {
            try
            {
                PipelineCache result = default(PipelineCache);
                Interop.PipelineCacheCreateInfo* marshalledCreateInfo = default(Interop.PipelineCacheCreateInfo*);
                Interop.AllocationCallbacks* marshalledAllocator = default(Interop.AllocationCallbacks*);
                Interop.PipelineCache marshalledPipelineCache = default(Interop.PipelineCache);
                marshalledCreateInfo = (Interop.PipelineCacheCreateInfo*)(Interop.HeapUtil.Allocate<Interop.PipelineCacheCreateInfo>());
                createInfo.MarshalTo(marshalledCreateInfo);
                if (allocator != null)
                {
                    marshalledAllocator = (Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<Interop.AllocationCallbacks>());
                    allocator.Value.MarshalTo(marshalledAllocator);
                }
                Interop.Commands.vkCreatePipelineCache(this.handle, marshalledCreateInfo, marshalledAllocator, &marshalledPipelineCache);
                result = new PipelineCache(this.handle, marshalledPipelineCache);
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
        public unsafe PipelineLayout CreatePipelineLayout(PipelineLayoutCreateInfo createInfo, AllocationCallbacks? allocator = null)
        {
            try
            {
                PipelineLayout result = default(PipelineLayout);
                Interop.PipelineLayoutCreateInfo* marshalledCreateInfo = default(Interop.PipelineLayoutCreateInfo*);
                Interop.AllocationCallbacks* marshalledAllocator = default(Interop.AllocationCallbacks*);
                Interop.PipelineLayout marshalledPipelineLayout = default(Interop.PipelineLayout);
                marshalledCreateInfo = (Interop.PipelineLayoutCreateInfo*)(Interop.HeapUtil.Allocate<Interop.PipelineLayoutCreateInfo>());
                createInfo.MarshalTo(marshalledCreateInfo);
                if (allocator != null)
                {
                    marshalledAllocator = (Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<Interop.AllocationCallbacks>());
                    allocator.Value.MarshalTo(marshalledAllocator);
                }
                Interop.Commands.vkCreatePipelineLayout(this.handle, marshalledCreateInfo, marshalledAllocator, &marshalledPipelineLayout);
                result = new PipelineLayout(this.handle, marshalledPipelineLayout);
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
        public unsafe Sampler CreateSampler(SamplerCreateInfo createInfo, AllocationCallbacks? allocator = null)
        {
            try
            {
                Sampler result = default(Sampler);
                Interop.SamplerCreateInfo* marshalledCreateInfo = default(Interop.SamplerCreateInfo*);
                Interop.AllocationCallbacks* marshalledAllocator = default(Interop.AllocationCallbacks*);
                Interop.Sampler marshalledSampler = default(Interop.Sampler);
                marshalledCreateInfo = (Interop.SamplerCreateInfo*)(Interop.HeapUtil.Allocate<Interop.SamplerCreateInfo>());
                createInfo.MarshalTo(marshalledCreateInfo);
                if (allocator != null)
                {
                    marshalledAllocator = (Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<Interop.AllocationCallbacks>());
                    allocator.Value.MarshalTo(marshalledAllocator);
                }
                Interop.Commands.vkCreateSampler(this.handle, marshalledCreateInfo, marshalledAllocator, &marshalledSampler);
                result = new Sampler(this.handle, marshalledSampler);
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
        public unsafe DescriptorSetLayout CreateDescriptorSetLayout(DescriptorSetLayoutCreateInfo createInfo, AllocationCallbacks? allocator = null)
        {
            try
            {
                DescriptorSetLayout result = default(DescriptorSetLayout);
                Interop.DescriptorSetLayoutCreateInfo* marshalledCreateInfo = default(Interop.DescriptorSetLayoutCreateInfo*);
                Interop.AllocationCallbacks* marshalledAllocator = default(Interop.AllocationCallbacks*);
                Interop.DescriptorSetLayout marshalledSetLayout = default(Interop.DescriptorSetLayout);
                marshalledCreateInfo = (Interop.DescriptorSetLayoutCreateInfo*)(Interop.HeapUtil.Allocate<Interop.DescriptorSetLayoutCreateInfo>());
                createInfo.MarshalTo(marshalledCreateInfo);
                if (allocator != null)
                {
                    marshalledAllocator = (Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<Interop.AllocationCallbacks>());
                    allocator.Value.MarshalTo(marshalledAllocator);
                }
                Interop.Commands.vkCreateDescriptorSetLayout(this.handle, marshalledCreateInfo, marshalledAllocator, &marshalledSetLayout);
                result = new DescriptorSetLayout(this.handle, marshalledSetLayout);
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
        public unsafe DescriptorPool CreateDescriptorPool(DescriptorPoolCreateInfo createInfo, AllocationCallbacks? allocator = null)
        {
            try
            {
                DescriptorPool result = default(DescriptorPool);
                Interop.DescriptorPoolCreateInfo* marshalledCreateInfo = default(Interop.DescriptorPoolCreateInfo*);
                Interop.AllocationCallbacks* marshalledAllocator = default(Interop.AllocationCallbacks*);
                Interop.DescriptorPool marshalledDescriptorPool = default(Interop.DescriptorPool);
                marshalledCreateInfo = (Interop.DescriptorPoolCreateInfo*)(Interop.HeapUtil.Allocate<Interop.DescriptorPoolCreateInfo>());
                createInfo.MarshalTo(marshalledCreateInfo);
                if (allocator != null)
                {
                    marshalledAllocator = (Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<Interop.AllocationCallbacks>());
                    allocator.Value.MarshalTo(marshalledAllocator);
                }
                Interop.Commands.vkCreateDescriptorPool(this.handle, marshalledCreateInfo, marshalledAllocator, &marshalledDescriptorPool);
                result = new DescriptorPool(this.handle, marshalledDescriptorPool);
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
        public unsafe DescriptorSet[] AllocateDescriptorSets(DescriptorSetAllocateInfo allocateInfo)
        {
            try
            {
                DescriptorSet[] result = default(DescriptorSet[]);
                Interop.DescriptorSetAllocateInfo* marshalledAllocateInfo = default(Interop.DescriptorSetAllocateInfo*);
                Interop.DescriptorSet* marshalledDescriptorSets = default(Interop.DescriptorSet*);
                marshalledAllocateInfo = (Interop.DescriptorSetAllocateInfo*)(Interop.HeapUtil.Allocate<Interop.DescriptorSetAllocateInfo>());
                allocateInfo.MarshalTo(marshalledAllocateInfo);
                Interop.Commands.vkAllocateDescriptorSets(this.handle, marshalledAllocateInfo, marshalledDescriptorSets);
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
        public unsafe void UpdateDescriptorSets(WriteDescriptorSet[] descriptorWrites, CopyDescriptorSet[] descriptorCopies)
        {
            try
            {
                Interop.WriteDescriptorSet* marshalledDescriptorWrites = default(Interop.WriteDescriptorSet*);
                Interop.CopyDescriptorSet* marshalledDescriptorCopies = default(Interop.CopyDescriptorSet*);
                if (descriptorWrites != null)
                {
                    var fieldPointer = (Interop.WriteDescriptorSet*)(Interop.HeapUtil.AllocateAndClear<Interop.WriteDescriptorSet>(descriptorWrites.Length).ToPointer());
                    for(int index = 0; index < (uint)(descriptorWrites.Length); index++)
                    {
                        descriptorWrites[index].MarshalTo(&fieldPointer[index]);
                    }
                    marshalledDescriptorWrites = fieldPointer;
                }
                else
                {
                    marshalledDescriptorWrites = null;
                }
                if (descriptorCopies != null)
                {
                    var fieldPointer = (Interop.CopyDescriptorSet*)(Interop.HeapUtil.AllocateAndClear<Interop.CopyDescriptorSet>(descriptorCopies.Length).ToPointer());
                    for(int index = 0; index < (uint)(descriptorCopies.Length); index++)
                    {
                        descriptorCopies[index].MarshalTo(&fieldPointer[index]);
                    }
                    marshalledDescriptorCopies = fieldPointer;
                }
                else
                {
                    marshalledDescriptorCopies = null;
                }
                Interop.Commands.vkUpdateDescriptorSets(this.handle, (uint)(descriptorWrites?.Length ?? 0), marshalledDescriptorWrites, (uint)(descriptorCopies?.Length ?? 0), marshalledDescriptorCopies);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        public unsafe Framebuffer CreateFramebuffer(FramebufferCreateInfo createInfo, AllocationCallbacks? allocator = null)
        {
            try
            {
                Framebuffer result = default(Framebuffer);
                Interop.FramebufferCreateInfo* marshalledCreateInfo = default(Interop.FramebufferCreateInfo*);
                Interop.AllocationCallbacks* marshalledAllocator = default(Interop.AllocationCallbacks*);
                Interop.Framebuffer marshalledFramebuffer = default(Interop.Framebuffer);
                marshalledCreateInfo = (Interop.FramebufferCreateInfo*)(Interop.HeapUtil.Allocate<Interop.FramebufferCreateInfo>());
                createInfo.MarshalTo(marshalledCreateInfo);
                if (allocator != null)
                {
                    marshalledAllocator = (Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<Interop.AllocationCallbacks>());
                    allocator.Value.MarshalTo(marshalledAllocator);
                }
                Interop.Commands.vkCreateFramebuffer(this.handle, marshalledCreateInfo, marshalledAllocator, &marshalledFramebuffer);
                result = new Framebuffer(this.handle, marshalledFramebuffer);
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
        public unsafe RenderPass CreateRenderPass(RenderPassCreateInfo createInfo, AllocationCallbacks? allocator = null)
        {
            try
            {
                RenderPass result = default(RenderPass);
                Interop.RenderPassCreateInfo* marshalledCreateInfo = default(Interop.RenderPassCreateInfo*);
                Interop.AllocationCallbacks* marshalledAllocator = default(Interop.AllocationCallbacks*);
                Interop.RenderPass marshalledRenderPass = default(Interop.RenderPass);
                marshalledCreateInfo = (Interop.RenderPassCreateInfo*)(Interop.HeapUtil.Allocate<Interop.RenderPassCreateInfo>());
                createInfo.MarshalTo(marshalledCreateInfo);
                if (allocator != null)
                {
                    marshalledAllocator = (Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<Interop.AllocationCallbacks>());
                    allocator.Value.MarshalTo(marshalledAllocator);
                }
                Interop.Commands.vkCreateRenderPass(this.handle, marshalledCreateInfo, marshalledAllocator, &marshalledRenderPass);
                result = new RenderPass(this.handle, marshalledRenderPass);
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
        public unsafe CommandPool CreateCommandPool(CommandPoolCreateInfo createInfo, AllocationCallbacks? allocator = null)
        {
            try
            {
                CommandPool result = default(CommandPool);
                Interop.CommandPoolCreateInfo* marshalledCreateInfo = default(Interop.CommandPoolCreateInfo*);
                Interop.AllocationCallbacks* marshalledAllocator = default(Interop.AllocationCallbacks*);
                Interop.CommandPool marshalledCommandPool = default(Interop.CommandPool);
                marshalledCreateInfo = (Interop.CommandPoolCreateInfo*)(Interop.HeapUtil.Allocate<Interop.CommandPoolCreateInfo>());
                createInfo.MarshalTo(marshalledCreateInfo);
                if (allocator != null)
                {
                    marshalledAllocator = (Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<Interop.AllocationCallbacks>());
                    allocator.Value.MarshalTo(marshalledAllocator);
                }
                Interop.Commands.vkCreateCommandPool(this.handle, marshalledCreateInfo, marshalledAllocator, &marshalledCommandPool);
                result = new CommandPool(this.handle, marshalledCommandPool);
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
        public unsafe CommandBuffer[] AllocateCommandBuffers(CommandBufferAllocateInfo allocateInfo)
        {
            try
            {
                CommandBuffer[] result = default(CommandBuffer[]);
                Interop.CommandBufferAllocateInfo* marshalledAllocateInfo = default(Interop.CommandBufferAllocateInfo*);
                Interop.CommandBuffer* marshalledCommandBuffers = default(Interop.CommandBuffer*);
                marshalledAllocateInfo = (Interop.CommandBufferAllocateInfo*)(Interop.HeapUtil.Allocate<Interop.CommandBufferAllocateInfo>());
                allocateInfo.MarshalTo(marshalledAllocateInfo);
                Interop.Commands.vkAllocateCommandBuffers(this.handle, marshalledAllocateInfo, marshalledCommandBuffers);
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
    }
}
