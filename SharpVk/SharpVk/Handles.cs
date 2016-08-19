//The MIT License (MIT)
//
//Copyright (c) Andrew Armstrong/FacticiusVir 2016
//
//Permission is hereby granted, free of charge, to any person obtaining a copy
//of this software and associated documentation files (the "Software"), to deal
//in the Software without restriction, including without limitation the rights
//to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
//copies of the Software, and to permit persons to whom the Software is
//furnished to do so, subject to the following conditions:
//
//The above copyright notice and this permission notice shall be included in all
//copies or substantial portions of the Software.
//
//THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
//OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
//SOFTWARE.

using System;

namespace SharpVk
{
    /// <summary>
    /// Buffers represent linear arrays of data which are used for various
    /// purposes by binding them to a graphics or compute pipeline via descriptor
    /// sets or via certain commands, or by directly specifying them as parameters
    /// to certain commands.
    /// </summary>
	public class Buffer
		: IDisposable
	{
		internal readonly Interop.Buffer handle;

		private readonly Device parent;

		internal AllocationCallbacks? Allocator
		{
			get
			{
				return this.parent.Allocator;
			}
		}


		internal Buffer(Interop.Buffer handle, Device parent)
		{
			this.handle = handle;
			this.parent = parent;
		}

		public void BindMemory(DeviceMemory memory, DeviceSize memoryOffset)
		{
			unsafe
			{
				Result commandResult;

				Interop.DeviceMemory marshalledMemory = memory.Pack();
				commandResult = Interop.Commands.vkBindBufferMemory(this.parent.handle, this.handle, marshalledMemory, memoryOffset);

				if (SharpVkException.IsError(commandResult))
				{
					throw SharpVkException.Create(commandResult);
				}

				Interop.HeapUtil.FreeLog();

			}
		}

		public MemoryRequirements GetMemoryRequirements()
		{
			unsafe
			{
				MemoryRequirements result = default(MemoryRequirements);

				Interop.Commands.vkGetBufferMemoryRequirements(this.parent.handle, this.handle, &result);


				Interop.HeapUtil.FreeLog();


				return result;
			}
		}

		public void Destroy()
		{
			unsafe
			{
				Interop.AllocationCallbacks marshalledAllocator;
				if(this.parent.Allocator != null) marshalledAllocator = this.parent.Allocator.Value.Pack();
				Interop.Commands.vkDestroyBuffer(this.parent.handle, this.handle, this.parent.Allocator == null ? null : &marshalledAllocator);


				Interop.HeapUtil.FreeLog();

			}
		}

		internal Interop.Buffer Pack()
		{
			return this.handle;
		}

		public void Dispose()
		{
			this.Destroy();
		}
	}

    /// <summary>
    /// A _buffer view_ represents a contiguous range of a buffer and a specific
    /// format to be used to interpret the data. Buffer views are used to enable
    /// shaders to access buffer contents interpreted as formatted data. In order to
    /// create a valid buffer view, the buffer must: have been created with at least
    /// one of the following usage flags:
    ///   * ename:VK_BUFFER_USAGE_UNIFORM_TEXEL_BUFFER_BIT
    ///   * ename:VK_BUFFER_USAGE_STORAGE_TEXEL_BUFFER_BIT
    /// </summary>
	public class BufferView
		: IDisposable
	{
		internal readonly Interop.BufferView handle;

		private readonly Device parent;

		internal AllocationCallbacks? Allocator
		{
			get
			{
				return this.parent.Allocator;
			}
		}


		internal BufferView(Interop.BufferView handle, Device parent)
		{
			this.handle = handle;
			this.parent = parent;
		}

		public void Destroy()
		{
			unsafe
			{
				Interop.AllocationCallbacks marshalledAllocator;
				if(this.parent.Allocator != null) marshalledAllocator = this.parent.Allocator.Value.Pack();
				Interop.Commands.vkDestroyBufferView(this.parent.handle, this.handle, this.parent.Allocator == null ? null : &marshalledAllocator);


				Interop.HeapUtil.FreeLog();

			}
		}

		internal Interop.BufferView Pack()
		{
			return this.handle;
		}

		public void Dispose()
		{
			this.Destroy();
		}
	}

    /// <summary>
    /// Command buffers are objects used to record commands which can: be
    /// subsequently submitted to a device queue for execution. There are two levels
    /// of command buffers - _primary command buffers_, which can: execute secondary
    /// command buffers, and which are submitted to queues, and _secondary command
    /// buffers_, which can: be executed by primary command buffers, and which are
    /// not directly submitted to queues.
    /// </summary>
	public class CommandBuffer
	{
		internal readonly Interop.CommandBuffer handle;

		private readonly CommandPool parent;

		internal AllocationCallbacks? Allocator
		{
			get
			{
				return this.parent.Allocator;
			}
		}


		internal CommandBuffer(Interop.CommandBuffer handle, CommandPool parent)
		{
			this.handle = handle;
			this.parent = parent;
		}

		public void Begin(CommandBufferBeginInfo beginInfo)
		{
			unsafe
			{
				Result commandResult;

				Interop.CommandBufferBeginInfo marshalledBeginInfo;
				marshalledBeginInfo = beginInfo.Pack();
				commandResult = Interop.Commands.vkBeginCommandBuffer(this.handle, &marshalledBeginInfo);

				if (SharpVkException.IsError(commandResult))
				{
					throw SharpVkException.Create(commandResult);
				}

				Interop.HeapUtil.FreeLog();

			}
		}

		public void End()
		{
			unsafe
			{
				Result commandResult;

				commandResult = Interop.Commands.vkEndCommandBuffer(this.handle);

				if (SharpVkException.IsError(commandResult))
				{
					throw SharpVkException.Create(commandResult);
				}

				Interop.HeapUtil.FreeLog();

			}
		}

		public void Reset(CommandBufferResetFlags flags)
		{
			unsafe
			{
				Result commandResult;

				commandResult = Interop.Commands.vkResetCommandBuffer(this.handle, flags);

				if (SharpVkException.IsError(commandResult))
				{
					throw SharpVkException.Create(commandResult);
				}

				Interop.HeapUtil.FreeLog();

			}
		}

		public void BindPipeline(PipelineBindPoint pipelineBindPoint, Pipeline pipeline)
		{
			unsafe
			{
				Interop.Pipeline marshalledPipeline = pipeline.Pack();
				Interop.Commands.vkCmdBindPipeline(this.handle, pipelineBindPoint, marshalledPipeline);


				Interop.HeapUtil.FreeLog();

			}
		}

		public void SetViewport(uint firstViewport, Viewport[] viewports)
		{
			unsafe
			{
				fixed(Viewport* marshalledViewports = viewports)
				Interop.Commands.vkCmdSetViewport(this.handle, firstViewport, (uint)viewports.Length, marshalledViewports);


				Interop.HeapUtil.FreeLog();

			}
		}

		public void SetScissor(uint firstScissor, Rect2D[] scissors)
		{
			unsafe
			{
				fixed(Rect2D* marshalledScissors = scissors)
				Interop.Commands.vkCmdSetScissor(this.handle, firstScissor, (uint)scissors.Length, marshalledScissors);


				Interop.HeapUtil.FreeLog();

			}
		}

		public void SetLineWidth(float lineWidth)
		{
			unsafe
			{
				Interop.Commands.vkCmdSetLineWidth(this.handle, lineWidth);


				Interop.HeapUtil.FreeLog();

			}
		}

		public void SetDepthBias(float depthBiasConstantFactor, float depthBiasClamp, float depthBiasSlopeFactor)
		{
			unsafe
			{
				Interop.Commands.vkCmdSetDepthBias(this.handle, depthBiasConstantFactor, depthBiasClamp, depthBiasSlopeFactor);


				Interop.HeapUtil.FreeLog();

			}
		}

		public void SetBlendConstants(float blendConstants)
		{
			unsafe
			{
				Interop.Commands.vkCmdSetBlendConstants(this.handle, blendConstants);


				Interop.HeapUtil.FreeLog();

			}
		}

		public void SetDepthBounds(float minDepthBounds, float maxDepthBounds)
		{
			unsafe
			{
				Interop.Commands.vkCmdSetDepthBounds(this.handle, minDepthBounds, maxDepthBounds);


				Interop.HeapUtil.FreeLog();

			}
		}

		public void SetStencilCompareMask(StencilFaceFlags faceMask, uint compareMask)
		{
			unsafe
			{
				Interop.Commands.vkCmdSetStencilCompareMask(this.handle, faceMask, compareMask);


				Interop.HeapUtil.FreeLog();

			}
		}

		public void SetStencilWriteMask(StencilFaceFlags faceMask, uint writeMask)
		{
			unsafe
			{
				Interop.Commands.vkCmdSetStencilWriteMask(this.handle, faceMask, writeMask);


				Interop.HeapUtil.FreeLog();

			}
		}

		public void SetStencilReference(StencilFaceFlags faceMask, uint reference)
		{
			unsafe
			{
				Interop.Commands.vkCmdSetStencilReference(this.handle, faceMask, reference);


				Interop.HeapUtil.FreeLog();

			}
		}

		public void BindDescriptorSets(PipelineBindPoint pipelineBindPoint, PipelineLayout layout, uint firstSet, DescriptorSet[] descriptorSets, uint[] dynamicOffsets)
		{
			unsafe
			{
				Interop.PipelineLayout marshalledLayout = layout.Pack();
				Interop.DescriptorSet* marshalledDescriptorSets;
				if (descriptorSets != null)
				{
				    marshalledDescriptorSets = (Interop.DescriptorSet*)Interop.HeapUtil.Allocate<Interop.DescriptorSet>(descriptorSets.Length);
				    for (int index = 0; index < descriptorSets.Length; index++)
				    {
				        marshalledDescriptorSets[index] = descriptorSets[index].Pack();
				    }
				}
				else
				{
				    marshalledDescriptorSets = null;
				}
				fixed(uint* marshalledDynamicOffsets = dynamicOffsets)
				Interop.Commands.vkCmdBindDescriptorSets(this.handle, pipelineBindPoint, marshalledLayout, firstSet, (uint)descriptorSets.Length, marshalledDescriptorSets, (uint)dynamicOffsets.Length, marshalledDynamicOffsets);


				Interop.HeapUtil.FreeLog();

			}
		}

		public void BindIndexBuffer(Buffer buffer, DeviceSize offset, IndexType indexType)
		{
			unsafe
			{
				Interop.Buffer marshalledBuffer = buffer.Pack();
				Interop.Commands.vkCmdBindIndexBuffer(this.handle, marshalledBuffer, offset, indexType);


				Interop.HeapUtil.FreeLog();

			}
		}

		public void BindVertexBuffers(uint firstBinding, Buffer[] buffers, DeviceSize[] offsets)
		{
			unsafe
			{
				Interop.Buffer* marshalledBuffers;
				if (buffers != null)
				{
				    marshalledBuffers = (Interop.Buffer*)Interop.HeapUtil.Allocate<Interop.Buffer>(buffers.Length);
				    for (int index = 0; index < buffers.Length; index++)
				    {
				        marshalledBuffers[index] = buffers[index].Pack();
				    }
				}
				else
				{
				    marshalledBuffers = null;
				}
				fixed(DeviceSize* marshalledOffsets = offsets)
				Interop.Commands.vkCmdBindVertexBuffers(this.handle, firstBinding, (uint)offsets.Length, marshalledBuffers, marshalledOffsets);


				Interop.HeapUtil.FreeLog();

			}
		}

		public void Draw(uint vertexCount, uint instanceCount, uint firstVertex, uint firstInstance)
		{
			unsafe
			{
				Interop.Commands.vkCmdDraw(this.handle, vertexCount, instanceCount, firstVertex, firstInstance);


				Interop.HeapUtil.FreeLog();

			}
		}

		public void DrawIndexed(uint indexCount, uint instanceCount, uint firstIndex, int vertexOffset, uint firstInstance)
		{
			unsafe
			{
				Interop.Commands.vkCmdDrawIndexed(this.handle, indexCount, instanceCount, firstIndex, vertexOffset, firstInstance);


				Interop.HeapUtil.FreeLog();

			}
		}

		public void DrawIndirect(Buffer buffer, DeviceSize offset, uint drawCount, uint stride)
		{
			unsafe
			{
				Interop.Buffer marshalledBuffer = buffer.Pack();
				Interop.Commands.vkCmdDrawIndirect(this.handle, marshalledBuffer, offset, drawCount, stride);


				Interop.HeapUtil.FreeLog();

			}
		}

		public void DrawIndexedIndirect(Buffer buffer, DeviceSize offset, uint drawCount, uint stride)
		{
			unsafe
			{
				Interop.Buffer marshalledBuffer = buffer.Pack();
				Interop.Commands.vkCmdDrawIndexedIndirect(this.handle, marshalledBuffer, offset, drawCount, stride);


				Interop.HeapUtil.FreeLog();

			}
		}

		public void Dispatch(uint x, uint y, uint z)
		{
			unsafe
			{
				Interop.Commands.vkCmdDispatch(this.handle, x, y, z);


				Interop.HeapUtil.FreeLog();

			}
		}

		public void DispatchIndirect(Buffer buffer, DeviceSize offset)
		{
			unsafe
			{
				Interop.Buffer marshalledBuffer = buffer.Pack();
				Interop.Commands.vkCmdDispatchIndirect(this.handle, marshalledBuffer, offset);


				Interop.HeapUtil.FreeLog();

			}
		}

		public void CopyBuffer(Buffer sourceBuffer, Buffer destinationBuffer, BufferCopy[] regions)
		{
			unsafe
			{
				Interop.Buffer marshalledSourceBuffer = sourceBuffer.Pack();
				Interop.Buffer marshalledDestinationBuffer = destinationBuffer.Pack();
				fixed(BufferCopy* marshalledRegions = regions)
				Interop.Commands.vkCmdCopyBuffer(this.handle, marshalledSourceBuffer, marshalledDestinationBuffer, (uint)regions.Length, marshalledRegions);


				Interop.HeapUtil.FreeLog();

			}
		}

		public void CopyImage(Image sourceImage, ImageLayout sourceImageLayout, Image destinationImage, ImageLayout destinationImageLayout, ImageCopy[] regions)
		{
			unsafe
			{
				Interop.Image marshalledSourceImage = sourceImage.Pack();
				Interop.Image marshalledDestinationImage = destinationImage.Pack();
				fixed(ImageCopy* marshalledRegions = regions)
				Interop.Commands.vkCmdCopyImage(this.handle, marshalledSourceImage, sourceImageLayout, marshalledDestinationImage, destinationImageLayout, (uint)regions.Length, marshalledRegions);


				Interop.HeapUtil.FreeLog();

			}
		}

		public void BlitImage(Image sourceImage, ImageLayout sourceImageLayout, Image destinationImage, ImageLayout destinationImageLayout, ImageBlit[] regions, Filter filter)
		{
			unsafe
			{
				Interop.Image marshalledSourceImage = sourceImage.Pack();
				Interop.Image marshalledDestinationImage = destinationImage.Pack();
				Interop.ImageBlit* marshalledRegions;
				if (regions != null)
				{
				    marshalledRegions = (Interop.ImageBlit*)Interop.HeapUtil.Allocate<Interop.ImageBlit>(regions.Length);
				    for (int index = 0; index < regions.Length; index++)
				    {
				        marshalledRegions[index] = regions[index].Pack();
				    }
				}
				else
				{
				    marshalledRegions = null;
				}
				Interop.Commands.vkCmdBlitImage(this.handle, marshalledSourceImage, sourceImageLayout, marshalledDestinationImage, destinationImageLayout, (uint)regions.Length, marshalledRegions, filter);


				Interop.HeapUtil.FreeLog();

			}
		}

		public void CopyBufferToImage(Buffer sourceBuffer, Image destinationImage, ImageLayout destinationImageLayout, BufferImageCopy[] regions)
		{
			unsafe
			{
				Interop.Buffer marshalledSourceBuffer = sourceBuffer.Pack();
				Interop.Image marshalledDestinationImage = destinationImage.Pack();
				fixed(BufferImageCopy* marshalledRegions = regions)
				Interop.Commands.vkCmdCopyBufferToImage(this.handle, marshalledSourceBuffer, marshalledDestinationImage, destinationImageLayout, (uint)regions.Length, marshalledRegions);


				Interop.HeapUtil.FreeLog();

			}
		}

		public void CopyImageToBuffer(Image sourceImage, ImageLayout sourceImageLayout, Buffer destinationBuffer, BufferImageCopy[] regions)
		{
			unsafe
			{
				Interop.Image marshalledSourceImage = sourceImage.Pack();
				Interop.Buffer marshalledDestinationBuffer = destinationBuffer.Pack();
				fixed(BufferImageCopy* marshalledRegions = regions)
				Interop.Commands.vkCmdCopyImageToBuffer(this.handle, marshalledSourceImage, sourceImageLayout, marshalledDestinationBuffer, (uint)regions.Length, marshalledRegions);


				Interop.HeapUtil.FreeLog();

			}
		}

		public void UpdateBuffer(Buffer destinationBuffer, DeviceSize destinationOffset, byte[] data)
		{
			unsafe
			{
				Interop.Buffer marshalledDestinationBuffer = destinationBuffer.Pack();
				fixed(byte* marshalledData = data)
				Interop.Commands.vkCmdUpdateBuffer(this.handle, marshalledDestinationBuffer, destinationOffset, (DeviceSize)data.Length, marshalledData);


				Interop.HeapUtil.FreeLog();

			}
		}

