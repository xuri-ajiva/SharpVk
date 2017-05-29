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
        
        internal unsafe void Begin(CommandBufferBeginInfo beginInfo)
        {
            Interop.CommandBufferBeginInfo* marshalledBeginInfo;
            marshalledBeginInfo = (Interop.CommandBufferBeginInfo*)(Interop.HeapUtil.Allocate<Interop.CommandBufferBeginInfo>());
            beginInfo.MarshalTo(marshalledBeginInfo);
        }
        
        internal unsafe void End()
        {
        }
        
        internal unsafe void Reset(CommandBufferResetFlags flags)
        {
            CommandBufferResetFlags marshalledFlags;
            marshalledFlags = flags;
        }
        
        internal unsafe void BindPipeline(PipelineBindPoint pipelineBindPoint, Pipeline pipeline)
        {
            PipelineBindPoint marshalledPipelineBindPoint;
            marshalledPipelineBindPoint = pipelineBindPoint;
            Interop.Pipeline marshalledPipeline;
            marshalledPipeline = pipeline.handle;
        }
        
        internal unsafe void SetViewport(uint firstViewport, Viewport[] viewports)
        {
            uint marshalledFirstViewport;
            marshalledFirstViewport = firstViewport;
            uint marshalledViewportCount;
            marshalledViewportCount = (uint)(viewports?.Length ?? 0);
            Viewport* marshalledViewports;
            if (viewports != null)
            {
                var fieldPointer = (Viewport*)(Interop.HeapUtil.AllocateAndClear<Viewport>(viewports.Length).ToPointer());
                for(int index = 0; index < viewports.Length; index++)
                {
                    fieldPointer[index] = viewports[index];
                }
                marshalledViewports = fieldPointer;
            }
            else
            {
                marshalledViewports = null;
            }
        }
        
        internal unsafe void SetScissor(uint firstScissor, Rect2D[] scissors)
        {
            uint marshalledFirstScissor;
            marshalledFirstScissor = firstScissor;
            uint marshalledScissorCount;
            marshalledScissorCount = (uint)(scissors?.Length ?? 0);
            Rect2D* marshalledScissors;
            if (scissors != null)
            {
                var fieldPointer = (Rect2D*)(Interop.HeapUtil.AllocateAndClear<Rect2D>(scissors.Length).ToPointer());
                for(int index = 0; index < scissors.Length; index++)
                {
                    fieldPointer[index] = scissors[index];
                }
                marshalledScissors = fieldPointer;
            }
            else
            {
                marshalledScissors = null;
            }
        }
        
        internal unsafe void SetLineWidth(float lineWidth)
        {
            float marshalledLineWidth;
            marshalledLineWidth = lineWidth;
        }
        
        internal unsafe void SetDepthBias(float depthBiasConstantFactor, float depthBiasClamp, float depthBiasSlopeFactor)
        {
            float marshalledDepthBiasConstantFactor;
            marshalledDepthBiasConstantFactor = depthBiasConstantFactor;
            float marshalledDepthBiasClamp;
            marshalledDepthBiasClamp = depthBiasClamp;
            float marshalledDepthBiasSlopeFactor;
            marshalledDepthBiasSlopeFactor = depthBiasSlopeFactor;
        }
        
        internal unsafe void SetBlendConstants(float blendConstants)
        {
            float marshalledBlendConstants;
            marshalledBlendConstants = blendConstants;
        }
        
        internal unsafe void SetDepthBounds(float minDepthBounds, float maxDepthBounds)
        {
            float marshalledMinDepthBounds;
            marshalledMinDepthBounds = minDepthBounds;
            float marshalledMaxDepthBounds;
            marshalledMaxDepthBounds = maxDepthBounds;
        }
        
        internal unsafe void SetStencilCompareMask(StencilFaceFlags faceMask, uint compareMask)
        {
            StencilFaceFlags marshalledFaceMask;
            marshalledFaceMask = faceMask;
            uint marshalledCompareMask;
            marshalledCompareMask = compareMask;
        }
        
        internal unsafe void SetStencilWriteMask(StencilFaceFlags faceMask, uint writeMask)
        {
            StencilFaceFlags marshalledFaceMask;
            marshalledFaceMask = faceMask;
            uint marshalledWriteMask;
            marshalledWriteMask = writeMask;
        }
        
        internal unsafe void SetStencilReference(StencilFaceFlags faceMask, uint reference)
        {
            StencilFaceFlags marshalledFaceMask;
            marshalledFaceMask = faceMask;
            uint marshalledReference;
            marshalledReference = reference;
        }
        
        internal unsafe void BindDescriptorSets(PipelineBindPoint pipelineBindPoint, PipelineLayout layout, uint firstSet, DescriptorSet[] descriptorSets, uint[] dynamicOffsets)
        {
            PipelineBindPoint marshalledPipelineBindPoint;
            marshalledPipelineBindPoint = pipelineBindPoint;
            Interop.PipelineLayout marshalledLayout;
            marshalledLayout = layout.handle;
            uint marshalledFirstSet;
            marshalledFirstSet = firstSet;
            uint marshalledDescriptorSetCount;
            marshalledDescriptorSetCount = (uint)(descriptorSets?.Length ?? 0);
            Interop.DescriptorSet* marshalledDescriptorSets;
            if (descriptorSets != null)
            {
                var fieldPointer = (Interop.DescriptorSet*)(Interop.HeapUtil.AllocateAndClear<Interop.DescriptorSet>(descriptorSets.Length).ToPointer());
                for(int index = 0; index < descriptorSets.Length; index++)
                {
                    fieldPointer[index] = descriptorSets[index].handle;
                }
                marshalledDescriptorSets = fieldPointer;
            }
            else
            {
                marshalledDescriptorSets = null;
            }
            uint marshalledDynamicOffsetCount;
            marshalledDynamicOffsetCount = (uint)(dynamicOffsets?.Length ?? 0);
            uint* marshalledDynamicOffsets;
            if (dynamicOffsets != null)
            {
                var fieldPointer = (uint*)(Interop.HeapUtil.AllocateAndClear<uint>(dynamicOffsets.Length).ToPointer());
                for(int index = 0; index < dynamicOffsets.Length; index++)
                {
                    fieldPointer[index] = dynamicOffsets[index];
                }
                marshalledDynamicOffsets = fieldPointer;
            }
            else
            {
                marshalledDynamicOffsets = null;
            }
        }
        
        internal unsafe void BindIndexBuffer(Buffer buffer, DeviceSize offset, IndexType indexType)
        {
            Interop.Buffer marshalledBuffer;
            marshalledBuffer = buffer.handle;
            DeviceSize marshalledOffset;
            marshalledOffset = offset;
            IndexType marshalledIndexType;
            marshalledIndexType = indexType;
        }
        
        internal unsafe void BindVertexBuffers(uint firstBinding, Buffer[] buffers, DeviceSize[] offsets)
        {
            uint marshalledFirstBinding;
            marshalledFirstBinding = firstBinding;
            uint marshalledBindingCount;
            marshalledBindingCount = (uint)(buffers?.Length ?? 0);
            Interop.Buffer* marshalledBuffers;
            if (buffers != null)
            {
                var fieldPointer = (Interop.Buffer*)(Interop.HeapUtil.AllocateAndClear<Interop.Buffer>(buffers.Length).ToPointer());
                for(int index = 0; index < buffers.Length; index++)
                {
                    fieldPointer[index] = buffers[index].handle;
                }
                marshalledBuffers = fieldPointer;
            }
            else
            {
                marshalledBuffers = null;
            }
            DeviceSize* marshalledOffsets;
            if (offsets != null)
            {
                var fieldPointer = (DeviceSize*)(Interop.HeapUtil.AllocateAndClear<DeviceSize>(offsets.Length).ToPointer());
                for(int index = 0; index < offsets.Length; index++)
                {
                    fieldPointer[index] = offsets[index];
                }
                marshalledOffsets = fieldPointer;
            }
            else
            {
                marshalledOffsets = null;
            }
        }
        
        internal unsafe void Draw(uint vertexCount, uint instanceCount, uint firstVertex, uint firstInstance)
        {
            uint marshalledVertexCount;
            marshalledVertexCount = vertexCount;
            uint marshalledInstanceCount;
            marshalledInstanceCount = instanceCount;
            uint marshalledFirstVertex;
            marshalledFirstVertex = firstVertex;
            uint marshalledFirstInstance;
            marshalledFirstInstance = firstInstance;
        }
        
        internal unsafe void DrawIndexed(uint indexCount, uint instanceCount, uint firstIndex, int vertexOffset, uint firstInstance)
        {
            uint marshalledIndexCount;
            marshalledIndexCount = indexCount;
            uint marshalledInstanceCount;
            marshalledInstanceCount = instanceCount;
            uint marshalledFirstIndex;
            marshalledFirstIndex = firstIndex;
            int marshalledVertexOffset;
            marshalledVertexOffset = vertexOffset;
            uint marshalledFirstInstance;
            marshalledFirstInstance = firstInstance;
        }
        
        internal unsafe void DrawIndirect(Buffer buffer, DeviceSize offset, uint drawCount, uint stride)
        {
            Interop.Buffer marshalledBuffer;
            marshalledBuffer = buffer.handle;
            DeviceSize marshalledOffset;
            marshalledOffset = offset;
            uint marshalledDrawCount;
            marshalledDrawCount = drawCount;
            uint marshalledStride;
            marshalledStride = stride;
        }
        
        internal unsafe void DrawIndexedIndirect(Buffer buffer, DeviceSize offset, uint drawCount, uint stride)
        {
            Interop.Buffer marshalledBuffer;
            marshalledBuffer = buffer.handle;
            DeviceSize marshalledOffset;
            marshalledOffset = offset;
            uint marshalledDrawCount;
            marshalledDrawCount = drawCount;
            uint marshalledStride;
            marshalledStride = stride;
        }
        
        internal unsafe void Dispatch(uint groupCountX, uint groupCountY, uint groupCountZ)
        {
            uint marshalledGroupCountX;
            marshalledGroupCountX = groupCountX;
            uint marshalledGroupCountY;
            marshalledGroupCountY = groupCountY;
            uint marshalledGroupCountZ;
            marshalledGroupCountZ = groupCountZ;
        }
        
        internal unsafe void DispatchIndirect(Buffer buffer, DeviceSize offset)
        {
            Interop.Buffer marshalledBuffer;
            marshalledBuffer = buffer.handle;
            DeviceSize marshalledOffset;
            marshalledOffset = offset;
        }
        
        internal unsafe void CopyBuffer(Buffer sourceBuffer, Buffer destinationBuffer, BufferCopy[] regions)
        {
            Interop.Buffer marshalledSourceBuffer;
            marshalledSourceBuffer = sourceBuffer.handle;
            Interop.Buffer marshalledDestinationBuffer;
            marshalledDestinationBuffer = destinationBuffer.handle;
            uint marshalledRegionCount;
            marshalledRegionCount = (uint)(regions?.Length ?? 0);
            BufferCopy* marshalledRegions;
            if (regions != null)
            {
                var fieldPointer = (BufferCopy*)(Interop.HeapUtil.AllocateAndClear<BufferCopy>(regions.Length).ToPointer());
                for(int index = 0; index < regions.Length; index++)
                {
                    fieldPointer[index] = regions[index];
                }
                marshalledRegions = fieldPointer;
            }
            else
            {
                marshalledRegions = null;
            }
        }
        
        internal unsafe void CopyImage(Image sourceImage, ImageLayout sourceImageLayout, Image destinationImage, ImageLayout destinationImageLayout, ImageCopy[] regions)
        {
            Interop.Image marshalledSourceImage;
            marshalledSourceImage = sourceImage.handle;
            ImageLayout marshalledSourceImageLayout;
            marshalledSourceImageLayout = sourceImageLayout;
            Interop.Image marshalledDestinationImage;
            marshalledDestinationImage = destinationImage.handle;
            ImageLayout marshalledDestinationImageLayout;
            marshalledDestinationImageLayout = destinationImageLayout;
            uint marshalledRegionCount;
            marshalledRegionCount = (uint)(regions?.Length ?? 0);
            ImageCopy* marshalledRegions;
            if (regions != null)
            {
                var fieldPointer = (ImageCopy*)(Interop.HeapUtil.AllocateAndClear<ImageCopy>(regions.Length).ToPointer());
                for(int index = 0; index < regions.Length; index++)
                {
                    fieldPointer[index] = regions[index];
                }
                marshalledRegions = fieldPointer;
            }
            else
            {
                marshalledRegions = null;
            }
        }
        
        internal unsafe void BlitImage(Image sourceImage, ImageLayout sourceImageLayout, Image destinationImage, ImageLayout destinationImageLayout, ImageBlit[] regions, Filter filter)
        {
            Interop.Image marshalledSourceImage;
            marshalledSourceImage = sourceImage.handle;
            ImageLayout marshalledSourceImageLayout;
            marshalledSourceImageLayout = sourceImageLayout;
            Interop.Image marshalledDestinationImage;
            marshalledDestinationImage = destinationImage.handle;
            ImageLayout marshalledDestinationImageLayout;
            marshalledDestinationImageLayout = destinationImageLayout;
            uint marshalledRegionCount;
            marshalledRegionCount = (uint)(regions?.Length ?? 0);
            Interop.ImageBlit* marshalledRegions;
            if (regions != null)
            {
                var fieldPointer = (Interop.ImageBlit*)(Interop.HeapUtil.AllocateAndClear<Interop.ImageBlit>(regions.Length).ToPointer());
                for(int index = 0; index < regions.Length; index++)
                {
                    regions[index].MarshalTo(&fieldPointer[index]);
                }
                marshalledRegions = fieldPointer;
            }
            else
            {
                marshalledRegions = null;
            }
            Filter marshalledFilter;
            marshalledFilter = filter;
        }
        
        internal unsafe void CopyBufferToImage(Buffer sourceBuffer, Image destinationImage, ImageLayout destinationImageLayout, BufferImageCopy[] regions)
        {
            Interop.Buffer marshalledSourceBuffer;
            marshalledSourceBuffer = sourceBuffer.handle;
            Interop.Image marshalledDestinationImage;
            marshalledDestinationImage = destinationImage.handle;
            ImageLayout marshalledDestinationImageLayout;
            marshalledDestinationImageLayout = destinationImageLayout;
            uint marshalledRegionCount;
            marshalledRegionCount = (uint)(regions?.Length ?? 0);
            BufferImageCopy* marshalledRegions;
            if (regions != null)
            {
                var fieldPointer = (BufferImageCopy*)(Interop.HeapUtil.AllocateAndClear<BufferImageCopy>(regions.Length).ToPointer());
                for(int index = 0; index < regions.Length; index++)
                {
                    fieldPointer[index] = regions[index];
                }
                marshalledRegions = fieldPointer;
            }
            else
            {
                marshalledRegions = null;
            }
        }
        
        internal unsafe void CopyImageToBuffer(Image sourceImage, ImageLayout sourceImageLayout, Buffer destinationBuffer, BufferImageCopy[] regions)
        {
            Interop.Image marshalledSourceImage;
            marshalledSourceImage = sourceImage.handle;
            ImageLayout marshalledSourceImageLayout;
            marshalledSourceImageLayout = sourceImageLayout;
            Interop.Buffer marshalledDestinationBuffer;
            marshalledDestinationBuffer = destinationBuffer.handle;
            uint marshalledRegionCount;
            marshalledRegionCount = (uint)(regions?.Length ?? 0);
            BufferImageCopy* marshalledRegions;
            if (regions != null)
            {
                var fieldPointer = (BufferImageCopy*)(Interop.HeapUtil.AllocateAndClear<BufferImageCopy>(regions.Length).ToPointer());
                for(int index = 0; index < regions.Length; index++)
                {
                    fieldPointer[index] = regions[index];
                }
                marshalledRegions = fieldPointer;
            }
            else
            {
                marshalledRegions = null;
            }
        }
        
        internal unsafe void UpdateBuffer(Buffer destinationBuffer, DeviceSize destinationOffset, byte[] data)
        {
            Interop.Buffer marshalledDestinationBuffer;
            marshalledDestinationBuffer = destinationBuffer.handle;
            DeviceSize marshalledDestinationOffset;
            marshalledDestinationOffset = destinationOffset;
            DeviceSize marshalledDataSize;
            marshalledDataSize = (DeviceSize)(data?.Length ?? 0);
            byte* marshalledData;
            if (data != null)
            {
                var fieldPointer = (byte*)(Interop.HeapUtil.AllocateAndClear<byte>(data.Length).ToPointer());
                for(int index = 0; index < data.Length; index++)
                {
                    fieldPointer[index] = data[index];
                }
                marshalledData = fieldPointer;
            }
            else
            {
                marshalledData = null;
            }
        }
        
        internal unsafe void FillBuffer(Buffer destinationBuffer, DeviceSize destinationOffset, DeviceSize size, uint data)
        {
            Interop.Buffer marshalledDestinationBuffer;
            marshalledDestinationBuffer = destinationBuffer.handle;
            DeviceSize marshalledDestinationOffset;
            marshalledDestinationOffset = destinationOffset;
            DeviceSize marshalledSize;
            marshalledSize = size;
            uint marshalledData;
            marshalledData = data;
        }
        
        internal unsafe void ClearColorImage(Image image, ImageLayout imageLayout, ClearColorValue color, ImageSubresourceRange[] ranges)
        {
            Interop.Image marshalledImage;
            marshalledImage = image.handle;
            ImageLayout marshalledImageLayout;
            marshalledImageLayout = imageLayout;
            ClearColorValue* marshalledColor;
            marshalledColor = (ClearColorValue*)(Interop.HeapUtil.Allocate<ClearColorValue>());
            *marshalledColor = color;
            uint marshalledRangeCount;
            marshalledRangeCount = (uint)(ranges?.Length ?? 0);
            ImageSubresourceRange* marshalledRanges;
            if (ranges != null)
            {
                var fieldPointer = (ImageSubresourceRange*)(Interop.HeapUtil.AllocateAndClear<ImageSubresourceRange>(ranges.Length).ToPointer());
                for(int index = 0; index < ranges.Length; index++)
                {
                    fieldPointer[index] = ranges[index];
                }
                marshalledRanges = fieldPointer;
            }
            else
            {
                marshalledRanges = null;
            }
        }
        
        internal unsafe void ClearDepthStencilImage(Image image, ImageLayout imageLayout, ClearDepthStencilValue depthStencil, ImageSubresourceRange[] ranges)
        {
            Interop.Image marshalledImage;
            marshalledImage = image.handle;
            ImageLayout marshalledImageLayout;
            marshalledImageLayout = imageLayout;
            ClearDepthStencilValue* marshalledDepthStencil;
            marshalledDepthStencil = (ClearDepthStencilValue*)(Interop.HeapUtil.Allocate<ClearDepthStencilValue>());
            *marshalledDepthStencil = depthStencil;
            uint marshalledRangeCount;
            marshalledRangeCount = (uint)(ranges?.Length ?? 0);
            ImageSubresourceRange* marshalledRanges;
            if (ranges != null)
            {
                var fieldPointer = (ImageSubresourceRange*)(Interop.HeapUtil.AllocateAndClear<ImageSubresourceRange>(ranges.Length).ToPointer());
                for(int index = 0; index < ranges.Length; index++)
                {
                    fieldPointer[index] = ranges[index];
                }
                marshalledRanges = fieldPointer;
            }
            else
            {
                marshalledRanges = null;
            }
        }
        
        internal unsafe void ClearAttachments(ClearAttachment[] attachments, ClearRect[] rects)
        {
            uint marshalledAttachmentCount;
            marshalledAttachmentCount = (uint)(attachments?.Length ?? 0);
            ClearAttachment* marshalledAttachments;
            if (attachments != null)
            {
                var fieldPointer = (ClearAttachment*)(Interop.HeapUtil.AllocateAndClear<ClearAttachment>(attachments.Length).ToPointer());
                for(int index = 0; index < attachments.Length; index++)
                {
                    fieldPointer[index] = attachments[index];
                }
                marshalledAttachments = fieldPointer;
            }
            else
            {
                marshalledAttachments = null;
            }
            uint marshalledRectCount;
            marshalledRectCount = (uint)(rects?.Length ?? 0);
            ClearRect* marshalledRects;
            if (rects != null)
            {
                var fieldPointer = (ClearRect*)(Interop.HeapUtil.AllocateAndClear<ClearRect>(rects.Length).ToPointer());
                for(int index = 0; index < rects.Length; index++)
                {
                    fieldPointer[index] = rects[index];
                }
                marshalledRects = fieldPointer;
            }
            else
            {
                marshalledRects = null;
            }
        }
        
        internal unsafe void ResolveImage(Image sourceImage, ImageLayout sourceImageLayout, Image destinationImage, ImageLayout destinationImageLayout, ImageResolve[] regions)
        {
            Interop.Image marshalledSourceImage;
            marshalledSourceImage = sourceImage.handle;
            ImageLayout marshalledSourceImageLayout;
            marshalledSourceImageLayout = sourceImageLayout;
            Interop.Image marshalledDestinationImage;
            marshalledDestinationImage = destinationImage.handle;
            ImageLayout marshalledDestinationImageLayout;
            marshalledDestinationImageLayout = destinationImageLayout;
            uint marshalledRegionCount;
            marshalledRegionCount = (uint)(regions?.Length ?? 0);
            ImageResolve* marshalledRegions;
            if (regions != null)
            {
                var fieldPointer = (ImageResolve*)(Interop.HeapUtil.AllocateAndClear<ImageResolve>(regions.Length).ToPointer());
                for(int index = 0; index < regions.Length; index++)
                {
                    fieldPointer[index] = regions[index];
                }
                marshalledRegions = fieldPointer;
            }
            else
            {
                marshalledRegions = null;
            }
        }
        
        internal unsafe void SetEvent(Event @event, PipelineStageFlags stageMask)
        {
            Interop.Event marshalledEvent;
            marshalledEvent = @event.handle;
            PipelineStageFlags marshalledStageMask;
            marshalledStageMask = stageMask;
        }
        
        internal unsafe void ResetEvent(Event @event, PipelineStageFlags stageMask)
        {
            Interop.Event marshalledEvent;
            marshalledEvent = @event.handle;
            PipelineStageFlags marshalledStageMask;
            marshalledStageMask = stageMask;
        }
        
        internal unsafe void WaitEvents(Event[] events, PipelineStageFlags sourceStageMask, PipelineStageFlags destinationStageMask, MemoryBarrier[] memoryBarriers, BufferMemoryBarrier[] bufferMemoryBarriers, ImageMemoryBarrier[] imageMemoryBarriers)
        {
            uint marshalledEventCount;
            marshalledEventCount = (uint)(events?.Length ?? 0);
            Interop.Event* marshalledEvents;
            if (events != null)
            {
                var fieldPointer = (Interop.Event*)(Interop.HeapUtil.AllocateAndClear<Interop.Event>(events.Length).ToPointer());
                for(int index = 0; index < events.Length; index++)
                {
                    fieldPointer[index] = events[index].handle;
                }
                marshalledEvents = fieldPointer;
            }
            else
            {
                marshalledEvents = null;
            }
            PipelineStageFlags marshalledSourceStageMask;
            marshalledSourceStageMask = sourceStageMask;
            PipelineStageFlags marshalledDestinationStageMask;
            marshalledDestinationStageMask = destinationStageMask;
            uint marshalledMemoryBarrierCount;
            marshalledMemoryBarrierCount = (uint)(memoryBarriers?.Length ?? 0);
            Interop.MemoryBarrier* marshalledMemoryBarriers;
            if (memoryBarriers != null)
            {
                var fieldPointer = (Interop.MemoryBarrier*)(Interop.HeapUtil.AllocateAndClear<Interop.MemoryBarrier>(memoryBarriers.Length).ToPointer());
                for(int index = 0; index < memoryBarriers.Length; index++)
                {
                    memoryBarriers[index].MarshalTo(&fieldPointer[index]);
                }
                marshalledMemoryBarriers = fieldPointer;
            }
            else
            {
                marshalledMemoryBarriers = null;
            }
            uint marshalledBufferMemoryBarrierCount;
            marshalledBufferMemoryBarrierCount = (uint)(bufferMemoryBarriers?.Length ?? 0);
            Interop.BufferMemoryBarrier* marshalledBufferMemoryBarriers;
            if (bufferMemoryBarriers != null)
            {
                var fieldPointer = (Interop.BufferMemoryBarrier*)(Interop.HeapUtil.AllocateAndClear<Interop.BufferMemoryBarrier>(bufferMemoryBarriers.Length).ToPointer());
                for(int index = 0; index < bufferMemoryBarriers.Length; index++)
                {
                    bufferMemoryBarriers[index].MarshalTo(&fieldPointer[index]);
                }
                marshalledBufferMemoryBarriers = fieldPointer;
            }
            else
            {
                marshalledBufferMemoryBarriers = null;
            }
            uint marshalledImageMemoryBarrierCount;
            marshalledImageMemoryBarrierCount = (uint)(imageMemoryBarriers?.Length ?? 0);
            Interop.ImageMemoryBarrier* marshalledImageMemoryBarriers;
            if (imageMemoryBarriers != null)
            {
                var fieldPointer = (Interop.ImageMemoryBarrier*)(Interop.HeapUtil.AllocateAndClear<Interop.ImageMemoryBarrier>(imageMemoryBarriers.Length).ToPointer());
                for(int index = 0; index < imageMemoryBarriers.Length; index++)
                {
                    imageMemoryBarriers[index].MarshalTo(&fieldPointer[index]);
                }
                marshalledImageMemoryBarriers = fieldPointer;
            }
            else
            {
                marshalledImageMemoryBarriers = null;
            }
        }
        
        internal unsafe void PipelineBarrier(PipelineStageFlags sourceStageMask, PipelineStageFlags destinationStageMask, DependencyFlags dependencyFlags, MemoryBarrier[] memoryBarriers, BufferMemoryBarrier[] bufferMemoryBarriers, ImageMemoryBarrier[] imageMemoryBarriers)
        {
            PipelineStageFlags marshalledSourceStageMask;
            marshalledSourceStageMask = sourceStageMask;
            PipelineStageFlags marshalledDestinationStageMask;
            marshalledDestinationStageMask = destinationStageMask;
            DependencyFlags marshalledDependencyFlags;
            marshalledDependencyFlags = dependencyFlags;
            uint marshalledMemoryBarrierCount;
            marshalledMemoryBarrierCount = (uint)(memoryBarriers?.Length ?? 0);
            Interop.MemoryBarrier* marshalledMemoryBarriers;
            if (memoryBarriers != null)
            {
                var fieldPointer = (Interop.MemoryBarrier*)(Interop.HeapUtil.AllocateAndClear<Interop.MemoryBarrier>(memoryBarriers.Length).ToPointer());
                for(int index = 0; index < memoryBarriers.Length; index++)
                {
                    memoryBarriers[index].MarshalTo(&fieldPointer[index]);
                }
                marshalledMemoryBarriers = fieldPointer;
            }
            else
            {
                marshalledMemoryBarriers = null;
            }
            uint marshalledBufferMemoryBarrierCount;
            marshalledBufferMemoryBarrierCount = (uint)(bufferMemoryBarriers?.Length ?? 0);
            Interop.BufferMemoryBarrier* marshalledBufferMemoryBarriers;
            if (bufferMemoryBarriers != null)
            {
                var fieldPointer = (Interop.BufferMemoryBarrier*)(Interop.HeapUtil.AllocateAndClear<Interop.BufferMemoryBarrier>(bufferMemoryBarriers.Length).ToPointer());
                for(int index = 0; index < bufferMemoryBarriers.Length; index++)
                {
                    bufferMemoryBarriers[index].MarshalTo(&fieldPointer[index]);
                }
                marshalledBufferMemoryBarriers = fieldPointer;
            }
            else
            {
                marshalledBufferMemoryBarriers = null;
            }
            uint marshalledImageMemoryBarrierCount;
            marshalledImageMemoryBarrierCount = (uint)(imageMemoryBarriers?.Length ?? 0);
            Interop.ImageMemoryBarrier* marshalledImageMemoryBarriers;
            if (imageMemoryBarriers != null)
            {
                var fieldPointer = (Interop.ImageMemoryBarrier*)(Interop.HeapUtil.AllocateAndClear<Interop.ImageMemoryBarrier>(imageMemoryBarriers.Length).ToPointer());
                for(int index = 0; index < imageMemoryBarriers.Length; index++)
                {
                    imageMemoryBarriers[index].MarshalTo(&fieldPointer[index]);
                }
                marshalledImageMemoryBarriers = fieldPointer;
            }
            else
            {
                marshalledImageMemoryBarriers = null;
            }
        }
        
        internal unsafe void BeginQuery(QueryPool queryPool, uint query, QueryControlFlags flags)
        {
            Interop.QueryPool marshalledQueryPool;
            marshalledQueryPool = queryPool.handle;
            uint marshalledQuery;
            marshalledQuery = query;
            QueryControlFlags marshalledFlags;
            marshalledFlags = flags;
        }
        
        internal unsafe void EndQuery(QueryPool queryPool, uint query)
        {
            Interop.QueryPool marshalledQueryPool;
            marshalledQueryPool = queryPool.handle;
            uint marshalledQuery;
            marshalledQuery = query;
        }
        
        internal unsafe void ResetQueryPool(QueryPool queryPool, uint firstQuery, uint queryCount)
        {
            Interop.QueryPool marshalledQueryPool;
            marshalledQueryPool = queryPool.handle;
            uint marshalledFirstQuery;
            marshalledFirstQuery = firstQuery;
            uint marshalledQueryCount;
            marshalledQueryCount = queryCount;
        }
        
        internal unsafe void WriteTimestamp(PipelineStageFlags pipelineStage, QueryPool queryPool, uint query)
        {
            PipelineStageFlags marshalledPipelineStage;
            marshalledPipelineStage = pipelineStage;
            Interop.QueryPool marshalledQueryPool;
            marshalledQueryPool = queryPool.handle;
            uint marshalledQuery;
            marshalledQuery = query;
        }
        
        internal unsafe void CopyQueryPoolResults(QueryPool queryPool, uint firstQuery, uint queryCount, Buffer destinationBuffer, DeviceSize destinationOffset, DeviceSize stride, QueryResultFlags flags)
        {
            Interop.QueryPool marshalledQueryPool;
            marshalledQueryPool = queryPool.handle;
            uint marshalledFirstQuery;
            marshalledFirstQuery = firstQuery;
            uint marshalledQueryCount;
            marshalledQueryCount = queryCount;
            Interop.Buffer marshalledDestinationBuffer;
            marshalledDestinationBuffer = destinationBuffer.handle;
            DeviceSize marshalledDestinationOffset;
            marshalledDestinationOffset = destinationOffset;
            DeviceSize marshalledStride;
            marshalledStride = stride;
            QueryResultFlags marshalledFlags;
            marshalledFlags = flags;
        }
        
        internal unsafe void PushConstants(PipelineLayout layout, ShaderStageFlags stageFlags, uint offset, byte[] values)
        {
            Interop.PipelineLayout marshalledLayout;
            marshalledLayout = layout.handle;
            ShaderStageFlags marshalledStageFlags;
            marshalledStageFlags = stageFlags;
            uint marshalledOffset;
            marshalledOffset = offset;
            uint marshalledSize;
            marshalledSize = (uint)(values?.Length ?? 0);
            byte* marshalledValues;
            if (values != null)
            {
                var fieldPointer = (byte*)(Interop.HeapUtil.AllocateAndClear<byte>(values.Length).ToPointer());
                for(int index = 0; index < values.Length; index++)
                {
                    fieldPointer[index] = values[index];
                }
                marshalledValues = fieldPointer;
            }
            else
            {
                marshalledValues = null;
            }
        }
        
        internal unsafe void BeginRenderPass(RenderPassBeginInfo renderPassBegin, SubpassContents contents)
        {
            Interop.RenderPassBeginInfo* marshalledRenderPassBegin;
            marshalledRenderPassBegin = (Interop.RenderPassBeginInfo*)(Interop.HeapUtil.Allocate<Interop.RenderPassBeginInfo>());
            renderPassBegin.MarshalTo(marshalledRenderPassBegin);
            SubpassContents marshalledContents;
            marshalledContents = contents;
        }
        
        internal unsafe void NextSubpass(SubpassContents contents)
        {
            SubpassContents marshalledContents;
            marshalledContents = contents;
        }
        
        internal unsafe void EndRenderPass()
        {
        }
        
        internal unsafe void ExecuteCommands(CommandBuffer[] commandBuffers)
        {
            uint marshalledCommandBufferCount;
            marshalledCommandBufferCount = (uint)(commandBuffers?.Length ?? 0);
            Interop.CommandBuffer* marshalledCommandBuffers;
            if (commandBuffers != null)
            {
                var fieldPointer = (Interop.CommandBuffer*)(Interop.HeapUtil.AllocateAndClear<Interop.CommandBuffer>(commandBuffers.Length).ToPointer());
                for(int index = 0; index < commandBuffers.Length; index++)
                {
                    fieldPointer[index] = commandBuffers[index].handle;
                }
                marshalledCommandBuffers = fieldPointer;
            }
            else
            {
                marshalledCommandBuffers = null;
            }
        }
    }
}
