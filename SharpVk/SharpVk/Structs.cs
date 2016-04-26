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

	public struct Bool32
	{
		private uint value;

		public Bool32(bool value)
		{
			this.value = value
							? Constants.True
							: Constants.False;
		}

		public static implicit operator Bool32(bool value)
		{
			return new Bool32(value);
		}

		public static implicit operator bool(Bool32 value)
		{
			return value.value != Constants.False;
		}
	}

	public struct DeviceSize
	{
		private ulong value;

		public static implicit operator DeviceSize(ulong value)
		{
			return new DeviceSize { value = value };
		}

		public static implicit operator ulong(DeviceSize size)
		{
			return size.value;
		}
	}

	public struct AttachmentDescription
	{

		public AttachmentDescriptionFlags Flags;

		public Format Format;

		public SampleCountFlags Samples;

		public AttachmentLoadOp LoadOp;

		public AttachmentStoreOp StoreOp;

		public AttachmentLoadOp StencilLoadOp;

		public AttachmentStoreOp StencilStoreOp;

		public ImageLayout InitialLayout;

		public ImageLayout FinalLayout;
	}

	public struct AttachmentReference
	{

		public uint Attachment;

		public ImageLayout Layout;
	}

	public struct BufferCopy
	{

		public DeviceSize SourceOffset;

		public DeviceSize DestinationOffset;

		public DeviceSize Size;
	}

	public struct BufferImageCopy
	{

		public DeviceSize BufferOffset;

		public uint BufferRowLength;

		public uint BufferImageHeight;

		public ImageSubresourceLayers ImageSubresource;

		public Offset3D ImageOffset;

		public Extent3D ImageExtent;
	}

	public struct ClearAttachment
	{

		public ImageAspectFlags AspectMask;

		public uint ColorAttachment;

		public ClearValue ClearValue;
	}

	public struct ClearDepthStencilValue
	{

		public float Depth;

		public uint Stencil;
	}

	public struct ClearRect
	{

		public Rect2D Rect;

		public uint BaseArrayLayer;

		public uint LayerCount;
	}

	public struct ComponentMapping
	{

		public ComponentSwizzle R;

		public ComponentSwizzle G;

		public ComponentSwizzle B;

		public ComponentSwizzle A;
	}

	public struct DescriptorPoolSize
	{

		public DescriptorType Type;

		public uint DescriptorCount;
	}

	public struct DispatchIndirectCommand
	{

		public uint X;

		public uint Y;

		public uint Z;
	}

	public struct DrawIndexedIndirectCommand
	{

		public uint IndexCount;

		public uint InstanceCount;

		public uint FirstIndex;

		public int VertexOffset;

		public uint FirstInstance;
	}

	public struct DrawIndirectCommand
	{

		public uint VertexCount;

		public uint InstanceCount;

		public uint FirstVertex;

		public uint FirstInstance;
	}

	public struct Extent2D
	{

		public uint Width;

		public uint Height;
	}

	public struct Extent3D
	{

		public uint Width;

		public uint Height;

		public uint Depth;
	}

	public struct FormatProperties
	{

		public FormatFeatureFlags LinearTilingFeatures;

		public FormatFeatureFlags OptimalTilingFeatures;

		public FormatFeatureFlags BufferFeatures;
	}

	public struct ImageCopy
	{

		public ImageSubresourceLayers SourceSubresource;

		public Offset3D SourceOffset;

		public ImageSubresourceLayers DestinationSubresource;

		public Offset3D DestinationOffset;

		public Extent3D Extent;
	}

	public struct ImageFormatProperties
	{

		public Extent3D MaxExtent;

		public uint MaxMipLevels;

		public uint MaxArrayLayers;

		public SampleCountFlags SampleCounts;

		public DeviceSize MaxResourceSize;
	}

	public struct ImageResolve
	{

		public ImageSubresourceLayers SourceSubresource;

		public Offset3D SourceOffset;

		public ImageSubresourceLayers DestinationSubresource;

		public Offset3D DestinationOffset;

		public Extent3D Extent;
	}

	public struct ImageSubresource
	{

		public ImageAspectFlags AspectMask;

		public uint MipLevel;

		public uint ArrayLayer;
	}

	public struct ImageSubresourceLayers
	{

		public ImageAspectFlags AspectMask;

		public uint MipLevel;

		public uint BaseArrayLayer;

		public uint LayerCount;
	}

	public struct ImageSubresourceRange
	{

		public ImageAspectFlags AspectMask;

		public uint BaseMipLevel;

		public uint LevelCount;

		public uint BaseArrayLayer;

		public uint LayerCount;
	}

	public struct MemoryHeap
	{

		public DeviceSize Size;

		public MemoryHeapFlags Flags;
	}

	public struct MemoryRequirements
	{

		public DeviceSize Size;

		public DeviceSize Alignment;

		public uint MemoryTypeBits;
	}

	public struct MemoryType
	{

		public MemoryPropertyFlags PropertyFlags;

		public uint HeapIndex;
	}

	public struct Offset2D
	{

		public int X;

		public int Y;
	}

	public struct Offset3D
	{

		public int X;

		public int Y;

		public int Z;
	}

	public struct PhysicalDeviceFeatures
	{

		public Bool32 RobustBufferAccess;

		public Bool32 FullDrawIndexUint32;

		public Bool32 ImageCubeArray;

		public Bool32 IndependentBlend;

		public Bool32 GeometryShader;

		public Bool32 TessellationShader;

		public Bool32 SampleRateShading;

		public Bool32 DualSourceBlend;

		public Bool32 LogicOp;

		public Bool32 MultiDrawIndirect;

		public Bool32 DrawIndirectFirstInstance;

		public Bool32 DepthClamp;

		public Bool32 DepthBiasClamp;

		public Bool32 FillModeNonSolid;

		public Bool32 DepthBounds;

		public Bool32 WideLines;

		public Bool32 LargePoints;

		public Bool32 AlphaToOne;

		public Bool32 MultiViewport;

		public Bool32 SamplerAnisotropy;

		public Bool32 TextureCompressionETC2;

		public Bool32 TextureCompressionASTC_LDR;

		public Bool32 TextureCompressionBC;

		public Bool32 OcclusionQueryPrecise;

		public Bool32 PipelineStatisticsQuery;

		public Bool32 VertexPipelineStoresAndAtomics;

		public Bool32 FragmentStoresAndAtomics;

		public Bool32 ShaderTessellationAndGeometryPointSize;

		public Bool32 ShaderImageGatherExtended;

		public Bool32 ShaderStorageImageExtendedFormats;

		public Bool32 ShaderStorageImageMultisample;

		public Bool32 ShaderStorageImageReadWithoutFormat;

		public Bool32 ShaderStorageImageWriteWithoutFormat;

		public Bool32 ShaderUniformBufferArrayDynamicIndexing;

		public Bool32 ShaderSampledImageArrayDynamicIndexing;

		public Bool32 ShaderStorageBufferArrayDynamicIndexing;

		public Bool32 ShaderStorageImageArrayDynamicIndexing;

		public Bool32 ShaderClipDistance;

		public Bool32 ShaderCullDistance;

		public Bool32 ShaderFloat64;

		public Bool32 ShaderInt64;

		public Bool32 ShaderInt16;

		public Bool32 ShaderResourceResidency;

		public Bool32 ShaderResourceMinLod;

		public Bool32 SparseBinding;

		public Bool32 SparseResidencyBuffer;

		public Bool32 SparseResidencyImage2D;

		public Bool32 SparseResidencyImage3D;

		public Bool32 SparseResidency2Samples;

		public Bool32 SparseResidency4Samples;

		public Bool32 SparseResidency8Samples;

		public Bool32 SparseResidency16Samples;

		public Bool32 SparseResidencyAliased;

		public Bool32 VariableMultisampleRate;

		public Bool32 InheritedQueries;
	}

	public struct PhysicalDeviceSparseProperties
	{

		public Bool32 ResidencyStandard2DBlockShape;

		public Bool32 ResidencyStandard2DMultisampleBlockShape;

		public Bool32 ResidencyStandard3DBlockShape;

		public Bool32 ResidencyAlignedMipSize;

		public Bool32 ResidencyNonResidentStrict;
	}

	public struct PipelineColorBlendAttachmentState
	{

		public Bool32 BlendEnable;

		public BlendFactor SourceColorBlendFactor;

		public BlendFactor DestinationColorBlendFactor;

		public BlendOp ColorBlendOp;

		public BlendFactor SourceAlphaBlendFactor;

		public BlendFactor DestinationAlphaBlendFactor;

		public BlendOp AlphaBlendOp;

		public ColorComponentFlags ColorWriteMask;
	}

	public struct PushConstantRange
	{

		public ShaderStageFlags StageFlags;

		public uint Offset;

		public uint Size;
	}

	public struct QueueFamilyProperties
	{

		public QueueFlags QueueFlags;

		public uint QueueCount;

		public uint TimestampValidBits;

		public Extent3D MinImageTransferGranularity;
	}

	public struct Rect2D
	{

		public Offset2D Offset;

		public Extent2D Extent;
	}

	public struct SparseImageFormatProperties
	{

		public ImageAspectFlags AspectMask;

		public Extent3D ImageGranularity;

		public SparseImageFormatFlags Flags;
	}

	public struct SparseImageMemoryRequirements
	{

		public SparseImageFormatProperties FormatProperties;

		public uint ImageMipTailFirstLod;

		public DeviceSize ImageMipTailSize;

		public DeviceSize ImageMipTailOffset;

		public DeviceSize ImageMipTailStride;
	}

	public struct SpecializationMapEntry
	{

		public uint Constant;

		public uint Offset;

		public UIntPtr Size;
	}

	public struct StencilOpState
	{

		public StencilOp FailOp;

		public StencilOp PassOp;

		public StencilOp DepthFailOp;

		public CompareOp CompareOp;

		public uint CompareMask;

		public uint WriteMask;

		public uint Reference;
	}

	public struct SubpassDependency
	{

		public uint SourceSubpass;

		public uint DestinationSubpass;

		public PipelineStageFlags SourceStageMask;

		public PipelineStageFlags DestinationStageMask;

		public AccessFlags SourceAccessMask;

		public AccessFlags DestinationAccessMask;

		public DependencyFlags DependencyFlags;
	}

	public struct SubresourceLayout
	{

		public DeviceSize Offset;

		public DeviceSize Size;

		public DeviceSize RowPitch;

		public DeviceSize ArrayPitch;

		public DeviceSize DepthPitch;
	}

	public struct VertexInputAttributeDescription
	{

		public uint Location;

		public uint Binding;

		public Format Format;

		public uint Offset;
	}

	public struct VertexInputBindingDescription
	{

		public uint Binding;

		public uint Stride;

		public VertexInputRate InputRate;
	}

	public struct Viewport
	{

		public float X;

		public float Y;

		public float Width;

		public float Height;

		public float MinDepth;

		public float MaxDepth;
	}
}