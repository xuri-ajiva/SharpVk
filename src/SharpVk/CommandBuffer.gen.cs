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
    /// 
    /// </summary>
    public partial class CommandBuffer
    {
        internal readonly SharpVk.Interop.CommandBuffer handle; 
        
        internal CommandBuffer(SharpVk.Interop.CommandBuffer handle)
        {
            this.handle = handle;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public unsafe void Begin(CommandBufferBeginInfo beginInfo)
        {
            try
            {
                Interop.CommandBufferBeginInfo* marshalledBeginInfo = default(Interop.CommandBufferBeginInfo*);
                marshalledBeginInfo = (Interop.CommandBufferBeginInfo*)(Interop.HeapUtil.Allocate<Interop.CommandBufferBeginInfo>());
                beginInfo.MarshalTo(marshalledBeginInfo);
                Interop.Commands.vkBeginCommandBuffer(this.handle, marshalledBeginInfo);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        public unsafe void End()
        {
            try
            {
                Interop.Commands.vkEndCommandBuffer(this.handle);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        public unsafe void Reset(CommandBufferResetFlags flags)
        {
            try
            {
                Interop.Commands.vkResetCommandBuffer(this.handle, flags);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        public unsafe void BindPipeline(PipelineBindPoint pipelineBindPoint, Pipeline pipeline)
        {
            try
            {
                Interop.Commands.vkCmdBindPipeline(this.handle, pipelineBindPoint, pipeline.handle);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        public unsafe void SetViewport(uint firstViewport, uint viewportCount, Viewport[] viewports)
        {
            try
            {
                Viewport* marshalledViewports = default(Viewport*);
                if (viewports != null)
                {
                    var fieldPointer = (Viewport*)(Interop.HeapUtil.AllocateAndClear<Viewport>(viewports.Length).ToPointer());
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
                Interop.Commands.vkCmdSetViewport(this.handle, firstViewport, viewportCount, marshalledViewports);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        public unsafe void SetScissor(uint firstScissor, uint scissorCount, Rect2D[] scissors)
        {
            try
            {
                Rect2D* marshalledScissors = default(Rect2D*);
                if (scissors != null)
                {
                    var fieldPointer = (Rect2D*)(Interop.HeapUtil.AllocateAndClear<Rect2D>(scissors.Length).ToPointer());
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
                Interop.Commands.vkCmdSetScissor(this.handle, firstScissor, scissorCount, marshalledScissors);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// 
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
        /// 
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
        /// 
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
        /// 
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
        /// 
        /// </summary>
        public unsafe void SetStencilCompareMask(StencilFaceFlags faceMask, uint compareMask)
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
        /// 
        /// </summary>
        public unsafe void SetStencilWriteMask(StencilFaceFlags faceMask, uint writeMask)
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
        /// 
        /// </summary>
        public unsafe void SetStencilReference(StencilFaceFlags faceMask, uint reference)
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
        /// 
        /// </summary>
        public unsafe void BindDescriptorSets(PipelineBindPoint pipelineBindPoint, PipelineLayout layout, uint firstSet, uint descriptorSetCount, DescriptorSet[] descriptorSets, uint dynamicOffsetCount, uint[] dynamicOffsets)
        {
            try
            {
                Interop.DescriptorSet* marshalledDescriptorSets = default(Interop.DescriptorSet*);
                uint* marshalledDynamicOffsets = default(uint*);
                if (descriptorSets != null)
                {
                    var fieldPointer = (Interop.DescriptorSet*)(Interop.HeapUtil.AllocateAndClear<Interop.DescriptorSet>(descriptorSets.Length).ToPointer());
                    for(int index = 0; index < (uint)(descriptorSets.Length); index++)
                    {
                        fieldPointer[index] = descriptorSets[index].handle;
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
                Interop.Commands.vkCmdBindDescriptorSets(this.handle, pipelineBindPoint, layout.handle, firstSet, descriptorSetCount, marshalledDescriptorSets, dynamicOffsetCount, marshalledDynamicOffsets);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        public unsafe void BindIndexBuffer(Buffer buffer, DeviceSize offset, IndexType indexType)
        {
            try
            {
                Interop.Commands.vkCmdBindIndexBuffer(this.handle, buffer.handle, offset, indexType);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        public unsafe void BindVertexBuffers(uint firstBinding, uint bindingCount, Buffer[] buffers, DeviceSize[] offsets)
        {
            try
            {
                Interop.Buffer* marshalledBuffers = default(Interop.Buffer*);
                DeviceSize* marshalledOffsets = default(DeviceSize*);
                if (buffers != null)
                {
                    var fieldPointer = (Interop.Buffer*)(Interop.HeapUtil.AllocateAndClear<Interop.Buffer>(buffers.Length).ToPointer());
                    for(int index = 0; index < (uint)(buffers.Length); index++)
                    {
                        fieldPointer[index] = buffers[index].handle;
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
                Interop.Commands.vkCmdBindVertexBuffers(this.handle, firstBinding, bindingCount, marshalledBuffers, marshalledOffsets);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// 
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
        /// 
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
        /// 
        /// </summary>
        public unsafe void DrawIndirect(Buffer buffer, DeviceSize offset, uint drawCount, uint stride)
        {
            try
            {
                Interop.Commands.vkCmdDrawIndirect(this.handle, buffer.handle, offset, drawCount, stride);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        public unsafe void DrawIndexedIndirect(Buffer buffer, DeviceSize offset, uint drawCount, uint stride)
        {
            try
            {
                Interop.Commands.vkCmdDrawIndexedIndirect(this.handle, buffer.handle, offset, drawCount, stride);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// 
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
        /// 
        /// </summary>
        public unsafe void DispatchIndirect(Buffer buffer, DeviceSize offset)
        {
            try
            {
                Interop.Commands.vkCmdDispatchIndirect(this.handle, buffer.handle, offset);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        public unsafe void CopyBuffer(Buffer sourceBuffer, Buffer destinationBuffer, uint regionCount, BufferCopy[] regions)
        {
            try
            {
                BufferCopy* marshalledRegions = default(BufferCopy*);
                if (regions != null)
                {
                    var fieldPointer = (BufferCopy*)(Interop.HeapUtil.AllocateAndClear<BufferCopy>(regions.Length).ToPointer());
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
                Interop.Commands.vkCmdCopyBuffer(this.handle, sourceBuffer.handle, destinationBuffer.handle, regionCount, marshalledRegions);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        public unsafe void CopyImage(Image sourceImage, ImageLayout sourceImageLayout, Image destinationImage, ImageLayout destinationImageLayout, uint regionCount, ImageCopy[] regions)
        {
            try
            {
                ImageCopy* marshalledRegions = default(ImageCopy*);
                if (regions != null)
                {
                    var fieldPointer = (ImageCopy*)(Interop.HeapUtil.AllocateAndClear<ImageCopy>(regions.Length).ToPointer());
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
                Interop.Commands.vkCmdCopyImage(this.handle, sourceImage.handle, sourceImageLayout, destinationImage.handle, destinationImageLayout, regionCount, marshalledRegions);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        public unsafe void BlitImage(Image sourceImage, ImageLayout sourceImageLayout, Image destinationImage, ImageLayout destinationImageLayout, uint regionCount, ImageBlit[] regions, Filter filter)
        {
            try
            {
                Interop.ImageBlit* marshalledRegions = default(Interop.ImageBlit*);
                if (regions != null)
                {
                    var fieldPointer = (Interop.ImageBlit*)(Interop.HeapUtil.AllocateAndClear<Interop.ImageBlit>(regions.Length).ToPointer());
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
                Interop.Commands.vkCmdBlitImage(this.handle, sourceImage.handle, sourceImageLayout, destinationImage.handle, destinationImageLayout, regionCount, marshalledRegions, filter);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        public unsafe void CopyBufferToImage(Buffer sourceBuffer, Image destinationImage, ImageLayout destinationImageLayout, uint regionCount, BufferImageCopy[] regions)
        {
            try
            {
                BufferImageCopy* marshalledRegions = default(BufferImageCopy*);
                if (regions != null)
                {
                    var fieldPointer = (BufferImageCopy*)(Interop.HeapUtil.AllocateAndClear<BufferImageCopy>(regions.Length).ToPointer());
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
                Interop.Commands.vkCmdCopyBufferToImage(this.handle, sourceBuffer.handle, destinationImage.handle, destinationImageLayout, regionCount, marshalledRegions);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        public unsafe void CopyImageToBuffer(Image sourceImage, ImageLayout sourceImageLayout, Buffer destinationBuffer, uint regionCount, BufferImageCopy[] regions)
        {
            try
            {
                BufferImageCopy* marshalledRegions = default(BufferImageCopy*);
                if (regions != null)
                {
                    var fieldPointer = (BufferImageCopy*)(Interop.HeapUtil.AllocateAndClear<BufferImageCopy>(regions.Length).ToPointer());
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
                Interop.Commands.vkCmdCopyImageToBuffer(this.handle, sourceImage.handle, sourceImageLayout, destinationBuffer.handle, regionCount, marshalledRegions);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        public unsafe void UpdateBuffer(Buffer destinationBuffer, DeviceSize destinationOffset, DeviceSize dataSize, byte[] data)
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
                Interop.Commands.vkCmdUpdateBuffer(this.handle, destinationBuffer.handle, destinationOffset, dataSize, marshalledData);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        public unsafe void FillBuffer(Buffer destinationBuffer, DeviceSize destinationOffset, DeviceSize size, uint data)
        {
            try
            {
                Interop.Commands.vkCmdFillBuffer(this.handle, destinationBuffer.handle, destinationOffset, size, data);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        public unsafe void ClearColorImage(Image image, ImageLayout imageLayout, ClearColorValue color, uint rangeCount, ImageSubresourceRange[] ranges)
        {
            try
            {
                ClearColorValue* marshalledColor = default(ClearColorValue*);
                ImageSubresourceRange* marshalledRanges = default(ImageSubresourceRange*);
                marshalledColor = (ClearColorValue*)(Interop.HeapUtil.Allocate<ClearColorValue>());
                *marshalledColor = color;
                if (ranges != null)
                {
                    var fieldPointer = (ImageSubresourceRange*)(Interop.HeapUtil.AllocateAndClear<ImageSubresourceRange>(ranges.Length).ToPointer());
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
                Interop.Commands.vkCmdClearColorImage(this.handle, image.handle, imageLayout, marshalledColor, rangeCount, marshalledRanges);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        public unsafe void ClearDepthStencilImage(Image image, ImageLayout imageLayout, ClearDepthStencilValue depthStencil, uint rangeCount, ImageSubresourceRange[] ranges)
        {
            try
            {
                ClearDepthStencilValue* marshalledDepthStencil = default(ClearDepthStencilValue*);
                ImageSubresourceRange* marshalledRanges = default(ImageSubresourceRange*);
                marshalledDepthStencil = (ClearDepthStencilValue*)(Interop.HeapUtil.Allocate<ClearDepthStencilValue>());
                *marshalledDepthStencil = depthStencil;
                if (ranges != null)
                {
                    var fieldPointer = (ImageSubresourceRange*)(Interop.HeapUtil.AllocateAndClear<ImageSubresourceRange>(ranges.Length).ToPointer());
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
                Interop.Commands.vkCmdClearDepthStencilImage(this.handle, image.handle, imageLayout, marshalledDepthStencil, rangeCount, marshalledRanges);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        public unsafe void ClearAttachments(uint attachmentCount, ClearAttachment[] attachments, uint rectCount, ClearRect[] rects)
        {
            try
            {
                ClearAttachment* marshalledAttachments = default(ClearAttachment*);
                ClearRect* marshalledRects = default(ClearRect*);
                if (attachments != null)
                {
                    var fieldPointer = (ClearAttachment*)(Interop.HeapUtil.AllocateAndClear<ClearAttachment>(attachments.Length).ToPointer());
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
                    var fieldPointer = (ClearRect*)(Interop.HeapUtil.AllocateAndClear<ClearRect>(rects.Length).ToPointer());
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
                Interop.Commands.vkCmdClearAttachments(this.handle, attachmentCount, marshalledAttachments, rectCount, marshalledRects);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        public unsafe void ResolveImage(Image sourceImage, ImageLayout sourceImageLayout, Image destinationImage, ImageLayout destinationImageLayout, uint regionCount, ImageResolve[] regions)
        {
            try
            {
                ImageResolve* marshalledRegions = default(ImageResolve*);
                if (regions != null)
                {
                    var fieldPointer = (ImageResolve*)(Interop.HeapUtil.AllocateAndClear<ImageResolve>(regions.Length).ToPointer());
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
                Interop.Commands.vkCmdResolveImage(this.handle, sourceImage.handle, sourceImageLayout, destinationImage.handle, destinationImageLayout, regionCount, marshalledRegions);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        public unsafe void SetEvent(Event @event, PipelineStageFlags stageMask)
        {
            try
            {
                Interop.Commands.vkCmdSetEvent(this.handle, @event.handle, stageMask);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        public unsafe void ResetEvent(Event @event, PipelineStageFlags stageMask)
        {
            try
            {
                Interop.Commands.vkCmdResetEvent(this.handle, @event.handle, stageMask);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        public unsafe void WaitEvents(uint eventCount, Event[] events, PipelineStageFlags sourceStageMask, PipelineStageFlags destinationStageMask, uint memoryBarrierCount, MemoryBarrier[] memoryBarriers, uint bufferMemoryBarrierCount, BufferMemoryBarrier[] bufferMemoryBarriers, uint imageMemoryBarrierCount, ImageMemoryBarrier[] imageMemoryBarriers)
        {
            try
            {
                Interop.Event* marshalledEvents = default(Interop.Event*);
                Interop.MemoryBarrier* marshalledMemoryBarriers = default(Interop.MemoryBarrier*);
                Interop.BufferMemoryBarrier* marshalledBufferMemoryBarriers = default(Interop.BufferMemoryBarrier*);
                Interop.ImageMemoryBarrier* marshalledImageMemoryBarriers = default(Interop.ImageMemoryBarrier*);
                if (events != null)
                {
                    var fieldPointer = (Interop.Event*)(Interop.HeapUtil.AllocateAndClear<Interop.Event>(events.Length).ToPointer());
                    for(int index = 0; index < (uint)(events.Length); index++)
                    {
                        fieldPointer[index] = events[index].handle;
                    }
                    marshalledEvents = fieldPointer;
                }
                else
                {
                    marshalledEvents = null;
                }
                if (memoryBarriers != null)
                {
                    var fieldPointer = (Interop.MemoryBarrier*)(Interop.HeapUtil.AllocateAndClear<Interop.MemoryBarrier>(memoryBarriers.Length).ToPointer());
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
                    var fieldPointer = (Interop.BufferMemoryBarrier*)(Interop.HeapUtil.AllocateAndClear<Interop.BufferMemoryBarrier>(bufferMemoryBarriers.Length).ToPointer());
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
                    var fieldPointer = (Interop.ImageMemoryBarrier*)(Interop.HeapUtil.AllocateAndClear<Interop.ImageMemoryBarrier>(imageMemoryBarriers.Length).ToPointer());
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
                Interop.Commands.vkCmdWaitEvents(this.handle, eventCount, marshalledEvents, sourceStageMask, destinationStageMask, memoryBarrierCount, marshalledMemoryBarriers, bufferMemoryBarrierCount, marshalledBufferMemoryBarriers, imageMemoryBarrierCount, marshalledImageMemoryBarriers);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        public unsafe void PipelineBarrier(PipelineStageFlags sourceStageMask, PipelineStageFlags destinationStageMask, DependencyFlags dependencyFlags, uint memoryBarrierCount, MemoryBarrier[] memoryBarriers, uint bufferMemoryBarrierCount, BufferMemoryBarrier[] bufferMemoryBarriers, uint imageMemoryBarrierCount, ImageMemoryBarrier[] imageMemoryBarriers)
        {
            try
            {
                Interop.MemoryBarrier* marshalledMemoryBarriers = default(Interop.MemoryBarrier*);
                Interop.BufferMemoryBarrier* marshalledBufferMemoryBarriers = default(Interop.BufferMemoryBarrier*);
                Interop.ImageMemoryBarrier* marshalledImageMemoryBarriers = default(Interop.ImageMemoryBarrier*);
                if (memoryBarriers != null)
                {
                    var fieldPointer = (Interop.MemoryBarrier*)(Interop.HeapUtil.AllocateAndClear<Interop.MemoryBarrier>(memoryBarriers.Length).ToPointer());
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
                    var fieldPointer = (Interop.BufferMemoryBarrier*)(Interop.HeapUtil.AllocateAndClear<Interop.BufferMemoryBarrier>(bufferMemoryBarriers.Length).ToPointer());
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
                    var fieldPointer = (Interop.ImageMemoryBarrier*)(Interop.HeapUtil.AllocateAndClear<Interop.ImageMemoryBarrier>(imageMemoryBarriers.Length).ToPointer());
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
                Interop.Commands.vkCmdPipelineBarrier(this.handle, sourceStageMask, destinationStageMask, dependencyFlags, memoryBarrierCount, marshalledMemoryBarriers, bufferMemoryBarrierCount, marshalledBufferMemoryBarriers, imageMemoryBarrierCount, marshalledImageMemoryBarriers);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        public unsafe void BeginQuery(QueryPool queryPool, uint query, QueryControlFlags flags)
        {
            try
            {
                Interop.Commands.vkCmdBeginQuery(this.handle, queryPool.handle, query, flags);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        public unsafe void EndQuery(QueryPool queryPool, uint query)
        {
            try
            {
                Interop.Commands.vkCmdEndQuery(this.handle, queryPool.handle, query);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        public unsafe void ResetQueryPool(QueryPool queryPool, uint firstQuery, uint queryCount)
        {
            try
            {
                Interop.Commands.vkCmdResetQueryPool(this.handle, queryPool.handle, firstQuery, queryCount);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        public unsafe void WriteTimestamp(PipelineStageFlags pipelineStage, QueryPool queryPool, uint query)
        {
            try
            {
                Interop.Commands.vkCmdWriteTimestamp(this.handle, pipelineStage, queryPool.handle, query);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        public unsafe void CopyQueryPoolResults(QueryPool queryPool, uint firstQuery, uint queryCount, Buffer destinationBuffer, DeviceSize destinationOffset, DeviceSize stride, QueryResultFlags flags)
        {
            try
            {
                Interop.Commands.vkCmdCopyQueryPoolResults(this.handle, queryPool.handle, firstQuery, queryCount, destinationBuffer.handle, destinationOffset, stride, flags);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        public unsafe void PushConstants(PipelineLayout layout, ShaderStageFlags stageFlags, uint offset, uint size, byte[] values)
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
                Interop.Commands.vkCmdPushConstants(this.handle, layout.handle, stageFlags, offset, size, marshalledValues);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        public unsafe void BeginRenderPass(RenderPassBeginInfo renderPassBegin, SubpassContents contents)
        {
            try
            {
                Interop.RenderPassBeginInfo* marshalledRenderPassBegin = default(Interop.RenderPassBeginInfo*);
                marshalledRenderPassBegin = (Interop.RenderPassBeginInfo*)(Interop.HeapUtil.Allocate<Interop.RenderPassBeginInfo>());
                renderPassBegin.MarshalTo(marshalledRenderPassBegin);
                Interop.Commands.vkCmdBeginRenderPass(this.handle, marshalledRenderPassBegin, contents);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        public unsafe void NextSubpass(SubpassContents contents)
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
        /// 
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
        /// 
        /// </summary>
        public unsafe void ExecuteCommands(uint commandBufferCount, CommandBuffer[] commandBuffers)
        {
            try
            {
                Interop.CommandBuffer* marshalledCommandBuffers = default(Interop.CommandBuffer*);
                if (commandBuffers != null)
                {
                    var fieldPointer = (Interop.CommandBuffer*)(Interop.HeapUtil.AllocateAndClear<Interop.CommandBuffer>(commandBuffers.Length).ToPointer());
                    for(int index = 0; index < (uint)(commandBuffers.Length); index++)
                    {
                        fieldPointer[index] = commandBuffers[index].handle;
                    }
                    marshalledCommandBuffers = fieldPointer;
                }
                else
                {
                    marshalledCommandBuffers = null;
                }
                Interop.Commands.vkCmdExecuteCommands(this.handle, commandBufferCount, marshalledCommandBuffers);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
    }
}
