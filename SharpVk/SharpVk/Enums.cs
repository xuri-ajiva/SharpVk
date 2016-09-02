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
    /// Bitmask specifying classes of memory access the will participate in a memory barrier dependency
    /// </para>
    /// <para>
    /// For more information, see:
    /// </para>
    /// <para>
    /// * The reference page for slink:VkMemoryBarrier, where this interface is defined. * The See Also section for other reference pages using this type. * The Vulkan Specification.
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
		/// Controls coherency of indirect command reads
		/// </para>
		/// </summary>
		IndirectCommandRead = 1 << 0,
	    /// <summary>
		/// <para>
		/// Controls coherency of index reads
		/// </para>
		/// </summary>
		IndexRead = 1 << 1,
	    /// <summary>
		/// <para>
		/// Controls coherency of vertex attribute reads
		/// </para>
		/// </summary>
		VertexAttributeRead = 1 << 2,
	    /// <summary>
		/// <para>
		/// Controls coherency of uniform buffer reads
		/// </para>
		/// </summary>
		UniformRead = 1 << 3,
	    /// <summary>
		/// <para>
		/// Controls coherency of input attachment reads
		/// </para>
		/// </summary>
		InputAttachmentRead = 1 << 4,
	    /// <summary>
		/// <para>
		/// Controls coherency of shader reads
		/// </para>
		/// </summary>
		ShaderRead = 1 << 5,
	    /// <summary>
		/// <para>
		/// Controls coherency of shader writes
		/// </para>
		/// </summary>
		ShaderWrite = 1 << 6,
	    /// <summary>
		/// <para>
		/// Controls coherency of color attachment reads
		/// </para>
		/// </summary>
		ColorAttachmentRead = 1 << 7,
	    /// <summary>
		/// <para>
		/// Controls coherency of color attachment writes
		/// </para>
		/// </summary>
		ColorAttachmentWrite = 1 << 8,
	    /// <summary>
		/// <para>
		/// Controls coherency of depth/stencil attachment reads
		/// </para>
		/// </summary>
		DepthStencilAttachmentRead = 1 << 9,
	    /// <summary>
		/// <para>
		/// Controls coherency of depth/stencil attachment writes
		/// </para>
		/// </summary>
		DepthStencilAttachmentWrite = 1 << 10,
	    /// <summary>
		/// <para>
		/// Controls coherency of transfer reads
		/// </para>
		/// </summary>
		TransferRead = 1 << 11,
	    /// <summary>
		/// <para>
		/// Controls coherency of transfer writes
		/// </para>
		/// </summary>
		TransferWrite = 1 << 12,
	    /// <summary>
		/// <para>
		/// Controls coherency of host reads
		/// </para>
		/// </summary>
		HostRead = 1 << 13,
	    /// <summary>
		/// <para>
		/// Controls coherency of host writes
		/// </para>
		/// </summary>
		HostWrite = 1 << 14,
	    /// <summary>
		/// <para>
		/// Controls coherency of memory reads
		/// </para>
		/// </summary>
		MemoryRead = 1 << 15,
	    /// <summary>
		/// <para>
		/// Controls coherency of memory writes
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
    /// Bitmask specifying additional properties of an attachment
    /// </para>
    /// <para>
    /// For more information, see:
    /// </para>
    /// <para>
    /// * The reference page for slink:VkAttachmentDescription, where this interface is defined. * The See Also section for other reference pages using this type. * The Vulkan Specification.
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
    /// Bitmask specifying additional parameters of a buffer
    /// </para>
    /// <para>
    /// For more information, see:
    /// </para>
    /// <para>
    /// * The reference page for slink:VkBufferCreateInfo, where this interface is defined. * The See Also section for other reference pages using this type. * The Vulkan Specification.
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
    /// Bitmask specifying allowed usage of a buffer
    /// </para>
    /// <para>
    /// For more information, see:
    /// </para>
    /// <para>
    /// * The reference page for slink:VkBufferCreateInfo, where this interface is defined. * The See Also section for other reference pages using this type. * The Vulkan Specification.
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
		/// Can be used as TBO
		/// </para>
		/// </summary>
		UniformTexelBuffer = 1 << 2,
	    /// <summary>
		/// <para>
		/// Can be used as IBO
		/// </para>
		/// </summary>
		StorageTexelBuffer = 1 << 3,
	    /// <summary>
		/// <para>
		/// Can be used as UBO
		/// </para>
		/// </summary>
		UniformBuffer = 1 << 4,
	    /// <summary>
		/// <para>
		/// Can be used as SSBO
		/// </para>
		/// </summary>
		StorageBuffer = 1 << 5,
	    /// <summary>
		/// <para>
		/// Can be used as source of fixed-function index fetch (index buffer)
		/// </para>
		/// </summary>
		IndexBuffer = 1 << 6,
	    /// <summary>
		/// <para>
		/// Can be used as source of fixed-function vertex fetch (VBO)
		/// </para>
		/// </summary>
		VertexBuffer = 1 << 7,
	    /// <summary>
		/// <para>
		/// Can be the source of indirect parameters (e.g. indirect buffer, parameter buffer)
		/// </para>
		/// </summary>
		IndirectBuffer = 1 << 8,
	}

    /// <summary>
    /// <para>
    /// Bitmask of VkBufferViewCreateFlagBits
    /// </para>
    /// <para>
    /// etext:VkBufferViewCreateFlags is a mask of zero or more elink:VkBufferViewCreateFlagBits. It is used as a member and/or parameter of the structures and commands in the See Also section below.
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
    /// Bitmask controlling which components are written to the framebuffer
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
    /// Bitmask controlling behavior of a command buffer reset
    /// </para>
    /// <para>
    /// For more information, see:
    /// </para>
    /// <para>
    /// * The reference page for flink:vkResetCommandBuffer, where this interface is defined. * The See Also section for other reference pages using this type. * The Vulkan Specification.
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
    /// Bitmask specifying usage behavior for command buffer
    /// </para>
    /// <para>
    /// For more information, see:
    /// </para>
    /// <para>
    /// * The reference page for slink:VkCommandBufferBeginInfo, where this interface is defined. * The See Also section for other reference pages using this type. * The Vulkan Specification.
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
    /// Bitmask specifying usage behavior for a command pool
    /// </para>
    /// <para>
    /// For more information, see:
    /// </para>
    /// <para>
    /// * The reference page for slink:VkCommandPoolCreateInfo, where this interface is defined. * The See Also section for other reference pages using this type. * The Vulkan Specification.
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
    /// Bitmask controlling behavior of a command pool reset
    /// </para>
    /// <para>
    /// For more information, see:
    /// </para>
    /// <para>
    /// * The reference page for flink:vkResetCommandPool, where this interface is defined. * The See Also section for other reference pages using this type. * The Vulkan Specification.
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
    /// -
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
    /// Bitmask controlling triangle culling
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
    /// Bitmask specifying dependencies between subpasses
    /// </para>
    /// <para>
    /// For more information, see:
    /// </para>
    /// <para>
    /// * The reference page for slink:VkSubpassDependency, where this interface is defined. * The See Also section for other reference pages using this type. * The Vulkan Specification.
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
    /// Bitmask specifying certain supported operations on a descriptor pool
    /// </para>
    /// <para>
    /// For more information, see:
    /// </para>
    /// <para>
    /// * The reference page for slink:VkDescriptorPoolCreateInfo, where this interface is defined. * The See Also section for other reference pages using this type. * The Vulkan Specification.
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
    /// Bitmask of VkDescriptorPoolResetFlagBits
    /// </para>
    /// <para>
    /// etext:VkDescriptorPoolResetFlags is a mask of zero or more elink:VkDescriptorPoolResetFlagBits. It is used as a member and/or parameter of the structures and commands in the See Also section below.
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
    /// Bitmask of VkDescriptorSetLayoutCreateFlagBits
    /// </para>
    /// <para>
    /// etext:VkDescriptorSetLayoutCreateFlags is a mask of zero or more elink:VkDescriptorSetLayoutCreateFlagBits. It is used as a member and/or parameter of the structures and commands in the See Also section below.
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
    /// Bitmask of VkDeviceCreateFlagBits
    /// </para>
    /// <para>
    /// etext:VkDeviceCreateFlags is a mask of zero or more elink:VkDeviceCreateFlagBits. It is used as a member and/or parameter of the structures and commands in the See Also section below.
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
    /// Bitmask of VkDeviceQueueCreateFlagBits
    /// </para>
    /// <para>
    /// etext:VkDeviceQueueCreateFlags is a mask of zero or more elink:VkDeviceQueueCreateFlagBits. It is used as a member and/or parameter of the structures and commands in the See Also section below.
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
    /// -
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
    /// Bitmask of VkEventCreateFlagBits
    /// </para>
    /// <para>
    /// etext:VkEventCreateFlags is a mask of zero or more elink:VkEventCreateFlagBits. It is used as a member and/or parameter of the structures and commands in the See Also section below.
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
    /// -
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
		/// -
		/// </para>
		/// </summary>
		DedicatedOnlyBit = 0x00000001,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		ExportableBit = 0x00000002,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		ImportableBit = 0x00000004,
	}

    /// <summary>
    /// <para>
    /// -
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
		OpaqueWin32Bit = 0x00000001,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		OpaqueWin32KmtBit = 0x00000002,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		D3d11ImageBit = 0x00000004,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		D3d11ImageKmtBit = 0x00000008,
	}

    /// <summary>
    /// <para>
    /// Bitmask specifying initial state and behavior of a fence
    /// </para>
    /// <para>
    /// For more information, see:
    /// </para>
    /// <para>
    /// * The reference page for slink:VkFenceCreateInfo, where this interface is defined. * The See Also section for other reference pages using this type. * The Vulkan Specification.
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
    /// Bitmask specifying features supported by a buffer
    /// </para>
    /// <para>
    /// For more information, see:
    /// </para>
    /// <para>
    /// * The reference page for slink:VkFormatProperties, where this interface is defined. * The See Also section for other reference pages using this type. * The Vulkan Specification.
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
    /// Bitmask of VkFramebufferCreateFlagBits
    /// </para>
    /// <para>
    /// etext:VkFramebufferCreateFlags is a mask of zero or more elink:VkFramebufferCreateFlagBits. It is used as a member and/or parameter of the structures and commands in the See Also section below.
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
    /// Bitmask specifying which aspects of an image are included in a view
    /// </para>
    /// <para>
    /// For more information, see:
    /// </para>
    /// <para>
    /// * The reference page for slink:VkImageSubresourceRange, where this interface is defined. * The See Also section for other reference pages using this type. * The Vulkan Specification.
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
    /// Bitmask specifying additional parameters of an image
    /// </para>
    /// <para>
    /// These bits have the following meanings:
    /// </para>
    /// <para>
    /// * ename:VK_IMAGE_CREATE_SPARSE_BINDING_BIT indicates that the image will be backed using sparse memory binding. * ename:VK_IMAGE_CREATE_SPARSE_RESIDENCY_BIT indicates that the image can: be partially backed using sparse memory binding. Images created with this flag must: also be created with the ename:VK_IMAGE_CREATE_SPARSE_BINDING_BIT flag. * ename:VK_IMAGE_CREATE_SPARSE_ALIASED_BIT indicates that the image will be backed using sparse memory binding with memory ranges that might also simultaneously be backing another image (or another portion of the same image). Images created with this flag must: also be created with the ename:VK_IMAGE_CREATE_SPARSE_BINDING_BIT flag * ename:VK_IMAGE_CREATE_MUTABLE_FORMAT_BIT indicates that the image can: be used to create a sname:VkImageView with a different format from the image. * ename:VK_IMAGE_CREATE_CUBE_COMPATIBLE_BIT indicates that the image can: be used to create a sname:VkImageView of type ename:VK_IMAGE_VIEW_TYPE_CUBE or ename:VK_IMAGE_VIEW_TYPE_CUBE_ARRAY.
    /// </para>
    /// <para>
    /// If any of the bits ename:VK_IMAGE_CREATE_SPARSE_BINDING_BIT, ename:VK_IMAGE_CREATE_SPARSE_RESIDENCY_BIT, or ename:VK_IMAGE_CREATE_SPARSE_ALIASED_BIT are set, ename:VK_IMAGE_USAGE_TRANSIENT_ATTACHMENT_BIT mustnot: also be set.
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
    /// Bitmask specifying intended usage of an image
    /// </para>
    /// <para>
    /// These bits have the following meanings:
    /// </para>
    /// <para>
    /// * ename:VK_IMAGE_USAGE_TRANSFER_SRC_BIT indicates that the image can: be used as the source of a transfer command. * ename:VK_IMAGE_USAGE_TRANSFER_DST_BIT indicates that the image can: be used as the destination of a transfer command. * ename:VK_IMAGE_USAGE_SAMPLED_BIT indicates that the image can: be used to create a sname:VkImageView suitable for occupying a sname:VkDescriptorSet slot either of type ename:VK_DESCRIPTOR_TYPE_SAMPLED_IMAGE or ename:VK_DESCRIPTOR_TYPE_COMBINED_IMAGE_SAMPLER, and be sampled by a shader. * ename:VK_IMAGE_USAGE_STORAGE_BIT indicates that the image can: be used to create a sname:VkImageView suitable for occupying a sname:VkDescriptorSet slot of type ename:VK_DESCRIPTOR_TYPE_STORAGE_IMAGE. * ename:VK_IMAGE_USAGE_COLOR_ATTACHMENT_BIT indicates that the image can: be used to create a sname:VkImageView suitable for use as a color or resolve attachment in a sname:VkFramebuffer. * ename:VK_IMAGE_USAGE_DEPTH_STENCIL_ATTACHMENT_BIT indicates that the image can: be used to create a sname:VkImageView suitable for use as a depth/stencil attachment in a sname:VkFramebuffer. * ename:VK_IMAGE_USAGE_TRANSIENT_ATTACHMENT_BIT indicates that the memory bound to this image will have been allocated with the ename:VK_MEMORY_PROPERTY_LAZILY_ALLOCATED_BIT (see &lt;&lt;memory&gt;&gt; for more detail). If this is set, then bits other than ename:VK_IMAGE_USAGE_COLOR_ATTACHMENT_BIT, ename:VK_IMAGE_USAGE_DEPTH_STENCIL_ATTACHMENT_BIT, and ename:VK_IMAGE_USAGE_INPUT_ATTACHMENT_BIT mustnot: be set. * ename:VK_IMAGE_USAGE_INPUT_ATTACHMENT_BIT indicates that the image can: be used to create a sname:VkImageView suitable for occupying sname:VkDescriptorSet slot of type ename:VK_DESCRIPTOR_TYPE_INPUT_ATTACHMENT; be read from a shader as an input attachment; and be used as an input attachment in a framebuffer.
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
    /// Bitmask of VkImageViewCreateFlagBits
    /// </para>
    /// <para>
    /// etext:VkImageViewCreateFlags is a mask of zero or more elink:VkImageViewCreateFlagBits. It is used as a member and/or parameter of the structures and commands in the See Also section below.
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
    /// Bitmask of VkInstanceCreateFlagBits
    /// </para>
    /// <para>
    /// etext:VkInstanceCreateFlags is a mask of zero or more elink:VkInstanceCreateFlagBits. It is used as a member and/or parameter of the structures and commands in the See Also section below.
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
    /// Bitmask specifying attribute flags for a heap
    /// </para>
    /// <para>
    /// For more information, see:
    /// </para>
    /// <para>
    /// * The reference page for slink:VkMemoryHeap, where this interface is defined. * The See Also section for other reference pages using this type. * The Vulkan Specification.
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
    /// Bitmask of VkMemoryMapFlagBits
    /// </para>
    /// <para>
    /// etext:VkMemoryMapFlags is a mask of zero or more elink:VkMemoryMapFlagBits. It is used as a member and/or parameter of the structures and commands in the See Also section below.
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
    /// Bitmask specifying properties for a memory type
    /// </para>
    /// <para>
    /// For more information, see:
    /// </para>
    /// <para>
    /// * The reference page for slink:VkMemoryType, where this interface is defined. * The See Also section for other reference pages using this type. * The Vulkan Specification.
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
    /// Bitmask of VkPipelineCacheCreateFlagBits
    /// </para>
    /// <para>
    /// etext:VkPipelineCacheCreateFlags is a mask of zero or more elink:VkPipelineCacheCreateFlagBits. It is used as a member and/or parameter of the structures and commands in the See Also section below.
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
    /// Bitmask of VkPipelineColorBlendStateCreateFlagBits
    /// </para>
    /// <para>
    /// etext:VkPipelineColorBlendStateCreateFlags is a mask of zero or more elink:VkPipelineColorBlendStateCreateFlagBits. It is used as a member and/or parameter of the structures and commands in the See Also section below.
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
    /// Bitmask controlling how a pipeline is generated
    /// </para>
    /// <para>
    /// For more information, see:
    /// </para>
    /// <para>
    /// * The reference page for slink:VkGraphicsPipelineCreateInfo, where this interface is defined. * The See Also section for other reference pages using this type. * The Vulkan Specification.
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
		/// -
		/// </para>
		/// </summary>
		DisableOptimization = 1 << 0,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		AllowDerivatives = 1 << 1,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		Derivative = 1 << 2,
	}

    /// <summary>
    /// <para>
    /// Bitmask of VkPipelineDepthStencilStateCreateFlagBits
    /// </para>
    /// <para>
    /// etext:VkPipelineDepthStencilStateCreateFlags is a mask of zero or more elink:VkPipelineDepthStencilStateCreateFlagBits. It is used as a member and/or parameter of the structures and commands in the See Also section below.
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
    /// Bitmask of VkPipelineDynamicStateCreateFlagBits
    /// </para>
    /// <para>
    /// etext:VkPipelineDynamicStateCreateFlags is a mask of zero or more elink:VkPipelineDynamicStateCreateFlagBits. It is used as a member and/or parameter of the structures and commands in the See Also section below.
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
    /// Bitmask of VkPipelineInputAssemblyStateCreateFlagBits
    /// </para>
    /// <para>
    /// etext:VkPipelineInputAssemblyStateCreateFlags is a mask of zero or more elink:VkPipelineInputAssemblyStateCreateFlagBits. It is used as a member and/or parameter of the structures and commands in the See Also section below.
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
    /// Bitmask of VkPipelineLayoutCreateFlagBits
    /// </para>
    /// <para>
    /// etext:VkPipelineLayoutCreateFlags is a mask of zero or more elink:VkPipelineLayoutCreateFlagBits. It is used as a member and/or parameter of the structures and commands in the See Also section below.
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
    /// Bitmask of VkPipelineMultisampleStateCreateFlagBits
    /// </para>
    /// <para>
    /// etext:VkPipelineMultisampleStateCreateFlags is a mask of zero or more elink:VkPipelineMultisampleStateCreateFlagBits. It is used as a member and/or parameter of the structures and commands in the See Also section below.
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
    /// Bitmask of VkPipelineRasterizationStateCreateFlagBits
    /// </para>
    /// <para>
    /// etext:VkPipelineRasterizationStateCreateFlags is a mask of zero or more elink:VkPipelineRasterizationStateCreateFlagBits. It is used as a member and/or parameter of the structures and commands in the See Also section below.
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
    /// Bitmask of VkPipelineShaderStageCreateFlagBits
    /// </para>
    /// <para>
    /// etext:VkPipelineShaderStageCreateFlags is a mask of zero or more elink:VkPipelineShaderStageCreateFlagBits. It is used as a member and/or parameter of the structures and commands in the See Also section below.
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
    /// Bitmask specifying pipeline stages
    /// </para>
    /// <para>
    /// The meaning of each bit is:
    /// </para>
    /// <para>
    /// * ename:VK_PIPELINE_STAGE_TOP_OF_PIPE_BIT: Stage of the pipeline where commands are initially received by the queue. * ename:VK_PIPELINE_STAGE_DRAW_INDIRECT_BIT: Stage of the pipeline where Draw/DispatchIndirect data structures are consumed. * ename:VK_PIPELINE_STAGE_VERTEX_INPUT_BIT: Stage of the pipeline where vertex and index buffers are consumed. * ename:VK_PIPELINE_STAGE_VERTEX_SHADER_BIT: Vertex shader stage. * ename:VK_PIPELINE_STAGE_TESSELLATION_CONTROL_SHADER_BIT: Tessellation control shader stage. * ename:VK_PIPELINE_STAGE_TESSELLATION_EVALUATION_SHADER_BIT: Tessellation evaluation shader stage. * ename:VK_PIPELINE_STAGE_GEOMETRY_SHADER_BIT: Geometry shader stage. * ename:VK_PIPELINE_STAGE_FRAGMENT_SHADER_BIT: Fragment shader stage. * ename:VK_PIPELINE_STAGE_EARLY_FRAGMENT_TESTS_BIT: Stage of the pipeline where early fragment tests (depth and stencil tests before fragment shading) are performed. * ename:VK_PIPELINE_STAGE_LATE_FRAGMENT_TESTS_BIT: Stage of the pipeline where late fragment tests (depth and stencil tests after fragment shading) are performed. * ename:VK_PIPELINE_STAGE_COLOR_ATTACHMENT_OUTPUT_BIT: Stage of the pipeline after blending where the final color values are output from the pipeline. This stage also includes resolve operations that occur at the end of a subpass. Note that this does not necessarily indicate that the values have been committed to memory. * ename:VK_PIPELINE_STAGE_TRANSFER_BIT: Execution of copy commands. This includes the operations resulting from all transfer commands. The set of transfer commands comprises fname:vkCmdCopyBuffer, fname:vkCmdCopyImage, fname:vkCmdBlitImage, fname:vkCmdCopyBufferToImage, fname:vkCmdCopyImageToBuffer, fname:vkCmdUpdateBuffer, fname:vkCmdFillBuffer, fname:vkCmdClearColorImage, fname:vkCmdClearDepthStencilImage, fname:vkCmdResolveImage, and fname:vkCmdCopyQueryPoolResults. * ename:VK_PIPELINE_STAGE_COMPUTE_SHADER_BIT: Execution of a compute shader. * ename:VK_PIPELINE_STAGE_BOTTOM_OF_PIPE_BIT: Final stage in the pipeline where commands complete execution. * ename:VK_PIPELINE_STAGE_HOST_BIT: A pseudo-stage indicating execution on the host of reads/writes of device memory. * ename:VK_PIPELINE_STAGE_ALL_GRAPHICS_BIT: Execution of all graphics pipeline stages. * ename:VK_PIPELINE_STAGE_ALL_COMMANDS_BIT: Execution of all stages supported on the queue.
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
    /// Bitmask of VkPipelineTessellationStateCreateFlagBits
    /// </para>
    /// <para>
    /// etext:VkPipelineTessellationStateCreateFlags is a mask of zero or more elink:VkPipelineTessellationStateCreateFlagBits. It is used as a member and/or parameter of the structures and commands in the See Also section below.
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
    /// Bitmask of VkPipelineVertexInputStateCreateFlagBits
    /// </para>
    /// <para>
    /// etext:VkPipelineVertexInputStateCreateFlags is a mask of zero or more elink:VkPipelineVertexInputStateCreateFlagBits. It is used as a member and/or parameter of the structures and commands in the See Also section below.
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
    /// Bitmask of VkPipelineViewportStateCreateFlagBits
    /// </para>
    /// <para>
    /// etext:VkPipelineViewportStateCreateFlags is a mask of zero or more elink:VkPipelineViewportStateCreateFlagBits. It is used as a member and/or parameter of the structures and commands in the See Also section below.
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
    /// Bitmask specifying constraints on a query
    /// </para>
    /// <para>
    /// For more information, see:
    /// </para>
    /// <para>
    /// * The reference page for flink:vkCmdBeginQuery, where this interface is defined. * The See Also section for other reference pages using this type. * The Vulkan Specification.
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
    /// Bitmask specifying queried pipeline statistics
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
    /// Bitmask of VkQueryPoolCreateFlagBits
    /// </para>
    /// <para>
    /// etext:VkQueryPoolCreateFlags is a mask of zero or more elink:VkQueryPoolCreateFlagBits. It is used as a member and/or parameter of the structures and commands in the See Also section below.
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
    /// Bitmask specifying how and when query results are returned
    /// </para>
    /// <para>
    /// For more information, see:
    /// </para>
    /// <para>
    /// * The reference page for flink:vkGetQueryPoolResults, where this interface is defined. * The See Also section for other reference pages using this type. * The Vulkan Specification.
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
    /// Bitmask specifying capabilities of queues in a queue family
    /// </para>
    /// <para>
    /// For more information, see:
    /// </para>
    /// <para>
    /// * The reference page for slink:VkQueueFamilyProperties, where this interface is defined. * The See Also section for other reference pages using this type. * The Vulkan Specification.
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
		/// Queue supports graphics operations
		/// </para>
		/// </summary>
		Graphics = 1 << 0,
	    /// <summary>
		/// <para>
		/// Queue supports compute operations
		/// </para>
		/// </summary>
		Compute = 1 << 1,
	    /// <summary>
		/// <para>
		/// Queue supports transfer operations
		/// </para>
		/// </summary>
		Transfer = 1 << 2,
	    /// <summary>
		/// <para>
		/// Queue supports sparse resource memory management operations
		/// </para>
		/// </summary>
		SparseBinding = 1 << 3,
	}

    /// <summary>
    /// <para>
    /// Bitmask of VkRenderPassCreateFlagBits
    /// </para>
    /// <para>
    /// etext:VkRenderPassCreateFlags is a mask of zero or more elink:VkRenderPassCreateFlagBits. It is used as a member and/or parameter of the structures and commands in the See Also section below.
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
    /// Bitmask specifying sample counts supported for an image used for storage operations
    /// </para>
    /// <para>
    /// For more information, see:
    /// </para>
    /// <para>
    /// * The reference page for slink:VkPhysicalDeviceLimits, where this interface is defined. * The See Also section for other reference pages using this type. * The Vulkan Specification.
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
    /// Bitmask of VkSamplerCreateFlagBits
    /// </para>
    /// <para>
    /// etext:VkSamplerCreateFlags is a mask of zero or more elink:VkSamplerCreateFlagBits. It is used as a member and/or parameter of the structures and commands in the See Also section below.
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
    /// Bitmask of VkSemaphoreCreateFlagBits
    /// </para>
    /// <para>
    /// etext:VkSemaphoreCreateFlags is a mask of zero or more elink:VkSemaphoreCreateFlagBits. It is used as a member and/or parameter of the structures and commands in the See Also section below.
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
    /// Bitmask of VkShaderModuleCreateFlagBits
    /// </para>
    /// <para>
    /// etext:VkShaderModuleCreateFlags is a mask of zero or more elink:VkShaderModuleCreateFlagBits. It is used as a member and/or parameter of the structures and commands in the See Also section below.
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
    /// Bitmask specifying a pipeline stage
    /// </para>
    /// <para>
    /// For more information, see:
    /// </para>
    /// <para>
    /// * The reference page for slink:VkPipelineShaderStageCreateInfo, where this interface is defined. * The See Also section for other reference pages using this type. * The Vulkan Specification.
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
    /// Bitmask specifying additional information about a sparse image resource
    /// </para>
    /// <para>
    /// For more information, see:
    /// </para>
    /// <para>
    /// * The reference page for slink:VkSparseImageFormatProperties, where this interface is defined. * The See Also section for other reference pages using this type. * The Vulkan Specification.
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
		/// Image uses a single miptail region for all array layers
		/// </para>
		/// </summary>
		SingleMiptail = 1 << 0,
	    /// <summary>
		/// <para>
		/// Image requires mip level dimensions to be an integer multiple of the sparse image block dimensions for non-miptail levels.
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
    /// Bitmask specifying usage of a sparse memory binding operation
    /// </para>
    /// <para>
    /// For more information, see:
    /// </para>
    /// <para>
    /// * The reference page for slink:VkSparseMemoryBind, where this interface is defined. * The See Also section for other reference pages using this type. * The Vulkan Specification.
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
    /// Bitmask specifying sets of stencil state for which to update the compare mask
    /// </para>
    /// <para>
    /// For more information, see:
    /// </para>
    /// <para>
    /// * The reference page for flink:vkCmdSetStencilCompareMask, where this interface is defined. * The See Also section for other reference pages using this type. * The Vulkan Specification.
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
    /// Bitmask of VkSubpassDescriptionFlagBits
    /// </para>
    /// <para>
    /// etext:VkSubpassDescriptionFlags is a mask of zero or more elink:VkSubpassDescriptionFlagBits. It is used as a member and/or parameter of the structures and commands in the See Also section below.
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
    /// -
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
    /// specify how contents of an attachment are treated at the beginning of a subpass
    /// </para>
    /// <para>
    /// For more information, see:
    /// </para>
    /// <para>
    /// * The reference page for slink:VkAttachmentDescription, where this interface is defined. * The See Also section for other reference pages using this type. * The Vulkan Specification.
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
    /// specify how contents of an attachment are treated at the end of a subpass
    /// </para>
    /// <para>
    /// For more information, see:
    /// </para>
    /// <para>
    /// * The reference page for slink:VkAttachmentDescription, where this interface is defined. * The See Also section for other reference pages using this type. * The Vulkan Specification.
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
    /// framebuffer blending factors
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
    /// framebuffer blending operations
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
    /// specify border color used for texture lookups
    /// </para>
    /// <para>
    /// For more information, see:
    /// </para>
    /// <para>
    /// * The reference page for slink:VkSamplerCreateInfo, where this interface is defined. * The See Also section for other reference pages using this type. * The Vulkan Specification.
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
    /// -
    /// </para>
    /// </summary>
	public enum ColorSpace
	{
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		SrgbNonlinear = 0,
	}

    /// <summary>
    /// <para>
    /// Structure specifying a command buffer level
    /// </para>
    /// <para>
    /// For more information, see:
    /// </para>
    /// <para>
    /// * The reference page for slink:VkCommandBufferAllocateInfo, where this interface is defined. * The See Also section for other reference pages using this type. * The Vulkan Specification.
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
    /// stencil comparison function
    /// </para>
    /// <para>
    /// * ename:VK_COMPARE_OP_NEVER: the test never passes. * ename:VK_COMPARE_OP_LESS: the test passes when latexmath:[$R \lt S$]. * ename:VK_COMPARE_OP_EQUAL: the test passes when latexmath:[$R = S$]. * ename:VK_COMPARE_OP_LESS_OR_EQUAL: the test passes when latexmath:[$R \leq S$]. * ename:VK_COMPARE_OP_GREATER: the test passes when latexmath:[$R \gt S$]. * ename:VK_COMPARE_OP_NOT_EQUAL: the test passes when latexmath:[$R \neq S$]. * ename:VK_COMPARE_OP_GREATER_OR_EQUAL: the test passes when latexmath:[$R \geq S$]. * ename:VK_COMPARE_OP_ALWAYS: the test always passes.
    /// </para>
    /// </summary>
	public enum CompareOp
	{
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		Never = 0,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		Less = 1,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		Equal = 2,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		LessOrEqual = 3,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		Greater = 4,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		NotEqual = 5,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		GreaterOrEqual = 6,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		Always = 7,
	}

    /// <summary>
    /// <para>
    /// specify how a component is swizzled
    /// </para>
    /// <para>
    /// For more information, see:
    /// </para>
    /// <para>
    /// * The reference page for slink:VkComponentMapping, where this interface is defined. * The See Also section for other reference pages using this type. * The Vulkan Specification.
    /// </para>
    /// </summary>
	public enum ComponentSwizzle
	{
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		Identity = 0,
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
		One = 2,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		R = 3,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		G = 4,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		B = 5,
	    /// <summary>
		/// <para>
		/// -
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
    /// indicate which dynamic state is taken from dynamic state commands
    /// </para>
    /// <para>
    /// * ename:VK_DYNAMIC_STATE_VIEWPORT indicates that the pname:pViewports state in sname:VkPipelineViewportStateCreateInfo will be ignored and must: be set dynamically with flink:vkCmdSetViewport before any draw commands. The number of viewports used by a pipeline is still specified by the pname:viewportCount member of sname:VkPipelineViewportStateCreateInfo. * ename:VK_DYNAMIC_STATE_SCISSOR indicates that the pname:pScissors state in sname:VkPipelineViewportStateCreateInfo will be ignored and must: be set dynamically with flink:vkCmdSetScissor before any draw commands. The number of scissor rectangles used by a pipeline is still specified by the pname:scissorCount member of sname:VkPipelineViewportStateCreateInfo. * ename:VK_DYNAMIC_STATE_LINE_WIDTH indicates that the pname:lineWidth state in sname:VkPipelineRasterizationStateCreateInfo will be ignored and must: be set dynamically with flink:vkCmdSetLineWidth before any draw commands that generate line primitives for the rasterizer. * ename:VK_DYNAMIC_STATE_DEPTH_BIAS indicates that the pname:depthBiasConstantFactor, pname:depthBiasClamp and pname:depthBiasSlopeFactor states in sname:VkPipelineRasterizationStateCreateInfo will be ignored and must: be set dynamically with flink:vkCmdSetDepthBias before any draws are performed with pname:depthBiasEnable in sname:VkPipelineRasterizationStateCreateInfo set to ename:VK_TRUE. * ename:VK_DYNAMIC_STATE_BLEND_CONSTANTS indicates that the pname:blendConstants state in sname:VkPipelineColorBlendStateCreateInfo will be ignored and must: be set dynamically with flink:vkCmdSetBlendConstants before any draws are performed with a pipeline state with sname:VkPipelineColorBlendAttachmentState member pname:blendEnable set to ename:VK_TRUE and any of the blend functions using a constant blend color. * ename:VK_DYNAMIC_STATE_DEPTH_BOUNDS indicates that the pname:minDepthBounds and pname:maxDepthBounds states of slink:VkPipelineDepthStencilStateCreateInfo will be ignored and must: be set dynamically with flink:vkCmdSetDepthBounds before any draws are performed with a pipeline state with sname:VkPipelineDepthStencilStateCreateInfo member pname:depthBoundsTestEnable set to ename:VK_TRUE. * ename:VK_DYNAMIC_STATE_STENCIL_COMPARE_MASK indicates that the pname:compareMask state in sname:VkPipelineDepthStencilStateCreateInfo for both pname:front and pname:back will be ignored and must: be set dynamically with flink:vkCmdSetStencilCompareMask before any draws are performed with a pipeline state with sname:VkPipelineDepthStencilStateCreateInfo member pname:stencilTestEnable set to ename:VK_TRUE * ename:VK_DYNAMIC_STATE_STENCIL_WRITE_MASK indicates that the pname:writeMask state in sname:VkPipelineDepthStencilStateCreateInfo for both pname:front and pname:back will be ignored and must: be set dynamically with flink:vkCmdSetStencilWriteMask before any draws are performed with a pipeline state with sname:VkPipelineDepthStencilStateCreateInfo member pname:stencilTestEnable set to ename:VK_TRUE * ename:VK_DYNAMIC_STATE_STENCIL_REFERENCE indicates that the pname:reference state in sname:VkPipelineDepthStencilStateCreateInfo for both pname:front and pname:back will be ignored and must: be set dynamically with flink:vkCmdSetStencilReference before any draws are performed with a pipeline state with sname:VkPipelineDepthStencilStateCreateInfo member pname:stencilTestEnable set to ename:VK_TRUE
    /// </para>
    /// </summary>
	public enum DynamicState
	{
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		Viewport = 0,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		Scissor = 1,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		LineWidth = 2,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		DepthBias = 3,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		BlendConstants = 4,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		DepthBounds = 5,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		StencilCompareMask = 6,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		StencilWriteMask = 7,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		StencilReference = 8,
	}

    /// <summary>
    /// <para>
    /// specify filters used for texture lookups
    /// </para>
    /// <para>
    /// For more information, see:
    /// </para>
    /// <para>
    /// * The reference page for slink:VkSamplerCreateInfo, where this interface is defined. * The See Also section for other reference pages using this type. * The Vulkan Specification.
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
    /// available image formats
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_UNDEFINED:: The format is not specified.
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_R4G4_UNORM_PACK8:: A two-component, 8-bit packed unsigned normalized format that has a 4-bit R component in bits 4..7, and a 4-bit G component in bits 0..3.
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_R4G4B4A4_UNORM_PACK16:: A four-component, 16-bit packed unsigned normalized format that has a 4-bit R component in bits 12..15, a 4-bit G component in bits 8..11, a 4-bit B component in bits 4..7, and a 4-bit A component in bits 0..3.
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_B4G4R4A4_UNORM_PACK16:: A four-component, 16-bit packed unsigned normalized format that has a 4-bit B component in bits 12..15, a 4-bit G component in bits 8..11, a 4-bit R component in bits 4..7, and a 4-bit A component in bits 0..3.
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_R5G6B5_UNORM_PACK16:: A three-component, 16-bit packed unsigned normalized format that has a 5-bit R component in bits 11..15, a 6-bit G component in bits 5..10, and a 5-bit B component in bits 0..4.
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_B5G6R5_UNORM_PACK16:: A three-component, 16-bit packed unsigned normalized format that has a 5-bit B component in bits 11..15, a 6-bit G component in bits 5..10, and a 5-bit R component in bits 0..4.
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_R5G5B5A1_UNORM_PACK16:: A four-component, 16-bit packed unsigned normalized format that has a 5-bit R component in bits 11..15, a 5-bit G component in bits 6..10, a 5-bit B component in bits 1..5, and a 1-bit A component in bit 0.
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_B5G5R5A1_UNORM_PACK16:: A four-component, 16-bit packed unsigned normalized format that has a 5-bit B component in bits 11..15, a 5-bit G component in bits 6..10, a 5-bit R component in bits 1..5, and a 1-bit A component in bit 0.
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_A1R5G5B5_UNORM_PACK16:: A four-component, 16-bit packed unsigned normalized format that has a 1-bit A component in bit 15, a 5-bit R component in bits 10..14, a 5-bit G component in bits 5..9, and a 5-bit B component in bits 0..4.
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_R8_UNORM:: A one-component, 8-bit unsigned normalized format that has a single 8-bit R component.
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_R8_SNORM:: A one-component, 8-bit signed normalized format that has a single 8-bit R component.
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_R8_USCALED:: A one-component, 8-bit unsigned scaled integer format that has a single 8-bit R component.
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_R8_SSCALED:: A one-component, 8-bit signed scaled integer format that has a single 8-bit R component.
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_R8_UINT:: A one-component, 8-bit unsigned integer format that has a single 8-bit R component.
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_R8_SINT:: A one-component, 8-bit signed integer format that has a single 8-bit R component.
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_R8_SRGB:: A one-component, 8-bit unsigned normalized format that has a single 8-bit R component stored with sRGB nonlinear encoding.
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_R8G8_UNORM:: A two-component, 16-bit unsigned normalized format that has an 8-bit R component in byte 0, and an 8-bit G component in byte 1.
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_R8G8_SNORM:: A two-component, 16-bit signed normalized format that has an 8-bit R component in byte 0, and an 8-bit G component in byte 1.
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_R8G8_USCALED:: A two-component, 16-bit unsigned scaled integer format that has an 8-bit R component in byte 0, and an 8-bit G component in byte 1.
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_R8G8_SSCALED:: A two-component, 16-bit signed scaled integer format that has an 8-bit R component in byte 0, and an 8-bit G component in byte 1.
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_R8G8_UINT:: A two-component, 16-bit unsigned integer format that has an 8-bit R component in byte 0, and an 8-bit G component in byte 1.
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_R8G8_SINT:: A two-component, 16-bit signed integer format that has an 8-bit R component in byte 0, and an 8-bit G component in byte 1.
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_R8G8_SRGB:: A two-component, 16-bit unsigned normalized format that has an 8-bit R component stored with sRGB nonlinear encoding in byte 0, and an 8-bit G component stored with sRGB nonlinear encoding in byte 1.
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_R8G8B8_UNORM:: A three-component, 24-bit unsigned normalized format that has an 8-bit R component in byte 0, an 8-bit G component in byte 1, and an 8-bit B component in byte 2.
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_R8G8B8_SNORM:: A three-component, 24-bit signed normalized format that has an 8-bit R component in byte 0, an 8-bit G component in byte 1, and an 8-bit B component in byte 2.
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_R8G8B8_USCALED:: A three-component, 24-bit unsigned scaled format that has an 8-bit R component in byte 0, an 8-bit G component in byte 1, and an 8-bit B component in byte 2.
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_R8G8B8_SSCALED:: A three-component, 24-bit signed scaled format that has an 8-bit R component in byte 0, an 8-bit G component in byte 1, and an 8-bit B component in byte 2.
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_R8G8B8_UINT:: A three-component, 24-bit unsigned integer format that has an 8-bit R component in byte 0, an 8-bit G component in byte 1, and an 8-bit B component in byte 2.
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_R8G8B8_SINT:: A three-component, 24-bit signed integer format that has an 8-bit R component in byte 0, an 8-bit G component in byte 1, and an 8-bit B component in byte 2.
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_R8G8B8_SRGB:: A three-component, 24-bit unsigned normalized format that has an 8-bit R component stored with sRGB nonlinear encoding in byte 0, an 8-bit G component stored with sRGB nonlinear encoding in byte 1, and an 8-bit B component stored with sRGB nonlinear encoding in byte 2.
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_B8G8R8_UNORM:: A three-component, 24-bit unsigned normalized format that has an 8-bit B component in byte 0, an 8-bit G component in byte 1, and an 8-bit R component in byte 2.
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_B8G8R8_SNORM:: A three-component, 24-bit signed normalized format that has an 8-bit B component in byte 0, an 8-bit G component in byte 1, and an 8-bit R component in byte 2.
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_B8G8R8_USCALED:: A three-component, 24-bit unsigned scaled format that has an 8-bit B component in byte 0, an 8-bit G component in byte 1, and an 8-bit R component in byte 2.
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_B8G8R8_SSCALED:: A three-component, 24-bit signed scaled format that has an 8-bit B component in byte 0, an 8-bit G component in byte 1, and an 8-bit R component in byte 2.
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_B8G8R8_UINT:: A three-component, 24-bit unsigned integer format that has an 8-bit B component in byte 0, an 8-bit G component in byte 1, and an 8-bit R component in byte 2.
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_B8G8R8_SINT:: A three-component, 24-bit signed integer format that has an 8-bit B component in byte 0, an 8-bit G component in byte 1, and an 8-bit R component in byte 2.
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_B8G8R8_SRGB:: A three-component, 24-bit unsigned normalized format that has an 8-bit B component stored with sRGB nonlinear encoding in byte 0, an 8-bit G component stored with sRGB nonlinear encoding in byte 1, and an 8-bit R component stored with sRGB nonlinear encoding in byte 2.
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_R8G8B8A8_UNORM:: A four-component, 32-bit unsigned normalized format that has an 8-bit R component in byte 0, an 8-bit G component in byte 1, an 8-bit B component in byte 2, and an 8-bit A component in byte 3.
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_R8G8B8A8_SNORM:: A four-component, 32-bit signed normalized format that has an 8-bit R component in byte 0, an 8-bit G component in byte 1, an 8-bit B component in byte 2, and an 8-bit A component in byte 3.
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_R8G8B8A8_USCALED:: A four-component, 32-bit unsigned scaled format that has an 8-bit R component in byte 0, an 8-bit G component in byte 1, an 8-bit B component in byte 2, and an 8-bit A component in byte 3.
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_R8G8B8A8_SSCALED:: A four-component, 32-bit signed scaled format that has an 8-bit R component in byte 0, an 8-bit G component in byte 1, an 8-bit B component in byte 2, and an 8-bit A component in byte 3.
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_R8G8B8A8_UINT:: A four-component, 32-bit unsigned integer format that has an 8-bit R component in byte 0, an 8-bit G component in byte 1, an 8-bit B component in byte 2, and an 8-bit A component in byte 3.
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_R8G8B8A8_SINT:: A four-component, 32-bit signed integer format that has an 8-bit R component in byte 0, an 8-bit G component in byte 1, an 8-bit B component in byte 2, and an 8-bit A component in byte 3.
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_R8G8B8A8_SRGB:: A four-component, 32-bit unsigned normalized format that has an 8-bit R component stored with sRGB nonlinear encoding in byte 0, an 8-bit G component stored with sRGB nonlinear encoding in byte 1, an 8-bit B component stored with sRGB nonlinear encoding in byte 2, and an 8-bit A component in byte 3.
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_B8G8R8A8_UNORM:: A four-component, 32-bit unsigned normalized format that has an 8-bit B component in byte 0, an 8-bit G component in byte 1, an 8-bit R component in byte 2, and an 8-bit A component in byte 3.
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_B8G8R8A8_SNORM:: A four-component, 32-bit signed normalized format that has an 8-bit B component in byte 0, an 8-bit G component in byte 1, an 8-bit R component in byte 2, and an 8-bit A component in byte 3.
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_B8G8R8A8_USCALED:: A four-component, 32-bit unsigned scaled format that has an 8-bit B component in byte 0, an 8-bit G component in byte 1, an 8-bit R component in byte 2, and an 8-bit A component in byte 3.
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_B8G8R8A8_SSCALED:: A four-component, 32-bit signed scaled format that has an 8-bit B component in byte 0, an 8-bit G component in byte 1, an 8-bit R component in byte 2, and an 8-bit A component in byte 3.
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_B8G8R8A8_UINT:: A four-component, 32-bit unsigned integer format that has an 8-bit B component in byte 0, an 8-bit G component in byte 1, an 8-bit R component in byte 2, and an 8-bit A component in byte 3.
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_B8G8R8A8_SINT:: A four-component, 32-bit signed integer format that has an 8-bit B component in byte 0, an 8-bit G component in byte 1, an 8-bit R component in byte 2, and an 8-bit A component in byte 3.
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_B8G8R8A8_SRGB:: A four-component, 32-bit unsigned normalized format that has an 8-bit B component stored with sRGB nonlinear encoding in byte 0, an 8-bit G component stored with sRGB nonlinear encoding in byte 1, an 8-bit R component stored with sRGB nonlinear encoding in byte 2, and an 8-bit A component in byte 3.
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_A8B8G8R8_UNORM_PACK32:: A four-component, 32-bit packed unsigned normalized format that has an 8-bit A component in bits 24..31, an 8-bit B component in bits 16..23, an 8-bit G component in bits 8..15, and an 8-bit R component in bits 0..7.
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_A8B8G8R8_SNORM_PACK32:: A four-component, 32-bit packed signed normalized format that has an 8-bit A component in bits 24..31, an 8-bit B component in bits 16..23, an 8-bit G component in bits 8..15, and an 8-bit R component in bits 0..7.
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_A8B8G8R8_USCALED_PACK32:: A four-component, 32-bit packed unsigned scaled integer format that has an 8-bit A component in bits 24..31, an 8-bit B component in bits 16..23, an 8-bit G component in bits 8..15, and an 8-bit R component in bits 0..7.
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_A8B8G8R8_SSCALED_PACK32:: A four-component, 32-bit packed signed scaled integer format that has an 8-bit A component in bits 24..31, an 8-bit B component in bits 16..23, an 8-bit G component in bits 8..15, and an 8-bit R component in bits 0..7.
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_A8B8G8R8_UINT_PACK32:: A four-component, 32-bit packed unsigned integer format that has an 8-bit A component in bits 24..31, an 8-bit B component in bits 16..23, an 8-bit G component in bits 8..15, and an 8-bit R component in bits 0..7.
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_A8B8G8R8_SINT_PACK32:: A four-component, 32-bit packed signed integer format that has an 8-bit A component in bits 24..31, an 8-bit B component in bits 16..23, an 8-bit G component in bits 8..15, and an 8-bit R component in bits 0..7.
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_A8B8G8R8_SRGB_PACK32:: A four-component, 32-bit packed unsigned normalized format that has an 8-bit A component in bits 24..31, an 8-bit B component stored with sRGB nonlinear encoding in bits 16..23, an 8-bit G component stored with sRGB nonlinear encoding in bits 8..15, and an 8-bit R component stored with sRGB nonlinear encoding in bits 0..7.
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_A2R10G10B10_UNORM_PACK32:: A four-component, 32-bit packed unsigned normalized format that has a 2-bit A component in bits 30..31, a 10-bit R component in bits 20..29, a 10-bit G component in bits 10..19, and a 10-bit B component in bits 0..9.
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_A2R10G10B10_SNORM_PACK32:: A four-component, 32-bit packed signed normalized format that has a 2-bit A component in bits 30..31, a 10-bit R component in bits 20..29, a 10-bit G component in bits 10..19, and a 10-bit B component in bits 0..9.
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_A2R10G10B10_USCALED_PACK32:: A four-component, 32-bit packed unsigned scaled integer format that has a 2-bit A component in bits 30..31, a 10-bit R component in bits 20..29, a 10-bit G component in bits 10..19, and a 10-bit B component in bits 0..9.
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_A2R10G10B10_SSCALED_PACK32:: A four-component, 32-bit packed signed scaled integer format that has a 2-bit A component in bits 30..31, a 10-bit R component in bits 20..29, a 10-bit G component in bits 10..19, and a 10-bit B component in bits 0..9.
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_A2R10G10B10_UINT_PACK32:: A four-component, 32-bit packed unsigned integer format that has a 2-bit A component in bits 30..31, a 10-bit R component in bits 20..29, a 10-bit G component in bits 10..19, and a 10-bit B component in bits 0..9.
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_A2R10G10B10_SINT_PACK32:: A four-component, 32-bit packed signed integer format that has a 2-bit A component in bits 30..31, a 10-bit R component in bits 20..29, a 10-bit G component in bits 10..19, and a 10-bit B component in bits 0..9.
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_A2B10G10R10_UNORM_PACK32:: A four-component, 32-bit packed unsigned normalized format that has a 2-bit A component in bits 30..31, a 10-bit B component in bits 20..29, a 10-bit G component in bits 10..19, and a 10-bit R component in bits 0..9.
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_A2B10G10R10_SNORM_PACK32:: A four-component, 32-bit packed signed normalized format that has a 2-bit A component in bits 30..31, a 10-bit B component in bits 20..29, a 10-bit G component in bits 10..19, and a 10-bit R component in bits 0..9.
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_A2B10G10R10_USCALED_PACK32:: A four-component, 32-bit packed unsigned scaled integer format that has a 2-bit A component in bits 30..31, a 10-bit B component in bits 20..29, a 10-bit G component in bits 10..19, and a 10-bit R component in bits 0..9.
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_A2B10G10R10_SSCALED_PACK32:: A four-component, 32-bit packed signed scaled integer format that has a 2-bit A component in bits 30..31, a 10-bit B component in bits 20..29, a 10-bit G component in bits 10..19, and a 10-bit R component in bits 0..9.
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_A2B10G10R10_UINT_PACK32:: A four-component, 32-bit packed unsigned integer format that has a 2-bit A component in bits 30..31, a 10-bit B component in bits 20..29, a 10-bit G component in bits 10..19, and a 10-bit R component in bits 0..9.
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_A2B10G10R10_SINT_PACK32:: A four-component, 32-bit packed signed integer format that has a 2-bit A component in bits 30..31, a 10-bit B component in bits 20..29, a 10-bit G component in bits 10..19, and a 10-bit R component in bits 0..9.
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_R16_UNORM:: A one-component, 16-bit unsigned normalized format that has a single 16-bit R component.
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_R16_SNORM:: A one-component, 16-bit signed normalized format that has a single 16-bit R component.
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_R16_USCALED:: A one-component, 16-bit unsigned scaled integer format that has a single 16-bit R component.
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_R16_SSCALED:: A one-component, 16-bit signed scaled integer format that has a single 16-bit R component.
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_R16_UINT:: A one-component, 16-bit unsigned integer format that has a single 16-bit R component.
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_R16_SINT:: A one-component, 16-bit signed integer format that has a single 16-bit R component.
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_R16_SFLOAT:: A one-component, 16-bit signed floating-point format that has a single 16-bit R component.
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_R16G16_UNORM:: A two-component, 32-bit unsigned normalized format that has a 16-bit R component in bytes 0..1, and a 16-bit G component in bytes 2..3.
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_R16G16_SNORM:: A two-component, 32-bit signed normalized format that has a 16-bit R component in bytes 0..1, and a 16-bit G component in bytes 2..3.
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_R16G16_USCALED:: A two-component, 32-bit unsigned scaled integer format that has a 16-bit R component in bytes 0..1, and a 16-bit G component in bytes 2..3.
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_R16G16_SSCALED:: A two-component, 32-bit signed scaled integer format that has a 16-bit R component in bytes 0..1, and a 16-bit G component in bytes 2..3.
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_R16G16_UINT:: A two-component, 32-bit unsigned integer format that has a 16-bit R component in bytes 0..1, and a 16-bit G component in bytes 2..3.
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_R16G16_SINT:: A two-component, 32-bit signed integer format that has a 16-bit R component in bytes 0..1, and a 16-bit G component in bytes 2..3.
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_R16G16_SFLOAT:: A two-component, 32-bit signed floating-point format that has a 16-bit R component in bytes 0..1, and a 16-bit G component in bytes 2..3.
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_R16G16B16_UNORM:: A three-component, 48-bit unsigned normalized format that has a 16-bit R component in bytes 0..1, a 16-bit G component in bytes 2..3, and a 16-bit B component in bytes 4..5.
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_R16G16B16_SNORM:: A three-component, 48-bit signed normalized format that has a 16-bit R component in bytes 0..1, a 16-bit G component in bytes 2..3, and a 16-bit B component in bytes 4..5.
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_R16G16B16_USCALED:: A three-component, 48-bit unsigned scaled integer format that has a 16-bit R component in bytes 0..1, a 16-bit G component in bytes 2..3, and a 16-bit B component in bytes 4..5.
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_R16G16B16_SSCALED:: A three-component, 48-bit signed scaled integer format that has a 16-bit R component in bytes 0..1, a 16-bit G component in bytes 2..3, and a 16-bit B component in bytes 4..5.
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_R16G16B16_UINT:: A three-component, 48-bit unsigned integer format that has a 16-bit R component in bytes 0..1, a 16-bit G component in bytes 2..3, and a 16-bit B component in bytes 4..5.
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_R16G16B16_SINT:: A three-component, 48-bit signed integer format that has a 16-bit R component in bytes 0..1, a 16-bit G component in bytes 2..3, and a 16-bit B component in bytes 4..5.
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_R16G16B16_SFLOAT:: A three-component, 48-bit signed floating-point format that has a 16-bit R component in bytes 0..1, a 16-bit G component in bytes 2..3, and a 16-bit B component in bytes 4..5.
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_R16G16B16A16_UNORM:: A four-component, 64-bit unsigned normalized format that has a 16-bit R component in bytes 0..1, a 16-bit G component in bytes 2..3, a 16-bit B component in bytes 4..5, and a 16-bit A component in bytes 6..7.
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_R16G16B16A16_SNORM:: A four-component, 64-bit signed normalized format that has a 16-bit R component in bytes 0..1, a 16-bit G component in bytes 2..3, a 16-bit B component in bytes 4..5, and a 16-bit A component in bytes 6..7.
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_R16G16B16A16_USCALED:: A four-component, 64-bit unsigned scaled integer format that has a 16-bit R component in bytes 0..1, a 16-bit G component in bytes 2..3, a 16-bit B component in bytes 4..5, and a 16-bit A component in bytes 6..7.
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_R16G16B16A16_SSCALED:: A four-component, 64-bit signed scaled integer format that has a 16-bit R component in bytes 0..1, a 16-bit G component in bytes 2..3, a 16-bit B component in bytes 4..5, and a 16-bit A component in bytes 6..7.
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_R16G16B16A16_UINT:: A four-component, 64-bit unsigned integer format that has a 16-bit R component in bytes 0..1, a 16-bit G component in bytes 2..3, a 16-bit B component in bytes 4..5, and a 16-bit A component in bytes 6..7.
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_R16G16B16A16_SINT:: A four-component, 64-bit signed integer format that has a 16-bit R component in bytes 0..1, a 16-bit G component in bytes 2..3, a 16-bit B component in bytes 4..5, and a 16-bit A component in bytes 6..7.
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_R16G16B16A16_SFLOAT:: A four-component, 64-bit signed floating-point format that has a 16-bit R component in bytes 0..1, a 16-bit G component in bytes 2..3, a 16-bit B component in bytes 4..5, and a 16-bit A component in bytes 6..7.
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_R32_UINT:: A one-component, 32-bit unsigned integer format that has a single 32-bit R component.
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_R32_SINT:: A one-component, 32-bit signed integer format that has a single 32-bit R component.
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_R32_SFLOAT:: A one-component, 32-bit signed floating-point format that has a single 32-bit R component.
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_R32G32_UINT:: A two-component, 64-bit unsigned integer format that has a 32-bit R component in bytes 0..3, and a 32-bit G component in bytes 4..7.
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_R32G32_SINT:: A two-component, 64-bit signed integer format that has a 32-bit R component in bytes 0..3, and a 32-bit G component in bytes 4..7.
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_R32G32_SFLOAT:: A two-component, 64-bit signed floating-point format that has a 32-bit R component in bytes 0..3, and a 32-bit G component in bytes 4..7.
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_R32G32B32_UINT:: A three-component, 96-bit unsigned integer format that has a 32-bit R component in bytes 0..3, a 32-bit G component in bytes 4..7, and a 32-bit B component in bytes 8..11.
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_R32G32B32_SINT:: A three-component, 96-bit signed integer format that has a 32-bit R component in bytes 0..3, a 32-bit G component in bytes 4..7, and a 32-bit B component in bytes 8..11.
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_R32G32B32_SFLOAT:: A three-component, 96-bit signed floating-point format that has a 32-bit R component in bytes 0..3, a 32-bit G component in bytes 4..7, and a 32-bit B component in bytes 8..11.
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_R32G32B32A32_UINT:: A four-component, 128-bit unsigned integer format that has a 32-bit R component in bytes 0..3, a 32-bit G component in bytes 4..7, a 32-bit B component in bytes 8..11, and a 32-bit A component in bytes 12..15.
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_R32G32B32A32_SINT:: A four-component, 128-bit signed integer format that has a 32-bit R component in bytes 0..3, a 32-bit G component in bytes 4..7, a 32-bit B component in bytes 8..11, and a 32-bit A component in bytes 12..15.
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_R32G32B32A32_SFLOAT:: A four-component, 128-bit signed floating-point format that has a 32-bit R component in bytes 0..3, a 32-bit G component in bytes 4..7, a 32-bit B component in bytes 8..11, and a 32-bit A component in bytes 12..15.
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_R64_UINT:: A one-component, 64-bit unsigned integer format that has a single 64-bit R component.
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_R64_SINT:: A one-component, 64-bit signed integer format that has a single 64-bit R component.
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_R64_SFLOAT:: A one-component, 64-bit signed floating-point format that has a single 64-bit R component.
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_R64G64_UINT:: A two-component, 128-bit unsigned integer format that has a 64-bit R component in bytes 0..7, and a 64-bit G component in bytes 8..15.
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_R64G64_SINT:: A two-component, 128-bit signed integer format that has a 64-bit R component in bytes 0..7, and a 64-bit G component in bytes 8..15.
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_R64G64_SFLOAT:: A two-component, 128-bit signed floating-point format that has a 64-bit R component in bytes 0..7, and a 64-bit G component in bytes 8..15.
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_R64G64B64_UINT:: A three-component, 192-bit unsigned integer format that has a 64-bit R component in bytes 0..7, a 64-bit G component in bytes 8..15, and a 64-bit B component in bytes 16..23.
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_R64G64B64_SINT:: A three-component, 192-bit signed integer format that has a 64-bit R component in bytes 0..7, a 64-bit G component in bytes 8..15, and a 64-bit B component in bytes 16..23.
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_R64G64B64_SFLOAT:: A three-component, 192-bit signed floating-point format that has a 64-bit R component in bytes 0..7, a 64-bit G component in bytes 8..15, and a 64-bit B component in bytes 16..23.
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_R64G64B64A64_UINT:: A four-component, 256-bit unsigned integer format that has a 64-bit R component in bytes 0..7, a 64-bit G component in bytes 8..15, a 64-bit B component in bytes 16..23, and a 64-bit A component in bytes 24..31.
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_R64G64B64A64_SINT:: A four-component, 256-bit signed integer format that has a 64-bit R component in bytes 0..7, a 64-bit G component in bytes 8..15, a 64-bit B component in bytes 16..23, and a 64-bit A component in bytes 24..31.
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_R64G64B64A64_SFLOAT:: A four-component, 256-bit signed floating-point format that has a 64-bit R component in bytes 0..7, a 64-bit G component in bytes 8..15, a 64-bit B component in bytes 16..23, and a 64-bit A component in bytes 24..31.
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_B10G11R11_UFLOAT_PACK32:: A three-component, 32-bit packed unsigned floating-point format that has a 10-bit B component in bits 22..31, an 11-bit G component in bits 11..21, an 11-bit R component in bits 0..10. See &lt;&lt;fundamentals-fp10&gt;&gt; and &lt;&lt;fundamentals-fp11&gt;&gt;.
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_E5B9G9R9_UFLOAT_PACK32:: A three-component, 32-bit packed unsigned floating-point format that has a 5-bit shared exponent in bits 27..31, a 9-bit B component mantissa in bits 18..26, a 9-bit G component mantissa in bits 9..17, and a 9-bit R component mantissa in bits 0..8.
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_D16_UNORM:: A one-component, 16-bit unsigned normalized format that has a single 16-bit depth component.
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_X8_D24_UNORM_PACK32:: A two-component, 32-bit format that has 24 unsigned normalized bits in the depth component and, optionally:, 8 bits that are unused.
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_D32_SFLOAT:: A one-component, 32-bit signed floating-point format that has 32-bits in the depth component.
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_S8_UINT:: A one-component, 8-bit unsigned integer format that has 8-bits in the stencil component.
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_D16_UNORM_S8_UINT:: A two-component, 24-bit format that has 16 unsigned normalized bits in the depth component and 8 unsigned integer bits in the stencil component.
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_D24_UNORM_S8_UINT:: A two-component, 32-bit packed format that has 8 unsigned integer bits in the stencil component, and 24 unsigned normalized bits in the depth component.
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_D32_SFLOAT_S8_UINT:: A two-component format that has 32 signed float bits in the depth component and 8 unsigned integer bits in the stencil component. There are optionally: 24-bits that are unused.
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_BC1_RGB_UNORM_BLOCK:: A three-component, block-compressed format where each 64-bit compressed texel block encodes a 4x4 rectangle of unsigned normalized RGB texel data. This format has no alpha and is considered opaque.
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_BC1_RGB_SRGB_BLOCK:: A three-component, block-compressed format where each 64-bit compressed texel block encodes a 4x4 rectangle of unsigned normalized RGB texel data with sRGB nonlinear encoding. This format has no alpha and is considered opaque.
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_BC1_RGBA_UNORM_BLOCK:: A four-component, block-compressed format where each 64-bit compressed texel block encodes a 4x4 rectangle of unsigned normalized RGB texel data, and provides 1 bit of alpha.
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_BC1_RGBA_SRGB_BLOCK:: A four-component, block-compressed format where each 64-bit compressed texel block encodes a 4x4 rectangle of unsigned normalized RGB texel data with sRGB nonlinear encoding, and provides 1 bit of alpha.
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_BC2_UNORM_BLOCK:: A four-component, block-compressed format where each 128-bit compressed texel block encodes a 4x4 rectangle of unsigned normalized RGBA texel data with the first 64 bits encoding alpha values followed by 64 bits encoding RGB values.
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_BC2_SRGB_BLOCK:: A four-component, block-compressed format where each 128-bit compressed texel block encodes a 4x4 rectangle of unsigned normalized RGBA texel data with the first 64 bits encoding alpha values followed by 64 bits encoding RGB values with sRGB nonlinear encoding.
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_BC3_UNORM_BLOCK:: A four-component, block-compressed format where each 128-bit compressed texel block encodes a 4x4 rectangle of unsigned normalized RGBA texel data with the first 64 bits encoding alpha values followed by 64 bits encoding RGB values.
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_BC3_SRGB_BLOCK:: A four-component, block-compressed format where each 128-bit compressed texel block encodes a 4x4 rectangle of unsigned normalized RGBA texel data with the first 64 bits encoding alpha values followed by 64 bits encoding RGB values with sRGB nonlinear encoding.
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_BC4_UNORM_BLOCK:: A one-component, block-compressed format where each 64-bit compressed texel block encodes a 4x4 rectangle of unsigned normalized red texel data.
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_BC4_SNORM_BLOCK:: A one-component, block-compressed format where each 64-bit compressed texel block encodes a 4x4 rectangle of signed normalized red texel data.
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_BC5_UNORM_BLOCK:: A two-component, block-compressed format where each 128-bit compressed texel block encodes a 4x4 rectangle of unsigned normalized RG texel data with the first 64 bits encoding red values followed by 64 bits encoding green values.
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_BC5_SNORM_BLOCK:: A two-component, block-compressed format where each 128-bit compressed texel block encodes a 4x4 rectangle of signed normalized RG texel data with the first 64 bits encoding red values followed by 64 bits encoding green values.
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_BC6H_UFLOAT_BLOCK:: A three-component, block-compressed format where each 128-bit compressed texel block encodes a 4x4 rectangle of unsigned floating-point RGB texel data.
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_BC6H_SFLOAT_BLOCK:: A three-component, block-compressed format where each 128-bit compressed texel block encodes a 4x4 rectangle of signed floating-point RGB texel data.
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_BC7_UNORM_BLOCK:: A four-component, block-compressed format where each 128-bit compressed texel block encodes a 4x4 rectangle of unsigned normalized RGBA texel data.
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_BC7_SRGB_BLOCK:: A four-component, block-compressed format where each 128-bit compressed texel block encodes a 4x4 rectangle of unsigned normalized RGBA texel data with sRGB nonlinear encoding applied to the RGB components.
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_ETC2_R8G8B8_UNORM_BLOCK:: A three-component, ETC2 compressed format where each 64-bit compressed texel block encodes a 4x4 rectangle of unsigned normalized RGB texel data. This format has no alpha and is considered opaque.
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_ETC2_R8G8B8_SRGB_BLOCK:: A three-component, ETC2 compressed format where each 64-bit compressed texel block encodes a 4x4 rectangle of unsigned normalized RGB texel data with sRGB nonlinear encoding. This format has no alpha and is considered opaque.
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_ETC2_R8G8B8A1_UNORM_BLOCK:: A four-component, ETC2 compressed format where each 64-bit compressed texel block encodes a 4x4 rectangle of unsigned normalized RGB texel data, and provides 1 bit of alpha.
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_ETC2_R8G8B8A1_SRGB_BLOCK:: A four-component, ETC2 compressed format where each 64-bit compressed texel block encodes a 4x4 rectangle of unsigned normalized RGB texel data with sRGB nonlinear encoding, and provides 1 bit of alpha.
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_ETC2_R8G8B8A8_UNORM_BLOCK:: A four-component, ETC2 compressed format where each 128-bit compressed texel block encodes a 4x4 rectangle of unsigned normalized RGBA texel data with the first 64 bits encoding alpha values followed by 64 bits encoding RGB values.
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_ETC2_R8G8B8A8_SRGB_BLOCK:: A four-component, ETC2 compressed format where each 64-bit compressed texel block encodes a 4x4 rectangle of unsigned normalized RGBA texel data with the first 64 bits encoding alpha values followed by 64 bits encoding RGB values with sRGB nonlinear encoding applied.
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_EAC_R11_UNORM_BLOCK:: A one-component, ETC2 compressed format where each 64-bit compressed texel block encodes a 4x4 rectangle of unsigned normalized red texel data.
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_EAC_R11_SNORM_BLOCK:: A one-component, ETC2 compressed format where each 64-bit compressed texel block encodes a 4x4 rectangle of signed normalized red texel data.
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_EAC_R11G11_UNORM_BLOCK:: A two-component, ETC2 compressed format where each 128-bit compressed texel block encodes a 4x4 rectangle of unsigned normalized RG texel data with the first 64 bits encoding red values followed by 64 bits encoding green values.
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_EAC_R11G11_SNORM_BLOCK:: A two-component, ETC2 compressed format where each 128-bit compressed texel block encodes a 4x4 rectangle of signed normalized RG texel data with the first 64 bits encoding red values followed by 64 bits encoding green values.
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_ASTC_4x4_UNORM_BLOCK:: A four-component, ASTC compressed format where each 128-bit compressed texel block encodes a 4x4 rectangle of unsigned normalized RGBA texel data.
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_ASTC_4x4_SRGB_BLOCK:: A four-component, ASTC compressed format where each 128-bit compressed texel block encodes a 4x4 rectangle of unsigned normalized RGBA texel data with sRGB nonlinear encoding applied to the RGB components.
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_ASTC_5x4_UNORM_BLOCK:: A four-component, ASTC compressed format where each 128-bit compressed texel block encodes a 5x4 rectangle of unsigned normalized RGBA texel data.
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_ASTC_5x4_SRGB_BLOCK:: A four-component, ASTC compressed format where each 128-bit compressed texel block encodes a 5x4 rectangle of unsigned normalized RGBA texel data with sRGB nonlinear encoding applied to the RGB components.
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_ASTC_5x5_UNORM_BLOCK:: A four-component, ASTC compressed format where each 128-bit compressed texel block encodes a 5x5 rectangle of unsigned normalized RGBA texel data.
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_ASTC_5x5_SRGB_BLOCK:: A four-component, ASTC compressed format where each 128-bit compressed texel block encodes a 5x5 rectangle of unsigned normalized RGBA texel data with sRGB nonlinear encoding applied to the RGB components.
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_ASTC_6x5_UNORM_BLOCK:: A four-component, ASTC compressed format where each 128-bit compressed texel block encodes a 6x5 rectangle of unsigned normalized RGBA texel data.
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_ASTC_6x5_SRGB_BLOCK:: A four-component, ASTC compressed format where each 128-bit compressed texel block encodes a 6x5 rectangle of unsigned normalized RGBA texel data with sRGB nonlinear encoding applied to the RGB components.
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_ASTC_6x6_UNORM_BLOCK:: A four-component, ASTC compressed format where each 128-bit compressed texel block encodes a 6x6 rectangle of unsigned normalized RGBA texel data.
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_ASTC_6x6_SRGB_BLOCK:: A four-component, ASTC compressed format where each 128-bit compressed texel block encodes a 6x6 rectangle of unsigned normalized RGBA texel data with sRGB nonlinear encoding applied to the RGB components.
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_ASTC_8x5_UNORM_BLOCK:: A four-component, ASTC compressed format where each 128-bit compressed texel block encodes a 8x5 rectangle of unsigned normalized RGBA texel data.
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_ASTC_8x5_SRGB_BLOCK:: A four-component, ASTC compressed format where each 128-bit compressed texel block encodes a 8x5 rectangle of unsigned normalized RGBA texel data with sRGB nonlinear encoding applied to the RGB components.
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_ASTC_8x6_UNORM_BLOCK:: A four-component, ASTC compressed format where each 128-bit compressed texel block encodes a 8x6 rectangle of unsigned normalized RGBA texel data.
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_ASTC_8x6_SRGB_BLOCK:: A four-component, ASTC compressed format where each 128-bit compressed texel block encodes a 8x6 rectangle of unsigned normalized RGBA texel data with sRGB nonlinear encoding applied to the RGB components.
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_ASTC_8x8_UNORM_BLOCK:: A four-component, ASTC compressed format where each 128-bit compressed texel block encodes a 8x8 rectangle of unsigned normalized RGBA texel data.
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_ASTC_8x8_SRGB_BLOCK:: A four-component, ASTC compressed format where each 128-bit compressed texel block encodes a 8x8 rectangle of unsigned normalized RGBA texel data with sRGB nonlinear encoding applied to the RGB components.
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_ASTC_10x5_UNORM_BLOCK:: A four-component, ASTC compressed format where each 128-bit compressed texel block encodes a 10x5 rectangle of unsigned normalized RGBA texel data.
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_ASTC_10x5_SRGB_BLOCK:: A four-component, ASTC compressed format where each 128-bit compressed texel block encodes a 10x5 rectangle of unsigned normalized RGBA texel data with sRGB nonlinear encoding applied to the RGB components.
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_ASTC_10x6_UNORM_BLOCK:: A four-component, ASTC compressed format where each 128-bit compressed texel block encodes a 10x6 rectangle of unsigned normalized RGBA texel data.
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_ASTC_10x6_SRGB_BLOCK:: A four-component, ASTC compressed format where each 128-bit compressed texel block encodes a 10x6 rectangle of unsigned normalized RGBA texel data with sRGB nonlinear encoding applied to the RGB components.
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_ASTC_10x8_UNORM_BLOCK:: A four-component, ASTC compressed format where each 128-bit compressed texel block encodes a 10x8 rectangle of unsigned normalized RGBA texel data.
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_ASTC_10x8_SRGB_BLOCK:: A four-component, ASTC compressed format where each 128-bit compressed texel block encodes a 10x8 rectangle of unsigned normalized RGBA texel data with sRGB nonlinear encoding applied to the RGB components.
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_ASTC_10x10_UNORM_BLOCK:: A four-component, ASTC compressed format where each 128-bit compressed texel block encodes a 10x10 rectangle of unsigned normalized RGBA texel data.
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_ASTC_10x10_SRGB_BLOCK:: A four-component, ASTC compressed format where each 128-bit compressed texel block encodes a 10x10 rectangle of unsigned normalized RGBA texel data with sRGB nonlinear encoding applied to the RGB components.
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_ASTC_12x10_UNORM_BLOCK:: A four-component, ASTC compressed format where each 128-bit compressed texel block encodes a 12x10 rectangle of unsigned normalized RGBA texel data.
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_ASTC_12x10_SRGB_BLOCK:: A four-component, ASTC compressed format where each 128-bit compressed texel block encodes a 12x10 rectangle of unsigned normalized RGBA texel data with sRGB nonlinear encoding applied to the RGB components.
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_ASTC_12x12_UNORM_BLOCK:: A four-component, ASTC compressed format where each 128-bit compressed texel block encodes a 12x12 rectangle of unsigned normalized RGBA texel data.
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_ASTC_12x12_SRGB_BLOCK:: A four-component, ASTC compressed format where each 128-bit compressed texel block encodes a 12x12 rectangle of unsigned normalized RGBA texel data with sRGB nonlinear encoding applied to the RGB components.
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
    /// interpret polygon front-facing orientation
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
    /// Layout of image and image subresources
    /// </para>
    /// <para>
    /// The type(s) of device access supported by each layout are:
    /// </para>
    /// <para>
    /// * ename:VK_IMAGE_LAYOUT_UNDEFINED: Supports no device access. This layout must: only be used as the pname:initialLayout member of sname:VkImageCreateInfo or sname:VkAttachmentDescription, or as the pname:oldLayout in an image transition. When transitioning out of this layout, the contents of the memory are not guaranteed to be preserved. * ename:VK_IMAGE_LAYOUT_PREINITIALIZED: Supports no device access. This layout must: only be used as the pname:initialLayout member of sname:VkImageCreateInfo or sname:VkAttachmentDescription, or as the pname:oldLayout in an image transition. When transitioning out of this layout, the contents of the memory are preserved. This layout is intended to be used as the initial layout for an image whose contents are written by the host, and hence the data can: be written to memory immediately, without first executing a layout transition. Currently, ename:VK_IMAGE_LAYOUT_PREINITIALIZED is only useful with ename:VK_IMAGE_TILING_LINEAR images because there is not a standard layout defined for ename:VK_IMAGE_TILING_OPTIMAL images. * ename:VK_IMAGE_LAYOUT_GENERAL: Supports all types of device access. * ename:VK_IMAGE_LAYOUT_COLOR_ATTACHMENT_OPTIMAL: must: only be used as a color or resolve attachment in a sname:VkFramebuffer. This layout is valid only for image subresources of images created with the ename:VK_IMAGE_USAGE_COLOR_ATTACHMENT_BIT usage bit enabled. * ename:VK_IMAGE_LAYOUT_DEPTH_STENCIL_ATTACHMENT_OPTIMAL: must: only be used as a depth/stencil attachment in a sname:VkFramebuffer. This layout is valid only for image subresources of images created with the ename:VK_IMAGE_USAGE_DEPTH_STENCIL_ATTACHMENT_BIT usage bit enabled. * ename:VK_IMAGE_LAYOUT_DEPTH_STENCIL_READ_ONLY_OPTIMAL: must: only be used as a read-only depth/stencil attachment in a sname:VkFramebuffer and/or as a read-only image in a shader (which can: be read as a sampled image, combined image/sampler and/or input attachment). This layout is valid only for image subresources of images created with the ename:VK_IMAGE_USAGE_DEPTH_STENCIL_ATTACHMENT_BIT usage bit enabled. * ename:VK_IMAGE_LAYOUT_SHADER_READ_ONLY_OPTIMAL: must: only be used as a read-only image in a shader (which can: be read as a sampled image, combined image/sampler and/or input attachment). This layout is valid only for image subresources of images created with the ename:VK_IMAGE_USAGE_SAMPLED_BIT or ename:VK_IMAGE_USAGE_INPUT_ATTACHMENT_BIT usage bit enabled. * ename:VK_IMAGE_LAYOUT_TRANSFER_SRC_OPTIMAL: must: only be used as a source image of a transfer command (see the definition of &lt;&lt;synchronization-transfer,ename:VK_PIPELINE_STAGE_TRANSFER_BIT&gt;&gt;). This layout is valid only for image subresources of images created with the ename:VK_IMAGE_USAGE_TRANSFER_SRC_BIT usage bit enabled. * ename:VK_IMAGE_LAYOUT_TRANSFER_DST_OPTIMAL: must: only be used as a destination image of a transfer command. This layout is valid only for image subresources of images created with the ename:VK_IMAGE_USAGE_TRANSFER_DST_BIT usage bit enabled. ifdef::VK_KHR_swapchain[] include::../chapters/VK_KHR_swapchain/VkImageLayout_swapchain.txt[] endif::VK_KHR_swapchain[]
    /// </para>
    /// <para>
    /// For each mechanism of accessing an image in the API, there is a parameter or structure member that controls the image layout used to access the image. For transfer commands, this is a parameter to the command (see &lt;&lt;clears&gt;&gt; and &lt;&lt;copies&gt;&gt;). For use as a framebuffer attachment, this is a member in the substructures of the sname:VkRenderPassCreateInfo (see &lt;&lt;renderpass,Render Pass&gt;&gt;). For use in a descriptor set, this is a member in the sname:VkDescriptorImageInfo structure (see &lt;&lt;descriptorsets-updates&gt;&gt;). At the time that any command buffer command accessing an image executes on any queue, the layouts of the image subresources that are accessed must: all match the layout specified via the API controlling those accesses.
    /// </para>
    /// <para>
    /// The image layout of each image subresource must: be well-defined at each point in the image subresource's lifetime. This means that when performing a layout transition on the image subresource, the old layout value must: either equal the current layout of the image subresource (at the time the transition executes), or else be ename:VK_IMAGE_LAYOUT_UNDEFINED (implying that the contents of the image subresource need not be preserved). The new layout used in a transition mustnot: be ename:VK_IMAGE_LAYOUT_UNDEFINED or ename:VK_IMAGE_LAYOUT_PREINITIALIZED.
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
    /// specifies the tiling arrangement of data in an image
    /// </para>
    /// <para>
    /// The tiling arrangement of data elements in an image is specified by slink:VkImageCreateInfo::pname:tiling, which must: be one of the values
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
    /// The basic dimensionality of an image is specified by slink:VkImageCreateInfo::pname:imageType, which must: be one of the values
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
    /// Image view types
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
    /// type of index buffer indices
    /// </para>
    /// <para>
    /// For more information, see:
    /// </para>
    /// <para>
    /// * The reference page for flink:vkCmdBindIndexBuffer, where this interface is defined. * The See Also section for other reference pages using this type. * The Vulkan Specification.
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
    /// framebuffer logical operations
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
    /// supported physical device types
    /// </para>
    /// <para>
    /// * ename:VK_PHYSICAL_DEVICE_TYPE_OTHER The device does not match any other available types. * ename:VK_PHYSICAL_DEVICE_TYPE_INTEGRATED_GPU The device is typically one embedded in or tightly coupled with the host. * ename:VK_PHYSICAL_DEVICE_TYPE_DISCRETE_GPU The device is typically a separate processor connected to the host via an interlink. * ename:VK_PHYSICAL_DEVICE_TYPE_VIRTUAL_GPU The device is typically a virtual node in a virtualization environment. * ename:VK_PHYSICAL_DEVICE_TYPE_CPU The device is typically running on the same processors as the host.
    /// </para>
    /// <para>
    /// The physical device type is advertised for informational purposes only, and does not directly affect the operation of the system. However, the device type may: correlate with other advertised properties or capabilities of the system, such as how many memory heaps there are.
    /// </para>
    /// </summary>
	public enum PhysicalDeviceType
	{
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		Other = 0,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		IntegratedGpu = 1,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		DiscreteGpu = 2,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		VirtualGpu = 3,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		Cpu = 4,
	}

    /// <summary>
    /// <para>
    /// specify the bind point of a pipeline object to a command buffer
    /// </para>
    /// <para>
    /// For more information, see:
    /// </para>
    /// <para>
    /// * The reference page for flink:vkCmdBindPipeline, where this interface is defined. * The See Also section for other reference pages using this type. * The Vulkan Specification.
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
    /// Encode pipeline cache version
    /// </para>
    /// <para>
    /// A consumer of the pipeline cache should use the cache version to interpret the remainder of the cache header.
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
    /// control polygon rasterization mode
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
    /// -
    /// </para>
    /// </summary>
	public enum PresentMode
	{
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		Immediate = 0,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		Mailbox = 1,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		Fifo = 2,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		FifoRelaxed = 3,
	}

    /// <summary>
    /// <para>
    /// supported primitive topologies
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
    /// specify the type of queries managed by a query pool
    /// </para>
    /// <para>
    /// For more information, see:
    /// </para>
    /// <para>
    /// * The reference page for slink:VkQueryPoolCreateInfo, where this interface is defined. * The See Also section for other reference pages using this type. * The Vulkan Specification.
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
    /// Vulkan command return codes
    /// </para>
    /// <para>
    /// While the core Vulkan API is not designed to capture incorrect usage, some circumstances still require return codes. Commands in Vulkan return their status via return codes that are in one of two categories:
    /// </para>
    /// <para>
    /// * Successful completion codes are returned when a command needs to communicate success or status information. All successful completion codes are non-negative values. * Run time error codes are returned when a command needs to communicate a failure that could only be detected at run time. All run time error codes are negative values.
    /// </para>
    /// <para>
    /// .Success codes * ename:VK_SUCCESS Command successfully completed * ename:VK_NOT_READY A fence or query has not yet completed * ename:VK_TIMEOUT A wait operation has not completed in the specified time * ename:VK_EVENT_SET An event is signaled * ename:VK_EVENT_RESET An event is unsignaled * ename:VK_INCOMPLETE A return array was too small for the result ifdef::VK_KHR_swapchain[] include::../chapters/VK_KHR_swapchain/VkResultSuccessDescriptions_swapchain.txt[] endif::VK_KHR_swapchain[]
    /// </para>
    /// <para>
    /// .Error codes * ename:VK_ERROR_OUT_OF_HOST_MEMORY A host memory allocation has failed. * ename:VK_ERROR_OUT_OF_DEVICE_MEMORY A device memory allocation has failed. * ename:VK_ERROR_INITIALIZATION_FAILED Initialization of an object could not be completed for implementation-specific reasons. * ename:VK_ERROR_DEVICE_LOST The logical or physical device has been lost. See &lt;&lt;devsandqueues-lost-device,Lost Device&gt;&gt; * ename:VK_ERROR_MEMORY_MAP_FAILED Mapping of a memory object has failed. * ename:VK_ERROR_LAYER_NOT_PRESENT A requested layer is not present or could not be loaded. * ename:VK_ERROR_EXTENSION_NOT_PRESENT A requested extension is not supported. * ename:VK_ERROR_FEATURE_NOT_PRESENT A requested feature is not supported. * ename:VK_ERROR_INCOMPATIBLE_DRIVER The requested version of Vulkan is not supported by the driver or is otherwise incompatible for implementation-specific reasons. * ename:VK_ERROR_TOO_MANY_OBJECTS Too many objects of the type have already been created. * ename:VK_ERROR_FORMAT_NOT_SUPPORTED A requested format is not supported on this device. * ename:VK_ERROR_FRAGMENTED_POOL A requested pool allocation has failed due to fragmentation of the pool's memory. ifdef::VK_KHR_surface[] include::../chapters/VK_KHR_surface/VkResultErrorDescriptions_surface.txt[] endif::VK_KHR_surface[] ifdef::VK_KHR_swapchain[] include::../chapters/VK_KHR_swapchain/VkResultErrorDescriptions_swapchain.txt[] endif::VK_KHR_swapchain[] ifdef::VK_KHR_display_swapchain[] include::../chapters/VK_KHR_display_swapchain/VkResultErrorDescriptions_display_swapchain.txt[] endif::VK_KHR_display_swapchain[] ifdef::VK_NV_glsl_shader[] * ename:VK_ERROR_INVALID_SHADER_NV One or more shaders failed to compile or link. More details are reported back to the application via pname:VK_EXT_debug_report if enabled. endif::VK_NV_glsl_shader[]
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
    /// specify behavior of sampling with texture coordinates outside an image
    /// </para>
    /// <para>
    /// For more information, see:
    /// </para>
    /// <para>
    /// * The reference page for slink:VkSamplerCreateInfo, where this interface is defined. * The See Also section for other reference pages using this type. * The Vulkan Specification.
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
    /// specify mipmap mode used for texture lookups
    /// </para>
    /// <para>
    /// For more information, see:
    /// </para>
    /// <para>
    /// * The reference page for slink:VkSamplerCreateInfo, where this interface is defined. * The See Also section for other reference pages using this type. * The Vulkan Specification.
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
    /// Buffer and image sharing modes
    /// </para>
    /// <para>
    /// * ename:VK_SHARING_MODE_EXCLUSIVE specifies that access to any range or image subresource of the object will be exclusive to a single queue family at a time. * ename:VK_SHARING_MODE_CONCURRENT specifies that concurrent access to any range or image subresource of the object from multiple queue families is supported.
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
		/// -
		/// </para>
		/// </summary>
		Exclusive = 0,
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		Concurrent = 1,
	}

    /// <summary>
    /// <para>
    /// stencil comparison function
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
    /// Vulkan structure types (pname:stype)
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
		DebugReportValidationFlags = 1000011002,
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
    /// specify how commands in the first subpass of a render pass are provided
    /// </para>
    /// <para>
    /// For more information, see:
    /// </para>
    /// <para>
    /// * The reference page for flink:vkCmdBeginRenderPass, where this interface is defined. * The See Also section for other reference pages using this type. * The Vulkan Specification.
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
    /// specify rate at which vertex attributes are pulled from buffers
    /// </para>
    /// <para>
    /// For more information, see:
    /// </para>
    /// <para>
    /// * The reference page for slink:VkVertexInputBindingDescription, where this interface is defined. * The See Also section for other reference pages using this type. * The Vulkan Specification.
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