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

namespace SharpVk.Multivendor
{
    /// <summary>
    /// </summary>
    public static class CommandBufferExtensions
    {
        /// <summary>
        /// </summary>
        /// <param name="extendedHandle">
        /// The CommandBuffer handle to extend.
        /// </param>
        /// <param name="firstBinding">
        /// </param>
        /// <param name="buffers">
        /// </param>
        /// <param name="offsets">
        /// </param>
        /// <param name="sizes">
        /// </param>
        public static unsafe void BindTransformFeedbackBuffers(this CommandBuffer extendedHandle, uint firstBinding, ArrayProxy<Buffer>? buffers, ArrayProxy<ulong>? offsets, ArrayProxy<ulong>? sizes = null)
        {
            try
            {
                CommandCache commandCache = default;
                SharpVk.Interop.Buffer* marshalledBuffers = default;
                ulong* marshalledOffsets = default;
                ulong* marshalledSizes = default;
                commandCache = extendedHandle.commandCache;
                if (buffers.IsNull())
                {
                    marshalledBuffers = null;
                }
                else
                {
                    if (buffers.Value.Contents == ProxyContents.Single)
                    {
                        marshalledBuffers = (SharpVk.Interop.Buffer*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Buffer>());
                        *(SharpVk.Interop.Buffer*)(marshalledBuffers) = buffers.Value.GetSingleValue()?.Handle ?? default;
                    }
                    else
                    {
                        var fieldPointer = (SharpVk.Interop.Buffer*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.Buffer>(Interop.HeapUtil.GetLength(buffers.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(buffers.Value)); index++)
                        {
                            fieldPointer[index] = buffers.Value[index]?.Handle ?? default;
                        }
                        marshalledBuffers = fieldPointer;
                    }
                }
                if (offsets.IsNull())
                {
                    marshalledOffsets = null;
                }
                else
                {
                    if (offsets.Value.Contents == ProxyContents.Single)
                    {
                        marshalledOffsets = (ulong*)(Interop.HeapUtil.Allocate<ulong>());
                        *(ulong*)(marshalledOffsets) = offsets.Value.GetSingleValue();
                    }
                    else
                    {
                        var fieldPointer = (ulong*)(Interop.HeapUtil.AllocateAndClear<ulong>(Interop.HeapUtil.GetLength(offsets.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(offsets.Value)); index++)
                        {
                            fieldPointer[index] = offsets.Value[index];
                        }
                        marshalledOffsets = fieldPointer;
                    }
                }
                if (sizes.IsNull())
                {
                    marshalledSizes = null;
                }
                else
                {
                    if (sizes.Value.Contents == ProxyContents.Single)
                    {
                        marshalledSizes = (ulong*)(Interop.HeapUtil.Allocate<ulong>());
                        *(ulong*)(marshalledSizes) = sizes.Value.GetSingleValue();
                    }
                    else
                    {
                        var fieldPointer = (ulong*)(Interop.HeapUtil.AllocateAndClear<ulong>(Interop.HeapUtil.GetLength(sizes.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(sizes.Value)); index++)
                        {
                            fieldPointer[index] = sizes.Value[index];
                        }
                        marshalledSizes = fieldPointer;
                    }
                }
                SharpVk.Interop.Multivendor.VkCommandBufferBindTransformFeedbackBuffersDelegate commandDelegate = commandCache.Cache.vkCmdBindTransformFeedbackBuffersEXT;
                commandDelegate(extendedHandle.Handle, firstBinding, (uint)(Interop.HeapUtil.GetLength(buffers)), marshalledBuffers, marshalledOffsets, marshalledSizes);
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
        /// <param name="firstCounterBuffer">
        /// </param>
        /// <param name="counterBuffers">
        /// </param>
        /// <param name="counterBufferOffsets">
        /// </param>
        public static unsafe void BeginTransformFeedback(this CommandBuffer extendedHandle, uint firstCounterBuffer, ArrayProxy<Buffer>? counterBuffers, ArrayProxy<ulong>? counterBufferOffsets = null)
        {
            try
            {
                CommandCache commandCache = default;
                SharpVk.Interop.Buffer* marshalledCounterBuffers = default;
                ulong* marshalledCounterBufferOffsets = default;
                commandCache = extendedHandle.commandCache;
                if (counterBuffers.IsNull())
                {
                    marshalledCounterBuffers = null;
                }
                else
                {
                    if (counterBuffers.Value.Contents == ProxyContents.Single)
                    {
                        marshalledCounterBuffers = (SharpVk.Interop.Buffer*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Buffer>());
                        *(SharpVk.Interop.Buffer*)(marshalledCounterBuffers) = counterBuffers.Value.GetSingleValue()?.Handle ?? default;
                    }
                    else
                    {
                        var fieldPointer = (SharpVk.Interop.Buffer*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.Buffer>(Interop.HeapUtil.GetLength(counterBuffers.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(counterBuffers.Value)); index++)
                        {
                            fieldPointer[index] = counterBuffers.Value[index]?.Handle ?? default;
                        }
                        marshalledCounterBuffers = fieldPointer;
                    }
                }
                if (counterBufferOffsets.IsNull())
                {
                    marshalledCounterBufferOffsets = null;
                }
                else
                {
                    if (counterBufferOffsets.Value.Contents == ProxyContents.Single)
                    {
                        marshalledCounterBufferOffsets = (ulong*)(Interop.HeapUtil.Allocate<ulong>());
                        *(ulong*)(marshalledCounterBufferOffsets) = counterBufferOffsets.Value.GetSingleValue();
                    }
                    else
                    {
                        var fieldPointer = (ulong*)(Interop.HeapUtil.AllocateAndClear<ulong>(Interop.HeapUtil.GetLength(counterBufferOffsets.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(counterBufferOffsets.Value)); index++)
                        {
                            fieldPointer[index] = counterBufferOffsets.Value[index];
                        }
                        marshalledCounterBufferOffsets = fieldPointer;
                    }
                }
                SharpVk.Interop.Multivendor.VkCommandBufferBeginTransformFeedbackDelegate commandDelegate = commandCache.Cache.vkCmdBeginTransformFeedbackEXT;
                commandDelegate(extendedHandle.Handle, firstCounterBuffer, (uint)(Interop.HeapUtil.GetLength(counterBuffers)), marshalledCounterBuffers, marshalledCounterBufferOffsets);
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
        /// <param name="firstCounterBuffer">
        /// </param>
        /// <param name="counterBuffers">
        /// </param>
        /// <param name="counterBufferOffsets">
        /// </param>
        public static unsafe void EndTransformFeedback(this CommandBuffer extendedHandle, uint firstCounterBuffer, ArrayProxy<Buffer>? counterBuffers, ArrayProxy<ulong>? counterBufferOffsets = null)
        {
            try
            {
                CommandCache commandCache = default;
                SharpVk.Interop.Buffer* marshalledCounterBuffers = default;
                ulong* marshalledCounterBufferOffsets = default;
                commandCache = extendedHandle.commandCache;
                if (counterBuffers.IsNull())
                {
                    marshalledCounterBuffers = null;
                }
                else
                {
                    if (counterBuffers.Value.Contents == ProxyContents.Single)
                    {
                        marshalledCounterBuffers = (SharpVk.Interop.Buffer*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Buffer>());
                        *(SharpVk.Interop.Buffer*)(marshalledCounterBuffers) = counterBuffers.Value.GetSingleValue()?.Handle ?? default;
                    }
                    else
                    {
                        var fieldPointer = (SharpVk.Interop.Buffer*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.Buffer>(Interop.HeapUtil.GetLength(counterBuffers.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(counterBuffers.Value)); index++)
                        {
                            fieldPointer[index] = counterBuffers.Value[index]?.Handle ?? default;
                        }
                        marshalledCounterBuffers = fieldPointer;
                    }
                }
                if (counterBufferOffsets.IsNull())
                {
                    marshalledCounterBufferOffsets = null;
                }
                else
                {
                    if (counterBufferOffsets.Value.Contents == ProxyContents.Single)
                    {
                        marshalledCounterBufferOffsets = (ulong*)(Interop.HeapUtil.Allocate<ulong>());
                        *(ulong*)(marshalledCounterBufferOffsets) = counterBufferOffsets.Value.GetSingleValue();
                    }
                    else
                    {
                        var fieldPointer = (ulong*)(Interop.HeapUtil.AllocateAndClear<ulong>(Interop.HeapUtil.GetLength(counterBufferOffsets.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(counterBufferOffsets.Value)); index++)
                        {
                            fieldPointer[index] = counterBufferOffsets.Value[index];
                        }
                        marshalledCounterBufferOffsets = fieldPointer;
                    }
                }
                SharpVk.Interop.Multivendor.VkCommandBufferEndTransformFeedbackDelegate commandDelegate = commandCache.Cache.vkCmdEndTransformFeedbackEXT;
                commandDelegate(extendedHandle.Handle, firstCounterBuffer, (uint)(Interop.HeapUtil.GetLength(counterBuffers)), marshalledCounterBuffers, marshalledCounterBufferOffsets);
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
        /// <param name="queryPool">
        /// </param>
        /// <param name="query">
        /// </param>
        /// <param name="flags">
        /// </param>
        /// <param name="index">
        /// </param>
        public static unsafe void BeginQueryIndexed(this CommandBuffer extendedHandle, QueryPool queryPool, uint query, uint index, QueryControlFlags? flags = default)
        {
            try
            {
                CommandCache commandCache = default;
                QueryControlFlags marshalledFlags = default;
                commandCache = extendedHandle.commandCache;
                if (flags != null)
                {
                    marshalledFlags = flags.Value;
                }
                else
                {
                    marshalledFlags = default;
                }
                SharpVk.Interop.Multivendor.VkCommandBufferBeginQueryIndexedDelegate commandDelegate = commandCache.Cache.vkCmdBeginQueryIndexedEXT;
                commandDelegate(extendedHandle.Handle, queryPool?.Handle ?? default, query, marshalledFlags, index);
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
        /// <param name="queryPool">
        /// </param>
        /// <param name="query">
        /// </param>
        /// <param name="index">
        /// </param>
        public static unsafe void EndQueryIndexed(this CommandBuffer extendedHandle, QueryPool queryPool, uint query, uint index)
        {
            try
            {
                CommandCache commandCache = default;
                commandCache = extendedHandle.commandCache;
                SharpVk.Interop.Multivendor.VkCommandBufferEndQueryIndexedDelegate commandDelegate = commandCache.Cache.vkCmdEndQueryIndexedEXT;
                commandDelegate(extendedHandle.Handle, queryPool?.Handle ?? default, query, index);
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
        /// <param name="instanceCount">
        /// </param>
        /// <param name="firstInstance">
        /// </param>
        /// <param name="counterBuffer">
        /// </param>
        /// <param name="counterBufferOffset">
        /// </param>
        /// <param name="counterOffset">
        /// </param>
        /// <param name="vertexStride">
        /// </param>
        public static unsafe void DrawIndirectByteCount(this CommandBuffer extendedHandle, uint instanceCount, uint firstInstance, Buffer counterBuffer, ulong counterBufferOffset, uint counterOffset, uint vertexStride)
        {
            try
            {
                CommandCache commandCache = default;
                commandCache = extendedHandle.commandCache;
                SharpVk.Interop.Multivendor.VkCommandBufferDrawIndirectByteCountDelegate commandDelegate = commandCache.Cache.vkCmdDrawIndirectByteCountEXT;
                commandDelegate(extendedHandle.Handle, instanceCount, firstInstance, counterBuffer?.Handle ?? default, counterBufferOffset, counterOffset, vertexStride);
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
        /// <param name="flags">
        /// </param>
        public static unsafe void BeginConditionalRendering(this CommandBuffer extendedHandle, Buffer buffer, ulong offset, ConditionalRenderingFlags? flags = default)
        {
            try
            {
                CommandCache commandCache = default;
                SharpVk.Interop.Multivendor.ConditionalRenderingBeginInfo* marshalledConditionalRenderingBegin = default;
                void* vkConditionalRenderingBeginInfoEXTNextPointer = default;
                commandCache = extendedHandle.commandCache;
                marshalledConditionalRenderingBegin = (SharpVk.Interop.Multivendor.ConditionalRenderingBeginInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.ConditionalRenderingBeginInfo>());
                marshalledConditionalRenderingBegin->SType = StructureType.ConditionalRenderingBeginInfo;
                marshalledConditionalRenderingBegin->Next = vkConditionalRenderingBeginInfoEXTNextPointer;
                marshalledConditionalRenderingBegin->Buffer = buffer?.Handle ?? default;
                marshalledConditionalRenderingBegin->Offset = offset;
                if (flags != null)
                {
                    marshalledConditionalRenderingBegin->Flags = flags.Value;
                }
                else
                {
                    marshalledConditionalRenderingBegin->Flags = default;
                }
                SharpVk.Interop.Multivendor.VkCommandBufferBeginConditionalRenderingDelegate commandDelegate = commandCache.Cache.vkCmdBeginConditionalRenderingEXT;
                commandDelegate(extendedHandle.Handle, marshalledConditionalRenderingBegin);
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
        public static unsafe void EndConditionalRendering(this CommandBuffer extendedHandle)
        {
            try
            {
                CommandCache commandCache = default;
                commandCache = extendedHandle.commandCache;
                SharpVk.Interop.Multivendor.VkCommandBufferEndConditionalRenderingDelegate commandDelegate = commandCache.Cache.vkCmdEndConditionalRenderingEXT;
                commandDelegate(extendedHandle.Handle);
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
        /// <param name="firstDiscardRectangle">
        /// </param>
        /// <param name="discardRectangles">
        /// </param>
        public static unsafe void SetDiscardRectangle(this CommandBuffer extendedHandle, uint firstDiscardRectangle, ArrayProxy<Rect2D>? discardRectangles)
        {
            try
            {
                CommandCache commandCache = default;
                Rect2D* marshalledDiscardRectangles = default;
                commandCache = extendedHandle.commandCache;
                if (discardRectangles.IsNull())
                {
                    marshalledDiscardRectangles = null;
                }
                else
                {
                    if (discardRectangles.Value.Contents == ProxyContents.Single)
                    {
                        marshalledDiscardRectangles = (Rect2D*)(Interop.HeapUtil.Allocate<Rect2D>());
                        *(Rect2D*)(marshalledDiscardRectangles) = discardRectangles.Value.GetSingleValue();
                    }
                    else
                    {
                        var fieldPointer = (Rect2D*)(Interop.HeapUtil.AllocateAndClear<Rect2D>(Interop.HeapUtil.GetLength(discardRectangles.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(discardRectangles.Value)); index++)
                        {
                            fieldPointer[index] = discardRectangles.Value[index];
                        }
                        marshalledDiscardRectangles = fieldPointer;
                    }
                }
                SharpVk.Interop.Multivendor.VkCommandBufferSetDiscardRectangleDelegate commandDelegate = commandCache.Cache.vkCmdSetDiscardRectangleEXT;
                commandDelegate(extendedHandle.Handle, firstDiscardRectangle, (uint)(Interop.HeapUtil.GetLength(discardRectangles)), marshalledDiscardRectangles);
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
        /// <param name="labelInfo">
        /// </param>
        public static unsafe void BeginDebugUtilsLabel(this CommandBuffer extendedHandle, DebugUtilsLabel labelInfo)
        {
            try
            {
                CommandCache commandCache = default;
                SharpVk.Interop.Multivendor.DebugUtilsLabel* marshalledLabelInfo = default;
                commandCache = extendedHandle.commandCache;
                marshalledLabelInfo = (SharpVk.Interop.Multivendor.DebugUtilsLabel*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.DebugUtilsLabel>());
                labelInfo.MarshalTo(marshalledLabelInfo);
                SharpVk.Interop.Multivendor.VkCommandBufferBeginDebugUtilsLabelDelegate commandDelegate = commandCache.Cache.vkCmdBeginDebugUtilsLabelEXT;
                commandDelegate(extendedHandle.Handle, marshalledLabelInfo);
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
        public static unsafe void EndDebugUtilsLabel(this CommandBuffer extendedHandle)
        {
            try
            {
                CommandCache commandCache = default;
                commandCache = extendedHandle.commandCache;
                SharpVk.Interop.Multivendor.VkCommandBufferEndDebugUtilsLabelDelegate commandDelegate = commandCache.Cache.vkCmdEndDebugUtilsLabelEXT;
                commandDelegate(extendedHandle.Handle);
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
        /// <param name="labelInfo">
        /// </param>
        public static unsafe void InsertDebugUtilsLabel(this CommandBuffer extendedHandle, DebugUtilsLabel labelInfo)
        {
            try
            {
                CommandCache commandCache = default;
                SharpVk.Interop.Multivendor.DebugUtilsLabel* marshalledLabelInfo = default;
                commandCache = extendedHandle.commandCache;
                marshalledLabelInfo = (SharpVk.Interop.Multivendor.DebugUtilsLabel*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.DebugUtilsLabel>());
                labelInfo.MarshalTo(marshalledLabelInfo);
                SharpVk.Interop.Multivendor.VkCommandBufferInsertDebugUtilsLabelDelegate commandDelegate = commandCache.Cache.vkCmdInsertDebugUtilsLabelEXT;
                commandDelegate(extendedHandle.Handle, marshalledLabelInfo);
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
        /// <param name="sampleLocationsInfo">
        /// </param>
        public static unsafe void SetSampleLocations(this CommandBuffer extendedHandle, SampleLocationsInfo sampleLocationsInfo)
        {
            try
            {
                CommandCache commandCache = default;
                SharpVk.Interop.Multivendor.SampleLocationsInfo* marshalledSampleLocationsInfo = default;
                commandCache = extendedHandle.commandCache;
                marshalledSampleLocationsInfo = (SharpVk.Interop.Multivendor.SampleLocationsInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.SampleLocationsInfo>());
                sampleLocationsInfo.MarshalTo(marshalledSampleLocationsInfo);
                SharpVk.Interop.Multivendor.VkCommandBufferSetSampleLocationsDelegate commandDelegate = commandCache.Cache.vkCmdSetSampleLocationsEXT;
                commandDelegate(extendedHandle.Handle, marshalledSampleLocationsInfo);
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
        /// <param name="lineStippleFactor">
        /// </param>
        /// <param name="lineStipplePattern">
        /// </param>
        public static unsafe void SetLineStipple(this CommandBuffer extendedHandle, uint lineStippleFactor, ushort lineStipplePattern)
        {
            try
            {
                CommandCache commandCache = default;
                commandCache = extendedHandle.commandCache;
                SharpVk.Interop.Multivendor.VkCommandBufferSetLineStippleDelegate commandDelegate = commandCache.Cache.vkCmdSetLineStippleEXT;
                commandDelegate(extendedHandle.Handle, lineStippleFactor, lineStipplePattern);
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
        /// <param name="cullMode">
        /// </param>
        public static unsafe void SetCullMode(this CommandBuffer extendedHandle, CullModeFlags? cullMode = default)
        {
            try
            {
                CommandCache commandCache = default;
                CullModeFlags marshalledCullMode = default;
                commandCache = extendedHandle.commandCache;
                if (cullMode != null)
                {
                    marshalledCullMode = cullMode.Value;
                }
                else
                {
                    marshalledCullMode = default;
                }
                SharpVk.Interop.Multivendor.VkCommandBufferSetCullModeDelegate commandDelegate = commandCache.Cache.vkCmdSetCullModeEXT;
                commandDelegate(extendedHandle.Handle, marshalledCullMode);
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
        /// <param name="frontFace">
        /// </param>
        public static unsafe void SetFrontFace(this CommandBuffer extendedHandle, FrontFace frontFace)
        {
            try
            {
                CommandCache commandCache = default;
                commandCache = extendedHandle.commandCache;
                SharpVk.Interop.Multivendor.VkCommandBufferSetFrontFaceDelegate commandDelegate = commandCache.Cache.vkCmdSetFrontFaceEXT;
                commandDelegate(extendedHandle.Handle, frontFace);
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
        /// <param name="primitiveTopology">
        /// </param>
        public static unsafe void SetPrimitiveTopology(this CommandBuffer extendedHandle, PrimitiveTopology primitiveTopology)
        {
            try
            {
                CommandCache commandCache = default;
                commandCache = extendedHandle.commandCache;
                SharpVk.Interop.Multivendor.VkCommandBufferSetPrimitiveTopologyDelegate commandDelegate = commandCache.Cache.vkCmdSetPrimitiveTopologyEXT;
                commandDelegate(extendedHandle.Handle, primitiveTopology);
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
        /// <param name="viewports">
        /// </param>
        public static unsafe void SetViewportWithCount(this CommandBuffer extendedHandle, ArrayProxy<Viewport>? viewports)
        {
            try
            {
                CommandCache commandCache = default;
                Viewport* marshalledViewports = default;
                commandCache = extendedHandle.commandCache;
                if (viewports.IsNull())
                {
                    marshalledViewports = null;
                }
                else
                {
                    if (viewports.Value.Contents == ProxyContents.Single)
                    {
                        marshalledViewports = (Viewport*)(Interop.HeapUtil.Allocate<Viewport>());
                        *(Viewport*)(marshalledViewports) = viewports.Value.GetSingleValue();
                    }
                    else
                    {
                        var fieldPointer = (Viewport*)(Interop.HeapUtil.AllocateAndClear<Viewport>(Interop.HeapUtil.GetLength(viewports.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(viewports.Value)); index++)
                        {
                            fieldPointer[index] = viewports.Value[index];
                        }
                        marshalledViewports = fieldPointer;
                    }
                }
                SharpVk.Interop.Multivendor.VkCommandBufferSetViewportWithCountDelegate commandDelegate = commandCache.Cache.vkCmdSetViewportWithCountEXT;
                commandDelegate(extendedHandle.Handle, (uint)(Interop.HeapUtil.GetLength(viewports)), marshalledViewports);
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
        /// <param name="scissors">
        /// </param>
        public static unsafe void SetScissorWithCount(this CommandBuffer extendedHandle, ArrayProxy<Rect2D>? scissors)
        {
            try
            {
                CommandCache commandCache = default;
                Rect2D* marshalledScissors = default;
                commandCache = extendedHandle.commandCache;
                if (scissors.IsNull())
                {
                    marshalledScissors = null;
                }
                else
                {
                    if (scissors.Value.Contents == ProxyContents.Single)
                    {
                        marshalledScissors = (Rect2D*)(Interop.HeapUtil.Allocate<Rect2D>());
                        *(Rect2D*)(marshalledScissors) = scissors.Value.GetSingleValue();
                    }
                    else
                    {
                        var fieldPointer = (Rect2D*)(Interop.HeapUtil.AllocateAndClear<Rect2D>(Interop.HeapUtil.GetLength(scissors.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(scissors.Value)); index++)
                        {
                            fieldPointer[index] = scissors.Value[index];
                        }
                        marshalledScissors = fieldPointer;
                    }
                }
                SharpVk.Interop.Multivendor.VkCommandBufferSetScissorWithCountDelegate commandDelegate = commandCache.Cache.vkCmdSetScissorWithCountEXT;
                commandDelegate(extendedHandle.Handle, (uint)(Interop.HeapUtil.GetLength(scissors)), marshalledScissors);
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
        /// <param name="firstBinding">
        /// </param>
        /// <param name="buffers">
        /// </param>
        /// <param name="offsets">
        /// </param>
        /// <param name="sizes">
        /// </param>
        /// <param name="strides">
        /// </param>
        public static unsafe void BindVertexBuffers2(this CommandBuffer extendedHandle, uint firstBinding, ArrayProxy<Buffer>? buffers, ArrayProxy<ulong>? offsets, ArrayProxy<ulong>? sizes = null, ArrayProxy<ulong>? strides = null)
        {
            try
            {
                CommandCache commandCache = default;
                SharpVk.Interop.Buffer* marshalledBuffers = default;
                ulong* marshalledOffsets = default;
                ulong* marshalledSizes = default;
                ulong* marshalledStrides = default;
                commandCache = extendedHandle.commandCache;
                if (buffers.IsNull())
                {
                    marshalledBuffers = null;
                }
                else
                {
                    if (buffers.Value.Contents == ProxyContents.Single)
                    {
                        marshalledBuffers = (SharpVk.Interop.Buffer*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Buffer>());
                        *(SharpVk.Interop.Buffer*)(marshalledBuffers) = buffers.Value.GetSingleValue()?.Handle ?? default;
                    }
                    else
                    {
                        var fieldPointer = (SharpVk.Interop.Buffer*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.Buffer>(Interop.HeapUtil.GetLength(buffers.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(buffers.Value)); index++)
                        {
                            fieldPointer[index] = buffers.Value[index]?.Handle ?? default;
                        }
                        marshalledBuffers = fieldPointer;
                    }
                }
                if (offsets.IsNull())
                {
                    marshalledOffsets = null;
                }
                else
                {
                    if (offsets.Value.Contents == ProxyContents.Single)
                    {
                        marshalledOffsets = (ulong*)(Interop.HeapUtil.Allocate<ulong>());
                        *(ulong*)(marshalledOffsets) = offsets.Value.GetSingleValue();
                    }
                    else
                    {
                        var fieldPointer = (ulong*)(Interop.HeapUtil.AllocateAndClear<ulong>(Interop.HeapUtil.GetLength(offsets.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(offsets.Value)); index++)
                        {
                            fieldPointer[index] = offsets.Value[index];
                        }
                        marshalledOffsets = fieldPointer;
                    }
                }
                if (sizes.IsNull())
                {
                    marshalledSizes = null;
                }
                else
                {
                    if (sizes.Value.Contents == ProxyContents.Single)
                    {
                        marshalledSizes = (ulong*)(Interop.HeapUtil.Allocate<ulong>());
                        *(ulong*)(marshalledSizes) = sizes.Value.GetSingleValue();
                    }
                    else
                    {
                        var fieldPointer = (ulong*)(Interop.HeapUtil.AllocateAndClear<ulong>(Interop.HeapUtil.GetLength(sizes.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(sizes.Value)); index++)
                        {
                            fieldPointer[index] = sizes.Value[index];
                        }
                        marshalledSizes = fieldPointer;
                    }
                }
                if (strides.IsNull())
                {
                    marshalledStrides = null;
                }
                else
                {
                    if (strides.Value.Contents == ProxyContents.Single)
                    {
                        marshalledStrides = (ulong*)(Interop.HeapUtil.Allocate<ulong>());
                        *(ulong*)(marshalledStrides) = strides.Value.GetSingleValue();
                    }
                    else
                    {
                        var fieldPointer = (ulong*)(Interop.HeapUtil.AllocateAndClear<ulong>(Interop.HeapUtil.GetLength(strides.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(strides.Value)); index++)
                        {
                            fieldPointer[index] = strides.Value[index];
                        }
                        marshalledStrides = fieldPointer;
                    }
                }
                SharpVk.Interop.Multivendor.VkCommandBufferBindVertexBuffers2Delegate commandDelegate = commandCache.Cache.vkCmdBindVertexBuffers2EXT;
                commandDelegate(extendedHandle.Handle, firstBinding, (uint)(Interop.HeapUtil.GetLength(buffers)), marshalledBuffers, marshalledOffsets, marshalledSizes, marshalledStrides);
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
        /// <param name="depthTestEnable">
        /// </param>
        public static unsafe void SetDepthTestEnable(this CommandBuffer extendedHandle, bool depthTestEnable)
        {
            try
            {
                CommandCache commandCache = default;
                commandCache = extendedHandle.commandCache;
                SharpVk.Interop.Multivendor.VkCommandBufferSetDepthTestEnableDelegate commandDelegate = commandCache.Cache.vkCmdSetDepthTestEnableEXT;
                commandDelegate(extendedHandle.Handle, depthTestEnable);
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
        /// <param name="depthWriteEnable">
        /// </param>
        public static unsafe void SetDepthWriteEnable(this CommandBuffer extendedHandle, bool depthWriteEnable)
        {
            try
            {
                CommandCache commandCache = default;
                commandCache = extendedHandle.commandCache;
                SharpVk.Interop.Multivendor.VkCommandBufferSetDepthWriteEnableDelegate commandDelegate = commandCache.Cache.vkCmdSetDepthWriteEnableEXT;
                commandDelegate(extendedHandle.Handle, depthWriteEnable);
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
        /// <param name="depthCompareOp">
        /// </param>
        public static unsafe void SetDepthCompareOp(this CommandBuffer extendedHandle, CompareOp depthCompareOp)
        {
            try
            {
                CommandCache commandCache = default;
                commandCache = extendedHandle.commandCache;
                SharpVk.Interop.Multivendor.VkCommandBufferSetDepthCompareOpDelegate commandDelegate = commandCache.Cache.vkCmdSetDepthCompareOpEXT;
                commandDelegate(extendedHandle.Handle, depthCompareOp);
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
        /// <param name="depthBoundsTestEnable">
        /// </param>
        public static unsafe void SetDepthBoundsTestEnable(this CommandBuffer extendedHandle, bool depthBoundsTestEnable)
        {
            try
            {
                CommandCache commandCache = default;
                commandCache = extendedHandle.commandCache;
                SharpVk.Interop.Multivendor.VkCommandBufferSetDepthBoundsTestEnableDelegate commandDelegate = commandCache.Cache.vkCmdSetDepthBoundsTestEnableEXT;
                commandDelegate(extendedHandle.Handle, depthBoundsTestEnable);
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
        /// <param name="stencilTestEnable">
        /// </param>
        public static unsafe void SetStencilTestEnable(this CommandBuffer extendedHandle, bool stencilTestEnable)
        {
            try
            {
                CommandCache commandCache = default;
                commandCache = extendedHandle.commandCache;
                SharpVk.Interop.Multivendor.VkCommandBufferSetStencilTestEnableDelegate commandDelegate = commandCache.Cache.vkCmdSetStencilTestEnableEXT;
                commandDelegate(extendedHandle.Handle, stencilTestEnable);
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
        /// <param name="faceMask">
        /// </param>
        /// <param name="failOp">
        /// </param>
        /// <param name="passOp">
        /// </param>
        /// <param name="depthFailOp">
        /// </param>
        /// <param name="compareOp">
        /// </param>
        public static unsafe void SetStencilOp(this CommandBuffer extendedHandle, StencilFaceFlags faceMask, StencilOp failOp, StencilOp passOp, StencilOp depthFailOp, CompareOp compareOp)
        {
            try
            {
                CommandCache commandCache = default;
                commandCache = extendedHandle.commandCache;
                SharpVk.Interop.Multivendor.VkCommandBufferSetStencilOpDelegate commandDelegate = commandCache.Cache.vkCmdSetStencilOpEXT;
                commandDelegate(extendedHandle.Handle, faceMask, failOp, passOp, depthFailOp, compareOp);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
    }
}
