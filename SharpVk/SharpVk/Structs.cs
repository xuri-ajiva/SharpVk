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

	public struct Viewport
	{

		public float X;

		public float Y;

		public float Width;

		public float Height;

		public float MinDepth;

		public float MaxDepth;
	}

	public struct Rect2D
	{

		public Offset2D Offset;

		public Extent2D Extent;
	}

	public struct Rect3D
	{

		public Offset3D Offset;

		public Extent3D Extent;
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

	public struct QueueFamilyProperties
	{

		public QueueFlags QueueFlags;

		public uint QueueCount;

		public uint TimestampValidBits;

		public Extent3D MinImageTransferGranularity;
	}

	public struct SparseImageFormatProperties
	{

		public ImageAspectFlags AspectMask;

		public Extent3D ImageGranularity;

		public SparseImageFormatFlags Flags;
	}

	public struct MemoryType
	{

		public MemoryPropertyFlags PropertyFlags;

		public uint HeapIndex;
	}

	public struct FormatProperties
	{

		public FormatFeatureFlags LinearTilingFeatures;

		public FormatFeatureFlags OptimalTilingFeatures;

		public FormatFeatureFlags BufferFeatures;
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

	public struct ImageCopy
	{

		public ImageSubresourceLayers SrcSubresource;

		public Offset3D SrcOffset;

		public ImageSubresourceLayers DstSubresource;

		public Offset3D DstOffset;

		public Extent3D Extent;
	}

	public struct ImageResolve
	{

		public ImageSubresourceLayers SrcSubresource;

		public Offset3D SrcOffset;

		public ImageSubresourceLayers DstSubresource;

		public Offset3D DstOffset;

		public Extent3D Extent;
	}

	public struct DescriptorPoolSize
	{

		public DescriptorType Type;

		public uint DescriptorCount;
	}

	public struct SpecializationMapEntry
	{

		public uint ConstantID;

		public uint Offset;

		public UIntPtr Size;
	}

	public struct VertexInputBindingDescription
	{

		public uint Binding;

		public uint Stride;

		public VertexInputRate InputRate;
	}

	public struct VertexInputAttributeDescription
	{

		public uint Location;

		public uint Binding;

		public Format Format;

		public uint Offset;
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

	public struct PushConstantRange
	{

		public ShaderStageFlags StageFlags;

		public uint Offset;

		public uint Size;
	}

	public struct ClearDepthStencilValue
	{

		public float Depth;

		public uint Stencil;
	}

	public struct ClearAttachment
	{

		public ImageAspectFlags AspectMask;

		public uint ColorAttachment;

		public ClearValue ClearValue;
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

	public struct SubpassDependency
	{

		public uint SrcSubpass;

		public uint DstSubpass;

		public PipelineStageFlags SrcStageMask;

		public PipelineStageFlags DstStageMask;

		public AccessFlags SrcAccessMask;

		public AccessFlags DstAccessMask;

		public DependencyFlags DependencyFlags;
	}

	public struct DrawIndirectCommand
	{

		public uint VertexCount;

		public uint InstanceCount;

		public uint FirstVertex;

		public uint FirstInstance;
	}

	public struct DrawIndexedIndirectCommand
	{

		public uint IndexCount;

		public uint InstanceCount;

		public uint FirstIndex;

		public int VertexOffset;

		public uint FirstInstance;
	}

	public struct DispatchIndirectCommand
	{

		public uint X;

		public uint Y;

		public uint Z;
	}
}