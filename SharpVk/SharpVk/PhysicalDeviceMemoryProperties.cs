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
    /// <para>
    /// Structure specifying physical device memory properties.
    /// </para>
    /// <para>
    /// The sname:VkPhysicalDeviceMemoryProperties structure describes a number
    /// of _memory heaps_ as well as a number of _memory types_ that can: be
    /// used to access memory allocated in those heaps. Each heap describes a
    /// memory resource of a particular size, and each memory type describes a
    /// set of memory properties (e.g. host cached vs uncached) that can: be
    /// used with a given memory heap. Allocations using a particular memory
    /// type will consume resources from the heap indicated by that memory
    /// type's heap index. More than one memory type may: share each heap, and
    /// the heaps and memory types provide a mechanism to advertise an accurate
    /// size of the physical memory resources while allowing the memory to be
    /// used with a variety of different properties.
    /// </para>
    /// <para>
    /// The number of memory heaps is given by pname:memoryHeapCount and is
    /// less than or equal to ename:VK_MAX_MEMORY_HEAPS. Each heap is described
    /// by an element of the pname:memoryHeaps array, as a sname:VkMemoryHeap
    /// structure. The number of memory types available across all memory heaps
    /// is given by pname:memoryTypeCount and is less than or equal to
    /// ename:VK_MAX_MEMORY_TYPES. Each memory type is described by an element
    /// of the pname:memoryTypes array, as a sname:VkMemoryType structure.
    /// </para>
    /// <para>
    /// At least one heap must: include ename:VK_MEMORY_HEAP_DEVICE_LOCAL_BIT
    /// in slink:VkMemoryHeap::pname:flags. If there are multiple heaps that
    /// all have similar performance characteristics, they may: all include
    /// ename:VK_MEMORY_HEAP_DEVICE_LOCAL_BIT. In a unified memory architecture
    /// (UMA) system, there is often only a single memory heap which is
    /// considered to be equally "`local`" to the host and to the device, and
    /// such an implementation must: advertise the heap as device-local.
    /// </para>
    /// <para>
    /// Each memory type returned by flink:vkGetPhysicalDeviceMemoryProperties
    /// must: have its pname:propertyFlags set to one of the following values:
    /// </para>
    /// </summary>
    public struct PhysicalDeviceMemoryProperties
    {
        /// <summary>
        /// pname:memoryTypes is an array of slink:VkMemoryType structures
        /// describing the _memory types_ that can: be used to access memory
        /// allocated from the heaps specified by pname:memoryHeaps.
        /// </summary>
        public MemoryType[] MemoryTypes
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:memoryHeaps is an array of slink:VkMemoryHeap structures
        /// describing the _memory heaps_ from which memory can: be allocated.
        /// </summary>
        public MemoryHeap[] MemoryHeaps
        {
            get;
            set;
        }
        
        internal static unsafe PhysicalDeviceMemoryProperties MarshalFrom(Interop.PhysicalDeviceMemoryProperties* value)
        {
            PhysicalDeviceMemoryProperties result = new PhysicalDeviceMemoryProperties();
            result.MemoryTypes = new MemoryType[value->MemoryTypeCount];
            MemoryType* MemoryTypesPointer = &value->MemoryTypes;
            for (int index = 0; index < value->MemoryTypeCount; index++)
            {
                result.MemoryTypes[index] = *MemoryTypesPointer;
                MemoryTypesPointer++;
            }
            result.MemoryHeaps = new MemoryHeap[value->MemoryHeapCount];
            MemoryHeap* MemoryHeapsPointer = &value->MemoryHeaps;
            for (int index = 0; index < value->MemoryHeapCount; index++)
            {
                result.MemoryHeaps[index] = *MemoryHeapsPointer;
                MemoryHeapsPointer++;
            }
            return result;
        }
    }
}
