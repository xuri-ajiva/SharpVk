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
    /// <para>
    /// Bitmask specifying classes of memory access the will participate in a memory barrier dependency.
    /// </para>
    /// <para>
    /// Color attachment reads and writes are automatically (without memory or execution dependencies) coherent and ordered against themselves and each other for a given sample within a subpass of a render pass instance, executing in &lt;&lt;primrast-order,rasterization order&gt;&gt;. Similarly, depth/stencil attachment reads and writes are automatically coherent and ordered against themselves and each other in the same circumstances.
    /// </para>
    /// <para>
    /// Shader reads and/or writes through two variables (in the same or different shader invocations) decorated with code:Coherent and which use the same image view or buffer view are automatically coherent with each other, but require execution dependencies if a specific order is desired. Similarly, shader atomic operations are coherent with each other and with code:Coherent variables. Non-code:Coherent shader memory accesses require memory dependencies for writes to be available and reads to be visible.
    /// </para>
    /// <para>
    /// Certain memory access types are only supported on queues that support a particular set of operations. The following table lists, for each access flag, which queue capability flag must: be supported by the queue. When multiple flags are enumerated in the second column of the table it means that the access type is supported on the queue if it supports any of the listed capability flags. For further details on queue capabilities see &lt;&lt;devsandqueues-physical-device-enumeration,Physical Device Enumeration&gt;&gt; and &lt;&lt;devsandqueues-queues,Queues&gt;&gt;.
    /// </para>
    /// <para>
    /// .Supported access flags [width="100%",cols="67%,33%",options="header",align="center"] |======================================== |Access flag                                                  | Required queue capability flag |ename:VK_ACCESS_INDIRECT_COMMAND_READ_BIT                    | ename:VK_QUEUE_GRAPHICS_BIT or ename:VK_QUEUE_COMPUTE_BIT |ename:VK_ACCESS_INDEX_READ_BIT                               | ename:VK_QUEUE_GRAPHICS_BIT |ename:VK_ACCESS_VERTEX_ATTRIBUTE_READ_BIT                    | ename:VK_QUEUE_GRAPHICS_BIT |ename:VK_ACCESS_UNIFORM_READ_BIT                             | ename:VK_QUEUE_GRAPHICS_BIT or ename:VK_QUEUE_COMPUTE_BIT |ename:VK_ACCESS_INPUT_ATTACHMENT_READ_BIT                    | ename:VK_QUEUE_GRAPHICS_BIT |ename:VK_ACCESS_SHADER_READ_BIT                              | ename:VK_QUEUE_GRAPHICS_BIT or ename:VK_QUEUE_COMPUTE_BIT |ename:VK_ACCESS_SHADER_WRITE_BIT                             | ename:VK_QUEUE_GRAPHICS_BIT or ename:VK_QUEUE_COMPUTE_BIT |ename:VK_ACCESS_COLOR_ATTACHMENT_READ_BIT                    | ename:VK_QUEUE_GRAPHICS_BIT |ename:VK_ACCESS_COLOR_ATTACHMENT_WRITE_BIT                   | ename:VK_QUEUE_GRAPHICS_BIT |ename:VK_ACCESS_DEPTH_STENCIL_ATTACHMENT_READ_BIT            | ename:VK_QUEUE_GRAPHICS_BIT |ename:VK_ACCESS_DEPTH_STENCIL_ATTACHMENT_WRITE_BIT           | ename:VK_QUEUE_GRAPHICS_BIT |ename:VK_ACCESS_TRANSFER_READ_BIT                            | ename:VK_QUEUE_GRAPHICS_BIT, ename:VK_QUEUE_COMPUTE_BIT or ename:VK_QUEUE_TRANSFER_BIT |ename:VK_ACCESS_TRANSFER_WRITE_BIT                           | ename:VK_QUEUE_GRAPHICS_BIT, ename:VK_QUEUE_COMPUTE_BIT or ename:VK_QUEUE_TRANSFER_BIT |ename:VK_ACCESS_HOST_READ_BIT                                | None |ename:VK_ACCESS_HOST_WRITE_BIT                               | None |ename:VK_ACCESS_MEMORY_READ_BIT                              | None |ename:VK_ACCESS_MEMORY_WRITE_BIT                             | None |========================================
    /// </para>
    /// </summary>
	[Flags]
	public enum AccessFlags
	{
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		None = 0,
	    /// <summary>
		/// <para>
		/// ename:VK_ACCESS_INDIRECT_COMMAND_READ_BIT indicates that the access is an indirect command structure read as part of an indirect drawing command.
		/// </para>
		/// </summary>
		IndirectCommandRead = 1 << 0,
	    /// <summary>
		/// <para>
		/// ename:VK_ACCESS_INDEX_READ_BIT indicates that the access is an index buffer read.
		/// </para>
		/// </summary>
		IndexRead = 1 << 1,
	    /// <summary>
		/// <para>
		/// ename:VK_ACCESS_VERTEX_ATTRIBUTE_READ_BIT indicates that the access is a read via the vertex input bindings.
		/// </para>
		/// </summary>
		VertexAttributeRead = 1 << 2,
	    /// <summary>
		/// <para>
		/// ename:VK_ACCESS_UNIFORM_READ_BIT indicates that the access is a read via a uniform buffer or dynamic uniform buffer descriptor.
		/// </para>
		/// </summary>
		UniformRead = 1 << 3,
	    /// <summary>
		/// <para>
		/// ename:VK_ACCESS_INPUT_ATTACHMENT_READ_BIT indicates that the access is a read via an input attachment descriptor.
		/// </para>
		/// </summary>
		InputAttachmentRead = 1 << 4,
	    /// <summary>
		/// <para>
		/// ename:VK_ACCESS_SHADER_READ_BIT indicates that the access is a read from a shader via any other descriptor type.
		/// </para>
		/// </summary>
		ShaderRead = 1 << 5,
	    /// <summary>
		/// <para>
		/// ename:VK_ACCESS_SHADER_WRITE_BIT indicates that the access is a write or atomic from a shader via the same descriptor types as in ename:VK_ACCESS_SHADER_READ_BIT.
		/// </para>
		/// </summary>
		ShaderWrite = 1 << 6,
	    /// <summary>
		/// <para>
		/// ename:VK_ACCESS_COLOR_ATTACHMENT_READ_BIT indicates that the access is a read via a color attachment.
		/// </para>
		/// </summary>
		ColorAttachmentRead = 1 << 7,
	    /// <summary>
		/// <para>
		/// ename:VK_ACCESS_COLOR_ATTACHMENT_WRITE_BIT indicates that the access is a write via a color or resolve attachment.
		/// </para>
		/// </summary>
		ColorAttachmentWrite = 1 << 8,
	    /// <summary>
		/// <para>
		/// ename:VK_ACCESS_DEPTH_STENCIL_ATTACHMENT_READ_BIT indicates that the access is a read via a depth/stencil attachment.
		/// </para>
		/// </summary>
		DepthStencilAttachmentRead = 1 << 9,
	    /// <summary>
		/// <para>
		/// ename:VK_ACCESS_DEPTH_STENCIL_ATTACHMENT_WRITE_BIT indicates that the access is a write via a depth/stencil attachment.
		/// </para>
		/// </summary>
		DepthStencilAttachmentWrite = 1 << 10,
	    /// <summary>
		/// <para>
		/// ename:VK_ACCESS_TRANSFER_READ_BIT indicates that the access is a read from a transfer (copy, blit, resolve, etc.) operation. For the complete set of transfer operations, see &lt;&lt;synchronization-transfer,ename:VK_PIPELINE_STAGE_TRANSFER_BIT&gt;&gt;.
		/// </para>
		/// </summary>
		TransferRead = 1 << 11,
	    /// <summary>
		/// <para>
		/// ename:VK_ACCESS_TRANSFER_WRITE_BIT indicates that the access is a write from a transfer (copy, blit, resolve, etc.) operation. For the complete set of transfer operations, see &lt;&lt;synchronization-transfer,ename:VK_PIPELINE_STAGE_TRANSFER_BIT&gt;&gt;.
		/// </para>
		/// </summary>
		TransferWrite = 1 << 12,
	    /// <summary>
		/// <para>
		/// ename:VK_ACCESS_HOST_READ_BIT indicates that the access is a read via the host.
		/// </para>
		/// </summary>
		HostRead = 1 << 13,
	    /// <summary>
		/// <para>
		/// ename:VK_ACCESS_HOST_WRITE_BIT indicates that the access is a write via the host.
		/// </para>
		/// </summary>
		HostWrite = 1 << 14,
	    /// <summary>
		/// <para>
		/// ename:VK_ACCESS_MEMORY_READ_BIT indicates that the access is a read via a non-specific unit attached to the memory. This unit may: be external to the Vulkan device or otherwise not part of the core Vulkan pipeline. When included in pname:dstAccessMask, all writes using access types in pname:srcAccessMask performed by pipeline stages in pname:srcStageMask must: be visible in memory.
		/// </para>
		/// </summary>
		MemoryRead = 1 << 15,
	    /// <summary>
		/// <para>
		/// ename:VK_ACCESS_MEMORY_WRITE_BIT indicates that the access is a write via a non-specific unit attached to the memory. This unit may: be external to the Vulkan device or otherwise not part of the core Vulkan pipeline. When included in pname:srcAccessMask, all access types in pname:dstAccessMask from pipeline stages in pname:dstStageMask will observe the side effects of commands that executed before the barrier. When included in pname:dstAccessMask all writes using access types in pname:srcAccessMask performed by pipeline stages in pname:srcStageMask must: be visible in memory.
		/// </para>
		/// </summary>
		MemoryWrite = 1 << 16,
	}

    /// <summary>
    /// <para>
    /// -
    /// </para>
    /// </summary>
	[Flags]
	public enum AndroidSurfaceCreateFlags
	{
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		None = 0,
	}

    /// <summary>
    /// <para>
    /// Bitmask specifying additional properties of an attachment.
    /// </para>
    /// </summary>
	[Flags]
	public enum AttachmentDescriptionFlags
	{
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		None = 0,
	    /// <summary>
		/// <para>
		/// The attachment may alias physical memory of another attachment in the same render pass
		/// </para>
		/// </summary>
		MayAlias = 1 << 0,
	}

    /// <summary>
    /// <para>
    /// Bitmask specifying additional parameters of a buffer.
    /// </para>
    /// <para>
    /// These bits have the following meanings:
    /// </para>
    /// <para>
    /// * ename:VK_BUFFER_CREATE_SPARSE_BINDING_BIT indicates that the buffer will be backed using sparse memory binding. * ename:VK_BUFFER_CREATE_SPARSE_RESIDENCY_BIT indicates that the buffer can: be partially backed using sparse memory binding. Buffers created with this flag must: also be created with the ename:VK_BUFFER_CREATE_SPARSE_BINDING_BIT flag. * ename:VK_BUFFER_CREATE_SPARSE_ALIASED_BIT indicates that the buffer will be backed using sparse memory binding with memory ranges that might also simultaneously be backing another buffer (or another portion of the same buffer). Buffers created with this flag must: also be created with the ename:VK_BUFFER_CREATE_SPARSE_BINDING_BIT flag.
    /// </para>
    /// <para>
    /// See &lt;&lt;sparsememory-sparseresourcefeatures,Sparse Resource Features&gt;&gt; and &lt;&lt;features-features,Physical Device Features&gt;&gt; for details of the sparse memory features supported on a device.
    /// </para>
    /// </summary>
	[Flags]
	public enum BufferCreateFlags
	{
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		None = 0,
	    /// <summary>
		/// <para>
		/// Buffer should support sparse backing
		/// </para>
		/// </summary>
		SparseBinding = 1 << 0,
	    /// <summary>
		/// <para>
		/// Buffer should support sparse backing with partial residency
		/// </para>
		/// </summary>
		SparseResidency = 1 << 1,
	    /// <summary>
		/// <para>
		/// Buffer should support constent data access to physical memory ranges mapped into multiple locations of sparse buffers
		/// </para>
		/// </summary>
		SparseAliased = 1 << 2,
	}

    /// <summary>
    /// <para>
    /// Bitmask specifying allowed usage of a buffer.
    /// </para>
    /// <para>
    /// Any combination of bits can: be specified for pname:usage, but at least one of the bits must: be set in order to create a valid buffer.
    /// </para>
    /// <para>
    /// Bits which can: be set in pname:flags are:
    /// </para>
    /// </summary>
	[Flags]
	public enum BufferUsageFlags
	{
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		None = 0,
	    /// <summary>
		/// <para>
		/// ename:VK_BUFFER_USAGE_TRANSFER_SRC_BIT indicates that the buffer can: be used as the source of a _transfer command_ (see the definition of &lt;&lt;synchronization-transfer,ename:VK_PIPELINE_STAGE_TRANSFER_BIT&gt;&gt;).
		/// </para>
		/// </summary>
		TransferSource = 1 << 0,
	    /// <summary>
		/// <para>
		/// ename:VK_BUFFER_USAGE_TRANSFER_DST_BIT indicates that the buffer can: be used as the destination of a transfer command.
		/// </para>
		/// </summary>
		TransferDestination = 1 << 1,
	    /// <summary>
		/// <para>
		/// ename:VK_BUFFER_USAGE_UNIFORM_TEXEL_BUFFER_BIT indicates that the buffer can: be used to create a sname:VkBufferView suitable for occupying a sname:VkDescriptorSet slot of type ename:VK_DESCRIPTOR_TYPE_UNIFORM_TEXEL_BUFFER.
		/// </para>
		/// </summary>
		UniformTexelBuffer = 1 << 2,
	    /// <summary>
		/// <para>
		/// ename:VK_BUFFER_USAGE_STORAGE_TEXEL_BUFFER_BIT indicates that the buffer can: be used to create a sname:VkBufferView suitable for occupying a sname:VkDescriptorSet slot of type ename:VK_DESCRIPTOR_TYPE_STORAGE_TEXEL_BUFFER.
		/// </para>
		/// </summary>
		StorageTexelBuffer = 1 << 3,
	    /// <summary>
		/// <para>
		/// ename:VK_BUFFER_USAGE_UNIFORM_BUFFER_BIT indicates that the buffer can: be used in a sname:VkDescriptorBufferInfo suitable for occupying a sname:VkDescriptorSet slot either of type ename:VK_DESCRIPTOR_TYPE_UNIFORM_BUFFER or ename:VK_DESCRIPTOR_TYPE_UNIFORM_BUFFER_DYNAMIC.
		/// </para>
		/// </summary>
		UniformBuffer = 1 << 4,
	    /// <summary>
		/// <para>
		/// ename:VK_BUFFER_USAGE_STORAGE_BUFFER_BIT indicates that the buffer can: be used in a sname:VkDescriptorBufferInfo suitable for occupying a sname:VkDescriptorSet slot either of type ename:VK_DESCRIPTOR_TYPE_STORAGE_BUFFER or ename:VK_DESCRIPTOR_TYPE_STORAGE_BUFFER_DYNAMIC.
		/// </para>
		/// </summary>
		StorageBuffer = 1 << 5,
	    /// <summary>
		/// <para>
		/// ename:VK_BUFFER_USAGE_INDEX_BUFFER_BIT indicates that the buffer is suitable for passing as the pname:buffer parameter to fname:vkCmdBindIndexBuffer.
		/// </para>
		/// </summary>
		IndexBuffer = 1 << 6,
	    /// <summary>
		/// <para>
		/// ename:VK_BUFFER_USAGE_VERTEX_BUFFER_BIT indicates that the buffer is suitable for passing as an element of the pname:pBuffers array to fname:vkCmdBindVertexBuffers.
		/// </para>
		/// </summary>
		VertexBuffer = 1 << 7,
	    /// <summary>
		/// <para>
		/// ename:VK_BUFFER_USAGE_INDIRECT_BUFFER_BIT indicates that the buffer is suitable for passing as the pname:buffer parameter to fname:vkCmdDrawIndirect, fname:vkCmdDrawIndexedIndirect, or fname:vkCmdDispatchIndirect.
		/// </para>
		/// </summary>
		IndirectBuffer = 1 << 8,
	}

    /// <summary>
    /// <para>
    /// -
    /// </para>
    /// </summary>
	[Flags]
	public enum BufferViewCreateFlags
	{
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		None = 0,
	}

    /// <summary>
    /// <para>
    /// Bitmask controlling which components are written to the framebuffer.
    /// </para>
    /// <para>
    /// If ename:VK_COLOR_COMPONENT_R_BIT is set, then the latexmath:[$R$] value is written to color attachment for the appropriate sample, otherwise the value in memory is unmodified. The ename:VK_COLOR_COMPONENT_G_BIT, ename:VK_COLOR_COMPONENT_B_BIT, and ename:VK_COLOR_COMPONENT_A_BIT bits similarly control writing of the latexmath:[$G, B,$] and latexmath:[$A$] values. The pname:colorWriteMask is applied regardless of whether blending is enabled.
    /// </para>
    /// </summary>
	[Flags]
	public enum ColorComponentFlags
	{
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		None = 0,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		R = 1 << 0,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		G = 1 << 1,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		B = 1 << 2,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		A = 1 << 3,
	}

    /// <summary>
    /// <para>
    /// Bitmask controlling behavior of a command buffer reset.
    /// </para>
    /// </summary>
	[Flags]
	public enum CommandBufferResetFlags
	{
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		None = 0,
	    /// <summary>
		/// <para>
		/// Release resources owned by the buffer
		/// </para>
		/// </summary>
		ReleaseResources = 1 << 0,
	}

    /// <summary>
    /// <para>
    /// Bitmask specifying usage behavior for command buffer.
    /// </para>
    /// </summary>
	[Flags]
	public enum CommandBufferUsageFlags
	{
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		None = 0,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		OneTimeSubmit = 1 << 0,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		RenderPassContinue = 1 << 1,
	    /// <summary>
		/// <para>
		/// Command buffer may be submitted/executed more than once simultaneously
		/// </para>
		/// </summary>
		SimultaneousUse = 1 << 2,
	}

    /// <summary>
    /// <para>
    /// Bitmask specifying usage behavior for a command pool.
    /// </para>
    /// </summary>
	[Flags]
	public enum CommandPoolCreateFlags
	{
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		None = 0,
	    /// <summary>
		/// <para>
		/// Command buffers have a short lifetime
		/// </para>
		/// </summary>
		Transient = 1 << 0,
	    /// <summary>
		/// <para>
		/// Command buffers may release their memory individually
		/// </para>
		/// </summary>
		ResetCommandBuffer = 1 << 1,
	}

    /// <summary>
    /// <para>
    /// Bitmask controlling behavior of a command pool reset.
    /// </para>
    /// <para>
    /// Resetting a command pool recycles all of the resources from all of the command buffers allocated from the command pool back to the command pool. All command buffers that have been allocated from the command pool are put in the initial state.
    /// </para>
    /// </summary>
	[Flags]
	public enum CommandPoolResetFlags
	{
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		None = 0,
	    /// <summary>
		/// <para>
		/// Release resources owned by the pool
		/// </para>
		/// </summary>
		ReleaseResources = 1 << 0,
	}

    /// <summary>
    /// <para>
    /// Alpha compositing modes supported on a device.
    /// </para>
    /// <para>
    /// These values are described as follows:
    /// </para>
    /// <para>
    /// * ename:VK_COMPOSITE_ALPHA_OPAQUE_BIT_KHR: The alpha channel, if it exists, of the images is ignored in the compositing process.  Instead, the image is treated as if it has a constant alpha of 1.0. * ename:VK_COMPOSITE_ALPHA_PRE_MULTIPLIED_BIT_KHR: The alpha channel, if it exists, of the images is respected in the compositing process. The non-alpha channels of the image are expected to already be multiplied by the alpha channel by the application. * ename:VK_COMPOSITE_ALPHA_POST_MULTIPLIED_BIT_KHR: The alpha channel, if it exists, of the images is respected in the compositing process. The non-alpha channels of the image are not expected to already be multiplied by the alpha channel by the application; instead, the compositor will multiply the non-alpha channels of the image by the alpha channel during compositing. * ename:VK_COMPOSITE_ALPHA_INHERIT_BIT_KHR: The way in which the presentation engine treats the alpha channel in the images is unknown to the Vulkan API. Instead, the application is responsible for setting the composite alpha blending mode using native window system commands. If the application does not set the blending mode using native window system commands, then a platform-specific default will be used.
    /// </para>
    /// </summary>
	[Flags]
	public enum CompositeAlphaFlags
	{
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		None = 0,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		Opaque = 1 << 0,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		PreMultiplied = 1 << 1,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		PostMultiplied = 1 << 2,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		Inherit = 1 << 3,
	}

    /// <summary>
    /// <para>
    /// Bitmask controlling triangle culling.
    /// </para>
    /// <para>
    /// If the pname:cullMode is set to ename:VK_CULL_MODE_NONE no triangles are discarded, if it is set to ename:VK_CULL_MODE_FRONT_BIT front-facing triangles are discarded, if it is set to ename:VK_CULL_MODE_BACK_BIT then back-facing triangles are discarded and if it is set to ename:VK_CULL_MODE_FRONT_AND_BACK then all triangles are discarded. Following culling, fragments are produced for any triangles which have not been discarded.
    /// </para>
    /// </summary>
	[Flags]
	public enum CullModeFlags
	{
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		None = 0,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		Front = 1 << 0,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		Back = 1 << 1,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		FrontAndBack = 0x00000003,
	}

    /// <summary>
    /// <para>
    /// -
    /// </para>
    /// </summary>
	[Flags]
	public enum DebugReportFlags
	{
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		None = 0,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		Information = 1 << 0,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		Warning = 1 << 1,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		PerformanceWarning = 1 << 2,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		Error = 1 << 3,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		Debug = 1 << 4,
	}

    /// <summary>
    /// <para>
    /// Bitmask specifying dependencies between subpasses.
    /// </para>
    /// <para>
    /// Each subpass dependency defines an execution and memory dependency between two sets of commands, with the second set depending on the first set. When pname:srcSubpass does not equal pname:dstSubpass then the first set of commands is:
    /// </para>
    /// <para>
    /// * All commands in the subpass indicated by pname:srcSubpass, if pname:srcSubpass is not ename:VK_SUBPASS_EXTERNAL. * All commands before the render pass instance, if pname:srcSubpass is ename:VK_SUBPASS_EXTERNAL.
    /// </para>
    /// <para>
    /// While the corresponding second set of commands is:
    /// </para>
    /// <para>
    /// * All commands in the subpass indicated by pname:dstSubpass, if pname:dstSubpass is not ename:VK_SUBPASS_EXTERNAL. * All commands after the render pass instance, if pname:dstSubpass is ename:VK_SUBPASS_EXTERNAL.
    /// </para>
    /// <para>
    /// When pname:srcSubpass equals pname:dstSubpass then the first set consists of commands in the subpass before a call to flink:vkCmdPipelineBarrier and the second set consists of commands in the subpass following that same call as described in the &lt;&lt;synchronization-pipeline-barriers-subpass-self-dependencies, Subpass Self-dependency&gt;&gt; section.
    /// </para>
    /// <para>
    /// The pname:srcStageMask, pname:dstStageMask, pname:srcAccessMask, pname:dstAccessMask, and pname:dependencyFlags parameters of the dependency are interpreted the same way as for other dependencies, as described in &lt;&lt;synchronization, Synchronization and Cache Control&gt;&gt;.
    /// </para>
    /// </summary>
	[Flags]
	public enum DependencyFlags
	{
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		None = 0,
	    /// <summary>
		/// <para>
		/// Dependency is per pixel region 
		/// </para>
		/// </summary>
		ByRegion = 1 << 0,
	}

    /// <summary>
    /// <para>
    /// Bitmask specifying certain supported operations on a descriptor pool.
    /// </para>
    /// <para>
    /// If multiple sname:VkDescriptorPoolSize structures appear in the pname:pPoolSizes array then the pool will be created with enough storage for the total number of descriptors of each type.
    /// </para>
    /// <para>
    /// Fragmentation of a descriptor pool is possible and may: lead to descriptor set allocation failures. A failure due to fragmentation is defined as failing a descriptor set allocation despite the sum of all outstanding descriptor set allocations from the pool plus the requested allocation requiring no more than the total number of descriptors requested at pool creation. Implementations provide certain guarantees of when fragmentation must: not cause allocation failure, as described below.
    /// </para>
    /// <para>
    /// If a descriptor pool has not had any descriptor sets freed since it was created or most recently reset then fragmentation must: not cause an allocation failure (note that this is always the case for a pool created without the ename:VK_DESCRIPTOR_POOL_CREATE_FREE_DESCRIPTOR_SET_BIT bit set). Additionally, if all sets allocated from the pool since it was created or most recently reset use the same number of descriptors (of each type) and the requested allocation also uses that same number of descriptors (of each type), then fragmentation must: not cause an allocation failure.
    /// </para>
    /// <para>
    /// If an allocation failure occurs due to fragmentation, an application can: create an additional descriptor pool to perform further descriptor set allocations.
    /// </para>
    /// </summary>
	[Flags]
	public enum DescriptorPoolCreateFlags
	{
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		None = 0,
	    /// <summary>
		/// <para>
		/// Descriptor sets may be freed individually
		/// </para>
		/// </summary>
		FreeDescriptorSet = 1 << 0,
	}

    /// <summary>
    /// <para>
    /// -
    /// </para>
    /// </summary>
	[Flags]
	public enum DescriptorPoolResetFlags
	{
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		None = 0,
	}

    /// <summary>
    /// <para>
    /// -
    /// </para>
    /// </summary>
	[Flags]
	public enum DescriptorSetLayoutCreateFlags
	{
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		None = 0,
	}

    /// <summary>
    /// <para>
    /// -
    /// </para>
    /// </summary>
	[Flags]
	public enum DeviceCreateFlags
	{
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		None = 0,
	}

    /// <summary>
    /// <para>
    /// -
    /// </para>
    /// </summary>
	[Flags]
	public enum DeviceQueueCreateFlags
	{
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		None = 0,
	}

    /// <summary>
    /// <para>
    /// -
    /// </para>
    /// </summary>
	[Flags]
	public enum DisplayModeCreateFlags
	{
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		None = 0,
	}

    /// <summary>
    /// <para>
    /// Alpha blending type.
    /// </para>
    /// <para>
    /// These values are described as follows:
    /// </para>
    /// <para>
    /// * ename:VK_DISPLAY_PLANE_ALPHA_OPAQUE_BIT_KHR: The source image will be treated as opaque. * ename:VK_DISPLAY_PLANE_ALPHA_GLOBAL_BIT_KHR: A global alpha value must: be specified that will be applied to all pixels in the source image. * ename:VK_DISPLAY_PLANE_ALPHA_PER_PIXEL_BIT_KHR: The alpha value will be determined by the alpha channel of the source image's pixels. If the source format contains no alpha values, no blending will be applied. The source alpha values are not premultiplied into the source image's other color channels. * ename:VK_DISPLAY_PLANE_ALPHA_PER_PIXEL_PREMULTIPLIED_BIT_KHR: This is equivalent to ename:VK_DISPLAY_PLANE_ALPHA_PER_PIXEL_BIT_KHR except the source alpha values are assumed to be premultiplied into the source image's other color channels.
    /// </para>
    /// </summary>
	[Flags]
	public enum DisplayPlaneAlphaFlags
	{
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		None = 0,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		Opaque = 1 << 0,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		Global = 1 << 1,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		PerPixel = 1 << 2,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		PerPixelPremultiplied = 1 << 3,
	}

    /// <summary>
    /// <para>
    /// -
    /// </para>
    /// </summary>
	[Flags]
	public enum DisplaySurfaceCreateFlags
	{
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		None = 0,
	}

    /// <summary>
    /// <para>
    /// -
    /// </para>
    /// </summary>
	[Flags]
	public enum EventCreateFlags
	{
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		None = 0,
	}

    /// <summary>
    /// <para>
    /// Bitmask specifying external memory features.
    /// </para>
    /// </summary>
	[Flags]
	public enum ExternalMemoryFeatureFlags
	{
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		None = 0,
	    /// <summary>
		/// <para>
		/// ename:VK_EXTERNAL_MEMORY_FEATURE_DEDICATED_ONLY_BIT_NV: External memory of the specified type must: be created as a dedicated allocation when used in the manner specified.
		/// </para>
		/// </summary>
		DedicatedOnly = 1 << 0,
	    /// <summary>
		/// <para>
		/// ename:VK_EXTERNAL_MEMORY_FEATURE_EXPORTABLE_BIT_NV: The implementation supports exporting handles of the specified type.
		/// </para>
		/// </summary>
		Exportable = 1 << 1,
	    /// <summary>
		/// <para>
		/// ename:VK_EXTERNAL_MEMORY_FEATURE_IMPORTABLE_BIT_NV: The implementation supports importing handles of the specified type.
		/// </para>
		/// </summary>
		Importable = 1 << 2,
	}

    /// <summary>
    /// <para>
    /// Bitmask specifying memory handle types.
    /// </para>
    /// </summary>
	[Flags]
	public enum ExternalMemoryHandleTypeFlags
	{
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		None = 0,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		OpaqueWin32 = 1 << 0,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		OpaqueWin32Kmt = 1 << 1,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		D3d11Image = 1 << 2,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		D3d11ImageKmt = 1 << 3,
	}

    /// <summary>
    /// <para>
    /// Bitmask specifying initial state and behavior of a fence.
    /// </para>
    /// </summary>
	[Flags]
	public enum FenceCreateFlags
	{
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		None = 0,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		Signaled = 1 << 0,
	}

    /// <summary>
    /// <para>
    /// Bitmask specifying features supported by a buffer.
    /// </para>
    /// <para>
    /// The pname:linearTilingFeatures and pname:optimalTilingFeatures members of the sname:VkFormatProperties structure describe what features are supported by ename:VK_IMAGE_TILING_LINEAR and ename:VK_IMAGE_TILING_OPTIMAL images, respectively.
    /// </para>
    /// <para>
    /// The following bits may: be set in pname:linearTilingFeatures and pname:optimalTilingFeatures, indicating they are supported by images or image views created with the queried flink:vkGetPhysicalDeviceFormatProperties::pname:format:
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_FEATURE_SAMPLED_IMAGE_BIT:: sname:VkImageView can: be sampled from. See &lt;&lt;descriptorsets-sampledimage, sampled images&gt;&gt; section.
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_FEATURE_STORAGE_IMAGE_BIT:: sname:VkImageView can: be used as storage image. See &lt;&lt;descriptorsets-storageimage, storage images&gt;&gt; section.
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_FEATURE_STORAGE_IMAGE_ATOMIC_BIT:: sname:VkImageView can: be used as storage image that supports atomic operations.
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_FEATURE_COLOR_ATTACHMENT_BIT:: sname:VkImageView can: be used as a framebuffer color attachment and as an input attachment.
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_FEATURE_COLOR_ATTACHMENT_BLEND_BIT:: sname:VkImageView can: be used as a framebuffer color attachment that supports blending and as an input attachment.
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_FEATURE_DEPTH_STENCIL_ATTACHMENT_BIT:: sname:VkImageView can: be used as a framebuffer depth/stencil attachment and as an input attachment.
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_FEATURE_BLIT_SRC_BIT:: sname:VkImage can: be used as pname:srcImage for the fname:vkCmdBlitImage command.
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_FEATURE_BLIT_DST_BIT:: sname:VkImage can: be used as pname:dstImage for the fname:vkCmdBlitImage command.
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_FEATURE_SAMPLED_IMAGE_FILTER_LINEAR_BIT:: If ename:VK_FORMAT_FEATURE_SAMPLED_IMAGE_BIT is also set, sname:VkImageView can: be used with a sampler that has either of pname:magFilter or pname:minFilter set to ename:VK_FILTER_LINEAR, or pname:mipmapMode set to ename:VK_SAMPLER_MIPMAP_MODE_LINEAR. If ename:VK_FORMAT_FEATURE_BLIT_SRC_BIT is also set, sname:VkImage can be used as the pname:srcImage to flink:vkCmdBlitImage with a pname:filter of ename:VK_FILTER_LINEAR. This bit must: only be exposed for formats that also support the ename:VK_FORMAT_FEATURE_SAMPLED_IMAGE_BIT or ename:VK_FORMAT_FEATURE_BLIT_SRC_BIT. + If the format being queried is a depth/stencil format, this bit only indicates that the depth aspect (not the stencil aspect) of an image of this format supports linear filtering, and that linear filtering of the depth aspect is supported whether depth compare is enabled in the sampler or not. If this bit is not present, linear filtering with depth compare disabled is unsupported and linear filtering with depth compare enabled is supported, but may: compute the filtered value in an implementation-dependent manner which differs from the normal rules of linear filtering. The resulting value must: be in the range latexmath:[$[0,1\]$] and should: be proportional to, or a weighted average of, the number of comparison passes or failures.
    /// </para>
    /// <para>
    /// ifdef::VK_IMG_filter_cubic[] include::VK_IMG_filter_cubic/filter_cubic_sampled_bit_description.txt[] endif::VK_IMG_filter_cubic[]
    /// </para>
    /// <para>
    /// The following features may: appear in pname:bufferFeatures, indicating they are supported by buffers or buffer views created with the queried flink:vkGetPhysicalDeviceFormatProperties::pname:format:
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_FEATURE_UNIFORM_TEXEL_BUFFER_BIT:: Format can: be used to create a sname:VkBufferView that can: be bound to a ename:VK_DESCRIPTOR_TYPE_UNIFORM_TEXEL_BUFFER descriptor.
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_FEATURE_STORAGE_TEXEL_BUFFER_BIT:: Format can: be used to create a sname:VkBufferView that can: be bound to a ename:VK_DESCRIPTOR_TYPE_STORAGE_TEXEL_BUFFER descriptor.
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_FEATURE_STORAGE_TEXEL_BUFFER_ATOMIC_BIT:: Atomic operations are supported on ename:VK_DESCRIPTOR_TYPE_STORAGE_TEXEL_BUFFER with this format.
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_FEATURE_VERTEX_BUFFER_BIT:: Format can: be used as a vertex attribute format (sname:VkVertexInputAttributeDescription::pname:format).
    /// </para>
    /// <para>
    /// [NOTE] .Note ==== If no format feature flags are supported, then the only possible use would be image transfers - which alone are not useful. As such, if no format feature flags are supported, the format itself is not supported, and images of that format cannot be created. ====
    /// </para>
    /// <para>
    /// If pname:format is a block-compression format, then buffers must: not support any features for the format.
    /// </para>
    /// </summary>
	[Flags]
	public enum FormatFeatureFlags
	{
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		None = 0,
	    /// <summary>
		/// <para>
		/// Format can be used for sampled images (SAMPLED_IMAGE and COMBINED_IMAGE_SAMPLER descriptor types)
		/// </para>
		/// </summary>
		SampledImage = 1 << 0,
	    /// <summary>
		/// <para>
		/// Format can be used for storage images (STORAGE_IMAGE descriptor type)
		/// </para>
		/// </summary>
		StorageImage = 1 << 1,
	    /// <summary>
		/// <para>
		/// Format supports atomic operations in case it is used for storage images
		/// </para>
		/// </summary>
		StorageImageAtomic = 1 << 2,
	    /// <summary>
		/// <para>
		/// Format can be used for uniform texel buffers (TBOs)
		/// </para>
		/// </summary>
		UniformTexelBuffer = 1 << 3,
	    /// <summary>
		/// <para>
		/// Format can be used for storage texel buffers (IBOs)
		/// </para>
		/// </summary>
		StorageTexelBuffer = 1 << 4,
	    /// <summary>
		/// <para>
		/// Format supports atomic operations in case it is used for storage texel buffers
		/// </para>
		/// </summary>
		StorageTexelBufferAtomic = 1 << 5,
	    /// <summary>
		/// <para>
		/// Format can be used for vertex buffers (VBOs)
		/// </para>
		/// </summary>
		VertexBuffer = 1 << 6,
	    /// <summary>
		/// <para>
		/// Format can be used for color attachment images
		/// </para>
		/// </summary>
		ColorAttachment = 1 << 7,
	    /// <summary>
		/// <para>
		/// Format supports blending in case it is used for color attachment images
		/// </para>
		/// </summary>
		ColorAttachmentBlend = 1 << 8,
	    /// <summary>
		/// <para>
		/// Format can be used for depth/stencil attachment images
		/// </para>
		/// </summary>
		DepthStencilAttachment = 1 << 9,
	    /// <summary>
		/// <para>
		/// Format can be used as the source image of blits with vkCmdBlitImage
		/// </para>
		/// </summary>
		BlitSource = 1 << 10,
	    /// <summary>
		/// <para>
		/// Format can be used as the destination image of blits with vkCmdBlitImage
		/// </para>
		/// </summary>
		BlitDestination = 1 << 11,
	    /// <summary>
		/// <para>
		/// Format can be filtered with VK_FILTER_LINEAR when being sampled
		/// </para>
		/// </summary>
		SampledImageFilterLinear = 1 << 12,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		SampledImageFilterCubicBitImg = 13,
	}

    /// <summary>
    /// <para>
    /// -
    /// </para>
    /// </summary>
	[Flags]
	public enum FramebufferCreateFlags
	{
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		None = 0,
	}

    /// <summary>
    /// <para>
    /// Bitmask specifying which aspects of an image are included in a view.
    /// </para>
    /// <para>
    /// The mask must: be only ename:VK_IMAGE_ASPECT_COLOR_BIT, ename:VK_IMAGE_ASPECT_DEPTH_BIT or ename:VK_IMAGE_ASPECT_STENCIL_BIT if pname:format is a color, depth-only or stencil-only format, respectively. If using a depth/stencil format with both depth and stencil components, pname:aspectMask must: include at least one of ename:VK_IMAGE_ASPECT_DEPTH_BIT and ename:VK_IMAGE_ASPECT_STENCIL_BIT, and can: include both.
    /// </para>
    /// <para>
    /// When using an imageView of a depth/stencil image to populate a descriptor set (e.g. for sampling in the shader, or for use as an input attachment), the pname:aspectMask must: only include one bit and selects whether the imageView is used for depth reads (i.e. using a floating-point sampler or input attachment in the shader) or stencil reads (i.e. using an unsigned integer sampler or input attachment in the shader). When an imageView of a depth/stencil image is used as a depth/stencil framebuffer attachment, the pname:aspectMask is ignored and both depth and stencil image subresources are used.
    /// </para>
    /// <para>
    /// The pname:components member is of type slink:VkComponentMapping, and describes a remapping from components of the image to components of the vector returned by shader image instructions. This remapping must: be identity for storage image descriptors, input attachment descriptors, and framebuffer attachments.
    /// </para>
    /// </summary>
	[Flags]
	public enum ImageAspectFlags
	{
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		None = 0,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		Color = 1 << 0,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		Depth = 1 << 1,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		Stencil = 1 << 2,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		Metadata = 1 << 3,
	}

    /// <summary>
    /// <para>
    /// Bitmask specifying additional parameters of an image.
    /// </para>
    /// <para>
    /// These bits have the following meanings:
    /// </para>
    /// <para>
    /// * ename:VK_IMAGE_CREATE_SPARSE_BINDING_BIT indicates that the image will be backed using sparse memory binding. * ename:VK_IMAGE_CREATE_SPARSE_RESIDENCY_BIT indicates that the image can: be partially backed using sparse memory binding. Images created with this flag must: also be created with the ename:VK_IMAGE_CREATE_SPARSE_BINDING_BIT flag. * ename:VK_IMAGE_CREATE_SPARSE_ALIASED_BIT indicates that the image will be backed using sparse memory binding with memory ranges that might also simultaneously be backing another image (or another portion of the same image). Images created with this flag must: also be created with the ename:VK_IMAGE_CREATE_SPARSE_BINDING_BIT flag * ename:VK_IMAGE_CREATE_MUTABLE_FORMAT_BIT indicates that the image can: be used to create a sname:VkImageView with a different format from the image. * ename:VK_IMAGE_CREATE_CUBE_COMPATIBLE_BIT indicates that the image can: be used to create a sname:VkImageView of type ename:VK_IMAGE_VIEW_TYPE_CUBE or ename:VK_IMAGE_VIEW_TYPE_CUBE_ARRAY.
    /// </para>
    /// <para>
    /// If any of the bits ename:VK_IMAGE_CREATE_SPARSE_BINDING_BIT, ename:VK_IMAGE_CREATE_SPARSE_RESIDENCY_BIT, or ename:VK_IMAGE_CREATE_SPARSE_ALIASED_BIT are set, ename:VK_IMAGE_USAGE_TRANSIENT_ATTACHMENT_BIT must: not also be set.
    /// </para>
    /// <para>
    /// See &lt;&lt;sparsememory-sparseresourcefeatures,Sparse Resource Features&gt;&gt; and &lt;&lt;sparsememory-physicalfeatures,Sparse Physical Device Features&gt;&gt; for more details.
    /// </para>
    /// </summary>
	[Flags]
	public enum ImageCreateFlags
	{
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		None = 0,
	    /// <summary>
		/// <para>
		/// Image should support sparse backing
		/// </para>
		/// </summary>
		SparseBinding = 1 << 0,
	    /// <summary>
		/// <para>
		/// Image should support sparse backing with partial residency
		/// </para>
		/// </summary>
		SparseResidency = 1 << 1,
	    /// <summary>
		/// <para>
		/// Image should support constent data access to physical memory ranges mapped into multiple locations of sparse images
		/// </para>
		/// </summary>
		SparseAliased = 1 << 2,
	    /// <summary>
		/// <para>
		/// Allows image views to have different format than the base image
		/// </para>
		/// </summary>
		MutableFormat = 1 << 3,
	    /// <summary>
		/// <para>
		/// Allows creating image views with cube type from the created image
		/// </para>
		/// </summary>
		CubeCompatible = 1 << 4,
	}

    /// <summary>
    /// <para>
    /// Bitmask specifying intended usage of an image.
    /// </para>
    /// <para>
    /// These bits have the following meanings:
    /// </para>
    /// <para>
    /// * ename:VK_IMAGE_USAGE_TRANSFER_SRC_BIT indicates that the image can: be used as the source of a transfer command. * ename:VK_IMAGE_USAGE_TRANSFER_DST_BIT indicates that the image can: be used as the destination of a transfer command. * ename:VK_IMAGE_USAGE_SAMPLED_BIT indicates that the image can: be used to create a sname:VkImageView suitable for occupying a sname:VkDescriptorSet slot either of type ename:VK_DESCRIPTOR_TYPE_SAMPLED_IMAGE or ename:VK_DESCRIPTOR_TYPE_COMBINED_IMAGE_SAMPLER, and be sampled by a shader. * ename:VK_IMAGE_USAGE_STORAGE_BIT indicates that the image can: be used to create a sname:VkImageView suitable for occupying a sname:VkDescriptorSet slot of type ename:VK_DESCRIPTOR_TYPE_STORAGE_IMAGE. * ename:VK_IMAGE_USAGE_COLOR_ATTACHMENT_BIT indicates that the image can: be used to create a sname:VkImageView suitable for use as a color or resolve attachment in a sname:VkFramebuffer. * ename:VK_IMAGE_USAGE_DEPTH_STENCIL_ATTACHMENT_BIT indicates that the image can: be used to create a sname:VkImageView suitable for use as a depth/stencil attachment in a sname:VkFramebuffer. * ename:VK_IMAGE_USAGE_TRANSIENT_ATTACHMENT_BIT indicates that the memory bound to this image will have been allocated with the ename:VK_MEMORY_PROPERTY_LAZILY_ALLOCATED_BIT (see &lt;&lt;memory&gt;&gt; for more detail). This bit can: be set for any image that can: be used to create a sname:VkImageView suitable for use as a color, resolve, depth/stencil, or input attachment. * ename:VK_IMAGE_USAGE_INPUT_ATTACHMENT_BIT indicates that the image can: be used to create a sname:VkImageView suitable for occupying sname:VkDescriptorSet slot of type ename:VK_DESCRIPTOR_TYPE_INPUT_ATTACHMENT; be read from a shader as an input attachment; and be used as an input attachment in a framebuffer.
    /// </para>
    /// </summary>
	[Flags]
	public enum ImageUsageFlags
	{
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		None = 0,
	    /// <summary>
		/// <para>
		/// Can be used as a source of transfer operations
		/// </para>
		/// </summary>
		TransferSource = 1 << 0,
	    /// <summary>
		/// <para>
		/// Can be used as a destination of transfer operations
		/// </para>
		/// </summary>
		TransferDestination = 1 << 1,
	    /// <summary>
		/// <para>
		/// Can be sampled from (SAMPLED_IMAGE and COMBINED_IMAGE_SAMPLER descriptor types)
		/// </para>
		/// </summary>
		Sampled = 1 << 2,
	    /// <summary>
		/// <para>
		/// Can be used as storage image (STORAGE_IMAGE descriptor type)
		/// </para>
		/// </summary>
		Storage = 1 << 3,
	    /// <summary>
		/// <para>
		/// Can be used as framebuffer color attachment
		/// </para>
		/// </summary>
		ColorAttachment = 1 << 4,
	    /// <summary>
		/// <para>
		/// Can be used as framebuffer depth/stencil attachment
		/// </para>
		/// </summary>
		DepthStencilAttachment = 1 << 5,
	    /// <summary>
		/// <para>
		/// Image data not needed outside of rendering
		/// </para>
		/// </summary>
		TransientAttachment = 1 << 6,
	    /// <summary>
		/// <para>
		/// Can be used as framebuffer input attachment
		/// </para>
		/// </summary>
		InputAttachment = 1 << 7,
	}

    /// <summary>
    /// <para>
    /// -
    /// </para>
    /// </summary>
	[Flags]
	public enum ImageViewCreateFlags
	{
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		None = 0,
	}

    /// <summary>
    /// <para>
    /// -
    /// </para>
    /// </summary>
	[Flags]
	public enum InstanceCreateFlags
	{
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		None = 0,
	}

    /// <summary>
    /// <para>
    /// Bitmask specifying attribute flags for a heap.
    /// </para>
    /// </summary>
	[Flags]
	public enum MemoryHeapFlags
	{
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		None = 0,
	    /// <summary>
		/// <para>
		/// If set, heap represents device memory
		/// </para>
		/// </summary>
		DeviceLocal = 1 << 0,
	}

    /// <summary>
    /// <para>
    /// -
    /// </para>
    /// </summary>
	[Flags]
	public enum MemoryMapFlags
	{
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		None = 0,
	}

    /// <summary>
    /// <para>
    /// Bitmask specifying properties for a memory type.
    /// </para>
    /// </summary>
	[Flags]
	public enum MemoryPropertyFlags
	{
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		None = 0,
	    /// <summary>
		/// <para>
		/// If otherwise stated, then allocate memory on device
		/// </para>
		/// </summary>
		DeviceLocal = 1 << 0,
	    /// <summary>
		/// <para>
		/// Memory is mappable by host
		/// </para>
		/// </summary>
		HostVisible = 1 << 1,
	    /// <summary>
		/// <para>
		/// Memory will have i/o coherency. If not set, application may need to use vkFlushMappedMemoryRanges and vkInvalidateMappedMemoryRanges to flush/invalidate host cache
		/// </para>
		/// </summary>
		HostCoherent = 1 << 2,
	    /// <summary>
		/// <para>
		/// Memory will be cached by the host
		/// </para>
		/// </summary>
		HostCached = 1 << 3,
	    /// <summary>
		/// <para>
		/// Memory may be allocated by the driver when it is required
		/// </para>
		/// </summary>
		LazilyAllocated = 1 << 4,
	}

    /// <summary>
    /// <para>
    /// -
    /// </para>
    /// </summary>
	[Flags]
	public enum MirSurfaceCreateFlags
	{
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		None = 0,
	}

    /// <summary>
    /// <para>
    /// -
    /// </para>
    /// </summary>
	[Flags]
	public enum PipelineCacheCreateFlags
	{
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		None = 0,
	}

    /// <summary>
    /// <para>
    /// -
    /// </para>
    /// </summary>
	[Flags]
	public enum PipelineColorBlendStateCreateFlags
	{
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		None = 0,
	}

    /// <summary>
    /// <para>
    /// Bitmask controlling how a pipeline is generated.
    /// </para>
    /// <para>
    /// It is valid to set both ename:VK_PIPELINE_CREATE_ALLOW_DERIVATIVES_BIT and ename:VK_PIPELINE_CREATE_DERIVATIVE_BIT. This allows a pipeline to be both a parent and possibly a child in a pipeline hierarchy. See &lt;&lt;pipelines-pipeline-derivatives,Pipeline Derivatives&gt;&gt; for more information.
    /// </para>
    /// <para>
    /// pname:pDynamicState points to a structure of type sname:VkPipelineDynamicStateCreateInfo.
    /// </para>
    /// <para>
    /// ifdef::VK_NV_glsl_shader[] If any shader stage fails to compile, ifdef::VK_EXT_debug_report[] the compile log will be reported back to the application, and endif::VK_EXT_debug_report[] ename:VK_ERROR_INVALID_SHADER_NV will be generated. endif::VK_NV_glsl_shader[]
    /// </para>
    /// </summary>
	[Flags]
	public enum PipelineCreateFlags
	{
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		None = 0,
	    /// <summary>
		/// <para>
		/// ename:VK_PIPELINE_CREATE_DISABLE_OPTIMIZATION_BIT specifies that the created pipeline will not be optimized. Using this flag may: reduce the time taken to create the pipeline.
		/// </para>
		/// </summary>
		DisableOptimization = 1 << 0,
	    /// <summary>
		/// <para>
		/// ename:VK_PIPELINE_CREATE_ALLOW_DERIVATIVES_BIT specifies that the pipeline to be created is allowed to be the parent of a pipeline that will be created in a subsequent call to flink:vkCreateGraphicsPipelines.
		/// </para>
		/// </summary>
		AllowDerivatives = 1 << 1,
	    /// <summary>
		/// <para>
		/// ename:VK_PIPELINE_CREATE_DERIVATIVE_BIT specifies that the pipeline to be created will be a child of a previously created parent pipeline.
		/// </para>
		/// </summary>
		Derivative = 1 << 2,
	}

    /// <summary>
    /// <para>
    /// -
    /// </para>
    /// </summary>
	[Flags]
	public enum PipelineDepthStencilStateCreateFlags
	{
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		None = 0,
	}

    /// <summary>
    /// <para>
    /// -
    /// </para>
    /// </summary>
	[Flags]
	public enum PipelineDynamicStateCreateFlags
	{
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		None = 0,
	}

    /// <summary>
    /// <para>
    /// -
    /// </para>
    /// </summary>
	[Flags]
	public enum PipelineInputAssemblyStateCreateFlags
	{
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		None = 0,
	}

    /// <summary>
    /// <para>
    /// -
    /// </para>
    /// </summary>
	[Flags]
	public enum PipelineLayoutCreateFlags
	{
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		None = 0,
	}

    /// <summary>
    /// <para>
    /// -
    /// </para>
    /// </summary>
	[Flags]
	public enum PipelineMultisampleStateCreateFlags
	{
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		None = 0,
	}

    /// <summary>
    /// <para>
    /// -
    /// </para>
    /// </summary>
	[Flags]
	public enum PipelineRasterizationStateCreateFlags
	{
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		None = 0,
	}

    /// <summary>
    /// <para>
    /// -
    /// </para>
    /// </summary>
	[Flags]
	public enum PipelineShaderStageCreateFlags
	{
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		None = 0,
	}

    /// <summary>
    /// <para>
    /// Bitmask specifying pipeline stages.
    /// </para>
    /// <para>
    /// The meaning of each bit is:
    /// </para>
    /// <para>
    /// * ename:VK_PIPELINE_STAGE_TOP_OF_PIPE_BIT: Stage of the pipeline where commands are initially received by the queue. * ename:VK_PIPELINE_STAGE_DRAW_INDIRECT_BIT: Stage of the pipeline where Draw/DispatchIndirect data structures are consumed. * ename:VK_PIPELINE_STAGE_VERTEX_INPUT_BIT: Stage of the pipeline where vertex and index buffers are consumed. * ename:VK_PIPELINE_STAGE_VERTEX_SHADER_BIT: Vertex shader stage. * ename:VK_PIPELINE_STAGE_TESSELLATION_CONTROL_SHADER_BIT: Tessellation control shader stage. * ename:VK_PIPELINE_STAGE_TESSELLATION_EVALUATION_SHADER_BIT: Tessellation evaluation shader stage. * ename:VK_PIPELINE_STAGE_GEOMETRY_SHADER_BIT: Geometry shader stage. * ename:VK_PIPELINE_STAGE_FRAGMENT_SHADER_BIT: Fragment shader stage. * ename:VK_PIPELINE_STAGE_EARLY_FRAGMENT_TESTS_BIT: Stage of the pipeline where early fragment tests (depth and stencil tests before fragment shading) are performed. * ename:VK_PIPELINE_STAGE_LATE_FRAGMENT_TESTS_BIT: Stage of the pipeline where late fragment tests (depth and stencil tests after fragment shading) are performed. * ename:VK_PIPELINE_STAGE_COLOR_ATTACHMENT_OUTPUT_BIT: Stage of the pipeline after blending where the final color values are output from the pipeline. This stage also includes resolve operations that occur at the end of a subpass. Note that this does not necessarily indicate that the values have been committed to memory. * [[synchronization-transfer]]ename:VK_PIPELINE_STAGE_TRANSFER_BIT: Execution of copy commands. This includes the operations resulting from all transfer commands. The set of transfer commands comprises fname:vkCmdCopyBuffer, fname:vkCmdCopyImage, fname:vkCmdBlitImage, fname:vkCmdCopyBufferToImage, fname:vkCmdCopyImageToBuffer, fname:vkCmdUpdateBuffer, fname:vkCmdFillBuffer, fname:vkCmdClearColorImage, fname:vkCmdClearDepthStencilImage, fname:vkCmdResolveImage, and fname:vkCmdCopyQueryPoolResults. * ename:VK_PIPELINE_STAGE_COMPUTE_SHADER_BIT: Execution of a compute shader. * ename:VK_PIPELINE_STAGE_BOTTOM_OF_PIPE_BIT: Final stage in the pipeline where commands complete execution. * ename:VK_PIPELINE_STAGE_HOST_BIT: A pseudo-stage indicating execution on the host of reads/writes of device memory. * ename:VK_PIPELINE_STAGE_ALL_GRAPHICS_BIT: Execution of all graphics pipeline stages. * ename:VK_PIPELINE_STAGE_ALL_COMMANDS_BIT: Execution of all stages supported on the queue.
    /// </para>
    /// <para>
    /// [NOTE] .Note ==== The ename:VK_PIPELINE_STAGE_ALL_COMMANDS_BIT and ename:VK_PIPELINE_STAGE_ALL_GRAPHICS_BIT differ from ename:VK_PIPELINE_STAGE_BOTTOM_OF_PIPE_BIT in that they correspond to all (or all graphics) stages, rather than to a specific stage at the end of the pipeline. An execution dependency with only ename:VK_PIPELINE_STAGE_BOTTOM_OF_PIPE_BIT in pname:dstStageMask will not delay subsequent commands, while including either of the other two bits will. Similarly, when defining a memory dependency, if the stage mask(s) refer to all stages, then the indicated access types from all stages will be made available and/or visible, but using only ename:VK_PIPELINE_STAGE_BOTTOM_OF_PIPE_BIT would not make any accesses available and/or visible because this stage does not access memory. The ename:VK_PIPELINE_STAGE_BOTTOM_OF_PIPE_BIT is useful for accomplishing memory barriers and layout transitions when the next accesses will be done in a different queue or by a presentation engine; in these cases subsequent commands in the same queue do not need to wait, but the barrier or transition must: complete before semaphores associated with the batch signal. ====
    /// </para>
    /// </summary>
	[Flags]
	public enum PipelineStageFlags
	{
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		None = 0,
	    /// <summary>
		/// <para>
		/// Before subsequent commands are processed
		/// </para>
		/// </summary>
		TopOfPipe = 1 << 0,
	    /// <summary>
		/// <para>
		/// Draw/DispatchIndirect command fetch
		/// </para>
		/// </summary>
		DrawIndirect = 1 << 1,
	    /// <summary>
		/// <para>
		/// Vertex/index fetch
		/// </para>
		/// </summary>
		VertexInput = 1 << 2,
	    /// <summary>
		/// <para>
		/// Vertex shading
		/// </para>
		/// </summary>
		VertexShader = 1 << 3,
	    /// <summary>
		/// <para>
		/// Tessellation control shading
		/// </para>
		/// </summary>
		TessellationControlShader = 1 << 4,
	    /// <summary>
		/// <para>
		/// Tessellation evaluation shading
		/// </para>
		/// </summary>
		TessellationEvaluationShader = 1 << 5,
	    /// <summary>
		/// <para>
		/// Geometry shading
		/// </para>
		/// </summary>
		GeometryShader = 1 << 6,
	    /// <summary>
		/// <para>
		/// Fragment shading
		/// </para>
		/// </summary>
		FragmentShader = 1 << 7,
	    /// <summary>
		/// <para>
		/// Early fragment (depth and stencil) tests
		/// </para>
		/// </summary>
		EarlyFragmentTests = 1 << 8,
	    /// <summary>
		/// <para>
		/// Late fragment (depth and stencil) tests
		/// </para>
		/// </summary>
		LateFragmentTests = 1 << 9,
	    /// <summary>
		/// <para>
		/// Color attachment writes
		/// </para>
		/// </summary>
		ColorAttachmentOutput = 1 << 10,
	    /// <summary>
		/// <para>
		/// Compute shading
		/// </para>
		/// </summary>
		ComputeShader = 1 << 11,
	    /// <summary>
		/// <para>
		/// Transfer/copy operations
		/// </para>
		/// </summary>
		Transfer = 1 << 12,
	    /// <summary>
		/// <para>
		/// After previous commands have completed
		/// </para>
		/// </summary>
		BottomOfPipe = 1 << 13,
	    /// <summary>
		/// <para>
		/// Indicates host (CPU) is a source/sink of the dependency
		/// </para>
		/// </summary>
		Host = 1 << 14,
	    /// <summary>
		/// <para>
		/// All stages of the graphics pipeline
		/// </para>
		/// </summary>
		AllGraphics = 1 << 15,
	    /// <summary>
		/// <para>
		/// All stages supported on the queue
		/// </para>
		/// </summary>
		AllCommands = 1 << 16,
	}

    /// <summary>
    /// <para>
    /// -
    /// </para>
    /// </summary>
	[Flags]
	public enum PipelineTessellationStateCreateFlags
	{
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		None = 0,
	}

    /// <summary>
    /// <para>
    /// -
    /// </para>
    /// </summary>
	[Flags]
	public enum PipelineVertexInputStateCreateFlags
	{
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		None = 0,
	}

    /// <summary>
    /// <para>
    /// -
    /// </para>
    /// </summary>
	[Flags]
	public enum PipelineViewportStateCreateFlags
	{
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		None = 0,
	}

    /// <summary>
    /// <para>
    /// Bitmask specifying constraints on a query.
    /// </para>
    /// <para>
    /// If the pname:queryType of the pool is ename:VK_QUERY_TYPE_OCCLUSION and pname:flags contains ename:VK_QUERY_CONTROL_PRECISE_BIT, an implementation must: return a result that matches the actual number of samples passed. This is described in more detail in &lt;&lt;queries-occlusion,Occlusion Queries&gt;&gt;.
    /// </para>
    /// <para>
    /// [[queries-operation-active]] After beginning a query, that query is considered _active_ within the command buffer it was called in until that same query is ended. Queries active in a primary command buffer when secondary command buffers are executed are considered active for those secondary command buffers.
    /// </para>
    /// </summary>
	[Flags]
	public enum QueryControlFlags
	{
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		None = 0,
	    /// <summary>
		/// <para>
		/// Require precise results to be collected by the query
		/// </para>
		/// </summary>
		Precise = 1 << 0,
	}

    /// <summary>
    /// <para>
    /// Bitmask specifying queried pipeline statistics.
    /// </para>
    /// <para>
    /// These bits have the following meanings:
    /// </para>
    /// <para>
    /// * If ename:VK_QUERY_PIPELINE_STATISTIC_INPUT_ASSEMBLY_VERTICES_BIT is set, queries managed by the pool will count the number of vertices processed by the &lt;&lt;drawing,input assembly&gt;&gt; stage. Vertices corresponding to incomplete primitives may: contribute to the count. * If ename:VK_QUERY_PIPELINE_STATISTIC_INPUT_ASSEMBLY_PRIMITIVES_BIT is set, queries managed by the pool will count the number of primitives processed by the &lt;&lt;drawing,input assembly&gt;&gt; stage. If primitive restart is enabled, restarting the primitive topology has no effect on the count. Incomplete primitives may: be counted. * If ename:VK_QUERY_PIPELINE_STATISTIC_VERTEX_SHADER_INVOCATIONS_BIT is set, queries managed by the pool will count the number of vertex shader invocations. This counter's value is incremented each time a vertex shader is &lt;&lt;shaders-vertex-execution,invoked&gt;&gt;. * If ename:VK_QUERY_PIPELINE_STATISTIC_GEOMETRY_SHADER_INVOCATIONS_BIT is set, queries managed by the pool will count the number of geometry shader invocations. This counter's value is incremented each time a geometry shader is &lt;&lt;shaders-geometry-execution,invoked&gt;&gt;. In the case of &lt;&lt;geometry-invocations,instanced geometry shaders&gt;&gt;, the geometry shader invocations count is incremented for each separate instanced invocation. * If ename:VK_QUERY_PIPELINE_STATISTIC_GEOMETRY_SHADER_PRIMITIVES_BIT is set, queries managed by the pool will count the number of primitives generated by geometry shader invocations. The counter's value is incremented each time the geometry shader emits a primitive. Restarting primitive topology using the SPIR-V instructions code:OpEndPrimitive or code:OpEndStreamPrimitive has no effect on the geometry shader output primitives count. * If ename:VK_QUERY_PIPELINE_STATISTIC_CLIPPING_INVOCATIONS_BIT is set, queries managed by the pool will count the number of primitives processed by the &lt;&lt;vertexpostproc-clipping,Primitive Clipping&gt;&gt; stage of the pipeline. The counter's value is incremented each time a primitive reaches the primitive clipping stage. * If ename:VK_QUERY_PIPELINE_STATISTIC_CLIPPING_PRIMITIVES_BIT is set, queries managed by the pool will count the number of primitives output by the &lt;&lt;vertexpostproc-clipping,Primitive Clipping&gt;&gt; stage of the pipeline. The counter's value is incremented each time a primitive passes the primitive clipping stage. The actual number of primitives output by the primitive clipping stage for a particular input primitive is implementation-dependent but must: satisfy the following conditions: ** If at least one vertex of the input primitive lies inside the clipping volume, the counter is incremented by one or more. ** Otherwise, the counter is incremented by zero or more. * If ename:VK_QUERY_PIPELINE_STATISTIC_FRAGMENT_SHADER_INVOCATIONS_BIT is set, queries managed by the pool will count the number of fragment shader invocations. The counter's value is incremented each time the fragment shader is &lt;&lt;shaders-fragment-execution,invoked&gt;&gt;. * If ename:VK_QUERY_PIPELINE_STATISTIC_TESSELLATION_CONTROL_SHADER_PATCHES_BIT is set, queries managed by the pool will count the number of patches processed by the tessellation control shader. The counter's value is incremented once for each patch for which a tessellation control shader is &lt;&lt;shaders-tessellation-control-execution,invoked&gt;&gt;. * If ename:VK_QUERY_PIPELINE_STATISTIC_TESSELLATION_EVALUATION_SHADER_INVOCATIONS_BIT is set, queries managed by the pool will count the number of invocations of the tessellation evaluation shader. The counter's value is incremented each time the tessellation evaluation shader is &lt;&lt;shaders-tessellation-evaluation-execution,invoked&gt;&gt;. * If ename:VK_QUERY_PIPELINE_STATISTIC_COMPUTE_SHADER_INVOCATIONS_BIT is set, queries managed by the pool will count the number of compute shader invocations. The counter's value is incremented every time the compute shader is invoked. Implementations may: skip the execution of certain compute shader invocations or execute additional compute shader invocations for implementation-dependent reasons as long as the results of rendering otherwise remain unchanged.
    /// </para>
    /// <para>
    /// These values are intended to measure relative statistics on one implementation. Various device architectures will count these values differently. Any or all counters may: be affected by the issues described in &lt;&lt;queries-operation-undefined,Query Operation&gt;&gt;.
    /// </para>
    /// <para>
    /// [NOTE] .Note ==== For example, tile-based rendering devices may: need to replay the scene multiple times, affecting some of the counts. ====
    /// </para>
    /// <para>
    /// If a pipeline has pname:rasterizerDiscardEnable enabled, implementations may: discard primitives after the final vertex processing stage. As a result, if pname:rasterizerDiscardEnable is enabled, the clipping input and output primitives counters may: not be incremented.
    /// </para>
    /// <para>
    /// When a pipeline statistics query finishes, the result for that query is marked as available. The application can: copy the result to a buffer (via fname:vkCmdCopyQueryPoolResults), or request it be put into host memory (via fname:vkGetQueryPoolResults).
    /// </para>
    /// </summary>
	[Flags]
	public enum QueryPipelineStatisticFlags
	{
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		None = 0,
	    /// <summary>
		/// <para>
		/// Optional
		/// </para>
		/// </summary>
		InputAssemblyVertices = 1 << 0,
	    /// <summary>
		/// <para>
		/// Optional
		/// </para>
		/// </summary>
		InputAssemblyPrimitives = 1 << 1,
	    /// <summary>
		/// <para>
		/// Optional
		/// </para>
		/// </summary>
		VertexShaderInvocations = 1 << 2,
	    /// <summary>
		/// <para>
		/// Optional
		/// </para>
		/// </summary>
		GeometryShaderInvocations = 1 << 3,
	    /// <summary>
		/// <para>
		/// Optional
		/// </para>
		/// </summary>
		GeometryShaderPrimitives = 1 << 4,
	    /// <summary>
		/// <para>
		/// Optional
		/// </para>
		/// </summary>
		ClippingInvocations = 1 << 5,
	    /// <summary>
		/// <para>
		/// Optional
		/// </para>
		/// </summary>
		ClippingPrimitives = 1 << 6,
	    /// <summary>
		/// <para>
		/// Optional
		/// </para>
		/// </summary>
		FragmentShaderInvocations = 1 << 7,
	    /// <summary>
		/// <para>
		/// Optional
		/// </para>
		/// </summary>
		TessellationControlShaderPatches = 1 << 8,
	    /// <summary>
		/// <para>
		/// Optional
		/// </para>
		/// </summary>
		TessellationEvaluationShaderInvocations = 1 << 9,
	    /// <summary>
		/// <para>
		/// Optional
		/// </para>
		/// </summary>
		ComputeShaderInvocations = 1 << 10,
	}

    /// <summary>
    /// <para>
    /// -
    /// </para>
    /// </summary>
	[Flags]
	public enum QueryPoolCreateFlags
	{
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		None = 0,
	}

    /// <summary>
    /// <para>
    /// Bitmask specifying how and when query results are returned.
    /// </para>
    /// <para>
    /// If no bits are set in pname:flags, and all requested queries are in the available state, results are written as an array of 32-bit unsigned integer values. The behavior when not all queries are available, is described &lt;&lt;queries-wait-bit-not-set, below&gt;&gt;.
    /// </para>
    /// <para>
    /// If ename:VK_QUERY_RESULT_64_BIT is not set and the result overflows a 32-bit value, the value may: either wrap or saturate. Similarly, if ename:VK_QUERY_RESULT_64_BIT is set and the result overflows a 64-bit value, the value may: either wrap or saturate.
    /// </para>
    /// <para>
    /// If ename:VK_QUERY_RESULT_WAIT_BIT is set, Vulkan will wait for each query to be in the available state before retrieving the numerical results for that query. In this case, fname:vkGetQueryPoolResults is guaranteed to succeed and return ename:VK_SUCCESS if the queries become available in a finite time (i.e. if they have been issued and not reset). If queries will never finish (e.g. due to being reset but not issued), then fname:vkGetQueryPoolResults may: not return in finite time.
    /// </para>
    /// <para>
    /// [[queries-wait-bit-not-set]] If ename:VK_QUERY_RESULT_WAIT_BIT and ename:VK_QUERY_RESULT_PARTIAL_BIT are both not set then no result values are written to pname:pData for queries that are in the unavailable state at the time of the call, and fname:vkGetQueryPoolResults returns ename:VK_NOT_READY. However, availability state is still written to pname:pData for those queries if ename:VK_QUERY_RESULT_WITH_AVAILABILITY_BIT is set.
    /// </para>
    /// <para>
    /// [NOTE] .Note ==== Applications must: take care to ensure that use of the ename:VK_QUERY_RESULT_WAIT_BIT bit has the desired effect.
    /// </para>
    /// <para>
    /// For example, if a query has been used previously and a command buffer records the commands fname:vkCmdResetQueryPool, fname:vkCmdBeginQuery, and fname:vkCmdEndQuery for that query, then the query will remain in the available state until the fname:vkCmdResetQueryPool command executes on a queue. Applications can: use fences or events to ensure that a query has already been reset before checking for its results or availability status. Otherwise, a stale value could be returned from a previous use of the query.
    /// </para>
    /// <para>
    /// The above also applies when ename:VK_QUERY_RESULT_WAIT_BIT is used in combination with ename:VK_QUERY_RESULT_WITH_AVAILABILITY_BIT. In this case, the returned availability status may: reflect the result of a previous use of the query unless the fname:vkCmdResetQueryPool command has been executed since the last use of the query. ====
    /// </para>
    /// <para>
    /// [NOTE] .Note ==== Applications can: double-buffer query pool usage, with a pool per frame, and reset queries at the end of the frame in which they are read. ====
    /// </para>
    /// <para>
    /// If ename:VK_QUERY_RESULT_PARTIAL_BIT is set, ename:VK_QUERY_RESULT_WAIT_BIT is not set, and the query's status is unavailable, an intermediate result value between zero and the final result value is written to pname:pData for that query.
    /// </para>
    /// <para>
    /// ename:VK_QUERY_RESULT_PARTIAL_BIT must: not be used if the pool's pname:queryType is ename:VK_QUERY_TYPE_TIMESTAMP.
    /// </para>
    /// <para>
    /// If ename:VK_QUERY_RESULT_WITH_AVAILABILITY_BIT is set, the final integer value written for each query is non-zero if the query's status was available or zero if the status was unavailable. When ename:VK_QUERY_RESULT_WITH_AVAILABILITY_BIT is used, implementations must: guarantee that if they return a non-zero availability value then the numerical results must: be valid, assuming the results are not reset by a subsequent command.
    /// </para>
    /// <para>
    /// [NOTE] .Note ==== Satisfying this guarantee may: require careful ordering by the application, e.g. to read the availability status before reading the results. ====
    /// </para>
    /// </summary>
	[Flags]
	public enum QueryResultFlags
	{
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		None = 0,
	    /// <summary>
		/// <para>
		/// Results of the queries are written to the destination buffer as 64-bit values
		/// </para>
		/// </summary>
		QueryResult64 = 1 << 0,
	    /// <summary>
		/// <para>
		/// Results of the queries are waited on before proceeding with the result copy
		/// </para>
		/// </summary>
		Wait = 1 << 1,
	    /// <summary>
		/// <para>
		/// Besides the results of the query, the availability of the results is also written
		/// </para>
		/// </summary>
		WithAvailability = 1 << 2,
	    /// <summary>
		/// <para>
		/// Copy the partial results of the query even if the final results are not available
		/// </para>
		/// </summary>
		Partial = 1 << 3,
	}

    /// <summary>
    /// <para>
    /// Bitmask specifying capabilities of queues in a queue family.
    /// </para>
    /// <para>
    /// If an implementation exposes any queue family that supports graphics operations, at least one queue family of at least one physical device exposed by the implementation must: support both graphics and compute operations.
    /// </para>
    /// <para>
    /// [NOTE] .Note ==== All commands that are allowed on a queue that supports transfer operations are also allowed on a queue that supports either graphics or compute operations thus if the capabilities of a queue family include ename:VK_QUEUE_GRAPHICS_BIT or ename:VK_QUEUE_COMPUTE_BIT then reporting the ename:VK_QUEUE_TRANSFER_BIT capability separately for that queue family is optional:. ====
    /// </para>
    /// <para>
    /// For further details see &lt;&lt;devsandqueues-queues,Queues&gt;&gt;.
    /// </para>
    /// <para>
    /// The value returned in pname:minImageTransferGranularity has a unit of compressed texel blocks for images having a block-compressed format, and a unit of texels otherwise.
    /// </para>
    /// <para>
    /// Possible values of pname:minImageTransferGranularity are:
    /// </para>
    /// <para>
    /// * latexmath:[$(0,0,0)$] which indicates that only whole mip levels must: be transferred using the image transfer operations on the corresponding queues. In this case, the following restrictions apply to all offset and extent parameters of image transfer operations:
    /// </para>
    /// <para>
    /// ** The pname:x, pname:y, and pname:z members of a slink:VkOffset3D parameter must: always be zero. ** The pname:width, pname:height, and pname:depth members of a slink:VkExtent3D parameter must: always match the width, height, and depth of the image subresource corresponding to the parameter, respectively.
    /// </para>
    /// <para>
    /// * latexmath:[$(Ax, Ay, Az)$] where latexmath:[$Ax$], latexmath:[$Ay$], and latexmath:[$Az$] are all integer powers of two. In this case the following restrictions apply to all image transfer operations:
    /// </para>
    /// <para>
    /// ** pname:x, pname:y, and pname:z of a slink:VkOffset3D parameter must: be integer multiples of latexmath:[$Ax$], latexmath:[$Ay$], and latexmath:[$Az$], respectively. ** pname:width of a slink:VkExtent3D parameter must: be an integer multiple of latexmath:[$Ax$], or else latexmath:[$(x + width)$] must: equal the width of the image subresource corresponding to the parameter. ** pname:height of a slink:VkExtent3D parameter must: be an integer multiple of latexmath:[$Ay$], or else latexmath:[$(y + height)$] must: equal the height of the image subresource corresponding to the parameter. ** pname:depth of a slink:VkExtent3D parameter must: be an integer multiple of latexmath:[$Az$], or else latexmath:[$(z + depth)$] must: equal the depth of the image subresource corresponding to the parameter. ** If the format of the image corresponding to the parameters is one of the block-compressed formats then for the purposes of the above calculations the granularity must: be scaled up by the compressed texel block dimensions.
    /// </para>
    /// <para>
    /// Queues supporting graphics and/or compute operations must: report latexmath:[$(1,1,1)$] in pname:minImageTransferGranularity, meaning that there are no additional restrictions on the granularity of image transfer operations for these queues. Other queues supporting image transfer operations are only required: to support whole mip level transfers, thus pname:minImageTransferGranularity for queues belonging to such queue families may: be latexmath:[$(0,0,0)$].
    /// </para>
    /// </summary>
	[Flags]
	public enum QueueFlags
	{
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		None = 0,
	    /// <summary>
		/// <para>
		/// if ename:VK_QUEUE_GRAPHICS_BIT is set, then the queues in this queue family support graphics operations.
		/// </para>
		/// </summary>
		Graphics = 1 << 0,
	    /// <summary>
		/// <para>
		/// if ename:VK_QUEUE_COMPUTE_BIT is set, then the queues in this queue family support compute operations.
		/// </para>
		/// </summary>
		Compute = 1 << 1,
	    /// <summary>
		/// <para>
		/// if ename:VK_QUEUE_TRANSFER_BIT is set, then the queues in this queue family support transfer operations.
		/// </para>
		/// </summary>
		Transfer = 1 << 2,
	    /// <summary>
		/// <para>
		/// if ename:VK_QUEUE_SPARSE_BINDING_BIT is set, then the queues in this queue family support sparse memory management operations (see &lt;&lt;sparsememory,Sparse Resources&gt;&gt;). If any of the sparse resource features are enabled, then at least one queue family must: support this bit.
		/// </para>
		/// </summary>
		SparseBinding = 1 << 3,
	}

    /// <summary>
    /// <para>
    /// -
    /// </para>
    /// </summary>
	[Flags]
	public enum RenderPassCreateFlags
	{
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		None = 0,
	}

    /// <summary>
    /// <para>
    /// Bitmask specifying sample counts supported for an image used for storage operations.
    /// </para>
    /// </summary>
	[Flags]
	public enum SampleCountFlags
	{
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		None = 0,
	    /// <summary>
		/// <para>
		/// Sample count 1 supported
		/// </para>
		/// </summary>
		SampleCount1 = 1 << 0,
	    /// <summary>
		/// <para>
		/// Sample count 2 supported
		/// </para>
		/// </summary>
		SampleCount2 = 1 << 1,
	    /// <summary>
		/// <para>
		/// Sample count 4 supported
		/// </para>
		/// </summary>
		SampleCount4 = 1 << 2,
	    /// <summary>
		/// <para>
		/// Sample count 8 supported
		/// </para>
		/// </summary>
		SampleCount8 = 1 << 3,
	    /// <summary>
		/// <para>
		/// Sample count 16 supported
		/// </para>
		/// </summary>
		SampleCount16 = 1 << 4,
	    /// <summary>
		/// <para>
		/// Sample count 32 supported
		/// </para>
		/// </summary>
		SampleCount32 = 1 << 5,
	    /// <summary>
		/// <para>
		/// Sample count 64 supported
		/// </para>
		/// </summary>
		SampleCount64 = 1 << 6,
	}

    /// <summary>
    /// <para>
    /// -
    /// </para>
    /// </summary>
	[Flags]
	public enum SamplerCreateFlags
	{
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		None = 0,
	}

    /// <summary>
    /// <para>
    /// -
    /// </para>
    /// </summary>
	[Flags]
	public enum SemaphoreCreateFlags
	{
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		None = 0,
	}

    /// <summary>
    /// <para>
    /// -
    /// </para>
    /// </summary>
	[Flags]
	public enum ShaderModuleCreateFlags
	{
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		None = 0,
	}

    /// <summary>
    /// <para>
    /// Bitmask specifying a pipeline stage.
    /// </para>
    /// </summary>
	[Flags]
	public enum ShaderStageFlags
	{
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		None = 0,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		Vertex = 1 << 0,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		TessellationControl = 1 << 1,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		TessellationEvaluation = 1 << 2,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		Geometry = 1 << 3,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		Fragment = 1 << 4,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		Compute = 1 << 5,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		AllGraphics = 0x0000001F,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		All = 0x7FFFFFFF,
	}

    /// <summary>
    /// <para>
    /// Bitmask specifying additional information about a sparse image resource.
    /// </para>
    /// </summary>
	[Flags]
	public enum SparseImageFormatFlags
	{
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		None = 0,
	    /// <summary>
		/// <para>
		/// Image uses a single mip tail region for all array layers
		/// </para>
		/// </summary>
		SingleMiptail = 1 << 0,
	    /// <summary>
		/// <para>
		/// Image requires mip level dimensions to be an integer multiple of the sparse image block dimensions for non-tail mip levels.
		/// </para>
		/// </summary>
		AlignedMipSize = 1 << 1,
	    /// <summary>
		/// <para>
		/// Image uses a non-standard sparse image block dimensions
		/// </para>
		/// </summary>
		NonstandardBlockSize = 1 << 2,
	}

    /// <summary>
    /// <para>
    /// Bitmask specifying usage of a sparse memory binding operation.
    /// </para>
    /// <para>
    /// The _binding range_ latexmath:[$[\mathit{resourceOffset}, \mathit{resourceOffset} + \mathit{size})$] has different constraints based on pname:flags. If pname:flags contains ename:VK_SPARSE_MEMORY_BIND_METADATA_BIT, the binding range must: be within the mip tail region of the metadata aspect. This metadata region is defined by:
    /// </para>
    /// <para>
    /// [latexmath] ++++++++++++++++++++++++++ \begin{align*} \mathit{metadataRegion} = [&amp; \mathit{imageMipTailOffset} + \mathit{imageMipTailStride} \times n,\\ &amp;\mathit{imageMipTailOffset} + \mathit{imageMipTailStride} \times n + \mathit{imageMipTailSize}) \end{align*} ++++++++++++++++++++++++++
    /// </para>
    /// <para>
    /// Where pname:imageMipTailOffset, pname:imageMipTailSize, and pname:imageMipTailStride values are from the slink:VkSparseImageMemoryRequirements that correspond to the metadata aspect of the image. The term latexmath:[$n$] is a valid array layer index for the image.
    /// </para>
    /// <para>
    /// pname:imageMipTailStride is considered to be zero for aspects where sname:VkSparseImageMemoryRequirements::pname:formatProperties.flags contains ename:VK_SPARSE_IMAGE_FORMAT_SINGLE_MIPTAIL_BIT.
    /// </para>
    /// <para>
    /// If pname:flags does not contain ename:VK_SPARSE_MEMORY_BIND_METADATA_BIT, the binding range must: be within the range latexmath:[$[0, {\mathit{VkMemoryRequirements}::\mathit{size}})$].
    /// </para>
    /// </summary>
	[Flags]
	public enum SparseMemoryBindFlags
	{
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		None = 0,
	    /// <summary>
		/// <para>
		/// Operation binds resource metadata to memory
		/// </para>
		/// </summary>
		Metadata = 1 << 0,
	}

    /// <summary>
    /// <para>
    /// Bitmask specifying sets of stencil state for which to update the compare mask.
    /// </para>
    /// </summary>
	[Flags]
	public enum StencilFaceFlags
	{
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		None = 0,
	    /// <summary>
		/// <para>
		/// Front face
		/// </para>
		/// </summary>
		Front = 1 << 0,
	    /// <summary>
		/// <para>
		/// Back face
		/// </para>
		/// </summary>
		Back = 1 << 1,
	    /// <summary>
		/// <para>
		/// Front and back faces
		/// </para>
		/// </summary>
		FrontAndBack = 0x00000003,
	}

    /// <summary>
    /// <para>
    /// -
    /// </para>
    /// </summary>
	[Flags]
	public enum SubpassDescriptionFlags
	{
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		None = 0,
	}

    /// <summary>
    /// <para>
    /// Presentation transforms supported on a device.
    /// </para>
    /// <para>
    /// These values are described as follows:
    /// </para>
    /// <para>
    /// * ename:VK_SURFACE_TRANSFORM_IDENTITY_BIT_KHR: The image content is presented without being transformed. * ename:VK_SURFACE_TRANSFORM_ROTATE_90_BIT_KHR: The image content is rotated 90 degrees clockwise. * ename:VK_SURFACE_TRANSFORM_ROTATE_180_BIT_KHR: The image content is rotated 180 degrees clockwise. * ename:VK_SURFACE_TRANSFORM_ROTATE_270_BIT_KHR: The image content is rotated 270 degrees clockwise. * ename:VK_SURFACE_TRANSFORM_HORIZONTAL_MIRROR_BIT_KHR: The image content is mirrored horizontally. * ename:VK_SURFACE_TRANSFORM_HORIZONTAL_MIRROR_ROTATE_90_BIT_KHR: The image content is mirrored horizontally, then rotated 90 degrees clockwise. * ename:VK_SURFACE_TRANSFORM_HORIZONTAL_MIRROR_ROTATE_180_BIT_KHR: The image content is mirrored horizontally, then rotated 180 degrees clockwise. * ename:VK_SURFACE_TRANSFORM_HORIZONTAL_MIRROR_ROTATE_270_BIT_KHR: The image content is mirrored horizontally, then rotated 270 degrees clockwise. * ename:VK_SURFACE_TRANSFORM_INHERIT_BIT_KHR: The presentation transform is not specified, and is instead determined by platform-specific considerations and mechanisms outside Vulkan.
    /// </para>
    /// </summary>
	[Flags]
	public enum SurfaceTransformFlags
	{
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		None = 0,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		Identity = 1 << 0,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		Rotate90 = 1 << 1,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		Rotate180 = 1 << 2,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		Rotate270 = 1 << 3,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		HorizontalMirror = 1 << 4,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		HorizontalMirrorRotate90 = 1 << 5,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		HorizontalMirrorRotate180 = 1 << 6,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		HorizontalMirrorRotate270 = 1 << 7,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		Inherit = 1 << 8,
	}

    /// <summary>
    /// <para>
    /// -
    /// </para>
    /// </summary>
	[Flags]
	public enum SwapchainCreateFlags
	{
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		None = 0,
	}

    /// <summary>
    /// <para>
    /// -
    /// </para>
    /// </summary>
	[Flags]
	public enum WaylandSurfaceCreateFlags
	{
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		None = 0,
	}

    /// <summary>
    /// <para>
    /// -
    /// </para>
    /// </summary>
	[Flags]
	public enum Win32SurfaceCreateFlags
	{
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		None = 0,
	}

    /// <summary>
    /// <para>
    /// -
    /// </para>
    /// </summary>
	[Flags]
	public enum XcbSurfaceCreateFlags
	{
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		None = 0,
	}

    /// <summary>
    /// <para>
    /// -
    /// </para>
    /// </summary>
	[Flags]
	public enum XlibSurfaceCreateFlags
	{
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		None = 0,
	}

    /// <summary>
    /// <para>
    /// Specify how contents of an attachment are treated at the beginning of a subpass.
    /// </para>
    /// </summary>
	public enum AttachmentLoadOp
	{
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		Load = 0,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		Clear = 1,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		DontCare = 2,
	}

    /// <summary>
    /// <para>
    /// Specify how contents of an attachment are treated at the end of a subpass.
    /// </para>
    /// <para>
    /// If the attachment uses a color format, then pname:loadOp and pname:storeOp are used, and pname:stencilLoadOp and pname:stencilStoreOp are ignored. If the format has depth and/or stencil components, pname:loadOp and pname:storeOp apply only to the depth data, while pname:stencilLoadOp and pname:stencilStoreOp define how the stencil data is handled.
    /// </para>
    /// <para>
    /// [[renderpass-precision]] During a render pass instance, input/color attachments with color formats that have a component size of 8, 16, or 32 bits must: be represented in the attachment's format throughout the instance. Attachments with other floating- or fixed-point color formats, or with depth components may: be represented in a format with a precision higher than the attachment format, but must: be represented with the same range. When such a component is loaded via the pname:loadOp, it will be converted into an implementation-dependent format used by the render pass. Such components must: be converted from the render pass format, to the format of the attachment, before they are stored or resolved at the end of a render pass instance via pname:storeOp. Conversions occur as described in &lt;&lt;fundamentals-numerics,Numeric Representation and Computation&gt;&gt; and &lt;&lt;fundamentals-fixedconv, Fixed-Point Data Conversions&gt;&gt;.
    /// </para>
    /// <para>
    /// [[renderpass-aliasing]] If pname:flags includes ename:VK_ATTACHMENT_DESCRIPTION_MAY_ALIAS_BIT, then the attachment is treated as if it shares physical memory with another attachment in the same render pass. This information limits the ability of the implementation to reorder certain operations (like layout transitions and the pname:loadOp) such that it is not improperly reordered against other uses of the same physical memory via a different attachment. This is described in more detail below.
    /// </para>
    /// </summary>
	public enum AttachmentStoreOp
	{
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		Store = 0,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		DontCare = 1,
	}

    /// <summary>
    /// <para>
    /// Framebuffer blending factors.
    /// </para>
    /// <para>
    /// The semantics of each enum value is described in the table below:
    /// </para>
    /// <para>
    /// .Blend Factors [width="100%",options="header",align="center",cols="59%,28%,13%"] |======================================== |VkBlendFactor                                  | RGB Blend Factors (latexmath:[$S_r,S_g,S_b$]) or (latexmath:[$D_r,D_g,D_b$]) | Alpha Blend Factor (latexmath:[$S_a$] or latexmath:[$D_a$]) |ename:VK_BLEND_FACTOR_ZERO                     | latexmath:[$(0,0,0)$]                           | latexmath:[$0$] |ename:VK_BLEND_FACTOR_ONE                      | latexmath:[$(1,1,1)$]                           | latexmath:[$1$] |ename:VK_BLEND_FACTOR_SRC_COLOR                | latexmath:[$(R_{s0},G_{s0},B_{s0})$]            | latexmath:[$A_{s0}$] |ename:VK_BLEND_FACTOR_ONE_MINUS_SRC_COLOR      | latexmath:[$(1-R_{s0},1-G_{s0},1-B_{s0})$]      | latexmath:[$1-A_{s0}$] |ename:VK_BLEND_FACTOR_DST_COLOR                | latexmath:[$(R_d,G_d,B_d)$]                     | latexmath:[$A_d$] |ename:VK_BLEND_FACTOR_ONE_MINUS_DST_COLOR      | latexmath:[$(1-R_d,1-G_d,1-B_d)$]               | latexmath:[$1-A_d$] |ename:VK_BLEND_FACTOR_SRC_ALPHA                | latexmath:[$(A_{s0},A_{s0},A_{s0})$]            | latexmath:[$A_{s0}$] |ename:VK_BLEND_FACTOR_ONE_MINUS_SRC_ALPHA      | latexmath:[$(1-A_{s0},1-A_{s0},1-A_{s0})$]      | latexmath:[$1-A_{s0}$] |ename:VK_BLEND_FACTOR_DST_ALPHA                | latexmath:[$(A_d,A_d,A_d)$]                     | latexmath:[$A_d$] |ename:VK_BLEND_FACTOR_ONE_MINUS_DST_ALPHA      | latexmath:[$(1-A_d,1-A_d,1-A_d)$]               | latexmath:[$1-A_d$] |ename:VK_BLEND_FACTOR_CONSTANT_COLOR           | latexmath:[$(R_c,G_c,B_c)$]                     | latexmath:[$A_c$] |ename:VK_BLEND_FACTOR_ONE_MINUS_CONSTANT_COLOR | latexmath:[$(1-R_c,1-G_c,1-B_c)$]               | latexmath:[$1-A_c$] |ename:VK_BLEND_FACTOR_CONSTANT_ALPHA           | latexmath:[$(A_c,A_c,A_c)$]                     | latexmath:[$A_c$] |ename:VK_BLEND_FACTOR_ONE_MINUS_CONSTANT_ALPHA | latexmath:[$(1-A_c,1-A_c,1-A_c)$]               | latexmath:[$1-A_c$] |ename:VK_BLEND_FACTOR_SRC_ALPHA_SATURATE       | latexmath:[$(f,f,f); f=\min(A_{s0},1-A_d)$]     | latexmath:[$1$] |ename:VK_BLEND_FACTOR_SRC1_COLOR               | latexmath:[$(R_{s1},G_{s1},B_{s1})$]            | latexmath:[$A_{s1}$] |ename:VK_BLEND_FACTOR_ONE_MINUS_SRC1_COLOR     | latexmath:[$(1-R_{s1},1-G_{s1},1-B_{s1})$]      | latexmath:[$1-A_{s1}$] |ename:VK_BLEND_FACTOR_SRC1_ALPHA               | latexmath:[$(A_{s1},A_{s1},A_{s1})$]            | latexmath:[$A_{s1}$] |ename:VK_BLEND_FACTOR_ONE_MINUS_SRC1_ALPHA     | latexmath:[$(1-A_{s1},1-A_{s1},1-A_{s1})$]      | latexmath:[$1-A_{s1}$] |========================================
    /// </para>
    /// <para>
    /// In this table, the following conventions are used:
    /// </para>
    /// <para>
    /// - latexmath:[$R_{s0},G_{s0},B_{s0}$] and latexmath:[$A_{s0}$] represent the first source color R, G, B, and A components, respectively, for the fragment output location corresponding to the color attachment being blended. - latexmath:[$R_{s1},G_{s1},B_{s1}$] and latexmath:[$A_{s1}$] represent the second source color R, G, B, and A components, respectively, used in dual source blending modes, for the fragment output location corresponding to the color attachment being blended. - latexmath:[$R_d,G_d,B_d$] and latexmath:[$A_d$] represent the R, G, B, and A components of the destination color. That is, the color currently in the corresponding color attachment for this fragment/sample. - latexmath:[$R_c,G_c,B_c$] and latexmath:[$A_c$] represent the blend constant R, G, B, and A components, respectively.
    /// </para>
    /// </summary>
	public enum BlendFactor
	{
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		Zero = 0,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		One = 1,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		SourceColor = 2,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		OneMinusSourceColor = 3,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		DestinationColor = 4,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		OneMinusDestinationColor = 5,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		SourceAlpha = 6,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		OneMinusSourceAlpha = 7,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		DestinationAlpha = 8,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		OneMinusDestinationAlpha = 9,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		ConstantColor = 10,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		OneMinusConstantColor = 11,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		ConstantAlpha = 12,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		OneMinusConstantAlpha = 13,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		SourceAlphaSaturate = 14,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		Src1Color = 15,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		OneMinusSrc1Color = 16,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		Src1Alpha = 17,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		OneMinusSrc1Alpha = 18,
	}

    /// <summary>
    /// <para>
    /// Framebuffer blending operations.
    /// </para>
    /// <para>
    /// &lt;&lt;&lt;
    /// </para>
    /// <para>
    /// The semantics of each enum value is described in the table below:
    /// </para>
    /// <para>
    /// .Blend Operations [width="100%",cols="45%,30%,25%",options="header",align="center"] |========================================== |VkBlendOp                                   | RGB Components                    | Alpha Component
    /// </para>
    /// <para>
    /// |ename:VK_BLEND_OP_ADD | latexmath:[$R=R_{s0}\times S_r+R_d\times D_r$] + latexmath:[$G=G_{s0}\times S_g+G_d\times D_g$] + latexmath:[$B=B_{s0}\times S_b+B_d\times D_b$] | latexmath:[$A=A_{s0}\times S_a+A_d\times D_a$]
    /// </para>
    /// <para>
    /// |ename:VK_BLEND_OP_SUBTRACT | latexmath:[$R=R_{s0}\times S_r-R_d\times D_r$] + latexmath:[$G=G_{s0}\times S_g-G_d\times D_g$] + latexmath:[$B=B_{s0}\times S_b-B_d\times D_b$] | latexmath:[$A=A_{s0}\times S_a-A_d\times D_a$]
    /// </para>
    /// <para>
    /// |ename:VK_BLEND_OP_REVERSE_SUBTRACT | latexmath:[$R=R_d\times D_r-R_{s0}\times S_r$] + latexmath:[$G=G_d\times D_g-G_{s0}\times S_g$] + latexmath:[$B=B_d\times D_b-B_{s0}\times S_b$] | latexmath:[$A=A_d\times D_a-A_{s0}\times S_a$]
    /// </para>
    /// <para>
    /// |ename:VK_BLEND_OP_MIN | latexmath:[$R=\min(R_{s0},R_d)$] + latexmath:[$G=\min(G_{s0},G_d)$] + latexmath:[$B=\min(B_{s0},B_d)$] | latexmath:[$A=\min(A_{s0},A_d)$]
    /// </para>
    /// <para>
    /// |ename:VK_BLEND_OP_MAX | latexmath:[$R=\max(R_{s0},R_d)$] + latexmath:[$G=\max(G_{s0},G_d)$] + latexmath:[$B=\max(B_{s0},B_d)$] | latexmath:[$A=\max(A_{s0},A_d)$] |==========================================
    /// </para>
    /// <para>
    /// In this table, the following conventions are used:
    /// </para>
    /// <para>
    /// - latexmath:[$R_{s0},G_{s0},B_{s0}$] and latexmath:[$A_{s0}$] represent the first source color R, G, B, and A components, respectively. - latexmath:[$R_d,G_d,B_d$] and latexmath:[$A_d$] represent the R, G, B, and A components of the destination color. That is, the color currently in the corresponding color attachment for this fragment/sample. - latexmath:[$S_r,S_g,S_b$] and latexmath:[$S_a$] represent the source blend factor R, G, B, and A components, respectively. - latexmath:[$D_r,D_g,D_b$] and latexmath:[$D_a$] represent the destination blend factor R, G, B, and A components, respectively.
    /// </para>
    /// <para>
    /// The blending operation produces a new set of values latexmath:[$R, G, B$] and latexmath:[$A$], which are written to the framebuffer attachment. If blending is not enabled for this attachment, then latexmath:[$R, G, B$] and latexmath:[$A$] are assigned latexmath:[$R_{s0},G_{s0},B_{s0}$] and latexmath:[$A_{s0}$], respectively.
    /// </para>
    /// <para>
    /// If the color attachment is fixed-point, the components of the source and destination values and blend factors are each clamped to latexmath:[$[0,1\]$] or latexmath:[$[-1,1\]$] respectively for an unsigned normalized or signed normalized color attachment prior to evaluating the blend operations. If the color attachment is floating-point, no clamping occurs.
    /// </para>
    /// </summary>
	public enum BlendOp
	{
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		Add = 0,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		Subtract = 1,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		ReverseSubtract = 2,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		Min = 3,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		Max = 4,
	}

    /// <summary>
    /// <para>
    /// Specify border color used for texture lookups.
    /// </para>
    /// <para>
    /// [NOTE] .Mapping of OpenGL to Vulkan filter modes ================== pname:magFilter values of ename:VK_FILTER_NEAREST and ename:VK_FILTER_LINEAR directly correspond to code:GL_NEAREST and code:GL_LINEAR magnification filters. pname:minFilter and pname:mipmapMode combine to correspond to the similarly named OpenGL minification filter of code:GL_minFilter_MIPMAP_mipmapMode (e.g. pname:minFilter of ename:VK_FILTER_LINEAR and pname:mipmapMode of ename:VK_SAMPLER_MIPMAP_MODE_NEAREST correspond to code:GL_LINEAR_MIPMAP_NEAREST).
    /// </para>
    /// <para>
    /// There are no Vulkan filter modes that directly correspond to OpenGL minification filters of code:GL_LINEAR or code:GL_NEAREST, but they can: be emulated using ename:VK_SAMPLER_MIPMAP_MODE_NEAREST, pname:minLod = 0, and pname:maxLod = 0.25, and using pname:minFilter = ename:VK_FILTER_LINEAR or pname:minFilter = ename:VK_FILTER_NEAREST, respectively.
    /// </para>
    /// <para>
    /// Note that using a pname:maxLod of zero would cause &lt;&lt;textures-texel-filtering,magnification&gt;&gt; to always be performed, and the pname:magFilter to always be used. This is valid, just not an exact match for OpenGL behavior. Clamping the maximum LOD to 0.25 allows the latexmath:[$\lambda$] value to be non-zero and minification to be performed, while still always rounding down to the base level. If the pname:minFilter and pname:magFilter are equal, then using a pname:maxLod of zero also works. ==================
    /// </para>
    /// <para>
    /// pname:addressModeU, pname:addressModeV, and pname:addressModeW must: each have one of the following values:
    /// </para>
    /// </summary>
	public enum BorderColor
	{
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		FloatTransparentBlack = 0,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		IntTransparentBlack = 1,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		FloatOpaqueBlack = 2,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		IntOpaqueBlack = 3,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		FloatOpaqueWhite = 4,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		IntOpaqueWhite = 5,
	}

    /// <summary>
    /// <para>
    /// Supported color space of the presentation engine.
    /// </para>
    /// <para>
    /// [NOTE] .Note ==== If pname:pSurfaceFormats includes just one entry, whose value for pname:format is ename:VK_FORMAT_UNDEFINED, pname:surface has no preferred format.  In this case, the application can use any valid ename:VkFormat value. ====
    /// </para>
    /// <para>
    /// [NOTE] .Note ==== In the initial release of the VK_KHR_surface and VK_KHR_swapchain extensions, the token ename:VK_COLORSPACE_SRGB_NONLINEAR_KHR was used. Starting in the May 13, 2016 updates to the extension branches, matching release 1.0.13 of the core API specification, ename:VK_COLOR_SPACE_SRGB_NONLINEAR_KHR is used instead for consistency with Vulkan naming rules. The older enum is still available for backwards compatibility. ====
    /// </para>
    /// </summary>
	public enum ColorSpace
	{
	    /// <summary>
		/// <para>
		/// ename:VK_COLOR_SPACE_SRGB_NONLINEAR_KHR: The presentation engine supports the sRGB color space.
		/// </para>
		/// </summary>
		SrgbNonlinear = 0,
	}

    /// <summary>
    /// <para>
    /// Structure specifying a command buffer level.
    /// </para>
    /// </summary>
	public enum CommandBufferLevel
	{
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		Primary = 0,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		Secondary = 1,
	}

    /// <summary>
    /// <para>
    /// Stencil comparison function.
    /// </para>
    /// </summary>
	public enum CompareOp
	{
	    /// <summary>
		/// <para>
		/// ename:VK_COMPARE_OP_NEVER: the test never passes.
		/// </para>
		/// </summary>
		Never = 0,
	    /// <summary>
		/// <para>
		/// ename:VK_COMPARE_OP_LESS: the test passes when latexmath:[$R \lt S$].
		/// </para>
		/// </summary>
		Less = 1,
	    /// <summary>
		/// <para>
		/// ename:VK_COMPARE_OP_EQUAL: the test passes when latexmath:[$R = S$].
		/// </para>
		/// </summary>
		Equal = 2,
	    /// <summary>
		/// <para>
		/// ename:VK_COMPARE_OP_LESS_OR_EQUAL: the test passes when latexmath:[$R \leq S$].
		/// </para>
		/// </summary>
		LessOrEqual = 3,
	    /// <summary>
		/// <para>
		/// ename:VK_COMPARE_OP_GREATER: the test passes when latexmath:[$R \gt S$].
		/// </para>
		/// </summary>
		Greater = 4,
	    /// <summary>
		/// <para>
		/// ename:VK_COMPARE_OP_NOT_EQUAL: the test passes when latexmath:[$R \neq S$].
		/// </para>
		/// </summary>
		NotEqual = 5,
	    /// <summary>
		/// <para>
		/// ename:VK_COMPARE_OP_GREATER_OR_EQUAL: the test passes when latexmath:[$R \geq S$].
		/// </para>
		/// </summary>
		GreaterOrEqual = 6,
	    /// <summary>
		/// <para>
		/// ename:VK_COMPARE_OP_ALWAYS: the test always passes.
		/// </para>
		/// </summary>
		Always = 7,
	}

    /// <summary>
    /// <para>
    /// Specify how a component is swizzled.
    /// </para>
    /// <para>
    /// Setting the identity swizzle on a component is equivalent to setting the identity mapping on that component. That is:
    /// </para>
    /// <para>
    /// [[resources-image-views-identity-mappings]] .Component Mappings Equivalent To ename:VK_COMPONENT_SWIZZLE_IDENTITY [options="header"] |==== | Component          | Identity Mapping | pname:components.r | ename:VK_COMPONENT_SWIZZLE_R | pname:components.g | ename:VK_COMPONENT_SWIZZLE_G | pname:components.b | ename:VK_COMPONENT_SWIZZLE_B | pname:components.a | ename:VK_COMPONENT_SWIZZLE_A |====
    /// </para>
    /// </summary>
	public enum ComponentSwizzle
	{
	    /// <summary>
		/// <para>
		/// ename:VK_COMPONENT_SWIZZLE_IDENTITY: the component is set to the identity swizzle.
		/// </para>
		/// </summary>
		Identity = 0,
	    /// <summary>
		/// <para>
		/// ename:VK_COMPONENT_SWIZZLE_ZERO: the component is set to zero.
		/// </para>
		/// </summary>
		Zero = 1,
	    /// <summary>
		/// <para>
		/// ename:VK_COMPONENT_SWIZZLE_ONE: the component is set to either 1 or 1.0 depending on whether the type of the image view format is integer or floating-point respectively, as determined by the &lt;&lt;features-formats-definition,Format Definition&gt;&gt; section for each elink:VkFormat.
		/// </para>
		/// </summary>
		One = 2,
	    /// <summary>
		/// <para>
		/// ename:VK_COMPONENT_SWIZZLE_R: the component is set to the value of the R component of the image.
		/// </para>
		/// </summary>
		R = 3,
	    /// <summary>
		/// <para>
		/// ename:VK_COMPONENT_SWIZZLE_G: the component is set to the value of the G component of the image.
		/// </para>
		/// </summary>
		G = 4,
	    /// <summary>
		/// <para>
		/// ename:VK_COMPONENT_SWIZZLE_B: the component is set to the value of the B component of the image.
		/// </para>
		/// </summary>
		B = 5,
	    /// <summary>
		/// <para>
		/// ename:VK_COMPONENT_SWIZZLE_A: the component is set to the value of the A component of the image.
		/// </para>
		/// </summary>
		A = 6,
	}

    /// <summary>
    /// <para>
    /// -
    /// </para>
    /// </summary>
	public enum DebugReportError
	{
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		None = 0,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		CallbackRef = 1,
	}

    /// <summary>
    /// <para>
    /// -
    /// </para>
    /// </summary>
	public enum DebugReportObjectType
	{
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		Unknown = 0,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		Instance = 1,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		PhysicalDevice = 2,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		Device = 3,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		Queue = 4,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		Semaphore = 5,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		CommandBuffer = 6,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		Fence = 7,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		DeviceMemory = 8,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		Buffer = 9,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		Image = 10,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		Event = 11,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		QueryPool = 12,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		BufferView = 13,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		ImageView = 14,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		ShaderModule = 15,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		PipelineCache = 16,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		PipelineLayout = 17,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		RenderPass = 18,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		Pipeline = 19,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		DescriptorSetLayout = 20,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		Sampler = 21,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		DescriptorPool = 22,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		DescriptorSet = 23,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		Framebuffer = 24,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		CommandPool = 25,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		SurfaceKhr = 26,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		SwapchainKhr = 27,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		DebugReport = 28,
	}

    /// <summary>
    /// <para>
    /// Specifies the type of a descriptor in a descriptor set.
    /// </para>
    /// <para>
    /// If pname:descriptorType is ename:VK_DESCRIPTOR_TYPE_UNIFORM_BUFFER, ename:VK_DESCRIPTOR_TYPE_STORAGE_BUFFER, ename:VK_DESCRIPTOR_TYPE_UNIFORM_BUFFER_DYNAMIC, or ename:VK_DESCRIPTOR_TYPE_STORAGE_BUFFER_DYNAMIC, the elements of the slink:VkWriteDescriptorSet::pname:pBufferInfo array of slink:VkDescriptorBufferInfo structures will be used to update the descriptors, and other arrays will be ignored.
    /// </para>
    /// <para>
    /// If pname:descriptorType is ename:VK_DESCRIPTOR_TYPE_UNIFORM_TEXEL_BUFFER or ename:VK_DESCRIPTOR_TYPE_STORAGE_TEXEL_BUFFER, the slink:VkWriteDescriptorSet::pname:pTexelBufferView array will be used to update the descriptors, and other arrays will be ignored.
    /// </para>
    /// <para>
    /// If pname:descriptorType is ename:VK_DESCRIPTOR_TYPE_SAMPLER, ename:VK_DESCRIPTOR_TYPE_COMBINED_IMAGE_SAMPLER, ename:VK_DESCRIPTOR_TYPE_SAMPLED_IMAGE, ename:VK_DESCRIPTOR_TYPE_STORAGE_IMAGE, or ename:VK_DESCRIPTOR_TYPE_INPUT_ATTACHMENT, the elements of the slink:VkWriteDescriptorSet::pname:pImageInfo array of slink:VkDescriptorImageInfo structures will be used to update the descriptors, and other arrays will be ignored.
    /// </para>
    /// </summary>
	public enum DescriptorType
	{
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		Sampler = 0,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		CombinedImageSampler = 1,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		SampledImage = 2,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		StorageImage = 3,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		UniformTexelBuffer = 4,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		StorageTexelBuffer = 5,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		UniformBuffer = 6,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		StorageBuffer = 7,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		UniformBufferDynamic = 8,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		StorageBufferDynamic = 9,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		InputAttachment = 10,
	}

    /// <summary>
    /// <para>
    /// Indicate which dynamic state is taken from dynamic state commands.
    /// </para>
    /// </summary>
	public enum DynamicState
	{
	    /// <summary>
		/// <para>
		/// ename:VK_DYNAMIC_STATE_VIEWPORT indicates that the pname:pViewports state in sname:VkPipelineViewportStateCreateInfo will be ignored and must: be set dynamically with flink:vkCmdSetViewport before any draw commands. The number of viewports used by a pipeline is still specified by the pname:viewportCount member of sname:VkPipelineViewportStateCreateInfo.
		/// </para>
		/// </summary>
		Viewport = 0,
	    /// <summary>
		/// <para>
		/// ename:VK_DYNAMIC_STATE_SCISSOR indicates that the pname:pScissors state in sname:VkPipelineViewportStateCreateInfo will be ignored and must: be set dynamically with flink:vkCmdSetScissor before any draw commands. The number of scissor rectangles used by a pipeline is still specified by the pname:scissorCount member of sname:VkPipelineViewportStateCreateInfo.
		/// </para>
		/// </summary>
		Scissor = 1,
	    /// <summary>
		/// <para>
		/// ename:VK_DYNAMIC_STATE_LINE_WIDTH indicates that the pname:lineWidth state in sname:VkPipelineRasterizationStateCreateInfo will be ignored and must: be set dynamically with flink:vkCmdSetLineWidth before any draw commands that generate line primitives for the rasterizer.
		/// </para>
		/// </summary>
		LineWidth = 2,
	    /// <summary>
		/// <para>
		/// ename:VK_DYNAMIC_STATE_DEPTH_BIAS indicates that the pname:depthBiasConstantFactor, pname:depthBiasClamp and pname:depthBiasSlopeFactor states in sname:VkPipelineRasterizationStateCreateInfo will be ignored and must: be set dynamically with flink:vkCmdSetDepthBias before any draws are performed with pname:depthBiasEnable in sname:VkPipelineRasterizationStateCreateInfo set to ename:VK_TRUE.
		/// </para>
		/// </summary>
		DepthBias = 3,
	    /// <summary>
		/// <para>
		/// ename:VK_DYNAMIC_STATE_BLEND_CONSTANTS indicates that the pname:blendConstants state in sname:VkPipelineColorBlendStateCreateInfo will be ignored and must: be set dynamically with flink:vkCmdSetBlendConstants before any draws are performed with a pipeline state with sname:VkPipelineColorBlendAttachmentState member pname:blendEnable set to ename:VK_TRUE and any of the blend functions using a constant blend color.
		/// </para>
		/// </summary>
		BlendConstants = 4,
	    /// <summary>
		/// <para>
		/// ename:VK_DYNAMIC_STATE_DEPTH_BOUNDS indicates that the pname:minDepthBounds and pname:maxDepthBounds states of slink:VkPipelineDepthStencilStateCreateInfo will be ignored and must: be set dynamically with flink:vkCmdSetDepthBounds before any draws are performed with a pipeline state with sname:VkPipelineDepthStencilStateCreateInfo member pname:depthBoundsTestEnable set to ename:VK_TRUE.
		/// </para>
		/// </summary>
		DepthBounds = 5,
	    /// <summary>
		/// <para>
		/// ename:VK_DYNAMIC_STATE_STENCIL_COMPARE_MASK indicates that the pname:compareMask state in sname:VkPipelineDepthStencilStateCreateInfo for both pname:front and pname:back will be ignored and must: be set dynamically with flink:vkCmdSetStencilCompareMask before any draws are performed with a pipeline state with sname:VkPipelineDepthStencilStateCreateInfo member pname:stencilTestEnable set to ename:VK_TRUE
		/// </para>
		/// </summary>
		StencilCompareMask = 6,
	    /// <summary>
		/// <para>
		/// ename:VK_DYNAMIC_STATE_STENCIL_WRITE_MASK indicates that the pname:writeMask state in sname:VkPipelineDepthStencilStateCreateInfo for both pname:front and pname:back will be ignored and must: be set dynamically with flink:vkCmdSetStencilWriteMask before any draws are performed with a pipeline state with sname:VkPipelineDepthStencilStateCreateInfo member pname:stencilTestEnable set to ename:VK_TRUE
		/// </para>
		/// </summary>
		StencilWriteMask = 7,
	    /// <summary>
		/// <para>
		/// ename:VK_DYNAMIC_STATE_STENCIL_REFERENCE indicates that the pname:reference state in sname:VkPipelineDepthStencilStateCreateInfo for both pname:front and pname:back will be ignored and must: be set dynamically with flink:vkCmdSetStencilReference before any draws are performed with a pipeline state with sname:VkPipelineDepthStencilStateCreateInfo member pname:stencilTestEnable set to ename:VK_TRUE
		/// </para>
		/// </summary>
		StencilReference = 8,
	}

    /// <summary>
    /// <para>
    /// Specify filters used for texture lookups.
    /// </para>
    /// </summary>
	public enum Filter
	{
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		Nearest = 0,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		Linear = 1,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		CubicImg = 1000015000,
	}

    /// <summary>
    /// <para>
    /// Available image formats.
    /// </para>
    /// </summary>
	public enum Format
	{
	    /// <summary>
		/// <para>
		/// ename:VK_FORMAT_UNDEFINED::     The format is not specified.
		/// </para>
		/// </summary>
		Undefined = 0,
	    /// <summary>
		/// <para>
		/// ename:VK_FORMAT_R4G4_UNORM_PACK8::     A two-component, 8-bit packed unsigned normalized format that has     a 4-bit R component in bits 4..7, and     a 4-bit G component in bits 0..3.
		/// </para>
		/// </summary>
		R4g4UnormPack8 = 1,
	    /// <summary>
		/// <para>
		/// ename:VK_FORMAT_R4G4B4A4_UNORM_PACK16::     A four-component, 16-bit packed unsigned normalized format that has     a 4-bit R component in bits 12..15,     a 4-bit G component in bits 8..11,     a 4-bit B component in bits 4..7, and     a 4-bit A component in bits 0..3.
		/// </para>
		/// </summary>
		R4g4b4a4UnormPack16 = 2,
	    /// <summary>
		/// <para>
		/// ename:VK_FORMAT_B4G4R4A4_UNORM_PACK16::     A four-component, 16-bit packed unsigned normalized format that has     a 4-bit B component in bits 12..15,     a 4-bit G component in bits 8..11,     a 4-bit R component in bits 4..7, and     a 4-bit A component in bits 0..3.
		/// </para>
		/// </summary>
		B4g4r4a4UnormPack16 = 3,
	    /// <summary>
		/// <para>
		/// ename:VK_FORMAT_R5G6B5_UNORM_PACK16::     A three-component, 16-bit packed unsigned normalized format that has     a 5-bit R component in bits 11..15,     a 6-bit G component in bits 5..10, and     a 5-bit B component in bits 0..4.
		/// </para>
		/// </summary>
		R5g6b5UnormPack16 = 4,
	    /// <summary>
		/// <para>
		/// ename:VK_FORMAT_B5G6R5_UNORM_PACK16::     A three-component, 16-bit packed unsigned normalized format that has     a 5-bit B component in bits 11..15,     a 6-bit G component in bits 5..10, and     a 5-bit R component in bits 0..4.
		/// </para>
		/// </summary>
		B5g6r5UnormPack16 = 5,
	    /// <summary>
		/// <para>
		/// ename:VK_FORMAT_R5G5B5A1_UNORM_PACK16::     A four-component, 16-bit packed unsigned normalized format that has     a 5-bit R component in bits 11..15,     a 5-bit G component in bits 6..10,     a 5-bit B component in bits 1..5, and     a 1-bit A component in bit 0.
		/// </para>
		/// </summary>
		R5g5b5a1UnormPack16 = 6,
	    /// <summary>
		/// <para>
		/// ename:VK_FORMAT_B5G5R5A1_UNORM_PACK16::     A four-component, 16-bit packed unsigned normalized format that has     a 5-bit B component in bits 11..15,     a 5-bit G component in bits 6..10,     a 5-bit R component in bits 1..5, and     a 1-bit A component in bit 0.
		/// </para>
		/// </summary>
		B5g5r5a1UnormPack16 = 7,
	    /// <summary>
		/// <para>
		/// ename:VK_FORMAT_A1R5G5B5_UNORM_PACK16::     A four-component, 16-bit packed unsigned normalized format that has     a 1-bit A component in bit 15,     a 5-bit R component in bits 10..14,     a 5-bit G component in bits 5..9, and     a 5-bit B component in bits 0..4.
		/// </para>
		/// </summary>
		A1r5g5b5UnormPack16 = 8,
	    /// <summary>
		/// <para>
		/// ename:VK_FORMAT_R8_UNORM::     A one-component, 8-bit unsigned normalized format that has     a single 8-bit R component.
		/// </para>
		/// </summary>
		R8Unorm = 9,
	    /// <summary>
		/// <para>
		/// ename:VK_FORMAT_R8_SNORM::     A one-component, 8-bit signed normalized format that has     a single 8-bit R component.
		/// </para>
		/// </summary>
		R8Snorm = 10,
	    /// <summary>
		/// <para>
		/// ename:VK_FORMAT_R8_USCALED::     A one-component, 8-bit unsigned scaled integer format that has     a single 8-bit R component.
		/// </para>
		/// </summary>
		R8Uscaled = 11,
	    /// <summary>
		/// <para>
		/// ename:VK_FORMAT_R8_SSCALED::     A one-component, 8-bit signed scaled integer format that has     a single 8-bit R component.
		/// </para>
		/// </summary>
		R8Sscaled = 12,
	    /// <summary>
		/// <para>
		/// ename:VK_FORMAT_R8_UINT::     A one-component, 8-bit unsigned integer format that has     a single 8-bit R component.
		/// </para>
		/// </summary>
		R8Uint = 13,
	    /// <summary>
		/// <para>
		/// ename:VK_FORMAT_R8_SINT::     A one-component, 8-bit signed integer format that has     a single 8-bit R component.
		/// </para>
		/// </summary>
		R8Sint = 14,
	    /// <summary>
		/// <para>
		/// ename:VK_FORMAT_R8_SRGB::     A one-component, 8-bit unsigned normalized format that has     a single 8-bit R component stored with sRGB nonlinear encoding.
		/// </para>
		/// </summary>
		R8Srgb = 15,
	    /// <summary>
		/// <para>
		/// ename:VK_FORMAT_R8G8_UNORM::     A two-component, 16-bit unsigned normalized format that has     an 8-bit R component in byte 0, and     an 8-bit G component in byte 1.
		/// </para>
		/// </summary>
		R8g8Unorm = 16,
	    /// <summary>
		/// <para>
		/// ename:VK_FORMAT_R8G8_SNORM::     A two-component, 16-bit signed normalized format that has     an 8-bit R component in byte 0, and     an 8-bit G component in byte 1.
		/// </para>
		/// </summary>
		R8g8Snorm = 17,
	    /// <summary>
		/// <para>
		/// ename:VK_FORMAT_R8G8_USCALED::     A two-component, 16-bit unsigned scaled integer format that has     an 8-bit R component in byte 0, and     an 8-bit G component in byte 1.
		/// </para>
		/// </summary>
		R8g8Uscaled = 18,
	    /// <summary>
		/// <para>
		/// ename:VK_FORMAT_R8G8_SSCALED::     A two-component, 16-bit signed scaled integer format that has     an 8-bit R component in byte 0, and     an 8-bit G component in byte 1.
		/// </para>
		/// </summary>
		R8g8Sscaled = 19,
	    /// <summary>
		/// <para>
		/// ename:VK_FORMAT_R8G8_UINT::     A two-component, 16-bit unsigned integer format that has     an 8-bit R component in byte 0, and     an 8-bit G component in byte 1.
		/// </para>
		/// </summary>
		R8g8Uint = 20,
	    /// <summary>
		/// <para>
		/// ename:VK_FORMAT_R8G8_SINT::     A two-component, 16-bit signed integer format that has     an 8-bit R component in byte 0, and     an 8-bit G component in byte 1.
		/// </para>
		/// </summary>
		R8g8Sint = 21,
	    /// <summary>
		/// <para>
		/// ename:VK_FORMAT_R8G8_SRGB::     A two-component, 16-bit unsigned normalized format that has     an 8-bit R component stored with sRGB nonlinear encoding in byte 0, and     an 8-bit G component stored with sRGB nonlinear encoding in byte 1.
		/// </para>
		/// </summary>
		R8g8Srgb = 22,
	    /// <summary>
		/// <para>
		/// ename:VK_FORMAT_R8G8B8_UNORM::     A three-component, 24-bit unsigned normalized format that has     an 8-bit R component in byte 0,     an 8-bit G component in byte 1, and     an 8-bit B component in byte 2.
		/// </para>
		/// </summary>
		R8g8b8Unorm = 23,
	    /// <summary>
		/// <para>
		/// ename:VK_FORMAT_R8G8B8_SNORM::     A three-component, 24-bit signed normalized format that has     an 8-bit R component in byte 0,     an 8-bit G component in byte 1, and     an 8-bit B component in byte 2.
		/// </para>
		/// </summary>
		R8g8b8Snorm = 24,
	    /// <summary>
		/// <para>
		/// ename:VK_FORMAT_R8G8B8_USCALED::     A three-component, 24-bit unsigned scaled format that has     an 8-bit R component in byte 0,     an 8-bit G component in byte 1, and     an 8-bit B component in byte 2.
		/// </para>
		/// </summary>
		R8g8b8Uscaled = 25,
	    /// <summary>
		/// <para>
		/// ename:VK_FORMAT_R8G8B8_SSCALED::     A three-component, 24-bit signed scaled format that has     an 8-bit R component in byte 0,     an 8-bit G component in byte 1, and     an 8-bit B component in byte 2.
		/// </para>
		/// </summary>
		R8g8b8Sscaled = 26,
	    /// <summary>
		/// <para>
		/// ename:VK_FORMAT_R8G8B8_UINT::     A three-component, 24-bit unsigned integer format that has     an 8-bit R component in byte 0,     an 8-bit G component in byte 1, and     an 8-bit B component in byte 2.
		/// </para>
		/// </summary>
		R8g8b8Uint = 27,
	    /// <summary>
		/// <para>
		/// ename:VK_FORMAT_R8G8B8_SINT::     A three-component, 24-bit signed integer format that has     an 8-bit R component in byte 0,     an 8-bit G component in byte 1, and     an 8-bit B component in byte 2.
		/// </para>
		/// </summary>
		R8g8b8Sint = 28,
	    /// <summary>
		/// <para>
		/// ename:VK_FORMAT_R8G8B8_SRGB::     A three-component, 24-bit unsigned normalized format that has     an 8-bit R component stored with sRGB nonlinear encoding in byte 0,     an 8-bit G component stored with sRGB nonlinear encoding in byte 1, and     an 8-bit B component stored with sRGB nonlinear encoding in byte 2.
		/// </para>
		/// </summary>
		R8g8b8Srgb = 29,
	    /// <summary>
		/// <para>
		/// ename:VK_FORMAT_B8G8R8_UNORM::     A three-component, 24-bit unsigned normalized format that has     an 8-bit B component in byte 0,     an 8-bit G component in byte 1, and     an 8-bit R component in byte 2.
		/// </para>
		/// </summary>
		B8g8r8Unorm = 30,
	    /// <summary>
		/// <para>
		/// ename:VK_FORMAT_B8G8R8_SNORM::     A three-component, 24-bit signed normalized format that has     an 8-bit B component in byte 0,     an 8-bit G component in byte 1, and     an 8-bit R component in byte 2.
		/// </para>
		/// </summary>
		B8g8r8Snorm = 31,
	    /// <summary>
		/// <para>
		/// ename:VK_FORMAT_B8G8R8_USCALED::     A three-component, 24-bit unsigned scaled format that has     an 8-bit B component in byte 0,     an 8-bit G component in byte 1, and     an 8-bit R component in byte 2.
		/// </para>
		/// </summary>
		B8g8r8Uscaled = 32,
	    /// <summary>
		/// <para>
		/// ename:VK_FORMAT_B8G8R8_SSCALED::     A three-component, 24-bit signed scaled format that has     an 8-bit B component in byte 0,     an 8-bit G component in byte 1, and     an 8-bit R component in byte 2.
		/// </para>
		/// </summary>
		B8g8r8Sscaled = 33,
	    /// <summary>
		/// <para>
		/// ename:VK_FORMAT_B8G8R8_UINT::     A three-component, 24-bit unsigned integer format that has     an 8-bit B component in byte 0,     an 8-bit G component in byte 1, and     an 8-bit R component in byte 2.
		/// </para>
		/// </summary>
		B8g8r8Uint = 34,
	    /// <summary>
		/// <para>
		/// ename:VK_FORMAT_B8G8R8_SINT::     A three-component, 24-bit signed integer format that has     an 8-bit B component in byte 0,     an 8-bit G component in byte 1, and     an 8-bit R component in byte 2.
		/// </para>
		/// </summary>
		B8g8r8Sint = 35,
	    /// <summary>
		/// <para>
		/// ename:VK_FORMAT_B8G8R8_SRGB::     A three-component, 24-bit unsigned normalized format that has     an 8-bit B component stored with sRGB nonlinear encoding in byte 0,     an 8-bit G component stored with sRGB nonlinear encoding in byte 1, and     an 8-bit R component stored with sRGB nonlinear encoding in byte 2.
		/// </para>
		/// </summary>
		B8g8r8Srgb = 36,
	    /// <summary>
		/// <para>
		/// ename:VK_FORMAT_R8G8B8A8_UNORM::     A four-component, 32-bit unsigned normalized format that has     an 8-bit R component in byte 0,     an 8-bit G component in byte 1,     an 8-bit B component in byte 2, and     an 8-bit A component in byte 3.
		/// </para>
		/// </summary>
		R8g8b8a8Unorm = 37,
	    /// <summary>
		/// <para>
		/// ename:VK_FORMAT_R8G8B8A8_SNORM::     A four-component, 32-bit signed normalized format that has     an 8-bit R component in byte 0,     an 8-bit G component in byte 1,     an 8-bit B component in byte 2, and     an 8-bit A component in byte 3.
		/// </para>
		/// </summary>
		R8g8b8a8Snorm = 38,
	    /// <summary>
		/// <para>
		/// ename:VK_FORMAT_R8G8B8A8_USCALED::     A four-component, 32-bit unsigned scaled format that has     an 8-bit R component in byte 0,     an 8-bit G component in byte 1,     an 8-bit B component in byte 2, and     an 8-bit A component in byte 3.
		/// </para>
		/// </summary>
		R8g8b8a8Uscaled = 39,
	    /// <summary>
		/// <para>
		/// ename:VK_FORMAT_R8G8B8A8_SSCALED::     A four-component, 32-bit signed scaled format that has     an 8-bit R component in byte 0,     an 8-bit G component in byte 1,     an 8-bit B component in byte 2, and     an 8-bit A component in byte 3.
		/// </para>
		/// </summary>
		R8g8b8a8Sscaled = 40,
	    /// <summary>
		/// <para>
		/// ename:VK_FORMAT_R8G8B8A8_UINT::     A four-component, 32-bit unsigned integer format that has     an 8-bit R component in byte 0,     an 8-bit G component in byte 1,     an 8-bit B component in byte 2, and     an 8-bit A component in byte 3.
		/// </para>
		/// </summary>
		R8g8b8a8Uint = 41,
	    /// <summary>
		/// <para>
		/// ename:VK_FORMAT_R8G8B8A8_SINT::     A four-component, 32-bit signed integer format that has     an 8-bit R component in byte 0,     an 8-bit G component in byte 1,     an 8-bit B component in byte 2, and     an 8-bit A component in byte 3.
		/// </para>
		/// </summary>
		R8g8b8a8Sint = 42,
	    /// <summary>
		/// <para>
		/// ename:VK_FORMAT_R8G8B8A8_SRGB::     A four-component, 32-bit unsigned normalized format that has     an 8-bit R component stored with sRGB nonlinear encoding in byte 0,     an 8-bit G component stored with sRGB nonlinear encoding in byte 1,     an 8-bit B component stored with sRGB nonlinear encoding in byte 2, and     an 8-bit A component in byte 3.
		/// </para>
		/// </summary>
		R8g8b8a8Srgb = 43,
	    /// <summary>
		/// <para>
		/// ename:VK_FORMAT_B8G8R8A8_UNORM::     A four-component, 32-bit unsigned normalized format that has     an 8-bit B component in byte 0,     an 8-bit G component in byte 1,     an 8-bit R component in byte 2, and     an 8-bit A component in byte 3.
		/// </para>
		/// </summary>
		B8g8r8a8Unorm = 44,
	    /// <summary>
		/// <para>
		/// ename:VK_FORMAT_B8G8R8A8_SNORM::     A four-component, 32-bit signed normalized format that has     an 8-bit B component in byte 0,     an 8-bit G component in byte 1,     an 8-bit R component in byte 2, and     an 8-bit A component in byte 3.
		/// </para>
		/// </summary>
		B8g8r8a8Snorm = 45,
	    /// <summary>
		/// <para>
		/// ename:VK_FORMAT_B8G8R8A8_USCALED::     A four-component, 32-bit unsigned scaled format that has     an 8-bit B component in byte 0,     an 8-bit G component in byte 1,     an 8-bit R component in byte 2, and     an 8-bit A component in byte 3.
		/// </para>
		/// </summary>
		B8g8r8a8Uscaled = 46,
	    /// <summary>
		/// <para>
		/// ename:VK_FORMAT_B8G8R8A8_SSCALED::     A four-component, 32-bit signed scaled format that has     an 8-bit B component in byte 0,     an 8-bit G component in byte 1,     an 8-bit R component in byte 2, and     an 8-bit A component in byte 3.
		/// </para>
		/// </summary>
		B8g8r8a8Sscaled = 47,
	    /// <summary>
		/// <para>
		/// ename:VK_FORMAT_B8G8R8A8_UINT::     A four-component, 32-bit unsigned integer format that has     an 8-bit B component in byte 0,     an 8-bit G component in byte 1,     an 8-bit R component in byte 2, and     an 8-bit A component in byte 3.
		/// </para>
		/// </summary>
		B8g8r8a8Uint = 48,
	    /// <summary>
		/// <para>
		/// ename:VK_FORMAT_B8G8R8A8_SINT::     A four-component, 32-bit signed integer format that has     an 8-bit B component in byte 0,     an 8-bit G component in byte 1,     an 8-bit R component in byte 2, and     an 8-bit A component in byte 3.
		/// </para>
		/// </summary>
		B8g8r8a8Sint = 49,
	    /// <summary>
		/// <para>
		/// ename:VK_FORMAT_B8G8R8A8_SRGB::     A four-component, 32-bit unsigned normalized format that has     an 8-bit B component stored with sRGB nonlinear encoding in byte 0,     an 8-bit G component stored with sRGB nonlinear encoding in byte 1,     an 8-bit R component stored with sRGB nonlinear encoding in byte 2, and     an 8-bit A component in byte 3.
		/// </para>
		/// </summary>
		B8g8r8a8Srgb = 50,
	    /// <summary>
		/// <para>
		/// ename:VK_FORMAT_A8B8G8R8_UNORM_PACK32::     A four-component, 32-bit packed unsigned normalized format that has     an 8-bit A component in bits 24..31,     an 8-bit B component in bits 16..23,     an 8-bit G component in bits 8..15, and     an 8-bit R component in bits 0..7.
		/// </para>
		/// </summary>
		A8b8g8r8UnormPack32 = 51,
	    /// <summary>
		/// <para>
		/// ename:VK_FORMAT_A8B8G8R8_SNORM_PACK32::     A four-component, 32-bit packed signed normalized format that has     an 8-bit A component in bits 24..31,     an 8-bit B component in bits 16..23,     an 8-bit G component in bits 8..15, and     an 8-bit R component in bits 0..7.
		/// </para>
		/// </summary>
		A8b8g8r8SnormPack32 = 52,
	    /// <summary>
		/// <para>
		/// ename:VK_FORMAT_A8B8G8R8_USCALED_PACK32::     A four-component, 32-bit packed unsigned scaled integer format that has     an 8-bit A component in bits 24..31,     an 8-bit B component in bits 16..23,     an 8-bit G component in bits 8..15, and     an 8-bit R component in bits 0..7.
		/// </para>
		/// </summary>
		A8b8g8r8UscaledPack32 = 53,
	    /// <summary>
		/// <para>
		/// ename:VK_FORMAT_A8B8G8R8_SSCALED_PACK32::     A four-component, 32-bit packed signed scaled integer format that has     an 8-bit A component in bits 24..31,     an 8-bit B component in bits 16..23,     an 8-bit G component in bits 8..15, and     an 8-bit R component in bits 0..7.
		/// </para>
		/// </summary>
		A8b8g8r8SscaledPack32 = 54,
	    /// <summary>
		/// <para>
		/// ename:VK_FORMAT_A8B8G8R8_UINT_PACK32::     A four-component, 32-bit packed unsigned integer format that has     an 8-bit A component in bits 24..31,     an 8-bit B component in bits 16..23,     an 8-bit G component in bits 8..15, and     an 8-bit R component in bits 0..7.
		/// </para>
		/// </summary>
		A8b8g8r8UintPack32 = 55,
	    /// <summary>
		/// <para>
		/// ename:VK_FORMAT_A8B8G8R8_SINT_PACK32::     A four-component, 32-bit packed signed integer format that has     an 8-bit A component in bits 24..31,     an 8-bit B component in bits 16..23,     an 8-bit G component in bits 8..15, and     an 8-bit R component in bits 0..7.
		/// </para>
		/// </summary>
		A8b8g8r8SintPack32 = 56,
	    /// <summary>
		/// <para>
		/// ename:VK_FORMAT_A8B8G8R8_SRGB_PACK32::     A four-component, 32-bit packed unsigned normalized format that has     an 8-bit A component in bits 24..31,     an 8-bit B component stored with sRGB nonlinear encoding in bits 16..23,     an 8-bit G component stored with sRGB nonlinear encoding in bits 8..15, and     an 8-bit R component stored with sRGB nonlinear encoding in bits     0..7.
		/// </para>
		/// </summary>
		A8b8g8r8SrgbPack32 = 57,
	    /// <summary>
		/// <para>
		/// ename:VK_FORMAT_A2R10G10B10_UNORM_PACK32::     A four-component, 32-bit packed unsigned normalized format that has     a 2-bit A component in bits 30..31,     a 10-bit R component in bits 20..29,     a 10-bit G component in bits 10..19, and     a 10-bit B component in bits 0..9.
		/// </para>
		/// </summary>
		A2r10g10b10UnormPack32 = 58,
	    /// <summary>
		/// <para>
		/// ename:VK_FORMAT_A2R10G10B10_SNORM_PACK32::     A four-component, 32-bit packed signed normalized format that has     a 2-bit A component in bits 30..31,     a 10-bit R component in bits 20..29,     a 10-bit G component in bits 10..19, and     a 10-bit B component in bits 0..9.
		/// </para>
		/// </summary>
		A2r10g10b10SnormPack32 = 59,
	    /// <summary>
		/// <para>
		/// ename:VK_FORMAT_A2R10G10B10_USCALED_PACK32::     A four-component, 32-bit packed unsigned scaled integer format that has     a 2-bit A component in bits 30..31,     a 10-bit R component in bits 20..29,     a 10-bit G component in bits 10..19, and     a 10-bit B component in bits 0..9.
		/// </para>
		/// </summary>
		A2r10g10b10UscaledPack32 = 60,
	    /// <summary>
		/// <para>
		/// ename:VK_FORMAT_A2R10G10B10_SSCALED_PACK32::     A four-component, 32-bit packed signed scaled integer format that has     a 2-bit A component in bits 30..31,     a 10-bit R component in bits 20..29,     a 10-bit G component in bits 10..19, and     a 10-bit B component in bits 0..9.
		/// </para>
		/// </summary>
		A2r10g10b10SscaledPack32 = 61,
	    /// <summary>
		/// <para>
		/// ename:VK_FORMAT_A2R10G10B10_UINT_PACK32::     A four-component, 32-bit packed unsigned integer format that has     a 2-bit A component in bits 30..31,     a 10-bit R component in bits 20..29,     a 10-bit G component in bits 10..19, and     a 10-bit B component in bits 0..9.
		/// </para>
		/// </summary>
		A2r10g10b10UintPack32 = 62,
	    /// <summary>
		/// <para>
		/// ename:VK_FORMAT_A2R10G10B10_SINT_PACK32::     A four-component, 32-bit packed signed integer format that has     a 2-bit A component in bits 30..31,     a 10-bit R component in bits 20..29,     a 10-bit G component in bits 10..19, and     a 10-bit B component in bits 0..9.
		/// </para>
		/// </summary>
		A2r10g10b10SintPack32 = 63,
	    /// <summary>
		/// <para>
		/// ename:VK_FORMAT_A2B10G10R10_UNORM_PACK32::     A four-component, 32-bit packed unsigned normalized format that has     a 2-bit A component in bits 30..31,     a 10-bit B component in bits 20..29,     a 10-bit G component in bits 10..19, and     a 10-bit R component in bits 0..9.
		/// </para>
		/// </summary>
		A2b10g10r10UnormPack32 = 64,
	    /// <summary>
		/// <para>
		/// ename:VK_FORMAT_A2B10G10R10_SNORM_PACK32::     A four-component, 32-bit packed signed normalized format that has     a 2-bit A component in bits 30..31,     a 10-bit B component in bits 20..29,     a 10-bit G component in bits 10..19, and     a 10-bit R component in bits 0..9.
		/// </para>
		/// </summary>
		A2b10g10r10SnormPack32 = 65,
	    /// <summary>
		/// <para>
		/// ename:VK_FORMAT_A2B10G10R10_USCALED_PACK32::     A four-component, 32-bit packed unsigned scaled integer format that has     a 2-bit A component in bits 30..31,     a 10-bit B component in bits 20..29,     a 10-bit G component in bits 10..19, and     a 10-bit R component in bits 0..9.
		/// </para>
		/// </summary>
		A2b10g10r10UscaledPack32 = 66,
	    /// <summary>
		/// <para>
		/// ename:VK_FORMAT_A2B10G10R10_SSCALED_PACK32::     A four-component, 32-bit packed signed scaled integer format that has     a 2-bit A component in bits 30..31,     a 10-bit B component in bits 20..29,     a 10-bit G component in bits 10..19, and     a 10-bit R component in bits 0..9.
		/// </para>
		/// </summary>
		A2b10g10r10SscaledPack32 = 67,
	    /// <summary>
		/// <para>
		/// ename:VK_FORMAT_A2B10G10R10_UINT_PACK32::     A four-component, 32-bit packed unsigned integer format that has     a 2-bit A component in bits 30..31,     a 10-bit B component in bits 20..29,     a 10-bit G component in bits 10..19, and     a 10-bit R component in bits 0..9.
		/// </para>
		/// </summary>
		A2b10g10r10UintPack32 = 68,
	    /// <summary>
		/// <para>
		/// ename:VK_FORMAT_A2B10G10R10_SINT_PACK32::     A four-component, 32-bit packed signed integer format that has     a 2-bit A component in bits 30..31,     a 10-bit B component in bits 20..29,     a 10-bit G component in bits 10..19, and     a 10-bit R component in bits 0..9.
		/// </para>
		/// </summary>
		A2b10g10r10SintPack32 = 69,
	    /// <summary>
		/// <para>
		/// ename:VK_FORMAT_R16_UNORM::     A one-component, 16-bit unsigned normalized format that has     a single 16-bit R component.
		/// </para>
		/// </summary>
		R16Unorm = 70,
	    /// <summary>
		/// <para>
		/// ename:VK_FORMAT_R16_SNORM::     A one-component, 16-bit signed normalized format that has     a single 16-bit R component.
		/// </para>
		/// </summary>
		R16Snorm = 71,
	    /// <summary>
		/// <para>
		/// ename:VK_FORMAT_R16_USCALED::     A one-component, 16-bit unsigned scaled integer format that has     a single 16-bit R component.
		/// </para>
		/// </summary>
		R16Uscaled = 72,
	    /// <summary>
		/// <para>
		/// ename:VK_FORMAT_R16_SSCALED::     A one-component, 16-bit signed scaled integer format that has     a single 16-bit R component.
		/// </para>
		/// </summary>
		R16Sscaled = 73,
	    /// <summary>
		/// <para>
		/// ename:VK_FORMAT_R16_UINT::     A one-component, 16-bit unsigned integer format that has     a single 16-bit R component.
		/// </para>
		/// </summary>
		R16Uint = 74,
	    /// <summary>
		/// <para>
		/// ename:VK_FORMAT_R16_SINT::     A one-component, 16-bit signed integer format that has     a single 16-bit R component.
		/// </para>
		/// </summary>
		R16Sint = 75,
	    /// <summary>
		/// <para>
		/// ename:VK_FORMAT_R16_SFLOAT::     A one-component, 16-bit signed floating-point format that has     a single 16-bit R component.
		/// </para>
		/// </summary>
		R16Sfloat = 76,
	    /// <summary>
		/// <para>
		/// ename:VK_FORMAT_R16G16_UNORM::     A two-component, 32-bit unsigned normalized format that has     a 16-bit R component in bytes 0..1, and     a 16-bit G component in bytes 2..3.
		/// </para>
		/// </summary>
		R16g16Unorm = 77,
	    /// <summary>
		/// <para>
		/// ename:VK_FORMAT_R16G16_SNORM::     A two-component, 32-bit signed normalized format that has     a 16-bit R component in bytes 0..1, and     a 16-bit G component in bytes 2..3.
		/// </para>
		/// </summary>
		R16g16Snorm = 78,
	    /// <summary>
		/// <para>
		/// ename:VK_FORMAT_R16G16_USCALED::     A two-component, 32-bit unsigned scaled integer format that has     a 16-bit R component in bytes 0..1, and     a 16-bit G component in bytes 2..3.
		/// </para>
		/// </summary>
		R16g16Uscaled = 79,
	    /// <summary>
		/// <para>
		/// ename:VK_FORMAT_R16G16_SSCALED::     A two-component, 32-bit signed scaled integer format that has     a 16-bit R component in bytes 0..1, and     a 16-bit G component in bytes 2..3.
		/// </para>
		/// </summary>
		R16g16Sscaled = 80,
	    /// <summary>
		/// <para>
		/// ename:VK_FORMAT_R16G16_UINT::     A two-component, 32-bit unsigned integer format that has     a 16-bit R component in bytes 0..1, and     a 16-bit G component in bytes 2..3.
		/// </para>
		/// </summary>
		R16g16Uint = 81,
	    /// <summary>
		/// <para>
		/// ename:VK_FORMAT_R16G16_SINT::     A two-component, 32-bit signed integer format that has     a 16-bit R component in bytes 0..1, and     a 16-bit G component in bytes 2..3.
		/// </para>
		/// </summary>
		R16g16Sint = 82,
	    /// <summary>
		/// <para>
		/// ename:VK_FORMAT_R16G16_SFLOAT::     A two-component, 32-bit signed floating-point format that has     a 16-bit R component in bytes 0..1, and     a 16-bit G component in bytes 2..3.
		/// </para>
		/// </summary>
		R16g16Sfloat = 83,
	    /// <summary>
		/// <para>
		/// ename:VK_FORMAT_R16G16B16_UNORM::     A three-component, 48-bit unsigned normalized format that has     a 16-bit R component in bytes 0..1,     a 16-bit G component in bytes 2..3, and     a 16-bit B component in bytes 4..5.
		/// </para>
		/// </summary>
		R16g16b16Unorm = 84,
	    /// <summary>
		/// <para>
		/// ename:VK_FORMAT_R16G16B16_SNORM::     A three-component, 48-bit signed normalized format that has     a 16-bit R component in bytes 0..1,     a 16-bit G component in bytes 2..3, and     a 16-bit B component in bytes 4..5.
		/// </para>
		/// </summary>
		R16g16b16Snorm = 85,
	    /// <summary>
		/// <para>
		/// ename:VK_FORMAT_R16G16B16_USCALED::     A three-component, 48-bit unsigned scaled integer format that has     a 16-bit R component in bytes 0..1,     a 16-bit G component in bytes 2..3, and     a 16-bit B component in bytes 4..5.
		/// </para>
		/// </summary>
		R16g16b16Uscaled = 86,
	    /// <summary>
		/// <para>
		/// ename:VK_FORMAT_R16G16B16_SSCALED::     A three-component, 48-bit signed scaled integer format that has     a 16-bit R component in bytes 0..1,     a 16-bit G component in bytes 2..3, and     a 16-bit B component in bytes 4..5.
		/// </para>
		/// </summary>
		R16g16b16Sscaled = 87,
	    /// <summary>
		/// <para>
		/// ename:VK_FORMAT_R16G16B16_UINT::     A three-component, 48-bit unsigned integer format that has     a 16-bit R component in bytes 0..1,     a 16-bit G component in bytes 2..3, and     a 16-bit B component in bytes 4..5.
		/// </para>
		/// </summary>
		R16g16b16Uint = 88,
	    /// <summary>
		/// <para>
		/// ename:VK_FORMAT_R16G16B16_SINT::     A three-component, 48-bit signed integer format that has     a 16-bit R component in bytes 0..1,     a 16-bit G component in bytes 2..3, and     a 16-bit B component in bytes 4..5.
		/// </para>
		/// </summary>
		R16g16b16Sint = 89,
	    /// <summary>
		/// <para>
		/// ename:VK_FORMAT_R16G16B16_SFLOAT::     A three-component, 48-bit signed floating-point format that has     a 16-bit R component in bytes 0..1,     a 16-bit G component in bytes 2..3, and     a 16-bit B component in bytes 4..5.
		/// </para>
		/// </summary>
		R16g16b16Sfloat = 90,
	    /// <summary>
		/// <para>
		/// ename:VK_FORMAT_R16G16B16A16_UNORM::     A four-component, 64-bit unsigned normalized format that has     a 16-bit R component in bytes 0..1,     a 16-bit G component in bytes 2..3,     a 16-bit B component in bytes 4..5, and     a 16-bit A component in bytes 6..7.
		/// </para>
		/// </summary>
		R16g16b16a16Unorm = 91,
	    /// <summary>
		/// <para>
		/// ename:VK_FORMAT_R16G16B16A16_SNORM::     A four-component, 64-bit signed normalized format that has     a 16-bit R component in bytes 0..1,     a 16-bit G component in bytes 2..3,     a 16-bit B component in bytes 4..5, and     a 16-bit A component in bytes 6..7.
		/// </para>
		/// </summary>
		R16g16b16a16Snorm = 92,
	    /// <summary>
		/// <para>
		/// ename:VK_FORMAT_R16G16B16A16_USCALED::     A four-component, 64-bit unsigned scaled integer format that has     a 16-bit R component in bytes 0..1,     a 16-bit G component in bytes 2..3,     a 16-bit B component in bytes 4..5, and     a 16-bit A component in bytes 6..7.
		/// </para>
		/// </summary>
		R16g16b16a16Uscaled = 93,
	    /// <summary>
		/// <para>
		/// ename:VK_FORMAT_R16G16B16A16_SSCALED::     A four-component, 64-bit signed scaled integer format that has     a 16-bit R component in bytes 0..1,     a 16-bit G component in bytes 2..3,     a 16-bit B component in bytes 4..5, and     a 16-bit A component in bytes 6..7.
		/// </para>
		/// </summary>
		R16g16b16a16Sscaled = 94,
	    /// <summary>
		/// <para>
		/// ename:VK_FORMAT_R16G16B16A16_UINT::     A four-component, 64-bit unsigned integer format that has     a 16-bit R component in bytes 0..1,     a 16-bit G component in bytes 2..3,     a 16-bit B component in bytes 4..5, and     a 16-bit A component in bytes 6..7.
		/// </para>
		/// </summary>
		R16g16b16a16Uint = 95,
	    /// <summary>
		/// <para>
		/// ename:VK_FORMAT_R16G16B16A16_SINT::     A four-component, 64-bit signed integer format that has     a 16-bit R component in bytes 0..1,     a 16-bit G component in bytes 2..3,     a 16-bit B component in bytes 4..5, and     a 16-bit A component in bytes 6..7.
		/// </para>
		/// </summary>
		R16g16b16a16Sint = 96,
	    /// <summary>
		/// <para>
		/// ename:VK_FORMAT_R16G16B16A16_SFLOAT::     A four-component, 64-bit signed floating-point format that has     a 16-bit R component in bytes 0..1,     a 16-bit G component in bytes 2..3,     a 16-bit B component in bytes 4..5, and     a 16-bit A component in bytes 6..7.
		/// </para>
		/// </summary>
		R16g16b16a16Sfloat = 97,
	    /// <summary>
		/// <para>
		/// ename:VK_FORMAT_R32_UINT::     A one-component, 32-bit unsigned integer format that has     a single 32-bit R component.
		/// </para>
		/// </summary>
		R32Uint = 98,
	    /// <summary>
		/// <para>
		/// ename:VK_FORMAT_R32_SINT::     A one-component, 32-bit signed integer format that has     a single 32-bit R component.
		/// </para>
		/// </summary>
		R32Sint = 99,
	    /// <summary>
		/// <para>
		/// ename:VK_FORMAT_R32_SFLOAT::     A one-component, 32-bit signed floating-point format that has     a single 32-bit R component.
		/// </para>
		/// </summary>
		R32Sfloat = 100,
	    /// <summary>
		/// <para>
		/// ename:VK_FORMAT_R32G32_UINT::     A two-component, 64-bit unsigned integer format that has     a 32-bit R component in bytes 0..3, and     a 32-bit G component in bytes 4..7.
		/// </para>
		/// </summary>
		R32g32Uint = 101,
	    /// <summary>
		/// <para>
		/// ename:VK_FORMAT_R32G32_SINT::     A two-component, 64-bit signed integer format that has     a 32-bit R component in bytes 0..3, and     a 32-bit G component in bytes 4..7.
		/// </para>
		/// </summary>
		R32g32Sint = 102,
	    /// <summary>
		/// <para>
		/// ename:VK_FORMAT_R32G32_SFLOAT::     A two-component, 64-bit signed floating-point format that has     a 32-bit R component in bytes 0..3, and     a 32-bit G component in bytes 4..7.
		/// </para>
		/// </summary>
		R32g32Sfloat = 103,
	    /// <summary>
		/// <para>
		/// ename:VK_FORMAT_R32G32B32_UINT::     A three-component, 96-bit unsigned integer format that has     a 32-bit R component in bytes 0..3,     a 32-bit G component in bytes 4..7, and     a 32-bit B component in bytes 8..11.
		/// </para>
		/// </summary>
		R32g32b32Uint = 104,
	    /// <summary>
		/// <para>
		/// ename:VK_FORMAT_R32G32B32_SINT::     A three-component, 96-bit signed integer format that has     a 32-bit R component in bytes 0..3,     a 32-bit G component in bytes 4..7, and     a 32-bit B component in bytes 8..11.
		/// </para>
		/// </summary>
		R32g32b32Sint = 105,
	    /// <summary>
		/// <para>
		/// ename:VK_FORMAT_R32G32B32_SFLOAT::     A three-component, 96-bit signed floating-point format that has     a 32-bit R component in bytes 0..3,     a 32-bit G component in bytes 4..7, and     a 32-bit B component in bytes 8..11.
		/// </para>
		/// </summary>
		R32g32b32Sfloat = 106,
	    /// <summary>
		/// <para>
		/// ename:VK_FORMAT_R32G32B32A32_UINT::     A four-component, 128-bit unsigned integer format that has     a 32-bit R component in bytes 0..3,     a 32-bit G component in bytes 4..7,     a 32-bit B component in bytes 8..11, and     a 32-bit A component in bytes 12..15.
		/// </para>
		/// </summary>
		R32g32b32a32Uint = 107,
	    /// <summary>
		/// <para>
		/// ename:VK_FORMAT_R32G32B32A32_SINT::     A four-component, 128-bit signed integer format that has     a 32-bit R component in bytes 0..3,     a 32-bit G component in bytes 4..7,     a 32-bit B component in bytes 8..11, and     a 32-bit A component in bytes 12..15.
		/// </para>
		/// </summary>
		R32g32b32a32Sint = 108,
	    /// <summary>
		/// <para>
		/// ename:VK_FORMAT_R32G32B32A32_SFLOAT::     A four-component, 128-bit signed floating-point format that has     a 32-bit R component in bytes 0..3,     a 32-bit G component in bytes 4..7,     a 32-bit B component in bytes 8..11, and     a 32-bit A component in bytes 12..15.
		/// </para>
		/// </summary>
		R32g32b32a32Sfloat = 109,
	    /// <summary>
		/// <para>
		/// ename:VK_FORMAT_R64_UINT::     A one-component, 64-bit unsigned integer format that has     a single 64-bit R component.
		/// </para>
		/// </summary>
		R64Uint = 110,
	    /// <summary>
		/// <para>
		/// ename:VK_FORMAT_R64_SINT::     A one-component, 64-bit signed integer format that has     a single 64-bit R component.
		/// </para>
		/// </summary>
		R64Sint = 111,
	    /// <summary>
		/// <para>
		/// ename:VK_FORMAT_R64_SFLOAT::     A one-component, 64-bit signed floating-point format that has     a single 64-bit R component.
		/// </para>
		/// </summary>
		R64Sfloat = 112,
	    /// <summary>
		/// <para>
		/// ename:VK_FORMAT_R64G64_UINT::     A two-component, 128-bit unsigned integer format that has     a 64-bit R component in bytes 0..7, and     a 64-bit G component in bytes 8..15.
		/// </para>
		/// </summary>
		R64g64Uint = 113,
	    /// <summary>
		/// <para>
		/// ename:VK_FORMAT_R64G64_SINT::     A two-component, 128-bit signed integer format that has     a 64-bit R component in bytes 0..7, and     a 64-bit G component in bytes 8..15.
		/// </para>
		/// </summary>
		R64g64Sint = 114,
	    /// <summary>
		/// <para>
		/// ename:VK_FORMAT_R64G64_SFLOAT::     A two-component, 128-bit signed floating-point format that has     a 64-bit R component in bytes 0..7, and     a 64-bit G component in bytes 8..15.
		/// </para>
		/// </summary>
		R64g64Sfloat = 115,
	    /// <summary>
		/// <para>
		/// ename:VK_FORMAT_R64G64B64_UINT::     A three-component, 192-bit unsigned integer format that has     a 64-bit R component in bytes 0..7,     a 64-bit G component in bytes 8..15, and     a 64-bit B component in bytes 16..23.
		/// </para>
		/// </summary>
		R64g64b64Uint = 116,
	    /// <summary>
		/// <para>
		/// ename:VK_FORMAT_R64G64B64_SINT::     A three-component, 192-bit signed integer format that has     a 64-bit R component in bytes 0..7,     a 64-bit G component in bytes 8..15, and     a 64-bit B component in bytes 16..23.
		/// </para>
		/// </summary>
		R64g64b64Sint = 117,
	    /// <summary>
		/// <para>
		/// ename:VK_FORMAT_R64G64B64_SFLOAT::     A three-component, 192-bit signed floating-point format that has     a 64-bit R component in bytes 0..7,     a 64-bit G component in bytes 8..15, and     a 64-bit B component in bytes 16..23.
		/// </para>
		/// </summary>
		R64g64b64Sfloat = 118,
	    /// <summary>
		/// <para>
		/// ename:VK_FORMAT_R64G64B64A64_UINT::     A four-component, 256-bit unsigned integer format that has     a 64-bit R component in bytes 0..7,     a 64-bit G component in bytes 8..15,     a 64-bit B component in bytes 16..23, and     a 64-bit A component in bytes 24..31.
		/// </para>
		/// </summary>
		R64g64b64a64Uint = 119,
	    /// <summary>
		/// <para>
		/// ename:VK_FORMAT_R64G64B64A64_SINT::     A four-component, 256-bit signed integer format that has     a 64-bit R component in bytes 0..7,     a 64-bit G component in bytes 8..15,     a 64-bit B component in bytes 16..23, and     a 64-bit A component in bytes 24..31.
		/// </para>
		/// </summary>
		R64g64b64a64Sint = 120,
	    /// <summary>
		/// <para>
		/// ename:VK_FORMAT_R64G64B64A64_SFLOAT::     A four-component, 256-bit signed floating-point format that has     a 64-bit R component in bytes 0..7,     a 64-bit G component in bytes 8..15,     a 64-bit B component in bytes 16..23, and     a 64-bit A component in bytes 24..31.
		/// </para>
		/// </summary>
		R64g64b64a64Sfloat = 121,
	    /// <summary>
		/// <para>
		/// ename:VK_FORMAT_B10G11R11_UFLOAT_PACK32::     A three-component, 32-bit packed unsigned floating-point format that has     a 10-bit B component in bits 22..31,     an 11-bit G component in bits 11..21,     an 11-bit R component in bits 0..10.     See &lt;&lt;fundamentals-fp10&gt;&gt; and &lt;&lt;fundamentals-fp11&gt;&gt;.
		/// </para>
		/// </summary>
		B10g11r11UfloatPack32 = 122,
	    /// <summary>
		/// <para>
		/// ename:VK_FORMAT_E5B9G9R9_UFLOAT_PACK32::     A three-component, 32-bit packed unsigned floating-point format that has     a 5-bit shared exponent in bits 27..31,     a 9-bit B component mantissa in bits 18..26,     a 9-bit G component mantissa in bits 9..17, and     a 9-bit R component mantissa in bits 0..8.
		/// </para>
		/// </summary>
		E5b9g9r9UfloatPack32 = 123,
	    /// <summary>
		/// <para>
		/// ename:VK_FORMAT_D16_UNORM::     A one-component, 16-bit unsigned normalized format that has a     single 16-bit depth component.
		/// </para>
		/// </summary>
		D16Unorm = 124,
	    /// <summary>
		/// <para>
		/// ename:VK_FORMAT_X8_D24_UNORM_PACK32::     A two-component, 32-bit format that has 24 unsigned normalized bits in     the depth component and, optionally:, 8 bits that are unused.
		/// </para>
		/// </summary>
		X8D24UnormPack32 = 125,
	    /// <summary>
		/// <para>
		/// ename:VK_FORMAT_D32_SFLOAT::     A one-component, 32-bit signed floating-point format that has 32-bits in     the depth component.
		/// </para>
		/// </summary>
		D32Sfloat = 126,
	    /// <summary>
		/// <para>
		/// ename:VK_FORMAT_S8_UINT::     A one-component, 8-bit unsigned integer format that has 8-bits in the     stencil component.
		/// </para>
		/// </summary>
		S8Uint = 127,
	    /// <summary>
		/// <para>
		/// ename:VK_FORMAT_D16_UNORM_S8_UINT::     A two-component, 24-bit format that has 16 unsigned normalized bits in     the depth component and 8 unsigned integer bits in the stencil     component.
		/// </para>
		/// </summary>
		D16UnormS8Uint = 128,
	    /// <summary>
		/// <para>
		/// ename:VK_FORMAT_D24_UNORM_S8_UINT::     A two-component, 32-bit packed format that has     8 unsigned integer bits in the stencil component, and     24 unsigned normalized bits in the depth component.
		/// </para>
		/// </summary>
		D24UnormS8Uint = 129,
	    /// <summary>
		/// <para>
		/// ename:VK_FORMAT_D32_SFLOAT_S8_UINT::     A two-component format that has 32 signed float bits in the depth     component and 8 unsigned integer bits in the stencil component. There     are optionally: 24-bits that are unused.
		/// </para>
		/// </summary>
		D32SfloatS8Uint = 130,
	    /// <summary>
		/// <para>
		/// ename:VK_FORMAT_BC1_RGB_UNORM_BLOCK::     A three-component, block-compressed format where each 64-bit compressed     texel block encodes a 4x4 rectangle of unsigned normalized RGB texel data.     This format has no alpha and is considered opaque.
		/// </para>
		/// </summary>
		Bc1RgbUnormBlock = 131,
	    /// <summary>
		/// <para>
		/// ename:VK_FORMAT_BC1_RGB_SRGB_BLOCK::     A three-component, block-compressed format where each 64-bit compressed     texel block encodes a 4x4 rectangle of unsigned normalized RGB texel data     with sRGB nonlinear encoding. This format has no alpha and is considered     opaque.
		/// </para>
		/// </summary>
		Bc1RgbSrgbBlock = 132,
	    /// <summary>
		/// <para>
		/// ename:VK_FORMAT_BC1_RGBA_UNORM_BLOCK::     A four-component, block-compressed format where each 64-bit compressed     texel block encodes a 4x4 rectangle of unsigned normalized RGB texel data,     and provides 1 bit of alpha.
		/// </para>
		/// </summary>
		Bc1RgbaUnormBlock = 133,
	    /// <summary>
		/// <para>
		/// ename:VK_FORMAT_BC1_RGBA_SRGB_BLOCK::     A four-component, block-compressed format where each 64-bit compressed     texel block encodes a 4x4 rectangle of unsigned normalized RGB texel data     with sRGB nonlinear encoding, and provides 1 bit of alpha.
		/// </para>
		/// </summary>
		Bc1RgbaSrgbBlock = 134,
	    /// <summary>
		/// <para>
		/// ename:VK_FORMAT_BC2_UNORM_BLOCK::     A four-component, block-compressed format where each 128-bit compressed     texel block encodes a 4x4 rectangle of unsigned normalized RGBA texel data     with the first 64 bits encoding alpha values followed by 64 bits encoding     RGB values.
		/// </para>
		/// </summary>
		Bc2UnormBlock = 135,
	    /// <summary>
		/// <para>
		/// ename:VK_FORMAT_BC2_SRGB_BLOCK::     A four-component, block-compressed format where each 128-bit compressed     texel block encodes a 4x4 rectangle of unsigned normalized RGBA texel data     with the first 64 bits encoding alpha values followed by 64 bits encoding     RGB values with sRGB nonlinear encoding.
		/// </para>
		/// </summary>
		Bc2SrgbBlock = 136,
	    /// <summary>
		/// <para>
		/// ename:VK_FORMAT_BC3_UNORM_BLOCK::     A four-component, block-compressed format where each 128-bit compressed     texel block encodes a 4x4 rectangle of unsigned normalized RGBA texel data     with the first 64 bits encoding alpha values followed by 64 bits encoding     RGB values.
		/// </para>
		/// </summary>
		Bc3UnormBlock = 137,
	    /// <summary>
		/// <para>
		/// ename:VK_FORMAT_BC3_SRGB_BLOCK::     A four-component, block-compressed format where each 128-bit compressed     texel block encodes a 4x4 rectangle of unsigned normalized RGBA texel data     with the first 64 bits encoding alpha values followed by 64 bits encoding     RGB values with sRGB nonlinear encoding.
		/// </para>
		/// </summary>
		Bc3SrgbBlock = 138,
	    /// <summary>
		/// <para>
		/// ename:VK_FORMAT_BC4_UNORM_BLOCK::     A one-component, block-compressed format where each 64-bit compressed     texel block encodes a 4x4 rectangle of unsigned normalized red texel data.
		/// </para>
		/// </summary>
		Bc4UnormBlock = 139,
	    /// <summary>
		/// <para>
		/// ename:VK_FORMAT_BC4_SNORM_BLOCK::     A one-component, block-compressed format where each 64-bit compressed     texel block encodes a 4x4 rectangle of signed normalized red texel data.
		/// </para>
		/// </summary>
		Bc4SnormBlock = 140,
	    /// <summary>
		/// <para>
		/// ename:VK_FORMAT_BC5_UNORM_BLOCK::     A two-component, block-compressed format where each 128-bit compressed     texel block encodes a 4x4 rectangle of unsigned normalized RG texel data     with the first 64 bits encoding red values followed by 64 bits encoding     green values.
		/// </para>
		/// </summary>
		Bc5UnormBlock = 141,
	    /// <summary>
		/// <para>
		/// ename:VK_FORMAT_BC5_SNORM_BLOCK::     A two-component, block-compressed format where each 128-bit compressed     texel block encodes a 4x4 rectangle of signed normalized RG texel data     with the first 64 bits encoding red values followed by 64 bits encoding     green values.
		/// </para>
		/// </summary>
		Bc5SnormBlock = 142,
	    /// <summary>
		/// <para>
		/// ename:VK_FORMAT_BC6H_UFLOAT_BLOCK::     A three-component, block-compressed format where each 128-bit compressed     texel block encodes a 4x4 rectangle of unsigned floating-point RGB texel     data.
		/// </para>
		/// </summary>
		Bc6hUfloatBlock = 143,
	    /// <summary>
		/// <para>
		/// ename:VK_FORMAT_BC6H_SFLOAT_BLOCK::     A three-component, block-compressed format where each 128-bit compressed     texel block encodes a 4x4 rectangle of signed floating-point RGB texel     data.
		/// </para>
		/// </summary>
		Bc6hSfloatBlock = 144,
	    /// <summary>
		/// <para>
		/// ename:VK_FORMAT_BC7_UNORM_BLOCK::     A four-component, block-compressed format where each 128-bit compressed     texel block encodes a 4x4 rectangle of unsigned normalized RGBA texel     data.
		/// </para>
		/// </summary>
		Bc7UnormBlock = 145,
	    /// <summary>
		/// <para>
		/// ename:VK_FORMAT_BC7_SRGB_BLOCK::     A four-component, block-compressed format where each 128-bit compressed     texel block encodes a 4x4 rectangle of unsigned normalized RGBA texel     data with sRGB nonlinear encoding applied to the RGB components.
		/// </para>
		/// </summary>
		Bc7SrgbBlock = 146,
	    /// <summary>
		/// <para>
		/// ename:VK_FORMAT_ETC2_R8G8B8_UNORM_BLOCK::     A three-component, ETC2 compressed format where each 64-bit compressed     texel block encodes a 4x4 rectangle of unsigned normalized RGB texel data.     This format has no alpha and is considered opaque.
		/// </para>
		/// </summary>
		Etc2R8g8b8UnormBlock = 147,
	    /// <summary>
		/// <para>
		/// ename:VK_FORMAT_ETC2_R8G8B8_SRGB_BLOCK::     A three-component, ETC2 compressed format where each 64-bit compressed     texel block encodes a 4x4 rectangle of unsigned normalized RGB texel data     with sRGB nonlinear encoding. This format has no alpha and is considered     opaque.
		/// </para>
		/// </summary>
		Etc2R8g8b8SrgbBlock = 148,
	    /// <summary>
		/// <para>
		/// ename:VK_FORMAT_ETC2_R8G8B8A1_UNORM_BLOCK::     A four-component, ETC2 compressed format where each 64-bit compressed     texel block encodes a 4x4 rectangle of unsigned normalized RGB texel data,     and provides 1 bit of alpha.
		/// </para>
		/// </summary>
		Etc2R8g8b8a1UnormBlock = 149,
	    /// <summary>
		/// <para>
		/// ename:VK_FORMAT_ETC2_R8G8B8A1_SRGB_BLOCK::     A four-component, ETC2 compressed format where each 64-bit compressed     texel block encodes a 4x4 rectangle of unsigned normalized RGB texel data     with sRGB nonlinear encoding, and provides 1 bit of alpha.
		/// </para>
		/// </summary>
		Etc2R8g8b8a1SrgbBlock = 150,
	    /// <summary>
		/// <para>
		/// ename:VK_FORMAT_ETC2_R8G8B8A8_UNORM_BLOCK::     A four-component, ETC2 compressed format where each 128-bit compressed     texel block encodes a 4x4 rectangle of unsigned normalized RGBA texel data     with the first 64 bits encoding alpha values followed by 64 bits encoding     RGB values.
		/// </para>
		/// </summary>
		Etc2R8g8b8a8UnormBlock = 151,
	    /// <summary>
		/// <para>
		/// ename:VK_FORMAT_ETC2_R8G8B8A8_SRGB_BLOCK::     A four-component, ETC2 compressed format where each 64-bit compressed     texel block encodes a 4x4 rectangle of unsigned normalized RGBA texel data     with the first 64 bits encoding alpha values followed by 64 bits encoding     RGB values with sRGB nonlinear encoding applied.
		/// </para>
		/// </summary>
		Etc2R8g8b8a8SrgbBlock = 152,
	    /// <summary>
		/// <para>
		/// ename:VK_FORMAT_EAC_R11_UNORM_BLOCK::     A one-component, ETC2 compressed format where each 64-bit compressed     texel block encodes a 4x4 rectangle of unsigned normalized red texel data.
		/// </para>
		/// </summary>
		EacR11UnormBlock = 153,
	    /// <summary>
		/// <para>
		/// ename:VK_FORMAT_EAC_R11_SNORM_BLOCK::     A one-component, ETC2 compressed format where each 64-bit compressed     texel block encodes a 4x4 rectangle of signed normalized red texel data.
		/// </para>
		/// </summary>
		EacR11SnormBlock = 154,
	    /// <summary>
		/// <para>
		/// ename:VK_FORMAT_EAC_R11G11_UNORM_BLOCK::     A two-component, ETC2 compressed format where each 128-bit compressed     texel block encodes a 4x4 rectangle of unsigned normalized RG texel data     with the first 64 bits encoding red values followed by 64 bits encoding     green values.
		/// </para>
		/// </summary>
		EacR11g11UnormBlock = 155,
	    /// <summary>
		/// <para>
		/// ename:VK_FORMAT_EAC_R11G11_SNORM_BLOCK::     A two-component, ETC2 compressed format where each 128-bit compressed     texel block encodes a 4x4 rectangle of signed normalized RG texel data     with the first 64 bits encoding red values followed by 64 bits encoding     green values.
		/// </para>
		/// </summary>
		EacR11g11SnormBlock = 156,
	    /// <summary>
		/// <para>
		/// ename:VK_FORMAT_ASTC_4x4_UNORM_BLOCK::     A four-component, ASTC compressed format where each 128-bit compressed     texel block encodes a 4x4 rectangle of unsigned normalized RGBA texel data.
		/// </para>
		/// </summary>
		Astc4x4UnormBlock = 157,
	    /// <summary>
		/// <para>
		/// ename:VK_FORMAT_ASTC_4x4_SRGB_BLOCK::     A four-component, ASTC compressed format where each 128-bit compressed     texel block encodes a 4x4 rectangle of unsigned normalized RGBA texel data     with sRGB nonlinear encoding applied to the RGB components.
		/// </para>
		/// </summary>
		Astc4x4SrgbBlock = 158,
	    /// <summary>
		/// <para>
		/// ename:VK_FORMAT_ASTC_5x4_UNORM_BLOCK::     A four-component, ASTC compressed format where each 128-bit compressed     texel block encodes a 5x4 rectangle of unsigned normalized RGBA texel data.
		/// </para>
		/// </summary>
		Astc5x4UnormBlock = 159,
	    /// <summary>
		/// <para>
		/// ename:VK_FORMAT_ASTC_5x4_SRGB_BLOCK::     A four-component, ASTC compressed format where each 128-bit compressed     texel block encodes a 5x4 rectangle of unsigned normalized RGBA texel data     with sRGB nonlinear encoding applied to the RGB components.
		/// </para>
		/// </summary>
		Astc5x4SrgbBlock = 160,
	    /// <summary>
		/// <para>
		/// ename:VK_FORMAT_ASTC_5x5_UNORM_BLOCK::     A four-component, ASTC compressed format where each 128-bit compressed     texel block encodes a 5x5 rectangle of unsigned normalized RGBA texel data.
		/// </para>
		/// </summary>
		Astc5x5UnormBlock = 161,
	    /// <summary>
		/// <para>
		/// ename:VK_FORMAT_ASTC_5x5_SRGB_BLOCK::     A four-component, ASTC compressed format where each 128-bit compressed     texel block encodes a 5x5 rectangle of unsigned normalized RGBA texel data     with sRGB nonlinear encoding applied to the RGB components.
		/// </para>
		/// </summary>
		Astc5x5SrgbBlock = 162,
	    /// <summary>
		/// <para>
		/// ename:VK_FORMAT_ASTC_6x5_UNORM_BLOCK::     A four-component, ASTC compressed format where each 128-bit compressed     texel block encodes a 6x5 rectangle of unsigned normalized RGBA texel data.
		/// </para>
		/// </summary>
		Astc6x5UnormBlock = 163,
	    /// <summary>
		/// <para>
		/// ename:VK_FORMAT_ASTC_6x5_SRGB_BLOCK::     A four-component, ASTC compressed format where each 128-bit compressed     texel block encodes a 6x5 rectangle of unsigned normalized RGBA texel data     with sRGB nonlinear encoding applied to the RGB components.
		/// </para>
		/// </summary>
		Astc6x5SrgbBlock = 164,
	    /// <summary>
		/// <para>
		/// ename:VK_FORMAT_ASTC_6x6_UNORM_BLOCK::     A four-component, ASTC compressed format where each 128-bit compressed     texel block encodes a 6x6 rectangle of unsigned normalized RGBA texel data.
		/// </para>
		/// </summary>
		Astc6x6UnormBlock = 165,
	    /// <summary>
		/// <para>
		/// ename:VK_FORMAT_ASTC_6x6_SRGB_BLOCK::     A four-component, ASTC compressed format where each 128-bit compressed     texel block encodes a 6x6 rectangle of unsigned normalized RGBA texel data     with sRGB nonlinear encoding applied to the RGB components.
		/// </para>
		/// </summary>
		Astc6x6SrgbBlock = 166,
	    /// <summary>
		/// <para>
		/// ename:VK_FORMAT_ASTC_8x5_UNORM_BLOCK::     A four-component, ASTC compressed format where each 128-bit compressed     texel block encodes an 8x5 rectangle of unsigned normalized RGBA texel data.
		/// </para>
		/// </summary>
		Astc8x5UnormBlock = 167,
	    /// <summary>
		/// <para>
		/// ename:VK_FORMAT_ASTC_8x5_SRGB_BLOCK::     A four-component, ASTC compressed format where each 128-bit compressed     texel block encodes an 8x5 rectangle of unsigned normalized RGBA texel data     with sRGB nonlinear encoding applied to the RGB components.
		/// </para>
		/// </summary>
		Astc8x5SrgbBlock = 168,
	    /// <summary>
		/// <para>
		/// ename:VK_FORMAT_ASTC_8x6_UNORM_BLOCK::     A four-component, ASTC compressed format where each 128-bit compressed     texel block encodes an 8x6 rectangle of unsigned normalized RGBA texel data.
		/// </para>
		/// </summary>
		Astc8x6UnormBlock = 169,
	    /// <summary>
		/// <para>
		/// ename:VK_FORMAT_ASTC_8x6_SRGB_BLOCK::     A four-component, ASTC compressed format where each 128-bit compressed     texel block encodes an 8x6 rectangle of unsigned normalized RGBA texel data     with sRGB nonlinear encoding applied to the RGB components.
		/// </para>
		/// </summary>
		Astc8x6SrgbBlock = 170,
	    /// <summary>
		/// <para>
		/// ename:VK_FORMAT_ASTC_8x8_UNORM_BLOCK::     A four-component, ASTC compressed format where each 128-bit compressed     texel block encodes an 8x8 rectangle of unsigned normalized RGBA texel data.
		/// </para>
		/// </summary>
		Astc8x8UnormBlock = 171,
	    /// <summary>
		/// <para>
		/// ename:VK_FORMAT_ASTC_8x8_SRGB_BLOCK::     A four-component, ASTC compressed format where each 128-bit compressed     texel block encodes an 8x8 rectangle of unsigned normalized RGBA texel data     with sRGB nonlinear encoding applied to the RGB components.
		/// </para>
		/// </summary>
		Astc8x8SrgbBlock = 172,
	    /// <summary>
		/// <para>
		/// ename:VK_FORMAT_ASTC_10x5_UNORM_BLOCK::     A four-component, ASTC compressed format where each 128-bit compressed     texel block encodes a 10x5 rectangle of unsigned normalized RGBA texel     data.
		/// </para>
		/// </summary>
		Astc10x5UnormBlock = 173,
	    /// <summary>
		/// <para>
		/// ename:VK_FORMAT_ASTC_10x5_SRGB_BLOCK::     A four-component, ASTC compressed format where each 128-bit compressed     texel block encodes a 10x5 rectangle of unsigned normalized RGBA texel data     with sRGB nonlinear encoding applied to the RGB components.
		/// </para>
		/// </summary>
		Astc10x5SrgbBlock = 174,
	    /// <summary>
		/// <para>
		/// ename:VK_FORMAT_ASTC_10x6_UNORM_BLOCK::     A four-component, ASTC compressed format where each 128-bit compressed     texel block encodes a 10x6 rectangle of unsigned normalized RGBA texel     data.
		/// </para>
		/// </summary>
		Astc10x6UnormBlock = 175,
	    /// <summary>
		/// <para>
		/// ename:VK_FORMAT_ASTC_10x6_SRGB_BLOCK::     A four-component, ASTC compressed format where each 128-bit compressed     texel block encodes a 10x6 rectangle of unsigned normalized RGBA texel data     with sRGB nonlinear encoding applied to the RGB components.
		/// </para>
		/// </summary>
		Astc10x6SrgbBlock = 176,
	    /// <summary>
		/// <para>
		/// ename:VK_FORMAT_ASTC_10x8_UNORM_BLOCK::     A four-component, ASTC compressed format where each 128-bit compressed     texel block encodes a 10x8 rectangle of unsigned normalized RGBA texel     data.
		/// </para>
		/// </summary>
		Astc10x8UnormBlock = 177,
	    /// <summary>
		/// <para>
		/// ename:VK_FORMAT_ASTC_10x8_SRGB_BLOCK::     A four-component, ASTC compressed format where each 128-bit compressed     texel block encodes a 10x8 rectangle of unsigned normalized RGBA texel data     with sRGB nonlinear encoding applied to the RGB components.
		/// </para>
		/// </summary>
		Astc10x8SrgbBlock = 178,
	    /// <summary>
		/// <para>
		/// ename:VK_FORMAT_ASTC_10x10_UNORM_BLOCK::     A four-component, ASTC compressed format where each 128-bit compressed     texel block encodes a 10x10 rectangle of unsigned normalized RGBA texel     data.
		/// </para>
		/// </summary>
		Astc10x10UnormBlock = 179,
	    /// <summary>
		/// <para>
		/// ename:VK_FORMAT_ASTC_10x10_SRGB_BLOCK::     A four-component, ASTC compressed format where each 128-bit compressed     texel block encodes a 10x10 rectangle of unsigned normalized RGBA texel     data with sRGB nonlinear encoding applied to the RGB components.
		/// </para>
		/// </summary>
		Astc10x10SrgbBlock = 180,
	    /// <summary>
		/// <para>
		/// ename:VK_FORMAT_ASTC_12x10_UNORM_BLOCK::     A four-component, ASTC compressed format where each 128-bit compressed     texel block encodes a 12x10 rectangle of unsigned normalized RGBA texel     data.
		/// </para>
		/// </summary>
		Astc12x10UnormBlock = 181,
	    /// <summary>
		/// <para>
		/// ename:VK_FORMAT_ASTC_12x10_SRGB_BLOCK::     A four-component, ASTC compressed format where each 128-bit compressed     texel block encodes a 12x10 rectangle of unsigned normalized RGBA texel     data with sRGB nonlinear encoding applied to the RGB components.
		/// </para>
		/// </summary>
		Astc12x10SrgbBlock = 182,
	    /// <summary>
		/// <para>
		/// ename:VK_FORMAT_ASTC_12x12_UNORM_BLOCK::     A four-component, ASTC compressed format where each 128-bit compressed     texel block encodes a 12x12 rectangle of unsigned normalized RGBA texel     data.
		/// </para>
		/// </summary>
		Astc12x12UnormBlock = 183,
	    /// <summary>
		/// <para>
		/// ename:VK_FORMAT_ASTC_12x12_SRGB_BLOCK::     A four-component, ASTC compressed format where each 128-bit compressed     texel block encodes a 12x12 rectangle of unsigned normalized RGBA texel     data with sRGB nonlinear encoding applied to the RGB components.
		/// </para>
		/// </summary>
		Astc12x12SrgbBlock = 184,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		Pvrtc12bppUnormBlockImg = 1000054000,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		Pvrtc14bppUnormBlockImg = 1000054001,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		Pvrtc22bppUnormBlockImg = 1000054002,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		Pvrtc24bppUnormBlockImg = 1000054003,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		Pvrtc12bppSrgbBlockImg = 1000054004,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		Pvrtc14bppSrgbBlockImg = 1000054005,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		Pvrtc22bppSrgbBlockImg = 1000054006,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		Pvrtc24bppSrgbBlockImg = 1000054007,
	}

    /// <summary>
    /// <para>
    /// Interpret polygon front-facing orientation.
    /// </para>
    /// <para>
    /// The first step of polygon rasterization is to determine whether the triangle is _back-facing_ or _front-facing_. This determination is made based on the sign of the (clipped or unclipped) polygon's area computed in framebuffer coordinates. One way to compute this area is:
    /// </para>
    /// <para>
    /// [latexmath] ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++ \[ a = -{1 \over 2}\sum_{i=0}^{n-1} x_f^i y_f^{i \oplus 1} - x_f^{i \oplus 1} y_f^i \] ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
    /// </para>
    /// <para>
    /// where latexmath:[$x_f^i$] and latexmath:[$y_f^i$] are the latexmath:[$x$] and latexmath:[$y$] framebuffer coordinates of the latexmath:[$i$]th vertex of the latexmath:[$n$]-vertex polygon (vertices are numbered starting at zero for the purposes of this computation) and latexmath:[$i \oplus 1$] is latexmath:[$(i + 1)~ \textrm{mod}~ n$].
    /// </para>
    /// <para>
    /// If pname:frontFace is set to ename:VK_FRONT_FACE_COUNTER_CLOCKWISE, a triangle with positive area is considered front-facing. If it is set to ename:VK_FRONT_FACE_CLOCKWISE, a triangle with negative area is considered front-facing. Any triangle which is not front-facing is back-facing, including zero-area triangles.
    /// </para>
    /// </summary>
	public enum FrontFace
	{
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		CounterClockwise = 0,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		Clockwise = 1,
	}

    /// <summary>
    /// <para>
    /// Layout of image and image subresources.
    /// </para>
    /// <para>
    /// The type(s) of device access supported by each layout are:
    /// </para>
    /// <para>
    /// * ename:VK_IMAGE_LAYOUT_UNDEFINED: Supports no device access. This layout must: only be used as the pname:initialLayout member of sname:VkImageCreateInfo or sname:VkAttachmentDescription, or as the pname:oldLayout in an image transition. When transitioning out of this layout, the contents of the memory are not guaranteed to be preserved. * ename:VK_IMAGE_LAYOUT_PREINITIALIZED: Supports no device access. This layout must: only be used as the pname:initialLayout member of sname:VkImageCreateInfo or sname:VkAttachmentDescription, or as the pname:oldLayout in an image transition. When transitioning out of this layout, the contents of the memory are preserved. This layout is intended to be used as the initial layout for an image whose contents are written by the host, and hence the data can: be written to memory immediately, without first executing a layout transition. Currently, ename:VK_IMAGE_LAYOUT_PREINITIALIZED is only useful with ename:VK_IMAGE_TILING_LINEAR images because there is not a standard layout defined for ename:VK_IMAGE_TILING_OPTIMAL images. * ename:VK_IMAGE_LAYOUT_GENERAL: Supports all types of device access. * ename:VK_IMAGE_LAYOUT_COLOR_ATTACHMENT_OPTIMAL: must: only be used as a color or resolve attachment in a sname:VkFramebuffer. This layout is valid only for image subresources of images created with the ename:VK_IMAGE_USAGE_COLOR_ATTACHMENT_BIT usage bit enabled. * ename:VK_IMAGE_LAYOUT_DEPTH_STENCIL_ATTACHMENT_OPTIMAL: must: only be used as a depth/stencil attachment in a sname:VkFramebuffer. This layout is valid only for image subresources of images created with the ename:VK_IMAGE_USAGE_DEPTH_STENCIL_ATTACHMENT_BIT usage bit enabled. * ename:VK_IMAGE_LAYOUT_DEPTH_STENCIL_READ_ONLY_OPTIMAL: must: only be used as a read-only depth/stencil attachment in a sname:VkFramebuffer and/or as a read-only image in a shader (which can: be read as a sampled image, combined image/sampler and/or input attachment). This layout is valid only for image subresources of images created with the ename:VK_IMAGE_USAGE_DEPTH_STENCIL_ATTACHMENT_BIT usage bit enabled. * ename:VK_IMAGE_LAYOUT_SHADER_READ_ONLY_OPTIMAL: must: only be used as a read-only image in a shader (which can: be read as a sampled image, combined image/sampler and/or input attachment). This layout is valid only for image subresources of images created with the ename:VK_IMAGE_USAGE_SAMPLED_BIT or ename:VK_IMAGE_USAGE_INPUT_ATTACHMENT_BIT usage bit enabled. * ename:VK_IMAGE_LAYOUT_TRANSFER_SRC_OPTIMAL: must: only be used as a source image of a transfer command (see the definition of &lt;&lt;synchronization-transfer,ename:VK_PIPELINE_STAGE_TRANSFER_BIT&gt;&gt;). This layout is valid only for image subresources of images created with the ename:VK_IMAGE_USAGE_TRANSFER_SRC_BIT usage bit enabled. * ename:VK_IMAGE_LAYOUT_TRANSFER_DST_OPTIMAL: must: only be used as a destination image of a transfer command. This layout is valid only for image subresources of images created with the ename:VK_IMAGE_USAGE_TRANSFER_DST_BIT usage bit enabled. ifdef::VK_KHR_swapchain[] include::VK_KHR_swapchain/VkImageLayout_swapchain.txt[] endif::VK_KHR_swapchain[]
    /// </para>
    /// <para>
    /// For each mechanism of accessing an image in the API, there is a parameter or structure member that controls the image layout used to access the image. For transfer commands, this is a parameter to the command (see &lt;&lt;clears&gt;&gt; and &lt;&lt;copies&gt;&gt;). For use as a framebuffer attachment, this is a member in the substructures of the sname:VkRenderPassCreateInfo (see &lt;&lt;renderpass,Render Pass&gt;&gt;). For use in a descriptor set, this is a member in the sname:VkDescriptorImageInfo structure (see &lt;&lt;descriptorsets-updates&gt;&gt;). At the time that any command buffer command accessing an image executes on any queue, the layouts of the image subresources that are accessed must: all match the layout specified via the API controlling those accesses.
    /// </para>
    /// <para>
    /// The image layout of each image subresource must: be well-defined at each point in the image subresource's lifetime. This means that when performing a layout transition on the image subresource, the old layout value must: either equal the current layout of the image subresource (at the time the transition executes), or else be ename:VK_IMAGE_LAYOUT_UNDEFINED (implying that the contents of the image subresource need not be preserved). The new layout used in a transition must: not be ename:VK_IMAGE_LAYOUT_UNDEFINED or ename:VK_IMAGE_LAYOUT_PREINITIALIZED.
    /// </para>
    /// </summary>
	public enum ImageLayout
	{
	    /// <summary>
		/// <para>
		/// Implicit layout an image is when its contents are undefined due to various reasons (e.g. right after creation)
		/// </para>
		/// </summary>
		Undefined = 0,
	    /// <summary>
		/// <para>
		/// General layout when image can be used for any kind of access
		/// </para>
		/// </summary>
		General = 1,
	    /// <summary>
		/// <para>
		/// Optimal layout when image is only used for color attachment read/write
		/// </para>
		/// </summary>
		ColorAttachmentOptimal = 2,
	    /// <summary>
		/// <para>
		/// Optimal layout when image is only used for depth/stencil attachment read/write
		/// </para>
		/// </summary>
		DepthStencilAttachmentOptimal = 3,
	    /// <summary>
		/// <para>
		/// Optimal layout when image is used for read only depth/stencil attachment and shader access
		/// </para>
		/// </summary>
		DepthStencilReadOnlyOptimal = 4,
	    /// <summary>
		/// <para>
		/// Optimal layout when image is used for read only shader access
		/// </para>
		/// </summary>
		ShaderReadOnlyOptimal = 5,
	    /// <summary>
		/// <para>
		/// Optimal layout when image is used only as source of transfer operations
		/// </para>
		/// </summary>
		TransferSourceOptimal = 6,
	    /// <summary>
		/// <para>
		/// Optimal layout when image is used only as destination of transfer operations
		/// </para>
		/// </summary>
		TransferDestinationOptimal = 7,
	    /// <summary>
		/// <para>
		/// Initial layout used when the data is populated by the CPU
		/// </para>
		/// </summary>
		Preinitialized = 8,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		PresentSource = 1000001002,
	}

    /// <summary>
    /// <para>
    /// Specifies the tiling arrangement of data in an image.
    /// </para>
    /// <para>
    /// ename:VK_IMAGE_TILING_OPTIMAL specifies optimal tiling (texels are laid out in an implementation-dependent arrangement, for more optimal memory access), and ename:VK_IMAGE_TILING_LINEAR specifies linear tiling (texels are laid out in memory in row-major order, possibly with some padding on each row).
    /// </para>
    /// </summary>
	public enum ImageTiling
	{
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		Optimal = 0,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		Linear = 1,
	}

    /// <summary>
    /// <para>
    /// Specifies the type of an image object.
    /// </para>
    /// <para>
    /// These values specify one-, two-, or three-dimensional images, respectively.
    /// </para>
    /// </summary>
	public enum ImageType
	{
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		Image1d = 0,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		Image2d = 1,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		Image3d = 2,
	}

    /// <summary>
    /// <para>
    /// Image view types.
    /// </para>
    /// <para>
    /// The exact image view type is partially implicit, based on the image's type and sample count, as well as the view creation parameters as described in the &lt;&lt;resources-image-views-compatibility,table below&gt;&gt;. This table also shows which SPIR-V OpTypeImage Dim and Arrayed parameters correspond to each image view type.
    /// </para>
    /// </summary>
	public enum ImageViewType
	{
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		ImageView1d = 0,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		ImageView2d = 1,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		ImageView3d = 2,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		Cube = 3,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		ImageView1dArray = 4,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		ImageView2dArray = 5,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		CubeArray = 6,
	}

    /// <summary>
    /// <para>
    /// Type of index buffer indices.
    /// </para>
    /// </summary>
	public enum IndexType
	{
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		Uint16 = 0,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		Uint32 = 1,
	}

    /// <summary>
    /// <para>
    /// Allocation type.
    /// </para>
    /// </summary>
	public enum InternalAllocationType
	{
	    /// <summary>
		/// <para>
		/// ename:VK_INTERNAL_ALLOCATION_TYPE_EXECUTABLE - The allocation is intended for execution by the host.
		/// </para>
		/// </summary>
		Executable = 0,
	}

    /// <summary>
    /// <para>
    /// Framebuffer logical operations.
    /// </para>
    /// <para>
    /// &lt;&lt;&lt;
    /// </para>
    /// <para>
    /// The logical operations supported by Vulkan are summarized in the following table in which
    /// </para>
    /// <para>
    /// * latexmath:[$\lnot$] is bitwise invert, * latexmath:[$\land$] is bitwise and, * latexmath:[$\lor$] is bitwise or, * latexmath:[$\oplus$] is bitwise exclusive or, * latexmath:[$s$] is the fragment's latexmath:[$R_{s0}, G_{s0}, B_{s0}$] or latexmath:[$A_{s0}$] component value for the fragment output corresponding to the color attachment being updated, and * latexmath:[$d$] is the color attachment's latexmath:[$R, G, B$] or latexmath:[$A$] component value:
    /// </para>
    /// <para>
    /// .Logical Operations [width="75%",options="header",align="center"] |========================================== |Mode                            | Operation |ename:VK_LOGIC_OP_CLEAR         | latexmath:[$0$] |ename:VK_LOGIC_OP_AND           | latexmath:[$s \land d$] |ename:VK_LOGIC_OP_AND_REVERSE   | latexmath:[$s \land \lnot d$] |ename:VK_LOGIC_OP_COPY          | latexmath:[$s$] |ename:VK_LOGIC_OP_AND_INVERTED  | latexmath:[$\lnot s \land d$] |ename:VK_LOGIC_OP_NO_OP         | latexmath:[$d$] |ename:VK_LOGIC_OP_XOR           | latexmath:[$s \oplus d$] |ename:VK_LOGIC_OP_OR            | latexmath:[$s \lor d$] |ename:VK_LOGIC_OP_NOR           | latexmath:[$\lnot (s \lor d)$] |ename:VK_LOGIC_OP_EQUIVALENT    | latexmath:[$\lnot (s \oplus d)$] |ename:VK_LOGIC_OP_INVERT        | latexmath:[$\lnot d$] |ename:VK_LOGIC_OP_OR_REVERSE    | latexmath:[$s \lor \lnot d$] |ename:VK_LOGIC_OP_COPY_INVERTED | latexmath:[$\lnot s$] |ename:VK_LOGIC_OP_OR_INVERTED   | latexmath:[$\lnot s \lor d$] |ename:VK_LOGIC_OP_NAND          | latexmath:[$\lnot (s \land d)$] |ename:VK_LOGIC_OP_SET           | all 1s |==========================================
    /// </para>
    /// <para>
    /// The result of the logical operation is then written to the color attachment as controlled by the component write mask, described in &lt;&lt;framebuffer-blendoperations,Blend Operations&gt;&gt;.
    /// </para>
    /// </summary>
	public enum LogicOp
	{
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		Clear = 0,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		And = 1,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		AndReverse = 2,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		Copy = 3,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		AndInverted = 4,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		NoOp = 5,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		Xor = 6,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		Or = 7,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		Nor = 8,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		Equivalent = 9,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		Invert = 10,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		OrReverse = 11,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		CopyInverted = 12,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		OrInverted = 13,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		Nand = 14,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		Set = 15,
	}

    /// <summary>
    /// <para>
    /// Supported physical device types.
    /// </para>
    /// <para>
    /// The physical device type is advertised for informational purposes only, and does not directly affect the operation of the system. However, the device type may: correlate with other advertised properties or capabilities of the system, such as how many memory heaps there are.
    /// </para>
    /// </summary>
	public enum PhysicalDeviceType
	{
	    /// <summary>
		/// <para>
		/// ename:VK_PHYSICAL_DEVICE_TYPE_OTHER The device does not match any other available types.
		/// </para>
		/// </summary>
		Other = 0,
	    /// <summary>
		/// <para>
		/// ename:VK_PHYSICAL_DEVICE_TYPE_INTEGRATED_GPU The device is typically one embedded in or tightly coupled with the host.
		/// </para>
		/// </summary>
		IntegratedGpu = 1,
	    /// <summary>
		/// <para>
		/// ename:VK_PHYSICAL_DEVICE_TYPE_DISCRETE_GPU The device is typically a separate processor connected to the host via an interlink.
		/// </para>
		/// </summary>
		DiscreteGpu = 2,
	    /// <summary>
		/// <para>
		/// ename:VK_PHYSICAL_DEVICE_TYPE_VIRTUAL_GPU The device is typically a virtual node in a virtualization environment.
		/// </para>
		/// </summary>
		VirtualGpu = 3,
	    /// <summary>
		/// <para>
		/// ename:VK_PHYSICAL_DEVICE_TYPE_CPU The device is typically running on the same processors as the host.
		/// </para>
		/// </summary>
		Cpu = 4,
	}

    /// <summary>
    /// <para>
    /// Specify the bind point of a pipeline object to a command buffer.
    /// </para>
    /// <para>
    /// Once bound, a pipeline binding affects subsequent graphics or compute commands in the command buffer until a different pipeline is bound to the bind point. The pipeline bound to ename:VK_PIPELINE_BIND_POINT_COMPUTE controls the behavior of flink:vkCmdDispatch and flink:vkCmdDispatchIndirect. The pipeline bound to ename:VK_PIPELINE_BIND_POINT_GRAPHICS controls the behavior of flink:vkCmdDraw, flink:vkCmdDrawIndexed, flink:vkCmdDrawIndirect, and flink:vkCmdDrawIndexedIndirect. No other commands are affected by the pipeline state.
    /// </para>
    /// </summary>
	public enum PipelineBindPoint
	{
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		Graphics = 0,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		Compute = 1,
	}

    /// <summary>
    /// <para>
    /// Encode pipeline cache version.
    /// </para>
    /// <para>
    /// A consumer of the pipeline cache should: use the cache version to interpret the remainder of the cache header.
    /// </para>
    /// </summary>
	public enum PipelineCacheHeaderVersion
	{
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		One = 1,
	}

    /// <summary>
    /// <para>
    /// Control polygon rasterization mode.
    /// </para>
    /// <para>
    /// The pname:polygonMode selects which method of rasterization is used for polygons. If pname:polygonMode is ename:VK_POLYGON_MODE_POINT, then the vertices of polygons are treated, for rasterization purposes, as if they had been drawn as points. ename:VK_POLYGON_MODE_LINE causes polygon edges to be drawn as line segments. ename:VK_POLYGON_MODE_FILL causes polygons to render using the polygon rasterization rules in this section.
    /// </para>
    /// <para>
    /// Note that these modes affect only the final rasterization of polygons: in particular, a polygon's vertices are shaded and the polygon is clipped and possibly culled before these modes are applied.
    /// </para>
    /// </summary>
	public enum PolygonMode
	{
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		Fill = 0,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		Line = 1,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		Point = 2,
	}

    /// <summary>
    /// <para>
    /// Presentation mode supported for a surface.
    /// </para>
    /// <para>
    /// [NOTE] .Note ==== For reference, the mode indicated by ename:VK_PRESENT_MODE_FIFO_KHR is equivalent to the behavior of {wgl|glX|egl}SwapBuffers with a swap interval of 1, while the mode indicated by ename:VK_PRESENT_MODE_FIFO_RELAXED_KHR is equivalent to the behavior of {wgl|glX}SwapBuffers with a swap interval of -1 (from the {WGL|GLX}_EXT_swap_control_tear extensions). ====
    /// </para>
    /// </summary>
	public enum PresentMode
	{
	    /// <summary>
		/// <para>
		/// ename:VK_PRESENT_MODE_IMMEDIATE_KHR: The presentation engine does not wait for a vertical blanking period to update the current image, meaning this mode may: result in visible tearing. No internal queuing of presentation requests is needed, as the requests are applied immediately.
		/// </para>
		/// </summary>
		Immediate = 0,
	    /// <summary>
		/// <para>
		/// ename:VK_PRESENT_MODE_MAILBOX_KHR: The presentation engine waits for the next vertical blanking period to update the current image. Tearing cannot: be observed. An internal single-entry queue is used to hold pending presentation requests. If the queue is full when a new presentation request is received, the new request replaces the existing entry, and any images associated with the prior entry become available for re-use by the application. One request is removed from the queue and processed during each vertical blanking period in which the queue is non-empty.
		/// </para>
		/// </summary>
		Mailbox = 1,
	    /// <summary>
		/// <para>
		/// ename:VK_PRESENT_MODE_FIFO_KHR: The presentation engine waits for the next vertical blanking period to update the current image. Tearing cannot: be observed. An internal queue is used to hold pending presentation requests. New requests are appended to the end of the queue, and one request is removed from the beginning of the queue and processed during each vertical blanking period in which the queue is non-empty. This is the only value of pname:presentMode that is required: to be supported.
		/// </para>
		/// </summary>
		Fifo = 2,
	    /// <summary>
		/// <para>
		/// ename:VK_PRESENT_MODE_FIFO_RELAXED_KHR: The presentation engine generally waits for the next vertical blanking period to update the current image. If a vertical blanking period has already passed since the last update of the current image then the presentation engine does not wait for another vertical blanking period for the update, meaning this mode may: result in visible tearing in this case. This mode is useful for reducing visual stutter with an application that will mostly present a new image before the next vertical blanking period, but may occasionally be late, and present a new image just after the next vertical blanking period. An internal queue is used to hold pending presentation requests. New requests are appended to the end of the queue, and one request is removed from the beginning of the queue and processed during or after each vertical blanking period in which the queue is non-empty.
		/// </para>
		/// </summary>
		FifoRelaxed = 3,
	}

    /// <summary>
    /// <para>
    /// Supported primitive topologies.
    /// </para>
    /// </summary>
	public enum PrimitiveTopology
	{
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		PointList = 0,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		LineList = 1,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		LineStrip = 2,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		TriangleList = 3,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		TriangleStrip = 4,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		TriangleFan = 5,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		LineListWithAdjacency = 6,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		LineStripWithAdjacency = 7,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		TriangleListWithAdjacency = 8,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		TriangleStripWithAdjacency = 9,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		PatchList = 10,
	}

    /// <summary>
    /// <para>
    /// Specify the type of queries managed by a query pool.
    /// </para>
    /// </summary>
	public enum QueryType
	{
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		Occlusion = 0,
	    /// <summary>
		/// <para>
		/// Optional
		/// </para>
		/// </summary>
		PipelineStatistics = 1,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		Timestamp = 2,
	}

    /// <summary>
    /// <para>
    /// -
    /// </para>
    /// </summary>
	public enum RasterizationOrder
	{
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		Strict = 0,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		Relaxed = 1,
	}

    /// <summary>
    /// <para>
    /// Vulkan command return codes.
    /// </para>
    /// <para>
    /// While the core Vulkan API is not designed to capture incorrect usage, some circumstances still require return codes. Commands in Vulkan return their status via return codes that are in one of two categories:
    /// </para>
    /// <para>
    /// * Successful completion codes are returned when a command needs to communicate success or status information. All successful completion codes are non-negative values. * Run time error codes are returned when a command needs to communicate a failure that could only be detected at run time. All run time error codes are negative values.
    /// </para>
    /// <para>
    /// [[fundamentals-successcodes]] .Success codes * ename:VK_SUCCESS Command successfully completed * ename:VK_NOT_READY A fence or query has not yet completed * ename:VK_TIMEOUT A wait operation has not completed in the specified time * ename:VK_EVENT_SET An event is signaled * ename:VK_EVENT_RESET An event is unsignaled * ename:VK_INCOMPLETE A return array was too small for the result ifdef::VK_KHR_swapchain[] include::VK_KHR_swapchain/VkResultSuccessDescriptions_swapchain.txt[] endif::VK_KHR_swapchain[]
    /// </para>
    /// <para>
    /// [[fundamentals-errorcodes]] .Error codes * ename:VK_ERROR_OUT_OF_HOST_MEMORY A host memory allocation has failed. * ename:VK_ERROR_OUT_OF_DEVICE_MEMORY A device memory allocation has failed. * ename:VK_ERROR_INITIALIZATION_FAILED Initialization of an object could not be completed for implementation-specific reasons. * ename:VK_ERROR_DEVICE_LOST The logical or physical device has been lost. See &lt;&lt;devsandqueues-lost-device,Lost Device&gt;&gt; * ename:VK_ERROR_MEMORY_MAP_FAILED Mapping of a memory object has failed. * ename:VK_ERROR_LAYER_NOT_PRESENT A requested layer is not present or could not be loaded. * ename:VK_ERROR_EXTENSION_NOT_PRESENT A requested extension is not supported. * ename:VK_ERROR_FEATURE_NOT_PRESENT A requested feature is not supported. * ename:VK_ERROR_INCOMPATIBLE_DRIVER The requested version of Vulkan is not supported by the driver or is otherwise incompatible for implementation-specific reasons. * ename:VK_ERROR_TOO_MANY_OBJECTS Too many objects of the type have already been created. * ename:VK_ERROR_FORMAT_NOT_SUPPORTED A requested format is not supported on this device. * ename:VK_ERROR_FRAGMENTED_POOL A requested pool allocation has failed due to fragmentation of the pool's memory. ifdef::VK_KHR_surface[] include::VK_KHR_surface/VkResultErrorDescriptions_surface.txt[] endif::VK_KHR_surface[] ifdef::VK_KHR_swapchain[] include::VK_KHR_swapchain/VkResultErrorDescriptions_swapchain.txt[] endif::VK_KHR_swapchain[] ifdef::VK_KHR_display_swapchain[] include::VK_KHR_display_swapchain/VkResultErrorDescriptions_display_swapchain.txt[] endif::VK_KHR_display_swapchain[] ifdef::VK_NV_glsl_shader[] * ename:VK_ERROR_INVALID_SHADER_NV One or more shaders failed to compile or link. More details are reported back to the application via pname:VK_EXT_debug_report if enabled. endif::VK_NV_glsl_shader[]
    /// </para>
    /// <para>
    /// If a command returns a run time error, it will leave any result pointers unmodified, unless other behavior is explicitly defined in the specification.
    /// </para>
    /// <para>
    /// Out of memory errors do not damage any currently existing Vulkan objects. Objects that have already been successfully created can: still be used by the application.
    /// </para>
    /// <para>
    /// Performance-critical commands generally do not have return codes. If a run time error occurs in such commands, the implementation will defer reporting the error until a specified point. For commands that record into command buffers (ftext:vkCmd*) run time errors are reported by fname:vkEndCommandBuffer.
    /// </para>
    /// </summary>
	public enum Result
	{
	    /// <summary>
		/// <para>
		/// Command completed successfully
		/// </para>
		/// </summary>
		Success = 0,
	    /// <summary>
		/// <para>
		/// A fence or query has not yet completed
		/// </para>
		/// </summary>
		NotReady = 1,
	    /// <summary>
		/// <para>
		/// A wait operation has not completed in the specified time
		/// </para>
		/// </summary>
		Timeout = 2,
	    /// <summary>
		/// <para>
		/// An event is signaled
		/// </para>
		/// </summary>
		EventSet = 3,
	    /// <summary>
		/// <para>
		/// An event is unsignaled
		/// </para>
		/// </summary>
		EventReset = 4,
	    /// <summary>
		/// <para>
		/// A return array was too small for the result
		/// </para>
		/// </summary>
		Incomplete = 5,
	    /// <summary>
		/// <para>
		/// A host memory allocation has failed
		/// </para>
		/// </summary>
		ErrorOutOfHostMemory = -1,
	    /// <summary>
		/// <para>
		/// A device memory allocation has failed
		/// </para>
		/// </summary>
		ErrorOutOfDeviceMemory = -2,
	    /// <summary>
		/// <para>
		/// Initialization of a object has failed
		/// </para>
		/// </summary>
		ErrorInitializationFailed = -3,
	    /// <summary>
		/// <para>
		/// The logical device has been lost. See &lt;&lt;devsandqueues-lost-device&gt;&gt;
		/// </para>
		/// </summary>
		ErrorDeviceLost = -4,
	    /// <summary>
		/// <para>
		/// Mapping of a memory object has failed
		/// </para>
		/// </summary>
		ErrorMemoryMapFailed = -5,
	    /// <summary>
		/// <para>
		/// Layer specified does not exist
		/// </para>
		/// </summary>
		ErrorLayerNotPresent = -6,
	    /// <summary>
		/// <para>
		/// Extension specified does not exist
		/// </para>
		/// </summary>
		ErrorExtensionNotPresent = -7,
	    /// <summary>
		/// <para>
		/// Requested feature is not available on this device
		/// </para>
		/// </summary>
		ErrorFeatureNotPresent = -8,
	    /// <summary>
		/// <para>
		/// Unable to find a Vulkan driver
		/// </para>
		/// </summary>
		ErrorIncompatibleDriver = -9,
	    /// <summary>
		/// <para>
		/// Too many objects of the type have already been created
		/// </para>
		/// </summary>
		ErrorTooManyObjects = -10,
	    /// <summary>
		/// <para>
		/// Requested format is not supported on this device
		/// </para>
		/// </summary>
		ErrorFormatNotSupported = -11,
	    /// <summary>
		/// <para>
		/// A requested pool allocation has failed due to fragmentation of the pool's memory
		/// </para>
		/// </summary>
		ErrorFragmentedPool = -12,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		ErrorSurfaceLost = -1000000000,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		ErrorNativeWindowInUse = -1000000001,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		Suboptimal = 1000001003,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		ErrorOutOfDate = -1000001004,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		ErrorIncompatibleDisplay = -1000003001,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		ErrorValidationFailed = -1000011001,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		ErrorInvalidShader = -1000012000,
	}

    /// <summary>
    /// <para>
    /// Specify behavior of sampling with texture coordinates outside an image.
    /// </para>
    /// <para>
    /// These values control the behavior of sampling with coordinates outside the range latexmath:[$[0,1\]$] for the respective u, v, or w coordinate as defined in the &lt;&lt;textures-wrapping-operation, Wrapping Operation&gt;&gt; section.
    /// </para>
    /// <para>
    /// * ename:VK_SAMPLER_ADDRESS_MODE_REPEAT indicates that the repeat wrap mode will be used. * ename:VK_SAMPLER_ADDRESS_MODE_MIRRORED_REPEAT indicates that the mirrored repeat wrap mode will be used. * ename:VK_SAMPLER_ADDRESS_MODE_CLAMP_TO_EDGE indicates that the clamp to edge wrap mode will be used. * ename:VK_SAMPLER_ADDRESS_MODE_CLAMP_TO_BORDER indicates that the clamp to border wrap mode will be used. * ename:VK_SAMPLER_ADDRESS_MODE_MIRROR_CLAMP_TO_EDGE indicates that the mirror clamp to edge wrap mode will be used. This is only valid if the +VK_KHR_mirror_clamp_to_edge+ extension is enabled.
    /// </para>
    /// <para>
    /// The maximum number of sampler objects which can: be simultaneously created on a device is implementation-dependent and specified by the &lt;&lt;features-limits-maxSamplerAllocationCount,pname:maxSamplerAllocationCount&gt;&gt; member of the sname:VkPhysicalDeviceLimits structure. If pname:maxSamplerAllocationCount is exceeded, fname:vkCreateSampler will return ename:VK_ERROR_TOO_MANY_OBJECTS.
    /// </para>
    /// <para>
    /// Since sname:VkSampler is a non-dispatchable handle type, implementations may: return the same handle for sampler state vectors that are identical. In such cases, all such objects would only count once against the pname:maxSamplerAllocationCount limit.
    /// </para>
    /// </summary>
	public enum SamplerAddressMode
	{
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		Repeat = 0,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		MirroredRepeat = 1,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		ClampToEdge = 2,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		ClampToBorder = 3,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		MirrorClampToEdge = 4,
	}

    /// <summary>
    /// <para>
    /// Specify mipmap mode used for texture lookups.
    /// </para>
    /// </summary>
	public enum SamplerMipmapMode
	{
	    /// <summary>
		/// <para>
		/// Choose nearest mip level
		/// </para>
		/// </summary>
		Nearest = 0,
	    /// <summary>
		/// <para>
		/// Linear filter between mip levels
		/// </para>
		/// </summary>
		Linear = 1,
	}

    /// <summary>
    /// <para>
    /// Buffer and image sharing modes.
    /// </para>
    /// <para>
    /// [NOTE] .Note ==== ename:VK_SHARING_MODE_CONCURRENT may: result in lower performance access to the buffer or image than ename:VK_SHARING_MODE_EXCLUSIVE. ====
    /// </para>
    /// <para>
    /// Ranges of buffers and image subresources of image objects created using ename:VK_SHARING_MODE_EXCLUSIVE must: only be accessed by queues in the same queue family at any given time. In order for a different queue family to be able to interpret the memory contents of a range or image subresource, the application must: transfer exclusive ownership of the range or image subresource between the source and destination queue families with the following sequence of operations:
    /// </para>
    /// <para>
    /// 1. Release exclusive ownership from the source queue family to the destination queue family. 2. Use semaphores to ensure proper execution control for the ownership transfer. 3. Acquire exclusive ownership for the destination queue family from the source queue family.
    /// </para>
    /// <para>
    /// To release exclusive ownership of a range of a buffer or image subresource of an image object, the application must: execute a buffer or image memory barrier, respectively (see slink:VkBufferMemoryBarrier and slink:VkImageMemoryBarrier) on a queue from the source queue family. The pname:srcQueueFamilyIndex parameter of the barrier must: be set to the source queue family index, and the pname:dstQueueFamilyIndex parameter to the destination queue family index.
    /// </para>
    /// <para>
    /// To acquire exclusive ownership, the application must: execute the same buffer or image memory barrier on a queue from the destination queue family.
    /// </para>
    /// <para>
    /// Upon creation, resources using ename:VK_SHARING_MODE_EXCLUSIVE are not owned by any queue family. A buffer or image memory barrier is not required to acquire ownership when no queue family owns the resource - it is implicitly acquired upon first use within a queue. However, images still require a &lt;&lt;resources-image-layouts,layout transition&gt;&gt; from ename:VK_IMAGE_LAYOUT_UNDEFINED or ename:VK_IMAGE_LAYOUT_PREINITIALIZED before being used on the first queue. This layout transition can: either be accomplished by an image memory barrier or by use in a render pass instance.
    /// </para>
    /// <para>
    /// Once a queue family has used a range or image subresource of an ename:VK_SHARING_MODE_EXCLUSIVE resource, its contents are undefined to other queue families unless ownership is transferred. The contents may: also become undefined for other reasons, e.g. as a result of writes to an image subresource that aliases the same memory. A queue family can: take ownership of a range or image subresource without an ownership transfer in the same way as for a resource that was just created, however doing so means any contents written by other queue families or via incompatible aliases are undefined.
    /// </para>
    /// </summary>
	public enum SharingMode
	{
	    /// <summary>
		/// <para>
		/// ename:VK_SHARING_MODE_EXCLUSIVE specifies that access to any range or image subresource of the object will be exclusive to a single queue family at a time.
		/// </para>
		/// </summary>
		Exclusive = 0,
	    /// <summary>
		/// <para>
		/// ename:VK_SHARING_MODE_CONCURRENT specifies that concurrent access to any range or image subresource of the object from multiple queue families is supported.
		/// </para>
		/// </summary>
		Concurrent = 1,
	}

    /// <summary>
    /// <para>
    /// Stencil comparison function.
    /// </para>
    /// <para>
    /// The possible values are:
    /// </para>
    /// <para>
    /// * ename:VK_STENCIL_OP_KEEP keeps the current value. * ename:VK_STENCIL_OP_ZERO sets the value to 0. * ename:VK_STENCIL_OP_REPLACE sets the value to pname:reference. * ename:VK_STENCIL_OP_INCREMENT_AND_CLAMP increments the current value and clamps to the maximum representable unsigned value. * ename:VK_STENCIL_OP_DECREMENT_AND_CLAMP decrements the current value and clamps to 0. * ename:VK_STENCIL_OP_INVERT bitwise-inverts the current value. * ename:VK_STENCIL_OP_INCREMENT_AND_WRAP increments the current value and wraps to 0 when the maximum value would have been exceeded. * ename:VK_STENCIL_OP_DECREMENT_AND_WRAP decrements the current value and wraps to the maximum possible value when the value would go below 0.
    /// </para>
    /// <para>
    /// For purposes of increment and decrement, the stencil bits are considered as an unsigned integer.
    /// </para>
    /// <para>
    /// If the stencil test fails, the sample's coverage bit is cleared in the fragment. If there is no stencil framebuffer attachment, stencil modification cannot: occur, and it is as if the stencil tests always pass.
    /// </para>
    /// <para>
    /// If the stencil test passes, the pname:writeMask member of the slink:VkStencilOpState structures controls how the updated stencil value is written to the stencil framebuffer attachment.
    /// </para>
    /// <para>
    /// The least significant latexmath:[$s$] bits of pname:writeMask, where latexmath:[$s$] is the number of bits in the stencil framebuffer attachment, specify an integer mask. Where a latexmath:[$1$] appears in this mask, the corresponding bit in the stencil value in the depth/stencil attachment is written; where a latexmath:[$0$] appears, the bit is not written. The pname:writeMask value uses either the front-facing or back-facing state based on the facing-ness of the fragment. Fragments generated by front-facing primitives use the front mask and fragments generated by back-facing primitives use the back mask.
    /// </para>
    /// </summary>
	public enum StencilOp
	{
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		Keep = 0,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		Zero = 1,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		Replace = 2,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		IncrementAndClamp = 3,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		DecrementAndClamp = 4,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		Invert = 5,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		IncrementAndWrap = 6,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		DecrementAndWrap = 7,
	}

    /// <summary>
    /// <para>
    /// -
    /// </para>
    /// </summary>
	public enum StructureType
	{
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		ApplicationInfo = 0,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		InstanceCreateInfo = 1,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		DeviceQueueCreateInfo = 2,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		DeviceCreateInfo = 3,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		SubmitInfo = 4,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		MemoryAllocateInfo = 5,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		MappedMemoryRange = 6,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		BindSparseInfo = 7,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		FenceCreateInfo = 8,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		SemaphoreCreateInfo = 9,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		EventCreateInfo = 10,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		QueryPoolCreateInfo = 11,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		BufferCreateInfo = 12,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		BufferViewCreateInfo = 13,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		ImageCreateInfo = 14,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		ImageViewCreateInfo = 15,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		ShaderModuleCreateInfo = 16,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		PipelineCacheCreateInfo = 17,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		PipelineShaderStageCreateInfo = 18,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		PipelineVertexInputStateCreateInfo = 19,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		PipelineInputAssemblyStateCreateInfo = 20,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		PipelineTessellationStateCreateInfo = 21,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		PipelineViewportStateCreateInfo = 22,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		PipelineRasterizationStateCreateInfo = 23,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		PipelineMultisampleStateCreateInfo = 24,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		PipelineDepthStencilStateCreateInfo = 25,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		PipelineColorBlendStateCreateInfo = 26,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		PipelineDynamicStateCreateInfo = 27,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		GraphicsPipelineCreateInfo = 28,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		ComputePipelineCreateInfo = 29,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		PipelineLayoutCreateInfo = 30,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		SamplerCreateInfo = 31,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		DescriptorSetLayoutCreateInfo = 32,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		DescriptorPoolCreateInfo = 33,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		DescriptorSetAllocateInfo = 34,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		WriteDescriptorSet = 35,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		CopyDescriptorSet = 36,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		FramebufferCreateInfo = 37,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		RenderPassCreateInfo = 38,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		CommandPoolCreateInfo = 39,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		CommandBufferAllocateInfo = 40,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		CommandBufferInheritanceInfo = 41,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		CommandBufferBeginInfo = 42,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		RenderPassBeginInfo = 43,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		BufferMemoryBarrier = 44,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		ImageMemoryBarrier = 45,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		MemoryBarrier = 46,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		LoaderInstanceCreateInfo = 47,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		LoaderDeviceCreateInfo = 48,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		SwapchainCreateInfo = 1000001000,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		PresentInfo = 1000001001,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		DisplayModeCreateInfo = 1000002000,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		DisplaySurfaceCreateInfo = 1000002001,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		DisplayPresentInfo = 1000003000,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		XlibSurfaceCreateInfo = 1000004000,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		XcbSurfaceCreateInfo = 1000005000,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		WaylandSurfaceCreateInfo = 1000006000,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		MirSurfaceCreateInfo = 1000007000,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		AndroidSurfaceCreateInfo = 1000008000,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		Win32SurfaceCreateInfo = 1000009000,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		DebugReportCallbackCreateInfo = 1000011000,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		PipelineRasterizationStateRasterizationOrder = 1000018000,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		DebugMarkerObjectNameInfo = 1000022000,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		DebugMarkerObjectTagInfo = 1000022001,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		DebugMarkerMarkerInfo = 1000022002,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		DedicatedAllocationImageCreateInfo = 1000026000,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		DedicatedAllocationBufferCreateInfo = 1000026001,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		DedicatedAllocationMemoryAllocateInfo = 1000026002,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		ExternalMemoryImageCreateInfo = 1000056000,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		ExportMemoryAllocateInfo = 1000056001,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		ImportMemoryWin32HandleInfo = 1000057000,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		ExportMemoryWin32HandleInfo = 1000057001,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		Win32KeyedMutexAcquireReleaseInfo = 1000058000,
	}

    /// <summary>
    /// <para>
    /// Specify how commands in the first subpass of a render pass are provided.
    /// </para>
    /// <para>
    /// After beginning a render pass instance, the command buffer is ready to record the commands for the first subpass of that render pass.
    /// </para>
    /// </summary>
	public enum SubpassContents
	{
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		Inline = 0,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		SecondaryCommandBuffers = 1,
	}

    /// <summary>
    /// <para>
    /// Allocation scope.
    /// </para>
    /// <para>
    /// Most Vulkan commands operate on a single object, or there is a sole object that is being created or manipulated. When an allocation uses a scope of ename:VK_SYSTEM_ALLOCATION_SCOPE_OBJECT or ename:VK_SYSTEM_ALLOCATION_SCOPE_CACHE, the allocation is scoped to the object being created or manipulated.
    /// </para>
    /// <para>
    /// When an implementation requires host memory, it will make callbacks to the application using the most specific allocator and scope available:
    /// </para>
    /// <para>
    /// * If an allocation is scoped to the duration of a command, the allocator will use the ename:VK_SYSTEM_ALLOCATION_SCOPE_COMMAND scope. The most specific allocator available is used: if the object being created or manipulated has an allocator, that object's allocator will be used, else if the parent sname:VkDevice has an allocator it will be used, else if the parent sname:VkInstance has an allocator it will be used. Else, * If an allocation is associated with an object of type sname:VkPipelineCache, the allocator will use the ename:VK_SYSTEM_ALLOCATION_SCOPE_CACHE scope. The most specific allocator available is used (pipeline cache, else device, else instance). Else, * If an allocation is scoped to the lifetime of an object, that object is being created or manipulated by the command, and that object's type is not sname:VkDevice or sname:VkInstance, the allocator will use a scope of ename:VK_SYSTEM_ALLOCATION_SCOPE_OBJECT. The most specific allocator available is used (object, else device, else instance). Else, * If an allocation is scoped to the lifetime of a device, the allocator will use scope of ename:VK_SYSTEM_ALLOCATION_SCOPE_DEVICE. The most specific allocator available is used (device, else instance). Else, * If the allocation is scoped to the lifetime of an instance and the instance has an allocator, its allocator will be used with a scope of ename:VK_SYSTEM_ALLOCATION_SCOPE_INSTANCE. * Otherwise an implementation will allocate memory through an alternative mechanism that is unspecified.
    /// </para>
    /// </summary>
	public enum SystemAllocationScope
	{
	    /// <summary>
		/// <para>
		/// ename:VK_SYSTEM_ALLOCATION_SCOPE_COMMAND - The allocation is scoped to the duration of the Vulkan command.
		/// </para>
		/// </summary>
		Command = 0,
	    /// <summary>
		/// <para>
		/// ename:VK_SYSTEM_ALLOCATION_SCOPE_OBJECT - The allocation is scoped to the lifetime of the Vulkan object that is being created or used.
		/// </para>
		/// </summary>
		Object = 1,
	    /// <summary>
		/// <para>
		/// ename:VK_SYSTEM_ALLOCATION_SCOPE_CACHE - The allocation is scoped to the lifetime of a sname:VkPipelineCache object.
		/// </para>
		/// </summary>
		Cache = 2,
	    /// <summary>
		/// <para>
		/// ename:VK_SYSTEM_ALLOCATION_SCOPE_DEVICE - The allocation is scoped to the lifetime of the Vulkan device.
		/// </para>
		/// </summary>
		Device = 3,
	    /// <summary>
		/// <para>
		/// ename:VK_SYSTEM_ALLOCATION_SCOPE_INSTANCE - The allocation is scoped to the lifetime of the Vulkan instance.
		/// </para>
		/// </summary>
		Instance = 4,
	}

    /// <summary>
    /// <para>
    /// Specify rate at which vertex attributes are pulled from buffers.
    /// </para>
    /// </summary>
	public enum VertexInputRate
	{
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		Vertex = 0,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		Instance = 1,
	}
}