		public void FillBuffer(Buffer destinationBuffer, DeviceSize destinationOffset, DeviceSize size, uint data)
		{
			unsafe
			{
				Interop.Buffer marshalledDestinationBuffer = destinationBuffer.Pack();
				Interop.Commands.vkCmdFillBuffer(this.handle, marshalledDestinationBuffer, destinationOffset, size, data);


				Interop.HeapUtil.FreeLog();

			}
		}

		public void ClearColorImage(Image image, ImageLayout imageLayout, ClearColorValue color, ImageSubresourceRange[] ranges)
		{
			unsafe
			{
				Interop.Image marshalledImage = image.Pack();
				fixed(ImageSubresourceRange* marshalledRanges = ranges)
				Interop.Commands.vkCmdClearColorImage(this.handle, marshalledImage, imageLayout, &color, (uint)ranges.Length, marshalledRanges);


				Interop.HeapUtil.FreeLog();

			}
		}

		public void ClearDepthStencilImage(Image image, ImageLayout imageLayout, ClearDepthStencilValue depthStencil, ImageSubresourceRange[] ranges)
		{
			unsafe
			{
				Interop.Image marshalledImage = image.Pack();
				fixed(ImageSubresourceRange* marshalledRanges = ranges)
				Interop.Commands.vkCmdClearDepthStencilImage(this.handle, marshalledImage, imageLayout, &depthStencil, (uint)ranges.Length, marshalledRanges);


				Interop.HeapUtil.FreeLog();

			}
		}

		public void ClearAttachments(ClearAttachment[] attachments, ClearRect[] rects)
		{
			unsafe
			{
				fixed(ClearAttachment* marshalledAttachments = attachments)
				fixed(ClearRect* marshalledRects = rects)
				Interop.Commands.vkCmdClearAttachments(this.handle, (uint)attachments.Length, marshalledAttachments, (uint)rects.Length, marshalledRects);


				Interop.HeapUtil.FreeLog();

			}
		}

		public void ResolveImage(Image sourceImage, ImageLayout sourceImageLayout, Image destinationImage, ImageLayout destinationImageLayout, ImageResolve[] regions)
		{
			unsafe
			{
				Interop.Image marshalledSourceImage = sourceImage.Pack();
				Interop.Image marshalledDestinationImage = destinationImage.Pack();
				fixed(ImageResolve* marshalledRegions = regions)
				Interop.Commands.vkCmdResolveImage(this.handle, marshalledSourceImage, sourceImageLayout, marshalledDestinationImage, destinationImageLayout, (uint)regions.Length, marshalledRegions);


				Interop.HeapUtil.FreeLog();

			}
		}

		public void SetEvent(Event @event, PipelineStageFlags stageMask)
		{
			unsafe
			{
				Interop.Event marshalledEvent = @event.Pack();
				Interop.Commands.vkCmdSetEvent(this.handle, marshalledEvent, stageMask);


				Interop.HeapUtil.FreeLog();

			}
		}

		public void ResetEvent(Event @event, PipelineStageFlags stageMask)
		{
			unsafe
			{
				Interop.Event marshalledEvent = @event.Pack();
				Interop.Commands.vkCmdResetEvent(this.handle, marshalledEvent, stageMask);


				Interop.HeapUtil.FreeLog();

			}
		}

		public void WaitEvents(Event[] events, PipelineStageFlags sourceStageMask, PipelineStageFlags destinationStageMask, MemoryBarrier[] memoryBarriers, BufferMemoryBarrier[] bufferMemoryBarriers, ImageMemoryBarrier[] imageMemoryBarriers)
		{
			unsafe
			{
				Interop.Event* marshalledEvents;
				if (events != null)
				{
				    marshalledEvents = (Interop.Event*)Interop.HeapUtil.Allocate<Interop.Event>(events.Length);
				    for (int index = 0; index < events.Length; index++)
				    {
				        marshalledEvents[index] = events[index].Pack();
				    }
				}
				else
				{
				    marshalledEvents = null;
				}
				Interop.MemoryBarrier* marshalledMemoryBarriers;
				if (memoryBarriers != null)
				{
				    marshalledMemoryBarriers = (Interop.MemoryBarrier*)Interop.HeapUtil.Allocate<Interop.MemoryBarrier>(memoryBarriers.Length);
				    for (int index = 0; index < memoryBarriers.Length; index++)
				    {
				        marshalledMemoryBarriers[index] = memoryBarriers[index].Pack();
				    }
				}
				else
				{
				    marshalledMemoryBarriers = null;
				}
				Interop.BufferMemoryBarrier* marshalledBufferMemoryBarriers;
				if (bufferMemoryBarriers != null)
				{
				    marshalledBufferMemoryBarriers = (Interop.BufferMemoryBarrier*)Interop.HeapUtil.Allocate<Interop.BufferMemoryBarrier>(bufferMemoryBarriers.Length);
				    for (int index = 0; index < bufferMemoryBarriers.Length; index++)
				    {
				        marshalledBufferMemoryBarriers[index] = bufferMemoryBarriers[index].Pack();
				    }
				}
				else
				{
				    marshalledBufferMemoryBarriers = null;
				}
				Interop.ImageMemoryBarrier* marshalledImageMemoryBarriers;
				if (imageMemoryBarriers != null)
				{
				    marshalledImageMemoryBarriers = (Interop.ImageMemoryBarrier*)Interop.HeapUtil.Allocate<Interop.ImageMemoryBarrier>(imageMemoryBarriers.Length);
				    for (int index = 0; index < imageMemoryBarriers.Length; index++)
				    {
				        marshalledImageMemoryBarriers[index] = imageMemoryBarriers[index].Pack();
				    }
				}
				else
				{
				    marshalledImageMemoryBarriers = null;
				}
				Interop.Commands.vkCmdWaitEvents(this.handle, (uint)events.Length, marshalledEvents, sourceStageMask, destinationStageMask, (uint)memoryBarriers.Length, marshalledMemoryBarriers, (uint)bufferMemoryBarriers.Length, marshalledBufferMemoryBarriers, (uint)imageMemoryBarriers.Length, marshalledImageMemoryBarriers);


				Interop.HeapUtil.FreeLog();

			}
		}

		public void PipelineBarrier(PipelineStageFlags sourceStageMask, PipelineStageFlags destinationStageMask, DependencyFlags dependencyFlags, MemoryBarrier[] memoryBarriers, BufferMemoryBarrier[] bufferMemoryBarriers, ImageMemoryBarrier[] imageMemoryBarriers)
		{
			unsafe
			{
				Interop.MemoryBarrier* marshalledMemoryBarriers;
				if (memoryBarriers != null)
				{
				    marshalledMemoryBarriers = (Interop.MemoryBarrier*)Interop.HeapUtil.Allocate<Interop.MemoryBarrier>(memoryBarriers.Length);
				    for (int index = 0; index < memoryBarriers.Length; index++)
				    {
				        marshalledMemoryBarriers[index] = memoryBarriers[index].Pack();
				    }
				}
				else
				{
				    marshalledMemoryBarriers = null;
				}
				Interop.BufferMemoryBarrier* marshalledBufferMemoryBarriers;
				if (bufferMemoryBarriers != null)
				{
				    marshalledBufferMemoryBarriers = (Interop.BufferMemoryBarrier*)Interop.HeapUtil.Allocate<Interop.BufferMemoryBarrier>(bufferMemoryBarriers.Length);
				    for (int index = 0; index < bufferMemoryBarriers.Length; index++)
				    {
				        marshalledBufferMemoryBarriers[index] = bufferMemoryBarriers[index].Pack();
				    }
				}
				else
				{
				    marshalledBufferMemoryBarriers = null;
				}
				Interop.ImageMemoryBarrier* marshalledImageMemoryBarriers;
				if (imageMemoryBarriers != null)
				{
				    marshalledImageMemoryBarriers = (Interop.ImageMemoryBarrier*)Interop.HeapUtil.Allocate<Interop.ImageMemoryBarrier>(imageMemoryBarriers.Length);
				    for (int index = 0; index < imageMemoryBarriers.Length; index++)
				    {
				        marshalledImageMemoryBarriers[index] = imageMemoryBarriers[index].Pack();
				    }
				}
				else
				{
				    marshalledImageMemoryBarriers = null;
				}
				Interop.Commands.vkCmdPipelineBarrier(this.handle, sourceStageMask, destinationStageMask, dependencyFlags, (uint)memoryBarriers.Length, marshalledMemoryBarriers, (uint)bufferMemoryBarriers.Length, marshalledBufferMemoryBarriers, (uint)imageMemoryBarriers.Length, marshalledImageMemoryBarriers);


				Interop.HeapUtil.FreeLog();

			}
		}

		public void BeginQuery(QueryPool queryPool, uint query, QueryControlFlags flags)
		{
			unsafe
			{
				Interop.QueryPool marshalledQueryPool = queryPool.Pack();
				Interop.Commands.vkCmdBeginQuery(this.handle, marshalledQueryPool, query, flags);


				Interop.HeapUtil.FreeLog();

			}
		}

		public void EndQuery(QueryPool queryPool, uint query)
		{
			unsafe
			{
				Interop.QueryPool marshalledQueryPool = queryPool.Pack();
				Interop.Commands.vkCmdEndQuery(this.handle, marshalledQueryPool, query);


				Interop.HeapUtil.FreeLog();

			}
		}

		public void ResetQueryPool(QueryPool queryPool, uint firstQuery, uint queryCount)
		{
			unsafe
			{
				Interop.QueryPool marshalledQueryPool = queryPool.Pack();
				Interop.Commands.vkCmdResetQueryPool(this.handle, marshalledQueryPool, firstQuery, queryCount);


				Interop.HeapUtil.FreeLog();

			}
		}

		public void WriteTimestamp(PipelineStageFlags pipelineStage, QueryPool queryPool, uint query)
		{
			unsafe
			{
				Interop.QueryPool marshalledQueryPool = queryPool.Pack();
				Interop.Commands.vkCmdWriteTimestamp(this.handle, pipelineStage, marshalledQueryPool, query);


				Interop.HeapUtil.FreeLog();

			}
		}

		public void CopyQueryPoolResults(QueryPool queryPool, uint firstQuery, uint queryCount, Buffer destinationBuffer, DeviceSize destinationOffset, DeviceSize stride, QueryResultFlags flags)
		{
			unsafe
			{
				Interop.QueryPool marshalledQueryPool = queryPool.Pack();
				Interop.Buffer marshalledDestinationBuffer = destinationBuffer.Pack();
				Interop.Commands.vkCmdCopyQueryPoolResults(this.handle, marshalledQueryPool, firstQuery, queryCount, marshalledDestinationBuffer, destinationOffset, stride, flags);


				Interop.HeapUtil.FreeLog();

			}
		}

		public void PushConstants(PipelineLayout layout, ShaderStageFlags stageFlags, uint offset, byte[] values)
		{
			unsafe
			{
				Interop.PipelineLayout marshalledLayout = layout.Pack();
				fixed(byte* marshalledValues = values)
				Interop.Commands.vkCmdPushConstants(this.handle, marshalledLayout, stageFlags, offset, (uint)values.Length, marshalledValues);


				Interop.HeapUtil.FreeLog();

			}
		}

		public void BeginRenderPass(RenderPassBeginInfo renderPassBegin, SubpassContents contents)
		{
			unsafe
			{
				Interop.RenderPassBeginInfo marshalledRenderPassBegin;
				marshalledRenderPassBegin = renderPassBegin.Pack();
				Interop.Commands.vkCmdBeginRenderPass(this.handle, &marshalledRenderPassBegin, contents);


				Interop.HeapUtil.FreeLog();

			}
		}

		public void NextSubpass(SubpassContents contents)
		{
			unsafe
			{
				Interop.Commands.vkCmdNextSubpass(this.handle, contents);


				Interop.HeapUtil.FreeLog();

			}
		}

		public void EndRenderPass()
		{
			unsafe
			{
				Interop.Commands.vkCmdEndRenderPass(this.handle);


				Interop.HeapUtil.FreeLog();

			}
		}

		public void ExecuteCommands(CommandBuffer[] commandBuffers)
		{
			unsafe
			{
				Interop.CommandBuffer* marshalledCommandBuffers;
				if (commandBuffers != null)
				{
				    marshalledCommandBuffers = (Interop.CommandBuffer*)Interop.HeapUtil.Allocate<Interop.CommandBuffer>(commandBuffers.Length);
				    for (int index = 0; index < commandBuffers.Length; index++)
				    {
				        marshalledCommandBuffers[index] = commandBuffers[index].Pack();
				    }
				}
				else
				{
				    marshalledCommandBuffers = null;
				}
				Interop.Commands.vkCmdExecuteCommands(this.handle, (uint)commandBuffers.Length, marshalledCommandBuffers);


				Interop.HeapUtil.FreeLog();

			}
		}

		public void DebugMarkerBegin(DebugMarkerMarkerInfo markerInfo)
		{
			unsafe
			{
				Interop.DebugMarkerMarkerInfo marshalledMarkerInfo;
				marshalledMarkerInfo = markerInfo.Pack();
				Interop.Commands.vkCmdDebugMarkerBeginEXT(this.handle, &marshalledMarkerInfo);


				Interop.HeapUtil.FreeLog();

			}
		}

		public void DebugMarkerEnd()
		{
			unsafe
			{
				Interop.Commands.vkCmdDebugMarkerEndEXT(this.handle);


				Interop.HeapUtil.FreeLog();

			}
		}

		public void DebugMarkerInsert(DebugMarkerMarkerInfo markerInfo)
		{
			unsafe
			{
				Interop.DebugMarkerMarkerInfo marshalledMarkerInfo;
				marshalledMarkerInfo = markerInfo.Pack();
				Interop.Commands.vkCmdDebugMarkerInsertEXT(this.handle, &marshalledMarkerInfo);


				Interop.HeapUtil.FreeLog();

			}
		}

		internal Interop.CommandBuffer Pack()
		{
			return this.handle;
		}
	}

    /// <summary>
    /// Command pools are opaque objects that command buffer memory is allocated
    /// from, and which allow the implementation to amortize the cost of resource
    /// creation across multiple command buffers. Command pools are
    /// application-synchronized, meaning that a command pool mustnot: be used
    /// concurrently in multiple threads. That includes use via recording commands
    /// on any command buffers allocated from the pool, as well as operations that
    /// allocate, free, and reset command buffers or the pool itself.
    /// </summary>
	public class CommandPool
		: IDisposable
	{
		internal readonly Interop.CommandPool handle;

		private readonly Device parent;

		internal AllocationCallbacks? Allocator
		{
			get
			{
				return this.parent.Allocator;
			}
		}


		internal CommandPool(Interop.CommandPool handle, Device parent)
		{
			this.handle = handle;
			this.parent = parent;
		}

		public void Destroy()
		{
			unsafe
			{
				Interop.AllocationCallbacks marshalledAllocator;
				if(this.parent.Allocator != null) marshalledAllocator = this.parent.Allocator.Value.Pack();
				Interop.Commands.vkDestroyCommandPool(this.parent.handle, this.handle, this.parent.Allocator == null ? null : &marshalledAllocator);


				Interop.HeapUtil.FreeLog();

			}
		}

		public void Reset(CommandPoolResetFlags flags)
		{
			unsafe
			{
				Result commandResult;

				commandResult = Interop.Commands.vkResetCommandPool(this.parent.handle, this.handle, flags);

				if (SharpVkException.IsError(commandResult))
				{
					throw SharpVkException.Create(commandResult);
				}

				Interop.HeapUtil.FreeLog();

			}
		}

		public void FreeCommandBuffers(CommandBuffer[] commandBuffers)
		{
			unsafe
			{
				Interop.CommandBuffer* marshalledCommandBuffers;
				if (commandBuffers != null)
				{
				    marshalledCommandBuffers = (Interop.CommandBuffer*)Interop.HeapUtil.Allocate<Interop.CommandBuffer>(commandBuffers.Length);
				    for (int index = 0; index < commandBuffers.Length; index++)
				    {
				        marshalledCommandBuffers[index] = commandBuffers[index].Pack();
				    }
				}
				else
				{
				    marshalledCommandBuffers = null;
				}
				Interop.Commands.vkFreeCommandBuffers(this.parent.handle, this.handle, (uint)commandBuffers.Length, marshalledCommandBuffers);


				Interop.HeapUtil.FreeLog();

			}
		}

		internal Interop.CommandPool Pack()
		{
			return this.handle;
		}

		public void Dispose()
		{
			this.Destroy();
		}
	}

    /// <summary>
    /// 
    /// </summary>
	public class DebugReportCallback
		: IDisposable
	{
		internal readonly Interop.DebugReportCallback handle;

		private readonly Instance parent;

		internal AllocationCallbacks? Allocator
		{
			get
			{
				return this.parent.Allocator;
			}
		}


		internal DebugReportCallback(Interop.DebugReportCallback handle, Instance parent)
		{
			this.handle = handle;
			this.parent = parent;
		}

		public void Destroy()
		{
			unsafe
			{
				Interop.AllocationCallbacks marshalledAllocator;
				if(this.parent.Allocator != null) marshalledAllocator = this.parent.Allocator.Value.Pack();
				Interop.Commands.vkDestroyDebugReportCallbackEXT(this.parent.handle, this.handle, this.parent.Allocator == null ? null : &marshalledAllocator);


				Interop.HeapUtil.FreeLog();

			}
		}

		internal Interop.DebugReportCallback Pack()
		{
			return this.handle;
		}

		public void Dispose()
		{
			this.Destroy();
		}
	}

