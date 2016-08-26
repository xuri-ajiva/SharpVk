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
    /// Opaque handle to a buffer object
    /// Buffers represent linear arrays of data which are used for various purposes by binding them to a graphics or compute pipeline via descriptor sets or via certain commands, or by directly specifying them as parameters to certain commands.
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

		/// <summary>
		/// Bind device memory to a buffer object
		/// </summary>
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

		/// <summary>
		/// Returns the memory requirements for specified Vulkan object.
		/// </summary>
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

		/// <summary>
		/// Destroy a buffer object
		/// </summary>
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

		/// <summary>
		/// Releases the unmanaged resources associated with this instance and
		/// destroys the underlying Vulkan handle.
		/// </summary>
		public void Dispose()
		{
			this.Destroy();
		}
	}

    /// <summary>
    /// Opaque handle to a buffer view object
    /// A _buffer view_ represents a contiguous range of a buffer and a specific format to be used to interpret the data. Buffer views are used to enable shaders to access buffer contents interpreted as formatted data. In order to create a valid buffer view, the buffer must: have been created with at least one of the following usage flags:
    /// * ename:VK_BUFFER_USAGE_UNIFORM_TEXEL_BUFFER_BIT   * ename:VK_BUFFER_USAGE_STORAGE_TEXEL_BUFFER_BIT
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

		/// <summary>
		/// Destroy a buffer view object
		/// </summary>
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

		/// <summary>
		/// Releases the unmanaged resources associated with this instance and
		/// destroys the underlying Vulkan handle.
		/// </summary>
		public void Dispose()
		{
			this.Destroy();
		}
	}

    /// <summary>
    /// Opaque handle to a command buffer object
    /// Command buffers are objects used to record commands which can: be subsequently submitted to a device queue for execution. There are two levels of command buffers - _primary command buffers_, which can: execute secondary command buffers, and which are submitted to queues, and _secondary command buffers_, which can: be executed by primary command buffers, and which are not directly submitted to queues.
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

		/// <summary>
		/// Start recording a command buffer
		/// </summary>
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

		/// <summary>
		/// Finish recording a command buffer
		/// If there was an error during recording, the application will be notified by an unsuccessful return code returned by fname:vkEndCommandBuffer. If the application wishes to further use the command buffer, the command buffer must: be reset.
		/// </summary>
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

		/// <summary>
		/// Reset a command buffer.
		/// </summary>
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

		/// <summary>
		/// Bind a pipeline object to a command buffer.
		/// Once bound, a pipeline binding affects subsequent graphics or compute commands in the command buffer until a different pipeline is bound to the bind point. The pipeline bound to ename:VK_PIPELINE_BIND_POINT_COMPUTE controls the behavior of flink:vkCmdDispatch and flink:vkCmdDispatchIndirect. The pipeline bound to ename:VK_PIPELINE_BIND_POINT_GRAPHICS controls the behavior of flink:vkCmdDraw, flink:vkCmdDrawIndexed, flink:vkCmdDrawIndirect, and flink:vkCmdDrawIndexedIndirect. No other commands are affected by the pipeline state.
		/// </summary>
		public void BindPipeline(PipelineBindPoint pipelineBindPoint, Pipeline pipeline)
		{
			unsafe
			{
				Interop.Pipeline marshalledPipeline = pipeline.Pack();
				Interop.Commands.vkCmdBindPipeline(this.handle, pipelineBindPoint, marshalledPipeline);


				Interop.HeapUtil.FreeLog();

			}
		}

		/// <summary>
		/// Set the viewport on a command buffer.
		/// The viewport parameters taken from element latexmath:[$i$] of pname:pViewports replace the current state for the viewport index latexmath:[$\mathit{firstViewport}+i$], for latexmath:[$i$] in latexmath:[$[0, viewportCount)$].
		/// </summary>
		public void SetViewport(uint firstViewport, Viewport[] viewports)
		{
			unsafe
			{
				fixed(Viewport* marshalledViewports = viewports)
				Interop.Commands.vkCmdSetViewport(this.handle, firstViewport, (uint)viewports.Length, marshalledViewports);


				Interop.HeapUtil.FreeLog();

			}
		}

		/// <summary>
		/// Set the dynamic scissor rectangles on a command buffer.
		/// The scissor rectangles taken from element latexmath:[$i$] of pname:pScissors replace the current state for the scissor index latexmath:[$\mathit{firstScissor}+i$], for latexmath:[$i$] in latexmath:[$[0, scissorCount)$].
		/// Each scissor rectangle is described by a slink:VkRect2D structure, with the pname:offset.x and pname:offset.y values determining the upper left corner of the scissor rectangle, and the pname:extent.width and pname:extent.height values determining the size in pixels.
		/// </summary>
		public void SetScissor(uint firstScissor, Rect2D[] scissors)
		{
			unsafe
			{
				fixed(Rect2D* marshalledScissors = scissors)
				Interop.Commands.vkCmdSetScissor(this.handle, firstScissor, (uint)scissors.Length, marshalledScissors);


				Interop.HeapUtil.FreeLog();

			}
		}

		/// <summary>
		/// Set the dynamic line width state.
		/// </summary>
		public void SetLineWidth(float lineWidth)
		{
			unsafe
			{
				Interop.Commands.vkCmdSetLineWidth(this.handle, lineWidth);


				Interop.HeapUtil.FreeLog();

			}
		}

		/// <summary>
		/// Set the depth bias dynamic state.
		/// The depth values of all fragments generated by the rasterization of a polygon can: be offset by a single value that is computed for that polygon. This behavior is controlled by the pname:depthBiasEnable, pname:depthBiasConstantFactor, pname:depthBiasClamp, and pname:depthBiasSlopeFactor members of slink:VkPipelineRasterizationStateCreateInfo, or by the corresponding parameters to the fname:vkCmdSetDepthBias command if depth bias state is dynamic.
		/// If pname:depthBiasEnable is ename:VK_FALSE, no depth bias is applied and the fragment's depth values are unchanged.
		/// pname:depthBiasSlopeFactor scales the maximum depth slope of the polygon, and pname:depthBiasConstantFactor scales an implementation-dependent constant that relates to the usable resolution of the depth buffer. The resulting values are summed to produce the depth bias value which is then clamped to a minimum or maximum value specified by pname:depthBiasClamp. pname:depthBiasSlopeFactor, pname:depthBiasConstantFactor, and pname:depthBiasClamp can: each be positive, negative, or zero.
		/// The maximum depth slope latexmath:[$m$] of a triangle is
		/// [latexmath] ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++ \begin{equation} m = \sqrt{ \left({\partial z_f \over \partial x_f}\right)^2  +  \left({\partial z_f \over  \partial y_f}\right)^2} \end{equation} ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
		/// where latexmath:[$(x_f, y_f, z_f)$] is a point on the triangle. latexmath:[$m$] may: be approximated as
		/// [latexmath] ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++ \begin{equation} m = \max( \left |{\partial z_f \over \partial x_f} \right |, \left |{\partial z_f \over \partial y_f} \right | ). \end{equation} ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
		/// The minimum resolvable difference latexmath:[$r$] is an implementation-dependent parameter that depends on the depth buffer representation. It is the smallest difference in framebuffer coordinate latexmath:[$z$] values that is guaranteed to remain distinct throughout polygon rasterization and in the depth buffer. All pairs of fragments generated by the rasterization of two polygons with otherwise identical vertices, but latexmath:[$z_f$] values that differ by $r$, will have distinct depth values.
		/// For fixed-point depth buffer representations, latexmath:[$r$] is constant throughout the range of the entire depth buffer. For floating-point depth buffers, there is no single minimum resolvable difference. In this case, the minimum resolvable difference for a given polygon is dependent on the maximum exponent, latexmath:[$e$], in the range of latexmath:[$z$] values spanned by the primitive. If latexmath:[$n$] is the number of bits in the floating-point mantissa, the minimum resolvable difference, latexmath:[$r$], for the given primitive is defined as
		/// [latexmath] ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++ \begin{equation} r = 2^{e - n} \end{equation} ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
		/// If no depth buffer is present, latexmath:[$r$] is undefined.
		/// The bias value latexmath:[$o$] for a polygon is
		/// [latexmath] ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++ \begin{equation} o = \begin{cases}     m \times depthBiasSlopeFactor +          r \times depthBiasConstantFactor  &amp; depthBiasClamp = 0\ or\ NaN \\     \min(m \times depthBiasSlopeFactor +          r \times depthBiasConstantFactor,          depthBiasClamp)                   &amp; depthBiasClamp &gt; 0  \\     \max(m \times depthBiasSlopeFactor +          r \times depthBiasConstantFactor,          depthBiasClamp)                   &amp; depthBiasClamp &lt; 0  \\ \end{cases} \end{equation} ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
		/// latexmath:[$m$] is computed as described above. If the depth buffer uses a fixed-point representation, latexmath:[$m$] is a function of depth values in the range latexmath:[$[0,1\]$], and latexmath:[$o$] is applied to depth values in the same range.
		/// For fixed-point depth buffers, fragment depth values are always limited to the range latexmath:[$[0,1\]$] by clamping after depth bias addition is performed. Fragment depth values are clamped even when the depth buffer uses a floating-point representation.
		/// </summary>
		public void SetDepthBias(float depthBiasConstantFactor, float depthBiasClamp, float depthBiasSlopeFactor)
		{
			unsafe
			{
				Interop.Commands.vkCmdSetDepthBias(this.handle, depthBiasConstantFactor, depthBiasClamp, depthBiasSlopeFactor);


				Interop.HeapUtil.FreeLog();

			}
		}

		/// <summary>
		/// Set the values of blend constants.
		/// </summary>
		public void SetBlendConstants(float blendConstants)
		{
			unsafe
			{
				Interop.Commands.vkCmdSetBlendConstants(this.handle, blendConstants);


				Interop.HeapUtil.FreeLog();

			}
		}

		/// <summary>
		/// Set the depth bounds test values for a command buffer.
		/// </summary>
		public void SetDepthBounds(float minDepthBounds, float maxDepthBounds)
		{
			unsafe
			{
				Interop.Commands.vkCmdSetDepthBounds(this.handle, minDepthBounds, maxDepthBounds);


				Interop.HeapUtil.FreeLog();

			}
		}

		/// <summary>
		/// Set the stencil compare mask dynamic state.
		/// </summary>
		public void SetStencilCompareMask(StencilFaceFlags faceMask, uint compareMask)
		{
			unsafe
			{
				Interop.Commands.vkCmdSetStencilCompareMask(this.handle, faceMask, compareMask);


				Interop.HeapUtil.FreeLog();

			}
		}

		/// <summary>
		/// Set the stencil write mask dynamic state.
		/// </summary>
		public void SetStencilWriteMask(StencilFaceFlags faceMask, uint writeMask)
		{
			unsafe
			{
				Interop.Commands.vkCmdSetStencilWriteMask(this.handle, faceMask, writeMask);


				Interop.HeapUtil.FreeLog();

			}
		}

		/// <summary>
		/// Set the stencil reference dynamic state.
		/// </summary>
		public void SetStencilReference(StencilFaceFlags faceMask, uint reference)
		{
			unsafe
			{
				Interop.Commands.vkCmdSetStencilReference(this.handle, faceMask, reference);


				Interop.HeapUtil.FreeLog();

			}
		}

		/// <summary>
		/// Binds descriptor sets to a command buffer.
		/// fname:vkCmdBindDescriptorSets causes the sets numbered [pname:firstSet.. pname:firstSet+pname:descriptorSetCount-1] to use the bindings stored in pname:pDescriptorSets[0..pname:descriptorSetCount-1] for subsequent rendering commands (either compute or graphics, according to the pname:pipelineBindPoint). Any bindings that were previously applied via these sets are no longer valid.
		/// Once bound, a descriptor set affects rendering of subsequent graphics or compute commands in the command buffer until a different set is bound to the same set number, or else until the set is disturbed as described in &lt;&lt;descriptorsets-compatibility, Pipeline Layout Compatibility&gt;&gt;.
		/// A compatible descriptor set must: be bound for all set numbers that any shaders in a pipeline access, at the time that a draw or dispatch command is recorded to execute using that pipeline. However, if none of the shaders in a pipeline statically use any bindings with a particular set number, then no descriptor set need be bound for that set number, even if the pipeline layout includes a non-trivial descriptor set layout for that set number.
		/// If any of the sets being bound include dynamic uniform or storage buffers, then pname:pDynamicOffsets includes one element for each array element in each dynamic descriptor type binding in each set. Values are taken from pname:pDynamicOffsets in an order such that all entries for set N come before set N+1; within a set, entries are ordered by the binding numbers in the descriptor set layouts; and within a binding array, elements are in order. pname:dynamicOffsetCount must: equal the total number of dynamic descriptors in the sets being bound.
		/// The effective offset used for dynamic uniform and storage buffer bindings is the sum of the relative offset taken from pname:pDynamicOffsets, and the base address of the buffer plus base offset in the descriptor set. The length of the dynamic uniform and storage buffer bindings is the buffer range as specified in the descriptor set.
		/// Each of the pname:pDescriptorSets must: be compatible with the pipeline layout specified by pname:layout. The layout used to program the bindings must: also be compatible with the pipeline used in subsequent graphics or compute commands, as defined in the &lt;&lt;descriptorsets-compatibility, Pipeline Layout Compatibility&gt;&gt; section.
		/// The descriptor set contents bound by a call to fname:vkCmdBindDescriptorSets may: be consumed during host execution of the command, or during shader execution of the resulting draws, or any time in between. Thus, the contents mustnot: be altered (overwritten by an update command, or freed) between when the command is recorded and when the command completes executing on the queue. The contents of pname:pDynamicOffsets are consumed immediately during execution of fname:vkCmdBindDescriptorSets. Once all pending uses have completed, it is legal to update and reuse a descriptor set.
		/// </summary>
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

		/// <summary>
		/// Bind an index buffer to a command buffer.
		/// </summary>
		public void BindIndexBuffer(Buffer buffer, DeviceSize offset, IndexType indexType)
		{
			unsafe
			{
				Interop.Buffer marshalledBuffer = buffer.Pack();
				Interop.Commands.vkCmdBindIndexBuffer(this.handle, marshalledBuffer, offset, indexType);


				Interop.HeapUtil.FreeLog();

			}
		}

		/// <summary>
		/// Bind vertex buffers to a command buffer
		/// The values taken from elements latexmath:[$i$] of pname:pBuffers and pname:pOffsets replace the current state for the vertex input binding latexmath:[$\mathit{firstBinding}+i$], for latexmath:[$i$] in latexmath:[$[0, bindingCount)$]. The vertex input binding is updated to start at the offset indicated by pname:pOffsets[i] from the start of the buffer pname:pBuffers[i]. All vertex input attributes that use each of these bindings will use these updated addresses in their address calculations for subsequent draw commands.
		/// </summary>
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

		/// <summary>
		/// Draw primitives.
		/// When the command is executed, primitives are assembled using the current primitive topology and pname:vertexCount consecutive vertex indices with the first code:vertexIndex value equal to pname:firstVertex. The primitives are drawn pname:instanceCount times with code:instanceIndex starting with pname:firstInstance and increasing sequentially for each instance. The assembled primitives execute the currently bound graphics pipeline.
		/// </summary>
		public void Draw(uint vertexCount, uint instanceCount, uint firstVertex, uint firstInstance)
		{
			unsafe
			{
				Interop.Commands.vkCmdDraw(this.handle, vertexCount, instanceCount, firstVertex, firstInstance);


				Interop.HeapUtil.FreeLog();

			}
		}

		/// <summary>
		/// Issue an indexed draw into a command buffer.
		/// When the command is executed, primitives are assembled using the current primitive topology and pname:indexCount vertices whose indices are retrieved from the index buffer. The index buffer is treated as an array of tightly packed unsigned integers of size defined by the flink:vkCmdBindIndexBuffer::pname:indexType parameter with which the buffer was bound.
		/// The first vertex index is at an offset of pname:firstIndex * code:indexSize + pname:offset within the currently bound index buffer, where pname:offset is the offset specified by fname:vkCmdBindIndexBuffer and code:indexSize is the byte size of the type specified by pname:indexType. Subsequent index values are retrieved from consecutive locations in the index buffer. Indices are first compared to the primitive restart value, then zero extended to 32 bits (if the code:indexType is ename:VK_INDEX_TYPE_UINT16) and have pname:vertexOffset added to them, before being supplied as the code:vertexIndex value.
		/// The primitives are drawn pname:instanceCount times with code:instanceIndex starting with pname:firstInstance and increasing sequentially for each instance. The assembled primitives execute the currently bound graphics pipeline.
		/// </summary>
		public void DrawIndexed(uint indexCount, uint instanceCount, uint firstIndex, int vertexOffset, uint firstInstance)
		{
			unsafe
			{
				Interop.Commands.vkCmdDrawIndexed(this.handle, indexCount, instanceCount, firstIndex, vertexOffset, firstInstance);


				Interop.HeapUtil.FreeLog();

			}
		}

		/// <summary>
		/// Issue an indirect draw into a command buffer.
		/// fname:vkCmdDrawIndirect behaves similarly to flink:vkCmdDraw except that the parameters are read by the device from a buffer during execution. pname:drawCount draws are executed by the command, with parameters taken from pname:buffer starting at pname:offset and increasing by pname:stride bytes for each successive draw. The parameters of each draw are encoded in an array of slink:VkDrawIndirectCommand structures. If pname:drawCount is less than or equal to one, pname:stride is ignored.
		/// </summary>
		public void DrawIndirect(Buffer buffer, DeviceSize offset, uint drawCount, uint stride)
		{
			unsafe
			{
				Interop.Buffer marshalledBuffer = buffer.Pack();
				Interop.Commands.vkCmdDrawIndirect(this.handle, marshalledBuffer, offset, drawCount, stride);


				Interop.HeapUtil.FreeLog();

			}
		}

		/// <summary>
		/// Perform an indexed indirect draw.
		/// fname:vkCmdDrawIndexedIndirect behaves similarly to flink:vkCmdDrawIndirect except that the parameters are read by the device from a buffer during execution. pname:drawCount draws are executed by the command, with parameters taken from pname:buffer starting at pname:offset and increasing by pname:stride bytes for each successive draw. The parameters of each draw are encoded in an array of slink:VkDrawIndexedIndirectCommand structures. If pname:drawCount is less than or equal to one, pname:stride is ignored.
		/// </summary>
		public void DrawIndexedIndirect(Buffer buffer, DeviceSize offset, uint drawCount, uint stride)
		{
			unsafe
			{
				Interop.Buffer marshalledBuffer = buffer.Pack();
				Interop.Commands.vkCmdDrawIndexedIndirect(this.handle, marshalledBuffer, offset, drawCount, stride);


				Interop.HeapUtil.FreeLog();

			}
		}

		/// <summary>
		/// Dispatch compute work items.
		/// When the command is executed, a global workgroup consisting of latexmath:[$x \times y \times z$] local workgroups is assembled.
		/// </summary>
		public void Dispatch(uint x, uint y, uint z)
		{
			unsafe
			{
				Interop.Commands.vkCmdDispatch(this.handle, x, y, z);


				Interop.HeapUtil.FreeLog();

			}
		}

		/// <summary>
		/// Dispatch compute work items using indirect parameters.
		/// fname:vkCmdDispatchIndirect behaves similarly to flink:vkCmdDispatch except that the parameters are read by the device from a buffer during execution. The parameters of the dispatch are encoded in a slink:VkDispatchIndirectCommand structure taken from pname:buffer starting at pname:offset.
		/// </summary>
		public void DispatchIndirect(Buffer buffer, DeviceSize offset)
		{
			unsafe
			{
				Interop.Buffer marshalledBuffer = buffer.Pack();
				Interop.Commands.vkCmdDispatchIndirect(this.handle, marshalledBuffer, offset);


				Interop.HeapUtil.FreeLog();

			}
		}

		/// <summary>
		/// Copy data between buffer regions.
		/// Each region in pname:pRegions is copied from the source buffer to the same region of the destination buffer. pname:srcBuffer and pname:dstBuffer can: be the same buffer or alias the same memory, but the result is undefined if the copy regions overlap in memory.
		/// </summary>
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

		/// <summary>
		/// Copy data between images.
		/// Each region in pname:pRegions is copied from the source image to the same region of the destination image. pname:srcImage and pname:dstImage can: be the same image or alias the same memory.
		/// Copies are done layer by layer starting with pname:baseArrayLayer member of pname:srcSubresource for the source and pname:dstSubresource for the destination. pname:layerCount layers are copied to the destination image.
		/// [[copies-images-format-compatibility]] The formats of pname:srcImage and pname:dstImage must: be compatible. Formats are considered compatible if their texel size in bytes is the same between both formats. For example, ename:VK_FORMAT_R8G8B8A8_UNORM is compatible with ename:VK_FORMAT_R32_UINT because both texels are 4 bytes in size. Depth/stencil formats must: match exactly.
		/// fname:vkCmdCopyImage allows copying between size-compatible compressed and uncompressed internal formats. Formats are size-compatible if the texel size of the uncompressed format is equal to the compressed texel block size in bytes of the compressed format. Such a copy does not perform on-the-fly compression or decompression. When copying from an uncompressed format to a compressed format, each texel of uncompressed data of the source image is copied as a raw value to the corresponding compressed texel block of the destination image. When copying from a compressed format to an uncompressed format, each compressed texel block of the source image is copied as a raw value to the corresponding texel of uncompressed data in the destination image. Thus, for example, it is legal to copy between a 128-bit uncompressed format and a compressed format which has a 128-bit sized compressed texel block representing 4x4 texels (using 8 bits per texel), or between a 64-bit uncompressed format and a compressed format which has a 64-bit sized compressed texel block representing 4x4 texels (using 4 bits per texel).
		/// When copying between compressed and uncompressed formats the pname:extent members represent the texel dimensions of the source image and not the destination. When copying from a compressed image to an uncompressed image the image texel dimensions written to the uncompressed image will be source extent divided by the compressed texel block dimensions. When copying from an uncompressed image to a compressed image the image texel dimensions written to the compressed image will be the source extent multiplied by the compressed texel block dimensions. In both cases the number of bytes read and the number of bytes written will be identical.
		/// Copying to or from block-compressed images is typically done in multiples of the compressed texel block. For this reason the pname:extent must: be a multiple of the compressed texel block dimension. There is one exception to this rule which is required: to handle compressed images created with dimensions that are not a multiple of the compressed texel block dimensions. If the pname:srcImage is compressed and if pname:extent.width is not a multiple of the compressed texel block width then (pname:extent.width + pname:srcOffset.x) must: equal the image subresource width, if pname:extent.height is not a multiple of the compressed texel block height then (pname:extent.height + pname:srcOffset.y) must: equal the image subresource height and if pname:extent.depth is not a multiple of the compressed texel block depth then (pname:extent.depth + pname:srcOffset.z) must: equal the image subresource depth. Similarly, if the pname:dstImage is compressed and if pname:extent.width is not a multiple of the compressed texel block width then (pname:extent.width + pname:dstOffset.x) must: equal the image subresource width, if pname:extent.height is not a multiple of the compressed texel block height then (pname:extent.height + pname:dstOffset.y) must: equal the image subresource height and if pname:extent.depth is not a multiple of the compressed texel block depth then (pname:extent.depth + pname:dstOffset.z) must: equal the image subresource depth. This allows the last compressed texel block of the image in each non-multiple dimension to be included as a source or destination of the copy.
		/// fname:vkCmdCopyImage can: be used to copy image data between multisample images, but both images must: have the same number of samples.
		/// </summary>
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

		/// <summary>
		/// Copy regions of an image, potentially performing format conversion,
		/// fname:vkCmdBlitImage mustnot: be used for multisampled source or destination images. Use flink:vkCmdResolveImage for this purpose.
		/// As the sizes of the source and destination extents can: differ in any dimension, texels in the source extent are scaled and filtered to the destination extent. Scaling occurs via the following operations:
		/// * For each destination texel, the integer coordinate of that texel is       converted to an unnormalized texture coordinate, using the effective       inverse of the equations described in       &lt;&lt;textures-unnormalized-to-integer, unnormalized to integer       conversion&gt;&gt;: [latexmath] ++++++++++++++++++++++++ \begin{align*} u_{base} &amp; = i + \frac{1}{2}\\ v_{base} &amp; = j + \frac{1}{2}\\ w_{base} &amp; = k + \frac{1}{2}\\ \end{align*} ++++++++++++++++++++++++     * These base coordinates are then offset by the first destination offset: [latexmath] ++++++++++++++++++++++++ \begin{align*} u_{offset} &amp; = u_{base} - x_{dst_0}\\ v_{offset} &amp; = v_{base} - y_{dst_0}\\ w_{offset} &amp; = w_{base} - z_{dst_0}\\ a_{offset} &amp; = a - baseArrayCount_{dst} \end{align*} ++++++++++++++++++++++++     * The scale is determined from the source and destination regions, and       applied to the offset coordinates: [latexmath] ++++++++++++++++++++++++ \begin{align*} scale_u &amp; = \frac{x_{src_1} - x_{src_0}}{x_{dst_1} - x_{dst_0}}\\ scale_v &amp; = \frac{y_{src_1} - y_{src_0}}{y_{dst_1} - y_{dst_0}}\\ scale_w &amp; = \frac{z_{src_1} - z_{src_0}}{z_{dst_1} - z_{dst_0}}\\ \\ u_{scaled} &amp; = u_{offset} * scale_u\\ v_{scaled} &amp; = v_{offset} * scale_v\\ w_{scaled} &amp; = w_{offset} * scale_w \end{align*} ++++++++++++++++++++++++     * Finally the source offset is added to the scaled coordinates, to       determine the final unnormalized coordinates used to sample from       pname:srcImage: [latexmath] ++++++++++++++++++++++++ \begin{align*} u &amp; = u_{scaled} + x_{src_0}\\ v &amp; = v_{scaled} + y_{src_0}\\ w &amp; = w_{scaled} + z_{src_0}\\ q &amp; = mipLevel\\ a &amp; = a_{offset} + baseArrayCount_{src} \end{align*} ++++++++++++++++++++++++
		/// These coordinates are used to sample from the source image, as described in &lt;&lt;textures, Image Operations chapter&gt;&gt;, with the filter mode equal to that of pname:filter, a mipmap mode of ename:VK_SAMPLER_MIPMAP_MODE_NEAREST and an address mode of ename:VK_SAMPLER_ADDRESS_MODE_CLAMP_TO_EDGE. Implementations must: clamp at the edge of the source image, and may: additionally clamp to the edge of the source region.
		/// [NOTE] .Note ==== Due to allowable rounding errors in the generation of the source texture coordinates, it is not always possible to guarantee exactly which source texels will be sampled for a given blit. As rounding errors are implementation dependent, the exact results of a blitting operation are also implementation dependent. ====
		/// Blits are done layer by layer starting with the pname:baseArrayLayer member of pname:srcSubresource for the source and pname:dstSubresource for the destination. pname:layerCount layers are blitted to the destination image.
		/// 3D textures are blitted slice by slice. Slices in the source region bounded by pname:srcOffsets[0].z and pname:srcOffsets[1].z are copied to slices in the destination region bounded by pname:dstOffsets[0].z and pname:dstOffsets[1].z. For each destination slice, a source z coordinate is linearly interpolated between pname:srcOffsets[0].z and pname:srcOffsets[1].z. If the pname:filter parameter is ename:VK_FILTER_LINEAR then the value sampled from the source image is taken by doing linear filtering using the interpolated z coordinate. If pname:filter parameter is ename:VK_FILTER_NEAREST then value sampled from the source image is taken from the single nearest slice (with undefined rounding mode).
		/// The following filtering and conversion rules apply:
		/// * Integer formats can: only be converted to other integer formats with the     same signedness.   * No format conversion is supported between depth/stencil images - the     formats must: match.   * Format conversions on unorm, snorm, unscaled and packed float formats of     the copied aspect of the image are performed by first converting the     pixels to float values.   * In case of sRGB source format, nonlinear RGB values are converted to     linear representation prior to filtering.   * After filtering, the float values are first clamped and then cast to the     destination image format. In case of sRGB destination format, linear RGB     values are converted to nonlinear representation before writing the     pixel to the image.
		/// Signed and unsigned integers are converted by first clamping to the representable range of the destination format, then casting the value.
		/// </summary>
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

		/// <summary>
		/// Copy data from a buffer into an image.
		/// Each region in pname:pRegions is copied from the specified region of the source buffer to the specified region of the destination image.
		/// </summary>
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

		/// <summary>
		/// Copy image data into a buffer.
		/// Each region in pname:pRegions is copied from the specified region of the source image to the specified region of the destination buffer.
		/// </summary>
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

		/// <summary>
		/// Update a buffer's contents from host memory.
		/// pname:dataSize must: be less than or equal to 65536 bytes. For larger updates, applications can: use buffer to buffer &lt;&lt;copies-buffers,copies&gt;&gt;.
		/// The source data is copied from the user pointer to the command buffer when the command is called.
		/// fname:vkCmdUpdateBuffer is only allowed outside of a render pass. This command is treated as ``transfer'' operation, for the purposes of synchronization barriers. The ename:VK_BUFFER_USAGE_TRANSFER_DST_BIT must: be specified in pname:usage of slink:VkBufferCreateInfo in order for the buffer to be compatible with fname:vkCmdUpdateBuffer.
		/// </summary>
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

		/// <summary>
		/// Fill a region of a buffer with a fixed value.
		/// fname:vkCmdFillBuffer is treated as ``transfer'' operation for the purposes of synchronization barriers. The ename:VK_BUFFER_USAGE_TRANSFER_DST_BIT must: be specified in pname:usage of sname:VkBufferCreateInfo in order for the buffer to be compatible with fname:vkCmdFillBuffer.
		/// </summary>
		public void FillBuffer(Buffer destinationBuffer, DeviceSize destinationOffset, DeviceSize size, uint data)
		{
			unsafe
			{
				Interop.Buffer marshalledDestinationBuffer = destinationBuffer.Pack();
				Interop.Commands.vkCmdFillBuffer(this.handle, marshalledDestinationBuffer, destinationOffset, size, data);


				Interop.HeapUtil.FreeLog();

			}
		}

		/// <summary>
		/// Clear regions of a color image.
		/// Each specified range in pname:pRanges is cleared to the value specified by pname:pColor.
		/// </summary>
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

		/// <summary>
		/// Fill regions of a combined depth-stencil image.
		/// </summary>
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

		/// <summary>
		/// Clear regions within currently bound framebuffer attachments.
		/// fname:vkCmdClearAttachments can: clear multiple regions of each attachment used in the current subpass of a render pass instance. This command must: be called only inside a render pass instance, and implicitly selects the images to clear based on the current framebuffer attachments and the command parameters.
		/// </summary>
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

		/// <summary>
		/// Resolve regions of an image.
		/// During the resolve the samples corresponding to each pixel location in the source are converted to a single sample before being written to the destination. If the source formats are floating-point or normalized types, the sample values for each pixel are resolved in an implementation-dependent manner. If the source formats are integer types, a single sample's value is selected for each pixel.
		/// pname:srcOffset and pname:dstOffset select the initial x, y, and z offsets in texels of the sub-regions of the source and destination image data. pname:extent is the size in texels of the source image to resolve in pname:width, pname:height and pname:depth. 1D images use only pname:x and pname:width. 2D images use pname:x, pname:y, pname:width and pname:height. 3D images use pname:x, pname:y, pname:z, pname:width, pname:height and pname:depth.
		/// Resolves are done layer by layer starting with pname:baseArrayLayer member of pname:srcSubresource for the source and pname:dstSubresource for the destination. pname:layerCount layers are resolved to the destination image.
		/// </summary>
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

		/// <summary>
		/// Set an event object to signaled state.
		/// </summary>
		public void SetEvent(Event @event, PipelineStageFlags stageMask)
		{
			unsafe
			{
				Interop.Event marshalledEvent = @event.Pack();
				Interop.Commands.vkCmdSetEvent(this.handle, marshalledEvent, stageMask);


				Interop.HeapUtil.FreeLog();

			}
		}

		/// <summary>
		/// Reset an event object to non-signaled state.
		/// </summary>
		public void ResetEvent(Event @event, PipelineStageFlags stageMask)
		{
			unsafe
			{
				Interop.Event marshalledEvent = @event.Pack();
				Interop.Commands.vkCmdResetEvent(this.handle, marshalledEvent, stageMask);


				Interop.HeapUtil.FreeLog();

			}
		}

		/// <summary>
		/// Wait for one or more events and insert a set of memory
		/// fname:vkCmdWaitEvents waits for events set by either fname:vkSetEvent or fname:vkCmdSetEvent to become signaled. Logically, it has three phases:
		/// . Wait at the pipeline stages specified by pname:dstStageMask (see     &lt;&lt;synchronization-pipeline-stage-flags&gt;&gt;) until the pname:eventCount     event objects specified by pname:pEvents become signaled.     Implementations may: wait for each event object to become signaled     in sequence (starting with the first event object in pname:pEvents,     and ending with the last), or wait for all of the event objects to     become signaled at the same time.   . Execute the memory barriers specified by pname:pMemoryBarriers,     pname:pBufferMemoryBarriers and pname:pImageMemoryBarriers (see     &lt;&lt;synchronization-memory-barriers&gt;&gt;).   . Resume execution of pipeline stages specified by pname:dstStageMask
		/// Implementations may: not execute commands in a pipelined manner, so fname:vkCmdWaitEvents may: not observe the results of a subsequent fname:vkCmdSetEvent or fname:vkCmdResetEvent command, even if the stages in pname:dstStageMask occur after the stages in pname:srcStageMask.
		/// Commands that update the state of events in different pipeline stages may: execute out of order, unless the ordering is enforced by execution dependencies.
		/// [NOTE] .Note ==== Applications should: be careful to avoid race conditions when using events. For example, an event should: only be reset if no fname:vkCmdWaitEvents command is executing that waits upon that event. ====
		/// </summary>
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

		/// <summary>
		/// Insert a set of execution and memory barriers.
		/// Each element of the pname:pMemoryBarriers, pname:pBufferMemoryBarriers and pname:pImageMemoryBarriers arrays specifies two halves of a memory dependency, as defined above. Specifics of each type of memory barrier and the memory access types are defined further in &lt;&lt;synchronization-memory-barriers,Memory Barriers&gt;&gt;.
		/// If fname:vkCmdPipelineBarrier is called outside a render pass instance, then the first set of commands is all prior commands submitted to the queue and recorded in the command buffer and the second set of commands is all subsequent commands recorded in the command buffer and submitted to the queue. If fname:vkCmdPipelineBarrier is called inside a render pass instance, then the first set of commands is all prior commands in the same subpass and the second set of commands is all subsequent commands in the same subpass.
		/// </summary>
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

		/// <summary>
		/// Begin a query.
		/// If the pname:queryType of the pool is ename:VK_QUERY_TYPE_OCCLUSION and pname:flags contains ename:VK_QUERY_CONTROL_PRECISE_BIT, an implementation must: return a result that matches the actual number of samples passed. This is described in more detail in &lt;&lt;queries-occlusion,Occlusion Queries&gt;&gt;.
		/// [[queries-operation-active]] After beginning a query, that query is considered _active_ within the command buffer it was called in until that same query is ended. Queries active in a primary command buffer when secondary command buffers are executed are considered active for those secondary command buffers.
		/// </summary>
		public void BeginQuery(QueryPool queryPool, uint query, QueryControlFlags flags)
		{
			unsafe
			{
				Interop.QueryPool marshalledQueryPool = queryPool.Pack();
				Interop.Commands.vkCmdBeginQuery(this.handle, marshalledQueryPool, query, flags);


				Interop.HeapUtil.FreeLog();

			}
		}

		/// <summary>
		/// Ends a query.
		/// [[queries-operation-finished]] As queries operate asynchronously, ending a query does not immediately set the query's status to available. A query is considered _finished_ when the final results of the query are ready to be retrieved by flink:vkGetQueryPoolResults and flink:vkCmdCopyQueryPoolResults, and this is when the query's status is set to available.
		/// Once a query is ended the query must: finish in finite time, unless the state of the query is changed using other commands, e.g. by issuing a reset of the query.
		/// </summary>
		public void EndQuery(QueryPool queryPool, uint query)
		{
			unsafe
			{
				Interop.QueryPool marshalledQueryPool = queryPool.Pack();
				Interop.Commands.vkCmdEndQuery(this.handle, marshalledQueryPool, query);


				Interop.HeapUtil.FreeLog();

			}
		}

		/// <summary>
		/// Reset queries in a query pool.
		/// When executed on a queue, this command sets the status of query indices latexmath:[$firstQuery,firstQuery+queryCount-1$] to unavailable.
		/// </summary>
		public void ResetQueryPool(QueryPool queryPool, uint firstQuery, uint queryCount)
		{
			unsafe
			{
				Interop.QueryPool marshalledQueryPool = queryPool.Pack();
				Interop.Commands.vkCmdResetQueryPool(this.handle, marshalledQueryPool, firstQuery, queryCount);


				Interop.HeapUtil.FreeLog();

			}
		}

		/// <summary>
		/// Write a device timestamp into a query object.
		/// fname:vkCmdWriteTimestamp latches the value of the timer when all previous commands have completed executing as far as the specified pipeline stage, and writes the timestamp value to memory. When the timestamp value is written, the availability status of the query is set to available.
		/// [NOTE] .Note ==== If an implementation is unable to detect completion and latch the timer at any specific stage of the pipeline, it may: instead do so at any logically later stage. ====
		/// flink:vkCmdCopyQueryPoolResults can: then be called to copy the timestamp value from the query pool into buffer memory, with ordering and synchronization behavior equivalent to how other queries operate. Timestamp values can: also be retrieved from the query pool using flink:vkGetQueryPoolResults. As with other queries, the query must: be reset using flink:vkCmdResetQueryPool before requesting the timestamp value be written to it.
		/// While fname:vkCmdWriteTimestamp can: be called inside or outside of a render pass instance, flink:vkCmdCopyQueryPoolResults must: only be called outside of a render pass instance.
		/// </summary>
		public void WriteTimestamp(PipelineStageFlags pipelineStage, QueryPool queryPool, uint query)
		{
			unsafe
			{
				Interop.QueryPool marshalledQueryPool = queryPool.Pack();
				Interop.Commands.vkCmdWriteTimestamp(this.handle, pipelineStage, marshalledQueryPool, query);


				Interop.HeapUtil.FreeLog();

			}
		}

		/// <summary>
		/// Copy the results of queries in a query pool to a buffer object.
		/// fname:vkCmdCopyQueryPoolResults is guaranteed to see the effect of previous uses of fname:vkCmdResetQueryPool in the same queue, without any additional synchronization. Thus, the results will always reflect the most recent use of the query.
		/// pname:flags has the same possible values described above for the pname:flags parameter of flink:vkGetQueryPoolResults, but the different style of execution causes some subtle behavioral differences. Because fname:vkCmdCopyQueryPoolResults executes in order with respect to other query commands, there is less ambiguity about which use of a query is being requested.
		/// If no bits are set in pname:flags, results for all requested queries in the available state are written as 32-bit unsigned integer values, and nothing is written for queries in the unavailable state.
		/// If ename:VK_QUERY_RESULT_64_BIT is set, the results are written as an array of 64-bit unsigned integer values as described for flink:vkGetQueryPoolResults.
		/// If ename:VK_QUERY_RESULT_WAIT_BIT is set, the implementation will wait for each query's status to be in the available state before retrieving the numerical results for that query. This is guaranteed to reflect the most recent use of the query on the same queue, assuming that the query is not being simultaneously used by other queues. If the query does not become available in a finite amount of time (e.g. due to not issuing a query since the last reset), a ename:VK_ERROR_DEVICE_LOST error may: occur.
		/// Similarly, if ename:VK_QUERY_RESULT_WITH_AVAILABILITY_BIT is set and ename:VK_QUERY_RESULT_WAIT_BIT is not set, the availability is guaranteed to reflect the most recent use of the query on the same queue, assuming that the query is not being simultaneously used by other queues. As with fname:vkGetQueryPoolResults, implementations must: guarantee that if they return a non-zero availability value, then the numerical results are valid.
		/// If ename:VK_QUERY_RESULT_PARTIAL_BIT is set, ename:VK_QUERY_RESULT_WAIT_BIT is not set, and the query's status is unavailable, an intermediate result value between zero and the final result value is written for that query.
		/// ename:VK_QUERY_RESULT_PARTIAL_BIT mustnot: be used if the pool's pname:queryType is ename:VK_QUERY_TYPE_TIMESTAMP.
		/// fname:vkCmdCopyQueryPoolResults is considered to be a transfer operation, and its writes to buffer memory must: be synchronized using ename:VK_PIPELINE_STAGE_TRANSFER_BIT and ename:VK_ACCESS_TRANSFER_WRITE_BIT before using the results.
		/// </summary>
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

		/// <summary>
		/// Update the values of push constants.
		/// </summary>
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

		/// <summary>
		/// Begin a new render pass.
		/// After beginning a render pass instance, the command buffer is ready to record the commands for the first subpass of that render pass.
		/// </summary>
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

		/// <summary>
		/// Transition to the next subpass of a render pass.
		/// The subpass index for a render pass begins at zero when fname:vkCmdBeginRenderPass is recorded, and increments each time fname:vkCmdNextSubpass is recorded.
		/// Moving to the next subpass automatically performs any multisample resolve operations in the subpass being ended. End-of-subpass multisample resolves are treated as color attachment writes for the purposes of synchronization. That is, they are considered to execute in the ename:VK_PIPELINE_STAGE_COLOR_ATTACHMENT_OUTPUT_BIT pipeline stage and their writes are synchronized with ename:VK_ACCESS_COLOR_ATTACHMENT_WRITE_BIT. Synchronization between rendering within a subpass and any resolve operations at the end of the subpass occurs automatically, without need for explicit dependencies or pipeline barriers. However, if the resolve attachment is also used in a different subpass, an explicit dependency is needed.
		/// After transitioning to the next subpass, the application can: record the commands for that subpass.
		/// </summary>
		public void NextSubpass(SubpassContents contents)
		{
			unsafe
			{
				Interop.Commands.vkCmdNextSubpass(this.handle, contents);


				Interop.HeapUtil.FreeLog();

			}
		}

		/// <summary>
		/// End the current render pass.
		/// Ending a render pass instance performs any multisample resolve operations on the final subpass.
		/// </summary>
		public void EndRenderPass()
		{
			unsafe
			{
				Interop.Commands.vkCmdEndRenderPass(this.handle);


				Interop.HeapUtil.FreeLog();

			}
		}

		/// <summary>
		/// Execute a secondary command buffer from a primary command buffer.
		/// Once fname:vkCmdExecuteCommands has been called, any prior executions of the secondary command buffers specified by pname:pCommandBuffers in any other primary command buffer become invalidated, unless those secondary command buffers were recorded with ename:VK_COMMAND_BUFFER_USAGE_SIMULTANEOUS_USE_BIT.
		/// </summary>
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

		/// <summary>
		/// -
		/// </summary>
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

		/// <summary>
		/// -
		/// </summary>
		public void DebugMarkerEnd()
		{
			unsafe
			{
				Interop.Commands.vkCmdDebugMarkerEndEXT(this.handle);


				Interop.HeapUtil.FreeLog();

			}
		}

		/// <summary>
		/// -
		/// </summary>
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
    /// Opaque handle to a command pool object
    /// Command pools are opaque objects that command buffer memory is allocated from, and which allow the implementation to amortize the cost of resource creation across multiple command buffers. Command pools are application-synchronized, meaning that a command pool mustnot: be used concurrently in multiple threads. That includes use via recording commands on any command buffers allocated from the pool, as well as operations that allocate, free, and reset command buffers or the pool itself.
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

		/// <summary>
		/// Destroy a command pool object
		/// When a pool is destroyed, all command buffers allocated from the pool are implicitly freed and become invalid. Command buffers allocated from a given pool do not need to be freed before destroying that command pool.
		/// </summary>
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

		/// <summary>
		/// Reset a command pool.
		/// Resetting a command pool recycles all of the resources from all of the command buffers allocated from the command pool back to the command pool. All command buffers that have been allocated from the command pool are put in the initial state.
		/// </summary>
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

		/// <summary>
		/// Free command buffers.
		/// </summary>
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

		/// <summary>
		/// Releases the unmanaged resources associated with this instance and
		/// destroys the underlying Vulkan handle.
		/// </summary>
		public void Dispose()
		{
			this.Destroy();
		}
	}

    /// <summary>
    /// -
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

		/// <summary>
		/// -
		/// </summary>
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

		/// <summary>
		/// Releases the unmanaged resources associated with this instance and
		/// destroys the underlying Vulkan handle.
		/// </summary>
		public void Dispose()
		{
			this.Destroy();
		}
	}

    /// <summary>
    /// Opaque handle to a descriptor pool object
    /// A _descriptor pool_ maintains a pool of descriptors, from which descriptor sets are allocated. Descriptor pools are externally synchronized, meaning that the application mustnot: allocate and/or free descriptor sets from the same pool in multiple threads simultaneously.
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

		/// <summary>
		/// Destroy a descriptor pool object
		/// When a pool is destroyed, all descriptor sets allocated from the pool are implicitly freed and become invalid. Descriptor sets allocated from a given pool do not need to be freed before destroying that descriptor pool.
		/// </summary>
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

		/// <summary>
		/// Resets a descriptor pool object.
		/// Resetting a descriptor pool recycles all of the resources from all of the descriptor sets allocated from the descriptor pool back to the descriptor pool, and the descriptor sets are implicitly freed.
		/// </summary>
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

		/// <summary>
		/// Free one or more descriptor sets
		/// After a successful call to fname:vkFreeDescriptorSets, all descriptor sets in pname:pDescriptorSets are invalid.
		/// </summary>
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

		/// <summary>
		/// Releases the unmanaged resources associated with this instance and
		/// destroys the underlying Vulkan handle.
		/// </summary>
		public void Dispose()
		{
			this.Destroy();
		}
	}

    /// <summary>
    /// Opaque handle to a descriptor set object
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
    /// Opaque handle to a descriptor set layout object
    /// A descriptor set layout object is defined by an array of zero or more descriptor bindings. Each individual descriptor binding is specified by a descriptor type, a count (array size) of the number of descriptors in the binding, a set of shader stages that can: access the binding, and (if using immutable samplers) an array of sampler descriptors.
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

		/// <summary>
		/// Destroy a descriptor set layout object
		/// </summary>
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

		/// <summary>
		/// Releases the unmanaged resources associated with this instance and
		/// destroys the underlying Vulkan handle.
		/// </summary>
		public void Dispose()
		{
			this.Destroy();
		}
	}

    /// <summary>
    /// Opaque handle to a device object
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

		/// <summary>
		/// Return a function pointer for a command
		/// The returned function pointer is of type tlink:PFN_vkVoidFunction, and must be cast to the type of the command being queried.
		/// .vkGetDeviceProcAddr behavior [width="80%",options="header",align="center"] |===== | pname:device | pname:pName | return value | NULL | * | undefined | invalid device | * | undefined | device | NULL | undefined | device | core Vulkan command^1^ | fp | device | enabled device extension commands for pname:device | fp | device | * (any pname:pName not covered above) | NULL |=====
		/// 1:: pname:pName is the name of any Vulkan command whose first parameter     is sname:VkDevice or any of its dispatchable children (e.g. sname:VkQueue,     sname:vkCommandBuffer).
		/// </summary>
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

		/// <summary>
		/// Destroy a logical device.
		/// To ensure that no work is active on the device, flink:vkDeviceWaitIdle can: be used to gate the destruction of the device. Prior to destroying a device, an application is responsible for destroying/freeing any Vulkan objects that were created using that device as the first parameter of the corresponding ftext:vkCreate* or ftext:vkAllocate* command.
		/// [NOTE] .Note ==== The lifetime of each of these objects is bound by the lifetime of the sname:VkDevice object. Therefore, to avoid resource leaks, it is critical that an application explicitly free all of these resources prior to calling fname:vkDestroyDevice. ====
		/// </summary>
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

		/// <summary>
		/// Get a queue handle from a device.
		/// </summary>
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

		/// <summary>
		/// Wait for a device to become idle.
		/// fname:vkDeviceWaitIdle is equivalent to calling fname:vkQueueWaitIdle for all queues owned by pname:device.
		/// </summary>
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

		/// <summary>
		/// Allocate GPU memory.
		/// Allocations returned by fname:vkAllocateMemory are guaranteed to meet any alignment requirement by the implementation. For example, if an implementation requires 128 byte alignment for images and 64 byte alignment for buffers, the device memory returned through this mechanism would be 128-byte aligned. This ensures that applications can: correctly suballocate objects of different types (with potentially different alignment requirements) in the same memory object.
		/// When memory is allocated, its contents are undefined.
		/// There is an implementation-dependent maximum number of memory allocations which can: be simultaneously created on a device. This is specified by the &lt;&lt;features-limits-maxMemoryAllocationCount,pname:maxMemoryAllocationCount&gt;&gt; member of the sname:VkPhysicalDeviceLimits structure. If pname:maxMemoryAllocationCount is exceeded, fname:vkAllocateMemory will return ename:VK_ERROR_TOO_MANY_OBJECTS.
		/// [NOTE] .Note ==== Some platforms may: have a limit on the maximum size of a single allocation. For example, certain systems may: fail to create allocations with a size greater than or equal to 4GB. Such a limit is implementation-dependent, and if such a failure occurs then the error ename:VK_ERROR_OUT_OF_DEVICE_MEMORY should: be returned. ====
		/// </summary>
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

		/// <summary>
		/// Free GPU memory
		/// Before freeing a memory object, an application must: ensure the memory object is no longer in use by the device--for example by command buffers queued for execution. The memory can: remain bound to images or buffers at the time the memory object is freed, but any further use of them (on host or device) for anything other than destroying those objects will result in undefined behavior. If there are still any bound images or buffers, the memory may: not be immediately released by the implementation, but must: be released by the time all bound images and buffers have been destroyed. Once memory is released, it is returned to the heap from which it was allocated.
		/// How memory objects are bound to Images and Buffers is described in detail in the &lt;&lt;resources-association, Resource Memory Association&gt;&gt; section.
		/// If a memory object is mapped at the time it is freed, it is implicitly unmapped.
		/// </summary>
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

		/// <summary>
		/// Flush mapped memory ranges.
		/// fname:vkFlushMappedMemoryRanges must: be used to guarantee that host writes to non-coherent memory are visible to the device. It must: be called after the host writes to non-coherent memory have completed and before command buffers that will read or write any of those memory locations are submitted to a queue.
		/// </summary>
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

		/// <summary>
		/// Invalidate ranges of mapped memory objects.
		/// fname:vkInvalidateMappedMemoryRanges must: be used to guarantee that device writes to non-coherent memory are visible to the host. It must: be called after command buffers that execute and flush (via memory barriers) the device writes have completed, and before the host will read or write any of those locations. If a range of non-coherent memory is written by the host and then invalidated without first being flushed, its contents are undefined.
		/// </summary>
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

		/// <summary>
		/// Create a new fence object.
		/// To create a new fence object, use the command
		/// </summary>
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

		/// <summary>
		/// Resets one or more fence objects.
		/// If a fence is already in the unsignaled state, then resetting it has no effect.
		/// </summary>
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

		/// <summary>
		/// Wait for one or more fences to become signaled.
		/// If the condition is satisfied when fname:vkWaitForFences is called, then fname:vkWaitForFences returns immediately. If the condition is not satisfied at the time fname:vkWaitForFences is called, then fname:vkWaitForFences will block and wait up to pname:timeout nanoseconds for the condition to become satisfied.
		/// If pname:timeout is zero, then fname:vkWaitForFences does not wait, but simply returns the current state of the fences. ename:VK_TIMEOUT will be returned in this case if the condition is not satisfied, even though no actual wait was performed.
		/// If the specified timeout period expires before the condition is satisfied, fname:vkWaitForFences returns ename:VK_TIMEOUT. If the condition is satisfied before pname:timeout nanoseconds has expired, fname:vkWaitForFences returns ename:VK_SUCCESS.
		/// [[synchronization-fences-devicewrites]] fname:vkWaitForFences defines the second half of a memory dependency with the host, for each fence being waited on. The memory dependency defined by signaling a fence and waiting on the host does not guarantee that the results of memory accesses will be visible to the host, or that the memory is available. To provide that guarantee, the application must: insert a memory barrier between the device writes and the end of the submission that will signal the fence, with pname:dstAccessMask having the ename:VK_ACCESS_HOST_READ_BIT bit set, with pname:dstStageMask having the ename:VK_PIPELINE_STAGE_HOST_BIT bit set, and with the appropriate pname:srcStageMask and pname:srcAccessMask members set to guarantee completion of the writes. If the memory was allocated without the ename:VK_MEMORY_PROPERTY_HOST_COHERENT_BIT set, then fname:vkInvalidateMappedMemoryRanges must: be called after the fence is signaled in order to ensure the writes are visible to the host, as described in &lt;&lt;memory-device-hostaccess,Host Access to Device Memory Objects&gt;&gt;.
		/// </summary>
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

		/// <summary>
		/// Create a new queue semaphore object.
		/// To create a new semaphore object, use the command
		/// </summary>
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

		/// <summary>
		/// Create a new event object.
		/// When created, the event object is in the unsignaled state.
		/// </summary>
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

		/// <summary>
		/// Create a new query pool object.
		/// </summary>
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

		/// <summary>
		/// Create a new buffer object.
		/// </summary>
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

		/// <summary>
		/// Create a new buffer view object.
		/// </summary>
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

		/// <summary>
		/// Create a new image object.
		/// </summary>
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

		/// <summary>
		/// Create an image view from an existing image.
		/// Some of the image creation parameters are inherited by the view. The remaining parameters are contained in the pname:pCreateInfo.
		/// </summary>
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

		/// <summary>
		/// Creates a new shader module object.
		/// Once a shader module has been created, any entry points it contains can: be used in pipeline shader stages as described in &lt;&lt;pipelines-compute,Compute Pipelines&gt;&gt; and &lt;&lt;pipelines-graphics,Graphics Pipelines&gt;&gt;.
		/// </summary>
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

		/// <summary>
		/// Creates a new pipeline cache
		/// [NOTE] .Note ==== Applications can: track and manage the total host memory size of a pipeline cache object using the pname:pAllocator.  Applications can: limit the amount of data retrieved from a pipeline cache object in fname:vkGetPipelineCacheData. Implementations shouldnot: internally limit the total number of entries added to a pipeline cache object or the total host memory consumed. ====
		/// Once created, a pipeline cache can: be passed to the fname:vkCreateGraphicsPipelines and fname:vkCreateComputePipelines commands. If the pipeline cache passed into these commands is not dlink:VK_NULL_HANDLE, the implementation will query it for possible reuse opportunities and update it with new content. The use of the pipeline cache object in these commands is internally synchronized, and the same pipeline cache object can: be used in multiple threads simultaneously.
		/// [NOTE] .Note ==== Implementations should: make every effort to limit any critical sections to the actual accesses to the cache, which is expected to be significantly shorter than the duration of the fname:vkCreateGraphicsPipelines and fname:vkCreateComputePipelines commands. ====
		/// </summary>
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

		/// <summary>
		/// Create graphics pipelines.
		/// The slink:VkGraphicsPipelineCreateInfo structure includes an array of shader create info structures containing all the desired active shader stages, as well as creation info to define all relevant fixed-function stages, and a pipeline layout.
		/// </summary>
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

		/// <summary>
		/// Creates a new compute pipeline object.
		/// </summary>
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

		/// <summary>
		/// Creates a new pipeline layout object.
		/// </summary>
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

		/// <summary>
		/// Create a new sampler object
		/// </summary>
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

		/// <summary>
		/// Create a new descriptor set layout.
		/// </summary>
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

		/// <summary>
		/// Creates a descriptor pool object.
		/// pname:pAllocator controls host memory allocation as described in the &lt;&lt;memory-allocation, Memory Allocation&gt;&gt; chapter.
		/// The created descriptor pool is returned in pname:pDescriptorPool.
		/// </summary>
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

		/// <summary>
		/// Allocate one or more descriptor sets.
		/// The allocated descriptor sets are returned in pname:pDescriptorSets.
		/// When a descriptor set is allocated, the initial state is largely uninitialized and all descriptors are undefined. However, the descriptor set can: be bound in a command buffer without causing errors or exceptions. All entries that are statically used by a pipeline in a drawing or dispatching command must: have been populated before the descriptor set is bound for use by that command. Entries that are not statically used by a pipeline can: have uninitialized descriptors or descriptors of resources that have been destroyed, and executing a draw or dispatch with such a descriptor set bound does not cause undefined behavior. This means applications need not populate unused entries with dummy descriptors.
		/// If an allocation fails due to fragmentation, an indeterminate error is returned with an unspecified error code. Any returned error other than ename:VK_ERROR_FRAGMENTED_POOL does not imply its usual meaning: applications should: assume that the allocation failed due to fragmentation, and create a new descriptor pool.
		/// [NOTE] .Note ==== Applications should check for a negative return value when allocating new descriptor sets, assume that any error effectively means ename:VK_ERROR_FRAGMENTED_POOL, and try to create a new descriptor pool. If ename:VK_ERROR_FRAGMENTED_POOL is the actual return value, it adds certainty to that decision.
		/// The reason for this is that ename:VK_ERROR_FRAGMENTED_POOL was only added in a later revision of the 1.0 specification, and so drivers may: return other errors if they were written against earlier revisions. To ensure full compatibility with earlier patch revisions, these other errors are allowed. ====
		/// </summary>
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

		/// <summary>
		/// Update the contents of a descriptor set object.
		/// The operations described by pname:pDescriptorWrites are performed first, followed by the operations described by pname:pDescriptorCopies. Within each array, the operations are performed in the order they appear in the array.
		/// Each element in the pname:pDescriptorWrites array describes an operation updating the descriptor set using descriptors for resources specified in the structure.
		/// Each element in the pname:pDescriptorCopies array is a slink:VkCopyDescriptorSet structure describing an operation copying descriptors between sets.
		/// </summary>
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

		/// <summary>
		/// Create a new framebuffer object.
		/// </summary>
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

		/// <summary>
		/// Create a new render pass object.
		/// </summary>
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

		/// <summary>
		/// Create a new command pool object.
		/// </summary>
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

		/// <summary>
		/// Allocate command buffers from an existing command pool
		/// </summary>
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

		/// <summary>
		/// -
		/// </summary>
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

		/// <summary>
		/// -
		/// </summary>
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

		/// <summary>
		/// -
		/// </summary>
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

		/// <summary>
		/// -
		/// </summary>
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

		/// <summary>
		/// Releases the unmanaged resources associated with this instance and
		/// destroys the underlying Vulkan handle.
		/// </summary>
		public void Dispose()
		{
			this.Destroy();
		}
	}

    /// <summary>
    /// Opaque handle to a device memory object
    /// A Vulkan device operates on data in device memory via memory objects that are represented in the API by a sname:VkDeviceMemory handle.
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

		/// <summary>
		/// Map a memory object into application address space.
		/// It is an application error to call fname:vkMapMemory on a memory object that is already mapped.
		/// [[memory-device-hostaccess-hazards]] fname:vkMapMemory does not check whether the device memory is currently in use before returning the host-accessible pointer. The application must: guarantee that any previously submitted command that writes to this range has completed before the host reads from or writes to that range, and that any previously submitted command that reads from that range has completed before the host writes to that region (see &lt;&lt;synchronization-fences-devicewrites, here&gt;&gt; for details on fulfilling such a guarantee). If the device memory was allocated without the ename:VK_MEMORY_PROPERTY_HOST_COHERENT_BIT set, these guarantees must: be made for an extended range: the application must: round down the start of the range to the nearest multiple of sname:VkPhysicalDeviceLimits::pname:nonCoherentAtomSize, and round the end of the range up to the nearest multiple of sname:VkPhysicalDeviceLimits::pname:nonCoherentAtomSize.
		/// While a range of device memory is mapped for host access, the application is responsible for synchronizing both device and host access to that memory range.
		/// [NOTE] .Note ==== It is important for the application developer to become meticulously familiar with all of the mechanisms described in the chapter on &lt;&lt;synchronization, Synchronization and Cache Control&gt;&gt; as they are crucial to maintaining memory access ordering. ====
		/// </summary>
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

		/// <summary>
		/// Unmap a previously mapped memory object.
		/// </summary>
		public void UnmapMemory()
		{
			unsafe
			{
				Interop.Commands.vkUnmapMemory(this.parent.handle, this.handle);


				Interop.HeapUtil.FreeLog();

			}
		}

		/// <summary>
		/// Query the current commitment for a VkDeviceMemory
		/// The implementation may: update the commitment at any time, and the value returned by this query may: be out of date.
		/// The implementation guarantees to allocate any committed memory from the heapIndex indicated by the memory type that the memory object was created with.
		/// </summary>
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
    /// -
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
    /// -
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

		/// <summary>
		/// -
		/// </summary>
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
    /// Opaque handle to a event object
    /// Events represent a fine-grained synchronization primitive that can: be used to gauge progress through a sequence of commands executed on a queue by Vulkan. An event is initially in the unsignaled state. It can: be signaled by a device, using commands inserted into the command buffer, or by the host. It can: also be reset to the unsignaled state by a device or the host. The host can: query the state of an event. A device can: wait for one or more events to become signaled.
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

		/// <summary>
		/// Destroy an event object
		/// </summary>
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

		/// <summary>
		/// Retrieve the status of an event object.
		/// Upon success, fname:vkGetEventStatus returns the state of the event object with the following return codes:
		/// [width="80%",options="header"] |===== | Status | Meaning | ename:VK_EVENT_SET | The event specified by pname:event is signaled. | ename:VK_EVENT_RESET | The event specified by pname:event is unsignaled. |=====
		/// The state of an event can: be updated by the host. The state of the event is immediately changed, and subsequent calls to fname:vkGetEventStatus will return the new state. If an event is already in the requested state, then updating it to the same state has no effect.
		/// </summary>
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

		/// <summary>
		/// Set an event to signaled state.
		/// </summary>
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

		/// <summary>
		/// Reset an event to non-signaled state.
		/// </summary>
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

		/// <summary>
		/// Releases the unmanaged resources associated with this instance and
		/// destroys the underlying Vulkan handle.
		/// </summary>
		public void Dispose()
		{
			this.Destroy();
		}
	}

    /// <summary>
    /// Opaque handle to a fence object
    /// Fences can: be used by the host to determine completion of execution of _queue operations_.
    /// A fence's status is always either _signaled_ or _unsignaled_. The host can: poll the status of a single fence, or wait for any or all of a group of fences to become signaled.
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

		/// <summary>
		/// Destroy a fence object
		/// </summary>
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

		/// <summary>
		/// Return the status of a fence.
		/// To query the status of a fence from the host, use the command
		/// Upon success, fname:vkGetFenceStatus returns the status of the fence, which is one of:
		/// * ename:VK_SUCCESS indicates that the fence is signaled.   * ename:VK_NOT_READY indicates that the fence is unsignaled.
		/// </summary>
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

		/// <summary>
		/// Releases the unmanaged resources associated with this instance and
		/// destroys the underlying Vulkan handle.
		/// </summary>
		public void Dispose()
		{
			this.Destroy();
		}
	}

    /// <summary>
    /// Opaque handle to a framebuffer object
    /// Render passes operate in conjunction with _framebuffers_. Framebuffers represent a collection of specific memory attachments that a render pass instance uses.
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

		/// <summary>
		/// Destroy a framebuffer object
		/// </summary>
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

		/// <summary>
		/// Releases the unmanaged resources associated with this instance and
		/// destroys the underlying Vulkan handle.
		/// </summary>
		public void Dispose()
		{
			this.Destroy();
		}
	}

    /// <summary>
    /// Opaque handle to a image object
    /// Images represent multidimensional - up to 3 - arrays of data which can: be used for various purposes (e.g. attachments, textures), by binding them to a graphics or compute pipeline via descriptor sets, or by directly specifying them as parameters to certain commands.
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

		/// <summary>
		/// Bind device memory to an image object
		/// </summary>
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

		/// <summary>
		/// Returns the memory requirements for specified Vulkan object.
		/// </summary>
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

		/// <summary>
		/// Query the memory requirements for a sparse image.
		/// If pname:pSparseMemoryRequirements is `NULL`, then the number of sparse memory requirements available is returned in pname:pSparseMemoryRequirementCount. Otherwise, pname:pSparseMemoryRequirementCount must: point to a variable set by the user to the number of elements in the pname:pSparseMemoryRequirements array, and on return the variable is overwritten with the number of structures actually written to pname:pSparseMemoryRequirements. If pname:pSparseMemoryRequirementCount is less than the number of sparse memory requirements available, at most pname:pSparseMemoryRequirementCount structures will be written.
		/// If the image was not created with ename:VK_IMAGE_CREATE_SPARSE_RESIDENCY_BIT then pname:pSparseMemoryRequirementCount will be set to zero and pname:pSparseMemoryRequirements will not be written to.
		/// [NOTE] .Note ==== It is legal for an implementation to report a larger value in sname:VkMemoryRequirements::pname:size than would be obtained by adding together memory sizes for all sname:VkSparseImageMemoryRequirements returned by fname:vkGetImageSparseMemoryRequirements. This may: occur when the hardware requires unused padding in the address range describing the resource. ====
		/// </summary>
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

		/// <summary>
		/// Destroy an image object
		/// </summary>
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

		/// <summary>
		/// Retrieve information about an image subresource.
		/// flink:vkGetImageSubresourceLayout is invariant for the lifetime of a single image.
		/// </summary>
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

		/// <summary>
		/// Releases the unmanaged resources associated with this instance and
		/// destroys the underlying Vulkan handle.
		/// </summary>
		public void Dispose()
		{
			this.Destroy();
		}
	}

    /// <summary>
    /// Opaque handle to a image view object
    /// Image objects are not directly accessed by pipeline shaders for reading or writing image data. Instead, _image views_ representing contiguous ranges of the image subresources and containing additional metadata are used for that purpose. Views must: be created on images of compatible types, and must: represent a valid subset of image subresources.
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

		/// <summary>
		/// Destroy an image view object
		/// </summary>
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

		/// <summary>
		/// Releases the unmanaged resources associated with this instance and
		/// destroys the underlying Vulkan handle.
		/// </summary>
		public void Dispose()
		{
			this.Destroy();
		}
	}

    /// <summary>
    /// Opaque handle to a instance object
    /// There is no global state in Vulkan and all per-application state is stored in a sname:VkInstance object. Creating a sname:VkInstance object initializes the Vulkan library and allows the application to pass information about itself to the implementation.
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

		/// <summary>
		/// Create a new Vulkan instance
		/// fname:vkCreateInstance creates the instance, then enables and initializes global layers and extensions requested by the application. If an extension is provided by a layer, both the layer and extension must: be specified at fname:vkCreateInstance time. If a specified layer cannot be found, no sname:VkInstance will be created and the function will return ename:VK_ERROR_LAYER_NOT_PRESENT. Likewise, if a specified extension cannot be found the call will return ename:VK_ERROR_EXTENSION_NOT_PRESENT.
		/// </summary>
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

		/// <summary>
		/// Destroy an instance of Vulkan.
		/// </summary>
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

		/// <summary>
		/// Enumerates the physical devices accessible to a Vulkan instance.
		/// If pname:pPhysicalDevices is `NULL`, then the number of physical devices available is returned in pname:pPhysicalDeviceCount. Otherwise, pname:pPhysicalDeviceCount must: point to a variable set by the user to the number of elements in the pname:pPhysicalDevices array, and on return the variable is overwritten with the number of structures actually written to pname:pPhysicalDevices. If pname:pPhysicalDeviceCount is less than the number of physical devices available, at most pname:pPhysicalDeviceCount structures will be written. If pname:pPhysicalDeviceCount is smaller than the number of physical devices available, ename:VK_INCOMPLETE will be returned instead of ename:VK_SUCCESS, to indicate that not all the available physical devices were returned.
		/// </summary>
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

		/// <summary>
		/// Return a function pointer for a command
		/// fname:vkGetInstanceProcAddr itself is obtained in a platform- and loader- specific manner. Typically, the loader library will export this command as a function symbol, so applications can: link against the loader library, or load it dynamically and look up the symbol using platform-specific APIs. Loaders are encouraged to export function symbols for all other core Vulkan commands as well; if this is done, then applications that use only the core Vulkan commands have no need to use fname:vkGetInstanceProcAddr.
		/// The table below defines the various use cases for fname:vkGetInstanceProcAddr and expected return value ("fp" is function pointer) for each case.
		/// The returned function pointer is of type tlink:PFN_vkVoidFunction, and must be cast to the type of the command being queried.
		/// .vkGetInstanceProcAddr behavior [width="80%",options="header",align="center"] |===== | pname:instance | pname:pName | return value | * | NULL | undefined | invalid instance | * | undefined | NULL | flink:vkEnumerateInstanceExtensionProperties | fp | NULL | flink:vkEnumerateInstanceLayerProperties | fp | NULL | flink:vkCreateInstance | fp | NULL | * (any pname:pName not covered above) | NULL | instance | core Vulkan command | fp^1^ | instance | enabled instance extension commands for pname:instance | fp^1^ | instance | available device extension commands for pname:instance | fp^1,2^ | instance | * (any pname:pName not covered above) | NULL |=====
		/// 1:: The returned function pointer must: only be called with a dispatchable object (the first parameter) that is a child of pname:instance.     e.g. sname:VkInstance, sname:VkPhysicalDevice, sname:VkDevice, sname:VkQueue, or     sname:VkCommandBuffer.
		/// 2:: available extension is an extension function supported by any of the loader, ICD or layer.
		/// ifdef::editing-notes[] [NOTE] .editing-note ==== (Jon, Bug 14886 / Gitlab issue 4) The WSI group tentatively agreed that the WSI extensions were special, and should get static entry points in link libraries and prototypes in +vulkan.h+, while future extensions would have to be dynamically loaded. If this decision is upheld by the group as a whole, it would probably be encoded in the previous paragraph, in the WSI extensions branch of the Specification.
		/// However, this decision has not been fully signed off on by the entire Vulkan WG yet AFAIK. Note that implementations typically will not support many of the WSI extensions, so ``static entry points'' do not relieve apps of the neccessity of runtime enabling and testing of each extension before using it. ==== endif::editing-notes[]
		/// </summary>
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

		/// <summary>
		/// Returns up to requested number of global extension properties.
		/// When pname:pLayerName parameter is NULL, only extensions provided by the Vulkan implementation or by implicitly enabled layers are returned. When pname:pLayerName is the name of a layer, the instance extensions provided by that layer are returned.
		/// If pname:pProperties is `NULL`, then the number of extensions properties available is returned in pname:pPropertyCount. Otherwise, pname:pPropertyCount must: point to a variable set by the user to the number of elements in the pname:pProperties array, and on return the variable is overwritten with the number of structures actually written to pname:pProperties. If pname:pPropertyCount is less than the number of extension properties available, at most pname:pPropertyCount structures will be written. If pname:pPropertyCount is smaller than the number of extensions available, ename:VK_INCOMPLETE will be returned instead of ename:VK_SUCCESS, to indicate that not all the available properties were returned.
		/// </summary>
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

		/// <summary>
		/// Returns up to requested number of global layer properties.
		/// If pname:pProperties is `NULL`, then the number of layer properties available is returned in pname:pPropertyCount. Otherwise, pname:pPropertyCount must: point to a variable set by the user to the number of elements in the pname:pProperties array, and on return the variable is overwritten with the number of structures actually written to pname:pProperties. If pname:pPropertyCount is less than the number of layer properties available, at most pname:pPropertyCount structures will be written. If pname:pPropertyCount is smaller than the number of layers available, ename:VK_INCOMPLETE will be returned instead of ename:VK_SUCCESS, to indicate that not all the available layer properties were returned.
		/// </summary>
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

		/// <summary>
		/// -
		/// </summary>
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

		/// <summary>
		/// -
		/// </summary>
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

		/// <summary>
		/// -
		/// </summary>
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

		/// <summary>
		/// -
		/// </summary>
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

		/// <summary>
		/// -
		/// </summary>
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

		/// <summary>
		/// -
		/// </summary>
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

		/// <summary>
		/// -
		/// </summary>
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

		/// <summary>
		/// -
		/// </summary>
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

		/// <summary>
		/// -
		/// </summary>
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

		/// <summary>
		/// Releases the unmanaged resources associated with this instance and
		/// destroys the underlying Vulkan handle.
		/// </summary>
		public void Dispose()
		{
			this.Destroy();
		}
	}

    /// <summary>
    /// Opaque handle to a physical device object
    /// Vulkan separates the concept of _physical_ and _logical_ devices. A physical device usually represents a single device in a system (perhaps made up of several individual hardware devices working together), of which there are a finite number. A logical device represents an application's view of the device.
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

		/// <summary>
		/// Reports capabilities of a physical device.
		/// </summary>
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

		/// <summary>
		/// Lists physical device's format capabilities.
		/// </summary>
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

		/// <summary>
		/// Lists physical device's image format capabilities.
		/// The pname:format, pname:type, pname:tiling, pname:usage, and pname:flags parameters correspond to parameters that would be consumed by flink:vkCreateImage.
		/// If pname:format is not a supported image format, or if the combination of pname:format, pname:type, pname:tiling, pname:usage, and pname:flags is not supported for images, then fname:vkGetPhysicalDeviceImageFormatProperties returns ename:VK_ERROR_FORMAT_NOT_SUPPORTED.
		/// The limitations on an image format that are reported by fname:vkGetPhysicalDeviceImageFormatProperties have the following property: if code:usage1 and code:usage2 of type elink:VkImageUsageFlags are such that the bits set in code:usage1 are a subset of the bits set in code:usage2, and code:flags1 and code:flags2 of type elink:VkImageCreateFlags are such that the bits set in code:flags1 are a subset of the bits set in code:flags2, then the limitations for code:usage1 and code:flags1 must: be no more strict than the limitations for code:usage2 and code:flags2, for all values of pname:format, pname:type, and pname:tiling.
		/// </summary>
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

		/// <summary>
		/// Returns properties of a physical device.
		/// </summary>
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

		/// <summary>
		/// Reports properties of the queues of the specified physical device.
		/// If pname:pQueueFamilyProperties is `NULL`, then the number of queue families available is returned in pname:pQueueFamilyPropertyCount. Otherwise, pname:pQueueFamilyPropertyCount must: point to a variable set by the user to the number of elements in the pname:pQueueFamilyProperties array, and on return the variable is overwritten with the number of structures actually written to pname:pQueueFamilyProperties. If pname:pQueueFamilyPropertyCount is less than the number of queue families available, at most pname:pQueueFamilyPropertyCount structures will be written.
		/// </summary>
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

		/// <summary>
		/// Reports memory information for the specified physical device.
		/// </summary>
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

		/// <summary>
		/// Create a new device instance.
		/// Multiple logical devices can: be created from the same physical device. Logical device creation may: fail due to lack of device-specific resources (in addition to the other errors). If that occurs, fname:vkCreateDevice will return ename:VK_ERROR_TOO_MANY_OBJECTS.
		/// </summary>
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

		/// <summary>
		/// Returns properties of available physical device extensions.
		/// When pname:pLayerName parameter is NULL, only extensions provided by the Vulkan implementation or by implicitly enabled layers are returned. When pname:pLayerName is the name of a layer, the device extensions provided by that layer are returned.
		/// </summary>
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

		/// <summary>
		/// Returns properties of available physical device layers.
		/// If pname:pProperties is `NULL`, then the number of layer properties available is returned in pname:pPropertyCount. Otherwise, pname:pPropertyCount must: point to a variable set by the user to the number of elements in the pname:pProperties array, and on return the variable is overwritten with the number of structures actually written to pname:pProperties. If pname:pPropertyCount is less than the number of layer properties available, at most pname:pPropertyCount structures will be written. If pname:pPropertyCount is smaller than the number of layers available, ename:VK_INCOMPLETE will be returned instead of ename:VK_SUCCESS, to indicate that not all the available layer properties were returned.
		/// The list of layers enumerated by fname:vkEnumerateDeviceLayerProperties must: be exactly the sequence of layers enabled for the instance. The members of sname:VkLayerProperties for each enumerated layer must: be the same as the properties when the layer was enumerated by fname:vkEnumerateInstanceLayerProperties.
		/// </summary>
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

		/// <summary>
		/// Retrieve properties of an image format applied to sparse images.
		/// fname:vkGetPhysicalDeviceSparseImageFormatProperties returns an array of slink:VkSparseImageFormatProperties. Each element will describe properties for one set of image aspects that are bound simultaneously in the image. This is usually one element for each aspect in the image, but for interleaved depth/stencil images there is only one element describing the combined aspects.
		/// If pname:pProperties is `NULL`, then the number of sparse format properties available is returned in pname:pPropertyCount. Otherwise, pname:pPropertyCount must: point to a variable set by the user to the number of elements in the pname:pProperties array, and on return the variable is overwritten with the number of structures actually written to pname:pProperties. If pname:pPropertyCount is less than the number of sparse format properties available, at most pname:pPropertyCount structures will be written.
		/// If ename:VK_IMAGE_CREATE_SPARSE_RESIDENCY_BIT is not supported for the given arguments, pname:pPropertyCount will be set to zero upon return, and no data will be written to pname:pProperties.
		/// Multiple aspects are returned for depth/stencil images that are implemented as separate planes by the implementation. The depth and stencil data planes each have unique sname:VkSparseImageFormatProperties data.
		/// Depth/stencil images with depth and stencil data interleaved into a single plane will return a single sname:VkSparseImageFormatProperties structure with the pname:aspectMask set to ename:VK_IMAGE_ASPECT_DEPTH_BIT | ename:VK_IMAGE_ASPECT_STENCIL_BIT.
		/// </summary>
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

		/// <summary>
		/// -
		/// </summary>
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

		/// <summary>
		/// -
		/// </summary>
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

		/// <summary>
		/// -
		/// </summary>
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

		/// <summary>
		/// -
		/// </summary>
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

		/// <summary>
		/// -
		/// </summary>
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

		/// <summary>
		/// -
		/// </summary>
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

		/// <summary>
		/// -
		/// </summary>
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

		/// <summary>
		/// -
		/// </summary>
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

		/// <summary>
		/// -
		/// </summary>
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

		/// <summary>
		/// -
		/// </summary>
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

		/// <summary>
		/// -
		/// </summary>
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

		/// <summary>
		/// -
		/// </summary>
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

		/// <summary>
		/// -
		/// </summary>
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

		/// <summary>
		/// -
		/// </summary>
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
    /// Opaque handle to a pipeline object
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

		/// <summary>
		/// Destroy a pipeline object
		/// </summary>
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

		/// <summary>
		/// Releases the unmanaged resources associated with this instance and
		/// destroys the underlying Vulkan handle.
		/// </summary>
		public void Dispose()
		{
			this.Destroy();
		}
	}

    /// <summary>
    /// Opaque handle to a pipeline cache object
    /// Pipeline cache objects allow the result of pipeline construction to be reused between pipelines and between runs of an application. Reuse between pipelines is achieved by passing the same pipeline cache object when creating multiple related pipelines. Reuse across runs of an application is achieved by retrieving pipeline cache contents in one run of an application, saving the contents, and using them to preinitialize a pipeline cache on a subsequent run. The contents of the pipeline cache objects are managed by the implementation. Applications can: manage the host memory consumed by a pipeline cache object and control the amount of data retrieved from a pipeline cache object.
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

		/// <summary>
		/// Destroy a pipeline cache object
		/// </summary>
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

		/// <summary>
		/// Get the data store from a pipeline cache
		/// If pname:pData is `NULL`, then the maximum size of the data that can: be retrieved from the pipeline cache, in bytes, is returned in pname:pDataSize. Otherwise, pname:pDataSize must: point to a variable set by the user to the size of the buffer, in bytes, pointed to by pname:pData, and on return the variable is overwritten with the amount of data actually written to pname:pData.
		/// If pname:pDataSize is less than the maximum size that can: be retrieved by the pipeline cache, at most pname:pDataSize bytes will be written to pname:pData, and fname:vkGetPipelineCacheData will return ename:VK_INCOMPLETE. Any data written to pname:pData is valid and can: be provided as the pname:pInitialData member of the sname:VkPipelineCacheCreateInfo structure passed to fname:vkCreatePipelineCache.
		/// [[pipelines-cache-header]] Applications can: store the data retrieved from the pipeline cache, and use these data, possibly in a future run of the application, to populate new pipeline cache objects. The results of pipeline compiles, however, may: depend on the vendor ID, device ID, driver version, and other details of the device. To enable applications to detect when previously retrieved data is incompatible with the device, the initial bytes written to pname:pData must: be a header consisting of the following members:
		/// .Layout for pipeline cache header version VK_PIPELINE_CACHE_HEADER_VERSION_ONE [width="85%",cols="8%,21%,71%",options="header"] |===== | Offset | Size | Meaning | 0 | 4                    | length in bytes of the entire pipeline cache header                              written as a stream of bytes, with the least                              significant byte first | 4 | 4                    | a elink:VkPipelineCacheHeaderVersion value                              written as a stream of bytes, with the least                              significant byte first | 8 | 4                    | a vendor ID equal to                              sname:VkPhysicalDeviceProperties::pname:vendorID                              written as a stream of bytes, with the least                              significant byte first | 12 | 4                    | a device ID equal to                              sname:VkPhysicalDeviceProperties::pname:deviceID                              written as a stream of bytes, with the least                              significant byte first | 16 | ename:VK_UUID_SIZE   | a pipeline cache ID equal to                              sname:VkPhysicalDeviceProperties::pname:pipelineCacheUUID |=====
		/// The first four bytes encode the length of the entire pipeline header, in bytes. This value includes all fields in the header including the pipeline cache version field and the size of the length field.
		/// The next four bytes encode the pipeline cache version. This field is interpreted as a elink:VkPipelineCacheHeaderVersion value, and must: have one of the following values:
		/// A consumer of the pipeline cache should use the cache version to interpret the remainder of the cache header.
		/// If pname:pDataSize is less than what is necessary to store this header, nothing will be written to pname:pData and zero will be written to pname:pDataSize.
		/// </summary>
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

		/// <summary>
		/// Combine the data stores of pipeline caches.
		/// [NOTE] .Note ==== The details of the merge operation are implementation dependent, but implementations should: merge the contents of the specified pipelines and prune duplicate entries. ====
		/// </summary>
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

		/// <summary>
		/// Releases the unmanaged resources associated with this instance and
		/// destroys the underlying Vulkan handle.
		/// </summary>
		public void Dispose()
		{
			this.Destroy();
		}
	}

    /// <summary>
    /// Opaque handle to a pipeline layout object
    /// Access to descriptor sets from a pipeline is accomplished through a _pipeline layout_. Zero or more descriptor set layouts and zero or more push constant ranges are combined to form a pipeline layout object which describes the complete set of resources that can: be accessed by a pipeline. The pipeline layout represents a sequence of descriptor sets with each having a specific layout. This sequence of layouts is used to determine the interface between shader stages and shader resources. Each pipeline is created using a pipeline layout.
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

		/// <summary>
		/// Destroy a pipeline layout object
		/// </summary>
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

		/// <summary>
		/// Releases the unmanaged resources associated with this instance and
		/// destroys the underlying Vulkan handle.
		/// </summary>
		public void Dispose()
		{
			this.Destroy();
		}
	}

    /// <summary>
    /// Opaque handle to a query pool object
    /// Queries are managed using _query pool_ objects. Each query pool is a collection of a specific number of queries of a particular type.
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

		/// <summary>
		/// Destroy a query pool object
		/// </summary>
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

		/// <summary>
		/// Copy results of queries in a query pool to a host memory region.
		/// If no bits are set in pname:flags, and all requested queries are in the available state, results are written as an array of 32-bit unsigned integer values. The behavior when not all queries are available, is described &lt;&lt;queries-wait-bit-not-set, below&gt;&gt;.
		/// If ename:VK_QUERY_RESULT_64_BIT is not set and the result overflows a 32-bit value, the value may: either wrap or saturate. Similarly, if ename:VK_QUERY_RESULT_64_BIT is set and the result overflows a 64-bit value, the value may: either wrap or saturate.
		/// If ename:VK_QUERY_RESULT_WAIT_BIT is set, Vulkan will wait for each query to be in the available state before retrieving the numerical results for that query. In this case, fname:vkGetQueryPoolResults is guaranteed to succeed and return ename:VK_SUCCESS if the queries become available in a finite time (i.e. if they have been issued and not reset). If queries will never finish (e.g. due to being reset but not issued), then fname:vkGetQueryPoolResults may: not return in finite time.
		/// [[queries-wait-bit-not-set]] If ename:VK_QUERY_RESULT_WAIT_BIT and ename:VK_QUERY_RESULT_PARTIAL_BIT are both not set then no result values are written to pname:pData for queries that are in the unavailable state at the time of the call, and fname:vkGetQueryPoolResults returns ename:VK_NOT_READY. However, availability state is still written to pname:pData for those queries if ename:VK_QUERY_RESULT_WITH_AVAILABILITY_BIT is set.
		/// [NOTE] .Note ==== Applications must: take care to ensure that use of the ename:VK_QUERY_RESULT_WAIT_BIT bit has the desired effect.
		/// For example, if a query has been used previously and a command buffer records the commands fname:vkCmdResetQueryPool, fname:vkCmdBeginQuery, and fname:vkCmdEndQuery for that query, then the query will remain in the available state until the fname:vkCmdResetQueryPool command executes on a queue. Applications can: use fences or events to ensure that an query has already been reset before checking for its results or availability status. Otherwise, a stale value could be returned from a previous use of the query.
		/// The above also applies when ename:VK_QUERY_RESULT_WAIT_BIT is used in combination with ename:VK_QUERY_RESULT_WITH_AVAILABILITY_BIT. In this case, the returned availability status may: reflect the result of a previous use of the query unless the fname:vkCmdResetQueryPool command has been executed since the last use of the query. ====
		/// [NOTE] .Note ==== Applications can: double-buffer query pool usage, with a pool per frame, and reset queries at the end of the frame in which they are read. ====
		/// If ename:VK_QUERY_RESULT_PARTIAL_BIT is set, ename:VK_QUERY_RESULT_WAIT_BIT is not set, and the query's status is unavailable, an intermediate result value between zero and the final result value is written to pname:pData for that query.
		/// ename:VK_QUERY_RESULT_PARTIAL_BIT mustnot: be used if the pool's pname:queryType is ename:VK_QUERY_TYPE_TIMESTAMP.
		/// If ename:VK_QUERY_RESULT_WITH_AVAILABILITY_BIT is set, the final integer value written for each query is non-zero if the query's status was available or zero if the status was unavailable. When ename:VK_QUERY_RESULT_WITH_AVAILABILITY_BIT is used, implementations must: guarantee that if they return a non-zero availability value then the numerical results must: be valid, assuming the results are not reset by a subsequent command.
		/// [NOTE] .Note ==== Satisfying this guarantee may: require careful ordering by the application, e.g. to read the availability status before reading the results. ====
		/// </summary>
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

		/// <summary>
		/// Releases the unmanaged resources associated with this instance and
		/// destroys the underlying Vulkan handle.
		/// </summary>
		public void Dispose()
		{
			this.Destroy();
		}
	}

    /// <summary>
    /// Opaque handle to a queue object
    /// Creating a logical device also creates the queues associated with that device. The queues to create are described by a set of slink:VkDeviceQueueCreateInfo structures that are passed to flink:vkCreateDevice in pname:pQueueCreateInfos.
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

		/// <summary>
		/// Submits a sequence of semaphores or command buffers to a queue.
		/// [NOTE] .Note ==== Submission can be a high overhead operation, and applications should: attempt to batch work together into as few calls to fname:vkQueueSubmit as possible. ====
		/// fname:vkQueueSubmit is a &lt;&lt;devsandqueues-submission,queue submission command&gt;&gt;, with each batch defined by an element of pname:pSubmits as an instance of the slink:VkSubmitInfo structure.
		/// Fence and semaphore operations submitted with flink:vkQueueSubmit have additional ordering constraints compared to other submission commands, with dependencies involving previous and subsequent queue operations. Information about these additional constraints can be found in the &lt;&lt;synchronization-semaphores, semaphore&gt;&gt; and &lt;&lt;synchronization-semaphores, fence&gt;&gt; sections of &lt;&lt;synchronization, the synchronization chapter&gt;&gt;.
		/// Details on the interaction of pname:pWaitDstStageMask with synchronization are described in the &lt;&lt;synchronization-semaphores-waiting, semaphore wait operation&gt;&gt; section of &lt;&lt;synchronization, the synchronization chapter&gt;&gt;.
		/// </summary>
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

		/// <summary>
		/// Wait for a queue to become idle.
		/// fname:vkQueueWaitIdle is equivalent to submitting a fence to a queue and waiting with an infinite timeout for that fence to signal.
		/// </summary>
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

		/// <summary>
		/// Bind device memory to a sparse resource object.
		/// fname:vkQueueBindSparse is a &lt;&lt;devsandqueues-submission,queue submission command&gt;&gt;, with each batch defined by an element of pname:pBindInfo as an instance of the slink:VkBindSparseInfo structure.
		/// Within a batch, a given range of a resource must: not be bound more than once. Across batches, if a range is to be bound to one allocation and offset and then to another allocation and offset, then the application must: guarantee (usually using semaphores) that the binding operations are executed in the correct order, as well as to order binding operations against the execution of command buffer submissions.
		/// As no operation to flink:vkQueueBindSparse causes any pipeline stage to access memory, synchronization primitives used in this command effectively only define execution dependencies.
		/// Additional information about fence and semaphore operation is described in &lt;&lt;synchronization, the synchronization chapter&gt;&gt;.
		/// </summary>
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

		/// <summary>
		/// -
		/// </summary>
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
    /// Opaque handle to a render pass object
    /// A _render pass_ represents a collection of attachments, subpasses, and dependencies between the subpasses, and describes how the attachments are used over the course of the subpasses. The use of a render pass in a command buffer is a  _render pass instance_.
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

		/// <summary>
		/// Destroy a render pass object
		/// </summary>
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

		/// <summary>
		/// Returns the granularity for optimal render area.
		/// The conditions leading to an optimal pname:renderArea are:
		/// * the pname:offset.x member in pname:renderArea is a multiple of the     pname:width member of the returned slink:VkExtent2D (the horizontal     granularity).   * the pname:offset.y member in pname:renderArea is a multiple of the     pname:height of the returned slink:VkExtent2D (the vertical     granularity).   * either the pname:offset.width member in pname:renderArea is a multiple     of the horizontal granularity or pname:offset.x+pname:offset.width is     equal to the pname:width of the pname:framebuffer in the     slink:VkRenderPassBeginInfo.   * either the pname:offset.height member in pname:renderArea is a multiple     of the vertical granularity or pname:offset.y+pname:offset.height is     equal to the pname:height of the pname:framebuffer in the     slink:VkRenderPassBeginInfo.
		/// Subpass dependencies are not affected by the render area, and apply to the entire image subresources attached to the framebuffer. Similarly, pipeline barriers are valid even if their effect extends outside the render area.
		/// </summary>
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

		/// <summary>
		/// Releases the unmanaged resources associated with this instance and
		/// destroys the underlying Vulkan handle.
		/// </summary>
		public void Dispose()
		{
			this.Destroy();
		}
	}

    /// <summary>
    /// Opaque handle to a sampler object
    /// sname:VkSampler objects represent the state of an image sampler which is used by the implementation to read image data and apply filtering and other transformations for the shader.
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

		/// <summary>
		/// Destroy a sampler object
		/// </summary>
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

		/// <summary>
		/// Releases the unmanaged resources associated with this instance and
		/// destroys the underlying Vulkan handle.
		/// </summary>
		public void Dispose()
		{
			this.Destroy();
		}
	}

    /// <summary>
    /// Opaque handle to a semaphore object
    /// Semaphores are used to coordinate queue operations both within a queue and between different queues. A semaphore's status is always either _signaled_ or _unsignaled_.
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

		/// <summary>
		/// Destroy a semaphore object
		/// </summary>
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

		/// <summary>
		/// Releases the unmanaged resources associated with this instance and
		/// destroys the underlying Vulkan handle.
		/// </summary>
		public void Dispose()
		{
			this.Destroy();
		}
	}

    /// <summary>
    /// Opaque handle to a shader module object
    /// _Shader modules_ contain _shader code_ and one or more entry points. Shaders are selected from a shader module by specifying an entry point as part of &lt;&lt;pipelines,pipeline&gt;&gt; creation. The stages of a pipeline can: use shaders that come from different modules. The shader code defining a shader module must: be in the SPIR-V format, as described by the &lt;&lt;spirvenv,Vulkan Environment for SPIR-V&gt;&gt; appendix.
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

		/// <summary>
		/// Destroy a shader module module
		/// A shader module can: be destroyed while pipelines created using its shaders are still in use.
		/// </summary>
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

		/// <summary>
		/// Releases the unmanaged resources associated with this instance and
		/// destroys the underlying Vulkan handle.
		/// </summary>
		public void Dispose()
		{
			this.Destroy();
		}
	}

    /// <summary>
    /// -
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

		/// <summary>
		/// -
		/// </summary>
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

		/// <summary>
		/// Releases the unmanaged resources associated with this instance and
		/// destroys the underlying Vulkan handle.
		/// </summary>
		public void Dispose()
		{
			this.Destroy();
		}
	}

    /// <summary>
    /// -
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

		/// <summary>
		/// -
		/// </summary>
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

		/// <summary>
		/// -
		/// </summary>
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

		/// <summary>
		/// -
		/// </summary>
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

		/// <summary>
		/// Releases the unmanaged resources associated with this instance and
		/// destroys the underlying Vulkan handle.
		/// </summary>
		public void Dispose()
		{
			this.Destroy();
		}
	}

}