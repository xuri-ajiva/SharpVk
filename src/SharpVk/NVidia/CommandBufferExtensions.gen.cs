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

namespace SharpVk.NVidia
{
    /// <summary>
    /// </summary>
    public static class CommandBufferExtensions
    {
        /// <summary>
        /// Set the viewport W scaling on a command buffer.
        /// </summary>
        /// <param name="extendedHandle">
        /// The CommandBuffer handle to extend.
        /// </param>
        /// <param name="firstViewport">
        /// </param>
        /// <param name="viewportWScalings">
        /// </param>
        public static unsafe void SetViewportWScaling(this CommandBuffer extendedHandle, uint firstViewport, ArrayProxy<ViewportWScaling>? viewportWScalings)
        {
            try
            {
                CommandCache commandCache = default;
                ViewportWScaling* marshalledViewportWScalings = default;
                commandCache = extendedHandle.commandCache;
                if (viewportWScalings.IsNull())
                {
                    marshalledViewportWScalings = null;
                }
                else
                {
                    if (viewportWScalings.Value.Contents == ProxyContents.Single)
                    {
                        marshalledViewportWScalings = (ViewportWScaling*)(Interop.HeapUtil.Allocate<ViewportWScaling>());
                        *(ViewportWScaling*)(marshalledViewportWScalings) = viewportWScalings.Value.GetSingleValue();
                    }
                    else
                    {
                        var fieldPointer = (ViewportWScaling*)(Interop.HeapUtil.AllocateAndClear<ViewportWScaling>(Interop.HeapUtil.GetLength(viewportWScalings.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(viewportWScalings.Value)); index++)
                        {
                            fieldPointer[index] = viewportWScalings.Value[index];
                        }
                        marshalledViewportWScalings = fieldPointer;
                    }
                }
                SharpVk.Interop.NVidia.VkCommandBufferSetViewportWScalingDelegate commandDelegate = commandCache.Cache.vkCmdSetViewportWScalingNV;
                commandDelegate(extendedHandle.Handle, firstViewport, (uint)(Interop.HeapUtil.GetLength(viewportWScalings)), marshalledViewportWScalings);
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
        /// <param name="imageView">
        /// </param>
        /// <param name="imageLayout">
        /// </param>
        public static unsafe void BindShadingRateImage(this CommandBuffer extendedHandle, ImageView imageView, ImageLayout imageLayout)
        {
            try
            {
                CommandCache commandCache = default;
                commandCache = extendedHandle.commandCache;
                SharpVk.Interop.NVidia.VkCommandBufferBindShadingRateImageDelegate commandDelegate = commandCache.Cache.vkCmdBindShadingRateImageNV;
                commandDelegate(extendedHandle.Handle, imageView?.Handle ?? default, imageLayout);
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
        /// <param name="firstViewport">
        /// </param>
        /// <param name="shadingRatePalettes">
        /// </param>
        public static unsafe void SetViewportShadingRatePalette(this CommandBuffer extendedHandle, uint firstViewport, ArrayProxy<ShadingRatePalette>? shadingRatePalettes)
        {
            try
            {
                CommandCache commandCache = default;
                SharpVk.Interop.NVidia.ShadingRatePalette* marshalledShadingRatePalettes = default;
                commandCache = extendedHandle.commandCache;
                if (shadingRatePalettes.IsNull())
                {
                    marshalledShadingRatePalettes = null;
                }
                else
                {
                    if (shadingRatePalettes.Value.Contents == ProxyContents.Single)
                    {
                        marshalledShadingRatePalettes = (SharpVk.Interop.NVidia.ShadingRatePalette*)(Interop.HeapUtil.Allocate<SharpVk.Interop.NVidia.ShadingRatePalette>());
                        shadingRatePalettes.Value.GetSingleValue().MarshalTo(&*(SharpVk.Interop.NVidia.ShadingRatePalette*)(marshalledShadingRatePalettes));
                    }
                    else
                    {
                        var fieldPointer = (SharpVk.Interop.NVidia.ShadingRatePalette*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.NVidia.ShadingRatePalette>(Interop.HeapUtil.GetLength(shadingRatePalettes.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(shadingRatePalettes.Value)); index++)
                        {
                            shadingRatePalettes.Value[index].MarshalTo(&fieldPointer[index]);
                        }
                        marshalledShadingRatePalettes = fieldPointer;
                    }
                }
                SharpVk.Interop.NVidia.VkCommandBufferSetViewportShadingRatePaletteDelegate commandDelegate = commandCache.Cache.vkCmdSetViewportShadingRatePaletteNV;
                commandDelegate(extendedHandle.Handle, firstViewport, (uint)(Interop.HeapUtil.GetLength(shadingRatePalettes)), marshalledShadingRatePalettes);
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
        /// <param name="sampleOrderType">
        /// </param>
        /// <param name="customSampleOrders">
        /// </param>
        public static unsafe void SetCoarseSampleOrder(this CommandBuffer extendedHandle, CoarseSampleOrderType sampleOrderType, ArrayProxy<CoarseSampleOrderCustom>? customSampleOrders)
        {
            try
            {
                CommandCache commandCache = default;
                SharpVk.Interop.NVidia.CoarseSampleOrderCustom* marshalledCustomSampleOrders = default;
                commandCache = extendedHandle.commandCache;
                if (customSampleOrders.IsNull())
                {
                    marshalledCustomSampleOrders = null;
                }
                else
                {
                    if (customSampleOrders.Value.Contents == ProxyContents.Single)
                    {
                        marshalledCustomSampleOrders = (SharpVk.Interop.NVidia.CoarseSampleOrderCustom*)(Interop.HeapUtil.Allocate<SharpVk.Interop.NVidia.CoarseSampleOrderCustom>());
                        customSampleOrders.Value.GetSingleValue().MarshalTo(&*(SharpVk.Interop.NVidia.CoarseSampleOrderCustom*)(marshalledCustomSampleOrders));
                    }
                    else
                    {
                        var fieldPointer = (SharpVk.Interop.NVidia.CoarseSampleOrderCustom*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.NVidia.CoarseSampleOrderCustom>(Interop.HeapUtil.GetLength(customSampleOrders.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(customSampleOrders.Value)); index++)
                        {
                            customSampleOrders.Value[index].MarshalTo(&fieldPointer[index]);
                        }
                        marshalledCustomSampleOrders = fieldPointer;
                    }
                }
                SharpVk.Interop.NVidia.VkCommandBufferSetCoarseSampleOrderDelegate commandDelegate = commandCache.Cache.vkCmdSetCoarseSampleOrderNV;
                commandDelegate(extendedHandle.Handle, sampleOrderType, (uint)(Interop.HeapUtil.GetLength(customSampleOrders)), marshalledCustomSampleOrders);
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
        /// <param name="instanceData">
        /// </param>
        /// <param name="instanceOffset">
        /// </param>
        /// <param name="update">
        /// </param>
        /// <param name="destination">
        /// </param>
        /// <param name="source">
        /// </param>
        /// <param name="scratch">
        /// </param>
        /// <param name="scratchOffset">
        /// </param>
        public static unsafe void BuildAccelerationStructure(this CommandBuffer extendedHandle, AccelerationStructureInfo info, Buffer instanceData, ulong instanceOffset, bool update, Khronos.AccelerationStructure destination, Khronos.AccelerationStructure source, Buffer scratch, ulong scratchOffset)
        {
            try
            {
                CommandCache commandCache = default;
                SharpVk.Interop.NVidia.AccelerationStructureInfo* marshalledInfo = default;
                commandCache = extendedHandle.commandCache;
                marshalledInfo = (SharpVk.Interop.NVidia.AccelerationStructureInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.NVidia.AccelerationStructureInfo>());
                info.MarshalTo(marshalledInfo);
                SharpVk.Interop.NVidia.VkCommandBufferBuildAccelerationStructureDelegate commandDelegate = commandCache.Cache.vkCmdBuildAccelerationStructureNV;
                commandDelegate(extendedHandle.Handle, marshalledInfo, instanceData?.Handle ?? default, instanceOffset, update, destination?.Handle ?? default, source?.Handle ?? default, scratch?.Handle ?? default, scratchOffset);
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
        /// <param name="destination">
        /// </param>
        /// <param name="source">
        /// </param>
        /// <param name="mode">
        /// </param>
        public static unsafe void CopyAccelerationStructure(this CommandBuffer extendedHandle, Khronos.AccelerationStructure destination, Khronos.AccelerationStructure source, Khronos.CopyAccelerationStructureMode mode)
        {
            try
            {
                CommandCache commandCache = default;
                commandCache = extendedHandle.commandCache;
                SharpVk.Interop.NVidia.VkCommandBufferCopyAccelerationStructureDelegate commandDelegate = commandCache.Cache.vkCmdCopyAccelerationStructureNV;
                commandDelegate(extendedHandle.Handle, destination?.Handle ?? default, source?.Handle ?? default, mode);
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
        /// <param name="raygenShaderBindingTableBuffer">
        /// </param>
        /// <param name="raygenShaderBindingOffset">
        /// </param>
        /// <param name="missShaderBindingTableBuffer">
        /// </param>
        /// <param name="missShaderBindingOffset">
        /// </param>
        /// <param name="missShaderBindingStride">
        /// </param>
        /// <param name="hitShaderBindingTableBuffer">
        /// </param>
        /// <param name="hitShaderBindingOffset">
        /// </param>
        /// <param name="hitShaderBindingStride">
        /// </param>
        /// <param name="callableShaderBindingTableBuffer">
        /// </param>
        /// <param name="callableShaderBindingOffset">
        /// </param>
        /// <param name="callableShaderBindingStride">
        /// </param>
        /// <param name="width">
        /// </param>
        /// <param name="height">
        /// </param>
        /// <param name="depth">
        /// </param>
        public static unsafe void TraceRays(this CommandBuffer extendedHandle, Buffer raygenShaderBindingTableBuffer, ulong raygenShaderBindingOffset, Buffer missShaderBindingTableBuffer, ulong missShaderBindingOffset, ulong missShaderBindingStride, Buffer hitShaderBindingTableBuffer, ulong hitShaderBindingOffset, ulong hitShaderBindingStride, Buffer callableShaderBindingTableBuffer, ulong callableShaderBindingOffset, ulong callableShaderBindingStride, uint width, uint height, uint depth)
        {
            try
            {
                CommandCache commandCache = default;
                commandCache = extendedHandle.commandCache;
                SharpVk.Interop.NVidia.VkCommandBufferTraceRaysDelegate commandDelegate = commandCache.Cache.vkCmdTraceRaysNV;
                commandDelegate(extendedHandle.Handle, raygenShaderBindingTableBuffer?.Handle ?? default, raygenShaderBindingOffset, missShaderBindingTableBuffer?.Handle ?? default, missShaderBindingOffset, missShaderBindingStride, hitShaderBindingTableBuffer?.Handle ?? default, hitShaderBindingOffset, hitShaderBindingStride, callableShaderBindingTableBuffer?.Handle ?? default, callableShaderBindingOffset, callableShaderBindingStride, width, height, depth);
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
        /// <param name="taskCount">
        /// </param>
        /// <param name="firstTask">
        /// </param>
        public static unsafe void DrawMeshTasks(this CommandBuffer extendedHandle, uint taskCount, uint firstTask)
        {
            try
            {
                CommandCache commandCache = default;
                commandCache = extendedHandle.commandCache;
                SharpVk.Interop.NVidia.VkCommandBufferDrawMeshTasksDelegate commandDelegate = commandCache.Cache.vkCmdDrawMeshTasksNV;
                commandDelegate(extendedHandle.Handle, taskCount, firstTask);
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
        /// <param name="buffer">
        /// </param>
        /// <param name="offset">
        /// </param>
        /// <param name="drawCount">
        /// </param>
        /// <param name="stride">
        /// </param>
        public static unsafe void DrawMeshTasksIndirect(this CommandBuffer extendedHandle, Buffer buffer, ulong offset, uint drawCount, uint stride)
        {
            try
            {
                CommandCache commandCache = default;
                commandCache = extendedHandle.commandCache;
                SharpVk.Interop.NVidia.VkCommandBufferDrawMeshTasksIndirectDelegate commandDelegate = commandCache.Cache.vkCmdDrawMeshTasksIndirectNV;
                commandDelegate(extendedHandle.Handle, buffer?.Handle ?? default, offset, drawCount, stride);
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
        /// <param name="buffer">
        /// </param>
        /// <param name="offset">
        /// </param>
        /// <param name="countBuffer">
        /// </param>
        /// <param name="countBufferOffset">
        /// </param>
        /// <param name="maxDrawCount">
        /// </param>
        /// <param name="stride">
        /// </param>
        public static unsafe void DrawMeshTasksIndirectCount(this CommandBuffer extendedHandle, Buffer buffer, ulong offset, Buffer countBuffer, ulong countBufferOffset, uint maxDrawCount, uint stride)
        {
            try
            {
                CommandCache commandCache = default;
                commandCache = extendedHandle.commandCache;
                SharpVk.Interop.NVidia.VkCommandBufferDrawMeshTasksIndirectCountDelegate commandDelegate = commandCache.Cache.vkCmdDrawMeshTasksIndirectCountNV;
                commandDelegate(extendedHandle.Handle, buffer?.Handle ?? default, offset, countBuffer?.Handle ?? default, countBufferOffset, maxDrawCount, stride);
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
        /// <param name="firstExclusiveScissor">
        /// </param>
        /// <param name="exclusiveScissors">
        /// </param>
        public static unsafe void SetExclusiveScissor(this CommandBuffer extendedHandle, uint firstExclusiveScissor, ArrayProxy<Rect2D>? exclusiveScissors)
        {
            try
            {
                CommandCache commandCache = default;
                Rect2D* marshalledExclusiveScissors = default;
                commandCache = extendedHandle.commandCache;
                if (exclusiveScissors.IsNull())
                {
                    marshalledExclusiveScissors = null;
                }
                else
                {
                    if (exclusiveScissors.Value.Contents == ProxyContents.Single)
                    {
                        marshalledExclusiveScissors = (Rect2D*)(Interop.HeapUtil.Allocate<Rect2D>());
                        *(Rect2D*)(marshalledExclusiveScissors) = exclusiveScissors.Value.GetSingleValue();
                    }
                    else
                    {
                        var fieldPointer = (Rect2D*)(Interop.HeapUtil.AllocateAndClear<Rect2D>(Interop.HeapUtil.GetLength(exclusiveScissors.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(exclusiveScissors.Value)); index++)
                        {
                            fieldPointer[index] = exclusiveScissors.Value[index];
                        }
                        marshalledExclusiveScissors = fieldPointer;
                    }
                }
                SharpVk.Interop.NVidia.VkCommandBufferSetExclusiveScissorDelegate commandDelegate = commandCache.Cache.vkCmdSetExclusiveScissorNV;
                commandDelegate(extendedHandle.Handle, firstExclusiveScissor, (uint)(Interop.HeapUtil.GetLength(exclusiveScissors)), marshalledExclusiveScissors);
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
        /// <param name="checkpointMarker">
        /// </param>
        public static unsafe void SetCheckpoint(this CommandBuffer extendedHandle, IntPtr checkpointMarker)
        {
            try
            {
                CommandCache commandCache = default;
                commandCache = extendedHandle.commandCache;
                SharpVk.Interop.NVidia.VkCommandBufferSetCheckpointDelegate commandDelegate = commandCache.Cache.vkCmdSetCheckpointNV;
                commandDelegate(extendedHandle.Handle, checkpointMarker.ToPointer());
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
        /// <param name="generatedCommandsInfo">
        /// </param>
        public static unsafe void PreprocessGeneratedCommands(this CommandBuffer extendedHandle, GeneratedCommandsInfo generatedCommandsInfo)
        {
            try
            {
                CommandCache commandCache = default;
                SharpVk.Interop.NVidia.GeneratedCommandsInfo* marshalledGeneratedCommandsInfo = default;
                commandCache = extendedHandle.commandCache;
                marshalledGeneratedCommandsInfo = (SharpVk.Interop.NVidia.GeneratedCommandsInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.NVidia.GeneratedCommandsInfo>());
                generatedCommandsInfo.MarshalTo(marshalledGeneratedCommandsInfo);
                SharpVk.Interop.NVidia.VkCommandBufferPreprocessGeneratedCommandsDelegate commandDelegate = commandCache.Cache.vkCmdPreprocessGeneratedCommandsNV;
                commandDelegate(extendedHandle.Handle, marshalledGeneratedCommandsInfo);
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
        /// <param name="isPreprocessed">
        /// </param>
        /// <param name="generatedCommandsInfo">
        /// </param>
        public static unsafe void ExecuteGeneratedCommands(this CommandBuffer extendedHandle, bool isPreprocessed, GeneratedCommandsInfo generatedCommandsInfo)
        {
            try
            {
                CommandCache commandCache = default;
                SharpVk.Interop.NVidia.GeneratedCommandsInfo* marshalledGeneratedCommandsInfo = default;
                commandCache = extendedHandle.commandCache;
                marshalledGeneratedCommandsInfo = (SharpVk.Interop.NVidia.GeneratedCommandsInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.NVidia.GeneratedCommandsInfo>());
                generatedCommandsInfo.MarshalTo(marshalledGeneratedCommandsInfo);
                SharpVk.Interop.NVidia.VkCommandBufferExecuteGeneratedCommandsDelegate commandDelegate = commandCache.Cache.vkCmdExecuteGeneratedCommandsNV;
                commandDelegate(extendedHandle.Handle, isPreprocessed, marshalledGeneratedCommandsInfo);
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
        /// <param name="pipelineBindPoint">
        /// </param>
        /// <param name="pipeline">
        /// </param>
        /// <param name="groupIndex">
        /// </param>
        public static unsafe void BindPipelineShaderGroup(this CommandBuffer extendedHandle, PipelineBindPoint pipelineBindPoint, Pipeline pipeline, uint groupIndex)
        {
            try
            {
                CommandCache commandCache = default;
                commandCache = extendedHandle.commandCache;
                SharpVk.Interop.NVidia.VkCommandBufferBindPipelineShaderGroupDelegate commandDelegate = commandCache.Cache.vkCmdBindPipelineShaderGroupNV;
                commandDelegate(extendedHandle.Handle, pipelineBindPoint, pipeline?.Handle ?? default, groupIndex);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
    }
}
