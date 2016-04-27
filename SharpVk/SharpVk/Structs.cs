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

		internal unsafe AttachmentDescription* MarshalTo()
		{
			throw new NotImplementedException();
		}
	}

	internal static class AttachmentDescriptionExtensions
	{
		internal unsafe static AttachmentDescription* MarshalTo(this AttachmentDescription[] values)
		{
			throw new NotImplementedException();
		}
	}

	public struct AttachmentReference
	{

		public uint Attachment;

		public ImageLayout Layout;

		internal unsafe AttachmentReference* MarshalTo()
		{
			throw new NotImplementedException();
		}
	}

	internal static class AttachmentReferenceExtensions
	{
		internal unsafe static AttachmentReference* MarshalTo(this AttachmentReference[] values)
		{
			throw new NotImplementedException();
		}
	}

	public struct BufferCopy
	{

		public DeviceSize SourceOffset;

		public DeviceSize DestinationOffset;

		public DeviceSize Size;

		internal unsafe BufferCopy* MarshalTo()
		{
			throw new NotImplementedException();
		}
	}

	internal static class BufferCopyExtensions
	{
		internal unsafe static BufferCopy* MarshalTo(this BufferCopy[] values)
		{
			throw new NotImplementedException();
		}
	}

	public struct BufferImageCopy
	{

		public DeviceSize BufferOffset;

		public uint BufferRowLength;

		public uint BufferImageHeight;

		public ImageSubresourceLayers ImageSubresource;

		public Offset3D ImageOffset;

		public Extent3D ImageExtent;

		internal unsafe BufferImageCopy* MarshalTo()
		{
			throw new NotImplementedException();
		}
	}

	internal static class BufferImageCopyExtensions
	{
		internal unsafe static BufferImageCopy* MarshalTo(this BufferImageCopy[] values)
		{
			throw new NotImplementedException();
		}
	}

	public struct ClearAttachment
	{

		public ImageAspectFlags AspectMask;

		public uint ColorAttachment;

		public ClearValue ClearValue;

		internal unsafe ClearAttachment* MarshalTo()
		{
			throw new NotImplementedException();
		}
	}

	internal static class ClearAttachmentExtensions
	{
		internal unsafe static ClearAttachment* MarshalTo(this ClearAttachment[] values)
		{
			throw new NotImplementedException();
		}
	}

	public struct ClearDepthStencilValue
	{

		public float Depth;

		public uint Stencil;

		internal unsafe ClearDepthStencilValue* MarshalTo()
		{
			throw new NotImplementedException();
		}
	}

	internal static class ClearDepthStencilValueExtensions
	{
		internal unsafe static ClearDepthStencilValue* MarshalTo(this ClearDepthStencilValue[] values)
		{
			throw new NotImplementedException();
		}
	}

	public struct ClearRect
	{

		public Rect2D Rect;

		public uint BaseArrayLayer;

		public uint LayerCount;

		internal unsafe ClearRect* MarshalTo()
		{
			throw new NotImplementedException();
		}
	}

	internal static class ClearRectExtensions
	{
		internal unsafe static ClearRect* MarshalTo(this ClearRect[] values)
		{
			throw new NotImplementedException();
		}
	}

	public struct ComponentMapping
	{

		public ComponentSwizzle R;

		public ComponentSwizzle G;

		public ComponentSwizzle B;

		public ComponentSwizzle A;

		internal unsafe ComponentMapping* MarshalTo()
		{
			throw new NotImplementedException();
		}
	}

	internal static class ComponentMappingExtensions
	{
		internal unsafe static ComponentMapping* MarshalTo(this ComponentMapping[] values)
		{
			throw new NotImplementedException();
		}
	}

	public struct DescriptorPoolSize
	{

		public DescriptorType Type;

		public uint DescriptorCount;

		internal unsafe DescriptorPoolSize* MarshalTo()
		{
			throw new NotImplementedException();
		}
	}

	internal static class DescriptorPoolSizeExtensions
	{
		internal unsafe static DescriptorPoolSize* MarshalTo(this DescriptorPoolSize[] values)
		{
			throw new NotImplementedException();
		}
	}

	public struct DispatchIndirectCommand
	{

		public uint X;

		public uint Y;

		public uint Z;

		internal unsafe DispatchIndirectCommand* MarshalTo()
		{
			throw new NotImplementedException();
		}
	}

	internal static class DispatchIndirectCommandExtensions
	{
		internal unsafe static DispatchIndirectCommand* MarshalTo(this DispatchIndirectCommand[] values)
		{
			throw new NotImplementedException();
		}
	}

	public struct DrawIndexedIndirectCommand
	{

		public uint IndexCount;

		public uint InstanceCount;

		public uint FirstIndex;

		public int VertexOffset;

		public uint FirstInstance;

		internal unsafe DrawIndexedIndirectCommand* MarshalTo()
		{
			throw new NotImplementedException();
		}
	}

	internal static class DrawIndexedIndirectCommandExtensions
	{
		internal unsafe static DrawIndexedIndirectCommand* MarshalTo(this DrawIndexedIndirectCommand[] values)
		{
			throw new NotImplementedException();
		}
	}

	public struct DrawIndirectCommand
	{

		public uint VertexCount;

		public uint InstanceCount;

		public uint FirstVertex;

		public uint FirstInstance;

		internal unsafe DrawIndirectCommand* MarshalTo()
		{
			throw new NotImplementedException();
		}
	}

	internal static class DrawIndirectCommandExtensions
	{
		internal unsafe static DrawIndirectCommand* MarshalTo(this DrawIndirectCommand[] values)
		{
			throw new NotImplementedException();
		}
	}

	public struct Extent2D
	{

		public uint Width;

		public uint Height;

		internal unsafe Extent2D* MarshalTo()
		{
			throw new NotImplementedException();
		}
	}

	internal static class Extent2DExtensions
	{
		internal unsafe static Extent2D* MarshalTo(this Extent2D[] values)
		{
			throw new NotImplementedException();
		}
	}

	public struct Extent3D
	{

		public uint Width;

		public uint Height;

		public uint Depth;

		internal unsafe Extent3D* MarshalTo()
		{
			throw new NotImplementedException();
		}
	}

	internal static class Extent3DExtensions
	{
		internal unsafe static Extent3D* MarshalTo(this Extent3D[] values)
		{
			throw new NotImplementedException();
		}
	}

	public struct FormatProperties
	{

		public FormatFeatureFlags LinearTilingFeatures;

		public FormatFeatureFlags OptimalTilingFeatures;

		public FormatFeatureFlags BufferFeatures;

		internal unsafe FormatProperties* MarshalTo()
		{
			throw new NotImplementedException();
		}
	}

	internal static class FormatPropertiesExtensions
	{
		internal unsafe static FormatProperties* MarshalTo(this FormatProperties[] values)
		{
			throw new NotImplementedException();
		}
	}

	public struct ImageCopy
	{

		public ImageSubresourceLayers SourceSubresource;

		public Offset3D SourceOffset;

		public ImageSubresourceLayers DestinationSubresource;

		public Offset3D DestinationOffset;

		public Extent3D Extent;

		internal unsafe ImageCopy* MarshalTo()
		{
			throw new NotImplementedException();
		}
	}

	internal static class ImageCopyExtensions
	{
		internal unsafe static ImageCopy* MarshalTo(this ImageCopy[] values)
		{
			throw new NotImplementedException();
		}
	}

	public struct ImageFormatProperties
	{

		public Extent3D MaxExtent;

		public uint MaxMipLevels;

		public uint MaxArrayLayers;

		public SampleCountFlags SampleCounts;

		public DeviceSize MaxResourceSize;

		internal unsafe ImageFormatProperties* MarshalTo()
		{
			throw new NotImplementedException();
		}
	}

	internal static class ImageFormatPropertiesExtensions
	{
		internal unsafe static ImageFormatProperties* MarshalTo(this ImageFormatProperties[] values)
		{
			throw new NotImplementedException();
		}
	}

	public struct ImageResolve
	{

		public ImageSubresourceLayers SourceSubresource;

		public Offset3D SourceOffset;

		public ImageSubresourceLayers DestinationSubresource;

		public Offset3D DestinationOffset;

		public Extent3D Extent;

		internal unsafe ImageResolve* MarshalTo()
		{
			throw new NotImplementedException();
		}
	}

	internal static class ImageResolveExtensions
	{
		internal unsafe static ImageResolve* MarshalTo(this ImageResolve[] values)
		{
			throw new NotImplementedException();
		}
	}

	public struct ImageSubresource
	{

		public ImageAspectFlags AspectMask;

		public uint MipLevel;

		public uint ArrayLayer;

		internal unsafe ImageSubresource* MarshalTo()
		{
			throw new NotImplementedException();
		}
	}

	internal static class ImageSubresourceExtensions
	{
		internal unsafe static ImageSubresource* MarshalTo(this ImageSubresource[] values)
		{
			throw new NotImplementedException();
		}
	}

	public struct ImageSubresourceLayers
	{

		public ImageAspectFlags AspectMask;

		public uint MipLevel;

		public uint BaseArrayLayer;

		public uint LayerCount;

		internal unsafe ImageSubresourceLayers* MarshalTo()
		{
			throw new NotImplementedException();
		}
	}

	internal static class ImageSubresourceLayersExtensions
	{
		internal unsafe static ImageSubresourceLayers* MarshalTo(this ImageSubresourceLayers[] values)
		{
			throw new NotImplementedException();
		}
	}

	public struct ImageSubresourceRange
	{

		public ImageAspectFlags AspectMask;

		public uint BaseMipLevel;

		public uint LevelCount;

		public uint BaseArrayLayer;

		public uint LayerCount;

		internal unsafe ImageSubresourceRange* MarshalTo()
		{
			throw new NotImplementedException();
		}
	}

	internal static class ImageSubresourceRangeExtensions
	{
		internal unsafe static ImageSubresourceRange* MarshalTo(this ImageSubresourceRange[] values)
		{
			throw new NotImplementedException();
		}
	}

	public struct MemoryHeap
	{

		public DeviceSize Size;

		public MemoryHeapFlags Flags;

		internal unsafe MemoryHeap* MarshalTo()
		{
			throw new NotImplementedException();
		}
	}

	internal static class MemoryHeapExtensions
	{
		internal unsafe static MemoryHeap* MarshalTo(this MemoryHeap[] values)
		{
			throw new NotImplementedException();
		}
	}

	public struct MemoryRequirements
	{

		public DeviceSize Size;

		public DeviceSize Alignment;

		public uint MemoryTypeBits;

		internal unsafe MemoryRequirements* MarshalTo()
		{
			throw new NotImplementedException();
		}
	}

	internal static class MemoryRequirementsExtensions
	{
		internal unsafe static MemoryRequirements* MarshalTo(this MemoryRequirements[] values)
		{
			throw new NotImplementedException();
		}
	}

	public struct MemoryType
	{

		public MemoryPropertyFlags PropertyFlags;

		public uint HeapIndex;

		internal unsafe MemoryType* MarshalTo()
		{
			throw new NotImplementedException();
		}
	}

	internal static class MemoryTypeExtensions
	{
		internal unsafe static MemoryType* MarshalTo(this MemoryType[] values)
		{
			throw new NotImplementedException();
		}
	}

	public struct Offset2D
	{

		public int X;

		public int Y;

		internal unsafe Offset2D* MarshalTo()
		{
			throw new NotImplementedException();
		}
	}

	internal static class Offset2DExtensions
	{
		internal unsafe static Offset2D* MarshalTo(this Offset2D[] values)
		{
			throw new NotImplementedException();
		}
	}

	public struct Offset3D
	{

		public int X;

		public int Y;

		public int Z;

		internal unsafe Offset3D* MarshalTo()
		{
			throw new NotImplementedException();
		}
	}

	internal static class Offset3DExtensions
	{
		internal unsafe static Offset3D* MarshalTo(this Offset3D[] values)
		{
			throw new NotImplementedException();
		}
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

		internal unsafe PhysicalDeviceFeatures* MarshalTo()
		{
			throw new NotImplementedException();
		}
	}

	internal static class PhysicalDeviceFeaturesExtensions
	{
		internal unsafe static PhysicalDeviceFeatures* MarshalTo(this PhysicalDeviceFeatures[] values)
		{
			throw new NotImplementedException();
		}
	}

	public struct PhysicalDeviceSparseProperties
	{

		public Bool32 ResidencyStandard2DBlockShape;

		public Bool32 ResidencyStandard2DMultisampleBlockShape;

		public Bool32 ResidencyStandard3DBlockShape;

		public Bool32 ResidencyAlignedMipSize;

		public Bool32 ResidencyNonResidentStrict;

		internal unsafe PhysicalDeviceSparseProperties* MarshalTo()
		{
			throw new NotImplementedException();
		}
	}

	internal static class PhysicalDeviceSparsePropertiesExtensions
	{
		internal unsafe static PhysicalDeviceSparseProperties* MarshalTo(this PhysicalDeviceSparseProperties[] values)
		{
			throw new NotImplementedException();
		}
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

		internal unsafe PipelineColorBlendAttachmentState* MarshalTo()
		{
			throw new NotImplementedException();
		}
	}

	internal static class PipelineColorBlendAttachmentStateExtensions
	{
		internal unsafe static PipelineColorBlendAttachmentState* MarshalTo(this PipelineColorBlendAttachmentState[] values)
		{
			throw new NotImplementedException();
		}
	}

	public struct PushConstantRange
	{

		public ShaderStageFlags StageFlags;

		public uint Offset;

		public uint Size;

		internal unsafe PushConstantRange* MarshalTo()
		{
			throw new NotImplementedException();
		}
	}

	internal static class PushConstantRangeExtensions
	{
		internal unsafe static PushConstantRange* MarshalTo(this PushConstantRange[] values)
		{
			throw new NotImplementedException();
		}
	}

	public struct QueueFamilyProperties
	{

		public QueueFlags QueueFlags;

		public uint QueueCount;

		public uint TimestampValidBits;

		public Extent3D MinImageTransferGranularity;

		internal unsafe QueueFamilyProperties* MarshalTo()
		{
			throw new NotImplementedException();
		}
	}

	internal static class QueueFamilyPropertiesExtensions
	{
		internal unsafe static QueueFamilyProperties* MarshalTo(this QueueFamilyProperties[] values)
		{
			throw new NotImplementedException();
		}
	}

	public struct Rect2D
	{

		public Offset2D Offset;

		public Extent2D Extent;

		internal unsafe Rect2D* MarshalTo()
		{
			throw new NotImplementedException();
		}
	}

	internal static class Rect2DExtensions
	{
		internal unsafe static Rect2D* MarshalTo(this Rect2D[] values)
		{
			throw new NotImplementedException();
		}
	}

	public struct SparseImageFormatProperties
	{

		public ImageAspectFlags AspectMask;

		public Extent3D ImageGranularity;

		public SparseImageFormatFlags Flags;

		internal unsafe SparseImageFormatProperties* MarshalTo()
		{
			throw new NotImplementedException();
		}
	}

	internal static class SparseImageFormatPropertiesExtensions
	{
		internal unsafe static SparseImageFormatProperties* MarshalTo(this SparseImageFormatProperties[] values)
		{
			throw new NotImplementedException();
		}
	}

	public struct SparseImageMemoryRequirements
	{

		public SparseImageFormatProperties FormatProperties;

		public uint ImageMipTailFirstLod;

		public DeviceSize ImageMipTailSize;

		public DeviceSize ImageMipTailOffset;

		public DeviceSize ImageMipTailStride;

		internal unsafe SparseImageMemoryRequirements* MarshalTo()
		{
			throw new NotImplementedException();
		}
	}

	internal static class SparseImageMemoryRequirementsExtensions
	{
		internal unsafe static SparseImageMemoryRequirements* MarshalTo(this SparseImageMemoryRequirements[] values)
		{
			throw new NotImplementedException();
		}
	}

	public struct SpecializationMapEntry
	{

		public uint ConstantID;

		public uint Offset;

		public UIntPtr Size;

		internal unsafe SpecializationMapEntry* MarshalTo()
		{
			throw new NotImplementedException();
		}
	}

	internal static class SpecializationMapEntryExtensions
	{
		internal unsafe static SpecializationMapEntry* MarshalTo(this SpecializationMapEntry[] values)
		{
			throw new NotImplementedException();
		}
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

		internal unsafe StencilOpState* MarshalTo()
		{
			throw new NotImplementedException();
		}
	}

	internal static class StencilOpStateExtensions
	{
		internal unsafe static StencilOpState* MarshalTo(this StencilOpState[] values)
		{
			throw new NotImplementedException();
		}
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

		internal unsafe SubpassDependency* MarshalTo()
		{
			throw new NotImplementedException();
		}
	}

	internal static class SubpassDependencyExtensions
	{
		internal unsafe static SubpassDependency* MarshalTo(this SubpassDependency[] values)
		{
			throw new NotImplementedException();
		}
	}

	public struct SubresourceLayout
	{

		public DeviceSize Offset;

		public DeviceSize Size;

		public DeviceSize RowPitch;

		public DeviceSize ArrayPitch;

		public DeviceSize DepthPitch;

		internal unsafe SubresourceLayout* MarshalTo()
		{
			throw new NotImplementedException();
		}
	}

	internal static class SubresourceLayoutExtensions
	{
		internal unsafe static SubresourceLayout* MarshalTo(this SubresourceLayout[] values)
		{
			throw new NotImplementedException();
		}
	}

	public struct VertexInputAttributeDescription
	{

		public uint Location;

		public uint Binding;

		public Format Format;

		public uint Offset;

		internal unsafe VertexInputAttributeDescription* MarshalTo()
		{
			throw new NotImplementedException();
		}
	}

	internal static class VertexInputAttributeDescriptionExtensions
	{
		internal unsafe static VertexInputAttributeDescription* MarshalTo(this VertexInputAttributeDescription[] values)
		{
			throw new NotImplementedException();
		}
	}

	public struct VertexInputBindingDescription
	{

		public uint Binding;

		public uint Stride;

		public VertexInputRate InputRate;

		internal unsafe VertexInputBindingDescription* MarshalTo()
		{
			throw new NotImplementedException();
		}
	}

	internal static class VertexInputBindingDescriptionExtensions
	{
		internal unsafe static VertexInputBindingDescription* MarshalTo(this VertexInputBindingDescription[] values)
		{
			throw new NotImplementedException();
		}
	}

	public struct Viewport
	{

		public float X;

		public float Y;

		public float Width;

		public float Height;

		public float MinDepth;

		public float MaxDepth;

		internal unsafe Viewport* MarshalTo()
		{
			throw new NotImplementedException();
		}
	}

	internal static class ViewportExtensions
	{
		internal unsafe static Viewport* MarshalTo(this Viewport[] values)
		{
			throw new NotImplementedException();
		}
	}
}