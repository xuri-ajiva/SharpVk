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

namespace SharpVk.Interop
{
	public struct SampleMask
	{
		private uint value;

		public static implicit operator SampleMask(uint value)
		{
			return new SampleMask { value = value };
		}

		public static implicit operator uint(SampleMask size)
		{
			return size.value;
		}
	}

	public unsafe struct AllocationCallbacks
	{
		public void* UserData;
		public IntPtr PfnAllocation;
		public IntPtr PfnReallocation;
		public IntPtr PfnFree;
		public IntPtr PfnInternalAllocation;
		public IntPtr PfnInternalFree;
	}

	public unsafe struct ApplicationInfo
	{
		public StructureType SType;
		public void* Next;
		public char* ApplicationName;
		public uint ApplicationVersion;
		public char* EngineName;
		public uint EngineVersion;
		public uint ApiVersion;
	}

	public unsafe struct BindSparseInfo
	{
		public StructureType SType;
		public void* Next;
		public uint WaitSemaphoreCount;
		public Semaphore* WaitSemaphores;
		public uint BufferBindCount;
		public SparseBufferMemoryBindInfo* BufferBinds;
		public uint ImageOpaqueBindCount;
		public SparseImageOpaqueMemoryBindInfo* ImageOpaqueBinds;
		public uint ImageBindCount;
		public SparseImageMemoryBindInfo* ImageBinds;
		public uint SignalSemaphoreCount;
		public Semaphore* SignalSemaphores;
	}

	public unsafe struct BufferCreateInfo
	{
		public StructureType SType;
		public void* Next;
		public BufferCreateFlags Flags;
		public DeviceSize Size;
		public BufferUsageFlags Usage;
		public SharingMode SharingMode;
		public uint QueueFamilyIndexCount;
		public uint* QueueFamilyIndices;
	}

	public unsafe struct BufferMemoryBarrier
	{
		public StructureType SType;
		public void* Next;
		public AccessFlags SourceAccessMask;
		public AccessFlags DestinationAccessMask;
		public uint SourceQueueFamilyIndex;
		public uint DestinationQueueFamilyIndex;
		public Buffer Buffer;
		public DeviceSize Offset;
		public DeviceSize Size;
	}

	public unsafe struct BufferViewCreateInfo
	{
		public StructureType SType;
		public void* Next;
		public BufferViewCreateFlags Flags;
		public Buffer Buffer;
		public Format Format;
		public DeviceSize Offset;
		public DeviceSize Range;
	}

	public unsafe struct CommandBufferAllocateInfo
	{
		public StructureType SType;
		public void* Next;
		public CommandPool CommandPool;
		public CommandBufferLevel Level;
		public uint CommandBufferCount;
	}

	public unsafe struct CommandBufferBeginInfo
	{
		public StructureType SType;
		public void* Next;
		public CommandBufferUsageFlags Flags;
		public CommandBufferInheritanceInfo* InheritanceInfo;
	}

	public unsafe struct CommandBufferInheritanceInfo
	{
		public StructureType SType;
		public void* Next;
		public RenderPass RenderPass;
		public uint Subpass;
		public Framebuffer Framebuffer;
		public Bool32 OcclusionQueryEnable;
		public QueryControlFlags QueryFlags;
		public QueryPipelineStatisticFlags PipelineStatistics;
	}

	public unsafe struct CommandPoolCreateInfo
	{
		public StructureType SType;
		public void* Next;
		public CommandPoolCreateFlags Flags;
		public uint QueueFamilyIndex;
	}

	public unsafe struct ComputePipelineCreateInfo
	{
		public StructureType SType;
		public void* Next;
		public PipelineCreateFlags Flags;
		public PipelineShaderStageCreateInfo Stage;
		public PipelineLayout Layout;
		public Pipeline BasePipelineHandle;
		public int BasePipelineIndex;
	}

	public unsafe struct CopyDescriptorSet
	{
		public StructureType SType;
		public void* Next;
		public DescriptorSet SourceSet;
		public uint SourceBinding;
		public uint SourceArrayElement;
		public DescriptorSet DestinationSet;
		public uint DestinationBinding;
		public uint DestinationArrayElement;
		public uint DescriptorCount;
	}

	public unsafe struct DescriptorBufferInfo
	{
		public Buffer Buffer;
		public DeviceSize Offset;
		public DeviceSize Range;
	}

