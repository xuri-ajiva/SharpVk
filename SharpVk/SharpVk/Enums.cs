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
		/// -
		/// </para>
		/// </summary>
		Undefined = 0,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		R4g4UnormPack8 = 1,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		R4g4b4a4UnormPack16 = 2,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		B4g4r4a4UnormPack16 = 3,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		R5g6b5UnormPack16 = 4,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		B5g6r5UnormPack16 = 5,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		R5g5b5a1UnormPack16 = 6,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		B5g5r5a1UnormPack16 = 7,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		A1r5g5b5UnormPack16 = 8,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		R8Unorm = 9,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		R8Snorm = 10,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		R8Uscaled = 11,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		R8Sscaled = 12,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		R8Uint = 13,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		R8Sint = 14,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		R8Srgb = 15,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		R8g8Unorm = 16,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		R8g8Snorm = 17,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		R8g8Uscaled = 18,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		R8g8Sscaled = 19,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		R8g8Uint = 20,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		R8g8Sint = 21,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		R8g8Srgb = 22,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		R8g8b8Unorm = 23,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		R8g8b8Snorm = 24,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		R8g8b8Uscaled = 25,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		R8g8b8Sscaled = 26,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		R8g8b8Uint = 27,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		R8g8b8Sint = 28,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		R8g8b8Srgb = 29,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		B8g8r8Unorm = 30,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		B8g8r8Snorm = 31,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		B8g8r8Uscaled = 32,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		B8g8r8Sscaled = 33,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		B8g8r8Uint = 34,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		B8g8r8Sint = 35,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		B8g8r8Srgb = 36,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		R8g8b8a8Unorm = 37,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		R8g8b8a8Snorm = 38,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		R8g8b8a8Uscaled = 39,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		R8g8b8a8Sscaled = 40,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		R8g8b8a8Uint = 41,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		R8g8b8a8Sint = 42,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		R8g8b8a8Srgb = 43,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		B8g8r8a8Unorm = 44,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		B8g8r8a8Snorm = 45,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		B8g8r8a8Uscaled = 46,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		B8g8r8a8Sscaled = 47,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		B8g8r8a8Uint = 48,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		B8g8r8a8Sint = 49,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		B8g8r8a8Srgb = 50,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		A8b8g8r8UnormPack32 = 51,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		A8b8g8r8SnormPack32 = 52,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		A8b8g8r8UscaledPack32 = 53,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		A8b8g8r8SscaledPack32 = 54,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		A8b8g8r8UintPack32 = 55,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		A8b8g8r8SintPack32 = 56,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		A8b8g8r8SrgbPack32 = 57,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		A2r10g10b10UnormPack32 = 58,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		A2r10g10b10SnormPack32 = 59,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		A2r10g10b10UscaledPack32 = 60,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		A2r10g10b10SscaledPack32 = 61,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		A2r10g10b10UintPack32 = 62,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		A2r10g10b10SintPack32 = 63,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		A2b10g10r10UnormPack32 = 64,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		A2b10g10r10SnormPack32 = 65,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		A2b10g10r10UscaledPack32 = 66,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		A2b10g10r10SscaledPack32 = 67,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		A2b10g10r10UintPack32 = 68,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		A2b10g10r10SintPack32 = 69,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		R16Unorm = 70,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		R16Snorm = 71,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		R16Uscaled = 72,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		R16Sscaled = 73,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		R16Uint = 74,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		R16Sint = 75,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		R16Sfloat = 76,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		R16g16Unorm = 77,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		R16g16Snorm = 78,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		R16g16Uscaled = 79,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		R16g16Sscaled = 80,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		R16g16Uint = 81,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		R16g16Sint = 82,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		R16g16Sfloat = 83,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		R16g16b16Unorm = 84,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		R16g16b16Snorm = 85,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		R16g16b16Uscaled = 86,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		R16g16b16Sscaled = 87,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		R16g16b16Uint = 88,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		R16g16b16Sint = 89,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		R16g16b16Sfloat = 90,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		R16g16b16a16Unorm = 91,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		R16g16b16a16Snorm = 92,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		R16g16b16a16Uscaled = 93,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		R16g16b16a16Sscaled = 94,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		R16g16b16a16Uint = 95,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		R16g16b16a16Sint = 96,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		R16g16b16a16Sfloat = 97,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		R32Uint = 98,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		R32Sint = 99,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		R32Sfloat = 100,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		R32g32Uint = 101,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		R32g32Sint = 102,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		R32g32Sfloat = 103,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		R32g32b32Uint = 104,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		R32g32b32Sint = 105,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		R32g32b32Sfloat = 106,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		R32g32b32a32Uint = 107,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		R32g32b32a32Sint = 108,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		R32g32b32a32Sfloat = 109,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		R64Uint = 110,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		R64Sint = 111,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		R64Sfloat = 112,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		R64g64Uint = 113,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		R64g64Sint = 114,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		R64g64Sfloat = 115,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		R64g64b64Uint = 116,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		R64g64b64Sint = 117,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		R64g64b64Sfloat = 118,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		R64g64b64a64Uint = 119,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		R64g64b64a64Sint = 120,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		R64g64b64a64Sfloat = 121,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		B10g11r11UfloatPack32 = 122,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		E5b9g9r9UfloatPack32 = 123,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		D16Unorm = 124,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		X8D24UnormPack32 = 125,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		D32Sfloat = 126,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		S8Uint = 127,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		D16UnormS8Uint = 128,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		D24UnormS8Uint = 129,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		D32SfloatS8Uint = 130,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		Bc1RgbUnormBlock = 131,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		Bc1RgbSrgbBlock = 132,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		Bc1RgbaUnormBlock = 133,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		Bc1RgbaSrgbBlock = 134,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		Bc2UnormBlock = 135,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		Bc2SrgbBlock = 136,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		Bc3UnormBlock = 137,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		Bc3SrgbBlock = 138,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		Bc4UnormBlock = 139,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		Bc4SnormBlock = 140,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		Bc5UnormBlock = 141,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		Bc5SnormBlock = 142,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		Bc6hUfloatBlock = 143,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		Bc6hSfloatBlock = 144,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		Bc7UnormBlock = 145,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		Bc7SrgbBlock = 146,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		Etc2R8g8b8UnormBlock = 147,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		Etc2R8g8b8SrgbBlock = 148,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		Etc2R8g8b8a1UnormBlock = 149,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		Etc2R8g8b8a1SrgbBlock = 150,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		Etc2R8g8b8a8UnormBlock = 151,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		Etc2R8g8b8a8SrgbBlock = 152,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		EacR11UnormBlock = 153,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		EacR11SnormBlock = 154,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		EacR11g11UnormBlock = 155,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		EacR11g11SnormBlock = 156,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		Astc4x4UnormBlock = 157,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		Astc4x4SrgbBlock = 158,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		Astc5x4UnormBlock = 159,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		Astc5x4SrgbBlock = 160,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		Astc5x5UnormBlock = 161,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		Astc5x5SrgbBlock = 162,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		Astc6x5UnormBlock = 163,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		Astc6x5SrgbBlock = 164,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		Astc6x6UnormBlock = 165,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		Astc6x6SrgbBlock = 166,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		Astc8x5UnormBlock = 167,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		Astc8x5SrgbBlock = 168,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		Astc8x6UnormBlock = 169,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		Astc8x6SrgbBlock = 170,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		Astc8x8UnormBlock = 171,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		Astc8x8SrgbBlock = 172,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		Astc10x5UnormBlock = 173,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		Astc10x5SrgbBlock = 174,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		Astc10x6UnormBlock = 175,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		Astc10x6SrgbBlock = 176,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		Astc10x8UnormBlock = 177,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		Astc10x8SrgbBlock = 178,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		Astc10x10UnormBlock = 179,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		Astc10x10SrgbBlock = 180,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		Astc12x10UnormBlock = 181,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		Astc12x10SrgbBlock = 182,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		Astc12x12UnormBlock = 183,
	    /// <summary>
		/// <para>
		/// -
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
    /// [latexmath] ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++ \[   a = -{1 \over 2}\sum_{i=0}^{n-1}         x_f^i y_f^{i \oplus 1} -         x_f^{i \oplus 1} y_f^i \] ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
    /// </para>
    /// <para>
    /// where latexmath:[$x_f^i$] and latexmath:[$y_f^i$] are the latexmath:[$x$] and latexmath:[$y$] framebuffer coordinates of the latexmath:[$i$]th vertex of the latexmath:[$n$]-vertex polygon (vertices are numbered starting at zero for the purposes of this computation) and latexmath:[$i \oplus 1$] is latexmath:[$(i + 1)~ \textrm{mod}~ n$].
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
    ///   * Successful completion codes are returned when a command needs to     communicate success or status information. All successful completion     codes are non-negative values.   * Run time error codes are returned when a command needs to communicate a     failure that could only be detected at run time. All run time error     codes are negative values.
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