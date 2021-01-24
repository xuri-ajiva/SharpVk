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

namespace SharpVk.NVidia
{
    /// <summary>
    /// </summary>
    public static class DeviceExtensions
    {
        /// <summary>
        /// </summary>
        /// <param name="extendedHandle">
        /// The Device handle to extend.
        /// </param>
        /// <param name="compactedSize">
        /// </param>
        /// <param name="info">
        /// </param>
        /// <param name="allocator">
        /// </param>
        public static unsafe Khronos.AccelerationStructure CreateAccelerationStructure(this Device extendedHandle, ulong compactedSize, AccelerationStructureInfo info, AllocationCallbacks? allocator = default)
        {
            try
            {
                Khronos.AccelerationStructure result = default;
                CommandCache commandCache = default;
                SharpVk.Interop.NVidia.AccelerationStructureCreateInfo* marshalledCreateInfo = default;
                void* vkAccelerationStructureCreateInfoNVNextPointer = default;
                SharpVk.Interop.AllocationCallbacks* marshalledAllocator = default;
                SharpVk.Interop.Khronos.AccelerationStructure marshalledAccelerationStructure = default;
                commandCache = extendedHandle.commandCache;
                marshalledCreateInfo = (SharpVk.Interop.NVidia.AccelerationStructureCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.NVidia.AccelerationStructureCreateInfo>());
                marshalledCreateInfo->SType = StructureType.AccelerationStructureCreateInfoNv;
                marshalledCreateInfo->Next = vkAccelerationStructureCreateInfoNVNextPointer;
                marshalledCreateInfo->CompactedSize = compactedSize;
                info.MarshalTo(&marshalledCreateInfo->Info);
                if (allocator != null)
                {
                    marshalledAllocator = (SharpVk.Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<SharpVk.Interop.AllocationCallbacks>());
                    allocator.Value.MarshalTo(marshalledAllocator);
                }
                else
                {
                    marshalledAllocator = default;
                }
                SharpVk.Interop.NVidia.VkDeviceCreateAccelerationStructureDelegate commandDelegate = commandCache.Cache.vkCreateAccelerationStructureNV;
                Result methodResult = commandDelegate(extendedHandle.Handle, marshalledCreateInfo, marshalledAllocator, &marshalledAccelerationStructure);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = new Khronos.AccelerationStructure(extendedHandle, marshalledAccelerationStructure);
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// </summary>
        /// <param name="extendedHandle">
        /// The Device handle to extend.
        /// </param>
        /// <param name="info">
        /// </param>
        public static unsafe MemoryRequirements2 GetAccelerationStructureMemoryRequirements(this Device extendedHandle, AccelerationStructureMemoryRequirementsInfo info)
        {
            try
            {
                MemoryRequirements2 result = default;
                CommandCache commandCache = default;
                SharpVk.Interop.NVidia.AccelerationStructureMemoryRequirementsInfo* marshalledInfo = default;
                SharpVk.Interop.MemoryRequirements2 marshalledMemoryRequirements = default;
                commandCache = extendedHandle.commandCache;
                marshalledInfo = (SharpVk.Interop.NVidia.AccelerationStructureMemoryRequirementsInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.NVidia.AccelerationStructureMemoryRequirementsInfo>());
                info.MarshalTo(marshalledInfo);
                SharpVk.Interop.NVidia.VkDeviceGetAccelerationStructureMemoryRequirementsDelegate commandDelegate = commandCache.Cache.vkGetAccelerationStructureMemoryRequirementsNV;
                commandDelegate(extendedHandle.Handle, marshalledInfo, &marshalledMemoryRequirements);
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
        /// <param name="extendedHandle">
        /// The Device handle to extend.
        /// </param>
        /// <param name="pipelineCache">
        /// </param>
        /// <param name="createInfos">
        /// </param>
        /// <param name="allocator">
        /// </param>
        public static unsafe Pipeline[] CreateRayTracingPipelines(this Device extendedHandle, PipelineCache pipelineCache, ArrayProxy<RayTracingPipelineCreateInfo>? createInfos, AllocationCallbacks? allocator = default)
        {
            try
            {
                Pipeline[] result = default;
                CommandCache commandCache = default;
                uint marshalledCreateInfoCount = default;
                SharpVk.Interop.NVidia.RayTracingPipelineCreateInfo* marshalledCreateInfos = default;
                SharpVk.Interop.AllocationCallbacks* marshalledAllocator = default;
                SharpVk.Interop.Pipeline* marshalledPipelines = default;
                commandCache = extendedHandle.commandCache;
                marshalledCreateInfoCount = (uint)(Interop.HeapUtil.GetLength(createInfos));
                if (createInfos.IsNull())
                {
                    marshalledCreateInfos = null;
                }
                else
                {
                    if (createInfos.Value.Contents == ProxyContents.Single)
                    {
                        marshalledCreateInfos = (SharpVk.Interop.NVidia.RayTracingPipelineCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.NVidia.RayTracingPipelineCreateInfo>());
                        createInfos.Value.GetSingleValue().MarshalTo(&*(SharpVk.Interop.NVidia.RayTracingPipelineCreateInfo*)(marshalledCreateInfos));
                    }
                    else
                    {
                        var fieldPointer = (SharpVk.Interop.NVidia.RayTracingPipelineCreateInfo*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.NVidia.RayTracingPipelineCreateInfo>(Interop.HeapUtil.GetLength(createInfos.Value)).ToPointer());
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
                SharpVk.Interop.NVidia.VkDeviceCreateRayTracingPipelinesDelegate commandDelegate = commandCache.Cache.vkCreateRayTracingPipelinesNV;
                Result methodResult = commandDelegate(extendedHandle.Handle, pipelineCache?.Handle ?? default, marshalledCreateInfoCount, marshalledCreateInfos, marshalledAllocator, marshalledPipelines);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                if (marshalledPipelines != null)
                {
                    var fieldPointer = new Pipeline[(uint)(marshalledCreateInfoCount)];
                    for(int index = 0; index < (uint)(marshalledCreateInfoCount); index++)
                    {
                        fieldPointer[index] = new Pipeline(extendedHandle, marshalledPipelines[index]);
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
        /// <param name="extendedHandle">
        /// The Device handle to extend.
        /// </param>
        /// <param name="pipelineCache">
        /// </param>
        /// <param name="flags">
        /// </param>
        /// <param name="stages">
        /// </param>
        /// <param name="groups">
        /// </param>
        /// <param name="maxRecursionDepth">
        /// </param>
        /// <param name="layout">
        /// </param>
        /// <param name="basePipelineHandle">
        /// </param>
        /// <param name="basePipelineIndex">
        /// </param>
        /// <param name="pipelineCreationFeedbackCreateInfoExt">
        /// Extension struct
        /// </param>
        /// <param name="allocator">
        /// </param>
        public static unsafe Pipeline CreateRayTracingPipeline(this Device extendedHandle, PipelineCache pipelineCache, ArrayProxy<PipelineShaderStageCreateInfo>? stages, ArrayProxy<RayTracingShaderGroupCreateInfo>? groups, uint maxRecursionDepth, PipelineLayout layout, Pipeline basePipelineHandle, int basePipelineIndex, PipelineCreateFlags? flags = default, Multivendor.PipelineCreationFeedbackCreateInfo? pipelineCreationFeedbackCreateInfoExt = null, AllocationCallbacks? allocator = default)
        {
            try
            {
                Pipeline result = default;
                CommandCache commandCache = default;
                uint marshalledCreateInfoCount = default;
                SharpVk.Interop.NVidia.RayTracingPipelineCreateInfo* marshalledCreateInfos = default;
                void* vkRayTracingPipelineCreateInfoNVNextPointer = default;
                SharpVk.Interop.AllocationCallbacks* marshalledAllocator = default;
                SharpVk.Interop.Pipeline* marshalledPipelines = default;
                if (pipelineCreationFeedbackCreateInfoExt != null)
                {
                    SharpVk.Interop.Multivendor.PipelineCreationFeedbackCreateInfo* extensionPointer = default;
                    extensionPointer = (SharpVk.Interop.Multivendor.PipelineCreationFeedbackCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.PipelineCreationFeedbackCreateInfo>());
                    pipelineCreationFeedbackCreateInfoExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkRayTracingPipelineCreateInfoNVNextPointer;
                    vkRayTracingPipelineCreateInfoNVNextPointer = extensionPointer;
                }
                commandCache = extendedHandle.commandCache;
                marshalledCreateInfoCount = 1;
                marshalledCreateInfos = (SharpVk.Interop.NVidia.RayTracingPipelineCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.NVidia.RayTracingPipelineCreateInfo>());
                marshalledCreateInfos->SType = StructureType.RayTracingPipelineCreateInfoNv;
                marshalledCreateInfos->Next = vkRayTracingPipelineCreateInfoNVNextPointer;
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
                marshalledCreateInfos->GroupCount = (uint)(Interop.HeapUtil.GetLength(groups));
                if (groups.IsNull())
                {
                    marshalledCreateInfos->Groups = null;
                }
                else
                {
                    if (groups.Value.Contents == ProxyContents.Single)
                    {
                        marshalledCreateInfos->Groups = (SharpVk.Interop.NVidia.RayTracingShaderGroupCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.NVidia.RayTracingShaderGroupCreateInfo>());
                        groups.Value.GetSingleValue().MarshalTo(&*(SharpVk.Interop.NVidia.RayTracingShaderGroupCreateInfo*)(marshalledCreateInfos->Groups));
                    }
                    else
                    {
                        var fieldPointer = (SharpVk.Interop.NVidia.RayTracingShaderGroupCreateInfo*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.NVidia.RayTracingShaderGroupCreateInfo>(Interop.HeapUtil.GetLength(groups.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(groups.Value)); index++)
                        {
                            groups.Value[index].MarshalTo(&fieldPointer[index]);
                        }
                        marshalledCreateInfos->Groups = fieldPointer;
                    }
                }
                marshalledCreateInfos->MaxRecursionDepth = maxRecursionDepth;
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
                SharpVk.Interop.NVidia.VkDeviceCreateRayTracingPipelinesDelegate commandDelegate = commandCache.Cache.vkCreateRayTracingPipelinesNV;
                Result methodResult = commandDelegate(extendedHandle.Handle, pipelineCache?.Handle ?? default, marshalledCreateInfoCount, marshalledCreateInfos, marshalledAllocator, marshalledPipelines);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = new Pipeline(extendedHandle, *marshalledPipelines);
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// </summary>
        /// <param name="extendedHandle">
        /// The Device handle to extend.
        /// </param>
        /// <param name="info">
        /// </param>
        public static unsafe MemoryRequirements2 GetGeneratedCommandsMemoryRequirements(this Device extendedHandle, GeneratedCommandsMemoryRequirementsInfo info)
        {
            try
            {
                MemoryRequirements2 result = default;
                CommandCache commandCache = default;
                SharpVk.Interop.NVidia.GeneratedCommandsMemoryRequirementsInfo* marshalledInfo = default;
                SharpVk.Interop.MemoryRequirements2 marshalledMemoryRequirements = default;
                commandCache = extendedHandle.commandCache;
                marshalledInfo = (SharpVk.Interop.NVidia.GeneratedCommandsMemoryRequirementsInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.NVidia.GeneratedCommandsMemoryRequirementsInfo>());
                info.MarshalTo(marshalledInfo);
                SharpVk.Interop.NVidia.VkDeviceGetGeneratedCommandsMemoryRequirementsDelegate commandDelegate = commandCache.Cache.vkGetGeneratedCommandsMemoryRequirementsNV;
                commandDelegate(extendedHandle.Handle, marshalledInfo, &marshalledMemoryRequirements);
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
        /// <param name="extendedHandle">
        /// The Device handle to extend.
        /// </param>
        /// <param name="flags">
        /// </param>
        /// <param name="pipelineBindPoint">
        /// </param>
        /// <param name="tokens">
        /// </param>
        /// <param name="streamStrides">
        /// </param>
        /// <param name="allocator">
        /// </param>
        public static unsafe IndirectCommandsLayout CreateIndirectCommandsLayout(this Device extendedHandle, IndirectCommandsLayoutUsageFlags flags, PipelineBindPoint pipelineBindPoint, ArrayProxy<IndirectCommandsLayoutToken>? tokens, ArrayProxy<uint>? streamStrides, AllocationCallbacks? allocator = default)
        {
            try
            {
                IndirectCommandsLayout result = default;
                CommandCache commandCache = default;
                SharpVk.Interop.NVidia.IndirectCommandsLayoutCreateInfo* marshalledCreateInfo = default;
                void* vkIndirectCommandsLayoutCreateInfoNVNextPointer = default;
                SharpVk.Interop.AllocationCallbacks* marshalledAllocator = default;
                SharpVk.Interop.NVidia.IndirectCommandsLayout marshalledIndirectCommandsLayout = default;
                commandCache = extendedHandle.commandCache;
                marshalledCreateInfo = (SharpVk.Interop.NVidia.IndirectCommandsLayoutCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.NVidia.IndirectCommandsLayoutCreateInfo>());
                marshalledCreateInfo->SType = StructureType.IndirectCommandsLayoutCreateInfo;
                marshalledCreateInfo->Next = vkIndirectCommandsLayoutCreateInfoNVNextPointer;
                marshalledCreateInfo->Flags = flags;
                marshalledCreateInfo->PipelineBindPoint = pipelineBindPoint;
                marshalledCreateInfo->TokenCount = (uint)(Interop.HeapUtil.GetLength(tokens));
                if (tokens.IsNull())
                {
                    marshalledCreateInfo->Tokens = null;
                }
                else
                {
                    if (tokens.Value.Contents == ProxyContents.Single)
                    {
                        marshalledCreateInfo->Tokens = (SharpVk.Interop.NVidia.IndirectCommandsLayoutToken*)(Interop.HeapUtil.Allocate<SharpVk.Interop.NVidia.IndirectCommandsLayoutToken>());
                        tokens.Value.GetSingleValue().MarshalTo(&*(SharpVk.Interop.NVidia.IndirectCommandsLayoutToken*)(marshalledCreateInfo->Tokens));
                    }
                    else
                    {
                        var fieldPointer = (SharpVk.Interop.NVidia.IndirectCommandsLayoutToken*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.NVidia.IndirectCommandsLayoutToken>(Interop.HeapUtil.GetLength(tokens.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(tokens.Value)); index++)
                        {
                            tokens.Value[index].MarshalTo(&fieldPointer[index]);
                        }
                        marshalledCreateInfo->Tokens = fieldPointer;
                    }
                }
                marshalledCreateInfo->StreamCount = (uint)(Interop.HeapUtil.GetLength(streamStrides));
                if (streamStrides.IsNull())
                {
                    marshalledCreateInfo->StreamStrides = null;
                }
                else
                {
                    if (streamStrides.Value.Contents == ProxyContents.Single)
                    {
                        marshalledCreateInfo->StreamStrides = (uint*)(Interop.HeapUtil.Allocate<uint>());
                        *(uint*)(marshalledCreateInfo->StreamStrides) = streamStrides.Value.GetSingleValue();
                    }
                    else
                    {
                        var fieldPointer = (uint*)(Interop.HeapUtil.AllocateAndClear<uint>(Interop.HeapUtil.GetLength(streamStrides.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(streamStrides.Value)); index++)
                        {
                            fieldPointer[index] = streamStrides.Value[index];
                        }
                        marshalledCreateInfo->StreamStrides = fieldPointer;
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
                SharpVk.Interop.NVidia.VkDeviceCreateIndirectCommandsLayoutDelegate commandDelegate = commandCache.Cache.vkCreateIndirectCommandsLayoutNV;
                Result methodResult = commandDelegate(extendedHandle.Handle, marshalledCreateInfo, marshalledAllocator, &marshalledIndirectCommandsLayout);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = new IndirectCommandsLayout(extendedHandle, marshalledIndirectCommandsLayout);
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
    }
}