	public unsafe struct DescriptorImageInfo
	{
		public Sampler Sampler;
		public ImageView ImageView;
		public ImageLayout ImageLayout;
	}

	public unsafe struct DescriptorPoolCreateInfo
	{
		public StructureType SType;
		public void* Next;
		public DescriptorPoolCreateFlags Flags;
		public uint MaxSets;
		public uint PoolSizeCount;
		public DescriptorPoolSize* PoolSizes;
	}

	public unsafe struct DescriptorSetAllocateInfo
	{
		public StructureType SType;
		public void* Next;
		public DescriptorPool DescriptorPool;
		public uint DescriptorSetCount;
		public DescriptorSetLayout* SetLayouts;
	}

	public unsafe struct DescriptorSetLayoutBinding
	{
		public uint Binding;
		public DescriptorType DescriptorType;
		public uint DescriptorCount;
		public ShaderStageFlags StageFlags;
		public Sampler* ImmutableSamplers;
	}

	public unsafe struct DescriptorSetLayoutCreateInfo
	{
		public StructureType SType;
		public void* Next;
		public DescriptorSetLayoutCreateFlags Flags;
		public uint BindingCount;
		public DescriptorSetLayoutBinding* Bindings;
	}

	public unsafe struct DeviceCreateInfo
	{
		public StructureType SType;
		public void* Next;
		public DeviceCreateFlags Flags;
		public uint QueueCreateInfoCount;
		public DeviceQueueCreateInfo* QueueCreateInfos;
		public uint EnabledLayerCount;
		public char** EnabledLayerNames;
		public uint EnabledExtensionCount;
		public char** EnabledExtensionNames;
		public PhysicalDeviceFeatures* EnabledFeatures;
	}

	public unsafe struct DeviceQueueCreateInfo
	{
		public StructureType SType;
		public void* Next;
		public DeviceQueueCreateFlags Flags;
		public uint QueueFamilyIndex;
		public uint QueueCount;
		public float* QueuePriorities;
	}

	public unsafe struct EventCreateInfo
	{
		public StructureType SType;
		public void* Next;
		public EventCreateFlags Flags;
	}

	public unsafe struct ExtensionProperties
	{
		public char ExtensionName;
		public uint SpecVersion;
	}

	public unsafe struct FenceCreateInfo
	{
		public StructureType SType;
		public void* Next;
		public FenceCreateFlags Flags;
	}

	public unsafe struct FramebufferCreateInfo
	{
		public StructureType SType;
		public void* Next;
		public FramebufferCreateFlags Flags;
		public RenderPass RenderPass;
		public uint AttachmentCount;
		public ImageView* Attachments;
		public uint Width;
		public uint Height;
		public uint Layers;
	}

	public unsafe struct GraphicsPipelineCreateInfo
	{
		public StructureType SType;
		public void* Next;
		public PipelineCreateFlags Flags;
		public uint StageCount;
		public PipelineShaderStageCreateInfo* Stages;
		public PipelineVertexInputStateCreateInfo* VertexInputState;
		public PipelineInputAssemblyStateCreateInfo* InputAssemblyState;
		public PipelineTessellationStateCreateInfo* TessellationState;
		public PipelineViewportStateCreateInfo* ViewportState;
		public PipelineRasterizationStateCreateInfo* RasterizationState;
		public PipelineMultisampleStateCreateInfo* MultisampleState;
		public PipelineDepthStencilStateCreateInfo* DepthStencilState;
		public PipelineColorBlendStateCreateInfo* ColorBlendState;
		public PipelineDynamicStateCreateInfo* DynamicState;
		public PipelineLayout Layout;
		public RenderPass RenderPass;
		public uint Subpass;
		public Pipeline BasePipelineHandle;
		public int BasePipelineIndex;
	}

	public unsafe struct ImageBlit
	{
		public ImageSubresourceLayers SourceSubresource;
		public Offset3D SourceOffsets;
		public ImageSubresourceLayers DestinationSubresource;
		public Offset3D DestinationOffsets;
	}