    /// <summary>
    /// A _descriptor pool_
    /// maintains a pool of descriptors, from which descriptor sets are allocated.
    /// Descriptor pools are externally synchronized, meaning that the application
    /// mustnot: allocate and/or free descriptor sets from the same pool in multiple
    /// threads simultaneously.
    /// </summary>
	public class DescriptorPool
		: IDisposable
	{
		internal readonly Interop.DescriptorPool handle;

		private readonly Device parent;

		internal AllocationCallbacks? Allocator
		{
			get
			{
				return this.parent.Allocator;
			}
		}


		internal DescriptorPool(Interop.DescriptorPool handle, Device parent)
		{
			this.handle = handle;
			this.parent = parent;
		}

		public void Destroy()
		{
			unsafe
			{
				Interop.AllocationCallbacks marshalledAllocator;
				if(this.parent.Allocator != null) marshalledAllocator = this.parent.Allocator.Value.Pack();
				Interop.Commands.vkDestroyDescriptorPool(this.parent.handle, this.handle, this.parent.Allocator == null ? null : &marshalledAllocator);


				Interop.HeapUtil.FreeLog();

			}
		}

		public void Reset(DescriptorPoolResetFlags flags)
		{
			unsafe
			{
				Result commandResult;

				commandResult = Interop.Commands.vkResetDescriptorPool(this.parent.handle, this.handle, flags);

				if (SharpVkException.IsError(commandResult))
				{
					throw SharpVkException.Create(commandResult);
				}

				Interop.HeapUtil.FreeLog();

			}
		}

		public void FreeDescriptorSets(DescriptorSet[] descriptorSets)
		{
			unsafe
			{
				Result commandResult;

				Interop.DescriptorSet* marshalledDescriptorSets;
				if (descriptorSets != null)
				{
				    marshalledDescriptorSets = (Interop.DescriptorSet*)Interop.HeapUtil.Allocate<Interop.DescriptorSet>(descriptorSets.Length);
				    for (int index = 0; index < descriptorSets.Length; index++)
				    {
				        marshalledDescriptorSets[index] = descriptorSets[index].Pack();
				    }
				}
				else
				{
				    marshalledDescriptorSets = null;
				}
				commandResult = Interop.Commands.vkFreeDescriptorSets(this.parent.handle, this.handle, (uint)descriptorSets.Length, marshalledDescriptorSets);

				if (SharpVkException.IsError(commandResult))
				{
					throw SharpVkException.Create(commandResult);
				}

				Interop.HeapUtil.FreeLog();

			}
		}

		internal Interop.DescriptorPool Pack()
		{
			return this.handle;
		}

		public void Dispose()
		{
			this.Destroy();
		}
	}

    /// <summary>
    /// 
    /// </summary>
	public class DescriptorSet
	{
		internal readonly Interop.DescriptorSet handle;

		private readonly DescriptorPool parent;

		internal AllocationCallbacks? Allocator
		{
			get
			{
				return this.parent.Allocator;
			}
		}


		internal DescriptorSet(Interop.DescriptorSet handle, DescriptorPool parent)
		{
			this.handle = handle;
			this.parent = parent;
		}

		internal Interop.DescriptorSet Pack()
		{
			return this.handle;
		}
	}

    /// <summary>
    /// A descriptor set layout object is defined by an array of zero or more
    /// descriptor bindings. Each individual descriptor binding is specified by a
    /// descriptor type, a count (array size) of the number of descriptors in the
    /// binding, a set of shader stages that can: access the binding, and (if using
    /// immutable samplers) an array of sampler descriptors.
    /// </summary>
	public class DescriptorSetLayout
		: IDisposable
	{
		internal readonly Interop.DescriptorSetLayout handle;

		private readonly Device parent;

		internal AllocationCallbacks? Allocator
		{
			get
			{
				return this.parent.Allocator;
			}
		}


		internal DescriptorSetLayout(Interop.DescriptorSetLayout handle, Device parent)
		{
			this.handle = handle;
			this.parent = parent;
		}

		public void Destroy()
		{
			unsafe
			{
				Interop.AllocationCallbacks marshalledAllocator;
				if(this.parent.Allocator != null) marshalledAllocator = this.parent.Allocator.Value.Pack();
				Interop.Commands.vkDestroyDescriptorSetLayout(this.parent.handle, this.handle, this.parent.Allocator == null ? null : &marshalledAllocator);


				Interop.HeapUtil.FreeLog();

			}
		}

		internal Interop.DescriptorSetLayout Pack()
		{
			return this.handle;
		}

		public void Dispose()
		{
			this.Destroy();
		}
	}

