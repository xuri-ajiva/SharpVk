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
                CommandBufferResetFlags marshalledFlags = default(CommandBufferResetFlags);
                marshalledFlags = flags;
                Interop.Commands.vkResetCommandBuffer(this.handle, marshalledFlags);
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
                PipelineBindPoint marshalledPipelineBindPoint = default(PipelineBindPoint);
                Interop.Pipeline marshalledPipeline = default(Interop.Pipeline);
                marshalledPipelineBindPoint = pipelineBindPoint;
                marshalledPipeline = pipeline.handle;
                Interop.Commands.vkCmdBindPipeline(this.handle, marshalledPipelineBindPoint, marshalledPipeline);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        public unsafe void SetViewport(uint firstViewport, Viewport[] viewports)
        {
            try
            {
                uint marshalledFirstViewport = default(uint);
                uint viewportCount = default(uint);
                Viewport* marshalledViewports = default(Viewport*);
                marshalledFirstViewport = firstViewport;
                viewportCount = (uint)(viewports?.Length ?? 0);
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
                Interop.Commands.vkCmdSetViewport(this.handle, marshalledFirstViewport, viewportCount, marshalledViewports);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        public unsafe void SetScissor(uint firstScissor, Rect2D[] scissors)
        {
            try
            {
                uint marshalledFirstScissor = default(uint);
                uint scissorCount = default(uint);
                Rect2D* marshalledScissors = default(Rect2D*);
                marshalledFirstScissor = firstScissor;
                scissorCount = (uint)(scissors?.Length ?? 0);
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
                Interop.Commands.vkCmdSetScissor(this.handle, marshalledFirstScissor, scissorCount, marshalledScissors);
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
                float marshalledLineWidth = default(float);
                marshalledLineWidth = lineWidth;
                Interop.Commands.vkCmdSetLineWidth(this.handle, marshalledLineWidth);
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
                float marshalledDepthBiasConstantFactor = default(float);
                float marshalledDepthBiasClamp = default(float);
                float marshalledDepthBiasSlopeFactor = default(float);
                marshalledDepthBiasConstantFactor = depthBiasConstantFactor;
                marshalledDepthBiasClamp = depthBiasClamp;
                marshalledDepthBiasSlopeFactor = depthBiasSlopeFactor;
                Interop.Commands.vkCmdSetDepthBias(this.handle, marshalledDepthBiasConstantFactor, marshalledDepthBiasClamp, marshalledDepthBiasSlopeFactor);
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
                float marshalledBlendConstants = default(float);
                marshalledBlendConstants = blendConstants;
                Interop.Commands.vkCmdSetBlendConstants(this.handle, marshalledBlendConstants);
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
                float marshalledMinDepthBounds = default(float);
                float marshalledMaxDepthBounds = default(float);
                marshalledMinDepthBounds = minDepthBounds;
                marshalledMaxDepthBounds = maxDepthBounds;
                Interop.Commands.vkCmdSetDepthBounds(this.handle, marshalledMinDepthBounds, marshalledMaxDepthBounds);
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
                StencilFaceFlags marshalledFaceMask = default(StencilFaceFlags);
                uint marshalledCompareMask = default(uint);
                marshalledFaceMask = faceMask;
                marshalledCompareMask = compareMask;
                Interop.Commands.vkCmdSetStencilCompareMask(this.handle, marshalledFaceMask, marshalledCompareMask);
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
                StencilFaceFlags marshalledFaceMask = default(StencilFaceFlags);
                uint marshalledWriteMask = default(uint);
                marshalledFaceMask = faceMask;
                marshalledWriteMask = writeMask;
                Interop.Commands.vkCmdSetStencilWriteMask(this.handle, marshalledFaceMask, marshalledWriteMask);
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
                StencilFaceFlags marshalledFaceMask = default(StencilFaceFlags);
                uint marshalledReference = default(uint);
                marshalledFaceMask = faceMask;
                marshalledReference = reference;
                Interop.Commands.vkCmdSetStencilReference(this.handle, marshalledFaceMask, marshalledReference);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        public unsafe void BindDescriptorSets(PipelineBindPoint pipelineBindPoint, PipelineLayout layout, uint firstSet, DescriptorSet[] descriptorSets, uint[] dynamicOffsets)
        {
            try
            {
                PipelineBindPoint marshalledPipelineBindPoint = default(PipelineBindPoint);
                Interop.PipelineLayout marshalledLayout = default(Interop.PipelineLayout);
                uint marshalledFirstSet = default(uint);
                uint descriptorSetCount = default(uint);
                Interop.DescriptorSet* marshalledDescriptorSets = default(Interop.DescriptorSet*);
                uint dynamicOffsetCount = default(uint);
                uint* marshalledDynamicOffsets = default(uint*);
                marshalledPipelineBindPoint = pipelineBindPoint;
                marshalledLayout = layout.handle;
                marshalledFirstSet = firstSet;
                descriptorSetCount = (uint)(descriptorSets?.Length ?? 0);
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
                dynamicOffsetCount = (uint)(dynamicOffsets?.Length ?? 0);
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
                Interop.Commands.vkCmdBindDescriptorSets(this.handle, marshalledPipelineBindPoint, marshalledLayout, marshalledFirstSet, descriptorSetCount, marshalledDescriptorSets, dynamicOffsetCount, marshalledDynamicOffsets);
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
                Interop.Buffer marshalledBuffer = default(Interop.Buffer);
                DeviceSize marshalledOffset = default(DeviceSize);
                IndexType marshalledIndexType = default(IndexType);
                marshalledBuffer = buffer.handle;
                marshalledOffset = offset;
                marshalledIndexType = indexType;
                Interop.Commands.vkCmdBindIndexBuffer(this.handle, marshalledBuffer, marshalledOffset, marshalledIndexType);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        public unsafe void BindVertexBuffers(uint firstBinding, Buffer[] buffers, DeviceSize[] offsets)
        {
            try
            {
                uint marshalledFirstBinding = default(uint);
                uint bindingCount = default(uint);
                Interop.Buffer* marshalledBuffers = default(Interop.Buffer*);
                DeviceSize* marshalledOffsets = default(DeviceSize*);
                marshalledFirstBinding = firstBinding;
                bindingCount = (uint)(buffers?.Length ?? 0);
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
                Interop.Commands.vkCmdBindVertexBuffers(this.handle, marshalledFirstBinding, bindingCount, marshalledBuffers, marshalledOffsets);
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
                uint marshalledVertexCount = default(uint);
                uint marshalledInstanceCount = default(uint);
                uint marshalledFirstVertex = default(uint);
                uint marshalledFirstInstance = default(uint);
                marshalledVertexCount = vertexCount;
                marshalledInstanceCount = instanceCount;
                marshalledFirstVertex = firstVertex;
                marshalledFirstInstance = firstInstance;
                Interop.Commands.vkCmdDraw(this.handle, marshalledVertexCount, marshalledInstanceCount, marshalledFirstVertex, marshalledFirstInstance);
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
                uint marshalledIndexCount = default(uint);
                uint marshalledInstanceCount = default(uint);
                uint marshalledFirstIndex = default(uint);
                int marshalledVertexOffset = default(int);
                uint marshalledFirstInstance = default(uint);
                marshalledIndexCount = indexCount;
                marshalledInstanceCount = instanceCount;
                marshalledFirstIndex = firstIndex;
                marshalledVertexOffset = vertexOffset;
                marshalledFirstInstance = firstInstance;
                Interop.Commands.vkCmdDrawIndexed(this.handle, marshalledIndexCount, marshalledInstanceCount, marshalledFirstIndex, marshalledVertexOffset, marshalledFirstInstance);
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
                Interop.Buffer marshalledBuffer = default(Interop.Buffer);
                DeviceSize marshalledOffset = default(DeviceSize);
                uint marshalledDrawCount = default(uint);
                uint marshalledStride = default(uint);
                marshalledBuffer = buffer.handle;
                marshalledOffset = offset;
                marshalledDrawCount = drawCount;
                marshalledStride = stride;
                Interop.Commands.vkCmdDrawIndirect(this.handle, marshalledBuffer, marshalledOffset, marshalledDrawCount, marshalledStride);
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
                Interop.Buffer marshalledBuffer = default(Interop.Buffer);
                DeviceSize marshalledOffset = default(DeviceSize);
                uint marshalledDrawCount = default(uint);
                uint marshalledStride = default(uint);
                marshalledBuffer = buffer.handle;
                marshalledOffset = offset;
                marshalledDrawCount = drawCount;
                marshalledStride = stride;
                Interop.Commands.vkCmdDrawIndexedIndirect(this.handle, marshalledBuffer, marshalledOffset, marshalledDrawCount, marshalledStride);
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
                uint marshalledGroupCountX = default(uint);
                uint marshalledGroupCountY = default(uint);
                uint marshalledGroupCountZ = default(uint);
                marshalledGroupCountX = groupCountX;
                marshalledGroupCountY = groupCountY;
                marshalledGroupCountZ = groupCountZ;
                Interop.Commands.vkCmdDispatch(this.handle, marshalledGroupCountX, marshalledGroupCountY, marshalledGroupCountZ);
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
                Interop.Buffer marshalledBuffer = default(Interop.Buffer);
                DeviceSize marshalledOffset = default(DeviceSize);
                marshalledBuffer = buffer.handle;
                marshalledOffset = offset;
                Interop.Commands.vkCmdDispatchIndirect(this.handle, marshalledBuffer, marshalledOffset);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        public unsafe void CopyBuffer(Buffer sourceBuffer, Buffer destinationBuffer, BufferCopy[] regions)
        {
            try
            {
                Interop.Buffer marshalledSourceBuffer = default(Interop.Buffer);
                Interop.Buffer marshalledDestinationBuffer = default(Interop.Buffer);
                uint regionCount = default(uint);
                BufferCopy* marshalledRegions = default(BufferCopy*);
                marshalledSourceBuffer = sourceBuffer.handle;
                marshalledDestinationBuffer = destinationBuffer.handle;
                regionCount = (uint)(regions?.Length ?? 0);
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
                Interop.Commands.vkCmdCopyBuffer(this.handle, marshalledSourceBuffer, marshalledDestinationBuffer, regionCount, marshalledRegions);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        public unsafe void CopyImage(Image sourceImage, ImageLayout sourceImageLayout, Image destinationImage, ImageLayout destinationImageLayout, ImageCopy[] regions)
        {
            try
            {
                Interop.Image marshalledSourceImage = default(Interop.Image);
                ImageLayout marshalledSourceImageLayout = default(ImageLayout);
                Interop.Image marshalledDestinationImage = default(Interop.Image);
                ImageLayout marshalledDestinationImageLayout = default(ImageLayout);
                uint regionCount = default(uint);
                ImageCopy* marshalledRegions = default(ImageCopy*);
                marshalledSourceImage = sourceImage.handle;
                marshalledSourceImageLayout = sourceImageLayout;
                marshalledDestinationImage = destinationImage.handle;
                marshalledDestinationImageLayout = destinationImageLayout;
                regionCount = (uint)(regions?.Length ?? 0);
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
                Interop.Commands.vkCmdCopyImage(this.handle, marshalledSourceImage, marshalledSourceImageLayout, marshalledDestinationImage, marshalledDestinationImageLayout, regionCount, marshalledRegions);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        public unsafe void BlitImage(Image sourceImage, ImageLayout sourceImageLayout, Image destinationImage, ImageLayout destinationImageLayout, ImageBlit[] regions, Filter filter)
        {
            try
            {
                Interop.Image marshalledSourceImage = default(Interop.Image);
                ImageLayout marshalledSourceImageLayout = default(ImageLayout);
                Interop.Image marshalledDestinationImage = default(Interop.Image);
                ImageLayout marshalledDestinationImageLayout = default(ImageLayout);
                uint regionCount = default(uint);
                Interop.ImageBlit* marshalledRegions = default(Interop.ImageBlit*);
                Filter marshalledFilter = default(Filter);
                marshalledSourceImage = sourceImage.handle;
                marshalledSourceImageLayout = sourceImageLayout;
                marshalledDestinationImage = destinationImage.handle;
                marshalledDestinationImageLayout = destinationImageLayout;
                regionCount = (uint)(regions?.Length ?? 0);
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
                marshalledFilter = filter;
                Interop.Commands.vkCmdBlitImage(this.handle, marshalledSourceImage, marshalledSourceImageLayout, marshalledDestinationImage, marshalledDestinationImageLayout, regionCount, marshalledRegions, marshalledFilter);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        public unsafe void CopyBufferToImage(Buffer sourceBuffer, Image destinationImage, ImageLayout destinationImageLayout, BufferImageCopy[] regions)
        {
            try
            {
                Interop.Buffer marshalledSourceBuffer = default(Interop.Buffer);
                Interop.Image marshalledDestinationImage = default(Interop.Image);
                ImageLayout marshalledDestinationImageLayout = default(ImageLayout);
                uint regionCount = default(uint);
                BufferImageCopy* marshalledRegions = default(BufferImageCopy*);
                marshalledSourceBuffer = sourceBuffer.handle;
                marshalledDestinationImage = destinationImage.handle;
                marshalledDestinationImageLayout = destinationImageLayout;
                regionCount = (uint)(regions?.Length ?? 0);
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
                Interop.Commands.vkCmdCopyBufferToImage(this.handle, marshalledSourceBuffer, marshalledDestinationImage, marshalledDestinationImageLayout, regionCount, marshalledRegions);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        public unsafe void CopyImageToBuffer(Image sourceImage, ImageLayout sourceImageLayout, Buffer destinationBuffer, BufferImageCopy[] regions)
        {
            try
            {
                Interop.Image marshalledSourceImage = default(Interop.Image);
                ImageLayout marshalledSourceImageLayout = default(ImageLayout);
                Interop.Buffer marshalledDestinationBuffer = default(Interop.Buffer);
                uint regionCount = default(uint);
                BufferImageCopy* marshalledRegions = default(BufferImageCopy*);
                marshalledSourceImage = sourceImage.handle;
                marshalledSourceImageLayout = sourceImageLayout;
                marshalledDestinationBuffer = destinationBuffer.handle;
                regionCount = (uint)(regions?.Length ?? 0);
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
                Interop.Commands.vkCmdCopyImageToBuffer(this.handle, marshalledSourceImage, marshalledSourceImageLayout, marshalledDestinationBuffer, regionCount, marshalledRegions);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        public unsafe void UpdateBuffer(Buffer destinationBuffer, DeviceSize destinationOffset, byte[] data)
        {
            try
            {
                Interop.Buffer marshalledDestinationBuffer = default(Interop.Buffer);
                DeviceSize marshalledDestinationOffset = default(DeviceSize);
                DeviceSize dataSize = default(DeviceSize);
                byte* marshalledData = default(byte*);
                marshalledDestinationBuffer = destinationBuffer.handle;
                marshalledDestinationOffset = destinationOffset;
                dataSize = (DeviceSize)(data?.Length ?? 0);
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
                Interop.Commands.vkCmdUpdateBuffer(this.handle, marshalledDestinationBuffer, marshalledDestinationOffset, dataSize, marshalledData);
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
                Interop.Buffer marshalledDestinationBuffer = default(Interop.Buffer);
                DeviceSize marshalledDestinationOffset = default(DeviceSize);
                DeviceSize marshalledSize = default(DeviceSize);
                uint marshalledData = default(uint);
                marshalledDestinationBuffer = destinationBuffer.handle;
                marshalledDestinationOffset = destinationOffset;
                marshalledSize = size;
                marshalledData = data;
                Interop.Commands.vkCmdFillBuffer(this.handle, marshalledDestinationBuffer, marshalledDestinationOffset, marshalledSize, marshalledData);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        public unsafe void ClearColorImage(Image image, ImageLayout imageLayout, ClearColorValue color, ImageSubresourceRange[] ranges)
        {
            try
            {
                Interop.Image marshalledImage = default(Interop.Image);
                ImageLayout marshalledImageLayout = default(ImageLayout);
                ClearColorValue* marshalledColor = default(ClearColorValue*);
                uint rangeCount = default(uint);
                ImageSubresourceRange* marshalledRanges = default(ImageSubresourceRange*);
                marshalledImage = image.handle;
                marshalledImageLayout = imageLayout;
                marshalledColor = (ClearColorValue*)(Interop.HeapUtil.Allocate<ClearColorValue>());
                *marshalledColor = color;
                rangeCount = (uint)(ranges?.Length ?? 0);
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
                Interop.Commands.vkCmdClearColorImage(this.handle, marshalledImage, marshalledImageLayout, marshalledColor, rangeCount, marshalledRanges);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        public unsafe void ClearDepthStencilImage(Image image, ImageLayout imageLayout, ClearDepthStencilValue depthStencil, ImageSubresourceRange[] ranges)
        {
            try
            {
                Interop.Image marshalledImage = default(Interop.Image);
                ImageLayout marshalledImageLayout = default(ImageLayout);
                ClearDepthStencilValue* marshalledDepthStencil = default(ClearDepthStencilValue*);
                uint rangeCount = default(uint);
                ImageSubresourceRange* marshalledRanges = default(ImageSubresourceRange*);
                marshalledImage = image.handle;
                marshalledImageLayout = imageLayout;
                marshalledDepthStencil = (ClearDepthStencilValue*)(Interop.HeapUtil.Allocate<ClearDepthStencilValue>());
                *marshalledDepthStencil = depthStencil;
                rangeCount = (uint)(ranges?.Length ?? 0);
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
                Interop.Commands.vkCmdClearDepthStencilImage(this.handle, marshalledImage, marshalledImageLayout, marshalledDepthStencil, rangeCount, marshalledRanges);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        public unsafe void ClearAttachments(ClearAttachment[] attachments, ClearRect[] rects)
        {
            try
            {
                uint attachmentCount = default(uint);
                ClearAttachment* marshalledAttachments = default(ClearAttachment*);
                uint rectCount = default(uint);
                ClearRect* marshalledRects = default(ClearRect*);
                attachmentCount = (uint)(attachments?.Length ?? 0);
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
                rectCount = (uint)(rects?.Length ?? 0);
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
        public unsafe void ResolveImage(Image sourceImage, ImageLayout sourceImageLayout, Image destinationImage, ImageLayout destinationImageLayout, ImageResolve[] regions)
        {
            try
            {
                Interop.Image marshalledSourceImage = default(Interop.Image);
                ImageLayout marshalledSourceImageLayout = default(ImageLayout);
                Interop.Image marshalledDestinationImage = default(Interop.Image);
                ImageLayout marshalledDestinationImageLayout = default(ImageLayout);
                uint regionCount = default(uint);
                ImageResolve* marshalledRegions = default(ImageResolve*);
                marshalledSourceImage = sourceImage.handle;
                marshalledSourceImageLayout = sourceImageLayout;
                marshalledDestinationImage = destinationImage.handle;
                marshalledDestinationImageLayout = destinationImageLayout;
                regionCount = (uint)(regions?.Length ?? 0);
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
                Interop.Commands.vkCmdResolveImage(this.handle, marshalledSourceImage, marshalledSourceImageLayout, marshalledDestinationImage, marshalledDestinationImageLayout, regionCount, marshalledRegions);
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
                Interop.Event marshalledEvent = default(Interop.Event);
                PipelineStageFlags marshalledStageMask = default(PipelineStageFlags);
                marshalledEvent = @event.handle;
                marshalledStageMask = stageMask;
                Interop.Commands.vkCmdSetEvent(this.handle, marshalledEvent, marshalledStageMask);
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
                Interop.Event marshalledEvent = default(Interop.Event);
                PipelineStageFlags marshalledStageMask = default(PipelineStageFlags);
                marshalledEvent = @event.handle;
                marshalledStageMask = stageMask;
                Interop.Commands.vkCmdResetEvent(this.handle, marshalledEvent, marshalledStageMask);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        public unsafe void WaitEvents(Event[] events, PipelineStageFlags sourceStageMask, PipelineStageFlags destinationStageMask, MemoryBarrier[] memoryBarriers, BufferMemoryBarrier[] bufferMemoryBarriers, ImageMemoryBarrier[] imageMemoryBarriers)
        {
            try
            {
                uint eventCount = default(uint);
                Interop.Event* marshalledEvents = default(Interop.Event*);
                PipelineStageFlags marshalledSourceStageMask = default(PipelineStageFlags);
                PipelineStageFlags marshalledDestinationStageMask = default(PipelineStageFlags);
                uint memoryBarrierCount = default(uint);
                Interop.MemoryBarrier* marshalledMemoryBarriers = default(Interop.MemoryBarrier*);
                uint bufferMemoryBarrierCount = default(uint);
                Interop.BufferMemoryBarrier* marshalledBufferMemoryBarriers = default(Interop.BufferMemoryBarrier*);
                uint imageMemoryBarrierCount = default(uint);
                Interop.ImageMemoryBarrier* marshalledImageMemoryBarriers = default(Interop.ImageMemoryBarrier*);
                eventCount = (uint)(events?.Length ?? 0);
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
                marshalledSourceStageMask = sourceStageMask;
                marshalledDestinationStageMask = destinationStageMask;
                memoryBarrierCount = (uint)(memoryBarriers?.Length ?? 0);
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
                bufferMemoryBarrierCount = (uint)(bufferMemoryBarriers?.Length ?? 0);
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
                imageMemoryBarrierCount = (uint)(imageMemoryBarriers?.Length ?? 0);
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
                Interop.Commands.vkCmdWaitEvents(this.handle, eventCount, marshalledEvents, marshalledSourceStageMask, marshalledDestinationStageMask, memoryBarrierCount, marshalledMemoryBarriers, bufferMemoryBarrierCount, marshalledBufferMemoryBarriers, imageMemoryBarrierCount, marshalledImageMemoryBarriers);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        public unsafe void PipelineBarrier(PipelineStageFlags sourceStageMask, PipelineStageFlags destinationStageMask, DependencyFlags dependencyFlags, MemoryBarrier[] memoryBarriers, BufferMemoryBarrier[] bufferMemoryBarriers, ImageMemoryBarrier[] imageMemoryBarriers)
        {
            try
            {
                PipelineStageFlags marshalledSourceStageMask = default(PipelineStageFlags);
                PipelineStageFlags marshalledDestinationStageMask = default(PipelineStageFlags);
                DependencyFlags marshalledDependencyFlags = default(DependencyFlags);
                uint memoryBarrierCount = default(uint);
                Interop.MemoryBarrier* marshalledMemoryBarriers = default(Interop.MemoryBarrier*);
                uint bufferMemoryBarrierCount = default(uint);
                Interop.BufferMemoryBarrier* marshalledBufferMemoryBarriers = default(Interop.BufferMemoryBarrier*);
                uint imageMemoryBarrierCount = default(uint);
                Interop.ImageMemoryBarrier* marshalledImageMemoryBarriers = default(Interop.ImageMemoryBarrier*);
                marshalledSourceStageMask = sourceStageMask;
                marshalledDestinationStageMask = destinationStageMask;
                marshalledDependencyFlags = dependencyFlags;
                memoryBarrierCount = (uint)(memoryBarriers?.Length ?? 0);
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
                bufferMemoryBarrierCount = (uint)(bufferMemoryBarriers?.Length ?? 0);
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
                imageMemoryBarrierCount = (uint)(imageMemoryBarriers?.Length ?? 0);
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
                Interop.Commands.vkCmdPipelineBarrier(this.handle, marshalledSourceStageMask, marshalledDestinationStageMask, marshalledDependencyFlags, memoryBarrierCount, marshalledMemoryBarriers, bufferMemoryBarrierCount, marshalledBufferMemoryBarriers, imageMemoryBarrierCount, marshalledImageMemoryBarriers);
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
                Interop.QueryPool marshalledQueryPool = default(Interop.QueryPool);
                uint marshalledQuery = default(uint);
                QueryControlFlags marshalledFlags = default(QueryControlFlags);
                marshalledQueryPool = queryPool.handle;
                marshalledQuery = query;
                marshalledFlags = flags;
                Interop.Commands.vkCmdBeginQuery(this.handle, marshalledQueryPool, marshalledQuery, marshalledFlags);
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
                Interop.QueryPool marshalledQueryPool = default(Interop.QueryPool);
                uint marshalledQuery = default(uint);
                marshalledQueryPool = queryPool.handle;
                marshalledQuery = query;
                Interop.Commands.vkCmdEndQuery(this.handle, marshalledQueryPool, marshalledQuery);
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
                Interop.QueryPool marshalledQueryPool = default(Interop.QueryPool);
                uint marshalledFirstQuery = default(uint);
                uint marshalledQueryCount = default(uint);
                marshalledQueryPool = queryPool.handle;
                marshalledFirstQuery = firstQuery;
                marshalledQueryCount = queryCount;
                Interop.Commands.vkCmdResetQueryPool(this.handle, marshalledQueryPool, marshalledFirstQuery, marshalledQueryCount);
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
                PipelineStageFlags marshalledPipelineStage = default(PipelineStageFlags);
                Interop.QueryPool marshalledQueryPool = default(Interop.QueryPool);
                uint marshalledQuery = default(uint);
                marshalledPipelineStage = pipelineStage;
                marshalledQueryPool = queryPool.handle;
                marshalledQuery = query;
                Interop.Commands.vkCmdWriteTimestamp(this.handle, marshalledPipelineStage, marshalledQueryPool, marshalledQuery);
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
                Interop.QueryPool marshalledQueryPool = default(Interop.QueryPool);
                uint marshalledFirstQuery = default(uint);
                uint marshalledQueryCount = default(uint);
                Interop.Buffer marshalledDestinationBuffer = default(Interop.Buffer);
                DeviceSize marshalledDestinationOffset = default(DeviceSize);
                DeviceSize marshalledStride = default(DeviceSize);
                QueryResultFlags marshalledFlags = default(QueryResultFlags);
                marshalledQueryPool = queryPool.handle;
                marshalledFirstQuery = firstQuery;
                marshalledQueryCount = queryCount;
                marshalledDestinationBuffer = destinationBuffer.handle;
                marshalledDestinationOffset = destinationOffset;
                marshalledStride = stride;
                marshalledFlags = flags;
                Interop.Commands.vkCmdCopyQueryPoolResults(this.handle, marshalledQueryPool, marshalledFirstQuery, marshalledQueryCount, marshalledDestinationBuffer, marshalledDestinationOffset, marshalledStride, marshalledFlags);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        public unsafe void PushConstants(PipelineLayout layout, ShaderStageFlags stageFlags, uint offset, byte[] values)
        {
            try
            {
                Interop.PipelineLayout marshalledLayout = default(Interop.PipelineLayout);
                ShaderStageFlags marshalledStageFlags = default(ShaderStageFlags);
                uint marshalledOffset = default(uint);
                uint size = default(uint);
                byte* marshalledValues = default(byte*);
                marshalledLayout = layout.handle;
                marshalledStageFlags = stageFlags;
                marshalledOffset = offset;
                size = (uint)(values?.Length ?? 0);
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
                Interop.Commands.vkCmdPushConstants(this.handle, marshalledLayout, marshalledStageFlags, marshalledOffset, size, marshalledValues);
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
                SubpassContents marshalledContents = default(SubpassContents);
                marshalledRenderPassBegin = (Interop.RenderPassBeginInfo*)(Interop.HeapUtil.Allocate<Interop.RenderPassBeginInfo>());
                renderPassBegin.MarshalTo(marshalledRenderPassBegin);
                marshalledContents = contents;
                Interop.Commands.vkCmdBeginRenderPass(this.handle, marshalledRenderPassBegin, marshalledContents);
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
                SubpassContents marshalledContents = default(SubpassContents);
                marshalledContents = contents;
                Interop.Commands.vkCmdNextSubpass(this.handle, marshalledContents);
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
        public unsafe void ExecuteCommands(CommandBuffer[] commandBuffers)
        {
            try
            {
                uint commandBufferCount = default(uint);
                Interop.CommandBuffer* marshalledCommandBuffers = default(Interop.CommandBuffer*);
                commandBufferCount = (uint)(commandBuffers?.Length ?? 0);
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
