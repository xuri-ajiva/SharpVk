// The MIT License (MIT)
// 
// Copyright (c) Andrew Armstrong/FacticiusVir 2016
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
using System.Runtime.InteropServices;

namespace SharpVk
{
    /// <summary>
    /// <para>
    /// Opaque handle to a command buffer object.
    /// </para>
    /// <para>
    /// Command buffers are objects used to record commands which can: be
    /// subsequently submitted to a device queue for execution. There are two
    /// levels of command buffers - _primary command buffers_, which can:
    /// execute secondary command buffers, and which are submitted to queues,
    /// and _secondary command buffers_, which can: be executed by primary
    /// command buffers, and which are not directly submitted to queues.
    /// </para>
    /// </summary>
    public partial class CommandBuffer
    {
        internal readonly Interop.CommandBuffer handle; 
        
        internal readonly CommandCache commandCache; 
        
        private readonly CommandPool parent; 
        
        internal AllocationCallbacks? Allocator
        {
            get
            {
                return this.parent.Allocator;
            }
        }
        
        internal CommandBuffer(Interop.CommandBuffer handle, CommandPool parent, CommandCache commandCache)
        {
            this.handle = handle;
            this.parent = parent;
            this.commandCache = commandCache;
        }
        
        /// <summary>
        /// Start recording a command buffer.
        /// </summary>
        public void Begin(CommandBufferBeginInfo beginInfo)
        {
            unsafe
            {
                try
                {
                    Result commandResult;
                    Interop.CommandBufferBeginInfo marshalledBeginInfo;
                    marshalledBeginInfo = beginInfo.Pack();
                    commandResult = Interop.Commands.vkBeginCommandBuffer(this.handle, &marshalledBeginInfo);
                    if (SharpVkException.IsError(commandResult))
                    {
                        throw SharpVkException.Create(commandResult);
                    }
                }
                finally
                {
                    Interop.HeapUtil.FreeLog();
                }
            }
        }
        
        /// <summary>
        /// Finish recording a command buffer.
        /// </summary>
        public void End()
        {
            unsafe
            {
                try
                {
                    Result commandResult;
                    commandResult = Interop.Commands.vkEndCommandBuffer(this.handle);
                    if (SharpVkException.IsError(commandResult))
                    {
                        throw SharpVkException.Create(commandResult);
                    }
                }
                finally
                {
                    Interop.HeapUtil.FreeLog();
                }
            }
        }
        
        /// <summary>
        /// Reset a command buffer.
        /// </summary>
        public void Reset(CommandBufferResetFlags flags)
        {
            unsafe
            {
                try
                {
                    Result commandResult;
                    commandResult = Interop.Commands.vkResetCommandBuffer(this.handle, flags);
                    if (SharpVkException.IsError(commandResult))
                    {
                        throw SharpVkException.Create(commandResult);
                    }
                }
                finally
                {
                    Interop.HeapUtil.FreeLog();
                }
            }
        }
        
        /// <summary>
        /// Bind a pipeline object to a command buffer.
        /// </summary>
        public void BindPipeline(PipelineBindPoint pipelineBindPoint, Pipeline pipeline)
        {
            unsafe
            {
                try
                {
                    Interop.Pipeline marshalledPipeline = pipeline.Pack();
                    Interop.Commands.vkCmdBindPipeline(this.handle, pipelineBindPoint, marshalledPipeline);
                }
                finally
                {
                    Interop.HeapUtil.FreeLog();
                }
            }
        }
        
        /// <summary>
        /// Set the viewport on a command buffer.
        /// </summary>
        public void SetViewport(uint firstViewport, ArrayProxy<Viewport> viewports)
        {
            unsafe
            {
                try
                {
                    GCHandle viewportsHandle = default(GCHandle);
                    Viewport* marshalledViewports = null;
                    if (viewports.Contents != ProxyContents.Null)
                    {
                        if(viewports.Contents == ProxyContents.Single)
                        {
                            Viewport* dataPointer = stackalloc Viewport[1];
                            *dataPointer = viewports.GetSingleValue();
                            marshalledViewports = dataPointer;
                        }
                        else
                        {
                            var arrayValue = viewports.GetArrayValue(); 
                            viewportsHandle = GCHandle.Alloc(arrayValue.Array); 
                            marshalledViewports = (Viewport*)(viewportsHandle.AddrOfPinnedObject() + (int)(MemUtil.SizeOf<Viewport>() * arrayValue.Offset)).ToPointer(); 
                        }
                    }
                    else
                    {
                        marshalledViewports = null;
                    }
                    Interop.Commands.vkCmdSetViewport(this.handle, firstViewport, (uint)(viewports.Length), marshalledViewports);
                    if (viewportsHandle.IsAllocated) viewportsHandle.Free();
                }
                finally
                {
                    Interop.HeapUtil.FreeLog();
                }
            }
        }
        
        /// <summary>
        /// Set the dynamic scissor rectangles on a command buffer.
        /// </summary>
        public void SetScissor(uint firstScissor, ArrayProxy<Rect2D> scissors)
        {
            unsafe
            {
                try
                {
                    GCHandle scissorsHandle = default(GCHandle);
                    Rect2D* marshalledScissors = null;
                    if (scissors.Contents != ProxyContents.Null)
                    {
                        if(scissors.Contents == ProxyContents.Single)
                        {
                            Rect2D* dataPointer = stackalloc Rect2D[1];
                            *dataPointer = scissors.GetSingleValue();
                            marshalledScissors = dataPointer;
                        }
                        else
                        {
                            var arrayValue = scissors.GetArrayValue(); 
                            scissorsHandle = GCHandle.Alloc(arrayValue.Array); 
                            marshalledScissors = (Rect2D*)(scissorsHandle.AddrOfPinnedObject() + (int)(MemUtil.SizeOf<Rect2D>() * arrayValue.Offset)).ToPointer(); 
                        }
                    }
                    else
                    {
                        marshalledScissors = null;
                    }
                    Interop.Commands.vkCmdSetScissor(this.handle, firstScissor, (uint)(scissors.Length), marshalledScissors);
                    if (scissorsHandle.IsAllocated) scissorsHandle.Free();
                }
                finally
                {
                    Interop.HeapUtil.FreeLog();
                }
            }
        }
        
        /// <summary>
        /// Set the dynamic line width state.
        /// </summary>
        public void SetLineWidth(float lineWidth)
        {
            unsafe
            {
                try
                {
                    Interop.Commands.vkCmdSetLineWidth(this.handle, lineWidth);
                }
                finally
                {
                    Interop.HeapUtil.FreeLog();
                }
            }
        }
        
        /// <summary>
        /// Set the depth bias dynamic state.
        /// </summary>
        public void SetDepthBias(float depthBiasConstantFactor, float depthBiasClamp, float depthBiasSlopeFactor)
        {
            unsafe
            {
                try
                {
                    Interop.Commands.vkCmdSetDepthBias(this.handle, depthBiasConstantFactor, depthBiasClamp, depthBiasSlopeFactor);
                }
                finally
                {
                    Interop.HeapUtil.FreeLog();
                }
            }
        }
        