    /// <summary>
    /// 
    /// </summary>
	public class Device
		: IDisposable
	{
		internal readonly Interop.Device handle;

		private readonly PhysicalDevice parent;

		internal AllocationCallbacks? Allocator
		{
			get
			{
				return this.parent.Allocator;
			}
		}


		internal Device(Interop.Device handle, PhysicalDevice parent)
		{
			this.handle = handle;
			this.parent = parent;
		}

		public IntPtr GetProcAddr(string name)
		{
			unsafe
			{
				IntPtr result = default(IntPtr);

				char* marshalledName = Interop.HeapUtil.MarshalTo(name);
				result = Interop.Commands.vkGetDeviceProcAddr(this.handle, marshalledName);


				Interop.HeapUtil.FreeLog();


				return result;
			}
		}

		public void Destroy()
		{
			unsafe
			{
				Interop.AllocationCallbacks marshalledAllocator;
				if(this.parent.Allocator != null) marshalledAllocator = this.parent.Allocator.Value.Pack();
				Interop.Commands.vkDestroyDevice(this.handle, this.parent.Allocator == null ? null : &marshalledAllocator);


				Interop.HeapUtil.FreeLog();

			}
		}

		public Queue GetQueue(uint queueFamilyIndex, uint queueIndex)
		{
			unsafe
			{
				Queue result = default(Queue);

				Interop.Queue marshalledQueue;
				Interop.Commands.vkGetDeviceQueue(this.handle, queueFamilyIndex, queueIndex, &marshalledQueue);

				result = new Queue(marshalledQueue, this);

				Interop.HeapUtil.FreeLog();


				return result;
			}
		}

		public void WaitIdle()
		{
			unsafe
			{
				Result commandResult;

				commandResult = Interop.Commands.vkDeviceWaitIdle(this.handle);

				if (SharpVkException.IsError(commandResult))
				{
					throw SharpVkException.Create(commandResult);
				}

				Interop.HeapUtil.FreeLog();

			}
		}

		public DeviceMemory AllocateMemory(MemoryAllocateInfo allocateInfo)
		{
			unsafe
			{
				DeviceMemory result = default(DeviceMemory);

				Result commandResult;

				Interop.MemoryAllocateInfo marshalledAllocateInfo;
				marshalledAllocateInfo = allocateInfo.Pack();
				Interop.AllocationCallbacks marshalledAllocator;
				if(this.parent.Allocator != null) marshalledAllocator = this.parent.Allocator.Value.Pack();
				Interop.DeviceMemory marshalledMemory;
				commandResult = Interop.Commands.vkAllocateMemory(this.handle, &marshalledAllocateInfo, this.parent.Allocator == null ? null : &marshalledAllocator, &marshalledMemory);

				if (SharpVkException.IsError(commandResult))
				{
					throw SharpVkException.Create(commandResult);
				}
				result = new DeviceMemory(marshalledMemory, this);

				Interop.HeapUtil.FreeLog();


				return result;
			}
		}

		public void FreeMemory(DeviceMemory memory)
		{
			unsafe
			{
				Interop.DeviceMemory marshalledMemory = memory?.Pack() ?? Interop.DeviceMemory.Null;
				Interop.AllocationCallbacks marshalledAllocator;
				if(this.parent.Allocator != null) marshalledAllocator = this.parent.Allocator.Value.Pack();
				Interop.Commands.vkFreeMemory(this.handle, marshalledMemory, this.parent.Allocator == null ? null : &marshalledAllocator);


				Interop.HeapUtil.FreeLog();

			}
		}

		public void FlushMappedMemoryRanges(MappedMemoryRange[] memoryRanges)
		{
			unsafe
			{
				Result commandResult;

				Interop.MappedMemoryRange* marshalledMemoryRanges;
				if (memoryRanges != null)
				{
				    marshalledMemoryRanges = (Interop.MappedMemoryRange*)Interop.HeapUtil.Allocate<Interop.MappedMemoryRange>(memoryRanges.Length);
				    for (int index = 0; index < memoryRanges.Length; index++)
				    {
				        marshalledMemoryRanges[index] = memoryRanges[index].Pack();
				    }
				}
				else
				{
				    marshalledMemoryRanges = null;
				}
				commandResult = Interop.Commands.vkFlushMappedMemoryRanges(this.handle, (uint)memoryRanges.Length, marshalledMemoryRanges);

				if (SharpVkException.IsError(commandResult))
				{
					throw SharpVkException.Create(commandResult);
				}

				Interop.HeapUtil.FreeLog();

			}
		}

		public void InvalidateMappedMemoryRanges(MappedMemoryRange[] memoryRanges)
		{
			unsafe
			{
				Result commandResult;

				Interop.MappedMemoryRange* marshalledMemoryRanges;
				if (memoryRanges != null)
				{
				    marshalledMemoryRanges = (Interop.MappedMemoryRange*)Interop.HeapUtil.Allocate<Interop.MappedMemoryRange>(memoryRanges.Length);
				    for (int index = 0; index < memoryRanges.Length; index++)
				    {
				        marshalledMemoryRanges[index] = memoryRanges[index].Pack();
				    }
				}
				else
				{
				    marshalledMemoryRanges = null;
				}
				commandResult = Interop.Commands.vkInvalidateMappedMemoryRanges(this.handle, (uint)memoryRanges.Length, marshalledMemoryRanges);

				if (SharpVkException.IsError(commandResult))
				{
					throw SharpVkException.Create(commandResult);
				}

				Interop.HeapUtil.FreeLog();

			}
		}

		public Fence CreateFence(FenceCreateInfo createInfo)
		{
			unsafe
			{
				Fence result = default(Fence);

				Result commandResult;

				Interop.FenceCreateInfo marshalledCreateInfo;
				marshalledCreateInfo = createInfo.Pack();
				Interop.AllocationCallbacks marshalledAllocator;
				if(this.parent.Allocator != null) marshalledAllocator = this.parent.Allocator.Value.Pack();
				Interop.Fence marshalledFence;
				commandResult = Interop.Commands.vkCreateFence(this.handle, &marshalledCreateInfo, this.parent.Allocator == null ? null : &marshalledAllocator, &marshalledFence);

				if (SharpVkException.IsError(commandResult))
				{
					throw SharpVkException.Create(commandResult);
				}
				result = new Fence(marshalledFence, this);

				Interop.HeapUtil.FreeLog();


				return result;
			}
		}

		public void ResetFences(Fence[] fences)
		{
			unsafe
			{
				Result commandResult;

				Interop.Fence* marshalledFences;
				if (fences != null)
				{
				    marshalledFences = (Interop.Fence*)Interop.HeapUtil.Allocate<Interop.Fence>(fences.Length);
				    for (int index = 0; index < fences.Length; index++)
				    {
				        marshalledFences[index] = fences[index].Pack();
				    }
				}
				else
				{
				    marshalledFences = null;
				}
				commandResult = Interop.Commands.vkResetFences(this.handle, (uint)fences.Length, marshalledFences);

				if (SharpVkException.IsError(commandResult))
				{
					throw SharpVkException.Create(commandResult);
				}

				Interop.HeapUtil.FreeLog();

			}
		}

		public void WaitForFences(Fence[] fences, Bool32 waitAll, ulong timeout)
		{
			unsafe
			{
				Result commandResult;

				Interop.Fence* marshalledFences;
				if (fences != null)
				{
				    marshalledFences = (Interop.Fence*)Interop.HeapUtil.Allocate<Interop.Fence>(fences.Length);
				    for (int index = 0; index < fences.Length; index++)
				    {
				        marshalledFences[index] = fences[index].Pack();
				    }
				}
				else
				{
				    marshalledFences = null;
				}
				commandResult = Interop.Commands.vkWaitForFences(this.handle, (uint)fences.Length, marshalledFences, waitAll, timeout);

				if (SharpVkException.IsError(commandResult))
				{
					throw SharpVkException.Create(commandResult);
				}

				Interop.HeapUtil.FreeLog();

			}
		}

		public Semaphore CreateSemaphore(SemaphoreCreateInfo createInfo)
		{
			unsafe
			{
				Semaphore result = default(Semaphore);

				Result commandResult;

				Interop.SemaphoreCreateInfo marshalledCreateInfo;
				marshalledCreateInfo = createInfo.Pack();
				Interop.AllocationCallbacks marshalledAllocator;
				if(this.parent.Allocator != null) marshalledAllocator = this.parent.Allocator.Value.Pack();
				Interop.Semaphore marshalledSemaphore;
				commandResult = Interop.Commands.vkCreateSemaphore(this.handle, &marshalledCreateInfo, this.parent.Allocator == null ? null : &marshalledAllocator, &marshalledSemaphore);

				if (SharpVkException.IsError(commandResult))
				{
					throw SharpVkException.Create(commandResult);
				}
				result = new Semaphore(marshalledSemaphore, this);

				Interop.HeapUtil.FreeLog();


				return result;
			}
		}

		public Event CreateEvent(EventCreateInfo createInfo)
		{
			unsafe
			{
				Event result = default(Event);

				Result commandResult;

				Interop.EventCreateInfo marshalledCreateInfo;
				marshalledCreateInfo = createInfo.Pack();
				Interop.AllocationCallbacks marshalledAllocator;
				if(this.parent.Allocator != null) marshalledAllocator = this.parent.Allocator.Value.Pack();
				Interop.Event marshalledEvent;
				commandResult = Interop.Commands.vkCreateEvent(this.handle, &marshalledCreateInfo, this.parent.Allocator == null ? null : &marshalledAllocator, &marshalledEvent);

				if (SharpVkException.IsError(commandResult))
				{
					throw SharpVkException.Create(commandResult);
				}
				result = new Event(marshalledEvent, this);

				Interop.HeapUtil.FreeLog();


				return result;
			}
		}

		public QueryPool CreateQueryPool(QueryPoolCreateInfo createInfo)
		{
			unsafe
			{
				QueryPool result = default(QueryPool);

				Result commandResult;

				Interop.QueryPoolCreateInfo marshalledCreateInfo;
				marshalledCreateInfo = createInfo.Pack();
				Interop.AllocationCallbacks marshalledAllocator;
				if(this.parent.Allocator != null) marshalledAllocator = this.parent.Allocator.Value.Pack();
				Interop.QueryPool marshalledQueryPool;
				commandResult = Interop.Commands.vkCreateQueryPool(this.handle, &marshalledCreateInfo, this.parent.Allocator == null ? null : &marshalledAllocator, &marshalledQueryPool);

				if (SharpVkException.IsError(commandResult))
				{
					throw SharpVkException.Create(commandResult);
				}
				result = new QueryPool(marshalledQueryPool, this);

				Interop.HeapUtil.FreeLog();


				return result;
			}
		}

		public Buffer CreateBuffer(BufferCreateInfo createInfo)
		{
			unsafe
			{
				Buffer result = default(Buffer);

				Result commandResult;

				Interop.BufferCreateInfo marshalledCreateInfo;
				marshalledCreateInfo = createInfo.Pack();
				Interop.AllocationCallbacks marshalledAllocator;
				if(this.parent.Allocator != null) marshalledAllocator = this.parent.Allocator.Value.Pack();
				Interop.Buffer marshalledBuffer;
				commandResult = Interop.Commands.vkCreateBuffer(this.handle, &marshalledCreateInfo, this.parent.Allocator == null ? null : &marshalledAllocator, &marshalledBuffer);

				if (SharpVkException.IsError(commandResult))
				{
					throw SharpVkException.Create(commandResult);
				}
				result = new Buffer(marshalledBuffer, this);

				Interop.HeapUtil.FreeLog();


				return result;
			}
		}

		public BufferView CreateBufferView(BufferViewCreateInfo createInfo)
		{
			unsafe
			{
				BufferView result = default(BufferView);

				Result commandResult;

				Interop.BufferViewCreateInfo marshalledCreateInfo;
				marshalledCreateInfo = createInfo.Pack();
				Interop.AllocationCallbacks marshalledAllocator;
				if(this.parent.Allocator != null) marshalledAllocator = this.parent.Allocator.Value.Pack();
				Interop.BufferView marshalledView;
				commandResult = Interop.Commands.vkCreateBufferView(this.handle, &marshalledCreateInfo, this.parent.Allocator == null ? null : &marshalledAllocator, &marshalledView);

				if (SharpVkException.IsError(commandResult))
				{
					throw SharpVkException.Create(commandResult);
				}
				result = new BufferView(marshalledView, this);

				Interop.HeapUtil.FreeLog();


				return result;
			}
		}

		public Image CreateImage(ImageCreateInfo createInfo)
		{
			unsafe
			{
				Image result = default(Image);

				Result commandResult;

				Interop.ImageCreateInfo marshalledCreateInfo;
				marshalledCreateInfo = createInfo.Pack();
				Interop.AllocationCallbacks marshalledAllocator;
				if(this.parent.Allocator != null) marshalledAllocator = this.parent.Allocator.Value.Pack();
				Interop.Image marshalledImage;
				commandResult = Interop.Commands.vkCreateImage(this.handle, &marshalledCreateInfo, this.parent.Allocator == null ? null : &marshalledAllocator, &marshalledImage);

				if (SharpVkException.IsError(commandResult))
				{
					throw SharpVkException.Create(commandResult);
				}
				result = new Image(marshalledImage, this);

				Interop.HeapUtil.FreeLog();


				return result;
			}
		}

		public ImageView CreateImageView(ImageViewCreateInfo createInfo)
		{
			unsafe
			{
				ImageView result = default(ImageView);

				Result commandResult;

				Interop.ImageViewCreateInfo marshalledCreateInfo;
				marshalledCreateInfo = createInfo.Pack();
				Interop.AllocationCallbacks marshalledAllocator;
				if(this.parent.Allocator != null) marshalledAllocator = this.parent.Allocator.Value.Pack();
				Interop.ImageView marshalledView;
				commandResult = Interop.Commands.vkCreateImageView(this.handle, &marshalledCreateInfo, this.parent.Allocator == null ? null : &marshalledAllocator, &marshalledView);

				if (SharpVkException.IsError(commandResult))
				{
					throw SharpVkException.Create(commandResult);
				}
				result = new ImageView(marshalledView, this);

				Interop.HeapUtil.FreeLog();


				return result;
			}
		}

		public ShaderModule CreateShaderModule(ShaderModuleCreateInfo createInfo)
		{
			unsafe
			{
				ShaderModule result = default(ShaderModule);

				Result commandResult;

				Interop.ShaderModuleCreateInfo marshalledCreateInfo;
				marshalledCreateInfo = createInfo.Pack();
				Interop.AllocationCallbacks marshalledAllocator;
				if(this.parent.Allocator != null) marshalledAllocator = this.parent.Allocator.Value.Pack();
				Interop.ShaderModule marshalledShaderModule;
				commandResult = Interop.Commands.vkCreateShaderModule(this.handle, &marshalledCreateInfo, this.parent.Allocator == null ? null : &marshalledAllocator, &marshalledShaderModule);

				if (SharpVkException.IsError(commandResult))
				{
					throw SharpVkException.Create(commandResult);
				}
				result = new ShaderModule(marshalledShaderModule, this);

				Interop.HeapUtil.FreeLog();


				return result;
			}
		}

		public PipelineCache CreatePipelineCache(PipelineCacheCreateInfo createInfo)
		{
			unsafe
			{
				PipelineCache result = default(PipelineCache);

				Result commandResult;

				Interop.PipelineCacheCreateInfo marshalledCreateInfo;
				marshalledCreateInfo = createInfo.Pack();
				Interop.AllocationCallbacks marshalledAllocator;
				if(this.parent.Allocator != null) marshalledAllocator = this.parent.Allocator.Value.Pack();
				Interop.PipelineCache marshalledPipelineCache;
				commandResult = Interop.Commands.vkCreatePipelineCache(this.handle, &marshalledCreateInfo, this.parent.Allocator == null ? null : &marshalledAllocator, &marshalledPipelineCache);

				if (SharpVkException.IsError(commandResult))
				{
					throw SharpVkException.Create(commandResult);
				}
				result = new PipelineCache(marshalledPipelineCache, this);

				Interop.HeapUtil.FreeLog();


				return result;
			}
		}

		public Pipeline[] CreateGraphicsPipelines(PipelineCache pipelineCache, GraphicsPipelineCreateInfo[] createInfos)
		{
			unsafe
			{
				Pipeline[] result = default(Pipeline[]);

				Result commandResult;

				Interop.PipelineCache marshalledPipelineCache = pipelineCache?.Pack() ?? Interop.PipelineCache.Null;
				Interop.GraphicsPipelineCreateInfo* marshalledCreateInfos;
				if (createInfos != null)
				{
				    marshalledCreateInfos = (Interop.GraphicsPipelineCreateInfo*)Interop.HeapUtil.Allocate<Interop.GraphicsPipelineCreateInfo>(createInfos.Length);
				    for (int index = 0; index < createInfos.Length; index++)
				    {
				        marshalledCreateInfos[index] = createInfos[index].Pack();
				    }
				}
				else
				{
				    marshalledCreateInfos = null;
				}
				Interop.AllocationCallbacks marshalledAllocator;
				if(this.parent.Allocator != null) marshalledAllocator = this.parent.Allocator.Value.Pack();
				Interop.Pipeline* marshalledPipelines = (Interop.Pipeline*)Interop.HeapUtil.Allocate<Interop.Pipeline>(createInfos.Length);
				commandResult = Interop.Commands.vkCreateGraphicsPipelines(this.handle, marshalledPipelineCache, (uint)createInfos.Length, marshalledCreateInfos, this.parent.Allocator == null ? null : &marshalledAllocator, marshalledPipelines);

				if (SharpVkException.IsError(commandResult))
				{
					throw SharpVkException.Create(commandResult);
				}
				result = new Pipeline[(uint)createInfos.Length];
				for(int index = 0; index < (uint)createInfos.Length; index++)
				{
					result[index] = new Pipeline(marshalledPipelines[index], this);
				}

				Interop.HeapUtil.FreeLog();


				return result;
			}
		}

		public Pipeline[] CreateComputePipelines(PipelineCache pipelineCache, ComputePipelineCreateInfo[] createInfos)
		{
			unsafe
			{
				Pipeline[] result = default(Pipeline[]);

				Result commandResult;

				Interop.PipelineCache marshalledPipelineCache = pipelineCache?.Pack() ?? Interop.PipelineCache.Null;
				Interop.ComputePipelineCreateInfo* marshalledCreateInfos;
				if (createInfos != null)
				{
				    marshalledCreateInfos = (Interop.ComputePipelineCreateInfo*)Interop.HeapUtil.Allocate<Interop.ComputePipelineCreateInfo>(createInfos.Length);
				    for (int index = 0; index < createInfos.Length; index++)
				    {
				        marshalledCreateInfos[index] = createInfos[index].Pack();
				    }
				}
				else
				{
				    marshalledCreateInfos = null;
				}
				Interop.AllocationCallbacks marshalledAllocator;
				if(this.parent.Allocator != null) marshalledAllocator = this.parent.Allocator.Value.Pack();
				Interop.Pipeline* marshalledPipelines = (Interop.Pipeline*)Interop.HeapUtil.Allocate<Interop.Pipeline>(createInfos.Length);
				commandResult = Interop.Commands.vkCreateComputePipelines(this.handle, marshalledPipelineCache, (uint)createInfos.Length, marshalledCreateInfos, this.parent.Allocator == null ? null : &marshalledAllocator, marshalledPipelines);

				if (SharpVkException.IsError(commandResult))
				{
					throw SharpVkException.Create(commandResult);
				}
				result = new Pipeline[(uint)createInfos.Length];
				for(int index = 0; index < (uint)createInfos.Length; index++)
				{
					result[index] = new Pipeline(marshalledPipelines[index], this);
				}

				Interop.HeapUtil.FreeLog();


				return result;
			}
		}

		public PipelineLayout CreatePipelineLayout(PipelineLayoutCreateInfo createInfo)
		{
			unsafe
			{
				PipelineLayout result = default(PipelineLayout);

				Result commandResult;

				Interop.PipelineLayoutCreateInfo marshalledCreateInfo;
				marshalledCreateInfo = createInfo.Pack();
				Interop.AllocationCallbacks marshalledAllocator;
				if(this.parent.Allocator != null) marshalledAllocator = this.parent.Allocator.Value.Pack();
				Interop.PipelineLayout marshalledPipelineLayout;
				commandResult = Interop.Commands.vkCreatePipelineLayout(this.handle, &marshalledCreateInfo, this.parent.Allocator == null ? null : &marshalledAllocator, &marshalledPipelineLayout);

				if (SharpVkException.IsError(commandResult))
				{
					throw SharpVkException.Create(commandResult);
				}
				result = new PipelineLayout(marshalledPipelineLayout, this);

				Interop.HeapUtil.FreeLog();


				return result;
			}
		}

		public Sampler CreateSampler(SamplerCreateInfo createInfo)
		{
			unsafe
			{
				Sampler result = default(Sampler);

				Result commandResult;

				Interop.SamplerCreateInfo marshalledCreateInfo;
				marshalledCreateInfo = createInfo.Pack();
				Interop.AllocationCallbacks marshalledAllocator;
				if(this.parent.Allocator != null) marshalledAllocator = this.parent.Allocator.Value.Pack();
				Interop.Sampler marshalledSampler;
				commandResult = Interop.Commands.vkCreateSampler(this.handle, &marshalledCreateInfo, this.parent.Allocator == null ? null : &marshalledAllocator, &marshalledSampler);

				if (SharpVkException.IsError(commandResult))
				{
					throw SharpVkException.Create(commandResult);
				}
				result = new Sampler(marshalledSampler, this);

				Interop.HeapUtil.FreeLog();


				return result;
			}
		}

		public DescriptorSetLayout CreateDescriptorSetLayout(DescriptorSetLayoutCreateInfo createInfo)
		{
			unsafe
			{
				DescriptorSetLayout result = default(DescriptorSetLayout);

				Result commandResult;

				Interop.DescriptorSetLayoutCreateInfo marshalledCreateInfo;
				marshalledCreateInfo = createInfo.Pack();
				Interop.AllocationCallbacks marshalledAllocator;
				if(this.parent.Allocator != null) marshalledAllocator = this.parent.Allocator.Value.Pack();
				Interop.DescriptorSetLayout marshalledSetLayout;
				commandResult = Interop.Commands.vkCreateDescriptorSetLayout(this.handle, &marshalledCreateInfo, this.parent.Allocator == null ? null : &marshalledAllocator, &marshalledSetLayout);

				if (SharpVkException.IsError(commandResult))
				{
					throw SharpVkException.Create(commandResult);
				}
				result = new DescriptorSetLayout(marshalledSetLayout, this);

				Interop.HeapUtil.FreeLog();


				return result;
			}
		}

		public DescriptorPool CreateDescriptorPool(DescriptorPoolCreateInfo createInfo)
		{
			unsafe
			{
				DescriptorPool result = default(DescriptorPool);

				Result commandResult;

				Interop.DescriptorPoolCreateInfo marshalledCreateInfo;
				marshalledCreateInfo = createInfo.Pack();
				Interop.AllocationCallbacks marshalledAllocator;
				if(this.parent.Allocator != null) marshalledAllocator = this.parent.Allocator.Value.Pack();
				Interop.DescriptorPool marshalledDescriptorPool;
				commandResult = Interop.Commands.vkCreateDescriptorPool(this.handle, &marshalledCreateInfo, this.parent.Allocator == null ? null : &marshalledAllocator, &marshalledDescriptorPool);

				if (SharpVkException.IsError(commandResult))
				{
					throw SharpVkException.Create(commandResult);
				}
				result = new DescriptorPool(marshalledDescriptorPool, this);

				Interop.HeapUtil.FreeLog();


				return result;
			}
		}

		public DescriptorSet[] AllocateDescriptorSets(DescriptorSetAllocateInfo allocateInfo)
		{
			unsafe
			{
				DescriptorSet[] result = default(DescriptorSet[]);

				Result commandResult;

				Interop.DescriptorSetAllocateInfo marshalledAllocateInfo;
				marshalledAllocateInfo = allocateInfo.Pack();
				Interop.DescriptorSet* marshalledDescriptorSets = (Interop.DescriptorSet*)Interop.HeapUtil.Allocate<Interop.DescriptorSet>(allocateInfo.SetLayouts.Length);
				commandResult = Interop.Commands.vkAllocateDescriptorSets(this.handle, &marshalledAllocateInfo, marshalledDescriptorSets);

				if (SharpVkException.IsError(commandResult))
				{
					throw SharpVkException.Create(commandResult);
				}
				result = new DescriptorSet[(uint)allocateInfo.SetLayouts.Length];
				for(int index = 0; index < (uint)allocateInfo.SetLayouts.Length; index++)
				{
					result[index] = new DescriptorSet(marshalledDescriptorSets[index], allocateInfo.DescriptorPool);
				}

				Interop.HeapUtil.FreeLog();


				return result;
			}
		}

		public void UpdateDescriptorSets(WriteDescriptorSet[] descriptorWrites, CopyDescriptorSet[] descriptorCopies)
		{
			unsafe
			{
				Interop.WriteDescriptorSet* marshalledDescriptorWrites;
				if (descriptorWrites != null)
				{
				    marshalledDescriptorWrites = (Interop.WriteDescriptorSet*)Interop.HeapUtil.Allocate<Interop.WriteDescriptorSet>(descriptorWrites.Length);
				    for (int index = 0; index < descriptorWrites.Length; index++)
				    {
				        marshalledDescriptorWrites[index] = descriptorWrites[index].Pack();
				    }
				}
				else
				{
				    marshalledDescriptorWrites = null;
				}
				Interop.CopyDescriptorSet* marshalledDescriptorCopies;
				if (descriptorCopies != null)
				{
				    marshalledDescriptorCopies = (Interop.CopyDescriptorSet*)Interop.HeapUtil.Allocate<Interop.CopyDescriptorSet>(descriptorCopies.Length);
				    for (int index = 0; index < descriptorCopies.Length; index++)
				    {
				        marshalledDescriptorCopies[index] = descriptorCopies[index].Pack();
				    }
				}
				else
				{
				    marshalledDescriptorCopies = null;
				}
				Interop.Commands.vkUpdateDescriptorSets(this.handle, (uint)descriptorWrites.Length, marshalledDescriptorWrites, (uint)descriptorCopies.Length, marshalledDescriptorCopies);


				Interop.HeapUtil.FreeLog();

			}
		}

		public Framebuffer CreateFramebuffer(FramebufferCreateInfo createInfo)
		{
			unsafe
			{
				Framebuffer result = default(Framebuffer);

				Result commandResult;

				Interop.FramebufferCreateInfo marshalledCreateInfo;
				marshalledCreateInfo = createInfo.Pack();
				Interop.AllocationCallbacks marshalledAllocator;
				if(this.parent.Allocator != null) marshalledAllocator = this.parent.Allocator.Value.Pack();
				Interop.Framebuffer marshalledFramebuffer;
				commandResult = Interop.Commands.vkCreateFramebuffer(this.handle, &marshalledCreateInfo, this.parent.Allocator == null ? null : &marshalledAllocator, &marshalledFramebuffer);

				if (SharpVkException.IsError(commandResult))
				{
					throw SharpVkException.Create(commandResult);
				}
				result = new Framebuffer(marshalledFramebuffer, this);

				Interop.HeapUtil.FreeLog();


				return result;
			}
		}

		public RenderPass CreateRenderPass(RenderPassCreateInfo createInfo)
		{
			unsafe
			{
				RenderPass result = default(RenderPass);

				Result commandResult;

				Interop.RenderPassCreateInfo marshalledCreateInfo;
				marshalledCreateInfo = createInfo.Pack();
				Interop.AllocationCallbacks marshalledAllocator;
				if(this.parent.Allocator != null) marshalledAllocator = this.parent.Allocator.Value.Pack();
				Interop.RenderPass marshalledRenderPass;
				commandResult = Interop.Commands.vkCreateRenderPass(this.handle, &marshalledCreateInfo, this.parent.Allocator == null ? null : &marshalledAllocator, &marshalledRenderPass);

				if (SharpVkException.IsError(commandResult))
				{
					throw SharpVkException.Create(commandResult);
				}
				result = new RenderPass(marshalledRenderPass, this);

				Interop.HeapUtil.FreeLog();


				return result;
			}
		}

		public CommandPool CreateCommandPool(CommandPoolCreateInfo createInfo)
		{
			unsafe
			{
				CommandPool result = default(CommandPool);

				Result commandResult;

				Interop.CommandPoolCreateInfo marshalledCreateInfo;
				marshalledCreateInfo = createInfo.Pack();
				Interop.AllocationCallbacks marshalledAllocator;
				if(this.parent.Allocator != null) marshalledAllocator = this.parent.Allocator.Value.Pack();
				Interop.CommandPool marshalledCommandPool;
				commandResult = Interop.Commands.vkCreateCommandPool(this.handle, &marshalledCreateInfo, this.parent.Allocator == null ? null : &marshalledAllocator, &marshalledCommandPool);

				if (SharpVkException.IsError(commandResult))
				{
					throw SharpVkException.Create(commandResult);
				}
				result = new CommandPool(marshalledCommandPool, this);

				Interop.HeapUtil.FreeLog();


				return result;
			}
		}

		public CommandBuffer[] AllocateCommandBuffers(CommandBufferAllocateInfo allocateInfo)
		{
			unsafe
			{
				CommandBuffer[] result = default(CommandBuffer[]);

				Result commandResult;

				Interop.CommandBufferAllocateInfo marshalledAllocateInfo;
				marshalledAllocateInfo = allocateInfo.Pack();
				Interop.CommandBuffer* marshalledCommandBuffers = (Interop.CommandBuffer*)Interop.HeapUtil.Allocate<Interop.CommandBuffer>(allocateInfo.CommandBufferCount);
				commandResult = Interop.Commands.vkAllocateCommandBuffers(this.handle, &marshalledAllocateInfo, marshalledCommandBuffers);

				if (SharpVkException.IsError(commandResult))
				{
					throw SharpVkException.Create(commandResult);
				}
				result = new CommandBuffer[(uint)allocateInfo.CommandBufferCount];
				for(int index = 0; index < (uint)allocateInfo.CommandBufferCount; index++)
				{
					result[index] = new CommandBuffer(marshalledCommandBuffers[index], allocateInfo.CommandPool);
				}

				Interop.HeapUtil.FreeLog();


				return result;
			}
		}

		public Swapchain CreateSwapchain(SwapchainCreateInfo createInfo)
		{
			unsafe
			{
				Swapchain result = default(Swapchain);

				Result commandResult;

				Interop.SwapchainCreateInfo marshalledCreateInfo;
				marshalledCreateInfo = createInfo.Pack();
				Interop.AllocationCallbacks marshalledAllocator;
				if(this.parent.Allocator != null) marshalledAllocator = this.parent.Allocator.Value.Pack();
				Interop.Swapchain marshalledSwapchain;
				commandResult = Interop.Commands.vkCreateSwapchainKHR(this.handle, &marshalledCreateInfo, this.parent.Allocator == null ? null : &marshalledAllocator, &marshalledSwapchain);

				if (SharpVkException.IsError(commandResult))
				{
					throw SharpVkException.Create(commandResult);
				}
				result = new Swapchain(marshalledSwapchain, createInfo.Surface, this);

				Interop.HeapUtil.FreeLog();


				return result;
			}
		}

		public Swapchain[] CreateSharedSwapchains(SwapchainCreateInfo[] createInfos)
		{
			unsafe
			{
				Swapchain[] result = default(Swapchain[]);

				Result commandResult;

				Interop.SwapchainCreateInfo* marshalledCreateInfos;
				if (createInfos != null)
				{
				    marshalledCreateInfos = (Interop.SwapchainCreateInfo*)Interop.HeapUtil.Allocate<Interop.SwapchainCreateInfo>(createInfos.Length);
				    for (int index = 0; index < createInfos.Length; index++)
				    {
				        marshalledCreateInfos[index] = createInfos[index].Pack();
				    }
				}
				else
				{
				    marshalledCreateInfos = null;
				}
				Interop.AllocationCallbacks marshalledAllocator;
				if(this.parent.Allocator != null) marshalledAllocator = this.parent.Allocator.Value.Pack();
				Interop.Swapchain* marshalledSwapchains = (Interop.Swapchain*)Interop.HeapUtil.Allocate<Interop.Swapchain>(createInfos.Length);
				commandResult = Interop.Commands.vkCreateSharedSwapchainsKHR(this.handle, (uint)createInfos.Length, marshalledCreateInfos, this.parent.Allocator == null ? null : &marshalledAllocator, marshalledSwapchains);

				if (SharpVkException.IsError(commandResult))
				{
					throw SharpVkException.Create(commandResult);
				}
				result = new Swapchain[(uint)createInfos.Length];
				for(int index = 0; index < (uint)createInfos.Length; index++)
				{
					result[index] = new Swapchain(marshalledSwapchains[index], createInfos[index].Surface, this);
				}

				Interop.HeapUtil.FreeLog();


				return result;
			}
		}

		public void DebugMarkerSetObjectTag(DebugMarkerObjectTagInfo tagInfo)
		{
			unsafe
			{
				Result commandResult;

				Interop.DebugMarkerObjectTagInfo marshalledTagInfo;
				marshalledTagInfo = tagInfo.Pack();
				commandResult = Interop.Commands.vkDebugMarkerSetObjectTagEXT(this.handle, &marshalledTagInfo);

				if (SharpVkException.IsError(commandResult))
				{
					throw SharpVkException.Create(commandResult);
				}

				Interop.HeapUtil.FreeLog();

			}
		}

		public void DebugMarkerSetObjectName(DebugMarkerObjectNameInfo nameInfo)
		{
			unsafe
			{
				Result commandResult;

				Interop.DebugMarkerObjectNameInfo marshalledNameInfo;
				marshalledNameInfo = nameInfo.Pack();
				commandResult = Interop.Commands.vkDebugMarkerSetObjectNameEXT(this.handle, &marshalledNameInfo);

				if (SharpVkException.IsError(commandResult))
				{
					throw SharpVkException.Create(commandResult);
				}

				Interop.HeapUtil.FreeLog();

			}
		}

		internal Interop.Device Pack()
		{
			return this.handle;
		}

		public void Dispose()
		{
			this.Destroy();
		}
	}

