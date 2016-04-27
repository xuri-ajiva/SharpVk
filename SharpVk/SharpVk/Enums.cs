//The MIT License (MIT)
//
//Copyright (c) 2016 Andrew Armstrong/FacticiusVir
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

	[Flags]
	public enum AccessFlags
	{
		None = 0,
		IndirectCommandRead = 1 << 0,
		IndexRead = 1 << 1,
		VertexAttributeRead = 1 << 2,
		UniformRead = 1 << 3,
		InputAttachmentRead = 1 << 4,
		ShaderRead = 1 << 5,
		ShaderWrite = 1 << 6,
		ColorAttachmentRead = 1 << 7,
		ColorAttachmentWrite = 1 << 8,
		DepthStencilAttachmentRead = 1 << 9,
		DepthStencilAttachmentWrite = 1 << 10,
		TransferRead = 1 << 11,
		TransferWrite = 1 << 12,
		HostRead = 1 << 13,
		HostWrite = 1 << 14,
		MemoryRead = 1 << 15,
		MemoryWrite = 1 << 16,
	}

	internal static class AccessFlagsExtensions
	{
		internal unsafe static AccessFlags* MarshalTo(this AccessFlags[] values)
		{
			throw new NotImplementedException();
		}
	}

	[Flags]
	public enum AttachmentDescriptionFlags
	{
		None = 0,
		MayAlias = 1 << 0,
	}

	internal static class AttachmentDescriptionFlagsExtensions
	{
		internal unsafe static AttachmentDescriptionFlags* MarshalTo(this AttachmentDescriptionFlags[] values)
		{
			throw new NotImplementedException();
		}
	}

	[Flags]
	public enum BufferCreateFlags
	{
		None = 0,
		SparseBinding = 1 << 0,
		SparseResidency = 1 << 1,
		SparseAliased = 1 << 2,
	}

	internal static class BufferCreateFlagsExtensions
	{
		internal unsafe static BufferCreateFlags* MarshalTo(this BufferCreateFlags[] values)
		{
			throw new NotImplementedException();
		}
	}

	[Flags]
	public enum BufferUsageFlags
	{
		None = 0,
		TransferSource = 1 << 0,
		TransferDestination = 1 << 1,
		UniformTexelBuffer = 1 << 2,
		StorageTexelBuffer = 1 << 3,
		UniformBuffer = 1 << 4,
		StorageBuffer = 1 << 5,
		IndexBuffer = 1 << 6,
		VertexBuffer = 1 << 7,
		IndirectBuffer = 1 << 8,
	}

	internal static class BufferUsageFlagsExtensions
	{
		internal unsafe static BufferUsageFlags* MarshalTo(this BufferUsageFlags[] values)
		{
			throw new NotImplementedException();
		}
	}

	[Flags]
	public enum BufferViewCreateFlags
	{
		None = 0,
	}

	internal static class BufferViewCreateFlagsExtensions
	{
		internal unsafe static BufferViewCreateFlags* MarshalTo(this BufferViewCreateFlags[] values)
		{
			throw new NotImplementedException();
		}
	}

	[Flags]
	public enum ColorComponentFlags
	{
		None = 0,
		R = 1 << 0,
		G = 1 << 1,
		B = 1 << 2,
		A = 1 << 3,
	}

	internal static class ColorComponentFlagsExtensions
	{
		internal unsafe static ColorComponentFlags* MarshalTo(this ColorComponentFlags[] values)
		{
			throw new NotImplementedException();
		}
	}

	[Flags]
	public enum CommandBufferResetFlags
	{
		None = 0,
		ReleaseResources = 1 << 0,
	}

	internal static class CommandBufferResetFlagsExtensions
	{
		internal unsafe static CommandBufferResetFlags* MarshalTo(this CommandBufferResetFlags[] values)
		{
			throw new NotImplementedException();
		}
	}

	[Flags]
	public enum CommandBufferUsageFlags
	{
		None = 0,
		OneTimeSubmit = 1 << 0,
		RenderPassContinue = 1 << 1,
		SimultaneousUse = 1 << 2,
	}

	internal static class CommandBufferUsageFlagsExtensions
	{
		internal unsafe static CommandBufferUsageFlags* MarshalTo(this CommandBufferUsageFlags[] values)
		{
			throw new NotImplementedException();
		}
	}

	[Flags]
	public enum CommandPoolCreateFlags
	{
		None = 0,
		Transient = 1 << 0,
		ResetCommandBuffer = 1 << 1,
	}

	internal static class CommandPoolCreateFlagsExtensions
	{
		internal unsafe static CommandPoolCreateFlags* MarshalTo(this CommandPoolCreateFlags[] values)
		{
			throw new NotImplementedException();
		}
	}

	[Flags]
	public enum CommandPoolResetFlags
	{
		None = 0,
		ReleaseResources = 1 << 0,
	}

	internal static class CommandPoolResetFlagsExtensions
	{
		internal unsafe static CommandPoolResetFlags* MarshalTo(this CommandPoolResetFlags[] values)
		{
			throw new NotImplementedException();
		}
	}

	[Flags]
	public enum CullModeFlags
	{
		None = 0,
		Front = 1 << 0,
		Back = 1 << 1,
		FrontAndBack = 0x00000003,
	}

	internal static class CullModeFlagsExtensions
	{
		internal unsafe static CullModeFlags* MarshalTo(this CullModeFlags[] values)
		{
			throw new NotImplementedException();
		}
	}

	[Flags]
	public enum DependencyFlags
	{
		None = 0,
		ByRegion = 1 << 0,
	}

	internal static class DependencyFlagsExtensions
	{
		internal unsafe static DependencyFlags* MarshalTo(this DependencyFlags[] values)
		{
			throw new NotImplementedException();
		}
	}

	[Flags]
	public enum DescriptorPoolCreateFlags
	{
		None = 0,
		FreeDescriptorSet = 1 << 0,
	}

	internal static class DescriptorPoolCreateFlagsExtensions
	{
		internal unsafe static DescriptorPoolCreateFlags* MarshalTo(this DescriptorPoolCreateFlags[] values)
		{
			throw new NotImplementedException();
		}
	}

	[Flags]
	public enum DescriptorPoolResetFlags
	{
		None = 0,
	}

	internal static class DescriptorPoolResetFlagsExtensions
	{
		internal unsafe static DescriptorPoolResetFlags* MarshalTo(this DescriptorPoolResetFlags[] values)
		{
			throw new NotImplementedException();
		}
	}

	[Flags]
	public enum DescriptorSetLayoutCreateFlags
	{
		None = 0,
	}

	internal static class DescriptorSetLayoutCreateFlagsExtensions
	{
		internal unsafe static DescriptorSetLayoutCreateFlags* MarshalTo(this DescriptorSetLayoutCreateFlags[] values)
		{
			throw new NotImplementedException();
		}
	}

	[Flags]
	public enum DeviceCreateFlags
	{
		None = 0,
	}

	internal static class DeviceCreateFlagsExtensions
	{
		internal unsafe static DeviceCreateFlags* MarshalTo(this DeviceCreateFlags[] values)
		{
			throw new NotImplementedException();
		}
	}

	[Flags]
	public enum DeviceQueueCreateFlags
	{
		None = 0,
	}

	internal static class DeviceQueueCreateFlagsExtensions
	{
		internal unsafe static DeviceQueueCreateFlags* MarshalTo(this DeviceQueueCreateFlags[] values)
		{
			throw new NotImplementedException();
		}
	}

	[Flags]
	public enum EventCreateFlags
	{
		None = 0,
	}

	internal static class EventCreateFlagsExtensions
	{
		internal unsafe static EventCreateFlags* MarshalTo(this EventCreateFlags[] values)
		{
			throw new NotImplementedException();
		}
	}

	[Flags]
	public enum FenceCreateFlags
	{
		None = 0,
		Signaled = 1 << 0,
	}

	internal static class FenceCreateFlagsExtensions
	{
		internal unsafe static FenceCreateFlags* MarshalTo(this FenceCreateFlags[] values)
		{
			throw new NotImplementedException();
		}
	}

	[Flags]
	public enum FormatFeatureFlags
	{
		None = 0,
		SampledImage = 1 << 0,
		StorageImage = 1 << 1,
		StorageImageAtomic = 1 << 2,
		UniformTexelBuffer = 1 << 3,
		StorageTexelBuffer = 1 << 4,
		StorageTexelBufferAtomic = 1 << 5,
		VertexBuffer = 1 << 6,
		ColorAttachment = 1 << 7,
		ColorAttachmentBlend = 1 << 8,
		DepthStencilAttachment = 1 << 9,
		BlitSource = 1 << 10,
		BlitDestination = 1 << 11,
		SampledImageFilterLinear = 1 << 12,
	}

	internal static class FormatFeatureFlagsExtensions
	{
		internal unsafe static FormatFeatureFlags* MarshalTo(this FormatFeatureFlags[] values)
		{
			throw new NotImplementedException();
		}
	}

	[Flags]
	public enum FramebufferCreateFlags
	{
		None = 0,
	}

	internal static class FramebufferCreateFlagsExtensions
	{
		internal unsafe static FramebufferCreateFlags* MarshalTo(this FramebufferCreateFlags[] values)
		{
			throw new NotImplementedException();
		}
	}

	[Flags]
	public enum ImageAspectFlags
	{
		None = 0,
		Color = 1 << 0,
		Depth = 1 << 1,
		Stencil = 1 << 2,
		Metadata = 1 << 3,
	}

	internal static class ImageAspectFlagsExtensions
	{
		internal unsafe static ImageAspectFlags* MarshalTo(this ImageAspectFlags[] values)
		{
			throw new NotImplementedException();
		}
	}

	[Flags]
	public enum ImageCreateFlags
	{
		None = 0,
		SparseBinding = 1 << 0,
		SparseResidency = 1 << 1,
		SparseAliased = 1 << 2,
		MutableFormat = 1 << 3,
		CubeCompatible = 1 << 4,
	}

	internal static class ImageCreateFlagsExtensions
	{
		internal unsafe static ImageCreateFlags* MarshalTo(this ImageCreateFlags[] values)
		{
			throw new NotImplementedException();
		}
	}

	[Flags]
	public enum ImageUsageFlags
	{
		None = 0,
		TransferSource = 1 << 0,
		TransferDestination = 1 << 1,
		Sampled = 1 << 2,
		Storage = 1 << 3,
		ColorAttachment = 1 << 4,
		DepthStencilAttachment = 1 << 5,
		TransientAttachment = 1 << 6,
		InputAttachment = 1 << 7,
	}

	internal static class ImageUsageFlagsExtensions
	{
		internal unsafe static ImageUsageFlags* MarshalTo(this ImageUsageFlags[] values)
		{
			throw new NotImplementedException();
		}
	}

	[Flags]
	public enum ImageViewCreateFlags
	{
		None = 0,
	}

	internal static class ImageViewCreateFlagsExtensions
	{
		internal unsafe static ImageViewCreateFlags* MarshalTo(this ImageViewCreateFlags[] values)
		{
			throw new NotImplementedException();
		}
	}

	[Flags]
	public enum InstanceCreateFlags
	{
		None = 0,
	}

	internal static class InstanceCreateFlagsExtensions
	{
		internal unsafe static InstanceCreateFlags* MarshalTo(this InstanceCreateFlags[] values)
		{
			throw new NotImplementedException();
		}
	}

	[Flags]
	public enum MemoryHeapFlags
	{
		None = 0,
		DeviceLocal = 1 << 0,
	}

	internal static class MemoryHeapFlagsExtensions
	{
		internal unsafe static MemoryHeapFlags* MarshalTo(this MemoryHeapFlags[] values)
		{
			throw new NotImplementedException();
		}
	}

	[Flags]
	public enum MemoryMapFlags
	{
		None = 0,
	}

	internal static class MemoryMapFlagsExtensions
	{
		internal unsafe static MemoryMapFlags* MarshalTo(this MemoryMapFlags[] values)
		{
			throw new NotImplementedException();
		}
	}

	[Flags]
	public enum MemoryPropertyFlags
	{
		None = 0,
		DeviceLocal = 1 << 0,
		HostVisible = 1 << 1,
		HostCoherent = 1 << 2,
		HostCached = 1 << 3,
		LazilyAllocated = 1 << 4,
	}

	internal static class MemoryPropertyFlagsExtensions
	{
		internal unsafe static MemoryPropertyFlags* MarshalTo(this MemoryPropertyFlags[] values)
		{
			throw new NotImplementedException();
		}
	}

	[Flags]
	public enum PipelineCacheCreateFlags
	{
		None = 0,
	}

	internal static class PipelineCacheCreateFlagsExtensions
	{
		internal unsafe static PipelineCacheCreateFlags* MarshalTo(this PipelineCacheCreateFlags[] values)
		{
			throw new NotImplementedException();
		}
	}

	[Flags]
	public enum PipelineColorBlendStateCreateFlags
	{
		None = 0,
	}

	internal static class PipelineColorBlendStateCreateFlagsExtensions
	{
		internal unsafe static PipelineColorBlendStateCreateFlags* MarshalTo(this PipelineColorBlendStateCreateFlags[] values)
		{
			throw new NotImplementedException();
		}
	}

	[Flags]
	public enum PipelineCreateFlags
	{
		None = 0,
		DisableOptimization = 1 << 0,
		AllowDerivatives = 1 << 1,
		Derivative = 1 << 2,
	}

	internal static class PipelineCreateFlagsExtensions
	{
		internal unsafe static PipelineCreateFlags* MarshalTo(this PipelineCreateFlags[] values)
		{
			throw new NotImplementedException();
		}
	}

	[Flags]
	public enum PipelineDepthStencilStateCreateFlags
	{
		None = 0,
	}

	internal static class PipelineDepthStencilStateCreateFlagsExtensions
	{
		internal unsafe static PipelineDepthStencilStateCreateFlags* MarshalTo(this PipelineDepthStencilStateCreateFlags[] values)
		{
			throw new NotImplementedException();
		}
	}

	[Flags]
	public enum PipelineDynamicStateCreateFlags
	{
		None = 0,
	}

	internal static class PipelineDynamicStateCreateFlagsExtensions
	{
		internal unsafe static PipelineDynamicStateCreateFlags* MarshalTo(this PipelineDynamicStateCreateFlags[] values)
		{
			throw new NotImplementedException();
		}
	}

	[Flags]
	public enum PipelineInputAssemblyStateCreateFlags
	{
		None = 0,
	}

	internal static class PipelineInputAssemblyStateCreateFlagsExtensions
	{
		internal unsafe static PipelineInputAssemblyStateCreateFlags* MarshalTo(this PipelineInputAssemblyStateCreateFlags[] values)
		{
			throw new NotImplementedException();
		}
	}

	[Flags]
	public enum PipelineLayoutCreateFlags
	{
		None = 0,
	}

	internal static class PipelineLayoutCreateFlagsExtensions
	{
		internal unsafe static PipelineLayoutCreateFlags* MarshalTo(this PipelineLayoutCreateFlags[] values)
		{
			throw new NotImplementedException();
		}
	}

	[Flags]
	public enum PipelineMultisampleStateCreateFlags
	{
		None = 0,
	}

	internal static class PipelineMultisampleStateCreateFlagsExtensions
	{
		internal unsafe static PipelineMultisampleStateCreateFlags* MarshalTo(this PipelineMultisampleStateCreateFlags[] values)
		{
			throw new NotImplementedException();
		}
	}

	[Flags]
	public enum PipelineRasterizationStateCreateFlags
	{
		None = 0,
	}

	internal static class PipelineRasterizationStateCreateFlagsExtensions
	{
		internal unsafe static PipelineRasterizationStateCreateFlags* MarshalTo(this PipelineRasterizationStateCreateFlags[] values)
		{
			throw new NotImplementedException();
		}
	}

	[Flags]
	public enum PipelineShaderStageCreateFlags
	{
		None = 0,
	}

	internal static class PipelineShaderStageCreateFlagsExtensions
	{
		internal unsafe static PipelineShaderStageCreateFlags* MarshalTo(this PipelineShaderStageCreateFlags[] values)
		{
			throw new NotImplementedException();
		}
	}

	[Flags]
	public enum PipelineStageFlags
	{
		None = 0,
		TopOfPipe = 1 << 0,
		DrawIndirect = 1 << 1,
		VertexInput = 1 << 2,
		VertexShader = 1 << 3,
		TessellationControlShader = 1 << 4,
		TessellationEvaluationShader = 1 << 5,
		GeometryShader = 1 << 6,
		FragmentShader = 1 << 7,
		EarlyFragmentTests = 1 << 8,
		LateFragmentTests = 1 << 9,
		ColorAttachmentOutput = 1 << 10,
		ComputeShader = 1 << 11,
		Transfer = 1 << 12,
		BottomOfPipe = 1 << 13,
		Host = 1 << 14,
		AllGraphics = 1 << 15,
		AllCommands = 1 << 16,
	}

	internal static class PipelineStageFlagsExtensions
	{
		internal unsafe static PipelineStageFlags* MarshalTo(this PipelineStageFlags[] values)
		{
			throw new NotImplementedException();
		}
	}

	[Flags]
	public enum PipelineTessellationStateCreateFlags
	{
		None = 0,
	}

	internal static class PipelineTessellationStateCreateFlagsExtensions
	{
		internal unsafe static PipelineTessellationStateCreateFlags* MarshalTo(this PipelineTessellationStateCreateFlags[] values)
		{
			throw new NotImplementedException();
		}
	}

	[Flags]
	public enum PipelineVertexInputStateCreateFlags
	{
		None = 0,
	}

	internal static class PipelineVertexInputStateCreateFlagsExtensions
	{
		internal unsafe static PipelineVertexInputStateCreateFlags* MarshalTo(this PipelineVertexInputStateCreateFlags[] values)
		{
			throw new NotImplementedException();
		}
	}

	[Flags]
	public enum PipelineViewportStateCreateFlags
	{
		None = 0,
	}

	internal static class PipelineViewportStateCreateFlagsExtensions
	{
		internal unsafe static PipelineViewportStateCreateFlags* MarshalTo(this PipelineViewportStateCreateFlags[] values)
		{
			throw new NotImplementedException();
		}
	}

	[Flags]
	public enum QueryControlFlags
	{
		None = 0,
		Precise = 1 << 0,
	}

	internal static class QueryControlFlagsExtensions
	{
		internal unsafe static QueryControlFlags* MarshalTo(this QueryControlFlags[] values)
		{
			throw new NotImplementedException();
		}
	}

	[Flags]
	public enum QueryPipelineStatisticFlags
	{
		None = 0,
		InputAssemblyVertices = 1 << 0,
		InputAssemblyPrimitives = 1 << 1,
		VertexShaderInvocations = 1 << 2,
		GeometryShaderInvocations = 1 << 3,
		GeometryShaderPrimitives = 1 << 4,
		ClippingInvocations = 1 << 5,
		ClippingPrimitives = 1 << 6,
		FragmentShaderInvocations = 1 << 7,
		TessellationControlShaderPatches = 1 << 8,
		TessellationEvaluationShaderInvocations = 1 << 9,
		ComputeShaderInvocations = 1 << 10,
	}

	internal static class QueryPipelineStatisticFlagsExtensions
	{
		internal unsafe static QueryPipelineStatisticFlags* MarshalTo(this QueryPipelineStatisticFlags[] values)
		{
			throw new NotImplementedException();
		}
	}

	[Flags]
	public enum QueryPoolCreateFlags
	{
		None = 0,
	}

	internal static class QueryPoolCreateFlagsExtensions
	{
		internal unsafe static QueryPoolCreateFlags* MarshalTo(this QueryPoolCreateFlags[] values)
		{
			throw new NotImplementedException();
		}
	}

	[Flags]
	public enum QueryResultFlags
	{
		None = 0,
		QueryResult64 = 1 << 0,
		Wait = 1 << 1,
		WithAvailability = 1 << 2,
		Partial = 1 << 3,
	}

	internal static class QueryResultFlagsExtensions
	{
		internal unsafe static QueryResultFlags* MarshalTo(this QueryResultFlags[] values)
		{
			throw new NotImplementedException();
		}
	}

	[Flags]
	public enum QueueFlags
	{
		None = 0,
		Graphics = 1 << 0,
		Compute = 1 << 1,
		Transfer = 1 << 2,
		SparseBinding = 1 << 3,
	}

	internal static class QueueFlagsExtensions
	{
		internal unsafe static QueueFlags* MarshalTo(this QueueFlags[] values)
		{
			throw new NotImplementedException();
		}
	}

	[Flags]
	public enum RenderPassCreateFlags
	{
		None = 0,
	}

	internal static class RenderPassCreateFlagsExtensions
	{
		internal unsafe static RenderPassCreateFlags* MarshalTo(this RenderPassCreateFlags[] values)
		{
			throw new NotImplementedException();
		}
	}

	[Flags]
	public enum SampleCountFlags
	{
		None = 0,
		SampleCount1 = 1 << 0,
		SampleCount2 = 1 << 1,
		SampleCount4 = 1 << 2,
		SampleCount8 = 1 << 3,
		SampleCount16 = 1 << 4,
		SampleCount32 = 1 << 5,
		SampleCount64 = 1 << 6,
	}

	internal static class SampleCountFlagsExtensions
	{
		internal unsafe static SampleCountFlags* MarshalTo(this SampleCountFlags[] values)
		{
			throw new NotImplementedException();
		}
	}

	[Flags]
	public enum SamplerCreateFlags
	{
		None = 0,
	}

	internal static class SamplerCreateFlagsExtensions
	{
		internal unsafe static SamplerCreateFlags* MarshalTo(this SamplerCreateFlags[] values)
		{
			throw new NotImplementedException();
		}
	}

	[Flags]
	public enum SemaphoreCreateFlags
	{
		None = 0,
	}

	internal static class SemaphoreCreateFlagsExtensions
	{
		internal unsafe static SemaphoreCreateFlags* MarshalTo(this SemaphoreCreateFlags[] values)
		{
			throw new NotImplementedException();
		}
	}

	[Flags]
	public enum ShaderModuleCreateFlags
	{
		None = 0,
	}

	internal static class ShaderModuleCreateFlagsExtensions
	{
		internal unsafe static ShaderModuleCreateFlags* MarshalTo(this ShaderModuleCreateFlags[] values)
		{
			throw new NotImplementedException();
		}
	}

	[Flags]
	public enum ShaderStageFlags
	{
		None = 0,
		Vertex = 1 << 0,
		TessellationControl = 1 << 1,
		TessellationEvaluation = 1 << 2,
		Geometry = 1 << 3,
		Fragment = 1 << 4,
		Compute = 1 << 5,
		AllGraphics = 0x0000001F,
		All = 0x7FFFFFFF,
	}

	internal static class ShaderStageFlagsExtensions
	{
		internal unsafe static ShaderStageFlags* MarshalTo(this ShaderStageFlags[] values)
		{
			throw new NotImplementedException();
		}
	}

	[Flags]
	public enum SparseImageFormatFlags
	{
		None = 0,
		SingleMiptail = 1 << 0,
		AlignedMipSize = 1 << 1,
		NonstandardBlockSize = 1 << 2,
	}

	internal static class SparseImageFormatFlagsExtensions
	{
		internal unsafe static SparseImageFormatFlags* MarshalTo(this SparseImageFormatFlags[] values)
		{
			throw new NotImplementedException();
		}
	}

	[Flags]
	public enum SparseMemoryBindFlags
	{
		None = 0,
		Metadata = 1 << 0,
	}

	internal static class SparseMemoryBindFlagsExtensions
	{
		internal unsafe static SparseMemoryBindFlags* MarshalTo(this SparseMemoryBindFlags[] values)
		{
			throw new NotImplementedException();
		}
	}

	[Flags]
	public enum StencilFaceFlags
	{
		None = 0,
		Front = 1 << 0,
		Back = 1 << 1,
		FrontAndBack = 0x00000003,
	}

	internal static class StencilFaceFlagsExtensions
	{
		internal unsafe static StencilFaceFlags* MarshalTo(this StencilFaceFlags[] values)
		{
			throw new NotImplementedException();
		}
	}

	[Flags]
	public enum SubpassDescriptionFlags
	{
		None = 0,
	}

	internal static class SubpassDescriptionFlagsExtensions
	{
		internal unsafe static SubpassDescriptionFlags* MarshalTo(this SubpassDescriptionFlags[] values)
		{
			throw new NotImplementedException();
		}
	}

	public enum AttachmentLoadOp
	{
		Load = 0,
		Clear = 1,
		DontCare = 2,
	}

	internal static class AttachmentLoadOpExtensions
	{
		internal unsafe static AttachmentLoadOp* MarshalTo(this AttachmentLoadOp[] values)
		{
			throw new NotImplementedException();
		}
	}

	public enum AttachmentStoreOp
	{
		Store = 0,
		DontCare = 1,
	}

	internal static class AttachmentStoreOpExtensions
	{
		internal unsafe static AttachmentStoreOp* MarshalTo(this AttachmentStoreOp[] values)
		{
			throw new NotImplementedException();
		}
	}

	public enum BlendFactor
	{
		Zero = 0,
		One = 1,
		SourceColor = 2,
		OneMinusSourceColor = 3,
		DestinationColor = 4,
		OneMinusDestinationColor = 5,
		SourceAlpha = 6,
		OneMinusSourceAlpha = 7,
		DestinationAlpha = 8,
		OneMinusDestinationAlpha = 9,
		ConstantColor = 10,
		OneMinusConstantColor = 11,
		ConstantAlpha = 12,
		OneMinusConstantAlpha = 13,
		SourceAlphaSaturate = 14,
		Src1Color = 15,
		OneMinusSrc1Color = 16,
		Src1Alpha = 17,
		OneMinusSrc1Alpha = 18,
	}

	internal static class BlendFactorExtensions
	{
		internal unsafe static BlendFactor* MarshalTo(this BlendFactor[] values)
		{
			throw new NotImplementedException();
		}
	}

	public enum BlendOp
	{
		Add = 0,
		Subtract = 1,
		ReverseSubtract = 2,
		Min = 3,
		Max = 4,
	}

	internal static class BlendOpExtensions
	{
		internal unsafe static BlendOp* MarshalTo(this BlendOp[] values)
		{
			throw new NotImplementedException();
		}
	}

	public enum BorderColor
	{
		FloatTransparentBlack = 0,
		IntTransparentBlack = 1,
		FloatOpaqueBlack = 2,
		IntOpaqueBlack = 3,
		FloatOpaqueWhite = 4,
		IntOpaqueWhite = 5,
	}

	internal static class BorderColorExtensions
	{
		internal unsafe static BorderColor* MarshalTo(this BorderColor[] values)
		{
			throw new NotImplementedException();
		}
	}

	public enum CommandBufferLevel
	{
		Primary = 0,
		Secondary = 1,
	}

	internal static class CommandBufferLevelExtensions
	{
		internal unsafe static CommandBufferLevel* MarshalTo(this CommandBufferLevel[] values)
		{
			throw new NotImplementedException();
		}
	}

	public enum CompareOp
	{
		Never = 0,
		Less = 1,
		Equal = 2,
		LessOrEqual = 3,
		Greater = 4,
		NotEqual = 5,
		GreaterOrEqual = 6,
		Always = 7,
	}

	internal static class CompareOpExtensions
	{
		internal unsafe static CompareOp* MarshalTo(this CompareOp[] values)
		{
			throw new NotImplementedException();
		}
	}

	public enum ComponentSwizzle
	{
		Identity = 0,
		Zero = 1,
		One = 2,
		R = 3,
		G = 4,
		B = 5,
		A = 6,
	}

	internal static class ComponentSwizzleExtensions
	{
		internal unsafe static ComponentSwizzle* MarshalTo(this ComponentSwizzle[] values)
		{
			throw new NotImplementedException();
		}
	}

	public enum DescriptorType
	{
		Sampler = 0,
		CombinedImageSampler = 1,
		SampledImage = 2,
		StorageImage = 3,
		UniformTexelBuffer = 4,
		StorageTexelBuffer = 5,
		UniformBuffer = 6,
		StorageBuffer = 7,
		UniformBufferDynamic = 8,
		StorageBufferDynamic = 9,
		InputAttachment = 10,
	}

	internal static class DescriptorTypeExtensions
	{
		internal unsafe static DescriptorType* MarshalTo(this DescriptorType[] values)
		{
			throw new NotImplementedException();
		}
	}

	public enum DynamicState
	{
		Viewport = 0,
		Scissor = 1,
		LineWidth = 2,
		DepthBias = 3,
		BlendConstants = 4,
		DepthBounds = 5,
		StencilCompareMask = 6,
		StencilWriteMask = 7,
		StencilReference = 8,
	}

	internal static class DynamicStateExtensions
	{
		internal unsafe static DynamicState* MarshalTo(this DynamicState[] values)
		{
			throw new NotImplementedException();
		}
	}

	public enum Filter
	{
		Nearest = 0,
		Linear = 1,
	}

	internal static class FilterExtensions
	{
		internal unsafe static Filter* MarshalTo(this Filter[] values)
		{
			throw new NotImplementedException();
		}
	}

	public enum Format
	{
		Undefined = 0,
		R4g4UnormPack8 = 1,
		R4g4b4a4UnormPack16 = 2,
		B4g4r4a4UnormPack16 = 3,
		R5g6b5UnormPack16 = 4,
		B5g6r5UnormPack16 = 5,
		R5g5b5a1UnormPack16 = 6,
		B5g5r5a1UnormPack16 = 7,
		A1r5g5b5UnormPack16 = 8,
		R8Unorm = 9,
		R8Snorm = 10,
		R8Uscaled = 11,
		R8Sscaled = 12,
		R8Uint = 13,
		R8Sint = 14,
		R8Srgb = 15,
		R8g8Unorm = 16,
		R8g8Snorm = 17,
		R8g8Uscaled = 18,
		R8g8Sscaled = 19,
		R8g8Uint = 20,
		R8g8Sint = 21,
		R8g8Srgb = 22,
		R8g8b8Unorm = 23,
		R8g8b8Snorm = 24,
		R8g8b8Uscaled = 25,
		R8g8b8Sscaled = 26,
		R8g8b8Uint = 27,
		R8g8b8Sint = 28,
		R8g8b8Srgb = 29,
		B8g8r8Unorm = 30,
		B8g8r8Snorm = 31,
		B8g8r8Uscaled = 32,
		B8g8r8Sscaled = 33,
		B8g8r8Uint = 34,
		B8g8r8Sint = 35,
		B8g8r8Srgb = 36,
		R8g8b8a8Unorm = 37,
		R8g8b8a8Snorm = 38,
		R8g8b8a8Uscaled = 39,
		R8g8b8a8Sscaled = 40,
		R8g8b8a8Uint = 41,
		R8g8b8a8Sint = 42,
		R8g8b8a8Srgb = 43,
		B8g8r8a8Unorm = 44,
		B8g8r8a8Snorm = 45,
		B8g8r8a8Uscaled = 46,
		B8g8r8a8Sscaled = 47,
		B8g8r8a8Uint = 48,
		B8g8r8a8Sint = 49,
		B8g8r8a8Srgb = 50,
		A8b8g8r8UnormPack32 = 51,
		A8b8g8r8SnormPack32 = 52,
		A8b8g8r8UscaledPack32 = 53,
		A8b8g8r8SscaledPack32 = 54,
		A8b8g8r8UintPack32 = 55,
		A8b8g8r8SintPack32 = 56,
		A8b8g8r8SrgbPack32 = 57,
		A2r10g10b10UnormPack32 = 58,
		A2r10g10b10SnormPack32 = 59,
		A2r10g10b10UscaledPack32 = 60,
		A2r10g10b10SscaledPack32 = 61,
		A2r10g10b10UintPack32 = 62,
		A2r10g10b10SintPack32 = 63,
		A2b10g10r10UnormPack32 = 64,
		A2b10g10r10SnormPack32 = 65,
		A2b10g10r10UscaledPack32 = 66,
		A2b10g10r10SscaledPack32 = 67,
		A2b10g10r10UintPack32 = 68,
		A2b10g10r10SintPack32 = 69,
		R16Unorm = 70,
		R16Snorm = 71,
		R16Uscaled = 72,
		R16Sscaled = 73,
		R16Uint = 74,
		R16Sint = 75,
		R16Sfloat = 76,
		R16g16Unorm = 77,
		R16g16Snorm = 78,
		R16g16Uscaled = 79,
		R16g16Sscaled = 80,
		R16g16Uint = 81,
		R16g16Sint = 82,
		R16g16Sfloat = 83,
		R16g16b16Unorm = 84,
		R16g16b16Snorm = 85,
		R16g16b16Uscaled = 86,
		R16g16b16Sscaled = 87,
		R16g16b16Uint = 88,
		R16g16b16Sint = 89,
		R16g16b16Sfloat = 90,
		R16g16b16a16Unorm = 91,
		R16g16b16a16Snorm = 92,
		R16g16b16a16Uscaled = 93,
		R16g16b16a16Sscaled = 94,
		R16g16b16a16Uint = 95,
		R16g16b16a16Sint = 96,
		R16g16b16a16Sfloat = 97,
		R32Uint = 98,
		R32Sint = 99,
		R32Sfloat = 100,
		R32g32Uint = 101,
		R32g32Sint = 102,
		R32g32Sfloat = 103,
		R32g32b32Uint = 104,
		R32g32b32Sint = 105,
		R32g32b32Sfloat = 106,
		R32g32b32a32Uint = 107,
		R32g32b32a32Sint = 108,
		R32g32b32a32Sfloat = 109,
		R64Uint = 110,
		R64Sint = 111,
		R64Sfloat = 112,
		R64g64Uint = 113,
		R64g64Sint = 114,
		R64g64Sfloat = 115,
		R64g64b64Uint = 116,
		R64g64b64Sint = 117,
		R64g64b64Sfloat = 118,
		R64g64b64a64Uint = 119,
		R64g64b64a64Sint = 120,
		R64g64b64a64Sfloat = 121,
		B10g11r11UfloatPack32 = 122,
		E5b9g9r9UfloatPack32 = 123,
		D16Unorm = 124,
		X8D24UnormPack32 = 125,
		D32Sfloat = 126,
		S8Uint = 127,
		D16UnormS8Uint = 128,
		D24UnormS8Uint = 129,
		D32SfloatS8Uint = 130,
		Bc1RgbUnormBlock = 131,
		Bc1RgbSrgbBlock = 132,
		Bc1RgbaUnormBlock = 133,
		Bc1RgbaSrgbBlock = 134,
		Bc2UnormBlock = 135,
		Bc2SrgbBlock = 136,
		Bc3UnormBlock = 137,
		Bc3SrgbBlock = 138,
		Bc4UnormBlock = 139,
		Bc4SnormBlock = 140,
		Bc5UnormBlock = 141,
		Bc5SnormBlock = 142,
		Bc6hUfloatBlock = 143,
		Bc6hSfloatBlock = 144,
		Bc7UnormBlock = 145,
		Bc7SrgbBlock = 146,
		Etc2R8g8b8UnormBlock = 147,
		Etc2R8g8b8SrgbBlock = 148,
		Etc2R8g8b8a1UnormBlock = 149,
		Etc2R8g8b8a1SrgbBlock = 150,
		Etc2R8g8b8a8UnormBlock = 151,
		Etc2R8g8b8a8SrgbBlock = 152,
		EacR11UnormBlock = 153,
		EacR11SnormBlock = 154,
		EacR11g11UnormBlock = 155,
		EacR11g11SnormBlock = 156,
		Astc4x4UnormBlock = 157,
		Astc4x4SrgbBlock = 158,
		Astc5x4UnormBlock = 159,
		Astc5x4SrgbBlock = 160,
		Astc5x5UnormBlock = 161,
		Astc5x5SrgbBlock = 162,
		Astc6x5UnormBlock = 163,
		Astc6x5SrgbBlock = 164,
		Astc6x6UnormBlock = 165,
		Astc6x6SrgbBlock = 166,
		Astc8x5UnormBlock = 167,
		Astc8x5SrgbBlock = 168,
		Astc8x6UnormBlock = 169,
		Astc8x6SrgbBlock = 170,
		Astc8x8UnormBlock = 171,
		Astc8x8SrgbBlock = 172,
		Astc10x5UnormBlock = 173,
		Astc10x5SrgbBlock = 174,
		Astc10x6UnormBlock = 175,
		Astc10x6SrgbBlock = 176,
		Astc10x8UnormBlock = 177,
		Astc10x8SrgbBlock = 178,
		Astc10x10UnormBlock = 179,
		Astc10x10SrgbBlock = 180,
		Astc12x10UnormBlock = 181,
		Astc12x10SrgbBlock = 182,
		Astc12x12UnormBlock = 183,
		Astc12x12SrgbBlock = 184,
	}

	internal static class FormatExtensions
	{
		internal unsafe static Format* MarshalTo(this Format[] values)
		{
			throw new NotImplementedException();
		}
	}

	public enum FrontFace
	{
		CounterClockwise = 0,
		Clockwise = 1,
	}

	internal static class FrontFaceExtensions
	{
		internal unsafe static FrontFace* MarshalTo(this FrontFace[] values)
		{
			throw new NotImplementedException();
		}
	}

	public enum ImageLayout
	{
		Undefined = 0,
		General = 1,
		ColorAttachmentOptimal = 2,
		DepthStencilAttachmentOptimal = 3,
		DepthStencilReadOnlyOptimal = 4,
		ShaderReadOnlyOptimal = 5,
		TransferSourceOptimal = 6,
		TransferDestinationOptimal = 7,
		Preinitialized = 8,
	}

	internal static class ImageLayoutExtensions
	{
		internal unsafe static ImageLayout* MarshalTo(this ImageLayout[] values)
		{
			throw new NotImplementedException();
		}
	}

	public enum ImageTiling
	{
		Optimal = 0,
		Linear = 1,
	}

	internal static class ImageTilingExtensions
	{
		internal unsafe static ImageTiling* MarshalTo(this ImageTiling[] values)
		{
			throw new NotImplementedException();
		}
	}

	public enum ImageType
	{
		Image1d = 0,
		Image2d = 1,
		Image3d = 2,
	}

	internal static class ImageTypeExtensions
	{
		internal unsafe static ImageType* MarshalTo(this ImageType[] values)
		{
			throw new NotImplementedException();
		}
	}

	public enum ImageViewType
	{
		ImageView1d = 0,
		ImageView2d = 1,
		ImageView3d = 2,
		Cube = 3,
		ImageView1dArray = 4,
		ImageView2dArray = 5,
		CubeArray = 6,
	}

	internal static class ImageViewTypeExtensions
	{
		internal unsafe static ImageViewType* MarshalTo(this ImageViewType[] values)
		{
			throw new NotImplementedException();
		}
	}

	public enum IndexType
	{
		Uint16 = 0,
		Uint32 = 1,
	}

	internal static class IndexTypeExtensions
	{
		internal unsafe static IndexType* MarshalTo(this IndexType[] values)
		{
			throw new NotImplementedException();
		}
	}

	public enum LogicOp
	{
		Clear = 0,
		And = 1,
		AndReverse = 2,
		Copy = 3,
		AndInverted = 4,
		NoOp = 5,
		Xor = 6,
		Or = 7,
		Nor = 8,
		Equivalent = 9,
		Invert = 10,
		OrReverse = 11,
		CopyInverted = 12,
		OrInverted = 13,
		Nand = 14,
		Set = 15,
	}

	internal static class LogicOpExtensions
	{
		internal unsafe static LogicOp* MarshalTo(this LogicOp[] values)
		{
			throw new NotImplementedException();
		}
	}

	public enum PhysicalDeviceType
	{
		Other = 0,
		IntegratedGpu = 1,
		DiscreteGpu = 2,
		VirtualGpu = 3,
		Cpu = 4,
	}

	internal static class PhysicalDeviceTypeExtensions
	{
		internal unsafe static PhysicalDeviceType* MarshalTo(this PhysicalDeviceType[] values)
		{
			throw new NotImplementedException();
		}
	}

	public enum PipelineBindPoint
	{
		Graphics = 0,
		Compute = 1,
	}

	internal static class PipelineBindPointExtensions
	{
		internal unsafe static PipelineBindPoint* MarshalTo(this PipelineBindPoint[] values)
		{
			throw new NotImplementedException();
		}
	}

	public enum PipelineCacheHeaderVersion
	{
		One = 1,
	}

	internal static class PipelineCacheHeaderVersionExtensions
	{
		internal unsafe static PipelineCacheHeaderVersion* MarshalTo(this PipelineCacheHeaderVersion[] values)
		{
			throw new NotImplementedException();
		}
	}

	public enum PolygonMode
	{
		Fill = 0,
		Line = 1,
		Point = 2,
	}

	internal static class PolygonModeExtensions
	{
		internal unsafe static PolygonMode* MarshalTo(this PolygonMode[] values)
		{
			throw new NotImplementedException();
		}
	}

	public enum PrimitiveTopology
	{
		PointList = 0,
		LineList = 1,
		LineStrip = 2,
		TriangleList = 3,
		TriangleStrip = 4,
		TriangleFan = 5,
		LineListWithAdjacency = 6,
		LineStripWithAdjacency = 7,
		TriangleListWithAdjacency = 8,
		TriangleStripWithAdjacency = 9,
		PatchList = 10,
	}

	internal static class PrimitiveTopologyExtensions
	{
		internal unsafe static PrimitiveTopology* MarshalTo(this PrimitiveTopology[] values)
		{
			throw new NotImplementedException();
		}
	}

	public enum QueryType
	{
		Occlusion = 0,
		PipelineStatistics = 1,
		Timestamp = 2,
	}

	internal static class QueryTypeExtensions
	{
		internal unsafe static QueryType* MarshalTo(this QueryType[] values)
		{
			throw new NotImplementedException();
		}
	}

	public enum Result
	{
		Success = 0,
		NotReady = 1,
		Timeout = 2,
		EventSet = 3,
		EventReset = 4,
		Incomplete = 5,
		ErrorOutOfHostMemory = -1,
		ErrorOutOfDeviceMemory = -2,
		ErrorInitializationFailed = -3,
		ErrorDeviceLost = -4,
		ErrorMemoryMapFailed = -5,
		ErrorLayerNotPresent = -6,
		ErrorExtensionNotPresent = -7,
		ErrorFeatureNotPresent = -8,
		ErrorIncompatibleDriver = -9,
		ErrorTooManyObjects = -10,
		ErrorFormatNotSupported = -11,
	}

	internal static class ResultExtensions
	{
		internal unsafe static Result* MarshalTo(this Result[] values)
		{
			throw new NotImplementedException();
		}
	}

	public enum SamplerAddressMode
	{
		Repeat = 0,
		MirroredRepeat = 1,
		ClampToEdge = 2,
		ClampToBorder = 3,
	}

	internal static class SamplerAddressModeExtensions
	{
		internal unsafe static SamplerAddressMode* MarshalTo(this SamplerAddressMode[] values)
		{
			throw new NotImplementedException();
		}
	}

	public enum SamplerMipmapMode
	{
		Nearest = 0,
		Linear = 1,
	}

	internal static class SamplerMipmapModeExtensions
	{
		internal unsafe static SamplerMipmapMode* MarshalTo(this SamplerMipmapMode[] values)
		{
			throw new NotImplementedException();
		}
	}

	public enum SharingMode
	{
		Exclusive = 0,
		Concurrent = 1,
	}

	internal static class SharingModeExtensions
	{
		internal unsafe static SharingMode* MarshalTo(this SharingMode[] values)
		{
			throw new NotImplementedException();
		}
	}

	public enum StencilOp
	{
		Keep = 0,
		Zero = 1,
		Replace = 2,
		IncrementAndClamp = 3,
		DecrementAndClamp = 4,
		Invert = 5,
		IncrementAndWrap = 6,
		DecrementAndWrap = 7,
	}

	internal static class StencilOpExtensions
	{
		internal unsafe static StencilOp* MarshalTo(this StencilOp[] values)
		{
			throw new NotImplementedException();
		}
	}

	public enum StructureType
	{
		ApplicationInfo = 0,
		InstanceCreateInfo = 1,
		DeviceQueueCreateInfo = 2,
		DeviceCreateInfo = 3,
		SubmitInfo = 4,
		MemoryAllocateInfo = 5,
		MappedMemoryRange = 6,
		BindSparseInfo = 7,
		FenceCreateInfo = 8,
		SemaphoreCreateInfo = 9,
		EventCreateInfo = 10,
		QueryPoolCreateInfo = 11,
		BufferCreateInfo = 12,
		BufferViewCreateInfo = 13,
		ImageCreateInfo = 14,
		ImageViewCreateInfo = 15,
		ShaderModuleCreateInfo = 16,
		PipelineCacheCreateInfo = 17,
		PipelineShaderStageCreateInfo = 18,
		PipelineVertexInputStateCreateInfo = 19,
		PipelineInputAssemblyStateCreateInfo = 20,
		PipelineTessellationStateCreateInfo = 21,
		PipelineViewportStateCreateInfo = 22,
		PipelineRasterizationStateCreateInfo = 23,
		PipelineMultisampleStateCreateInfo = 24,
		PipelineDepthStencilStateCreateInfo = 25,
		PipelineColorBlendStateCreateInfo = 26,
		PipelineDynamicStateCreateInfo = 27,
		GraphicsPipelineCreateInfo = 28,
		ComputePipelineCreateInfo = 29,
		PipelineLayoutCreateInfo = 30,
		SamplerCreateInfo = 31,
		DescriptorSetLayoutCreateInfo = 32,
		DescriptorPoolCreateInfo = 33,
		DescriptorSetAllocateInfo = 34,
		WriteDescriptorSet = 35,
		CopyDescriptorSet = 36,
		FramebufferCreateInfo = 37,
		RenderPassCreateInfo = 38,
		CommandPoolCreateInfo = 39,
		CommandBufferAllocateInfo = 40,
		CommandBufferInheritanceInfo = 41,
		CommandBufferBeginInfo = 42,
		RenderPassBeginInfo = 43,
		BufferMemoryBarrier = 44,
		ImageMemoryBarrier = 45,
		MemoryBarrier = 46,
		LoaderInstanceCreateInfo = 47,
		LoaderDeviceCreateInfo = 48,
	}

	internal static class StructureTypeExtensions
	{
		internal unsafe static StructureType* MarshalTo(this StructureType[] values)
		{
			throw new NotImplementedException();
		}
	}

	public enum SubpassContents
	{
		Inline = 0,
		SecondaryCommandBuffers = 1,
	}

	internal static class SubpassContentsExtensions
	{
		internal unsafe static SubpassContents* MarshalTo(this SubpassContents[] values)
		{
			throw new NotImplementedException();
		}
	}

	public enum VertexInputRate
	{
		Vertex = 0,
		Instance = 1,
	}

	internal static class VertexInputRateExtensions
	{
		internal unsafe static VertexInputRate* MarshalTo(this VertexInputRate[] values)
		{
			throw new NotImplementedException();
		}
	}
}