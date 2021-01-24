// The MIT License (MIT)
// 
// Copyright (c) Andrew Armstrong/FacticiusVir & xuri 2021
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
    /// Opaque handle to a device object.
    /// </summary>
    public partial class Device
        : IProcLookup, IDisposable
    {
        internal readonly SharpVk.Interop.Device Handle; 
        
        internal readonly CommandCache commandCache; 
        
        internal readonly PhysicalDevice parent; 
        
        internal Device(PhysicalDevice parent, SharpVk.Interop.Device handle)
        {
            Handle = handle;
            this.parent = parent;
            commandCache = new CommandCache(this, "device", parent.commandCache);
            commandCache.Initialise();
        }
        
        /// <summary>
        /// The raw handle for this instance.
        /// </summary>
        public SharpVk.Interop.Device RawHandle => Handle;
        
        /// <summary>
        /// Return a function pointer for a command.
        /// </summary>
        /// <param name="name">
        /// </param>
        public unsafe IntPtr GetProcedureAddress(string name)
        {
            try
            {
                IntPtr result = default;
                Interop.VkDeviceGetProcedureAddressDelegate commandDelegate = commandCache.Cache.vkGetDeviceProcAddr;
                result = commandDelegate(Handle, Interop.HeapUtil.MarshalTo(name));
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Destroy a logical device.
        /// </summary>
        /// <param name="allocator">
        /// An optional AllocationCallbacks instance that controls host memory
        /// allocation.
        /// </param>
        public unsafe void Destroy(AllocationCallbacks? allocator = default)
        {
            try
            {
                SharpVk.Interop.AllocationCallbacks* marshalledAllocator = default;
                if (allocator != null)
                {
                    marshalledAllocator = (SharpVk.Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<SharpVk.Interop.AllocationCallbacks>());
                    allocator.Value.MarshalTo(marshalledAllocator);
                }
                else
                {
                    marshalledAllocator = default;
                }
                Interop.VkDeviceDestroyDelegate commandDelegate = commandCache.Cache.vkDestroyDevice;
                commandDelegate(Handle, marshalledAllocator);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Get a queue handle from a device.
        /// </summary>
        /// <param name="queueFamilyIndex">
        /// </param>
        /// <param name="queueIndex">
        /// </param>
        public unsafe Queue GetQueue(uint queueFamilyIndex, uint queueIndex)
        {
            try
            {
                Queue result = default;
                SharpVk.Interop.Queue marshalledQueue = default;
                Interop.VkDeviceGetQueueDelegate commandDelegate = commandCache.Cache.vkGetDeviceQueue;
                commandDelegate(Handle, queueFamilyIndex, queueIndex, &marshalledQueue);
                result = new Queue(this, marshalledQueue);
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Wait for a device to become idle.
        /// </summary>
        public unsafe void WaitIdle()
        {
            try
            {
                Interop.VkDeviceWaitIdleDelegate commandDelegate = commandCache.Cache.vkDeviceWaitIdle;
                Result methodResult = commandDelegate(Handle);
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
        /// Allocate GPU memory.
        /// </summary>
        /// <param name="allocationSize">
        /// The size of the allocation in bytes
        /// </param>
        /// <param name="memoryTypeIndex">
        /// The memory type index, which selects the properties of the memory
        /// to be allocated, as well as the heap the memory will come from.
        /// </param>
        /// <param name="dedicatedAllocationMemoryAllocateInfoNv">
        /// Extension struct
        /// </param>
        /// <param name="exportMemoryAllocateInfoNv">
        /// Extension struct
        /// </param>
        /// <param name="importMemoryWin32HandleInfoNv">
        /// Extension struct
        /// </param>
        /// <param name="exportMemoryWin32HandleInfoNv">
        /// Extension struct
        /// </param>
        /// <param name="exportMemoryAllocateInfo">
        /// Extension struct
        /// </param>
        /// <param name="importMemoryWin32HandleInfoKhr">
        /// Extension struct
        /// </param>
        /// <param name="exportMemoryWin32HandleInfoKhr">
        /// Extension struct
        /// </param>
        /// <param name="importMemoryFileDescriptorInfoKhr">
        /// Extension struct
        /// </param>
        /// <param name="memoryAllocateFlagsInfo">
        /// Extension struct
        /// </param>
        /// <param name="memoryDedicatedAllocateInfo">
        /// Extension struct
        /// </param>
        /// <param name="importMemoryHostPointerInfoExt">
        /// Extension struct
        /// </param>
        /// <param name="importAndroidHardwareBufferInfoAndroid">
        /// Extension struct
        /// </param>
        /// <param name="memoryPriorityAllocateInfoExt">
        /// Extension struct
        /// </param>
        /// <param name="memoryOpaqueCaptureAddressAllocateInfo">
        /// Extension struct
        /// </param>
        /// <param name="allocator">
        /// An optional AllocationCallbacks instance that controls host memory
        /// allocation.
        /// </param>
        public unsafe DeviceMemory AllocateMemory(ulong allocationSize, uint memoryTypeIndex, NVidia.DedicatedAllocationMemoryAllocateInfo? dedicatedAllocationMemoryAllocateInfoNv = null, SharpVk.NVidia.ExportMemoryAllocateInfo? exportMemoryAllocateInfoNv = null, NVidia.ImportMemoryWin32HandleInfo? importMemoryWin32HandleInfoNv = null, NVidia.ExportMemoryWin32HandleInfo? exportMemoryWin32HandleInfoNv = null, ExportMemoryAllocateInfo? exportMemoryAllocateInfo = null, Khronos.ImportMemoryWin32HandleInfo? importMemoryWin32HandleInfoKhr = null, Khronos.ExportMemoryWin32HandleInfo? exportMemoryWin32HandleInfoKhr = null, Khronos.ImportMemoryFileDescriptorInfo? importMemoryFileDescriptorInfoKhr = null, MemoryAllocateFlagsInfo? memoryAllocateFlagsInfo = null, MemoryDedicatedAllocateInfo? memoryDedicatedAllocateInfo = null, Multivendor.ImportMemoryHostPointerInfo? importMemoryHostPointerInfoExt = null, Android.ImportAndroidHardwareBufferInfo? importAndroidHardwareBufferInfoAndroid = null, Multivendor.MemoryPriorityAllocateInfo? memoryPriorityAllocateInfoExt = null, MemoryOpaqueCaptureAddressAllocateInfo? memoryOpaqueCaptureAddressAllocateInfo = null, AllocationCallbacks? allocator = default)
        {
            try
            {
                DeviceMemory result = default;
                SharpVk.Interop.MemoryAllocateInfo* marshalledAllocateInfo = default;
                void* vkMemoryAllocateInfoNextPointer = default;
                SharpVk.Interop.AllocationCallbacks* marshalledAllocator = default;
                SharpVk.Interop.DeviceMemory marshalledMemory = default;
                if (dedicatedAllocationMemoryAllocateInfoNv != null)
                {
                    SharpVk.Interop.NVidia.DedicatedAllocationMemoryAllocateInfo* extensionPointer = default;
                    extensionPointer = (SharpVk.Interop.NVidia.DedicatedAllocationMemoryAllocateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.NVidia.DedicatedAllocationMemoryAllocateInfo>());
                    dedicatedAllocationMemoryAllocateInfoNv.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkMemoryAllocateInfoNextPointer;
                    vkMemoryAllocateInfoNextPointer = extensionPointer;
                }
                if (exportMemoryAllocateInfoNv != null)
                {
                    SharpVk.Interop.NVidia.ExportMemoryAllocateInfo* extensionPointer = default;
                    extensionPointer = (SharpVk.Interop.NVidia.ExportMemoryAllocateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.NVidia.ExportMemoryAllocateInfo>());
                    exportMemoryAllocateInfoNv.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkMemoryAllocateInfoNextPointer;
                    vkMemoryAllocateInfoNextPointer = extensionPointer;
                }
                if (importMemoryWin32HandleInfoNv != null)
                {
                    SharpVk.Interop.NVidia.ImportMemoryWin32HandleInfo* extensionPointer = default;
                    extensionPointer = (SharpVk.Interop.NVidia.ImportMemoryWin32HandleInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.NVidia.ImportMemoryWin32HandleInfo>());
                    importMemoryWin32HandleInfoNv.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkMemoryAllocateInfoNextPointer;
                    vkMemoryAllocateInfoNextPointer = extensionPointer;
                }
                if (exportMemoryWin32HandleInfoNv != null)
                {
                    SharpVk.Interop.NVidia.ExportMemoryWin32HandleInfo* extensionPointer = default;
                    extensionPointer = (SharpVk.Interop.NVidia.ExportMemoryWin32HandleInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.NVidia.ExportMemoryWin32HandleInfo>());
                    exportMemoryWin32HandleInfoNv.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkMemoryAllocateInfoNextPointer;
                    vkMemoryAllocateInfoNextPointer = extensionPointer;
                }
                if (exportMemoryAllocateInfo != null)
                {
                    SharpVk.Interop.ExportMemoryAllocateInfo* extensionPointer = default;
                    extensionPointer = (SharpVk.Interop.ExportMemoryAllocateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.ExportMemoryAllocateInfo>());
                    exportMemoryAllocateInfo.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkMemoryAllocateInfoNextPointer;
                    vkMemoryAllocateInfoNextPointer = extensionPointer;
                }
                if (importMemoryWin32HandleInfoKhr != null)
                {
                    SharpVk.Interop.Khronos.ImportMemoryWin32HandleInfo* extensionPointer = default;
                    extensionPointer = (SharpVk.Interop.Khronos.ImportMemoryWin32HandleInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.ImportMemoryWin32HandleInfo>());
                    importMemoryWin32HandleInfoKhr.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkMemoryAllocateInfoNextPointer;
                    vkMemoryAllocateInfoNextPointer = extensionPointer;
                }
                if (exportMemoryWin32HandleInfoKhr != null)
                {
                    SharpVk.Interop.Khronos.ExportMemoryWin32HandleInfo* extensionPointer = default;
                    extensionPointer = (SharpVk.Interop.Khronos.ExportMemoryWin32HandleInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.ExportMemoryWin32HandleInfo>());
                    exportMemoryWin32HandleInfoKhr.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkMemoryAllocateInfoNextPointer;
                    vkMemoryAllocateInfoNextPointer = extensionPointer;
                }
                if (importMemoryFileDescriptorInfoKhr != null)
                {
                    SharpVk.Interop.Khronos.ImportMemoryFileDescriptorInfo* extensionPointer = default;
                    extensionPointer = (SharpVk.Interop.Khronos.ImportMemoryFileDescriptorInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.ImportMemoryFileDescriptorInfo>());
                    importMemoryFileDescriptorInfoKhr.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkMemoryAllocateInfoNextPointer;
                    vkMemoryAllocateInfoNextPointer = extensionPointer;
                }
                if (memoryAllocateFlagsInfo != null)
                {
                    SharpVk.Interop.MemoryAllocateFlagsInfo* extensionPointer = default;
                    extensionPointer = (SharpVk.Interop.MemoryAllocateFlagsInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.MemoryAllocateFlagsInfo>());
                    memoryAllocateFlagsInfo.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkMemoryAllocateInfoNextPointer;
                    vkMemoryAllocateInfoNextPointer = extensionPointer;
                }
                if (memoryDedicatedAllocateInfo != null)
                {
                    SharpVk.Interop.MemoryDedicatedAllocateInfo* extensionPointer = default;
                    extensionPointer = (SharpVk.Interop.MemoryDedicatedAllocateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.MemoryDedicatedAllocateInfo>());
                    memoryDedicatedAllocateInfo.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkMemoryAllocateInfoNextPointer;
                    vkMemoryAllocateInfoNextPointer = extensionPointer;
                }
                if (importMemoryHostPointerInfoExt != null)
                {
                    SharpVk.Interop.Multivendor.ImportMemoryHostPointerInfo* extensionPointer = default;
                    extensionPointer = (SharpVk.Interop.Multivendor.ImportMemoryHostPointerInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.ImportMemoryHostPointerInfo>());
                    importMemoryHostPointerInfoExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkMemoryAllocateInfoNextPointer;
                    vkMemoryAllocateInfoNextPointer = extensionPointer;
                }
                if (importAndroidHardwareBufferInfoAndroid != null)
                {
                    SharpVk.Interop.Android.ImportAndroidHardwareBufferInfo* extensionPointer = default;
                    extensionPointer = (SharpVk.Interop.Android.ImportAndroidHardwareBufferInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Android.ImportAndroidHardwareBufferInfo>());
                    importAndroidHardwareBufferInfoAndroid.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkMemoryAllocateInfoNextPointer;
                    vkMemoryAllocateInfoNextPointer = extensionPointer;
                }
                if (memoryPriorityAllocateInfoExt != null)
                {
                    SharpVk.Interop.Multivendor.MemoryPriorityAllocateInfo* extensionPointer = default;
                    extensionPointer = (SharpVk.Interop.Multivendor.MemoryPriorityAllocateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.MemoryPriorityAllocateInfo>());
                    memoryPriorityAllocateInfoExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkMemoryAllocateInfoNextPointer;
                    vkMemoryAllocateInfoNextPointer = extensionPointer;
                }
                if (memoryOpaqueCaptureAddressAllocateInfo != null)
                {
                    SharpVk.Interop.MemoryOpaqueCaptureAddressAllocateInfo* extensionPointer = default;
                    extensionPointer = (SharpVk.Interop.MemoryOpaqueCaptureAddressAllocateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.MemoryOpaqueCaptureAddressAllocateInfo>());
                    memoryOpaqueCaptureAddressAllocateInfo.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkMemoryAllocateInfoNextPointer;
                    vkMemoryAllocateInfoNextPointer = extensionPointer;
                }
                marshalledAllocateInfo = (SharpVk.Interop.MemoryAllocateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.MemoryAllocateInfo>());
                marshalledAllocateInfo->SType = StructureType.MemoryAllocateInfo;
                marshalledAllocateInfo->Next = vkMemoryAllocateInfoNextPointer;
                marshalledAllocateInfo->AllocationSize = allocationSize;
                marshalledAllocateInfo->MemoryTypeIndex = memoryTypeIndex;
                if (allocator != null)
                {
                    marshalledAllocator = (SharpVk.Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<SharpVk.Interop.AllocationCallbacks>());
                    allocator.Value.MarshalTo(marshalledAllocator);
                }
                else
                {
                    marshalledAllocator = default;
                }
                Interop.VkDeviceAllocateMemoryDelegate commandDelegate = commandCache.Cache.vkAllocateMemory;
                Result methodResult = commandDelegate(Handle, marshalledAllocateInfo, marshalledAllocator, &marshalledMemory);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = new DeviceMemory(this, marshalledMemory);
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Flush mapped memory ranges.
        /// </summary>
        /// <param name="memoryRanges">
        /// </param>
        public unsafe void FlushMappedMemoryRanges(ArrayProxy<MappedMemoryRange>? memoryRanges)
        {
            try
            {
                SharpVk.Interop.MappedMemoryRange* marshalledMemoryRanges = default;
                if (memoryRanges.IsNull())
                {
                    marshalledMemoryRanges = null;
                }
                else
                {
                    if (memoryRanges.Value.Contents == ProxyContents.Single)
                    {
                        marshalledMemoryRanges = (SharpVk.Interop.MappedMemoryRange*)(Interop.HeapUtil.Allocate<SharpVk.Interop.MappedMemoryRange>());
                        memoryRanges.Value.GetSingleValue().MarshalTo(&*(SharpVk.Interop.MappedMemoryRange*)(marshalledMemoryRanges));
                    }
                    else
                    {
                        var fieldPointer = (SharpVk.Interop.MappedMemoryRange*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.MappedMemoryRange>(Interop.HeapUtil.GetLength(memoryRanges.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(memoryRanges.Value)); index++)
                        {
                            memoryRanges.Value[index].MarshalTo(&fieldPointer[index]);
                        }
                        marshalledMemoryRanges = fieldPointer;
                    }
                }
                Interop.VkDeviceFlushMappedMemoryRangesDelegate commandDelegate = commandCache.Cache.vkFlushMappedMemoryRanges;
                Result methodResult = commandDelegate(Handle, (uint)(Interop.HeapUtil.GetLength(memoryRanges)), marshalledMemoryRanges);
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
        /// Invalidate ranges of mapped memory objects.
        /// </summary>
        /// <param name="memoryRanges">
        /// </param>
        public unsafe void InvalidateMappedMemoryRanges(ArrayProxy<MappedMemoryRange>? memoryRanges)
        {
            try
            {
                SharpVk.Interop.MappedMemoryRange* marshalledMemoryRanges = default;
                if (memoryRanges.IsNull())
                {
                    marshalledMemoryRanges = null;
                }
                else
                {
                    if (memoryRanges.Value.Contents == ProxyContents.Single)
                    {
                        marshalledMemoryRanges = (SharpVk.Interop.MappedMemoryRange*)(Interop.HeapUtil.Allocate<SharpVk.Interop.MappedMemoryRange>());
                        memoryRanges.Value.GetSingleValue().MarshalTo(&*(SharpVk.Interop.MappedMemoryRange*)(marshalledMemoryRanges));
                    }
                    else
                    {
                        var fieldPointer = (SharpVk.Interop.MappedMemoryRange*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.MappedMemoryRange>(Interop.HeapUtil.GetLength(memoryRanges.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(memoryRanges.Value)); index++)
                        {
                            memoryRanges.Value[index].MarshalTo(&fieldPointer[index]);
                        }
                        marshalledMemoryRanges = fieldPointer;
                    }
                }
                Interop.VkDeviceInvalidateMappedMemoryRangesDelegate commandDelegate = commandCache.Cache.vkInvalidateMappedMemoryRanges;
                Result methodResult = commandDelegate(Handle, (uint)(Interop.HeapUtil.GetLength(memoryRanges)), marshalledMemoryRanges);
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
        /// Create a new fence object.
        /// </summary>
        /// <param name="flags">
        /// flags defines the initial state and behavior of the fence. Bits
        /// which can be set include: + --
        /// </param>
        /// <param name="exportFenceCreateInfo">
        /// Extension struct
        /// </param>
        /// <param name="exportFenceWin32HandleInfoKhr">
        /// Extension struct
        /// </param>
        /// <param name="allocator">
        /// An optional AllocationCallbacks instance that controls host memory
        /// allocation.
        /// </param>
        public unsafe Fence CreateFence(FenceCreateFlags? flags = default, ExportFenceCreateInfo? exportFenceCreateInfo = null, Khronos.ExportFenceWin32HandleInfo? exportFenceWin32HandleInfoKhr = null, AllocationCallbacks? allocator = default)
        {
            try
            {
                Fence result = default;
                SharpVk.Interop.FenceCreateInfo* marshalledCreateInfo = default;
                void* vkFenceCreateInfoNextPointer = default;
                SharpVk.Interop.AllocationCallbacks* marshalledAllocator = default;
                SharpVk.Interop.Fence marshalledFence = default;
                if (exportFenceCreateInfo != null)
                {
                    SharpVk.Interop.ExportFenceCreateInfo* extensionPointer = default;
                    extensionPointer = (SharpVk.Interop.ExportFenceCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.ExportFenceCreateInfo>());
                    exportFenceCreateInfo.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkFenceCreateInfoNextPointer;
                    vkFenceCreateInfoNextPointer = extensionPointer;
                }
                if (exportFenceWin32HandleInfoKhr != null)
                {
                    SharpVk.Interop.Khronos.ExportFenceWin32HandleInfo* extensionPointer = default;
                    extensionPointer = (SharpVk.Interop.Khronos.ExportFenceWin32HandleInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.ExportFenceWin32HandleInfo>());
                    exportFenceWin32HandleInfoKhr.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkFenceCreateInfoNextPointer;
                    vkFenceCreateInfoNextPointer = extensionPointer;
                }
                marshalledCreateInfo = (SharpVk.Interop.FenceCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.FenceCreateInfo>());
                marshalledCreateInfo->SType = StructureType.FenceCreateInfo;
                marshalledCreateInfo->Next = vkFenceCreateInfoNextPointer;
                if (flags != null)
                {
                    marshalledCreateInfo->Flags = flags.Value;
                }
                else
                {
                    marshalledCreateInfo->Flags = default;
                }
                if (allocator != null)
                {
                    marshalledAllocator = (SharpVk.Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<SharpVk.Interop.AllocationCallbacks>());
                    allocator.Value.MarshalTo(marshalledAllocator);
                }
                else
                {
                    marshalledAllocator = default;
                }
                Interop.VkDeviceCreateFenceDelegate commandDelegate = commandCache.Cache.vkCreateFence;
                Result methodResult = commandDelegate(Handle, marshalledCreateInfo, marshalledAllocator, &marshalledFence);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = new Fence(this, marshalledFence);
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Resets one or more fence objects.
        /// </summary>
        /// <param name="fences">
        /// </param>
        public unsafe void ResetFences(ArrayProxy<Fence>? fences)
        {
            try
            {
                SharpVk.Interop.Fence* marshalledFences = default;
                if (fences.IsNull())
                {
                    marshalledFences = null;
                }
                else
                {
                    if (fences.Value.Contents == ProxyContents.Single)
                    {
                        marshalledFences = (SharpVk.Interop.Fence*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Fence>());
                        *(SharpVk.Interop.Fence*)(marshalledFences) = fences.Value.GetSingleValue()?.Handle ?? default;
                    }
                    else
                    {
                        var fieldPointer = (SharpVk.Interop.Fence*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.Fence>(Interop.HeapUtil.GetLength(fences.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(fences.Value)); index++)
                        {
                            fieldPointer[index] = fences.Value[index]?.Handle ?? default;
                        }
                        marshalledFences = fieldPointer;
                    }
                }
                Interop.VkDeviceResetFencesDelegate commandDelegate = commandCache.Cache.vkResetFences;
                Result methodResult = commandDelegate(Handle, (uint)(Interop.HeapUtil.GetLength(fences)), marshalledFences);
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
        /// Wait for one or more fences to become signaled.
        /// </summary>
        /// <param name="fences">
        /// </param>
        /// <param name="waitAll">
        /// </param>
        /// <param name="timeout">
        /// </param>
        public unsafe Result WaitForFences(ArrayProxy<Fence>? fences, bool waitAll, ulong timeout)
        {
            try
            {
                Result result = default;
                SharpVk.Interop.Fence* marshalledFences = default;
                if (fences.IsNull())
                {
                    marshalledFences = null;
                }
                else
                {
                    if (fences.Value.Contents == ProxyContents.Single)
                    {
                        marshalledFences = (SharpVk.Interop.Fence*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Fence>());
                        *(SharpVk.Interop.Fence*)(marshalledFences) = fences.Value.GetSingleValue()?.Handle ?? default;
                    }
                    else
                    {
                        var fieldPointer = (SharpVk.Interop.Fence*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.Fence>(Interop.HeapUtil.GetLength(fences.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(fences.Value)); index++)
                        {
                            fieldPointer[index] = fences.Value[index]?.Handle ?? default;
                        }
                        marshalledFences = fieldPointer;
                    }
                }
                Interop.VkDeviceWaitForFencesDelegate commandDelegate = commandCache.Cache.vkWaitForFences;
                result = commandDelegate(Handle, (uint)(Interop.HeapUtil.GetLength(fences)), marshalledFences, waitAll, timeout);
                if (SharpVkException.IsError(result))
                {
                    throw SharpVkException.Create(result);
                }
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Create a new queue semaphore object.
        /// </summary>
        /// <param name="flags">
        /// Reserved for future use.
        /// </param>
        /// <param name="exportSemaphoreCreateInfo">
        /// Extension struct
        /// </param>
        /// <param name="exportSemaphoreWin32HandleInfoKhr">
        /// Extension struct
        /// </param>
        /// <param name="semaphoreTypeCreateInfo">
        /// Extension struct
        /// </param>
        /// <param name="allocator">
        /// An optional AllocationCallbacks instance that controls host memory
        /// allocation.
        /// </param>
        public unsafe Semaphore CreateSemaphore(SemaphoreCreateFlags? flags = default, ExportSemaphoreCreateInfo? exportSemaphoreCreateInfo = null, Khronos.ExportSemaphoreWin32HandleInfo? exportSemaphoreWin32HandleInfoKhr = null, SemaphoreTypeCreateInfo? semaphoreTypeCreateInfo = null, AllocationCallbacks? allocator = default)
        {
            try
            {
                Semaphore result = default;
                SharpVk.Interop.SemaphoreCreateInfo* marshalledCreateInfo = default;
                void* vkSemaphoreCreateInfoNextPointer = default;
                SharpVk.Interop.AllocationCallbacks* marshalledAllocator = default;
                SharpVk.Interop.Semaphore marshalledSemaphore = default;
                if (exportSemaphoreCreateInfo != null)
                {
                    SharpVk.Interop.ExportSemaphoreCreateInfo* extensionPointer = default;
                    extensionPointer = (SharpVk.Interop.ExportSemaphoreCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.ExportSemaphoreCreateInfo>());
                    exportSemaphoreCreateInfo.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkSemaphoreCreateInfoNextPointer;
                    vkSemaphoreCreateInfoNextPointer = extensionPointer;
                }
                if (exportSemaphoreWin32HandleInfoKhr != null)
                {
                    SharpVk.Interop.Khronos.ExportSemaphoreWin32HandleInfo* extensionPointer = default;
                    extensionPointer = (SharpVk.Interop.Khronos.ExportSemaphoreWin32HandleInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.ExportSemaphoreWin32HandleInfo>());
                    exportSemaphoreWin32HandleInfoKhr.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkSemaphoreCreateInfoNextPointer;
                    vkSemaphoreCreateInfoNextPointer = extensionPointer;
                }
                if (semaphoreTypeCreateInfo != null)
                {
                    SharpVk.Interop.SemaphoreTypeCreateInfo* extensionPointer = default;
                    extensionPointer = (SharpVk.Interop.SemaphoreTypeCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.SemaphoreTypeCreateInfo>());
                    semaphoreTypeCreateInfo.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkSemaphoreCreateInfoNextPointer;
                    vkSemaphoreCreateInfoNextPointer = extensionPointer;
                }
                marshalledCreateInfo = (SharpVk.Interop.SemaphoreCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.SemaphoreCreateInfo>());
                marshalledCreateInfo->SType = StructureType.SemaphoreCreateInfo;
                marshalledCreateInfo->Next = vkSemaphoreCreateInfoNextPointer;
                if (flags != null)
                {
                    marshalledCreateInfo->Flags = flags.Value;
                }
                else
                {
                    marshalledCreateInfo->Flags = default;
                }
                if (allocator != null)
                {
                    marshalledAllocator = (SharpVk.Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<SharpVk.Interop.AllocationCallbacks>());
                    allocator.Value.MarshalTo(marshalledAllocator);
                }
                else
                {
                    marshalledAllocator = default;
                }
                Interop.VkDeviceCreateSemaphoreDelegate commandDelegate = commandCache.Cache.vkCreateSemaphore;
                Result methodResult = commandDelegate(Handle, marshalledCreateInfo, marshalledAllocator, &marshalledSemaphore);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = new Semaphore(this, marshalledSemaphore);
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Create a new event object.
        /// </summary>
        /// <param name="flags">
        /// Reserved for future use.
        /// </param>
        /// <param name="allocator">
        /// An optional AllocationCallbacks instance that controls host memory
        /// allocation.
        /// </param>
        public unsafe Event CreateEvent(EventCreateFlags? flags = default, AllocationCallbacks? allocator = default)
        {
            try
            {
                Event result = default;
                SharpVk.Interop.EventCreateInfo* marshalledCreateInfo = default;
                void* vkEventCreateInfoNextPointer = default;
                SharpVk.Interop.AllocationCallbacks* marshalledAllocator = default;
                SharpVk.Interop.Event marshalledEvent = default;
                marshalledCreateInfo = (SharpVk.Interop.EventCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.EventCreateInfo>());
                marshalledCreateInfo->SType = StructureType.EventCreateInfo;
                marshalledCreateInfo->Next = vkEventCreateInfoNextPointer;
                if (flags != null)
                {
                    marshalledCreateInfo->Flags = flags.Value;
                }
                else
                {
                    marshalledCreateInfo->Flags = default;
                }
                if (allocator != null)
                {
                    marshalledAllocator = (SharpVk.Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<SharpVk.Interop.AllocationCallbacks>());
                    allocator.Value.MarshalTo(marshalledAllocator);
                }
                else
                {
                    marshalledAllocator = default;
                }
                Interop.VkDeviceCreateEventDelegate commandDelegate = commandCache.Cache.vkCreateEvent;
                Result methodResult = commandDelegate(Handle, marshalledCreateInfo, marshalledAllocator, &marshalledEvent);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = new Event(this, marshalledEvent);
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Create a new query pool object.
        /// </summary>
        /// <param name="flags">
        /// Reserved for future use.
        /// </param>
        /// <param name="queryType">
        /// The type of queries managed by the pool.
        /// </param>
        /// <param name="queryCount">
        /// </param>
        /// <param name="pipelineStatistics">
        /// </param>
        /// <param name="queryPoolPerformanceCreateInfoKhr">
        /// Extension struct
        /// </param>
        /// <param name="queryPoolPerformanceQueryCreateInfoIntel">
        /// Extension struct
        /// </param>
        /// <param name="allocator">
        /// An optional AllocationCallbacks instance that controls host memory
        /// allocation.
        /// </param>
        public unsafe QueryPool CreateQueryPool(QueryType queryType, uint queryCount, QueryPoolCreateFlags? flags = default, QueryPipelineStatisticFlags? pipelineStatistics = default, Khronos.QueryPoolPerformanceCreateInfo? queryPoolPerformanceCreateInfoKhr = null, Intel.QueryPoolPerformanceQueryCreateInfo? queryPoolPerformanceQueryCreateInfoIntel = null, AllocationCallbacks? allocator = default)
        {
            try
            {
                QueryPool result = default;
                SharpVk.Interop.QueryPoolCreateInfo* marshalledCreateInfo = default;
                void* vkQueryPoolCreateInfoNextPointer = default;
                SharpVk.Interop.AllocationCallbacks* marshalledAllocator = default;
                SharpVk.Interop.QueryPool marshalledQueryPool = default;
                if (queryPoolPerformanceCreateInfoKhr != null)
                {
                    SharpVk.Interop.Khronos.QueryPoolPerformanceCreateInfo* extensionPointer = default;
                    extensionPointer = (SharpVk.Interop.Khronos.QueryPoolPerformanceCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.QueryPoolPerformanceCreateInfo>());
                    queryPoolPerformanceCreateInfoKhr.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkQueryPoolCreateInfoNextPointer;
                    vkQueryPoolCreateInfoNextPointer = extensionPointer;
                }
                if (queryPoolPerformanceQueryCreateInfoIntel != null)
                {
                    SharpVk.Interop.Intel.QueryPoolPerformanceQueryCreateInfo* extensionPointer = default;
                    extensionPointer = (SharpVk.Interop.Intel.QueryPoolPerformanceQueryCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Intel.QueryPoolPerformanceQueryCreateInfo>());
                    queryPoolPerformanceQueryCreateInfoIntel.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkQueryPoolCreateInfoNextPointer;
                    vkQueryPoolCreateInfoNextPointer = extensionPointer;
                }
                marshalledCreateInfo = (SharpVk.Interop.QueryPoolCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.QueryPoolCreateInfo>());
                marshalledCreateInfo->SType = StructureType.QueryPoolCreateInfo;
                marshalledCreateInfo->Next = vkQueryPoolCreateInfoNextPointer;
                if (flags != null)
                {
                    marshalledCreateInfo->Flags = flags.Value;
                }
                else
                {
                    marshalledCreateInfo->Flags = default;
                }
                marshalledCreateInfo->QueryType = queryType;
                marshalledCreateInfo->QueryCount = queryCount;
                if (pipelineStatistics != null)
                {
                    marshalledCreateInfo->PipelineStatistics = pipelineStatistics.Value;
                }
                else
                {
                    marshalledCreateInfo->PipelineStatistics = default;
                }
                if (allocator != null)
                {
                    marshalledAllocator = (SharpVk.Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<SharpVk.Interop.AllocationCallbacks>());
                    allocator.Value.MarshalTo(marshalledAllocator);
                }
                else
                {
                    marshalledAllocator = default;
                }
                Interop.VkDeviceCreateQueryPoolDelegate commandDelegate = commandCache.Cache.vkCreateQueryPool;
                Result methodResult = commandDelegate(Handle, marshalledCreateInfo, marshalledAllocator, &marshalledQueryPool);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = new QueryPool(this, marshalledQueryPool);
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Create a new buffer object.
        /// </summary>
        /// <param name="flags">
        /// A bitmask describing additional parameters of the buffer.
        /// </param>
        /// <param name="size">
        /// The size in bytes of the buffer to be created.
        /// </param>
        /// <param name="usage">
        /// A bitmask describing the allowed usages of the buffer.
        /// </param>
        /// <param name="sharingMode">
        /// The sharing mode of the buffer when it will be accessed by multiple
        /// queue families.
        /// </param>
        /// <param name="queueFamilyIndices">
        /// </param>
        /// <param name="dedicatedAllocationBufferCreateInfoNv">
        /// Extension struct
        /// </param>
        /// <param name="externalMemoryBufferCreateInfo">
        /// Extension struct
        /// </param>
        /// <param name="bufferOpaqueCaptureAddressCreateInfo">
        /// Extension struct
        /// </param>
        /// <param name="bufferDeviceAddressCreateInfoExt">
        /// Extension struct
        /// </param>
        /// <param name="allocator">
        /// An optional AllocationCallbacks instance that controls host memory
        /// allocation.
        /// </param>
        public unsafe Buffer CreateBuffer(ulong size, BufferUsageFlags usage, SharingMode sharingMode, ArrayProxy<uint>? queueFamilyIndices, BufferCreateFlags? flags = default, NVidia.DedicatedAllocationBufferCreateInfo? dedicatedAllocationBufferCreateInfoNv = null, ExternalMemoryBufferCreateInfo? externalMemoryBufferCreateInfo = null, BufferOpaqueCaptureAddressCreateInfo? bufferOpaqueCaptureAddressCreateInfo = null, Multivendor.BufferDeviceAddressCreateInfo? bufferDeviceAddressCreateInfoExt = null, AllocationCallbacks? allocator = default)
        {
            try
            {
                Buffer result = default;
                SharpVk.Interop.BufferCreateInfo* marshalledCreateInfo = default;
                void* vkBufferCreateInfoNextPointer = default;
                SharpVk.Interop.AllocationCallbacks* marshalledAllocator = default;
                SharpVk.Interop.Buffer marshalledBuffer = default;
                if (dedicatedAllocationBufferCreateInfoNv != null)
                {
                    SharpVk.Interop.NVidia.DedicatedAllocationBufferCreateInfo* extensionPointer = default;
                    extensionPointer = (SharpVk.Interop.NVidia.DedicatedAllocationBufferCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.NVidia.DedicatedAllocationBufferCreateInfo>());
                    dedicatedAllocationBufferCreateInfoNv.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkBufferCreateInfoNextPointer;
                    vkBufferCreateInfoNextPointer = extensionPointer;
                }
                if (externalMemoryBufferCreateInfo != null)
                {
                    SharpVk.Interop.ExternalMemoryBufferCreateInfo* extensionPointer = default;
                    extensionPointer = (SharpVk.Interop.ExternalMemoryBufferCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.ExternalMemoryBufferCreateInfo>());
                    externalMemoryBufferCreateInfo.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkBufferCreateInfoNextPointer;
                    vkBufferCreateInfoNextPointer = extensionPointer;
                }
                if (bufferOpaqueCaptureAddressCreateInfo != null)
                {
                    SharpVk.Interop.BufferOpaqueCaptureAddressCreateInfo* extensionPointer = default;
                    extensionPointer = (SharpVk.Interop.BufferOpaqueCaptureAddressCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.BufferOpaqueCaptureAddressCreateInfo>());
                    bufferOpaqueCaptureAddressCreateInfo.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkBufferCreateInfoNextPointer;
                    vkBufferCreateInfoNextPointer = extensionPointer;
                }
                if (bufferDeviceAddressCreateInfoExt != null)
                {
                    SharpVk.Interop.Multivendor.BufferDeviceAddressCreateInfo* extensionPointer = default;
                    extensionPointer = (SharpVk.Interop.Multivendor.BufferDeviceAddressCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.BufferDeviceAddressCreateInfo>());
                    bufferDeviceAddressCreateInfoExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkBufferCreateInfoNextPointer;
                    vkBufferCreateInfoNextPointer = extensionPointer;
                }
                marshalledCreateInfo = (SharpVk.Interop.BufferCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.BufferCreateInfo>());
                marshalledCreateInfo->SType = StructureType.BufferCreateInfo;
                marshalledCreateInfo->Next = vkBufferCreateInfoNextPointer;
                if (flags != null)
                {
                    marshalledCreateInfo->Flags = flags.Value;
                }
                else
                {
                    marshalledCreateInfo->Flags = default;
                }
                marshalledCreateInfo->Size = size;
                marshalledCreateInfo->Usage = usage;
                marshalledCreateInfo->SharingMode = sharingMode;
                marshalledCreateInfo->QueueFamilyIndexCount = (uint)(Interop.HeapUtil.GetLength(queueFamilyIndices));
                if (queueFamilyIndices.IsNull())
                {
                    marshalledCreateInfo->QueueFamilyIndices = null;
                }
                else
                {
                    if (queueFamilyIndices.Value.Contents == ProxyContents.Single)
                    {
                        marshalledCreateInfo->QueueFamilyIndices = (uint*)(Interop.HeapUtil.Allocate<uint>());
                        *(uint*)(marshalledCreateInfo->QueueFamilyIndices) = queueFamilyIndices.Value.GetSingleValue();
                    }
                    else
                    {
                        var fieldPointer = (uint*)(Interop.HeapUtil.AllocateAndClear<uint>(Interop.HeapUtil.GetLength(queueFamilyIndices.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(queueFamilyIndices.Value)); index++)
                        {
                            fieldPointer[index] = queueFamilyIndices.Value[index];
                        }
                        marshalledCreateInfo->QueueFamilyIndices = fieldPointer;
                    }
                }
                if (allocator != null)
                {
                    marshalledAllocator = (SharpVk.Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<SharpVk.Interop.AllocationCallbacks>());
                    allocator.Value.MarshalTo(marshalledAllocator);
                }
                else
                {
                    marshalledAllocator = default;
                }
                Interop.VkDeviceCreateBufferDelegate commandDelegate = commandCache.Cache.vkCreateBuffer;
                Result methodResult = commandDelegate(Handle, marshalledCreateInfo, marshalledAllocator, &marshalledBuffer);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = new Buffer(this, marshalledBuffer);
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Create a new buffer view object.
        /// </summary>
        /// <param name="flags">
        /// Reserved for future use.
        /// </param>
        /// <param name="buffer">
        /// A Buffer on which the view will be created.
        /// </param>
        /// <param name="format">
        /// A Format describing the format of the data elements in the buffer.
        /// </param>
        /// <param name="offset">
        /// An offset in bytes from the base address of the buffer. Accesses to
        /// the buffer view from shaders use addressing that is relative to
        /// this starting offset.
        /// </param>
        /// <param name="range">
        /// A size in bytes of the buffer view. If range is equal to
        /// Constants.WholeSize, the range from offset to the end of the buffer
        /// is used. If Constants.WholeSize is used and the remaining size of
        /// the buffer is not a multiple of the element size of format, then
        /// the nearest smaller multiple is used.
        /// </param>
        /// <param name="allocator">
        /// An optional AllocationCallbacks instance that controls host memory
        /// allocation.
        /// </param>
        public unsafe BufferView CreateBufferView(Buffer buffer, Format format, ulong offset, ulong range, BufferViewCreateFlags? flags = default, AllocationCallbacks? allocator = default)
        {
            try
            {
                BufferView result = default;
                SharpVk.Interop.BufferViewCreateInfo* marshalledCreateInfo = default;
                void* vkBufferViewCreateInfoNextPointer = default;
                SharpVk.Interop.AllocationCallbacks* marshalledAllocator = default;
                SharpVk.Interop.BufferView marshalledView = default;
                marshalledCreateInfo = (SharpVk.Interop.BufferViewCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.BufferViewCreateInfo>());
                marshalledCreateInfo->SType = StructureType.BufferViewCreateInfo;
                marshalledCreateInfo->Next = vkBufferViewCreateInfoNextPointer;
                if (flags != null)
                {
                    marshalledCreateInfo->Flags = flags.Value;
                }
                else
                {
                    marshalledCreateInfo->Flags = default;
                }
                marshalledCreateInfo->Buffer = buffer?.Handle ?? default;
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
                    marshalledAllocator = default;
                }
                Interop.VkDeviceCreateBufferViewDelegate commandDelegate = commandCache.Cache.vkCreateBufferView;
                Result methodResult = commandDelegate(Handle, marshalledCreateInfo, marshalledAllocator, &marshalledView);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = new BufferView(this, marshalledView);
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Create a new image object.
        /// </summary>
        /// <param name="flags">
        /// A bitmask describing additional parameters of the image. See
        /// ImageCreateFlagBits below for a description of the supported bits.
        /// </param>
        /// <param name="imageType">
        /// An ImageType specifying the basic dimensionality of the image, as
        /// described below. Layers in array textures do not count as a
        /// dimension for the purposes of the image type.
        /// </param>
        /// <param name="format">
        /// A Format describing the format and type of the data elements that
        /// will be contained in the image.
        /// </param>
        /// <param name="extent">
        /// A Extent3D describing the number of data elements in each dimension
        /// of the base level.
        /// </param>
        /// <param name="mipLevels">
        /// mipLevels describes the number of levels of detail available for
        /// minified sampling of the image.
        /// </param>
        /// <param name="arrayLayers">
        /// The number of layers in the image.
        /// </param>
        /// <param name="samples">
        /// The number of sub-data element samples in the image as defined in
        /// SampleCountFlagBits. See Multisampling.
        /// </param>
        /// <param name="tiling">
        /// An ImageTiling specifying the tiling arrangement of the data
        /// elements in memory, as described below.
        /// </param>
        /// <param name="usage">
        /// A bitmask describing the intended usage of the image. See
        /// ImageUsageFlagBits below for a description of the supported bits.
        /// </param>
        /// <param name="sharingMode">
        /// The sharing mode of the image when it will be accessed by multiple
        /// queue families, and must be one of the values described for
        /// SharingMode in the Resource Sharing section below.
        /// </param>
        /// <param name="queueFamilyIndices">
        /// </param>
        /// <param name="initialLayout">
        /// initialLayout selects the initial ImageLayout state of all image
        /// subresources of the image. See Image Layouts. initialLayout must be
        /// VK_IMAGE_LAYOUT_UNDEFINED or VK_IMAGE_LAYOUT_PREINITIALIZED.
        /// </param>
        /// <param name="dedicatedAllocationImageCreateInfoNv">
        /// Extension struct
        /// </param>
        /// <param name="externalMemoryImageCreateInfoNv">
        /// Extension struct
        /// </param>
        /// <param name="externalMemoryImageCreateInfo">
        /// Extension struct
        /// </param>
        /// <param name="imageSwapchainCreateInfoKhr">
        /// Extension struct
        /// </param>
        /// <param name="imageFormatListCreateInfo">
        /// Extension struct
        /// </param>
        /// <param name="externalFormatAndroid">
        /// Extension struct
        /// </param>
        /// <param name="imageDrmFormatModifierListCreateInfoExt">
        /// Extension struct
        /// </param>
        /// <param name="imageDrmFormatModifierExplicitCreateInfoExt">
        /// Extension struct
        /// </param>
        /// <param name="imageStencilUsageCreateInfo">
        /// Extension struct
        /// </param>
        /// <param name="allocator">
        /// An optional AllocationCallbacks instance that controls host memory
        /// allocation.
        /// </param>
        public unsafe Image CreateImage(ImageType imageType, Format format, Extent3D extent, uint mipLevels, uint arrayLayers, SampleCountFlags samples, ImageTiling tiling, ImageUsageFlags usage, SharingMode sharingMode, ArrayProxy<uint>? queueFamilyIndices, ImageLayout initialLayout, ImageCreateFlags? flags = default, NVidia.DedicatedAllocationImageCreateInfo? dedicatedAllocationImageCreateInfoNv = null, SharpVk.NVidia.ExternalMemoryImageCreateInfo? externalMemoryImageCreateInfoNv = null, ExternalMemoryImageCreateInfo? externalMemoryImageCreateInfo = null, Khronos.ImageSwapchainCreateInfo? imageSwapchainCreateInfoKhr = null, ImageFormatListCreateInfo? imageFormatListCreateInfo = null, Android.ExternalFormat? externalFormatAndroid = null, Multivendor.ImageDrmFormatModifierListCreateInfo? imageDrmFormatModifierListCreateInfoExt = null, Multivendor.ImageDrmFormatModifierExplicitCreateInfo? imageDrmFormatModifierExplicitCreateInfoExt = null, ImageStencilUsageCreateInfo? imageStencilUsageCreateInfo = null, AllocationCallbacks? allocator = default)
        {
            try
            {
                Image result = default;
                SharpVk.Interop.ImageCreateInfo* marshalledCreateInfo = default;
                void* vkImageCreateInfoNextPointer = default;
                SharpVk.Interop.AllocationCallbacks* marshalledAllocator = default;
                SharpVk.Interop.Image marshalledImage = default;
                if (dedicatedAllocationImageCreateInfoNv != null)
                {
                    SharpVk.Interop.NVidia.DedicatedAllocationImageCreateInfo* extensionPointer = default;
                    extensionPointer = (SharpVk.Interop.NVidia.DedicatedAllocationImageCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.NVidia.DedicatedAllocationImageCreateInfo>());
                    dedicatedAllocationImageCreateInfoNv.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkImageCreateInfoNextPointer;
                    vkImageCreateInfoNextPointer = extensionPointer;
                }
                if (externalMemoryImageCreateInfoNv != null)
                {
                    SharpVk.Interop.NVidia.ExternalMemoryImageCreateInfo* extensionPointer = default;
                    extensionPointer = (SharpVk.Interop.NVidia.ExternalMemoryImageCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.NVidia.ExternalMemoryImageCreateInfo>());
                    externalMemoryImageCreateInfoNv.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkImageCreateInfoNextPointer;
                    vkImageCreateInfoNextPointer = extensionPointer;
                }
                if (externalMemoryImageCreateInfo != null)
                {
                    SharpVk.Interop.ExternalMemoryImageCreateInfo* extensionPointer = default;
                    extensionPointer = (SharpVk.Interop.ExternalMemoryImageCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.ExternalMemoryImageCreateInfo>());
                    externalMemoryImageCreateInfo.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkImageCreateInfoNextPointer;
                    vkImageCreateInfoNextPointer = extensionPointer;
                }
                if (imageSwapchainCreateInfoKhr != null)
                {
                    SharpVk.Interop.Khronos.ImageSwapchainCreateInfo* extensionPointer = default;
                    extensionPointer = (SharpVk.Interop.Khronos.ImageSwapchainCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.ImageSwapchainCreateInfo>());
                    imageSwapchainCreateInfoKhr.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkImageCreateInfoNextPointer;
                    vkImageCreateInfoNextPointer = extensionPointer;
                }
                if (imageFormatListCreateInfo != null)
                {
                    SharpVk.Interop.ImageFormatListCreateInfo* extensionPointer = default;
                    extensionPointer = (SharpVk.Interop.ImageFormatListCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.ImageFormatListCreateInfo>());
                    imageFormatListCreateInfo.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkImageCreateInfoNextPointer;
                    vkImageCreateInfoNextPointer = extensionPointer;
                }
                if (externalFormatAndroid != null)
                {
                    SharpVk.Interop.Android.ExternalFormat* extensionPointer = default;
                    extensionPointer = (SharpVk.Interop.Android.ExternalFormat*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Android.ExternalFormat>());
                    externalFormatAndroid.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkImageCreateInfoNextPointer;
                    vkImageCreateInfoNextPointer = extensionPointer;
                }
                if (imageDrmFormatModifierListCreateInfoExt != null)
                {
                    SharpVk.Interop.Multivendor.ImageDrmFormatModifierListCreateInfo* extensionPointer = default;
                    extensionPointer = (SharpVk.Interop.Multivendor.ImageDrmFormatModifierListCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.ImageDrmFormatModifierListCreateInfo>());
                    imageDrmFormatModifierListCreateInfoExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkImageCreateInfoNextPointer;
                    vkImageCreateInfoNextPointer = extensionPointer;
                }
                if (imageDrmFormatModifierExplicitCreateInfoExt != null)
                {
                    SharpVk.Interop.Multivendor.ImageDrmFormatModifierExplicitCreateInfo* extensionPointer = default;
                    extensionPointer = (SharpVk.Interop.Multivendor.ImageDrmFormatModifierExplicitCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.ImageDrmFormatModifierExplicitCreateInfo>());
                    imageDrmFormatModifierExplicitCreateInfoExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkImageCreateInfoNextPointer;
                    vkImageCreateInfoNextPointer = extensionPointer;
                }
                if (imageStencilUsageCreateInfo != null)
                {
                    SharpVk.Interop.ImageStencilUsageCreateInfo* extensionPointer = default;
                    extensionPointer = (SharpVk.Interop.ImageStencilUsageCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.ImageStencilUsageCreateInfo>());
                    imageStencilUsageCreateInfo.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkImageCreateInfoNextPointer;
                    vkImageCreateInfoNextPointer = extensionPointer;
                }
                marshalledCreateInfo = (SharpVk.Interop.ImageCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.ImageCreateInfo>());
                marshalledCreateInfo->SType = StructureType.ImageCreateInfo;
                marshalledCreateInfo->Next = vkImageCreateInfoNextPointer;
                if (flags != null)
                {
                    marshalledCreateInfo->Flags = flags.Value;
                }
                else
                {
                    marshalledCreateInfo->Flags = default;
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
                marshalledCreateInfo->QueueFamilyIndexCount = (uint)(Interop.HeapUtil.GetLength(queueFamilyIndices));
                if (queueFamilyIndices.IsNull())
                {
                    marshalledCreateInfo->QueueFamilyIndices = null;
                }
                else
                {
                    if (queueFamilyIndices.Value.Contents == ProxyContents.Single)
                    {
                        marshalledCreateInfo->QueueFamilyIndices = (uint*)(Interop.HeapUtil.Allocate<uint>());
                        *(uint*)(marshalledCreateInfo->QueueFamilyIndices) = queueFamilyIndices.Value.GetSingleValue();
                    }
                    else
                    {
                        var fieldPointer = (uint*)(Interop.HeapUtil.AllocateAndClear<uint>(Interop.HeapUtil.GetLength(queueFamilyIndices.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(queueFamilyIndices.Value)); index++)
                        {
                            fieldPointer[index] = queueFamilyIndices.Value[index];
                        }
                        marshalledCreateInfo->QueueFamilyIndices = fieldPointer;
                    }
                }
                marshalledCreateInfo->InitialLayout = initialLayout;
                if (allocator != null)
                {
                    marshalledAllocator = (SharpVk.Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<SharpVk.Interop.AllocationCallbacks>());
                    allocator.Value.MarshalTo(marshalledAllocator);
                }
                else
                {
                    marshalledAllocator = default;
                }
                Interop.VkDeviceCreateImageDelegate commandDelegate = commandCache.Cache.vkCreateImage;
                Result methodResult = commandDelegate(Handle, marshalledCreateInfo, marshalledAllocator, &marshalledImage);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = new Image(this, marshalledImage);
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Create an image view from an existing image.
        /// </summary>
        /// <param name="flags">
        /// Reserved for future use.
        /// </param>
        /// <param name="image">
        /// An Image on which the view will be created.
        /// </param>
        /// <param name="viewType">
        /// The type of the image view.
        /// </param>
        /// <param name="format">
        /// A Format describing the format and type used to interpret data
        /// elements in the image.
        /// </param>
        /// <param name="components">
        /// Specifies a remapping of color components (or of depth or stencil
        /// components after they have been converted into color components).
        /// </param>
        /// <param name="subresourceRange">
        /// An ImageSubresourceRange selecting the set of mipmap levels and
        /// array layers to be accessible to the view.
        /// </param>
        /// <param name="imageViewUsageCreateInfo">
        /// Extension struct
        /// </param>
        /// <param name="samplerYcbcrConversionInfo">
        /// Extension struct
        /// </param>
        /// <param name="imageViewASTCDecodeModeExt">
        /// Extension struct
        /// </param>
        /// <param name="allocator">
        /// An optional AllocationCallbacks instance that controls host memory
        /// allocation.
        /// </param>
        public unsafe ImageView CreateImageView(Image image, ImageViewType viewType, Format format, ComponentMapping components, ImageSubresourceRange subresourceRange, ImageViewCreateFlags? flags = default, ImageViewUsageCreateInfo? imageViewUsageCreateInfo = null, SamplerYcbcrConversionInfo? samplerYcbcrConversionInfo = null, Multivendor.ImageViewASTCDecodeMode? imageViewASTCDecodeModeExt = null, AllocationCallbacks? allocator = default)
        {
            try
            {
                ImageView result = default;
                SharpVk.Interop.ImageViewCreateInfo* marshalledCreateInfo = default;
                void* vkImageViewCreateInfoNextPointer = default;
                SharpVk.Interop.AllocationCallbacks* marshalledAllocator = default;
                SharpVk.Interop.ImageView marshalledView = default;
                if (imageViewUsageCreateInfo != null)
                {
                    SharpVk.Interop.ImageViewUsageCreateInfo* extensionPointer = default;
                    extensionPointer = (SharpVk.Interop.ImageViewUsageCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.ImageViewUsageCreateInfo>());
                    imageViewUsageCreateInfo.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkImageViewCreateInfoNextPointer;
                    vkImageViewCreateInfoNextPointer = extensionPointer;
                }
                if (samplerYcbcrConversionInfo != null)
                {
                    SharpVk.Interop.SamplerYcbcrConversionInfo* extensionPointer = default;
                    extensionPointer = (SharpVk.Interop.SamplerYcbcrConversionInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.SamplerYcbcrConversionInfo>());
                    samplerYcbcrConversionInfo.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkImageViewCreateInfoNextPointer;
                    vkImageViewCreateInfoNextPointer = extensionPointer;
                }
                if (imageViewASTCDecodeModeExt != null)
                {
                    SharpVk.Interop.Multivendor.ImageViewASTCDecodeMode* extensionPointer = default;
                    extensionPointer = (SharpVk.Interop.Multivendor.ImageViewASTCDecodeMode*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.ImageViewASTCDecodeMode>());
                    imageViewASTCDecodeModeExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkImageViewCreateInfoNextPointer;
                    vkImageViewCreateInfoNextPointer = extensionPointer;
                }
                marshalledCreateInfo = (SharpVk.Interop.ImageViewCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.ImageViewCreateInfo>());
                marshalledCreateInfo->SType = StructureType.ImageViewCreateInfo;
                marshalledCreateInfo->Next = vkImageViewCreateInfoNextPointer;
                if (flags != null)
                {
                    marshalledCreateInfo->Flags = flags.Value;
                }
                else
                {
                    marshalledCreateInfo->Flags = default;
                }
                marshalledCreateInfo->Image = image?.Handle ?? default;
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
                    marshalledAllocator = default;
                }
                Interop.VkDeviceCreateImageViewDelegate commandDelegate = commandCache.Cache.vkCreateImageView;
                Result methodResult = commandDelegate(Handle, marshalledCreateInfo, marshalledAllocator, &marshalledView);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = new ImageView(this, marshalledView);
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Creates a new shader module object.
        /// </summary>
        /// <param name="flags">
        /// Reserved for future use.
        /// </param>
        /// <param name="codeSize">
        /// The size, in bytes, of the code.
        /// </param>
        /// <param name="code">
        /// </param>
        /// <param name="shaderModuleValidationCacheCreateInfoExt">
        /// Extension struct
        /// </param>
        /// <param name="allocator">
        /// An optional AllocationCallbacks instance that controls host memory
        /// allocation.
        /// </param>
        public unsafe ShaderModule CreateShaderModule(HostSize codeSize, ArrayProxy<uint>? code, ShaderModuleCreateFlags? flags = default, Multivendor.ShaderModuleValidationCacheCreateInfo? shaderModuleValidationCacheCreateInfoExt = null, AllocationCallbacks? allocator = default)
        {
            try
            {
                ShaderModule result = default;
                SharpVk.Interop.ShaderModuleCreateInfo* marshalledCreateInfo = default;
                void* vkShaderModuleCreateInfoNextPointer = default;
                SharpVk.Interop.AllocationCallbacks* marshalledAllocator = default;
                SharpVk.Interop.ShaderModule marshalledShaderModule = default;
                if (shaderModuleValidationCacheCreateInfoExt != null)
                {
                    SharpVk.Interop.Multivendor.ShaderModuleValidationCacheCreateInfo* extensionPointer = default;
                    extensionPointer = (SharpVk.Interop.Multivendor.ShaderModuleValidationCacheCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.ShaderModuleValidationCacheCreateInfo>());
                    shaderModuleValidationCacheCreateInfoExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkShaderModuleCreateInfoNextPointer;
                    vkShaderModuleCreateInfoNextPointer = extensionPointer;
                }
                marshalledCreateInfo = (SharpVk.Interop.ShaderModuleCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.ShaderModuleCreateInfo>());
                marshalledCreateInfo->SType = StructureType.ShaderModuleCreateInfo;
                marshalledCreateInfo->Next = vkShaderModuleCreateInfoNextPointer;
                if (flags != null)
                {
                    marshalledCreateInfo->Flags = flags.Value;
                }
                else
                {
                    marshalledCreateInfo->Flags = default;
                }
                marshalledCreateInfo->CodeSize = codeSize;
                if (code.IsNull())
                {
                    marshalledCreateInfo->Code = null;
                }
                else
                {
                    if (code.Value.Contents == ProxyContents.Single)
                    {
                        marshalledCreateInfo->Code = (uint*)(Interop.HeapUtil.Allocate<uint>());
                        *(uint*)(marshalledCreateInfo->Code) = code.Value.GetSingleValue();
                    }
                    else
                    {
                        var fieldPointer = (uint*)(Interop.HeapUtil.AllocateAndClear<uint>(Interop.HeapUtil.GetLength(code.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(code.Value)); index++)
                        {
                            fieldPointer[index] = code.Value[index];
                        }
                        marshalledCreateInfo->Code = fieldPointer;
                    }
                }
                if (allocator != null)
                {
                    marshalledAllocator = (SharpVk.Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<SharpVk.Interop.AllocationCallbacks>());
                    allocator.Value.MarshalTo(marshalledAllocator);
                }
                else
                {
                    marshalledAllocator = default;
                }
                Interop.VkDeviceCreateShaderModuleDelegate commandDelegate = commandCache.Cache.vkCreateShaderModule;
                Result methodResult = commandDelegate(Handle, marshalledCreateInfo, marshalledAllocator, &marshalledShaderModule);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = new ShaderModule(this, marshalledShaderModule);
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Creates a new pipeline cache.
        /// </summary>
        /// <param name="flags">
        /// Reserved for future use.
        /// </param>
        /// <param name="initialData">
        /// </param>
        /// <param name="allocator">
        /// An optional AllocationCallbacks instance that controls host memory
        /// allocation.
        /// </param>
        public unsafe PipelineCache CreatePipelineCache(ArrayProxy<byte>? initialData, PipelineCacheCreateFlags? flags = default, AllocationCallbacks? allocator = default)
        {
            try
            {
                PipelineCache result = default;
                SharpVk.Interop.PipelineCacheCreateInfo* marshalledCreateInfo = default;
                void* vkPipelineCacheCreateInfoNextPointer = default;
                SharpVk.Interop.AllocationCallbacks* marshalledAllocator = default;
                SharpVk.Interop.PipelineCache marshalledPipelineCache = default;
                marshalledCreateInfo = (SharpVk.Interop.PipelineCacheCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.PipelineCacheCreateInfo>());
                marshalledCreateInfo->SType = StructureType.PipelineCacheCreateInfo;
                marshalledCreateInfo->Next = vkPipelineCacheCreateInfoNextPointer;
                if (flags != null)
                {
                    marshalledCreateInfo->Flags = flags.Value;
                }
                else
                {
                    marshalledCreateInfo->Flags = default;
                }
                marshalledCreateInfo->InitialDataSize = (HostSize)(Interop.HeapUtil.GetLength(initialData));
                if (initialData.IsNull())
                {
                    marshalledCreateInfo->InitialData = null;
                }
                else
                {
                    if (initialData.Value.Contents == ProxyContents.Single)
                    {
                        marshalledCreateInfo->InitialData = (byte*)(Interop.HeapUtil.Allocate<byte>());
                        *(byte*)(marshalledCreateInfo->InitialData) = initialData.Value.GetSingleValue();
                    }
                    else
                    {
                        var fieldPointer = (byte*)(Interop.HeapUtil.AllocateAndClear<byte>(Interop.HeapUtil.GetLength(initialData.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(initialData.Value)); index++)
                        {
                            fieldPointer[index] = initialData.Value[index];
                        }
                        marshalledCreateInfo->InitialData = fieldPointer;
                    }
                }
                if (allocator != null)
                {
                    marshalledAllocator = (SharpVk.Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<SharpVk.Interop.AllocationCallbacks>());
                    allocator.Value.MarshalTo(marshalledAllocator);
                }
                else
                {
                    marshalledAllocator = default;
                }
                Interop.VkDeviceCreatePipelineCacheDelegate commandDelegate = commandCache.Cache.vkCreatePipelineCache;
                Result methodResult = commandDelegate(Handle, marshalledCreateInfo, marshalledAllocator, &marshalledPipelineCache);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = new PipelineCache(this, marshalledPipelineCache);
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Create graphics pipelines.
        /// </summary>
        /// <param name="pipelineCache">
        /// </param>
        /// <param name="createInfos">
        /// </param>
        /// <param name="allocator">
        /// An optional AllocationCallbacks instance that controls host memory
        /// allocation.
        /// </param>
        public unsafe Pipeline[] CreateGraphicsPipelines(PipelineCache pipelineCache, ArrayProxy<GraphicsPipelineCreateInfo>? createInfos, AllocationCallbacks? allocator = default)
        {
            try
            {
                Pipeline[] result = default;
                uint marshalledCreateInfoCount = default;
                SharpVk.Interop.GraphicsPipelineCreateInfo* marshalledCreateInfos = default;
                SharpVk.Interop.AllocationCallbacks* marshalledAllocator = default;
                SharpVk.Interop.Pipeline* marshalledPipelines = default;
                marshalledCreateInfoCount = (uint)(Interop.HeapUtil.GetLength(createInfos));
                if (createInfos.IsNull())
                {
                    marshalledCreateInfos = null;
                }
                else
                {
                    if (createInfos.Value.Contents == ProxyContents.Single)
                    {
                        marshalledCreateInfos = (SharpVk.Interop.GraphicsPipelineCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.GraphicsPipelineCreateInfo>());
                        createInfos.Value.GetSingleValue().MarshalTo(&*(SharpVk.Interop.GraphicsPipelineCreateInfo*)(marshalledCreateInfos));
                    }
                    else
                    {
                        var fieldPointer = (SharpVk.Interop.GraphicsPipelineCreateInfo*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.GraphicsPipelineCreateInfo>(Interop.HeapUtil.GetLength(createInfos.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(createInfos.Value)); index++)
                        {
                            createInfos.Value[index].MarshalTo(&fieldPointer[index]);
                        }
                        marshalledCreateInfos = fieldPointer;
                    }
                }
                if (allocator != null)
                {
                    marshalledAllocator = (SharpVk.Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<SharpVk.Interop.AllocationCallbacks>());
                    allocator.Value.MarshalTo(marshalledAllocator);
                }
                else
                {
                    marshalledAllocator = default;
                }
                marshalledPipelines = (SharpVk.Interop.Pipeline*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Pipeline>(marshalledCreateInfoCount));
                Interop.VkDeviceCreateGraphicsPipelinesDelegate commandDelegate = commandCache.Cache.vkCreateGraphicsPipelines;
                Result methodResult = commandDelegate(Handle, pipelineCache?.Handle ?? default, marshalledCreateInfoCount, marshalledCreateInfos, marshalledAllocator, marshalledPipelines);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                if (marshalledPipelines != null)
                {
                    var fieldPointer = new Pipeline[(uint)(marshalledCreateInfoCount)];
                    for(int index = 0; index < (uint)(marshalledCreateInfoCount); index++)
                    {
                        fieldPointer[index] = new Pipeline(this, marshalledPipelines[index]);
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
        /// Create graphics pipelines.
        /// </summary>
        /// <param name="pipelineCache">
        /// </param>
        /// <param name="flags">
        /// A bitmask of PipelineCreateFlagBits controlling how the pipeline
        /// will be generated, as described below.
        /// </param>
        /// <param name="stages">
        /// </param>
        /// <param name="vertexInputState">
        /// An instance of the PipelineVertexInputStateCreateInfo structure.
        /// </param>
        /// <param name="inputAssemblyState">
        /// An instance of the PipelineInputAssemblyStateCreateInfo structure
        /// which determines input assembly behavior.
        /// </param>
        /// <param name="tessellationState">
        /// An instance of the PipelineTessellationStateCreateInfo structure,
        /// or Null if the pipeline does not include a tessellation control
        /// shader stage and tessellation evaluation shader stage.
        /// </param>
        /// <param name="viewportState">
        /// An instance of the PipelineViewportStateCreateInfo structure, or
        /// Null if the pipeline has rasterization disabled.
        /// </param>
        /// <param name="rasterizationState">
        /// An instance of the PipelineRasterizationStateCreateInfo structure.
        /// </param>
        /// <param name="multisampleState">
        /// An instance of the PipelineMultisampleStateCreateInfo, or Null if
        /// the pipeline has rasterization disabled.
        /// </param>
        /// <param name="depthStencilState">
        /// An instance of the PipelineDepthStencilStateCreateInfo structure,
        /// or Null if the pipeline has rasterization disabled or if the
        /// subpass of the render pass the pipeline is created against does not
        /// use a depth/stencil attachment.
        /// </param>
        /// <param name="colorBlendState">
        /// An instance of the PipelineColorBlendStateCreateInfo structure, or
        /// Null if the pipeline has rasterization disabled or if the subpass
        /// of the render pass the pipeline is created against does not use any
        /// color attachments.
        /// </param>
        /// <param name="dynamicState">
        /// A pointer to PipelineDynamicStateCreateInfo and is used to indicate
        /// which properties of the pipeline state object are dynamic and can
        /// be changed independently of the pipeline state. This can be Null,
        /// which means no state in the pipeline is considered dynamic.
        /// </param>
        /// <param name="layout">
        /// The description of binding locations used by both the pipeline and
        /// descriptor sets used with the pipeline.
        /// </param>
        /// <param name="renderPass">
        /// A handle to a render pass object describing the environment in
        /// which the pipeline will be used; the pipeline must only be used
        /// with an instance of any render pass compatible with the one
        /// provided.
        /// </param>
        /// <param name="subpass">
        /// The index of the subpass in the render pass where this pipeline
        /// will be used.
        /// </param>
        /// <param name="basePipelineHandle">
        /// A pipeline to derive from.
        /// </param>
        /// <param name="basePipelineIndex">
        /// An index into the pCreateInfos parameter to use as a pipeline to
        /// derive from.
        /// </param>
        /// <param name="graphicsPipelineShaderGroupsCreateInfoNv">
        /// Extension struct
        /// </param>
        /// <param name="pipelineDiscardRectangleStateCreateInfoExt">
        /// Extension struct
        /// </param>
        /// <param name="pipelineRepresentativeFragmentTestStateCreateInfoNv">
        /// Extension struct
        /// </param>
        /// <param name="pipelineCreationFeedbackCreateInfoExt">
        /// Extension struct
        /// </param>
        /// <param name="pipelineCompilerControlCreateInfoAmd">
        /// Extension struct
        /// </param>
        /// <param name="allocator">
        /// An optional AllocationCallbacks instance that controls host memory
        /// allocation.
        /// </param>
        public unsafe Pipeline CreateGraphicsPipeline(PipelineCache pipelineCache, ArrayProxy<PipelineShaderStageCreateInfo>? stages, PipelineRasterizationStateCreateInfo rasterizationState, PipelineLayout layout, RenderPass renderPass, uint subpass, Pipeline basePipelineHandle, int basePipelineIndex, PipelineCreateFlags? flags = default, PipelineVertexInputStateCreateInfo? vertexInputState = default, PipelineInputAssemblyStateCreateInfo? inputAssemblyState = default, PipelineTessellationStateCreateInfo? tessellationState = default, PipelineViewportStateCreateInfo? viewportState = default, PipelineMultisampleStateCreateInfo? multisampleState = default, PipelineDepthStencilStateCreateInfo? depthStencilState = default, PipelineColorBlendStateCreateInfo? colorBlendState = default, PipelineDynamicStateCreateInfo? dynamicState = default, NVidia.GraphicsPipelineShaderGroupsCreateInfo? graphicsPipelineShaderGroupsCreateInfoNv = null, Multivendor.PipelineDiscardRectangleStateCreateInfo? pipelineDiscardRectangleStateCreateInfoExt = null, NVidia.PipelineRepresentativeFragmentTestStateCreateInfo? pipelineRepresentativeFragmentTestStateCreateInfoNv = null, Multivendor.PipelineCreationFeedbackCreateInfo? pipelineCreationFeedbackCreateInfoExt = null, Amd.PipelineCompilerControlCreateInfo? pipelineCompilerControlCreateInfoAmd = null, AllocationCallbacks? allocator = default)
        {
            try
            {
                Pipeline result = default;
                uint marshalledCreateInfoCount = default;
                SharpVk.Interop.GraphicsPipelineCreateInfo* marshalledCreateInfos = default;
                void* vkGraphicsPipelineCreateInfoNextPointer = default;
                SharpVk.Interop.AllocationCallbacks* marshalledAllocator = default;
                SharpVk.Interop.Pipeline* marshalledPipelines = default;
                if (graphicsPipelineShaderGroupsCreateInfoNv != null)
                {
                    SharpVk.Interop.NVidia.GraphicsPipelineShaderGroupsCreateInfo* extensionPointer = default;
                    extensionPointer = (SharpVk.Interop.NVidia.GraphicsPipelineShaderGroupsCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.NVidia.GraphicsPipelineShaderGroupsCreateInfo>());
                    graphicsPipelineShaderGroupsCreateInfoNv.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkGraphicsPipelineCreateInfoNextPointer;
                    vkGraphicsPipelineCreateInfoNextPointer = extensionPointer;
                }
                if (pipelineDiscardRectangleStateCreateInfoExt != null)
                {
                    SharpVk.Interop.Multivendor.PipelineDiscardRectangleStateCreateInfo* extensionPointer = default;
                    extensionPointer = (SharpVk.Interop.Multivendor.PipelineDiscardRectangleStateCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.PipelineDiscardRectangleStateCreateInfo>());
                    pipelineDiscardRectangleStateCreateInfoExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkGraphicsPipelineCreateInfoNextPointer;
                    vkGraphicsPipelineCreateInfoNextPointer = extensionPointer;
                }
                if (pipelineRepresentativeFragmentTestStateCreateInfoNv != null)
                {
                    SharpVk.Interop.NVidia.PipelineRepresentativeFragmentTestStateCreateInfo* extensionPointer = default;
                    extensionPointer = (SharpVk.Interop.NVidia.PipelineRepresentativeFragmentTestStateCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.NVidia.PipelineRepresentativeFragmentTestStateCreateInfo>());
                    pipelineRepresentativeFragmentTestStateCreateInfoNv.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkGraphicsPipelineCreateInfoNextPointer;
                    vkGraphicsPipelineCreateInfoNextPointer = extensionPointer;
                }
                if (pipelineCreationFeedbackCreateInfoExt != null)
                {
                    SharpVk.Interop.Multivendor.PipelineCreationFeedbackCreateInfo* extensionPointer = default;
                    extensionPointer = (SharpVk.Interop.Multivendor.PipelineCreationFeedbackCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.PipelineCreationFeedbackCreateInfo>());
                    pipelineCreationFeedbackCreateInfoExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkGraphicsPipelineCreateInfoNextPointer;
                    vkGraphicsPipelineCreateInfoNextPointer = extensionPointer;
                }
                if (pipelineCompilerControlCreateInfoAmd != null)
                {
                    SharpVk.Interop.Amd.PipelineCompilerControlCreateInfo* extensionPointer = default;
                    extensionPointer = (SharpVk.Interop.Amd.PipelineCompilerControlCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Amd.PipelineCompilerControlCreateInfo>());
                    pipelineCompilerControlCreateInfoAmd.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkGraphicsPipelineCreateInfoNextPointer;
                    vkGraphicsPipelineCreateInfoNextPointer = extensionPointer;
                }
                marshalledCreateInfoCount = 1;
                marshalledCreateInfos = (SharpVk.Interop.GraphicsPipelineCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.GraphicsPipelineCreateInfo>());
                marshalledCreateInfos->SType = StructureType.GraphicsPipelineCreateInfo;
                marshalledCreateInfos->Next = vkGraphicsPipelineCreateInfoNextPointer;
                if (flags != null)
                {
                    marshalledCreateInfos->Flags = flags.Value;
                }
                else
                {
                    marshalledCreateInfos->Flags = default;
                }
                marshalledCreateInfos->StageCount = (uint)(Interop.HeapUtil.GetLength(stages));
                if (stages.IsNull())
                {
                    marshalledCreateInfos->Stages = null;
                }
                else
                {
                    if (stages.Value.Contents == ProxyContents.Single)
                    {
                        marshalledCreateInfos->Stages = (SharpVk.Interop.PipelineShaderStageCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.PipelineShaderStageCreateInfo>());
                        stages.Value.GetSingleValue().MarshalTo(&*(SharpVk.Interop.PipelineShaderStageCreateInfo*)(marshalledCreateInfos->Stages));
                    }
                    else
                    {
                        var fieldPointer = (SharpVk.Interop.PipelineShaderStageCreateInfo*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.PipelineShaderStageCreateInfo>(Interop.HeapUtil.GetLength(stages.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(stages.Value)); index++)
                        {
                            stages.Value[index].MarshalTo(&fieldPointer[index]);
                        }
                        marshalledCreateInfos->Stages = fieldPointer;
                    }
                }
                if (vertexInputState != null)
                {
                    marshalledCreateInfos->VertexInputState = (SharpVk.Interop.PipelineVertexInputStateCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.PipelineVertexInputStateCreateInfo>());
                    vertexInputState.Value.MarshalTo(marshalledCreateInfos->VertexInputState);
                }
                else
                {
                    marshalledCreateInfos->VertexInputState = default;
                }
                if (inputAssemblyState != null)
                {
                    marshalledCreateInfos->InputAssemblyState = (SharpVk.Interop.PipelineInputAssemblyStateCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.PipelineInputAssemblyStateCreateInfo>());
                    inputAssemblyState.Value.MarshalTo(marshalledCreateInfos->InputAssemblyState);
                }
                else
                {
                    marshalledCreateInfos->InputAssemblyState = default;
                }
                if (tessellationState != null)
                {
                    marshalledCreateInfos->TessellationState = (SharpVk.Interop.PipelineTessellationStateCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.PipelineTessellationStateCreateInfo>());
                    tessellationState.Value.MarshalTo(marshalledCreateInfos->TessellationState);
                }
                else
                {
                    marshalledCreateInfos->TessellationState = default;
                }
                if (viewportState != null)
                {
                    marshalledCreateInfos->ViewportState = (SharpVk.Interop.PipelineViewportStateCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.PipelineViewportStateCreateInfo>());
                    viewportState.Value.MarshalTo(marshalledCreateInfos->ViewportState);
                }
                else
                {
                    marshalledCreateInfos->ViewportState = default;
                }
                marshalledCreateInfos->RasterizationState = (SharpVk.Interop.PipelineRasterizationStateCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.PipelineRasterizationStateCreateInfo>());
                rasterizationState.MarshalTo(marshalledCreateInfos->RasterizationState);
                if (multisampleState != null)
                {
                    marshalledCreateInfos->MultisampleState = (SharpVk.Interop.PipelineMultisampleStateCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.PipelineMultisampleStateCreateInfo>());
                    multisampleState.Value.MarshalTo(marshalledCreateInfos->MultisampleState);
                }
                else
                {
                    marshalledCreateInfos->MultisampleState = default;
                }
                if (depthStencilState != null)
                {
                    marshalledCreateInfos->DepthStencilState = (SharpVk.Interop.PipelineDepthStencilStateCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.PipelineDepthStencilStateCreateInfo>());
                    depthStencilState.Value.MarshalTo(marshalledCreateInfos->DepthStencilState);
                }
                else
                {
                    marshalledCreateInfos->DepthStencilState = default;
                }
                if (colorBlendState != null)
                {
                    marshalledCreateInfos->ColorBlendState = (SharpVk.Interop.PipelineColorBlendStateCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.PipelineColorBlendStateCreateInfo>());
                    colorBlendState.Value.MarshalTo(marshalledCreateInfos->ColorBlendState);
                }
                else
                {
                    marshalledCreateInfos->ColorBlendState = default;
                }
                if (dynamicState != null)
                {
                    marshalledCreateInfos->DynamicState = (SharpVk.Interop.PipelineDynamicStateCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.PipelineDynamicStateCreateInfo>());
                    dynamicState.Value.MarshalTo(marshalledCreateInfos->DynamicState);
                }
                else
                {
                    marshalledCreateInfos->DynamicState = default;
                }
                marshalledCreateInfos->Layout = layout?.Handle ?? default;
                marshalledCreateInfos->RenderPass = renderPass?.Handle ?? default;
                marshalledCreateInfos->Subpass = subpass;
                marshalledCreateInfos->BasePipelineHandle = basePipelineHandle?.Handle ?? default;
                marshalledCreateInfos->BasePipelineIndex = basePipelineIndex;
                if (allocator != null)
                {
                    marshalledAllocator = (SharpVk.Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<SharpVk.Interop.AllocationCallbacks>());
                    allocator.Value.MarshalTo(marshalledAllocator);
                }
                else
                {
                    marshalledAllocator = default;
                }
                marshalledPipelines = (SharpVk.Interop.Pipeline*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Pipeline>(1));
                Interop.VkDeviceCreateGraphicsPipelinesDelegate commandDelegate = commandCache.Cache.vkCreateGraphicsPipelines;
                Result methodResult = commandDelegate(Handle, pipelineCache?.Handle ?? default, marshalledCreateInfoCount, marshalledCreateInfos, marshalledAllocator, marshalledPipelines);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = new Pipeline(this, *marshalledPipelines);
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Creates a new compute pipeline object.
        /// </summary>
        /// <param name="pipelineCache">
        /// </param>
        /// <param name="createInfos">
        /// </param>
        /// <param name="allocator">
        /// An optional AllocationCallbacks instance that controls host memory
        /// allocation.
        /// </param>
        public unsafe Pipeline[] CreateComputePipelines(PipelineCache pipelineCache, ArrayProxy<ComputePipelineCreateInfo>? createInfos, AllocationCallbacks? allocator = default)
        {
            try
            {
                Pipeline[] result = default;
                uint marshalledCreateInfoCount = default;
                SharpVk.Interop.ComputePipelineCreateInfo* marshalledCreateInfos = default;
                SharpVk.Interop.AllocationCallbacks* marshalledAllocator = default;
                SharpVk.Interop.Pipeline* marshalledPipelines = default;
                marshalledCreateInfoCount = (uint)(Interop.HeapUtil.GetLength(createInfos));
                if (createInfos.IsNull())
                {
                    marshalledCreateInfos = null;
                }
                else
                {
                    if (createInfos.Value.Contents == ProxyContents.Single)
                    {
                        marshalledCreateInfos = (SharpVk.Interop.ComputePipelineCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.ComputePipelineCreateInfo>());
                        createInfos.Value.GetSingleValue().MarshalTo(&*(SharpVk.Interop.ComputePipelineCreateInfo*)(marshalledCreateInfos));
                    }
                    else
                    {
                        var fieldPointer = (SharpVk.Interop.ComputePipelineCreateInfo*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.ComputePipelineCreateInfo>(Interop.HeapUtil.GetLength(createInfos.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(createInfos.Value)); index++)
                        {
                            createInfos.Value[index].MarshalTo(&fieldPointer[index]);
                        }
                        marshalledCreateInfos = fieldPointer;
                    }
                }
                if (allocator != null)
                {
                    marshalledAllocator = (SharpVk.Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<SharpVk.Interop.AllocationCallbacks>());
                    allocator.Value.MarshalTo(marshalledAllocator);
                }
                else
                {
                    marshalledAllocator = default;
                }
                marshalledPipelines = (SharpVk.Interop.Pipeline*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Pipeline>(marshalledCreateInfoCount));
                Interop.VkDeviceCreateComputePipelinesDelegate commandDelegate = commandCache.Cache.vkCreateComputePipelines;
                Result methodResult = commandDelegate(Handle, pipelineCache?.Handle ?? default, marshalledCreateInfoCount, marshalledCreateInfos, marshalledAllocator, marshalledPipelines);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                if (marshalledPipelines != null)
                {
                    var fieldPointer = new Pipeline[(uint)(marshalledCreateInfoCount)];
                    for(int index = 0; index < (uint)(marshalledCreateInfoCount); index++)
                    {
                        fieldPointer[index] = new Pipeline(this, marshalledPipelines[index]);
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
        /// Creates a new compute pipeline object.
        /// </summary>
        /// <param name="pipelineCache">
        /// </param>
        /// <param name="flags">
        /// flags provides options for pipeline creation, and is of type
        /// PipelineCreateFlagBits.
        /// </param>
        /// <param name="stage">
        /// A PipelineShaderStageCreateInfo describing the compute shader.
        /// </param>
        /// <param name="layout">
        /// The description of binding locations used by both the pipeline and
        /// descriptor sets used with the pipeline.
        /// </param>
        /// <param name="basePipelineHandle">
        /// A pipeline to derive from
        /// </param>
        /// <param name="basePipelineIndex">
        /// An index into the pCreateInfos parameter to use as a pipeline to
        /// derive from
        /// </param>
        /// <param name="pipelineCreationFeedbackCreateInfoExt">
        /// Extension struct
        /// </param>
        /// <param name="pipelineCompilerControlCreateInfoAmd">
        /// Extension struct
        /// </param>
        /// <param name="allocator">
        /// An optional AllocationCallbacks instance that controls host memory
        /// allocation.
        /// </param>
        public unsafe Pipeline CreateComputePipeline(PipelineCache pipelineCache, PipelineShaderStageCreateInfo stage, PipelineLayout layout, Pipeline basePipelineHandle, int basePipelineIndex, PipelineCreateFlags? flags = default, Multivendor.PipelineCreationFeedbackCreateInfo? pipelineCreationFeedbackCreateInfoExt = null, Amd.PipelineCompilerControlCreateInfo? pipelineCompilerControlCreateInfoAmd = null, AllocationCallbacks? allocator = default)
        {
            try
            {
                Pipeline result = default;
                uint marshalledCreateInfoCount = default;
                SharpVk.Interop.ComputePipelineCreateInfo* marshalledCreateInfos = default;
                void* vkComputePipelineCreateInfoNextPointer = default;
                SharpVk.Interop.AllocationCallbacks* marshalledAllocator = default;
                SharpVk.Interop.Pipeline* marshalledPipelines = default;
                if (pipelineCreationFeedbackCreateInfoExt != null)
                {
                    SharpVk.Interop.Multivendor.PipelineCreationFeedbackCreateInfo* extensionPointer = default;
                    extensionPointer = (SharpVk.Interop.Multivendor.PipelineCreationFeedbackCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.PipelineCreationFeedbackCreateInfo>());
                    pipelineCreationFeedbackCreateInfoExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkComputePipelineCreateInfoNextPointer;
                    vkComputePipelineCreateInfoNextPointer = extensionPointer;
                }
                if (pipelineCompilerControlCreateInfoAmd != null)
                {
                    SharpVk.Interop.Amd.PipelineCompilerControlCreateInfo* extensionPointer = default;
                    extensionPointer = (SharpVk.Interop.Amd.PipelineCompilerControlCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Amd.PipelineCompilerControlCreateInfo>());
                    pipelineCompilerControlCreateInfoAmd.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkComputePipelineCreateInfoNextPointer;
                    vkComputePipelineCreateInfoNextPointer = extensionPointer;
                }
                marshalledCreateInfoCount = 1;
                marshalledCreateInfos = (SharpVk.Interop.ComputePipelineCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.ComputePipelineCreateInfo>());
                marshalledCreateInfos->SType = StructureType.ComputePipelineCreateInfo;
                marshalledCreateInfos->Next = vkComputePipelineCreateInfoNextPointer;
                if (flags != null)
                {
                    marshalledCreateInfos->Flags = flags.Value;
                }
                else
                {
                    marshalledCreateInfos->Flags = default;
                }
                stage.MarshalTo(&marshalledCreateInfos->Stage);
                marshalledCreateInfos->Layout = layout?.Handle ?? default;
                marshalledCreateInfos->BasePipelineHandle = basePipelineHandle?.Handle ?? default;
                marshalledCreateInfos->BasePipelineIndex = basePipelineIndex;
                if (allocator != null)
                {
                    marshalledAllocator = (SharpVk.Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<SharpVk.Interop.AllocationCallbacks>());
                    allocator.Value.MarshalTo(marshalledAllocator);
                }
                else
                {
                    marshalledAllocator = default;
                }
                marshalledPipelines = (SharpVk.Interop.Pipeline*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Pipeline>(1));
                Interop.VkDeviceCreateComputePipelinesDelegate commandDelegate = commandCache.Cache.vkCreateComputePipelines;
                Result methodResult = commandDelegate(Handle, pipelineCache?.Handle ?? default, marshalledCreateInfoCount, marshalledCreateInfos, marshalledAllocator, marshalledPipelines);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = new Pipeline(this, *marshalledPipelines);
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Creates a new pipeline layout object.
        /// </summary>
        /// <param name="flags">
        /// Reserved for future use.
        /// </param>
        /// <param name="setLayouts">
        /// </param>
        /// <param name="pushConstantRanges">
        /// </param>
        /// <param name="allocator">
        /// An optional AllocationCallbacks instance that controls host memory
        /// allocation.
        /// </param>
        public unsafe PipelineLayout CreatePipelineLayout(ArrayProxy<DescriptorSetLayout>? setLayouts, ArrayProxy<PushConstantRange>? pushConstantRanges, PipelineLayoutCreateFlags? flags = default, AllocationCallbacks? allocator = default)
        {
            try
            {
                PipelineLayout result = default;
                SharpVk.Interop.PipelineLayoutCreateInfo* marshalledCreateInfo = default;
                void* vkPipelineLayoutCreateInfoNextPointer = default;
                SharpVk.Interop.AllocationCallbacks* marshalledAllocator = default;
                SharpVk.Interop.PipelineLayout marshalledPipelineLayout = default;
                marshalledCreateInfo = (SharpVk.Interop.PipelineLayoutCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.PipelineLayoutCreateInfo>());
                marshalledCreateInfo->SType = StructureType.PipelineLayoutCreateInfo;
                marshalledCreateInfo->Next = vkPipelineLayoutCreateInfoNextPointer;
                if (flags != null)
                {
                    marshalledCreateInfo->Flags = flags.Value;
                }
                else
                {
                    marshalledCreateInfo->Flags = default;
                }
                marshalledCreateInfo->SetLayoutCount = (uint)(Interop.HeapUtil.GetLength(setLayouts));
                if (setLayouts.IsNull())
                {
                    marshalledCreateInfo->SetLayouts = null;
                }
                else
                {
                    if (setLayouts.Value.Contents == ProxyContents.Single)
                    {
                        marshalledCreateInfo->SetLayouts = (SharpVk.Interop.DescriptorSetLayout*)(Interop.HeapUtil.Allocate<SharpVk.Interop.DescriptorSetLayout>());
                        *(SharpVk.Interop.DescriptorSetLayout*)(marshalledCreateInfo->SetLayouts) = setLayouts.Value.GetSingleValue()?.Handle ?? default;
                    }
                    else
                    {
                        var fieldPointer = (SharpVk.Interop.DescriptorSetLayout*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.DescriptorSetLayout>(Interop.HeapUtil.GetLength(setLayouts.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(setLayouts.Value)); index++)
                        {
                            fieldPointer[index] = setLayouts.Value[index]?.Handle ?? default;
                        }
                        marshalledCreateInfo->SetLayouts = fieldPointer;
                    }
                }
                marshalledCreateInfo->PushConstantRangeCount = (uint)(Interop.HeapUtil.GetLength(pushConstantRanges));
                if (pushConstantRanges.IsNull())
                {
                    marshalledCreateInfo->PushConstantRanges = null;
                }
                else
                {
                    if (pushConstantRanges.Value.Contents == ProxyContents.Single)
                    {
                        marshalledCreateInfo->PushConstantRanges = (PushConstantRange*)(Interop.HeapUtil.Allocate<PushConstantRange>());
                        *(PushConstantRange*)(marshalledCreateInfo->PushConstantRanges) = pushConstantRanges.Value.GetSingleValue();
                    }
                    else
                    {
                        var fieldPointer = (PushConstantRange*)(Interop.HeapUtil.AllocateAndClear<PushConstantRange>(Interop.HeapUtil.GetLength(pushConstantRanges.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(pushConstantRanges.Value)); index++)
                        {
                            fieldPointer[index] = pushConstantRanges.Value[index];
                        }
                        marshalledCreateInfo->PushConstantRanges = fieldPointer;
                    }
                }
                if (allocator != null)
                {
                    marshalledAllocator = (SharpVk.Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<SharpVk.Interop.AllocationCallbacks>());
                    allocator.Value.MarshalTo(marshalledAllocator);
                }
                else
                {
                    marshalledAllocator = default;
                }
                Interop.VkDeviceCreatePipelineLayoutDelegate commandDelegate = commandCache.Cache.vkCreatePipelineLayout;
                Result methodResult = commandDelegate(Handle, marshalledCreateInfo, marshalledAllocator, &marshalledPipelineLayout);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = new PipelineLayout(this, marshalledPipelineLayout);
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Create a new sampler object.
        /// </summary>
        /// <param name="flags">
        /// Reserved for future use.
        /// </param>
        /// <param name="magFilter">
        /// The magnification filter to apply to lookups.
        /// </param>
        /// <param name="minFilter">
        /// </param>
        /// <param name="mipmapMode">
        /// </param>
        /// <param name="addressModeU">
        /// </param>
        /// <param name="addressModeV">
        /// </param>
        /// <param name="addressModeW">
        /// </param>
        /// <param name="mipLodBias">
        /// </param>
        /// <param name="anisotropyEnable">
        /// </param>
        /// <param name="maxAnisotropy">
        /// </param>
        /// <param name="compareEnable">
        /// </param>
        /// <param name="compareOp">
        /// </param>
        /// <param name="minLod">
        /// </param>
        /// <param name="maxLod">
        /// </param>
        /// <param name="borderColor">
        /// </param>
        /// <param name="unnormalizedCoordinates">
        /// </param>
        /// <param name="samplerYcbcrConversionInfo">
        /// Extension struct
        /// </param>
        /// <param name="samplerReductionModeCreateInfo">
        /// Extension struct
        /// </param>
        /// <param name="samplerCustomBorderColorCreateInfoExt">
        /// Extension struct
        /// </param>
        /// <param name="allocator">
        /// An optional AllocationCallbacks instance that controls host memory
        /// allocation.
        /// </param>
        public unsafe Sampler CreateSampler(Filter magFilter, Filter minFilter, SamplerMipmapMode mipmapMode, SamplerAddressMode addressModeU, SamplerAddressMode addressModeV, SamplerAddressMode addressModeW, float mipLodBias, bool anisotropyEnable, float maxAnisotropy, bool compareEnable, CompareOp compareOp, float minLod, float maxLod, BorderColor borderColor, bool unnormalizedCoordinates, SamplerCreateFlags? flags = default, SamplerYcbcrConversionInfo? samplerYcbcrConversionInfo = null, SamplerReductionModeCreateInfo? samplerReductionModeCreateInfo = null, Multivendor.SamplerCustomBorderColorCreateInfo? samplerCustomBorderColorCreateInfoExt = null, AllocationCallbacks? allocator = default)
        {
            try
            {
                Sampler result = default;
                SharpVk.Interop.SamplerCreateInfo* marshalledCreateInfo = default;
                void* vkSamplerCreateInfoNextPointer = default;
                SharpVk.Interop.AllocationCallbacks* marshalledAllocator = default;
                SharpVk.Interop.Sampler marshalledSampler = default;
                if (samplerYcbcrConversionInfo != null)
                {
                    SharpVk.Interop.SamplerYcbcrConversionInfo* extensionPointer = default;
                    extensionPointer = (SharpVk.Interop.SamplerYcbcrConversionInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.SamplerYcbcrConversionInfo>());
                    samplerYcbcrConversionInfo.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkSamplerCreateInfoNextPointer;
                    vkSamplerCreateInfoNextPointer = extensionPointer;
                }
                if (samplerReductionModeCreateInfo != null)
                {
                    SharpVk.Interop.SamplerReductionModeCreateInfo* extensionPointer = default;
                    extensionPointer = (SharpVk.Interop.SamplerReductionModeCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.SamplerReductionModeCreateInfo>());
                    samplerReductionModeCreateInfo.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkSamplerCreateInfoNextPointer;
                    vkSamplerCreateInfoNextPointer = extensionPointer;
                }
                if (samplerCustomBorderColorCreateInfoExt != null)
                {
                    SharpVk.Interop.Multivendor.SamplerCustomBorderColorCreateInfo* extensionPointer = default;
                    extensionPointer = (SharpVk.Interop.Multivendor.SamplerCustomBorderColorCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.SamplerCustomBorderColorCreateInfo>());
                    samplerCustomBorderColorCreateInfoExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkSamplerCreateInfoNextPointer;
                    vkSamplerCreateInfoNextPointer = extensionPointer;
                }
                marshalledCreateInfo = (SharpVk.Interop.SamplerCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.SamplerCreateInfo>());
                marshalledCreateInfo->SType = StructureType.SamplerCreateInfo;
                marshalledCreateInfo->Next = vkSamplerCreateInfoNextPointer;
                if (flags != null)
                {
                    marshalledCreateInfo->Flags = flags.Value;
                }
                else
                {
                    marshalledCreateInfo->Flags = default;
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
                    marshalledAllocator = default;
                }
                Interop.VkDeviceCreateSamplerDelegate commandDelegate = commandCache.Cache.vkCreateSampler;
                Result methodResult = commandDelegate(Handle, marshalledCreateInfo, marshalledAllocator, &marshalledSampler);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = new Sampler(this, marshalledSampler);
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Create a new descriptor set layout.
        /// </summary>
        /// <param name="flags">
        /// flags provides options for descriptor set layout creation, and is
        /// of type DescriptorSetLayoutCreateFlags. Bits which can be set
        /// include: + --
        /// </param>
        /// <param name="bindings">
        /// </param>
        /// <param name="descriptorSetLayoutBindingFlagsCreateInfo">
        /// Extension struct
        /// </param>
        /// <param name="allocator">
        /// An optional AllocationCallbacks instance that controls host memory
        /// allocation.
        /// </param>
        public unsafe DescriptorSetLayout CreateDescriptorSetLayout(ArrayProxy<DescriptorSetLayoutBinding>? bindings, DescriptorSetLayoutCreateFlags? flags = default, DescriptorSetLayoutBindingFlagsCreateInfo? descriptorSetLayoutBindingFlagsCreateInfo = null, AllocationCallbacks? allocator = default)
        {
            try
            {
                DescriptorSetLayout result = default;
                SharpVk.Interop.DescriptorSetLayoutCreateInfo* marshalledCreateInfo = default;
                void* vkDescriptorSetLayoutCreateInfoNextPointer = default;
                SharpVk.Interop.AllocationCallbacks* marshalledAllocator = default;
                SharpVk.Interop.DescriptorSetLayout marshalledSetLayout = default;
                if (descriptorSetLayoutBindingFlagsCreateInfo != null)
                {
                    SharpVk.Interop.DescriptorSetLayoutBindingFlagsCreateInfo* extensionPointer = default;
                    extensionPointer = (SharpVk.Interop.DescriptorSetLayoutBindingFlagsCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.DescriptorSetLayoutBindingFlagsCreateInfo>());
                    descriptorSetLayoutBindingFlagsCreateInfo.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDescriptorSetLayoutCreateInfoNextPointer;
                    vkDescriptorSetLayoutCreateInfoNextPointer = extensionPointer;
                }
                marshalledCreateInfo = (SharpVk.Interop.DescriptorSetLayoutCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.DescriptorSetLayoutCreateInfo>());
                marshalledCreateInfo->SType = StructureType.DescriptorSetLayoutCreateInfo;
                marshalledCreateInfo->Next = vkDescriptorSetLayoutCreateInfoNextPointer;
                if (flags != null)
                {
                    marshalledCreateInfo->Flags = flags.Value;
                }
                else
                {
                    marshalledCreateInfo->Flags = default;
                }
                marshalledCreateInfo->BindingCount = (uint)(Interop.HeapUtil.GetLength(bindings));
                if (bindings.IsNull())
                {
                    marshalledCreateInfo->Bindings = null;
                }
                else
                {
                    if (bindings.Value.Contents == ProxyContents.Single)
                    {
                        marshalledCreateInfo->Bindings = (SharpVk.Interop.DescriptorSetLayoutBinding*)(Interop.HeapUtil.Allocate<SharpVk.Interop.DescriptorSetLayoutBinding>());
                        bindings.Value.GetSingleValue().MarshalTo(&*(SharpVk.Interop.DescriptorSetLayoutBinding*)(marshalledCreateInfo->Bindings));
                    }
                    else
                    {
                        var fieldPointer = (SharpVk.Interop.DescriptorSetLayoutBinding*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.DescriptorSetLayoutBinding>(Interop.HeapUtil.GetLength(bindings.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(bindings.Value)); index++)
                        {
                            bindings.Value[index].MarshalTo(&fieldPointer[index]);
                        }
                        marshalledCreateInfo->Bindings = fieldPointer;
                    }
                }
                if (allocator != null)
                {
                    marshalledAllocator = (SharpVk.Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<SharpVk.Interop.AllocationCallbacks>());
                    allocator.Value.MarshalTo(marshalledAllocator);
                }
                else
                {
                    marshalledAllocator = default;
                }
                Interop.VkDeviceCreateDescriptorSetLayoutDelegate commandDelegate = commandCache.Cache.vkCreateDescriptorSetLayout;
                Result methodResult = commandDelegate(Handle, marshalledCreateInfo, marshalledAllocator, &marshalledSetLayout);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = new DescriptorSetLayout(this, marshalledSetLayout);
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Creates a descriptor pool object.
        /// </summary>
        /// <param name="flags">
        /// Specifies certain supported operations on the pool. Bits which can
        /// be set include: + --
        /// </param>
        /// <param name="maxSets">
        /// </param>
        /// <param name="poolSizes">
        /// </param>
        /// <param name="descriptorPoolInlineUniformBlockCreateInfoExt">
        /// Extension struct
        /// </param>
        /// <param name="allocator">
        /// An optional AllocationCallbacks instance that controls host memory
        /// allocation.
        /// </param>
        public unsafe DescriptorPool CreateDescriptorPool(uint maxSets, ArrayProxy<DescriptorPoolSize>? poolSizes, DescriptorPoolCreateFlags? flags = default, Multivendor.DescriptorPoolInlineUniformBlockCreateInfo? descriptorPoolInlineUniformBlockCreateInfoExt = null, AllocationCallbacks? allocator = default)
        {
            try
            {
                DescriptorPool result = default;
                SharpVk.Interop.DescriptorPoolCreateInfo* marshalledCreateInfo = default;
                void* vkDescriptorPoolCreateInfoNextPointer = default;
                SharpVk.Interop.AllocationCallbacks* marshalledAllocator = default;
                SharpVk.Interop.DescriptorPool marshalledDescriptorPool = default;
                if (descriptorPoolInlineUniformBlockCreateInfoExt != null)
                {
                    SharpVk.Interop.Multivendor.DescriptorPoolInlineUniformBlockCreateInfo* extensionPointer = default;
                    extensionPointer = (SharpVk.Interop.Multivendor.DescriptorPoolInlineUniformBlockCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.DescriptorPoolInlineUniformBlockCreateInfo>());
                    descriptorPoolInlineUniformBlockCreateInfoExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDescriptorPoolCreateInfoNextPointer;
                    vkDescriptorPoolCreateInfoNextPointer = extensionPointer;
                }
                marshalledCreateInfo = (SharpVk.Interop.DescriptorPoolCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.DescriptorPoolCreateInfo>());
                marshalledCreateInfo->SType = StructureType.DescriptorPoolCreateInfo;
                marshalledCreateInfo->Next = vkDescriptorPoolCreateInfoNextPointer;
                if (flags != null)
                {
                    marshalledCreateInfo->Flags = flags.Value;
                }
                else
                {
                    marshalledCreateInfo->Flags = default;
                }
                marshalledCreateInfo->MaxSets = maxSets;
                marshalledCreateInfo->PoolSizeCount = (uint)(Interop.HeapUtil.GetLength(poolSizes));
                if (poolSizes.IsNull())
                {
                    marshalledCreateInfo->PoolSizes = null;
                }
                else
                {
                    if (poolSizes.Value.Contents == ProxyContents.Single)
                    {
                        marshalledCreateInfo->PoolSizes = (DescriptorPoolSize*)(Interop.HeapUtil.Allocate<DescriptorPoolSize>());
                        *(DescriptorPoolSize*)(marshalledCreateInfo->PoolSizes) = poolSizes.Value.GetSingleValue();
                    }
                    else
                    {
                        var fieldPointer = (DescriptorPoolSize*)(Interop.HeapUtil.AllocateAndClear<DescriptorPoolSize>(Interop.HeapUtil.GetLength(poolSizes.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(poolSizes.Value)); index++)
                        {
                            fieldPointer[index] = poolSizes.Value[index];
                        }
                        marshalledCreateInfo->PoolSizes = fieldPointer;
                    }
                }
                if (allocator != null)
                {
                    marshalledAllocator = (SharpVk.Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<SharpVk.Interop.AllocationCallbacks>());
                    allocator.Value.MarshalTo(marshalledAllocator);
                }
                else
                {
                    marshalledAllocator = default;
                }
                Interop.VkDeviceCreateDescriptorPoolDelegate commandDelegate = commandCache.Cache.vkCreateDescriptorPool;
                Result methodResult = commandDelegate(Handle, marshalledCreateInfo, marshalledAllocator, &marshalledDescriptorPool);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = new DescriptorPool(this, marshalledDescriptorPool);
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Allocate one or more descriptor sets.
        /// </summary>
        /// <param name="descriptorPool">
        ///     The pool which the sets will be allocated from.
        /// </param>
        /// <param name="setLayouts">
        /// </param>
        /// <param name="descriptorSetVariableDescriptorCountAllocateInfo">
        ///     Extension struct
        /// </param>
        public unsafe DescriptorSet[] AllocateDescriptorSets(DescriptorPool descriptorPool, ArrayProxy<DescriptorSetLayout>? setLayouts, DescriptorSetVariableDescriptorCountAllocateInfo? descriptorSetVariableDescriptorCountAllocateInfo = null)
        {
            try
            {
                var result = default(DescriptorSet[]);
                var marshalledAllocateInfo = default(Interop.DescriptorSetAllocateInfo*);
                var vkDescriptorSetAllocateInfoNextPointer = default(void*);
                var marshalledDescriptorSets = default(Interop.DescriptorSet*);
                if (descriptorSetVariableDescriptorCountAllocateInfo != null)
                {
                    var extensionPointer = default(Interop.DescriptorSetVariableDescriptorCountAllocateInfo*);
                    extensionPointer = (Interop.DescriptorSetVariableDescriptorCountAllocateInfo*)Interop.HeapUtil.Allocate<Interop.DescriptorSetVariableDescriptorCountAllocateInfo>();
                    descriptorSetVariableDescriptorCountAllocateInfo.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDescriptorSetAllocateInfoNextPointer;
                    vkDescriptorSetAllocateInfoNextPointer = extensionPointer;
                }
                marshalledAllocateInfo = (Interop.DescriptorSetAllocateInfo*)Interop.HeapUtil.Allocate<Interop.DescriptorSetAllocateInfo>();
                marshalledAllocateInfo->SType = StructureType.DescriptorSetAllocateInfo;
                marshalledAllocateInfo->Next = vkDescriptorSetAllocateInfoNextPointer;
                marshalledAllocateInfo->DescriptorPool = descriptorPool?.Handle ?? default(Interop.DescriptorPool);
                marshalledAllocateInfo->DescriptorSetCount = Interop.HeapUtil.GetLength(setLayouts);
                if (setLayouts.IsNull())
                {
                    marshalledAllocateInfo->SetLayouts = null;
                }
                else
                {
                    if (setLayouts.Value.Contents == ProxyContents.Single)
                    {
                        marshalledAllocateInfo->SetLayouts = (Interop.DescriptorSetLayout*)Interop.HeapUtil.Allocate<Interop.DescriptorSetLayout>();
                        *marshalledAllocateInfo->SetLayouts = setLayouts.Value.GetSingleValue()?.Handle ?? default(Interop.DescriptorSetLayout);
                    }
                    else
                    {
                        var fieldPointer = (Interop.DescriptorSetLayout*)Interop.HeapUtil.AllocateAndClear<Interop.DescriptorSetLayout>(Interop.HeapUtil.GetLength(setLayouts.Value)).ToPointer();
                        for (var index = 0; index < Interop.HeapUtil.GetLength(setLayouts.Value); index++) fieldPointer[index] = setLayouts.Value[index]?.Handle ?? default(Interop.DescriptorSetLayout);
                        marshalledAllocateInfo->SetLayouts = fieldPointer;
                    }
                }
                marshalledDescriptorSets = (Interop.DescriptorSet*)Interop.HeapUtil.Allocate<Interop.DescriptorSet>(Interop.HeapUtil.GetLength(setLayouts));
                var commandDelegate = commandCache.Cache.vkAllocateDescriptorSets;
                var methodResult = commandDelegate(Handle, marshalledAllocateInfo, marshalledDescriptorSets);
                if (SharpVkException.IsError(methodResult)) throw SharpVkException.Create(methodResult);
                if (marshalledDescriptorSets != null)
                {
                    var fieldPointer = new DescriptorSet[Interop.HeapUtil.GetLength(setLayouts)];
                    for (var index = 0; index < Interop.HeapUtil.GetLength(setLayouts); index++) fieldPointer[index] = new(descriptorPool, marshalledDescriptorSets[index]);
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
        /// Update the contents of a descriptor set object.
        /// </summary>
        /// <param name="descriptorWrites">
        /// </param>
        /// <param name="descriptorCopies">
        /// </param>
        public unsafe void UpdateDescriptorSets(ArrayProxy<WriteDescriptorSet>? descriptorWrites, ArrayProxy<CopyDescriptorSet>? descriptorCopies)
        {
            try
            {
                SharpVk.Interop.WriteDescriptorSet* marshalledDescriptorWrites = default;
                SharpVk.Interop.CopyDescriptorSet* marshalledDescriptorCopies = default;
                if (descriptorWrites.IsNull())
                {
                    marshalledDescriptorWrites = null;
                }
                else
                {
                    if (descriptorWrites.Value.Contents == ProxyContents.Single)
                    {
                        marshalledDescriptorWrites = (SharpVk.Interop.WriteDescriptorSet*)(Interop.HeapUtil.Allocate<SharpVk.Interop.WriteDescriptorSet>());
                        descriptorWrites.Value.GetSingleValue().MarshalTo(&*(SharpVk.Interop.WriteDescriptorSet*)(marshalledDescriptorWrites));
                    }
                    else
                    {
                        var fieldPointer = (SharpVk.Interop.WriteDescriptorSet*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.WriteDescriptorSet>(Interop.HeapUtil.GetLength(descriptorWrites.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(descriptorWrites.Value)); index++)
                        {
                            descriptorWrites.Value[index].MarshalTo(&fieldPointer[index]);
                        }
                        marshalledDescriptorWrites = fieldPointer;
                    }
                }
                if (descriptorCopies.IsNull())
                {
                    marshalledDescriptorCopies = null;
                }
                else
                {
                    if (descriptorCopies.Value.Contents == ProxyContents.Single)
                    {
                        marshalledDescriptorCopies = (SharpVk.Interop.CopyDescriptorSet*)(Interop.HeapUtil.Allocate<SharpVk.Interop.CopyDescriptorSet>());
                        descriptorCopies.Value.GetSingleValue().MarshalTo(&*(SharpVk.Interop.CopyDescriptorSet*)(marshalledDescriptorCopies));
                    }
                    else
                    {
                        var fieldPointer = (SharpVk.Interop.CopyDescriptorSet*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.CopyDescriptorSet>(Interop.HeapUtil.GetLength(descriptorCopies.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(descriptorCopies.Value)); index++)
                        {
                            descriptorCopies.Value[index].MarshalTo(&fieldPointer[index]);
                        }
                        marshalledDescriptorCopies = fieldPointer;
                    }
                }
                Interop.VkDeviceUpdateDescriptorSetsDelegate commandDelegate = commandCache.Cache.vkUpdateDescriptorSets;
                commandDelegate(Handle, (uint)(Interop.HeapUtil.GetLength(descriptorWrites)), marshalledDescriptorWrites, (uint)(Interop.HeapUtil.GetLength(descriptorCopies)), marshalledDescriptorCopies);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Create a new framebuffer object.
        /// </summary>
        /// <param name="flags">
        /// Reserved for future use.
        /// </param>
        /// <param name="renderPass">
        /// A render pass that defines what render passes the framebuffer will
        /// be compatible with.
        /// </param>
        /// <param name="attachments">
        /// </param>
        /// <param name="width">
        /// width, height and layers define the dimensions of the framebuffer.
        /// If the render pass uses multiview, then layers must be one and each
        /// attachment requires a number of layers that is greater than the
        /// maximum bit index set in the view mask in the subpasses in which it
        /// is used.
        /// </param>
        /// <param name="height">
        /// </param>
        /// <param name="layers">
        /// </param>
        /// <param name="framebufferAttachmentsCreateInfo">
        /// Extension struct
        /// </param>
        /// <param name="allocator">
        /// An optional AllocationCallbacks instance that controls host memory
        /// allocation.
        /// </param>
        public unsafe Framebuffer CreateFramebuffer(RenderPass renderPass, ArrayProxy<ImageView>? attachments, uint width, uint height, uint layers, FramebufferCreateFlags? flags = default, FramebufferAttachmentsCreateInfo? framebufferAttachmentsCreateInfo = null, AllocationCallbacks? allocator = default)
        {
            try
            {
                Framebuffer result = default;
                SharpVk.Interop.FramebufferCreateInfo* marshalledCreateInfo = default;
                void* vkFramebufferCreateInfoNextPointer = default;
                SharpVk.Interop.AllocationCallbacks* marshalledAllocator = default;
                SharpVk.Interop.Framebuffer marshalledFramebuffer = default;
                if (framebufferAttachmentsCreateInfo != null)
                {
                    SharpVk.Interop.FramebufferAttachmentsCreateInfo* extensionPointer = default;
                    extensionPointer = (SharpVk.Interop.FramebufferAttachmentsCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.FramebufferAttachmentsCreateInfo>());
                    framebufferAttachmentsCreateInfo.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkFramebufferCreateInfoNextPointer;
                    vkFramebufferCreateInfoNextPointer = extensionPointer;
                }
                marshalledCreateInfo = (SharpVk.Interop.FramebufferCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.FramebufferCreateInfo>());
                marshalledCreateInfo->SType = StructureType.FramebufferCreateInfo;
                marshalledCreateInfo->Next = vkFramebufferCreateInfoNextPointer;
                if (flags != null)
                {
                    marshalledCreateInfo->Flags = flags.Value;
                }
                else
                {
                    marshalledCreateInfo->Flags = default;
                }
                marshalledCreateInfo->RenderPass = renderPass?.Handle ?? default;
                marshalledCreateInfo->AttachmentCount = (uint)(Interop.HeapUtil.GetLength(attachments));
                if (attachments.IsNull())
                {
                    marshalledCreateInfo->Attachments = null;
                }
                else
                {
                    if (attachments.Value.Contents == ProxyContents.Single)
                    {
                        marshalledCreateInfo->Attachments = (SharpVk.Interop.ImageView*)(Interop.HeapUtil.Allocate<SharpVk.Interop.ImageView>());
                        *(SharpVk.Interop.ImageView*)(marshalledCreateInfo->Attachments) = attachments.Value.GetSingleValue()?.Handle ?? default;
                    }
                    else
                    {
                        var fieldPointer = (SharpVk.Interop.ImageView*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.ImageView>(Interop.HeapUtil.GetLength(attachments.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(attachments.Value)); index++)
                        {
                            fieldPointer[index] = attachments.Value[index]?.Handle ?? default;
                        }
                        marshalledCreateInfo->Attachments = fieldPointer;
                    }
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
                    marshalledAllocator = default;
                }
                Interop.VkDeviceCreateFramebufferDelegate commandDelegate = commandCache.Cache.vkCreateFramebuffer;
                Result methodResult = commandDelegate(Handle, marshalledCreateInfo, marshalledAllocator, &marshalledFramebuffer);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = new Framebuffer(this, marshalledFramebuffer);
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Create a new render pass object.
        /// </summary>
        /// <param name="flags">
        /// Reserved for future use.
        /// </param>
        /// <param name="attachments">
        /// </param>
        /// <param name="subpasses">
        /// </param>
        /// <param name="dependencies">
        /// </param>
        /// <param name="renderPassMultiviewCreateInfo">
        /// Extension struct
        /// </param>
        /// <param name="renderPassInputAttachmentAspectCreateInfo">
        /// Extension struct
        /// </param>
        /// <param name="renderPassFragmentDensityMapCreateInfoExt">
        /// Extension struct
        /// </param>
        /// <param name="allocator">
        /// An optional AllocationCallbacks instance that controls host memory
        /// allocation.
        /// </param>
        public unsafe RenderPass CreateRenderPass(ArrayProxy<AttachmentDescription>? attachments, ArrayProxy<SubpassDescription>? subpasses, ArrayProxy<SubpassDependency>? dependencies, RenderPassCreateFlags? flags = default, RenderPassMultiviewCreateInfo? renderPassMultiviewCreateInfo = null, RenderPassInputAttachmentAspectCreateInfo? renderPassInputAttachmentAspectCreateInfo = null, Multivendor.RenderPassFragmentDensityMapCreateInfo? renderPassFragmentDensityMapCreateInfoExt = null, AllocationCallbacks? allocator = default)
        {
            try
            {
                RenderPass result = default;
                SharpVk.Interop.RenderPassCreateInfo* marshalledCreateInfo = default;
                void* vkRenderPassCreateInfoNextPointer = default;
                SharpVk.Interop.AllocationCallbacks* marshalledAllocator = default;
                SharpVk.Interop.RenderPass marshalledRenderPass = default;
                if (renderPassMultiviewCreateInfo != null)
                {
                    SharpVk.Interop.RenderPassMultiviewCreateInfo* extensionPointer = default;
                    extensionPointer = (SharpVk.Interop.RenderPassMultiviewCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.RenderPassMultiviewCreateInfo>());
                    renderPassMultiviewCreateInfo.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkRenderPassCreateInfoNextPointer;
                    vkRenderPassCreateInfoNextPointer = extensionPointer;
                }
                if (renderPassInputAttachmentAspectCreateInfo != null)
                {
                    SharpVk.Interop.RenderPassInputAttachmentAspectCreateInfo* extensionPointer = default;
                    extensionPointer = (SharpVk.Interop.RenderPassInputAttachmentAspectCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.RenderPassInputAttachmentAspectCreateInfo>());
                    renderPassInputAttachmentAspectCreateInfo.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkRenderPassCreateInfoNextPointer;
                    vkRenderPassCreateInfoNextPointer = extensionPointer;
                }
                if (renderPassFragmentDensityMapCreateInfoExt != null)
                {
                    SharpVk.Interop.Multivendor.RenderPassFragmentDensityMapCreateInfo* extensionPointer = default;
                    extensionPointer = (SharpVk.Interop.Multivendor.RenderPassFragmentDensityMapCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.RenderPassFragmentDensityMapCreateInfo>());
                    renderPassFragmentDensityMapCreateInfoExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkRenderPassCreateInfoNextPointer;
                    vkRenderPassCreateInfoNextPointer = extensionPointer;
                }
                marshalledCreateInfo = (SharpVk.Interop.RenderPassCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.RenderPassCreateInfo>());
                marshalledCreateInfo->SType = StructureType.RenderPassCreateInfo;
                marshalledCreateInfo->Next = vkRenderPassCreateInfoNextPointer;
                if (flags != null)
                {
                    marshalledCreateInfo->Flags = flags.Value;
                }
                else
                {
                    marshalledCreateInfo->Flags = default;
                }
                marshalledCreateInfo->AttachmentCount = (uint)(Interop.HeapUtil.GetLength(attachments));
                if (attachments.IsNull())
                {
                    marshalledCreateInfo->Attachments = null;
                }
                else
                {
                    if (attachments.Value.Contents == ProxyContents.Single)
                    {
                        marshalledCreateInfo->Attachments = (AttachmentDescription*)(Interop.HeapUtil.Allocate<AttachmentDescription>());
                        *(AttachmentDescription*)(marshalledCreateInfo->Attachments) = attachments.Value.GetSingleValue();
                    }
                    else
                    {
                        var fieldPointer = (AttachmentDescription*)(Interop.HeapUtil.AllocateAndClear<AttachmentDescription>(Interop.HeapUtil.GetLength(attachments.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(attachments.Value)); index++)
                        {
                            fieldPointer[index] = attachments.Value[index];
                        }
                        marshalledCreateInfo->Attachments = fieldPointer;
                    }
                }
                marshalledCreateInfo->SubpassCount = (uint)(Interop.HeapUtil.GetLength(subpasses));
                if (subpasses.IsNull())
                {
                    marshalledCreateInfo->Subpasses = null;
                }
                else
                {
                    if (subpasses.Value.Contents == ProxyContents.Single)
                    {
                        marshalledCreateInfo->Subpasses = (SharpVk.Interop.SubpassDescription*)(Interop.HeapUtil.Allocate<SharpVk.Interop.SubpassDescription>());
                        subpasses.Value.GetSingleValue().MarshalTo(&*(SharpVk.Interop.SubpassDescription*)(marshalledCreateInfo->Subpasses));
                    }
                    else
                    {
                        var fieldPointer = (SharpVk.Interop.SubpassDescription*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.SubpassDescription>(Interop.HeapUtil.GetLength(subpasses.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(subpasses.Value)); index++)
                        {
                            subpasses.Value[index].MarshalTo(&fieldPointer[index]);
                        }
                        marshalledCreateInfo->Subpasses = fieldPointer;
                    }
                }
                marshalledCreateInfo->DependencyCount = (uint)(Interop.HeapUtil.GetLength(dependencies));
                if (dependencies.IsNull())
                {
                    marshalledCreateInfo->Dependencies = null;
                }
                else
                {
                    if (dependencies.Value.Contents == ProxyContents.Single)
                    {
                        marshalledCreateInfo->Dependencies = (SubpassDependency*)(Interop.HeapUtil.Allocate<SubpassDependency>());
                        *(SubpassDependency*)(marshalledCreateInfo->Dependencies) = dependencies.Value.GetSingleValue();
                    }
                    else
                    {
                        var fieldPointer = (SubpassDependency*)(Interop.HeapUtil.AllocateAndClear<SubpassDependency>(Interop.HeapUtil.GetLength(dependencies.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(dependencies.Value)); index++)
                        {
                            fieldPointer[index] = dependencies.Value[index];
                        }
                        marshalledCreateInfo->Dependencies = fieldPointer;
                    }
                }
                if (allocator != null)
                {
                    marshalledAllocator = (SharpVk.Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<SharpVk.Interop.AllocationCallbacks>());
                    allocator.Value.MarshalTo(marshalledAllocator);
                }
                else
                {
                    marshalledAllocator = default;
                }
                Interop.VkDeviceCreateRenderPassDelegate commandDelegate = commandCache.Cache.vkCreateRenderPass;
                Result methodResult = commandDelegate(Handle, marshalledCreateInfo, marshalledAllocator, &marshalledRenderPass);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = new RenderPass(this, marshalledRenderPass);
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Create a new command pool object.
        /// </summary>
        /// <param name="flags">
        /// A bitmask indicating usage behavior for the pool and command
        /// buffers allocated from it. Bits which can be set include: + --
        /// </param>
        /// <param name="queueFamilyIndex">
        /// </param>
        /// <param name="allocator">
        /// An optional AllocationCallbacks instance that controls host memory
        /// allocation.
        /// </param>
        public unsafe CommandPool CreateCommandPool(uint queueFamilyIndex, CommandPoolCreateFlags? flags = default, AllocationCallbacks? allocator = default)
        {
            try
            {
                CommandPool result = default;
                SharpVk.Interop.CommandPoolCreateInfo* marshalledCreateInfo = default;
                void* vkCommandPoolCreateInfoNextPointer = default;
                SharpVk.Interop.AllocationCallbacks* marshalledAllocator = default;
                SharpVk.Interop.CommandPool marshalledCommandPool = default;
                marshalledCreateInfo = (SharpVk.Interop.CommandPoolCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.CommandPoolCreateInfo>());
                marshalledCreateInfo->SType = StructureType.CommandPoolCreateInfo;
                marshalledCreateInfo->Next = vkCommandPoolCreateInfoNextPointer;
                if (flags != null)
                {
                    marshalledCreateInfo->Flags = flags.Value;
                }
                else
                {
                    marshalledCreateInfo->Flags = default;
                }
                marshalledCreateInfo->QueueFamilyIndex = queueFamilyIndex;
                if (allocator != null)
                {
                    marshalledAllocator = (SharpVk.Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<SharpVk.Interop.AllocationCallbacks>());
                    allocator.Value.MarshalTo(marshalledAllocator);
                }
                else
                {
                    marshalledAllocator = default;
                }
                Interop.VkDeviceCreateCommandPoolDelegate commandDelegate = commandCache.Cache.vkCreateCommandPool;
                Result methodResult = commandDelegate(Handle, marshalledCreateInfo, marshalledAllocator, &marshalledCommandPool);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = new CommandPool(this, marshalledCommandPool);
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Allocate command buffers from an existing command pool.
        /// </summary>
        /// <param name="commandPool">
        ///     The command pool from which the command buffers are allocated.
        /// </param>
        /// <param name="level">
        ///     level determines whether the command buffers are primary or
        ///     secondary command buffers. Possible values include: + --
        /// </param>
        /// <param name="commandBufferCount">
        /// </param>
        public unsafe CommandBuffer[] AllocateCommandBuffers(CommandPool commandPool, CommandBufferLevel level, uint commandBufferCount)
        {
            try
            {
                var result = default(CommandBuffer[]);
                var marshalledAllocateInfo = default(Interop.CommandBufferAllocateInfo*);
                var vkCommandBufferAllocateInfoNextPointer = default(void*);
                var marshalledCommandBuffers = default(Interop.CommandBuffer*);
                marshalledAllocateInfo = (Interop.CommandBufferAllocateInfo*)Interop.HeapUtil.Allocate<Interop.CommandBufferAllocateInfo>();
                marshalledAllocateInfo->SType = StructureType.CommandBufferAllocateInfo;
                marshalledAllocateInfo->Next = vkCommandBufferAllocateInfoNextPointer;
                marshalledAllocateInfo->CommandPool = commandPool?.Handle ?? default(Interop.CommandPool);
                marshalledAllocateInfo->Level = level;
                marshalledAllocateInfo->CommandBufferCount = commandBufferCount;
                marshalledCommandBuffers = (Interop.CommandBuffer*)Interop.HeapUtil.Allocate<Interop.CommandBuffer>(commandBufferCount);
                var commandDelegate = commandCache.Cache.vkAllocateCommandBuffers;
                var methodResult = commandDelegate(Handle, marshalledAllocateInfo, marshalledCommandBuffers);
                if (SharpVkException.IsError(methodResult)) throw SharpVkException.Create(methodResult);
                if (marshalledCommandBuffers != null)
                {
                    var fieldPointer = new CommandBuffer[commandBufferCount];
                    for(int index = 0; index < (uint)(commandBufferCount); index++)
                    {
                        fieldPointer[index] = new CommandBuffer(commandPool, marshalledCommandBuffers[index]);
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
        /// </summary>
        /// <param name="bindInfos">
        /// </param>
        public unsafe void BindBufferMemory2(ArrayProxy<BindBufferMemoryInfo>? bindInfos)
        {
            try
            {
                SharpVk.Interop.BindBufferMemoryInfo* marshalledBindInfos = default;
                if (bindInfos.IsNull())
                {
                    marshalledBindInfos = null;
                }
                else
                {
                    if (bindInfos.Value.Contents == ProxyContents.Single)
                    {
                        marshalledBindInfos = (SharpVk.Interop.BindBufferMemoryInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.BindBufferMemoryInfo>());
                        bindInfos.Value.GetSingleValue().MarshalTo(&*(SharpVk.Interop.BindBufferMemoryInfo*)(marshalledBindInfos));
                    }
                    else
                    {
                        var fieldPointer = (SharpVk.Interop.BindBufferMemoryInfo*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.BindBufferMemoryInfo>(Interop.HeapUtil.GetLength(bindInfos.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(bindInfos.Value)); index++)
                        {
                            bindInfos.Value[index].MarshalTo(&fieldPointer[index]);
                        }
                        marshalledBindInfos = fieldPointer;
                    }
                }
                Interop.VkDeviceBindBufferMemory2Delegate commandDelegate = commandCache.Cache.vkBindBufferMemory2;
                Result methodResult = commandDelegate(Handle, (uint)(Interop.HeapUtil.GetLength(bindInfos)), marshalledBindInfos);
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
        /// </summary>
        /// <param name="bindInfos">
        /// </param>
        public unsafe void BindImageMemory2(ArrayProxy<BindImageMemoryInfo>? bindInfos)
        {
            try
            {
                SharpVk.Interop.BindImageMemoryInfo* marshalledBindInfos = default;
                if (bindInfos.IsNull())
                {
                    marshalledBindInfos = null;
                }
                else
                {
                    if (bindInfos.Value.Contents == ProxyContents.Single)
                    {
                        marshalledBindInfos = (SharpVk.Interop.BindImageMemoryInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.BindImageMemoryInfo>());
                        bindInfos.Value.GetSingleValue().MarshalTo(&*(SharpVk.Interop.BindImageMemoryInfo*)(marshalledBindInfos));
                    }
                    else
                    {
                        var fieldPointer = (SharpVk.Interop.BindImageMemoryInfo*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.BindImageMemoryInfo>(Interop.HeapUtil.GetLength(bindInfos.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(bindInfos.Value)); index++)
                        {
                            bindInfos.Value[index].MarshalTo(&fieldPointer[index]);
                        }
                        marshalledBindInfos = fieldPointer;
                    }
                }
                Interop.VkDeviceBindImageMemory2Delegate commandDelegate = commandCache.Cache.vkBindImageMemory2;
                Result methodResult = commandDelegate(Handle, (uint)(Interop.HeapUtil.GetLength(bindInfos)), marshalledBindInfos);
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
        /// </summary>
        /// <param name="heapIndex">
        /// </param>
        /// <param name="localDeviceIndex">
        /// </param>
        /// <param name="remoteDeviceIndex">
        /// </param>
        public unsafe PeerMemoryFeatureFlags GetGroupPeerMemoryFeatures(uint heapIndex, uint localDeviceIndex, uint remoteDeviceIndex)
        {
            try
            {
                PeerMemoryFeatureFlags result = default;
                PeerMemoryFeatureFlags marshalledPeerMemoryFeatures = default;
                Interop.VkDeviceGetGroupPeerMemoryFeaturesDelegate commandDelegate = commandCache.Cache.vkGetDeviceGroupPeerMemoryFeatures;
                commandDelegate(Handle, heapIndex, localDeviceIndex, remoteDeviceIndex, &marshalledPeerMemoryFeatures);
                result = marshalledPeerMemoryFeatures;
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// </summary>
        /// <param name="info">
        /// </param>
        public unsafe MemoryRequirements2 GetImageMemoryRequirements2(ImageMemoryRequirementsInfo2 info)
        {
            try
            {
                MemoryRequirements2 result = default;
                SharpVk.Interop.ImageMemoryRequirementsInfo2* marshalledInfo = default;
                SharpVk.Interop.MemoryRequirements2 marshalledMemoryRequirements = default;
                marshalledMemoryRequirements.SType = StructureType.MemoryRequirements2Version;
                marshalledInfo = (SharpVk.Interop.ImageMemoryRequirementsInfo2*)(Interop.HeapUtil.Allocate<SharpVk.Interop.ImageMemoryRequirementsInfo2>());
                info.MarshalTo(marshalledInfo);
                Interop.VkDeviceGetImageMemoryRequirements2Delegate commandDelegate = commandCache.Cache.vkGetImageMemoryRequirements2;
                commandDelegate(Handle, marshalledInfo, &marshalledMemoryRequirements);
                result = MemoryRequirements2.MarshalFrom(&marshalledMemoryRequirements);
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// </summary>
        /// <param name="info">
        /// </param>
        public unsafe MemoryRequirements2 GetBufferMemoryRequirements2(BufferMemoryRequirementsInfo2 info)
        {
            try
            {
                MemoryRequirements2 result = default;
                SharpVk.Interop.BufferMemoryRequirementsInfo2* marshalledInfo = default;
                SharpVk.Interop.MemoryRequirements2 marshalledMemoryRequirements = default;
                marshalledInfo = (SharpVk.Interop.BufferMemoryRequirementsInfo2*)(Interop.HeapUtil.Allocate<SharpVk.Interop.BufferMemoryRequirementsInfo2>());
                info.MarshalTo(marshalledInfo);
                Interop.VkDeviceGetBufferMemoryRequirements2Delegate commandDelegate = commandCache.Cache.vkGetBufferMemoryRequirements2;
                commandDelegate(Handle, marshalledInfo, &marshalledMemoryRequirements);
                result = MemoryRequirements2.MarshalFrom(&marshalledMemoryRequirements);
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// </summary>
        /// <param name="info">
        /// </param>
        public unsafe SparseImageMemoryRequirements2[] GetImageSparseMemoryRequirements2(ImageSparseMemoryRequirementsInfo2 info)
        {
            try
            {
                SparseImageMemoryRequirements2[] result = default;
                uint marshalledSparseMemoryRequirementCount = default;
                SharpVk.Interop.ImageSparseMemoryRequirementsInfo2* marshalledInfo = default;
                SharpVk.Interop.SparseImageMemoryRequirements2* marshalledSparseMemoryRequirements = default;
                marshalledInfo = (SharpVk.Interop.ImageSparseMemoryRequirementsInfo2*)(Interop.HeapUtil.Allocate<SharpVk.Interop.ImageSparseMemoryRequirementsInfo2>());
                info.MarshalTo(marshalledInfo);
                Interop.VkDeviceGetImageSparseMemoryRequirements2Delegate commandDelegate = commandCache.Cache.vkGetImageSparseMemoryRequirements2;
                commandDelegate(Handle, marshalledInfo, &marshalledSparseMemoryRequirementCount, marshalledSparseMemoryRequirements);
                marshalledSparseMemoryRequirements = (SharpVk.Interop.SparseImageMemoryRequirements2*)(Interop.HeapUtil.Allocate<SharpVk.Interop.SparseImageMemoryRequirements2>((uint)(marshalledSparseMemoryRequirementCount)));
                commandDelegate(Handle, marshalledInfo, &marshalledSparseMemoryRequirementCount, marshalledSparseMemoryRequirements);
                if (marshalledSparseMemoryRequirements != null)
                {
                    var fieldPointer = new SparseImageMemoryRequirements2[(uint)(marshalledSparseMemoryRequirementCount)];
                    for(int index = 0; index < (uint)(marshalledSparseMemoryRequirementCount); index++)
                    {
                        fieldPointer[index] = SparseImageMemoryRequirements2.MarshalFrom(&marshalledSparseMemoryRequirements[index]);
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
        /// </summary>
        /// <param name="queueInfo">
        /// </param>
        public unsafe Queue GetQueue2(DeviceQueueInfo2 queueInfo)
        {
            try
            {
                Queue result = default;
                SharpVk.Interop.DeviceQueueInfo2* marshalledQueueInfo = default;
                SharpVk.Interop.Queue marshalledQueue = default;
                marshalledQueueInfo = (SharpVk.Interop.DeviceQueueInfo2*)(Interop.HeapUtil.Allocate<SharpVk.Interop.DeviceQueueInfo2>());
                queueInfo.MarshalTo(marshalledQueueInfo);
                Interop.VkDeviceGetQueue2Delegate commandDelegate = commandCache.Cache.vkGetDeviceQueue2;
                commandDelegate(Handle, marshalledQueueInfo, &marshalledQueue);
                result = new Queue(this, marshalledQueue);
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// </summary>
        /// <param name="format">
        /// </param>
        /// <param name="ycbcrModel">
        /// </param>
        /// <param name="ycbcrRange">
        /// </param>
        /// <param name="components">
        /// </param>
        /// <param name="xChromaOffset">
        /// </param>
        /// <param name="yChromaOffset">
        /// </param>
        /// <param name="chromaFilter">
        /// </param>
        /// <param name="forceExplicitReconstruction">
        /// </param>
        /// <param name="externalFormatAndroid">
        /// Extension struct
        /// </param>
        /// <param name="allocator">
        /// </param>
        public unsafe SamplerYcbcrConversion CreateSamplerYcbcrConversion(Format format, SamplerYcbcrModelConversion ycbcrModel, SamplerYcbcrRange ycbcrRange, ComponentMapping components, ChromaLocation xChromaOffset, ChromaLocation yChromaOffset, Filter chromaFilter, bool forceExplicitReconstruction, Android.ExternalFormat? externalFormatAndroid = null, AllocationCallbacks? allocator = default)
        {
            try
            {
                SamplerYcbcrConversion result = default;
                SharpVk.Interop.SamplerYcbcrConversionCreateInfo* marshalledCreateInfo = default;
                void* vkSamplerYcbcrConversionCreateInfoNextPointer = default;
                SharpVk.Interop.AllocationCallbacks* marshalledAllocator = default;
                SharpVk.Interop.SamplerYcbcrConversion marshalledYcbcrConversion = default;
                if (externalFormatAndroid != null)
                {
                    SharpVk.Interop.Android.ExternalFormat* extensionPointer = default;
                    extensionPointer = (SharpVk.Interop.Android.ExternalFormat*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Android.ExternalFormat>());
                    externalFormatAndroid.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkSamplerYcbcrConversionCreateInfoNextPointer;
                    vkSamplerYcbcrConversionCreateInfoNextPointer = extensionPointer;
                }
                marshalledCreateInfo = (SharpVk.Interop.SamplerYcbcrConversionCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.SamplerYcbcrConversionCreateInfo>());
                marshalledCreateInfo->SType = StructureType.SamplerYcbcrConversionCreateInfoVersion;
                marshalledCreateInfo->Next = vkSamplerYcbcrConversionCreateInfoNextPointer;
                marshalledCreateInfo->Format = format;
                marshalledCreateInfo->YcbcrModel = ycbcrModel;
                marshalledCreateInfo->YcbcrRange = ycbcrRange;
                marshalledCreateInfo->Components = components;
                marshalledCreateInfo->XChromaOffset = xChromaOffset;
                marshalledCreateInfo->YChromaOffset = yChromaOffset;
                marshalledCreateInfo->ChromaFilter = chromaFilter;
                marshalledCreateInfo->ForceExplicitReconstruction = forceExplicitReconstruction;
                if (allocator != null)
                {
                    marshalledAllocator = (SharpVk.Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<SharpVk.Interop.AllocationCallbacks>());
                    allocator.Value.MarshalTo(marshalledAllocator);
                }
                else
                {
                    marshalledAllocator = default;
                }
                Interop.VkDeviceCreateSamplerYcbcrConversionDelegate commandDelegate = commandCache.Cache.vkCreateSamplerYcbcrConversion;
                Result methodResult = commandDelegate(Handle, marshalledCreateInfo, marshalledAllocator, &marshalledYcbcrConversion);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = new SamplerYcbcrConversion(this, marshalledYcbcrConversion);
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// </summary>
        /// <param name="flags">
        /// </param>
        /// <param name="descriptorUpdateEntries">
        /// </param>
        /// <param name="templateType">
        /// </param>
        /// <param name="descriptorSetLayout">
        /// </param>
        /// <param name="pipelineBindPoint">
        /// </param>
        /// <param name="pipelineLayout">
        /// </param>
        /// <param name="set">
        /// </param>
        /// <param name="allocator">
        /// </param>
        public unsafe DescriptorUpdateTemplate CreateDescriptorUpdateTemplate(ArrayProxy<DescriptorUpdateTemplateEntry>? descriptorUpdateEntries, DescriptorUpdateTemplateType templateType, DescriptorSetLayout descriptorSetLayout, PipelineBindPoint pipelineBindPoint, PipelineLayout pipelineLayout, uint set, DescriptorUpdateTemplateCreateFlags? flags = default, AllocationCallbacks? allocator = default)
        {
            try
            {
                DescriptorUpdateTemplate result = default;
                SharpVk.Interop.DescriptorUpdateTemplateCreateInfo* marshalledCreateInfo = default;
                void* vkDescriptorUpdateTemplateCreateInfoNextPointer = default;
                SharpVk.Interop.AllocationCallbacks* marshalledAllocator = default;
                SharpVk.Interop.DescriptorUpdateTemplate marshalledDescriptorUpdateTemplate = default;
                marshalledCreateInfo = (SharpVk.Interop.DescriptorUpdateTemplateCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.DescriptorUpdateTemplateCreateInfo>());
                marshalledCreateInfo->SType = StructureType.DescriptorUpdateTemplateCreateInfoVersion;
                marshalledCreateInfo->Next = vkDescriptorUpdateTemplateCreateInfoNextPointer;
                if (flags != null)
                {
                    marshalledCreateInfo->Flags = flags.Value;
                }
                else
                {
                    marshalledCreateInfo->Flags = default;
                }
                marshalledCreateInfo->DescriptorUpdateEntryCount = (uint)(Interop.HeapUtil.GetLength(descriptorUpdateEntries));
                if (descriptorUpdateEntries.IsNull())
                {
                    marshalledCreateInfo->DescriptorUpdateEntries = null;
                }
                else
                {
                    if (descriptorUpdateEntries.Value.Contents == ProxyContents.Single)
                    {
                        marshalledCreateInfo->DescriptorUpdateEntries = (DescriptorUpdateTemplateEntry*)(Interop.HeapUtil.Allocate<DescriptorUpdateTemplateEntry>());
                        *(DescriptorUpdateTemplateEntry*)(marshalledCreateInfo->DescriptorUpdateEntries) = descriptorUpdateEntries.Value.GetSingleValue();
                    }
                    else
                    {
                        var fieldPointer = (DescriptorUpdateTemplateEntry*)(Interop.HeapUtil.AllocateAndClear<DescriptorUpdateTemplateEntry>(Interop.HeapUtil.GetLength(descriptorUpdateEntries.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(descriptorUpdateEntries.Value)); index++)
                        {
                            fieldPointer[index] = descriptorUpdateEntries.Value[index];
                        }
                        marshalledCreateInfo->DescriptorUpdateEntries = fieldPointer;
                    }
                }
                marshalledCreateInfo->TemplateType = templateType;
                marshalledCreateInfo->DescriptorSetLayout = descriptorSetLayout?.Handle ?? default;
                marshalledCreateInfo->PipelineBindPoint = pipelineBindPoint;
                marshalledCreateInfo->PipelineLayout = pipelineLayout?.Handle ?? default;
                marshalledCreateInfo->Set = set;
                if (allocator != null)
                {
                    marshalledAllocator = (SharpVk.Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<SharpVk.Interop.AllocationCallbacks>());
                    allocator.Value.MarshalTo(marshalledAllocator);
                }
                else
                {
                    marshalledAllocator = default;
                }
                Interop.VkDeviceCreateDescriptorUpdateTemplateDelegate commandDelegate = commandCache.Cache.vkCreateDescriptorUpdateTemplate;
                Result methodResult = commandDelegate(Handle, marshalledCreateInfo, marshalledAllocator, &marshalledDescriptorUpdateTemplate);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = new DescriptorUpdateTemplate(this, marshalledDescriptorUpdateTemplate);
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// </summary>
        /// <param name="descriptorSet">
        /// </param>
        /// <param name="descriptorUpdateTemplate">
        /// </param>
        /// <param name="data">
        /// </param>
        public unsafe void UpdateDescriptorSetWithTemplate(DescriptorSet descriptorSet, DescriptorUpdateTemplate descriptorUpdateTemplate, IntPtr data)
        {
            try
            {
                Interop.VkDeviceUpdateDescriptorSetWithTemplateDelegate commandDelegate = commandCache.Cache.vkUpdateDescriptorSetWithTemplate;
                commandDelegate(Handle, descriptorSet?.Handle ?? default, descriptorUpdateTemplate?.Handle ?? default, data.ToPointer());
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// </summary>
        /// <param name="createInfo">
        /// </param>
        public unsafe DescriptorSetLayoutSupport GetDescriptorSetLayoutSupport(DescriptorSetLayoutCreateInfo createInfo)
        {
            try
            {
                DescriptorSetLayoutSupport result = default;
                SharpVk.Interop.DescriptorSetLayoutCreateInfo* marshalledCreateInfo = default;
                SharpVk.Interop.DescriptorSetLayoutSupport marshalledSupport = default;
                marshalledCreateInfo = (SharpVk.Interop.DescriptorSetLayoutCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.DescriptorSetLayoutCreateInfo>());
                createInfo.MarshalTo(marshalledCreateInfo);
                Interop.VkDeviceGetDescriptorSetLayoutSupportDelegate commandDelegate = commandCache.Cache.vkGetDescriptorSetLayoutSupport;
                commandDelegate(Handle, marshalledCreateInfo, &marshalledSupport);
                result = DescriptorSetLayoutSupport.MarshalFrom(&marshalledSupport);
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// </summary>
        /// <param name="createInfo">
        /// </param>
        /// <param name="allocator">
        /// </param>
        public unsafe RenderPass CreateRenderPass2(RenderPassCreateInfo2 createInfo, AllocationCallbacks? allocator = default)
        {
            try
            {
                RenderPass result = default;
                SharpVk.Interop.RenderPassCreateInfo2* marshalledCreateInfo = default;
                SharpVk.Interop.AllocationCallbacks* marshalledAllocator = default;
                SharpVk.Interop.RenderPass marshalledRenderPass = default;
                marshalledCreateInfo = (SharpVk.Interop.RenderPassCreateInfo2*)(Interop.HeapUtil.Allocate<SharpVk.Interop.RenderPassCreateInfo2>());
                createInfo.MarshalTo(marshalledCreateInfo);
                if (allocator != null)
                {
                    marshalledAllocator = (SharpVk.Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<SharpVk.Interop.AllocationCallbacks>());
                    allocator.Value.MarshalTo(marshalledAllocator);
                }
                else
                {
                    marshalledAllocator = default;
                }
                Interop.VkDeviceCreateRenderPass2Delegate commandDelegate = commandCache.Cache.vkCreateRenderPass2;
                Result methodResult = commandDelegate(Handle, marshalledCreateInfo, marshalledAllocator, &marshalledRenderPass);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = new RenderPass(this, marshalledRenderPass);
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// </summary>
        /// <param name="flags">
        /// </param>
        /// <param name="semaphores">
        /// </param>
        /// <param name="values">
        /// </param>
        /// <param name="timeout">
        /// </param>
        public unsafe Result WaitSemaphores(ArrayProxy<Semaphore>? semaphores, ArrayProxy<ulong>? values, ulong timeout, SemaphoreWaitFlags? flags = default)
        {
            try
            {
                Result result = default;
                SharpVk.Interop.SemaphoreWaitInfo* marshalledWaitInfo = default;
                void* vkSemaphoreWaitInfoNextPointer = default;
                marshalledWaitInfo = (SharpVk.Interop.SemaphoreWaitInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.SemaphoreWaitInfo>());
                marshalledWaitInfo->SType = StructureType.SemaphoreWaitInfoVersion;
                marshalledWaitInfo->Next = vkSemaphoreWaitInfoNextPointer;
                if (flags != null)
                {
                    marshalledWaitInfo->Flags = flags.Value;
                }
                else
                {
                    marshalledWaitInfo->Flags = default;
                }
                marshalledWaitInfo->SemaphoreCount = (uint)(Interop.HeapUtil.GetLength(semaphores));
                if (semaphores.IsNull())
                {
                    marshalledWaitInfo->Semaphores = null;
                }
                else
                {
                    if (semaphores.Value.Contents == ProxyContents.Single)
                    {
                        marshalledWaitInfo->Semaphores = (SharpVk.Interop.Semaphore*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Semaphore>());
                        *(SharpVk.Interop.Semaphore*)(marshalledWaitInfo->Semaphores) = semaphores.Value.GetSingleValue()?.Handle ?? default;
                    }
                    else
                    {
                        var fieldPointer = (SharpVk.Interop.Semaphore*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.Semaphore>(Interop.HeapUtil.GetLength(semaphores.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(semaphores.Value)); index++)
                        {
                            fieldPointer[index] = semaphores.Value[index]?.Handle ?? default;
                        }
                        marshalledWaitInfo->Semaphores = fieldPointer;
                    }
                }
                if (values.IsNull())
                {
                    marshalledWaitInfo->Values = null;
                }
                else
                {
                    if (values.Value.Contents == ProxyContents.Single)
                    {
                        marshalledWaitInfo->Values = (ulong*)(Interop.HeapUtil.Allocate<ulong>());
                        *(ulong*)(marshalledWaitInfo->Values) = values.Value.GetSingleValue();
                    }
                    else
                    {
                        var fieldPointer = (ulong*)(Interop.HeapUtil.AllocateAndClear<ulong>(Interop.HeapUtil.GetLength(values.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(values.Value)); index++)
                        {
                            fieldPointer[index] = values.Value[index];
                        }
                        marshalledWaitInfo->Values = fieldPointer;
                    }
                }
                Interop.VkDeviceWaitSemaphoresDelegate commandDelegate = commandCache.Cache.vkWaitSemaphores;
                result = commandDelegate(Handle, marshalledWaitInfo, timeout);
                if (SharpVkException.IsError(result))
                {
                    throw SharpVkException.Create(result);
                }
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// </summary>
        /// <param name="semaphore">
        /// </param>
        /// <param name="value">
        /// </param>
        public unsafe void SignalSemaphore(Semaphore semaphore, ulong value)
        {
            try
            {
                SharpVk.Interop.SemaphoreSignalInfo* marshalledSignalInfo = default;
                void* vkSemaphoreSignalInfoNextPointer = default;
                marshalledSignalInfo = (SharpVk.Interop.SemaphoreSignalInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.SemaphoreSignalInfo>());
                marshalledSignalInfo->SType = StructureType.SemaphoreSignalInfoVersion;
                marshalledSignalInfo->Next = vkSemaphoreSignalInfoNextPointer;
                marshalledSignalInfo->Semaphore = semaphore?.Handle ?? default;
                marshalledSignalInfo->Value = value;
                Interop.VkDeviceSignalSemaphoreDelegate commandDelegate = commandCache.Cache.vkSignalSemaphore;
                Result methodResult = commandDelegate(Handle, marshalledSignalInfo);
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
        /// </summary>
        /// <param name="info">
        /// </param>
        public unsafe void GetBufferDeviceAddress(BufferDeviceAddressInfo info)
        {
            try
            {
                SharpVk.Interop.BufferDeviceAddressInfo* marshalledInfo = default;
                marshalledInfo = (SharpVk.Interop.BufferDeviceAddressInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.BufferDeviceAddressInfo>());
                info.MarshalTo(marshalledInfo);
                Interop.VkDeviceGetBufferDeviceAddressDelegate commandDelegate = commandCache.Cache.vkGetBufferDeviceAddress;
                commandDelegate(Handle, marshalledInfo);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// </summary>
        /// <param name="info">
        /// </param>
        public unsafe void GetBufferOpaqueCaptureAddress(BufferDeviceAddressInfo info)
        {
            try
            {
                SharpVk.Interop.BufferDeviceAddressInfo* marshalledInfo = default;
                marshalledInfo = (SharpVk.Interop.BufferDeviceAddressInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.BufferDeviceAddressInfo>());
                info.MarshalTo(marshalledInfo);
                Interop.VkDeviceGetBufferOpaqueCaptureAddressDelegate commandDelegate = commandCache.Cache.vkGetBufferOpaqueCaptureAddress;
                commandDelegate(Handle, marshalledInfo);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// </summary>
        /// <param name="info">
        /// </param>
        public unsafe void GetMemoryOpaqueCaptureAddress(DeviceMemoryOpaqueCaptureAddressInfo info)
        {
            try
            {
                SharpVk.Interop.DeviceMemoryOpaqueCaptureAddressInfo* marshalledInfo = default;
                marshalledInfo = (SharpVk.Interop.DeviceMemoryOpaqueCaptureAddressInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.DeviceMemoryOpaqueCaptureAddressInfo>());
                info.MarshalTo(marshalledInfo);
                Interop.VkDeviceGetMemoryOpaqueCaptureAddressDelegate commandDelegate = commandCache.Cache.vkGetDeviceMemoryOpaqueCaptureAddress;
                commandDelegate(Handle, marshalledInfo);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Destroys the handles and releases any unmanaged resources
        /// associated with it.
        /// </summary>
        public void Dispose()
        {
            Destroy();
        }
    }
}
