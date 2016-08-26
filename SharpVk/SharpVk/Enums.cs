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
    /// -
    /// </summary>
	[Flags]
	public enum AccessFlags
	{
	    /// <summary>
	    /// -
	    /// </summary>
		None = 0,
	    /// <summary>
	    /// -
	    /// </summary>
		IndirectCommandRead = 1 << 0,
	    /// <summary>
	    /// -
	    /// </summary>
		IndexRead = 1 << 1,
	    /// <summary>
	    /// -
	    /// </summary>
		VertexAttributeRead = 1 << 2,
	    /// <summary>
	    /// -
	    /// </summary>
		UniformRead = 1 << 3,
	    /// <summary>
	    /// -
	    /// </summary>
		InputAttachmentRead = 1 << 4,
	    /// <summary>
	    /// -
	    /// </summary>
		ShaderRead = 1 << 5,
	    /// <summary>
	    /// -
	    /// </summary>
		ShaderWrite = 1 << 6,
	    /// <summary>
	    /// -
	    /// </summary>
		ColorAttachmentRead = 1 << 7,
	    /// <summary>
	    /// -
	    /// </summary>
		ColorAttachmentWrite = 1 << 8,
	    /// <summary>
	    /// -
	    /// </summary>
		DepthStencilAttachmentRead = 1 << 9,
	    /// <summary>
	    /// -
	    /// </summary>
		DepthStencilAttachmentWrite = 1 << 10,
	    /// <summary>
	    /// -
	    /// </summary>
		TransferRead = 1 << 11,
	    /// <summary>
	    /// -
	    /// </summary>
		TransferWrite = 1 << 12,
	    /// <summary>
	    /// -
	    /// </summary>
		HostRead = 1 << 13,
	    /// <summary>
	    /// -
	    /// </summary>
		HostWrite = 1 << 14,
	    /// <summary>
	    /// -
	    /// </summary>
		MemoryRead = 1 << 15,
	    /// <summary>
	    /// -
	    /// </summary>
		MemoryWrite = 1 << 16,
	}

    /// <summary>
    /// -
    /// </summary>
	[Flags]
	public enum AndroidSurfaceCreateFlags
	{
	    /// <summary>
	    /// -
	    /// </summary>
		None = 0,
	}

    /// <summary>
    /// -
    /// </summary>
	[Flags]
	public enum AttachmentDescriptionFlags
	{
	    /// <summary>
	    /// -
	    /// </summary>
		None = 0,
	    /// <summary>
	    /// -
	    /// </summary>
		MayAlias = 1 << 0,
	}

    /// <summary>
    /// -
    /// </summary>
	[Flags]
	public enum BufferCreateFlags
	{
	    /// <summary>
	    /// -
	    /// </summary>
		None = 0,
	    /// <summary>
	    /// -
	    /// </summary>
		SparseBinding = 1 << 0,
	    /// <summary>
	    /// -
	    /// </summary>
		SparseResidency = 1 << 1,
	    /// <summary>
	    /// -
	    /// </summary>
		SparseAliased = 1 << 2,
	}

    /// <summary>
    /// -
    /// </summary>
	[Flags]
	public enum BufferUsageFlags
	{
	    /// <summary>
	    /// -
	    /// </summary>
		None = 0,
	    /// <summary>
	    /// -
	    /// </summary>
		TransferSource = 1 << 0,
	    /// <summary>
	    /// -
	    /// </summary>
		TransferDestination = 1 << 1,
	    /// <summary>
	    /// -
	    /// </summary>
		UniformTexelBuffer = 1 << 2,
	    /// <summary>
	    /// -
	    /// </summary>
		StorageTexelBuffer = 1 << 3,
	    /// <summary>
	    /// -
	    /// </summary>
		UniformBuffer = 1 << 4,
	    /// <summary>
	    /// -
	    /// </summary>
		StorageBuffer = 1 << 5,
	    /// <summary>
	    /// -
	    /// </summary>
		IndexBuffer = 1 << 6,
	    /// <summary>
	    /// -
	    /// </summary>
		VertexBuffer = 1 << 7,
	    /// <summary>
	    /// -
	    /// </summary>
		IndirectBuffer = 1 << 8,
	}

    /// <summary>
    /// -
    /// </summary>
	[Flags]
	public enum BufferViewCreateFlags
	{
	    /// <summary>
	    /// -
	    /// </summary>
		None = 0,
	}

    /// <summary>
    /// -
    /// </summary>
	[Flags]
	public enum ColorComponentFlags
	{
	    /// <summary>
	    /// -
	    /// </summary>
		None = 0,
	    /// <summary>
	    /// -
	    /// </summary>
		R = 1 << 0,
	    /// <summary>
	    /// -
	    /// </summary>
		G = 1 << 1,
	    /// <summary>
	    /// -
	    /// </summary>
		B = 1 << 2,
	    /// <summary>
	    /// -
	    /// </summary>
		A = 1 << 3,
	}

    /// <summary>
    /// -
    /// </summary>
	[Flags]
	public enum CommandBufferResetFlags
	{
	    /// <summary>
	    /// -
	    /// </summary>
		None = 0,
	    /// <summary>
	    /// -
	    /// </summary>
		ReleaseResources = 1 << 0,
	}

    /// <summary>
    /// -
    /// </summary>
	[Flags]
	public enum CommandBufferUsageFlags
	{
	    /// <summary>
	    /// -
	    /// </summary>
		None = 0,
	    /// <summary>
	    /// -
	    /// </summary>
		OneTimeSubmit = 1 << 0,
	    /// <summary>
	    /// -
	    /// </summary>
		RenderPassContinue = 1 << 1,
	    /// <summary>
	    /// -
	    /// </summary>
		SimultaneousUse = 1 << 2,
	}

    /// <summary>
    /// -
    /// </summary>
	[Flags]
	public enum CommandPoolCreateFlags
	{
	    /// <summary>
	    /// -
	    /// </summary>
		None = 0,
	    /// <summary>
	    /// -
	    /// </summary>
		Transient = 1 << 0,
	    /// <summary>
	    /// -
	    /// </summary>
		ResetCommandBuffer = 1 << 1,
	}

    /// <summary>
    /// -
    /// </summary>
	[Flags]
	public enum CommandPoolResetFlags
	{
	    /// <summary>
	    /// -
	    /// </summary>
		None = 0,
	    /// <summary>
	    /// -
	    /// </summary>
		ReleaseResources = 1 << 0,
	}

    /// <summary>
    /// -
    /// </summary>
	[Flags]
	public enum CompositeAlphaFlags
	{
	    /// <summary>
	    /// -
	    /// </summary>
		None = 0,
	    /// <summary>
	    /// -
	    /// </summary>
		Opaque = 1 << 0,
	    /// <summary>
	    /// -
	    /// </summary>
		PreMultiplied = 1 << 1,
	    /// <summary>
	    /// -
	    /// </summary>
		PostMultiplied = 1 << 2,
	    /// <summary>
	    /// -
	    /// </summary>
		Inherit = 1 << 3,
	}

    /// <summary>
    /// -
    /// </summary>
	[Flags]
	public enum CullModeFlags
	{
	    /// <summary>
	    /// -
	    /// </summary>
		None = 0,
	    /// <summary>
	    /// -
	    /// </summary>
		Front = 1 << 0,
	    /// <summary>
	    /// -
	    /// </summary>
		Back = 1 << 1,
	    /// <summary>
	    /// -
	    /// </summary>
		FrontAndBack = 0x00000003,
	}

    /// <summary>
    /// -
    /// </summary>
	[Flags]
	public enum DebugReportFlags
	{
	    /// <summary>
	    /// -
	    /// </summary>
		None = 0,
	    /// <summary>
	    /// -
	    /// </summary>
		Information = 1 << 0,
	    /// <summary>
	    /// -
	    /// </summary>
		Warning = 1 << 1,
	    /// <summary>
	    /// -
	    /// </summary>
		PerformanceWarning = 1 << 2,
	    /// <summary>
	    /// -
	    /// </summary>
		Error = 1 << 3,
	    /// <summary>
	    /// -
	    /// </summary>
		Debug = 1 << 4,
	}

    /// <summary>
    /// -
    /// </summary>
	[Flags]
	public enum DependencyFlags
	{
	    /// <summary>
	    /// -
	    /// </summary>
		None = 0,
	    /// <summary>
	    /// -
	    /// </summary>
		ByRegion = 1 << 0,
	}

    /// <summary>
    /// -
    /// </summary>
	[Flags]
	public enum DescriptorPoolCreateFlags
	{
	    /// <summary>
	    /// -
	    /// </summary>
		None = 0,
	    /// <summary>
	    /// -
	    /// </summary>
		FreeDescriptorSet = 1 << 0,
	}

    /// <summary>
    /// -
    /// </summary>
	[Flags]
	public enum DescriptorPoolResetFlags
	{
	    /// <summary>
	    /// -
	    /// </summary>
		None = 0,
	}

    /// <summary>
    /// -
    /// </summary>
	[Flags]
	public enum DescriptorSetLayoutCreateFlags
	{
	    /// <summary>
	    /// -
	    /// </summary>
		None = 0,
	}

    /// <summary>
    /// -
    /// </summary>
	[Flags]
	public enum DeviceCreateFlags
	{
	    /// <summary>
	    /// -
	    /// </summary>
		None = 0,
	}

    /// <summary>
    /// -
    /// </summary>
	[Flags]
	public enum DeviceQueueCreateFlags
	{
	    /// <summary>
	    /// -
	    /// </summary>
		None = 0,
	}

    /// <summary>
    /// -
    /// </summary>
	[Flags]
	public enum DisplayModeCreateFlags
	{
	    /// <summary>
	    /// -
	    /// </summary>
		None = 0,
	}

    /// <summary>
    /// -
    /// </summary>
	[Flags]
	public enum DisplayPlaneAlphaFlags
	{
	    /// <summary>
	    /// -
	    /// </summary>
		None = 0,
	    /// <summary>
	    /// -
	    /// </summary>
		Opaque = 1 << 0,
	    /// <summary>
	    /// -
	    /// </summary>
		Global = 1 << 1,
	    /// <summary>
	    /// -
	    /// </summary>
		PerPixel = 1 << 2,
	    /// <summary>
	    /// -
	    /// </summary>
		PerPixelPremultiplied = 1 << 3,
	}

    /// <summary>
    /// -
    /// </summary>
	[Flags]
	public enum DisplaySurfaceCreateFlags
	{
	    /// <summary>
	    /// -
	    /// </summary>
		None = 0,
	}

    /// <summary>
    /// -
    /// </summary>
	[Flags]
	public enum EventCreateFlags
	{
	    /// <summary>
	    /// -
	    /// </summary>
		None = 0,
	}

    /// <summary>
    /// -
    /// </summary>
	[Flags]
	public enum FenceCreateFlags
	{
	    /// <summary>
	    /// -
	    /// </summary>
		None = 0,
	    /// <summary>
	    /// -
	    /// </summary>
		Signaled = 1 << 0,
	}

    /// <summary>
    /// -
    /// </summary>
	[Flags]
	public enum FormatFeatureFlags
	{
	    /// <summary>
	    /// -
	    /// </summary>
		None = 0,
	    /// <summary>
	    /// -
	    /// </summary>
		SampledImage = 1 << 0,
	    /// <summary>
	    /// -
	    /// </summary>
		StorageImage = 1 << 1,
	    /// <summary>
	    /// -
	    /// </summary>
		StorageImageAtomic = 1 << 2,
	    /// <summary>
	    /// -
	    /// </summary>
		UniformTexelBuffer = 1 << 3,
	    /// <summary>
	    /// -
	    /// </summary>
		StorageTexelBuffer = 1 << 4,
	    /// <summary>
	    /// -
	    /// </summary>
		StorageTexelBufferAtomic = 1 << 5,
	    /// <summary>
	    /// -
	    /// </summary>
		VertexBuffer = 1 << 6,
	    /// <summary>
	    /// -
	    /// </summary>
		ColorAttachment = 1 << 7,
	    /// <summary>
	    /// -
	    /// </summary>
		ColorAttachmentBlend = 1 << 8,
	    /// <summary>
	    /// -
	    /// </summary>
		DepthStencilAttachment = 1 << 9,
	    /// <summary>
	    /// -
	    /// </summary>
		BlitSource = 1 << 10,
	    /// <summary>
	    /// -
	    /// </summary>
		BlitDestination = 1 << 11,
	    /// <summary>
	    /// -
	    /// </summary>
		SampledImageFilterLinear = 1 << 12,
	    /// <summary>
	    /// -
	    /// </summary>
		SampledImageFilterCubicBitImg = 13,
	}

    /// <summary>
    /// -
    /// </summary>
	[Flags]
	public enum FramebufferCreateFlags
	{
	    /// <summary>
	    /// -
	    /// </summary>
		None = 0,
	}

    /// <summary>
    /// -
    /// </summary>
	[Flags]
	public enum ImageAspectFlags
	{
	    /// <summary>
	    /// -
	    /// </summary>
		None = 0,
	    /// <summary>
	    /// -
	    /// </summary>
		Color = 1 << 0,
	    /// <summary>
	    /// -
	    /// </summary>
		Depth = 1 << 1,
	    /// <summary>
	    /// -
	    /// </summary>
		Stencil = 1 << 2,
	    /// <summary>
	    /// -
	    /// </summary>
		Metadata = 1 << 3,
	}

    /// <summary>
    /// -
    /// </summary>
	[Flags]
	public enum ImageCreateFlags
	{
	    /// <summary>
	    /// -
	    /// </summary>
		None = 0,
	    /// <summary>
	    /// -
	    /// </summary>
		SparseBinding = 1 << 0,
	    /// <summary>
	    /// -
	    /// </summary>
		SparseResidency = 1 << 1,
	    /// <summary>
	    /// -
	    /// </summary>
		SparseAliased = 1 << 2,
	    /// <summary>
	    /// -
	    /// </summary>
		MutableFormat = 1 << 3,
	    /// <summary>
	    /// -
	    /// </summary>
		CubeCompatible = 1 << 4,
	}

    /// <summary>
    /// -
    /// </summary>
	[Flags]
	public enum ImageUsageFlags
	{
	    /// <summary>
	    /// -
	    /// </summary>
		None = 0,
	    /// <summary>
	    /// -
	    /// </summary>
		TransferSource = 1 << 0,
	    /// <summary>
	    /// -
	    /// </summary>
		TransferDestination = 1 << 1,
	    /// <summary>
	    /// -
	    /// </summary>
		Sampled = 1 << 2,
	    /// <summary>
	    /// -
	    /// </summary>
		Storage = 1 << 3,
	    /// <summary>
	    /// -
	    /// </summary>
		ColorAttachment = 1 << 4,
	    /// <summary>
	    /// -
	    /// </summary>
		DepthStencilAttachment = 1 << 5,
	    /// <summary>
	    /// -
	    /// </summary>
		TransientAttachment = 1 << 6,
	    /// <summary>
	    /// -
	    /// </summary>
		InputAttachment = 1 << 7,
	}

    /// <summary>
    /// -
    /// </summary>
	[Flags]
	public enum ImageViewCreateFlags
	{
	    /// <summary>
	    /// -
	    /// </summary>
		None = 0,
	}

    /// <summary>
    /// -
    /// </summary>
	[Flags]
	public enum InstanceCreateFlags
	{
	    /// <summary>
	    /// -
	    /// </summary>
		None = 0,
	}

    /// <summary>
    /// -
    /// </summary>
	[Flags]
	public enum MemoryHeapFlags
	{
	    /// <summary>
	    /// -
	    /// </summary>
		None = 0,
	    /// <summary>
	    /// -
	    /// </summary>
		DeviceLocal = 1 << 0,
	}

    /// <summary>
    /// -
    /// </summary>
	[Flags]
	public enum MemoryMapFlags
	{
	    /// <summary>
	    /// -
	    /// </summary>
		None = 0,
	}

    /// <summary>
    /// -
    /// </summary>
	[Flags]
	public enum MemoryPropertyFlags
	{
	    /// <summary>
	    /// -
	    /// </summary>
		None = 0,
	    /// <summary>
	    /// -
	    /// </summary>
		DeviceLocal = 1 << 0,
	    /// <summary>
	    /// -
	    /// </summary>
		HostVisible = 1 << 1,
	    /// <summary>
	    /// -
	    /// </summary>
		HostCoherent = 1 << 2,
	    /// <summary>
	    /// -
	    /// </summary>
		HostCached = 1 << 3,
	    /// <summary>
	    /// -
	    /// </summary>
		LazilyAllocated = 1 << 4,
	}

    /// <summary>
    /// -
    /// </summary>
	[Flags]
	public enum MirSurfaceCreateFlags
	{
	    /// <summary>
	    /// -
	    /// </summary>
		None = 0,
	}

    /// <summary>
    /// -
    /// </summary>
	[Flags]
	public enum PipelineCacheCreateFlags
	{
	    /// <summary>
	    /// -
	    /// </summary>
		None = 0,
	}

    /// <summary>
    /// -
    /// </summary>
	[Flags]
	public enum PipelineColorBlendStateCreateFlags
	{
	    /// <summary>
	    /// -
	    /// </summary>
		None = 0,
	}

    /// <summary>
    /// -
    /// </summary>
	[Flags]
	public enum PipelineCreateFlags
	{
	    /// <summary>
	    /// -
	    /// </summary>
		None = 0,
	    /// <summary>
	    /// -
	    /// </summary>
		DisableOptimization = 1 << 0,
	    /// <summary>
	    /// -
	    /// </summary>
		AllowDerivatives = 1 << 1,
	    /// <summary>
	    /// -
	    /// </summary>
		Derivative = 1 << 2,
	}

    /// <summary>
    /// -
    /// </summary>
	[Flags]
	public enum PipelineDepthStencilStateCreateFlags
	{
	    /// <summary>
	    /// -
	    /// </summary>
		None = 0,
	}

    /// <summary>
    /// -
    /// </summary>
	[Flags]
	public enum PipelineDynamicStateCreateFlags
	{
	    /// <summary>
	    /// -
	    /// </summary>
		None = 0,
	}

    /// <summary>
    /// -
    /// </summary>
	[Flags]
	public enum PipelineInputAssemblyStateCreateFlags
	{
	    /// <summary>
	    /// -
	    /// </summary>
		None = 0,
	}

    /// <summary>
    /// -
    /// </summary>
	[Flags]
	public enum PipelineLayoutCreateFlags
	{
	    /// <summary>
	    /// -
	    /// </summary>
		None = 0,
	}

    /// <summary>
    /// -
    /// </summary>
	[Flags]
	public enum PipelineMultisampleStateCreateFlags
	{
	    /// <summary>
	    /// -
	    /// </summary>
		None = 0,
	}

    /// <summary>
    /// -
    /// </summary>
	[Flags]
	public enum PipelineRasterizationStateCreateFlags
	{
	    /// <summary>
	    /// -
	    /// </summary>
		None = 0,
	}

    /// <summary>
    /// -
    /// </summary>
	[Flags]
	public enum PipelineShaderStageCreateFlags
	{
	    /// <summary>
	    /// -
	    /// </summary>
		None = 0,
	}

    /// <summary>
    /// -
    /// </summary>
	[Flags]
	public enum PipelineStageFlags
	{
	    /// <summary>
	    /// -
	    /// </summary>
		None = 0,
	    /// <summary>
	    /// -
	    /// </summary>
		TopOfPipe = 1 << 0,
	    /// <summary>
	    /// -
	    /// </summary>
		DrawIndirect = 1 << 1,
	    /// <summary>
	    /// -
	    /// </summary>
		VertexInput = 1 << 2,
	    /// <summary>
	    /// -
	    /// </summary>
		VertexShader = 1 << 3,
	    /// <summary>
	    /// -
	    /// </summary>
		TessellationControlShader = 1 << 4,
	    /// <summary>
	    /// -
	    /// </summary>
		TessellationEvaluationShader = 1 << 5,
	    /// <summary>
	    /// -
	    /// </summary>
		GeometryShader = 1 << 6,
	    /// <summary>
	    /// -
	    /// </summary>
		FragmentShader = 1 << 7,
	    /// <summary>
	    /// -
	    /// </summary>
		EarlyFragmentTests = 1 << 8,
	    /// <summary>
	    /// -
	    /// </summary>
		LateFragmentTests = 1 << 9,
	    /// <summary>
	    /// -
	    /// </summary>
		ColorAttachmentOutput = 1 << 10,
	    /// <summary>
	    /// -
	    /// </summary>
		ComputeShader = 1 << 11,
	    /// <summary>
	    /// -
	    /// </summary>
		Transfer = 1 << 12,
	    /// <summary>
	    /// -
	    /// </summary>
		BottomOfPipe = 1 << 13,
	    /// <summary>
	    /// -
	    /// </summary>
		Host = 1 << 14,
	    /// <summary>
	    /// -
	    /// </summary>
		AllGraphics = 1 << 15,
	    /// <summary>
	    /// -
	    /// </summary>
		AllCommands = 1 << 16,
	}

    /// <summary>
    /// -
    /// </summary>
	[Flags]
	public enum PipelineTessellationStateCreateFlags
	{
	    /// <summary>
	    /// -
	    /// </summary>
		None = 0,
	}

    /// <summary>
    /// -
    /// </summary>
	[Flags]
	public enum PipelineVertexInputStateCreateFlags
	{
	    /// <summary>
	    /// -
	    /// </summary>
		None = 0,
	}

    /// <summary>
    /// -
    /// </summary>
	[Flags]
	public enum PipelineViewportStateCreateFlags
	{
	    /// <summary>
	    /// -
	    /// </summary>
		None = 0,
	}

    /// <summary>
    /// -
    /// </summary>
	[Flags]
	public enum QueryControlFlags
	{
	    /// <summary>
	    /// -
	    /// </summary>
		None = 0,
	    /// <summary>
	    /// -
	    /// </summary>
		Precise = 1 << 0,
	}

    /// <summary>
    /// -
    /// </summary>
	[Flags]
	public enum QueryPipelineStatisticFlags
	{
	    /// <summary>
	    /// -
	    /// </summary>
		None = 0,
	    /// <summary>
	    /// -
	    /// </summary>
		InputAssemblyVertices = 1 << 0,
	    /// <summary>
	    /// -
	    /// </summary>
		InputAssemblyPrimitives = 1 << 1,
	    /// <summary>
	    /// -
	    /// </summary>
		VertexShaderInvocations = 1 << 2,
	    /// <summary>
	    /// -
	    /// </summary>
		GeometryShaderInvocations = 1 << 3,
	    /// <summary>
	    /// -
	    /// </summary>
		GeometryShaderPrimitives = 1 << 4,
	    /// <summary>
	    /// -
	    /// </summary>
		ClippingInvocations = 1 << 5,
	    /// <summary>
	    /// -
	    /// </summary>
		ClippingPrimitives = 1 << 6,
	    /// <summary>
	    /// -
	    /// </summary>
		FragmentShaderInvocations = 1 << 7,
	    /// <summary>
	    /// -
	    /// </summary>
		TessellationControlShaderPatches = 1 << 8,
	    /// <summary>
	    /// -
	    /// </summary>
		TessellationEvaluationShaderInvocations = 1 << 9,
	    /// <summary>
	    /// -
	    /// </summary>
		ComputeShaderInvocations = 1 << 10,
	}

    /// <summary>
    /// -
    /// </summary>
	[Flags]
	public enum QueryPoolCreateFlags
	{
	    /// <summary>
	    /// -
	    /// </summary>
		None = 0,
	}

    /// <summary>
    /// -
    /// </summary>
	[Flags]
	public enum QueryResultFlags
	{
	    /// <summary>
	    /// -
	    /// </summary>
		None = 0,
	    /// <summary>
	    /// -
	    /// </summary>
		QueryResult64 = 1 << 0,
	    /// <summary>
	    /// -
	    /// </summary>
		Wait = 1 << 1,
	    /// <summary>
	    /// -
	    /// </summary>
		WithAvailability = 1 << 2,
	    /// <summary>
	    /// -
	    /// </summary>
		Partial = 1 << 3,
	}

    /// <summary>
    /// -
    /// </summary>
	[Flags]
	public enum QueueFlags
	{
	    /// <summary>
	    /// -
	    /// </summary>
		None = 0,
	    /// <summary>
	    /// -
	    /// </summary>
		Graphics = 1 << 0,
	    /// <summary>
	    /// -
	    /// </summary>
		Compute = 1 << 1,
	    /// <summary>
	    /// -
	    /// </summary>
		Transfer = 1 << 2,
	    /// <summary>
	    /// -
	    /// </summary>
		SparseBinding = 1 << 3,
	}

    /// <summary>
    /// -
    /// </summary>
	[Flags]
	public enum RenderPassCreateFlags
	{
	    /// <summary>
	    /// -
	    /// </summary>
		None = 0,
	}

    /// <summary>
    /// -
    /// </summary>
	[Flags]
	public enum SampleCountFlags
	{
	    /// <summary>
	    /// -
	    /// </summary>
		None = 0,
	    /// <summary>
	    /// -
	    /// </summary>
		SampleCount1 = 1 << 0,
	    /// <summary>
	    /// -
	    /// </summary>
		SampleCount2 = 1 << 1,
	    /// <summary>
	    /// -
	    /// </summary>
		SampleCount4 = 1 << 2,
	    /// <summary>
	    /// -
	    /// </summary>
		SampleCount8 = 1 << 3,
	    /// <summary>
	    /// -
	    /// </summary>
		SampleCount16 = 1 << 4,
	    /// <summary>
	    /// -
	    /// </summary>
		SampleCount32 = 1 << 5,
	    /// <summary>
	    /// -
	    /// </summary>
		SampleCount64 = 1 << 6,
	}

    /// <summary>
    /// -
    /// </summary>
	[Flags]
	public enum SamplerCreateFlags
	{
	    /// <summary>
	    /// -
	    /// </summary>
		None = 0,
	}

    /// <summary>
    /// -
    /// </summary>
	[Flags]
	public enum SemaphoreCreateFlags
	{
	    /// <summary>
	    /// -
	    /// </summary>
		None = 0,
	}

    /// <summary>
    /// -
    /// </summary>
	[Flags]
	public enum ShaderModuleCreateFlags
	{
	    /// <summary>
	    /// -
	    /// </summary>
		None = 0,
	}

    /// <summary>
    /// -
    /// </summary>
	[Flags]
	public enum ShaderStageFlags
	{
	    /// <summary>
	    /// -
	    /// </summary>
		None = 0,
	    /// <summary>
	    /// -
	    /// </summary>
		Vertex = 1 << 0,
	    /// <summary>
	    /// -
	    /// </summary>
		TessellationControl = 1 << 1,
	    /// <summary>
	    /// -
	    /// </summary>
		TessellationEvaluation = 1 << 2,
	    /// <summary>
	    /// -
	    /// </summary>
		Geometry = 1 << 3,
	    /// <summary>
	    /// -
	    /// </summary>
		Fragment = 1 << 4,
	    /// <summary>
	    /// -
	    /// </summary>
		Compute = 1 << 5,
	    /// <summary>
	    /// -
	    /// </summary>
		AllGraphics = 0x0000001F,
	    /// <summary>
	    /// -
	    /// </summary>
		All = 0x7FFFFFFF,
	}

    /// <summary>
    /// -
    /// </summary>
	[Flags]
	public enum SparseImageFormatFlags
	{
	    /// <summary>
	    /// -
	    /// </summary>
		None = 0,
	    /// <summary>
	    /// -
	    /// </summary>
		SingleMiptail = 1 << 0,
	    /// <summary>
	    /// -
	    /// </summary>
		AlignedMipSize = 1 << 1,
	    /// <summary>
	    /// -
	    /// </summary>
		NonstandardBlockSize = 1 << 2,
	}

    /// <summary>
    /// -
    /// </summary>
	[Flags]
	public enum SparseMemoryBindFlags
	{
	    /// <summary>
	    /// -
	    /// </summary>
		None = 0,
	    /// <summary>
	    /// -
	    /// </summary>
		Metadata = 1 << 0,
	}

    /// <summary>
    /// -
    /// </summary>
	[Flags]
	public enum StencilFaceFlags
	{
	    /// <summary>
	    /// -
	    /// </summary>
		None = 0,
	    /// <summary>
	    /// -
	    /// </summary>
		Front = 1 << 0,
	    /// <summary>
	    /// -
	    /// </summary>
		Back = 1 << 1,
	    /// <summary>
	    /// -
	    /// </summary>
		FrontAndBack = 0x00000003,
	}

    /// <summary>
    /// -
    /// </summary>
	[Flags]
	public enum SubpassDescriptionFlags
	{
	    /// <summary>
	    /// -
	    /// </summary>
		None = 0,
	}

    /// <summary>
    /// -
    /// </summary>
	[Flags]
	public enum SurfaceTransformFlags
	{
	    /// <summary>
	    /// -
	    /// </summary>
		None = 0,
	    /// <summary>
	    /// -
	    /// </summary>
		Identity = 1 << 0,
	    /// <summary>
	    /// -
	    /// </summary>
		Rotate90 = 1 << 1,
	    /// <summary>
	    /// -
	    /// </summary>
		Rotate180 = 1 << 2,
	    /// <summary>
	    /// -
	    /// </summary>
		Rotate270 = 1 << 3,
	    /// <summary>
	    /// -
	    /// </summary>
		HorizontalMirror = 1 << 4,
	    /// <summary>
	    /// -
	    /// </summary>
		HorizontalMirrorRotate90 = 1 << 5,
	    /// <summary>
	    /// -
	    /// </summary>
		HorizontalMirrorRotate180 = 1 << 6,
	    /// <summary>
	    /// -
	    /// </summary>
		HorizontalMirrorRotate270 = 1 << 7,
	    /// <summary>
	    /// -
	    /// </summary>
		Inherit = 1 << 8,
	}

    /// <summary>
    /// -
    /// </summary>
	[Flags]
	public enum SwapchainCreateFlags
	{
	    /// <summary>
	    /// -
	    /// </summary>
		None = 0,
	}

    /// <summary>
    /// -
    /// </summary>
	[Flags]
	public enum WaylandSurfaceCreateFlags
	{
	    /// <summary>
	    /// -
	    /// </summary>
		None = 0,
	}

    /// <summary>
    /// -
    /// </summary>
	[Flags]
	public enum Win32SurfaceCreateFlags
	{
	    /// <summary>
	    /// -
	    /// </summary>
		None = 0,
	}

    /// <summary>
    /// -
    /// </summary>
	[Flags]
	public enum XcbSurfaceCreateFlags
	{
	    /// <summary>
	    /// -
	    /// </summary>
		None = 0,
	}

    /// <summary>
    /// -
    /// </summary>
	[Flags]
	public enum XlibSurfaceCreateFlags
	{
	    /// <summary>
	    /// -
	    /// </summary>
		None = 0,
	}

    /// <summary>
    /// -
    /// </summary>
	public enum AttachmentLoadOp
	{
	    /// <summary>
	    /// -
	    /// </summary>
		Load = 0,
	    /// <summary>
	    /// -
	    /// </summary>
		Clear = 1,
	    /// <summary>
	    /// -
	    /// </summary>
		DontCare = 2,
	}

    /// <summary>
    /// -
    /// </summary>
	public enum AttachmentStoreOp
	{
	    /// <summary>
	    /// -
	    /// </summary>
		Store = 0,
	    /// <summary>
	    /// -
	    /// </summary>
		DontCare = 1,
	}

    /// <summary>
    /// -
    /// </summary>
	public enum BlendFactor
	{
	    /// <summary>
	    /// -
	    /// </summary>
		Zero = 0,
	    /// <summary>
	    /// -
	    /// </summary>
		One = 1,
	    /// <summary>
	    /// -
	    /// </summary>
		SourceColor = 2,
	    /// <summary>
	    /// -
	    /// </summary>
		OneMinusSourceColor = 3,
	    /// <summary>
	    /// -
	    /// </summary>
		DestinationColor = 4,
	    /// <summary>
	    /// -
	    /// </summary>
		OneMinusDestinationColor = 5,
	    /// <summary>
	    /// -
	    /// </summary>
		SourceAlpha = 6,
	    /// <summary>
	    /// -
	    /// </summary>
		OneMinusSourceAlpha = 7,
	    /// <summary>
	    /// -
	    /// </summary>
		DestinationAlpha = 8,
	    /// <summary>
	    /// -
	    /// </summary>
		OneMinusDestinationAlpha = 9,
	    /// <summary>
	    /// -
	    /// </summary>
		ConstantColor = 10,
	    /// <summary>
	    /// -
	    /// </summary>
		OneMinusConstantColor = 11,
	    /// <summary>
	    /// -
	    /// </summary>
		ConstantAlpha = 12,
	    /// <summary>
	    /// -
	    /// </summary>
		OneMinusConstantAlpha = 13,
	    /// <summary>
	    /// -
	    /// </summary>
		SourceAlphaSaturate = 14,
	    /// <summary>
	    /// -
	    /// </summary>
		Src1Color = 15,
	    /// <summary>
	    /// -
	    /// </summary>
		OneMinusSrc1Color = 16,
	    /// <summary>
	    /// -
	    /// </summary>
		Src1Alpha = 17,
	    /// <summary>
	    /// -
	    /// </summary>
		OneMinusSrc1Alpha = 18,
	}

    /// <summary>
    /// -
    /// </summary>
	public enum BlendOp
	{
	    /// <summary>
	    /// -
	    /// </summary>
		Add = 0,
	    /// <summary>
	    /// -
	    /// </summary>
		Subtract = 1,
	    /// <summary>
	    /// -
	    /// </summary>
		ReverseSubtract = 2,
	    /// <summary>
	    /// -
	    /// </summary>
		Min = 3,
	    /// <summary>
	    /// -
	    /// </summary>
		Max = 4,
	}

    /// <summary>
    /// -
    /// </summary>
	public enum BorderColor
	{
	    /// <summary>
	    /// -
	    /// </summary>
		FloatTransparentBlack = 0,
	    /// <summary>
	    /// -
	    /// </summary>
		IntTransparentBlack = 1,
	    /// <summary>
	    /// -
	    /// </summary>
		FloatOpaqueBlack = 2,
	    /// <summary>
	    /// -
	    /// </summary>
		IntOpaqueBlack = 3,
	    /// <summary>
	    /// -
	    /// </summary>
		FloatOpaqueWhite = 4,
	    /// <summary>
	    /// -
	    /// </summary>
		IntOpaqueWhite = 5,
	}

    /// <summary>
    /// -
    /// </summary>
	public enum ColorSpace
	{
	    /// <summary>
	    /// -
	    /// </summary>
		SrgbNonlinear = 0,
	}

    /// <summary>
    /// -
    /// </summary>
	public enum CommandBufferLevel
	{
	    /// <summary>
	    /// -
	    /// </summary>
		Primary = 0,
	    /// <summary>
	    /// -
	    /// </summary>
		Secondary = 1,
	}

    /// <summary>
    /// -
    /// </summary>
	public enum CompareOp
	{
	    /// <summary>
	    /// -
	    /// </summary>
		Never = 0,
	    /// <summary>
	    /// -
	    /// </summary>
		Less = 1,
	    /// <summary>
	    /// -
	    /// </summary>
		Equal = 2,
	    /// <summary>
	    /// -
	    /// </summary>
		LessOrEqual = 3,
	    /// <summary>
	    /// -
	    /// </summary>
		Greater = 4,
	    /// <summary>
	    /// -
	    /// </summary>
		NotEqual = 5,
	    /// <summary>
	    /// -
	    /// </summary>
		GreaterOrEqual = 6,
	    /// <summary>
	    /// -
	    /// </summary>
		Always = 7,
	}

    /// <summary>
    /// -
    /// </summary>
	public enum ComponentSwizzle
	{
	    /// <summary>
	    /// -
	    /// </summary>
		Identity = 0,
	    /// <summary>
	    /// -
	    /// </summary>
		Zero = 1,
	    /// <summary>
	    /// -
	    /// </summary>
		One = 2,
	    /// <summary>
	    /// -
	    /// </summary>
		R = 3,
	    /// <summary>
	    /// -
	    /// </summary>
		G = 4,
	    /// <summary>
	    /// -
	    /// </summary>
		B = 5,
	    /// <summary>
	    /// -
	    /// </summary>
		A = 6,
	}

    /// <summary>
    /// -
    /// </summary>
	public enum DebugReportError
	{
	    /// <summary>
	    /// -
	    /// </summary>
		None = 0,
	    /// <summary>
	    /// -
	    /// </summary>
		CallbackRef = 1,
	}

    /// <summary>
    /// -
    /// </summary>
	public enum DebugReportObjectType
	{
	    /// <summary>
	    /// -
	    /// </summary>
		Unknown = 0,
	    /// <summary>
	    /// -
	    /// </summary>
		Instance = 1,
	    /// <summary>
	    /// -
	    /// </summary>
		PhysicalDevice = 2,
	    /// <summary>
	    /// -
	    /// </summary>
		Device = 3,
	    /// <summary>
	    /// -
	    /// </summary>
		Queue = 4,
	    /// <summary>
	    /// -
	    /// </summary>
		Semaphore = 5,
	    /// <summary>
	    /// -
	    /// </summary>
		CommandBuffer = 6,
	    /// <summary>
	    /// -
	    /// </summary>
		Fence = 7,
	    /// <summary>
	    /// -
	    /// </summary>
		DeviceMemory = 8,
	    /// <summary>
	    /// -
	    /// </summary>
		Buffer = 9,
	    /// <summary>
	    /// -
	    /// </summary>
		Image = 10,
	    /// <summary>
	    /// -
	    /// </summary>
		Event = 11,
	    /// <summary>
	    /// -
	    /// </summary>
		QueryPool = 12,
	    /// <summary>
	    /// -
	    /// </summary>
		BufferView = 13,
	    /// <summary>
	    /// -
	    /// </summary>
		ImageView = 14,
	    /// <summary>
	    /// -
	    /// </summary>
		ShaderModule = 15,
	    /// <summary>
	    /// -
	    /// </summary>
		PipelineCache = 16,
	    /// <summary>
	    /// -
	    /// </summary>
		PipelineLayout = 17,
	    /// <summary>
	    /// -
	    /// </summary>
		RenderPass = 18,
	    /// <summary>
	    /// -
	    /// </summary>
		Pipeline = 19,
	    /// <summary>
	    /// -
	    /// </summary>
		DescriptorSetLayout = 20,
	    /// <summary>
	    /// -
	    /// </summary>
		Sampler = 21,
	    /// <summary>
	    /// -
	    /// </summary>
		DescriptorPool = 22,
	    /// <summary>
	    /// -
	    /// </summary>
		DescriptorSet = 23,
	    /// <summary>
	    /// -
	    /// </summary>
		Framebuffer = 24,
	    /// <summary>
	    /// -
	    /// </summary>
		CommandPool = 25,
	    /// <summary>
	    /// -
	    /// </summary>
		SurfaceKhr = 26,
	    /// <summary>
	    /// -
	    /// </summary>
		SwapchainKhr = 27,
	    /// <summary>
	    /// -
	    /// </summary>
		DebugReport = 28,
	}

    /// <summary>
    /// -
    /// </summary>
	public enum DescriptorType
	{
	    /// <summary>
	    /// -
	    /// </summary>
		Sampler = 0,
	    /// <summary>
	    /// -
	    /// </summary>
		CombinedImageSampler = 1,
	    /// <summary>
	    /// -
	    /// </summary>
		SampledImage = 2,
	    /// <summary>
	    /// -
	    /// </summary>
		StorageImage = 3,
	    /// <summary>
	    /// -
	    /// </summary>
		UniformTexelBuffer = 4,
	    /// <summary>
	    /// -
	    /// </summary>
		StorageTexelBuffer = 5,
	    /// <summary>
	    /// -
	    /// </summary>
		UniformBuffer = 6,
	    /// <summary>
	    /// -
	    /// </summary>
		StorageBuffer = 7,
	    /// <summary>
	    /// -
	    /// </summary>
		UniformBufferDynamic = 8,
	    /// <summary>
	    /// -
	    /// </summary>
		StorageBufferDynamic = 9,
	    /// <summary>
	    /// -
	    /// </summary>
		InputAttachment = 10,
	}

    /// <summary>
    /// -
    /// </summary>
	public enum DynamicState
	{
	    /// <summary>
	    /// -
	    /// </summary>
		Viewport = 0,
	    /// <summary>
	    /// -
	    /// </summary>
		Scissor = 1,
	    /// <summary>
	    /// -
	    /// </summary>
		LineWidth = 2,
	    /// <summary>
	    /// -
	    /// </summary>
		DepthBias = 3,
	    /// <summary>
	    /// -
	    /// </summary>
		BlendConstants = 4,
	    /// <summary>
	    /// -
	    /// </summary>
		DepthBounds = 5,
	    /// <summary>
	    /// -
	    /// </summary>
		StencilCompareMask = 6,
	    /// <summary>
	    /// -
	    /// </summary>
		StencilWriteMask = 7,
	    /// <summary>
	    /// -
	    /// </summary>
		StencilReference = 8,
	}

    /// <summary>
    /// -
    /// </summary>
	public enum Filter
	{
	    /// <summary>
	    /// -
	    /// </summary>
		Nearest = 0,
	    /// <summary>
	    /// -
	    /// </summary>
		Linear = 1,
	    /// <summary>
	    /// -
	    /// </summary>
		CubicImg = 1000015000,
	}

    /// <summary>
    /// -
    /// </summary>
	public enum Format
	{
	    /// <summary>
	    /// -
	    /// </summary>
		Undefined = 0,
	    /// <summary>
	    /// -
	    /// </summary>
		R4g4UnormPack8 = 1,
	    /// <summary>
	    /// -
	    /// </summary>
		R4g4b4a4UnormPack16 = 2,
	    /// <summary>
	    /// -
	    /// </summary>
		B4g4r4a4UnormPack16 = 3,
	    /// <summary>
	    /// -
	    /// </summary>
		R5g6b5UnormPack16 = 4,
	    /// <summary>
	    /// -
	    /// </summary>
		B5g6r5UnormPack16 = 5,
	    /// <summary>
	    /// -
	    /// </summary>
		R5g5b5a1UnormPack16 = 6,
	    /// <summary>
	    /// -
	    /// </summary>
		B5g5r5a1UnormPack16 = 7,
	    /// <summary>
	    /// -
	    /// </summary>
		A1r5g5b5UnormPack16 = 8,
	    /// <summary>
	    /// -
	    /// </summary>
		R8Unorm = 9,
	    /// <summary>
	    /// -
	    /// </summary>
		R8Snorm = 10,
	    /// <summary>
	    /// -
	    /// </summary>
		R8Uscaled = 11,
	    /// <summary>
	    /// -
	    /// </summary>
		R8Sscaled = 12,
	    /// <summary>
	    /// -
	    /// </summary>
		R8Uint = 13,
	    /// <summary>
	    /// -
	    /// </summary>
		R8Sint = 14,
	    /// <summary>
	    /// -
	    /// </summary>
		R8Srgb = 15,
	    /// <summary>
	    /// -
	    /// </summary>
		R8g8Unorm = 16,
	    /// <summary>
	    /// -
	    /// </summary>
		R8g8Snorm = 17,
	    /// <summary>
	    /// -
	    /// </summary>
		R8g8Uscaled = 18,
	    /// <summary>
	    /// -
	    /// </summary>
		R8g8Sscaled = 19,
	    /// <summary>
	    /// -
	    /// </summary>
		R8g8Uint = 20,
	    /// <summary>
	    /// -
	    /// </summary>
		R8g8Sint = 21,
	    /// <summary>
	    /// -
	    /// </summary>
		R8g8Srgb = 22,
	    /// <summary>
	    /// -
	    /// </summary>
		R8g8b8Unorm = 23,
	    /// <summary>
	    /// -
	    /// </summary>
		R8g8b8Snorm = 24,
	    /// <summary>
	    /// -
	    /// </summary>
		R8g8b8Uscaled = 25,
	    /// <summary>
	    /// -
	    /// </summary>
		R8g8b8Sscaled = 26,
	    /// <summary>
	    /// -
	    /// </summary>
		R8g8b8Uint = 27,
	    /// <summary>
	    /// -
	    /// </summary>
		R8g8b8Sint = 28,
	    /// <summary>
	    /// -
	    /// </summary>
		R8g8b8Srgb = 29,
	    /// <summary>
	    /// -
	    /// </summary>
		B8g8r8Unorm = 30,
	    /// <summary>
	    /// -
	    /// </summary>
		B8g8r8Snorm = 31,
	    /// <summary>
	    /// -
	    /// </summary>
		B8g8r8Uscaled = 32,
	    /// <summary>
	    /// -
	    /// </summary>
		B8g8r8Sscaled = 33,
	    /// <summary>
	    /// -
	    /// </summary>
		B8g8r8Uint = 34,
	    /// <summary>
	    /// -
	    /// </summary>
		B8g8r8Sint = 35,
	    /// <summary>
	    /// -
	    /// </summary>
		B8g8r8Srgb = 36,
	    /// <summary>
	    /// -
	    /// </summary>
		R8g8b8a8Unorm = 37,
	    /// <summary>
	    /// -
	    /// </summary>
		R8g8b8a8Snorm = 38,
	    /// <summary>
	    /// -
	    /// </summary>
		R8g8b8a8Uscaled = 39,
	    /// <summary>
	    /// -
	    /// </summary>
		R8g8b8a8Sscaled = 40,
	    /// <summary>
	    /// -
	    /// </summary>
		R8g8b8a8Uint = 41,
	    /// <summary>
	    /// -
	    /// </summary>
		R8g8b8a8Sint = 42,
	    /// <summary>
	    /// -
	    /// </summary>
		R8g8b8a8Srgb = 43,
	    /// <summary>
	    /// -
	    /// </summary>
		B8g8r8a8Unorm = 44,
	    /// <summary>
	    /// -
	    /// </summary>
		B8g8r8a8Snorm = 45,
	    /// <summary>
	    /// -
	    /// </summary>
		B8g8r8a8Uscaled = 46,
	    /// <summary>
	    /// -
	    /// </summary>
		B8g8r8a8Sscaled = 47,
	    /// <summary>
	    /// -
	    /// </summary>
		B8g8r8a8Uint = 48,
	    /// <summary>
	    /// -
	    /// </summary>
		B8g8r8a8Sint = 49,
	    /// <summary>
	    /// -
	    /// </summary>
		B8g8r8a8Srgb = 50,
	    /// <summary>
	    /// -
	    /// </summary>
		A8b8g8r8UnormPack32 = 51,
	    /// <summary>
	    /// -
	    /// </summary>
		A8b8g8r8SnormPack32 = 52,
	    /// <summary>
	    /// -
	    /// </summary>
		A8b8g8r8UscaledPack32 = 53,
	    /// <summary>
	    /// -
	    /// </summary>
		A8b8g8r8SscaledPack32 = 54,
	    /// <summary>
	    /// -
	    /// </summary>
		A8b8g8r8UintPack32 = 55,
	    /// <summary>
	    /// -
	    /// </summary>
		A8b8g8r8SintPack32 = 56,
	    /// <summary>
	    /// -
	    /// </summary>
		A8b8g8r8SrgbPack32 = 57,
	    /// <summary>
	    /// -
	    /// </summary>
		A2r10g10b10UnormPack32 = 58,
	    /// <summary>
	    /// -
	    /// </summary>
		A2r10g10b10SnormPack32 = 59,
	    /// <summary>
	    /// -
	    /// </summary>
		A2r10g10b10UscaledPack32 = 60,
	    /// <summary>
	    /// -
	    /// </summary>
		A2r10g10b10SscaledPack32 = 61,
	    /// <summary>
	    /// -
	    /// </summary>
		A2r10g10b10UintPack32 = 62,
	    /// <summary>
	    /// -
	    /// </summary>
		A2r10g10b10SintPack32 = 63,
	    /// <summary>
	    /// -
	    /// </summary>
		A2b10g10r10UnormPack32 = 64,
	    /// <summary>
	    /// -
	    /// </summary>
		A2b10g10r10SnormPack32 = 65,
	    /// <summary>
	    /// -
	    /// </summary>
		A2b10g10r10UscaledPack32 = 66,
	    /// <summary>
	    /// -
	    /// </summary>
		A2b10g10r10SscaledPack32 = 67,
	    /// <summary>
	    /// -
	    /// </summary>
		A2b10g10r10UintPack32 = 68,
	    /// <summary>
	    /// -
	    /// </summary>
		A2b10g10r10SintPack32 = 69,
	    /// <summary>
	    /// -
	    /// </summary>
		R16Unorm = 70,
	    /// <summary>
	    /// -
	    /// </summary>
		R16Snorm = 71,
	    /// <summary>
	    /// -
	    /// </summary>
		R16Uscaled = 72,
	    /// <summary>
	    /// -
	    /// </summary>
		R16Sscaled = 73,
	    /// <summary>
	    /// -
	    /// </summary>
		R16Uint = 74,
	    /// <summary>
	    /// -
	    /// </summary>
		R16Sint = 75,
	    /// <summary>
	    /// -
	    /// </summary>
		R16Sfloat = 76,
	    /// <summary>
	    /// -
	    /// </summary>
		R16g16Unorm = 77,
	    /// <summary>
	    /// -
	    /// </summary>
		R16g16Snorm = 78,
	    /// <summary>
	    /// -
	    /// </summary>
		R16g16Uscaled = 79,
	    /// <summary>
	    /// -
	    /// </summary>
		R16g16Sscaled = 80,
	    /// <summary>
	    /// -
	    /// </summary>
		R16g16Uint = 81,
	    /// <summary>
	    /// -
	    /// </summary>
		R16g16Sint = 82,
	    /// <summary>
	    /// -
	    /// </summary>
		R16g16Sfloat = 83,
	    /// <summary>
	    /// -
	    /// </summary>
		R16g16b16Unorm = 84,
	    /// <summary>
	    /// -
	    /// </summary>
		R16g16b16Snorm = 85,
	    /// <summary>
	    /// -
	    /// </summary>
		R16g16b16Uscaled = 86,
	    /// <summary>
	    /// -
	    /// </summary>
		R16g16b16Sscaled = 87,
	    /// <summary>
	    /// -
	    /// </summary>
		R16g16b16Uint = 88,
	    /// <summary>
	    /// -
	    /// </summary>
		R16g16b16Sint = 89,
	    /// <summary>
	    /// -
	    /// </summary>
		R16g16b16Sfloat = 90,
	    /// <summary>
	    /// -
	    /// </summary>
		R16g16b16a16Unorm = 91,
	    /// <summary>
	    /// -
	    /// </summary>
		R16g16b16a16Snorm = 92,
	    /// <summary>
	    /// -
	    /// </summary>
		R16g16b16a16Uscaled = 93,
	    /// <summary>
	    /// -
	    /// </summary>
		R16g16b16a16Sscaled = 94,
	    /// <summary>
	    /// -
	    /// </summary>
		R16g16b16a16Uint = 95,
	    /// <summary>
	    /// -
	    /// </summary>
		R16g16b16a16Sint = 96,
	    /// <summary>
	    /// -
	    /// </summary>
		R16g16b16a16Sfloat = 97,
	    /// <summary>
	    /// -
	    /// </summary>
		R32Uint = 98,
	    /// <summary>
	    /// -
	    /// </summary>
		R32Sint = 99,
	    /// <summary>
	    /// -
	    /// </summary>
		R32Sfloat = 100,
	    /// <summary>
	    /// -
	    /// </summary>
		R32g32Uint = 101,
	    /// <summary>
	    /// -
	    /// </summary>
		R32g32Sint = 102,
	    /// <summary>
	    /// -
	    /// </summary>
		R32g32Sfloat = 103,
	    /// <summary>
	    /// -
	    /// </summary>
		R32g32b32Uint = 104,
	    /// <summary>
	    /// -
	    /// </summary>
		R32g32b32Sint = 105,
	    /// <summary>
	    /// -
	    /// </summary>
		R32g32b32Sfloat = 106,
	    /// <summary>
	    /// -
	    /// </summary>
		R32g32b32a32Uint = 107,
	    /// <summary>
	    /// -
	    /// </summary>
		R32g32b32a32Sint = 108,
	    /// <summary>
	    /// -
	    /// </summary>
		R32g32b32a32Sfloat = 109,
	    /// <summary>
	    /// -
	    /// </summary>
		R64Uint = 110,
	    /// <summary>
	    /// -
	    /// </summary>
		R64Sint = 111,
	    /// <summary>
	    /// -
	    /// </summary>
		R64Sfloat = 112,
	    /// <summary>
	    /// -
	    /// </summary>
		R64g64Uint = 113,
	    /// <summary>
	    /// -
	    /// </summary>
		R64g64Sint = 114,
	    /// <summary>
	    /// -
	    /// </summary>
		R64g64Sfloat = 115,
	    /// <summary>
	    /// -
	    /// </summary>
		R64g64b64Uint = 116,
	    /// <summary>
	    /// -
	    /// </summary>
		R64g64b64Sint = 117,
	    /// <summary>
	    /// -
	    /// </summary>
		R64g64b64Sfloat = 118,
	    /// <summary>
	    /// -
	    /// </summary>
		R64g64b64a64Uint = 119,
	    /// <summary>
	    /// -
	    /// </summary>
		R64g64b64a64Sint = 120,
	    /// <summary>
	    /// -
	    /// </summary>
		R64g64b64a64Sfloat = 121,
	    /// <summary>
	    /// -
	    /// </summary>
		B10g11r11UfloatPack32 = 122,
	    /// <summary>
	    /// -
	    /// </summary>
		E5b9g9r9UfloatPack32 = 123,
	    /// <summary>
	    /// -
	    /// </summary>
		D16Unorm = 124,
	    /// <summary>
	    /// -
	    /// </summary>
		X8D24UnormPack32 = 125,
	    /// <summary>
	    /// -
	    /// </summary>
		D32Sfloat = 126,
	    /// <summary>
	    /// -
	    /// </summary>
		S8Uint = 127,
	    /// <summary>
	    /// -
	    /// </summary>
		D16UnormS8Uint = 128,
	    /// <summary>
	    /// -
	    /// </summary>
		D24UnormS8Uint = 129,
	    /// <summary>
	    /// -
	    /// </summary>
		D32SfloatS8Uint = 130,
	    /// <summary>
	    /// -
	    /// </summary>
		Bc1RgbUnormBlock = 131,
	    /// <summary>
	    /// -
	    /// </summary>
		Bc1RgbSrgbBlock = 132,
	    /// <summary>
	    /// -
	    /// </summary>
		Bc1RgbaUnormBlock = 133,
	    /// <summary>
	    /// -
	    /// </summary>
		Bc1RgbaSrgbBlock = 134,
	    /// <summary>
	    /// -
	    /// </summary>
		Bc2UnormBlock = 135,
	    /// <summary>
	    /// -
	    /// </summary>
		Bc2SrgbBlock = 136,
	    /// <summary>
	    /// -
	    /// </summary>
		Bc3UnormBlock = 137,
	    /// <summary>
	    /// -
	    /// </summary>
		Bc3SrgbBlock = 138,
	    /// <summary>
	    /// -
	    /// </summary>
		Bc4UnormBlock = 139,
	    /// <summary>
	    /// -
	    /// </summary>
		Bc4SnormBlock = 140,
	    /// <summary>
	    /// -
	    /// </summary>
		Bc5UnormBlock = 141,
	    /// <summary>
	    /// -
	    /// </summary>
		Bc5SnormBlock = 142,
	    /// <summary>
	    /// -
	    /// </summary>
		Bc6hUfloatBlock = 143,
	    /// <summary>
	    /// -
	    /// </summary>
		Bc6hSfloatBlock = 144,
	    /// <summary>
	    /// -
	    /// </summary>
		Bc7UnormBlock = 145,
	    /// <summary>
	    /// -
	    /// </summary>
		Bc7SrgbBlock = 146,
	    /// <summary>
	    /// -
	    /// </summary>
		Etc2R8g8b8UnormBlock = 147,
	    /// <summary>
	    /// -
	    /// </summary>
		Etc2R8g8b8SrgbBlock = 148,
	    /// <summary>
	    /// -
	    /// </summary>
		Etc2R8g8b8a1UnormBlock = 149,
	    /// <summary>
	    /// -
	    /// </summary>
		Etc2R8g8b8a1SrgbBlock = 150,
	    /// <summary>
	    /// -
	    /// </summary>
		Etc2R8g8b8a8UnormBlock = 151,
	    /// <summary>
	    /// -
	    /// </summary>
		Etc2R8g8b8a8SrgbBlock = 152,
	    /// <summary>
	    /// -
	    /// </summary>
		EacR11UnormBlock = 153,
	    /// <summary>
	    /// -
	    /// </summary>
		EacR11SnormBlock = 154,
	    /// <summary>
	    /// -
	    /// </summary>
		EacR11g11UnormBlock = 155,
	    /// <summary>
	    /// -
	    /// </summary>
		EacR11g11SnormBlock = 156,
	    /// <summary>
	    /// -
	    /// </summary>
		Astc4x4UnormBlock = 157,
	    /// <summary>
	    /// -
	    /// </summary>
		Astc4x4SrgbBlock = 158,
	    /// <summary>
	    /// -
	    /// </summary>
		Astc5x4UnormBlock = 159,
	    /// <summary>
	    /// -
	    /// </summary>
		Astc5x4SrgbBlock = 160,
	    /// <summary>
	    /// -
	    /// </summary>
		Astc5x5UnormBlock = 161,
	    /// <summary>
	    /// -
	    /// </summary>
		Astc5x5SrgbBlock = 162,
	    /// <summary>
	    /// -
	    /// </summary>
		Astc6x5UnormBlock = 163,
	    /// <summary>
	    /// -
	    /// </summary>
		Astc6x5SrgbBlock = 164,
	    /// <summary>
	    /// -
	    /// </summary>
		Astc6x6UnormBlock = 165,
	    /// <summary>
	    /// -
	    /// </summary>
		Astc6x6SrgbBlock = 166,
	    /// <summary>
	    /// -
	    /// </summary>
		Astc8x5UnormBlock = 167,
	    /// <summary>
	    /// -
	    /// </summary>
		Astc8x5SrgbBlock = 168,
	    /// <summary>
	    /// -
	    /// </summary>
		Astc8x6UnormBlock = 169,
	    /// <summary>
	    /// -
	    /// </summary>
		Astc8x6SrgbBlock = 170,
	    /// <summary>
	    /// -
	    /// </summary>
		Astc8x8UnormBlock = 171,
	    /// <summary>
	    /// -
	    /// </summary>
		Astc8x8SrgbBlock = 172,
	    /// <summary>
	    /// -
	    /// </summary>
		Astc10x5UnormBlock = 173,
	    /// <summary>
	    /// -
	    /// </summary>
		Astc10x5SrgbBlock = 174,
	    /// <summary>
	    /// -
	    /// </summary>
		Astc10x6UnormBlock = 175,
	    /// <summary>
	    /// -
	    /// </summary>
		Astc10x6SrgbBlock = 176,
	    /// <summary>
	    /// -
	    /// </summary>
		Astc10x8UnormBlock = 177,
	    /// <summary>
	    /// -
	    /// </summary>
		Astc10x8SrgbBlock = 178,
	    /// <summary>
	    /// -
	    /// </summary>
		Astc10x10UnormBlock = 179,
	    /// <summary>
	    /// -
	    /// </summary>
		Astc10x10SrgbBlock = 180,
	    /// <summary>
	    /// -
	    /// </summary>
		Astc12x10UnormBlock = 181,
	    /// <summary>
	    /// -
	    /// </summary>
		Astc12x10SrgbBlock = 182,
	    /// <summary>
	    /// -
	    /// </summary>
		Astc12x12UnormBlock = 183,
	    /// <summary>
	    /// -
	    /// </summary>
		Astc12x12SrgbBlock = 184,
	    /// <summary>
	    /// -
	    /// </summary>
		Pvrtc12bppUnormBlockImg = 1000054000,
	    /// <summary>
	    /// -
	    /// </summary>
		Pvrtc14bppUnormBlockImg = 1000054001,
	    /// <summary>
	    /// -
	    /// </summary>
		Pvrtc22bppUnormBlockImg = 1000054002,
	    /// <summary>
	    /// -
	    /// </summary>
		Pvrtc24bppUnormBlockImg = 1000054003,
	    /// <summary>
	    /// -
	    /// </summary>
		Pvrtc12bppSrgbBlockImg = 1000054004,
	    /// <summary>
	    /// -
	    /// </summary>
		Pvrtc14bppSrgbBlockImg = 1000054005,
	    /// <summary>
	    /// -
	    /// </summary>
		Pvrtc22bppSrgbBlockImg = 1000054006,
	    /// <summary>
	    /// -
	    /// </summary>
		Pvrtc24bppSrgbBlockImg = 1000054007,
	}

    /// <summary>
    /// -
    /// </summary>
	public enum FrontFace
	{
	    /// <summary>
	    /// -
	    /// </summary>
		CounterClockwise = 0,
	    /// <summary>
	    /// -
	    /// </summary>
		Clockwise = 1,
	}

    /// <summary>
    /// -
    /// </summary>
	public enum ImageLayout
	{
	    /// <summary>
	    /// -
	    /// </summary>
		Undefined = 0,
	    /// <summary>
	    /// -
	    /// </summary>
		General = 1,
	    /// <summary>
	    /// -
	    /// </summary>
		ColorAttachmentOptimal = 2,
	    /// <summary>
	    /// -
	    /// </summary>
		DepthStencilAttachmentOptimal = 3,
	    /// <summary>
	    /// -
	    /// </summary>
		DepthStencilReadOnlyOptimal = 4,
	    /// <summary>
	    /// -
	    /// </summary>
		ShaderReadOnlyOptimal = 5,
	    /// <summary>
	    /// -
	    /// </summary>
		TransferSourceOptimal = 6,
	    /// <summary>
	    /// -
	    /// </summary>
		TransferDestinationOptimal = 7,
	    /// <summary>
	    /// -
	    /// </summary>
		Preinitialized = 8,
	    /// <summary>
	    /// -
	    /// </summary>
		PresentSource = 1000001002,
	}

    /// <summary>
    /// -
    /// </summary>
	public enum ImageTiling
	{
	    /// <summary>
	    /// -
	    /// </summary>
		Optimal = 0,
	    /// <summary>
	    /// -
	    /// </summary>
		Linear = 1,
	}

    /// <summary>
    /// -
    /// </summary>
	public enum ImageType
	{
	    /// <summary>
	    /// -
	    /// </summary>
		Image1d = 0,
	    /// <summary>
	    /// -
	    /// </summary>
		Image2d = 1,
	    /// <summary>
	    /// -
	    /// </summary>
		Image3d = 2,
	}

    /// <summary>
    /// -
    /// </summary>
	public enum ImageViewType
	{
	    /// <summary>
	    /// -
	    /// </summary>
		ImageView1d = 0,
	    /// <summary>
	    /// -
	    /// </summary>
		ImageView2d = 1,
	    /// <summary>
	    /// -
	    /// </summary>
		ImageView3d = 2,
	    /// <summary>
	    /// -
	    /// </summary>
		Cube = 3,
	    /// <summary>
	    /// -
	    /// </summary>
		ImageView1dArray = 4,
	    /// <summary>
	    /// -
	    /// </summary>
		ImageView2dArray = 5,
	    /// <summary>
	    /// -
	    /// </summary>
		CubeArray = 6,
	}

    /// <summary>
    /// -
    /// </summary>
	public enum IndexType
	{
	    /// <summary>
	    /// -
	    /// </summary>
		Uint16 = 0,
	    /// <summary>
	    /// -
	    /// </summary>
		Uint32 = 1,
	}

    /// <summary>
    /// -
    /// </summary>
	public enum LogicOp
	{
	    /// <summary>
	    /// -
	    /// </summary>
		Clear = 0,
	    /// <summary>
	    /// -
	    /// </summary>
		And = 1,
	    /// <summary>
	    /// -
	    /// </summary>
		AndReverse = 2,
	    /// <summary>
	    /// -
	    /// </summary>
		Copy = 3,
	    /// <summary>
	    /// -
	    /// </summary>
		AndInverted = 4,
	    /// <summary>
	    /// -
	    /// </summary>
		NoOp = 5,
	    /// <summary>
	    /// -
	    /// </summary>
		Xor = 6,
	    /// <summary>
	    /// -
	    /// </summary>
		Or = 7,
	    /// <summary>
	    /// -
	    /// </summary>
		Nor = 8,
	    /// <summary>
	    /// -
	    /// </summary>
		Equivalent = 9,
	    /// <summary>
	    /// -
	    /// </summary>
		Invert = 10,
	    /// <summary>
	    /// -
	    /// </summary>
		OrReverse = 11,
	    /// <summary>
	    /// -
	    /// </summary>
		CopyInverted = 12,
	    /// <summary>
	    /// -
	    /// </summary>
		OrInverted = 13,
	    /// <summary>
	    /// -
	    /// </summary>
		Nand = 14,
	    /// <summary>
	    /// -
	    /// </summary>
		Set = 15,
	}

    /// <summary>
    /// -
    /// </summary>
	public enum PhysicalDeviceType
	{
	    /// <summary>
	    /// -
	    /// </summary>
		Other = 0,
	    /// <summary>
	    /// -
	    /// </summary>
		IntegratedGpu = 1,
	    /// <summary>
	    /// -
	    /// </summary>
		DiscreteGpu = 2,
	    /// <summary>
	    /// -
	    /// </summary>
		VirtualGpu = 3,
	    /// <summary>
	    /// -
	    /// </summary>
		Cpu = 4,
	}

    /// <summary>
    /// -
    /// </summary>
	public enum PipelineBindPoint
	{
	    /// <summary>
	    /// -
	    /// </summary>
		Graphics = 0,
	    /// <summary>
	    /// -
	    /// </summary>
		Compute = 1,
	}

    /// <summary>
    /// -
    /// </summary>
	public enum PipelineCacheHeaderVersion
	{
	    /// <summary>
	    /// -
	    /// </summary>
		One = 1,
	}

    /// <summary>
    /// -
    /// </summary>
	public enum PolygonMode
	{
	    /// <summary>
	    /// -
	    /// </summary>
		Fill = 0,
	    /// <summary>
	    /// -
	    /// </summary>
		Line = 1,
	    /// <summary>
	    /// -
	    /// </summary>
		Point = 2,
	}

    /// <summary>
    /// -
    /// </summary>
	public enum PresentMode
	{
	    /// <summary>
	    /// -
	    /// </summary>
		Immediate = 0,
	    /// <summary>
	    /// -
	    /// </summary>
		Mailbox = 1,
	    /// <summary>
	    /// -
	    /// </summary>
		Fifo = 2,
	    /// <summary>
	    /// -
	    /// </summary>
		FifoRelaxed = 3,
	}

    /// <summary>
    /// -
    /// </summary>
	public enum PrimitiveTopology
	{
	    /// <summary>
	    /// -
	    /// </summary>
		PointList = 0,
	    /// <summary>
	    /// -
	    /// </summary>
		LineList = 1,
	    /// <summary>
	    /// -
	    /// </summary>
		LineStrip = 2,
	    /// <summary>
	    /// -
	    /// </summary>
		TriangleList = 3,
	    /// <summary>
	    /// -
	    /// </summary>
		TriangleStrip = 4,
	    /// <summary>
	    /// -
	    /// </summary>
		TriangleFan = 5,
	    /// <summary>
	    /// -
	    /// </summary>
		LineListWithAdjacency = 6,
	    /// <summary>
	    /// -
	    /// </summary>
		LineStripWithAdjacency = 7,
	    /// <summary>
	    /// -
	    /// </summary>
		TriangleListWithAdjacency = 8,
	    /// <summary>
	    /// -
	    /// </summary>
		TriangleStripWithAdjacency = 9,
	    /// <summary>
	    /// -
	    /// </summary>
		PatchList = 10,
	}

    /// <summary>
    /// -
    /// </summary>
	public enum QueryType
	{
	    /// <summary>
	    /// -
	    /// </summary>
		Occlusion = 0,
	    /// <summary>
	    /// -
	    /// </summary>
		PipelineStatistics = 1,
	    /// <summary>
	    /// -
	    /// </summary>
		Timestamp = 2,
	}

    /// <summary>
    /// -
    /// </summary>
	public enum RasterizationOrder
	{
	    /// <summary>
	    /// -
	    /// </summary>
		Strict = 0,
	    /// <summary>
	    /// -
	    /// </summary>
		Relaxed = 1,
	}

    /// <summary>
    /// -
    /// </summary>
	public enum Result
	{
	    /// <summary>
	    /// -
	    /// </summary>
		Success = 0,
	    /// <summary>
	    /// -
	    /// </summary>
		NotReady = 1,
	    /// <summary>
	    /// -
	    /// </summary>
		Timeout = 2,
	    /// <summary>
	    /// -
	    /// </summary>
		EventSet = 3,
	    /// <summary>
	    /// -
	    /// </summary>
		EventReset = 4,
	    /// <summary>
	    /// -
	    /// </summary>
		Incomplete = 5,
	    /// <summary>
	    /// -
	    /// </summary>
		ErrorOutOfHostMemory = -1,
	    /// <summary>
	    /// -
	    /// </summary>
		ErrorOutOfDeviceMemory = -2,
	    /// <summary>
	    /// -
	    /// </summary>
		ErrorInitializationFailed = -3,
	    /// <summary>
	    /// -
	    /// </summary>
		ErrorDeviceLost = -4,
	    /// <summary>
	    /// -
	    /// </summary>
		ErrorMemoryMapFailed = -5,
	    /// <summary>
	    /// -
	    /// </summary>
		ErrorLayerNotPresent = -6,
	    /// <summary>
	    /// -
	    /// </summary>
		ErrorExtensionNotPresent = -7,
	    /// <summary>
	    /// -
	    /// </summary>
		ErrorFeatureNotPresent = -8,
	    /// <summary>
	    /// -
	    /// </summary>
		ErrorIncompatibleDriver = -9,
	    /// <summary>
	    /// -
	    /// </summary>
		ErrorTooManyObjects = -10,
	    /// <summary>
	    /// -
	    /// </summary>
		ErrorFormatNotSupported = -11,
	    /// <summary>
	    /// -
	    /// </summary>
		ErrorFragmentedPool = -12,
	    /// <summary>
	    /// -
	    /// </summary>
		ErrorSurfaceLost = -1000000000,
	    /// <summary>
	    /// -
	    /// </summary>
		ErrorNativeWindowInUse = -1000000001,
	    /// <summary>
	    /// -
	    /// </summary>
		Suboptimal = 1000001003,
	    /// <summary>
	    /// -
	    /// </summary>
		ErrorOutOfDate = -1000001004,
	    /// <summary>
	    /// -
	    /// </summary>
		ErrorIncompatibleDisplay = -1000003001,
	    /// <summary>
	    /// -
	    /// </summary>
		ErrorValidationFailed = -1000011001,
	    /// <summary>
	    /// -
	    /// </summary>
		ErrorInvalidShader = -1000012000,
	}

    /// <summary>
    /// -
    /// </summary>
	public enum SamplerAddressMode
	{
	    /// <summary>
	    /// -
	    /// </summary>
		Repeat = 0,
	    /// <summary>
	    /// -
	    /// </summary>
		MirroredRepeat = 1,
	    /// <summary>
	    /// -
	    /// </summary>
		ClampToEdge = 2,
	    /// <summary>
	    /// -
	    /// </summary>
		ClampToBorder = 3,
	    /// <summary>
	    /// -
	    /// </summary>
		MirrorClampToEdge = 4,
	}

    /// <summary>
    /// -
    /// </summary>
	public enum SamplerMipmapMode
	{
	    /// <summary>
	    /// -
	    /// </summary>
		Nearest = 0,
	    /// <summary>
	    /// -
	    /// </summary>
		Linear = 1,
	}

    /// <summary>
    /// -
    /// </summary>
	public enum SharingMode
	{
	    /// <summary>
	    /// -
	    /// </summary>
		Exclusive = 0,
	    /// <summary>
	    /// -
	    /// </summary>
		Concurrent = 1,
	}

    /// <summary>
    /// -
    /// </summary>
	public enum StencilOp
	{
	    /// <summary>
	    /// -
	    /// </summary>
		Keep = 0,
	    /// <summary>
	    /// -
	    /// </summary>
		Zero = 1,
	    /// <summary>
	    /// -
	    /// </summary>
		Replace = 2,
	    /// <summary>
	    /// -
	    /// </summary>
		IncrementAndClamp = 3,
	    /// <summary>
	    /// -
	    /// </summary>
		DecrementAndClamp = 4,
	    /// <summary>
	    /// -
	    /// </summary>
		Invert = 5,
	    /// <summary>
	    /// -
	    /// </summary>
		IncrementAndWrap = 6,
	    /// <summary>
	    /// -
	    /// </summary>
		DecrementAndWrap = 7,
	}

    /// <summary>
    /// -
    /// </summary>
	public enum StructureType
	{
	    /// <summary>
	    /// -
	    /// </summary>
		ApplicationInfo = 0,
	    /// <summary>
	    /// -
	    /// </summary>
		InstanceCreateInfo = 1,
	    /// <summary>
	    /// -
	    /// </summary>
		DeviceQueueCreateInfo = 2,
	    /// <summary>
	    /// -
	    /// </summary>
		DeviceCreateInfo = 3,
	    /// <summary>
	    /// -
	    /// </summary>
		SubmitInfo = 4,
	    /// <summary>
	    /// -
	    /// </summary>
		MemoryAllocateInfo = 5,
	    /// <summary>
	    /// -
	    /// </summary>
		MappedMemoryRange = 6,
	    /// <summary>
	    /// -
	    /// </summary>
		BindSparseInfo = 7,
	    /// <summary>
	    /// -
	    /// </summary>
		FenceCreateInfo = 8,
	    /// <summary>
	    /// -
	    /// </summary>
		SemaphoreCreateInfo = 9,
	    /// <summary>
	    /// -
	    /// </summary>
		EventCreateInfo = 10,
	    /// <summary>
	    /// -
	    /// </summary>
		QueryPoolCreateInfo = 11,
	    /// <summary>
	    /// -
	    /// </summary>
		BufferCreateInfo = 12,
	    /// <summary>
	    /// -
	    /// </summary>
		BufferViewCreateInfo = 13,
	    /// <summary>
	    /// -
	    /// </summary>
		ImageCreateInfo = 14,
	    /// <summary>
	    /// -
	    /// </summary>
		ImageViewCreateInfo = 15,
	    /// <summary>
	    /// -
	    /// </summary>
		ShaderModuleCreateInfo = 16,
	    /// <summary>
	    /// -
	    /// </summary>
		PipelineCacheCreateInfo = 17,
	    /// <summary>
	    /// -
	    /// </summary>
		PipelineShaderStageCreateInfo = 18,
	    /// <summary>
	    /// -
	    /// </summary>
		PipelineVertexInputStateCreateInfo = 19,
	    /// <summary>
	    /// -
	    /// </summary>
		PipelineInputAssemblyStateCreateInfo = 20,
	    /// <summary>
	    /// -
	    /// </summary>
		PipelineTessellationStateCreateInfo = 21,
	    /// <summary>
	    /// -
	    /// </summary>
		PipelineViewportStateCreateInfo = 22,
	    /// <summary>
	    /// -
	    /// </summary>
		PipelineRasterizationStateCreateInfo = 23,
	    /// <summary>
	    /// -
	    /// </summary>
		PipelineMultisampleStateCreateInfo = 24,
	    /// <summary>
	    /// -
	    /// </summary>
		PipelineDepthStencilStateCreateInfo = 25,
	    /// <summary>
	    /// -
	    /// </summary>
		PipelineColorBlendStateCreateInfo = 26,
	    /// <summary>
	    /// -
	    /// </summary>
		PipelineDynamicStateCreateInfo = 27,
	    /// <summary>
	    /// -
	    /// </summary>
		GraphicsPipelineCreateInfo = 28,
	    /// <summary>
	    /// -
	    /// </summary>
		ComputePipelineCreateInfo = 29,
	    /// <summary>
	    /// -
	    /// </summary>
		PipelineLayoutCreateInfo = 30,
	    /// <summary>
	    /// -
	    /// </summary>
		SamplerCreateInfo = 31,
	    /// <summary>
	    /// -
	    /// </summary>
		DescriptorSetLayoutCreateInfo = 32,
	    /// <summary>
	    /// -
	    /// </summary>
		DescriptorPoolCreateInfo = 33,
	    /// <summary>
	    /// -
	    /// </summary>
		DescriptorSetAllocateInfo = 34,
	    /// <summary>
	    /// -
	    /// </summary>
		WriteDescriptorSet = 35,
	    /// <summary>
	    /// -
	    /// </summary>
		CopyDescriptorSet = 36,
	    /// <summary>
	    /// -
	    /// </summary>
		FramebufferCreateInfo = 37,
	    /// <summary>
	    /// -
	    /// </summary>
		RenderPassCreateInfo = 38,
	    /// <summary>
	    /// -
	    /// </summary>
		CommandPoolCreateInfo = 39,
	    /// <summary>
	    /// -
	    /// </summary>
		CommandBufferAllocateInfo = 40,
	    /// <summary>
	    /// -
	    /// </summary>
		CommandBufferInheritanceInfo = 41,
	    /// <summary>
	    /// -
	    /// </summary>
		CommandBufferBeginInfo = 42,
	    /// <summary>
	    /// -
	    /// </summary>
		RenderPassBeginInfo = 43,
	    /// <summary>
	    /// -
	    /// </summary>
		BufferMemoryBarrier = 44,
	    /// <summary>
	    /// -
	    /// </summary>
		ImageMemoryBarrier = 45,
	    /// <summary>
	    /// -
	    /// </summary>
		MemoryBarrier = 46,
	    /// <summary>
	    /// -
	    /// </summary>
		LoaderInstanceCreateInfo = 47,
	    /// <summary>
	    /// -
	    /// </summary>
		LoaderDeviceCreateInfo = 48,
	    /// <summary>
	    /// -
	    /// </summary>
		SwapchainCreateInfo = 1000001000,
	    /// <summary>
	    /// -
	    /// </summary>
		PresentInfo = 1000001001,
	    /// <summary>
	    /// -
	    /// </summary>
		DisplayModeCreateInfo = 1000002000,
	    /// <summary>
	    /// -
	    /// </summary>
		DisplaySurfaceCreateInfo = 1000002001,
	    /// <summary>
	    /// -
	    /// </summary>
		DisplayPresentInfo = 1000003000,
	    /// <summary>
	    /// -
	    /// </summary>
		XlibSurfaceCreateInfo = 1000004000,
	    /// <summary>
	    /// -
	    /// </summary>
		XcbSurfaceCreateInfo = 1000005000,
	    /// <summary>
	    /// -
	    /// </summary>
		WaylandSurfaceCreateInfo = 1000006000,
	    /// <summary>
	    /// -
	    /// </summary>
		MirSurfaceCreateInfo = 1000007000,
	    /// <summary>
	    /// -
	    /// </summary>
		AndroidSurfaceCreateInfo = 1000008000,
	    /// <summary>
	    /// -
	    /// </summary>
		Win32SurfaceCreateInfo = 1000009000,
	    /// <summary>
	    /// -
	    /// </summary>
		DebugReportCallbackCreateInfo = 1000011000,
	    /// <summary>
	    /// -
	    /// </summary>
		PipelineRasterizationStateRasterizationOrder = 1000018000,
	    /// <summary>
	    /// -
	    /// </summary>
		DebugMarkerObjectNameInfo = 1000022000,
	    /// <summary>
	    /// -
	    /// </summary>
		DebugMarkerObjectTagInfo = 1000022001,
	    /// <summary>
	    /// -
	    /// </summary>
		DebugMarkerMarkerInfo = 1000022002,
	    /// <summary>
	    /// -
	    /// </summary>
		DedicatedAllocationImageCreateInfo = 1000026000,
	    /// <summary>
	    /// -
	    /// </summary>
		DedicatedAllocationBufferCreateInfo = 1000026001,
	    /// <summary>
	    /// -
	    /// </summary>
		DedicatedAllocationMemoryAllocateInfo = 1000026002,
	}

    /// <summary>
    /// -
    /// </summary>
	public enum SubpassContents
	{
	    /// <summary>
	    /// -
	    /// </summary>
		Inline = 0,
	    /// <summary>
	    /// -
	    /// </summary>
		SecondaryCommandBuffers = 1,
	}

    /// <summary>
    /// -
    /// </summary>
	public enum VertexInputRate
	{
	    /// <summary>
	    /// -
	    /// </summary>
		Vertex = 0,
	    /// <summary>
	    /// -
	    /// </summary>
		Instance = 1,
	}
}