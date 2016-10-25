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
    /// considered to be equally ``local'' to the host and to the device, and
    /// such an implementation must: advertise the heap as device-local.
    /// </para>
    /// <para>
    /// Each memory type returned by flink:vkGetPhysicalDeviceMemoryProperties
    /// must: have its pname:propertyFlags set to one of the following values:
    /// </para>
    /// <para>
    /// * 0 * ename:VK_MEMORY_PROPERTY_HOST_VISIBLE_BIT |
    /// ename:VK_MEMORY_PROPERTY_HOST_COHERENT_BIT *
    /// ename:VK_MEMORY_PROPERTY_HOST_VISIBLE_BIT |
    /// ename:VK_MEMORY_PROPERTY_HOST_CACHED_BIT *
    /// ename:VK_MEMORY_PROPERTY_HOST_VISIBLE_BIT |
    /// ename:VK_MEMORY_PROPERTY_HOST_CACHED_BIT |
    /// ename:VK_MEMORY_PROPERTY_HOST_COHERENT_BIT *
    /// ename:VK_MEMORY_PROPERTY_DEVICE_LOCAL_BIT *
    /// ename:VK_MEMORY_PROPERTY_DEVICE_LOCAL_BIT |
    /// ename:VK_MEMORY_PROPERTY_HOST_VISIBLE_BIT |
    /// ename:VK_MEMORY_PROPERTY_HOST_COHERENT_BIT *
    /// ename:VK_MEMORY_PROPERTY_DEVICE_LOCAL_BIT |
    /// ename:VK_MEMORY_PROPERTY_HOST_VISIBLE_BIT |
    /// ename:VK_MEMORY_PROPERTY_HOST_CACHED_BIT *
    /// ename:VK_MEMORY_PROPERTY_DEVICE_LOCAL_BIT |
    /// ename:VK_MEMORY_PROPERTY_HOST_VISIBLE_BIT |
    /// ename:VK_MEMORY_PROPERTY_HOST_CACHED_BIT |
    /// ename:VK_MEMORY_PROPERTY_HOST_COHERENT_BIT *
    /// ename:VK_MEMORY_PROPERTY_DEVICE_LOCAL_BIT |
    /// ename:VK_MEMORY_PROPERTY_LAZILY_ALLOCATED_BIT
    /// </para>
    /// <para>
    /// There must: be at least one memory type with both the
    /// ename:VK_MEMORY_PROPERTY_HOST_VISIBLE_BIT and
    /// ename:VK_MEMORY_PROPERTY_HOST_COHERENT_BIT bits set in its
    /// pname:propertyFlags. There must: be at least one memory type with the
    /// ename:VK_MEMORY_PROPERTY_DEVICE_LOCAL_BIT bit set in its
    /// pname:propertyFlags.
    /// </para>
    /// <para>
    /// The memory types are sorted according to a preorder which serves to aid
    /// in easily selecting an appropriate memory type. Given two memory types
    /// X and Y, the preorder defines [eq]#X {leq} Y# if:
    /// </para>
    /// <para>
    /// * the memory property bits set for X are a strict subset of the memory
    /// property bits set for Y. Or, * the memory property bits set for X are
    /// the same as the memory property bits set for Y, and X uses a memory
    /// heap with greater or equal performance (as determined in an
    /// implementation-specific manner).
    /// </para>
    /// <para>
    /// Memory types are ordered in the list such that X is assigned a lesser
    /// pname:memoryTypeIndex than Y if [eq]#(X {leq} Y) {land} {lnot} (Y {leq}
    /// X)# according to the preorder. Note that the list of all allowed memory
    /// property flag combinations above satisfies this preorder, but other
    /// orders would as well. The goal of this ordering is to enable
    /// applications to use a simple search loop in selecting the proper memory
    /// type, along the lines of:
    /// </para>
    /// <para>
    /// [source,{basebackend@docbook:c++:cpp}]
    /// --------------------------------------------------- // Find a memory
    /// type in "memoryTypeBits" that includes all of "properties" int32_t
    /// FindProperties(uint32_t memoryTypeBits, VkMemoryPropertyFlags
    /// properties) { for (int32_t i = 0; i &lt; memoryTypeCount; ++i) { if
    /// ((memoryTypeBits &amp; (1 &lt;&lt; i)) &amp;&amp;
    /// ((memoryTypes[i].propertyFlags &amp; properties) == properties)) return
    /// i; } return -1; }
    /// </para>
    /// <para>
    /// // Try to find an optimal memory type, or if it does not exist // find
    /// any compatible memory type VkMemoryRequirements memoryRequirements;
    /// vkGetImageMemoryRequirements(device, image, &amp;memoryRequirements);
    /// int32_t memoryType = FindProperties(memoryRequirements.memoryTypeBits,
    /// optimalProperties); if (memoryType == -1) memoryType =
    /// FindProperties(memoryRequirements.memoryTypeBits, requiredProperties);
    /// ---------------------------------------------------
    /// </para>
    /// <para>
    /// The loop will find the first supported memory type that has all bits
    /// requested in code:properties set. If there is no exact match, it will
    /// find a closest match (i.e. a memory type with the fewest additional
    /// bits set), which has some additional bits set but which are not
    /// detrimental to the behaviors requested by code:properties. The
    /// application can: first search for the optimal properties, e.g. a memory
    /// type that is device-local or supports coherent cached accesses, as
    /// appropriate for the intended usage, and if such a memory type is not
    /// present can: fallback to searching for a less optimal but guaranteed
    /// set of properties such as "0" or "host-visible and coherent".
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
