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
        /// Start recording a command buffer.
        /// </summary>
        /// <param name="flags">
        /// A bitmask indicating usage behavior for the command buffer. Bits
        /// which can be set include: + --
        /// </param>
        public unsafe void Begin(SharpVk.CommandBufferUsageFlags? flags = default(SharpVk.CommandBufferUsageFlags?), SharpVk.CommandBufferInheritanceInfo? inheritanceInfo = default(SharpVk.CommandBufferInheritanceInfo?))
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
                Result methodResult = Interop.Commands.vkBeginCommandBuffer(this.handle, marshalledBeginInfo);
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
                Result methodResult = Interop.Commands.vkEndCommandBuffer(this.handle);
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
                Result methodResult = Interop.Commands.vkResetCommandBuffer(this.handle, marshalledFlags);
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
                Interop.Commands.vkCmdBindPipeline(this.handle, pipelineBindPoint, pipeline?.handle ?? default(SharpVk.Interop.Pipeline));
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Set the viewport on a command buffer.
        /// </summary>
        public unsafe void SetViewport(uint firstViewport, SharpVk.Viewport[] viewports)
        {
            try
            {
                SharpVk.Viewport* marshalledViewports = default(SharpVk.Viewport*);
                if (viewports != null)
                {
                    var fieldPointer = (SharpVk.Viewport*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Viewport>(viewports.Length).ToPointer());
                    for(int index = 0; index < (uint)(viewports.Length); index++)
                    {
                        fieldPointer[index] = viewports[index];
                    }
                    marshalledViewports = fieldPointer;
                }
                else
                {
                    marshalledViewports = null;
                }
                Interop.Commands.vkCmdSetViewport(this.handle, firstViewport, (uint)(viewports?.Length ?? 0), marshalledViewports);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Set the dynamic scissor rectangles on a command buffer.
        /// </summary>
        public unsafe void SetScissor(uint firstScissor, SharpVk.Rect2D[] scissors)
        {
            try
            {
                SharpVk.Rect2D* marshalledScissors = default(SharpVk.Rect2D*);
                if (scissors != null)
                {
                    var fieldPointer = (SharpVk.Rect2D*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Rect2D>(scissors.Length).ToPointer());
                    for(int index = 0; index < (uint)(scissors.Length); index++)
                    {
                        fieldPointer[index] = scissors[index];
                    }
                    marshalledScissors = fieldPointer;
                }
                else
                {
                    marshalledScissors = null;
                }
                Interop.Commands.vkCmdSetScissor(this.handle, firstScissor, (uint)(scissors?.Length ?? 0), marshalledScissors);
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
                Interop.Commands.vkCmdSetLineWidth(this.handle, lineWidth);
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
                Interop.Commands.vkCmdSetDepthBias(this.handle, depthBiasConstantFactor, depthBiasClamp, depthBiasSlopeFactor);
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
                Interop.Commands.vkCmdSetBlendConstants(this.handle, blendConstants);
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
                Interop.Commands.vkCmdSetDepthBounds(this.handle, minDepthBounds, maxDepthBounds);
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
                Interop.Commands.vkCmdSetStencilCompareMask(this.handle, faceMask, compareMask);
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
                Interop.Commands.vkCmdSetStencilWriteMask(this.handle, faceMask, writeMask);
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
                Interop.Commands.vkCmdSetStencilReference(this.handle, faceMask, reference);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Binds descriptor sets to a command buffer.
        /// </summary>
        public unsafe void BindDescriptorSets(SharpVk.PipelineBindPoint pipelineBindPoint, SharpVk.PipelineLayout layout, uint firstSet, SharpVk.DescriptorSet[] descriptorSets, uint[] dynamicOffsets)
        {
            try
            {
                SharpVk.Interop.DescriptorSet* marshalledDescriptorSets = default(SharpVk.Interop.DescriptorSet*);
                uint* marshalledDynamicOffsets = default(uint*);
                if (descriptorSets != null)
                {
                    var fieldPointer = (SharpVk.Interop.DescriptorSet*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.DescriptorSet>(descriptorSets.Length).ToPointer());
                    for(int index = 0; index < (uint)(descriptorSets.Length); index++)
                    {
                        fieldPointer[index] = descriptorSets[index]?.handle ?? default(SharpVk.Interop.DescriptorSet);
                    }
                    marshalledDescriptorSets = fieldPointer;
                }
                else
                {
                    marshalledDescriptorSets = null;
                }
                if (dynamicOffsets != null)
                {
                    var fieldPointer = (uint*)(Interop.HeapUtil.AllocateAndClear<uint>(dynamicOffsets.Length).ToPointer());
                    for(int index = 0; index < (uint)(dynamicOffsets.Length); index++)
                    {
                        fieldPointer[index] = dynamicOffsets[index];
                    }
                    marshalledDynamicOffsets = fieldPointer;
                }
                else
                {
                    marshalledDynamicOffsets = null;
                }
                Interop.Commands.vkCmdBindDescriptorSets(this.handle, pipelineBindPoint, layout?.handle ?? default(SharpVk.Interop.PipelineLayout), firstSet, (uint)(descriptorSets?.Length ?? 0), marshalledDescriptorSets, (uint)(dynamicOffsets?.Length ?? 0), marshalledDynamicOffsets);
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
                Interop.Commands.vkCmdBindIndexBuffer(this.handle, buffer?.handle ?? default(SharpVk.Interop.Buffer), offset, indexType);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Bind vertex buffers to a command buffer.
        /// </summary>
        public unsafe void BindVertexBuffers(uint firstBinding, SharpVk.Buffer[] buffers, DeviceSize[] offsets)
        {
            try
            {
                SharpVk.Interop.Buffer* marshalledBuffers = default(SharpVk.Interop.Buffer*);
                DeviceSize* marshalledOffsets = default(DeviceSize*);
                if (buffers != null)
                {
                    var fieldPointer = (SharpVk.Interop.Buffer*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.Buffer>(buffers.Length).ToPointer());
                    for(int index = 0; index < (uint)(buffers.Length); index++)
                    {
                        fieldPointer[index] = buffers[index]?.handle ?? default(SharpVk.Interop.Buffer);
                    }
                    marshalledBuffers = fieldPointer;
                }
                else
                {
                    marshalledBuffers = null;
                }
                if (offsets != null)
                {
                    var fieldPointer = (DeviceSize*)(Interop.HeapUtil.AllocateAndClear<DeviceSize>(offsets.Length).ToPointer());
                    for(int index = 0; index < (uint)(offsets.Length); index++)
                    {
                        fieldPointer[index] = offsets[index];
                    }
                    marshalledOffsets = fieldPointer;
                }
                else
                {
                    marshalledOffsets = null;
                }
                Interop.Commands.vkCmdBindVertexBuffers(this.handle, firstBinding, (uint)(buffers?.Length ?? 0), marshalledBuffers, marshalledOffsets);
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
                Interop.Commands.vkCmdDraw(this.handle, vertexCount, instanceCount, firstVertex, firstInstance);
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
                Interop.Commands.vkCmdDrawIndexed(this.handle, indexCount, instanceCount, firstIndex, vertexOffset, firstInstance);
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
                Interop.Commands.vkCmdDrawIndirect(this.handle, buffer?.handle ?? default(SharpVk.Interop.Buffer), offset, drawCount, stride);
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
                Interop.Commands.vkCmdDrawIndexedIndirect(this.handle, buffer?.handle ?? default(SharpVk.Interop.Buffer), offset, drawCount, stride);
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
                Interop.Commands.vkCmdDispatch(this.handle, groupCountX, groupCountY, groupCountZ);
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
                Interop.Commands.vkCmdDispatchIndirect(this.handle, buffer?.handle ?? default(SharpVk.Interop.Buffer), offset);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Copy data between buffer regions.
        /// </summary>
        public unsafe void CopyBuffer(SharpVk.Buffer sourceBuffer, SharpVk.Buffer destinationBuffer, SharpVk.BufferCopy[] regions)
        {
            try
            {
                SharpVk.BufferCopy* marshalledRegions = default(SharpVk.BufferCopy*);
                if (regions != null)
                {
                    var fieldPointer = (SharpVk.BufferCopy*)(Interop.HeapUtil.AllocateAndClear<SharpVk.BufferCopy>(regions.Length).ToPointer());
                    for(int index = 0; index < (uint)(regions.Length); index++)
                    {
                        fieldPointer[index] = regions[index];
                    }
                    marshalledRegions = fieldPointer;
                }
                else
                {
                    marshalledRegions = null;
                }
                Interop.Commands.vkCmdCopyBuffer(this.handle, sourceBuffer?.handle ?? default(SharpVk.Interop.Buffer), destinationBuffer?.handle ?? default(SharpVk.Interop.Buffer), (uint)(regions?.Length ?? 0), marshalledRegions);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Copy data between images.
        /// </summary>
        public unsafe void CopyImage(SharpVk.Image sourceImage, SharpVk.ImageLayout sourceImageLayout, SharpVk.Image destinationImage, SharpVk.ImageLayout destinationImageLayout, SharpVk.ImageCopy[] regions)
        {
            try
            {
                SharpVk.ImageCopy* marshalledRegions = default(SharpVk.ImageCopy*);
                if (regions != null)
                {
                    var fieldPointer = (SharpVk.ImageCopy*)(Interop.HeapUtil.AllocateAndClear<SharpVk.ImageCopy>(regions.Length).ToPointer());
                    for(int index = 0; index < (uint)(regions.Length); index++)
                    {
                        fieldPointer[index] = regions[index];
                    }
                    marshalledRegions = fieldPointer;
                }
                else
                {
                    marshalledRegions = null;
                }
                Interop.Commands.vkCmdCopyImage(this.handle, sourceImage?.handle ?? default(SharpVk.Interop.Image), sourceImageLayout, destinationImage?.handle ?? default(SharpVk.Interop.Image), destinationImageLayout, (uint)(regions?.Length ?? 0), marshalledRegions);
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
        public unsafe void BlitImage(SharpVk.Image sourceImage, SharpVk.ImageLayout sourceImageLayout, SharpVk.Image destinationImage, SharpVk.ImageLayout destinationImageLayout, SharpVk.ImageBlit[] regions, SharpVk.Filter filter)
        {
            try
            {
                SharpVk.Interop.ImageBlit* marshalledRegions = default(SharpVk.Interop.ImageBlit*);
                if (regions != null)
                {
                    var fieldPointer = (SharpVk.Interop.ImageBlit*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.ImageBlit>(regions.Length).ToPointer());
                    for(int index = 0; index < (uint)(regions.Length); index++)
                    {
                        regions[index].MarshalTo(&fieldPointer[index]);
                    }
                    marshalledRegions = fieldPointer;
                }
                else
                {
                    marshalledRegions = null;
                }
                Interop.Commands.vkCmdBlitImage(this.handle, sourceImage?.handle ?? default(SharpVk.Interop.Image), sourceImageLayout, destinationImage?.handle ?? default(SharpVk.Interop.Image), destinationImageLayout, (uint)(regions?.Length ?? 0), marshalledRegions, filter);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Copy data from a buffer into an image.
        /// </summary>
        public unsafe void CopyBufferToImage(SharpVk.Buffer sourceBuffer, SharpVk.Image destinationImage, SharpVk.ImageLayout destinationImageLayout, SharpVk.BufferImageCopy[] regions)
        {
            try
            {
                SharpVk.BufferImageCopy* marshalledRegions = default(SharpVk.BufferImageCopy*);
                if (regions != null)
                {
                    var fieldPointer = (SharpVk.BufferImageCopy*)(Interop.HeapUtil.AllocateAndClear<SharpVk.BufferImageCopy>(regions.Length).ToPointer());
                    for(int index = 0; index < (uint)(regions.Length); index++)
                    {
                        fieldPointer[index] = regions[index];
                    }
                    marshalledRegions = fieldPointer;
                }
                else
                {
                    marshalledRegions = null;
                }
                Interop.Commands.vkCmdCopyBufferToImage(this.handle, sourceBuffer?.handle ?? default(SharpVk.Interop.Buffer), destinationImage?.handle ?? default(SharpVk.Interop.Image), destinationImageLayout, (uint)(regions?.Length ?? 0), marshalledRegions);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Copy image data into a buffer.
        /// </summary>
        public unsafe void CopyImageToBuffer(SharpVk.Image sourceImage, SharpVk.ImageLayout sourceImageLayout, SharpVk.Buffer destinationBuffer, SharpVk.BufferImageCopy[] regions)
        {
            try
            {
                SharpVk.BufferImageCopy* marshalledRegions = default(SharpVk.BufferImageCopy*);
                if (regions != null)
                {
                    var fieldPointer = (SharpVk.BufferImageCopy*)(Interop.HeapUtil.AllocateAndClear<SharpVk.BufferImageCopy>(regions.Length).ToPointer());
                    for(int index = 0; index < (uint)(regions.Length); index++)
                    {
                        fieldPointer[index] = regions[index];
                    }
                    marshalledRegions = fieldPointer;
                }
                else
                {
                    marshalledRegions = null;
                }
                Interop.Commands.vkCmdCopyImageToBuffer(this.handle, sourceImage?.handle ?? default(SharpVk.Interop.Image), sourceImageLayout, destinationBuffer?.handle ?? default(SharpVk.Interop.Buffer), (uint)(regions?.Length ?? 0), marshalledRegions);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Update a buffer's contents from host memory.
        /// </summary>
        public unsafe void UpdateBuffer(SharpVk.Buffer destinationBuffer, DeviceSize destinationOffset, byte[] data)
        {
            try
            {
                byte* marshalledData = default(byte*);
                if (data != null)
                {
                    var fieldPointer = (byte*)(Interop.HeapUtil.AllocateAndClear<byte>(data.Length).ToPointer());
                    for(int index = 0; index < (uint)(data.Length); index++)
                    {
                        fieldPointer[index] = data[index];
                    }
                    marshalledData = fieldPointer;
                }
                else
                {
                    marshalledData = null;
                }
                Interop.Commands.vkCmdUpdateBuffer(this.handle, destinationBuffer?.handle ?? default(SharpVk.Interop.Buffer), destinationOffset, (DeviceSize)(data?.Length ?? 0), marshalledData);
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
                Interop.Commands.vkCmdFillBuffer(this.handle, destinationBuffer?.handle ?? default(SharpVk.Interop.Buffer), destinationOffset, size, data);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Clear regions of a color image.
        /// </summary>
        public unsafe void ClearColorImage(SharpVk.Image image, SharpVk.ImageLayout imageLayout, SharpVk.ClearColorValue color, SharpVk.ImageSubresourceRange[] ranges)
        {
            try
            {
                SharpVk.ImageSubresourceRange* marshalledRanges = default(SharpVk.ImageSubresourceRange*);
                if (ranges != null)
                {
                    var fieldPointer = (SharpVk.ImageSubresourceRange*)(Interop.HeapUtil.AllocateAndClear<SharpVk.ImageSubresourceRange>(ranges.Length).ToPointer());
                    for(int index = 0; index < (uint)(ranges.Length); index++)
                    {
                        fieldPointer[index] = ranges[index];
                    }
                    marshalledRanges = fieldPointer;
                }
                else
                {
                    marshalledRanges = null;
                }
                Interop.Commands.vkCmdClearColorImage(this.handle, image?.handle ?? default(SharpVk.Interop.Image), imageLayout, default(SharpVk.Interop.ClearColorValue*), (uint)(ranges?.Length ?? 0), marshalledRanges);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Fill regions of a combined depth/stencil image.
        /// </summary>
        public unsafe void ClearDepthStencilImage(SharpVk.Image image, SharpVk.ImageLayout imageLayout, SharpVk.ClearDepthStencilValue depthStencil, SharpVk.ImageSubresourceRange[] ranges)
        {
            try
            {
                SharpVk.ClearDepthStencilValue* marshalledDepthStencil = default(SharpVk.ClearDepthStencilValue*);
                SharpVk.ImageSubresourceRange* marshalledRanges = default(SharpVk.ImageSubresourceRange*);
                marshalledDepthStencil = (SharpVk.ClearDepthStencilValue*)(Interop.HeapUtil.Allocate<SharpVk.ClearDepthStencilValue>());
                *marshalledDepthStencil = depthStencil;
                if (ranges != null)
                {
                    var fieldPointer = (SharpVk.ImageSubresourceRange*)(Interop.HeapUtil.AllocateAndClear<SharpVk.ImageSubresourceRange>(ranges.Length).ToPointer());
                    for(int index = 0; index < (uint)(ranges.Length); index++)
                    {
                        fieldPointer[index] = ranges[index];
                    }
                    marshalledRanges = fieldPointer;
                }
                else
                {
                    marshalledRanges = null;
                }
                Interop.Commands.vkCmdClearDepthStencilImage(this.handle, image?.handle ?? default(SharpVk.Interop.Image), imageLayout, marshalledDepthStencil, (uint)(ranges?.Length ?? 0), marshalledRanges);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Clear regions within currently bound framebuffer attachments.
        /// </summary>
        public unsafe void ClearAttachments(SharpVk.ClearAttachment[] attachments, SharpVk.ClearRect[] rects)
        {
            try
            {
                SharpVk.ClearAttachment* marshalledAttachments = default(SharpVk.ClearAttachment*);
                SharpVk.ClearRect* marshalledRects = default(SharpVk.ClearRect*);
                if (attachments != null)
                {
                    var fieldPointer = (SharpVk.ClearAttachment*)(Interop.HeapUtil.AllocateAndClear<SharpVk.ClearAttachment>(attachments.Length).ToPointer());
                    for(int index = 0; index < (uint)(attachments.Length); index++)
                    {
                        fieldPointer[index] = attachments[index];
                    }
                    marshalledAttachments = fieldPointer;
                }
                else
                {
                    marshalledAttachments = null;
                }
                if (rects != null)
                {
                    var fieldPointer = (SharpVk.ClearRect*)(Interop.HeapUtil.AllocateAndClear<SharpVk.ClearRect>(rects.Length).ToPointer());
                    for(int index = 0; index < (uint)(rects.Length); index++)
                    {
                        fieldPointer[index] = rects[index];
                    }
                    marshalledRects = fieldPointer;
                }
                else
                {
                    marshalledRects = null;
                }
                Interop.Commands.vkCmdClearAttachments(this.handle, (uint)(attachments?.Length ?? 0), marshalledAttachments, (uint)(rects?.Length ?? 0), marshalledRects);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Resolve regions of an image.
        /// </summary>
        public unsafe void ResolveImage(SharpVk.Image sourceImage, SharpVk.ImageLayout sourceImageLayout, SharpVk.Image destinationImage, SharpVk.ImageLayout destinationImageLayout, SharpVk.ImageResolve[] regions)
        {
            try
            {
                SharpVk.ImageResolve* marshalledRegions = default(SharpVk.ImageResolve*);
                if (regions != null)
                {
                    var fieldPointer = (SharpVk.ImageResolve*)(Interop.HeapUtil.AllocateAndClear<SharpVk.ImageResolve>(regions.Length).ToPointer());
                    for(int index = 0; index < (uint)(regions.Length); index++)
                    {
                        fieldPointer[index] = regions[index];
                    }
                    marshalledRegions = fieldPointer;
                }
                else
                {
                    marshalledRegions = null;
                }
                Interop.Commands.vkCmdResolveImage(this.handle, sourceImage?.handle ?? default(SharpVk.Interop.Image), sourceImageLayout, destinationImage?.handle ?? default(SharpVk.Interop.Image), destinationImageLayout, (uint)(regions?.Length ?? 0), marshalledRegions);
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
                Interop.Commands.vkCmdSetEvent(this.handle, @event?.handle ?? default(SharpVk.Interop.Event), stageMask);
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
                Interop.Commands.vkCmdResetEvent(this.handle, @event?.handle ?? default(SharpVk.Interop.Event), stageMask);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Wait for one or more events and insert a set of memory.
        /// </summary>
        public unsafe void WaitEvents(SharpVk.Event[] events, SharpVk.PipelineStageFlags sourceStageMask, SharpVk.PipelineStageFlags destinationStageMask, SharpVk.MemoryBarrier[] memoryBarriers, SharpVk.BufferMemoryBarrier[] bufferMemoryBarriers, SharpVk.ImageMemoryBarrier[] imageMemoryBarriers)
        {
            try
            {
                SharpVk.Interop.Event* marshalledEvents = default(SharpVk.Interop.Event*);
                SharpVk.Interop.MemoryBarrier* marshalledMemoryBarriers = default(SharpVk.Interop.MemoryBarrier*);
                SharpVk.Interop.BufferMemoryBarrier* marshalledBufferMemoryBarriers = default(SharpVk.Interop.BufferMemoryBarrier*);
                SharpVk.Interop.ImageMemoryBarrier* marshalledImageMemoryBarriers = default(SharpVk.Interop.ImageMemoryBarrier*);
                if (events != null)
                {
                    var fieldPointer = (SharpVk.Interop.Event*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.Event>(events.Length).ToPointer());
                    for(int index = 0; index < (uint)(events.Length); index++)
                    {
                        fieldPointer[index] = events[index]?.handle ?? default(SharpVk.Interop.Event);
                    }
                    marshalledEvents = fieldPointer;
                }
                else
                {
                    marshalledEvents = null;
                }
                if (memoryBarriers != null)
                {
                    var fieldPointer = (SharpVk.Interop.MemoryBarrier*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.MemoryBarrier>(memoryBarriers.Length).ToPointer());
                    for(int index = 0; index < (uint)(memoryBarriers.Length); index++)
                    {
                        memoryBarriers[index].MarshalTo(&fieldPointer[index]);
                    }
                    marshalledMemoryBarriers = fieldPointer;
                }
                else
                {
                    marshalledMemoryBarriers = null;
                }
                if (bufferMemoryBarriers != null)
                {
                    var fieldPointer = (SharpVk.Interop.BufferMemoryBarrier*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.BufferMemoryBarrier>(bufferMemoryBarriers.Length).ToPointer());
                    for(int index = 0; index < (uint)(bufferMemoryBarriers.Length); index++)
                    {
                        bufferMemoryBarriers[index].MarshalTo(&fieldPointer[index]);
                    }
                    marshalledBufferMemoryBarriers = fieldPointer;
                }
                else
                {
                    marshalledBufferMemoryBarriers = null;
                }
                if (imageMemoryBarriers != null)
                {
                    var fieldPointer = (SharpVk.Interop.ImageMemoryBarrier*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.ImageMemoryBarrier>(imageMemoryBarriers.Length).ToPointer());
                    for(int index = 0; index < (uint)(imageMemoryBarriers.Length); index++)
                    {
                        imageMemoryBarriers[index].MarshalTo(&fieldPointer[index]);
                    }
                    marshalledImageMemoryBarriers = fieldPointer;
                }
                else
                {
                    marshalledImageMemoryBarriers = null;
                }
                Interop.Commands.vkCmdWaitEvents(this.handle, (uint)(events?.Length ?? 0), marshalledEvents, sourceStageMask, destinationStageMask, (uint)(memoryBarriers?.Length ?? 0), marshalledMemoryBarriers, (uint)(bufferMemoryBarriers?.Length ?? 0), marshalledBufferMemoryBarriers, (uint)(imageMemoryBarriers?.Length ?? 0), marshalledImageMemoryBarriers);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Insert a memory dependency.
        /// </summary>
        public unsafe void PipelineBarrier(SharpVk.PipelineStageFlags sourceStageMask, SharpVk.PipelineStageFlags destinationStageMask, SharpVk.MemoryBarrier[] memoryBarriers, SharpVk.BufferMemoryBarrier[] bufferMemoryBarriers, SharpVk.ImageMemoryBarrier[] imageMemoryBarriers, SharpVk.DependencyFlags? dependencyFlags = default(SharpVk.DependencyFlags?))
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
                if (memoryBarriers != null)
                {
                    var fieldPointer = (SharpVk.Interop.MemoryBarrier*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.MemoryBarrier>(memoryBarriers.Length).ToPointer());
                    for(int index = 0; index < (uint)(memoryBarriers.Length); index++)
                    {
                        memoryBarriers[index].MarshalTo(&fieldPointer[index]);
                    }
                    marshalledMemoryBarriers = fieldPointer;
                }
                else
                {
                    marshalledMemoryBarriers = null;
                }
                if (bufferMemoryBarriers != null)
                {
                    var fieldPointer = (SharpVk.Interop.BufferMemoryBarrier*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.BufferMemoryBarrier>(bufferMemoryBarriers.Length).ToPointer());
                    for(int index = 0; index < (uint)(bufferMemoryBarriers.Length); index++)
                    {
                        bufferMemoryBarriers[index].MarshalTo(&fieldPointer[index]);
                    }
                    marshalledBufferMemoryBarriers = fieldPointer;
                }
                else
                {
                    marshalledBufferMemoryBarriers = null;
                }
                if (imageMemoryBarriers != null)
                {
                    var fieldPointer = (SharpVk.Interop.ImageMemoryBarrier*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.ImageMemoryBarrier>(imageMemoryBarriers.Length).ToPointer());
                    for(int index = 0; index < (uint)(imageMemoryBarriers.Length); index++)
                    {
                        imageMemoryBarriers[index].MarshalTo(&fieldPointer[index]);
                    }
                    marshalledImageMemoryBarriers = fieldPointer;
                }
                else
                {
                    marshalledImageMemoryBarriers = null;
                }
                Interop.Commands.vkCmdPipelineBarrier(this.handle, sourceStageMask, destinationStageMask, marshalledDependencyFlags, (uint)(memoryBarriers?.Length ?? 0), marshalledMemoryBarriers, (uint)(bufferMemoryBarriers?.Length ?? 0), marshalledBufferMemoryBarriers, (uint)(imageMemoryBarriers?.Length ?? 0), marshalledImageMemoryBarriers);
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
                Interop.Commands.vkCmdBeginQuery(this.handle, queryPool?.handle ?? default(SharpVk.Interop.QueryPool), query, marshalledFlags);
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
                Interop.Commands.vkCmdEndQuery(this.handle, queryPool?.handle ?? default(SharpVk.Interop.QueryPool), query);
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
                Interop.Commands.vkCmdResetQueryPool(this.handle, queryPool?.handle ?? default(SharpVk.Interop.QueryPool), firstQuery, queryCount);
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
                Interop.Commands.vkCmdWriteTimestamp(this.handle, pipelineStage, queryPool?.handle ?? default(SharpVk.Interop.QueryPool), query);
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
                Interop.Commands.vkCmdCopyQueryPoolResults(this.handle, queryPool?.handle ?? default(SharpVk.Interop.QueryPool), firstQuery, queryCount, destinationBuffer?.handle ?? default(SharpVk.Interop.Buffer), destinationOffset, stride, marshalledFlags);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Update the values of push constants.
        /// </summary>
        public unsafe void PushConstants(SharpVk.PipelineLayout layout, SharpVk.ShaderStageFlags stageFlags, uint offset, byte[] values)
        {
            try
            {
                byte* marshalledValues = default(byte*);
                if (values != null)
                {
                    var fieldPointer = (byte*)(Interop.HeapUtil.AllocateAndClear<byte>(values.Length).ToPointer());
                    for(int index = 0; index < (uint)(values.Length); index++)
                    {
                        fieldPointer[index] = values[index];
                    }
                    marshalledValues = fieldPointer;
                }
                else
                {
                    marshalledValues = null;
                }
                Interop.Commands.vkCmdPushConstants(this.handle, layout?.handle ?? default(SharpVk.Interop.PipelineLayout), stageFlags, offset, (uint)(values?.Length ?? 0), marshalledValues);
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
        /// An array of ClearValue structures that contains clear values for
        /// each attachment, if the attachment uses a loadOp value of
        /// VK_ATTACHMENT_LOAD_OP_CLEAR or if the attachment has a
        /// depth/stencil format and uses a stencilLoadOp value of
        /// VK_ATTACHMENT_LOAD_OP_CLEAR. The array is indexed by attachment
        /// number. Only elements corresponding to cleared attachments are
        /// used. Other elements of pClearValues are ignored.
        /// </param>
        public unsafe void BeginRenderPass(SharpVk.RenderPass renderPass, SharpVk.Framebuffer framebuffer, SharpVk.Rect2D renderArea, SharpVk.ClearValue[] clearValues, SharpVk.SubpassContents contents)
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
                marshalledRenderPassBegin->ClearValueCount = (uint)(clearValues?.Length ?? 0);
                if (clearValues != null)
                {
                    var fieldPointer = (SharpVk.ClearValue*)(Interop.HeapUtil.AllocateAndClear<SharpVk.ClearValue>(clearValues.Length).ToPointer());
                    for(int index = 0; index < (uint)(clearValues.Length); index++)
                    {
                        fieldPointer[index] = default(SharpVk.ClearValue);
                    }
                    marshalledRenderPassBegin->ClearValues = fieldPointer;
                }
                else
                {
                    marshalledRenderPassBegin->ClearValues = null;
                }
                Interop.Commands.vkCmdBeginRenderPass(this.handle, marshalledRenderPassBegin, contents);
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
                Interop.Commands.vkCmdNextSubpass(this.handle, contents);
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
                Interop.Commands.vkCmdEndRenderPass(this.handle);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Execute a secondary command buffer from a primary command buffer.
        /// </summary>
        public unsafe void ExecuteCommands(SharpVk.CommandBuffer[] commandBuffers)
        {
            try
            {
                SharpVk.Interop.CommandBuffer* marshalledCommandBuffers = default(SharpVk.Interop.CommandBuffer*);
                if (commandBuffers != null)
                {
                    var fieldPointer = (SharpVk.Interop.CommandBuffer*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.CommandBuffer>(commandBuffers.Length).ToPointer());
                    for(int index = 0; index < (uint)(commandBuffers.Length); index++)
                    {
                        fieldPointer[index] = commandBuffers[index]?.handle ?? default(SharpVk.Interop.CommandBuffer);
                    }
                    marshalledCommandBuffers = fieldPointer;
                }
                else
                {
                    marshalledCommandBuffers = null;
                }
                Interop.Commands.vkCmdExecuteCommands(this.handle, (uint)(commandBuffers?.Length ?? 0), marshalledCommandBuffers);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
    }
}