        /// <summary>
        /// Set the values of blend constants.
        /// </summary>
        public void SetBlendConstants(float blendConstants)
        {
            unsafe
            {
                try
                {
                    Interop.Commands.vkCmdSetBlendConstants(this.handle, blendConstants);
                }
                finally
                {
                    Interop.HeapUtil.FreeLog();
                }
            }
        }
        
        /// <summary>
        /// Set the depth bounds test values for a command buffer.
        /// </summary>
        public void SetDepthBounds(float minDepthBounds, float maxDepthBounds)
        {
            unsafe
            {
                try
                {
                    Interop.Commands.vkCmdSetDepthBounds(this.handle, minDepthBounds, maxDepthBounds);
                }
                finally
                {
                    Interop.HeapUtil.FreeLog();
                }
            }
        }
        
        /// <summary>
        /// Set the stencil compare mask dynamic state.
        /// </summary>
        public void SetStencilCompareMask(StencilFaceFlags faceMask, uint compareMask)
        {
            unsafe
            {
                try
                {
                    Interop.Commands.vkCmdSetStencilCompareMask(this.handle, faceMask, compareMask);
                }
                finally
                {
                    Interop.HeapUtil.FreeLog();
                }
            }
        }
        
        /// <summary>
        /// Set the stencil write mask dynamic state.
        /// </summary>
        public void SetStencilWriteMask(StencilFaceFlags faceMask, uint writeMask)
        {
            unsafe
            {
                try
                {
                    Interop.Commands.vkCmdSetStencilWriteMask(this.handle, faceMask, writeMask);
                }
                finally
                {
                    Interop.HeapUtil.FreeLog();
                }
            }
        }
        
        /// <summary>
        /// Set the stencil reference dynamic state.
        /// </summary>
        public void SetStencilReference(StencilFaceFlags faceMask, uint reference)
        {
            unsafe
            {
                try
                {
                    Interop.Commands.vkCmdSetStencilReference(this.handle, faceMask, reference);
                }
                finally
                {
                    Interop.HeapUtil.FreeLog();
                }
            }
        }
        
        /// <summary>
        /// Binds descriptor sets to a command buffer.
        /// </summary>
        public void BindDescriptorSets(PipelineBindPoint pipelineBindPoint, PipelineLayout layout, uint firstSet, ArrayProxy<DescriptorSet> descriptorSets, ArrayProxy<uint> dynamicOffsets)
        {
            unsafe
            {
                try
                {
                    Interop.PipelineLayout marshalledLayout = layout.Pack();
                    Interop.DescriptorSet* marshalledDescriptorSets = null;
                    if (descriptorSets.Contents != ProxyContents.Null)
                    {
                        Interop.DescriptorSet* arrayPointer = stackalloc Interop.DescriptorSet[descriptorSets.Length];
                        if(descriptorSets.Contents == ProxyContents.Single)
                        {
                            *arrayPointer = descriptorSets.GetSingleValue().Pack();
                        }
                        else
                        {
                            var arrayValue  = descriptorSets.GetArrayValue();
                            for (int index = 0; index < descriptorSets.Length; index++)
                            {
                                arrayPointer[index] = arrayValue.Array[arrayValue.Offset + index].Pack();
                            }
                        }
                        marshalledDescriptorSets = arrayPointer;
                    }
                    else
                    {
                        marshalledDescriptorSets = null;
                    }
                    GCHandle dynamicOffsetsHandle = default(GCHandle);
                    uint* marshalledDynamicOffsets = null;
                    if (dynamicOffsets.Contents != ProxyContents.Null)
                    {
                        if(dynamicOffsets.Contents == ProxyContents.Single)
                        {
                            uint* dataPointer = stackalloc uint[1];
                            *dataPointer = dynamicOffsets.GetSingleValue();
                            marshalledDynamicOffsets = dataPointer;
                        }
                        else
                        {
                            var arrayValue = dynamicOffsets.GetArrayValue(); 
                            dynamicOffsetsHandle = GCHandle.Alloc(arrayValue.Array); 
                            marshalledDynamicOffsets = (uint*)(dynamicOffsetsHandle.AddrOfPinnedObject() + (int)(MemUtil.SizeOf<uint>() * arrayValue.Offset)).ToPointer(); 
                        }
                    }
                    else
                    {
                        marshalledDynamicOffsets = null;
                    }
                    Interop.Commands.vkCmdBindDescriptorSets(this.handle, pipelineBindPoint, marshalledLayout, firstSet, (uint)(descriptorSets.Length), marshalledDescriptorSets, (uint)(dynamicOffsets.Length), marshalledDynamicOffsets);
                    if (dynamicOffsetsHandle.IsAllocated) dynamicOffsetsHandle.Free();
                }
                finally
                {
                    Interop.HeapUtil.FreeLog();
                }
            }
        }
        
        /// <summary>
        /// Bind an index buffer to a command buffer.
        /// </summary>
        public void BindIndexBuffer(Buffer buffer, DeviceSize offset, IndexType indexType)
        {
            unsafe
            {
                try
                {
                    Interop.Buffer marshalledBuffer = buffer.Pack();
                    Interop.Commands.vkCmdBindIndexBuffer(this.handle, marshalledBuffer, offset, indexType);
                }
                finally
                {
                    Interop.HeapUtil.FreeLog();
                }
            }
        }
        
        /// <summary>
        /// Bind vertex buffers to a command buffer.
        /// </summary>
        public void BindVertexBuffers(uint firstBinding, ArrayProxy<Buffer> buffers, ArrayProxy<DeviceSize> offsets)
        {
            unsafe
            {
                try
                {
                    Interop.Buffer* marshalledBuffers = null;
                    if (buffers.Contents != ProxyContents.Null)
                    {
                        Interop.Buffer* arrayPointer = stackalloc Interop.Buffer[buffers.Length];
                        if(buffers.Contents == ProxyContents.Single)
                        {
                            *arrayPointer = buffers.GetSingleValue().Pack();
                        }
                        else
                        {
                            var arrayValue  = buffers.GetArrayValue();
                            for (int index = 0; index < buffers.Length; index++)
                            {
                                arrayPointer[index] = arrayValue.Array[arrayValue.Offset + index].Pack();
                            }
                        }
                        marshalledBuffers = arrayPointer;
                    }
                    else
                    {
                        marshalledBuffers = null;
                    }
                    GCHandle offsetsHandle = default(GCHandle);
                    DeviceSize* marshalledOffsets = null;
                    if (offsets.Contents != ProxyContents.Null)
                    {
                        if(offsets.Contents == ProxyContents.Single)
                        {
                            DeviceSize* dataPointer = stackalloc DeviceSize[1];
                            *dataPointer = offsets.GetSingleValue();
                            marshalledOffsets = dataPointer;
                        }
                        else
                        {
                            var arrayValue = offsets.GetArrayValue(); 
                            offsetsHandle = GCHandle.Alloc(arrayValue.Array); 
                            marshalledOffsets = (DeviceSize*)(offsetsHandle.AddrOfPinnedObject() + (int)(MemUtil.SizeOf<DeviceSize>() * arrayValue.Offset)).ToPointer(); 
                        }
                    }
                    else
                    {
                        marshalledOffsets = null;
                    }
                    Interop.Commands.vkCmdBindVertexBuffers(this.handle, firstBinding, (uint)(offsets.Length), marshalledBuffers, marshalledOffsets);
                    if (offsetsHandle.IsAllocated) offsetsHandle.Free();
                }
                finally
                {
                    Interop.HeapUtil.FreeLog();
                }
            }
        }
        