    /// <summary>
    /// A Vulkan device operates on data in device memory via memory objects that
    /// are represented in the API by a sname:VkDeviceMemory handle.
    /// </summary>
	public class DeviceMemory
	{
		internal readonly Interop.DeviceMemory handle;

		private readonly Device parent;

		internal AllocationCallbacks? Allocator
		{
			get
			{
				return this.parent.Allocator;
			}
		}


		internal DeviceMemory(Interop.DeviceMemory handle, Device parent)
		{
			this.handle = handle;
			this.parent = parent;
		}

		public void MapMemory(DeviceSize offset, DeviceSize size, MemoryMapFlags flags, ref IntPtr ppData)
		{
			unsafe
			{
				Result commandResult;

				void* marshalledPpData;
				commandResult = Interop.Commands.vkMapMemory(this.parent.handle, this.handle, offset, size, flags, &marshalledPpData);

				if (SharpVkException.IsError(commandResult))
				{
					throw SharpVkException.Create(commandResult);
				}
				ppData = new IntPtr(marshalledPpData);

				Interop.HeapUtil.FreeLog();

			}
		}

		public void UnmapMemory()
		{
			unsafe
			{
				Interop.Commands.vkUnmapMemory(this.parent.handle, this.handle);


				Interop.HeapUtil.FreeLog();

			}
		}

		public DeviceSize GetCommitment()
		{
			unsafe
			{
				DeviceSize result = default(DeviceSize);

				Interop.Commands.vkGetDeviceMemoryCommitment(this.parent.handle, this.handle, &result);


				Interop.HeapUtil.FreeLog();


				return result;
			}
		}

		internal Interop.DeviceMemory Pack()
		{
			return this.handle;
		}
	}

    /// <summary>
    /// 
    /// </summary>
	public class Display
	{
		internal readonly Interop.Display handle;

		private AllocationCallbacks? allocator;

		internal AllocationCallbacks? Allocator
		{
			get
			{
				return this.allocator;
			}
		}

		internal Display(Interop.Display handle, AllocationCallbacks? allocator)
		{
			this.handle = handle;

			this.allocator = allocator;
		}

		internal Interop.Display Pack()
		{
			return this.handle;
		}
	}

    /// <summary>
    /// 
    /// </summary>
	public class DisplayMode
	{
		internal readonly Interop.DisplayMode handle;

		private readonly PhysicalDevice parent;

		internal AllocationCallbacks? Allocator
		{
			get
			{
				return this.parent.Allocator;
			}
		}


		internal DisplayMode(Interop.DisplayMode handle, PhysicalDevice parent)
		{
			this.handle = handle;
			this.parent = parent;
		}

		public DisplayPlaneCapabilities GetDisplayPlaneCapabilities(uint planeIndex)
		{
			unsafe
			{
				DisplayPlaneCapabilities result = default(DisplayPlaneCapabilities);

				Result commandResult;

				commandResult = Interop.Commands.vkGetDisplayPlaneCapabilitiesKHR(this.parent.handle, this.handle, planeIndex, &result);

				if (SharpVkException.IsError(commandResult))
				{
					throw SharpVkException.Create(commandResult);
				}

				Interop.HeapUtil.FreeLog();


				return result;
			}
		}

		internal Interop.DisplayMode Pack()
		{
			return this.handle;
		}
	}

    /// <summary>
    /// Events represent a fine-grained synchronization primitive that can: be used
    /// to gauge progress through a sequence of commands executed on a queue by
    /// Vulkan. An event is initially in the unsignaled state. It can: be
    /// signaled by a device, using commands inserted into the command buffer, or by
    /// the host. It can: also be reset to the unsignaled state by a device or the
    /// host. The host can: query the state of an event. A device can: wait for one
    /// or more events to become signaled.
    /// </summary>
	public class Event
		: IDisposable
	{
		internal readonly Interop.Event handle;

		private readonly Device parent;

		internal AllocationCallbacks? Allocator
		{
			get
			{
				return this.parent.Allocator;
			}
		}


		internal Event(Interop.Event handle, Device parent)
		{
			this.handle = handle;
			this.parent = parent;
		}

		public void Destroy()
		{
			unsafe
			{
				Interop.AllocationCallbacks marshalledAllocator;
				if(this.parent.Allocator != null) marshalledAllocator = this.parent.Allocator.Value.Pack();
				Interop.Commands.vkDestroyEvent(this.parent.handle, this.handle, this.parent.Allocator == null ? null : &marshalledAllocator);


				Interop.HeapUtil.FreeLog();

			}
		}

		public void GetStatus()
		{
			unsafe
			{
				Result commandResult;

				commandResult = Interop.Commands.vkGetEventStatus(this.parent.handle, this.handle);

				if (SharpVkException.IsError(commandResult))
				{
					throw SharpVkException.Create(commandResult);
				}

				Interop.HeapUtil.FreeLog();

			}
		}

		public void Set()
		{
			unsafe
			{
				Result commandResult;

				commandResult = Interop.Commands.vkSetEvent(this.parent.handle, this.handle);

				if (SharpVkException.IsError(commandResult))
				{
					throw SharpVkException.Create(commandResult);
				}

				Interop.HeapUtil.FreeLog();

			}
		}

		public void Reset()
		{
			unsafe
			{
				Result commandResult;

				commandResult = Interop.Commands.vkResetEvent(this.parent.handle, this.handle);

				if (SharpVkException.IsError(commandResult))
				{
					throw SharpVkException.Create(commandResult);
				}

				Interop.HeapUtil.FreeLog();

			}
		}

		internal Interop.Event Pack()
		{
			return this.handle;
		}

		public void Dispose()
		{
			this.Destroy();
		}
	}

    /// <summary>
    /// Fences can: be used by the host to determine completion of execution of
    /// _queue operations_.
    /// A fence's status is always either _signaled_ or _unsignaled_. The host can:
    /// poll the status of a single fence, or wait for any or all of a group of
    /// fences to become signaled.
    /// </summary>
	public class Fence
		: IDisposable
	{
		internal readonly Interop.Fence handle;

		private readonly Device parent;

		internal AllocationCallbacks? Allocator
		{
			get
			{
				return this.parent.Allocator;
			}
		}


		internal Fence(Interop.Fence handle, Device parent)
		{
			this.handle = handle;
			this.parent = parent;
		}

		public void Destroy()
		{
			unsafe
			{
				Interop.AllocationCallbacks marshalledAllocator;
				if(this.parent.Allocator != null) marshalledAllocator = this.parent.Allocator.Value.Pack();
				Interop.Commands.vkDestroyFence(this.parent.handle, this.handle, this.parent.Allocator == null ? null : &marshalledAllocator);


				Interop.HeapUtil.FreeLog();

			}
		}

		public void GetStatus()
		{
			unsafe
			{
				Result commandResult;

				commandResult = Interop.Commands.vkGetFenceStatus(this.parent.handle, this.handle);

				if (SharpVkException.IsError(commandResult))
				{
					throw SharpVkException.Create(commandResult);
				}

				Interop.HeapUtil.FreeLog();

			}
		}

		internal Interop.Fence Pack()
		{
			return this.handle;
		}

		public void Dispose()
		{
			this.Destroy();
		}
	}

    /// <summary>
    /// Render passes operate in conjunction with _framebuffers_. Framebuffers represent a
    /// collection of specific memory attachments that a render pass instance uses.
    /// </summary>
	public class Framebuffer
		: IDisposable
	{
		internal readonly Interop.Framebuffer handle;

		private readonly Device parent;

		internal AllocationCallbacks? Allocator
		{
			get
			{
				return this.parent.Allocator;
			}
		}


		internal Framebuffer(Interop.Framebuffer handle, Device parent)
		{
			this.handle = handle;
			this.parent = parent;
		}

		public void Destroy()
		{
			unsafe
			{
				Interop.AllocationCallbacks marshalledAllocator;
				if(this.parent.Allocator != null) marshalledAllocator = this.parent.Allocator.Value.Pack();
				Interop.Commands.vkDestroyFramebuffer(this.parent.handle, this.handle, this.parent.Allocator == null ? null : &marshalledAllocator);


				Interop.HeapUtil.FreeLog();

			}
		}

		internal Interop.Framebuffer Pack()
		{
			return this.handle;
		}

		public void Dispose()
		{
			this.Destroy();
		}
	}

    /// <summary>
    /// Images represent multidimensional - up to 3 - arrays of data which can: be
    /// used for various purposes (e.g. attachments, textures), by binding them to a
    /// graphics or compute pipeline via descriptor sets, or by directly specifying
    /// them as parameters to certain commands.
    /// </summary>
	public class Image
		: IDisposable
	{
		internal readonly Interop.Image handle;

		private readonly Device parent;

		internal AllocationCallbacks? Allocator
		{
			get
			{
				return this.parent.Allocator;
			}
		}


		internal Image(Interop.Image handle, Device parent)
		{
			this.handle = handle;
			this.parent = parent;
		}

		public void BindMemory(DeviceMemory memory, DeviceSize memoryOffset)
		{
			unsafe
			{
				Result commandResult;

				Interop.DeviceMemory marshalledMemory = memory.Pack();
				commandResult = Interop.Commands.vkBindImageMemory(this.parent.handle, this.handle, marshalledMemory, memoryOffset);

				if (SharpVkException.IsError(commandResult))
				{
					throw SharpVkException.Create(commandResult);
				}

				Interop.HeapUtil.FreeLog();

			}
		}

		public MemoryRequirements GetMemoryRequirements()
		{
			unsafe
			{
				MemoryRequirements result = default(MemoryRequirements);

				Interop.Commands.vkGetImageMemoryRequirements(this.parent.handle, this.handle, &result);


				Interop.HeapUtil.FreeLog();


				return result;
			}
		}

		public SparseImageMemoryRequirements[] GetSparseMemoryRequirements()
		{
			unsafe
			{
				SparseImageMemoryRequirements[] result = default(SparseImageMemoryRequirements[]);

				uint sparseMemoryRequirementCount;
				SparseImageMemoryRequirements* marshalledSparseMemoryRequirements = null;
				Interop.Commands.vkGetImageSparseMemoryRequirements(this.parent.handle, this.handle, &sparseMemoryRequirementCount, null);

				marshalledSparseMemoryRequirements = (SparseImageMemoryRequirements*)Interop.HeapUtil.Allocate<SparseImageMemoryRequirements>((uint)sparseMemoryRequirementCount);
				Interop.Commands.vkGetImageSparseMemoryRequirements(this.parent.handle, this.handle, &sparseMemoryRequirementCount, marshalledSparseMemoryRequirements);

				result = new SparseImageMemoryRequirements[(uint)sparseMemoryRequirementCount];
				for(int index = 0; index < (uint)sparseMemoryRequirementCount; index++)
				{
					result[index] = marshalledSparseMemoryRequirements[index];
				}

				Interop.HeapUtil.FreeLog();


				return result;
			}
		}

		public void Destroy()
		{
			unsafe
			{
				Interop.AllocationCallbacks marshalledAllocator;
				if(this.parent.Allocator != null) marshalledAllocator = this.parent.Allocator.Value.Pack();
				Interop.Commands.vkDestroyImage(this.parent.handle, this.handle, this.parent.Allocator == null ? null : &marshalledAllocator);


				Interop.HeapUtil.FreeLog();

			}
		}

		public SubresourceLayout GetSubresourceLayout(ImageSubresource subresource)
		{
			unsafe
			{
				SubresourceLayout result = default(SubresourceLayout);

				Interop.Commands.vkGetImageSubresourceLayout(this.parent.handle, this.handle, &subresource, &result);


				Interop.HeapUtil.FreeLog();


				return result;
			}
		}

		internal Interop.Image Pack()
		{
			return this.handle;
		}

		public void Dispose()
		{
			this.Destroy();
		}
	}

    /// <summary>
    /// Image objects are not directly accessed by pipeline shaders for reading or
    /// writing image data. Instead, _image views_ representing contiguous ranges of
    /// the image subresources and containing additional metadata are used for that
    /// purpose. Views must: be created on images of compatible types, and must:
    /// represent a valid subset of image subresources.
    /// </summary>
	public class ImageView
		: IDisposable
	{
		internal readonly Interop.ImageView handle;

		private readonly Device parent;

		internal AllocationCallbacks? Allocator
		{
			get
			{
				return this.parent.Allocator;
			}
		}


		internal ImageView(Interop.ImageView handle, Device parent)
		{
			this.handle = handle;
			this.parent = parent;
		}

		public void Destroy()
		{
			unsafe
			{
				Interop.AllocationCallbacks marshalledAllocator;
				if(this.parent.Allocator != null) marshalledAllocator = this.parent.Allocator.Value.Pack();
				Interop.Commands.vkDestroyImageView(this.parent.handle, this.handle, this.parent.Allocator == null ? null : &marshalledAllocator);


				Interop.HeapUtil.FreeLog();

			}
		}

		internal Interop.ImageView Pack()
		{
			return this.handle;
		}

		public void Dispose()
		{
			this.Destroy();
		}
	}

