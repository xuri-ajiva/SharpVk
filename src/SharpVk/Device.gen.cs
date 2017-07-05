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
        : IProcLookup
    {
        internal readonly SharpVk.Interop.Device handle; 
        
        internal readonly CommandCache commandCache; 
        
        internal readonly SharpVk.PhysicalDevice parent; 
        
        internal Device(SharpVk.PhysicalDevice parent, SharpVk.Interop.Device handle)
        {
            this.handle = handle;
            this.parent = parent;
            this.commandCache = new CommandCache(this, "device", parent.commandCache);
        }
        
        /// <summary>
        /// 
        /// </summary>
        public unsafe IntPtr GetProcedureAddress(string name)
        {
            try
            {
                IntPtr result = default(IntPtr);
                result = Interop.Commands.vkGetDeviceProcAddr(this.handle, Interop.HeapUtil.MarshalTo(name));
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
        public unsafe void Destroy(SharpVk.AllocationCallbacks? allocator = default(SharpVk.AllocationCallbacks?))
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
                result = new SharpVk.Queue(this, marshalledQueue);
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
        public unsafe SharpVk.DeviceMemory AllocateMemory(DeviceSize allocationSize, uint memoryTypeIndex, SharpVk.AllocationCallbacks? allocator = default(SharpVk.AllocationCallbacks?))
        {
            try
            {
                SharpVk.DeviceMemory result = default(SharpVk.DeviceMemory);
                SharpVk.Interop.MemoryAllocateInfo* marshalledAllocateInfo = default(SharpVk.Interop.MemoryAllocateInfo*);
                SharpVk.Interop.AllocationCallbacks* marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                SharpVk.Interop.DeviceMemory marshalledMemory = default(SharpVk.Interop.DeviceMemory);
                marshalledAllocateInfo = (SharpVk.Interop.MemoryAllocateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.MemoryAllocateInfo>());
                marshalledAllocateInfo->SType = StructureType.MemoryAllocateInfo;
                marshalledAllocateInfo->Next = null;
                marshalledAllocateInfo->AllocationSize = allocationSize;
                marshalledAllocateInfo->MemoryTypeIndex = memoryTypeIndex;
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
                result = new SharpVk.DeviceMemory(this, marshalledMemory);
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
        public unsafe SharpVk.Fence CreateFence(SharpVk.FenceCreateFlags? flags = default(SharpVk.FenceCreateFlags?), SharpVk.AllocationCallbacks? allocator = default(SharpVk.AllocationCallbacks?))
        {
            try
            {
                SharpVk.Fence result = default(SharpVk.Fence);
                SharpVk.Interop.FenceCreateInfo* marshalledCreateInfo = default(SharpVk.Interop.FenceCreateInfo*);
                SharpVk.Interop.AllocationCallbacks* marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                SharpVk.Interop.Fence marshalledFence = default(SharpVk.Interop.Fence);
                marshalledCreateInfo = (SharpVk.Interop.FenceCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.FenceCreateInfo>());
                marshalledCreateInfo->SType = StructureType.FenceCreateInfo;
                marshalledCreateInfo->Next = null;
                if (flags != null)
                {
                    marshalledCreateInfo->Flags = flags.Value;
                }
                else
                {
                    marshalledCreateInfo->Flags = default(SharpVk.FenceCreateFlags);
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
                Result methodResult = Interop.Commands.vkCreateFence(this.handle, marshalledCreateInfo, marshalledAllocator, &marshalledFence);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = new SharpVk.Fence(this, marshalledFence);
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
        public unsafe SharpVk.Semaphore CreateSemaphore(SharpVk.SemaphoreCreateFlags? flags = default(SharpVk.SemaphoreCreateFlags?), SharpVk.AllocationCallbacks? allocator = default(SharpVk.AllocationCallbacks?))
        {
            try
            {
                SharpVk.Semaphore result = default(SharpVk.Semaphore);
                SharpVk.Interop.SemaphoreCreateInfo* marshalledCreateInfo = default(SharpVk.Interop.SemaphoreCreateInfo*);
                SharpVk.Interop.AllocationCallbacks* marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                SharpVk.Interop.Semaphore marshalledSemaphore = default(SharpVk.Interop.Semaphore);
                marshalledCreateInfo = (SharpVk.Interop.SemaphoreCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.SemaphoreCreateInfo>());
                marshalledCreateInfo->SType = StructureType.SemaphoreCreateInfo;
                marshalledCreateInfo->Next = null;
                if (flags != null)
                {
                    marshalledCreateInfo->Flags = flags.Value;
                }
                else
                {
                    marshalledCreateInfo->Flags = default(SharpVk.SemaphoreCreateFlags);
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
                Result methodResult = Interop.Commands.vkCreateSemaphore(this.handle, marshalledCreateInfo, marshalledAllocator, &marshalledSemaphore);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = new SharpVk.Semaphore(this, marshalledSemaphore);
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
        public unsafe SharpVk.Event CreateEvent(SharpVk.EventCreateFlags? flags = default(SharpVk.EventCreateFlags?), SharpVk.AllocationCallbacks? allocator = default(SharpVk.AllocationCallbacks?))
        {
            try
            {
                SharpVk.Event result = default(SharpVk.Event);
                SharpVk.Interop.EventCreateInfo* marshalledCreateInfo = default(SharpVk.Interop.EventCreateInfo*);
                SharpVk.Interop.AllocationCallbacks* marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                SharpVk.Interop.Event marshalledEvent = default(SharpVk.Interop.Event);
                marshalledCreateInfo = (SharpVk.Interop.EventCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.EventCreateInfo>());
                marshalledCreateInfo->SType = StructureType.EventCreateInfo;
                marshalledCreateInfo->Next = null;
                if (flags != null)
                {
                    marshalledCreateInfo->Flags = flags.Value;
                }
                else
                {
                    marshalledCreateInfo->Flags = default(SharpVk.EventCreateFlags);
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
                Result methodResult = Interop.Commands.vkCreateEvent(this.handle, marshalledCreateInfo, marshalledAllocator, &marshalledEvent);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = new SharpVk.Event(this, marshalledEvent);
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
        public unsafe SharpVk.QueryPool CreateQueryPool(SharpVk.QueryType queryType, uint queryCount, SharpVk.QueryPoolCreateFlags? flags = default(SharpVk.QueryPoolCreateFlags?), SharpVk.QueryPipelineStatisticFlags? pipelineStatistics = default(SharpVk.QueryPipelineStatisticFlags?), SharpVk.AllocationCallbacks? allocator = default(SharpVk.AllocationCallbacks?))
        {
            try
            {
                SharpVk.QueryPool result = default(SharpVk.QueryPool);
                SharpVk.Interop.QueryPoolCreateInfo* marshalledCreateInfo = default(SharpVk.Interop.QueryPoolCreateInfo*);
                SharpVk.Interop.AllocationCallbacks* marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                SharpVk.Interop.QueryPool marshalledQueryPool = default(SharpVk.Interop.QueryPool);
                marshalledCreateInfo = (SharpVk.Interop.QueryPoolCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.QueryPoolCreateInfo>());
                marshalledCreateInfo->SType = StructureType.QueryPoolCreateInfo;
                marshalledCreateInfo->Next = null;
                if (flags != null)
                {
                    marshalledCreateInfo->Flags = flags.Value;
                }
                else
                {
                    marshalledCreateInfo->Flags = default(SharpVk.QueryPoolCreateFlags);
                }
                marshalledCreateInfo->QueryType = queryType;
                marshalledCreateInfo->QueryCount = queryCount;
                if (pipelineStatistics != null)
                {
                    marshalledCreateInfo->PipelineStatistics = pipelineStatistics.Value;
                }
                else
                {
                    marshalledCreateInfo->PipelineStatistics = default(SharpVk.QueryPipelineStatisticFlags);
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
                Result methodResult = Interop.Commands.vkCreateQueryPool(this.handle, marshalledCreateInfo, marshalledAllocator, &marshalledQueryPool);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = new SharpVk.QueryPool(this, marshalledQueryPool);
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
        public unsafe SharpVk.Buffer CreateBuffer(DeviceSize size, SharpVk.BufferUsageFlags usage, SharpVk.SharingMode sharingMode, uint[] queueFamilyIndices, SharpVk.BufferCreateFlags? flags = default(SharpVk.BufferCreateFlags?), SharpVk.AllocationCallbacks? allocator = default(SharpVk.AllocationCallbacks?))
        {
            try
            {
                SharpVk.Buffer result = default(SharpVk.Buffer);
                SharpVk.Interop.BufferCreateInfo* marshalledCreateInfo = default(SharpVk.Interop.BufferCreateInfo*);
                SharpVk.Interop.AllocationCallbacks* marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                SharpVk.Interop.Buffer marshalledBuffer = default(SharpVk.Interop.Buffer);
                marshalledCreateInfo = (SharpVk.Interop.BufferCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.BufferCreateInfo>());
                marshalledCreateInfo->SType = StructureType.BufferCreateInfo;
                marshalledCreateInfo->Next = null;
                if (flags != null)
                {
                    marshalledCreateInfo->Flags = flags.Value;
                }
                else
                {
                    marshalledCreateInfo->Flags = default(SharpVk.BufferCreateFlags);
                }
                marshalledCreateInfo->Size = size;
                marshalledCreateInfo->Usage = usage;
                marshalledCreateInfo->SharingMode = sharingMode;
                marshalledCreateInfo->QueueFamilyIndexCount = (uint)(queueFamilyIndices?.Length ?? 0);
                if (queueFamilyIndices != null)
                {
                    var fieldPointer = (uint*)(Interop.HeapUtil.AllocateAndClear<uint>(queueFamilyIndices.Length).ToPointer());
                    for(int index = 0; index < (uint)(queueFamilyIndices.Length); index++)
                    {
                        fieldPointer[index] = queueFamilyIndices[index];
                    }
                    marshalledCreateInfo->QueueFamilyIndices = fieldPointer;
                }
                else
                {
                    marshalledCreateInfo->QueueFamilyIndices = null;
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
                Result methodResult = Interop.Commands.vkCreateBuffer(this.handle, marshalledCreateInfo, marshalledAllocator, &marshalledBuffer);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = new SharpVk.Buffer(this, marshalledBuffer);
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
        public unsafe SharpVk.BufferView CreateBufferView(SharpVk.Buffer buffer, SharpVk.Format format, DeviceSize offset, DeviceSize range, SharpVk.BufferViewCreateFlags? flags = default(SharpVk.BufferViewCreateFlags?), SharpVk.AllocationCallbacks? allocator = default(SharpVk.AllocationCallbacks?))
        {
            try
            {
                SharpVk.BufferView result = default(SharpVk.BufferView);
                SharpVk.Interop.BufferViewCreateInfo* marshalledCreateInfo = default(SharpVk.Interop.BufferViewCreateInfo*);
                SharpVk.Interop.AllocationCallbacks* marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                SharpVk.Interop.BufferView marshalledView = default(SharpVk.Interop.BufferView);
                marshalledCreateInfo = (SharpVk.Interop.BufferViewCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.BufferViewCreateInfo>());
                marshalledCreateInfo->SType = StructureType.BufferViewCreateInfo;
                marshalledCreateInfo->Next = null;
                if (flags != null)
                {
                    marshalledCreateInfo->Flags = flags.Value;
                }
                else
                {
                    marshalledCreateInfo->Flags = default(SharpVk.BufferViewCreateFlags);
                }
                marshalledCreateInfo->Buffer = buffer?.handle ?? default(SharpVk.Interop.Buffer);
                marshalledCreateInfo->Format = format;
                marshalledCreateInfo->Offset = offset;
                marshalledCreateInfo->Range = range;
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
                result = new SharpVk.BufferView(this, marshalledView);
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
        public unsafe SharpVk.Image CreateImage(SharpVk.ImageType imageType, SharpVk.Format format, SharpVk.Extent3D extent, uint mipLevels, uint arrayLayers, SharpVk.SampleCountFlags samples, SharpVk.ImageTiling tiling, SharpVk.ImageUsageFlags usage, SharpVk.SharingMode sharingMode, uint[] queueFamilyIndices, SharpVk.ImageLayout initialLayout, SharpVk.ImageCreateFlags? flags = default(SharpVk.ImageCreateFlags?), SharpVk.AllocationCallbacks? allocator = default(SharpVk.AllocationCallbacks?))
        {
            try
            {
                SharpVk.Image result = default(SharpVk.Image);
                SharpVk.Interop.ImageCreateInfo* marshalledCreateInfo = default(SharpVk.Interop.ImageCreateInfo*);
                SharpVk.Interop.AllocationCallbacks* marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                SharpVk.Interop.Image marshalledImage = default(SharpVk.Interop.Image);
                marshalledCreateInfo = (SharpVk.Interop.ImageCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.ImageCreateInfo>());
                marshalledCreateInfo->SType = StructureType.ImageCreateInfo;
                marshalledCreateInfo->Next = null;
                if (flags != null)
                {
                    marshalledCreateInfo->Flags = flags.Value;
                }
                else
                {
                    marshalledCreateInfo->Flags = default(SharpVk.ImageCreateFlags);
                }
                marshalledCreateInfo->ImageType = imageType;
                marshalledCreateInfo->Format = format;
                marshalledCreateInfo->Extent = extent;
                marshalledCreateInfo->MipLevels = mipLevels;
                marshalledCreateInfo->ArrayLayers = arrayLayers;
                marshalledCreateInfo->Samples = samples;
                marshalledCreateInfo->Tiling = tiling;
                marshalledCreateInfo->Usage = usage;
                marshalledCreateInfo->SharingMode = sharingMode;
                marshalledCreateInfo->QueueFamilyIndexCount = (uint)(queueFamilyIndices?.Length ?? 0);
                if (queueFamilyIndices != null)
                {
                    var fieldPointer = (uint*)(Interop.HeapUtil.AllocateAndClear<uint>(queueFamilyIndices.Length).ToPointer());
                    for(int index = 0; index < (uint)(queueFamilyIndices.Length); index++)
                    {
                        fieldPointer[index] = queueFamilyIndices[index];
                    }
                    marshalledCreateInfo->QueueFamilyIndices = fieldPointer;
                }
                else
                {
                    marshalledCreateInfo->QueueFamilyIndices = null;
                }
                marshalledCreateInfo->InitialLayout = initialLayout;
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
                result = new SharpVk.Image(this, marshalledImage);
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
        public unsafe SharpVk.ImageView CreateImageView(SharpVk.Image image, SharpVk.ImageViewType viewType, SharpVk.Format format, SharpVk.ComponentMapping components, SharpVk.ImageSubresourceRange subresourceRange, SharpVk.ImageViewCreateFlags? flags = default(SharpVk.ImageViewCreateFlags?), SharpVk.AllocationCallbacks? allocator = default(SharpVk.AllocationCallbacks?))
        {
            try
            {
                SharpVk.ImageView result = default(SharpVk.ImageView);
                SharpVk.Interop.ImageViewCreateInfo* marshalledCreateInfo = default(SharpVk.Interop.ImageViewCreateInfo*);
                SharpVk.Interop.AllocationCallbacks* marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                SharpVk.Interop.ImageView marshalledView = default(SharpVk.Interop.ImageView);
                marshalledCreateInfo = (SharpVk.Interop.ImageViewCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.ImageViewCreateInfo>());
                marshalledCreateInfo->SType = StructureType.ImageViewCreateInfo;
                marshalledCreateInfo->Next = null;
                if (flags != null)
                {
                    marshalledCreateInfo->Flags = flags.Value;
                }
                else
                {
                    marshalledCreateInfo->Flags = default(SharpVk.ImageViewCreateFlags);
                }
                marshalledCreateInfo->Image = image?.handle ?? default(SharpVk.Interop.Image);
                marshalledCreateInfo->ViewType = viewType;
                marshalledCreateInfo->Format = format;
                marshalledCreateInfo->Components = components;
                marshalledCreateInfo->SubresourceRange = subresourceRange;
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
                result = new SharpVk.ImageView(this, marshalledView);
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
        public unsafe SharpVk.ShaderModule CreateShaderModule(HostSize codeSize, uint[] code, SharpVk.ShaderModuleCreateFlags? flags = default(SharpVk.ShaderModuleCreateFlags?), SharpVk.AllocationCallbacks? allocator = default(SharpVk.AllocationCallbacks?))
        {
            try
            {
                SharpVk.ShaderModule result = default(SharpVk.ShaderModule);
                SharpVk.Interop.ShaderModuleCreateInfo* marshalledCreateInfo = default(SharpVk.Interop.ShaderModuleCreateInfo*);
                SharpVk.Interop.AllocationCallbacks* marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                SharpVk.Interop.ShaderModule marshalledShaderModule = default(SharpVk.Interop.ShaderModule);
                marshalledCreateInfo = (SharpVk.Interop.ShaderModuleCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.ShaderModuleCreateInfo>());
                marshalledCreateInfo->SType = StructureType.ShaderModuleCreateInfo;
                marshalledCreateInfo->Next = null;
                if (flags != null)
                {
                    marshalledCreateInfo->Flags = flags.Value;
                }
                else
                {
                    marshalledCreateInfo->Flags = default(SharpVk.ShaderModuleCreateFlags);
                }
                marshalledCreateInfo->CodeSize = codeSize;
                if (code != null)
                {
                    var fieldPointer = (uint*)(Interop.HeapUtil.AllocateAndClear<uint>(code.Length).ToPointer());
                    for(int index = 0; index < (uint)(code.Length); index++)
                    {
                        fieldPointer[index] = code[index];
                    }
                    marshalledCreateInfo->Code = fieldPointer;
                }
                else
                {
                    marshalledCreateInfo->Code = null;
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
                Result methodResult = Interop.Commands.vkCreateShaderModule(this.handle, marshalledCreateInfo, marshalledAllocator, &marshalledShaderModule);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = new SharpVk.ShaderModule(this, marshalledShaderModule);
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
        public unsafe SharpVk.PipelineCache CreatePipelineCache(byte[] initialData, SharpVk.PipelineCacheCreateFlags? flags = default(SharpVk.PipelineCacheCreateFlags?), SharpVk.AllocationCallbacks? allocator = default(SharpVk.AllocationCallbacks?))
        {
            try
            {
                SharpVk.PipelineCache result = default(SharpVk.PipelineCache);
                SharpVk.Interop.PipelineCacheCreateInfo* marshalledCreateInfo = default(SharpVk.Interop.PipelineCacheCreateInfo*);
                SharpVk.Interop.AllocationCallbacks* marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                SharpVk.Interop.PipelineCache marshalledPipelineCache = default(SharpVk.Interop.PipelineCache);
                marshalledCreateInfo = (SharpVk.Interop.PipelineCacheCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.PipelineCacheCreateInfo>());
                marshalledCreateInfo->SType = StructureType.PipelineCacheCreateInfo;
                marshalledCreateInfo->Next = null;
                if (flags != null)
                {
                    marshalledCreateInfo->Flags = flags.Value;
                }
                else
                {
                    marshalledCreateInfo->Flags = default(SharpVk.PipelineCacheCreateFlags);
                }
                marshalledCreateInfo->InitialDataSize = (HostSize)(initialData?.Length ?? 0);
                if (initialData != null)
                {
                    var fieldPointer = (byte*)(Interop.HeapUtil.AllocateAndClear<byte>(initialData.Length).ToPointer());
                    for(int index = 0; index < (uint)(initialData.Length); index++)
                    {
                        fieldPointer[index] = initialData[index];
                    }
                    marshalledCreateInfo->InitialData = fieldPointer;
                }
                else
                {
                    marshalledCreateInfo->InitialData = null;
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
                Result methodResult = Interop.Commands.vkCreatePipelineCache(this.handle, marshalledCreateInfo, marshalledAllocator, &marshalledPipelineCache);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = new SharpVk.PipelineCache(this, marshalledPipelineCache);
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
        public unsafe SharpVk.Pipeline[] CreateGraphicsPipelines(SharpVk.PipelineCache pipelineCache, SharpVk.GraphicsPipelineCreateInfo[] createInfos, SharpVk.AllocationCallbacks? allocator = default(SharpVk.AllocationCallbacks?))
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
                        fieldPointer[index] = new SharpVk.Pipeline(this, marshalledPipelines[index]);
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
        public unsafe SharpVk.Pipeline[] CreateComputePipelines(SharpVk.PipelineCache pipelineCache, SharpVk.ComputePipelineCreateInfo[] createInfos, SharpVk.AllocationCallbacks? allocator = default(SharpVk.AllocationCallbacks?))
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
                        fieldPointer[index] = new SharpVk.Pipeline(this, marshalledPipelines[index]);
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
        public unsafe SharpVk.PipelineLayout CreatePipelineLayout(SharpVk.DescriptorSetLayout[] setLayouts, SharpVk.PushConstantRange[] pushConstantRanges, SharpVk.PipelineLayoutCreateFlags? flags = default(SharpVk.PipelineLayoutCreateFlags?), SharpVk.AllocationCallbacks? allocator = default(SharpVk.AllocationCallbacks?))
        {
            try
            {
                SharpVk.PipelineLayout result = default(SharpVk.PipelineLayout);
                SharpVk.Interop.PipelineLayoutCreateInfo* marshalledCreateInfo = default(SharpVk.Interop.PipelineLayoutCreateInfo*);
                SharpVk.Interop.AllocationCallbacks* marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                SharpVk.Interop.PipelineLayout marshalledPipelineLayout = default(SharpVk.Interop.PipelineLayout);
                marshalledCreateInfo = (SharpVk.Interop.PipelineLayoutCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.PipelineLayoutCreateInfo>());
                marshalledCreateInfo->SType = StructureType.PipelineLayoutCreateInfo;
                marshalledCreateInfo->Next = null;
                if (flags != null)
                {
                    marshalledCreateInfo->Flags = flags.Value;
                }
                else
                {
                    marshalledCreateInfo->Flags = default(SharpVk.PipelineLayoutCreateFlags);
                }
                marshalledCreateInfo->SetLayoutCount = (uint)(setLayouts?.Length ?? 0);
                if (setLayouts != null)
                {
                    var fieldPointer = (SharpVk.Interop.DescriptorSetLayout*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.DescriptorSetLayout>(setLayouts.Length).ToPointer());
                    for(int index = 0; index < (uint)(setLayouts.Length); index++)
                    {
                        fieldPointer[index] = setLayouts[index]?.handle ?? default(SharpVk.Interop.DescriptorSetLayout);
                    }
                    marshalledCreateInfo->SetLayouts = fieldPointer;
                }
                else
                {
                    marshalledCreateInfo->SetLayouts = null;
                }
                marshalledCreateInfo->PushConstantRangeCount = (uint)(pushConstantRanges?.Length ?? 0);
                if (pushConstantRanges != null)
                {
                    var fieldPointer = (SharpVk.PushConstantRange*)(Interop.HeapUtil.AllocateAndClear<SharpVk.PushConstantRange>(pushConstantRanges.Length).ToPointer());
                    for(int index = 0; index < (uint)(pushConstantRanges.Length); index++)
                    {
                        fieldPointer[index] = pushConstantRanges[index];
                    }
                    marshalledCreateInfo->PushConstantRanges = fieldPointer;
                }
                else
                {
                    marshalledCreateInfo->PushConstantRanges = null;
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
                Result methodResult = Interop.Commands.vkCreatePipelineLayout(this.handle, marshalledCreateInfo, marshalledAllocator, &marshalledPipelineLayout);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = new SharpVk.PipelineLayout(this, marshalledPipelineLayout);
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
        public unsafe SharpVk.Sampler CreateSampler(SharpVk.Filter magFilter, SharpVk.Filter minFilter, SharpVk.SamplerMipmapMode mipmapMode, SharpVk.SamplerAddressMode addressModeU, SharpVk.SamplerAddressMode addressModeV, SharpVk.SamplerAddressMode addressModeW, float mipLodBias, Bool32 anisotropyEnable, float maxAnisotropy, Bool32 compareEnable, SharpVk.CompareOp compareOp, float minLod, float maxLod, SharpVk.BorderColor borderColor, Bool32 unnormalizedCoordinates, SharpVk.SamplerCreateFlags? flags = default(SharpVk.SamplerCreateFlags?), SharpVk.AllocationCallbacks? allocator = default(SharpVk.AllocationCallbacks?))
        {
            try
            {
                SharpVk.Sampler result = default(SharpVk.Sampler);
                SharpVk.Interop.SamplerCreateInfo* marshalledCreateInfo = default(SharpVk.Interop.SamplerCreateInfo*);
                SharpVk.Interop.AllocationCallbacks* marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                SharpVk.Interop.Sampler marshalledSampler = default(SharpVk.Interop.Sampler);
                marshalledCreateInfo = (SharpVk.Interop.SamplerCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.SamplerCreateInfo>());
                marshalledCreateInfo->SType = StructureType.SamplerCreateInfo;
                marshalledCreateInfo->Next = null;
                if (flags != null)
                {
                    marshalledCreateInfo->Flags = flags.Value;
                }
                else
                {
                    marshalledCreateInfo->Flags = default(SharpVk.SamplerCreateFlags);
                }
                marshalledCreateInfo->MagFilter = magFilter;
                marshalledCreateInfo->MinFilter = minFilter;
                marshalledCreateInfo->MipmapMode = mipmapMode;
                marshalledCreateInfo->AddressModeU = addressModeU;
                marshalledCreateInfo->AddressModeV = addressModeV;
                marshalledCreateInfo->AddressModeW = addressModeW;
                marshalledCreateInfo->MipLodBias = mipLodBias;
                marshalledCreateInfo->AnisotropyEnable = anisotropyEnable;
                marshalledCreateInfo->MaxAnisotropy = maxAnisotropy;
                marshalledCreateInfo->CompareEnable = compareEnable;
                marshalledCreateInfo->CompareOp = compareOp;
                marshalledCreateInfo->MinLod = minLod;
                marshalledCreateInfo->MaxLod = maxLod;
                marshalledCreateInfo->BorderColor = borderColor;
                marshalledCreateInfo->UnnormalizedCoordinates = unnormalizedCoordinates;
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
                result = new SharpVk.Sampler(this, marshalledSampler);
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
        public unsafe SharpVk.DescriptorSetLayout CreateDescriptorSetLayout(SharpVk.DescriptorSetLayoutBinding[] bindings, SharpVk.DescriptorSetLayoutCreateFlags? flags = default(SharpVk.DescriptorSetLayoutCreateFlags?), SharpVk.AllocationCallbacks? allocator = default(SharpVk.AllocationCallbacks?))
        {
            try
            {
                SharpVk.DescriptorSetLayout result = default(SharpVk.DescriptorSetLayout);
                SharpVk.Interop.DescriptorSetLayoutCreateInfo* marshalledCreateInfo = default(SharpVk.Interop.DescriptorSetLayoutCreateInfo*);
                SharpVk.Interop.AllocationCallbacks* marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                SharpVk.Interop.DescriptorSetLayout marshalledSetLayout = default(SharpVk.Interop.DescriptorSetLayout);
                marshalledCreateInfo = (SharpVk.Interop.DescriptorSetLayoutCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.DescriptorSetLayoutCreateInfo>());
                marshalledCreateInfo->SType = StructureType.DescriptorSetLayoutCreateInfo;
                marshalledCreateInfo->Next = null;
                if (flags != null)
                {
                    marshalledCreateInfo->Flags = flags.Value;
                }
                else
                {
                    marshalledCreateInfo->Flags = default(SharpVk.DescriptorSetLayoutCreateFlags);
                }
                marshalledCreateInfo->BindingCount = (uint)(bindings?.Length ?? 0);
                if (bindings != null)
                {
                    var fieldPointer = (SharpVk.Interop.DescriptorSetLayoutBinding*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.DescriptorSetLayoutBinding>(bindings.Length).ToPointer());
                    for(int index = 0; index < (uint)(bindings.Length); index++)
                    {
                        bindings[index].MarshalTo(&fieldPointer[index]);
                    }
                    marshalledCreateInfo->Bindings = fieldPointer;
                }
                else
                {
                    marshalledCreateInfo->Bindings = null;
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
                Result methodResult = Interop.Commands.vkCreateDescriptorSetLayout(this.handle, marshalledCreateInfo, marshalledAllocator, &marshalledSetLayout);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = new SharpVk.DescriptorSetLayout(this, marshalledSetLayout);
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
        public unsafe SharpVk.DescriptorPool CreateDescriptorPool(uint maxSets, SharpVk.DescriptorPoolSize[] poolSizes, SharpVk.DescriptorPoolCreateFlags? flags = default(SharpVk.DescriptorPoolCreateFlags?), SharpVk.AllocationCallbacks? allocator = default(SharpVk.AllocationCallbacks?))
        {
            try
            {
                SharpVk.DescriptorPool result = default(SharpVk.DescriptorPool);
                SharpVk.Interop.DescriptorPoolCreateInfo* marshalledCreateInfo = default(SharpVk.Interop.DescriptorPoolCreateInfo*);
                SharpVk.Interop.AllocationCallbacks* marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                SharpVk.Interop.DescriptorPool marshalledDescriptorPool = default(SharpVk.Interop.DescriptorPool);
                marshalledCreateInfo = (SharpVk.Interop.DescriptorPoolCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.DescriptorPoolCreateInfo>());
                marshalledCreateInfo->SType = StructureType.DescriptorPoolCreateInfo;
                marshalledCreateInfo->Next = null;
                if (flags != null)
                {
                    marshalledCreateInfo->Flags = flags.Value;
                }
                else
                {
                    marshalledCreateInfo->Flags = default(SharpVk.DescriptorPoolCreateFlags);
                }
                marshalledCreateInfo->MaxSets = maxSets;
                marshalledCreateInfo->PoolSizeCount = (uint)(poolSizes?.Length ?? 0);
                if (poolSizes != null)
                {
                    var fieldPointer = (SharpVk.DescriptorPoolSize*)(Interop.HeapUtil.AllocateAndClear<SharpVk.DescriptorPoolSize>(poolSizes.Length).ToPointer());
                    for(int index = 0; index < (uint)(poolSizes.Length); index++)
                    {
                        fieldPointer[index] = poolSizes[index];
                    }
                    marshalledCreateInfo->PoolSizes = fieldPointer;
                }
                else
                {
                    marshalledCreateInfo->PoolSizes = null;
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
                Result methodResult = Interop.Commands.vkCreateDescriptorPool(this.handle, marshalledCreateInfo, marshalledAllocator, &marshalledDescriptorPool);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = new SharpVk.DescriptorPool(this, marshalledDescriptorPool);
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
        public unsafe SharpVk.DescriptorSet[] AllocateDescriptorSets(SharpVk.DescriptorPool descriptorPool, SharpVk.DescriptorSetLayout[] setLayouts)
        {
            try
            {
                SharpVk.DescriptorSet[] result = default(SharpVk.DescriptorSet[]);
                SharpVk.Interop.DescriptorSetAllocateInfo* marshalledAllocateInfo = default(SharpVk.Interop.DescriptorSetAllocateInfo*);
                SharpVk.Interop.DescriptorSet* marshalledDescriptorSets = default(SharpVk.Interop.DescriptorSet*);
                marshalledAllocateInfo = (SharpVk.Interop.DescriptorSetAllocateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.DescriptorSetAllocateInfo>());
                marshalledAllocateInfo->SType = StructureType.DescriptorSetAllocateInfo;
                marshalledAllocateInfo->Next = null;
                marshalledAllocateInfo->DescriptorPool = descriptorPool?.handle ?? default(SharpVk.Interop.DescriptorPool);
                marshalledAllocateInfo->DescriptorSetCount = (uint)(setLayouts?.Length ?? 0);
                if (setLayouts != null)
                {
                    var fieldPointer = (SharpVk.Interop.DescriptorSetLayout*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.DescriptorSetLayout>(setLayouts.Length).ToPointer());
                    for(int index = 0; index < (uint)(setLayouts.Length); index++)
                    {
                        fieldPointer[index] = setLayouts[index]?.handle ?? default(SharpVk.Interop.DescriptorSetLayout);
                    }
                    marshalledAllocateInfo->SetLayouts = fieldPointer;
                }
                else
                {
                    marshalledAllocateInfo->SetLayouts = null;
                }
                marshalledDescriptorSets = (SharpVk.Interop.DescriptorSet*)(Interop.HeapUtil.Allocate<SharpVk.Interop.DescriptorSet>(setLayouts.Length));
                Result methodResult = Interop.Commands.vkAllocateDescriptorSets(this.handle, marshalledAllocateInfo, marshalledDescriptorSets);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                if (marshalledDescriptorSets != null)
                {
                    var fieldPointer = new SharpVk.DescriptorSet[(uint)(setLayouts.Length)];
                    for(int index = 0; index < (uint)(setLayouts.Length); index++)
                    {
                        fieldPointer[index] = new SharpVk.DescriptorSet(descriptorPool, marshalledDescriptorSets[index]);
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
        public unsafe SharpVk.Framebuffer CreateFramebuffer(SharpVk.RenderPass renderPass, SharpVk.ImageView[] attachments, uint width, uint height, uint layers, SharpVk.FramebufferCreateFlags? flags = default(SharpVk.FramebufferCreateFlags?), SharpVk.AllocationCallbacks? allocator = default(SharpVk.AllocationCallbacks?))
        {
            try
            {
                SharpVk.Framebuffer result = default(SharpVk.Framebuffer);
                SharpVk.Interop.FramebufferCreateInfo* marshalledCreateInfo = default(SharpVk.Interop.FramebufferCreateInfo*);
                SharpVk.Interop.AllocationCallbacks* marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                SharpVk.Interop.Framebuffer marshalledFramebuffer = default(SharpVk.Interop.Framebuffer);
                marshalledCreateInfo = (SharpVk.Interop.FramebufferCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.FramebufferCreateInfo>());
                marshalledCreateInfo->SType = StructureType.FramebufferCreateInfo;
                marshalledCreateInfo->Next = null;
                if (flags != null)
                {
                    marshalledCreateInfo->Flags = flags.Value;
                }
                else
                {
                    marshalledCreateInfo->Flags = default(SharpVk.FramebufferCreateFlags);
                }
                marshalledCreateInfo->RenderPass = renderPass?.handle ?? default(SharpVk.Interop.RenderPass);
                marshalledCreateInfo->AttachmentCount = (uint)(attachments?.Length ?? 0);
                if (attachments != null)
                {
                    var fieldPointer = (SharpVk.Interop.ImageView*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.ImageView>(attachments.Length).ToPointer());
                    for(int index = 0; index < (uint)(attachments.Length); index++)
                    {
                        fieldPointer[index] = attachments[index]?.handle ?? default(SharpVk.Interop.ImageView);
                    }
                    marshalledCreateInfo->Attachments = fieldPointer;
                }
                else
                {
                    marshalledCreateInfo->Attachments = null;
                }
                marshalledCreateInfo->Width = width;
                marshalledCreateInfo->Height = height;
                marshalledCreateInfo->Layers = layers;
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
                result = new SharpVk.Framebuffer(this, marshalledFramebuffer);
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
        public unsafe SharpVk.RenderPass CreateRenderPass(SharpVk.AttachmentDescription[] attachments, SharpVk.SubpassDescription[] subpasses, SharpVk.SubpassDependency[] dependencies, SharpVk.RenderPassCreateFlags? flags = default(SharpVk.RenderPassCreateFlags?), SharpVk.AllocationCallbacks? allocator = default(SharpVk.AllocationCallbacks?))
        {
            try
            {
                SharpVk.RenderPass result = default(SharpVk.RenderPass);
                SharpVk.Interop.RenderPassCreateInfo* marshalledCreateInfo = default(SharpVk.Interop.RenderPassCreateInfo*);
                SharpVk.Interop.AllocationCallbacks* marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                SharpVk.Interop.RenderPass marshalledRenderPass = default(SharpVk.Interop.RenderPass);
                marshalledCreateInfo = (SharpVk.Interop.RenderPassCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.RenderPassCreateInfo>());
                marshalledCreateInfo->SType = StructureType.RenderPassCreateInfo;
                marshalledCreateInfo->Next = null;
                if (flags != null)
                {
                    marshalledCreateInfo->Flags = flags.Value;
                }
                else
                {
                    marshalledCreateInfo->Flags = default(SharpVk.RenderPassCreateFlags);
                }
                marshalledCreateInfo->AttachmentCount = (uint)(attachments?.Length ?? 0);
                if (attachments != null)
                {
                    var fieldPointer = (SharpVk.AttachmentDescription*)(Interop.HeapUtil.AllocateAndClear<SharpVk.AttachmentDescription>(attachments.Length).ToPointer());
                    for(int index = 0; index < (uint)(attachments.Length); index++)
                    {
                        fieldPointer[index] = attachments[index];
                    }
                    marshalledCreateInfo->Attachments = fieldPointer;
                }
                else
                {
                    marshalledCreateInfo->Attachments = null;
                }
                marshalledCreateInfo->SubpassCount = (uint)(subpasses?.Length ?? 0);
                if (subpasses != null)
                {
                    var fieldPointer = (SharpVk.Interop.SubpassDescription*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.SubpassDescription>(subpasses.Length).ToPointer());
                    for(int index = 0; index < (uint)(subpasses.Length); index++)
                    {
                        subpasses[index].MarshalTo(&fieldPointer[index]);
                    }
                    marshalledCreateInfo->Subpasses = fieldPointer;
                }
                else
                {
                    marshalledCreateInfo->Subpasses = null;
                }
                marshalledCreateInfo->DependencyCount = (uint)(dependencies?.Length ?? 0);
                if (dependencies != null)
                {
                    var fieldPointer = (SharpVk.SubpassDependency*)(Interop.HeapUtil.AllocateAndClear<SharpVk.SubpassDependency>(dependencies.Length).ToPointer());
                    for(int index = 0; index < (uint)(dependencies.Length); index++)
                    {
                        fieldPointer[index] = dependencies[index];
                    }
                    marshalledCreateInfo->Dependencies = fieldPointer;
                }
                else
                {
                    marshalledCreateInfo->Dependencies = null;
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
                Result methodResult = Interop.Commands.vkCreateRenderPass(this.handle, marshalledCreateInfo, marshalledAllocator, &marshalledRenderPass);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = new SharpVk.RenderPass(this, marshalledRenderPass);
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
        public unsafe SharpVk.CommandPool CreateCommandPool(uint queueFamilyIndex, SharpVk.CommandPoolCreateFlags? flags = default(SharpVk.CommandPoolCreateFlags?), SharpVk.AllocationCallbacks? allocator = default(SharpVk.AllocationCallbacks?))
        {
            try
            {
                SharpVk.CommandPool result = default(SharpVk.CommandPool);
                SharpVk.Interop.CommandPoolCreateInfo* marshalledCreateInfo = default(SharpVk.Interop.CommandPoolCreateInfo*);
                SharpVk.Interop.AllocationCallbacks* marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                SharpVk.Interop.CommandPool marshalledCommandPool = default(SharpVk.Interop.CommandPool);
                marshalledCreateInfo = (SharpVk.Interop.CommandPoolCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.CommandPoolCreateInfo>());
                marshalledCreateInfo->SType = StructureType.CommandPoolCreateInfo;
                marshalledCreateInfo->Next = null;
                if (flags != null)
                {
                    marshalledCreateInfo->Flags = flags.Value;
                }
                else
                {
                    marshalledCreateInfo->Flags = default(SharpVk.CommandPoolCreateFlags);
                }
                marshalledCreateInfo->QueueFamilyIndex = queueFamilyIndex;
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
                result = new SharpVk.CommandPool(this, marshalledCommandPool);
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
        public unsafe SharpVk.CommandBuffer[] AllocateCommandBuffers(SharpVk.CommandPool commandPool, SharpVk.CommandBufferLevel level, uint commandBufferCount)
        {
            try
            {
                SharpVk.CommandBuffer[] result = default(SharpVk.CommandBuffer[]);
                SharpVk.Interop.CommandBufferAllocateInfo* marshalledAllocateInfo = default(SharpVk.Interop.CommandBufferAllocateInfo*);
                SharpVk.Interop.CommandBuffer* marshalledCommandBuffers = default(SharpVk.Interop.CommandBuffer*);
                marshalledAllocateInfo = (SharpVk.Interop.CommandBufferAllocateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.CommandBufferAllocateInfo>());
                marshalledAllocateInfo->SType = StructureType.CommandBufferAllocateInfo;
                marshalledAllocateInfo->Next = null;
                marshalledAllocateInfo->CommandPool = commandPool?.handle ?? default(SharpVk.Interop.CommandPool);
                marshalledAllocateInfo->Level = level;
                marshalledAllocateInfo->CommandBufferCount = commandBufferCount;
                marshalledCommandBuffers = (SharpVk.Interop.CommandBuffer*)(Interop.HeapUtil.Allocate<SharpVk.Interop.CommandBuffer>(commandBufferCount));
                Result methodResult = Interop.Commands.vkAllocateCommandBuffers(this.handle, marshalledAllocateInfo, marshalledCommandBuffers);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                if (marshalledCommandBuffers != null)
                {
                    var fieldPointer = new SharpVk.CommandBuffer[(uint)(commandBufferCount)];
                    for(int index = 0; index < (uint)(commandBufferCount); index++)
                    {
                        fieldPointer[index] = new SharpVk.CommandBuffer(commandPool, marshalledCommandBuffers[index]);
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
