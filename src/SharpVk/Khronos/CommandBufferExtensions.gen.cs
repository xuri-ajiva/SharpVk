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

namespace SharpVk.Khronos
{
    /// <summary>
    /// </summary>
    public static class CommandBufferExtensions
    {
        /// <summary>
        /// Pushes descriptor updates into a command buffer.
        /// </summary>
        /// <param name="extendedHandle">
        /// The CommandBuffer handle to extend.
        /// </param>
        /// <param name="pipelineBindPoint">
        /// </param>
        /// <param name="layout">
        /// </param>
        /// <param name="set">
        /// </param>
        /// <param name="descriptorWrites">
        /// </param>
        public static unsafe void PushDescriptorSet(this CommandBuffer extendedHandle, PipelineBindPoint pipelineBindPoint, PipelineLayout layout, uint set, ArrayProxy<WriteDescriptorSet>? descriptorWrites)
        {
            try
            {
                CommandCache commandCache = default;
                SharpVk.Interop.WriteDescriptorSet* marshalledDescriptorWrites = default;
                commandCache = extendedHandle.commandCache;
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
                SharpVk.Interop.Khronos.VkCommandBufferPushDescriptorSetDelegate commandDelegate = commandCache.Cache.vkCmdPushDescriptorSetKHR;
                commandDelegate(extendedHandle.Handle, pipelineBindPoint, layout?.Handle ?? default, set, (uint)(Interop.HeapUtil.GetLength(descriptorWrites)), marshalledDescriptorWrites);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Pushes descriptor updates into a command buffer using a descriptor
        /// update template.
        /// </summary>
        /// <param name="extendedHandle">
        /// The CommandBuffer handle to extend.
        /// </param>
        /// <param name="descriptorUpdateTemplate">
        /// </param>
        /// <param name="layout">
        /// </param>
        /// <param name="set">
        /// </param>
        /// <param name="data">
        /// </param>
        public static unsafe void PushDescriptorSetWithTemplate(this CommandBuffer extendedHandle, DescriptorUpdateTemplate descriptorUpdateTemplate, PipelineLayout layout, uint set, IntPtr data)
        {
            try
            {
                CommandCache commandCache = default;
                commandCache = extendedHandle.commandCache;
                SharpVk.Interop.Khronos.VkCommandBufferPushDescriptorSetWithTemplateDelegate commandDelegate = commandCache.Cache.vkCmdPushDescriptorSetWithTemplateKHR;
                commandDelegate(extendedHandle.Handle, descriptorUpdateTemplate?.Handle ?? default, layout?.Handle ?? default, set, data.ToPointer());
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// </summary>
        /// <param name="extendedHandle">
        /// The CommandBuffer handle to extend.
        /// </param>
        /// <param name="infos">
        /// </param>
        /// <param name="offsetInfos">
        /// </param>
        public static unsafe void BuildAccelerationStructure(this CommandBuffer extendedHandle, ArrayProxy<AccelerationStructureBuildGeometryInfo>? infos, ArrayProxy<AccelerationStructureBuildOffsetInfo>? offsetInfos)
        {
            try
            {
                CommandCache commandCache = default;
                SharpVk.Interop.Khronos.AccelerationStructureBuildGeometryInfo* marshalledInfos = default;
                AccelerationStructureBuildOffsetInfo** marshalledOffsetInfos = default;
                AccelerationStructureBuildOffsetInfo* semiMarshalledOffsetInfos = default;
                commandCache = extendedHandle.commandCache;
                if (infos.IsNull())
                {
                    marshalledInfos = null;
                }
                else
                {
                    if (infos.Value.Contents == ProxyContents.Single)
                    {
                        marshalledInfos = (SharpVk.Interop.Khronos.AccelerationStructureBuildGeometryInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.AccelerationStructureBuildGeometryInfo>());
                        infos.Value.GetSingleValue().MarshalTo(&*(SharpVk.Interop.Khronos.AccelerationStructureBuildGeometryInfo*)(marshalledInfos));
                    }
                    else
                    {
                        var fieldPointer = (SharpVk.Interop.Khronos.AccelerationStructureBuildGeometryInfo*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.Khronos.AccelerationStructureBuildGeometryInfo>(Interop.HeapUtil.GetLength(infos.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(infos.Value)); index++)
                        {
                            infos.Value[index].MarshalTo(&fieldPointer[index]);
                        }
                        marshalledInfos = fieldPointer;
                    }
                }
                if (offsetInfos.IsNull())
                {
                    marshalledOffsetInfos = null;
                }
                else
                {
                    if (offsetInfos.Value.Contents == ProxyContents.Single)
                    {
                        semiMarshalledOffsetInfos = (AccelerationStructureBuildOffsetInfo*)(Interop.HeapUtil.Allocate<AccelerationStructureBuildOffsetInfo>());
                        *(AccelerationStructureBuildOffsetInfo*)(semiMarshalledOffsetInfos) = offsetInfos.Value.GetSingleValue();
                    }
                    else
                    {
                        var fieldPointer = (AccelerationStructureBuildOffsetInfo*)(Interop.HeapUtil.AllocateAndClear<AccelerationStructureBuildOffsetInfo>(Interop.HeapUtil.GetLength(offsetInfos.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(offsetInfos.Value)); index++)
                        {
                            fieldPointer[index] = offsetInfos.Value[index];
                        }
                        semiMarshalledOffsetInfos = fieldPointer;
                        var marshalledFieldPointer = (AccelerationStructureBuildOffsetInfo**)(Interop.HeapUtil.AllocateAndClear<IntPtr>(Interop.HeapUtil.GetLength(offsetInfos.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(offsetInfos.Value)); index++)
                        {
                            marshalledFieldPointer[index] = &semiMarshalledOffsetInfos[index];
                        }
                        marshalledOffsetInfos = marshalledFieldPointer;
                    }
                }
                SharpVk.Interop.Khronos.VkCommandBufferBuildAccelerationStructureDelegate commandDelegate = commandCache.Cache.vkCmdBuildAccelerationStructureKHR;
                commandDelegate(extendedHandle.Handle, (uint)(Interop.HeapUtil.GetLength(infos)), marshalledInfos, marshalledOffsetInfos);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// </summary>
        /// <param name="extendedHandle">
        /// The CommandBuffer handle to extend.
        /// </param>
        /// <param name="info">
        /// </param>
        /// <param name="indirectBuffer">
        /// </param>
        /// <param name="indirectOffset">
        /// </param>
        /// <param name="indirectStride">
        /// </param>
        public static unsafe void BuildAccelerationStructureIndirect(this CommandBuffer extendedHandle, AccelerationStructureBuildGeometryInfo info, Buffer indirectBuffer, ulong indirectOffset, uint indirectStride)
        {
            try
            {
                CommandCache commandCache = default;
                SharpVk.Interop.Khronos.AccelerationStructureBuildGeometryInfo* marshalledInfo = default;
                commandCache = extendedHandle.commandCache;
                marshalledInfo = (SharpVk.Interop.Khronos.AccelerationStructureBuildGeometryInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.AccelerationStructureBuildGeometryInfo>());
                info.MarshalTo(marshalledInfo);
                SharpVk.Interop.Khronos.VkCommandBufferBuildAccelerationStructureIndirectDelegate commandDelegate = commandCache.Cache.vkCmdBuildAccelerationStructureIndirectKHR;
                commandDelegate(extendedHandle.Handle, marshalledInfo, indirectBuffer?.Handle ?? default, indirectOffset, indirectStride);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// </summary>
        /// <param name="extendedHandle">
        /// The CommandBuffer handle to extend.
        /// </param>
        /// <param name="info">
        /// </param>
        public static unsafe void CopyAccelerationStructure(this CommandBuffer extendedHandle, CopyAccelerationStructureInfo info)
        {
            try
            {
                CommandCache commandCache = default;
                SharpVk.Interop.Khronos.CopyAccelerationStructureInfo* marshalledInfo = default;
                commandCache = extendedHandle.commandCache;
                marshalledInfo = (SharpVk.Interop.Khronos.CopyAccelerationStructureInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.CopyAccelerationStructureInfo>());
                info.MarshalTo(marshalledInfo);
                SharpVk.Interop.Khronos.VkCommandBufferCopyAccelerationStructureDelegate commandDelegate = commandCache.Cache.vkCmdCopyAccelerationStructureKHR;
                commandDelegate(extendedHandle.Handle, marshalledInfo);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// </summary>
        /// <param name="extendedHandle">
        /// The CommandBuffer handle to extend.
        /// </param>
        /// <param name="info">
        /// </param>
        public static unsafe void CopyAccelerationStructureToMemory(this CommandBuffer extendedHandle, CopyAccelerationStructureToMemoryInfo info)
        {
            try
            {
                CommandCache commandCache = default;
                SharpVk.Interop.Khronos.CopyAccelerationStructureToMemoryInfo* marshalledInfo = default;
                commandCache = extendedHandle.commandCache;
                marshalledInfo = (SharpVk.Interop.Khronos.CopyAccelerationStructureToMemoryInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.CopyAccelerationStructureToMemoryInfo>());
                info.MarshalTo(marshalledInfo);
                SharpVk.Interop.Khronos.VkCommandBufferCopyAccelerationStructureToMemoryDelegate commandDelegate = commandCache.Cache.vkCmdCopyAccelerationStructureToMemoryKHR;
                commandDelegate(extendedHandle.Handle, marshalledInfo);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// </summary>
        /// <param name="extendedHandle">
        /// The CommandBuffer handle to extend.
        /// </param>
        /// <param name="info">
        /// </param>
        public static unsafe void CopyMemoryToAccelerationStructure(this CommandBuffer extendedHandle, CopyMemoryToAccelerationStructureInfo info)
        {
            try
            {
                CommandCache commandCache = default;
                SharpVk.Interop.Khronos.CopyMemoryToAccelerationStructureInfo* marshalledInfo = default;
                commandCache = extendedHandle.commandCache;
                marshalledInfo = (SharpVk.Interop.Khronos.CopyMemoryToAccelerationStructureInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.CopyMemoryToAccelerationStructureInfo>());
                info.MarshalTo(marshalledInfo);
                SharpVk.Interop.Khronos.VkCommandBufferCopyMemoryToAccelerationStructureDelegate commandDelegate = commandCache.Cache.vkCmdCopyMemoryToAccelerationStructureKHR;
                commandDelegate(extendedHandle.Handle, marshalledInfo);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// </summary>
        /// <param name="extendedHandle">
        /// The CommandBuffer handle to extend.
        /// </param>
        /// <param name="raygenShaderBindingTable">
        /// </param>
        /// <param name="missShaderBindingTable">
        /// </param>
        /// <param name="hitShaderBindingTable">
        /// </param>
        /// <param name="callableShaderBindingTable">
        /// </param>
        /// <param name="width">
        /// </param>
        /// <param name="height">
        /// </param>
        /// <param name="depth">
        /// </param>
        public static unsafe void TraceRays(this CommandBuffer extendedHandle, StridedBufferRegion raygenShaderBindingTable, StridedBufferRegion missShaderBindingTable, StridedBufferRegion hitShaderBindingTable, StridedBufferRegion callableShaderBindingTable, uint width, uint height, uint depth)
        {
            try
            {
                CommandCache commandCache = default;
                SharpVk.Interop.Khronos.StridedBufferRegion* marshalledRaygenShaderBindingTable = default;
                SharpVk.Interop.Khronos.StridedBufferRegion* marshalledMissShaderBindingTable = default;
                SharpVk.Interop.Khronos.StridedBufferRegion* marshalledHitShaderBindingTable = default;
                SharpVk.Interop.Khronos.StridedBufferRegion* marshalledCallableShaderBindingTable = default;
                commandCache = extendedHandle.commandCache;
                marshalledRaygenShaderBindingTable = (SharpVk.Interop.Khronos.StridedBufferRegion*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.StridedBufferRegion>());
                raygenShaderBindingTable.MarshalTo(marshalledRaygenShaderBindingTable);
                marshalledMissShaderBindingTable = (SharpVk.Interop.Khronos.StridedBufferRegion*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.StridedBufferRegion>());
                missShaderBindingTable.MarshalTo(marshalledMissShaderBindingTable);
                marshalledHitShaderBindingTable = (SharpVk.Interop.Khronos.StridedBufferRegion*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.StridedBufferRegion>());
                hitShaderBindingTable.MarshalTo(marshalledHitShaderBindingTable);
                marshalledCallableShaderBindingTable = (SharpVk.Interop.Khronos.StridedBufferRegion*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.StridedBufferRegion>());
                callableShaderBindingTable.MarshalTo(marshalledCallableShaderBindingTable);
                SharpVk.Interop.Khronos.VkCommandBufferTraceRaysDelegate commandDelegate = commandCache.Cache.vkCmdTraceRaysKHR;
                commandDelegate(extendedHandle.Handle, marshalledRaygenShaderBindingTable, marshalledMissShaderBindingTable, marshalledHitShaderBindingTable, marshalledCallableShaderBindingTable, width, height, depth);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// </summary>
        /// <param name="extendedHandle">
        /// The CommandBuffer handle to extend.
        /// </param>
        /// <param name="accelerationStructures">
        /// </param>
        /// <param name="queryType">
        /// </param>
        /// <param name="queryPool">
        /// </param>
        /// <param name="firstQuery">
        /// </param>
        public static unsafe void WriteAccelerationStructuresProperties(this CommandBuffer extendedHandle, ArrayProxy<AccelerationStructure>? accelerationStructures, QueryType queryType, QueryPool queryPool, uint firstQuery)
        {
            try
            {
                CommandCache commandCache = default;
                SharpVk.Interop.Khronos.AccelerationStructure* marshalledAccelerationStructures = default;
                commandCache = extendedHandle.commandCache;
                if (accelerationStructures.IsNull())
                {
                    marshalledAccelerationStructures = null;
                }
                else
                {
                    if (accelerationStructures.Value.Contents == ProxyContents.Single)
                    {
                        marshalledAccelerationStructures = (SharpVk.Interop.Khronos.AccelerationStructure*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.AccelerationStructure>());
                        *(SharpVk.Interop.Khronos.AccelerationStructure*)(marshalledAccelerationStructures) = accelerationStructures.Value.GetSingleValue()?.Handle ?? default;
                    }
                    else
                    {
                        var fieldPointer = (SharpVk.Interop.Khronos.AccelerationStructure*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.Khronos.AccelerationStructure>(Interop.HeapUtil.GetLength(accelerationStructures.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(accelerationStructures.Value)); index++)
                        {
                            fieldPointer[index] = accelerationStructures.Value[index]?.Handle ?? default;
                        }
                        marshalledAccelerationStructures = fieldPointer;
                    }
                }
                SharpVk.Interop.Khronos.VkCommandBufferWriteAccelerationStructuresPropertiesDelegate commandDelegate = commandCache.Cache.vkCmdWriteAccelerationStructuresPropertiesKHR;
                commandDelegate(extendedHandle.Handle, (uint)(Interop.HeapUtil.GetLength(accelerationStructures)), marshalledAccelerationStructures, queryType, queryPool?.Handle ?? default, firstQuery);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// </summary>
        /// <param name="extendedHandle">
        /// The CommandBuffer handle to extend.
        /// </param>
        /// <param name="raygenShaderBindingTable">
        /// </param>
        /// <param name="missShaderBindingTable">
        /// </param>
        /// <param name="hitShaderBindingTable">
        /// </param>
        /// <param name="callableShaderBindingTable">
        /// </param>
        /// <param name="buffer">
        /// </param>
        /// <param name="offset">
        /// </param>
        public static unsafe void TraceRaysIndirect(this CommandBuffer extendedHandle, StridedBufferRegion raygenShaderBindingTable, StridedBufferRegion missShaderBindingTable, StridedBufferRegion hitShaderBindingTable, StridedBufferRegion callableShaderBindingTable, Buffer buffer, ulong offset)
        {
            try
            {
                CommandCache commandCache = default;
                SharpVk.Interop.Khronos.StridedBufferRegion* marshalledRaygenShaderBindingTable = default;
                SharpVk.Interop.Khronos.StridedBufferRegion* marshalledMissShaderBindingTable = default;
                SharpVk.Interop.Khronos.StridedBufferRegion* marshalledHitShaderBindingTable = default;
                SharpVk.Interop.Khronos.StridedBufferRegion* marshalledCallableShaderBindingTable = default;
                commandCache = extendedHandle.commandCache;
                marshalledRaygenShaderBindingTable = (SharpVk.Interop.Khronos.StridedBufferRegion*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.StridedBufferRegion>());
                raygenShaderBindingTable.MarshalTo(marshalledRaygenShaderBindingTable);
                marshalledMissShaderBindingTable = (SharpVk.Interop.Khronos.StridedBufferRegion*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.StridedBufferRegion>());
                missShaderBindingTable.MarshalTo(marshalledMissShaderBindingTable);
                marshalledHitShaderBindingTable = (SharpVk.Interop.Khronos.StridedBufferRegion*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.StridedBufferRegion>());
                hitShaderBindingTable.MarshalTo(marshalledHitShaderBindingTable);
                marshalledCallableShaderBindingTable = (SharpVk.Interop.Khronos.StridedBufferRegion*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.StridedBufferRegion>());
                callableShaderBindingTable.MarshalTo(marshalledCallableShaderBindingTable);
                SharpVk.Interop.Khronos.VkCommandBufferTraceRaysIndirectDelegate commandDelegate = commandCache.Cache.vkCmdTraceRaysIndirectKHR;
                commandDelegate(extendedHandle.Handle, marshalledRaygenShaderBindingTable, marshalledMissShaderBindingTable, marshalledHitShaderBindingTable, marshalledCallableShaderBindingTable, buffer?.Handle ?? default, offset);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
    }
}