        /// <summary>
        /// Draw primitives.
        /// </summary>
        public void Draw(uint vertexCount, uint instanceCount, uint firstVertex, uint firstInstance)
        {
            unsafe
            {
                try
                {
                    Interop.Commands.vkCmdDraw(this.handle, vertexCount, instanceCount, firstVertex, firstInstance);
                }
                finally
                {
                    Interop.HeapUtil.FreeLog();
                }
            }
        }
        
        /// <summary>
        /// Issue an indexed draw into a command buffer.
        /// </summary>
        public void DrawIndexed(uint indexCount, uint instanceCount, uint firstIndex, int vertexOffset, uint firstInstance)
        {
            unsafe
            {
                try
                {
                    Interop.Commands.vkCmdDrawIndexed(this.handle, indexCount, instanceCount, firstIndex, vertexOffset, firstInstance);
                }
                finally
                {
                    Interop.HeapUtil.FreeLog();
                }
            }
        }
        
        /// <summary>
        /// Issue an indirect draw into a command buffer.
        /// </summary>
        public void DrawIndirect(Buffer buffer, DeviceSize offset, uint drawCount, uint stride)
        {
            unsafe
            {
                try
                {
                    Interop.Buffer marshalledBuffer = buffer.Pack();
                    Interop.Commands.vkCmdDrawIndirect(this.handle, marshalledBuffer, offset, drawCount, stride);
                }
                finally
                {
                    Interop.HeapUtil.FreeLog();
                }
            }
        }
        
        /// <summary>
        /// Perform an indexed indirect draw.
        /// </summary>
        public void DrawIndexedIndirect(Buffer buffer, DeviceSize offset, uint drawCount, uint stride)
        {
            unsafe
            {
                try
                {
                    Interop.Buffer marshalledBuffer = buffer.Pack();
                    Interop.Commands.vkCmdDrawIndexedIndirect(this.handle, marshalledBuffer, offset, drawCount, stride);
                }
                finally
                {
                    Interop.HeapUtil.FreeLog();
                }
            }
        }
        
        /// <summary>
        /// Dispatch compute work items.
        /// </summary>
        public void Dispatch(uint x, uint y, uint z)
        {
            unsafe
            {
                try
                {
                    Interop.Commands.vkCmdDispatch(this.handle, x, y, z);
                }
                finally
                {
                    Interop.HeapUtil.FreeLog();
                }
            }
        }
        
        /// <summary>
        /// Dispatch compute work items using indirect parameters.
        /// </summary>
        public void DispatchIndirect(Buffer buffer, DeviceSize offset)
        {
            unsafe
            {
                try
                {
                    Interop.Buffer marshalledBuffer = buffer.Pack();
                    Interop.Commands.vkCmdDispatchIndirect(this.handle, marshalledBuffer, offset);
                }
                finally
                {
                    Interop.HeapUtil.FreeLog();
                }
            }
        }
        
        /// <summary>
        /// Copy data between buffer regions.
        /// </summary>
        public void CopyBuffer(Buffer sourceBuffer, Buffer destinationBuffer, ArrayProxy<BufferCopy> regions)
        {
            unsafe
            {
                try
                {
                    Interop.Buffer marshalledSourceBuffer = sourceBuffer.Pack();
                    Interop.Buffer marshalledDestinationBuffer = destinationBuffer.Pack();
                    GCHandle regionsHandle = default(GCHandle);
                    BufferCopy* marshalledRegions = null;
                    if (regions.Contents != ProxyContents.Null)
                    {
                        if(regions.Contents == ProxyContents.Single)
                        {
                            BufferCopy* dataPointer = stackalloc BufferCopy[1];
                            *dataPointer = regions.GetSingleValue();
                            marshalledRegions = dataPointer;
                        }
                        else
                        {
                            var arrayValue = regions.GetArrayValue(); 
                            regionsHandle = GCHandle.Alloc(arrayValue.Array); 
                            marshalledRegions = (BufferCopy*)(regionsHandle.AddrOfPinnedObject() + (int)(MemUtil.SizeOf<BufferCopy>() * arrayValue.Offset)).ToPointer(); 
                        }
                    }
                    else
                    {
                        marshalledRegions = null;
                    }
                    Interop.Commands.vkCmdCopyBuffer(this.handle, marshalledSourceBuffer, marshalledDestinationBuffer, (uint)(regions.Length), marshalledRegions);
                    if (regionsHandle.IsAllocated) regionsHandle.Free();
                }
                finally
                {
                    Interop.HeapUtil.FreeLog();
                }
            }
        }
        
        /// <summary>
        /// Copy data between images.
        /// </summary>
        public void CopyImage(Image sourceImage, ImageLayout sourceImageLayout, Image destinationImage, ImageLayout destinationImageLayout, ArrayProxy<ImageCopy> regions)
        {
            unsafe
            {
                try
                {
                    Interop.Image marshalledSourceImage = sourceImage.Pack();
                    Interop.Image marshalledDestinationImage = destinationImage.Pack();
                    GCHandle regionsHandle = default(GCHandle);
                    ImageCopy* marshalledRegions = null;
                    if (regions.Contents != ProxyContents.Null)
                    {
                        if(regions.Contents == ProxyContents.Single)
                        {
                            ImageCopy* dataPointer = stackalloc ImageCopy[1];
                            *dataPointer = regions.GetSingleValue();
                            marshalledRegions = dataPointer;
                        }
                        else
                        {
                            var arrayValue = regions.GetArrayValue(); 
                            regionsHandle = GCHandle.Alloc(arrayValue.Array); 
                            marshalledRegions = (ImageCopy*)(regionsHandle.AddrOfPinnedObject() + (int)(MemUtil.SizeOf<ImageCopy>() * arrayValue.Offset)).ToPointer(); 
                        }
                    }
                    else
                    {
                        marshalledRegions = null;
                    }
                    Interop.Commands.vkCmdCopyImage(this.handle, marshalledSourceImage, sourceImageLayout, marshalledDestinationImage, destinationImageLayout, (uint)(regions.Length), marshalledRegions);
                    if (regionsHandle.IsAllocated) regionsHandle.Free();
                }
                finally
                {
                    Interop.HeapUtil.FreeLog();
                }
            }
        }
        
