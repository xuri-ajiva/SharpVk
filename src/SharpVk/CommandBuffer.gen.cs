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
        public void Begin(CommandBufferBeginInfo beginInfo)
        {
        }
        
        /// <summary>
        /// 
        /// </summary>
        public void End()
        {
        }
        
        /// <summary>
        /// 
        /// </summary>
        public void Reset(CommandBufferResetFlags flags)
        {
        }
        
        /// <summary>
        /// 
        /// </summary>
        public void BindPipeline(PipelineBindPoint pipelineBindPoint, Pipeline pipeline)
        {
        }
        
        /// <summary>
        /// 
        /// </summary>
        public void SetViewport(uint firstViewport, Viewport[] viewports)
        {
        }
        
        /// <summary>
        /// 
        /// </summary>
        public void SetScissor(uint firstScissor, Rect2D[] scissors)
        {
        }
        
        /// <summary>
        /// 
        /// </summary>
        public void SetLineWidth(float lineWidth)
        {
        }
        
        /// <summary>
        /// 
        /// </summary>
        public void SetDepthBias(float depthBiasConstantFactor, float depthBiasClamp, float depthBiasSlopeFactor)
        {
        }
        
        /// <summary>
        /// 
        /// </summary>
        public void SetBlendConstants(float blendConstants)
        {
        }
        
        /// <summary>
        /// 
        /// </summary>
        public void SetDepthBounds(float minDepthBounds, float maxDepthBounds)
        {
        }
        
        /// <summary>
        /// 
        /// </summary>
        public void SetStencilCompareMask(StencilFaceFlags faceMask, uint compareMask)
        {
        }
        
        /// <summary>
        /// 
        /// </summary>
        public void SetStencilWriteMask(StencilFaceFlags faceMask, uint writeMask)
        {
        }
        
        /// <summary>
        /// 
        /// </summary>
        public void SetStencilReference(StencilFaceFlags faceMask, uint reference)
        {
        }
        
        /// <summary>
        /// 
        /// </summary>
        public void BindDescriptorSets(PipelineBindPoint pipelineBindPoint, PipelineLayout layout, uint firstSet, DescriptorSet[] descriptorSets, uint[] dynamicOffsets)
        {
        }
        
        /// <summary>
        /// 
        /// </summary>
        public void BindIndexBuffer(Buffer buffer, DeviceSize offset, IndexType indexType)
        {
        }
        
        /// <summary>
        /// 
        /// </summary>
        public void BindVertexBuffers(uint firstBinding, Buffer[] buffers, DeviceSize[] offsets)
        {
        }
        
        /// <summary>
        /// 
        /// </summary>
        public void Draw(uint vertexCount, uint instanceCount, uint firstVertex, uint firstInstance)
        {
        }
        
        /// <summary>
        /// 
        /// </summary>
        public void DrawIndexed(uint indexCount, uint instanceCount, uint firstIndex, int vertexOffset, uint firstInstance)
        {
        }
        
        /// <summary>
        /// 
        /// </summary>
        public void DrawIndirect(Buffer buffer, DeviceSize offset, uint drawCount, uint stride)
        {
        }
        
        /// <summary>
        /// 
        /// </summary>
        public void DrawIndexedIndirect(Buffer buffer, DeviceSize offset, uint drawCount, uint stride)
        {
        }
        
        /// <summary>
        /// 
        /// </summary>
        public void Dispatch(uint groupCountX, uint groupCountY, uint groupCountZ)
        {
        }
        
        /// <summary>
        /// 
        /// </summary>
        public void DispatchIndirect(Buffer buffer, DeviceSize offset)
        {
        }
        
        /// <summary>
        /// 
        /// </summary>
        public void CopyBuffer(Buffer sourceBuffer, Buffer destinationBuffer, BufferCopy[] regions)
        {
        }
        
        /// <summary>
        /// 
        /// </summary>
        public void CopyImage(Image sourceImage, ImageLayout sourceImageLayout, Image destinationImage, ImageLayout destinationImageLayout, ImageCopy[] regions)
        {
        }
        
        /// <summary>
        /// 
        /// </summary>
        public void BlitImage(Image sourceImage, ImageLayout sourceImageLayout, Image destinationImage, ImageLayout destinationImageLayout, ImageBlit[] regions, Filter filter)
        {
        }
        
        /// <summary>
        /// 
        /// </summary>
        public void CopyBufferToImage(Buffer sourceBuffer, Image destinationImage, ImageLayout destinationImageLayout, BufferImageCopy[] regions)
        {
        }
        
        /// <summary>
        /// 
        /// </summary>
        public void CopyImageToBuffer(Image sourceImage, ImageLayout sourceImageLayout, Buffer destinationBuffer, BufferImageCopy[] regions)
        {
        }
        
        /// <summary>
        /// 
        /// </summary>
        public void UpdateBuffer(Buffer destinationBuffer, DeviceSize destinationOffset, byte[] data)
        {
        }
        
        /// <summary>
        /// 
        /// </summary>
        public void FillBuffer(Buffer destinationBuffer, DeviceSize destinationOffset, DeviceSize size, uint data)
        {
        }
        
        /// <summary>
        /// 
        /// </summary>
        public void ClearColorImage(Image image, ImageLayout imageLayout, ClearColorValue color, ImageSubresourceRange[] ranges)
        {
        }
        
        /// <summary>
        /// 
        /// </summary>
        public void ClearDepthStencilImage(Image image, ImageLayout imageLayout, ClearDepthStencilValue depthStencil, ImageSubresourceRange[] ranges)
        {
        }
        
        /// <summary>
        /// 
        /// </summary>
        public void ClearAttachments(ClearAttachment[] attachments, ClearRect[] rects)
        {
        }
        
        /// <summary>
        /// 
        /// </summary>
        public void ResolveImage(Image sourceImage, ImageLayout sourceImageLayout, Image destinationImage, ImageLayout destinationImageLayout, ImageResolve[] regions)
        {
        }
        
        /// <summary>
        /// 
        /// </summary>
        public void SetEvent(Event @event, PipelineStageFlags stageMask)
        {
        }
        
        /// <summary>
        /// 
        /// </summary>
        public void ResetEvent(Event @event, PipelineStageFlags stageMask)
        {
        }
        
        /// <summary>
        /// 
        /// </summary>
        public void WaitEvents(Event[] events, PipelineStageFlags sourceStageMask, PipelineStageFlags destinationStageMask, MemoryBarrier[] memoryBarriers, BufferMemoryBarrier[] bufferMemoryBarriers, ImageMemoryBarrier[] imageMemoryBarriers)
        {
        }
        
        /// <summary>
        /// 
        /// </summary>
        public void PipelineBarrier(PipelineStageFlags sourceStageMask, PipelineStageFlags destinationStageMask, DependencyFlags dependencyFlags, MemoryBarrier[] memoryBarriers, BufferMemoryBarrier[] bufferMemoryBarriers, ImageMemoryBarrier[] imageMemoryBarriers)
        {
        }
        
        /// <summary>
        /// 
        /// </summary>
        public void BeginQuery(QueryPool queryPool, uint query, QueryControlFlags flags)
        {
        }
        
        /// <summary>
        /// 
        /// </summary>
        public void EndQuery(QueryPool queryPool, uint query)
        {
        }
        
        /// <summary>
        /// 
        /// </summary>
        public void ResetQueryPool(QueryPool queryPool, uint firstQuery, uint queryCount)
        {
        }
        
        /// <summary>
        /// 
        /// </summary>
        public void WriteTimestamp(PipelineStageFlags pipelineStage, QueryPool queryPool, uint query)
        {
        }
        
        /// <summary>
        /// 
        /// </summary>
        public void CopyQueryPoolResults(QueryPool queryPool, uint firstQuery, uint queryCount, Buffer destinationBuffer, DeviceSize destinationOffset, DeviceSize stride, QueryResultFlags flags)
        {
        }
        
        /// <summary>
        /// 
        /// </summary>
        public void PushConstants(PipelineLayout layout, ShaderStageFlags stageFlags, uint offset, byte[] values)
        {
        }
        
        /// <summary>
        /// 
        /// </summary>
        public void BeginRenderPass(RenderPassBeginInfo renderPassBegin, SubpassContents contents)
        {
        }
        
        /// <summary>
        /// 
        /// </summary>
        public void NextSubpass(SubpassContents contents)
        {
        }
        
        /// <summary>
        /// 
        /// </summary>
        public void EndRenderPass()
        {
        }
        
        /// <summary>
        /// 
        /// </summary>
        public void ExecuteCommands(CommandBuffer[] commandBuffers)
        {
        }
    }
}
