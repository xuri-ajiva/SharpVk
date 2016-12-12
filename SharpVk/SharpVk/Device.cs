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
    /// Opaque handle to a device object.
    /// </summary>
    public partial class Device
        : IDisposable, IProcLookup
    {
        internal readonly Interop.Device handle; 
        
        internal readonly CommandCache commandCache; 
        
        private readonly PhysicalDevice parent; 
        
        internal AllocationCallbacks? Allocator
        {
            get
            {
                return this.parent.Allocator;
            }
        }
        
        internal Device(Interop.Device handle, PhysicalDevice parent)
        {
            this.handle = handle;
            this.parent = parent;
            this.commandCache = new CommandCache(this, "device", parent.commandCache);
        }
        
        /// <summary>
        /// Return a function pointer for a command.
        /// </summary>
        public IntPtr GetProcedureAddress(string name)
        {
            unsafe
            {
                try
                {
                    IntPtr result = default(IntPtr);
                    char* marshalledName = Interop.HeapUtil.MarshalTo(name);
                    result = Interop.Commands.vkGetDeviceProcAddr(this.handle, marshalledName);
                    return result;
                }
                finally
                {
                    Interop.HeapUtil.FreeLog();
                }
            }
        }
        
        /// <summary>
        /// Destroy a logical device.
        /// </summary>
        public void Destroy()
        {
            unsafe
            {
                try
                {
                    Interop.AllocationCallbacks marshalledAllocator;
                    if(this.parent.Allocator != null) marshalledAllocator = this.parent.Allocator.Value.Pack();
                    Interop.Commands.vkDestroyDevice(this.handle, this.parent.Allocator == null ? null : &marshalledAllocator);
                }
                finally
                {
                    Interop.HeapUtil.FreeLog();
                }
            }
        }
        
        /// <summary>
        /// Get a queue handle from a device.
        /// </summary>
        public Queue GetQueue(uint queueFamilyIndex, uint queueIndex)
        {
            unsafe
            {
                try
                {
                    Queue result = default(Queue);
                    Interop.Queue marshalledQueue;
                    Interop.Commands.vkGetDeviceQueue(this.handle, queueFamilyIndex, queueIndex, &marshalledQueue);
                    result = new Queue(marshalledQueue, this, this.commandCache);
                    return result;
                }
                finally
                {
                    Interop.HeapUtil.FreeLog();
                }
            }
        }
        
        /// <summary>
        /// Wait for a device to become idle.
        /// </summary>
        public void WaitIdle()
        {
            unsafe
            {
                try
                {
                    Result commandResult;
                    commandResult = Interop.Commands.vkDeviceWaitIdle(this.handle);
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
        
        /// <summary>
        /// Allocate GPU memory.
        /// </summary>
        public DeviceMemory AllocateMemory(MemoryAllocateInfo allocateInfo)
        {
            unsafe
            {
                try
                {
                    DeviceMemory result = default(DeviceMemory);
                    Result commandResult;
                    Interop.MemoryAllocateInfo marshalledAllocateInfo;
                    marshalledAllocateInfo = allocateInfo.Pack();
                    Interop.AllocationCallbacks marshalledAllocator;
                    if(this.parent.Allocator != null) marshalledAllocator = this.parent.Allocator.Value.Pack();
                    Interop.DeviceMemory marshalledMemory;
                    commandResult = Interop.Commands.vkAllocateMemory(this.handle, &marshalledAllocateInfo, this.parent.Allocator == null ? null : &marshalledAllocator, &marshalledMemory);
                    if (SharpVkException.IsError(commandResult))
                    {
                        throw SharpVkException.Create(commandResult);
                    }
                    result = new DeviceMemory(marshalledMemory, this, this.commandCache);
                    return result;
                }
                finally
                {
                    Interop.HeapUtil.FreeLog();
                }
            }
        }
        
        /// <summary>
        /// Free GPU memory.
        /// </summary>
        public void FreeMemory(DeviceMemory memory)
        {
            unsafe
            {
                try
                {
                    Interop.DeviceMemory marshalledMemory = memory?.Pack() ?? Interop.DeviceMemory.Null;
                    Interop.AllocationCallbacks marshalledAllocator;
                    if(this.parent.Allocator != null) marshalledAllocator = this.parent.Allocator.Value.Pack();
                    Interop.Commands.vkFreeMemory(this.handle, marshalledMemory, this.parent.Allocator == null ? null : &marshalledAllocator);
                }
                finally
                {
                    Interop.HeapUtil.FreeLog();
                }
            }
        }
        
        /// <summary>
        /// Flush mapped memory ranges.
        /// </summary>
        public void FlushMappedMemoryRanges(ArrayProxy<MappedMemoryRange> memoryRanges)
        {
            unsafe
            {
                try
                {
                    Result commandResult;
                    Interop.MappedMemoryRange* marshalledMemoryRanges = null;
                    if (memoryRanges.Contents != ProxyContents.Null)
                    {
                        Interop.MappedMemoryRange* arrayPointer = stackalloc Interop.MappedMemoryRange[memoryRanges.Length];
                        if(memoryRanges.Contents == ProxyContents.Single)
                        {
                            *arrayPointer = memoryRanges.GetSingleValue().Pack();
                        }
                        else
                        {
                            var arrayValue  = memoryRanges.GetArrayValue();
                            for (int index = 0; index < memoryRanges.Length; index++)
                            {
                                arrayPointer[index] = arrayValue.Array[arrayValue.Offset + index].Pack();
                            }
                        }
                        marshalledMemoryRanges = arrayPointer;
                    }
                    else
                    {
                        marshalledMemoryRanges = null;
                    }
                    commandResult = Interop.Commands.vkFlushMappedMemoryRanges(this.handle, (uint)(memoryRanges.Length), marshalledMemoryRanges);
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
        
        /// <summary>
        /// Invalidate ranges of mapped memory objects.
        /// </summary>
        public void InvalidateMappedMemoryRanges(ArrayProxy<MappedMemoryRange> memoryRanges)
        {
            unsafe
            {
                try
                {
                    Result commandResult;
                    Interop.MappedMemoryRange* marshalledMemoryRanges = null;
                    if (memoryRanges.Contents != ProxyContents.Null)
                    {
                        Interop.MappedMemoryRange* arrayPointer = stackalloc Interop.MappedMemoryRange[memoryRanges.Length];
                        if(memoryRanges.Contents == ProxyContents.Single)
                        {
                            *arrayPointer = memoryRanges.GetSingleValue().Pack();
                        }
                        else
                        {
                            var arrayValue  = memoryRanges.GetArrayValue();
                            for (int index = 0; index < memoryRanges.Length; index++)
                            {
                                arrayPointer[index] = arrayValue.Array[arrayValue.Offset + index].Pack();
                            }
                        }
                        marshalledMemoryRanges = arrayPointer;
                    }
                    else
                    {
                        marshalledMemoryRanges = null;
                    }
                    commandResult = Interop.Commands.vkInvalidateMappedMemoryRanges(this.handle, (uint)(memoryRanges.Length), marshalledMemoryRanges);
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
        
        /// <summary>
        /// Create a new fence object.
        /// </summary>
        public Fence CreateFence(FenceCreateInfo createInfo)
        {
            unsafe
            {
                try
                {
                    Fence result = default(Fence);
                    Result commandResult;
                    Interop.FenceCreateInfo marshalledCreateInfo;
                    marshalledCreateInfo = createInfo.Pack();
                    Interop.AllocationCallbacks marshalledAllocator;
                    if(this.parent.Allocator != null) marshalledAllocator = this.parent.Allocator.Value.Pack();
                    Interop.Fence marshalledFence;
                    commandResult = Interop.Commands.vkCreateFence(this.handle, &marshalledCreateInfo, this.parent.Allocator == null ? null : &marshalledAllocator, &marshalledFence);
                    if (SharpVkException.IsError(commandResult))
                    {
                        throw SharpVkException.Create(commandResult);
                    }
                    result = new Fence(marshalledFence, this, this.commandCache);
                    return result;
                }
                finally
                {
                    Interop.HeapUtil.FreeLog();
                }
            }
        }
        
        /// <summary>
        /// Resets one or more fence objects.
        /// </summary>
        public void ResetFences(ArrayProxy<Fence> fences)
        {
            unsafe
            {
                try
                {
                    Result commandResult;
                    Interop.Fence* marshalledFences = null;
                    if (fences.Contents != ProxyContents.Null)
                    {
                        Interop.Fence* arrayPointer = stackalloc Interop.Fence[fences.Length];
                        if(fences.Contents == ProxyContents.Single)
                        {
                            *arrayPointer = fences.GetSingleValue().Pack();
                        }
                        else
                        {
                            var arrayValue  = fences.GetArrayValue();
                            for (int index = 0; index < fences.Length; index++)
                            {
                                arrayPointer[index] = arrayValue.Array[arrayValue.Offset + index].Pack();
                            }
                        }
                        marshalledFences = arrayPointer;
                    }
                    else
                    {
                        marshalledFences = null;
                    }
                    commandResult = Interop.Commands.vkResetFences(this.handle, (uint)(fences.Length), marshalledFences);
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
        
        /// <summary>
        /// Wait for one or more fences to become signaled.
        /// </summary>
        public void WaitForFences(ArrayProxy<Fence> fences, Bool32 waitAll, ulong timeout)
        {
            unsafe
            {
                try
                {
                    Result commandResult;
                    Interop.Fence* marshalledFences = null;
                    if (fences.Contents != ProxyContents.Null)
                    {
                        Interop.Fence* arrayPointer = stackalloc Interop.Fence[fences.Length];
                        if(fences.Contents == ProxyContents.Single)
                        {
                            *arrayPointer = fences.GetSingleValue().Pack();
                        }
                        else
                        {
                            var arrayValue  = fences.GetArrayValue();
                            for (int index = 0; index < fences.Length; index++)
                            {
                                arrayPointer[index] = arrayValue.Array[arrayValue.Offset + index].Pack();
                            }
                        }
                        marshalledFences = arrayPointer;
                    }
                    else
                    {
                        marshalledFences = null;
                    }
                    commandResult = Interop.Commands.vkWaitForFences(this.handle, (uint)(fences.Length), marshalledFences, waitAll, timeout);
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
        
        /// <summary>
        /// Create a new queue semaphore object.
        /// </summary>
        public Semaphore CreateSemaphore(SemaphoreCreateInfo createInfo)
        {
            unsafe
            {
                try
                {
                    Semaphore result = default(Semaphore);
                    Result commandResult;
                    Interop.SemaphoreCreateInfo marshalledCreateInfo;
                    marshalledCreateInfo = createInfo.Pack();
                    Interop.AllocationCallbacks marshalledAllocator;
                    if(this.parent.Allocator != null) marshalledAllocator = this.parent.Allocator.Value.Pack();
                    Interop.Semaphore marshalledSemaphore;
                    commandResult = Interop.Commands.vkCreateSemaphore(this.handle, &marshalledCreateInfo, this.parent.Allocator == null ? null : &marshalledAllocator, &marshalledSemaphore);
                    if (SharpVkException.IsError(commandResult))
                    {
                        throw SharpVkException.Create(commandResult);
                    }
                    result = new Semaphore(marshalledSemaphore, this, this.commandCache);
                    return result;
                }
                finally
                {
                    Interop.HeapUtil.FreeLog();
                }
            }
        }
        
        /// <summary>
        /// Create a new event object.
        /// </summary>
        public Event CreateEvent(EventCreateInfo createInfo)
        {
            unsafe
            {
                try
                {
                    Event result = default(Event);
                    Result commandResult;
                    Interop.EventCreateInfo marshalledCreateInfo;
                    marshalledCreateInfo = createInfo.Pack();
                    Interop.AllocationCallbacks marshalledAllocator;
                    if(this.parent.Allocator != null) marshalledAllocator = this.parent.Allocator.Value.Pack();
                    Interop.Event marshalledEvent;
                    commandResult = Interop.Commands.vkCreateEvent(this.handle, &marshalledCreateInfo, this.parent.Allocator == null ? null : &marshalledAllocator, &marshalledEvent);
                    if (SharpVkException.IsError(commandResult))
                    {
                        throw SharpVkException.Create(commandResult);
                    }
                    result = new Event(marshalledEvent, this, this.commandCache);
                    return result;
                }
                finally
                {
                    Interop.HeapUtil.FreeLog();
                }
            }
        }
        
        /// <summary>
        /// Create a new query pool object.
        /// </summary>
        public QueryPool CreateQueryPool(QueryPoolCreateInfo createInfo)
        {
            unsafe
            {
                try
                {
                    QueryPool result = default(QueryPool);
                    Result commandResult;
                    Interop.QueryPoolCreateInfo marshalledCreateInfo;
                    marshalledCreateInfo = createInfo.Pack();
                    Interop.AllocationCallbacks marshalledAllocator;
                    if(this.parent.Allocator != null) marshalledAllocator = this.parent.Allocator.Value.Pack();
                    Interop.QueryPool marshalledQueryPool;
                    commandResult = Interop.Commands.vkCreateQueryPool(this.handle, &marshalledCreateInfo, this.parent.Allocator == null ? null : &marshalledAllocator, &marshalledQueryPool);
                    if (SharpVkException.IsError(commandResult))
                    {
                        throw SharpVkException.Create(commandResult);
                    }
                    result = new QueryPool(marshalledQueryPool, this, this.commandCache);
                    return result;
                }
                finally
                {
                    Interop.HeapUtil.FreeLog();
                }
            }
        }
        
        /// <summary>
        /// Create a new buffer object.
        /// </summary>
        public Buffer CreateBuffer(BufferCreateInfo createInfo)
        {
            unsafe
            {
                try
                {
                    Buffer result = default(Buffer);
                    Result commandResult;
                    Interop.BufferCreateInfo marshalledCreateInfo;
                    marshalledCreateInfo = createInfo.Pack();
                    Interop.AllocationCallbacks marshalledAllocator;
                    if(this.parent.Allocator != null) marshalledAllocator = this.parent.Allocator.Value.Pack();
                    Interop.Buffer marshalledBuffer;
                    commandResult = Interop.Commands.vkCreateBuffer(this.handle, &marshalledCreateInfo, this.parent.Allocator == null ? null : &marshalledAllocator, &marshalledBuffer);
                    if (SharpVkException.IsError(commandResult))
                    {
                        throw SharpVkException.Create(commandResult);
                    }
                    result = new Buffer(marshalledBuffer, this, this.commandCache);
                    return result;
                }
                finally
                {
                    Interop.HeapUtil.FreeLog();
                }
            }
        }
        
        /// <summary>
        /// Create a new buffer view object.
        /// </summary>
        public BufferView CreateBufferView(BufferViewCreateInfo createInfo)
        {
            unsafe
            {
                try
                {
                    BufferView result = default(BufferView);
                    Result commandResult;
                    Interop.BufferViewCreateInfo marshalledCreateInfo;
                    marshalledCreateInfo = createInfo.Pack();
                    Interop.AllocationCallbacks marshalledAllocator;
                    if(this.parent.Allocator != null) marshalledAllocator = this.parent.Allocator.Value.Pack();
                    Interop.BufferView marshalledView;
                    commandResult = Interop.Commands.vkCreateBufferView(this.handle, &marshalledCreateInfo, this.parent.Allocator == null ? null : &marshalledAllocator, &marshalledView);
                    if (SharpVkException.IsError(commandResult))
                    {
                        throw SharpVkException.Create(commandResult);
                    }
                    result = new BufferView(marshalledView, this, this.commandCache);
                    return result;
                }
                finally
                {
                    Interop.HeapUtil.FreeLog();
                }
            }
        }
        
        /// <summary>
        /// Create a new image object.
        /// </summary>
        public Image CreateImage(ImageCreateInfo createInfo)
        {
            unsafe
            {
                try
                {
                    Image result = default(Image);
                    Result commandResult;
                    Interop.ImageCreateInfo marshalledCreateInfo;
                    marshalledCreateInfo = createInfo.Pack();
                    Interop.AllocationCallbacks marshalledAllocator;
                    if(this.parent.Allocator != null) marshalledAllocator = this.parent.Allocator.Value.Pack();
                    Interop.Image marshalledImage;
                    commandResult = Interop.Commands.vkCreateImage(this.handle, &marshalledCreateInfo, this.parent.Allocator == null ? null : &marshalledAllocator, &marshalledImage);
                    if (SharpVkException.IsError(commandResult))
                    {
                        throw SharpVkException.Create(commandResult);
                    }
                    result = new Image(marshalledImage, this, this.commandCache);
                    return result;
                }
                finally
                {
                    Interop.HeapUtil.FreeLog();
                }
            }
        }
        
        /// <summary>
        /// Create an image view from an existing image.
        /// </summary>
        public ImageView CreateImageView(ImageViewCreateInfo createInfo)
        {
            unsafe
            {
                try
                {
                    ImageView result = default(ImageView);
                    Result commandResult;
                    Interop.ImageViewCreateInfo marshalledCreateInfo;
                    marshalledCreateInfo = createInfo.Pack();
                    Interop.AllocationCallbacks marshalledAllocator;
                    if(this.parent.Allocator != null) marshalledAllocator = this.parent.Allocator.Value.Pack();
                    Interop.ImageView marshalledView;
                    commandResult = Interop.Commands.vkCreateImageView(this.handle, &marshalledCreateInfo, this.parent.Allocator == null ? null : &marshalledAllocator, &marshalledView);
                    if (SharpVkException.IsError(commandResult))
                    {
                        throw SharpVkException.Create(commandResult);
                    }
                    result = new ImageView(marshalledView, this, this.commandCache);
                    return result;
                }
                finally
                {
                    Interop.HeapUtil.FreeLog();
                }
            }
        }
        
        /// <summary>
        /// Creates a new shader module object.
        /// </summary>
        public ShaderModule CreateShaderModule(ShaderModuleCreateInfo createInfo)
        {
            unsafe
            {
                try
                {
                    ShaderModule result = default(ShaderModule);
                    Result commandResult;
                    Interop.ShaderModuleCreateInfo marshalledCreateInfo;
                    marshalledCreateInfo = createInfo.Pack();
                    Interop.AllocationCallbacks marshalledAllocator;
                    if(this.parent.Allocator != null) marshalledAllocator = this.parent.Allocator.Value.Pack();
                    Interop.ShaderModule marshalledShaderModule;
                    commandResult = Interop.Commands.vkCreateShaderModule(this.handle, &marshalledCreateInfo, this.parent.Allocator == null ? null : &marshalledAllocator, &marshalledShaderModule);
                    if (SharpVkException.IsError(commandResult))
                    {
                        throw SharpVkException.Create(commandResult);
                    }
                    result = new ShaderModule(marshalledShaderModule, this, this.commandCache);
                    return result;
                }
                finally
                {
                    Interop.HeapUtil.FreeLog();
                }
            }
        }
        
        /// <summary>
        /// Creates a new pipeline cache.
        /// </summary>
        public PipelineCache CreatePipelineCache(PipelineCacheCreateInfo createInfo)
        {
            unsafe
            {
                try
                {
                    PipelineCache result = default(PipelineCache);
                    Result commandResult;
                    Interop.PipelineCacheCreateInfo marshalledCreateInfo;
                    marshalledCreateInfo = createInfo.Pack();
                    Interop.AllocationCallbacks marshalledAllocator;
                    if(this.parent.Allocator != null) marshalledAllocator = this.parent.Allocator.Value.Pack();
                    Interop.PipelineCache marshalledPipelineCache;
                    commandResult = Interop.Commands.vkCreatePipelineCache(this.handle, &marshalledCreateInfo, this.parent.Allocator == null ? null : &marshalledAllocator, &marshalledPipelineCache);
                    if (SharpVkException.IsError(commandResult))
                    {
                        throw SharpVkException.Create(commandResult);
                    }
                    result = new PipelineCache(marshalledPipelineCache, this, this.commandCache);
                    return result;
                }
                finally
                {
                    Interop.HeapUtil.FreeLog();
                }
            }
        }
        
        /// <summary>
        /// Create graphics pipelines.
        /// </summary>
        public Pipeline[] CreateGraphicsPipelines(PipelineCache pipelineCache, ArrayProxy<GraphicsPipelineCreateInfo> createInfos)
        {
            unsafe
            {
                try
                {
                    Pipeline[] result = default(Pipeline[]);
                    Result commandResult;
                    Interop.PipelineCache marshalledPipelineCache = pipelineCache?.Pack() ?? Interop.PipelineCache.Null;
                    Interop.GraphicsPipelineCreateInfo* marshalledCreateInfos = null;
                    if (createInfos.Contents != ProxyContents.Null)
                    {
                        Interop.GraphicsPipelineCreateInfo* arrayPointer = stackalloc Interop.GraphicsPipelineCreateInfo[createInfos.Length];
                        if(createInfos.Contents == ProxyContents.Single)
                        {
                            *arrayPointer = createInfos.GetSingleValue().Pack();
                        }
                        else
                        {
                            var arrayValue  = createInfos.GetArrayValue();
                            for (int index = 0; index < createInfos.Length; index++)
                            {
                                arrayPointer[index] = arrayValue.Array[arrayValue.Offset + index].Pack();
                            }
                        }
                        marshalledCreateInfos = arrayPointer;
                    }
                    else
                    {
                        marshalledCreateInfos = null;
                    }
                    Interop.AllocationCallbacks marshalledAllocator;
                    if(this.parent.Allocator != null) marshalledAllocator = this.parent.Allocator.Value.Pack();
                    Interop.Pipeline* marshalledPipelines = (Interop.Pipeline*)Interop.HeapUtil.Allocate<Interop.Pipeline>(createInfos.Length);
                    commandResult = Interop.Commands.vkCreateGraphicsPipelines(this.handle, marshalledPipelineCache, (uint)(createInfos.Length), marshalledCreateInfos, this.parent.Allocator == null ? null : &marshalledAllocator, marshalledPipelines);
                    if (SharpVkException.IsError(commandResult))
                    {
                        throw SharpVkException.Create(commandResult);
                    }
                    result = new Pipeline[(uint)createInfos.Length];
                    for(int index = 0; index < (uint)createInfos.Length; index++)
                    {
                    	result[index] = new Pipeline(marshalledPipelines[index], this, this.commandCache);
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
        /// Creates a new compute pipeline object.
        /// </summary>
        public Pipeline[] CreateComputePipelines(PipelineCache pipelineCache, ArrayProxy<ComputePipelineCreateInfo> createInfos)
        {
            unsafe
            {
                try
                {
                    Pipeline[] result = default(Pipeline[]);
                    Result commandResult;
                    Interop.PipelineCache marshalledPipelineCache = pipelineCache?.Pack() ?? Interop.PipelineCache.Null;
                    Interop.ComputePipelineCreateInfo* marshalledCreateInfos = null;
                    if (createInfos.Contents != ProxyContents.Null)
                    {
                        Interop.ComputePipelineCreateInfo* arrayPointer = stackalloc Interop.ComputePipelineCreateInfo[createInfos.Length];
                        if(createInfos.Contents == ProxyContents.Single)
                        {
                            *arrayPointer = createInfos.GetSingleValue().Pack();
                        }
                        else
                        {
                            var arrayValue  = createInfos.GetArrayValue();
                            for (int index = 0; index < createInfos.Length; index++)
                            {
                                arrayPointer[index] = arrayValue.Array[arrayValue.Offset + index].Pack();
                            }
                        }
                        marshalledCreateInfos = arrayPointer;
                    }
                    else
                    {
                        marshalledCreateInfos = null;
                    }
                    Interop.AllocationCallbacks marshalledAllocator;
                    if(this.parent.Allocator != null) marshalledAllocator = this.parent.Allocator.Value.Pack();
                    Interop.Pipeline* marshalledPipelines = (Interop.Pipeline*)Interop.HeapUtil.Allocate<Interop.Pipeline>(createInfos.Length);
                    commandResult = Interop.Commands.vkCreateComputePipelines(this.handle, marshalledPipelineCache, (uint)(createInfos.Length), marshalledCreateInfos, this.parent.Allocator == null ? null : &marshalledAllocator, marshalledPipelines);
                    if (SharpVkException.IsError(commandResult))
                    {
                        throw SharpVkException.Create(commandResult);
                    }
                    result = new Pipeline[(uint)createInfos.Length];
                    for(int index = 0; index < (uint)createInfos.Length; index++)
                    {
                    	result[index] = new Pipeline(marshalledPipelines[index], this, this.commandCache);
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
        /// Creates a new pipeline layout object.
        /// </summary>
        public PipelineLayout CreatePipelineLayout(PipelineLayoutCreateInfo createInfo)
        {
            unsafe
            {
                try
                {
                    PipelineLayout result = default(PipelineLayout);
                    Result commandResult;
                    Interop.PipelineLayoutCreateInfo marshalledCreateInfo;
                    marshalledCreateInfo = createInfo.Pack();
                    Interop.AllocationCallbacks marshalledAllocator;
                    if(this.parent.Allocator != null) marshalledAllocator = this.parent.Allocator.Value.Pack();
                    Interop.PipelineLayout marshalledPipelineLayout;
                    commandResult = Interop.Commands.vkCreatePipelineLayout(this.handle, &marshalledCreateInfo, this.parent.Allocator == null ? null : &marshalledAllocator, &marshalledPipelineLayout);
                    if (SharpVkException.IsError(commandResult))
                    {
                        throw SharpVkException.Create(commandResult);
                    }
                    result = new PipelineLayout(marshalledPipelineLayout, this, this.commandCache);
                    return result;
                }
                finally
                {
                    Interop.HeapUtil.FreeLog();
                }
            }
        }
        
        /// <summary>
        /// Create a new sampler object.
        /// </summary>
        public Sampler CreateSampler(SamplerCreateInfo createInfo)
        {
            unsafe
            {
                try
                {
                    Sampler result = default(Sampler);
                    Result commandResult;
                    Interop.SamplerCreateInfo marshalledCreateInfo;
                    marshalledCreateInfo = createInfo.Pack();
                    Interop.AllocationCallbacks marshalledAllocator;
                    if(this.parent.Allocator != null) marshalledAllocator = this.parent.Allocator.Value.Pack();
                    Interop.Sampler marshalledSampler;
                    commandResult = Interop.Commands.vkCreateSampler(this.handle, &marshalledCreateInfo, this.parent.Allocator == null ? null : &marshalledAllocator, &marshalledSampler);
                    if (SharpVkException.IsError(commandResult))
                    {
                        throw SharpVkException.Create(commandResult);
                    }
                    result = new Sampler(marshalledSampler, this, this.commandCache);
                    return result;
                }
                finally
                {
                    Interop.HeapUtil.FreeLog();
                }
            }
        }
        
        /// <summary>
        /// Create a new descriptor set layout.
        /// </summary>
        public DescriptorSetLayout CreateDescriptorSetLayout(DescriptorSetLayoutCreateInfo createInfo)
        {
            unsafe
            {
                try
                {
                    DescriptorSetLayout result = default(DescriptorSetLayout);
                    Result commandResult;
                    Interop.DescriptorSetLayoutCreateInfo marshalledCreateInfo;
                    marshalledCreateInfo = createInfo.Pack();
                    Interop.AllocationCallbacks marshalledAllocator;
                    if(this.parent.Allocator != null) marshalledAllocator = this.parent.Allocator.Value.Pack();
                    Interop.DescriptorSetLayout marshalledSetLayout;
                    commandResult = Interop.Commands.vkCreateDescriptorSetLayout(this.handle, &marshalledCreateInfo, this.parent.Allocator == null ? null : &marshalledAllocator, &marshalledSetLayout);
                    if (SharpVkException.IsError(commandResult))
                    {
                        throw SharpVkException.Create(commandResult);
                    }
                    result = new DescriptorSetLayout(marshalledSetLayout, this, this.commandCache);
                    return result;
                }
                finally
                {
                    Interop.HeapUtil.FreeLog();
                }
            }
        }
        
        /// <summary>
        /// Creates a descriptor pool object.
        /// </summary>
        public DescriptorPool CreateDescriptorPool(DescriptorPoolCreateInfo createInfo)
        {
            unsafe
            {
                try
                {
                    DescriptorPool result = default(DescriptorPool);
                    Result commandResult;
                    Interop.DescriptorPoolCreateInfo marshalledCreateInfo;
                    marshalledCreateInfo = createInfo.Pack();
                    Interop.AllocationCallbacks marshalledAllocator;
                    if(this.parent.Allocator != null) marshalledAllocator = this.parent.Allocator.Value.Pack();
                    Interop.DescriptorPool marshalledDescriptorPool;
                    commandResult = Interop.Commands.vkCreateDescriptorPool(this.handle, &marshalledCreateInfo, this.parent.Allocator == null ? null : &marshalledAllocator, &marshalledDescriptorPool);
                    if (SharpVkException.IsError(commandResult))
                    {
                        throw SharpVkException.Create(commandResult);
                    }
                    result = new DescriptorPool(marshalledDescriptorPool, this, this.commandCache);
                    return result;
                }
                finally
                {
                    Interop.HeapUtil.FreeLog();
                }
            }
        }
        
        /// <summary>
        /// Allocate one or more descriptor sets.
        /// </summary>
        public DescriptorSet[] AllocateDescriptorSets(DescriptorSetAllocateInfo allocateInfo)
        {
            unsafe
            {
                try
                {
                    DescriptorSet[] result = default(DescriptorSet[]);
                    Result commandResult;
                    Interop.DescriptorSetAllocateInfo marshalledAllocateInfo;
                    marshalledAllocateInfo = allocateInfo.Pack();
                    Interop.DescriptorSet* marshalledDescriptorSets = (Interop.DescriptorSet*)Interop.HeapUtil.Allocate<Interop.DescriptorSet>(allocateInfo.SetLayouts.Length);
                    commandResult = Interop.Commands.vkAllocateDescriptorSets(this.handle, &marshalledAllocateInfo, marshalledDescriptorSets);
                    if (SharpVkException.IsError(commandResult))
                    {
                        throw SharpVkException.Create(commandResult);
                    }
                    result = new DescriptorSet[(uint)allocateInfo.SetLayouts.Length];
                    for(int index = 0; index < (uint)allocateInfo.SetLayouts.Length; index++)
                    {
                    	result[index] = new DescriptorSet(marshalledDescriptorSets[index], allocateInfo.DescriptorPool, this.commandCache);
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
        /// Update the contents of a descriptor set object.
        /// </summary>
        public void UpdateDescriptorSets(ArrayProxy<WriteDescriptorSet> descriptorWrites, ArrayProxy<CopyDescriptorSet> descriptorCopies)
        {
            unsafe
            {
                try
                {
                    Interop.WriteDescriptorSet* marshalledDescriptorWrites = null;
                    if (descriptorWrites.Contents != ProxyContents.Null)
                    {
                        Interop.WriteDescriptorSet* arrayPointer = stackalloc Interop.WriteDescriptorSet[descriptorWrites.Length];
                        if(descriptorWrites.Contents == ProxyContents.Single)
                        {
                            *arrayPointer = descriptorWrites.GetSingleValue().Pack();
                        }
                        else
                        {
                            var arrayValue  = descriptorWrites.GetArrayValue();
                            for (int index = 0; index < descriptorWrites.Length; index++)
                            {
                                arrayPointer[index] = arrayValue.Array[arrayValue.Offset + index].Pack();
                            }
                        }
                        marshalledDescriptorWrites = arrayPointer;
                    }
                    else
                    {
                        marshalledDescriptorWrites = null;
                    }
                    Interop.CopyDescriptorSet* marshalledDescriptorCopies = null;
                    if (descriptorCopies.Contents != ProxyContents.Null)
                    {
                        Interop.CopyDescriptorSet* arrayPointer = stackalloc Interop.CopyDescriptorSet[descriptorCopies.Length];
                        if(descriptorCopies.Contents == ProxyContents.Single)
                        {
                            *arrayPointer = descriptorCopies.GetSingleValue().Pack();
                        }
                        else
                        {
                            var arrayValue  = descriptorCopies.GetArrayValue();
                            for (int index = 0; index < descriptorCopies.Length; index++)
                            {
                                arrayPointer[index] = arrayValue.Array[arrayValue.Offset + index].Pack();
                            }
                        }
                        marshalledDescriptorCopies = arrayPointer;
                    }
                    else
                    {
                        marshalledDescriptorCopies = null;
                    }
                    Interop.Commands.vkUpdateDescriptorSets(this.handle, (uint)(descriptorWrites.Length), marshalledDescriptorWrites, (uint)(descriptorCopies.Length), marshalledDescriptorCopies);
                }
                finally
                {
                    Interop.HeapUtil.FreeLog();
                }
            }
        }
        
        /// <summary>
        /// Create a new framebuffer object.
        /// </summary>
        public Framebuffer CreateFramebuffer(FramebufferCreateInfo createInfo)
        {
            unsafe
            {
                try
                {
                    Framebuffer result = default(Framebuffer);
                    Result commandResult;
                    Interop.FramebufferCreateInfo marshalledCreateInfo;
                    marshalledCreateInfo = createInfo.Pack();
                    Interop.AllocationCallbacks marshalledAllocator;
                    if(this.parent.Allocator != null) marshalledAllocator = this.parent.Allocator.Value.Pack();
                    Interop.Framebuffer marshalledFramebuffer;
                    commandResult = Interop.Commands.vkCreateFramebuffer(this.handle, &marshalledCreateInfo, this.parent.Allocator == null ? null : &marshalledAllocator, &marshalledFramebuffer);
                    if (SharpVkException.IsError(commandResult))
                    {
                        throw SharpVkException.Create(commandResult);
                    }
                    result = new Framebuffer(marshalledFramebuffer, this, this.commandCache);
                    return result;
                }
                finally
                {
                    Interop.HeapUtil.FreeLog();
                }
            }
        }
        
        /// <summary>
        /// Create a new render pass object.
        /// </summary>
        public RenderPass CreateRenderPass(RenderPassCreateInfo createInfo)
        {
            unsafe
            {
                try
                {
                    RenderPass result = default(RenderPass);
                    Result commandResult;
                    Interop.RenderPassCreateInfo marshalledCreateInfo;
                    marshalledCreateInfo = createInfo.Pack();
                    Interop.AllocationCallbacks marshalledAllocator;
                    if(this.parent.Allocator != null) marshalledAllocator = this.parent.Allocator.Value.Pack();
                    Interop.RenderPass marshalledRenderPass;
                    commandResult = Interop.Commands.vkCreateRenderPass(this.handle, &marshalledCreateInfo, this.parent.Allocator == null ? null : &marshalledAllocator, &marshalledRenderPass);
                    if (SharpVkException.IsError(commandResult))
                    {
                        throw SharpVkException.Create(commandResult);
                    }
                    result = new RenderPass(marshalledRenderPass, this, this.commandCache);
                    return result;
                }
                finally
                {
                    Interop.HeapUtil.FreeLog();
                }
            }
        }
        
        /// <summary>
        /// Create a new command pool object.
        /// </summary>
        public CommandPool CreateCommandPool(CommandPoolCreateInfo createInfo)
        {
            unsafe
            {
                try
                {
                    CommandPool result = default(CommandPool);
                    Result commandResult;
                    Interop.CommandPoolCreateInfo marshalledCreateInfo;
                    marshalledCreateInfo = createInfo.Pack();
                    Interop.AllocationCallbacks marshalledAllocator;
                    if(this.parent.Allocator != null) marshalledAllocator = this.parent.Allocator.Value.Pack();
                    Interop.CommandPool marshalledCommandPool;
                    commandResult = Interop.Commands.vkCreateCommandPool(this.handle, &marshalledCreateInfo, this.parent.Allocator == null ? null : &marshalledAllocator, &marshalledCommandPool);
                    if (SharpVkException.IsError(commandResult))
                    {
                        throw SharpVkException.Create(commandResult);
                    }
                    result = new CommandPool(marshalledCommandPool, this, this.commandCache);
                    return result;
                }
                finally
                {
                    Interop.HeapUtil.FreeLog();
                }
            }
        }
        
        /// <summary>
        /// Allocate command buffers from an existing command pool.
        /// </summary>
        public CommandBuffer[] AllocateCommandBuffers(CommandBufferAllocateInfo allocateInfo)
        {
            unsafe
            {
                try
                {
                    CommandBuffer[] result = default(CommandBuffer[]);
                    Result commandResult;
                    Interop.CommandBufferAllocateInfo marshalledAllocateInfo;
                    marshalledAllocateInfo = allocateInfo.Pack();
                    Interop.CommandBuffer* marshalledCommandBuffers = (Interop.CommandBuffer*)Interop.HeapUtil.Allocate<Interop.CommandBuffer>(allocateInfo.CommandBufferCount);
                    commandResult = Interop.Commands.vkAllocateCommandBuffers(this.handle, &marshalledAllocateInfo, marshalledCommandBuffers);
                    if (SharpVkException.IsError(commandResult))
                    {
                        throw SharpVkException.Create(commandResult);
                    }
                    result = new CommandBuffer[(uint)allocateInfo.CommandBufferCount];
                    for(int index = 0; index < (uint)allocateInfo.CommandBufferCount; index++)
                    {
                    	result[index] = new CommandBuffer(marshalledCommandBuffers[index], allocateInfo.CommandPool, this.commandCache);
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
        /// Create a swapchain.
        /// </summary>
        public Swapchain CreateSwapchain(SwapchainCreateInfo createInfo)
        {
            unsafe
            {
                try
                {
                    var commandDelegate = this.commandCache.GetCommandDelegate<Interop.vkCreateSwapchainKHR>("vkCreateSwapchainKHR", "device");
                    Swapchain result = default(Swapchain);
                    Result commandResult;
                    Interop.SwapchainCreateInfo marshalledCreateInfo;
                    marshalledCreateInfo = createInfo.Pack();
                    Interop.AllocationCallbacks marshalledAllocator;
                    if(this.parent.Allocator != null) marshalledAllocator = this.parent.Allocator.Value.Pack();
                    Interop.Swapchain marshalledSwapchain;
                    commandResult = commandDelegate(this.handle, &marshalledCreateInfo, this.parent.Allocator == null ? null : &marshalledAllocator, &marshalledSwapchain);
                    if (SharpVkException.IsError(commandResult))
                    {
                        throw SharpVkException.Create(commandResult);
                    }
                    result = new Swapchain(marshalledSwapchain, createInfo.Surface, this, this.commandCache);
                    return result;
                }
                finally
                {
                    Interop.HeapUtil.FreeLog();
                }
            }
        }
        
        /// <summary>
        /// Create multiple swapchains that share presentable images.
        /// </summary>
        public Swapchain[] CreateSharedSwapchains(ArrayProxy<SwapchainCreateInfo> createInfos)
        {
            unsafe
            {
                try
                {
                    var commandDelegate = this.commandCache.GetCommandDelegate<Interop.vkCreateSharedSwapchainsKHR>("vkCreateSharedSwapchainsKHR", "device");
                    Swapchain[] result = default(Swapchain[]);
                    Result commandResult;
                    Interop.SwapchainCreateInfo* marshalledCreateInfos = null;
                    if (createInfos.Contents != ProxyContents.Null)
                    {
                        Interop.SwapchainCreateInfo* arrayPointer = stackalloc Interop.SwapchainCreateInfo[createInfos.Length];
                        if(createInfos.Contents == ProxyContents.Single)
                        {
                            *arrayPointer = createInfos.GetSingleValue().Pack();
                        }
                        else
                        {
                            var arrayValue  = createInfos.GetArrayValue();
                            for (int index = 0; index < createInfos.Length; index++)
                            {
                                arrayPointer[index] = arrayValue.Array[arrayValue.Offset + index].Pack();
                            }
                        }
                        marshalledCreateInfos = arrayPointer;
                    }
                    else
                    {
                        marshalledCreateInfos = null;
                    }
                    Interop.AllocationCallbacks marshalledAllocator;
                    if(this.parent.Allocator != null) marshalledAllocator = this.parent.Allocator.Value.Pack();
                    Interop.Swapchain* marshalledSwapchains = (Interop.Swapchain*)Interop.HeapUtil.Allocate<Interop.Swapchain>(createInfos.Length);
                    commandResult = commandDelegate(this.handle, (uint)(createInfos.Length), marshalledCreateInfos, this.parent.Allocator == null ? null : &marshalledAllocator, marshalledSwapchains);
                    if (SharpVkException.IsError(commandResult))
                    {
                        throw SharpVkException.Create(commandResult);
                    }
                    result = new Swapchain[(uint)createInfos.Length];
                    for(int index = 0; index < (uint)createInfos.Length; index++)
                    {
                    	result[index] = new Swapchain(marshalledSwapchains[index], createInfos[index].Surface, this, this.commandCache);
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
        /// Attach arbitrary data to an object.
        /// </summary>
        public void DebugMarkerSetObjectTag(DebugMarkerObjectTagInfo tagInfo)
        {
            unsafe
            {
                try
                {
                    var commandDelegate = this.commandCache.GetCommandDelegate<Interop.vkDebugMarkerSetObjectTagEXT>("vkDebugMarkerSetObjectTagEXT", "device");
                    Result commandResult;
                    Interop.DebugMarkerObjectTagInfo marshalledTagInfo;
                    marshalledTagInfo = tagInfo.Pack();
                    commandResult = commandDelegate(this.handle, &marshalledTagInfo);
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
        
        /// <summary>
        /// Give a user-friendly name to an object.
        /// </summary>
        public void DebugMarkerSetObjectName(DebugMarkerObjectNameInfo nameInfo)
        {
            unsafe
            {
                try
                {
                    var commandDelegate = this.commandCache.GetCommandDelegate<Interop.vkDebugMarkerSetObjectNameEXT>("vkDebugMarkerSetObjectNameEXT", "device");
                    Result commandResult;
                    Interop.DebugMarkerObjectNameInfo marshalledNameInfo;
                    marshalledNameInfo = nameInfo.Pack();
                    commandResult = commandDelegate(this.handle, &marshalledNameInfo);
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
        
        /// <summary>
        /// -
        /// </summary>
        public IndirectCommandsLayout CreateIndirectCommandsLayout(IndirectCommandsLayoutCreateInfo createInfo)
        {
            unsafe
            {
                try
                {
                    var commandDelegate = this.commandCache.GetCommandDelegate<Interop.vkCreateIndirectCommandsLayoutNVX>("vkCreateIndirectCommandsLayoutNVX", "device");
                    IndirectCommandsLayout result = default(IndirectCommandsLayout);
                    Result commandResult;
                    Interop.IndirectCommandsLayoutCreateInfo marshalledCreateInfo;
                    marshalledCreateInfo = createInfo.Pack();
                    Interop.AllocationCallbacks marshalledAllocator;
                    if(this.parent.Allocator != null) marshalledAllocator = this.parent.Allocator.Value.Pack();
                    Interop.IndirectCommandsLayout marshalledIndirectCommandsLayout;
                    commandResult = commandDelegate(this.handle, &marshalledCreateInfo, this.parent.Allocator == null ? null : &marshalledAllocator, &marshalledIndirectCommandsLayout);
                    if (SharpVkException.IsError(commandResult))
                    {
                        throw SharpVkException.Create(commandResult);
                    }
                    result = new IndirectCommandsLayout(marshalledIndirectCommandsLayout, this, this.commandCache);
                    return result;
                }
                finally
                {
                    Interop.HeapUtil.FreeLog();
                }
            }
        }
        
        /// <summary>
        /// -
        /// </summary>
        public ObjectTable CreateObjectTable(ObjectTableCreateInfo createInfo)
        {
            unsafe
            {
                try
                {
                    var commandDelegate = this.commandCache.GetCommandDelegate<Interop.vkCreateObjectTableNVX>("vkCreateObjectTableNVX", "device");
                    ObjectTable result = default(ObjectTable);
                    Result commandResult;
                    Interop.ObjectTableCreateInfo marshalledCreateInfo;
                    marshalledCreateInfo = createInfo.Pack();
                    Interop.AllocationCallbacks marshalledAllocator;
                    if(this.parent.Allocator != null) marshalledAllocator = this.parent.Allocator.Value.Pack();
                    Interop.ObjectTable marshalledObjectTable;
                    commandResult = commandDelegate(this.handle, &marshalledCreateInfo, this.parent.Allocator == null ? null : &marshalledAllocator, &marshalledObjectTable);
                    if (SharpVkException.IsError(commandResult))
                    {
                        throw SharpVkException.Create(commandResult);
                    }
                    result = new ObjectTable(marshalledObjectTable, this, this.commandCache);
                    return result;
                }
                finally
                {
                    Interop.HeapUtil.FreeLog();
                }
            }
        }
        
        internal Interop.Device Pack()
        {
            return this.handle;
        }
        
        /// <summary>
        /// The interop handle for this Device.
        /// </summary>
        public Interop.Device RawHandle => this.handle;
        
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
