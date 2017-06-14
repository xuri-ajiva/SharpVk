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
        public unsafe void Destroy(SharpVk.AllocationCallbacks? allocator = null)
        {
            try
            {
                SharpVk.Interop.AllocationCallbacks* marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                if (allocator != null)
                {
                    marshalledAllocator = (SharpVk.Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<SharpVk.Interop.AllocationCallbacks>());
                    allocator.Value.MarshalTo(marshalledAllocator);
                }
                else
                {
                    marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
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
        public unsafe SharpVk.Queue GetQueue(uint queueFamilyIndex, uint queueIndex)
        {
            try
            {
                SharpVk.Queue result = default(SharpVk.Queue);
                SharpVk.Interop.Queue marshalledQueue = default(SharpVk.Interop.Queue);
                Interop.Commands.vkGetDeviceQueue(this.handle, queueFamilyIndex, queueIndex, &marshalledQueue);
                result = new SharpVk.Queue(this.handle, marshalledQueue);
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
                Result methodResult = Interop.Commands.vkDeviceWaitIdle(this.handle);
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
        /// 
        /// </summary>
        public unsafe SharpVk.DeviceMemory AllocateMemory(SharpVk.MemoryAllocateInfo allocateInfo, SharpVk.AllocationCallbacks? allocator = null)
        {
            try
            {
                SharpVk.DeviceMemory result = default(SharpVk.DeviceMemory);
                SharpVk.Interop.MemoryAllocateInfo* marshalledAllocateInfo = default(SharpVk.Interop.MemoryAllocateInfo*);
                SharpVk.Interop.AllocationCallbacks* marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                SharpVk.Interop.DeviceMemory marshalledMemory = default(SharpVk.Interop.DeviceMemory);
                marshalledAllocateInfo = (SharpVk.Interop.MemoryAllocateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.MemoryAllocateInfo>());
                allocateInfo.MarshalTo(marshalledAllocateInfo);
                if (allocator != null)
                {
                    marshalledAllocator = (SharpVk.Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<SharpVk.Interop.AllocationCallbacks>());
                    allocator.Value.MarshalTo(marshalledAllocator);
                }
                else
                {
                    marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                }
                Result methodResult = Interop.Commands.vkAllocateMemory(this.handle, marshalledAllocateInfo, marshalledAllocator, &marshalledMemory);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = new SharpVk.DeviceMemory(this.handle, marshalledMemory);
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
        public unsafe void FlushMappedMemoryRanges(SharpVk.MappedMemoryRange[] memoryRanges)
        {
            try
            {
                SharpVk.Interop.MappedMemoryRange* marshalledMemoryRanges = default(SharpVk.Interop.MappedMemoryRange*);
                if (memoryRanges != null)
                {
                    var fieldPointer = (SharpVk.Interop.MappedMemoryRange*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.MappedMemoryRange>(memoryRanges.Length).ToPointer());
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
                Result methodResult = Interop.Commands.vkFlushMappedMemoryRanges(this.handle, (uint)(memoryRanges?.Length ?? 0), marshalledMemoryRanges);
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
        /// 
        /// </summary>
        public unsafe void InvalidateMappedMemoryRanges(SharpVk.MappedMemoryRange[] memoryRanges)
        {
            try
            {
                SharpVk.Interop.MappedMemoryRange* marshalledMemoryRanges = default(SharpVk.Interop.MappedMemoryRange*);
                if (memoryRanges != null)
                {
                    var fieldPointer = (SharpVk.Interop.MappedMemoryRange*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.MappedMemoryRange>(memoryRanges.Length).ToPointer());
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
                Result methodResult = Interop.Commands.vkInvalidateMappedMemoryRanges(this.handle, (uint)(memoryRanges?.Length ?? 0), marshalledMemoryRanges);
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
        /// 
        /// </summary>
        public unsafe SharpVk.Fence CreateFence(SharpVk.FenceCreateInfo createInfo, SharpVk.AllocationCallbacks? allocator = null)
        {
            try
            {
                SharpVk.Fence result = default(SharpVk.Fence);
                SharpVk.Interop.FenceCreateInfo* marshalledCreateInfo = default(SharpVk.Interop.FenceCreateInfo*);
                SharpVk.Interop.AllocationCallbacks* marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                SharpVk.Interop.Fence marshalledFence = default(SharpVk.Interop.Fence);
                marshalledCreateInfo = (SharpVk.Interop.FenceCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.FenceCreateInfo>());
                createInfo.MarshalTo(marshalledCreateInfo);
                if (allocator != null)
                {
                    marshalledAllocator = (SharpVk.Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<SharpVk.Interop.AllocationCallbacks>());
                    allocator.Value.MarshalTo(marshalledAllocator);
                }
                else
                {
                    marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                }
                Result methodResult = Interop.Commands.vkCreateFence(this.handle, marshalledCreateInfo, marshalledAllocator, &marshalledFence);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = new SharpVk.Fence(this.handle, marshalledFence);
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
        public unsafe void ResetFences(SharpVk.Fence[] fences)
        {
            try
            {
                SharpVk.Interop.Fence* marshalledFences = default(SharpVk.Interop.Fence*);
                if (fences != null)
                {
                    var fieldPointer = (SharpVk.Interop.Fence*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.Fence>(fences.Length).ToPointer());
                    for(int index = 0; index < (uint)(fences.Length); index++)
                    {
                        fieldPointer[index] = fences[index]?.handle ?? default(SharpVk.Interop.Fence);
                    }
                    marshalledFences = fieldPointer;
                }
                else
                {
                    marshalledFences = null;
                }
                Result methodResult = Interop.Commands.vkResetFences(this.handle, (uint)(fences?.Length ?? 0), marshalledFences);
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
        /// 
        /// </summary>
        public unsafe void WaitForFences(SharpVk.Fence[] fences, Bool32 waitAll, ulong timeout)
        {
            try
            {
                SharpVk.Interop.Fence* marshalledFences = default(SharpVk.Interop.Fence*);
                if (fences != null)
                {
                    var fieldPointer = (SharpVk.Interop.Fence*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.Fence>(fences.Length).ToPointer());
                    for(int index = 0; index < (uint)(fences.Length); index++)
                    {
                        fieldPointer[index] = fences[index]?.handle ?? default(SharpVk.Interop.Fence);
                    }
                    marshalledFences = fieldPointer;
                }
                else
                {
                    marshalledFences = null;
                }
                Result methodResult = Interop.Commands.vkWaitForFences(this.handle, (uint)(fences?.Length ?? 0), marshalledFences, waitAll, timeout);
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
        /// 
        /// </summary>
        public unsafe SharpVk.Semaphore CreateSemaphore(SharpVk.SemaphoreCreateInfo createInfo, SharpVk.AllocationCallbacks? allocator = null)
        {
            try
            {
                SharpVk.Semaphore result = default(SharpVk.Semaphore);
                SharpVk.Interop.SemaphoreCreateInfo* marshalledCreateInfo = default(SharpVk.Interop.SemaphoreCreateInfo*);
                SharpVk.Interop.AllocationCallbacks* marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                SharpVk.Interop.Semaphore marshalledSemaphore = default(SharpVk.Interop.Semaphore);
                marshalledCreateInfo = (SharpVk.Interop.SemaphoreCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.SemaphoreCreateInfo>());
                createInfo.MarshalTo(marshalledCreateInfo);
                if (allocator != null)
                {
                    marshalledAllocator = (SharpVk.Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<SharpVk.Interop.AllocationCallbacks>());
                    allocator.Value.MarshalTo(marshalledAllocator);
                }
                else
                {
                    marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                }
                Result methodResult = Interop.Commands.vkCreateSemaphore(this.handle, marshalledCreateInfo, marshalledAllocator, &marshalledSemaphore);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = new SharpVk.Semaphore(this.handle, marshalledSemaphore);
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
        public unsafe SharpVk.Event CreateEvent(SharpVk.EventCreateInfo createInfo, SharpVk.AllocationCallbacks? allocator = null)
        {
            try
            {
                SharpVk.Event result = default(SharpVk.Event);
                SharpVk.Interop.EventCreateInfo* marshalledCreateInfo = default(SharpVk.Interop.EventCreateInfo*);
                SharpVk.Interop.AllocationCallbacks* marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                SharpVk.Interop.Event marshalledEvent = default(SharpVk.Interop.Event);
                marshalledCreateInfo = (SharpVk.Interop.EventCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.EventCreateInfo>());
                createInfo.MarshalTo(marshalledCreateInfo);
                if (allocator != null)
                {
                    marshalledAllocator = (SharpVk.Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<SharpVk.Interop.AllocationCallbacks>());
                    allocator.Value.MarshalTo(marshalledAllocator);
                }
                else
                {
                    marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                }
                Result methodResult = Interop.Commands.vkCreateEvent(this.handle, marshalledCreateInfo, marshalledAllocator, &marshalledEvent);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = new SharpVk.Event(this.handle, marshalledEvent);
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
        public unsafe SharpVk.QueryPool CreateQueryPool(SharpVk.QueryPoolCreateInfo createInfo, SharpVk.AllocationCallbacks? allocator = null)
        {
            try
            {
                SharpVk.QueryPool result = default(SharpVk.QueryPool);
                SharpVk.Interop.QueryPoolCreateInfo* marshalledCreateInfo = default(SharpVk.Interop.QueryPoolCreateInfo*);
                SharpVk.Interop.AllocationCallbacks* marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                SharpVk.Interop.QueryPool marshalledQueryPool = default(SharpVk.Interop.QueryPool);
                marshalledCreateInfo = (SharpVk.Interop.QueryPoolCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.QueryPoolCreateInfo>());
                createInfo.MarshalTo(marshalledCreateInfo);
                if (allocator != null)
                {
                    marshalledAllocator = (SharpVk.Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<SharpVk.Interop.AllocationCallbacks>());
                    allocator.Value.MarshalTo(marshalledAllocator);
                }
                else
                {
                    marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                }
                Result methodResult = Interop.Commands.vkCreateQueryPool(this.handle, marshalledCreateInfo, marshalledAllocator, &marshalledQueryPool);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = new SharpVk.QueryPool(this.handle, marshalledQueryPool);
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
        public unsafe SharpVk.Buffer CreateBuffer(SharpVk.BufferCreateInfo createInfo, SharpVk.AllocationCallbacks? allocator = null)
        {
            try
            {
                SharpVk.Buffer result = default(SharpVk.Buffer);
                SharpVk.Interop.BufferCreateInfo* marshalledCreateInfo = default(SharpVk.Interop.BufferCreateInfo*);
                SharpVk.Interop.AllocationCallbacks* marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                SharpVk.Interop.Buffer marshalledBuffer = default(SharpVk.Interop.Buffer);
                marshalledCreateInfo = (SharpVk.Interop.BufferCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.BufferCreateInfo>());
                createInfo.MarshalTo(marshalledCreateInfo);
                if (allocator != null)
                {
                    marshalledAllocator = (SharpVk.Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<SharpVk.Interop.AllocationCallbacks>());
                    allocator.Value.MarshalTo(marshalledAllocator);
                }
                else
                {
                    marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                }
                Result methodResult = Interop.Commands.vkCreateBuffer(this.handle, marshalledCreateInfo, marshalledAllocator, &marshalledBuffer);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = new SharpVk.Buffer(this.handle, marshalledBuffer);
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
        public unsafe SharpVk.BufferView CreateBufferView(SharpVk.BufferViewCreateInfo createInfo, SharpVk.AllocationCallbacks? allocator = null)
        {
            try
            {
                SharpVk.BufferView result = default(SharpVk.BufferView);
                SharpVk.Interop.BufferViewCreateInfo* marshalledCreateInfo = default(SharpVk.Interop.BufferViewCreateInfo*);
                SharpVk.Interop.AllocationCallbacks* marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                SharpVk.Interop.BufferView marshalledView = default(SharpVk.Interop.BufferView);
                marshalledCreateInfo = (SharpVk.Interop.BufferViewCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.BufferViewCreateInfo>());
                createInfo.MarshalTo(marshalledCreateInfo);
                if (allocator != null)
                {
                    marshalledAllocator = (SharpVk.Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<SharpVk.Interop.AllocationCallbacks>());
                    allocator.Value.MarshalTo(marshalledAllocator);
                }
                else
                {
                    marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                }
                Result methodResult = Interop.Commands.vkCreateBufferView(this.handle, marshalledCreateInfo, marshalledAllocator, &marshalledView);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = new SharpVk.BufferView(this.handle, marshalledView);
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
        public unsafe SharpVk.Image CreateImage(SharpVk.ImageCreateInfo createInfo, SharpVk.AllocationCallbacks? allocator = null)
        {
            try
            {
                SharpVk.Image result = default(SharpVk.Image);
                SharpVk.Interop.ImageCreateInfo* marshalledCreateInfo = default(SharpVk.Interop.ImageCreateInfo*);
                SharpVk.Interop.AllocationCallbacks* marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                SharpVk.Interop.Image marshalledImage = default(SharpVk.Interop.Image);
                marshalledCreateInfo = (SharpVk.Interop.ImageCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.ImageCreateInfo>());
                createInfo.MarshalTo(marshalledCreateInfo);
                if (allocator != null)
                {
                    marshalledAllocator = (SharpVk.Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<SharpVk.Interop.AllocationCallbacks>());
                    allocator.Value.MarshalTo(marshalledAllocator);
                }
                else
                {
                    marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                }
                Result methodResult = Interop.Commands.vkCreateImage(this.handle, marshalledCreateInfo, marshalledAllocator, &marshalledImage);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = new SharpVk.Image(this.handle, marshalledImage);
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
        public unsafe SharpVk.ImageView CreateImageView(SharpVk.ImageViewCreateInfo createInfo, SharpVk.AllocationCallbacks? allocator = null)
        {
            try
            {
                SharpVk.ImageView result = default(SharpVk.ImageView);
                SharpVk.Interop.ImageViewCreateInfo* marshalledCreateInfo = default(SharpVk.Interop.ImageViewCreateInfo*);
                SharpVk.Interop.AllocationCallbacks* marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                SharpVk.Interop.ImageView marshalledView = default(SharpVk.Interop.ImageView);
                marshalledCreateInfo = (SharpVk.Interop.ImageViewCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.ImageViewCreateInfo>());
                createInfo.MarshalTo(marshalledCreateInfo);
                if (allocator != null)
                {
                    marshalledAllocator = (SharpVk.Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<SharpVk.Interop.AllocationCallbacks>());
                    allocator.Value.MarshalTo(marshalledAllocator);
                }
                else
                {
                    marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                }
                Result methodResult = Interop.Commands.vkCreateImageView(this.handle, marshalledCreateInfo, marshalledAllocator, &marshalledView);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = new SharpVk.ImageView(this.handle, marshalledView);
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
        public unsafe SharpVk.ShaderModule CreateShaderModule(SharpVk.ShaderModuleCreateInfo createInfo, SharpVk.AllocationCallbacks? allocator = null)
        {
            try
            {
                SharpVk.ShaderModule result = default(SharpVk.ShaderModule);
                SharpVk.Interop.ShaderModuleCreateInfo* marshalledCreateInfo = default(SharpVk.Interop.ShaderModuleCreateInfo*);
                SharpVk.Interop.AllocationCallbacks* marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                SharpVk.Interop.ShaderModule marshalledShaderModule = default(SharpVk.Interop.ShaderModule);
                marshalledCreateInfo = (SharpVk.Interop.ShaderModuleCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.ShaderModuleCreateInfo>());
                createInfo.MarshalTo(marshalledCreateInfo);
                if (allocator != null)
                {
                    marshalledAllocator = (SharpVk.Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<SharpVk.Interop.AllocationCallbacks>());
                    allocator.Value.MarshalTo(marshalledAllocator);
                }
                else
                {
                    marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                }
                Result methodResult = Interop.Commands.vkCreateShaderModule(this.handle, marshalledCreateInfo, marshalledAllocator, &marshalledShaderModule);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = new SharpVk.ShaderModule(this.handle, marshalledShaderModule);
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
        public unsafe SharpVk.PipelineCache CreatePipelineCache(SharpVk.PipelineCacheCreateInfo createInfo, SharpVk.AllocationCallbacks? allocator = null)
        {
            try
            {
                SharpVk.PipelineCache result = default(SharpVk.PipelineCache);
                SharpVk.Interop.PipelineCacheCreateInfo* marshalledCreateInfo = default(SharpVk.Interop.PipelineCacheCreateInfo*);
                SharpVk.Interop.AllocationCallbacks* marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                SharpVk.Interop.PipelineCache marshalledPipelineCache = default(SharpVk.Interop.PipelineCache);
                marshalledCreateInfo = (SharpVk.Interop.PipelineCacheCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.PipelineCacheCreateInfo>());
                createInfo.MarshalTo(marshalledCreateInfo);
                if (allocator != null)
                {
                    marshalledAllocator = (SharpVk.Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<SharpVk.Interop.AllocationCallbacks>());
                    allocator.Value.MarshalTo(marshalledAllocator);
                }
                else
                {
                    marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                }
                Result methodResult = Interop.Commands.vkCreatePipelineCache(this.handle, marshalledCreateInfo, marshalledAllocator, &marshalledPipelineCache);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = new SharpVk.PipelineCache(this.handle, marshalledPipelineCache);
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
        public unsafe SharpVk.Pipeline[] CreateGraphicsPipelines(SharpVk.PipelineCache pipelineCache, SharpVk.GraphicsPipelineCreateInfo[] createInfos, SharpVk.AllocationCallbacks? allocator = null)
        {
            try
            {
                SharpVk.Pipeline[] result = default(SharpVk.Pipeline[]);
                uint createInfoCount = default(uint);
                SharpVk.Interop.GraphicsPipelineCreateInfo* marshalledCreateInfos = default(SharpVk.Interop.GraphicsPipelineCreateInfo*);
                SharpVk.Interop.AllocationCallbacks* marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                SharpVk.Interop.Pipeline* marshalledPipelines = default(SharpVk.Interop.Pipeline*);
                createInfoCount = (uint)(createInfos?.Length ?? 0);
                if (createInfos != null)
                {
                    var fieldPointer = (SharpVk.Interop.GraphicsPipelineCreateInfo*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.GraphicsPipelineCreateInfo>(createInfos.Length).ToPointer());
                    for(int index = 0; index < (uint)(createInfos.Length); index++)
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
                    marshalledAllocator = (SharpVk.Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<SharpVk.Interop.AllocationCallbacks>());
                    allocator.Value.MarshalTo(marshalledAllocator);
                }
                else
                {
                    marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                }
                marshalledPipelines = (SharpVk.Interop.Pipeline*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Pipeline>(createInfoCount));
                Result methodResult = Interop.Commands.vkCreateGraphicsPipelines(this.handle, pipelineCache?.handle ?? default(SharpVk.Interop.PipelineCache), createInfoCount, marshalledCreateInfos, marshalledAllocator, marshalledPipelines);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                if (marshalledPipelines != null)
                {
                    var fieldPointer = new SharpVk.Pipeline[(uint)(createInfoCount)];
                    for(int index = 0; index < (uint)(createInfoCount); index++)
                    {
                        fieldPointer[index] = new SharpVk.Pipeline(this.handle, marshalledPipelines[index]);
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
        /// 
        /// </summary>
        public unsafe SharpVk.Pipeline[] CreateComputePipelines(SharpVk.PipelineCache pipelineCache, SharpVk.ComputePipelineCreateInfo[] createInfos, SharpVk.AllocationCallbacks? allocator = null)
        {
            try
            {
                SharpVk.Pipeline[] result = default(SharpVk.Pipeline[]);
                uint createInfoCount = default(uint);
                SharpVk.Interop.ComputePipelineCreateInfo* marshalledCreateInfos = default(SharpVk.Interop.ComputePipelineCreateInfo*);
                SharpVk.Interop.AllocationCallbacks* marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                SharpVk.Interop.Pipeline* marshalledPipelines = default(SharpVk.Interop.Pipeline*);
                createInfoCount = (uint)(createInfos?.Length ?? 0);
                if (createInfos != null)
                {
                    var fieldPointer = (SharpVk.Interop.ComputePipelineCreateInfo*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.ComputePipelineCreateInfo>(createInfos.Length).ToPointer());
                    for(int index = 0; index < (uint)(createInfos.Length); index++)
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
                    marshalledAllocator = (SharpVk.Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<SharpVk.Interop.AllocationCallbacks>());
                    allocator.Value.MarshalTo(marshalledAllocator);
                }
                else
                {
                    marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                }
                marshalledPipelines = (SharpVk.Interop.Pipeline*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Pipeline>(createInfoCount));
                Result methodResult = Interop.Commands.vkCreateComputePipelines(this.handle, pipelineCache?.handle ?? default(SharpVk.Interop.PipelineCache), createInfoCount, marshalledCreateInfos, marshalledAllocator, marshalledPipelines);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                if (marshalledPipelines != null)
                {
                    var fieldPointer = new SharpVk.Pipeline[(uint)(createInfoCount)];
                    for(int index = 0; index < (uint)(createInfoCount); index++)
                    {
                        fieldPointer[index] = new SharpVk.Pipeline(this.handle, marshalledPipelines[index]);
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
        /// 
        /// </summary>
        public unsafe SharpVk.PipelineLayout CreatePipelineLayout(SharpVk.PipelineLayoutCreateInfo createInfo, SharpVk.AllocationCallbacks? allocator = null)
        {
            try
            {
                SharpVk.PipelineLayout result = default(SharpVk.PipelineLayout);
                SharpVk.Interop.PipelineLayoutCreateInfo* marshalledCreateInfo = default(SharpVk.Interop.PipelineLayoutCreateInfo*);
                SharpVk.Interop.AllocationCallbacks* marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                SharpVk.Interop.PipelineLayout marshalledPipelineLayout = default(SharpVk.Interop.PipelineLayout);
                marshalledCreateInfo = (SharpVk.Interop.PipelineLayoutCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.PipelineLayoutCreateInfo>());
                createInfo.MarshalTo(marshalledCreateInfo);
                if (allocator != null)
                {
                    marshalledAllocator = (SharpVk.Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<SharpVk.Interop.AllocationCallbacks>());
                    allocator.Value.MarshalTo(marshalledAllocator);
                }
                else
                {
                    marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                }
                Result methodResult = Interop.Commands.vkCreatePipelineLayout(this.handle, marshalledCreateInfo, marshalledAllocator, &marshalledPipelineLayout);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = new SharpVk.PipelineLayout(this.handle, marshalledPipelineLayout);
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
        public unsafe SharpVk.Sampler CreateSampler(SharpVk.SamplerCreateInfo createInfo, SharpVk.AllocationCallbacks? allocator = null)
        {
            try
            {
                SharpVk.Sampler result = default(SharpVk.Sampler);
                SharpVk.Interop.SamplerCreateInfo* marshalledCreateInfo = default(SharpVk.Interop.SamplerCreateInfo*);
                SharpVk.Interop.AllocationCallbacks* marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                SharpVk.Interop.Sampler marshalledSampler = default(SharpVk.Interop.Sampler);
                marshalledCreateInfo = (SharpVk.Interop.SamplerCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.SamplerCreateInfo>());
                createInfo.MarshalTo(marshalledCreateInfo);
                if (allocator != null)
                {
                    marshalledAllocator = (SharpVk.Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<SharpVk.Interop.AllocationCallbacks>());
                    allocator.Value.MarshalTo(marshalledAllocator);
                }
                else
                {
                    marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                }
                Result methodResult = Interop.Commands.vkCreateSampler(this.handle, marshalledCreateInfo, marshalledAllocator, &marshalledSampler);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = new SharpVk.Sampler(this.handle, marshalledSampler);
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
        public unsafe SharpVk.DescriptorSetLayout CreateDescriptorSetLayout(SharpVk.DescriptorSetLayoutCreateInfo createInfo, SharpVk.AllocationCallbacks? allocator = null)
        {
            try
            {
                SharpVk.DescriptorSetLayout result = default(SharpVk.DescriptorSetLayout);
                SharpVk.Interop.DescriptorSetLayoutCreateInfo* marshalledCreateInfo = default(SharpVk.Interop.DescriptorSetLayoutCreateInfo*);
                SharpVk.Interop.AllocationCallbacks* marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                SharpVk.Interop.DescriptorSetLayout marshalledSetLayout = default(SharpVk.Interop.DescriptorSetLayout);
                marshalledCreateInfo = (SharpVk.Interop.DescriptorSetLayoutCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.DescriptorSetLayoutCreateInfo>());
                createInfo.MarshalTo(marshalledCreateInfo);
                if (allocator != null)
                {
                    marshalledAllocator = (SharpVk.Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<SharpVk.Interop.AllocationCallbacks>());
                    allocator.Value.MarshalTo(marshalledAllocator);
                }
                else
                {
                    marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                }
                Result methodResult = Interop.Commands.vkCreateDescriptorSetLayout(this.handle, marshalledCreateInfo, marshalledAllocator, &marshalledSetLayout);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = new SharpVk.DescriptorSetLayout(this.handle, marshalledSetLayout);
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
        public unsafe SharpVk.DescriptorPool CreateDescriptorPool(SharpVk.DescriptorPoolCreateInfo createInfo, SharpVk.AllocationCallbacks? allocator = null)
        {
            try
            {
                SharpVk.DescriptorPool result = default(SharpVk.DescriptorPool);
                SharpVk.Interop.DescriptorPoolCreateInfo* marshalledCreateInfo = default(SharpVk.Interop.DescriptorPoolCreateInfo*);
                SharpVk.Interop.AllocationCallbacks* marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                SharpVk.Interop.DescriptorPool marshalledDescriptorPool = default(SharpVk.Interop.DescriptorPool);
                marshalledCreateInfo = (SharpVk.Interop.DescriptorPoolCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.DescriptorPoolCreateInfo>());
                createInfo.MarshalTo(marshalledCreateInfo);
                if (allocator != null)
                {
                    marshalledAllocator = (SharpVk.Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<SharpVk.Interop.AllocationCallbacks>());
                    allocator.Value.MarshalTo(marshalledAllocator);
                }
                else
                {
                    marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                }
                Result methodResult = Interop.Commands.vkCreateDescriptorPool(this.handle, marshalledCreateInfo, marshalledAllocator, &marshalledDescriptorPool);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = new SharpVk.DescriptorPool(this.handle, marshalledDescriptorPool);
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
        public unsafe SharpVk.DescriptorSet[] AllocateDescriptorSets(SharpVk.DescriptorSetAllocateInfo allocateInfo)
        {
            try
            {
                SharpVk.DescriptorSet[] result = default(SharpVk.DescriptorSet[]);
                SharpVk.Interop.DescriptorSetAllocateInfo* marshalledAllocateInfo = default(SharpVk.Interop.DescriptorSetAllocateInfo*);
                SharpVk.Interop.DescriptorSet* marshalledDescriptorSets = default(SharpVk.Interop.DescriptorSet*);
                marshalledAllocateInfo = (SharpVk.Interop.DescriptorSetAllocateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.DescriptorSetAllocateInfo>());
                allocateInfo.MarshalTo(marshalledAllocateInfo);
                marshalledDescriptorSets = (SharpVk.Interop.DescriptorSet*)(Interop.HeapUtil.Allocate<SharpVk.Interop.DescriptorSet>(allocateInfo.SetLayouts.Length));
                Result methodResult = Interop.Commands.vkAllocateDescriptorSets(this.handle, marshalledAllocateInfo, marshalledDescriptorSets);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                if (marshalledDescriptorSets != null)
                {
                    var fieldPointer = new SharpVk.DescriptorSet[(uint)(allocateInfo.SetLayouts.Length)];
                    for(int index = 0; index < (uint)(allocateInfo.SetLayouts.Length); index++)
                    {
                        fieldPointer[index] = new SharpVk.DescriptorSet(default(Interop.DescriptorPool), marshalledDescriptorSets[index]);
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
        /// 
        /// </summary>
        public unsafe void UpdateDescriptorSets(SharpVk.WriteDescriptorSet[] descriptorWrites, SharpVk.CopyDescriptorSet[] descriptorCopies)
        {
            try
            {
                SharpVk.Interop.WriteDescriptorSet* marshalledDescriptorWrites = default(SharpVk.Interop.WriteDescriptorSet*);
                SharpVk.Interop.CopyDescriptorSet* marshalledDescriptorCopies = default(SharpVk.Interop.CopyDescriptorSet*);
                if (descriptorWrites != null)
                {
                    var fieldPointer = (SharpVk.Interop.WriteDescriptorSet*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.WriteDescriptorSet>(descriptorWrites.Length).ToPointer());
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
                    var fieldPointer = (SharpVk.Interop.CopyDescriptorSet*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.CopyDescriptorSet>(descriptorCopies.Length).ToPointer());
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
        public unsafe SharpVk.Framebuffer CreateFramebuffer(SharpVk.FramebufferCreateInfo createInfo, SharpVk.AllocationCallbacks? allocator = null)
        {
            try
            {
                SharpVk.Framebuffer result = default(SharpVk.Framebuffer);
                SharpVk.Interop.FramebufferCreateInfo* marshalledCreateInfo = default(SharpVk.Interop.FramebufferCreateInfo*);
                SharpVk.Interop.AllocationCallbacks* marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                SharpVk.Interop.Framebuffer marshalledFramebuffer = default(SharpVk.Interop.Framebuffer);
                marshalledCreateInfo = (SharpVk.Interop.FramebufferCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.FramebufferCreateInfo>());
                createInfo.MarshalTo(marshalledCreateInfo);
                if (allocator != null)
                {
                    marshalledAllocator = (SharpVk.Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<SharpVk.Interop.AllocationCallbacks>());
                    allocator.Value.MarshalTo(marshalledAllocator);
                }
                else
                {
                    marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                }
                Result methodResult = Interop.Commands.vkCreateFramebuffer(this.handle, marshalledCreateInfo, marshalledAllocator, &marshalledFramebuffer);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = new SharpVk.Framebuffer(this.handle, marshalledFramebuffer);
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
        public unsafe SharpVk.RenderPass CreateRenderPass(SharpVk.RenderPassCreateInfo createInfo, SharpVk.AllocationCallbacks? allocator = null)
        {
            try
            {
                SharpVk.RenderPass result = default(SharpVk.RenderPass);
                SharpVk.Interop.RenderPassCreateInfo* marshalledCreateInfo = default(SharpVk.Interop.RenderPassCreateInfo*);
                SharpVk.Interop.AllocationCallbacks* marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                SharpVk.Interop.RenderPass marshalledRenderPass = default(SharpVk.Interop.RenderPass);
                marshalledCreateInfo = (SharpVk.Interop.RenderPassCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.RenderPassCreateInfo>());
                createInfo.MarshalTo(marshalledCreateInfo);
                if (allocator != null)
                {
                    marshalledAllocator = (SharpVk.Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<SharpVk.Interop.AllocationCallbacks>());
                    allocator.Value.MarshalTo(marshalledAllocator);
                }
                else
                {
                    marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                }
                Result methodResult = Interop.Commands.vkCreateRenderPass(this.handle, marshalledCreateInfo, marshalledAllocator, &marshalledRenderPass);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = new SharpVk.RenderPass(this.handle, marshalledRenderPass);
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
        public unsafe SharpVk.CommandPool CreateCommandPool(SharpVk.CommandPoolCreateInfo createInfo, SharpVk.AllocationCallbacks? allocator = null)
        {
            try
            {
                SharpVk.CommandPool result = default(SharpVk.CommandPool);
                SharpVk.Interop.CommandPoolCreateInfo* marshalledCreateInfo = default(SharpVk.Interop.CommandPoolCreateInfo*);
                SharpVk.Interop.AllocationCallbacks* marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                SharpVk.Interop.CommandPool marshalledCommandPool = default(SharpVk.Interop.CommandPool);
                marshalledCreateInfo = (SharpVk.Interop.CommandPoolCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.CommandPoolCreateInfo>());
                createInfo.MarshalTo(marshalledCreateInfo);
                if (allocator != null)
                {
                    marshalledAllocator = (SharpVk.Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<SharpVk.Interop.AllocationCallbacks>());
                    allocator.Value.MarshalTo(marshalledAllocator);
                }
                else
                {
                    marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                }
                Result methodResult = Interop.Commands.vkCreateCommandPool(this.handle, marshalledCreateInfo, marshalledAllocator, &marshalledCommandPool);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = new SharpVk.CommandPool(this.handle, marshalledCommandPool);
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
        public unsafe SharpVk.CommandBuffer[] AllocateCommandBuffers(SharpVk.CommandBufferAllocateInfo allocateInfo)
        {
            try
            {
                SharpVk.CommandBuffer[] result = default(SharpVk.CommandBuffer[]);
                SharpVk.Interop.CommandBufferAllocateInfo* marshalledAllocateInfo = default(SharpVk.Interop.CommandBufferAllocateInfo*);
                SharpVk.Interop.CommandBuffer* marshalledCommandBuffers = default(SharpVk.Interop.CommandBuffer*);
                marshalledAllocateInfo = (SharpVk.Interop.CommandBufferAllocateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.CommandBufferAllocateInfo>());
                allocateInfo.MarshalTo(marshalledAllocateInfo);
                marshalledCommandBuffers = (SharpVk.Interop.CommandBuffer*)(Interop.HeapUtil.Allocate<SharpVk.Interop.CommandBuffer>(allocateInfo.CommandBufferCount));
                Result methodResult = Interop.Commands.vkAllocateCommandBuffers(this.handle, marshalledAllocateInfo, marshalledCommandBuffers);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                if (marshalledCommandBuffers != null)
                {
                    var fieldPointer = new SharpVk.CommandBuffer[(uint)(allocateInfo.CommandBufferCount)];
                    for(int index = 0; index < (uint)(allocateInfo.CommandBufferCount); index++)
                    {
                        fieldPointer[index] = new SharpVk.CommandBuffer(default(Interop.CommandPool), marshalledCommandBuffers[index]);
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
    }
}