	public unsafe struct ImageCreateInfo
	{
		public StructureType SType;
		public void* Next;
		public ImageCreateFlags Flags;
		public ImageType ImageType;
		public Format Format;
		public Extent3D Extent;
		public uint MipLevels;
		public uint ArrayLayers;
		public SampleCountFlags Samples;
		public ImageTiling Tiling;
		public ImageUsageFlags Usage;
		public SharingMode SharingMode;
		public uint QueueFamilyIndexCount;
		public uint* QueueFamilyIndices;
		public ImageLayout InitialLayout;
	}

	public unsafe struct ImageMemoryBarrier
	{
		public StructureType SType;
		public void* Next;
		public AccessFlags SourceAccessMask;
		public AccessFlags DestinationAccessMask;
		public ImageLayout OldLayout;
		public ImageLayout NewLayout;
		public uint SourceQueueFamilyIndex;
		public uint DestinationQueueFamilyIndex;
		public Image Image;
		public ImageSubresourceRange SubresourceRange;
	}

	public unsafe struct ImageViewCreateInfo
	{
		public StructureType SType;
		public void* Next;
		public ImageViewCreateFlags Flags;
		public Image Image;
		public ImageViewType ViewType;
		public Format Format;
		public ComponentMapping Components;
		public ImageSubresourceRange SubresourceRange;
	}

	public unsafe struct InstanceCreateInfo
	{
		public StructureType SType;
		public void* Next;
		public InstanceCreateFlags Flags;
		public ApplicationInfo* ApplicationInfo;
		public uint EnabledLayerCount;
		public char** EnabledLayerNames;
		public uint EnabledExtensionCount;
		public char** EnabledExtensionNames;
	}

	public unsafe struct LayerProperties
	{
		public char LayerName;
		public uint SpecVersion;
		public uint ImplementationVersion;
		public char Description;
	}

	public unsafe struct MappedMemoryRange
	{
		public StructureType SType;
		public void* Next;
		public DeviceMemory Memory;
		public DeviceSize Offset;
		public DeviceSize Size;
	}

	public unsafe struct MemoryAllocateInfo
	{
		public StructureType SType;
		public void* Next;
		public DeviceSize AllocationSize;
		public uint MemoryTypeIndex;
	}

	public unsafe struct MemoryBarrier
	{
		public StructureType SType;
		public void* Next;
		public AccessFlags SourceAccessMask;
		public AccessFlags DestinationAccessMask;
	}