    /// <summary>
    /// There is no global state in Vulkan and all per-application state is
    /// stored in a sname:VkInstance object. Creating a sname:VkInstance object
    /// initializes the Vulkan library and allows the application to pass
    /// information about itself to the implementation.
    /// </summary>
	public class Instance
		: IDisposable
	{
		internal readonly Interop.Instance handle;

		private AllocationCallbacks? allocator;

		internal AllocationCallbacks? Allocator
		{
			get
			{
				return this.allocator;
			}
		}

		internal Instance(Interop.Instance handle, AllocationCallbacks? allocator)
		{
			this.handle = handle;

			this.allocator = allocator;
		}

		public static Instance Create(InstanceCreateInfo createInfo, AllocationCallbacks? allocator = null)
		{
			unsafe
			{
				Instance result = default(Instance);

				Result commandResult;

				Interop.InstanceCreateInfo marshalledCreateInfo;
				marshalledCreateInfo = createInfo.Pack();
				Interop.AllocationCallbacks marshalledAllocator;
				if(allocator != null) marshalledAllocator = allocator.Value.Pack();
				Interop.Instance marshalledInstance;
				commandResult = Interop.Commands.vkCreateInstance(&marshalledCreateInfo, allocator == null ? null : &marshalledAllocator, &marshalledInstance);

				if (SharpVkException.IsError(commandResult))
				{
					throw SharpVkException.Create(commandResult);
				}
				result = new Instance(marshalledInstance, allocator);

				Interop.HeapUtil.FreeLog();


				return result;
			}
		}

		public void Destroy()
		{
			unsafe
			{
				Interop.AllocationCallbacks marshalledAllocator;
				if(this.allocator != null) marshalledAllocator = this.allocator.Value.Pack();
				Interop.Commands.vkDestroyInstance(this.handle, this.allocator == null ? null : &marshalledAllocator);


				Interop.HeapUtil.FreeLog();

			}
		}

		public PhysicalDevice[] EnumeratePhysicalDevices()
		{
			unsafe
			{
				PhysicalDevice[] result = default(PhysicalDevice[]);

				Result commandResult;

				uint physicalDeviceCount;
				Interop.PhysicalDevice* marshalledPhysicalDevices = null;
				commandResult = Interop.Commands.vkEnumeratePhysicalDevices(this.handle, &physicalDeviceCount, null);

				if (SharpVkException.IsError(commandResult))
				{
					throw SharpVkException.Create(commandResult);
				}
				marshalledPhysicalDevices = (Interop.PhysicalDevice*)Interop.HeapUtil.Allocate<Interop.PhysicalDevice>((uint)physicalDeviceCount);
				commandResult = Interop.Commands.vkEnumeratePhysicalDevices(this.handle, &physicalDeviceCount, marshalledPhysicalDevices);

				if (SharpVkException.IsError(commandResult))
				{
					throw SharpVkException.Create(commandResult);
				}
				result = new PhysicalDevice[(uint)physicalDeviceCount];
				for(int index = 0; index < (uint)physicalDeviceCount; index++)
				{
					result[index] = new PhysicalDevice(marshalledPhysicalDevices[index], this);
				}

				Interop.HeapUtil.FreeLog();


				return result;
			}
		}

		public IntPtr GetProcAddr(string name)
		{
			unsafe
			{
				IntPtr result = default(IntPtr);

				char* marshalledName = Interop.HeapUtil.MarshalTo(name);
				result = Interop.Commands.vkGetInstanceProcAddr(this.handle, marshalledName);


				Interop.HeapUtil.FreeLog();


				return result;
			}
		}

		public static ExtensionProperties[] EnumerateExtensionProperties(string layerName)
		{
			unsafe
			{
				ExtensionProperties[] result = default(ExtensionProperties[]);

				Result commandResult;

				char* marshalledLayerName = Interop.HeapUtil.MarshalTo(layerName);
				uint propertyCount;
				Interop.ExtensionProperties* marshalledProperties = null;
				commandResult = Interop.Commands.vkEnumerateInstanceExtensionProperties(marshalledLayerName, &propertyCount, null);

				if (SharpVkException.IsError(commandResult))
				{
					throw SharpVkException.Create(commandResult);
				}
				marshalledProperties = (Interop.ExtensionProperties*)Interop.HeapUtil.Allocate<Interop.ExtensionProperties>((uint)propertyCount);
				commandResult = Interop.Commands.vkEnumerateInstanceExtensionProperties(marshalledLayerName, &propertyCount, marshalledProperties);

				if (SharpVkException.IsError(commandResult))
				{
					throw SharpVkException.Create(commandResult);
				}
				result = new ExtensionProperties[(uint)propertyCount];
				for(int index = 0; index < (uint)propertyCount; index++)
				{
					result[index] = ExtensionProperties.MarshalFrom(&marshalledProperties[index]);
				}

				Interop.HeapUtil.FreeLog();


				return result;
			}
		}

		public static LayerProperties[] EnumerateLayerProperties()
		{
			unsafe
			{
				LayerProperties[] result = default(LayerProperties[]);

				Result commandResult;

				uint propertyCount;
				Interop.LayerProperties* marshalledProperties = null;
				commandResult = Interop.Commands.vkEnumerateInstanceLayerProperties(&propertyCount, null);

				if (SharpVkException.IsError(commandResult))
				{
					throw SharpVkException.Create(commandResult);
				}
				marshalledProperties = (Interop.LayerProperties*)Interop.HeapUtil.Allocate<Interop.LayerProperties>((uint)propertyCount);
				commandResult = Interop.Commands.vkEnumerateInstanceLayerProperties(&propertyCount, marshalledProperties);

				if (SharpVkException.IsError(commandResult))
				{
					throw SharpVkException.Create(commandResult);
				}
				result = new LayerProperties[(uint)propertyCount];
				for(int index = 0; index < (uint)propertyCount; index++)
				{
					result[index] = LayerProperties.MarshalFrom(&marshalledProperties[index]);
				}

				Interop.HeapUtil.FreeLog();


				return result;
			}
		}

		public Surface CreateDisplayPlaneSurface(DisplaySurfaceCreateInfo createInfo)
		{
			unsafe
			{
				Surface result = default(Surface);

				Result commandResult;

				Interop.DisplaySurfaceCreateInfo marshalledCreateInfo;
				marshalledCreateInfo = createInfo.Pack();
				Interop.AllocationCallbacks marshalledAllocator;
				if(this.allocator != null) marshalledAllocator = this.allocator.Value.Pack();
				Interop.Surface marshalledSurface;
				commandResult = Interop.Commands.vkCreateDisplayPlaneSurfaceKHR(this.handle, &marshalledCreateInfo, this.allocator == null ? null : &marshalledAllocator, &marshalledSurface);

				if (SharpVkException.IsError(commandResult))
				{
					throw SharpVkException.Create(commandResult);
				}
				result = new Surface(marshalledSurface, this);

				Interop.HeapUtil.FreeLog();


				return result;
			}
		}

		public Surface CreateXlibSurface(XlibSurfaceCreateInfo createInfo)
		{
			unsafe
			{
				Surface result = default(Surface);

				Result commandResult;

				Interop.XlibSurfaceCreateInfo marshalledCreateInfo;
				marshalledCreateInfo = createInfo.Pack();
				Interop.AllocationCallbacks marshalledAllocator;
				if(this.allocator != null) marshalledAllocator = this.allocator.Value.Pack();
				Interop.Surface marshalledSurface;
				commandResult = Interop.Commands.vkCreateXlibSurfaceKHR(this.handle, &marshalledCreateInfo, this.allocator == null ? null : &marshalledAllocator, &marshalledSurface);

				if (SharpVkException.IsError(commandResult))
				{
					throw SharpVkException.Create(commandResult);
				}
				result = new Surface(marshalledSurface, this);

				Interop.HeapUtil.FreeLog();


				return result;
			}
		}

		public Surface CreateXcbSurface(XcbSurfaceCreateInfo createInfo)
		{
			unsafe
			{
				Surface result = default(Surface);

				Result commandResult;

				Interop.XcbSurfaceCreateInfo marshalledCreateInfo;
				marshalledCreateInfo = createInfo.Pack();
				Interop.AllocationCallbacks marshalledAllocator;
				if(this.allocator != null) marshalledAllocator = this.allocator.Value.Pack();
				Interop.Surface marshalledSurface;
				commandResult = Interop.Commands.vkCreateXcbSurfaceKHR(this.handle, &marshalledCreateInfo, this.allocator == null ? null : &marshalledAllocator, &marshalledSurface);

				if (SharpVkException.IsError(commandResult))
				{
					throw SharpVkException.Create(commandResult);
				}
				result = new Surface(marshalledSurface, this);

				Interop.HeapUtil.FreeLog();


				return result;
			}
		}

		public Surface CreateWaylandSurface(WaylandSurfaceCreateInfo createInfo)
		{
			unsafe
			{
				Surface result = default(Surface);

				Result commandResult;

				Interop.WaylandSurfaceCreateInfo marshalledCreateInfo;
				marshalledCreateInfo = createInfo.Pack();
				Interop.AllocationCallbacks marshalledAllocator;
				if(this.allocator != null) marshalledAllocator = this.allocator.Value.Pack();
				Interop.Surface marshalledSurface;
				commandResult = Interop.Commands.vkCreateWaylandSurfaceKHR(this.handle, &marshalledCreateInfo, this.allocator == null ? null : &marshalledAllocator, &marshalledSurface);

				if (SharpVkException.IsError(commandResult))
				{
					throw SharpVkException.Create(commandResult);
				}
				result = new Surface(marshalledSurface, this);

				Interop.HeapUtil.FreeLog();


				return result;
			}
		}

		public Surface CreateMirSurface(MirSurfaceCreateInfo createInfo)
		{
			unsafe
			{
				Surface result = default(Surface);

				Result commandResult;

				Interop.MirSurfaceCreateInfo marshalledCreateInfo;
				marshalledCreateInfo = createInfo.Pack();
				Interop.AllocationCallbacks marshalledAllocator;
				if(this.allocator != null) marshalledAllocator = this.allocator.Value.Pack();
				Interop.Surface marshalledSurface;
				commandResult = Interop.Commands.vkCreateMirSurfaceKHR(this.handle, &marshalledCreateInfo, this.allocator == null ? null : &marshalledAllocator, &marshalledSurface);

				if (SharpVkException.IsError(commandResult))
				{
					throw SharpVkException.Create(commandResult);
				}
				result = new Surface(marshalledSurface, this);

				Interop.HeapUtil.FreeLog();


				return result;
			}
		}

		public Surface CreateAndroidSurface(AndroidSurfaceCreateInfo createInfo)
		{
			unsafe
			{
				Surface result = default(Surface);

				Result commandResult;

				Interop.AndroidSurfaceCreateInfo marshalledCreateInfo;
				marshalledCreateInfo = createInfo.Pack();
				Interop.AllocationCallbacks marshalledAllocator;
				if(this.allocator != null) marshalledAllocator = this.allocator.Value.Pack();
				Interop.Surface marshalledSurface;
				commandResult = Interop.Commands.vkCreateAndroidSurfaceKHR(this.handle, &marshalledCreateInfo, this.allocator == null ? null : &marshalledAllocator, &marshalledSurface);

				if (SharpVkException.IsError(commandResult))
				{
					throw SharpVkException.Create(commandResult);
				}
				result = new Surface(marshalledSurface, this);

				Interop.HeapUtil.FreeLog();


				return result;
			}
		}

		public Surface CreateWin32Surface(Win32SurfaceCreateInfo createInfo)
		{
			unsafe
			{
				Surface result = default(Surface);

				Result commandResult;

				Interop.Win32SurfaceCreateInfo marshalledCreateInfo;
				marshalledCreateInfo = createInfo.Pack();
				Interop.AllocationCallbacks marshalledAllocator;
				if(this.allocator != null) marshalledAllocator = this.allocator.Value.Pack();
				Interop.Surface marshalledSurface;
				commandResult = Interop.Commands.vkCreateWin32SurfaceKHR(this.handle, &marshalledCreateInfo, this.allocator == null ? null : &marshalledAllocator, &marshalledSurface);

				if (SharpVkException.IsError(commandResult))
				{
					throw SharpVkException.Create(commandResult);
				}
				result = new Surface(marshalledSurface, this);

				Interop.HeapUtil.FreeLog();


				return result;
			}
		}

		public DebugReportCallback CreateDebugReportCallback(DebugReportCallbackCreateInfo createInfo)
		{
			unsafe
			{
				DebugReportCallback result = default(DebugReportCallback);

				Result commandResult;

				Interop.DebugReportCallbackCreateInfo marshalledCreateInfo;
				marshalledCreateInfo = createInfo.Pack();
				Interop.AllocationCallbacks marshalledAllocator;
				if(this.allocator != null) marshalledAllocator = this.allocator.Value.Pack();
				Interop.DebugReportCallback marshalledCallback;
				commandResult = Interop.Commands.vkCreateDebugReportCallbackEXT(this.handle, &marshalledCreateInfo, this.allocator == null ? null : &marshalledAllocator, &marshalledCallback);

				if (SharpVkException.IsError(commandResult))
				{
					throw SharpVkException.Create(commandResult);
				}
				result = new DebugReportCallback(marshalledCallback, this);

				Interop.HeapUtil.FreeLog();


				return result;
			}
		}

		public void DebugReportMessage(DebugReportFlags flags, DebugReportObjectType objectType, ulong @object, UIntPtr location, int messageCode, char layerPrefix, char message)
		{
			unsafe
			{
				Interop.Commands.vkDebugReportMessageEXT(this.handle, flags, objectType, @object, location, messageCode, &layerPrefix, &message);


				Interop.HeapUtil.FreeLog();

			}
		}

		internal Interop.Instance Pack()
		{
			return this.handle;
		}

		public void Dispose()
		{
			this.Destroy();
		}
	}

    /// <summary>
    /// Vulkan separates the concept of _physical_ and _logical_ devices. A
    /// physical device usually represents a single device in a system (perhaps made
    /// up of several individual hardware devices working together), of which there
    /// are a finite number. A logical device represents an application's view of
    /// the device.
    /// </summary>
	public class PhysicalDevice
	{
		internal readonly Interop.PhysicalDevice handle;

		private readonly Instance parent;

		internal AllocationCallbacks? Allocator
		{
			get
			{
				return this.parent.Allocator;
			}
		}


		internal PhysicalDevice(Interop.PhysicalDevice handle, Instance parent)
		{
			this.handle = handle;
			this.parent = parent;
		}

		public PhysicalDeviceFeatures GetFeatures()
		{
			unsafe
			{
				PhysicalDeviceFeatures result = default(PhysicalDeviceFeatures);

				Interop.Commands.vkGetPhysicalDeviceFeatures(this.handle, &result);


				Interop.HeapUtil.FreeLog();


				return result;
			}
		}

		public FormatProperties GetFormatProperties(Format format)
		{
			unsafe
			{
				FormatProperties result = default(FormatProperties);

				Interop.Commands.vkGetPhysicalDeviceFormatProperties(this.handle, format, &result);


				Interop.HeapUtil.FreeLog();


				return result;
			}
		}

		public ImageFormatProperties GetImageFormatProperties(Format format, ImageType type, ImageTiling tiling, ImageUsageFlags usage, ImageCreateFlags flags)
		{
			unsafe
			{
				ImageFormatProperties result = default(ImageFormatProperties);

				Result commandResult;

				commandResult = Interop.Commands.vkGetPhysicalDeviceImageFormatProperties(this.handle, format, type, tiling, usage, flags, &result);

				if (SharpVkException.IsError(commandResult))
				{
					throw SharpVkException.Create(commandResult);
				}

				Interop.HeapUtil.FreeLog();


				return result;
			}
		}

		public PhysicalDeviceProperties GetProperties()
		{
			unsafe
			{
				PhysicalDeviceProperties result = default(PhysicalDeviceProperties);

				Interop.PhysicalDeviceProperties marshalledProperties;
				Interop.Commands.vkGetPhysicalDeviceProperties(this.handle, &marshalledProperties);

				result = PhysicalDeviceProperties.MarshalFrom(&marshalledProperties);

				Interop.HeapUtil.FreeLog();


				return result;
			}
		}

		public QueueFamilyProperties[] GetQueueFamilyProperties()
		{
			unsafe
			{
				QueueFamilyProperties[] result = default(QueueFamilyProperties[]);

				uint queueFamilyPropertyCount;
				QueueFamilyProperties* marshalledQueueFamilyProperties = null;
				Interop.Commands.vkGetPhysicalDeviceQueueFamilyProperties(this.handle, &queueFamilyPropertyCount, null);

				marshalledQueueFamilyProperties = (QueueFamilyProperties*)Interop.HeapUtil.Allocate<QueueFamilyProperties>((uint)queueFamilyPropertyCount);
				Interop.Commands.vkGetPhysicalDeviceQueueFamilyProperties(this.handle, &queueFamilyPropertyCount, marshalledQueueFamilyProperties);

				result = new QueueFamilyProperties[(uint)queueFamilyPropertyCount];
				for(int index = 0; index < (uint)queueFamilyPropertyCount; index++)
				{
					result[index] = marshalledQueueFamilyProperties[index];
				}

				Interop.HeapUtil.FreeLog();


				return result;
			}
		}

		public PhysicalDeviceMemoryProperties GetMemoryProperties()
		{
			unsafe
			{
				PhysicalDeviceMemoryProperties result = default(PhysicalDeviceMemoryProperties);

				Interop.PhysicalDeviceMemoryProperties marshalledMemoryProperties;
				Interop.Commands.vkGetPhysicalDeviceMemoryProperties(this.handle, &marshalledMemoryProperties);

				result = PhysicalDeviceMemoryProperties.MarshalFrom(&marshalledMemoryProperties);

				Interop.HeapUtil.FreeLog();


				return result;
			}
		}

		public Device CreateDevice(DeviceCreateInfo createInfo)
		{
			unsafe
			{
				Device result = default(Device);

				Result commandResult;

				Interop.DeviceCreateInfo marshalledCreateInfo;
				marshalledCreateInfo = createInfo.Pack();
				Interop.AllocationCallbacks marshalledAllocator;
				if(this.parent.Allocator != null) marshalledAllocator = this.parent.Allocator.Value.Pack();
				Interop.Device marshalledDevice;
				commandResult = Interop.Commands.vkCreateDevice(this.handle, &marshalledCreateInfo, this.parent.Allocator == null ? null : &marshalledAllocator, &marshalledDevice);

				if (SharpVkException.IsError(commandResult))
				{
					throw SharpVkException.Create(commandResult);
				}
				result = new Device(marshalledDevice, this);

				Interop.HeapUtil.FreeLog();


				return result;
			}
		}