        /// <summary>
        /// Copy regions of an image, potentially performing format
        /// conversion,.
        /// </summary>
        public void BlitImage(Image sourceImage, ImageLayout sourceImageLayout, Image destinationImage, ImageLayout destinationImageLayout, ArrayProxy<ImageBlit> regions, Filter filter)
        {
            unsafe
            {
                try
                {
                    Interop.Image marshalledSourceImage = sourceImage.Pack();
                    Interop.Image marshalledDestinationImage = destinationImage.Pack();
                    Interop.ImageBlit* marshalledRegions = null;
                    if (regions.Contents != ProxyContents.Null)
                    {
                        Interop.ImageBlit* arrayPointer = stackalloc Interop.ImageBlit[regions.Length];
                        if(regions.Contents == ProxyContents.Single)
                        {
                            *arrayPointer = regions.GetSingleValue().Pack();
                        }
                        else
                        {
                            var arrayValue  = regions.GetArrayValue();
                            for (int index = 0; index < regions.Length; index++)
                            {
                                arrayPointer[index] = arrayValue.Array[arrayValue.Offset + index].Pack();
                            }
                        }
                        marshalledRegions = arrayPointer;
                    }
                    else
                    {
                        marshalledRegions = null;
                    }
                    Interop.Commands.vkCmdBlitImage(this.handle, marshalledSourceImage, sourceImageLayout, marshalledDestinationImage, destinationImageLayout, (uint)(regions.Length), marshalledRegions, filter);
                }
                finally
                {
                    Interop.HeapUtil.FreeLog();
                }
            }
        }
        
        /// <summary>
        /// Copy data from a buffer into an image.
        /// </summary>
        public void CopyBufferToImage(Buffer sourceBuffer, Image destinationImage, ImageLayout destinationImageLayout, ArrayProxy<BufferImageCopy> regions)
        {
            unsafe
            {
                try
                {
                    Interop.Buffer marshalledSourceBuffer = sourceBuffer.Pack();
                    Interop.Image marshalledDestinationImage = destinationImage.Pack();
                    GCHandle regionsHandle = default(GCHandle);
                    BufferImageCopy* marshalledRegions = null;
                    if (regions.Contents != ProxyContents.Null)
                    {
                        if(regions.Contents == ProxyContents.Single)
                        {
                            BufferImageCopy* dataPointer = stackalloc BufferImageCopy[1];
                            *dataPointer = regions.GetSingleValue();
                            marshalledRegions = dataPointer;
                        }
                        else
                        {
                            var arrayValue = regions.GetArrayValue(); 
                            regionsHandle = GCHandle.Alloc(arrayValue.Array); 
                            marshalledRegions = (BufferImageCopy*)(regionsHandle.AddrOfPinnedObject() + (int)(MemUtil.SizeOf<BufferImageCopy>() * arrayValue.Offset)).ToPointer(); 
                        }
                    }
                    else
                    {
                        marshalledRegions = null;
                    }
                    Interop.Commands.vkCmdCopyBufferToImage(this.handle, marshalledSourceBuffer, marshalledDestinationImage, destinationImageLayout, (uint)(regions.Length), marshalledRegions);
                    if (regionsHandle.IsAllocated) regionsHandle.Free();
                }
                finally
                {
                    Interop.HeapUtil.FreeLog();
                }
            }
        }
        
        /// <summary>
        /// Copy image data into a buffer.
        /// </summary>
        public void CopyImageToBuffer(Image sourceImage, ImageLayout sourceImageLayout, Buffer destinationBuffer, ArrayProxy<BufferImageCopy> regions)
        {
            unsafe
            {
                try
                {
                    Interop.Image marshalledSourceImage = sourceImage.Pack();
                    Interop.Buffer marshalledDestinationBuffer = destinationBuffer.Pack();
                    GCHandle regionsHandle = default(GCHandle);
                    BufferImageCopy* marshalledRegions = null;
                    if (regions.Contents != ProxyContents.Null)
                    {
                        if(regions.Contents == ProxyContents.Single)
                        {
                            BufferImageCopy* dataPointer = stackalloc BufferImageCopy[1];
                            *dataPointer = regions.GetSingleValue();
                            marshalledRegions = dataPointer;
                        }
                        else
                        {
                            var arrayValue = regions.GetArrayValue(); 
                            regionsHandle = GCHandle.Alloc(arrayValue.Array); 
                            marshalledRegions = (BufferImageCopy*)(regionsHandle.AddrOfPinnedObject() + (int)(MemUtil.SizeOf<BufferImageCopy>() * arrayValue.Offset)).ToPointer(); 
                        }
                    }
                    else
                    {
                        marshalledRegions = null;
                    }
                    Interop.Commands.vkCmdCopyImageToBuffer(this.handle, marshalledSourceImage, sourceImageLayout, marshalledDestinationBuffer, (uint)(regions.Length), marshalledRegions);
                    if (regionsHandle.IsAllocated) regionsHandle.Free();
                }
                finally
                {
                    Interop.HeapUtil.FreeLog();
                }
            }
        }
        
        /// <summary>
        /// Update a buffer's contents from host memory.
        /// </summary>
        public void UpdateBuffer(Buffer destinationBuffer, DeviceSize destinationOffset, ArrayProxy<byte> data)
        {
            unsafe
            {
                try
                {
                    Interop.Buffer marshalledDestinationBuffer = destinationBuffer.Pack();
                    GCHandle dataHandle = default(GCHandle);
                    byte* marshalledData = null;
                    if (data.Contents != ProxyContents.Null)
                    {
                        if(data.Contents == ProxyContents.Single)
                        {
                            byte* dataPointer = stackalloc byte[1];
                            *dataPointer = data.GetSingleValue();
                            marshalledData = dataPointer;
                        }
                        else
                        {
                            var arrayValue = data.GetArrayValue(); 
                            dataHandle = GCHandle.Alloc(arrayValue.Array); 
                            marshalledData = (byte*)(dataHandle.AddrOfPinnedObject() + (int)(MemUtil.SizeOf<byte>() * arrayValue.Offset)).ToPointer(); 
                        }
                    }
                    else
                    {
                        marshalledData = null;
                    }
                    Interop.Commands.vkCmdUpdateBuffer(this.handle, marshalledDestinationBuffer, destinationOffset, (DeviceSize)(data.Length), marshalledData);
                    if (dataHandle.IsAllocated) dataHandle.Free();
                }
                finally
                {
                    Interop.HeapUtil.FreeLog();
                }
            }
        }
        
        /// <summary>
        /// Fill a region of a buffer with a fixed value.
        /// </summary>
        public void FillBuffer(Buffer destinationBuffer, DeviceSize destinationOffset, DeviceSize size, uint data)
        {
            unsafe
            {
                try
                {
                    Interop.Buffer marshalledDestinationBuffer = destinationBuffer.Pack();
                    Interop.Commands.vkCmdFillBuffer(this.handle, marshalledDestinationBuffer, destinationOffset, size, data);
                }
                finally
                {
                    Interop.HeapUtil.FreeLog();
                }
            }
        }
        