	public unsafe struct PhysicalDeviceLimits
	{
		public uint MaxImageDimension1D;
		public uint MaxImageDimension2D;
		public uint MaxImageDimension3D;
		public uint MaxImageDimensionCube;
		public uint MaxImageArrayLayers;
		public uint MaxTexelBufferElements;
		public uint MaxUniformBufferRange;
		public uint MaxStorageBufferRange;
		public uint MaxPushConstantsSize;
		public uint MaxMemoryAllocationCount;
		public uint MaxSamplerAllocationCount;
		public DeviceSize BufferImageGranularity;
		public DeviceSize SparseAddressSpaceSize;
		public uint MaxBoundDescriptorSets;
		public uint MaxPerStageDescriptorSamplers;
		public uint MaxPerStageDescriptorUniformBuffers;
		public uint MaxPerStageDescriptorStorageBuffers;
		public uint MaxPerStageDescriptorSampledImages;
		public uint MaxPerStageDescriptorStorageImages;
		public uint MaxPerStageDescriptorInputAttachments;
		public uint MaxPerStageResources;
		public uint MaxDescriptorSetSamplers;
		public uint MaxDescriptorSetUniformBuffers;
		public uint MaxDescriptorSetUniformBuffersDynamic;
		public uint MaxDescriptorSetStorageBuffers;
		public uint MaxDescriptorSetStorageBuffersDynamic;
		public uint MaxDescriptorSetSampledImages;
		public uint MaxDescriptorSetStorageImages;
		public uint MaxDescriptorSetInputAttachments;
		public uint MaxVertexInputAttributes;
		public uint MaxVertexInputBindings;
		public uint MaxVertexInputAttributeOffset;
		public uint MaxVertexInputBindingStride;
		public uint MaxVertexOutputComponents;
		public uint MaxTessellationGenerationLevel;
		public uint MaxTessellationPatchSize;
		public uint MaxTessellationControlPerVertexInputComponents;
		public uint MaxTessellationControlPerVertexOutputComponents;
		public uint MaxTessellationControlPerPatchOutputComponents;
		public uint MaxTessellationControlTotalOutputComponents;
		public uint MaxTessellationEvaluationInputComponents;
		public uint MaxTessellationEvaluationOutputComponents;
		public uint MaxGeometryShaderInvocations;
		public uint MaxGeometryInputComponents;
		public uint MaxGeometryOutputComponents;
		public uint MaxGeometryOutputVertices;
		public uint MaxGeometryTotalOutputComponents;
		public uint MaxFragmentInputComponents;
		public uint MaxFragmentOutputAttachments;
		public uint MaxFragmentDualSourceAttachments;
		public uint MaxFragmentCombinedOutputResources;
		public uint MaxComputeSharedMemorySize;
		public uint MaxComputeWorkGroupCount;
		public uint MaxComputeWorkGroupInvocations;
		public uint MaxComputeWorkGroupSize;
		public uint SubPixelPrecisionBits;
		public uint SubTexelPrecisionBits;
		public uint MipmapPrecisionBits;
		public uint MaxDrawIndexedIndexValue;
		public uint MaxDrawIndirectCount;
		public float MaxSamplerLodBias;
		public float MaxSamplerAnisotropy;
		public uint MaxViewports;
		public uint MaxViewportDimensions;
		public float ViewportBoundsRange;
		public uint ViewportSubPixelBits;
		public UIntPtr MinMemoryMapAlignment;
		public DeviceSize MinTexelBufferOffsetAlignment;
		public DeviceSize MinUniformBufferOffsetAlignment;
		public DeviceSize MinStorageBufferOffsetAlignment;
		public int MinTexelOffset;
		public uint MaxTexelOffset;
		public int MinTexelGatherOffset;
		public uint MaxTexelGatherOffset;
		public float MinInterpolationOffset;
		public float MaxInterpolationOffset;
		public uint SubPixelInterpolationOffsetBits;
		public uint MaxFramebufferWidth;
		public uint MaxFramebufferHeight;
		public uint MaxFramebufferLayers;
		public SampleCountFlags FramebufferColorSampleCounts;
		public SampleCountFlags FramebufferDepthSampleCounts;
		public SampleCountFlags FramebufferStencilSampleCounts;
		public SampleCountFlags FramebufferNoAttachmentsSampleCounts;
		public uint MaxColorAttachments;
		public SampleCountFlags SampledImageColorSampleCounts;
		public SampleCountFlags SampledImageIntegerSampleCounts;
		public SampleCountFlags SampledImageDepthSampleCounts;
		public SampleCountFlags SampledImageStencilSampleCounts;
		public SampleCountFlags StorageImageSampleCounts;
		public uint MaxSampleMaskWords;
		public Bool32 TimestampComputeAndGraphics;
		public float TimestampPeriod;
		public uint MaxClipDistances;
		public uint MaxCullDistances;
		public uint MaxCombinedClipAndCullDistances;
		public uint DiscreteQueuePriorities;
		public float PointSizeRange;
		public float LineWidthRange;
		public float PointSizeGranularity;
		public float LineWidthGranularity;
		public Bool32 StrictLines;
		public Bool32 StandardSampleLocations;
		public DeviceSize OptimalBufferCopyOffsetAlignment;
		public DeviceSize OptimalBufferCopyRowPitchAlignment;
		public DeviceSize NonCoherentAtomSize;
	}

	public unsafe struct PhysicalDeviceMemoryProperties
	{
		public uint MemoryTypeCount;
		public MemoryType MemoryTypes;
		public uint MemoryHeapCount;
		public MemoryHeap MemoryHeaps;
	}

	public unsafe struct PhysicalDeviceProperties
	{
		public uint ApiVersion;
		public uint DriverVersion;
		public uint Vendor;
		public uint Device;
		public PhysicalDeviceType DeviceType;
		public char DeviceName;
		public byte PipelineCache;
		public PhysicalDeviceLimits Limits;
		public PhysicalDeviceSparseProperties SparseProperties;
	}

	public unsafe struct PipelineCacheCreateInfo
	{
		public StructureType SType;
		public void* Next;
		public PipelineCacheCreateFlags Flags;
		public UIntPtr InitialDataSize;
		public void* InitialData;
	}

	public unsafe struct PipelineColorBlendStateCreateInfo
	{
		public StructureType SType;
		public void* Next;
		public PipelineColorBlendStateCreateFlags Flags;
		public Bool32 LogicOpEnable;
		public LogicOp LogicOp;
		public uint AttachmentCount;
		public PipelineColorBlendAttachmentState* Attachments;
		public float BlendConstants;
	}

