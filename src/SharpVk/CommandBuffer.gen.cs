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
    /// Opaque handle to a command buffer object.
    /// </summary>
    public partial class CommandBuffer
    {
        internal readonly SharpVk.Interop.CommandBuffer handle; 
        
        internal readonly CommandCache commandCache; 
        
        internal readonly SharpVk.CommandPool parent; 
        
        internal CommandBuffer(SharpVk.CommandPool parent, SharpVk.Interop.CommandBuffer handle)
        {
            this.handle = handle;
            this.parent = parent;
            this.commandCache = parent.commandCache;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Interop.CommandBuffer RawHandle => this.handle;
        
        /// <summary>
        /// Start recording a command buffer.
        /// </summary>
        /// <param name="flags">
        /// A bitmask indicating usage behavior for the command buffer. Bits
        /// which can be set include: + --
        /// </param>
        public unsafe void Begin(SharpVk.CommandBufferUsageFlags? flags = default(SharpVk.CommandBufferUsageFlags?), SharpVk.CommandBufferInheritanceInfo? inheritanceInfo = default(SharpVk.CommandBufferInheritanceInfo?), SharpVk.Khronos.Experimental.DeviceGroupCommandBufferBeginInfo? deviceGroupCommandBufferBeginInfoKhx = null)
        {
            try
            {
                SharpVk.Interop.CommandBufferBeginInfo* marshalledBeginInfo = default(SharpVk.Interop.CommandBufferBeginInfo*);
                marshalledBeginInfo = (SharpVk.Interop.CommandBufferBeginInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.CommandBufferBeginInfo>());
                marshalledBeginInfo->SType = StructureType.CommandBufferBeginInfo;
                marshalledBeginInfo->Next = null;
                if (flags != null)
                {
                    marshalledBeginInfo->Flags = flags.Value;
                }
                else
                {
                    marshalledBeginInfo->Flags = default(SharpVk.CommandBufferUsageFlags);
                }
                if (inheritanceInfo != null)
                {
                    marshalledBeginInfo->InheritanceInfo = (SharpVk.Interop.CommandBufferInheritanceInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.CommandBufferInheritanceInfo>());
                    inheritanceInfo.Value.MarshalTo(marshalledBeginInfo->InheritanceInfo);
                }
                else
                {
                    marshalledBeginInfo->InheritanceInfo = default(SharpVk.Interop.CommandBufferInheritanceInfo*);
                }
                SharpVk.Interop.VkCommandBufferBeginDelegate commandDelegate = commandCache.GetCommandDelegate<SharpVk.Interop.VkCommandBufferBeginDelegate>("vkBeginCommandBuffer", "");
                Result methodResult = commandDelegate(this.handle, marshalledBeginInfo);
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
                SharpVk.Interop.VkCommandBufferEndDelegate commandDelegate = commandCache.GetCommandDelegate<SharpVk.Interop.VkCommandBufferEndDelegate>("vkEndCommandBuffer", "");
                Result methodResult = commandDelegate(this.handle);
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
        public unsafe void Reset(SharpVk.CommandBufferResetFlags? flags = default(SharpVk.CommandBufferResetFlags?))
        {
            try
            {
                SharpVk.CommandBufferResetFlags marshalledFlags = default(SharpVk.CommandBufferResetFlags);
                if (flags != null)
                {
                    marshalledFlags = flags.Value;
                }
                else
                {
                    marshalledFlags = default(SharpVk.CommandBufferResetFlags);
                }
                SharpVk.Interop.VkCommandBufferResetDelegate commandDelegate = commandCache.GetCommandDelegate<SharpVk.Interop.VkCommandBufferResetDelegate>("vkResetCommandBuffer", "");
                Result methodResult = commandDelegate(this.handle, marshalledFlags);
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
        public unsafe void BindPipeline(SharpVk.PipelineBindPoint pipelineBindPoint, SharpVk.Pipeline pipeline)
        {
            try
            {
                SharpVk.Interop.VkCommandBufferBindPipelineDelegate commandDelegate = commandCache.GetCommandDelegate<SharpVk.Interop.VkCommandBufferBindPipelineDelegate>("vkCmdBindPipeline", "");
                commandDelegate(this.handle, pipelineBindPoint, pipeline?.handle ?? default(SharpVk.Interop.Pipeline));
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Set the viewport on a command buffer.
        /// </summary>
        public unsafe void SetViewport(uint firstViewport, ArrayProxy<SharpVk.Viewport>? viewports)
        {
            try
            {
                SharpVk.Viewport* marshalledViewports = default(SharpVk.Viewport*);
                if (viewports.IsNull())
                {
                    marshalledViewports = null;
                }
                else
                {
                    if (viewports.Value.Contents == ProxyContents.Single)
                    {
                        marshalledViewports = (SharpVk.Viewport*)(Interop.HeapUtil.Allocate<SharpVk.Viewport>());
                        *(SharpVk.Viewport*)(marshalledViewports) = viewports.Value.GetSingleValue();
                    }
                    else
                    {
                        var fieldPointer = (SharpVk.Viewport*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Viewport>(Interop.HeapUtil.GetLength(viewports.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(viewports.Value)); index++)
                        {
                            fieldPointer[index] = viewports.Value[index];
                        }
                        marshalledViewports = fieldPointer;
                    }
                }
                SharpVk.Interop.VkCommandBufferSetViewportDelegate commandDelegate = commandCache.GetCommandDelegate<SharpVk.Interop.VkCommandBufferSetViewportDelegate>("vkCmdSetViewport", "");
                commandDelegate(this.handle, firstViewport, (uint)(Interop.HeapUtil.GetLength(viewports)), marshalledViewports);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Set the dynamic scissor rectangles on a command buffer.
        /// </summary>
        public unsafe void SetScissor(uint firstScissor, ArrayProxy<SharpVk.Rect2D>? scissors)
        {
            try
            {
                SharpVk.Rect2D* marshalledScissors = default(SharpVk.Rect2D*);
                if (scissors.IsNull())
                {
                    marshalledScissors = null;
                }
                else
                {
                    if (scissors.Value.Contents == ProxyContents.Single)
                    {
                        marshalledScissors = (SharpVk.Rect2D*)(Interop.HeapUtil.Allocate<SharpVk.Rect2D>());
                        *(SharpVk.Rect2D*)(marshalledScissors) = scissors.Value.GetSingleValue();
                    }
                    else
                    {
                        var fieldPointer = (SharpVk.Rect2D*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Rect2D>(Interop.HeapUtil.GetLength(scissors.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(scissors.Value)); index++)
                        {
                            fieldPointer[index] = scissors.Value[index];
                        }
                        marshalledScissors = fieldPointer;
                    }
                }
                SharpVk.Interop.VkCommandBufferSetScissorDelegate commandDelegate = commandCache.GetCommandDelegate<SharpVk.Interop.VkCommandBufferSetScissorDelegate>("vkCmdSetScissor", "");
                commandDelegate(this.handle, firstScissor, (uint)(Interop.HeapUtil.GetLength(scissors)), marshalledScissors);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Set the dynamic line width state.
        /// </summary>
        public unsafe void SetLineWidth(float lineWidth)
        {
            try
            {
                SharpVk.Interop.VkCommandBufferSetLineWidthDelegate commandDelegate = commandCache.GetCommandDelegate<SharpVk.Interop.VkCommandBufferSetLineWidthDelegate>("vkCmdSetLineWidth", "");
                commandDelegate(this.handle, lineWidth);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Set the depth bias dynamic state.
        /// </summary>
        public unsafe void SetDepthBias(float depthBiasConstantFactor, float depthBiasClamp, float depthBiasSlopeFactor)
        {
            try
            {
                SharpVk.Interop.VkCommandBufferSetDepthBiasDelegate commandDelegate = commandCache.GetCommandDelegate<SharpVk.Interop.VkCommandBufferSetDepthBiasDelegate>("vkCmdSetDepthBias", "");
                commandDelegate(this.handle, depthBiasConstantFactor, depthBiasClamp, depthBiasSlopeFactor);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Set the values of blend constants.
        /// </summary>
        public unsafe void SetBlendConstants(float blendConstants)
        {
            try
            {
                SharpVk.Interop.VkCommandBufferSetBlendConstantsDelegate commandDelegate = commandCache.GetCommandDelegate<SharpVk.Interop.VkCommandBufferSetBlendConstantsDelegate>("vkCmdSetBlendConstants", "");
                commandDelegate(this.handle, blendConstants);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Set the depth bounds test values for a command buffer.
        /// </summary>
        public unsafe void SetDepthBounds(float minDepthBounds, float maxDepthBounds)
        {
            try
            {
                SharpVk.Interop.VkCommandBufferSetDepthBoundsDelegate commandDelegate = commandCache.GetCommandDelegate<SharpVk.Interop.VkCommandBufferSetDepthBoundsDelegate>("vkCmdSetDepthBounds", "");
                commandDelegate(this.handle, minDepthBounds, maxDepthBounds);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Set the stencil compare mask dynamic state.
        /// </summary>
        public unsafe void SetStencilCompareMask(SharpVk.StencilFaceFlags faceMask, uint compareMask)
        {
            try
            {
                SharpVk.Interop.VkCommandBufferSetStencilCompareMaskDelegate commandDelegate = commandCache.GetCommandDelegate<SharpVk.Interop.VkCommandBufferSetStencilCompareMaskDelegate>("vkCmdSetStencilCompareMask", "");
                commandDelegate(this.handle, faceMask, compareMask);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Set the stencil write mask dynamic state.
        /// </summary>
        public unsafe void SetStencilWriteMask(SharpVk.StencilFaceFlags faceMask, uint writeMask)
        {
            try
            {
                SharpVk.Interop.VkCommandBufferSetStencilWriteMaskDelegate commandDelegate = commandCache.GetCommandDelegate<SharpVk.Interop.VkCommandBufferSetStencilWriteMaskDelegate>("vkCmdSetStencilWriteMask", "");
                commandDelegate(this.handle, faceMask, writeMask);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Set the stencil reference dynamic state.
        /// </summary>
        public unsafe void SetStencilReference(SharpVk.StencilFaceFlags faceMask, uint reference)
        {
            try
            {
                SharpVk.Interop.VkCommandBufferSetStencilReferenceDelegate commandDelegate = commandCache.GetCommandDelegate<SharpVk.Interop.VkCommandBufferSetStencilReferenceDelegate>("vkCmdSetStencilReference", "");
                commandDelegate(this.handle, faceMask, reference);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Binds descriptor sets to a command buffer.
        /// </summary>
        public unsafe void BindDescriptorSets(SharpVk.PipelineBindPoint pipelineBindPoint, SharpVk.PipelineLayout layout, uint firstSet, ArrayProxy<SharpVk.DescriptorSet>? descriptorSets, ArrayProxy<uint>? dynamicOffsets)
        {
            try
            {
                SharpVk.Interop.DescriptorSet* marshalledDescriptorSets = default(SharpVk.Interop.DescriptorSet*);
                uint* marshalledDynamicOffsets = default(uint*);
                if (descriptorSets.IsNull())
                {
                    marshalledDescriptorSets = null;
                }
                else
                {
                    if (descriptorSets.Value.Contents == ProxyContents.Single)
                    {
                        marshalledDescriptorSets = (SharpVk.Interop.DescriptorSet*)(Interop.HeapUtil.Allocate<SharpVk.Interop.DescriptorSet>());
                        *(SharpVk.Interop.DescriptorSet*)(marshalledDescriptorSets) = descriptorSets.Value.GetSingleValue()?.handle ?? default(SharpVk.Interop.DescriptorSet);
                    }
                    else
                    {
                        var fieldPointer = (SharpVk.Interop.DescriptorSet*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.DescriptorSet>(Interop.HeapUtil.GetLength(descriptorSets.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(descriptorSets.Value)); index++)
                        {
                            fieldPointer[index] = descriptorSets.Value[index]?.handle ?? default(SharpVk.Interop.DescriptorSet);
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
                SharpVk.Interop.VkCommandBufferBindDescriptorSetsDelegate commandDelegate = commandCache.GetCommandDelegate<SharpVk.Interop.VkCommandBufferBindDescriptorSetsDelegate>("vkCmdBindDescriptorSets", "");
                commandDelegate(this.handle, pipelineBindPoint, layout?.handle ?? default(SharpVk.Interop.PipelineLayout), firstSet, (uint)(Interop.HeapUtil.GetLength(descriptorSets)), marshalledDescriptorSets, (uint)(Interop.HeapUtil.GetLength(dynamicOffsets)), marshalledDynamicOffsets);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Bind an index buffer to a command buffer.
        /// </summary>
        public unsafe void BindIndexBuffer(SharpVk.Buffer buffer, DeviceSize offset, SharpVk.IndexType indexType)
        {
            try
            {
                SharpVk.Interop.VkCommandBufferBindIndexBufferDelegate commandDelegate = commandCache.GetCommandDelegate<SharpVk.Interop.VkCommandBufferBindIndexBufferDelegate>("vkCmdBindIndexBuffer", "");
                commandDelegate(this.handle, buffer?.handle ?? default(SharpVk.Interop.Buffer), offset, indexType);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Bind vertex buffers to a command buffer.
        /// </summary>
        public unsafe void BindVertexBuffers(uint firstBinding, ArrayProxy<SharpVk.Buffer>? buffers, ArrayProxy<DeviceSize>? offsets)
        {
            try
            {
                SharpVk.Interop.Buffer* marshalledBuffers = default(SharpVk.Interop.Buffer*);
                DeviceSize* marshalledOffsets = default(DeviceSize*);
                if (buffers.IsNull())
                {
                    marshalledBuffers = null;
                }
                else
                {
                    if (buffers.Value.Contents == ProxyContents.Single)
                    {
                        marshalledBuffers = (SharpVk.Interop.Buffer*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Buffer>());
                        *(SharpVk.Interop.Buffer*)(marshalledBuffers) = buffers.Value.GetSingleValue()?.handle ?? default(SharpVk.Interop.Buffer);
                    }
                    else
                    {
                        var fieldPointer = (SharpVk.Interop.Buffer*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.Buffer>(Interop.HeapUtil.GetLength(buffers.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(buffers.Value)); index++)
                        {
                            fieldPointer[index] = buffers.Value[index]?.handle ?? default(SharpVk.Interop.Buffer);
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
                        marshalledOffsets = (DeviceSize*)(Interop.HeapUtil.Allocate<DeviceSize>());
                        *(DeviceSize*)(marshalledOffsets) = offsets.Value.GetSingleValue();
                    }
                    else
                    {
                        var fieldPointer = (DeviceSize*)(Interop.HeapUtil.AllocateAndClear<DeviceSize>(Interop.HeapUtil.GetLength(offsets.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(offsets.Value)); index++)
                        {
                            fieldPointer[index] = offsets.Value[index];
                        }
                        marshalledOffsets = fieldPointer;
                    }
                }
                SharpVk.Interop.VkCommandBufferBindVertexBuffersDelegate commandDelegate = commandCache.GetCommandDelegate<SharpVk.Interop.VkCommandBufferBindVertexBuffersDelegate>("vkCmdBindVertexBuffers", "");
                commandDelegate(this.handle, firstBinding, (uint)(Interop.HeapUtil.GetLength(buffers)), marshalledBuffers, marshalledOffsets);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Draw primitives.
        /// </summary>
        public unsafe void Draw(uint vertexCount, uint instanceCount, uint firstVertex, uint firstInstance)
        {
            try
            {
                SharpVk.Interop.VkCommandBufferDrawDelegate commandDelegate = commandCache.GetCommandDelegate<SharpVk.Interop.VkCommandBufferDrawDelegate>("vkCmdDraw", "");
                commandDelegate(this.handle, vertexCount, instanceCount, firstVertex, firstInstance);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Issue an indexed draw into a command buffer.
        /// </summary>
        public unsafe void DrawIndexed(uint indexCount, uint instanceCount, uint firstIndex, int vertexOffset, uint firstInstance)
        {
            try
            {
                SharpVk.Interop.VkCommandBufferDrawIndexedDelegate commandDelegate = commandCache.GetCommandDelegate<SharpVk.Interop.VkCommandBufferDrawIndexedDelegate>("vkCmdDrawIndexed", "");
                commandDelegate(this.handle, indexCount, instanceCount, firstIndex, vertexOffset, firstInstance);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Issue an indirect draw into a command buffer.
        /// </summary>
        public unsafe void DrawIndirect(SharpVk.Buffer buffer, DeviceSize offset, uint drawCount, uint stride)
        {
            try
            {
                SharpVk.Interop.VkCommandBufferDrawIndirectDelegate commandDelegate = commandCache.GetCommandDelegate<SharpVk.Interop.VkCommandBufferDrawIndirectDelegate>("vkCmdDrawIndirect", "");
                commandDelegate(this.handle, buffer?.handle ?? default(SharpVk.Interop.Buffer), offset, drawCount, stride);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Perform an indexed indirect draw.
        /// </summary>
        public unsafe void DrawIndexedIndirect(SharpVk.Buffer buffer, DeviceSize offset, uint drawCount, uint stride)
        {
            try
            {
                SharpVk.Interop.VkCommandBufferDrawIndexedIndirectDelegate commandDelegate = commandCache.GetCommandDelegate<SharpVk.Interop.VkCommandBufferDrawIndexedIndirectDelegate>("vkCmdDrawIndexedIndirect", "");
                commandDelegate(this.handle, buffer?.handle ?? default(SharpVk.Interop.Buffer), offset, drawCount, stride);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Dispatch compute work items.
        /// </summary>
        public unsafe void Dispatch(uint groupCountX, uint groupCountY, uint groupCountZ)
        {
            try
            {
                SharpVk.Interop.VkCommandBufferDispatchDelegate commandDelegate = commandCache.GetCommandDelegate<SharpVk.Interop.VkCommandBufferDispatchDelegate>("vkCmdDispatch", "");
                commandDelegate(this.handle, groupCountX, groupCountY, groupCountZ);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Dispatch compute work items using indirect parameters.
        /// </summary>
        public unsafe void DispatchIndirect(SharpVk.Buffer buffer, DeviceSize offset)
        {
            try
            {
                SharpVk.Interop.VkCommandBufferDispatchIndirectDelegate commandDelegate = commandCache.GetCommandDelegate<SharpVk.Interop.VkCommandBufferDispatchIndirectDelegate>("vkCmdDispatchIndirect", "");
                commandDelegate(this.handle, buffer?.handle ?? default(SharpVk.Interop.Buffer), offset);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Copy data between buffer regions.
        /// </summary>
        public unsafe void CopyBuffer(SharpVk.Buffer sourceBuffer, SharpVk.Buffer destinationBuffer, ArrayProxy<SharpVk.BufferCopy>? regions)
        {
            try
            {
                SharpVk.BufferCopy* marshalledRegions = default(SharpVk.BufferCopy*);
                if (regions.IsNull())
                {
                    marshalledRegions = null;
                }
                else
                {
                    if (regions.Value.Contents == ProxyContents.Single)
                    {
                        marshalledRegions = (SharpVk.BufferCopy*)(Interop.HeapUtil.Allocate<SharpVk.BufferCopy>());
                        *(SharpVk.BufferCopy*)(marshalledRegions) = regions.Value.GetSingleValue();
                    }
                    else
                    {
                        var fieldPointer = (SharpVk.BufferCopy*)(Interop.HeapUtil.AllocateAndClear<SharpVk.BufferCopy>(Interop.HeapUtil.GetLength(regions.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(regions.Value)); index++)
                        {
                            fieldPointer[index] = regions.Value[index];
                        }
                        marshalledRegions = fieldPointer;
                    }
                }
                SharpVk.Interop.VkCommandBufferCopyBufferDelegate commandDelegate = commandCache.GetCommandDelegate<SharpVk.Interop.VkCommandBufferCopyBufferDelegate>("vkCmdCopyBuffer", "");
                commandDelegate(this.handle, sourceBuffer?.handle ?? default(SharpVk.Interop.Buffer), destinationBuffer?.handle ?? default(SharpVk.Interop.Buffer), (uint)(Interop.HeapUtil.GetLength(regions)), marshalledRegions);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Copy data between images.
        /// </summary>
        public unsafe void CopyImage(SharpVk.Image sourceImage, SharpVk.ImageLayout sourceImageLayout, SharpVk.Image destinationImage, SharpVk.ImageLayout destinationImageLayout, ArrayProxy<SharpVk.ImageCopy>? regions)
        {
            try
            {
                SharpVk.ImageCopy* marshalledRegions = default(SharpVk.ImageCopy*);
                if (regions.IsNull())
                {
                    marshalledRegions = null;
                }
                else
                {
                    if (regions.Value.Contents == ProxyContents.Single)
                    {
                        marshalledRegions = (SharpVk.ImageCopy*)(Interop.HeapUtil.Allocate<SharpVk.ImageCopy>());
                        *(SharpVk.ImageCopy*)(marshalledRegions) = regions.Value.GetSingleValue();
                    }
                    else
                    {
                        var fieldPointer = (SharpVk.ImageCopy*)(Interop.HeapUtil.AllocateAndClear<SharpVk.ImageCopy>(Interop.HeapUtil.GetLength(regions.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(regions.Value)); index++)
                        {
                            fieldPointer[index] = regions.Value[index];
                        }
                        marshalledRegions = fieldPointer;
                    }
                }
                SharpVk.Interop.VkCommandBufferCopyImageDelegate commandDelegate = commandCache.GetCommandDelegate<SharpVk.Interop.VkCommandBufferCopyImageDelegate>("vkCmdCopyImage", "");
                commandDelegate(this.handle, sourceImage?.handle ?? default(SharpVk.Interop.Image), sourceImageLayout, destinationImage?.handle ?? default(SharpVk.Interop.Image), destinationImageLayout, (uint)(Interop.HeapUtil.GetLength(regions)), marshalledRegions);
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
        public unsafe void BlitImage(SharpVk.Image sourceImage, SharpVk.ImageLayout sourceImageLayout, SharpVk.Image destinationImage, SharpVk.ImageLayout destinationImageLayout, ArrayProxy<SharpVk.ImageBlit>? regions, SharpVk.Filter filter)
        {
            try
            {
                SharpVk.Interop.ImageBlit* marshalledRegions = default(SharpVk.Interop.ImageBlit*);
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
                SharpVk.Interop.VkCommandBufferBlitImageDelegate commandDelegate = commandCache.GetCommandDelegate<SharpVk.Interop.VkCommandBufferBlitImageDelegate>("vkCmdBlitImage", "");
                commandDelegate(this.handle, sourceImage?.handle ?? default(SharpVk.Interop.Image), sourceImageLayout, destinationImage?.handle ?? default(SharpVk.Interop.Image), destinationImageLayout, (uint)(Interop.HeapUtil.GetLength(regions)), marshalledRegions, filter);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Copy data from a buffer into an image.
        /// </summary>
        public unsafe void CopyBufferToImage(SharpVk.Buffer sourceBuffer, SharpVk.Image destinationImage, SharpVk.ImageLayout destinationImageLayout, ArrayProxy<SharpVk.BufferImageCopy>? regions)
        {
            try
            {
                SharpVk.BufferImageCopy* marshalledRegions = default(SharpVk.BufferImageCopy*);
                if (regions.IsNull())
                {
                    marshalledRegions = null;
                }
                else
                {
                    if (regions.Value.Contents == ProxyContents.Single)
                    {
                        marshalledRegions = (SharpVk.BufferImageCopy*)(Interop.HeapUtil.Allocate<SharpVk.BufferImageCopy>());
                        *(SharpVk.BufferImageCopy*)(marshalledRegions) = regions.Value.GetSingleValue();
                    }
                    else
                    {
                        var fieldPointer = (SharpVk.BufferImageCopy*)(Interop.HeapUtil.AllocateAndClear<SharpVk.BufferImageCopy>(Interop.HeapUtil.GetLength(regions.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(regions.Value)); index++)
                        {
                            fieldPointer[index] = regions.Value[index];
                        }
                        marshalledRegions = fieldPointer;
                    }
                }
                SharpVk.Interop.VkCommandBufferCopyBufferToImageDelegate commandDelegate = commandCache.GetCommandDelegate<SharpVk.Interop.VkCommandBufferCopyBufferToImageDelegate>("vkCmdCopyBufferToImage", "");
                commandDelegate(this.handle, sourceBuffer?.handle ?? default(SharpVk.Interop.Buffer), destinationImage?.handle ?? default(SharpVk.Interop.Image), destinationImageLayout, (uint)(Interop.HeapUtil.GetLength(regions)), marshalledRegions);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Copy image data into a buffer.
        /// </summary>
        public unsafe void CopyImageToBuffer(SharpVk.Image sourceImage, SharpVk.ImageLayout sourceImageLayout, SharpVk.Buffer destinationBuffer, ArrayProxy<SharpVk.BufferImageCopy>? regions)
        {
            try
            {
                SharpVk.BufferImageCopy* marshalledRegions = default(SharpVk.BufferImageCopy*);
                if (regions.IsNull())
                {
                    marshalledRegions = null;
                }
                else
                {
                    if (regions.Value.Contents == ProxyContents.Single)
                    {
                        marshalledRegions = (SharpVk.BufferImageCopy*)(Interop.HeapUtil.Allocate<SharpVk.BufferImageCopy>());
                        *(SharpVk.BufferImageCopy*)(marshalledRegions) = regions.Value.GetSingleValue();
                    }
                    else
                    {
                        var fieldPointer = (SharpVk.BufferImageCopy*)(Interop.HeapUtil.AllocateAndClear<SharpVk.BufferImageCopy>(Interop.HeapUtil.GetLength(regions.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(regions.Value)); index++)
                        {
                            fieldPointer[index] = regions.Value[index];
                        }
                        marshalledRegions = fieldPointer;
                    }
                }
                SharpVk.Interop.VkCommandBufferCopyImageToBufferDelegate commandDelegate = commandCache.GetCommandDelegate<SharpVk.Interop.VkCommandBufferCopyImageToBufferDelegate>("vkCmdCopyImageToBuffer", "");
                commandDelegate(this.handle, sourceImage?.handle ?? default(SharpVk.Interop.Image), sourceImageLayout, destinationBuffer?.handle ?? default(SharpVk.Interop.Buffer), (uint)(Interop.HeapUtil.GetLength(regions)), marshalledRegions);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Update a buffer's contents from host memory.
        /// </summary>
        public unsafe void UpdateBuffer(SharpVk.Buffer destinationBuffer, DeviceSize destinationOffset, ArrayProxy<byte>? data)
        {
            try
            {
                byte* marshalledData = default(byte*);
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
                SharpVk.Interop.VkCommandBufferUpdateBufferDelegate commandDelegate = commandCache.GetCommandDelegate<SharpVk.Interop.VkCommandBufferUpdateBufferDelegate>("vkCmdUpdateBuffer", "");
                commandDelegate(this.handle, destinationBuffer?.handle ?? default(SharpVk.Interop.Buffer), destinationOffset, (DeviceSize)(Interop.HeapUtil.GetLength(data)), marshalledData);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Fill a region of a buffer with a fixed value.
        /// </summary>
        public unsafe void FillBuffer(SharpVk.Buffer destinationBuffer, DeviceSize destinationOffset, DeviceSize size, uint data)
        {
            try
            {
                SharpVk.Interop.VkCommandBufferFillBufferDelegate commandDelegate = commandCache.GetCommandDelegate<SharpVk.Interop.VkCommandBufferFillBufferDelegate>("vkCmdFillBuffer", "");
                commandDelegate(this.handle, destinationBuffer?.handle ?? default(SharpVk.Interop.Buffer), destinationOffset, size, data);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Clear regions of a color image.
        /// </summary>
        public unsafe void ClearColorImage(SharpVk.Image image, SharpVk.ImageLayout imageLayout, SharpVk.ClearColorValue color, ArrayProxy<SharpVk.ImageSubresourceRange>? ranges)
        {
            try
            {
                SharpVk.ClearColorValue* marshalledColor = default(SharpVk.ClearColorValue*);
                SharpVk.ImageSubresourceRange* marshalledRanges = default(SharpVk.ImageSubresourceRange*);
                marshalledColor = (SharpVk.ClearColorValue*)(Interop.HeapUtil.Allocate<SharpVk.ClearColorValue>());
                *marshalledColor = color;
                if (ranges.IsNull())
                {
                    marshalledRanges = null;
                }
                else
                {
                    if (ranges.Value.Contents == ProxyContents.Single)
                    {
                        marshalledRanges = (SharpVk.ImageSubresourceRange*)(Interop.HeapUtil.Allocate<SharpVk.ImageSubresourceRange>());
                        *(SharpVk.ImageSubresourceRange*)(marshalledRanges) = ranges.Value.GetSingleValue();
                    }
                    else
                    {
                        var fieldPointer = (SharpVk.ImageSubresourceRange*)(Interop.HeapUtil.AllocateAndClear<SharpVk.ImageSubresourceRange>(Interop.HeapUtil.GetLength(ranges.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(ranges.Value)); index++)
                        {
                            fieldPointer[index] = ranges.Value[index];
                        }
                        marshalledRanges = fieldPointer;
                    }
                }
                SharpVk.Interop.VkCommandBufferClearColorImageDelegate commandDelegate = commandCache.GetCommandDelegate<SharpVk.Interop.VkCommandBufferClearColorImageDelegate>("vkCmdClearColorImage", "");
                commandDelegate(this.handle, image?.handle ?? default(SharpVk.Interop.Image), imageLayout, marshalledColor, (uint)(Interop.HeapUtil.GetLength(ranges)), marshalledRanges);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Fill regions of a combined depth/stencil image.
        /// </summary>
        public unsafe void ClearDepthStencilImage(SharpVk.Image image, SharpVk.ImageLayout imageLayout, SharpVk.ClearDepthStencilValue depthStencil, ArrayProxy<SharpVk.ImageSubresourceRange>? ranges)
        {
            try
            {
                SharpVk.ClearDepthStencilValue* marshalledDepthStencil = default(SharpVk.ClearDepthStencilValue*);
                SharpVk.ImageSubresourceRange* marshalledRanges = default(SharpVk.ImageSubresourceRange*);
                marshalledDepthStencil = (SharpVk.ClearDepthStencilValue*)(Interop.HeapUtil.Allocate<SharpVk.ClearDepthStencilValue>());
                *marshalledDepthStencil = depthStencil;
                if (ranges.IsNull())
                {
                    marshalledRanges = null;
                }
                else
                {
                    if (ranges.Value.Contents == ProxyContents.Single)
                    {
                        marshalledRanges = (SharpVk.ImageSubresourceRange*)(Interop.HeapUtil.Allocate<SharpVk.ImageSubresourceRange>());
                        *(SharpVk.ImageSubresourceRange*)(marshalledRanges) = ranges.Value.GetSingleValue();
                    }
                    else
                    {
                        var fieldPointer = (SharpVk.ImageSubresourceRange*)(Interop.HeapUtil.AllocateAndClear<SharpVk.ImageSubresourceRange>(Interop.HeapUtil.GetLength(ranges.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(ranges.Value)); index++)
                        {
                            fieldPointer[index] = ranges.Value[index];
                        }
                        marshalledRanges = fieldPointer;
                    }
                }
                SharpVk.Interop.VkCommandBufferClearDepthStencilImageDelegate commandDelegate = commandCache.GetCommandDelegate<SharpVk.Interop.VkCommandBufferClearDepthStencilImageDelegate>("vkCmdClearDepthStencilImage", "");
                commandDelegate(this.handle, image?.handle ?? default(SharpVk.Interop.Image), imageLayout, marshalledDepthStencil, (uint)(Interop.HeapUtil.GetLength(ranges)), marshalledRanges);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Clear regions within currently bound framebuffer attachments.
        /// </summary>
        public unsafe void ClearAttachments(ArrayProxy<SharpVk.ClearAttachment>? attachments, ArrayProxy<SharpVk.ClearRect>? rects)
        {
            try
            {
                SharpVk.ClearAttachment* marshalledAttachments = default(SharpVk.ClearAttachment*);
                SharpVk.ClearRect* marshalledRects = default(SharpVk.ClearRect*);
                if (attachments.IsNull())
                {
                    marshalledAttachments = null;
                }
                else
                {
                    if (attachments.Value.Contents == ProxyContents.Single)
                    {
                        marshalledAttachments = (SharpVk.ClearAttachment*)(Interop.HeapUtil.Allocate<SharpVk.ClearAttachment>());
                        *(SharpVk.ClearAttachment*)(marshalledAttachments) = attachments.Value.GetSingleValue();
                    }
                    else
                    {
                        var fieldPointer = (SharpVk.ClearAttachment*)(Interop.HeapUtil.AllocateAndClear<SharpVk.ClearAttachment>(Interop.HeapUtil.GetLength(attachments.Value)).ToPointer());
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
                        marshalledRects = (SharpVk.ClearRect*)(Interop.HeapUtil.Allocate<SharpVk.ClearRect>());
                        *(SharpVk.ClearRect*)(marshalledRects) = rects.Value.GetSingleValue();
                    }
                    else
                    {
                        var fieldPointer = (SharpVk.ClearRect*)(Interop.HeapUtil.AllocateAndClear<SharpVk.ClearRect>(Interop.HeapUtil.GetLength(rects.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(rects.Value)); index++)
                        {
                            fieldPointer[index] = rects.Value[index];
                        }
                        marshalledRects = fieldPointer;
                    }
                }
                SharpVk.Interop.VkCommandBufferClearAttachmentsDelegate commandDelegate = commandCache.GetCommandDelegate<SharpVk.Interop.VkCommandBufferClearAttachmentsDelegate>("vkCmdClearAttachments", "");
                commandDelegate(this.handle, (uint)(Interop.HeapUtil.GetLength(attachments)), marshalledAttachments, (uint)(Interop.HeapUtil.GetLength(rects)), marshalledRects);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Resolve regions of an image.
        /// </summary>
        public unsafe void ResolveImage(SharpVk.Image sourceImage, SharpVk.ImageLayout sourceImageLayout, SharpVk.Image destinationImage, SharpVk.ImageLayout destinationImageLayout, ArrayProxy<SharpVk.ImageResolve>? regions)
        {
            try
            {
                SharpVk.ImageResolve* marshalledRegions = default(SharpVk.ImageResolve*);
                if (regions.IsNull())
                {
                    marshalledRegions = null;
                }
                else
                {
                    if (regions.Value.Contents == ProxyContents.Single)
                    {
                        marshalledRegions = (SharpVk.ImageResolve*)(Interop.HeapUtil.Allocate<SharpVk.ImageResolve>());
                        *(SharpVk.ImageResolve*)(marshalledRegions) = regions.Value.GetSingleValue();
                    }
                    else
                    {
                        var fieldPointer = (SharpVk.ImageResolve*)(Interop.HeapUtil.AllocateAndClear<SharpVk.ImageResolve>(Interop.HeapUtil.GetLength(regions.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(regions.Value)); index++)
                        {
                            fieldPointer[index] = regions.Value[index];
                        }
                        marshalledRegions = fieldPointer;
                    }
                }
                SharpVk.Interop.VkCommandBufferResolveImageDelegate commandDelegate = commandCache.GetCommandDelegate<SharpVk.Interop.VkCommandBufferResolveImageDelegate>("vkCmdResolveImage", "");
                commandDelegate(this.handle, sourceImage?.handle ?? default(SharpVk.Interop.Image), sourceImageLayout, destinationImage?.handle ?? default(SharpVk.Interop.Image), destinationImageLayout, (uint)(Interop.HeapUtil.GetLength(regions)), marshalledRegions);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Set an event object to signaled state.
        /// </summary>
        public unsafe void SetEvent(SharpVk.Event @event, SharpVk.PipelineStageFlags stageMask)
        {
            try
            {
                SharpVk.Interop.VkCommandBufferSetEventDelegate commandDelegate = commandCache.GetCommandDelegate<SharpVk.Interop.VkCommandBufferSetEventDelegate>("vkCmdSetEvent", "");
                commandDelegate(this.handle, @event?.handle ?? default(SharpVk.Interop.Event), stageMask);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Reset an event object to non-signaled state.
        /// </summary>
        public unsafe void ResetEvent(SharpVk.Event @event, SharpVk.PipelineStageFlags stageMask)
        {
            try
            {
                SharpVk.Interop.VkCommandBufferResetEventDelegate commandDelegate = commandCache.GetCommandDelegate<SharpVk.Interop.VkCommandBufferResetEventDelegate>("vkCmdResetEvent", "");
                commandDelegate(this.handle, @event?.handle ?? default(SharpVk.Interop.Event), stageMask);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Wait for one or more events and insert a set of memory.
        /// </summary>
        public unsafe void WaitEvents(ArrayProxy<SharpVk.Event>? events, SharpVk.PipelineStageFlags sourceStageMask, SharpVk.PipelineStageFlags destinationStageMask, ArrayProxy<SharpVk.MemoryBarrier>? memoryBarriers, ArrayProxy<SharpVk.BufferMemoryBarrier>? bufferMemoryBarriers, ArrayProxy<SharpVk.ImageMemoryBarrier>? imageMemoryBarriers)
        {
            try
            {
                SharpVk.Interop.Event* marshalledEvents = default(SharpVk.Interop.Event*);
                SharpVk.Interop.MemoryBarrier* marshalledMemoryBarriers = default(SharpVk.Interop.MemoryBarrier*);
                SharpVk.Interop.BufferMemoryBarrier* marshalledBufferMemoryBarriers = default(SharpVk.Interop.BufferMemoryBarrier*);
                SharpVk.Interop.ImageMemoryBarrier* marshalledImageMemoryBarriers = default(SharpVk.Interop.ImageMemoryBarrier*);
                if (events.IsNull())
                {
                    marshalledEvents = null;
                }
                else
                {
                    if (events.Value.Contents == ProxyContents.Single)
                    {
                        marshalledEvents = (SharpVk.Interop.Event*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Event>());
                        *(SharpVk.Interop.Event*)(marshalledEvents) = events.Value.GetSingleValue()?.handle ?? default(SharpVk.Interop.Event);
                    }
                    else
                    {
                        var fieldPointer = (SharpVk.Interop.Event*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.Event>(Interop.HeapUtil.GetLength(events.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(events.Value)); index++)
                        {
                            fieldPointer[index] = events.Value[index]?.handle ?? default(SharpVk.Interop.Event);
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
                SharpVk.Interop.VkCommandBufferWaitEventsDelegate commandDelegate = commandCache.GetCommandDelegate<SharpVk.Interop.VkCommandBufferWaitEventsDelegate>("vkCmdWaitEvents", "");
                commandDelegate(this.handle, (uint)(Interop.HeapUtil.GetLength(events)), marshalledEvents, sourceStageMask, destinationStageMask, (uint)(Interop.HeapUtil.GetLength(memoryBarriers)), marshalledMemoryBarriers, (uint)(Interop.HeapUtil.GetLength(bufferMemoryBarriers)), marshalledBufferMemoryBarriers, (uint)(Interop.HeapUtil.GetLength(imageMemoryBarriers)), marshalledImageMemoryBarriers);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Insert a memory dependency.
        /// </summary>
        public unsafe void PipelineBarrier(SharpVk.PipelineStageFlags sourceStageMask, SharpVk.PipelineStageFlags destinationStageMask, ArrayProxy<SharpVk.MemoryBarrier>? memoryBarriers, ArrayProxy<SharpVk.BufferMemoryBarrier>? bufferMemoryBarriers, ArrayProxy<SharpVk.ImageMemoryBarrier>? imageMemoryBarriers, SharpVk.DependencyFlags? dependencyFlags = default(SharpVk.DependencyFlags?))
        {
            try
            {
                SharpVk.DependencyFlags marshalledDependencyFlags = default(SharpVk.DependencyFlags);
                SharpVk.Interop.MemoryBarrier* marshalledMemoryBarriers = default(SharpVk.Interop.MemoryBarrier*);
                SharpVk.Interop.BufferMemoryBarrier* marshalledBufferMemoryBarriers = default(SharpVk.Interop.BufferMemoryBarrier*);
                SharpVk.Interop.ImageMemoryBarrier* marshalledImageMemoryBarriers = default(SharpVk.Interop.ImageMemoryBarrier*);
                if (dependencyFlags != null)
                {
                    marshalledDependencyFlags = dependencyFlags.Value;
                }
                else
                {
                    marshalledDependencyFlags = default(SharpVk.DependencyFlags);
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
                SharpVk.Interop.VkCommandBufferPipelineBarrierDelegate commandDelegate = commandCache.GetCommandDelegate<SharpVk.Interop.VkCommandBufferPipelineBarrierDelegate>("vkCmdPipelineBarrier", "");
                commandDelegate(this.handle, sourceStageMask, destinationStageMask, marshalledDependencyFlags, (uint)(Interop.HeapUtil.GetLength(memoryBarriers)), marshalledMemoryBarriers, (uint)(Interop.HeapUtil.GetLength(bufferMemoryBarriers)), marshalledBufferMemoryBarriers, (uint)(Interop.HeapUtil.GetLength(imageMemoryBarriers)), marshalledImageMemoryBarriers);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Begin a query.
        /// </summary>
        public unsafe void BeginQuery(SharpVk.QueryPool queryPool, uint query, SharpVk.QueryControlFlags? flags = default(SharpVk.QueryControlFlags?))
        {
            try
            {
                SharpVk.QueryControlFlags marshalledFlags = default(SharpVk.QueryControlFlags);
                if (flags != null)
                {
                    marshalledFlags = flags.Value;
                }
                else
                {
                    marshalledFlags = default(SharpVk.QueryControlFlags);
                }
                SharpVk.Interop.VkCommandBufferBeginQueryDelegate commandDelegate = commandCache.GetCommandDelegate<SharpVk.Interop.VkCommandBufferBeginQueryDelegate>("vkCmdBeginQuery", "");
                commandDelegate(this.handle, queryPool?.handle ?? default(SharpVk.Interop.QueryPool), query, marshalledFlags);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Ends a query.
        /// </summary>
        public unsafe void EndQuery(SharpVk.QueryPool queryPool, uint query)
        {
            try
            {
                SharpVk.Interop.VkCommandBufferEndQueryDelegate commandDelegate = commandCache.GetCommandDelegate<SharpVk.Interop.VkCommandBufferEndQueryDelegate>("vkCmdEndQuery", "");
                commandDelegate(this.handle, queryPool?.handle ?? default(SharpVk.Interop.QueryPool), query);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Reset queries in a query pool.
        /// </summary>
        public unsafe void ResetQueryPool(SharpVk.QueryPool queryPool, uint firstQuery, uint queryCount)
        {
            try
            {
                SharpVk.Interop.VkCommandBufferResetQueryPoolDelegate commandDelegate = commandCache.GetCommandDelegate<SharpVk.Interop.VkCommandBufferResetQueryPoolDelegate>("vkCmdResetQueryPool", "");
                commandDelegate(this.handle, queryPool?.handle ?? default(SharpVk.Interop.QueryPool), firstQuery, queryCount);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Write a device timestamp into a query object.
        /// </summary>
        public unsafe void WriteTimestamp(SharpVk.PipelineStageFlags pipelineStage, SharpVk.QueryPool queryPool, uint query)
        {
            try
            {
                SharpVk.Interop.VkCommandBufferWriteTimestampDelegate commandDelegate = commandCache.GetCommandDelegate<SharpVk.Interop.VkCommandBufferWriteTimestampDelegate>("vkCmdWriteTimestamp", "");
                commandDelegate(this.handle, pipelineStage, queryPool?.handle ?? default(SharpVk.Interop.QueryPool), query);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Copy the results of queries in a query pool to a buffer object.
        /// </summary>
        public unsafe void CopyQueryPoolResults(SharpVk.QueryPool queryPool, uint firstQuery, uint queryCount, SharpVk.Buffer destinationBuffer, DeviceSize destinationOffset, DeviceSize stride, SharpVk.QueryResultFlags? flags = default(SharpVk.QueryResultFlags?))
        {
            try
            {
                SharpVk.QueryResultFlags marshalledFlags = default(SharpVk.QueryResultFlags);
                if (flags != null)
                {
                    marshalledFlags = flags.Value;
                }
                else
                {
                    marshalledFlags = default(SharpVk.QueryResultFlags);
                }
                SharpVk.Interop.VkCommandBufferCopyQueryPoolResultsDelegate commandDelegate = commandCache.GetCommandDelegate<SharpVk.Interop.VkCommandBufferCopyQueryPoolResultsDelegate>("vkCmdCopyQueryPoolResults", "");
                commandDelegate(this.handle, queryPool?.handle ?? default(SharpVk.Interop.QueryPool), firstQuery, queryCount, destinationBuffer?.handle ?? default(SharpVk.Interop.Buffer), destinationOffset, stride, marshalledFlags);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Update the values of push constants.
        /// </summary>
        public unsafe void PushConstants(SharpVk.PipelineLayout layout, SharpVk.ShaderStageFlags stageFlags, uint offset, ArrayProxy<byte>? values)
        {
            try
            {
                byte* marshalledValues = default(byte*);
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
                SharpVk.Interop.VkCommandBufferPushConstantsDelegate commandDelegate = commandCache.GetCommandDelegate<SharpVk.Interop.VkCommandBufferPushConstantsDelegate>("vkCmdPushConstants", "");
                commandDelegate(this.handle, layout?.handle ?? default(SharpVk.Interop.PipelineLayout), stageFlags, offset, (uint)(Interop.HeapUtil.GetLength(values)), marshalledValues);
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
        public unsafe void BeginRenderPass(SharpVk.RenderPass renderPass, SharpVk.Framebuffer framebuffer, SharpVk.Rect2D renderArea, ArrayProxy<SharpVk.ClearValue>? clearValues, SharpVk.SubpassContents contents, SharpVk.Khronos.Experimental.DeviceGroupRenderPassBeginInfo? deviceGroupRenderPassBeginInfoKhx = null, SharpVk.Multivendor.RenderPassSampleLocationsBeginInfo? renderPassSampleLocationsBeginInfoExt = null)
        {
            try
            {
                SharpVk.Interop.RenderPassBeginInfo* marshalledRenderPassBegin = default(SharpVk.Interop.RenderPassBeginInfo*);
                marshalledRenderPassBegin = (SharpVk.Interop.RenderPassBeginInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.RenderPassBeginInfo>());
                marshalledRenderPassBegin->SType = StructureType.RenderPassBeginInfo;
                marshalledRenderPassBegin->Next = null;
                marshalledRenderPassBegin->RenderPass = renderPass?.handle ?? default(SharpVk.Interop.RenderPass);
                marshalledRenderPassBegin->Framebuffer = framebuffer?.handle ?? default(SharpVk.Interop.Framebuffer);
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
                        marshalledRenderPassBegin->ClearValues = (SharpVk.ClearValue*)(Interop.HeapUtil.Allocate<SharpVk.ClearValue>());
                        *(SharpVk.ClearValue*)(marshalledRenderPassBegin->ClearValues) = clearValues.Value.GetSingleValue();
                    }
                    else
                    {
                        var fieldPointer = (SharpVk.ClearValue*)(Interop.HeapUtil.AllocateAndClear<SharpVk.ClearValue>(Interop.HeapUtil.GetLength(clearValues.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(clearValues.Value)); index++)
                        {
                            fieldPointer[index] = clearValues.Value[index];
                        }
                        marshalledRenderPassBegin->ClearValues = fieldPointer;
                    }
                }
                SharpVk.Interop.VkCommandBufferBeginRenderPassDelegate commandDelegate = commandCache.GetCommandDelegate<SharpVk.Interop.VkCommandBufferBeginRenderPassDelegate>("vkCmdBeginRenderPass", "");
                commandDelegate(this.handle, marshalledRenderPassBegin, contents);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Transition to the next subpass of a render pass.
        /// </summary>
        public unsafe void NextSubpass(SharpVk.SubpassContents contents)
        {
            try
            {
                SharpVk.Interop.VkCommandBufferNextSubpassDelegate commandDelegate = commandCache.GetCommandDelegate<SharpVk.Interop.VkCommandBufferNextSubpassDelegate>("vkCmdNextSubpass", "");
                commandDelegate(this.handle, contents);
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
                SharpVk.Interop.VkCommandBufferEndRenderPassDelegate commandDelegate = commandCache.GetCommandDelegate<SharpVk.Interop.VkCommandBufferEndRenderPassDelegate>("vkCmdEndRenderPass", "");
                commandDelegate(this.handle);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Execute a secondary command buffer from a primary command buffer.
        /// </summary>
        public unsafe void ExecuteCommands(ArrayProxy<SharpVk.CommandBuffer>? commandBuffers)
        {
            try
            {
                SharpVk.Interop.CommandBuffer* marshalledCommandBuffers = default(SharpVk.Interop.CommandBuffer*);
                if (commandBuffers.IsNull())
                {
                    marshalledCommandBuffers = null;
                }
                else
                {
                    if (commandBuffers.Value.Contents == ProxyContents.Single)
                    {
                        marshalledCommandBuffers = (SharpVk.Interop.CommandBuffer*)(Interop.HeapUtil.Allocate<SharpVk.Interop.CommandBuffer>());
                        *(SharpVk.Interop.CommandBuffer*)(marshalledCommandBuffers) = commandBuffers.Value.GetSingleValue()?.handle ?? default(SharpVk.Interop.CommandBuffer);
                    }
                    else
                    {
                        var fieldPointer = (SharpVk.Interop.CommandBuffer*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.CommandBuffer>(Interop.HeapUtil.GetLength(commandBuffers.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(commandBuffers.Value)); index++)
                        {
                            fieldPointer[index] = commandBuffers.Value[index]?.handle ?? default(SharpVk.Interop.CommandBuffer);
                        }
                        marshalledCommandBuffers = fieldPointer;
                    }
                }
                SharpVk.Interop.VkCommandBufferExecuteCommandsDelegate commandDelegate = commandCache.GetCommandDelegate<SharpVk.Interop.VkCommandBufferExecuteCommandsDelegate>("vkCmdExecuteCommands", "");
                commandDelegate(this.handle, (uint)(Interop.HeapUtil.GetLength(commandBuffers)), marshalledCommandBuffers);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
    }
}