        /// <summary>
        /// Clear regions of a color image.
        /// </summary>
        public void ClearColorImage(Image image, ImageLayout imageLayout, ClearColorValue color, ArrayProxy<ImageSubresourceRange> ranges)
        {
            unsafe
            {
                try
                {
                    Interop.Image marshalledImage = image.Pack();
                    GCHandle rangesHandle = default(GCHandle);
                    ImageSubresourceRange* marshalledRanges = null;
                    if (ranges.Contents != ProxyContents.Null)
                    {
                        if(ranges.Contents == ProxyContents.Single)
                        {
                            ImageSubresourceRange* dataPointer = stackalloc ImageSubresourceRange[1];
                            *dataPointer = ranges.GetSingleValue();
                            marshalledRanges = dataPointer;
                        }
                        else
                        {
                            var arrayValue = ranges.GetArrayValue(); 
                            rangesHandle = GCHandle.Alloc(arrayValue.Array); 
                            marshalledRanges = (ImageSubresourceRange*)(rangesHandle.AddrOfPinnedObject() + (int)(MemUtil.SizeOf<ImageSubresourceRange>() * arrayValue.Offset)).ToPointer(); 
                        }
                    }
                    else
                    {
                        marshalledRanges = null;
                    }
                    Interop.Commands.vkCmdClearColorImage(this.handle, marshalledImage, imageLayout, &color, (uint)(ranges.Length), marshalledRanges);
                    if (rangesHandle.IsAllocated) rangesHandle.Free();
                }
                finally
                {
                    Interop.HeapUtil.FreeLog();
                }
            }
        }
        
        /// <summary>
        /// Fill regions of a combined depth-stencil image.
        /// </summary>
        public void ClearDepthStencilImage(Image image, ImageLayout imageLayout, ClearDepthStencilValue depthStencil, ArrayProxy<ImageSubresourceRange> ranges)
        {
            unsafe
            {
                try
                {
                    Interop.Image marshalledImage = image.Pack();
                    GCHandle rangesHandle = default(GCHandle);
                    ImageSubresourceRange* marshalledRanges = null;
                    if (ranges.Contents != ProxyContents.Null)
                    {
                        if(ranges.Contents == ProxyContents.Single)
                        {
                            ImageSubresourceRange* dataPointer = stackalloc ImageSubresourceRange[1];
                            *dataPointer = ranges.GetSingleValue();
                            marshalledRanges = dataPointer;
                        }
                        else
                        {
                            var arrayValue = ranges.GetArrayValue(); 
                            rangesHandle = GCHandle.Alloc(arrayValue.Array); 
                            marshalledRanges = (ImageSubresourceRange*)(rangesHandle.AddrOfPinnedObject() + (int)(MemUtil.SizeOf<ImageSubresourceRange>() * arrayValue.Offset)).ToPointer(); 
                        }
                    }
                    else
                    {
                        marshalledRanges = null;
                    }
                    Interop.Commands.vkCmdClearDepthStencilImage(this.handle, marshalledImage, imageLayout, &depthStencil, (uint)(ranges.Length), marshalledRanges);
                    if (rangesHandle.IsAllocated) rangesHandle.Free();
                }
                finally
                {
                    Interop.HeapUtil.FreeLog();
                }
            }
        }
        
        /// <summary>
        /// Clear regions within currently bound framebuffer attachments.
        /// </summary>
        public void ClearAttachments(ArrayProxy<ClearAttachment> attachments, ArrayProxy<ClearRect> rects)
        {
            unsafe
            {
                try
                {
                    GCHandle attachmentsHandle = default(GCHandle);
                    ClearAttachment* marshalledAttachments = null;
                    if (attachments.Contents != ProxyContents.Null)
                    {
                        if(attachments.Contents == ProxyContents.Single)
                        {
                            ClearAttachment* dataPointer = stackalloc ClearAttachment[1];
                            *dataPointer = attachments.GetSingleValue();
                            marshalledAttachments = dataPointer;
                        }
                        else
                        {
                            var arrayValue = attachments.GetArrayValue(); 
                            attachmentsHandle = GCHandle.Alloc(arrayValue.Array); 
                            marshalledAttachments = (ClearAttachment*)(attachmentsHandle.AddrOfPinnedObject() + (int)(MemUtil.SizeOf<ClearAttachment>() * arrayValue.Offset)).ToPointer(); 
                        }
                    }
                    else
                    {
                        marshalledAttachments = null;
                    }
                    GCHandle rectsHandle = default(GCHandle);
                    ClearRect* marshalledRects = null;
                    if (rects.Contents != ProxyContents.Null)
                    {
                        if(rects.Contents == ProxyContents.Single)
                        {
                            ClearRect* dataPointer = stackalloc ClearRect[1];
                            *dataPointer = rects.GetSingleValue();
                            marshalledRects = dataPointer;
                        }
                        else
                        {
                            var arrayValue = rects.GetArrayValue(); 
                            rectsHandle = GCHandle.Alloc(arrayValue.Array); 
                            marshalledRects = (ClearRect*)(rectsHandle.AddrOfPinnedObject() + (int)(MemUtil.SizeOf<ClearRect>() * arrayValue.Offset)).ToPointer(); 
                        }
                    }
                    else
                    {
                        marshalledRects = null;
                    }
                    Interop.Commands.vkCmdClearAttachments(this.handle, (uint)(attachments.Length), marshalledAttachments, (uint)(rects.Length), marshalledRects);
                    if (attachmentsHandle.IsAllocated) attachmentsHandle.Free();
                    if (rectsHandle.IsAllocated) rectsHandle.Free();
                }
                finally
                {
                    Interop.HeapUtil.FreeLog();
                }
            }
        }
        
        /// <summary>
        /// Resolve regions of an image.
        /// </summary>
        public void ResolveImage(Image sourceImage, ImageLayout sourceImageLayout, Image destinationImage, ImageLayout destinationImageLayout, ArrayProxy<ImageResolve> regions)
        {
            unsafe
            {
                try
                {
                    Interop.Image marshalledSourceImage = sourceImage.Pack();
                    Interop.Image marshalledDestinationImage = destinationImage.Pack();
                    GCHandle regionsHandle = default(GCHandle);
                    ImageResolve* marshalledRegions = null;
                    if (regions.Contents != ProxyContents.Null)
                    {
                        if(regions.Contents == ProxyContents.Single)
                        {
                            ImageResolve* dataPointer = stackalloc ImageResolve[1];
                            *dataPointer = regions.GetSingleValue();
                            marshalledRegions = dataPointer;
                        }
                        else
                        {
                            var arrayValue = regions.GetArrayValue(); 
                            regionsHandle = GCHandle.Alloc(arrayValue.Array); 
                            marshalledRegions = (ImageResolve*)(regionsHandle.AddrOfPinnedObject() + (int)(MemUtil.SizeOf<ImageResolve>() * arrayValue.Offset)).ToPointer(); 
                        }
                    }
                    else
                    {
                        marshalledRegions = null;
                    }
                    Interop.Commands.vkCmdResolveImage(this.handle, marshalledSourceImage, sourceImageLayout, marshalledDestinationImage, destinationImageLayout, (uint)(regions.Length), marshalledRegions);
                    if (regionsHandle.IsAllocated) regionsHandle.Free();
                }
                finally
                {
                    Interop.HeapUtil.FreeLog();
                }
            }
        }
        
