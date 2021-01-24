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

namespace SharpVk
{
    /// <summary>
    /// Opaque handle to a command buffer object.
    /// </summary>
    public partial class CommandBuffer
    {
        internal readonly SharpVk.Interop.CommandBuffer Handle; 
        
        internal readonly CommandCache commandCache; 
        
        internal readonly CommandPool parent; 
        
        internal CommandBuffer(CommandPool parent, SharpVk.Interop.CommandBuffer handle)
        {
            Handle = handle;
            this.parent = parent;
            commandCache = parent.commandCache;
        }
        
        /// <summary>
        /// The raw handle for this instance.
        /// </summary>
        public SharpVk.Interop.CommandBuffer RawHandle => Handle;
        
        /// <summary>
        /// Start recording a command buffer.
        /// </summary>
        /// <param name="flags">
        /// A bitmask indicating usage behavior for the command buffer. Bits
        /// which can be set include: + --
        /// </param>
        /// <param name="inheritanceInfo">
        /// </param>
        /// <param name="deviceGroupCommandBufferBeginInfo">
        /// Extension struct
        /// </param>
        public unsafe void Begin(CommandBufferUsageFlags? flags = default, CommandBufferInheritanceInfo? inheritanceInfo = default, DeviceGroupCommandBufferBeginInfo? deviceGroupCommandBufferBeginInfo = null)
        {
            try
            {
                SharpVk.Interop.CommandBufferBeginInfo* marshalledBeginInfo = default;
                void* vkCommandBufferBeginInfoNextPointer = default;
                if (deviceGroupCommandBufferBeginInfo != null)
                {
                    SharpVk.Interop.DeviceGroupCommandBufferBeginInfo* extensionPointer = default;
                    extensionPointer = (SharpVk.Interop.DeviceGroupCommandBufferBeginInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.DeviceGroupCommandBufferBeginInfo>());
                    deviceGroupCommandBufferBeginInfo.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkCommandBufferBeginInfoNextPointer;
                    vkCommandBufferBeginInfoNextPointer = extensionPointer;
                }
                marshalledBeginInfo = (SharpVk.Interop.CommandBufferBeginInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.CommandBufferBeginInfo>());
                marshalledBeginInfo->SType = StructureType.CommandBufferBeginInfo;
                marshalledBeginInfo->Next = vkCommandBufferBeginInfoNextPointer;
                if (flags != null)
                {
                    marshalledBeginInfo->Flags = flags.Value;
                }
                else
                {
                    marshalledBeginInfo->Flags = default;
                }
                if (inheritanceInfo != null)
                {
                    marshalledBeginInfo->InheritanceInfo = (SharpVk.Interop.CommandBufferInheritanceInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.CommandBufferInheritanceInfo>());
                    inheritanceInfo.Value.MarshalTo(marshalledBeginInfo->InheritanceInfo);
                }
                else
                {
                    marshalledBeginInfo->InheritanceInfo = default;
                }
                Interop.VkCommandBufferBeginDelegate commandDelegate = commandCache.Cache.vkBeginCommandBuffer;
                Result methodResult = commandDelegate(Handle, marshalledBeginInfo);
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
        /// Finish recording a command buffer.
        /// </summary>
        public unsafe void End()
        {
            try
            {
                Interop.VkCommandBufferEndDelegate commandDelegate = commandCache.Cache.vkEndCommandBuffer;
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
        /// Reset a command buffer.
        /// </summary>
        /// <param name="flags">
        /// </param>
        public unsafe void Reset(CommandBufferResetFlags? flags = default)
        {
            try
            {
                CommandBufferResetFlags marshalledFlags = default;
                if (flags != null)
                {
                    marshalledFlags = flags.Value;
                }
                else
                {
                    marshalledFlags = default;
                }
                Interop.VkCommandBufferResetDelegate commandDelegate = commandCache.Cache.vkResetCommandBuffer;
                Result methodResult = commandDelegate(Handle, marshalledFlags);
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
        /// Bind a pipeline object to a command buffer.
        /// </summary>
        /// <param name="pipelineBindPoint">
        /// </param>
        /// <param name="pipeline">
        /// </param>
        public unsafe void BindPipeline(PipelineBindPoint pipelineBindPoint, Pipeline pipeline)
        {
            try
            {
                Interop.VkCommandBufferBindPipelineDelegate commandDelegate = commandCache.Cache.vkCmdBindPipeline;
                commandDelegate(Handle, pipelineBindPoint, pipeline?.Handle ?? default);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Set the viewport on a command buffer.
        /// </summary>
        /// <param name="firstViewport">
        /// </param>
        /// <param name="viewports">
        /// </param>
        public unsafe void SetViewport(uint firstViewport, ArrayProxy<Viewport>? viewports)
        {
            try
            {
                Viewport* marshalledViewports = default;
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
                Interop.VkCommandBufferSetViewportDelegate commandDelegate = commandCache.Cache.vkCmdSetViewport;
                commandDelegate(Handle, firstViewport, (uint)(Interop.HeapUtil.GetLength(viewports)), marshalledViewports);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Set the dynamic scissor rectangles on a command buffer.
        /// </summary>
        /// <param name="firstScissor">
        /// </param>
        /// <param name="scissors">
        /// </param>
        public unsafe void SetScissor(uint firstScissor, ArrayProxy<Rect2D>? scissors)
        {
            try
            {
                Rect2D* marshalledScissors = default;
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
                Interop.VkCommandBufferSetScissorDelegate commandDelegate = commandCache.Cache.vkCmdSetScissor;
                commandDelegate(Handle, firstScissor, (uint)(Interop.HeapUtil.GetLength(scissors)), marshalledScissors);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Set the dynamic line width state.
        /// </summary>
        /// <param name="lineWidth">
        /// </param>
        public unsafe void SetLineWidth(float lineWidth)
        {
            try
            {
                Interop.VkCommandBufferSetLineWidthDelegate commandDelegate = commandCache.Cache.vkCmdSetLineWidth;
                commandDelegate(Handle, lineWidth);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Set the depth bias dynamic state.
        /// </summary>
        /// <param name="depthBiasConstantFactor">
        /// </param>
        /// <param name="depthBiasClamp">
        /// </param>
        /// <param name="depthBiasSlopeFactor">
        /// </param>
        public unsafe void SetDepthBias(float depthBiasConstantFactor, float depthBiasClamp, float depthBiasSlopeFactor)
        {
            try
            {
                Interop.VkCommandBufferSetDepthBiasDelegate commandDelegate = commandCache.Cache.vkCmdSetDepthBias;
                commandDelegate(Handle, depthBiasConstantFactor, depthBiasClamp, depthBiasSlopeFactor);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Set the values of blend constants.
        /// </summary>
        /// <param name="blendConstants">
        /// </param>
        public unsafe void SetBlendConstants(float blendConstants)
        {
            try
            {
                Interop.VkCommandBufferSetBlendConstantsDelegate commandDelegate = commandCache.Cache.vkCmdSetBlendConstants;
                commandDelegate(Handle, blendConstants);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Set the depth bounds test values for a command buffer.
        /// </summary>
        /// <param name="minDepthBounds">
        /// </param>
        /// <param name="maxDepthBounds">
        /// </param>
        public unsafe void SetDepthBounds(float minDepthBounds, float maxDepthBounds)
        {
            try
            {
                Interop.VkCommandBufferSetDepthBoundsDelegate commandDelegate = commandCache.Cache.vkCmdSetDepthBounds;
                commandDelegate(Handle, minDepthBounds, maxDepthBounds);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Set the stencil compare mask dynamic state.
        /// </summary>
        /// <param name="faceMask">
        /// </param>
        /// <param name="compareMask">
        /// </param>
        public unsafe void SetStencilCompareMask(StencilFaceFlags faceMask, uint compareMask)
        {
            try
            {
                Interop.VkCommandBufferSetStencilCompareMaskDelegate commandDelegate = commandCache.Cache.vkCmdSetStencilCompareMask;
                commandDelegate(Handle, faceMask, compareMask);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Set the stencil write mask dynamic state.
        /// </summary>
        /// <param name="faceMask">
        /// </param>
        /// <param name="writeMask">
        /// </param>
        public unsafe void SetStencilWriteMask(StencilFaceFlags faceMask, uint writeMask)
        {
            try
            {
                Interop.VkCommandBufferSetStencilWriteMaskDelegate commandDelegate = commandCache.Cache.vkCmdSetStencilWriteMask;
                commandDelegate(Handle, faceMask, writeMask);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Set the stencil reference dynamic state.
        /// </summary>
        /// <param name="faceMask">
        /// </param>
        /// <param name="reference">
        /// </param>
        public unsafe void SetStencilReference(StencilFaceFlags faceMask, uint reference)
        {
            try
            {
                Interop.VkCommandBufferSetStencilReferenceDelegate commandDelegate = commandCache.Cache.vkCmdSetStencilReference;
                commandDelegate(Handle, faceMask, reference);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Binds descriptor sets to a command buffer.
        /// </summary>
        /// <param name="pipelineBindPoint">
        /// </param>
        /// <param name="layout">
        /// </param>
        /// <param name="firstSet">
        /// </param>
        /// <param name="descriptorSets">
        /// </param>
        /// <param name="dynamicOffsets">
        /// </param>
        public unsafe void BindDescriptorSets(PipelineBindPoint pipelineBindPoint, PipelineLayout layout, uint firstSet, ArrayProxy<DescriptorSet>? descriptorSets, ArrayProxy<uint>? dynamicOffsets)
        {
            try
            {
                SharpVk.Interop.DescriptorSet* marshalledDescriptorSets = default;
                uint* marshalledDynamicOffsets = default;
                if (descriptorSets.IsNull())
                {
                    marshalledDescriptorSets = null;
                }
                else
                {
                    if (descriptorSets.Value.Contents == ProxyContents.Single)
                    {
                        marshalledDescriptorSets = (SharpVk.Interop.DescriptorSet*)(Interop.HeapUtil.Allocate<SharpVk.Interop.DescriptorSet>());
                        *(SharpVk.Interop.DescriptorSet*)(marshalledDescriptorSets) = descriptorSets.Value.GetSingleValue()?.Handle ?? default;
                    }
                    else
                    {
                        var fieldPointer = (SharpVk.Interop.DescriptorSet*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.DescriptorSet>(Interop.HeapUtil.GetLength(descriptorSets.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(descriptorSets.Value)); index++)
                        {
                            fieldPointer[index] = descriptorSets.Value[index]?.Handle ?? default;
                        }
                        marshalledDescriptorSets = fieldPointer;
                    }
                }
                if (dynamicOffsets.IsNull())
                {
                    marshalledDynamicOffsets = null;
                }
                else
                {
                    if (dynamicOffsets.Value.Contents == ProxyContents.Single)
                    {
                        marshalledDynamicOffsets = (uint*)(Interop.HeapUtil.Allocate<uint>());
                        *(uint*)(marshalledDynamicOffsets) = dynamicOffsets.Value.GetSingleValue();
                    }
                    else
                    {
                        var fieldPointer = (uint*)(Interop.HeapUtil.AllocateAndClear<uint>(Interop.HeapUtil.GetLength(dynamicOffsets.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(dynamicOffsets.Value)); index++)
                        {
                            fieldPointer[index] = dynamicOffsets.Value[index];
                        }
                        marshalledDynamicOffsets = fieldPointer;
                    }
                }
                Interop.VkCommandBufferBindDescriptorSetsDelegate commandDelegate = commandCache.Cache.vkCmdBindDescriptorSets;
                commandDelegate(Handle, pipelineBindPoint, layout?.Handle ?? default, firstSet, (uint)(Interop.HeapUtil.GetLength(descriptorSets)), marshalledDescriptorSets, (uint)(Interop.HeapUtil.GetLength(dynamicOffsets)), marshalledDynamicOffsets);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Bind an index buffer to a command buffer.
        /// </summary>
        /// <param name="buffer">
        /// </param>
        /// <param name="offset">
        /// </param>
        /// <param name="indexType">
        /// </param>
        public unsafe void BindIndexBuffer(Buffer buffer, ulong offset, IndexType indexType)
        {
            try
            {
                Interop.VkCommandBufferBindIndexBufferDelegate commandDelegate = commandCache.Cache.vkCmdBindIndexBuffer;
                commandDelegate(Handle, buffer?.Handle ?? default, offset, indexType);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Bind vertex buffers to a command buffer.
        /// </summary>
        /// <param name="firstBinding">
        /// </param>
        /// <param name="buffers">
        /// </param>
        /// <param name="offsets">
        /// </param>
        public unsafe void BindVertexBuffers(uint firstBinding, ArrayProxy<Buffer>? buffers, ArrayProxy<ulong>? offsets)
        {
            try
            {
                SharpVk.Interop.Buffer* marshalledBuffers = default;
                ulong* marshalledOffsets = default;
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
                Interop.VkCommandBufferBindVertexBuffersDelegate commandDelegate = commandCache.Cache.vkCmdBindVertexBuffers;
                commandDelegate(Handle, firstBinding, (uint)(Interop.HeapUtil.GetLength(buffers)), marshalledBuffers, marshalledOffsets);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Draw primitives.
        /// </summary>
        /// <param name="vertexCount">
        /// </param>
        /// <param name="instanceCount">
        /// </param>
        /// <param name="firstVertex">
        /// </param>
        /// <param name="firstInstance">
        /// </param>
        public unsafe void Draw(uint vertexCount, uint instanceCount, uint firstVertex, uint firstInstance)
        {
            try
            {
                Interop.VkCommandBufferDrawDelegate commandDelegate = commandCache.Cache.vkCmdDraw;
                commandDelegate(Handle, vertexCount, instanceCount, firstVertex, firstInstance);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Issue an indexed draw into a command buffer.
        /// </summary>
        /// <param name="indexCount">
        /// </param>
        /// <param name="instanceCount">
        /// </param>
        /// <param name="firstIndex">
        /// </param>
        /// <param name="vertexOffset">
        /// </param>
        /// <param name="firstInstance">
        /// </param>
        public unsafe void DrawIndexed(uint indexCount, uint instanceCount, uint firstIndex, int vertexOffset, uint firstInstance)
        {
            try
            {
                Interop.VkCommandBufferDrawIndexedDelegate commandDelegate = commandCache.Cache.vkCmdDrawIndexed;
                commandDelegate(Handle, indexCount, instanceCount, firstIndex, vertexOffset, firstInstance);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Issue an indirect draw into a command buffer.
        /// </summary>
        /// <param name="buffer">
        /// </param>
        /// <param name="offset">
        /// </param>
        /// <param name="drawCount">
        /// </param>
        /// <param name="stride">
        /// </param>
        public unsafe void DrawIndirect(Buffer buffer, ulong offset, uint drawCount, uint stride)
        {
            try
            {
                Interop.VkCommandBufferDrawIndirectDelegate commandDelegate = commandCache.Cache.vkCmdDrawIndirect;
                commandDelegate(Handle, buffer?.Handle ?? default, offset, drawCount, stride);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Perform an indexed indirect draw.
        /// </summary>
        /// <param name="buffer">
        /// </param>
        /// <param name="offset">
        /// </param>
        /// <param name="drawCount">
        /// </param>
        /// <param name="stride">
        /// </param>
        public unsafe void DrawIndexedIndirect(Buffer buffer, ulong offset, uint drawCount, uint stride)
        {
            try
            {
                Interop.VkCommandBufferDrawIndexedIndirectDelegate commandDelegate = commandCache.Cache.vkCmdDrawIndexedIndirect;
                commandDelegate(Handle, buffer?.Handle ?? default, offset, drawCount, stride);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Dispatch compute work items.
        /// </summary>
        /// <param name="groupCountX">
        /// </param>
        /// <param name="groupCountY">
        /// </param>
        /// <param name="groupCountZ">
        /// </param>
        public unsafe void Dispatch(uint groupCountX, uint groupCountY, uint groupCountZ)
        {
            try
            {
                Interop.VkCommandBufferDispatchDelegate commandDelegate = commandCache.Cache.vkCmdDispatch;
                commandDelegate(Handle, groupCountX, groupCountY, groupCountZ);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Dispatch compute work items using indirect parameters.
        /// </summary>
        /// <param name="buffer">
        /// </param>
        /// <param name="offset">
        /// </param>
        public unsafe void DispatchIndirect(Buffer buffer, ulong offset)
        {
            try
            {
                Interop.VkCommandBufferDispatchIndirectDelegate commandDelegate = commandCache.Cache.vkCmdDispatchIndirect;
                commandDelegate(Handle, buffer?.Handle ?? default, offset);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Copy data between buffer regions.
        /// </summary>
        /// <param name="sourceBuffer">
        /// </param>
        /// <param name="destinationBuffer">
        /// </param>
        /// <param name="regions">
        /// </param>
        public unsafe void CopyBuffer(Buffer sourceBuffer, Buffer destinationBuffer, ArrayProxy<BufferCopy>? regions)
        {
            try
            {
                BufferCopy* marshalledRegions = default;
                if (regions.IsNull())
                {
                    marshalledRegions = null;
                }
                else
                {
                    if (regions.Value.Contents == ProxyContents.Single)
                    {
                        marshalledRegions = (BufferCopy*)(Interop.HeapUtil.Allocate<BufferCopy>());
                        *(BufferCopy*)(marshalledRegions) = regions.Value.GetSingleValue();
                    }
                    else
                    {
                        var fieldPointer = (BufferCopy*)(Interop.HeapUtil.AllocateAndClear<BufferCopy>(Interop.HeapUtil.GetLength(regions.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(regions.Value)); index++)
                        {
                            fieldPointer[index] = regions.Value[index];
                        }
                        marshalledRegions = fieldPointer;
                    }
                }
                Interop.VkCommandBufferCopyBufferDelegate commandDelegate = commandCache.Cache.vkCmdCopyBuffer;
                commandDelegate(Handle, sourceBuffer?.Handle ?? default, destinationBuffer?.Handle ?? default, (uint)(Interop.HeapUtil.GetLength(regions)), marshalledRegions);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Copy data between images.
        /// </summary>
        /// <param name="sourceImage">
        /// </param>
        /// <param name="sourceImageLayout">
        /// </param>
        /// <param name="destinationImage">
        /// </param>
        /// <param name="destinationImageLayout">
        /// </param>
        /// <param name="regions">
        /// </param>
        public unsafe void CopyImage(Image sourceImage, ImageLayout sourceImageLayout, Image destinationImage, ImageLayout destinationImageLayout, ArrayProxy<ImageCopy>? regions)
        {
            try
            {
                ImageCopy* marshalledRegions = default;
                if (regions.IsNull())
                {
                    marshalledRegions = null;
                }
                else
                {
                    if (regions.Value.Contents == ProxyContents.Single)
                    {
                        marshalledRegions = (ImageCopy*)(Interop.HeapUtil.Allocate<ImageCopy>());
                        *(ImageCopy*)(marshalledRegions) = regions.Value.GetSingleValue();
                    }
                    else
                    {
                        var fieldPointer = (ImageCopy*)(Interop.HeapUtil.AllocateAndClear<ImageCopy>(Interop.HeapUtil.GetLength(regions.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(regions.Value)); index++)
                        {
                            fieldPointer[index] = regions.Value[index];
                        }
                        marshalledRegions = fieldPointer;
                    }
                }
                Interop.VkCommandBufferCopyImageDelegate commandDelegate = commandCache.Cache.vkCmdCopyImage;
                commandDelegate(Handle, sourceImage?.Handle ?? default, sourceImageLayout, destinationImage?.Handle ?? default, destinationImageLayout, (uint)(Interop.HeapUtil.GetLength(regions)), marshalledRegions);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Copy regions of an image, potentially performing format
        /// conversion,.
        /// </summary>
        /// <param name="sourceImage">
        /// </param>
        /// <param name="sourceImageLayout">
        /// </param>
        /// <param name="destinationImage">
        /// </param>
        /// <param name="destinationImageLayout">
        /// </param>
        /// <param name="regions">
        /// </param>
        /// <param name="filter">
        /// </param>
        public unsafe void BlitImage(Image sourceImage, ImageLayout sourceImageLayout, Image destinationImage, ImageLayout destinationImageLayout, ArrayProxy<ImageBlit>? regions, Filter filter)
        {
            try
            {
                SharpVk.Interop.ImageBlit* marshalledRegions = default;
                if (regions.IsNull())
                {
                    marshalledRegions = null;
                }
                else
                {
                    if (regions.Value.Contents == ProxyContents.Single)
                    {
                        marshalledRegions = (SharpVk.Interop.ImageBlit*)(Interop.HeapUtil.Allocate<SharpVk.Interop.ImageBlit>());
                        regions.Value.GetSingleValue().MarshalTo(&*(SharpVk.Interop.ImageBlit*)(marshalledRegions));
                    }
                    else
                    {
                        var fieldPointer = (SharpVk.Interop.ImageBlit*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.ImageBlit>(Interop.HeapUtil.GetLength(regions.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(regions.Value)); index++)
                        {
                            regions.Value[index].MarshalTo(&fieldPointer[index]);
                        }
                        marshalledRegions = fieldPointer;
                    }
                }
                Interop.VkCommandBufferBlitImageDelegate commandDelegate = commandCache.Cache.vkCmdBlitImage;
                commandDelegate(Handle, sourceImage?.Handle ?? default, sourceImageLayout, destinationImage?.Handle ?? default, destinationImageLayout, (uint)(Interop.HeapUtil.GetLength(regions)), marshalledRegions, filter);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Copy data from a buffer into an image.
        /// </summary>
        /// <param name="sourceBuffer">
        /// </param>
        /// <param name="destinationImage">
        /// </param>
        /// <param name="destinationImageLayout">
        /// </param>
        /// <param name="regions">
        /// </param>
        public unsafe void CopyBufferToImage(Buffer sourceBuffer, Image destinationImage, ImageLayout destinationImageLayout, ArrayProxy<BufferImageCopy>? regions)
        {
            try
            {
                BufferImageCopy* marshalledRegions = default;
                if (regions.IsNull())
                {
                    marshalledRegions = null;
                }
                else
                {
                    if (regions.Value.Contents == ProxyContents.Single)
                    {
                        marshalledRegions = (BufferImageCopy*)(Interop.HeapUtil.Allocate<BufferImageCopy>());
                        *(BufferImageCopy*)(marshalledRegions) = regions.Value.GetSingleValue();
                    }
                    else
                    {
                        var fieldPointer = (BufferImageCopy*)(Interop.HeapUtil.AllocateAndClear<BufferImageCopy>(Interop.HeapUtil.GetLength(regions.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(regions.Value)); index++)
                        {
                            fieldPointer[index] = regions.Value[index];
                        }
                        marshalledRegions = fieldPointer;
                    }
                }
                Interop.VkCommandBufferCopyBufferToImageDelegate commandDelegate = commandCache.Cache.vkCmdCopyBufferToImage;
                commandDelegate(Handle, sourceBuffer?.Handle ?? default, destinationImage?.Handle ?? default, destinationImageLayout, (uint)(Interop.HeapUtil.GetLength(regions)), marshalledRegions);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Copy image data into a buffer.
        /// </summary>
        /// <param name="sourceImage">
        /// </param>
        /// <param name="sourceImageLayout">
        /// </param>
        /// <param name="destinationBuffer">
        /// </param>
        /// <param name="regions">
        /// </param>
        public unsafe void CopyImageToBuffer(Image sourceImage, ImageLayout sourceImageLayout, Buffer destinationBuffer, ArrayProxy<BufferImageCopy>? regions)
        {
            try
            {
                BufferImageCopy* marshalledRegions = default;
                if (regions.IsNull())
                {
                    marshalledRegions = null;
                }
                else
                {
                    if (regions.Value.Contents == ProxyContents.Single)
                    {
                        marshalledRegions = (BufferImageCopy*)(Interop.HeapUtil.Allocate<BufferImageCopy>());
                        *(BufferImageCopy*)(marshalledRegions) = regions.Value.GetSingleValue();
                    }
                    else
                    {
                        var fieldPointer = (BufferImageCopy*)(Interop.HeapUtil.AllocateAndClear<BufferImageCopy>(Interop.HeapUtil.GetLength(regions.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(regions.Value)); index++)
                        {
                            fieldPointer[index] = regions.Value[index];
                        }
                        marshalledRegions = fieldPointer;
                    }
                }
                Interop.VkCommandBufferCopyImageToBufferDelegate commandDelegate = commandCache.Cache.vkCmdCopyImageToBuffer;
                commandDelegate(Handle, sourceImage?.Handle ?? default, sourceImageLayout, destinationBuffer?.Handle ?? default, (uint)(Interop.HeapUtil.GetLength(regions)), marshalledRegions);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Update a buffer's contents from host memory.
        /// </summary>
        /// <param name="destinationBuffer">
        /// </param>
        /// <param name="destinationOffset">
        /// </param>
        /// <param name="data">
        /// </param>
        public unsafe void UpdateBuffer(Buffer destinationBuffer, ulong destinationOffset, ArrayProxy<byte>? data)
        {
            try
            {
                byte* marshalledData = default;
                if (data.IsNull())
                {
                    marshalledData = null;
                }
                else
                {
                    if (data.Value.Contents == ProxyContents.Single)
                    {
                        marshalledData = (byte*)(Interop.HeapUtil.Allocate<byte>());
                        *(byte*)(marshalledData) = data.Value.GetSingleValue();
                    }
                    else
                    {
                        var fieldPointer = (byte*)(Interop.HeapUtil.AllocateAndClear<byte>(Interop.HeapUtil.GetLength(data.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(data.Value)); index++)
                        {
                            fieldPointer[index] = data.Value[index];
                        }
                        marshalledData = fieldPointer;
                    }
                }
                Interop.VkCommandBufferUpdateBufferDelegate commandDelegate = commandCache.Cache.vkCmdUpdateBuffer;
                commandDelegate(Handle, destinationBuffer?.Handle ?? default, destinationOffset, (ulong)(Interop.HeapUtil.GetLength(data)), marshalledData);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Fill a region of a buffer with a fixed value.
        /// </summary>
        /// <param name="destinationBuffer">
        /// </param>
        /// <param name="destinationOffset">
        /// </param>
        /// <param name="size">
        /// </param>
        /// <param name="data">
        /// </param>
        public unsafe void FillBuffer(Buffer destinationBuffer, ulong destinationOffset, ulong size, uint data)
        {
            try
            {
                Interop.VkCommandBufferFillBufferDelegate commandDelegate = commandCache.Cache.vkCmdFillBuffer;
                commandDelegate(Handle, destinationBuffer?.Handle ?? default, destinationOffset, size, data);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Clear regions of a color image.
        /// </summary>
        /// <param name="image">
        /// </param>
        /// <param name="imageLayout">
        /// </param>
        /// <param name="color">
        /// </param>
        /// <param name="ranges">
        /// </param>
        public unsafe void ClearColorImage(Image image, ImageLayout imageLayout, ClearColorValue color, ArrayProxy<ImageSubresourceRange>? ranges)
        {
            try
            {
                ClearColorValue* marshalledColor = default;
                ImageSubresourceRange* marshalledRanges = default;
                marshalledColor = (ClearColorValue*)(Interop.HeapUtil.Allocate<ClearColorValue>());
                *marshalledColor = color;
                if (ranges.IsNull())
                {
                    marshalledRanges = null;
                }
                else
                {
                    if (ranges.Value.Contents == ProxyContents.Single)
                    {
                        marshalledRanges = (ImageSubresourceRange*)(Interop.HeapUtil.Allocate<ImageSubresourceRange>());
                        *(ImageSubresourceRange*)(marshalledRanges) = ranges.Value.GetSingleValue();
                    }
                    else
                    {
                        var fieldPointer = (ImageSubresourceRange*)(Interop.HeapUtil.AllocateAndClear<ImageSubresourceRange>(Interop.HeapUtil.GetLength(ranges.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(ranges.Value)); index++)
                        {
                            fieldPointer[index] = ranges.Value[index];
                        }
                        marshalledRanges = fieldPointer;
                    }
                }
                Interop.VkCommandBufferClearColorImageDelegate commandDelegate = commandCache.Cache.vkCmdClearColorImage;
                commandDelegate(Handle, image?.Handle ?? default, imageLayout, marshalledColor, (uint)(Interop.HeapUtil.GetLength(ranges)), marshalledRanges);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Fill regions of a combined depth/stencil image.
        /// </summary>
        /// <param name="image">
        /// </param>
        /// <param name="imageLayout">
        /// </param>
        /// <param name="depthStencil">
        /// </param>
        /// <param name="ranges">
        /// </param>
        public unsafe void ClearDepthStencilImage(Image image, ImageLayout imageLayout, ClearDepthStencilValue depthStencil, ArrayProxy<ImageSubresourceRange>? ranges)
        {
            try
            {
                ClearDepthStencilValue* marshalledDepthStencil = default;
                ImageSubresourceRange* marshalledRanges = default;
                marshalledDepthStencil = (ClearDepthStencilValue*)(Interop.HeapUtil.Allocate<ClearDepthStencilValue>());
                *marshalledDepthStencil = depthStencil;
                if (ranges.IsNull())
                {
                    marshalledRanges = null;
                }
                else
                {
                    if (ranges.Value.Contents == ProxyContents.Single)
                    {
                        marshalledRanges = (ImageSubresourceRange*)(Interop.HeapUtil.Allocate<ImageSubresourceRange>());
                        *(ImageSubresourceRange*)(marshalledRanges) = ranges.Value.GetSingleValue();
                    }
                    else
                    {
                        var fieldPointer = (ImageSubresourceRange*)(Interop.HeapUtil.AllocateAndClear<ImageSubresourceRange>(Interop.HeapUtil.GetLength(ranges.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(ranges.Value)); index++)
                        {
                            fieldPointer[index] = ranges.Value[index];
                        }
                        marshalledRanges = fieldPointer;
                    }
                }
                Interop.VkCommandBufferClearDepthStencilImageDelegate commandDelegate = commandCache.Cache.vkCmdClearDepthStencilImage;
                commandDelegate(Handle, image?.Handle ?? default, imageLayout, marshalledDepthStencil, (uint)(Interop.HeapUtil.GetLength(ranges)), marshalledRanges);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Clear regions within currently bound framebuffer attachments.
        /// </summary>
        /// <param name="attachments">
        /// </param>
        /// <param name="rects">
        /// </param>
        public unsafe void ClearAttachments(ArrayProxy<ClearAttachment>? attachments, ArrayProxy<ClearRect>? rects)
        {
            try
            {
                ClearAttachment* marshalledAttachments = default;
                ClearRect* marshalledRects = default;
                if (attachments.IsNull())
                {
                    marshalledAttachments = null;
                }
                else
                {
                    if (attachments.Value.Contents == ProxyContents.Single)
                    {
                        marshalledAttachments = (ClearAttachment*)(Interop.HeapUtil.Allocate<ClearAttachment>());
                        *(ClearAttachment*)(marshalledAttachments) = attachments.Value.GetSingleValue();
                    }
                    else
                    {
                        var fieldPointer = (ClearAttachment*)(Interop.HeapUtil.AllocateAndClear<ClearAttachment>(Interop.HeapUtil.GetLength(attachments.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(attachments.Value)); index++)
                        {
                            fieldPointer[index] = attachments.Value[index];
                        }
                        marshalledAttachments = fieldPointer;
                    }
                }
                if (rects.IsNull())
                {
                    marshalledRects = null;
                }
                else
                {
                    if (rects.Value.Contents == ProxyContents.Single)
                    {
                        marshalledRects = (ClearRect*)(Interop.HeapUtil.Allocate<ClearRect>());
                        *(ClearRect*)(marshalledRects) = rects.Value.GetSingleValue();
                    }
                    else
                    {
                        var fieldPointer = (ClearRect*)(Interop.HeapUtil.AllocateAndClear<ClearRect>(Interop.HeapUtil.GetLength(rects.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(rects.Value)); index++)
                        {
                            fieldPointer[index] = rects.Value[index];
                        }
                        marshalledRects = fieldPointer;
                    }
                }
                Interop.VkCommandBufferClearAttachmentsDelegate commandDelegate = commandCache.Cache.vkCmdClearAttachments;
                commandDelegate(Handle, (uint)(Interop.HeapUtil.GetLength(attachments)), marshalledAttachments, (uint)(Interop.HeapUtil.GetLength(rects)), marshalledRects);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Resolve regions of an image.
        /// </summary>
        /// <param name="sourceImage">
        /// </param>
        /// <param name="sourceImageLayout">
        /// </param>
        /// <param name="destinationImage">
        /// </param>
        /// <param name="destinationImageLayout">
        /// </param>
        /// <param name="regions">
        /// </param>
        public unsafe void ResolveImage(Image sourceImage, ImageLayout sourceImageLayout, Image destinationImage, ImageLayout destinationImageLayout, ArrayProxy<ImageResolve>? regions)
        {
            try
            {
                ImageResolve* marshalledRegions = default;
                if (regions.IsNull())
                {
                    marshalledRegions = null;
                }
                else
                {
                    if (regions.Value.Contents == ProxyContents.Single)
                    {
                        marshalledRegions = (ImageResolve*)(Interop.HeapUtil.Allocate<ImageResolve>());
                        *(ImageResolve*)(marshalledRegions) = regions.Value.GetSingleValue();
                    }
                    else
                    {
                        var fieldPointer = (ImageResolve*)(Interop.HeapUtil.AllocateAndClear<ImageResolve>(Interop.HeapUtil.GetLength(regions.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(regions.Value)); index++)
                        {
                            fieldPointer[index] = regions.Value[index];
                        }
                        marshalledRegions = fieldPointer;
                    }
                }
                Interop.VkCommandBufferResolveImageDelegate commandDelegate = commandCache.Cache.vkCmdResolveImage;
                commandDelegate(Handle, sourceImage?.Handle ?? default, sourceImageLayout, destinationImage?.Handle ?? default, destinationImageLayout, (uint)(Interop.HeapUtil.GetLength(regions)), marshalledRegions);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Set an event object to signaled state.
        /// </summary>
        /// <param name="event">
        /// </param>
        /// <param name="stageMask">
        /// </param>
        public unsafe void SetEvent(Event @event, PipelineStageFlags stageMask)
        {
            try
            {
                Interop.VkCommandBufferSetEventDelegate commandDelegate = commandCache.Cache.vkCmdSetEvent;
                commandDelegate(Handle, @event?.Handle ?? default, stageMask);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Reset an event object to non-signaled state.
        /// </summary>
        /// <param name="event">
        /// </param>
        /// <param name="stageMask">
        /// </param>
        public unsafe void ResetEvent(Event @event, PipelineStageFlags stageMask)
        {
            try
            {
                Interop.VkCommandBufferResetEventDelegate commandDelegate = commandCache.Cache.vkCmdResetEvent;
                commandDelegate(Handle, @event?.Handle ?? default, stageMask);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Wait for one or more events and insert a set of memory.
        /// </summary>
        /// <param name="events">
        /// </param>
        /// <param name="sourceStageMask">
        /// </param>
        /// <param name="destinationStageMask">
        /// </param>
        /// <param name="memoryBarriers">
        /// </param>
        /// <param name="bufferMemoryBarriers">
        /// </param>
        /// <param name="imageMemoryBarriers">
        /// </param>
        public unsafe void WaitEvents(ArrayProxy<Event>? events, PipelineStageFlags sourceStageMask, PipelineStageFlags destinationStageMask, ArrayProxy<MemoryBarrier>? memoryBarriers, ArrayProxy<BufferMemoryBarrier>? bufferMemoryBarriers, ArrayProxy<ImageMemoryBarrier>? imageMemoryBarriers)
        {
            try
            {
                SharpVk.Interop.Event* marshalledEvents = default;
                SharpVk.Interop.MemoryBarrier* marshalledMemoryBarriers = default;
                SharpVk.Interop.BufferMemoryBarrier* marshalledBufferMemoryBarriers = default;
                SharpVk.Interop.ImageMemoryBarrier* marshalledImageMemoryBarriers = default;
                if (events.IsNull())
                {
                    marshalledEvents = null;
                }
                else
                {
                    if (events.Value.Contents == ProxyContents.Single)
                    {
                        marshalledEvents = (SharpVk.Interop.Event*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Event>());
                        *(SharpVk.Interop.Event*)(marshalledEvents) = events.Value.GetSingleValue()?.Handle ?? default;
                    }
                    else
                    {
                        var fieldPointer = (SharpVk.Interop.Event*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.Event>(Interop.HeapUtil.GetLength(events.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(events.Value)); index++)
                        {
                            fieldPointer[index] = events.Value[index]?.Handle ?? default;
                        }
                        marshalledEvents = fieldPointer;
                    }
                }
                if (memoryBarriers.IsNull())
                {
                    marshalledMemoryBarriers = null;
                }
                else
                {
                    if (memoryBarriers.Value.Contents == ProxyContents.Single)
                    {
                        marshalledMemoryBarriers = (SharpVk.Interop.MemoryBarrier*)(Interop.HeapUtil.Allocate<SharpVk.Interop.MemoryBarrier>());
                        memoryBarriers.Value.GetSingleValue().MarshalTo(&*(SharpVk.Interop.MemoryBarrier*)(marshalledMemoryBarriers));
                    }
                    else
                    {
                        var fieldPointer = (SharpVk.Interop.MemoryBarrier*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.MemoryBarrier>(Interop.HeapUtil.GetLength(memoryBarriers.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(memoryBarriers.Value)); index++)
                        {
                            memoryBarriers.Value[index].MarshalTo(&fieldPointer[index]);
                        }
                        marshalledMemoryBarriers = fieldPointer;
                    }
                }
                if (bufferMemoryBarriers.IsNull())
                {
                    marshalledBufferMemoryBarriers = null;
                }
                else
                {
                    if (bufferMemoryBarriers.Value.Contents == ProxyContents.Single)
                    {
                        marshalledBufferMemoryBarriers = (SharpVk.Interop.BufferMemoryBarrier*)(Interop.HeapUtil.Allocate<SharpVk.Interop.BufferMemoryBarrier>());
                        bufferMemoryBarriers.Value.GetSingleValue().MarshalTo(&*(SharpVk.Interop.BufferMemoryBarrier*)(marshalledBufferMemoryBarriers));
                    }
                    else
                    {
                        var fieldPointer = (SharpVk.Interop.BufferMemoryBarrier*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.BufferMemoryBarrier>(Interop.HeapUtil.GetLength(bufferMemoryBarriers.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(bufferMemoryBarriers.Value)); index++)
                        {
                            bufferMemoryBarriers.Value[index].MarshalTo(&fieldPointer[index]);
                        }
                        marshalledBufferMemoryBarriers = fieldPointer;
                    }
                }
                if (imageMemoryBarriers.IsNull())
                {
                    marshalledImageMemoryBarriers = null;
                }
                else
                {
                    if (imageMemoryBarriers.Value.Contents == ProxyContents.Single)
                    {
                        marshalledImageMemoryBarriers = (SharpVk.Interop.ImageMemoryBarrier*)(Interop.HeapUtil.Allocate<SharpVk.Interop.ImageMemoryBarrier>());
                        imageMemoryBarriers.Value.GetSingleValue().MarshalTo(&*(SharpVk.Interop.ImageMemoryBarrier*)(marshalledImageMemoryBarriers));
                    }
                    else
                    {
                        var fieldPointer = (SharpVk.Interop.ImageMemoryBarrier*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.ImageMemoryBarrier>(Interop.HeapUtil.GetLength(imageMemoryBarriers.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(imageMemoryBarriers.Value)); index++)
                        {
                            imageMemoryBarriers.Value[index].MarshalTo(&fieldPointer[index]);
                        }
                        marshalledImageMemoryBarriers = fieldPointer;
                    }
                }
                Interop.VkCommandBufferWaitEventsDelegate commandDelegate = commandCache.Cache.vkCmdWaitEvents;
                commandDelegate(Handle, (uint)(Interop.HeapUtil.GetLength(events)), marshalledEvents, sourceStageMask, destinationStageMask, (uint)(Interop.HeapUtil.GetLength(memoryBarriers)), marshalledMemoryBarriers, (uint)(Interop.HeapUtil.GetLength(bufferMemoryBarriers)), marshalledBufferMemoryBarriers, (uint)(Interop.HeapUtil.GetLength(imageMemoryBarriers)), marshalledImageMemoryBarriers);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Insert a memory dependency.
        /// </summary>
        /// <param name="sourceStageMask">
        /// </param>
        /// <param name="destinationStageMask">
        /// </param>
        /// <param name="dependencyFlags">
        /// </param>
        /// <param name="memoryBarriers">
        /// </param>
        /// <param name="bufferMemoryBarriers">
        /// </param>
        /// <param name="imageMemoryBarriers">
        /// </param>
        public unsafe void PipelineBarrier(PipelineStageFlags sourceStageMask, PipelineStageFlags destinationStageMask, ArrayProxy<MemoryBarrier>? memoryBarriers, ArrayProxy<BufferMemoryBarrier>? bufferMemoryBarriers, ArrayProxy<ImageMemoryBarrier>? imageMemoryBarriers, DependencyFlags? dependencyFlags = default)
        {
            try
            {
                DependencyFlags marshalledDependencyFlags = default;
                SharpVk.Interop.MemoryBarrier* marshalledMemoryBarriers = default;
                SharpVk.Interop.BufferMemoryBarrier* marshalledBufferMemoryBarriers = default;
                SharpVk.Interop.ImageMemoryBarrier* marshalledImageMemoryBarriers = default;
                if (dependencyFlags != null)
                {
                    marshalledDependencyFlags = dependencyFlags.Value;
                }
                else
                {
                    marshalledDependencyFlags = default;
                }
                if (memoryBarriers.IsNull())
                {
                    marshalledMemoryBarriers = null;
                }
                else
                {
                    if (memoryBarriers.Value.Contents == ProxyContents.Single)
                    {
                        marshalledMemoryBarriers = (SharpVk.Interop.MemoryBarrier*)(Interop.HeapUtil.Allocate<SharpVk.Interop.MemoryBarrier>());
                        memoryBarriers.Value.GetSingleValue().MarshalTo(&*(SharpVk.Interop.MemoryBarrier*)(marshalledMemoryBarriers));
                    }
                    else
                    {
                        var fieldPointer = (SharpVk.Interop.MemoryBarrier*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.MemoryBarrier>(Interop.HeapUtil.GetLength(memoryBarriers.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(memoryBarriers.Value)); index++)
                        {
                            memoryBarriers.Value[index].MarshalTo(&fieldPointer[index]);
                        }
                        marshalledMemoryBarriers = fieldPointer;
                    }
                }
                if (bufferMemoryBarriers.IsNull())
                {
                    marshalledBufferMemoryBarriers = null;
                }
                else
                {
                    if (bufferMemoryBarriers.Value.Contents == ProxyContents.Single)
                    {
                        marshalledBufferMemoryBarriers = (SharpVk.Interop.BufferMemoryBarrier*)(Interop.HeapUtil.Allocate<SharpVk.Interop.BufferMemoryBarrier>());
                        bufferMemoryBarriers.Value.GetSingleValue().MarshalTo(&*(SharpVk.Interop.BufferMemoryBarrier*)(marshalledBufferMemoryBarriers));
                    }
                    else
                    {
                        var fieldPointer = (SharpVk.Interop.BufferMemoryBarrier*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.BufferMemoryBarrier>(Interop.HeapUtil.GetLength(bufferMemoryBarriers.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(bufferMemoryBarriers.Value)); index++)
                        {
                            bufferMemoryBarriers.Value[index].MarshalTo(&fieldPointer[index]);
                        }
                        marshalledBufferMemoryBarriers = fieldPointer;
                    }
                }
                if (imageMemoryBarriers.IsNull())
                {
                    marshalledImageMemoryBarriers = null;
                }
                else
                {
                    if (imageMemoryBarriers.Value.Contents == ProxyContents.Single)
                    {
                        marshalledImageMemoryBarriers = (SharpVk.Interop.ImageMemoryBarrier*)(Interop.HeapUtil.Allocate<SharpVk.Interop.ImageMemoryBarrier>());
                        imageMemoryBarriers.Value.GetSingleValue().MarshalTo(&*(SharpVk.Interop.ImageMemoryBarrier*)(marshalledImageMemoryBarriers));
                    }
                    else
                    {
                        var fieldPointer = (SharpVk.Interop.ImageMemoryBarrier*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.ImageMemoryBarrier>(Interop.HeapUtil.GetLength(imageMemoryBarriers.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(imageMemoryBarriers.Value)); index++)
                        {
                            imageMemoryBarriers.Value[index].MarshalTo(&fieldPointer[index]);
                        }
                        marshalledImageMemoryBarriers = fieldPointer;
                    }
                }
                Interop.VkCommandBufferPipelineBarrierDelegate commandDelegate = commandCache.Cache.vkCmdPipelineBarrier;
                commandDelegate(Handle, sourceStageMask, destinationStageMask, marshalledDependencyFlags, (uint)(Interop.HeapUtil.GetLength(memoryBarriers)), marshalledMemoryBarriers, (uint)(Interop.HeapUtil.GetLength(bufferMemoryBarriers)), marshalledBufferMemoryBarriers, (uint)(Interop.HeapUtil.GetLength(imageMemoryBarriers)), marshalledImageMemoryBarriers);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Begin a query.
        /// </summary>
        /// <param name="queryPool">
        /// </param>
        /// <param name="query">
        /// </param>
        /// <param name="flags">
        /// </param>
        public unsafe void BeginQuery(QueryPool queryPool, uint query, QueryControlFlags? flags = default)
        {
            try
            {
                QueryControlFlags marshalledFlags = default;
                if (flags != null)
                {
                    marshalledFlags = flags.Value;
                }
                else
                {
                    marshalledFlags = default;
                }
                Interop.VkCommandBufferBeginQueryDelegate commandDelegate = commandCache.Cache.vkCmdBeginQuery;
                commandDelegate(Handle, queryPool?.Handle ?? default, query, marshalledFlags);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Ends a query.
        /// </summary>
        /// <param name="queryPool">
        /// </param>
        /// <param name="query">
        /// </param>
        public unsafe void EndQuery(QueryPool queryPool, uint query)
        {
            try
            {
                Interop.VkCommandBufferEndQueryDelegate commandDelegate = commandCache.Cache.vkCmdEndQuery;
                commandDelegate(Handle, queryPool?.Handle ?? default, query);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Reset queries in a query pool.
        /// </summary>
        /// <param name="queryPool">
        /// </param>
        /// <param name="firstQuery">
        /// </param>
        /// <param name="queryCount">
        /// </param>
        public unsafe void ResetQueryPool(QueryPool queryPool, uint firstQuery, uint queryCount)
        {
            try
            {
                Interop.VkCommandBufferResetQueryPoolDelegate commandDelegate = commandCache.Cache.vkCmdResetQueryPool;
                commandDelegate(Handle, queryPool?.Handle ?? default, firstQuery, queryCount);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Write a device timestamp into a query object.
        /// </summary>
        /// <param name="pipelineStage">
        /// </param>
        /// <param name="queryPool">
        /// </param>
        /// <param name="query">
        /// </param>
        public unsafe void WriteTimestamp(PipelineStageFlags pipelineStage, QueryPool queryPool, uint query)
        {
            try
            {
                Interop.VkCommandBufferWriteTimestampDelegate commandDelegate = commandCache.Cache.vkCmdWriteTimestamp;
                commandDelegate(Handle, pipelineStage, queryPool?.Handle ?? default, query);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Copy the results of queries in a query pool to a buffer object.
        /// </summary>
        /// <param name="queryPool">
        /// </param>
        /// <param name="firstQuery">
        /// </param>
        /// <param name="queryCount">
        /// </param>
        /// <param name="destinationBuffer">
        /// </param>
        /// <param name="destinationOffset">
        /// </param>
        /// <param name="stride">
        /// </param>
        /// <param name="flags">
        /// </param>
        public unsafe void CopyQueryPoolResults(QueryPool queryPool, uint firstQuery, uint queryCount, Buffer destinationBuffer, ulong destinationOffset, ulong stride, QueryResultFlags? flags = default)
        {
            try
            {
                QueryResultFlags marshalledFlags = default;
                if (flags != null)
                {
                    marshalledFlags = flags.Value;
                }
                else
                {
                    marshalledFlags = default;
                }
                Interop.VkCommandBufferCopyQueryPoolResultsDelegate commandDelegate = commandCache.Cache.vkCmdCopyQueryPoolResults;
                commandDelegate(Handle, queryPool?.Handle ?? default, firstQuery, queryCount, destinationBuffer?.Handle ?? default, destinationOffset, stride, marshalledFlags);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Update the values of push constants.
        /// </summary>
        /// <param name="layout">
        /// </param>
        /// <param name="stageFlags">
        /// </param>
        /// <param name="offset">
        /// </param>
        /// <param name="values">
        /// </param>
        public unsafe void PushConstants(PipelineLayout layout, ShaderStageFlags stageFlags, uint offset, ArrayProxy<byte>? values)
        {
            try
            {
                byte* marshalledValues = default;
                if (values.IsNull())
                {
                    marshalledValues = null;
                }
                else
                {
                    if (values.Value.Contents == ProxyContents.Single)
                    {
                        marshalledValues = (byte*)(Interop.HeapUtil.Allocate<byte>());
                        *(byte*)(marshalledValues) = values.Value.GetSingleValue();
                    }
                    else
                    {
                        var fieldPointer = (byte*)(Interop.HeapUtil.AllocateAndClear<byte>(Interop.HeapUtil.GetLength(values.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(values.Value)); index++)
                        {
                            fieldPointer[index] = values.Value[index];
                        }
                        marshalledValues = fieldPointer;
                    }
                }
                Interop.VkCommandBufferPushConstantsDelegate commandDelegate = commandCache.Cache.vkCmdPushConstants;
                commandDelegate(Handle, layout?.Handle ?? default, stageFlags, offset, (uint)(Interop.HeapUtil.GetLength(values)), marshalledValues);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Begin a new render pass.
        /// </summary>
        /// <param name="renderPass">
        /// The render pass to begin an instance of.
        /// </param>
        /// <param name="framebuffer">
        /// The framebuffer containing the attachments that are used with the
        /// render pass.
        /// </param>
        /// <param name="renderArea">
        /// The render area that is affected by the render pass instance, and
        /// is described in more detail below.
        /// </param>
        /// <param name="clearValues">
        /// </param>
        /// <param name="deviceGroupRenderPassBeginInfo">
        /// Extension struct
        /// </param>
        /// <param name="renderPassSampleLocationsBeginInfoExt">
        /// Extension struct
        /// </param>
        /// <param name="renderPassAttachmentBeginInfo">
        /// Extension struct
        /// </param>
        /// <param name="renderPassTransformBeginInfoQcom">
        /// Extension struct
        /// </param>
        /// <param name="contents">
        /// </param>
        public unsafe void BeginRenderPass(RenderPass renderPass, Framebuffer framebuffer, Rect2D renderArea, ArrayProxy<ClearValue>? clearValues, SubpassContents contents, DeviceGroupRenderPassBeginInfo? deviceGroupRenderPassBeginInfo = null, Multivendor.RenderPassSampleLocationsBeginInfo? renderPassSampleLocationsBeginInfoExt = null, RenderPassAttachmentBeginInfo? renderPassAttachmentBeginInfo = null, Qcom.RenderPassTransformBeginInfo? renderPassTransformBeginInfoQcom = null)
        {
            try
            {
                SharpVk.Interop.RenderPassBeginInfo* marshalledRenderPassBegin = default;
                void* vkRenderPassBeginInfoNextPointer = default;
                if (deviceGroupRenderPassBeginInfo != null)
                {
                    SharpVk.Interop.DeviceGroupRenderPassBeginInfo* extensionPointer = default;
                    extensionPointer = (SharpVk.Interop.DeviceGroupRenderPassBeginInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.DeviceGroupRenderPassBeginInfo>());
                    deviceGroupRenderPassBeginInfo.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkRenderPassBeginInfoNextPointer;
                    vkRenderPassBeginInfoNextPointer = extensionPointer;
                }
                if (renderPassSampleLocationsBeginInfoExt != null)
                {
                    SharpVk.Interop.Multivendor.RenderPassSampleLocationsBeginInfo* extensionPointer = default;
                    extensionPointer = (SharpVk.Interop.Multivendor.RenderPassSampleLocationsBeginInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.RenderPassSampleLocationsBeginInfo>());
                    renderPassSampleLocationsBeginInfoExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkRenderPassBeginInfoNextPointer;
                    vkRenderPassBeginInfoNextPointer = extensionPointer;
                }
                if (renderPassAttachmentBeginInfo != null)
                {
                    SharpVk.Interop.RenderPassAttachmentBeginInfo* extensionPointer = default;
                    extensionPointer = (SharpVk.Interop.RenderPassAttachmentBeginInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.RenderPassAttachmentBeginInfo>());
                    renderPassAttachmentBeginInfo.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkRenderPassBeginInfoNextPointer;
                    vkRenderPassBeginInfoNextPointer = extensionPointer;
                }
                if (renderPassTransformBeginInfoQcom != null)
                {
                    SharpVk.Interop.Qcom.RenderPassTransformBeginInfo* extensionPointer = default;
                    extensionPointer = (SharpVk.Interop.Qcom.RenderPassTransformBeginInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Qcom.RenderPassTransformBeginInfo>());
                    renderPassTransformBeginInfoQcom.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkRenderPassBeginInfoNextPointer;
                    vkRenderPassBeginInfoNextPointer = extensionPointer;
                }
                marshalledRenderPassBegin = (SharpVk.Interop.RenderPassBeginInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.RenderPassBeginInfo>());
                marshalledRenderPassBegin->SType = StructureType.RenderPassBeginInfo;
                marshalledRenderPassBegin->Next = vkRenderPassBeginInfoNextPointer;
                marshalledRenderPassBegin->RenderPass = renderPass?.Handle ?? default;
                marshalledRenderPassBegin->Framebuffer = framebuffer?.Handle ?? default;
                marshalledRenderPassBegin->RenderArea = renderArea;
                marshalledRenderPassBegin->ClearValueCount = (uint)(Interop.HeapUtil.GetLength(clearValues));
                if (clearValues.IsNull())
                {
                    marshalledRenderPassBegin->ClearValues = null;
                }
                else
                {
                    if (clearValues.Value.Contents == ProxyContents.Single)
                    {
                        marshalledRenderPassBegin->ClearValues = (ClearValue*)(Interop.HeapUtil.Allocate<ClearValue>());
                        *(ClearValue*)(marshalledRenderPassBegin->ClearValues) = clearValues.Value.GetSingleValue();
                    }
                    else
                    {
                        var fieldPointer = (ClearValue*)(Interop.HeapUtil.AllocateAndClear<ClearValue>(Interop.HeapUtil.GetLength(clearValues.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(clearValues.Value)); index++)
                        {
                            fieldPointer[index] = clearValues.Value[index];
                        }
                        marshalledRenderPassBegin->ClearValues = fieldPointer;
                    }
                }
                Interop.VkCommandBufferBeginRenderPassDelegate commandDelegate = commandCache.Cache.vkCmdBeginRenderPass;
                commandDelegate(Handle, marshalledRenderPassBegin, contents);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Transition to the next subpass of a render pass.
        /// </summary>
        /// <param name="contents">
        /// </param>
        public unsafe void NextSubpass(SubpassContents contents)
        {
            try
            {
                Interop.VkCommandBufferNextSubpassDelegate commandDelegate = commandCache.Cache.vkCmdNextSubpass;
                commandDelegate(Handle, contents);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// End the current render pass.
        /// </summary>
        public unsafe void EndRenderPass()
        {
            try
            {
                Interop.VkCommandBufferEndRenderPassDelegate commandDelegate = commandCache.Cache.vkCmdEndRenderPass;
                commandDelegate(Handle);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Execute a secondary command buffer from a primary command buffer.
        /// </summary>
        /// <param name="commandBuffers">
        /// </param>
        public unsafe void ExecuteCommands(ArrayProxy<CommandBuffer>? commandBuffers)
        {
            try
            {
                SharpVk.Interop.CommandBuffer* marshalledCommandBuffers = default;
                if (commandBuffers.IsNull())
                {
                    marshalledCommandBuffers = null;
                }
                else
                {
                    if (commandBuffers.Value.Contents == ProxyContents.Single)
                    {
                        marshalledCommandBuffers = (SharpVk.Interop.CommandBuffer*)(Interop.HeapUtil.Allocate<SharpVk.Interop.CommandBuffer>());
                        *(SharpVk.Interop.CommandBuffer*)(marshalledCommandBuffers) = commandBuffers.Value.GetSingleValue()?.Handle ?? default;
                    }
                    else
                    {
                        var fieldPointer = (SharpVk.Interop.CommandBuffer*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.CommandBuffer>(Interop.HeapUtil.GetLength(commandBuffers.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(commandBuffers.Value)); index++)
                        {
                            fieldPointer[index] = commandBuffers.Value[index]?.Handle ?? default;
                        }
                        marshalledCommandBuffers = fieldPointer;
                    }
                }
                Interop.VkCommandBufferExecuteCommandsDelegate commandDelegate = commandCache.Cache.vkCmdExecuteCommands;
                commandDelegate(Handle, (uint)(Interop.HeapUtil.GetLength(commandBuffers)), marshalledCommandBuffers);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// </summary>
        /// <param name="deviceMask">
        /// </param>
        public unsafe void SetDeviceMask(uint deviceMask)
        {
            try
            {
                Interop.VkCommandBufferSetDeviceMaskDelegate commandDelegate = commandCache.Cache.vkCmdSetDeviceMask;
                commandDelegate(Handle, deviceMask);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// </summary>
        /// <param name="baseGroupX">
        /// </param>
        /// <param name="baseGroupY">
        /// </param>
        /// <param name="baseGroupZ">
        /// </param>
        /// <param name="groupCountX">
        /// </param>
        /// <param name="groupCountY">
        /// </param>
        /// <param name="groupCountZ">
        /// </param>
        public unsafe void DispatchBase(uint baseGroupX, uint baseGroupY, uint baseGroupZ, uint groupCountX, uint groupCountY, uint groupCountZ)
        {
            try
            {
                Interop.VkCommandBufferDispatchBaseDelegate commandDelegate = commandCache.Cache.vkCmdDispatchBase;
                commandDelegate(Handle, baseGroupX, baseGroupY, baseGroupZ, groupCountX, groupCountY, groupCountZ);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// </summary>
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
        public unsafe void DrawIndirectCount(Buffer buffer, ulong offset, Buffer countBuffer, ulong countBufferOffset, uint maxDrawCount, uint stride)
        {
            try
            {
                Interop.VkCommandBufferDrawIndirectCountDelegate commandDelegate = commandCache.Cache.vkCmdDrawIndirectCount;
                commandDelegate(Handle, buffer?.Handle ?? default, offset, countBuffer?.Handle ?? default, countBufferOffset, maxDrawCount, stride);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// </summary>
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
        public unsafe void DrawIndexedIndirectCount(Buffer buffer, ulong offset, Buffer countBuffer, ulong countBufferOffset, uint maxDrawCount, uint stride)
        {
            try
            {
                Interop.VkCommandBufferDrawIndexedIndirectCountDelegate commandDelegate = commandCache.Cache.vkCmdDrawIndexedIndirectCount;
                commandDelegate(Handle, buffer?.Handle ?? default, offset, countBuffer?.Handle ?? default, countBufferOffset, maxDrawCount, stride);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// </summary>
        /// <param name="renderPass">
        /// The render pass to begin an instance of.
        /// </param>
        /// <param name="framebuffer">
        /// The framebuffer containing the attachments that are used with the
        /// render pass.
        /// </param>
        /// <param name="renderArea">
        /// The render area that is affected by the render pass instance, and
        /// is described in more detail below.
        /// </param>
        /// <param name="clearValues">
        /// </param>
        /// <param name="deviceGroupRenderPassBeginInfo">
        /// Extension struct
        /// </param>
        /// <param name="renderPassSampleLocationsBeginInfoExt">
        /// Extension struct
        /// </param>
        /// <param name="renderPassAttachmentBeginInfo">
        /// Extension struct
        /// </param>
        /// <param name="renderPassTransformBeginInfoQcom">
        /// Extension struct
        /// </param>
        /// <param name="contents">
        /// </param>
        public unsafe void BeginRenderPass2(RenderPass renderPass, Framebuffer framebuffer, Rect2D renderArea, ArrayProxy<ClearValue>? clearValues, SubpassContents contents, DeviceGroupRenderPassBeginInfo? deviceGroupRenderPassBeginInfo = null, Multivendor.RenderPassSampleLocationsBeginInfo? renderPassSampleLocationsBeginInfoExt = null, RenderPassAttachmentBeginInfo? renderPassAttachmentBeginInfo = null, Qcom.RenderPassTransformBeginInfo? renderPassTransformBeginInfoQcom = null)
        {
            try
            {
                SharpVk.Interop.RenderPassBeginInfo* marshalledRenderPassBegin = default;
                void* vkRenderPassBeginInfoNextPointer = default;
                SharpVk.Interop.SubpassBeginInfo* marshalledSubpassBeginInfo = default;
                void* vkSubpassBeginInfoNextPointer = default;
                if (deviceGroupRenderPassBeginInfo != null)
                {
                    SharpVk.Interop.DeviceGroupRenderPassBeginInfo* extensionPointer = default;
                    extensionPointer = (SharpVk.Interop.DeviceGroupRenderPassBeginInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.DeviceGroupRenderPassBeginInfo>());
                    deviceGroupRenderPassBeginInfo.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkRenderPassBeginInfoNextPointer;
                    vkRenderPassBeginInfoNextPointer = extensionPointer;
                }
                if (renderPassSampleLocationsBeginInfoExt != null)
                {
                    SharpVk.Interop.Multivendor.RenderPassSampleLocationsBeginInfo* extensionPointer = default;
                    extensionPointer = (SharpVk.Interop.Multivendor.RenderPassSampleLocationsBeginInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.RenderPassSampleLocationsBeginInfo>());
                    renderPassSampleLocationsBeginInfoExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkRenderPassBeginInfoNextPointer;
                    vkRenderPassBeginInfoNextPointer = extensionPointer;
                }
                if (renderPassAttachmentBeginInfo != null)
                {
                    SharpVk.Interop.RenderPassAttachmentBeginInfo* extensionPointer = default;
                    extensionPointer = (SharpVk.Interop.RenderPassAttachmentBeginInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.RenderPassAttachmentBeginInfo>());
                    renderPassAttachmentBeginInfo.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkRenderPassBeginInfoNextPointer;
                    vkRenderPassBeginInfoNextPointer = extensionPointer;
                }
                if (renderPassTransformBeginInfoQcom != null)
                {
                    SharpVk.Interop.Qcom.RenderPassTransformBeginInfo* extensionPointer = default;
                    extensionPointer = (SharpVk.Interop.Qcom.RenderPassTransformBeginInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Qcom.RenderPassTransformBeginInfo>());
                    renderPassTransformBeginInfoQcom.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkRenderPassBeginInfoNextPointer;
                    vkRenderPassBeginInfoNextPointer = extensionPointer;
                }
                marshalledRenderPassBegin = (SharpVk.Interop.RenderPassBeginInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.RenderPassBeginInfo>());
                marshalledRenderPassBegin->SType = StructureType.RenderPassBeginInfo;
                marshalledRenderPassBegin->Next = vkRenderPassBeginInfoNextPointer;
                marshalledRenderPassBegin->RenderPass = renderPass?.Handle ?? default;
                marshalledRenderPassBegin->Framebuffer = framebuffer?.Handle ?? default;
                marshalledRenderPassBegin->RenderArea = renderArea;
                marshalledRenderPassBegin->ClearValueCount = (uint)(Interop.HeapUtil.GetLength(clearValues));
                if (clearValues.IsNull())
                {
                    marshalledRenderPassBegin->ClearValues = null;
                }
                else
                {
                    if (clearValues.Value.Contents == ProxyContents.Single)
                    {
                        marshalledRenderPassBegin->ClearValues = (ClearValue*)(Interop.HeapUtil.Allocate<ClearValue>());
                        *(ClearValue*)(marshalledRenderPassBegin->ClearValues) = clearValues.Value.GetSingleValue();
                    }
                    else
                    {
                        var fieldPointer = (ClearValue*)(Interop.HeapUtil.AllocateAndClear<ClearValue>(Interop.HeapUtil.GetLength(clearValues.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(clearValues.Value)); index++)
                        {
                            fieldPointer[index] = clearValues.Value[index];
                        }
                        marshalledRenderPassBegin->ClearValues = fieldPointer;
                    }
                }
                marshalledSubpassBeginInfo = (SharpVk.Interop.SubpassBeginInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.SubpassBeginInfo>());
                marshalledSubpassBeginInfo->SType = StructureType.SubpassBeginInfoVersion;
                marshalledSubpassBeginInfo->Next = vkSubpassBeginInfoNextPointer;
                marshalledSubpassBeginInfo->Contents = contents;
                Interop.VkCommandBufferBeginRenderPass2Delegate commandDelegate = commandCache.Cache.vkCmdBeginRenderPass2;
                commandDelegate(Handle, marshalledRenderPassBegin, marshalledSubpassBeginInfo);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// </summary>
        /// <param name="subpassBeginInfo">
        /// </param>
        /// <param name="subpassEndInfo">
        /// </param>
        public unsafe void NextSubpass2(SubpassBeginInfo subpassBeginInfo, SubpassEndInfo subpassEndInfo)
        {
            try
            {
                SharpVk.Interop.SubpassBeginInfo* marshalledSubpassBeginInfo = default;
                SharpVk.Interop.SubpassEndInfo* marshalledSubpassEndInfo = default;
                marshalledSubpassBeginInfo = (SharpVk.Interop.SubpassBeginInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.SubpassBeginInfo>());
                subpassBeginInfo.MarshalTo(marshalledSubpassBeginInfo);
                marshalledSubpassEndInfo = (SharpVk.Interop.SubpassEndInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.SubpassEndInfo>());
                subpassEndInfo.MarshalTo(marshalledSubpassEndInfo);
                Interop.VkCommandBufferNextSubpass2Delegate commandDelegate = commandCache.Cache.vkCmdNextSubpass2;
                commandDelegate(Handle, marshalledSubpassBeginInfo, marshalledSubpassEndInfo);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// </summary>
        public unsafe void EndRenderPass2()
        {
            try
            {
                SharpVk.Interop.SubpassEndInfo* marshalledSubpassEndInfo = default;
                void* vkSubpassEndInfoNextPointer = default;
                marshalledSubpassEndInfo = (SharpVk.Interop.SubpassEndInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.SubpassEndInfo>());
                marshalledSubpassEndInfo->SType = StructureType.SubpassEndInfoVersion;
                marshalledSubpassEndInfo->Next = vkSubpassEndInfoNextPointer;
                Interop.VkCommandBufferEndRenderPass2Delegate commandDelegate = commandCache.Cache.vkCmdEndRenderPass2;
                commandDelegate(Handle, marshalledSubpassEndInfo);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
    }
}
