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

namespace SharpVk.NVidia.Experimental
{
    /// <summary>
    /// 
    /// </summary>
    public static class DeviceExtensions
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pipelineBindPoint">
        /// The PipelineBindPoint that this layout targets.
        /// </param>
        /// <param name="flags">
        /// A bitmask providing usage hints of this layout. See
        /// IndirectCommandsLayoutUsageFlagBitsNVX below for a description of
        /// the supported bits.
        /// </param>
        /// <param name="tokens">
        /// An array describing each command token in detail. See
        /// IndirectCommandsTokenTypeNVX and IndirectCommandsLayoutTokenNVX
        /// below for details.
        /// </param>
        public static unsafe SharpVk.NVidia.Experimental.IndirectCommandsLayout CreateIndirectCommandsLayout(this SharpVk.Device extendedHandle, SharpVk.PipelineBindPoint pipelineBindPoint, SharpVk.NVidia.Experimental.IndirectCommandsLayoutUsageFlags flags, SharpVk.NVidia.Experimental.IndirectCommandsLayoutToken[] tokens, SharpVk.AllocationCallbacks? allocator = default(SharpVk.AllocationCallbacks?))
        {
            try
            {
                SharpVk.NVidia.Experimental.IndirectCommandsLayout result = default(SharpVk.NVidia.Experimental.IndirectCommandsLayout);
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.NVidia.Experimental.IndirectCommandsLayoutCreateInfo* marshalledCreateInfo = default(SharpVk.Interop.NVidia.Experimental.IndirectCommandsLayoutCreateInfo*);
                SharpVk.Interop.AllocationCallbacks* marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                SharpVk.Interop.NVidia.Experimental.IndirectCommandsLayout marshalledIndirectCommandsLayout = default(SharpVk.Interop.NVidia.Experimental.IndirectCommandsLayout);
                commandCache = extendedHandle.commandCache;
                marshalledCreateInfo = (SharpVk.Interop.NVidia.Experimental.IndirectCommandsLayoutCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.NVidia.Experimental.IndirectCommandsLayoutCreateInfo>());
                marshalledCreateInfo->SType = StructureType.IndirectCommandsLayoutCreateInfoNvx;
                marshalledCreateInfo->Next = null;
                marshalledCreateInfo->PipelineBindPoint = pipelineBindPoint;
                marshalledCreateInfo->Flags = flags;
                marshalledCreateInfo->TokenCount = (uint)(tokens?.Length ?? 0);
                if (tokens != null)
                {
                    var fieldPointer = (SharpVk.NVidia.Experimental.IndirectCommandsLayoutToken*)(Interop.HeapUtil.AllocateAndClear<SharpVk.NVidia.Experimental.IndirectCommandsLayoutToken>(tokens.Length).ToPointer());
                    for(int index = 0; index < (uint)(tokens.Length); index++)
                    {
                        fieldPointer[index] = tokens[index];
                    }
                    marshalledCreateInfo->Tokens = fieldPointer;
                }
                else
                {
                    marshalledCreateInfo->Tokens = null;
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
                SharpVk.Interop.NVidia.Experimental.VkDeviceCreateIndirectCommandsLayoutDelegate commandDelegate = commandCache.GetCommandDelegate<SharpVk.Interop.NVidia.Experimental.VkDeviceCreateIndirectCommandsLayoutDelegate>("vkCreateIndirectCommandsLayoutNVX", "instance");
                Result methodResult = commandDelegate(extendedHandle.handle, marshalledCreateInfo, marshalledAllocator, &marshalledIndirectCommandsLayout);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = new SharpVk.NVidia.Experimental.IndirectCommandsLayout(extendedHandle, marshalledIndirectCommandsLayout);
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
        /// <param name="objectEntryTypes">
        /// An array of ObjectEntryTypeNVX providing the entry type of a given
        /// configuration.
        /// </param>
        /// <param name="objectEntryCounts">
        /// An array of counts how many objects can be registered in the table.
        /// </param>
        /// <param name="objectEntryUsageFlags">
        /// An array of bitmasks describing the binding usage of the entry. See
        /// ObjectEntryUsageFlagBitsNVX below for a description of the
        /// supported bits.
        /// </param>
        /// <param name="maxUniformBuffersPerDescriptor">
        /// The maximum number of VK_DESCRIPTOR_TYPE_UNIFORM_BUFFER or
        /// VK_DESCRIPTOR_TYPE_UNIFORM_BUFFER_DYNAMIC used by any single
        /// registered DescriptorSet in this table.
        /// </param>
        /// <param name="maxStorageBuffersPerDescriptor">
        /// The maximum number of VK_DESCRIPTOR_TYPE_STORAGE_BUFFER or
        /// VK_DESCRIPTOR_TYPE_STORAGE_BUFFER_DYNAMIC used by any single
        /// registered DescriptorSet in this table.
        /// </param>
        /// <param name="maxStorageImagesPerDescriptor">
        /// The maximum number of VK_DESCRIPTOR_TYPE_STORAGE_IMAGE or
        /// VK_DESCRIPTOR_TYPE_STORAGE_TEXEL_BUFFER used by any single
        /// registered DescriptorSet in this table.
        /// </param>
        /// <param name="maxSampledImagesPerDescriptor">
        /// The maximum number of VK_DESCRIPTOR_TYPE_SAMPLER,
        /// VK_DESCRIPTOR_TYPE_COMBINED_IMAGE_SAMPLER, VK_DESCRIPTOR_TYPE_UNIFORM_TEXEL_BUFFER
        /// or VK_DESCRIPTOR_TYPE_INPUT_ATTACHMENT used by any single
        /// registered DescriptorSet in this table.
        /// </param>
        /// <param name="maxPipelineLayouts">
        /// The maximum number of unique PipelineLayout used by any registered
        /// DescriptorSet or Pipeline in this table.
        /// </param>
        public static unsafe SharpVk.NVidia.Experimental.ObjectTable CreateObjectTable(this SharpVk.Device extendedHandle, SharpVk.NVidia.Experimental.ObjectEntryType[] objectEntryTypes, uint[] objectEntryCounts, SharpVk.NVidia.Experimental.ObjectEntryUsageFlags[] objectEntryUsageFlags, uint maxUniformBuffersPerDescriptor, uint maxStorageBuffersPerDescriptor, uint maxStorageImagesPerDescriptor, uint maxSampledImagesPerDescriptor, uint maxPipelineLayouts, SharpVk.AllocationCallbacks? allocator = default(SharpVk.AllocationCallbacks?))
        {
            try
            {
                SharpVk.NVidia.Experimental.ObjectTable result = default(SharpVk.NVidia.Experimental.ObjectTable);
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.NVidia.Experimental.ObjectTableCreateInfo* marshalledCreateInfo = default(SharpVk.Interop.NVidia.Experimental.ObjectTableCreateInfo*);
                SharpVk.Interop.AllocationCallbacks* marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                SharpVk.Interop.NVidia.Experimental.ObjectTable marshalledObjectTable = default(SharpVk.Interop.NVidia.Experimental.ObjectTable);
                commandCache = extendedHandle.commandCache;
                marshalledCreateInfo = (SharpVk.Interop.NVidia.Experimental.ObjectTableCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.NVidia.Experimental.ObjectTableCreateInfo>());
                marshalledCreateInfo->SType = StructureType.ObjectTableCreateInfoNvx;
                marshalledCreateInfo->Next = null;
                marshalledCreateInfo->ObjectCount = (uint)(objectEntryTypes?.Length ?? 0);
                if (objectEntryTypes != null)
                {
                    var fieldPointer = (SharpVk.NVidia.Experimental.ObjectEntryType*)(Interop.HeapUtil.AllocateAndClear<SharpVk.NVidia.Experimental.ObjectEntryType>(objectEntryTypes.Length).ToPointer());
                    for(int index = 0; index < (uint)(objectEntryTypes.Length); index++)
                    {
                        fieldPointer[index] = objectEntryTypes[index];
                    }
                    marshalledCreateInfo->ObjectEntryTypes = fieldPointer;
                }
                else
                {
                    marshalledCreateInfo->ObjectEntryTypes = null;
                }
                if (objectEntryCounts != null)
                {
                    var fieldPointer = (uint*)(Interop.HeapUtil.AllocateAndClear<uint>(objectEntryCounts.Length).ToPointer());
                    for(int index = 0; index < (uint)(objectEntryCounts.Length); index++)
                    {
                        fieldPointer[index] = objectEntryCounts[index];
                    }
                    marshalledCreateInfo->ObjectEntryCounts = fieldPointer;
                }
                else
                {
                    marshalledCreateInfo->ObjectEntryCounts = null;
                }
                if (objectEntryUsageFlags != null)
                {
                    var fieldPointer = (SharpVk.NVidia.Experimental.ObjectEntryUsageFlags*)(Interop.HeapUtil.AllocateAndClear<SharpVk.NVidia.Experimental.ObjectEntryUsageFlags>(objectEntryUsageFlags.Length).ToPointer());
                    for(int index = 0; index < (uint)(objectEntryUsageFlags.Length); index++)
                    {
                        fieldPointer[index] = objectEntryUsageFlags[index];
                    }
                    marshalledCreateInfo->ObjectEntryUsageFlags = fieldPointer;
                }
                else
                {
                    marshalledCreateInfo->ObjectEntryUsageFlags = null;
                }
                marshalledCreateInfo->MaxUniformBuffersPerDescriptor = maxUniformBuffersPerDescriptor;
                marshalledCreateInfo->MaxStorageBuffersPerDescriptor = maxStorageBuffersPerDescriptor;
                marshalledCreateInfo->MaxStorageImagesPerDescriptor = maxStorageImagesPerDescriptor;
                marshalledCreateInfo->MaxSampledImagesPerDescriptor = maxSampledImagesPerDescriptor;
                marshalledCreateInfo->MaxPipelineLayouts = maxPipelineLayouts;
                if (allocator != null)
                {
                    marshalledAllocator = (SharpVk.Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<SharpVk.Interop.AllocationCallbacks>());
                    allocator.Value.MarshalTo(marshalledAllocator);
                }
                else
                {
                    marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                }
                SharpVk.Interop.NVidia.Experimental.VkDeviceCreateObjectTableDelegate commandDelegate = commandCache.GetCommandDelegate<SharpVk.Interop.NVidia.Experimental.VkDeviceCreateObjectTableDelegate>("vkCreateObjectTableNVX", "instance");
                Result methodResult = commandDelegate(extendedHandle.handle, marshalledCreateInfo, marshalledAllocator, &marshalledObjectTable);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = new SharpVk.NVidia.Experimental.ObjectTable(extendedHandle, marshalledObjectTable);
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
    }
}