		public ExtensionProperties[] EnumerateDeviceExtensionProperties(string layerName)
		{
			unsafe
			{
				ExtensionProperties[] result = default(ExtensionProperties[]);

				Result commandResult;

				char* marshalledLayerName = Interop.HeapUtil.MarshalTo(layerName);
				uint propertyCount;
				Interop.ExtensionProperties* marshalledProperties = null;
				commandResult = Interop.Commands.vkEnumerateDeviceExtensionProperties(this.handle, marshalledLayerName, &propertyCount, null);

				if (SharpVkException.IsError(commandResult))
				{
					throw SharpVkException.Create(commandResult);
				}
				marshalledProperties = (Interop.ExtensionProperties*)Interop.HeapUtil.Allocate<Interop.ExtensionProperties>((uint)propertyCount);
				commandResult = Interop.Commands.vkEnumerateDeviceExtensionProperties(this.handle, marshalledLayerName, &propertyCount, marshalledProperties);

				if (SharpVkException.IsError(commandResult))
				{
					throw SharpVkException.Create(commandResult);
				}
				result = new ExtensionProperties[(uint)propertyCount];
				for(int index = 0; index < (uint)propertyCount; index++)
				{
					result[index] = ExtensionProperties.MarshalFrom(&marshalledProperties[index]);
				}

				Interop.HeapUtil.FreeLog();


				return result;
			}
		}

		public LayerProperties[] EnumerateDeviceLayerProperties()
		{
			unsafe
			{
				LayerProperties[] result = default(LayerProperties[]);

				Result commandResult;

				uint propertyCount;
				Interop.LayerProperties* marshalledProperties = null;
				commandResult = Interop.Commands.vkEnumerateDeviceLayerProperties(this.handle, &propertyCount, null);

				if (SharpVkException.IsError(commandResult))
				{
					throw SharpVkException.Create(commandResult);
				}
				marshalledProperties = (Interop.LayerProperties*)Interop.HeapUtil.Allocate<Interop.LayerProperties>((uint)propertyCount);
				commandResult = Interop.Commands.vkEnumerateDeviceLayerProperties(this.handle, &propertyCount, marshalledProperties);

				if (SharpVkException.IsError(commandResult))
				{
					throw SharpVkException.Create(commandResult);
				}
				result = new LayerProperties[(uint)propertyCount];
				for(int index = 0; index < (uint)propertyCount; index++)
				{
					result[index] = LayerProperties.MarshalFrom(&marshalledProperties[index]);
				}

				Interop.HeapUtil.FreeLog();


				return result;
			}
		}

		public SparseImageFormatProperties[] GetSparseImageFormatProperties(Format format, ImageType type, SampleCountFlags samples, ImageUsageFlags usage, ImageTiling tiling)
		{
			unsafe
			{
				SparseImageFormatProperties[] result = default(SparseImageFormatProperties[]);

				uint propertyCount;
				SparseImageFormatProperties* marshalledProperties = null;
				Interop.Commands.vkGetPhysicalDeviceSparseImageFormatProperties(this.handle, format, type, samples, usage, tiling, &propertyCount, null);

				marshalledProperties = (SparseImageFormatProperties*)Interop.HeapUtil.Allocate<SparseImageFormatProperties>((uint)propertyCount);
				Interop.Commands.vkGetPhysicalDeviceSparseImageFormatProperties(this.handle, format, type, samples, usage, tiling, &propertyCount, marshalledProperties);

				result = new SparseImageFormatProperties[(uint)propertyCount];
				for(int index = 0; index < (uint)propertyCount; index++)
				{
					result[index] = marshalledProperties[index];
				}

				Interop.HeapUtil.FreeLog();


				return result;
			}
		}

		public Bool32 GetSurfaceSupport(uint queueFamilyIndex, Surface surface)
		{
			unsafe
			{
				Bool32 result = default(Bool32);

				Result commandResult;

				Interop.Surface marshalledSurface = surface.Pack();
				commandResult = Interop.Commands.vkGetPhysicalDeviceSurfaceSupportKHR(this.handle, queueFamilyIndex, marshalledSurface, &result);

				if (SharpVkException.IsError(commandResult))
				{
					throw SharpVkException.Create(commandResult);
				}

				Interop.HeapUtil.FreeLog();


				return result;
			}
		}

		public SurfaceCapabilities GetSurfaceCapabilities(Surface surface)
		{
			unsafe
			{
				SurfaceCapabilities result = default(SurfaceCapabilities);

				Result commandResult;

				Interop.Surface marshalledSurface = surface.Pack();
				commandResult = Interop.Commands.vkGetPhysicalDeviceSurfaceCapabilitiesKHR(this.handle, marshalledSurface, &result);

				if (SharpVkException.IsError(commandResult))
				{
					throw SharpVkException.Create(commandResult);
				}

				Interop.HeapUtil.FreeLog();


				return result;
			}
		}

		public SurfaceFormat[] GetSurfaceFormats(Surface surface)
		{
			unsafe
			{
				SurfaceFormat[] result = default(SurfaceFormat[]);

				Result commandResult;

				Interop.Surface marshalledSurface = surface.Pack();
				uint surfaceFormatCount;
				SurfaceFormat* marshalledSurfaceFormats = null;
				commandResult = Interop.Commands.vkGetPhysicalDeviceSurfaceFormatsKHR(this.handle, marshalledSurface, &surfaceFormatCount, null);

				if (SharpVkException.IsError(commandResult))
				{
					throw SharpVkException.Create(commandResult);
				}
				marshalledSurfaceFormats = (SurfaceFormat*)Interop.HeapUtil.Allocate<SurfaceFormat>((uint)surfaceFormatCount);
				commandResult = Interop.Commands.vkGetPhysicalDeviceSurfaceFormatsKHR(this.handle, marshalledSurface, &surfaceFormatCount, marshalledSurfaceFormats);

				if (SharpVkException.IsError(commandResult))
				{
					throw SharpVkException.Create(commandResult);
				}
				result = new SurfaceFormat[(uint)surfaceFormatCount];
				for(int index = 0; index < (uint)surfaceFormatCount; index++)
				{
					result[index] = marshalledSurfaceFormats[index];
				}

				Interop.HeapUtil.FreeLog();


				return result;
			}
		}

		public PresentMode[] GetSurfacePresentModes(Surface surface)
		{
			unsafe
			{
				PresentMode[] result = default(PresentMode[]);

				Result commandResult;

				Interop.Surface marshalledSurface = surface.Pack();
				uint presentModeCount;
				PresentMode* marshalledPresentModes = null;
				commandResult = Interop.Commands.vkGetPhysicalDeviceSurfacePresentModesKHR(this.handle, marshalledSurface, &presentModeCount, null);

				if (SharpVkException.IsError(commandResult))
				{
					throw SharpVkException.Create(commandResult);
				}
				marshalledPresentModes = (PresentMode*)Interop.HeapUtil.Allocate<int>((uint)presentModeCount);
				commandResult = Interop.Commands.vkGetPhysicalDeviceSurfacePresentModesKHR(this.handle, marshalledSurface, &presentModeCount, marshalledPresentModes);

				if (SharpVkException.IsError(commandResult))
				{
					throw SharpVkException.Create(commandResult);
				}
				result = new PresentMode[(uint)presentModeCount];
				for(int index = 0; index < (uint)presentModeCount; index++)
				{
					result[index] = marshalledPresentModes[index];
				}

				Interop.HeapUtil.FreeLog();


				return result;
			}
		}

		public DisplayProperties[] GetDisplayProperties()
		{
			unsafe
			{
				DisplayProperties[] result = default(DisplayProperties[]);

				Result commandResult;

				uint propertyCount;
				Interop.DisplayProperties* marshalledProperties = null;
				commandResult = Interop.Commands.vkGetPhysicalDeviceDisplayPropertiesKHR(this.handle, &propertyCount, null);

				if (SharpVkException.IsError(commandResult))
				{
					throw SharpVkException.Create(commandResult);
				}
				marshalledProperties = (Interop.DisplayProperties*)Interop.HeapUtil.Allocate<Interop.DisplayProperties>((uint)propertyCount);
				commandResult = Interop.Commands.vkGetPhysicalDeviceDisplayPropertiesKHR(this.handle, &propertyCount, marshalledProperties);

				if (SharpVkException.IsError(commandResult))
				{
					throw SharpVkException.Create(commandResult);
				}
				result = new DisplayProperties[(uint)propertyCount];
				for(int index = 0; index < (uint)propertyCount; index++)
				{
					result[index] = DisplayProperties.MarshalFrom(&marshalledProperties[index]);
				}

				Interop.HeapUtil.FreeLog();


				return result;
			}
		}

		public DisplayPlaneProperties[] GetDisplayPlaneProperties()
		{
			unsafe
			{
				DisplayPlaneProperties[] result = default(DisplayPlaneProperties[]);

				Result commandResult;

				uint propertyCount;
				Interop.DisplayPlaneProperties* marshalledProperties = null;
				commandResult = Interop.Commands.vkGetPhysicalDeviceDisplayPlanePropertiesKHR(this.handle, &propertyCount, null);

				if (SharpVkException.IsError(commandResult))
				{
					throw SharpVkException.Create(commandResult);
				}
				marshalledProperties = (Interop.DisplayPlaneProperties*)Interop.HeapUtil.Allocate<Interop.DisplayPlaneProperties>((uint)propertyCount);
				commandResult = Interop.Commands.vkGetPhysicalDeviceDisplayPlanePropertiesKHR(this.handle, &propertyCount, marshalledProperties);

				if (SharpVkException.IsError(commandResult))
				{
					throw SharpVkException.Create(commandResult);
				}
				result = new DisplayPlaneProperties[(uint)propertyCount];
				for(int index = 0; index < (uint)propertyCount; index++)
				{
					result[index] = DisplayPlaneProperties.MarshalFrom(&marshalledProperties[index]);
				}

				Interop.HeapUtil.FreeLog();


				return result;
			}
		}

		public Display[] GetDisplayPlaneSupportedDisplays(uint planeIndex)
		{
			unsafe
			{
				Display[] result = default(Display[]);

				Result commandResult;

				uint displayCount;
				Interop.Display* marshalledDisplays = null;
				commandResult = Interop.Commands.vkGetDisplayPlaneSupportedDisplaysKHR(this.handle, planeIndex, &displayCount, null);

				if (SharpVkException.IsError(commandResult))
				{
					throw SharpVkException.Create(commandResult);
				}
				marshalledDisplays = (Interop.Display*)Interop.HeapUtil.Allocate<Interop.Display>((uint)displayCount);
				commandResult = Interop.Commands.vkGetDisplayPlaneSupportedDisplaysKHR(this.handle, planeIndex, &displayCount, marshalledDisplays);

				if (SharpVkException.IsError(commandResult))
				{
					throw SharpVkException.Create(commandResult);
				}
				result = new Display[(uint)displayCount];
				for(int index = 0; index < (uint)displayCount; index++)
				{
					result[index] = new Display(marshalledDisplays[index], this.Allocator);
				}

				Interop.HeapUtil.FreeLog();


				return result;
			}
		}

		public DisplayModeProperties[] GetDisplayModeProperties(Display display)
		{
			unsafe
			{
				DisplayModeProperties[] result = default(DisplayModeProperties[]);

				Result commandResult;

				Interop.Display marshalledDisplay = display.Pack();
				uint propertyCount;
				Interop.DisplayModeProperties* marshalledProperties = null;
				commandResult = Interop.Commands.vkGetDisplayModePropertiesKHR(this.handle, marshalledDisplay, &propertyCount, null);

				if (SharpVkException.IsError(commandResult))
				{
					throw SharpVkException.Create(commandResult);
				}
				marshalledProperties = (Interop.DisplayModeProperties*)Interop.HeapUtil.Allocate<Interop.DisplayModeProperties>((uint)propertyCount);
				commandResult = Interop.Commands.vkGetDisplayModePropertiesKHR(this.handle, marshalledDisplay, &propertyCount, marshalledProperties);

				if (SharpVkException.IsError(commandResult))
				{
					throw SharpVkException.Create(commandResult);
				}
				result = new DisplayModeProperties[(uint)propertyCount];
				for(int index = 0; index < (uint)propertyCount; index++)
				{
					result[index] = DisplayModeProperties.MarshalFrom(&marshalledProperties[index]);
				}

				Interop.HeapUtil.FreeLog();


				return result;
			}
		}

		public DisplayMode CreateDisplayMode(Display display, DisplayModeCreateInfo createInfo)
		{
			unsafe
			{
				DisplayMode result = default(DisplayMode);

				Result commandResult;

				Interop.Display marshalledDisplay = display.Pack();
				Interop.DisplayModeCreateInfo marshalledCreateInfo;
				marshalledCreateInfo = createInfo.Pack();
				Interop.AllocationCallbacks marshalledAllocator;
				if(this.parent.Allocator != null) marshalledAllocator = this.parent.Allocator.Value.Pack();
				Interop.DisplayMode marshalledMode;
				commandResult = Interop.Commands.vkCreateDisplayModeKHR(this.handle, marshalledDisplay, &marshalledCreateInfo, this.parent.Allocator == null ? null : &marshalledAllocator, &marshalledMode);

				if (SharpVkException.IsError(commandResult))
				{
					throw SharpVkException.Create(commandResult);
				}
				result = new DisplayMode(marshalledMode, this);

				Interop.HeapUtil.FreeLog();


				return result;
			}
		}

		public bool GetXlibPresentationSupport(uint queueFamilyIndex, IntPtr dpy, IntPtr visualID)
		{
			unsafe
			{
				bool result = default(bool);

				result = Interop.Commands.vkGetPhysicalDeviceXlibPresentationSupportKHR(this.handle, queueFamilyIndex, &dpy, visualID);


				Interop.HeapUtil.FreeLog();


				return result;
			}
		}

		public bool GetXcbPresentationSupport(uint queueFamilyIndex, IntPtr connection, IntPtr visual_id)
		{
			unsafe
			{
				bool result = default(bool);

				result = Interop.Commands.vkGetPhysicalDeviceXcbPresentationSupportKHR(this.handle, queueFamilyIndex, &connection, visual_id);


				Interop.HeapUtil.FreeLog();


				return result;
			}
		}

		public bool GetWaylandPresentationSupport(uint queueFamilyIndex, IntPtr display)
		{
			unsafe
			{
				bool result = default(bool);

				result = Interop.Commands.vkGetPhysicalDeviceWaylandPresentationSupportKHR(this.handle, queueFamilyIndex, display);


				Interop.HeapUtil.FreeLog();


				return result;
			}
		}

		public bool GetMirPresentationSupport(uint queueFamilyIndex, IntPtr connection)
		{
			unsafe
			{
				bool result = default(bool);

				result = Interop.Commands.vkGetPhysicalDeviceMirPresentationSupportKHR(this.handle, queueFamilyIndex, &connection);


				Interop.HeapUtil.FreeLog();


				return result;
			}
		}

		public bool GetWin32PresentationSupport(uint queueFamilyIndex)
		{
			unsafe
			{
				bool result = default(bool);

				result = Interop.Commands.vkGetPhysicalDeviceWin32PresentationSupportKHR(this.handle, queueFamilyIndex);


				Interop.HeapUtil.FreeLog();


				return result;
			}
		}

		internal Interop.PhysicalDevice Pack()
		{
			return this.handle;
		}
	}

    /// <summary>
    /// 
    /// </summary>
	public class Pipeline
		: IDisposable
	{
		internal readonly Interop.Pipeline handle;

		private readonly Device parent;

		internal AllocationCallbacks? Allocator
		{
			get
			{
				return this.parent.Allocator;
			}
		}


		internal Pipeline(Interop.Pipeline handle, Device parent)
		{
			this.handle = handle;
			this.parent = parent;
		}

		public void Destroy()
		{
			unsafe
			{
				Interop.AllocationCallbacks marshalledAllocator;
				if(this.parent.Allocator != null) marshalledAllocator = this.parent.Allocator.Value.Pack();
				Interop.Commands.vkDestroyPipeline(this.parent.handle, this.handle, this.parent.Allocator == null ? null : &marshalledAllocator);


				Interop.HeapUtil.FreeLog();

			}
		}

		internal Interop.Pipeline Pack()
		{
			return this.handle;
		}

		public void Dispose()
		{
			this.Destroy();
		}
	}