	public unsafe struct PipelineDepthStencilStateCreateInfo
	{
		public StructureType SType;
		public void* Next;
		public PipelineDepthStencilStateCreateFlags Flags;
		public Bool32 DepthTestEnable;
		public Bool32 DepthWriteEnable;
		public CompareOp DepthCompareOp;
		public Bool32 DepthBoundsTestEnable;
		public Bool32 StencilTestEnable;
		public StencilOpState Front;
		public StencilOpState Back;
		public float MinDepthBounds;
		public float MaxDepthBounds;
	}

	public unsafe struct PipelineDynamicStateCreateInfo
	{
		public StructureType SType;
		public void* Next;
		public PipelineDynamicStateCreateFlags Flags;
		public uint DynamicStateCount;
		public DynamicState* DynamicStates;
	}

	public unsafe struct PipelineInputAssemblyStateCreateInfo
	{
		public StructureType SType;
		public void* Next;
		public PipelineInputAssemblyStateCreateFlags Flags;
		public PrimitiveTopology Topology;
		public Bool32 PrimitiveRestartEnable;
	}

	public unsafe struct PipelineLayoutCreateInfo
	{
		public StructureType SType;
		public void* Next;
		public PipelineLayoutCreateFlags Flags;
		public uint SetLayoutCount;
		public DescriptorSetLayout* SetLayouts;
		public uint PushConstantRangeCount;
		public PushConstantRange* PushConstantRanges;
	}

	public unsafe struct PipelineMultisampleStateCreateInfo
	{
		public StructureType SType;
		public void* Next;
		public PipelineMultisampleStateCreateFlags Flags;
		public SampleCountFlags RasterizationSamples;
		public Bool32 SampleShadingEnable;
		public float MinSampleShading;
		public SampleMask* SampleMask;
		public Bool32 AlphaToCoverageEnable;
		public Bool32 AlphaToOneEnable;
	}

	public unsafe struct PipelineRasterizationStateCreateInfo
	{
		public StructureType SType;
		public void* Next;
		public PipelineRasterizationStateCreateFlags Flags;
		public Bool32 DepthClampEnable;
		public Bool32 RasterizerDiscardEnable;
		public PolygonMode PolygonMode;
		public CullModeFlags CullMode;
		public FrontFace FrontFace;
		public Bool32 DepthBiasEnable;
		public float DepthBiasConstantFactor;
		public float DepthBiasClamp;
		public float DepthBiasSlopeFactor;
		public float LineWidth;
	}

	public unsafe struct PipelineShaderStageCreateInfo
	{
		public StructureType SType;
		public void* Next;
		public PipelineShaderStageCreateFlags Flags;
		public ShaderStageFlags Stage;
		public ShaderModule Module;
		public char* Name;
		public SpecializationInfo* SpecializationInfo;
	}

	public unsafe struct PipelineTessellationStateCreateInfo
	{
		public StructureType SType;
		public void* Next;
		public PipelineTessellationStateCreateFlags Flags;
		public uint PatchControlPoints;
	}

	public unsafe struct PipelineVertexInputStateCreateInfo
	{
		public StructureType SType;
		public void* Next;
		public PipelineVertexInputStateCreateFlags Flags;
		public uint VertexBindingDescriptionCount;
		public VertexInputBindingDescription* VertexBindingDescriptions;
		public uint VertexAttributeDescriptionCount;
		public VertexInputAttributeDescription* VertexAttributeDescriptions;
	}

	public unsafe struct PipelineViewportStateCreateInfo
	{
		public StructureType SType;
		public void* Next;
		public PipelineViewportStateCreateFlags Flags;
		public uint ViewportCount;
		public Viewport* Viewports;
		public uint ScissorCount;
		public Rect2D* Scissors;
	}

	public unsafe struct QueryPoolCreateInfo
	{
		public StructureType SType;
		public void* Next;
		public QueryPoolCreateFlags Flags;
		public QueryType QueryType;
		public uint QueryCount;
		public QueryPipelineStatisticFlags PipelineStatistics;
	}