        /// <summary>
        /// Set an event object to signaled state.
        /// </summary>
        public void SetEvent(Event @event, PipelineStageFlags stageMask)
        {
            unsafe
            {
                try
                {
                    Interop.Event marshalledEvent = @event.Pack();
                    Interop.Commands.vkCmdSetEvent(this.handle, marshalledEvent, stageMask);
                }
                finally
                {
                    Interop.HeapUtil.FreeLog();
                }
            }
        }
        
        /// <summary>
        /// Reset an event object to non-signaled state.
        /// </summary>
        public void ResetEvent(Event @event, PipelineStageFlags stageMask)
        {
            unsafe
            {
                try
                {
                    Interop.Event marshalledEvent = @event.Pack();
                    Interop.Commands.vkCmdResetEvent(this.handle, marshalledEvent, stageMask);
                }
                finally
                {
                    Interop.HeapUtil.FreeLog();
                }
            }
        }
        
        /// <summary>
        /// Wait for one or more events and insert a set of memory.
        /// </summary>
        public void WaitEvents(ArrayProxy<Event> events, PipelineStageFlags sourceStageMask, PipelineStageFlags destinationStageMask, ArrayProxy<MemoryBarrier> memoryBarriers, ArrayProxy<BufferMemoryBarrier> bufferMemoryBarriers, ArrayProxy<ImageMemoryBarrier> imageMemoryBarriers)
        {
            unsafe
            {
                try
                {
                    Interop.Event* marshalledEvents = null;
                    if (events.Contents != ProxyContents.Null)
                    {
                        Interop.Event* arrayPointer = stackalloc Interop.Event[events.Length];
                        if(events.Contents == ProxyContents.Single)
                        {
                            *arrayPointer = events.GetSingleValue().Pack();
                        }
                        else
                        {
                            var arrayValue  = events.GetArrayValue();
                            for (int index = 0; index < events.Length; index++)
                            {
                                arrayPointer[index] = arrayValue.Array[arrayValue.Offset + index].Pack();
                            }
                        }
                        marshalledEvents = arrayPointer;
                    }
                    else
                    {
                        marshalledEvents = null;
                    }
                    Interop.MemoryBarrier* marshalledMemoryBarriers = null;
                    if (memoryBarriers.Contents != ProxyContents.Null)
                    {
                        Interop.MemoryBarrier* arrayPointer = stackalloc Interop.MemoryBarrier[memoryBarriers.Length];
                        if(memoryBarriers.Contents == ProxyContents.Single)
                        {
                            *arrayPointer = memoryBarriers.GetSingleValue().Pack();
                        }
                        else
                        {
                            var arrayValue  = memoryBarriers.GetArrayValue();
                            for (int index = 0; index < memoryBarriers.Length; index++)
                            {
                                arrayPointer[index] = arrayValue.Array[arrayValue.Offset + index].Pack();
                            }
                        }
                        marshalledMemoryBarriers = arrayPointer;
                    }
                    else
                    {
                        marshalledMemoryBarriers = null;
                    }
                    Interop.BufferMemoryBarrier* marshalledBufferMemoryBarriers = null;
                    if (bufferMemoryBarriers.Contents != ProxyContents.Null)
                    {
                        Interop.BufferMemoryBarrier* arrayPointer = stackalloc Interop.BufferMemoryBarrier[bufferMemoryBarriers.Length];
                        if(bufferMemoryBarriers.Contents == ProxyContents.Single)
                        {
                            *arrayPointer = bufferMemoryBarriers.GetSingleValue().Pack();
                        }
                        else
                        {
                            var arrayValue  = bufferMemoryBarriers.GetArrayValue();
                            for (int index = 0; index < bufferMemoryBarriers.Length; index++)
                            {
                                arrayPointer[index] = arrayValue.Array[arrayValue.Offset + index].Pack();
                            }
                        }
                        marshalledBufferMemoryBarriers = arrayPointer;
                    }
                    else
                    {
                        marshalledBufferMemoryBarriers = null;
                    }
                    Interop.ImageMemoryBarrier* marshalledImageMemoryBarriers = null;
                    if (imageMemoryBarriers.Contents != ProxyContents.Null)
                    {
                        Interop.ImageMemoryBarrier* arrayPointer = stackalloc Interop.ImageMemoryBarrier[imageMemoryBarriers.Length];
                        if(imageMemoryBarriers.Contents == ProxyContents.Single)
                        {
                            *arrayPointer = imageMemoryBarriers.GetSingleValue().Pack();
                        }
                        else
                        {
                            var arrayValue  = imageMemoryBarriers.GetArrayValue();
                            for (int index = 0; index < imageMemoryBarriers.Length; index++)
                            {
                                arrayPointer[index] = arrayValue.Array[arrayValue.Offset + index].Pack();
                            }
                        }
                        marshalledImageMemoryBarriers = arrayPointer;
                    }
                    else
                    {
                        marshalledImageMemoryBarriers = null;
                    }
                    Interop.Commands.vkCmdWaitEvents(this.handle, (uint)(events.Length), marshalledEvents, sourceStageMask, destinationStageMask, (uint)(memoryBarriers.Length), marshalledMemoryBarriers, (uint)(bufferMemoryBarriers.Length), marshalledBufferMemoryBarriers, (uint)(imageMemoryBarriers.Length), marshalledImageMemoryBarriers);
                }
                finally
                {
                    Interop.HeapUtil.FreeLog();
                }
            }
        }
        