    /// <summary>
    /// Pipeline cache objects allow the result of pipeline construction to be
    /// reused between pipelines and between runs of an application. Reuse between
    /// pipelines is achieved by passing the same pipeline cache object when
    /// creating multiple related pipelines. Reuse across runs of an application is
    /// achieved by retrieving pipeline cache contents in one run of an application,
    /// saving the contents, and using them to preinitialize a pipeline cache on a
    /// subsequent run. The contents of the pipeline cache objects are
    /// managed by the implementation. Applications can: manage the host memory
    /// consumed by a pipeline cache object and control the amount of data
    /// retrieved from a pipeline cache object.
    /// </summary>
	public class PipelineCache
		: IDisposable
	{
		internal readonly Interop.PipelineCache handle;

		private readonly Device parent;

		internal AllocationCallbacks? Allocator
		{
			get
			{
				return this.parent.Allocator;
			}
		}


		internal PipelineCache(Interop.PipelineCache handle, Device parent)
		{
			this.handle = handle;
			this.parent = parent;
		}

		public void Destroy()
		{
			unsafe
			{
				Interop.AllocationCallbacks marshalledAllocator;
				if(this.parent.Allocator != null) marshalledAllocator = this.parent.Allocator.Value.Pack();
				Interop.Commands.vkDestroyPipelineCache(this.parent.handle, this.handle, this.parent.Allocator == null ? null : &marshalledAllocator);


				Interop.HeapUtil.FreeLog();

			}
		}

		public byte[] GetData()
		{
			unsafe
			{
				byte[] result = default(byte[]);

				Result commandResult;

				UIntPtr dataSize;
				byte* marshalledData = null;
				commandResult = Interop.Commands.vkGetPipelineCacheData(this.parent.handle, this.handle, &dataSize, null);

				if (SharpVkException.IsError(commandResult))
				{
					throw SharpVkException.Create(commandResult);
				}
				marshalledData = (byte*)Interop.HeapUtil.Allocate<byte>((uint)dataSize);
				commandResult = Interop.Commands.vkGetPipelineCacheData(this.parent.handle, this.handle, &dataSize, marshalledData);

				if (SharpVkException.IsError(commandResult))
				{
					throw SharpVkException.Create(commandResult);
				}
				result = new byte[(uint)dataSize];
				for(int index = 0; index < (uint)dataSize; index++)
				{
					result[index] = marshalledData[index];
				}

				Interop.HeapUtil.FreeLog();


				return result;
			}
		}

		public void MergePipelineCaches(PipelineCache[] sourceCaches)
		{
			unsafe
			{
				Result commandResult;

				Interop.PipelineCache* marshalledSourceCaches;
				if (sourceCaches != null)
				{
				    marshalledSourceCaches = (Interop.PipelineCache*)Interop.HeapUtil.Allocate<Interop.PipelineCache>(sourceCaches.Length);
				    for (int index = 0; index < sourceCaches.Length; index++)
				    {
				        marshalledSourceCaches[index] = sourceCaches[index].Pack();
				    }
				}
				else
				{
				    marshalledSourceCaches = null;
				}
				commandResult = Interop.Commands.vkMergePipelineCaches(this.parent.handle, this.handle, (uint)sourceCaches.Length, marshalledSourceCaches);

				if (SharpVkException.IsError(commandResult))
				{
					throw SharpVkException.Create(commandResult);
				}

				Interop.HeapUtil.FreeLog();

			}
		}

		internal Interop.PipelineCache Pack()
		{
			return this.handle;
		}

		public void Dispose()
		{
			this.Destroy();
		}
	}

    /// <summary>
    /// Access to descriptor sets from a pipeline is accomplished through a
    /// _pipeline layout_. Zero or more descriptor set layouts and zero or more push
    /// constant ranges are combined to form a
    /// pipeline layout object which describes the complete set of resources that
    /// can: be accessed by a pipeline. The pipeline layout represents a sequence of
    /// descriptor sets with each having a specific layout. This sequence of layouts
    /// is used to determine the interface between shader stages and shader
    /// resources. Each pipeline is created using a pipeline layout.
    /// </summary>
	public class PipelineLayout
		: IDisposable
	{
		internal readonly Interop.PipelineLayout handle;

		private readonly Device parent;

		internal AllocationCallbacks? Allocator
		{
			get
			{
				return this.parent.Allocator;
			}
		}


		internal PipelineLayout(Interop.PipelineLayout handle, Device parent)
		{
			this.handle = handle;
			this.parent = parent;
		}

		public void Destroy()
		{
			unsafe
			{
				Interop.AllocationCallbacks marshalledAllocator;
				if(this.parent.Allocator != null) marshalledAllocator = this.parent.Allocator.Value.Pack();
				Interop.Commands.vkDestroyPipelineLayout(this.parent.handle, this.handle, this.parent.Allocator == null ? null : &marshalledAllocator);


				Interop.HeapUtil.FreeLog();

			}
		}

		internal Interop.PipelineLayout Pack()
		{
			return this.handle;
		}

		public void Dispose()
		{
			this.Destroy();
		}
	}

    /// <summary>
    /// Queries are managed using _query pool_ objects. Each query pool is a
    /// collection of a specific number of queries of a particular type.
    /// </summary>
	public class QueryPool
		: IDisposable
	{
		internal readonly Interop.QueryPool handle;

		private readonly Device parent;

		internal AllocationCallbacks? Allocator
		{
			get
			{
				return this.parent.Allocator;
			}
		}


		internal QueryPool(Interop.QueryPool handle, Device parent)
		{
			this.handle = handle;
			this.parent = parent;
		}

		public void Destroy()
		{
			unsafe
			{
				Interop.AllocationCallbacks marshalledAllocator;
				if(this.parent.Allocator != null) marshalledAllocator = this.parent.Allocator.Value.Pack();
				Interop.Commands.vkDestroyQueryPool(this.parent.handle, this.handle, this.parent.Allocator == null ? null : &marshalledAllocator);


				Interop.HeapUtil.FreeLog();

			}
		}

		public void GetResults(uint firstQuery, uint queryCount, byte[] data, DeviceSize stride, QueryResultFlags flags)
		{
			unsafe
			{
				Result commandResult;

				fixed(byte* marshalledData = data)
				commandResult = Interop.Commands.vkGetQueryPoolResults(this.parent.handle, this.handle, firstQuery, queryCount, (UIntPtr)data.Length, marshalledData, stride, flags);

				if (SharpVkException.IsError(commandResult))
				{
					throw SharpVkException.Create(commandResult);
				}

				Interop.HeapUtil.FreeLog();

			}
		}

		internal Interop.QueryPool Pack()
		{
			return this.handle;
		}

		public void Dispose()
		{
			this.Destroy();
		}
	}

    /// <summary>
    /// Creating a logical device also creates the queues associated with that
    /// device. The queues to create are described by a set of
    /// slink:VkDeviceQueueCreateInfo structures that are passed to
    /// flink:vkCreateDevice in pname:pQueueCreateInfos.
    /// </summary>
	public class Queue
	{
		internal readonly Interop.Queue handle;

		private readonly Device parent;

		internal AllocationCallbacks? Allocator
		{
			get
			{
				return this.parent.Allocator;
			}
		}


		internal Queue(Interop.Queue handle, Device parent)
		{
			this.handle = handle;
			this.parent = parent;
		}

		public void Submit(SubmitInfo[] submits, Fence fence)
		{
			unsafe
			{
				Result commandResult;

				Interop.SubmitInfo* marshalledSubmits;
				if (submits != null)
				{
				    marshalledSubmits = (Interop.SubmitInfo*)Interop.HeapUtil.Allocate<Interop.SubmitInfo>(submits.Length);
				    for (int index = 0; index < submits.Length; index++)
				    {
				        marshalledSubmits[index] = submits[index].Pack();
				    }
				}
				else
				{
				    marshalledSubmits = null;
				}
				Interop.Fence marshalledFence = fence?.Pack() ?? Interop.Fence.Null;
				commandResult = Interop.Commands.vkQueueSubmit(this.handle, (uint)submits.Length, marshalledSubmits, marshalledFence);

				if (SharpVkException.IsError(commandResult))
				{
					throw SharpVkException.Create(commandResult);
				}

				Interop.HeapUtil.FreeLog();

			}
		}

		public void WaitIdle()
		{
			unsafe
			{
				Result commandResult;

				commandResult = Interop.Commands.vkQueueWaitIdle(this.handle);

				if (SharpVkException.IsError(commandResult))
				{
					throw SharpVkException.Create(commandResult);
				}

				Interop.HeapUtil.FreeLog();

			}
		}

		public void BindSparse(BindSparseInfo[] bindInfo, Fence fence)
		{
			unsafe
			{
				Result commandResult;

				Interop.BindSparseInfo* marshalledBindInfo;
				if (bindInfo != null)
				{
				    marshalledBindInfo = (Interop.BindSparseInfo*)Interop.HeapUtil.Allocate<Interop.BindSparseInfo>(bindInfo.Length);
				    for (int index = 0; index < bindInfo.Length; index++)
				    {
				        marshalledBindInfo[index] = bindInfo[index].Pack();
				    }
				}
				else
				{
				    marshalledBindInfo = null;
				}
				Interop.Fence marshalledFence = fence?.Pack() ?? Interop.Fence.Null;
				commandResult = Interop.Commands.vkQueueBindSparse(this.handle, (uint)bindInfo.Length, marshalledBindInfo, marshalledFence);

				if (SharpVkException.IsError(commandResult))
				{
					throw SharpVkException.Create(commandResult);
				}

				Interop.HeapUtil.FreeLog();

			}
		}

		public void Present(PresentInfo presentInfo)
		{
			unsafe
			{
				Result commandResult;

				Interop.PresentInfo marshalledPresentInfo;
				marshalledPresentInfo = presentInfo.Pack();
				commandResult = Interop.Commands.vkQueuePresentKHR(this.handle, &marshalledPresentInfo);

				if (SharpVkException.IsError(commandResult))
				{
					throw SharpVkException.Create(commandResult);
				}

				Interop.HeapUtil.FreeLog();

			}
		}

		internal Interop.Queue Pack()
		{
			return this.handle;
		}
	}

    /// <summary>
    /// A _render pass_ represents a collection of attachments, subpasses, and
    /// dependencies between the subpasses, and describes how the attachments
    /// are used over the course of the subpasses. The use of a render pass
    /// in a command buffer is a  _render pass instance_.
    /// </summary>
	public class RenderPass
		: IDisposable
	{
		internal readonly Interop.RenderPass handle;

		private readonly Device parent;

		internal AllocationCallbacks? Allocator
		{
			get
			{
				return this.parent.Allocator;
			}
		}


		internal RenderPass(Interop.RenderPass handle, Device parent)
		{
			this.handle = handle;
			this.parent = parent;
		}

		public void Destroy()
		{
			unsafe
			{
				Interop.AllocationCallbacks marshalledAllocator;
				if(this.parent.Allocator != null) marshalledAllocator = this.parent.Allocator.Value.Pack();
				Interop.Commands.vkDestroyRenderPass(this.parent.handle, this.handle, this.parent.Allocator == null ? null : &marshalledAllocator);


				Interop.HeapUtil.FreeLog();

			}
		}

		public Extent2D GetRenderAreaGranularity()
		{
			unsafe
			{
				Extent2D result = default(Extent2D);

				Interop.Commands.vkGetRenderAreaGranularity(this.parent.handle, this.handle, &result);


				Interop.HeapUtil.FreeLog();


				return result;
			}
		}

		internal Interop.RenderPass Pack()
		{
			return this.handle;
		}

		public void Dispose()
		{
			this.Destroy();
		}
	}

    /// <summary>
    /// sname:VkSampler objects represent the state of an image sampler which is
    /// used by the implementation to read image data and apply filtering and other
    /// transformations for the shader.
    /// </summary>
	public class Sampler
		: IDisposable
	{
		internal readonly Interop.Sampler handle;

		private readonly Device parent;

		internal AllocationCallbacks? Allocator
		{
			get
			{
				return this.parent.Allocator;
			}
		}


		internal Sampler(Interop.Sampler handle, Device parent)
		{
			this.handle = handle;
			this.parent = parent;
		}

		public void Destroy()
		{
			unsafe
			{
				Interop.AllocationCallbacks marshalledAllocator;
				if(this.parent.Allocator != null) marshalledAllocator = this.parent.Allocator.Value.Pack();
				Interop.Commands.vkDestroySampler(this.parent.handle, this.handle, this.parent.Allocator == null ? null : &marshalledAllocator);


				Interop.HeapUtil.FreeLog();

			}
		}

		internal Interop.Sampler Pack()
		{
			return this.handle;
		}

		public void Dispose()
		{
			this.Destroy();
		}
	}

    /// <summary>
    /// Semaphores are used to coordinate queue operations both within a queue and
    /// between different queues. A semaphore's status is always either _signaled_
    /// or _unsignaled_.
    /// </summary>
	public class Semaphore
		: IDisposable
	{
		internal readonly Interop.Semaphore handle;

		private readonly Device parent;

		internal AllocationCallbacks? Allocator
		{
			get
			{
				return this.parent.Allocator;
			}
		}


		internal Semaphore(Interop.Semaphore handle, Device parent)
		{
			this.handle = handle;
			this.parent = parent;
		}

		public void Destroy()
		{
			unsafe
			{
				Interop.AllocationCallbacks marshalledAllocator;
				if(this.parent.Allocator != null) marshalledAllocator = this.parent.Allocator.Value.Pack();
				Interop.Commands.vkDestroySemaphore(this.parent.handle, this.handle, this.parent.Allocator == null ? null : &marshalledAllocator);


				Interop.HeapUtil.FreeLog();

			}
		}

		internal Interop.Semaphore Pack()
		{
			return this.handle;
		}

		public void Dispose()
		{
			this.Destroy();
		}
	}

    /// <summary>
    /// _Shader modules_ contain _shader code_ and one or more entry points. Shaders
    /// are selected from a shader module by specifying an entry point as part of
    /// <<pipelines,pipeline>> creation. The stages of a pipeline can: use shaders
    /// that come from different modules. The shader code defining a shader module
    /// must: be in the SPIR-V format, as described by the <<spirvenv,Vulkan
    /// Environment for SPIR-V>> appendix.
    /// </summary>
	public class ShaderModule
		: IDisposable
	{
		internal readonly Interop.ShaderModule handle;

		private readonly Device parent;

		internal AllocationCallbacks? Allocator
		{
			get
			{
				return this.parent.Allocator;
			}
		}


		internal ShaderModule(Interop.ShaderModule handle, Device parent)
		{
			this.handle = handle;
			this.parent = parent;
		}

		public void Destroy()
		{
			unsafe
			{
				Interop.AllocationCallbacks marshalledAllocator;
				if(this.parent.Allocator != null) marshalledAllocator = this.parent.Allocator.Value.Pack();
				Interop.Commands.vkDestroyShaderModule(this.parent.handle, this.handle, this.parent.Allocator == null ? null : &marshalledAllocator);


				Interop.HeapUtil.FreeLog();

			}
		}

		internal Interop.ShaderModule Pack()
		{
			return this.handle;
		}

		public void Dispose()
		{
			this.Destroy();
		}
	}

    /// <summary>
    /// 
    /// </summary>
	public class Surface
		: IDisposable
	{
		internal readonly Interop.Surface handle;

		private readonly Instance parent;

		internal AllocationCallbacks? Allocator
		{
			get
			{
				return this.parent.Allocator;
			}
		}


		internal Surface(Interop.Surface handle, Instance parent)
		{
			this.handle = handle;
			this.parent = parent;
		}

		public void Destroy()
		{
			unsafe
			{
				Interop.AllocationCallbacks marshalledAllocator;
				if(this.parent.Allocator != null) marshalledAllocator = this.parent.Allocator.Value.Pack();
				Interop.Commands.vkDestroySurfaceKHR(this.parent.handle, this.handle, this.parent.Allocator == null ? null : &marshalledAllocator);


				Interop.HeapUtil.FreeLog();

			}
		}

		internal Interop.Surface Pack()
		{
			return this.handle;
		}

		public void Dispose()
		{
			this.Destroy();
		}
	}

    /// <summary>
    /// 
    /// </summary>
	public class Swapchain
		: IDisposable
	{
		internal readonly Interop.Swapchain handle;

		private readonly Surface parent;

		internal AllocationCallbacks? Allocator
		{
			get
			{
				return this.parent.Allocator;
			}
		}

		private readonly Device associated;

		internal Swapchain(Interop.Swapchain handle, Surface parent, Device associated)
		{
			this.handle = handle;
			this.parent = parent;
			this.associated = associated;
		}

		public void Destroy()
		{
			unsafe
			{
				Interop.AllocationCallbacks marshalledAllocator;
				if(this.parent.Allocator != null) marshalledAllocator = this.parent.Allocator.Value.Pack();
				Interop.Commands.vkDestroySwapchainKHR(this.associated.handle, this.handle, this.parent.Allocator == null ? null : &marshalledAllocator);


				Interop.HeapUtil.FreeLog();

			}
		}

		public Image[] GetImages()
		{
			unsafe
			{
				Image[] result = default(Image[]);

				Result commandResult;

				uint swapchainImageCount;
				Interop.Image* marshalledSwapchainImages = null;
				commandResult = Interop.Commands.vkGetSwapchainImagesKHR(this.associated.handle, this.handle, &swapchainImageCount, null);

				if (SharpVkException.IsError(commandResult))
				{
					throw SharpVkException.Create(commandResult);
				}
				marshalledSwapchainImages = (Interop.Image*)Interop.HeapUtil.Allocate<Interop.Image>((uint)swapchainImageCount);
				commandResult = Interop.Commands.vkGetSwapchainImagesKHR(this.associated.handle, this.handle, &swapchainImageCount, marshalledSwapchainImages);

				if (SharpVkException.IsError(commandResult))
				{
					throw SharpVkException.Create(commandResult);
				}
				result = new Image[(uint)swapchainImageCount];
				for(int index = 0; index < (uint)swapchainImageCount; index++)
				{
					result[index] = new Image(marshalledSwapchainImages[index], this.associated);
				}

				Interop.HeapUtil.FreeLog();


				return result;
			}
		}

		public uint AcquireNextImage(ulong timeout, Semaphore semaphore, Fence fence)
		{
			unsafe
			{
				uint result = default(uint);

				Result commandResult;

				Interop.Semaphore marshalledSemaphore = semaphore?.Pack() ?? Interop.Semaphore.Null;
				Interop.Fence marshalledFence = fence?.Pack() ?? Interop.Fence.Null;
				commandResult = Interop.Commands.vkAcquireNextImageKHR(this.associated.handle, this.handle, timeout, marshalledSemaphore, marshalledFence, &result);

				if (SharpVkException.IsError(commandResult))
				{
					throw SharpVkException.Create(commandResult);
				}

				Interop.HeapUtil.FreeLog();


				return result;
			}
		}

		internal Interop.Swapchain Pack()
		{
			return this.handle;
		}

		public void Dispose()
		{
			this.Destroy();
		}
	}

}