	public unsafe struct RenderPassBeginInfo
	{
		public StructureType SType;
		public void* Next;
		public RenderPass RenderPass;
		public Framebuffer Framebuffer;
		public Rect2D RenderArea;
		public uint ClearValueCount;
		public ClearValue* ClearValues;
	}

	public unsafe struct RenderPassCreateInfo
	{
		public StructureType SType;
		public void* Next;
		public RenderPassCreateFlags Flags;
		public uint AttachmentCount;
		public AttachmentDescription* Attachments;
		public uint SubpassCount;
		public SubpassDescription* Subpasses;
		public uint DependencyCount;
		public SubpassDependency* Dependencies;
	}

	public unsafe struct SamplerCreateInfo
	{
		public StructureType SType;
		public void* Next;
		public SamplerCreateFlags Flags;
		public Filter MagFilter;
		public Filter MinFilter;
		public SamplerMipmapMode MipmapMode;
		public SamplerAddressMode AddressModeU;
		public SamplerAddressMode AddressModeV;
		public SamplerAddressMode AddressModeW;
		public float MipLodBias;
		public Bool32 AnisotropyEnable;
		public float MaxAnisotropy;
		public Bool32 CompareEnable;
		public CompareOp CompareOp;
		public float MinLod;
		public float MaxLod;
		public BorderColor BorderColor;
		public Bool32 UnnormalizedCoordinates;
	}

	public unsafe struct SemaphoreCreateInfo
	{
		public StructureType SType;
		public void* Next;
		public SemaphoreCreateFlags Flags;
	}

	public unsafe struct ShaderModuleCreateInfo
	{
		public StructureType SType;
		public void* Next;
		public ShaderModuleCreateFlags Flags;
		public UIntPtr CodeSize;
		public uint* Code;
	}

	public unsafe struct SparseBufferMemoryBindInfo
	{
		public Buffer Buffer;
		public uint BindCount;
		public SparseMemoryBind* Binds;
	}

	public unsafe struct SparseImageMemoryBind
	{
		public ImageSubresource Subresource;
		public Offset3D Offset;
		public Extent3D Extent;
		public DeviceMemory Memory;
		public DeviceSize MemoryOffset;
		public SparseMemoryBindFlags Flags;
	}

	public unsafe struct SparseImageMemoryBindInfo
	{
		public Image Image;
		public uint BindCount;
		public SparseImageMemoryBind* Binds;
	}

	public unsafe struct SparseImageOpaqueMemoryBindInfo
	{
		public Image Image;
		public uint BindCount;
		public SparseMemoryBind* Binds;
	}

	public unsafe struct SparseMemoryBind
	{
		public DeviceSize ResourceOffset;
		public DeviceSize Size;
		public DeviceMemory Memory;
		public DeviceSize MemoryOffset;
		public SparseMemoryBindFlags Flags;
	}

	public unsafe struct SpecializationInfo
	{
		public uint MapEntryCount;
		public SpecializationMapEntry* MapEntries;
		public UIntPtr DataSize;
		public void* Data;
	}

	public unsafe struct SubmitInfo
	{
		public StructureType SType;
		public void* Next;
		public uint WaitSemaphoreCount;
		public Semaphore* WaitSemaphores;
		public PipelineStageFlags* WaitDestinationStageMask;
		public uint CommandBufferCount;
		public CommandBuffer* CommandBuffers;
		public uint SignalSemaphoreCount;
		public Semaphore* SignalSemaphores;
	}

	public unsafe struct SubpassDescription
	{
		public SubpassDescriptionFlags Flags;
		public PipelineBindPoint PipelineBindPoint;
		public uint InputAttachmentCount;
		public AttachmentReference* InputAttachments;
		public uint ColorAttachmentCount;
		public AttachmentReference* ColorAttachments;
		public AttachmentReference* ResolveAttachments;
		public AttachmentReference* DepthStencilAttachment;
		public uint PreserveAttachmentCount;
		public uint* PreserveAttachments;
	}

	public unsafe struct WriteDescriptorSet
	{
		public StructureType SType;
		public void* Next;
		public DescriptorSet DestinationSet;
		public uint DestinationBinding;
		public uint DestinationArrayElement;
		public uint DescriptorCount;
		public DescriptorType DescriptorType;
		public DescriptorImageInfo* ImageInfo;
		public DescriptorBufferInfo* BufferInfo;
		public BufferView* TexelBufferView;
	}
}