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

	public class AllocationCallbacks
	{
	}

	public class ApplicationInfo
	{
		public string ApplicationName
		{
			get;
			set;
		}

		public uint ApplicationVersion
		{
			get;
			set;
		}

		public string EngineName
		{
			get;
			set;
		}

		public uint EngineVersion
		{
			get;
			set;
		}

		public uint ApiVersion
		{
			get;
			set;
		}

	}

	public class BindSparseInfo
	{
		public Semaphore[] WaitSemaphores
		{
			get;
			set;
		}

		public SparseBufferMemoryBindInfo[] BufferBinds
		{
			get;
			set;
		}

		public SparseImageOpaqueMemoryBindInfo[] ImageOpaqueBinds
		{
			get;
			set;
		}

		public SparseImageMemoryBindInfo[] ImageBinds
		{
			get;
			set;
		}

		public Semaphore[] SignalSemaphores
		{
			get;
			set;
		}

	}

	public class BufferCreateInfo
	{
		public BufferCreateFlags Flags
		{
			get;
			set;
		}

		public DeviceSize Size
		{
			get;
			set;
		}

		public BufferUsageFlags Usage
		{
			get;
			set;
		}

		public SharingMode SharingMode
		{
			get;
			set;
		}

		public uint[] QueueFamilyIndices
		{
			get;
			set;
		}

	}

	public class BufferMemoryBarrier
	{
		public AccessFlags SourceAccessMask
		{
			get;
			set;
		}

		public AccessFlags DestinationAccessMask
		{
			get;
			set;
		}

		public uint SourceQueueFamilyIndex
		{
			get;
			set;
		}

		public uint DestinationQueueFamilyIndex
		{
			get;
			set;
		}

		public Buffer Buffer
		{
			get;
			set;
		}

		public DeviceSize Offset
		{
			get;
			set;
		}

		public DeviceSize Size
		{
			get;
			set;
		}

	}

	public class BufferViewCreateInfo
	{
		public BufferViewCreateFlags Flags
		{
			get;
			set;
		}

		public Buffer Buffer
		{
			get;
			set;
		}

		public Format Format
		{
			get;
			set;
		}

		public DeviceSize Offset
		{
			get;
			set;
		}

		public DeviceSize Range
		{
			get;
			set;
		}

	}

	public class CommandBufferAllocateInfo
	{
		public CommandPool CommandPool
		{
			get;
			set;
		}

		public CommandBufferLevel Level
		{
			get;
			set;
		}

		public uint CommandBufferCount
		{
			get;
			set;
		}

	}

	public class CommandBufferBeginInfo
	{
		public CommandBufferUsageFlags Flags
		{
			get;
			set;
		}

	}

	public class CommandBufferInheritanceInfo
	{
		public RenderPass RenderPass
		{
			get;
			set;
		}

		public uint Subpass
		{
			get;
			set;
		}

		public Framebuffer Framebuffer
		{
			get;
			set;
		}

		public Bool32 OcclusionQueryEnable
		{
			get;
			set;
		}

		public QueryControlFlags QueryFlags
		{
			get;
			set;
		}

		public QueryPipelineStatisticFlags PipelineStatistics
		{
			get;
			set;
		}

	}

	public class CommandPoolCreateInfo
	{
		public CommandPoolCreateFlags Flags
		{
			get;
			set;
		}

		public uint QueueFamilyIndex
		{
			get;
			set;
		}

	}

	public class ComputePipelineCreateInfo
	{
		public PipelineCreateFlags Flags
		{
			get;
			set;
		}

		public PipelineShaderStageCreateInfo Stage
		{
			get;
			set;
		}

		public PipelineLayout Layout
		{
			get;
			set;
		}

		public Pipeline BasePipelineHandle
		{
			get;
			set;
		}

		public int BasePipelineIndex
		{
			get;
			set;
		}

	}

	public class CopyDescriptorSet
	{
		public DescriptorSet SourceSet
		{
			get;
			set;
		}

		public uint SourceBinding
		{
			get;
			set;
		}

		public uint SourceArrayElement
		{
			get;
			set;
		}

		public DescriptorSet DestinationSet
		{
			get;
			set;
		}

		public uint DestinationBinding
		{
			get;
			set;
		}

		public uint DestinationArrayElement
		{
			get;
			set;
		}

		public uint DescriptorCount
		{
			get;
			set;
		}

	}

	public class DescriptorBufferInfo
	{
		public Buffer Buffer
		{
			get;
			set;
		}

		public DeviceSize Offset
		{
			get;
			set;
		}

		public DeviceSize Range
		{
			get;
			set;
		}

	}

	public class DescriptorImageInfo
	{
		public Sampler Sampler
		{
			get;
			set;
		}

		public ImageView ImageView
		{
			get;
			set;
		}

		public ImageLayout ImageLayout
		{
			get;
			set;
		}

	}

	public class DescriptorPoolCreateInfo
	{
		public DescriptorPoolCreateFlags Flags
		{
			get;
			set;
		}

		public uint MaxSets
		{
			get;
			set;
		}

		public DescriptorPoolSize[] PoolSizes
		{
			get;
			set;
		}

	}

	public class DescriptorSetAllocateInfo
	{
		public DescriptorPool DescriptorPool
		{
			get;
			set;
		}

		public DescriptorSetLayout[] SetLayouts
		{
			get;
			set;
		}

	}

	public class DescriptorSetLayoutBinding
	{
		public uint Binding
		{
			get;
			set;
		}

		public DescriptorType DescriptorType
		{
			get;
			set;
		}

		public ShaderStageFlags StageFlags
		{
			get;
			set;
		}

		public Sampler[] ImmutableSamplers
		{
			get;
			set;
		}

	}

	public class DescriptorSetLayoutCreateInfo
	{
		public DescriptorSetLayoutCreateFlags Flags
		{
			get;
			set;
		}

		public DescriptorSetLayoutBinding[] Bindings
		{
			get;
			set;
		}

	}

	public class DeviceCreateInfo
	{
		public DeviceCreateFlags Flags
		{
			get;
			set;
		}

		public DeviceQueueCreateInfo[] QueueCreateInfos
		{
			get;
			set;
		}

		public string[] EnabledLayerNames
		{
			get;
			set;
		}

		public string[] EnabledExtensionNames
		{
			get;
			set;
		}

	}

	public class DeviceQueueCreateInfo
	{
		public DeviceQueueCreateFlags Flags
		{
			get;
			set;
		}

		public uint QueueFamilyIndex
		{
			get;
			set;
		}

		public float[] QueuePriorities
		{
			get;
			set;
		}

	}

	public class EventCreateInfo
	{
		public EventCreateFlags Flags
		{
			get;
			set;
		}

	}

	public class ExtensionProperties
	{
		public char ExtensionName
		{
			get;
			set;
		}

		public uint SpecVersion
		{
			get;
			set;
		}

	}

	public class FenceCreateInfo
	{
		public FenceCreateFlags Flags
		{
			get;
			set;
		}

	}

	public class FramebufferCreateInfo
	{
		public FramebufferCreateFlags Flags
		{
			get;
			set;
		}

		public RenderPass RenderPass
		{
			get;
			set;
		}

		public ImageView[] Attachments
		{
			get;
			set;
		}

		public uint Width
		{
			get;
			set;
		}

		public uint Height
		{
			get;
			set;
		}

		public uint Layers
		{
			get;
			set;
		}

	}

	public class GraphicsPipelineCreateInfo
	{
		public PipelineCreateFlags Flags
		{
			get;
			set;
		}

		public PipelineShaderStageCreateInfo[] Stages
		{
			get;
			set;
		}

		public PipelineLayout Layout
		{
			get;
			set;
		}

		public RenderPass RenderPass
		{
			get;
			set;
		}

		public uint Subpass
		{
			get;
			set;
		}

		public Pipeline BasePipelineHandle
		{
			get;
			set;
		}

		public int BasePipelineIndex
		{
			get;
			set;
		}

	}

	public class ImageBlit
	{
		public ImageSubresourceLayers SourceSubresource
		{
			get;
			set;
		}

		public Offset3D SourceOffsets
		{
			get;
			set;
		}

		public ImageSubresourceLayers DestinationSubresource
		{
			get;
			set;
		}

		public Offset3D DestinationOffsets
		{
			get;
			set;
		}

	}

	public class ImageCreateInfo
	{
		public ImageCreateFlags Flags
		{
			get;
			set;
		}

		public ImageType ImageType
		{
			get;
			set;
		}

		public Format Format
		{
			get;
			set;
		}

		public Extent3D Extent
		{
			get;
			set;
		}

		public uint MipLevels
		{
			get;
			set;
		}

		public uint ArrayLayers
		{
			get;
			set;
		}

		public SampleCountFlags Samples
		{
			get;
			set;
		}

		public ImageTiling Tiling
		{
			get;
			set;
		}

		public ImageUsageFlags Usage
		{
			get;
			set;
		}

		public SharingMode SharingMode
		{
			get;
			set;
		}

		public uint[] QueueFamilyIndices
		{
			get;
			set;
		}

		public ImageLayout InitialLayout
		{
			get;
			set;
		}

	}

	public class ImageMemoryBarrier
	{
		public AccessFlags SourceAccessMask
		{
			get;
			set;
		}

		public AccessFlags DestinationAccessMask
		{
			get;
			set;
		}

		public ImageLayout OldLayout
		{
			get;
			set;
		}

		public ImageLayout NewLayout
		{
			get;
			set;
		}

		public uint SourceQueueFamilyIndex
		{
			get;
			set;
		}

		public uint DestinationQueueFamilyIndex
		{
			get;
			set;
		}

		public Image Image
		{
			get;
			set;
		}

		public ImageSubresourceRange SubresourceRange
		{
			get;
			set;
		}

	}

	public class ImageViewCreateInfo
	{
		public ImageViewCreateFlags Flags
		{
			get;
			set;
		}

		public Image Image
		{
			get;
			set;
		}

		public ImageViewType ViewType
		{
			get;
			set;
		}

		public Format Format
		{
			get;
			set;
		}

		public ComponentMapping Components
		{
			get;
			set;
		}

		public ImageSubresourceRange SubresourceRange
		{
			get;
			set;
		}

	}

	public class InstanceCreateInfo
	{
		public InstanceCreateFlags Flags
		{
			get;
			set;
		}

		public string[] EnabledLayerNames
		{
			get;
			set;
		}

		public string[] EnabledExtensionNames
		{
			get;
			set;
		}

	}

	public class LayerProperties
	{
		public char LayerName
		{
			get;
			set;
		}

		public uint SpecVersion
		{
			get;
			set;
		}

		public uint ImplementationVersion
		{
			get;
			set;
		}

		public char Description
		{
			get;
			set;
		}

	}

	public class MappedMemoryRange
	{
		public DeviceMemory Memory
		{
			get;
			set;
		}

		public DeviceSize Offset
		{
			get;
			set;
		}

		public DeviceSize Size
		{
			get;
			set;
		}

	}

	public class MemoryAllocateInfo
	{
		public DeviceSize AllocationSize
		{
			get;
			set;
		}

		public uint MemoryTypeIndex
		{
			get;
			set;
		}

	}

	public class MemoryBarrier
	{
		public AccessFlags SourceAccessMask
		{
			get;
			set;
		}

		public AccessFlags DestinationAccessMask
		{
			get;
			set;
		}

	}

	public class PhysicalDeviceLimits
	{
		public uint MaxImageDimension1D
		{
			get;
			set;
		}

		public uint MaxImageDimension2D
		{
			get;
			set;
		}

		public uint MaxImageDimension3D
		{
			get;
			set;
		}

		public uint MaxImageDimensionCube
		{
			get;
			set;
		}

		public uint MaxImageArrayLayers
		{
			get;
			set;
		}

		public uint MaxTexelBufferElements
		{
			get;
			set;
		}

		public uint MaxUniformBufferRange
		{
			get;
			set;
		}

		public uint MaxStorageBufferRange
		{
			get;
			set;
		}

		public uint MaxPushConstantsSize
		{
			get;
			set;
		}

		public uint MaxMemoryAllocationCount
		{
			get;
			set;
		}

		public uint MaxSamplerAllocationCount
		{
			get;
			set;
		}

		public DeviceSize BufferImageGranularity
		{
			get;
			set;
		}

		public DeviceSize SparseAddressSpaceSize
		{
			get;
			set;
		}

		public uint MaxBoundDescriptorSets
		{
			get;
			set;
		}

		public uint MaxPerStageDescriptorSamplers
		{
			get;
			set;
		}

		public uint MaxPerStageDescriptorUniformBuffers
		{
			get;
			set;
		}

		public uint MaxPerStageDescriptorStorageBuffers
		{
			get;
			set;
		}

		public uint MaxPerStageDescriptorSampledImages
		{
			get;
			set;
		}

		public uint MaxPerStageDescriptorStorageImages
		{
			get;
			set;
		}

		public uint MaxPerStageDescriptorInputAttachments
		{
			get;
			set;
		}

		public uint MaxPerStageResources
		{
			get;
			set;
		}

		public uint MaxDescriptorSetSamplers
		{
			get;
			set;
		}

		public uint MaxDescriptorSetUniformBuffers
		{
			get;
			set;
		}

		public uint MaxDescriptorSetUniformBuffersDynamic
		{
			get;
			set;
		}

		public uint MaxDescriptorSetStorageBuffers
		{
			get;
			set;
		}

		public uint MaxDescriptorSetStorageBuffersDynamic
		{
			get;
			set;
		}

		public uint MaxDescriptorSetSampledImages
		{
			get;
			set;
		}

		public uint MaxDescriptorSetStorageImages
		{
			get;
			set;
		}

		public uint MaxDescriptorSetInputAttachments
		{
			get;
			set;
		}

		public uint MaxVertexInputAttributes
		{
			get;
			set;
		}

		public uint MaxVertexInputBindings
		{
			get;
			set;
		}

		public uint MaxVertexInputAttributeOffset
		{
			get;
			set;
		}

		public uint MaxVertexInputBindingStride
		{
			get;
			set;
		}

		public uint MaxVertexOutputComponents
		{
			get;
			set;
		}

		public uint MaxTessellationGenerationLevel
		{
			get;
			set;
		}

		public uint MaxTessellationPatchSize
		{
			get;
			set;
		}

		public uint MaxTessellationControlPerVertexInputComponents
		{
			get;
			set;
		}

		public uint MaxTessellationControlPerVertexOutputComponents
		{
			get;
			set;
		}

		public uint MaxTessellationControlPerPatchOutputComponents
		{
			get;
			set;
		}

		public uint MaxTessellationControlTotalOutputComponents
		{
			get;
			set;
		}

		public uint MaxTessellationEvaluationInputComponents
		{
			get;
			set;
		}

		public uint MaxTessellationEvaluationOutputComponents
		{
			get;
			set;
		}

		public uint MaxGeometryShaderInvocations
		{
			get;
			set;
		}

		public uint MaxGeometryInputComponents
		{
			get;
			set;
		}

		public uint MaxGeometryOutputComponents
		{
			get;
			set;
		}

		public uint MaxGeometryOutputVertices
		{
			get;
			set;
		}

		public uint MaxGeometryTotalOutputComponents
		{
			get;
			set;
		}

		public uint MaxFragmentInputComponents
		{
			get;
			set;
		}

		public uint MaxFragmentOutputAttachments
		{
			get;
			set;
		}

		public uint MaxFragmentDualSourceAttachments
		{
			get;
			set;
		}

		public uint MaxFragmentCombinedOutputResources
		{
			get;
			set;
		}

		public uint MaxComputeSharedMemorySize
		{
			get;
			set;
		}

		public uint MaxComputeWorkGroupCount
		{
			get;
			set;
		}

		public uint MaxComputeWorkGroupInvocations
		{
			get;
			set;
		}

		public uint MaxComputeWorkGroupSize
		{
			get;
			set;
		}

		public uint SubPixelPrecisionBits
		{
			get;
			set;
		}

		public uint SubTexelPrecisionBits
		{
			get;
			set;
		}

		public uint MipmapPrecisionBits
		{
			get;
			set;
		}

		public uint MaxDrawIndexedIndexValue
		{
			get;
			set;
		}

		public uint MaxDrawIndirectCount
		{
			get;
			set;
		}

		public float MaxSamplerLodBias
		{
			get;
			set;
		}

		public float MaxSamplerAnisotropy
		{
			get;
			set;
		}

		public uint MaxViewports
		{
			get;
			set;
		}

		public uint MaxViewportDimensions
		{
			get;
			set;
		}

		public float ViewportBoundsRange
		{
			get;
			set;
		}

		public uint ViewportSubPixelBits
		{
			get;
			set;
		}

		public UIntPtr MinMemoryMapAlignment
		{
			get;
			set;
		}

		public DeviceSize MinTexelBufferOffsetAlignment
		{
			get;
			set;
		}

		public DeviceSize MinUniformBufferOffsetAlignment
		{
			get;
			set;
		}

		public DeviceSize MinStorageBufferOffsetAlignment
		{
			get;
			set;
		}

		public int MinTexelOffset
		{
			get;
			set;
		}

		public uint MaxTexelOffset
		{
			get;
			set;
		}

		public int MinTexelGatherOffset
		{
			get;
			set;
		}

		public uint MaxTexelGatherOffset
		{
			get;
			set;
		}

		public float MinInterpolationOffset
		{
			get;
			set;
		}

		public float MaxInterpolationOffset
		{
			get;
			set;
		}

		public uint SubPixelInterpolationOffsetBits
		{
			get;
			set;
		}

		public uint MaxFramebufferWidth
		{
			get;
			set;
		}

		public uint MaxFramebufferHeight
		{
			get;
			set;
		}

		public uint MaxFramebufferLayers
		{
			get;
			set;
		}

		public SampleCountFlags FramebufferColorSampleCounts
		{
			get;
			set;
		}

		public SampleCountFlags FramebufferDepthSampleCounts
		{
			get;
			set;
		}

		public SampleCountFlags FramebufferStencilSampleCounts
		{
			get;
			set;
		}

		public SampleCountFlags FramebufferNoAttachmentsSampleCounts
		{
			get;
			set;
		}

		public uint MaxColorAttachments
		{
			get;
			set;
		}

		public SampleCountFlags SampledImageColorSampleCounts
		{
			get;
			set;
		}

		public SampleCountFlags SampledImageIntegerSampleCounts
		{
			get;
			set;
		}

		public SampleCountFlags SampledImageDepthSampleCounts
		{
			get;
			set;
		}

		public SampleCountFlags SampledImageStencilSampleCounts
		{
			get;
			set;
		}

		public SampleCountFlags StorageImageSampleCounts
		{
			get;
			set;
		}

		public uint MaxSampleMaskWords
		{
			get;
			set;
		}

		public Bool32 TimestampComputeAndGraphics
		{
			get;
			set;
		}

		public float TimestampPeriod
		{
			get;
			set;
		}

		public uint MaxClipDistances
		{
			get;
			set;
		}

		public uint MaxCullDistances
		{
			get;
			set;
		}

		public uint MaxCombinedClipAndCullDistances
		{
			get;
			set;
		}

		public uint DiscreteQueuePriorities
		{
			get;
			set;
		}

		public float PointSizeRange
		{
			get;
			set;
		}

		public float LineWidthRange
		{
			get;
			set;
		}

		public float PointSizeGranularity
		{
			get;
			set;
		}

		public float LineWidthGranularity
		{
			get;
			set;
		}

		public Bool32 StrictLines
		{
			get;
			set;
		}

		public Bool32 StandardSampleLocations
		{
			get;
			set;
		}

		public DeviceSize OptimalBufferCopyOffsetAlignment
		{
			get;
			set;
		}

		public DeviceSize OptimalBufferCopyRowPitchAlignment
		{
			get;
			set;
		}

		public DeviceSize NonCoherentAtomSize
		{
			get;
			set;
		}

	}

	public class PhysicalDeviceMemoryProperties
	{
		public uint MemoryTypeCount
		{
			get;
			set;
		}

		public MemoryType MemoryTypes
		{
			get;
			set;
		}

		public uint MemoryHeapCount
		{
			get;
			set;
		}

		public MemoryHeap MemoryHeaps
		{
			get;
			set;
		}

	}

	public class PhysicalDeviceProperties
	{
		public uint ApiVersion
		{
			get;
			set;
		}

		public uint DriverVersion
		{
			get;
			set;
		}

		public uint Vendor
		{
			get;
			set;
		}

		public uint Device
		{
			get;
			set;
		}

		public PhysicalDeviceType DeviceType
		{
			get;
			set;
		}

		public char DeviceName
		{
			get;
			set;
		}

		public byte PipelineCache
		{
			get;
			set;
		}

		public PhysicalDeviceLimits Limits
		{
			get;
			set;
		}

		public PhysicalDeviceSparseProperties SparseProperties
		{
			get;
			set;
		}

	}

	public class PipelineCacheCreateInfo
	{
		public PipelineCacheCreateFlags Flags
		{
			get;
			set;
		}

		public byte[] InitialData
		{
			get;
			set;
		}

	}

	public class PipelineColorBlendStateCreateInfo
	{
		public PipelineColorBlendStateCreateFlags Flags
		{
			get;
			set;
		}

		public Bool32 LogicOpEnable
		{
			get;
			set;
		}

		public LogicOp LogicOp
		{
			get;
			set;
		}

		public PipelineColorBlendAttachmentState[] Attachments
		{
			get;
			set;
		}

		public float BlendConstants
		{
			get;
			set;
		}

	}

	public class PipelineDepthStencilStateCreateInfo
	{
		public PipelineDepthStencilStateCreateFlags Flags
		{
			get;
			set;
		}

		public Bool32 DepthTestEnable
		{
			get;
			set;
		}

		public Bool32 DepthWriteEnable
		{
			get;
			set;
		}

		public CompareOp DepthCompareOp
		{
			get;
			set;
		}

		public Bool32 DepthBoundsTestEnable
		{
			get;
			set;
		}

		public Bool32 StencilTestEnable
		{
			get;
			set;
		}

		public StencilOpState Front
		{
			get;
			set;
		}

		public StencilOpState Back
		{
			get;
			set;
		}

		public float MinDepthBounds
		{
			get;
			set;
		}

		public float MaxDepthBounds
		{
			get;
			set;
		}

	}

	public class PipelineDynamicStateCreateInfo
	{
		public PipelineDynamicStateCreateFlags Flags
		{
			get;
			set;
		}

		public DynamicState[] DynamicStates
		{
			get;
			set;
		}

	}

	public class PipelineInputAssemblyStateCreateInfo
	{
		public PipelineInputAssemblyStateCreateFlags Flags
		{
			get;
			set;
		}

		public PrimitiveTopology Topology
		{
			get;
			set;
		}

		public Bool32 PrimitiveRestartEnable
		{
			get;
			set;
		}

	}

	public class PipelineLayoutCreateInfo
	{
		public PipelineLayoutCreateFlags Flags
		{
			get;
			set;
		}

		public DescriptorSetLayout[] SetLayouts
		{
			get;
			set;
		}

		public PushConstantRange[] PushConstantRanges
		{
			get;
			set;
		}

	}

	public class PipelineMultisampleStateCreateInfo
	{
		public PipelineMultisampleStateCreateFlags Flags
		{
			get;
			set;
		}

		public SampleCountFlags RasterizationSamples
		{
			get;
			set;
		}

		public Bool32 SampleShadingEnable
		{
			get;
			set;
		}

		public float MinSampleShading
		{
			get;
			set;
		}

		public Bool32 AlphaToCoverageEnable
		{
			get;
			set;
		}

		public Bool32 AlphaToOneEnable
		{
			get;
			set;
		}

	}

	public class PipelineRasterizationStateCreateInfo
	{
		public PipelineRasterizationStateCreateFlags Flags
		{
			get;
			set;
		}

		public Bool32 DepthClampEnable
		{
			get;
			set;
		}

		public Bool32 RasterizerDiscardEnable
		{
			get;
			set;
		}

		public PolygonMode PolygonMode
		{
			get;
			set;
		}

		public CullModeFlags CullMode
		{
			get;
			set;
		}

		public FrontFace FrontFace
		{
			get;
			set;
		}

		public Bool32 DepthBiasEnable
		{
			get;
			set;
		}

		public float DepthBiasConstantFactor
		{
			get;
			set;
		}

		public float DepthBiasClamp
		{
			get;
			set;
		}

		public float DepthBiasSlopeFactor
		{
			get;
			set;
		}

		public float LineWidth
		{
			get;
			set;
		}

	}

	public class PipelineShaderStageCreateInfo
	{
		public PipelineShaderStageCreateFlags Flags
		{
			get;
			set;
		}

		public ShaderStageFlags Stage
		{
			get;
			set;
		}

		public ShaderModule Module
		{
			get;
			set;
		}

		public string Name
		{
			get;
			set;
		}

	}

	public class PipelineTessellationStateCreateInfo
	{
		public PipelineTessellationStateCreateFlags Flags
		{
			get;
			set;
		}

		public uint PatchControlPoints
		{
			get;
			set;
		}

	}

	public class PipelineVertexInputStateCreateInfo
	{
		public PipelineVertexInputStateCreateFlags Flags
		{
			get;
			set;
		}

		public VertexInputBindingDescription[] VertexBindingDescriptions
		{
			get;
			set;
		}

		public VertexInputAttributeDescription[] VertexAttributeDescriptions
		{
			get;
			set;
		}

	}

	public class PipelineViewportStateCreateInfo
	{
		public PipelineViewportStateCreateFlags Flags
		{
			get;
			set;
		}

		public Viewport[] Viewports
		{
			get;
			set;
		}

		public Rect2D[] Scissors
		{
			get;
			set;
		}

	}

	public class QueryPoolCreateInfo
	{
		public QueryPoolCreateFlags Flags
		{
			get;
			set;
		}

		public QueryType QueryType
		{
			get;
			set;
		}

		public uint QueryCount
		{
			get;
			set;
		}

		public QueryPipelineStatisticFlags PipelineStatistics
		{
			get;
			set;
		}

	}

	public class RenderPassBeginInfo
	{
		public RenderPass RenderPass
		{
			get;
			set;
		}

		public Framebuffer Framebuffer
		{
			get;
			set;
		}

		public Rect2D RenderArea
		{
			get;
			set;
		}

		public ClearValue[] ClearValues
		{
			get;
			set;
		}

	}

	public class RenderPassCreateInfo
	{
		public RenderPassCreateFlags Flags
		{
			get;
			set;
		}

		public AttachmentDescription[] Attachments
		{
			get;
			set;
		}

		public SubpassDescription[] Subpasses
		{
			get;
			set;
		}

		public SubpassDependency[] Dependencies
		{
			get;
			set;
		}

	}

	public class SamplerCreateInfo
	{
		public SamplerCreateFlags Flags
		{
			get;
			set;
		}

		public Filter MagFilter
		{
			get;
			set;
		}

		public Filter MinFilter
		{
			get;
			set;
		}

		public SamplerMipmapMode MipmapMode
		{
			get;
			set;
		}

		public SamplerAddressMode AddressModeU
		{
			get;
			set;
		}

		public SamplerAddressMode AddressModeV
		{
			get;
			set;
		}

		public SamplerAddressMode AddressModeW
		{
			get;
			set;
		}

		public float MipLodBias
		{
			get;
			set;
		}

		public Bool32 AnisotropyEnable
		{
			get;
			set;
		}

		public float MaxAnisotropy
		{
			get;
			set;
		}

		public Bool32 CompareEnable
		{
			get;
			set;
		}

		public CompareOp CompareOp
		{
			get;
			set;
		}

		public float MinLod
		{
			get;
			set;
		}

		public float MaxLod
		{
			get;
			set;
		}

		public BorderColor BorderColor
		{
			get;
			set;
		}

		public Bool32 UnnormalizedCoordinates
		{
			get;
			set;
		}

	}

	public class SemaphoreCreateInfo
	{
		public SemaphoreCreateFlags Flags
		{
			get;
			set;
		}

	}

	public class ShaderModuleCreateInfo
	{
		public ShaderModuleCreateFlags Flags
		{
			get;
			set;
		}

		public UIntPtr CodeSize
		{
			get;
			set;
		}

	}

	public class SparseBufferMemoryBindInfo
	{
		public Buffer Buffer
		{
			get;
			set;
		}

		public SparseMemoryBind[] Binds
		{
			get;
			set;
		}

	}

	public class SparseImageMemoryBind
	{
		public ImageSubresource Subresource
		{
			get;
			set;
		}

		public Offset3D Offset
		{
			get;
			set;
		}

		public Extent3D Extent
		{
			get;
			set;
		}

		public DeviceMemory Memory
		{
			get;
			set;
		}

		public DeviceSize MemoryOffset
		{
			get;
			set;
		}

		public SparseMemoryBindFlags Flags
		{
			get;
			set;
		}

	}

	public class SparseImageMemoryBindInfo
	{
		public Image Image
		{
			get;
			set;
		}

		public SparseImageMemoryBind[] Binds
		{
			get;
			set;
		}

	}

	public class SparseImageOpaqueMemoryBindInfo
	{
		public Image Image
		{
			get;
			set;
		}

		public SparseMemoryBind[] Binds
		{
			get;
			set;
		}

	}

	public class SparseMemoryBind
	{
		public DeviceSize ResourceOffset
		{
			get;
			set;
		}

		public DeviceSize Size
		{
			get;
			set;
		}

		public DeviceMemory Memory
		{
			get;
			set;
		}

		public DeviceSize MemoryOffset
		{
			get;
			set;
		}

		public SparseMemoryBindFlags Flags
		{
			get;
			set;
		}

	}

	public class SpecializationInfo
	{
		public SpecializationMapEntry[] MapEntries
		{
			get;
			set;
		}

		public byte[] Data
		{
			get;
			set;
		}

	}

	public class SubmitInfo
	{
		public Semaphore[] WaitSemaphores
		{
			get;
			set;
		}

		public PipelineStageFlags[] WaitDestinationStageMask
		{
			get;
			set;
		}

		public CommandBuffer[] CommandBuffers
		{
			get;
			set;
		}

		public Semaphore[] SignalSemaphores
		{
			get;
			set;
		}

	}

	public class SubpassDescription
	{
		public SubpassDescriptionFlags Flags
		{
			get;
			set;
		}

		public PipelineBindPoint PipelineBindPoint
		{
			get;
			set;
		}

		public AttachmentReference[] InputAttachments
		{
			get;
			set;
		}

		public AttachmentReference[] ColorAttachments
		{
			get;
			set;
		}

		public AttachmentReference[] ResolveAttachments
		{
			get;
			set;
		}

		public uint[] PreserveAttachments
		{
			get;
			set;
		}

	}

	public class WriteDescriptorSet
	{
		public DescriptorSet DestinationSet
		{
			get;
			set;
		}

		public uint DestinationBinding
		{
			get;
			set;
		}

		public uint DestinationArrayElement
		{
			get;
			set;
		}

		public DescriptorType DescriptorType
		{
			get;
			set;
		}

		public DescriptorImageInfo[] ImageInfo
		{
			get;
			set;
		}

		public DescriptorBufferInfo[] BufferInfo
		{
			get;
			set;
		}

		public BufferView[] TexelBufferView
		{
			get;
			set;
		}

	}
}