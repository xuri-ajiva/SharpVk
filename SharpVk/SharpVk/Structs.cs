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
using System.Runtime.InteropServices;
using System.Text;

namespace SharpVk
{
	/// <summary>
	/// -
	/// </summary>
	public struct SampleMask
	{
		private uint value;
		
		/// <summary>
		/// -
		/// </summary>
		public static implicit operator SampleMask(uint value)
		{
			return new SampleMask { value = value };
		}
		
		/// <summary>
		/// -
		/// </summary>
		public static implicit operator uint(SampleMask size)
		{
			return size.value;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public override string ToString()
		{
			return this.value.ToString();
		}
	}
	
	/// <summary>
	/// -
	/// </summary>
	public struct Bool32
	{
		private uint value;
		
		/// <summary>
		/// -
		/// </summary>
		public Bool32(bool value)
		{
			this.value = value
							? Constants.True
							: Constants.False;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public static implicit operator Bool32(bool value)
		{
			return new Bool32(value);
		}
		
		/// <summary>
		/// -
		/// </summary>
		public static implicit operator bool(Bool32 value)
		{
			return value.value != Constants.False;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public override string ToString()
		{
			return ((bool)this).ToString();
		}
	}
	
	/// <summary>
	/// -
	/// </summary>
	public struct DeviceSize
	{
		private ulong value;
		
		/// <summary>
		/// -
		/// </summary>
		public static implicit operator DeviceSize(int value)
		{
			return new DeviceSize { value = (ulong)value };
		}
		
		/// <summary>
		/// -
		/// </summary>
		public static implicit operator DeviceSize(ulong value)
		{
			return new DeviceSize { value = value };
		}
		
		/// <summary>
		/// -
		/// </summary>
		public static implicit operator ulong(DeviceSize size)
		{
			return size.value;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public override string ToString()
		{
			return this.value.ToString();
		}
	}

	public partial struct ComponentMapping
	{
		/// <summary>
		/// Returns a default ComponentMapping of Identity for all components.
		/// </summary>
		public static ComponentMapping Identity
		{
			get
			{
				return new ComponentMapping
					{
						R = ComponentSwizzle.Identity,
						G = ComponentSwizzle.Identity,
						B = ComponentSwizzle.Identity,
						A = ComponentSwizzle.Identity
					};
			}
		}
	}

    /// <summary>
    /// If the attachment uses a color format, then pname:loadOp and pname:storeOp
    /// are used, and pname:stencilLoadOp and pname:stencilStoreOp are ignored. If
    /// the format has depth and/or stencil components, pname:loadOp and
    /// pname:storeOp apply only to the depth data, while pname:stencilLoadOp and
    /// pname:stencilStoreOp define how the stencil data is handled.
    /// [[renderpass-precision]]
    /// During a render pass instance, input/color attachments with color formats
    /// that have a component size of 8, 16, or 32 bits must: be represented in the
    /// attachment's format throughout the instance. Attachments with other
    /// floating- or fixed-point color formats, or with depth components may: be
    /// represented in a format with a precision higher than the attachment format,
    /// but must: be represented with the same range. When such a component is
    /// loaded via the pname:loadOp, it will be converted into an
    /// implementation-dependent format used by the render pass. Such components
    /// must: be converted from the render pass format, to the format of the
    /// attachment, before they are stored or resolved at the end of a render pass
    /// instance via pname:storeOp. Conversions occur as described in
    /// &lt;&lt;fundamentals-numerics,Numeric Representation and Computation&gt;&gt; and
    /// &lt;&lt;fundamentals-fixedconv, Fixed-Point Data Conversions&gt;&gt;.
    /// [[renderpass-aliasing]]
    /// If pname:flags includes ename:VK_ATTACHMENT_DESCRIPTION_MAY_ALIAS_BIT, then
    /// the attachment is treated as if it shares physical memory with another
    /// attachment in the same render pass. This information limits the ability of
    /// the implementation to reorder certain operations (like layout transitions
    /// and the pname:loadOp) such that it is not improperly reordered against
    /// other uses of the same physical memory via a different attachment. This is
    /// described in more detail below.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
	public partial struct AttachmentDescription
	{
		/// <summary>
		/// -
		/// </summary>
		public AttachmentDescriptionFlags Flags;

		/// <summary>
		/// -
		/// </summary>
		public Format Format;

		/// <summary>
		/// -
		/// </summary>
		public SampleCountFlags Samples;

		/// <summary>
		/// -
		/// </summary>
		public AttachmentLoadOp LoadOp;

		/// <summary>
		/// -
		/// </summary>
		public AttachmentStoreOp StoreOp;

		/// <summary>
		/// -
		/// </summary>
		public AttachmentLoadOp StencilLoadOp;

		/// <summary>
		/// -
		/// </summary>
		public AttachmentStoreOp StencilStoreOp;

		/// <summary>
		/// -
		/// </summary>
		public ImageLayout InitialLayout;

		/// <summary>
		/// -
		/// </summary>
		public ImageLayout FinalLayout;

		/// <summary>
		/// -
		/// </summary>
		public override string ToString()
		{
			var builder = new StringBuilder();
			
            builder.AppendLine("AttachmentDescription");
            builder.AppendLine("{");
            builder.AppendLine($"Flags: {this.Flags}");
            builder.AppendLine($"Format: {this.Format}");
            builder.AppendLine($"Samples: {this.Samples}");
            builder.AppendLine($"LoadOp: {this.LoadOp}");
            builder.AppendLine($"StoreOp: {this.StoreOp}");
            builder.AppendLine($"StencilLoadOp: {this.StencilLoadOp}");
            builder.AppendLine($"StencilStoreOp: {this.StencilStoreOp}");
            builder.AppendLine($"InitialLayout: {this.InitialLayout}");
            builder.AppendLine($"FinalLayout: {this.FinalLayout}");
            builder.Append("}");

			return builder.ToString();
		}
	}

    /// <summary>
    /// -
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
	public partial struct AttachmentReference
	{
		/// <summary>
		/// -
		/// </summary>
		public uint Attachment;

		/// <summary>
		/// -
		/// </summary>
		public ImageLayout Layout;

		/// <summary>
		/// -
		/// </summary>
		public override string ToString()
		{
			var builder = new StringBuilder();
			
            builder.AppendLine("AttachmentReference");
            builder.AppendLine("{");
            builder.AppendLine($"Attachment: {this.Attachment}");
            builder.AppendLine($"Layout: {this.Layout}");
            builder.Append("}");

			return builder.ToString();
		}
	}

    /// <summary>
    /// -
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
	public partial struct BufferCopy
	{
		/// <summary>
		/// -
		/// </summary>
		public DeviceSize SourceOffset;

		/// <summary>
		/// -
		/// </summary>
		public DeviceSize DestinationOffset;

		/// <summary>
		/// -
		/// </summary>
		public DeviceSize Size;

		/// <summary>
		/// -
		/// </summary>
		public override string ToString()
		{
			var builder = new StringBuilder();
			
            builder.AppendLine("BufferCopy");
            builder.AppendLine("{");
            builder.AppendLine($"SourceOffset: {this.SourceOffset}");
            builder.AppendLine($"DestinationOffset: {this.DestinationOffset}");
            builder.AppendLine($"Size: {this.Size}");
            builder.Append("}");

			return builder.ToString();
		}
	}

    /// <summary>
    /// When copying to or from a depth or stencil aspect, the data in buffer
    /// memory uses a layout that is a (mostly) tightly packed representation of
    /// the depth or stencil data. Specifically:
    ///   * data copied to or from the stencil aspect of any depth/stencil format
    ///     is tightly packed with one ename:VK_FORMAT_S8_UINT value per texel.
    ///   * data copied to or from the depth aspect of a ename:VK_FORMAT_D16_UNORM
    ///     or ename:VK_FORMAT_D16_UNORM_S8_UINT format is tightly packed with one
    ///     ename:VK_FORMAT_D16_UNORM value per texel.
    ///   * data copied to or from the depth aspect of a ename:VK_FORMAT_D32_SFLOAT
    ///     or ename:VK_FORMAT_D32_SFLOAT_S8_UINT format is tightly packed with
    ///     one ename:VK_FORMAT_D32_SFLOAT value per texel.
    ///   * data copied to or from the depth aspect of a
    ///     ename:VK_FORMAT_X8_D24_UNORM_PACK32 or
    ///     ename:VK_FORMAT_D24_UNORM_S8_UINT format is packed with one 32-bit word
    ///     per texel with the D24 value in the LSBs of the word, and undefined
    ///     values in the eight MSBs.
    /// [NOTE]
    /// .Note
    /// ====
    /// To copy both the depth and stencil aspects of a depth/stencil format, two
    /// entries in pname:pRegions can: be used, where one specifies the depth
    /// aspect in pname:imageSubresource, and the other specifies the stencil
    /// aspect.
    /// ====
    /// Because depth or stencil aspect buffer to image copies may: require format
    /// conversions on some implementations, they are not supported on queues
    /// that do not support graphics.
    /// Copies are done layer by layer starting with image layer
    /// pname:baseArrayLayer member of pname:imageSubresource. pname:layerCount
    /// layers are copied from the source image or to the destination image.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
	public partial struct BufferImageCopy
	{
		/// <summary>
		/// -
		/// </summary>
		public DeviceSize BufferOffset;

		/// <summary>
		/// -
		/// </summary>
		public uint BufferRowLength;

		/// <summary>
		/// -
		/// </summary>
		public uint BufferImageHeight;

		/// <summary>
		/// -
		/// </summary>
		public ImageSubresourceLayers ImageSubresource;

		/// <summary>
		/// -
		/// </summary>
		public Offset3D ImageOffset;

		/// <summary>
		/// -
		/// </summary>
		public Extent3D ImageExtent;

		/// <summary>
		/// -
		/// </summary>
		public override string ToString()
		{
			var builder = new StringBuilder();
			
            builder.AppendLine("BufferImageCopy");
            builder.AppendLine("{");
            builder.AppendLine($"BufferOffset: {this.BufferOffset}");
            builder.AppendLine($"BufferRowLength: {this.BufferRowLength}");
            builder.AppendLine($"BufferImageHeight: {this.BufferImageHeight}");
            builder.AppendLine($"ImageSubresource: {this.ImageSubresource}");
            builder.AppendLine($"ImageOffset: {this.ImageOffset}");
            builder.AppendLine($"ImageExtent: {this.ImageExtent}");
            builder.Append("}");

			return builder.ToString();
		}
	}

    /// <summary>
    /// No memory barriers are needed between fname:vkCmdClearAttachments and
    /// preceding or subsequent draw or attachment clear commands in the same
    /// subpass.
    /// The fname:vkCmdClearAttachments command is not affected by the bound
    /// pipeline state.
    /// Attachments can: also be cleared at the beginning of a render pass instance
    /// by setting pname:loadOp (or pname:stencilLoadOp) of
    /// slink:VkAttachmentDescription to ename:VK_ATTACHMENT_LOAD_OP_CLEAR, as
    /// described for flink:vkCreateRenderPass.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
	public partial struct ClearAttachment
	{
		/// <summary>
		/// -
		/// </summary>
		public ImageAspectFlags AspectMask;

		/// <summary>
		/// -
		/// </summary>
		public uint ColorAttachment;

		/// <summary>
		/// -
		/// </summary>
		public ClearValue ClearValue;

		/// <summary>
		/// -
		/// </summary>
		public override string ToString()
		{
			var builder = new StringBuilder();
			
            builder.AppendLine("ClearAttachment");
            builder.AppendLine("{");
            builder.AppendLine($"AspectMask: {this.AspectMask}");
            builder.AppendLine($"ColorAttachment: {this.ColorAttachment}");
            builder.AppendLine($"ClearValue: {this.ClearValue}");
            builder.Append("}");

			return builder.ToString();
		}
	}

    /// <summary>
    /// -
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
	public partial struct ClearDepthStencilValue
	{
		/// <summary>
		/// -
		/// </summary>
		public float Depth;

		/// <summary>
		/// -
		/// </summary>
		public uint Stencil;

		/// <summary>
		/// -
		/// </summary>
		public override string ToString()
		{
			var builder = new StringBuilder();
			
            builder.AppendLine("ClearDepthStencilValue");
            builder.AppendLine("{");
            builder.AppendLine($"Depth: {this.Depth}");
            builder.AppendLine($"Stencil: {this.Stencil}");
            builder.Append("}");

			return builder.ToString();
		}
	}

    /// <summary>
    /// The layers latexmath:[$[baseArrayLayer, baseArrayLayer+layerCount)$]
    /// counting from the base layer of the attachment image view are cleared.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
	public partial struct ClearRect
	{
		/// <summary>
		/// -
		/// </summary>
		public Rect2D Rect;

		/// <summary>
		/// -
		/// </summary>
		public uint BaseArrayLayer;

		/// <summary>
		/// -
		/// </summary>
		public uint LayerCount;

		/// <summary>
		/// -
		/// </summary>
		public override string ToString()
		{
			var builder = new StringBuilder();
			
            builder.AppendLine("ClearRect");
            builder.AppendLine("{");
            builder.AppendLine($"Rect: {this.Rect}");
            builder.AppendLine($"BaseArrayLayer: {this.BaseArrayLayer}");
            builder.AppendLine($"LayerCount: {this.LayerCount}");
            builder.Append("}");

			return builder.ToString();
		}
	}

    /// <summary>
    /// Each of pname:r, pname:g, pname:b, and pname:a is one of the values:
    /// // refBegin VkComponentSwizzle - specify how a component is swizzled
    /// include::../api/enums/VkComponentSwizzle.txt[]
    ///   * ename:VK_COMPONENT_SWIZZLE_IDENTITY: the component is set to the
    ///     identity swizzle.
    ///   * ename:VK_COMPONENT_SWIZZLE_ZERO: the component is set to zero.
    ///   * ename:VK_COMPONENT_SWIZZLE_ONE: the component is set to either 1 or 1.0
    ///     depending on whether the type of the image view format is integer or
    ///     floating-point respectively, as determined by the
    ///     &lt;&lt;features-formats-definition,Format Definition&gt;&gt; section for each
    ///     elink:VkFormat.
    ///   * ename:VK_COMPONENT_SWIZZLE_R: the component is set to the value
    ///     of the R component of the image.
    ///   * ename:VK_COMPONENT_SWIZZLE_G: the component is set to the value
    ///     of the G component of the image.
    ///   * ename:VK_COMPONENT_SWIZZLE_B: the component is set to the value
    ///     of the B component of the image.
    ///   * ename:VK_COMPONENT_SWIZZLE_A: the component is set to the value
    ///     of the A component of the image.
    /// Setting the identity swizzle on a component is equivalent to setting the
    /// identity mapping on that component. That is:
    /// [[resources-image-views-identity-mappings]]
    /// .Component Mappings Equivalent To ename:VK_COMPONENT_SWIZZLE_IDENTITY
    /// [options="header"]
    /// |====
    /// | Component          | Identity Mapping
    /// | pname:components.r | ename:VK_COMPONENT_SWIZZLE_R
    /// | pname:components.g | ename:VK_COMPONENT_SWIZZLE_G
    /// | pname:components.b | ename:VK_COMPONENT_SWIZZLE_B
    /// | pname:components.a | ename:VK_COMPONENT_SWIZZLE_A
    /// |====
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
	public partial struct ComponentMapping
	{
		/// <summary>
		/// -
		/// </summary>
		public ComponentSwizzle R;

		/// <summary>
		/// -
		/// </summary>
		public ComponentSwizzle G;

		/// <summary>
		/// -
		/// </summary>
		public ComponentSwizzle B;

		/// <summary>
		/// -
		/// </summary>
		public ComponentSwizzle A;

		/// <summary>
		/// -
		/// </summary>
		public override string ToString()
		{
			var builder = new StringBuilder();
			
            builder.AppendLine("ComponentMapping");
            builder.AppendLine("{");
            builder.AppendLine($"R: {this.R}");
            builder.AppendLine($"G: {this.G}");
            builder.AppendLine($"B: {this.B}");
            builder.AppendLine($"A: {this.A}");
            builder.Append("}");

			return builder.ToString();
		}
	}

    /// <summary>
    /// -
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
	public partial struct DescriptorPoolSize
	{
		/// <summary>
		/// -
		/// </summary>
		public DescriptorType Type;

		/// <summary>
		/// -
		/// </summary>
		public uint DescriptorCount;

		/// <summary>
		/// -
		/// </summary>
		public override string ToString()
		{
			var builder = new StringBuilder();
			
            builder.AppendLine("DescriptorPoolSize");
            builder.AppendLine("{");
            builder.AppendLine($"Type: {this.Type}");
            builder.AppendLine($"DescriptorCount: {this.DescriptorCount}");
            builder.Append("}");

			return builder.ToString();
		}
	}

    /// <summary>
    /// The members of sname:VkDispatchIndirectCommand structure have the same
    /// meaning as the similarly named parameters of flink:vkCmdDispatch.
    /// include::../validity/structs/VkDispatchIndirectCommand.txt[]
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
	public partial struct DispatchIndirectCommand
	{
		/// <summary>
		/// -
		/// </summary>
		public uint X;

		/// <summary>
		/// -
		/// </summary>
		public uint Y;

		/// <summary>
		/// -
		/// </summary>
		public uint Z;

		/// <summary>
		/// -
		/// </summary>
		public override string ToString()
		{
			var builder = new StringBuilder();
			
            builder.AppendLine("DispatchIndirectCommand");
            builder.AppendLine("{");
            builder.AppendLine($"X: {this.X}");
            builder.AppendLine($"Y: {this.Y}");
            builder.AppendLine($"Z: {this.Z}");
            builder.Append("}");

			return builder.ToString();
		}
	}

    /// <summary>
    /// 
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
	public partial struct DisplayModeParameters
	{
		/// <summary>
		/// -
		/// </summary>
		public Extent2D VisibleRegion;

		/// <summary>
		/// -
		/// </summary>
		public uint RefreshRate;

		/// <summary>
		/// -
		/// </summary>
		public override string ToString()
		{
			var builder = new StringBuilder();
			
            builder.AppendLine("DisplayModeParameters");
            builder.AppendLine("{");
            builder.AppendLine($"VisibleRegion: {this.VisibleRegion}");
            builder.AppendLine($"RefreshRate: {this.RefreshRate}");
            builder.Append("}");

			return builder.ToString();
		}
	}

    /// <summary>
    /// 
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
	public partial struct DisplayPlaneCapabilities
	{
		/// <summary>
		/// -
		/// </summary>
		public DisplayPlaneAlphaFlags SupportedAlpha;

		/// <summary>
		/// -
		/// </summary>
		public Offset2D MinSourcePosition;

		/// <summary>
		/// -
		/// </summary>
		public Offset2D MaxSourcePosition;

		/// <summary>
		/// -
		/// </summary>
		public Extent2D MinSourceExtent;

		/// <summary>
		/// -
		/// </summary>
		public Extent2D MaxSourceExtent;

		/// <summary>
		/// -
		/// </summary>
		public Offset2D MinDestinationPosition;

		/// <summary>
		/// -
		/// </summary>
		public Offset2D MaxDestinationPosition;

		/// <summary>
		/// -
		/// </summary>
		public Extent2D MinDestinationExtent;

		/// <summary>
		/// -
		/// </summary>
		public Extent2D MaxDestinationExtent;

		/// <summary>
		/// -
		/// </summary>
		public override string ToString()
		{
			var builder = new StringBuilder();
			
            builder.AppendLine("DisplayPlaneCapabilities");
            builder.AppendLine("{");
            builder.AppendLine($"SupportedAlpha: {this.SupportedAlpha}");
            builder.AppendLine($"MinSourcePosition: {this.MinSourcePosition}");
            builder.AppendLine($"MaxSourcePosition: {this.MaxSourcePosition}");
            builder.AppendLine($"MinSourceExtent: {this.MinSourceExtent}");
            builder.AppendLine($"MaxSourceExtent: {this.MaxSourceExtent}");
            builder.AppendLine($"MinDestinationPosition: {this.MinDestinationPosition}");
            builder.AppendLine($"MaxDestinationPosition: {this.MaxDestinationPosition}");
            builder.AppendLine($"MinDestinationExtent: {this.MinDestinationExtent}");
            builder.AppendLine($"MaxDestinationExtent: {this.MaxDestinationExtent}");
            builder.Append("}");

			return builder.ToString();
		}
	}

    /// <summary>
    /// The members of sname:VkDrawIndexedIndirectCommand have the same meaning as
    /// the similarly named parameters of flink:vkCmdDrawIndexed.
    /// include::../validity/structs/VkDrawIndexedIndirectCommand.txt[]
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
	public partial struct DrawIndexedIndirectCommand
	{
		/// <summary>
		/// -
		/// </summary>
		public uint IndexCount;

		/// <summary>
		/// -
		/// </summary>
		public uint InstanceCount;

		/// <summary>
		/// -
		/// </summary>
		public uint FirstIndex;

		/// <summary>
		/// -
		/// </summary>
		public int VertexOffset;

		/// <summary>
		/// -
		/// </summary>
		public uint FirstInstance;

		/// <summary>
		/// -
		/// </summary>
		public override string ToString()
		{
			var builder = new StringBuilder();
			
            builder.AppendLine("DrawIndexedIndirectCommand");
            builder.AppendLine("{");
            builder.AppendLine($"IndexCount: {this.IndexCount}");
            builder.AppendLine($"InstanceCount: {this.InstanceCount}");
            builder.AppendLine($"FirstIndex: {this.FirstIndex}");
            builder.AppendLine($"VertexOffset: {this.VertexOffset}");
            builder.AppendLine($"FirstInstance: {this.FirstInstance}");
            builder.Append("}");

			return builder.ToString();
		}
	}

    /// <summary>
    /// The members of sname:VkDrawIndirectCommand have the same meaning as the
    /// similarly named parameters of flink:vkCmdDraw.
    /// include::../validity/structs/VkDrawIndirectCommand.txt[]
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
	public partial struct DrawIndirectCommand
	{
		/// <summary>
		/// -
		/// </summary>
		public uint VertexCount;

		/// <summary>
		/// -
		/// </summary>
		public uint InstanceCount;

		/// <summary>
		/// -
		/// </summary>
		public uint FirstVertex;

		/// <summary>
		/// -
		/// </summary>
		public uint FirstInstance;

		/// <summary>
		/// -
		/// </summary>
		public override string ToString()
		{
			var builder = new StringBuilder();
			
            builder.AppendLine("DrawIndirectCommand");
            builder.AppendLine("{");
            builder.AppendLine($"VertexCount: {this.VertexCount}");
            builder.AppendLine($"InstanceCount: {this.InstanceCount}");
            builder.AppendLine($"FirstVertex: {this.FirstVertex}");
            builder.AppendLine($"FirstInstance: {this.FirstInstance}");
            builder.Append("}");

			return builder.ToString();
		}
	}

    /// <summary>
    /// -
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
	public partial struct Extent2D
	{
		/// <summary>
		/// -
		/// </summary>
		public uint Width;

		/// <summary>
		/// -
		/// </summary>
		public uint Height;

		/// <summary>
		/// -
		/// </summary>
		public override string ToString()
		{
			var builder = new StringBuilder();
			
            builder.AppendLine("Extent2D");
            builder.AppendLine("{");
            builder.AppendLine($"Width: {this.Width}");
            builder.AppendLine($"Height: {this.Height}");
            builder.Append("}");

			return builder.ToString();
		}
	}

    /// <summary>
    /// -
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
	public partial struct Extent3D
	{
		/// <summary>
		/// -
		/// </summary>
		public uint Width;

		/// <summary>
		/// -
		/// </summary>
		public uint Height;

		/// <summary>
		/// -
		/// </summary>
		public uint Depth;

		/// <summary>
		/// -
		/// </summary>
		public override string ToString()
		{
			var builder = new StringBuilder();
			
            builder.AppendLine("Extent3D");
            builder.AppendLine("{");
            builder.AppendLine($"Width: {this.Width}");
            builder.AppendLine($"Height: {this.Height}");
            builder.AppendLine($"Depth: {this.Depth}");
            builder.Append("}");

			return builder.ToString();
		}
	}

    /// <summary>
    /// Supported features are described as a set of elink:VkFormatFeatureFlagBits:
    /// // refBegin VkFormatFeatureFlagBits - Bitmask specifying features supported by a buffer
    /// include::../api/enums/VkFormatFeatureFlagBits.txt[]
    /// The pname:linearTilingFeatures and pname:optimalTilingFeatures members of
    /// the sname:VkFormatProperties structure describe what features are supported
    /// by ename:VK_IMAGE_TILING_LINEAR and ename:VK_IMAGE_TILING_OPTIMAL images,
    /// respectively.
    /// The following bits may: be set in pname:linearTilingFeatures and
    /// pname:optimalTilingFeatures, indicating they are supported by images or
    /// image views created with the queried
    /// flink:vkGetPhysicalDeviceFormatProperties::pname:format:
    /// ename:VK_FORMAT_FEATURE_SAMPLED_IMAGE_BIT::
    ///     sname:VkImageView can: be sampled from. See
    ///     &lt;&lt;descriptorsets-sampledimage, sampled images&gt;&gt; section.
    /// ename:VK_FORMAT_FEATURE_STORAGE_IMAGE_BIT::
    ///     sname:VkImageView can: be used as storage image. See
    ///     &lt;&lt;descriptorsets-storageimage, storage images&gt;&gt; section.
    /// ename:VK_FORMAT_FEATURE_STORAGE_IMAGE_ATOMIC_BIT::
    ///     sname:VkImageView can: be used as storage image that supports atomic
    ///     operations.
    /// ename:VK_FORMAT_FEATURE_COLOR_ATTACHMENT_BIT::
    ///     sname:VkImageView can: be used as a framebuffer color attachment and
    ///     as an input attachment.
    /// ename:VK_FORMAT_FEATURE_COLOR_ATTACHMENT_BLEND_BIT::
    ///     sname:VkImageView can: be used as a framebuffer color attachment that
    ///     supports blending and as an input attachment.
    /// ename:VK_FORMAT_FEATURE_DEPTH_STENCIL_ATTACHMENT_BIT::
    ///     sname:VkImageView can: be used as a framebuffer depth/stencil attachment
    ///     and as an input attachment.
    /// ename:VK_FORMAT_FEATURE_BLIT_SRC_BIT::
    ///     sname:VkImage can: be used as pname:srcImage for the
    ///     fname:vkCmdBlitImage command.
    /// ename:VK_FORMAT_FEATURE_BLIT_DST_BIT::
    ///     sname:VkImage can: be used as pname:dstImage for the
    ///     fname:vkCmdBlitImage command.
    /// ename:VK_FORMAT_FEATURE_SAMPLED_IMAGE_FILTER_LINEAR_BIT::
    ///     If ename:VK_FORMAT_FEATURE_SAMPLED_IMAGE_BIT is also set,
    ///     sname:VkImageView can: be used with a sampler that has either of
    ///     pname:magFilter or pname:minFilter set to ename:VK_FILTER_LINEAR,
    ///     or pname:mipmapMode set to ename:VK_SAMPLER_MIPMAP_MODE_LINEAR.
    ///     If ename:VK_FORMAT_FEATURE_BLIT_SRC_BIT is also set, sname:VkImage
    ///     can be used as the pname:srcImage to flink:vkCmdBlitImage
    ///     with a pname:filter of ename:VK_FILTER_LINEAR. This bit must: only be
    ///     exposed for formats that also support the
    ///     ename:VK_FORMAT_FEATURE_SAMPLED_IMAGE_BIT or
    ///     ename:VK_FORMAT_FEATURE_BLIT_SRC_BIT.
    /// +
    /// If the format being queried is a depth/stencil format, this bit only indicates
    ///     that the depth aspect (not the stencil aspect) of an image of this format
    ///     supports linear filtering,
    ///     and that linear filtering of the depth aspect is supported whether depth
    ///     compare is enabled in the sampler or not. If this bit is not present,
    ///     linear filtering with depth compare disabled is unsupported and linear
    ///     filtering with depth compare enabled is supported, but may: compute the
    ///     filtered value in an implementation-dependent manner which differs from
    ///     the normal rules of linear filtering. The resulting value must: be in the
    ///     range latexmath:[$[0,1\]$] and should: be proportional to, or a weighted
    ///     average of, the number of comparison passes or failures.
    /// The following features may: appear in pname:bufferFeatures, indicating they
    /// are supported by buffers or buffer views created with the queried
    /// flink:vkGetPhysicalDeviceFormatProperties::pname:format:
    /// ename:VK_FORMAT_FEATURE_UNIFORM_TEXEL_BUFFER_BIT::
    ///     Format can: be used to create a sname:VkBufferView that can: be bound to
    ///     a ename:VK_DESCRIPTOR_TYPE_UNIFORM_TEXEL_BUFFER descriptor.
    /// ename:VK_FORMAT_FEATURE_STORAGE_TEXEL_BUFFER_BIT::
    ///     Format can: be used to create a sname:VkBufferView that can: be bound to
    ///     a ename:VK_DESCRIPTOR_TYPE_STORAGE_TEXEL_BUFFER descriptor.
    /// ename:VK_FORMAT_FEATURE_STORAGE_TEXEL_BUFFER_ATOMIC_BIT::
    ///     Atomic operations are supported on
    ///     ename:VK_DESCRIPTOR_TYPE_STORAGE_TEXEL_BUFFER with this format.
    /// ename:VK_FORMAT_FEATURE_VERTEX_BUFFER_BIT::
    ///     Format can: be used as a vertex attribute format
    ///     (sname:VkVertexInputAttributeDescription::pname:format).
    /// [NOTE]
    /// .Note
    /// ====
    /// If no format feature flags are supported, then the only possible use would
    /// be image transfers - which alone are not useful.
    /// As such, if no format feature flags are supported, the format itself is not
    /// supported, and images of that format cannot be created.
    /// ====
    /// If pname:format is a block-compression format, then buffers mustnot: support
    /// any features for the format.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
	public partial struct FormatProperties
	{
		/// <summary>
		/// -
		/// </summary>
		public FormatFeatureFlags LinearTilingFeatures;

		/// <summary>
		/// -
		/// </summary>
		public FormatFeatureFlags OptimalTilingFeatures;

		/// <summary>
		/// -
		/// </summary>
		public FormatFeatureFlags BufferFeatures;

		/// <summary>
		/// -
		/// </summary>
		public override string ToString()
		{
			var builder = new StringBuilder();
			
            builder.AppendLine("FormatProperties");
            builder.AppendLine("{");
            builder.AppendLine($"LinearTilingFeatures: {this.LinearTilingFeatures}");
            builder.AppendLine($"OptimalTilingFeatures: {this.OptimalTilingFeatures}");
            builder.AppendLine($"BufferFeatures: {this.BufferFeatures}");
            builder.Append("}");

			return builder.ToString();
		}
	}

    /// <summary>
    /// -
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
	public partial struct ImageCopy
	{
		/// <summary>
		/// -
		/// </summary>
		public ImageSubresourceLayers SourceSubresource;

		/// <summary>
		/// -
		/// </summary>
		public Offset3D SourceOffset;

		/// <summary>
		/// -
		/// </summary>
		public ImageSubresourceLayers DestinationSubresource;

		/// <summary>
		/// -
		/// </summary>
		public Offset3D DestinationOffset;

		/// <summary>
		/// -
		/// </summary>
		public Extent3D Extent;

		/// <summary>
		/// -
		/// </summary>
		public override string ToString()
		{
			var builder = new StringBuilder();
			
            builder.AppendLine("ImageCopy");
            builder.AppendLine("{");
            builder.AppendLine($"SourceSubresource: {this.SourceSubresource}");
            builder.AppendLine($"SourceOffset: {this.SourceOffset}");
            builder.AppendLine($"DestinationSubresource: {this.DestinationSubresource}");
            builder.AppendLine($"DestinationOffset: {this.DestinationOffset}");
            builder.AppendLine($"Extent: {this.Extent}");
            builder.Append("}");

			return builder.ToString();
		}
	}

    /// <summary>
    /// [NOTE]
    /// .Note
    /// ====
    /// There is no mechanism to query the size of an image before creating it, to
    /// compare that size against pname:maxResourceSize. If an application attempts
    /// to create an image that exceeds this limit, the creation will fail or the
    /// image will be invalid. While the advertised limit must: be at least 2^31^,
    /// it may: not be possible to create an image that approaches that size,
    /// particularly for ename:VK_IMAGE_TYPE_1D.
    /// ====
    /// If the combination of parameters to
    /// fname:vkGetPhysicalDeviceImageFormatProperties is not supported by the
    /// implementation for use in flink:vkCreateImage, then all members of
    /// sname:VkImageFormatProperties will be filled with zero.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
	public partial struct ImageFormatProperties
	{
		/// <summary>
		/// -
		/// </summary>
		public Extent3D MaxExtent;

		/// <summary>
		/// -
		/// </summary>
		public uint MaxMipLevels;

		/// <summary>
		/// -
		/// </summary>
		public uint MaxArrayLayers;

		/// <summary>
		/// -
		/// </summary>
		public SampleCountFlags SampleCounts;

		/// <summary>
		/// -
		/// </summary>
		public DeviceSize MaxResourceSize;

		/// <summary>
		/// -
		/// </summary>
		public override string ToString()
		{
			var builder = new StringBuilder();
			
            builder.AppendLine("ImageFormatProperties");
            builder.AppendLine("{");
            builder.AppendLine($"MaxExtent: {this.MaxExtent}");
            builder.AppendLine($"MaxMipLevels: {this.MaxMipLevels}");
            builder.AppendLine($"MaxArrayLayers: {this.MaxArrayLayers}");
            builder.AppendLine($"SampleCounts: {this.SampleCounts}");
            builder.AppendLine($"MaxResourceSize: {this.MaxResourceSize}");
            builder.Append("}");

			return builder.ToString();
		}
	}

    /// <summary>
    /// -
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
	public partial struct ImageResolve
	{
		/// <summary>
		/// -
		/// </summary>
		public ImageSubresourceLayers SourceSubresource;

		/// <summary>
		/// -
		/// </summary>
		public Offset3D SourceOffset;

		/// <summary>
		/// -
		/// </summary>
		public ImageSubresourceLayers DestinationSubresource;

		/// <summary>
		/// -
		/// </summary>
		public Offset3D DestinationOffset;

		/// <summary>
		/// -
		/// </summary>
		public Extent3D Extent;

		/// <summary>
		/// -
		/// </summary>
		public override string ToString()
		{
			var builder = new StringBuilder();
			
            builder.AppendLine("ImageResolve");
            builder.AppendLine("{");
            builder.AppendLine($"SourceSubresource: {this.SourceSubresource}");
            builder.AppendLine($"SourceOffset: {this.SourceOffset}");
            builder.AppendLine($"DestinationSubresource: {this.DestinationSubresource}");
            builder.AppendLine($"DestinationOffset: {this.DestinationOffset}");
            builder.AppendLine($"Extent: {this.Extent}");
            builder.Append("}");

			return builder.ToString();
		}
	}

    /// <summary>
    /// -
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
	public partial struct ImageSubresource
	{
		/// <summary>
		/// -
		/// </summary>
		public ImageAspectFlags AspectMask;

		/// <summary>
		/// -
		/// </summary>
		public uint MipLevel;

		/// <summary>
		/// -
		/// </summary>
		public uint ArrayLayer;

		/// <summary>
		/// -
		/// </summary>
		public override string ToString()
		{
			var builder = new StringBuilder();
			
            builder.AppendLine("ImageSubresource");
            builder.AppendLine("{");
            builder.AppendLine($"AspectMask: {this.AspectMask}");
            builder.AppendLine($"MipLevel: {this.MipLevel}");
            builder.AppendLine($"ArrayLayer: {this.ArrayLayer}");
            builder.Append("}");

			return builder.ToString();
		}
	}

    /// <summary>
    /// -
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
	public partial struct ImageSubresourceLayers
	{
		/// <summary>
		/// -
		/// </summary>
		public ImageAspectFlags AspectMask;

		/// <summary>
		/// -
		/// </summary>
		public uint MipLevel;

		/// <summary>
		/// -
		/// </summary>
		public uint BaseArrayLayer;

		/// <summary>
		/// -
		/// </summary>
		public uint LayerCount;

		/// <summary>
		/// -
		/// </summary>
		public override string ToString()
		{
			var builder = new StringBuilder();
			
            builder.AppendLine("ImageSubresourceLayers");
            builder.AppendLine("{");
            builder.AppendLine($"AspectMask: {this.AspectMask}");
            builder.AppendLine($"MipLevel: {this.MipLevel}");
            builder.AppendLine($"BaseArrayLayer: {this.BaseArrayLayer}");
            builder.AppendLine($"LayerCount: {this.LayerCount}");
            builder.Append("}");

			return builder.ToString();
		}
	}

    /// <summary>
    /// The number of mip-map levels and array layers must: be a subset of the
    /// image subresources in the image. If an application wants to use all
    /// mip-levels or layers in an image after the pname:baseMipLevel or
    /// pname:baseArrayLayer, it can: set pname:levelCount and pname:layerCount to
    /// the special values ename:VK_REMAINING_MIP_LEVELS and
    /// ename:VK_REMAINING_ARRAY_LAYERS without knowing the exact number of
    /// mip-levels or layers.
    /// For cube and cube array image views, the layers of the image view starting
    /// at pname:baseArrayLayer correspond to faces in the order +X, -X, +Y, -Y, +Z,
    /// -Z. For cube arrays, each set of six sequential layers is a single cube, so
    /// the number of cube maps in a cube map array view is _pname:layerCount / 6_,
    /// and image array layer _pname:baseArrayLayer + i_ is face index _i mod 6_ of
    /// cube _i / 6_. If the number of layers in the view, whether set explicitly in
    /// pname:layerCount or implied by ename:VK_REMAINING_ARRAY_LAYERS, is not a
    /// multiple of 6, behavior when indexing the last cube is undefined.
    /// pname:aspectMask is a bitmask indicating the format being used. Bits which
    /// may: be set include:
    /// // refBegin VkImageAspectFlagBits - Bitmask specifying which aspects of an image are included in a view
    /// include::../api/enums/VkImageAspectFlagBits.txt[]
    /// The mask must: be only ename:VK_IMAGE_ASPECT_COLOR_BIT,
    /// ename:VK_IMAGE_ASPECT_DEPTH_BIT or ename:VK_IMAGE_ASPECT_STENCIL_BIT if
    /// pname:format is a color, depth-only or stencil-only format, respectively. If
    /// using a depth/stencil format with both depth and stencil components,
    /// pname:aspectMask must: include at least one of
    /// ename:VK_IMAGE_ASPECT_DEPTH_BIT and ename:VK_IMAGE_ASPECT_STENCIL_BIT, and
    /// can: include both.
    /// When using an imageView of a depth/stencil image to populate a descriptor
    /// set (e.g. for sampling in the shader, or for use as an input attachment),
    /// the pname:aspectMask must: only include one bit and selects whether the
    /// imageView is used for depth reads (i.e. using a floating-point sampler or
    /// input attachment in the shader) or stencil reads (i.e. using an unsigned
    /// integer sampler or input attachment in the shader). When an imageView of a
    /// depth/stencil image is used as a depth/stencil framebuffer attachment, the
    /// pname:aspectMask is ignored and both depth and stencil image subresources
    /// are used.
    /// The pname:components member is of type slink:VkComponentMapping, and
    /// describes a remapping from components of the image to components of the
    /// vector returned by shader image instructions. This remapping must: be
    /// identity for storage image descriptors, input attachment descriptors, and
    /// framebuffer attachments.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
	public partial struct ImageSubresourceRange
	{
		/// <summary>
		/// -
		/// </summary>
		public ImageAspectFlags AspectMask;

		/// <summary>
		/// -
		/// </summary>
		public uint BaseMipLevel;

		/// <summary>
		/// -
		/// </summary>
		public uint LevelCount;

		/// <summary>
		/// -
		/// </summary>
		public uint BaseArrayLayer;

		/// <summary>
		/// -
		/// </summary>
		public uint LayerCount;

		/// <summary>
		/// -
		/// </summary>
		public override string ToString()
		{
			var builder = new StringBuilder();
			
            builder.AppendLine("ImageSubresourceRange");
            builder.AppendLine("{");
            builder.AppendLine($"AspectMask: {this.AspectMask}");
            builder.AppendLine($"BaseMipLevel: {this.BaseMipLevel}");
            builder.AppendLine($"LevelCount: {this.LevelCount}");
            builder.AppendLine($"BaseArrayLayer: {this.BaseArrayLayer}");
            builder.AppendLine($"LayerCount: {this.LayerCount}");
            builder.Append("}");

			return builder.ToString();
		}
	}

    /// <summary>
    /// -
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
	public partial struct MemoryHeap
	{
		/// <summary>
		/// -
		/// </summary>
		public DeviceSize Size;

		/// <summary>
		/// -
		/// </summary>
		public MemoryHeapFlags Flags;

		/// <summary>
		/// -
		/// </summary>
		public override string ToString()
		{
			var builder = new StringBuilder();
			
            builder.AppendLine("MemoryHeap");
            builder.AppendLine("{");
            builder.AppendLine($"Size: {this.Size}");
            builder.AppendLine($"Flags: {this.Flags}");
            builder.Append("}");

			return builder.ToString();
		}
	}

    /// <summary>
    /// -
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
	public partial struct MemoryRequirements
	{
		/// <summary>
		/// -
		/// </summary>
		public DeviceSize Size;

		/// <summary>
		/// -
		/// </summary>
		public DeviceSize Alignment;

		/// <summary>
		/// -
		/// </summary>
		public uint MemoryTypeBits;

		/// <summary>
		/// -
		/// </summary>
		public override string ToString()
		{
			var builder = new StringBuilder();
			
            builder.AppendLine("MemoryRequirements");
            builder.AppendLine("{");
            builder.AppendLine($"Size: {this.Size}");
            builder.AppendLine($"Alignment: {this.Alignment}");
            builder.AppendLine($"MemoryTypeBits: {this.MemoryTypeBits}");
            builder.Append("}");

			return builder.ToString();
		}
	}

    /// <summary>
    /// -
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
	public partial struct MemoryType
	{
		/// <summary>
		/// -
		/// </summary>
		public MemoryPropertyFlags PropertyFlags;

		/// <summary>
		/// -
		/// </summary>
		public uint HeapIndex;

		/// <summary>
		/// -
		/// </summary>
		public override string ToString()
		{
			var builder = new StringBuilder();
			
            builder.AppendLine("MemoryType");
            builder.AppendLine("{");
            builder.AppendLine($"PropertyFlags: {this.PropertyFlags}");
            builder.AppendLine($"HeapIndex: {this.HeapIndex}");
            builder.Append("}");

			return builder.ToString();
		}
	}

    /// <summary>
    /// -
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
	public partial struct Offset2D
	{
		/// <summary>
		/// -
		/// </summary>
		public int X;

		/// <summary>
		/// -
		/// </summary>
		public int Y;

		/// <summary>
		/// -
		/// </summary>
		public override string ToString()
		{
			var builder = new StringBuilder();
			
            builder.AppendLine("Offset2D");
            builder.AppendLine("{");
            builder.AppendLine($"X: {this.X}");
            builder.AppendLine($"Y: {this.Y}");
            builder.Append("}");

			return builder.ToString();
		}
	}

    /// <summary>
    /// -
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
	public partial struct Offset3D
	{
		/// <summary>
		/// -
		/// </summary>
		public int X;

		/// <summary>
		/// -
		/// </summary>
		public int Y;

		/// <summary>
		/// -
		/// </summary>
		public int Z;

		/// <summary>
		/// -
		/// </summary>
		public override string ToString()
		{
			var builder = new StringBuilder();
			
            builder.AppendLine("Offset3D");
            builder.AppendLine("{");
            builder.AppendLine($"X: {this.X}");
            builder.AppendLine($"Y: {this.Y}");
            builder.AppendLine($"Z: {this.Z}");
            builder.Append("}");

			return builder.ToString();
		}
	}

    /// <summary>
    ///   * [[features-features-robustBufferAccess]] pname:robustBufferAccess
    ///     indicates that accesses to buffers are bounds-checked against the range of
    ///     the buffer descriptor (as determined by
    ///     sname:VkDescriptorBufferInfo::pname:range,
    ///     sname:VkBufferViewCreateInfo::pname:range, or the size of the buffer). Out
    ///     of bounds accesses mustnot: cause application termination, and the effects
    ///     of shader loads, stores, and atomics must: conform to an
    ///     implementation-dependent behavior as described below.
    ///   ** A buffer access is considered to be out of bounds if any of the following
    ///      are true:
    ///   *** The pointer was formed by code:OpImageTexelPointer and the coordinate is
    ///       less than zero or greater than or equal to the number of whole elements
    ///       in the bound range.
    ///   *** The pointer was not formed by code:OpImageTexelPointer and the object
    ///       pointed to is not wholly contained within the bound range.
    /// +
    /// --
    /// [NOTE]
    /// .Note
    /// ====
    /// If a SPIR-V code:OpLoad instruction loads a structure and the tail end of the
    /// structure is out of bounds, then all members of the structure are considered
    /// out of bounds even if the members at the end are not statically used.
    /// ====
    /// --
    /// +
    ///   *** If any buffer access in a given SPIR-V block is determined to be
    ///       out of bounds, then any other access of the same type (load, store, or
    ///       atomic) in the same SPIR-V block that accesses an address less
    ///       than 16 bytes away from the out of bounds address may: also be
    ///       considered out of bounds.
    ///   ** Out-of-bounds buffer loads will return any of the following values:
    ///   *** Values from anywhere within the memory range(s) bound to the buffer
    ///       (possibly including bytes of memory past the end of the buffer, up to
    ///       the end of the bound range).
    ///   *** Zero values, or (0,0,0,x) vectors for vector reads where x is a valid
    ///       value represented in the type of the vector components and may: be any
    ///       of:
    ///   **** 0, 1, or the maximum representable positive integer value, for signed
    ///        or unsigned integer components
    ///   **** 0.0 or 1.0, for floating-point components
    ///   ** Out-of-bounds writes may: modify values within the memory range(s) bound
    ///      to the buffer, but mustnot: modify any other memory.
    ///   ** Out-of-bounds atomics may: modify values within the memory range(s) bound
    ///      to the buffer, but mustnot: modify any other memory, and return an
    ///      undefined value.
    ///   ** Vertex input attributes are considered out of bounds if the address of the
    ///      attribute plus the size of the attribute is greater than the size of the
    ///      bound buffer. Further, if any vertex input attribute using a specific
    ///      vertex input binding is out of bounds, then all vertex input attributes
    ///      using that vertex input binding for that vertex shader invocation are
    ///      considered out of bounds.
    ///   *** If a vertex input attribute is out of bounds, it will be assigned one
    ///       of the following values:
    ///   **** Values from anywhere within the memory range(s) bound to the buffer,
    ///      converted according to the format of the attribute.
    ///   **** Zero values, format converted according to the format of the attribute.
    ///   **** Zero values, or (0,0,0,x) vectors, as described above.
    ///   ** If pname:robustBufferAccess is not enabled, out of bounds accesses may:
    ///      corrupt any memory within the process and cause undefined behaviour up
    ///      to and including application termination.
    ///   * [[features-features-fullDrawIndexUint32]] pname:fullDrawIndexUint32
    ///     indicates the full 32-bit range of indices is supported for indexed draw
    ///     calls when using a elink:VkIndexType of ename:VK_INDEX_TYPE_UINT32.
    ///     pname:maxDrawIndexedIndexValue is the maximum index value that may: be
    ///     used (aside from the primitive restart index, which is always 2^32^-1
    ///     when the elink:VkIndexType is ename:VK_INDEX_TYPE_UINT32). If this
    ///     feature is supported, pname:maxDrawIndexedIndexValue must: be 2^32^-1;
    ///     otherwise it must: be no smaller than 2^24^-1. See
    ///     &lt;&lt;features-limits-maxDrawIndexedIndexValue,maxDrawIndexedIndexValue&gt;&gt;.
    ///   * [[features-features-imageCubeArray]] pname:imageCubeArray indicates
    ///     whether image views with a elink:VkImageViewType of
    ///     ename:VK_IMAGE_VIEW_TYPE_CUBE_ARRAY can: be created, and that the
    ///     corresponding code:SampledCubeArray and code:ImageCubeArray SPIR-V
    ///     capabilities can: be used in shader code.
    ///   * [[features-features-independentBlend]] pname:independentBlend indicates
    ///     whether the sname:VkPipelineColorBlendAttachmentState settings are
    ///     controlled independently per-attachment. If this feature is not enabled,
    ///     the sname:VkPipelineColorBlendAttachmentState settings for all color
    ///     attachments must: be identical. Otherwise, a different
    ///     sname:VkPipelineColorBlendAttachmentState can: be provided for each
    ///     bound color attachment.
    ///   * [[features-features-geometryShader]] pname:geometryShader indicates
    ///     whether geometry shaders are supported. If this feature is not enabled,
    ///     the ename:VK_SHADER_STAGE_GEOMETRY_BIT and
    ///     ename:VK_PIPELINE_STAGE_GEOMETRY_SHADER_BIT enum values mustnot: be
    ///     used. This also indicates whether shader modules can: declare the
    ///     code:Geometry capability.
    ///   * [[features-features-tessellationShader]] pname:tessellationShader
    ///     indicates whether tessellation control and evaluation shaders are
    ///     supported. If this feature is not enabled, the
    ///     ename:VK_SHADER_STAGE_TESSELLATION_CONTROL_BIT,
    ///     ename:VK_SHADER_STAGE_TESSELLATION_EVALUATION_BIT,
    ///     ename:VK_PIPELINE_STAGE_TESSELLATION_CONTROL_SHADER_BIT,
    ///     ename:VK_PIPELINE_STAGE_TESSELLATION_EVALUATION_SHADER_BIT, and
    ///     ename:VK_STRUCTURE_TYPE_PIPELINE_TESSELLATION_STATE_CREATE_INFO enum
    ///     values mustnot: be used. This also indicates whether shader modules can:
    ///     declare the code:Tessellation capability.
    ///   * [[features-features-sampleRateShading]] pname:sampleRateShading
    ///     indicates whether per-sample shading and multisample interpolation are
    ///     supported. If this feature is not enabled, the pname:sampleShadingEnable
    ///     member of the sname:VkPipelineMultisampleStateCreateInfo structure must:
    ///     be set to ename:VK_FALSE and the pname:minSampleShading member is
    ///     ignored. This also indicates whether shader modules can: declare the
    ///     code:SampleRateShading capability.
    ///   * [[features-features-dualSrcBlend]] pname:dualSrcBlend indicates whether
    ///     blend operations which take two sources are supported. If this feature
    ///     is not enabled, the ename:VK_BLEND_FACTOR_SRC1_COLOR,
    ///     ename:VK_BLEND_FACTOR_ONE_MINUS_SRC1_COLOR,
    ///     ename:VK_BLEND_FACTOR_SRC1_ALPHA, and
    ///     ename:VK_BLEND_FACTOR_ONE_MINUS_SRC1_ALPHA enum values mustnot: be used
    ///     as source or destination blending factors. See &lt;&lt;framebuffer-dsb&gt;&gt;.
    ///   * [[features-features-logicOp]] pname:logicOp indicates whether logic
    ///     operations are supported. If this feature is not enabled, the
    ///     pname:logicOpEnable member of the
    ///     sname:VkPipelineColorBlendStateCreateInfo structure must: be set to
    ///     ename:VK_FALSE, and the pname:logicOp member is ignored.
    ///   * [[features-features-multiDrawIndirect]] pname:multiDrawIndirect
    ///     indicates whether multiple draw indirect is supported. If this feature
    ///     is not enabled, the pname:drawCount parameter to the
    ///     fname:vkCmdDrawIndirect and fname:vkCmdDrawIndexedIndirect commands
    ///     must: be 0 or 1. The pname:maxDrawIndirectCount member of the
    ///     sname:VkPhysicalDeviceLimits structure must: also be 1 if this feature
    ///     is not supported. See
    ///     &lt;&lt;features-limits-maxDrawIndirectCount,maxDrawIndirectCount&gt;&gt;.
    ///   * [[features-features-drawIndirectFirstInstance]]
    ///     pname:drawIndirectFirstInstance indicates whether indirect draw calls
    ///     support the pname:firstInstance parameter. If this feature is not
    ///     enabled, the pname:firstInstance member of all
    ///     sname:VkDrawIndirectCommand and sname:VkDrawIndexedIndirectCommand
    ///     structures that are provided to the fname:vkCmdDrawIndirect and
    ///     fname:vkCmdDrawIndexedIndirect commands must: be 0.
    ///   * [[features-features-depthClamp]] pname:depthClamp indicates whether
    ///     depth clamping is supported. If this feature is not enabled, the
    ///     pname:depthClampEnable member of the
    ///     sname:VkPipelineRasterizationStateCreateInfo structure must: be set to
    ///     ename:VK_FALSE. Otherwise, setting pname:depthClampEnable to
    ///     ename:VK_TRUE will enable depth clamping.
    ///   * [[features-features-depthBiasClamp]] pname:depthBiasClamp indicates
    ///     whether depth bias clamping is supported. If this feature is not
    ///     enabled, the pname:depthBiasClamp member of the
    ///     sname:VkPipelineRasterizationStateCreateInfo structure must: be set
    ///     to 0.0 unless the VK_DYNAMIC_STATE_DEPTH_BIAS dynamic state is enabled,
    ///     and the pname:depthBiasClamp parameter to fname:vkCmdSetDepthBias must:
    ///     be set to 0.0.
    ///   * [[features-features-fillModeNonSolid]] pname:fillModeNonSolid indicates
    ///     whether point and wireframe fill modes are supported. If this feature is
    ///     not enabled, the ename:VK_POLYGON_MODE_POINT and
    ///     ename:VK_POLYGON_MODE_LINE enum values mustnot: be used.
    ///   * [[features-features-depthBounds]] pname:depthBounds indicates whether
    ///     depth bounds tests are supported. If this feature is not enabled, the
    ///     pname:depthBoundsTestEnable member of the
    ///     sname:VkPipelineDepthStencilStateCreateInfo structure must: be set to
    ///     ename:VK_FALSE. When pname:depthBoundsTestEnable is set to
    ///     ename:VK_FALSE, the pname:minDepthBounds and
    ///     pname:maxDepthBounds members of the
    ///     sname:VkPipelineDepthStencilStateCreateInfo structure are ignored.
    ///   * [[features-features-wideLines]] pname:wideLines indicates whether lines
    ///     with width other than 1.0 are supported. If this feature is not enabled,
    ///     the pname:lineWidth member of the
    ///     sname:VkPipelineRasterizationStateCreateInfo structure must: be set
    ///     to 1.0 unless the VK_DYNAMIC_STATE_LINE_WIDTH dynamic state is enabled,
    ///     and the pname:lineWidth parameter to fname:vkCmdSetLineWidth must: be set
    ///     to 1.0. When this feature is supported, the range and granularity of
    ///     supported line widths are indicated by the pname:lineWidthRange and
    ///     pname:lineWidthGranularity members of the sname:VkPhysicalDeviceLimits
    ///     structure, respectively.
    ///   * [[features-features-largePoints]] pname:largePoints indicates whether
    ///     points with size greater than 1.0 are supported. If this feature is not
    ///     enabled, only a point size of 1.0 written by a shader is supported. The
    ///     range and granularity of supported point sizes are indicated by the
    ///     pname:pointSizeRange and pname:pointSizeGranularity members of the
    ///     sname:VkPhysicalDeviceLimits structure, respectively.
    ///   * [[features-features-alphaToOne]] pname:alphaToOne indicates whether the
    ///     implementation is able to replace the alpha value of the color fragment
    ///     output from the fragment shader with the maximum representable alpha
    ///     value for fixed-point colors or 1.0 for floating-point colors. If this
    ///     feature is not enabled, then the pname:alphaToOneEnable member of the
    ///     sname:VkPipelineMultisampleStateCreateInfo structure must: be set to
    ///     ename:VK_FALSE. Otherwise setting pname:alphaToOneEnable to
    ///     ename:VK_TRUE will enable alpha-to-one behaviour.
    ///   * [[features-features-multiViewport]] pname:multiViewport indicates
    ///     whether more than one viewport is supported. If this feature is not
    ///     enabled, the pname:viewportCount and pname:scissorCount members of the
    ///     sname:VkPipelineViewportStateCreateInfo structure must: be set to 1.
    ///     Similarly, the pname:viewportCount parameter to the
    ///     fname:vkCmdSetViewport command and the pname:scissorCount parameter to
    ///     the fname:vkCmdSetScissor command must: be 1, and the
    ///     pname:firstViewport parameter to the fname:vkCmdSetViewport command and
    ///     the pname:firstScissor parameter to the fname:vkCmdSetScissor command
    ///     must: be 0.
    ///   * [[features-features-samplerAnisotropy]] pname:samplerAnisotropy
    ///     indicates whether anisotropic filtering is supported. If this feature is
    ///     not enabled, the pname:maxAnisotropy member of the
    ///     sname:VkSamplerCreateInfo structure must: be 1.0.
    ///   * [[features-features-textureCompressionETC2]]
    ///     pname:textureCompressionETC2 indicates whether the ETC2 and EAC
    ///     compressed texture formats are supported. If this feature is not
    ///     enabled, the following formats mustnot: be used to create images:
    /// +
    /// --
    /// * ename:VK_FORMAT_ETC2_R8G8B8_UNORM_BLOCK
    /// * ename:VK_FORMAT_ETC2_R8G8B8_SRGB_BLOCK
    /// * ename:VK_FORMAT_ETC2_R8G8B8A1_UNORM_BLOCK
    /// * ename:VK_FORMAT_ETC2_R8G8B8A1_SRGB_BLOCK
    /// * ename:VK_FORMAT_ETC2_R8G8B8A8_UNORM_BLOCK
    /// * ename:VK_FORMAT_ETC2_R8G8B8A8_SRGB_BLOCK
    /// * ename:VK_FORMAT_EAC_R11_UNORM_BLOCK
    /// * ename:VK_FORMAT_EAC_R11_SNORM_BLOCK
    /// * ename:VK_FORMAT_EAC_R11G11_UNORM_BLOCK
    /// * ename:VK_FORMAT_EAC_R11G11_SNORM_BLOCK
    /// --
    /// +
    /// flink:vkGetPhysicalDeviceFormatProperties is used to
    /// check for the supported properties of individual formats.
    /// +
    ///   * [[features-features-textureCompressionASTC_LDR]]
    ///     pname:textureCompressionASTC_LDR indicates whether the ASTC LDR
    ///     compressed texture formats are supported. If this feature is not
    ///     enabled, the following formats mustnot: be used to create images:
    /// +
    /// --
    /// * ename:VK_FORMAT_ASTC_4x4_UNORM_BLOCK
    /// * ename:VK_FORMAT_ASTC_4x4_SRGB_BLOCK
    /// * ename:VK_FORMAT_ASTC_5x4_UNORM_BLOCK
    /// * ename:VK_FORMAT_ASTC_5x4_SRGB_BLOCK
    /// * ename:VK_FORMAT_ASTC_5x5_UNORM_BLOCK
    /// * ename:VK_FORMAT_ASTC_5x5_SRGB_BLOCK
    /// * ename:VK_FORMAT_ASTC_6x5_UNORM_BLOCK
    /// * ename:VK_FORMAT_ASTC_6x5_SRGB_BLOCK
    /// * ename:VK_FORMAT_ASTC_6x6_UNORM_BLOCK
    /// * ename:VK_FORMAT_ASTC_6x6_SRGB_BLOCK
    /// * ename:VK_FORMAT_ASTC_8x5_UNORM_BLOCK
    /// * ename:VK_FORMAT_ASTC_8x5_SRGB_BLOCK
    /// * ename:VK_FORMAT_ASTC_8x6_UNORM_BLOCK
    /// * ename:VK_FORMAT_ASTC_8x6_SRGB_BLOCK
    /// * ename:VK_FORMAT_ASTC_8x8_UNORM_BLOCK
    /// * ename:VK_FORMAT_ASTC_8x8_SRGB_BLOCK
    /// * ename:VK_FORMAT_ASTC_10x5_UNORM_BLOCK
    /// * ename:VK_FORMAT_ASTC_10x5_SRGB_BLOCK
    /// * ename:VK_FORMAT_ASTC_10x6_UNORM_BLOCK
    /// * ename:VK_FORMAT_ASTC_10x6_SRGB_BLOCK
    /// * ename:VK_FORMAT_ASTC_10x8_UNORM_BLOCK
    /// * ename:VK_FORMAT_ASTC_10x8_SRGB_BLOCK
    /// * ename:VK_FORMAT_ASTC_10x10_UNORM_BLOCK
    /// * ename:VK_FORMAT_ASTC_10x10_SRGB_BLOCK
    /// * ename:VK_FORMAT_ASTC_12x10_UNORM_BLOCK
    /// * ename:VK_FORMAT_ASTC_12x10_SRGB_BLOCK
    /// * ename:VK_FORMAT_ASTC_12x12_UNORM_BLOCK
    /// * ename:VK_FORMAT_ASTC_12x12_SRGB_BLOCK
    /// --
    /// +
    /// flink:vkGetPhysicalDeviceFormatProperties is used to
    /// check for the supported properties of individual formats.
    /// +
    ///   * [[features-features-textureCompressionBC]] pname:textureCompressionBC
    ///     indicates whether the BC compressed texture formats are supported. If
    ///     this feature is not enabled, the following formats mustnot: be used to
    ///     create images:
    /// +
    /// --
    /// * ename:VK_FORMAT_BC1_RGB_UNORM_BLOCK
    /// * ename:VK_FORMAT_BC1_RGB_SRGB_BLOCK
    /// * ename:VK_FORMAT_BC1_RGBA_UNORM_BLOCK
    /// * ename:VK_FORMAT_BC1_RGBA_SRGB_BLOCK
    /// * ename:VK_FORMAT_BC2_UNORM_BLOCK
    /// * ename:VK_FORMAT_BC2_SRGB_BLOCK
    /// * ename:VK_FORMAT_BC3_UNORM_BLOCK
    /// * ename:VK_FORMAT_BC3_SRGB_BLOCK
    /// * ename:VK_FORMAT_BC4_UNORM_BLOCK
    /// * ename:VK_FORMAT_BC4_SNORM_BLOCK
    /// * ename:VK_FORMAT_BC5_UNORM_BLOCK
    /// * ename:VK_FORMAT_BC5_SNORM_BLOCK
    /// * ename:VK_FORMAT_BC6H_UFLOAT_BLOCK
    /// * ename:VK_FORMAT_BC6H_SFLOAT_BLOCK
    /// * ename:VK_FORMAT_BC7_UNORM_BLOCK
    /// * ename:VK_FORMAT_BC7_SRGB_BLOCK
    /// --
    /// +
    /// flink:vkGetPhysicalDeviceFormatProperties is used to
    /// check for the supported properties of individual formats.
    /// +
    ///   * [[features-features-occlusionQueryPrecise]] pname:occlusionQueryPrecise
    ///     indicates whether occlusion queries returning actual sample counts are
    ///     supported. Occlusion queries are created in a sname:VkQueryPool by
    ///     specifying the pname:queryType of ename:VK_QUERY_TYPE_OCCLUSION in the
    ///     sname:VkQueryPoolCreateInfo structure which is passed to
    ///     fname:vkCreateQueryPool. If this feature is enabled, queries of this
    ///     type can: enable ename:VK_QUERY_CONTROL_PRECISE_BIT in the pname:flags
    ///     parameter to fname:vkCmdBeginQuery. If this feature is not supported,
    ///     the implementation supports only boolean occlusion queries. When any
    ///     samples are passed, boolean queries will return a non-zero result value,
    ///     otherwise a result value of zero is returned. When this feature is
    ///     enabled and ename:VK_QUERY_CONTROL_PRECISE_BIT is set, occlusion queries
    ///     will report the actual number of samples passed.
    ///   * [[features-features-pipelineStatisticsQuery]]
    ///     pname:pipelineStatisticsQuery indicates whether the pipeline statistics
    ///     queries are supported. If this feature is not enabled, queries of type
    ///     ename:VK_QUERY_TYPE_PIPELINE_STATISTICS cannot: be created, and none of
    ///     the elink:VkQueryPipelineStatisticFlagBits bits can: be set in the
    ///     pname:pipelineStatistics member of the sname:VkQueryPoolCreateInfo
    ///     structure.
    ///   * [[features-features-vertexPipelineStoresAndAtomics]]
    ///     pname:vertexPipelineStoresAndAtomics indicates whether storage buffers
    ///     and images support stores and atomic operations in the vertex,
    ///     tessellation, and geometry shader stages. If this feature is not
    ///     enabled, all storage image, storage texel buffers, and storage buffer
    ///     variables used by these stages in shader modules must: be decorated with
    ///     the code:NonWriteable decoration (or the code:readonly memory qualifier
    ///     in GLSL).
    ///   * [[features-features-fragmentStoresAndAtomics]]
    ///     pname:fragmentStoresAndAtomics indicates whether storage buffers and
    ///     images support stores and atomic operations in the fragment shader
    ///     stage. If this feature is not enabled, all storage image, storage texel
    ///     buffers, and storage buffer variables used by the fragment stage in
    ///     shader modules must: be decorated with the code:NonWriteable decoration
    ///     (or the code:readonly memory qualifier in GLSL).
    ///   * [[features-features-shaderTessellationAndGeometryPointSize]]
    ///     pname:shaderTessellationAndGeometryPointSize indicates whether the
    ///     code:PointSize built-in decoration is available in the tessellation
    ///     control, tessellation evaluation, and geometry shader stages. If this
    ///     feature is not enabled, members decorated with the code:PointSize
    ///     built-in decoration mustnot: be read from or written to
    ///     and all points written from a
    ///     tessellation or geometry shader will have a size of 1.0. This also
    ///     indicates whether shader modules can: declare the
    ///     code:TessellationPointSize capability for tessellation control and
    ///     evaluation shaders, or if the shader modules can: declare the
    ///     code:GeometryPointSize capability for geometry shaders. An
    ///     implementation supporting this feature must: also support one or both of
    ///     the &lt;&lt;features-features-tessellationShader,pname:tessellationShader&gt;&gt; or
    ///     &lt;&lt;features-features-geometryShader,pname:geometryShader&gt;&gt; features.
    ///   * [[features-features-shaderImageGatherExtended]]
    ///     pname:shaderImageGatherExtended indicates whether the extended set of
    ///     image gather instructions are available in shader code. If this feature
    ///     is not enabled, the code:OpImage*code:Gather instructions do not support
    ///     the code:Offset and code:ConstOffsets operands. This also indicates
    ///     whether shader modules can: declare the code:ImageGatherExtended
    ///     capability.
    ///   * [[features-features-shaderStorageImageExtendedFormats]]
    ///     pname:shaderStorageImageExtendedFormats indicates whether the extended
    ///     storage image formats are available in shader code. If this feature is
    ///     not enabled, the formats requiring the code:StorageImageExtendedFormats
    ///     capability are not supported for storage images. This also indicates
    ///     whether shader modules can: declare the code:StorageImageExtendedFormats
    ///     capability.
    ///   * [[features-features-shaderStorageImageMultisample]]
    ///     pname:shaderStorageImageMultisample indicates whether multisampled
    ///     storage images are supported. If this feature is not enabled, images
    ///     that are created with a pname:usage that includes
    ///     ename:VK_IMAGE_USAGE_STORAGE_BIT must: be created with pname:samples
    ///     equal to ename:VK_SAMPLE_COUNT_1_BIT. This also indicates whether shader
    ///     modules can: declare the code:StorageImageMultisample capability.
    ///   * [[features-features-shaderStorageImageReadWithoutFormat]]
    ///     pname:shaderStorageImageReadWithoutFormat indicates whether storage
    ///     images require a format qualifier to be specified when reading from
    ///     storage images. If this feature is not enabled, the code:OpImageRead
    ///     instruction mustnot: have an code:OpTypeImage of code:Unknown. This also
    ///     indicates whether shader modules can: declare the
    ///     code:StorageImageReadWithoutFormat capability.
    ///   * [[features-features-shaderStorageImageWriteWithoutFormat]]
    ///     pname:shaderStorageImageWriteWithoutFormat indicates whether storage
    ///     images require a format qualifier to be specified when writing to
    ///     storage images. If this feature is not enabled, the code:OpImageWrite
    ///     instruction mustnot: have an code:OpTypeImage of code:Unknown. This also
    ///     indicates whether shader modules can: declare the
    ///     code:StorageImageWriteWithoutFormat capability.
    ///   * [[features-features-shaderUniformBufferArrayDynamicIndexing]]
    ///     pname:shaderUniformBufferArrayDynamicIndexing indicates whether arrays
    ///     of uniform buffers can: be indexed by dynamically uniform integer
    ///     expressions in shader code. If this feature is not enabled, resources
    ///     with a descriptor type of ename:VK_DESCRIPTOR_TYPE_UNIFORM_BUFFER or
    ///     ename:VK_DESCRIPTOR_TYPE_UNIFORM_BUFFER_DYNAMIC must: be indexed only by
    ///     constant integral expressions when aggregated into arrays in shader
    ///     code. This also indicates whether shader modules can: declare the
    ///     code:UniformBufferArrayDynamicIndexing capability.
    ///   * [[features-features-shaderSampledImageArrayDynamicIndexing]]
    ///     pname:shaderSampledImageArrayDynamicIndexing indicates whether arrays of
    ///     samplers or sampled images can: be indexed by dynamically uniform
    ///     integer expressions in shader code. If this feature is not enabled,
    ///     resources with a descriptor type of ename:VK_DESCRIPTOR_TYPE_SAMPLER,
    ///     ename:VK_DESCRIPTOR_TYPE_COMBINED_IMAGE_SAMPLER, or
    ///     ename:VK_DESCRIPTOR_TYPE_SAMPLED_IMAGE must: be indexed only by constant
    ///     integral expressions when aggregated into arrays in shader code. This
    ///     also indicates whether shader modules can: declare the
    ///     code:SampledImageArrayDynamicIndexing capability.
    ///   * [[features-features-shaderStorageBufferArrayDynamicIndexing]]
    ///     pname:shaderStorageBufferArrayDynamicIndexing indicates whether arrays
    ///     of storage buffers can: be indexed by dynamically uniform integer
    ///     expressions in shader code. If this feature is not enabled, resources
    ///     with a descriptor type of ename:VK_DESCRIPTOR_TYPE_STORAGE_BUFFER or
    ///     ename:VK_DESCRIPTOR_TYPE_STORAGE_BUFFER_DYNAMIC must: be indexed only by
    ///     constant integral expressions when aggregated into arrays in shader
    ///     code. This also indicates whether shader modules can: declare the
    ///     code:StorageBufferArrayDynamicIndexing capability.
    ///   * [[features-features-shaderStorageImageArrayDynamicIndexing]]
    ///     pname:shaderStorageImageArrayDynamicIndexing indicates whether arrays of
    ///     storage images can: be indexed by dynamically uniform integer
    ///     expressions in shader code. If this feature is not enabled, resources
    ///     with a descriptor type of ename:VK_DESCRIPTOR_TYPE_STORAGE_IMAGE must:
    ///     be indexed only by constant integral expressions when aggregated into
    ///     arrays in shader code. This also indicates whether shader modules can:
    ///     declare the code:StorageImageArrayDynamicIndexing capability.
    ///   * [[features-features-shaderClipDistance]] pname:shaderClipDistance
    ///     indicates whether clip distances are supported in shader code. If this
    ///     feature is not enabled, any members decorated with the code:ClipDistance
    ///     built-in decoration mustnot: be read from or written to in shader modules.
    ///     This also indicates whether shader
    ///     modules can: declare the code:ClipDistance capability.
    ///   * [[features-features-shaderCullDistance]] pname:shaderCullDistance
    ///     indicates whether cull distances are supported in shader code. If this
    ///     feature is not enabled, any members decorated with the code:CullDistance
    ///     built-in decoration mustnot: be read from or written to in shader modules.
    ///     This also indicates whether shader
    ///     modules can: declare the code:CullDistance capability.
    ///   * [[features-features-shaderFloat64]] pname:shaderFloat64 indicates
    ///     whether 64-bit floats (doubles) are supported in shader code. If this
    ///     feature is not enabled, 64-bit floating-point types mustnot: be used in
    ///     shader code. This also indicates whether shader modules can: declare the
    ///     code:Float64 capability.
    ///   * [[features-features-shaderInt64]] pname:shaderInt64 indicates whether
    ///     64-bit integers (signed and unsigned) are supported in shader code. If
    ///     this feature is not enabled, 64-bit integer types mustnot: be used in
    ///     shader code. This also indicates whether shader modules can: declare the
    ///     code:Int64 capability.
    ///   * [[features-features-shaderInt16]] pname:shaderInt16 indicates whether
    ///     16-bit integers (signed and unsigned) are supported in shader code. If
    ///     this feature is not enabled, 16-bit integer types mustnot: be used in
    ///     shader code. This also indicates whether shader modules can: declare the
    ///     code:Int16 capability.
    ///   * [[features-features-shaderResourceResidency]]
    ///     pname:shaderResourceResidency indicates whether image operations that
    ///     return resource residency information are supported in shader code. If
    ///     this feature is not enabled, the code:OpImageSparse* instructions
    ///     mustnot: be used in shader code. This also indicates whether shader
    ///     modules can: declare the code:SparseResidency capability. The feature
    ///     requires at least one of the ptext:sparseResidency* features to be
    ///     supported.
    ///   * [[features-features-shaderResourceMinLod]] pname:shaderResourceMinLod
    ///     indicates whether image operations that specify the minimum resource
    ///     level-of-detail (LOD) are supported in shader code. If this feature is
    ///     not enabled, the code:MinLod image operand mustnot: be used in shader
    ///     code. This also indicates whether shader modules can: declare the
    ///     code:MinLod capability.
    ///   * [[features-features-sparseBinding]] pname:sparseBinding indicates
    ///     whether resource memory can: be managed at opaque sparse block level
    ///     instead of at the object level. If this feature is not enabled, resource
    ///     memory must: be bound only on a per-object basis using the
    ///     fname:vkBindBufferMemory and fname:vkBindImageMemory commands. In this
    ///     case, buffers and images mustnot: be created with
    ///     ename:VK_BUFFER_CREATE_SPARSE_BINDING_BIT and
    ///     ename:VK_IMAGE_CREATE_SPARSE_BINDING_BIT set in the pname:flags member
    ///     of the sname:VkBufferCreateInfo and sname:VkImageCreateInfo structures,
    ///     respectively. Otherwise resource memory can: be managed as described in
    ///     &lt;&lt;sparsememory-sparseresourcefeatures,Sparse Resource Features&gt;&gt;.
    ///   * [[features-features-sparseResidencyBuffer]] pname:sparseResidencyBuffer
    ///     indicates whether the device can: access partially resident buffers. If
    ///     this feature is not enabled, buffers mustnot: be created with
    ///     ename:VK_BUFFER_CREATE_SPARSE_RESIDENCY_BIT set in the pname:flags
    ///     member of the sname:VkBufferCreateInfo structure.
    ///   * [[features-features-sparseResidencyImage2D]]
    ///     pname:sparseResidencyImage2D indicates whether the device can: access
    ///     partially resident 2D images with 1 sample per pixel. If this feature is
    ///     not enabled, images with an pname:imageType of ename:VK_IMAGE_TYPE_2D
    ///     and pname:samples set to ename:VK_SAMPLE_COUNT_1_BIT mustnot: be created
    ///     with ename:VK_IMAGE_CREATE_SPARSE_RESIDENCY_BIT set in the pname:flags
    ///     member of the sname:VkImageCreateInfo structure.
    ///   * [[features-features-sparseResidencyImage3D]]
    ///     pname:sparseResidencyImage3D indicates whether the device can: access
    ///     partially resident 3D images. If this feature is not enabled, images
    ///     with an pname:imageType of ename:VK_IMAGE_TYPE_3D mustnot: be created
    ///     with ename:VK_IMAGE_CREATE_SPARSE_RESIDENCY_BIT set in the pname:flags
    ///     member of the sname:VkImageCreateInfo structure.
    ///   * [[features-features-sparseResidency2Samples]]
    ///     pname:sparseResidency2Samples indicates whether the physical device can:
    ///     access partially resident 2D images with 2 samples per pixel. If this
    ///     feature is not enabled, images with an pname:imageType of
    ///     ename:VK_IMAGE_TYPE_2D and pname:samples set to
    ///     ename:VK_SAMPLE_COUNT_2_BIT mustnot: be created with
    ///     ename:VK_IMAGE_CREATE_SPARSE_RESIDENCY_BIT set in the pname:flags member
    ///     of the sname:VkImageCreateInfo structure.
    ///   * [[features-features-sparseResidency4Samples]]
    ///     pname:sparseResidency4Samples indicates whether the physical device can:
    ///     access partially resident 2D images with 4 samples per pixel. If this
    ///     feature is not enabled, images with an pname:imageType of
    ///     ename:VK_IMAGE_TYPE_2D and pname:samples set to
    ///     ename:VK_SAMPLE_COUNT_4_BIT mustnot: be created with
    ///     ename:VK_IMAGE_CREATE_SPARSE_RESIDENCY_BIT set in the pname:flags member
    ///     of the sname:VkImageCreateInfo structure.
    ///   * [[features-features-sparseResidency8Samples]]
    ///     pname:sparseResidency8Samples indicates whether the physical device can:
    ///     access partially resident 2D images with 8 samples per pixel. If this
    ///     feature is not enabled, images with an pname:imageType of
    ///     ename:VK_IMAGE_TYPE_2D and pname:samples set to
    ///     ename:VK_SAMPLE_COUNT_8_BIT mustnot: be created with
    ///     ename:VK_IMAGE_CREATE_SPARSE_RESIDENCY_BIT set in the pname:flags member
    ///     of the sname:VkImageCreateInfo structure.
    ///   * [[features-features-sparseResidency16Samples]]
    ///     pname:sparseResidency16Samples indicates whether the physical device
    ///     can: access partially resident 2D images with 16 samples per pixel. If
    ///     this feature is not enabled, images with an pname:imageType of
    ///     ename:VK_IMAGE_TYPE_2D and pname:samples set to
    ///     ename:VK_SAMPLE_COUNT_16_BIT mustnot: be created with
    ///     ename:VK_IMAGE_CREATE_SPARSE_RESIDENCY_BIT set in the pname:flags member
    ///     of the sname:VkImageCreateInfo structure.
    ///   * [[features-features-sparseResidencyAliased]]
    ///     pname:sparseResidencyAliased indicates whether the physical device can:
    ///     correctly access data aliased into multiple locations. If this feature
    ///     is not enabled, the ename:VK_BUFFER_CREATE_SPARSE_ALIASED_BIT and
    ///     ename:VK_IMAGE_CREATE_SPARSE_ALIASED_BIT enum values mustnot: be used in
    ///     pname:flags members of the sname:VkBufferCreateInfo and
    ///     sname:VkImageCreateInfo structures, respectively.
    ///   * [[features-features-variableMultisampleRate]]
    ///     pname:variableMultisampleRate indicates whether all pipelines that will
    ///     be bound to a command buffer during a subpass with no attachments must:
    ///     have the same value for
    ///     sname:VkPipelineMultisampleStateCreateInfo::pname:rasterizationSamples.
    ///     If set to ename:VK_TRUE, the implementation supports variable
    ///     multisample rates in a subpass with no attachments. If set to
    ///     ename:VK_FALSE, then all pipelines bound in such a subpass must: have
    ///     the same multisample rate. This has no effect in situations where a
    ///     subpass uses any attachments.
    ///   * [[features-features-inheritedQueries]] pname:inheritedQueries indicates
    ///     whether a secondary command buffer may: be executed while a query is
    ///     active.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
	public partial struct PhysicalDeviceFeatures
	{
		/// <summary>
		/// -
		/// </summary>
		public Bool32 RobustBufferAccess;

		/// <summary>
		/// -
		/// </summary>
		public Bool32 FullDrawIndexUint32;

		/// <summary>
		/// -
		/// </summary>
		public Bool32 ImageCubeArray;

		/// <summary>
		/// -
		/// </summary>
		public Bool32 IndependentBlend;

		/// <summary>
		/// -
		/// </summary>
		public Bool32 GeometryShader;

		/// <summary>
		/// -
		/// </summary>
		public Bool32 TessellationShader;

		/// <summary>
		/// -
		/// </summary>
		public Bool32 SampleRateShading;

		/// <summary>
		/// -
		/// </summary>
		public Bool32 DualSourceBlend;

		/// <summary>
		/// -
		/// </summary>
		public Bool32 LogicOp;

		/// <summary>
		/// -
		/// </summary>
		public Bool32 MultiDrawIndirect;

		/// <summary>
		/// -
		/// </summary>
		public Bool32 DrawIndirectFirstInstance;

		/// <summary>
		/// -
		/// </summary>
		public Bool32 DepthClamp;

		/// <summary>
		/// -
		/// </summary>
		public Bool32 DepthBiasClamp;

		/// <summary>
		/// -
		/// </summary>
		public Bool32 FillModeNonSolid;

		/// <summary>
		/// -
		/// </summary>
		public Bool32 DepthBounds;

		/// <summary>
		/// -
		/// </summary>
		public Bool32 WideLines;

		/// <summary>
		/// -
		/// </summary>
		public Bool32 LargePoints;

		/// <summary>
		/// -
		/// </summary>
		public Bool32 AlphaToOne;

		/// <summary>
		/// -
		/// </summary>
		public Bool32 MultiViewport;

		/// <summary>
		/// -
		/// </summary>
		public Bool32 SamplerAnisotropy;

		/// <summary>
		/// -
		/// </summary>
		public Bool32 TextureCompressionETC2;

		/// <summary>
		/// -
		/// </summary>
		public Bool32 TextureCompressionASTC_LDR;

		/// <summary>
		/// -
		/// </summary>
		public Bool32 TextureCompressionBC;

		/// <summary>
		/// -
		/// </summary>
		public Bool32 OcclusionQueryPrecise;

		/// <summary>
		/// -
		/// </summary>
		public Bool32 PipelineStatisticsQuery;

		/// <summary>
		/// -
		/// </summary>
		public Bool32 VertexPipelineStoresAndAtomics;

		/// <summary>
		/// -
		/// </summary>
		public Bool32 FragmentStoresAndAtomics;

		/// <summary>
		/// -
		/// </summary>
		public Bool32 ShaderTessellationAndGeometryPointSize;

		/// <summary>
		/// -
		/// </summary>
		public Bool32 ShaderImageGatherExtended;

		/// <summary>
		/// -
		/// </summary>
		public Bool32 ShaderStorageImageExtendedFormats;

		/// <summary>
		/// -
		/// </summary>
		public Bool32 ShaderStorageImageMultisample;

		/// <summary>
		/// -
		/// </summary>
		public Bool32 ShaderStorageImageReadWithoutFormat;

		/// <summary>
		/// -
		/// </summary>
		public Bool32 ShaderStorageImageWriteWithoutFormat;

		/// <summary>
		/// -
		/// </summary>
		public Bool32 ShaderUniformBufferArrayDynamicIndexing;

		/// <summary>
		/// -
		/// </summary>
		public Bool32 ShaderSampledImageArrayDynamicIndexing;

		/// <summary>
		/// -
		/// </summary>
		public Bool32 ShaderStorageBufferArrayDynamicIndexing;

		/// <summary>
		/// -
		/// </summary>
		public Bool32 ShaderStorageImageArrayDynamicIndexing;

		/// <summary>
		/// -
		/// </summary>
		public Bool32 ShaderClipDistance;

		/// <summary>
		/// -
		/// </summary>
		public Bool32 ShaderCullDistance;

		/// <summary>
		/// -
		/// </summary>
		public Bool32 ShaderFloat64;

		/// <summary>
		/// -
		/// </summary>
		public Bool32 ShaderInt64;

		/// <summary>
		/// -
		/// </summary>
		public Bool32 ShaderInt16;

		/// <summary>
		/// -
		/// </summary>
		public Bool32 ShaderResourceResidency;

		/// <summary>
		/// -
		/// </summary>
		public Bool32 ShaderResourceMinLod;

		/// <summary>
		/// -
		/// </summary>
		public Bool32 SparseBinding;

		/// <summary>
		/// -
		/// </summary>
		public Bool32 SparseResidencyBuffer;

		/// <summary>
		/// -
		/// </summary>
		public Bool32 SparseResidencyImage2D;

		/// <summary>
		/// -
		/// </summary>
		public Bool32 SparseResidencyImage3D;

		/// <summary>
		/// -
		/// </summary>
		public Bool32 SparseResidency2Samples;

		/// <summary>
		/// -
		/// </summary>
		public Bool32 SparseResidency4Samples;

		/// <summary>
		/// -
		/// </summary>
		public Bool32 SparseResidency8Samples;

		/// <summary>
		/// -
		/// </summary>
		public Bool32 SparseResidency16Samples;

		/// <summary>
		/// -
		/// </summary>
		public Bool32 SparseResidencyAliased;

		/// <summary>
		/// -
		/// </summary>
		public Bool32 VariableMultisampleRate;

		/// <summary>
		/// -
		/// </summary>
		public Bool32 InheritedQueries;

		/// <summary>
		/// -
		/// </summary>
		public override string ToString()
		{
			var builder = new StringBuilder();
			
            builder.AppendLine("PhysicalDeviceFeatures");
            builder.AppendLine("{");
            builder.AppendLine($"RobustBufferAccess: {this.RobustBufferAccess}");
            builder.AppendLine($"FullDrawIndexUint32: {this.FullDrawIndexUint32}");
            builder.AppendLine($"ImageCubeArray: {this.ImageCubeArray}");
            builder.AppendLine($"IndependentBlend: {this.IndependentBlend}");
            builder.AppendLine($"GeometryShader: {this.GeometryShader}");
            builder.AppendLine($"TessellationShader: {this.TessellationShader}");
            builder.AppendLine($"SampleRateShading: {this.SampleRateShading}");
            builder.AppendLine($"DualSourceBlend: {this.DualSourceBlend}");
            builder.AppendLine($"LogicOp: {this.LogicOp}");
            builder.AppendLine($"MultiDrawIndirect: {this.MultiDrawIndirect}");
            builder.AppendLine($"DrawIndirectFirstInstance: {this.DrawIndirectFirstInstance}");
            builder.AppendLine($"DepthClamp: {this.DepthClamp}");
            builder.AppendLine($"DepthBiasClamp: {this.DepthBiasClamp}");
            builder.AppendLine($"FillModeNonSolid: {this.FillModeNonSolid}");
            builder.AppendLine($"DepthBounds: {this.DepthBounds}");
            builder.AppendLine($"WideLines: {this.WideLines}");
            builder.AppendLine($"LargePoints: {this.LargePoints}");
            builder.AppendLine($"AlphaToOne: {this.AlphaToOne}");
            builder.AppendLine($"MultiViewport: {this.MultiViewport}");
            builder.AppendLine($"SamplerAnisotropy: {this.SamplerAnisotropy}");
            builder.AppendLine($"TextureCompressionETC2: {this.TextureCompressionETC2}");
            builder.AppendLine($"TextureCompressionASTC_LDR: {this.TextureCompressionASTC_LDR}");
            builder.AppendLine($"TextureCompressionBC: {this.TextureCompressionBC}");
            builder.AppendLine($"OcclusionQueryPrecise: {this.OcclusionQueryPrecise}");
            builder.AppendLine($"PipelineStatisticsQuery: {this.PipelineStatisticsQuery}");
            builder.AppendLine($"VertexPipelineStoresAndAtomics: {this.VertexPipelineStoresAndAtomics}");
            builder.AppendLine($"FragmentStoresAndAtomics: {this.FragmentStoresAndAtomics}");
            builder.AppendLine($"ShaderTessellationAndGeometryPointSize: {this.ShaderTessellationAndGeometryPointSize}");
            builder.AppendLine($"ShaderImageGatherExtended: {this.ShaderImageGatherExtended}");
            builder.AppendLine($"ShaderStorageImageExtendedFormats: {this.ShaderStorageImageExtendedFormats}");
            builder.AppendLine($"ShaderStorageImageMultisample: {this.ShaderStorageImageMultisample}");
            builder.AppendLine($"ShaderStorageImageReadWithoutFormat: {this.ShaderStorageImageReadWithoutFormat}");
            builder.AppendLine($"ShaderStorageImageWriteWithoutFormat: {this.ShaderStorageImageWriteWithoutFormat}");
            builder.AppendLine($"ShaderUniformBufferArrayDynamicIndexing: {this.ShaderUniformBufferArrayDynamicIndexing}");
            builder.AppendLine($"ShaderSampledImageArrayDynamicIndexing: {this.ShaderSampledImageArrayDynamicIndexing}");
            builder.AppendLine($"ShaderStorageBufferArrayDynamicIndexing: {this.ShaderStorageBufferArrayDynamicIndexing}");
            builder.AppendLine($"ShaderStorageImageArrayDynamicIndexing: {this.ShaderStorageImageArrayDynamicIndexing}");
            builder.AppendLine($"ShaderClipDistance: {this.ShaderClipDistance}");
            builder.AppendLine($"ShaderCullDistance: {this.ShaderCullDistance}");
            builder.AppendLine($"ShaderFloat64: {this.ShaderFloat64}");
            builder.AppendLine($"ShaderInt64: {this.ShaderInt64}");
            builder.AppendLine($"ShaderInt16: {this.ShaderInt16}");
            builder.AppendLine($"ShaderResourceResidency: {this.ShaderResourceResidency}");
            builder.AppendLine($"ShaderResourceMinLod: {this.ShaderResourceMinLod}");
            builder.AppendLine($"SparseBinding: {this.SparseBinding}");
            builder.AppendLine($"SparseResidencyBuffer: {this.SparseResidencyBuffer}");
            builder.AppendLine($"SparseResidencyImage2D: {this.SparseResidencyImage2D}");
            builder.AppendLine($"SparseResidencyImage3D: {this.SparseResidencyImage3D}");
            builder.AppendLine($"SparseResidency2Samples: {this.SparseResidency2Samples}");
            builder.AppendLine($"SparseResidency4Samples: {this.SparseResidency4Samples}");
            builder.AppendLine($"SparseResidency8Samples: {this.SparseResidency8Samples}");
            builder.AppendLine($"SparseResidency16Samples: {this.SparseResidency16Samples}");
            builder.AppendLine($"SparseResidencyAliased: {this.SparseResidencyAliased}");
            builder.AppendLine($"VariableMultisampleRate: {this.VariableMultisampleRate}");
            builder.AppendLine($"InheritedQueries: {this.InheritedQueries}");
            builder.Append("}");

			return builder.ToString();
		}
	}

    /// <summary>
    /// -
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
	public partial struct PhysicalDeviceSparseProperties
	{
		/// <summary>
		/// -
		/// </summary>
		public Bool32 ResidencyStandard2DBlockShape;

		/// <summary>
		/// -
		/// </summary>
		public Bool32 ResidencyStandard2DMultisampleBlockShape;

		/// <summary>
		/// -
		/// </summary>
		public Bool32 ResidencyStandard3DBlockShape;

		/// <summary>
		/// -
		/// </summary>
		public Bool32 ResidencyAlignedMipSize;

		/// <summary>
		/// -
		/// </summary>
		public Bool32 ResidencyNonResidentStrict;

		/// <summary>
		/// -
		/// </summary>
		public override string ToString()
		{
			var builder = new StringBuilder();
			
            builder.AppendLine("PhysicalDeviceSparseProperties");
            builder.AppendLine("{");
            builder.AppendLine($"ResidencyStandard2DBlockShape: {this.ResidencyStandard2DBlockShape}");
            builder.AppendLine($"ResidencyStandard2DMultisampleBlockShape: {this.ResidencyStandard2DMultisampleBlockShape}");
            builder.AppendLine($"ResidencyStandard3DBlockShape: {this.ResidencyStandard3DBlockShape}");
            builder.AppendLine($"ResidencyAlignedMipSize: {this.ResidencyAlignedMipSize}");
            builder.AppendLine($"ResidencyNonResidentStrict: {this.ResidencyNonResidentStrict}");
            builder.Append("}");

			return builder.ToString();
		}
	}

    /// <summary>
    /// -
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
	public partial struct PipelineColorBlendAttachmentState
	{
		/// <summary>
		/// -
		/// </summary>
		public Bool32 BlendEnable;

		/// <summary>
		/// -
		/// </summary>
		public BlendFactor SourceColorBlendFactor;

		/// <summary>
		/// -
		/// </summary>
		public BlendFactor DestinationColorBlendFactor;

		/// <summary>
		/// -
		/// </summary>
		public BlendOp ColorBlendOp;

		/// <summary>
		/// -
		/// </summary>
		public BlendFactor SourceAlphaBlendFactor;

		/// <summary>
		/// -
		/// </summary>
		public BlendFactor DestinationAlphaBlendFactor;

		/// <summary>
		/// -
		/// </summary>
		public BlendOp AlphaBlendOp;

		/// <summary>
		/// -
		/// </summary>
		public ColorComponentFlags ColorWriteMask;

		/// <summary>
		/// -
		/// </summary>
		public override string ToString()
		{
			var builder = new StringBuilder();
			
            builder.AppendLine("PipelineColorBlendAttachmentState");
            builder.AppendLine("{");
            builder.AppendLine($"BlendEnable: {this.BlendEnable}");
            builder.AppendLine($"SourceColorBlendFactor: {this.SourceColorBlendFactor}");
            builder.AppendLine($"DestinationColorBlendFactor: {this.DestinationColorBlendFactor}");
            builder.AppendLine($"ColorBlendOp: {this.ColorBlendOp}");
            builder.AppendLine($"SourceAlphaBlendFactor: {this.SourceAlphaBlendFactor}");
            builder.AppendLine($"DestinationAlphaBlendFactor: {this.DestinationAlphaBlendFactor}");
            builder.AppendLine($"AlphaBlendOp: {this.AlphaBlendOp}");
            builder.AppendLine($"ColorWriteMask: {this.ColorWriteMask}");
            builder.Append("}");

			return builder.ToString();
		}
	}

    /// <summary>
    /// -
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
	public partial struct PushConstantRange
	{
		/// <summary>
		/// -
		/// </summary>
		public ShaderStageFlags StageFlags;

		/// <summary>
		/// -
		/// </summary>
		public uint Offset;

		/// <summary>
		/// -
		/// </summary>
		public uint Size;

		/// <summary>
		/// -
		/// </summary>
		public override string ToString()
		{
			var builder = new StringBuilder();
			
            builder.AppendLine("PushConstantRange");
            builder.AppendLine("{");
            builder.AppendLine($"StageFlags: {this.StageFlags}");
            builder.AppendLine($"Offset: {this.Offset}");
            builder.AppendLine($"Size: {this.Size}");
            builder.Append("}");

			return builder.ToString();
		}
	}

    /// <summary>
    /// The bits specified in pname:queueFlags are:
    /// // refBegin VkQueueFlagBits - Bitmask specifying capabilities of queues in a queue family
    /// include::../api/enums/VkQueueFlagBits.txt[]
    ///   * if ename:VK_QUEUE_GRAPHICS_BIT is set, then the queues in this queue
    ///     family support graphics operations.
    ///   * if ename:VK_QUEUE_COMPUTE_BIT is set, then the queues in this queue
    ///     family support compute operations.
    ///   * if ename:VK_QUEUE_TRANSFER_BIT is set, then the queues in this queue
    ///     family support transfer operations.
    ///   * if ename:VK_QUEUE_SPARSE_BINDING_BIT is set, then the queues in this
    ///     queue family support sparse memory management operations (see
    ///     &lt;&lt;sparsememory,Sparse Resources&gt;&gt;). If any of the sparse resource
    ///     features are enabled, then at least one queue family must: support this
    ///     bit.
    /// If an implementation exposes any queue family that supports graphics
    /// operations, at least one queue family of at least one physical device
    /// exposed by the implementation must: support both graphics and compute
    /// operations.
    /// [NOTE]
    /// .Note
    /// ====
    /// All commands that are allowed on a queue that supports transfer operations
    /// are also allowed on a queue that supports either graphics or compute
    /// operations thus if the capabilities of a queue family include
    /// ename:VK_QUEUE_GRAPHICS_BIT or ename:VK_QUEUE_COMPUTE_BIT then
    /// reporting the ename:VK_QUEUE_TRANSFER_BIT capability separately for that
    /// queue family is optional:.
    /// ====
    /// For further details see &lt;&lt;devsandqueues-queues,Queues&gt;&gt;.
    /// The value returned in pname:minImageTransferGranularity has a unit of
    /// compressed texel blocks for images having a block-compressed format, and a
    /// unit of texels otherwise.
    /// Possible values of pname:minImageTransferGranularity are:
    ///   * latexmath:[$(0,0,0)$] which indicates that only whole mip levels must:
    ///     be transferred using the image transfer operations on the corresponding
    ///     queues. In this case, the following restrictions apply to all offset and
    ///     extent parameters of image transfer operations:
    ///   ** The pname:x, pname:y, and pname:z members of a slink:VkOffset3D
    ///      parameter must: always be zero.
    ///   ** The pname:width, pname:height, and pname:depth members of a
    ///      slink:VkExtent3D parameter must: always match the width, height, and
    ///      depth of the image subresource corresponding to the parameter,
    ///      respectively.
    ///   * latexmath:[$(Ax, Ay, Az)$] where latexmath:[$Ax$], latexmath:[$Ay$],
    ///     and latexmath:[$Az$] are all integer powers of two. In this case the
    ///     following restrictions apply to all image transfer operations:
    ///   ** pname:x, pname:y, and pname:z of a slink:VkOffset3D parameter must: be
    ///      integer multiples of latexmath:[$Ax$], latexmath:[$Ay$], and
    ///      latexmath:[$Az$], respectively.
    ///   ** pname:width of a slink:VkExtent3D parameter must: be an integer
    ///      multiple of latexmath:[$Ax$], or else latexmath:[$(x + width)$] must:
    ///      equal the width of the image subresource corresponding to the
    ///      parameter.
    ///   ** pname:height of a slink:VkExtent3D parameter must: be an integer
    ///      multiple of latexmath:[$Ay$], or else latexmath:[$(y + height)$] must:
    ///      equal the height of the image subresource corresponding to the
    ///      parameter.
    ///   ** pname:depth of a slink:VkExtent3D parameter must: be an integer
    ///      multiple of latexmath:[$Az$], or else latexmath:[$(z + depth)$] must:
    ///      equal the depth of the image subresource corresponding to the
    ///      parameter.
    ///   ** If the format of the image corresponding to the parameters is one of
    ///      the block-compressed formats then for the purposes of the above
    ///      calculations the granularity must: be scaled up by the compressed
    ///      texel block dimensions.
    /// Queues supporting graphics and/or compute operations must: report
    /// latexmath:[$(1,1,1)$] in pname:minImageTransferGranularity, meaning that
    /// there are no additional restrictions on the granularity of image
    /// transfer operations for these queues. Other queues supporting image
    /// transfer operations are only required: to support whole mip level
    /// transfers, thus pname:minImageTransferGranularity for
    /// queues belonging to such queue families may: be latexmath:[$(0,0,0)$].
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
	public partial struct QueueFamilyProperties
	{
		/// <summary>
		/// -
		/// </summary>
		public QueueFlags QueueFlags;

		/// <summary>
		/// -
		/// </summary>
		public uint QueueCount;

		/// <summary>
		/// -
		/// </summary>
		public uint TimestampValidBits;

		/// <summary>
		/// -
		/// </summary>
		public Extent3D MinImageTransferGranularity;

		/// <summary>
		/// -
		/// </summary>
		public override string ToString()
		{
			var builder = new StringBuilder();
			
            builder.AppendLine("QueueFamilyProperties");
            builder.AppendLine("{");
            builder.AppendLine($"QueueFlags: {this.QueueFlags}");
            builder.AppendLine($"QueueCount: {this.QueueCount}");
            builder.AppendLine($"TimestampValidBits: {this.TimestampValidBits}");
            builder.AppendLine($"MinImageTransferGranularity: {this.MinImageTransferGranularity}");
            builder.Append("}");

			return builder.ToString();
		}
	}

    /// <summary>
    /// -
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
	public partial struct Rect2D
	{
		/// <summary>
		/// -
		/// </summary>
		public Offset2D Offset;

		/// <summary>
		/// -
		/// </summary>
		public Extent2D Extent;

		/// <summary>
		/// -
		/// </summary>
		public override string ToString()
		{
			var builder = new StringBuilder();
			
            builder.AppendLine("Rect2D");
            builder.AppendLine("{");
            builder.AppendLine($"Offset: {this.Offset}");
            builder.AppendLine($"Extent: {this.Extent}");
            builder.Append("}");

			return builder.ToString();
		}
	}

    /// <summary>
    /// -
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
	public partial struct SparseImageFormatProperties
	{
		/// <summary>
		/// -
		/// </summary>
		public ImageAspectFlags AspectMask;

		/// <summary>
		/// -
		/// </summary>
		public Extent3D ImageGranularity;

		/// <summary>
		/// -
		/// </summary>
		public SparseImageFormatFlags Flags;

		/// <summary>
		/// -
		/// </summary>
		public override string ToString()
		{
			var builder = new StringBuilder();
			
            builder.AppendLine("SparseImageFormatProperties");
            builder.AppendLine("{");
            builder.AppendLine($"AspectMask: {this.AspectMask}");
            builder.AppendLine($"ImageGranularity: {this.ImageGranularity}");
            builder.AppendLine($"Flags: {this.Flags}");
            builder.Append("}");

			return builder.ToString();
		}
	}

    /// <summary>
    /// -
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
	public partial struct SparseImageMemoryRequirements
	{
		/// <summary>
		/// -
		/// </summary>
		public SparseImageFormatProperties FormatProperties;

		/// <summary>
		/// -
		/// </summary>
		public uint ImageMipTailFirstLod;

		/// <summary>
		/// -
		/// </summary>
		public DeviceSize ImageMipTailSize;

		/// <summary>
		/// -
		/// </summary>
		public DeviceSize ImageMipTailOffset;

		/// <summary>
		/// -
		/// </summary>
		public DeviceSize ImageMipTailStride;

		/// <summary>
		/// -
		/// </summary>
		public override string ToString()
		{
			var builder = new StringBuilder();
			
            builder.AppendLine("SparseImageMemoryRequirements");
            builder.AppendLine("{");
            builder.AppendLine($"FormatProperties: {this.FormatProperties}");
            builder.AppendLine($"ImageMipTailFirstLod: {this.ImageMipTailFirstLod}");
            builder.AppendLine($"ImageMipTailSize: {this.ImageMipTailSize}");
            builder.AppendLine($"ImageMipTailOffset: {this.ImageMipTailOffset}");
            builder.AppendLine($"ImageMipTailStride: {this.ImageMipTailStride}");
            builder.Append("}");

			return builder.ToString();
		}
	}

    /// <summary>
    /// If a pname:constantID value is not a specialization constant ID used in the
    /// shader, that map entry does not affect the behavior of the pipeline.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
	public partial struct SpecializationMapEntry
	{
		/// <summary>
		/// -
		/// </summary>
		public uint ConstantID;

		/// <summary>
		/// -
		/// </summary>
		public uint Offset;

		/// <summary>
		/// -
		/// </summary>
		public UIntPtr Size;

		/// <summary>
		/// -
		/// </summary>
		public override string ToString()
		{
			var builder = new StringBuilder();
			
            builder.AppendLine("SpecializationMapEntry");
            builder.AppendLine("{");
            builder.AppendLine($"ConstantID: {this.ConstantID}");
            builder.AppendLine($"Offset: {this.Offset}");
            builder.AppendLine($"Size: {this.Size}");
            builder.Append("}");

			return builder.ToString();
		}
	}

    /// <summary>
    /// -
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
	public partial struct StencilOpState
	{
		/// <summary>
		/// -
		/// </summary>
		public StencilOp FailOp;

		/// <summary>
		/// -
		/// </summary>
		public StencilOp PassOp;

		/// <summary>
		/// -
		/// </summary>
		public StencilOp DepthFailOp;

		/// <summary>
		/// -
		/// </summary>
		public CompareOp CompareOp;

		/// <summary>
		/// -
		/// </summary>
		public uint CompareMask;

		/// <summary>
		/// -
		/// </summary>
		public uint WriteMask;

		/// <summary>
		/// -
		/// </summary>
		public uint Reference;

		/// <summary>
		/// -
		/// </summary>
		public override string ToString()
		{
			var builder = new StringBuilder();
			
            builder.AppendLine("StencilOpState");
            builder.AppendLine("{");
            builder.AppendLine($"FailOp: {this.FailOp}");
            builder.AppendLine($"PassOp: {this.PassOp}");
            builder.AppendLine($"DepthFailOp: {this.DepthFailOp}");
            builder.AppendLine($"CompareOp: {this.CompareOp}");
            builder.AppendLine($"CompareMask: {this.CompareMask}");
            builder.AppendLine($"WriteMask: {this.WriteMask}");
            builder.AppendLine($"Reference: {this.Reference}");
            builder.Append("}");

			return builder.ToString();
		}
	}

    /// <summary>
    /// Each subpass dependency defines an execution and memory dependency
    /// between two sets of commands, with the second set depending on the first
    /// set. When pname:srcSubpass does not equal pname:dstSubpass then the first
    /// set of commands is:
    ///   * All commands in the subpass indicated by pname:srcSubpass, if
    ///     pname:srcSubpass is not ename:VK_SUBPASS_EXTERNAL.
    ///   * All commands before the render pass instance, if pname:srcSubpass is
    ///     ename:VK_SUBPASS_EXTERNAL.
    /// While the corresponding second set of commands is:
    ///   * All commands in the subpass indicated by pname:dstSubpass, if
    ///     pname:dstSubpass is not ename:VK_SUBPASS_EXTERNAL.
    ///   * All commands after the render pass instance, if pname:dstSubpass is
    ///     ename:VK_SUBPASS_EXTERNAL.
    /// When pname:srcSubpass equals pname:dstSubpass then the first set consists of
    /// commands in the subpass before a call to flink:vkCmdPipelineBarrier and the
    /// second set consists of commands in the subpass following that same call as
    /// described in the
    /// &lt;&lt;synchronization-pipeline-barriers-subpass-self-dependencies, Subpass
    /// Self-dependency&gt;&gt; section.
    /// The pname:srcStageMask, pname:dstStageMask, pname:srcAccessMask,
    /// pname:dstAccessMask, and pname:dependencyFlags parameters of the dependency
    /// are interpreted the same way as for other dependencies, as described in
    /// &lt;&lt;synchronization, Synchronization and Cache Control&gt;&gt;.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
	public partial struct SubpassDependency
	{
		/// <summary>
		/// -
		/// </summary>
		public uint SourceSubpass;

		/// <summary>
		/// -
		/// </summary>
		public uint DestinationSubpass;

		/// <summary>
		/// -
		/// </summary>
		public PipelineStageFlags SourceStageMask;

		/// <summary>
		/// -
		/// </summary>
		public PipelineStageFlags DestinationStageMask;

		/// <summary>
		/// -
		/// </summary>
		public AccessFlags SourceAccessMask;

		/// <summary>
		/// -
		/// </summary>
		public AccessFlags DestinationAccessMask;

		/// <summary>
		/// -
		/// </summary>
		public DependencyFlags DependencyFlags;

		/// <summary>
		/// -
		/// </summary>
		public override string ToString()
		{
			var builder = new StringBuilder();
			
            builder.AppendLine("SubpassDependency");
            builder.AppendLine("{");
            builder.AppendLine($"SourceSubpass: {this.SourceSubpass}");
            builder.AppendLine($"DestinationSubpass: {this.DestinationSubpass}");
            builder.AppendLine($"SourceStageMask: {this.SourceStageMask}");
            builder.AppendLine($"DestinationStageMask: {this.DestinationStageMask}");
            builder.AppendLine($"SourceAccessMask: {this.SourceAccessMask}");
            builder.AppendLine($"DestinationAccessMask: {this.DestinationAccessMask}");
            builder.AppendLine($"DependencyFlags: {this.DependencyFlags}");
            builder.Append("}");

			return builder.ToString();
		}
	}

    /// <summary>
    /// For images created with linear tiling, pname:rowPitch, pname:arrayPitch and
    /// pname:depthPitch describe the layout of the image subresource in linear
    /// memory. For uncompressed formats, pname:rowPitch is the number of bytes
    /// between texels with the same x coordinate in adjacent rows (y coordinates
    /// differ by one). pname:arrayPitch is the number of bytes between texels with
    /// the same x and y coordinate in adjacent array layers of the image (array
    /// layer values differ by one). pname:depthPitch is the number of bytes between
    /// texels with the same x and y coordinate in adjacent slices of a 3D image (z
    /// coordinates differ by one). Expressed as an addressing formula, the starting
    /// byte of a texel in the image subresource has address:
    /// [source,c]
    /// ---------------------------------------------------
    /// // (x,y,z,layer) are in texel coordinates
    /// address(x,y,z,layer) = layer*arrayPitch + z*depthPitch + y*rowPitch + x*texelSize + offset
    /// ---------------------------------------------------
    /// For compressed formats, the pname:rowPitch is the number of bytes between
    /// compressed texel blocks in adjacent rows. pname:arrayPitch is the number of
    /// bytes between compressed texel blocks in adjacent array layers.
    /// pname:depthPitch is the number of bytes between compressed texel blocks in
    /// adjacent slices of a 3D image.
    /// [source,c]
    /// ---------------------------------------------------
    /// // (x,y,z,layer) are in compressed texel block coordinates
    /// address(x,y,z,layer) = layer*arrayPitch + z*depthPitch + y*rowPitch + x*compressedTexelBlockByteSize + offset;
    /// ---------------------------------------------------
    /// pname:arrayPitch is undefined for images that were not created as arrays.
    /// pname:depthPitch is defined only for 3D images.
    /// For color formats, the pname:aspectMask member of sname:VkImageSubresource
    /// must: be ename:VK_IMAGE_ASPECT_COLOR_BIT. For depth/stencil formats,
    /// pname:aspectMask must: be either ename:VK_IMAGE_ASPECT_DEPTH_BIT or
    /// ename:VK_IMAGE_ASPECT_STENCIL_BIT. On implementations that store depth and
    /// stencil aspects separately, querying each of these image subresource layouts
    /// will return a different pname:offset and pname:size representing the region
    /// of memory used for that aspect. On implementations that store depth and
    /// stencil aspects interleaved, the same pname:offset and pname:size are
    /// returned and represent the interleaved memory allocation.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
	public partial struct SubresourceLayout
	{
		/// <summary>
		/// -
		/// </summary>
		public DeviceSize Offset;

		/// <summary>
		/// -
		/// </summary>
		public DeviceSize Size;

		/// <summary>
		/// -
		/// </summary>
		public DeviceSize RowPitch;

		/// <summary>
		/// -
		/// </summary>
		public DeviceSize ArrayPitch;

		/// <summary>
		/// -
		/// </summary>
		public DeviceSize DepthPitch;

		/// <summary>
		/// -
		/// </summary>
		public override string ToString()
		{
			var builder = new StringBuilder();
			
            builder.AppendLine("SubresourceLayout");
            builder.AppendLine("{");
            builder.AppendLine($"Offset: {this.Offset}");
            builder.AppendLine($"Size: {this.Size}");
            builder.AppendLine($"RowPitch: {this.RowPitch}");
            builder.AppendLine($"ArrayPitch: {this.ArrayPitch}");
            builder.AppendLine($"DepthPitch: {this.DepthPitch}");
            builder.Append("}");

			return builder.ToString();
		}
	}

    /// <summary>
    /// 
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
	public partial struct SurfaceCapabilities
	{
		/// <summary>
		/// -
		/// </summary>
		public uint MinImageCount;

		/// <summary>
		/// -
		/// </summary>
		public uint MaxImageCount;

		/// <summary>
		/// -
		/// </summary>
		public Extent2D CurrentExtent;

		/// <summary>
		/// -
		/// </summary>
		public Extent2D MinImageExtent;

		/// <summary>
		/// -
		/// </summary>
		public Extent2D MaxImageExtent;

		/// <summary>
		/// -
		/// </summary>
		public uint MaxImageArrayLayers;

		/// <summary>
		/// -
		/// </summary>
		public SurfaceTransformFlags SupportedTransforms;

		/// <summary>
		/// -
		/// </summary>
		public SurfaceTransformFlags CurrentTransform;

		/// <summary>
		/// -
		/// </summary>
		public CompositeAlphaFlags SupportedCompositeAlpha;

		/// <summary>
		/// -
		/// </summary>
		public ImageUsageFlags SupportedUsageFlags;

		/// <summary>
		/// -
		/// </summary>
		public override string ToString()
		{
			var builder = new StringBuilder();
			
            builder.AppendLine("SurfaceCapabilities");
            builder.AppendLine("{");
            builder.AppendLine($"MinImageCount: {this.MinImageCount}");
            builder.AppendLine($"MaxImageCount: {this.MaxImageCount}");
            builder.AppendLine($"CurrentExtent: {this.CurrentExtent}");
            builder.AppendLine($"MinImageExtent: {this.MinImageExtent}");
            builder.AppendLine($"MaxImageExtent: {this.MaxImageExtent}");
            builder.AppendLine($"MaxImageArrayLayers: {this.MaxImageArrayLayers}");
            builder.AppendLine($"SupportedTransforms: {this.SupportedTransforms}");
            builder.AppendLine($"CurrentTransform: {this.CurrentTransform}");
            builder.AppendLine($"SupportedCompositeAlpha: {this.SupportedCompositeAlpha}");
            builder.AppendLine($"SupportedUsageFlags: {this.SupportedUsageFlags}");
            builder.Append("}");

			return builder.ToString();
		}
	}

    /// <summary>
    /// 
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
	public partial struct SurfaceFormat
	{
		/// <summary>
		/// -
		/// </summary>
		public Format Format;

		/// <summary>
		/// -
		/// </summary>
		public ColorSpace ColorSpace;

		/// <summary>
		/// -
		/// </summary>
		public override string ToString()
		{
			var builder = new StringBuilder();
			
            builder.AppendLine("SurfaceFormat");
            builder.AppendLine("{");
            builder.AppendLine($"Format: {this.Format}");
            builder.AppendLine($"ColorSpace: {this.ColorSpace}");
            builder.Append("}");

			return builder.ToString();
		}
	}

    /// <summary>
    /// -
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
	public partial struct VertexInputAttributeDescription
	{
		/// <summary>
		/// -
		/// </summary>
		public uint Location;

		/// <summary>
		/// -
		/// </summary>
		public uint Binding;

		/// <summary>
		/// -
		/// </summary>
		public Format Format;

		/// <summary>
		/// -
		/// </summary>
		public uint Offset;

		/// <summary>
		/// -
		/// </summary>
		public override string ToString()
		{
			var builder = new StringBuilder();
			
            builder.AppendLine("VertexInputAttributeDescription");
            builder.AppendLine("{");
            builder.AppendLine($"Location: {this.Location}");
            builder.AppendLine($"Binding: {this.Binding}");
            builder.AppendLine($"Format: {this.Format}");
            builder.AppendLine($"Offset: {this.Offset}");
            builder.Append("}");

			return builder.ToString();
		}
	}

    /// <summary>
    /// -
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
	public partial struct VertexInputBindingDescription
	{
		/// <summary>
		/// -
		/// </summary>
		public uint Binding;

		/// <summary>
		/// -
		/// </summary>
		public uint Stride;

		/// <summary>
		/// -
		/// </summary>
		public VertexInputRate InputRate;

		/// <summary>
		/// -
		/// </summary>
		public override string ToString()
		{
			var builder = new StringBuilder();
			
            builder.AppendLine("VertexInputBindingDescription");
            builder.AppendLine("{");
            builder.AppendLine($"Binding: {this.Binding}");
            builder.AppendLine($"Stride: {this.Stride}");
            builder.AppendLine($"InputRate: {this.InputRate}");
            builder.Append("}");

			return builder.ToString();
		}
	}

    /// <summary>
    /// The framebuffer depth coordinate latexmath:[$z_f$] may: be represented using
    /// either a fixed-point or floating-point representation. However, a
    /// floating-point representation must: be used if the depth/stencil attachment
    /// has a floating-point depth component. If an latexmath:[$m$]-bit fixed-point
    /// representation is used, we assume that it represents each value
    /// latexmath:[$\frac{k}{2^m - 1}$], where latexmath:[$k \in \{ 0,1, \ldots,
    /// 2^m-1 \}$], as latexmath:[$k$] (e.g. 1.0 is represented in binary as a
    /// string of all ones).
    /// The viewport parameters shown in the above equations are found from these
    /// values as
    /// [latexmath]
    /// ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
    /// \begin{align*}
    ///     o_x &amp; = x + \frac{width}{2} \\
    ///     o_y &amp; = y + \frac{height}{2} \\
    ///     o_z &amp; = minDepth \\
    ///     p_x &amp; = width \\
    ///     p_y &amp; = height \\
    ///     p_z &amp; = maxDepth - minDepth.
    /// \end{align*}
    /// ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
    /// The width and height of the &lt;&lt;features-limits-maxViewportDimensions,
    /// implementation-dependent maximum viewport dimensions&gt;&gt; must: be greater
    /// than or equal to the width and height of the largest image which can: be
    /// created and attached to a framebuffer.
    /// The floating-point viewport bounds are represented with an
    /// &lt;&lt;features-limits-viewportSubPixelBits,implementation-dependent precision&gt;&gt;.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
	public partial struct Viewport
	{
		/// <summary>
		/// -
		/// </summary>
		public float X;

		/// <summary>
		/// -
		/// </summary>
		public float Y;

		/// <summary>
		/// -
		/// </summary>
		public float Width;

		/// <summary>
		/// -
		/// </summary>
		public float Height;

		/// <summary>
		/// -
		/// </summary>
		public float MinDepth;

		/// <summary>
		/// -
		/// </summary>
		public float MaxDepth;

		/// <summary>
		/// -
		/// </summary>
		public override string ToString()
		{
			var builder = new StringBuilder();
			
            builder.AppendLine("Viewport");
            builder.AppendLine("{");
            builder.AppendLine($"X: {this.X}");
            builder.AppendLine($"Y: {this.Y}");
            builder.AppendLine($"Width: {this.Width}");
            builder.AppendLine($"Height: {this.Height}");
            builder.AppendLine($"MinDepth: {this.MinDepth}");
            builder.AppendLine($"MaxDepth: {this.MaxDepth}");
            builder.Append("}");

			return builder.ToString();
		}
	}
}