        /// <summary>
        /// Insert a set of execution and memory barriers.
        /// </summary>
        public void PipelineBarrier(PipelineStageFlags sourceStageMask, PipelineStageFlags destinationStageMask, DependencyFlags dependencyFlags, ArrayProxy<MemoryBarrier> memoryBarriers, ArrayProxy<BufferMemoryBarrier> bufferMemoryBarriers, ArrayProxy<ImageMemoryBarrier> imageMemoryBarriers)
        {
            unsafe
            {
                try
                {
                    Interop.MemoryBarrier* marshalledMemoryBarriers = null;
                    if (memoryBarriers.Contents != ProxyContents.Null)
                    {
                        Interop.MemoryBarrier* arrayPointer = stackalloc Interop.MemoryBarrier[memoryBarriers.Length];
                        if(memoryBarriers.Contents == ProxyContents.Single)
                        {
                            *arrayPointer = memoryBarriers.GetSingleValue().Pack();
                        }
                        else
                        {
                            var arrayValue  = memoryBarriers.GetArrayValue();
                            for (int index = 0; index < memoryBarriers.Length; index++)
                            {
                                arrayPointer[index] = arrayValue.Array[arrayValue.Offset + index].Pack();
                            }
                        }
                        marshalledMemoryBarriers = arrayPointer;
                    }
                    else
                    {
                        marshalledMemoryBarriers = null;
                    }
                    Interop.BufferMemoryBarrier* marshalledBufferMemoryBarriers = null;
                    if (bufferMemoryBarriers.Contents != ProxyContents.Null)
                    {
                        Interop.BufferMemoryBarrier* arrayPointer = stackalloc Interop.BufferMemoryBarrier[bufferMemoryBarriers.Length];
                        if(bufferMemoryBarriers.Contents == ProxyContents.Single)
                        {
                            *arrayPointer = bufferMemoryBarriers.GetSingleValue().Pack();
                        }
                        else
                        {
                            var arrayValue  = bufferMemoryBarriers.GetArrayValue();
                            for (int index = 0; index < bufferMemoryBarriers.Length; index++)
                            {
                                arrayPointer[index] = arrayValue.Array[arrayValue.Offset + index].Pack();
                            }
                        }
                        marshalledBufferMemoryBarriers = arrayPointer;
                    }
                    else
                    {
                        marshalledBufferMemoryBarriers = null;
                    }
                    Interop.ImageMemoryBarrier* marshalledImageMemoryBarriers = null;
                    if (imageMemoryBarriers.Contents != ProxyContents.Null)
                    {
                        Interop.ImageMemoryBarrier* arrayPointer = stackalloc Interop.ImageMemoryBarrier[imageMemoryBarriers.Length];
                        if(imageMemoryBarriers.Contents == ProxyContents.Single)
                        {
                            *arrayPointer = imageMemoryBarriers.GetSingleValue().Pack();
                        }
                        else
                        {
                            var arrayValue  = imageMemoryBarriers.GetArrayValue();
                            for (int index = 0; index < imageMemoryBarriers.Length; index++)
                            {
                                arrayPointer[index] = arrayValue.Array[arrayValue.Offset + index].Pack();
                            }
                        }
                        marshalledImageMemoryBarriers = arrayPointer;
                    }
                    else
                    {
                        marshalledImageMemoryBarriers = null;
                    }
                    Interop.Commands.vkCmdPipelineBarrier(this.handle, sourceStageMask, destinationStageMask, dependencyFlags, (uint)(memoryBarriers.Length), marshalledMemoryBarriers, (uint)(bufferMemoryBarriers.Length), marshalledBufferMemoryBarriers, (uint)(imageMemoryBarriers.Length), marshalledImageMemoryBarriers);
                }
                finally
                {
                    Interop.HeapUtil.FreeLog();
                }
            }
        }
        
        /// <summary>
        /// Begin a query.
        /// </summary>
        public void BeginQuery(QueryPool queryPool, uint query, QueryControlFlags flags)
        {
            unsafe
            {
                try
                {
                    Interop.QueryPool marshalledQueryPool = queryPool.Pack();
                    Interop.Commands.vkCmdBeginQuery(this.handle, marshalledQueryPool, query, flags);
                }
                finally
                {
                    Interop.HeapUtil.FreeLog();
                }
            }
        }
        
        /// <summary>
        /// Ends a query.
        /// </summary>
        public void EndQuery(QueryPool queryPool, uint query)
        {
            unsafe
            {
                try
                {
                    Interop.QueryPool marshalledQueryPool = queryPool.Pack();
                    Interop.Commands.vkCmdEndQuery(this.handle, marshalledQueryPool, query);
                }
                finally
                {
                    Interop.HeapUtil.FreeLog();
                }
            }
        }
        
        /// <summary>
        /// Reset queries in a query pool.
        /// </summary>
        public void ResetQueryPool(QueryPool queryPool, uint firstQuery, uint queryCount)
        {
            unsafe
            {
                try
                {
                    Interop.QueryPool marshalledQueryPool = queryPool.Pack();
                    Interop.Commands.vkCmdResetQueryPool(this.handle, marshalledQueryPool, firstQuery, queryCount);
                }
                finally
                {
                    Interop.HeapUtil.FreeLog();
                }
            }
        }
        
        /// <summary>
        /// Write a device timestamp into a query object.
        /// </summary>
        public void WriteTimestamp(PipelineStageFlags pipelineStage, QueryPool queryPool, uint query)
        {
            unsafe
            {
                try
                {
                    Interop.QueryPool marshalledQueryPool = queryPool.Pack();
                    Interop.Commands.vkCmdWriteTimestamp(this.handle, pipelineStage, marshalledQueryPool, query);
                }
                finally
                {
                    Interop.HeapUtil.FreeLog();
                }
            }
        }
        
        /// <summary>
        /// Copy the results of queries in a query pool to a buffer object.
        /// </summary>
        public void CopyQueryPoolResults(QueryPool queryPool, uint firstQuery, uint queryCount, Buffer destinationBuffer, DeviceSize destinationOffset, DeviceSize stride, QueryResultFlags flags)
        {
            unsafe
            {
                try
                {
                    Interop.QueryPool marshalledQueryPool = queryPool.Pack();
                    Interop.Buffer marshalledDestinationBuffer = destinationBuffer.Pack();
                    Interop.Commands.vkCmdCopyQueryPoolResults(this.handle, marshalledQueryPool, firstQuery, queryCount, marshalledDestinationBuffer, destinationOffset, stride, flags);
                }
                finally
                {
                    Interop.HeapUtil.FreeLog();
                }
            }
        }
        
        /// <summary>
        /// Update the values of push constants.
        /// </summary>
        public void PushConstants(PipelineLayout layout, ShaderStageFlags stageFlags, uint offset, ArrayProxy<byte> values)
        {
            unsafe
            {
                try
                {
                    Interop.PipelineLayout marshalledLayout = layout.Pack();
                    GCHandle valuesHandle = default(GCHandle);
                    byte* marshalledValues = null;
                    if (values.Contents != ProxyContents.Null)
                    {
                        if(values.Contents == ProxyContents.Single)
                        {
                            byte* dataPointer = stackalloc byte[1];
                            *dataPointer = values.GetSingleValue();
                            marshalledValues = dataPointer;
                        }
                        else
                        {
                            var arrayValue = values.GetArrayValue(); 
                            valuesHandle = GCHandle.Alloc(arrayValue.Array); 
                            marshalledValues = (byte*)(valuesHandle.AddrOfPinnedObject() + (int)(MemUtil.SizeOf<byte>() * arrayValue.Offset)).ToPointer(); 
                        }
                    }
                    else
                    {
                        marshalledValues = null;
                    }
                    Interop.Commands.vkCmdPushConstants(this.handle, marshalledLayout, stageFlags, offset, (uint)(values.Length), marshalledValues);
                    if (valuesHandle.IsAllocated) valuesHandle.Free();
                }
                finally
                {
                    Interop.HeapUtil.FreeLog();
                }
            }
        }
        
        /// <summary>
        /// Begin a new render pass.
        /// </summary>
        public void BeginRenderPass(RenderPassBeginInfo renderPassBegin, SubpassContents contents)
        {
            unsafe
            {
                try
                {
                    Interop.RenderPassBeginInfo marshalledRenderPassBegin;
                    marshalledRenderPassBegin = renderPassBegin.Pack();
                    Interop.Commands.vkCmdBeginRenderPass(this.handle, &marshalledRenderPassBegin, contents);
                }
                finally
                {
                    Interop.HeapUtil.FreeLog();
                }
            }
        }
        
        /// <summary>
        /// Transition to the next subpass of a render pass.
        /// </summary>
        public void NextSubpass(SubpassContents contents)
        {
            unsafe
            {
                try
                {
                    Interop.Commands.vkCmdNextSubpass(this.handle, contents);
                }
                finally
                {
                    Interop.HeapUtil.FreeLog();
                }
            }
        }
        
        /// <summary>
        /// End the current render pass.
        /// </summary>
        public void EndRenderPass()
        {
            unsafe
            {
                try
                {
                    Interop.Commands.vkCmdEndRenderPass(this.handle);
                }
                finally
                {
                    Interop.HeapUtil.FreeLog();
                }
            }
        }
        
        /// <summary>
        /// Execute a secondary command buffer from a primary command buffer.
        /// </summary>
        public void ExecuteCommands(ArrayProxy<CommandBuffer> commandBuffers)
        {
            unsafe
            {
                try
                {
                    Interop.CommandBuffer* marshalledCommandBuffers = null;
                    if (commandBuffers.Contents != ProxyContents.Null)
                    {
                        Interop.CommandBuffer* arrayPointer = stackalloc Interop.CommandBuffer[commandBuffers.Length];
                        if(commandBuffers.Contents == ProxyContents.Single)
                        {
                            *arrayPointer = commandBuffers.GetSingleValue().Pack();
                        }
                        else
                        {
                            var arrayValue  = commandBuffers.GetArrayValue();
                            for (int index = 0; index < commandBuffers.Length; index++)
                            {
                                arrayPointer[index] = arrayValue.Array[arrayValue.Offset + index].Pack();
                            }
                        }
                        marshalledCommandBuffers = arrayPointer;
                    }
                    else
                    {
                        marshalledCommandBuffers = null;
                    }
                    Interop.Commands.vkCmdExecuteCommands(this.handle, (uint)(commandBuffers.Length), marshalledCommandBuffers);
                }
                finally
                {
                    Interop.HeapUtil.FreeLog();
                }
            }
        }
        
        /// <summary>
        /// Open a command buffer marker region.
        /// </summary>
        public void DebugMarkerBegin(DebugMarkerMarkerInfo markerInfo)
        {
            unsafe
            {
                try
                {
                    var commandDelegate = this.commandCache.GetCommandDelegate<Interop.vkCmdDebugMarkerBeginEXT>("vkCmdDebugMarkerBeginEXT", "device");
                    Interop.DebugMarkerMarkerInfo marshalledMarkerInfo;
                    marshalledMarkerInfo = markerInfo.Pack();
                    commandDelegate(this.handle, &marshalledMarkerInfo);
                }
                finally
                {
                    Interop.HeapUtil.FreeLog();
                }
            }
        }
        
        /// <summary>
        /// Close a command buffer marker region.
        /// </summary>
        public void DebugMarkerEnd()
        {
            unsafe
            {
                try
                {
                    var commandDelegate = this.commandCache.GetCommandDelegate<Interop.vkCmdDebugMarkerEndEXT>("vkCmdDebugMarkerEndEXT", "device");
                    commandDelegate(this.handle);
                }
                finally
                {
                    Interop.HeapUtil.FreeLog();
                }
            }
        }
        
        /// <summary>
        /// Insert a marker label into a command buffer.
        /// </summary>
        public void DebugMarkerInsert(DebugMarkerMarkerInfo markerInfo)
        {
            unsafe
            {
                try
                {
                    var commandDelegate = this.commandCache.GetCommandDelegate<Interop.vkCmdDebugMarkerInsertEXT>("vkCmdDebugMarkerInsertEXT", "device");
                    Interop.DebugMarkerMarkerInfo marshalledMarkerInfo;
                    marshalledMarkerInfo = markerInfo.Pack();
                    commandDelegate(this.handle, &marshalledMarkerInfo);
                }
                finally
                {
                    Interop.HeapUtil.FreeLog();
                }
            }
        }
        
        /// <summary>
        /// Perform an indirect draw with the draw count sourced from a buffer.
        /// </summary>
        public void DrawIndirectCount(Buffer buffer, DeviceSize offset, Buffer countBuffer, DeviceSize countBufferOffset, uint maxDrawCount, uint stride)
        {
            unsafe
            {
                try
                {
                    var commandDelegate = this.commandCache.GetCommandDelegate<Interop.vkCmdDrawIndirectCountAMD>("vkCmdDrawIndirectCountAMD", "device");
                    Interop.Buffer marshalledBuffer = buffer.Pack();
                    Interop.Buffer marshalledCountBuffer = countBuffer.Pack();
                    commandDelegate(this.handle, marshalledBuffer, offset, marshalledCountBuffer, countBufferOffset, maxDrawCount, stride);
                }
                finally
                {
                    Interop.HeapUtil.FreeLog();
                }
            }
        }
        
        /// <summary>
        /// Perform an indexed indirect draw with the draw count sourced from a
        /// buffer.
        /// </summary>
        public void DrawIndexedIndirectCount(Buffer buffer, DeviceSize offset, Buffer countBuffer, DeviceSize countBufferOffset, uint maxDrawCount, uint stride)
        {
            unsafe
            {
                try
                {
                    var commandDelegate = this.commandCache.GetCommandDelegate<Interop.vkCmdDrawIndexedIndirectCountAMD>("vkCmdDrawIndexedIndirectCountAMD", "device");
                    Interop.Buffer marshalledBuffer = buffer.Pack();
                    Interop.Buffer marshalledCountBuffer = countBuffer.Pack();
                    commandDelegate(this.handle, marshalledBuffer, offset, marshalledCountBuffer, countBufferOffset, maxDrawCount, stride);
                }
                finally
                {
                    Interop.HeapUtil.FreeLog();
                }
            }
        }
        
        internal Interop.CommandBuffer Pack()
        {
            return this.handle;
        }
        
        /// <summary>
        /// The interop handle for this CommandBuffer.
        /// </summary>
        public Interop.CommandBuffer RawHandle => this.handle;
    }
}
