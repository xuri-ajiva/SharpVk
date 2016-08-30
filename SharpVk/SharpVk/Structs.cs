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
	[StructLayout(LayoutKind.Sequential)]
	public struct SECURITY_ATTRIBUTES
	{
		public int nLength;
		public IntPtr lpSecurityDescriptor;
		public int bInheritHandle;
	}

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
	/// <para>
    /// Structure specifying an attachment description
	/// </para>
	/// <para>
    /// If the attachment uses a color format, then pname:loadOp and pname:storeOp are used, and pname:stencilLoadOp and pname:stencilStoreOp are ignored. If the format has depth and/or stencil components, pname:loadOp and pname:storeOp apply only to the depth data, while pname:stencilLoadOp and pname:stencilStoreOp define how the stencil data is handled.
	/// </para>
	/// <para>
    /// During a render pass instance, input/color attachments with color formats that have a component size of 8, 16, or 32 bits must: be represented in the attachment's format throughout the instance. Attachments with other floating- or fixed-point color formats, or with depth components may: be represented in a format with a precision higher than the attachment format, but must: be represented with the same range. When such a component is loaded via the pname:loadOp, it will be converted into an implementation-dependent format used by the render pass. Such components must: be converted from the render pass format, to the format of the attachment, before they are stored or resolved at the end of a render pass instance via pname:storeOp. Conversions occur as described in &lt;&lt;fundamentals-numerics,Numeric Representation and Computation&gt;&gt; and &lt;&lt;fundamentals-fixedconv, Fixed-Point Data Conversions&gt;&gt;.
	/// </para>
	/// <para>
    /// If pname:flags includes ename:VK_ATTACHMENT_DESCRIPTION_MAY_ALIAS_BIT, then the attachment is treated as if it shares physical memory with another attachment in the same render pass. This information limits the ability of the implementation to reorder certain operations (like layout transitions and the pname:loadOp) such that it is not improperly reordered against other uses of the same physical memory via a different attachment. This is described in more detail below.
	/// </para>
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
	public partial struct AttachmentDescription
	{
	   /// <summary>
		/// <para>
		/// pname:flags is a bitmask describing additional properties of the attachment. Bits which can: be set include: + -- // refBegin VkAttachmentDescriptionFlagBits - Bitmask specifying additional properties of an attachment include::../api/enums/VkAttachmentDescriptionFlagBits.txt[] --
		/// </para>
		/// </summary>
		public AttachmentDescriptionFlags Flags;

	   /// <summary>
		/// <para>
		/// pname:format is a elink:VkFormat value specifying the format of the image that will be used for the attachment.
		/// </para>
		/// </summary>
		public Format Format;

	   /// <summary>
		/// <para>
		/// pname:samples is the number of samples of the image as defined in elink:VkSampleCountFlagBits.
		/// </para>
		/// </summary>
		public SampleCountFlags Samples;

	   /// <summary>
		/// <para>
		/// pname:loadOp specifies how the contents of color and depth components of the attachment are treated at the beginning of the subpass where it is first used: + -- // refBegin VkAttachmentLoadOp - specify how contents of an attachment are treated at the beginning of a subpass include::../api/enums/VkAttachmentLoadOp.txt[] --
		/// </para>
		/// </summary>
		public AttachmentLoadOp LoadOp;

	   /// <summary>
		/// <para>
		/// pname:storeOp specifies how the contents of color and depth components of the attachment are treated at the end of the subpass where it is last used: + -- // refBegin VkAttachmentStoreOp - specify how contents of an attachment are treated at the end of a subpass include::../api/enums/VkAttachmentStoreOp.txt[] --
		/// </para>
		/// </summary>
		public AttachmentStoreOp StoreOp;

	   /// <summary>
		/// <para>
		/// pname:stencilLoadOp specifies how the contents of stencil components of the attachment are treated at the beginning of the subpass where it is first used, and must: be one of the same values allowed for pname:loadOp above.
		/// </para>
		/// </summary>
		public AttachmentLoadOp StencilLoadOp;

	   /// <summary>
		/// <para>
		/// pname:stencilStoreOp specifies how the contents of stencil components of the attachment are treated at the end of the last subpass where it is used, and must: be one of the same values allowed for pname:storeOp above.
		/// </para>
		/// </summary>
		public AttachmentStoreOp StencilStoreOp;

	   /// <summary>
		/// <para>
		/// pname:initialLayout is the layout the attachment image subresource will be in when a render pass instance begins.
		/// </para>
		/// </summary>
		public ImageLayout InitialLayout;

	   /// <summary>
		/// <para>
		/// pname:finalLayout is the layout the attachment image subresource will be transitioned to when a render pass instance ends. During a render pass instance, an attachment can: use a different layout in each subpass, if desired.
		/// </para>
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
	/// <para>
    /// Structure specifying an attachment reference
	/// </para>
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
	public partial struct AttachmentReference
	{
	   /// <summary>
		/// <para>
		/// pname:attachment is the index of the attachment of the render pass, and corresponds to the index of the corresponding element in the pname:pAttachments array of the sname:VkRenderPassCreateInfo structure. If any color or depth/stencil attachments are ename:VK_ATTACHMENT_UNUSED, then no writes occur for those attachments.
		/// </para>
		/// </summary>
		public uint Attachment;

	   /// <summary>
		/// <para>
		/// pname:layout is a elink:VkImageLayout value specifying the layout the attachment uses during the subpass. The implementation will automatically perform layout transitions as needed between subpasses to make each subpass use the requested layouts.
		/// </para>
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
	/// <para>
    /// Structure specifying a buffer copy operation
	/// </para>
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
	public partial struct BufferCopy
	{
	   /// <summary>
		/// <para>
		/// pname:srcOffset is the starting offset in bytes from the start of pname:srcBuffer.
		/// </para>
		/// </summary>
		public DeviceSize SourceOffset;

	   /// <summary>
		/// <para>
		/// pname:dstOffset is the starting offset in bytes from the start of pname:dstBuffer.
		/// </para>
		/// </summary>
		public DeviceSize DestinationOffset;

	   /// <summary>
		/// <para>
		/// pname:size is the number of bytes to copy.
		/// </para>
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
	/// <para>
    /// Structure specifying a buffer image copy operation
	/// </para>
	/// <para>
    /// When copying to or from a depth or stencil aspect, the data in buffer memory uses a layout that is a (mostly) tightly packed representation of the depth or stencil data. Specifically:
	/// </para>
	/// <para>
    /// * data copied to or from the stencil aspect of any depth/stencil format is tightly packed with one ename:VK_FORMAT_S8_UINT value per texel. * data copied to or from the depth aspect of a ename:VK_FORMAT_D16_UNORM or ename:VK_FORMAT_D16_UNORM_S8_UINT format is tightly packed with one ename:VK_FORMAT_D16_UNORM value per texel. * data copied to or from the depth aspect of a ename:VK_FORMAT_D32_SFLOAT or ename:VK_FORMAT_D32_SFLOAT_S8_UINT format is tightly packed with one ename:VK_FORMAT_D32_SFLOAT value per texel. * data copied to or from the depth aspect of a ename:VK_FORMAT_X8_D24_UNORM_PACK32 or ename:VK_FORMAT_D24_UNORM_S8_UINT format is packed with one 32-bit word per texel with the D24 value in the LSBs of the word, and undefined values in the eight MSBs.
	/// </para>
	/// <para>
    /// [NOTE] .Note ==== To copy both the depth and stencil aspects of a depth/stencil format, two entries in pname:pRegions can: be used, where one specifies the depth aspect in pname:imageSubresource, and the other specifies the stencil aspect. ====
	/// </para>
	/// <para>
    /// Because depth or stencil aspect buffer to image copies may: require format conversions on some implementations, they are not supported on queues that do not support graphics.
	/// </para>
	/// <para>
    /// Copies are done layer by layer starting with image layer pname:baseArrayLayer member of pname:imageSubresource. pname:layerCount layers are copied from the source image or to the destination image.
	/// </para>
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
	public partial struct BufferImageCopy
	{
	   /// <summary>
		/// <para>
		/// pname:bufferOffset is the offset in bytes from the start of the buffer object where the image data is copied from or to.
		/// </para>
		/// </summary>
		public DeviceSize BufferOffset;

	   /// <summary>
		/// <para>
		/// pname:bufferRowLength and pname:bufferImageHeight specify the data in buffer memory as a subregion of a larger two- or three-dimensional image, and control the addressing calculations of data in buffer memory. If either of these values is zero, that aspect of the buffer memory is considered to be tightly packed according to the pname:imageExtent.
		/// </para>
		/// </summary>
		public uint BufferRowLength;

	   /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		public uint BufferImageHeight;

	   /// <summary>
		/// <para>
		/// pname:imageSubresource is a slink:VkImageSubresourceLayers used to specify the specific image subresources of the image used for the source or destination image data.
		/// </para>
		/// </summary>
		public ImageSubresourceLayers ImageSubresource;

	   /// <summary>
		/// <para>
		/// pname:imageOffset selects the initial x, y, z offsets in texels of the sub-region of the source or destination image data.
		/// </para>
		/// </summary>
		public Offset3D ImageOffset;

	   /// <summary>
		/// <para>
		/// pname:imageExtent is the size in texels of the image to copy in pname:width, pname:height and pname:depth. 1D images use only pname:x and pname:width. 2D images use pname:x, pname:y, pname:width and pname:height. 3D images use pname:x, pname:y, pname:z, pname:width, pname:height and pname:depth.
		/// </para>
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
	/// <para>
    /// Structure specifying a clear attachment
	/// </para>
	/// <para>
    /// No memory barriers are needed between fname:vkCmdClearAttachments and preceding or subsequent draw or attachment clear commands in the same subpass.
	/// </para>
	/// <para>
    /// The fname:vkCmdClearAttachments command is not affected by the bound pipeline state.
	/// </para>
	/// <para>
    /// Attachments can: also be cleared at the beginning of a render pass instance by setting pname:loadOp (or pname:stencilLoadOp) of slink:VkAttachmentDescription to ename:VK_ATTACHMENT_LOAD_OP_CLEAR, as described for flink:vkCreateRenderPass.
	/// </para>
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
	public partial struct ClearAttachment
	{
	   /// <summary>
		/// <para>
		/// pname:aspectMask is a mask selecting the color, depth and/or stencil aspects of the attachment to be cleared. pname:aspectMask can: include ename:VK_IMAGE_ASPECT_COLOR_BIT for color attachments, ename:VK_IMAGE_ASPECT_DEPTH_BIT for depth/stencil attachments with a depth component, and ename:VK_IMAGE_ASPECT_STENCIL_BIT for depth/stencil attachments with a stencil component. If the subpass's depth/stencil attachment is ename:VK_ATTACHMENT_UNUSED, then the clear has no effect.
		/// </para>
		/// </summary>
		public ImageAspectFlags AspectMask;

	   /// <summary>
		/// <para>
		/// pname:colorAttachment is only meaningful if ename:VK_IMAGE_ASPECT_COLOR_BIT is set in pname:aspectMask, in which case it is an index to the pname:pColorAttachments array in the slink:VkSubpassDescription structure of the current subpass which selects the color attachment to clear. If pname:colorAttachment is ename:VK_ATTACHMENT_UNUSED or is greater than or equal to sname:VkSubpassDescription::pname:colorAttachmentCount, then the clear has no effect.
		/// </para>
		/// </summary>
		public uint ColorAttachment;

	   /// <summary>
		/// <para>
		/// pname:clearValue is the color or depth/stencil value to clear the attachment to, as described in &lt;&lt;clears-values,Clear Values&gt;&gt; below.
		/// </para>
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
	/// <para>
    /// Structure specifying a clear depth stencil value
	/// </para>
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
	public partial struct ClearDepthStencilValue
	{
	   /// <summary>
		/// <para>
		/// pname:depth is the clear value for the depth aspect of the depth/stencil attachment. It is a floating-point value which is automatically converted to the attachment's format.
		/// </para>
		/// </summary>
		public float Depth;

	   /// <summary>
		/// <para>
		/// pname:stencil is the clear value for the stencil aspect of the depth/stencil attachment. It is a 32-bit integer value which is converted to the attachment's format by taking the appropriate number of LSBs.
		/// </para>
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
	/// <para>
    /// Structure specifying a clear rectangle
	/// </para>
	/// <para>
    /// The layers latexmath:[$[baseArrayLayer, baseArrayLayer+layerCount)$] counting from the base layer of the attachment image view are cleared.
	/// </para>
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
	public partial struct ClearRect
	{
	   /// <summary>
		/// <para>
		/// pname:rect is the two-dimensional region to be cleared.
		/// </para>
		/// </summary>
		public Rect2D Rect;

	   /// <summary>
		/// <para>
		/// pname:baseArrayLayer is the first layer to be cleared.
		/// </para>
		/// </summary>
		public uint BaseArrayLayer;

	   /// <summary>
		/// <para>
		/// pname:layerCount is the number of layers to clear.
		/// </para>
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
	/// <para>
    /// Structure specifying a color component mapping
	/// </para>
	/// <para>
    /// Each of pname:r, pname:g, pname:b, and pname:a is one of the values:
	/// </para>
	/// <para>
    /// * ename:VK_COMPONENT_SWIZZLE_IDENTITY: the component is set to the identity swizzle. * ename:VK_COMPONENT_SWIZZLE_ZERO: the component is set to zero. * ename:VK_COMPONENT_SWIZZLE_ONE: the component is set to either 1 or 1.0 depending on whether the type of the image view format is integer or floating-point respectively, as determined by the &lt;&lt;features-formats-definition,Format Definition&gt;&gt; section for each elink:VkFormat. * ename:VK_COMPONENT_SWIZZLE_R: the component is set to the value of the R component of the image. * ename:VK_COMPONENT_SWIZZLE_G: the component is set to the value of the G component of the image. * ename:VK_COMPONENT_SWIZZLE_B: the component is set to the value of the B component of the image. * ename:VK_COMPONENT_SWIZZLE_A: the component is set to the value of the A component of the image.
	/// </para>
	/// <para>
    /// Setting the identity swizzle on a component is equivalent to setting the identity mapping on that component. That is:
	/// </para>
	/// <para>
    /// .Component Mappings Equivalent To ename:VK_COMPONENT_SWIZZLE_IDENTITY [options="header"] |==== | Component          | Identity Mapping | pname:components.r | ename:VK_COMPONENT_SWIZZLE_R | pname:components.g | ename:VK_COMPONENT_SWIZZLE_G | pname:components.b | ename:VK_COMPONENT_SWIZZLE_B | pname:components.a | ename:VK_COMPONENT_SWIZZLE_A |====
	/// </para>
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
	public partial struct ComponentMapping
	{
	   /// <summary>
		/// <para>
		/// pname:r determines the component value placed in the R component of the output vector.
		/// </para>
		/// </summary>
		public ComponentSwizzle R;

	   /// <summary>
		/// <para>
		/// pname:g determines the component value placed in the G component of the output vector.
		/// </para>
		/// </summary>
		public ComponentSwizzle G;

	   /// <summary>
		/// <para>
		/// pname:b determines the component value placed in the B component of the output vector.
		/// </para>
		/// </summary>
		public ComponentSwizzle B;

	   /// <summary>
		/// <para>
		/// pname:a determines the component value placed in the A component of the output vector.
		/// </para>
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
	/// <para>
    /// Structure specifying descriptor pool size
	/// </para>
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
	public partial struct DescriptorPoolSize
	{
	   /// <summary>
		/// <para>
		/// pname:type is the type of descriptor.
		/// </para>
		/// </summary>
		public DescriptorType Type;

	   /// <summary>
		/// <para>
		/// pname:descriptorCount is the number of descriptors of that type to allocate.
		/// </para>
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
	/// <para>
    /// Structure specifying a dispatch indirect command
	/// </para>
	/// <para>
    /// The members of sname:VkDispatchIndirectCommand structure have the same meaning as the similarly named parameters of flink:vkCmdDispatch.
	/// </para>
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
	public partial struct DispatchIndirectCommand
	{
	   /// <summary>
		/// <para>
		/// pname:x is the number of local workgroups to dispatch in the X dimension.
		/// </para>
		/// </summary>
		public uint X;

	   /// <summary>
		/// <para>
		/// pname:y is the number of local workgroups to dispatch in the Y dimension.
		/// </para>
		/// </summary>
		public uint Y;

	   /// <summary>
		/// <para>
		/// pname:z is the number of local workgroups to dispatch in the Z dimension.
		/// </para>
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
	/// <para>
    /// -
	/// </para>
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
	public partial struct DisplayModeParameters
	{
	   /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		public Extent2D VisibleRegion;

	   /// <summary>
		/// <para>
		/// -
		/// </para>
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
	/// <para>
    /// -
	/// </para>
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
	public partial struct DisplayPlaneCapabilities
	{
	   /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		public DisplayPlaneAlphaFlags SupportedAlpha;

	   /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		public Offset2D MinSourcePosition;

	   /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		public Offset2D MaxSourcePosition;

	   /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		public Extent2D MinSourceExtent;

	   /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		public Extent2D MaxSourceExtent;

	   /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		public Offset2D MinDestinationPosition;

	   /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		public Offset2D MaxDestinationPosition;

	   /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		public Extent2D MinDestinationExtent;

	   /// <summary>
		/// <para>
		/// -
		/// </para>
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
	/// <para>
    /// Structure specifying a draw indexed indirect command
	/// </para>
	/// <para>
    /// The members of sname:VkDrawIndexedIndirectCommand have the same meaning as the similarly named parameters of flink:vkCmdDrawIndexed.
	/// </para>
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
	public partial struct DrawIndexedIndirectCommand
	{
	   /// <summary>
		/// <para>
		/// pname:indexCount is the number of vertices to draw.
		/// </para>
		/// </summary>
		public uint IndexCount;

	   /// <summary>
		/// <para>
		/// pname:instanceCount is the number of instances to draw.
		/// </para>
		/// </summary>
		public uint InstanceCount;

	   /// <summary>
		/// <para>
		/// pname:firstIndex is the base index within the index buffer.
		/// </para>
		/// </summary>
		public uint FirstIndex;

	   /// <summary>
		/// <para>
		/// pname:vertexOffset is the value added to the vertex index before indexing into the vertex buffer.
		/// </para>
		/// </summary>
		public int VertexOffset;

	   /// <summary>
		/// <para>
		/// pname:firstInstance is the instance ID of the first instance to draw.
		/// </para>
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
	/// <para>
    /// Structure specifying a draw indirect command
	/// </para>
	/// <para>
    /// The members of sname:VkDrawIndirectCommand have the same meaning as the similarly named parameters of flink:vkCmdDraw.
	/// </para>
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
	public partial struct DrawIndirectCommand
	{
	   /// <summary>
		/// <para>
		/// pname:vertexCount is the number of vertices to draw.
		/// </para>
		/// </summary>
		public uint VertexCount;

	   /// <summary>
		/// <para>
		/// pname:instanceCount is the number of instances to draw.
		/// </para>
		/// </summary>
		public uint InstanceCount;

	   /// <summary>
		/// <para>
		/// pname:firstVertex is the index of the first vertex to draw.
		/// </para>
		/// </summary>
		public uint FirstVertex;

	   /// <summary>
		/// <para>
		/// pname:firstInstance is the instance ID of the first instance to draw.
		/// </para>
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
	/// <para>
    /// Structure specifying a two-dimensional extent
	/// </para>
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
	public partial struct Extent2D
	{
	   /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		public uint Width;

	   /// <summary>
		/// <para>
		/// -
		/// </para>
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
	/// <para>
    /// Structure specifying a three-dimensional extent
	/// </para>
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
	public partial struct Extent3D
	{
	   /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		public uint Width;

	   /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		public uint Height;

	   /// <summary>
		/// <para>
		/// -
		/// </para>
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
	/// <para>
    /// -
	/// </para>
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
	public partial struct ExternalImageFormatProperties
	{
	   /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		public ImageFormatProperties ImageFormatProperties;

	   /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		public ExternalMemoryFeatureFlags ExternalMemoryFeatures;

	   /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		public ExternalMemoryHandleTypeFlags ExportFromImportedHandleTypes;

	   /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		public ExternalMemoryHandleTypeFlags CompatibleHandleTypes;

		/// <summary>
		/// -
		/// </summary>
		public override string ToString()
		{
			var builder = new StringBuilder();
			
            builder.AppendLine("ExternalImageFormatProperties");
            builder.AppendLine("{");
            builder.AppendLine($"ImageFormatProperties: {this.ImageFormatProperties}");
            builder.AppendLine($"ExternalMemoryFeatures: {this.ExternalMemoryFeatures}");
            builder.AppendLine($"ExportFromImportedHandleTypes: {this.ExportFromImportedHandleTypes}");
            builder.AppendLine($"CompatibleHandleTypes: {this.CompatibleHandleTypes}");
            builder.Append("}");

			return builder.ToString();
		}
	}

    /// <summary>
	/// <para>
    /// Structure specifying image format properties
	/// </para>
	/// <para>
    /// Supported features are described as a set of elink:VkFormatFeatureFlagBits:
	/// </para>
	/// <para>
    /// The pname:linearTilingFeatures and pname:optimalTilingFeatures members of the sname:VkFormatProperties structure describe what features are supported by ename:VK_IMAGE_TILING_LINEAR and ename:VK_IMAGE_TILING_OPTIMAL images, respectively.
	/// </para>
	/// <para>
    /// The following bits may: be set in pname:linearTilingFeatures and pname:optimalTilingFeatures, indicating they are supported by images or image views created with the queried flink:vkGetPhysicalDeviceFormatProperties::pname:format:
	/// </para>
	/// <para>
    /// ename:VK_FORMAT_FEATURE_SAMPLED_IMAGE_BIT:: sname:VkImageView can: be sampled from. See &lt;&lt;descriptorsets-sampledimage, sampled images&gt;&gt; section.
	/// </para>
	/// <para>
    /// ename:VK_FORMAT_FEATURE_STORAGE_IMAGE_BIT:: sname:VkImageView can: be used as storage image. See &lt;&lt;descriptorsets-storageimage, storage images&gt;&gt; section.
	/// </para>
	/// <para>
    /// ename:VK_FORMAT_FEATURE_STORAGE_IMAGE_ATOMIC_BIT:: sname:VkImageView can: be used as storage image that supports atomic operations.
	/// </para>
	/// <para>
    /// ename:VK_FORMAT_FEATURE_COLOR_ATTACHMENT_BIT:: sname:VkImageView can: be used as a framebuffer color attachment and as an input attachment.
	/// </para>
	/// <para>
    /// ename:VK_FORMAT_FEATURE_COLOR_ATTACHMENT_BLEND_BIT:: sname:VkImageView can: be used as a framebuffer color attachment that supports blending and as an input attachment.
	/// </para>
	/// <para>
    /// ename:VK_FORMAT_FEATURE_DEPTH_STENCIL_ATTACHMENT_BIT:: sname:VkImageView can: be used as a framebuffer depth/stencil attachment and as an input attachment.
	/// </para>
	/// <para>
    /// ename:VK_FORMAT_FEATURE_BLIT_SRC_BIT:: sname:VkImage can: be used as pname:srcImage for the fname:vkCmdBlitImage command.
	/// </para>
	/// <para>
    /// ename:VK_FORMAT_FEATURE_BLIT_DST_BIT:: sname:VkImage can: be used as pname:dstImage for the fname:vkCmdBlitImage command.
	/// </para>
	/// <para>
    /// ename:VK_FORMAT_FEATURE_SAMPLED_IMAGE_FILTER_LINEAR_BIT:: If ename:VK_FORMAT_FEATURE_SAMPLED_IMAGE_BIT is also set, sname:VkImageView can: be used with a sampler that has either of pname:magFilter or pname:minFilter set to ename:VK_FILTER_LINEAR, or pname:mipmapMode set to ename:VK_SAMPLER_MIPMAP_MODE_LINEAR. If ename:VK_FORMAT_FEATURE_BLIT_SRC_BIT is also set, sname:VkImage can be used as the pname:srcImage to flink:vkCmdBlitImage with a pname:filter of ename:VK_FILTER_LINEAR. This bit must: only be exposed for formats that also support the ename:VK_FORMAT_FEATURE_SAMPLED_IMAGE_BIT or ename:VK_FORMAT_FEATURE_BLIT_SRC_BIT. + If the format being queried is a depth/stencil format, this bit only indicates that the depth aspect (not the stencil aspect) of an image of this format supports linear filtering, and that linear filtering of the depth aspect is supported whether depth compare is enabled in the sampler or not. If this bit is not present, linear filtering with depth compare disabled is unsupported and linear filtering with depth compare enabled is supported, but may: compute the filtered value in an implementation-dependent manner which differs from the normal rules of linear filtering. The resulting value must: be in the range latexmath:[$[0,1\]$] and should: be proportional to, or a weighted average of, the number of comparison passes or failures.
	/// </para>
	/// <para>
    /// ifdef::VK_IMG_filter_cubic[] include::../chapters/VK_IMG_filter_cubic/filter_cubic_sampled_bit_description.txt[] endif::VK_IMG_filter_cubic[]
	/// </para>
	/// <para>
    /// The following features may: appear in pname:bufferFeatures, indicating they are supported by buffers or buffer views created with the queried flink:vkGetPhysicalDeviceFormatProperties::pname:format:
	/// </para>
	/// <para>
    /// ename:VK_FORMAT_FEATURE_UNIFORM_TEXEL_BUFFER_BIT:: Format can: be used to create a sname:VkBufferView that can: be bound to a ename:VK_DESCRIPTOR_TYPE_UNIFORM_TEXEL_BUFFER descriptor.
	/// </para>
	/// <para>
    /// ename:VK_FORMAT_FEATURE_STORAGE_TEXEL_BUFFER_BIT:: Format can: be used to create a sname:VkBufferView that can: be bound to a ename:VK_DESCRIPTOR_TYPE_STORAGE_TEXEL_BUFFER descriptor.
	/// </para>
	/// <para>
    /// ename:VK_FORMAT_FEATURE_STORAGE_TEXEL_BUFFER_ATOMIC_BIT:: Atomic operations are supported on ename:VK_DESCRIPTOR_TYPE_STORAGE_TEXEL_BUFFER with this format.
	/// </para>
	/// <para>
    /// ename:VK_FORMAT_FEATURE_VERTEX_BUFFER_BIT:: Format can: be used as a vertex attribute format (sname:VkVertexInputAttributeDescription::pname:format).
	/// </para>
	/// <para>
    /// [NOTE] .Note ==== If no format feature flags are supported, then the only possible use would be image transfers - which alone are not useful. As such, if no format feature flags are supported, the format itself is not supported, and images of that format cannot be created. ====
	/// </para>
	/// <para>
    /// If pname:format is a block-compression format, then buffers mustnot: support any features for the format.
	/// </para>
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
	public partial struct FormatProperties
	{
	   /// <summary>
		/// <para>
		/// pname:linearTilingFeatures describes the features supported by ename:VK_IMAGE_TILING_LINEAR.
		/// </para>
		/// </summary>
		public FormatFeatureFlags LinearTilingFeatures;

	   /// <summary>
		/// <para>
		/// pname:optimalTilingFeatures describes the features supported by ename:VK_IMAGE_TILING_OPTIMAL.
		/// </para>
		/// </summary>
		public FormatFeatureFlags OptimalTilingFeatures;

	   /// <summary>
		/// <para>
		/// pname:bufferFeatures describes the features supported by buffers.
		/// </para>
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
	/// <para>
    /// Structure specifying an image copy operation
	/// </para>
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
	public partial struct ImageCopy
	{
	   /// <summary>
		/// <para>
		/// pname:srcSubresource and pname:dstSubresource are slink:VkImageSubresourceLayers structures specifying the image subresources of the images used for the source and destination image data, respectively.
		/// </para>
		/// </summary>
		public ImageSubresourceLayers SourceSubresource;

	   /// <summary>
		/// <para>
		/// pname:srcOffset and pname:dstOffset select the initial x, y, and z offsets in texels of the sub-regions of the source and destination image data.
		/// </para>
		/// </summary>
		public Offset3D SourceOffset;

	   /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		public ImageSubresourceLayers DestinationSubresource;

	   /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		public Offset3D DestinationOffset;

	   /// <summary>
		/// <para>
		/// pname:extent is the size in texels of the source image to copy in pname:width, pname:height and pname:depth. 1D images use only pname:x and pname:width. 2D images use pname:x, pname:y, pname:width and pname:height. 3D images use pname:x, pname:y, pname:z, pname:width, pname:height and pname:depth.
		/// </para>
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
	/// <para>
    /// Structure specifying a image format properties
	/// </para>
	/// <para>
    /// [NOTE] .Note ==== There is no mechanism to query the size of an image before creating it, to compare that size against pname:maxResourceSize. If an application attempts to create an image that exceeds this limit, the creation will fail or the image will be invalid. While the advertised limit must: be at least 2^31^, it may: not be possible to create an image that approaches that size, particularly for ename:VK_IMAGE_TYPE_1D. ====
	/// </para>
	/// <para>
    /// If the combination of parameters to fname:vkGetPhysicalDeviceImageFormatProperties is not supported by the implementation for use in flink:vkCreateImage, then all members of sname:VkImageFormatProperties will be filled with zero.
	/// </para>
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
	public partial struct ImageFormatProperties
	{
	   /// <summary>
		/// <para>
		/// pname:maxExtent are the maximum image dimensions. See the &lt;&lt;features-extentperimagetype,Allowed Extent Values&gt;&gt; section below for how these values are constrained by pname:type.
		/// </para>
		/// </summary>
		public Extent3D MaxExtent;

	   /// <summary>
		/// <para>
		/// pname:maxMipLevels is the maximum number of mipmap levels. pname:maxMipLevels must: either be equal to 1 (valid only if pname:tiling is ename:VK_IMAGE_TILING_LINEAR) or be equal to latexmath:[$\left\lceil\log_2(\max( \mathit{width},\mathit{height},\mathit{depth})) \right\rceil + 1$] where latexmath:[$\mathit{width}$], latexmath:[$\mathit{height}$], and latexmath:[$\mathit{depth}$] are taken from the corresponding members of pname:maxExtent.
		/// </para>
		/// </summary>
		public uint MaxMipLevels;

	   /// <summary>
		/// <para>
		/// pname:maxArrayLayers is the maximum number of array layers. pname:maxArrayLayers must: either be equal to 1 or be greater than or equal to the pname:maxImageArrayLayers member of slink:VkPhysicalDeviceLimits. A value of 1 is valid only if pname:tiling is ename:VK_IMAGE_TILING_LINEAR or if pname:type is ename:VK_IMAGE_TYPE_3D.
		/// </para>
		/// </summary>
		public uint MaxArrayLayers;

	   /// <summary>
		/// <para>
		/// pname:sampleCounts is a bitmask of elink:VkSampleCountFlagBits specifying all the supported sample counts for this image as described &lt;&lt;features-supported-sample-counts, below&gt;&gt;.
		/// </para>
		/// </summary>
		public SampleCountFlags SampleCounts;

	   /// <summary>
		/// <para>
		/// pname:maxResourceSize is an upper bound on the total image size in bytes, inclusive of all image subresources. Implementations may: have an address space limit on total size of a resource, which is advertised by this property. pname:maxResourceSize must: be at least 2^31^.
		/// </para>
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
	/// <para>
    /// Structure specifying an image resolve operation
	/// </para>
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
	public partial struct ImageResolve
	{
	   /// <summary>
		/// <para>
		/// pname:srcSubresource and pname:dstSubresource are slink:VkImageSubresourceLayers structures specifying the image subresources of the images used for the source and destination image data, respectively. Resolve of depth/stencil images is not supported.
		/// </para>
		/// </summary>
		public ImageSubresourceLayers SourceSubresource;

	   /// <summary>
		/// <para>
		/// pname:srcOffset and pname:dstOffset select the initial x, y, and z offsets in texels of the sub-regions of the source and destination image data.
		/// </para>
		/// </summary>
		public Offset3D SourceOffset;

	   /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		public ImageSubresourceLayers DestinationSubresource;

	   /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		public Offset3D DestinationOffset;

	   /// <summary>
		/// <para>
		/// pname:extent is the size in texels of the source image to resolve in pname:width, pname:height and pname:depth. 1D images use only pname:x and pname:width. 2D images use pname:x, pname:y, pname:width and pname:height. 3D images use pname:x, pname:y, pname:z, pname:width, pname:height and pname:depth.
		/// </para>
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
	/// <para>
    /// Structure specifying a image subresource
	/// </para>
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
	public partial struct ImageSubresource
	{
	   /// <summary>
		/// <para>
		/// pname:aspectMask is a elink:VkImageAspectFlags selecting the image _aspect_.
		/// </para>
		/// </summary>
		public ImageAspectFlags AspectMask;

	   /// <summary>
		/// <para>
		/// pname:mipLevel selects the mipmap level.
		/// </para>
		/// </summary>
		public uint MipLevel;

	   /// <summary>
		/// <para>
		/// pname:arrayLayer selects the array layer.
		/// </para>
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
	/// <para>
    /// Structure specifying a image subresource layers
	/// </para>
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
	public partial struct ImageSubresourceLayers
	{
	   /// <summary>
		/// <para>
		/// pname:aspectMask is a combination of elink:VkImageAspectFlagBits, selecting the color, depth and/or stencil aspects to be copied.
		/// </para>
		/// </summary>
		public ImageAspectFlags AspectMask;

	   /// <summary>
		/// <para>
		/// pname:mipLevel is the mipmap level to copy from.
		/// </para>
		/// </summary>
		public uint MipLevel;

	   /// <summary>
		/// <para>
		/// pname:baseArrayLayer and pname:layerCount are the starting layer and number of layers to copy.
		/// </para>
		/// </summary>
		public uint BaseArrayLayer;

	   /// <summary>
		/// <para>
		/// -
		/// </para>
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
	/// <para>
    /// Structure specifying a image subresource range
	/// </para>
	/// <para>
    /// The number of mip-map levels and array layers must: be a subset of the image subresources in the image. If an application wants to use all mip-levels or layers in an image after the pname:baseMipLevel or pname:baseArrayLayer, it can: set pname:levelCount and pname:layerCount to the special values ename:VK_REMAINING_MIP_LEVELS and ename:VK_REMAINING_ARRAY_LAYERS without knowing the exact number of mip-levels or layers.
	/// </para>
	/// <para>
    /// For cube and cube array image views, the layers of the image view starting at pname:baseArrayLayer correspond to faces in the order +X, -X, +Y, -Y, +Z, -Z. For cube arrays, each set of six sequential layers is a single cube, so the number of cube maps in a cube map array view is _pname:layerCount / 6_, and image array layer _pname:baseArrayLayer + i_ is face index _i mod 6_ of cube _i / 6_. If the number of layers in the view, whether set explicitly in pname:layerCount or implied by ename:VK_REMAINING_ARRAY_LAYERS, is not a multiple of 6, behavior when indexing the last cube is undefined.
	/// </para>
	/// <para>
    /// pname:aspectMask is a bitmask indicating the format being used. Bits which may: be set include:
	/// </para>
	/// <para>
    /// The mask must: be only ename:VK_IMAGE_ASPECT_COLOR_BIT, ename:VK_IMAGE_ASPECT_DEPTH_BIT or ename:VK_IMAGE_ASPECT_STENCIL_BIT if pname:format is a color, depth-only or stencil-only format, respectively. If using a depth/stencil format with both depth and stencil components, pname:aspectMask must: include at least one of ename:VK_IMAGE_ASPECT_DEPTH_BIT and ename:VK_IMAGE_ASPECT_STENCIL_BIT, and can: include both.
	/// </para>
	/// <para>
    /// When using an imageView of a depth/stencil image to populate a descriptor set (e.g. for sampling in the shader, or for use as an input attachment), the pname:aspectMask must: only include one bit and selects whether the imageView is used for depth reads (i.e. using a floating-point sampler or input attachment in the shader) or stencil reads (i.e. using an unsigned integer sampler or input attachment in the shader). When an imageView of a depth/stencil image is used as a depth/stencil framebuffer attachment, the pname:aspectMask is ignored and both depth and stencil image subresources are used.
	/// </para>
	/// <para>
    /// The pname:components member is of type slink:VkComponentMapping, and describes a remapping from components of the image to components of the vector returned by shader image instructions. This remapping must: be identity for storage image descriptors, input attachment descriptors, and framebuffer attachments.
	/// </para>
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
	public partial struct ImageSubresourceRange
	{
	   /// <summary>
		/// <para>
		/// pname:aspectMask is a bitmask indicating which aspect(s) of the image are included in the view. See elink:VkImageAspectFlagBits.
		/// </para>
		/// </summary>
		public ImageAspectFlags AspectMask;

	   /// <summary>
		/// <para>
		/// pname:baseMipLevel is the first mipmap level accessible to the view.
		/// </para>
		/// </summary>
		public uint BaseMipLevel;

	   /// <summary>
		/// <para>
		/// pname:levelCount is the number of mipmap levels (starting from pname:baseMipLevel) accessible to the view.
		/// </para>
		/// </summary>
		public uint LevelCount;

	   /// <summary>
		/// <para>
		/// pname:baseArrayLayer is the first array layer accessible to the view.
		/// </para>
		/// </summary>
		public uint BaseArrayLayer;

	   /// <summary>
		/// <para>
		/// pname:layerCount is the number of array layers (starting from pname:baseArrayLayer) accessible to the view.
		/// </para>
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
	/// <para>
    /// Structure specifying a memory heap
	/// </para>
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
	public partial struct MemoryHeap
	{
	   /// <summary>
		/// <para>
		/// pname:size is the total memory size in bytes in the heap.
		/// </para>
		/// </summary>
		public DeviceSize Size;

	   /// <summary>
		/// <para>
		/// pname:flags is a bitmask of attribute flags for the heap. The bits specified in pname:flags are: + -- // refBegin VkMemoryHeapFlagBits - Bitmask specifying attribute flags for a heap include::../api/enums/VkMemoryHeapFlagBits.txt[] --
		/// </para>
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
	/// <para>
    /// Structure specifying memory requirements
	/// </para>
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
	public partial struct MemoryRequirements
	{
	   /// <summary>
		/// <para>
		/// pname:size is the size, in bytes, of the memory allocation required: for the resource.
		/// </para>
		/// </summary>
		public DeviceSize Size;

	   /// <summary>
		/// <para>
		/// pname:alignment is the alignment, in bytes, of the offset within the allocation required: for the resource.
		/// </para>
		/// </summary>
		public DeviceSize Alignment;

	   /// <summary>
		/// <para>
		/// pname:memoryTypeBits is a bitmask and contains one bit set for every supported memory type for the resource. Bit `i` is set if and only if the memory type `i` in the sname:VkPhysicalDeviceMemoryProperties structure for the physical device is supported for the resource.
		/// </para>
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
	/// <para>
    /// Structure specifying memory type
	/// </para>
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
	public partial struct MemoryType
	{
	   /// <summary>
		/// <para>
		/// pname:propertyFlags is a bitmask of properties for this memory type. The bits specified in pname:propertyFlags are: + -- // refBegin VkMemoryPropertyFlagBits - Bitmask specifying properties for a memory type include::../api/enums/VkMemoryPropertyFlagBits.txt[] --
		/// </para>
		/// </summary>
		public MemoryPropertyFlags PropertyFlags;

	   /// <summary>
		/// <para>
		/// pname:heapIndex describes which memory heap this memory type corresponds to, and must: be less than pname:memoryHeapCount from the sname:VkPhysicalDeviceMemoryProperties structure.
		/// </para>
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
	/// <para>
    /// Structure specifying a two-dimensional offset
	/// </para>
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
	public partial struct Offset2D
	{
	   /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		public int X;

	   /// <summary>
		/// <para>
		/// -
		/// </para>
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
	/// <para>
    /// Structure specifying a three-dimensional offset
	/// </para>
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
	public partial struct Offset3D
	{
	   /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		public int X;

	   /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		public int Y;

	   /// <summary>
		/// <para>
		/// -
		/// </para>
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
	/// <para>
    /// Structure describing the fine-grained features that can be supported by an implementation.
	/// </para>
	/// <para>
    /// *  pname:robustBufferAccess indicates that accesses to buffers are bounds-checked against the range of the buffer descriptor (as determined by sname:VkDescriptorBufferInfo::pname:range, sname:VkBufferViewCreateInfo::pname:range, or the size of the buffer). Out of bounds accesses mustnot: cause application termination, and the effects of shader loads, stores, and atomics must: conform to an implementation-dependent behavior as described below. ** A buffer access is considered to be out of bounds if any of the following are true: *** The pointer was formed by code:OpImageTexelPointer and the coordinate is less than zero or greater than or equal to the number of whole elements in the bound range. *** The pointer was not formed by code:OpImageTexelPointer and the object pointed to is not wholly contained within the bound range. + -- [NOTE] .Note ==== If a SPIR-V code:OpLoad instruction loads a structure and the tail end of the structure is out of bounds, then all members of the structure are considered out of bounds even if the members at the end are not statically used. ==== -- + *** If any buffer access in a given SPIR-V block is determined to be out of bounds, then any other access of the same type (load, store, or atomic) in the same SPIR-V block that accesses an address less than 16 bytes away from the out of bounds address may: also be considered out of bounds. ** Out-of-bounds buffer loads will return any of the following values: *** Values from anywhere within the memory range(s) bound to the buffer (possibly including bytes of memory past the end of the buffer, up to the end of the bound range). *** Zero values, or (0,0,0,x) vectors for vector reads where x is a valid value represented in the type of the vector components and may: be any of: **** 0, 1, or the maximum representable positive integer value, for signed or unsigned integer components **** 0.0 or 1.0, for floating-point components ** Out-of-bounds writes may: modify values within the memory range(s) bound to the buffer, but mustnot: modify any other memory. ** Out-of-bounds atomics may: modify values within the memory range(s) bound to the buffer, but mustnot: modify any other memory, and return an undefined value. ** Vertex input attributes are considered out of bounds if the address of the attribute plus the size of the attribute is greater than the size of the bound buffer. Further, if any vertex input attribute using a specific vertex input binding is out of bounds, then all vertex input attributes using that vertex input binding for that vertex shader invocation are considered out of bounds. *** If a vertex input attribute is out of bounds, it will be assigned one of the following values: **** Values from anywhere within the memory range(s) bound to the buffer, converted according to the format of the attribute. **** Zero values, format converted according to the format of the attribute. **** Zero values, or (0,0,0,x) vectors, as described above. ** If pname:robustBufferAccess is not enabled, out of bounds accesses may: corrupt any memory within the process and cause undefined behaviour up to and including application termination. *  pname:fullDrawIndexUint32 indicates the full 32-bit range of indices is supported for indexed draw calls when using a elink:VkIndexType of ename:VK_INDEX_TYPE_UINT32. pname:maxDrawIndexedIndexValue is the maximum index value that may: be used (aside from the primitive restart index, which is always 2^32^-1 when the elink:VkIndexType is ename:VK_INDEX_TYPE_UINT32). If this feature is supported, pname:maxDrawIndexedIndexValue must: be 2^32^-1; otherwise it must: be no smaller than 2^24^-1. See &lt;&lt;features-limits-maxDrawIndexedIndexValue,maxDrawIndexedIndexValue&gt;&gt;. *  pname:imageCubeArray indicates whether image views with a elink:VkImageViewType of ename:VK_IMAGE_VIEW_TYPE_CUBE_ARRAY can: be created, and that the corresponding code:SampledCubeArray and code:ImageCubeArray SPIR-V capabilities can: be used in shader code. *  pname:independentBlend indicates whether the sname:VkPipelineColorBlendAttachmentState settings are controlled independently per-attachment. If this feature is not enabled, the sname:VkPipelineColorBlendAttachmentState settings for all color attachments must: be identical. Otherwise, a different sname:VkPipelineColorBlendAttachmentState can: be provided for each bound color attachment. *  pname:geometryShader indicates whether geometry shaders are supported. If this feature is not enabled, the ename:VK_SHADER_STAGE_GEOMETRY_BIT and ename:VK_PIPELINE_STAGE_GEOMETRY_SHADER_BIT enum values mustnot: be used. This also indicates whether shader modules can: declare the code:Geometry capability. *  pname:tessellationShader indicates whether tessellation control and evaluation shaders are supported. If this feature is not enabled, the ename:VK_SHADER_STAGE_TESSELLATION_CONTROL_BIT, ename:VK_SHADER_STAGE_TESSELLATION_EVALUATION_BIT, ename:VK_PIPELINE_STAGE_TESSELLATION_CONTROL_SHADER_BIT, ename:VK_PIPELINE_STAGE_TESSELLATION_EVALUATION_SHADER_BIT, and ename:VK_STRUCTURE_TYPE_PIPELINE_TESSELLATION_STATE_CREATE_INFO enum values mustnot: be used. This also indicates whether shader modules can: declare the code:Tessellation capability. *  pname:sampleRateShading indicates whether per-sample shading and multisample interpolation are supported. If this feature is not enabled, the pname:sampleShadingEnable member of the sname:VkPipelineMultisampleStateCreateInfo structure must: be set to ename:VK_FALSE and the pname:minSampleShading member is ignored. This also indicates whether shader modules can: declare the code:SampleRateShading capability. *  pname:dualSrcBlend indicates whether blend operations which take two sources are supported. If this feature is not enabled, the ename:VK_BLEND_FACTOR_SRC1_COLOR, ename:VK_BLEND_FACTOR_ONE_MINUS_SRC1_COLOR, ename:VK_BLEND_FACTOR_SRC1_ALPHA, and ename:VK_BLEND_FACTOR_ONE_MINUS_SRC1_ALPHA enum values mustnot: be used as source or destination blending factors. See &lt;&lt;framebuffer-dsb&gt;&gt;. *  pname:logicOp indicates whether logic operations are supported. If this feature is not enabled, the pname:logicOpEnable member of the sname:VkPipelineColorBlendStateCreateInfo structure must: be set to ename:VK_FALSE, and the pname:logicOp member is ignored. *  pname:multiDrawIndirect indicates whether multiple draw indirect is supported. If this feature is not enabled, the pname:drawCount parameter to the fname:vkCmdDrawIndirect and fname:vkCmdDrawIndexedIndirect commands must: be 0 or 1. The pname:maxDrawIndirectCount member of the sname:VkPhysicalDeviceLimits structure must: also be 1 if this feature is not supported. See &lt;&lt;features-limits-maxDrawIndirectCount,maxDrawIndirectCount&gt;&gt;. * pname:drawIndirectFirstInstance indicates whether indirect draw calls support the pname:firstInstance parameter. If this feature is not enabled, the pname:firstInstance member of all sname:VkDrawIndirectCommand and sname:VkDrawIndexedIndirectCommand structures that are provided to the fname:vkCmdDrawIndirect and fname:vkCmdDrawIndexedIndirect commands must: be 0. *  pname:depthClamp indicates whether depth clamping is supported. If this feature is not enabled, the pname:depthClampEnable member of the sname:VkPipelineRasterizationStateCreateInfo structure must: be set to ename:VK_FALSE. Otherwise, setting pname:depthClampEnable to ename:VK_TRUE will enable depth clamping. *  pname:depthBiasClamp indicates whether depth bias clamping is supported. If this feature is not enabled, the pname:depthBiasClamp member of the sname:VkPipelineRasterizationStateCreateInfo structure must: be set to 0.0 unless the ename:VK_DYNAMIC_STATE_DEPTH_BIAS dynamic state is enabled, and the pname:depthBiasClamp parameter to fname:vkCmdSetDepthBias must: be set to 0.0. *  pname:fillModeNonSolid indicates whether point and wireframe fill modes are supported. If this feature is not enabled, the ename:VK_POLYGON_MODE_POINT and ename:VK_POLYGON_MODE_LINE enum values mustnot: be used. *  pname:depthBounds indicates whether depth bounds tests are supported. If this feature is not enabled, the pname:depthBoundsTestEnable member of the sname:VkPipelineDepthStencilStateCreateInfo structure must: be set to ename:VK_FALSE. When pname:depthBoundsTestEnable is set to ename:VK_FALSE, the pname:minDepthBounds and pname:maxDepthBounds members of the sname:VkPipelineDepthStencilStateCreateInfo structure are ignored. *  pname:wideLines indicates whether lines with width other than 1.0 are supported. If this feature is not enabled, the pname:lineWidth member of the sname:VkPipelineRasterizationStateCreateInfo structure must: be set to 1.0 unless the ename:VK_DYNAMIC_STATE_LINE_WIDTH dynamic state is enabled, and the pname:lineWidth parameter to fname:vkCmdSetLineWidth must: be set to 1.0. When this feature is supported, the range and granularity of supported line widths are indicated by the pname:lineWidthRange and pname:lineWidthGranularity members of the sname:VkPhysicalDeviceLimits structure, respectively. *  pname:largePoints indicates whether points with size greater than 1.0 are supported. If this feature is not enabled, only a point size of 1.0 written by a shader is supported. The range and granularity of supported point sizes are indicated by the pname:pointSizeRange and pname:pointSizeGranularity members of the sname:VkPhysicalDeviceLimits structure, respectively. *  pname:alphaToOne indicates whether the implementation is able to replace the alpha value of the color fragment output from the fragment shader with the maximum representable alpha value for fixed-point colors or 1.0 for floating-point colors. If this feature is not enabled, then the pname:alphaToOneEnable member of the sname:VkPipelineMultisampleStateCreateInfo structure must: be set to ename:VK_FALSE. Otherwise setting pname:alphaToOneEnable to ename:VK_TRUE will enable alpha-to-one behaviour. *  pname:multiViewport indicates whether more than one viewport is supported. If this feature is not enabled, the pname:viewportCount and pname:scissorCount members of the sname:VkPipelineViewportStateCreateInfo structure must: be set to 1. Similarly, the pname:viewportCount parameter to the fname:vkCmdSetViewport command and the pname:scissorCount parameter to the fname:vkCmdSetScissor command must: be 1, and the pname:firstViewport parameter to the fname:vkCmdSetViewport command and the pname:firstScissor parameter to the fname:vkCmdSetScissor command must: be 0. *  pname:samplerAnisotropy indicates whether anisotropic filtering is supported. If this feature is not enabled, the pname:maxAnisotropy member of the sname:VkSamplerCreateInfo structure must: be 1.0. * pname:textureCompressionETC2 indicates whether the ETC2 and EAC compressed texture formats are supported. If this feature is not enabled, the following formats mustnot: be used to create images: + -- * ename:VK_FORMAT_ETC2_R8G8B8_UNORM_BLOCK * ename:VK_FORMAT_ETC2_R8G8B8_SRGB_BLOCK * ename:VK_FORMAT_ETC2_R8G8B8A1_UNORM_BLOCK * ename:VK_FORMAT_ETC2_R8G8B8A1_SRGB_BLOCK * ename:VK_FORMAT_ETC2_R8G8B8A8_UNORM_BLOCK * ename:VK_FORMAT_ETC2_R8G8B8A8_SRGB_BLOCK * ename:VK_FORMAT_EAC_R11_UNORM_BLOCK * ename:VK_FORMAT_EAC_R11_SNORM_BLOCK * ename:VK_FORMAT_EAC_R11G11_UNORM_BLOCK * ename:VK_FORMAT_EAC_R11G11_SNORM_BLOCK -- + flink:vkGetPhysicalDeviceFormatProperties is used to check for the supported properties of individual formats. + * pname:textureCompressionASTC_LDR indicates whether the ASTC LDR compressed texture formats are supported. If this feature is not enabled, the following formats mustnot: be used to create images: + -- * ename:VK_FORMAT_ASTC_4x4_UNORM_BLOCK * ename:VK_FORMAT_ASTC_4x4_SRGB_BLOCK * ename:VK_FORMAT_ASTC_5x4_UNORM_BLOCK * ename:VK_FORMAT_ASTC_5x4_SRGB_BLOCK * ename:VK_FORMAT_ASTC_5x5_UNORM_BLOCK * ename:VK_FORMAT_ASTC_5x5_SRGB_BLOCK * ename:VK_FORMAT_ASTC_6x5_UNORM_BLOCK * ename:VK_FORMAT_ASTC_6x5_SRGB_BLOCK * ename:VK_FORMAT_ASTC_6x6_UNORM_BLOCK * ename:VK_FORMAT_ASTC_6x6_SRGB_BLOCK * ename:VK_FORMAT_ASTC_8x5_UNORM_BLOCK * ename:VK_FORMAT_ASTC_8x5_SRGB_BLOCK * ename:VK_FORMAT_ASTC_8x6_UNORM_BLOCK * ename:VK_FORMAT_ASTC_8x6_SRGB_BLOCK * ename:VK_FORMAT_ASTC_8x8_UNORM_BLOCK * ename:VK_FORMAT_ASTC_8x8_SRGB_BLOCK * ename:VK_FORMAT_ASTC_10x5_UNORM_BLOCK * ename:VK_FORMAT_ASTC_10x5_SRGB_BLOCK * ename:VK_FORMAT_ASTC_10x6_UNORM_BLOCK * ename:VK_FORMAT_ASTC_10x6_SRGB_BLOCK * ename:VK_FORMAT_ASTC_10x8_UNORM_BLOCK * ename:VK_FORMAT_ASTC_10x8_SRGB_BLOCK * ename:VK_FORMAT_ASTC_10x10_UNORM_BLOCK * ename:VK_FORMAT_ASTC_10x10_SRGB_BLOCK * ename:VK_FORMAT_ASTC_12x10_UNORM_BLOCK * ename:VK_FORMAT_ASTC_12x10_SRGB_BLOCK * ename:VK_FORMAT_ASTC_12x12_UNORM_BLOCK * ename:VK_FORMAT_ASTC_12x12_SRGB_BLOCK -- + flink:vkGetPhysicalDeviceFormatProperties is used to check for the supported properties of individual formats. + *  pname:textureCompressionBC indicates whether the BC compressed texture formats are supported. If this feature is not enabled, the following formats mustnot: be used to create images: + -- * ename:VK_FORMAT_BC1_RGB_UNORM_BLOCK * ename:VK_FORMAT_BC1_RGB_SRGB_BLOCK * ename:VK_FORMAT_BC1_RGBA_UNORM_BLOCK * ename:VK_FORMAT_BC1_RGBA_SRGB_BLOCK * ename:VK_FORMAT_BC2_UNORM_BLOCK * ename:VK_FORMAT_BC2_SRGB_BLOCK * ename:VK_FORMAT_BC3_UNORM_BLOCK * ename:VK_FORMAT_BC3_SRGB_BLOCK * ename:VK_FORMAT_BC4_UNORM_BLOCK * ename:VK_FORMAT_BC4_SNORM_BLOCK * ename:VK_FORMAT_BC5_UNORM_BLOCK * ename:VK_FORMAT_BC5_SNORM_BLOCK * ename:VK_FORMAT_BC6H_UFLOAT_BLOCK * ename:VK_FORMAT_BC6H_SFLOAT_BLOCK * ename:VK_FORMAT_BC7_UNORM_BLOCK * ename:VK_FORMAT_BC7_SRGB_BLOCK -- + flink:vkGetPhysicalDeviceFormatProperties is used to check for the supported properties of individual formats. + *  pname:occlusionQueryPrecise indicates whether occlusion queries returning actual sample counts are supported. Occlusion queries are created in a sname:VkQueryPool by specifying the pname:queryType of ename:VK_QUERY_TYPE_OCCLUSION in the sname:VkQueryPoolCreateInfo structure which is passed to fname:vkCreateQueryPool. If this feature is enabled, queries of this type can: enable ename:VK_QUERY_CONTROL_PRECISE_BIT in the pname:flags parameter to fname:vkCmdBeginQuery. If this feature is not supported, the implementation supports only boolean occlusion queries. When any samples are passed, boolean queries will return a non-zero result value, otherwise a result value of zero is returned. When this feature is enabled and ename:VK_QUERY_CONTROL_PRECISE_BIT is set, occlusion queries will report the actual number of samples passed. * pname:pipelineStatisticsQuery indicates whether the pipeline statistics queries are supported. If this feature is not enabled, queries of type ename:VK_QUERY_TYPE_PIPELINE_STATISTICS cannot: be created, and none of the elink:VkQueryPipelineStatisticFlagBits bits can: be set in the pname:pipelineStatistics member of the sname:VkQueryPoolCreateInfo structure. * pname:vertexPipelineStoresAndAtomics indicates whether storage buffers and images support stores and atomic operations in the vertex, tessellation, and geometry shader stages. If this feature is not enabled, all storage image, storage texel buffers, and storage buffer variables used by these stages in shader modules must: be decorated with the code:NonWriteable decoration (or the code:readonly memory qualifier in GLSL). * pname:fragmentStoresAndAtomics indicates whether storage buffers and images support stores and atomic operations in the fragment shader stage. If this feature is not enabled, all storage image, storage texel buffers, and storage buffer variables used by the fragment stage in shader modules must: be decorated with the code:NonWriteable decoration (or the code:readonly memory qualifier in GLSL). * pname:shaderTessellationAndGeometryPointSize indicates whether the code:PointSize built-in decoration is available in the tessellation control, tessellation evaluation, and geometry shader stages. If this feature is not enabled, members decorated with the code:PointSize built-in decoration mustnot: be read from or written to and all points written from a tessellation or geometry shader will have a size of 1.0. This also indicates whether shader modules can: declare the code:TessellationPointSize capability for tessellation control and evaluation shaders, or if the shader modules can: declare the code:GeometryPointSize capability for geometry shaders. An implementation supporting this feature must: also support one or both of the &lt;&lt;features-features-tessellationShader,pname:tessellationShader&gt;&gt; or &lt;&lt;features-features-geometryShader,pname:geometryShader&gt;&gt; features. * pname:shaderImageGatherExtended indicates whether the extended set of image gather instructions are available in shader code. If this feature is not enabled, the code:OpImage*code:Gather instructions do not support the code:Offset and code:ConstOffsets operands. This also indicates whether shader modules can: declare the code:ImageGatherExtended capability. * pname:shaderStorageImageExtendedFormats indicates whether the extended storage image formats are available in shader code. If this feature is not enabled, the formats requiring the code:StorageImageExtendedFormats capability are not supported for storage images. This also indicates whether shader modules can: declare the code:StorageImageExtendedFormats capability. * pname:shaderStorageImageMultisample indicates whether multisampled storage images are supported. If this feature is not enabled, images that are created with a pname:usage that includes ename:VK_IMAGE_USAGE_STORAGE_BIT must: be created with pname:samples equal to ename:VK_SAMPLE_COUNT_1_BIT. This also indicates whether shader modules can: declare the code:StorageImageMultisample capability. * pname:shaderStorageImageReadWithoutFormat indicates whether storage images require a format qualifier to be specified when reading from storage images. If this feature is not enabled, the code:OpImageRead instruction mustnot: have an code:OpTypeImage of code:Unknown. This also indicates whether shader modules can: declare the code:StorageImageReadWithoutFormat capability. * pname:shaderStorageImageWriteWithoutFormat indicates whether storage images require a format qualifier to be specified when writing to storage images. If this feature is not enabled, the code:OpImageWrite instruction mustnot: have an code:OpTypeImage of code:Unknown. This also indicates whether shader modules can: declare the code:StorageImageWriteWithoutFormat capability. * pname:shaderUniformBufferArrayDynamicIndexing indicates whether arrays of uniform buffers can: be indexed by dynamically uniform integer expressions in shader code. If this feature is not enabled, resources with a descriptor type of ename:VK_DESCRIPTOR_TYPE_UNIFORM_BUFFER or ename:VK_DESCRIPTOR_TYPE_UNIFORM_BUFFER_DYNAMIC must: be indexed only by constant integral expressions when aggregated into arrays in shader code. This also indicates whether shader modules can: declare the code:UniformBufferArrayDynamicIndexing capability. * pname:shaderSampledImageArrayDynamicIndexing indicates whether arrays of samplers or sampled images can: be indexed by dynamically uniform integer expressions in shader code. If this feature is not enabled, resources with a descriptor type of ename:VK_DESCRIPTOR_TYPE_SAMPLER, ename:VK_DESCRIPTOR_TYPE_COMBINED_IMAGE_SAMPLER, or ename:VK_DESCRIPTOR_TYPE_SAMPLED_IMAGE must: be indexed only by constant integral expressions when aggregated into arrays in shader code. This also indicates whether shader modules can: declare the code:SampledImageArrayDynamicIndexing capability. * pname:shaderStorageBufferArrayDynamicIndexing indicates whether arrays of storage buffers can: be indexed by dynamically uniform integer expressions in shader code. If this feature is not enabled, resources with a descriptor type of ename:VK_DESCRIPTOR_TYPE_STORAGE_BUFFER or ename:VK_DESCRIPTOR_TYPE_STORAGE_BUFFER_DYNAMIC must: be indexed only by constant integral expressions when aggregated into arrays in shader code. This also indicates whether shader modules can: declare the code:StorageBufferArrayDynamicIndexing capability. * pname:shaderStorageImageArrayDynamicIndexing indicates whether arrays of storage images can: be indexed by dynamically uniform integer expressions in shader code. If this feature is not enabled, resources with a descriptor type of ename:VK_DESCRIPTOR_TYPE_STORAGE_IMAGE must: be indexed only by constant integral expressions when aggregated into arrays in shader code. This also indicates whether shader modules can: declare the code:StorageImageArrayDynamicIndexing capability. *  pname:shaderClipDistance indicates whether clip distances are supported in shader code. If this feature is not enabled, any members decorated with the code:ClipDistance built-in decoration mustnot: be read from or written to in shader modules. This also indicates whether shader modules can: declare the code:ClipDistance capability. *  pname:shaderCullDistance indicates whether cull distances are supported in shader code. If this feature is not enabled, any members decorated with the code:CullDistance built-in decoration mustnot: be read from or written to in shader modules. This also indicates whether shader modules can: declare the code:CullDistance capability. *  pname:shaderFloat64 indicates whether 64-bit floats (doubles) are supported in shader code. If this feature is not enabled, 64-bit floating-point types mustnot: be used in shader code. This also indicates whether shader modules can: declare the code:Float64 capability. *  pname:shaderInt64 indicates whether 64-bit integers (signed and unsigned) are supported in shader code. If this feature is not enabled, 64-bit integer types mustnot: be used in shader code. This also indicates whether shader modules can: declare the code:Int64 capability. *  pname:shaderInt16 indicates whether 16-bit integers (signed and unsigned) are supported in shader code. If this feature is not enabled, 16-bit integer types mustnot: be used in shader code. This also indicates whether shader modules can: declare the code:Int16 capability. * pname:shaderResourceResidency indicates whether image operations that return resource residency information are supported in shader code. If this feature is not enabled, the code:OpImageSparse* instructions mustnot: be used in shader code. This also indicates whether shader modules can: declare the code:SparseResidency capability. The feature requires at least one of the ptext:sparseResidency* features to be supported. *  pname:shaderResourceMinLod indicates whether image operations that specify the minimum resource level-of-detail (LOD) are supported in shader code. If this feature is not enabled, the code:MinLod image operand mustnot: be used in shader code. This also indicates whether shader modules can: declare the code:MinLod capability. *  pname:sparseBinding indicates whether resource memory can: be managed at opaque sparse block level instead of at the object level. If this feature is not enabled, resource memory must: be bound only on a per-object basis using the fname:vkBindBufferMemory and fname:vkBindImageMemory commands. In this case, buffers and images mustnot: be created with ename:VK_BUFFER_CREATE_SPARSE_BINDING_BIT and ename:VK_IMAGE_CREATE_SPARSE_BINDING_BIT set in the pname:flags member of the sname:VkBufferCreateInfo and sname:VkImageCreateInfo structures, respectively. Otherwise resource memory can: be managed as described in &lt;&lt;sparsememory-sparseresourcefeatures,Sparse Resource Features&gt;&gt;. *  pname:sparseResidencyBuffer indicates whether the device can: access partially resident buffers. If this feature is not enabled, buffers mustnot: be created with ename:VK_BUFFER_CREATE_SPARSE_RESIDENCY_BIT set in the pname:flags member of the sname:VkBufferCreateInfo structure. * pname:sparseResidencyImage2D indicates whether the device can: access partially resident 2D images with 1 sample per pixel. If this feature is not enabled, images with an pname:imageType of ename:VK_IMAGE_TYPE_2D and pname:samples set to ename:VK_SAMPLE_COUNT_1_BIT mustnot: be created with ename:VK_IMAGE_CREATE_SPARSE_RESIDENCY_BIT set in the pname:flags member of the sname:VkImageCreateInfo structure. * pname:sparseResidencyImage3D indicates whether the device can: access partially resident 3D images. If this feature is not enabled, images with an pname:imageType of ename:VK_IMAGE_TYPE_3D mustnot: be created with ename:VK_IMAGE_CREATE_SPARSE_RESIDENCY_BIT set in the pname:flags member of the sname:VkImageCreateInfo structure. * pname:sparseResidency2Samples indicates whether the physical device can: access partially resident 2D images with 2 samples per pixel. If this feature is not enabled, images with an pname:imageType of ename:VK_IMAGE_TYPE_2D and pname:samples set to ename:VK_SAMPLE_COUNT_2_BIT mustnot: be created with ename:VK_IMAGE_CREATE_SPARSE_RESIDENCY_BIT set in the pname:flags member of the sname:VkImageCreateInfo structure. * pname:sparseResidency4Samples indicates whether the physical device can: access partially resident 2D images with 4 samples per pixel. If this feature is not enabled, images with an pname:imageType of ename:VK_IMAGE_TYPE_2D and pname:samples set to ename:VK_SAMPLE_COUNT_4_BIT mustnot: be created with ename:VK_IMAGE_CREATE_SPARSE_RESIDENCY_BIT set in the pname:flags member of the sname:VkImageCreateInfo structure. * pname:sparseResidency8Samples indicates whether the physical device can: access partially resident 2D images with 8 samples per pixel. If this feature is not enabled, images with an pname:imageType of ename:VK_IMAGE_TYPE_2D and pname:samples set to ename:VK_SAMPLE_COUNT_8_BIT mustnot: be created with ename:VK_IMAGE_CREATE_SPARSE_RESIDENCY_BIT set in the pname:flags member of the sname:VkImageCreateInfo structure. * pname:sparseResidency16Samples indicates whether the physical device can: access partially resident 2D images with 16 samples per pixel. If this feature is not enabled, images with an pname:imageType of ename:VK_IMAGE_TYPE_2D and pname:samples set to ename:VK_SAMPLE_COUNT_16_BIT mustnot: be created with ename:VK_IMAGE_CREATE_SPARSE_RESIDENCY_BIT set in the pname:flags member of the sname:VkImageCreateInfo structure. * pname:sparseResidencyAliased indicates whether the physical device can: correctly access data aliased into multiple locations. If this feature is not enabled, the ename:VK_BUFFER_CREATE_SPARSE_ALIASED_BIT and ename:VK_IMAGE_CREATE_SPARSE_ALIASED_BIT enum values mustnot: be used in pname:flags members of the sname:VkBufferCreateInfo and sname:VkImageCreateInfo structures, respectively. * pname:variableMultisampleRate indicates whether all pipelines that will be bound to a command buffer during a subpass with no attachments must: have the same value for sname:VkPipelineMultisampleStateCreateInfo::pname:rasterizationSamples. If set to ename:VK_TRUE, the implementation supports variable multisample rates in a subpass with no attachments. If set to ename:VK_FALSE, then all pipelines bound in such a subpass must: have the same multisample rate. This has no effect in situations where a subpass uses any attachments. *  pname:inheritedQueries indicates whether a secondary command buffer may: be executed while a query is active.
	/// </para>
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
	public partial struct PhysicalDeviceFeatures
	{
	   /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		public Bool32 RobustBufferAccess;

	   /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		public Bool32 FullDrawIndexUint32;

	   /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		public Bool32 ImageCubeArray;

	   /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		public Bool32 IndependentBlend;

	   /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		public Bool32 GeometryShader;

	   /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		public Bool32 TessellationShader;

	   /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		public Bool32 SampleRateShading;

	   /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		public Bool32 DualSourceBlend;

	   /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		public Bool32 LogicOp;

	   /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		public Bool32 MultiDrawIndirect;

	   /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		public Bool32 DrawIndirectFirstInstance;

	   /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		public Bool32 DepthClamp;

	   /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		public Bool32 DepthBiasClamp;

	   /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		public Bool32 FillModeNonSolid;

	   /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		public Bool32 DepthBounds;

	   /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		public Bool32 WideLines;

	   /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		public Bool32 LargePoints;

	   /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		public Bool32 AlphaToOne;

	   /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		public Bool32 MultiViewport;

	   /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		public Bool32 SamplerAnisotropy;

	   /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		public Bool32 TextureCompressionETC2;

	   /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		public Bool32 TextureCompressionASTC_LDR;

	   /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		public Bool32 TextureCompressionBC;

	   /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		public Bool32 OcclusionQueryPrecise;

	   /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		public Bool32 PipelineStatisticsQuery;

	   /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		public Bool32 VertexPipelineStoresAndAtomics;

	   /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		public Bool32 FragmentStoresAndAtomics;

	   /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		public Bool32 ShaderTessellationAndGeometryPointSize;

	   /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		public Bool32 ShaderImageGatherExtended;

	   /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		public Bool32 ShaderStorageImageExtendedFormats;

	   /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		public Bool32 ShaderStorageImageMultisample;

	   /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		public Bool32 ShaderStorageImageReadWithoutFormat;

	   /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		public Bool32 ShaderStorageImageWriteWithoutFormat;

	   /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		public Bool32 ShaderUniformBufferArrayDynamicIndexing;

	   /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		public Bool32 ShaderSampledImageArrayDynamicIndexing;

	   /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		public Bool32 ShaderStorageBufferArrayDynamicIndexing;

	   /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		public Bool32 ShaderStorageImageArrayDynamicIndexing;

	   /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		public Bool32 ShaderClipDistance;

	   /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		public Bool32 ShaderCullDistance;

	   /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		public Bool32 ShaderFloat64;

	   /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		public Bool32 ShaderInt64;

	   /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		public Bool32 ShaderInt16;

	   /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		public Bool32 ShaderResourceResidency;

	   /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		public Bool32 ShaderResourceMinLod;

	   /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		public Bool32 SparseBinding;

	   /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		public Bool32 SparseResidencyBuffer;

	   /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		public Bool32 SparseResidencyImage2D;

	   /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		public Bool32 SparseResidencyImage3D;

	   /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		public Bool32 SparseResidency2Samples;

	   /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		public Bool32 SparseResidency4Samples;

	   /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		public Bool32 SparseResidency8Samples;

	   /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		public Bool32 SparseResidency16Samples;

	   /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		public Bool32 SparseResidencyAliased;

	   /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		public Bool32 VariableMultisampleRate;

	   /// <summary>
		/// <para>
		/// -
		/// </para>
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
	/// <para>
    /// Structure specifying physical device sparse memory properties
	/// </para>
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
	public partial struct PhysicalDeviceSparseProperties
	{
	   /// <summary>
		/// <para>
		/// pname:residencyStandard2DBlockShape is ename:VK_TRUE if the physical device will access all single-sample 2D sparse resources using the standard sparse image block shapes (based on image format), as described in the &lt;&lt;sparsememory-sparseblockshapessingle,Standard Sparse Image Block Shapes (Single Sample)&gt;&gt; table. If this property is not supported the value returned in the pname:imageGranularity member of the sname:VkSparseImageFormatProperties structure for single-sample 2D images is not required: to match the standard sparse image block dimensions listed in the table.
		/// </para>
		/// </summary>
		public Bool32 ResidencyStandard2DBlockShape;

	   /// <summary>
		/// <para>
		/// pname:residencyStandard2DMultisampleBlockShape is ename:VK_TRUE if the physical device will access all multisample 2D sparse resources using the standard sparse image block shapes (based on image format), as described in the &lt;&lt;sparsememory-sparseblockshapesmsaa,Standard Sparse Image Block Shapes (MSAA)&gt;&gt; table. If this property is not supported, the value returned in the pname:imageGranularity member of the sname:VkSparseImageFormatProperties structure for multisample 2D images is not required: to match the standard sparse image block dimensions listed in the table.
		/// </para>
		/// </summary>
		public Bool32 ResidencyStandard2DMultisampleBlockShape;

	   /// <summary>
		/// <para>
		/// pname:residencyStandard3DBlockShape is ename:VK_TRUE if the physical device will access all 3D sparse resources using the standard sparse image block shapes (based on image format), as described in the &lt;&lt;sparsememory-sparseblockshapessingle,Standard Sparse Image Block Shapes (Single Sample)&gt;&gt; table. If this property is not supported, the value returned in the pname:imageGranularity member of the sname:VkSparseImageFormatProperties structure for 3D images is not required: to match the standard sparse image block dimensions listed in the table.
		/// </para>
		/// </summary>
		public Bool32 ResidencyStandard3DBlockShape;

	   /// <summary>
		/// <para>
		/// pname:residencyAlignedMipSize is ename:VK_TRUE if images with mip level dimensions that are not integer multiples of the corresponding dimensions of the sparse image block may: be placed in the mip tail. If this property is not reported, only mip levels with dimensions smaller than the pname:imageGranularity member of the sname:VkSparseImageFormatProperties structure will be placed in the mip tail. If this property is reported the implementation is allowed to return ename:VK_SPARSE_IMAGE_FORMAT_ALIGNED_MIP_SIZE_BIT in the pname:flags member of sname:VkSparseImageFormatProperties, indicating that mip level dimensions that are not integer multiples of the corresponding dimensions of the sparse image block will be placed in the mip tail.
		/// </para>
		/// </summary>
		public Bool32 ResidencyAlignedMipSize;

	   /// <summary>
		/// <para>
		/// pname:residencyNonResidentStrict specifies whether the physical device can: consistently access non-resident regions of a resource. If this property is ename:VK_TRUE, access to non-resident regions of resources will be guaranteed to return values as if the resource were populated with 0; writes to non-resident regions will be discarded.
		/// </para>
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
	/// <para>
    /// Structure specifying a pipeline color blend attachment state
	/// </para>
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
	public partial struct PipelineColorBlendAttachmentState
	{
	   /// <summary>
		/// <para>
		/// pname:blendEnable controls whether blending is enabled for the corresponding color attachment. If blending is not enabled, the source fragment's color for that attachment is passed through unmodified.
		/// </para>
		/// </summary>
		public Bool32 BlendEnable;

	   /// <summary>
		/// <para>
		/// pname:srcColorBlendFactor selects which blend factor is used to determine the source factors latexmath:[$S_r,S_g,S_b$].
		/// </para>
		/// </summary>
		public BlendFactor SourceColorBlendFactor;

	   /// <summary>
		/// <para>
		/// pname:dstColorBlendFactor selects which blend factor is used to determine the destination factors latexmath:[$D_r,D_g,D_b$].
		/// </para>
		/// </summary>
		public BlendFactor DestinationColorBlendFactor;

	   /// <summary>
		/// <para>
		/// pname:colorBlendOp selects which blend operation is used to calculate the RGB values to write to the color attachment.
		/// </para>
		/// </summary>
		public BlendOp ColorBlendOp;

	   /// <summary>
		/// <para>
		/// pname:srcAlphaBlendFactor selects which blend factor is used to determine the source factor latexmath:[$S_a$].
		/// </para>
		/// </summary>
		public BlendFactor SourceAlphaBlendFactor;

	   /// <summary>
		/// <para>
		/// pname:dstAlphaBlendFactor selects which blend factor is used to determine the destination factor latexmath:[$D_a$].
		/// </para>
		/// </summary>
		public BlendFactor DestinationAlphaBlendFactor;

	   /// <summary>
		/// <para>
		/// pname:alphaBlendOp selects which blend operation is use to calculate the alpha values to write to the color attachment.
		/// </para>
		/// </summary>
		public BlendOp AlphaBlendOp;

	   /// <summary>
		/// <para>
		/// pname:colorWriteMask is a bitmask selecting which of the R, G, B, and/or A components are enabled for writing, as described later in this chapter.
		/// </para>
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
	/// <para>
    /// Structure specifying a push constant range
	/// </para>
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
	public partial struct PushConstantRange
	{
	   /// <summary>
		/// <para>
		/// pname:stageFlags is a set of stage flags describing the shader stages that will access a range of push constants. If a particular stage is not included in the range, then accessing members of that range of push constants from the corresponding shader stage will result in undefined data being read.
		/// </para>
		/// </summary>
		public ShaderStageFlags StageFlags;

	   /// <summary>
		/// <para>
		/// pname:offset and pname:size are the start offset and size, respectively, consumed by the range. Both pname:offset and pname:size are in units of bytes and must: be a multiple of 4. The layout of the push constant variables is specified in the shader.
		/// </para>
		/// </summary>
		public uint Offset;

	   /// <summary>
		/// <para>
		/// -
		/// </para>
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
	/// <para>
    /// Structure providing information about a queue family.
	/// </para>
	/// <para>
    /// The bits specified in pname:queueFlags are:
	/// </para>
	/// <para>
    /// * if ename:VK_QUEUE_GRAPHICS_BIT is set, then the queues in this queue family support graphics operations. * if ename:VK_QUEUE_COMPUTE_BIT is set, then the queues in this queue family support compute operations. * if ename:VK_QUEUE_TRANSFER_BIT is set, then the queues in this queue family support transfer operations. * if ename:VK_QUEUE_SPARSE_BINDING_BIT is set, then the queues in this queue family support sparse memory management operations (see &lt;&lt;sparsememory,Sparse Resources&gt;&gt;). If any of the sparse resource features are enabled, then at least one queue family must: support this bit.
	/// </para>
	/// <para>
    /// If an implementation exposes any queue family that supports graphics operations, at least one queue family of at least one physical device exposed by the implementation must: support both graphics and compute operations.
	/// </para>
	/// <para>
    /// [NOTE] .Note ==== All commands that are allowed on a queue that supports transfer operations are also allowed on a queue that supports either graphics or compute operations thus if the capabilities of a queue family include ename:VK_QUEUE_GRAPHICS_BIT or ename:VK_QUEUE_COMPUTE_BIT then reporting the ename:VK_QUEUE_TRANSFER_BIT capability separately for that queue family is optional:. ====
	/// </para>
	/// <para>
    /// For further details see &lt;&lt;devsandqueues-queues,Queues&gt;&gt;.
	/// </para>
	/// <para>
    /// The value returned in pname:minImageTransferGranularity has a unit of compressed texel blocks for images having a block-compressed format, and a unit of texels otherwise.
	/// </para>
	/// <para>
    /// Possible values of pname:minImageTransferGranularity are:
	/// </para>
	/// <para>
    /// * latexmath:[$(0,0,0)$] which indicates that only whole mip levels must: be transferred using the image transfer operations on the corresponding queues. In this case, the following restrictions apply to all offset and extent parameters of image transfer operations:
	/// </para>
	/// <para>
    /// ** The pname:x, pname:y, and pname:z members of a slink:VkOffset3D parameter must: always be zero. ** The pname:width, pname:height, and pname:depth members of a slink:VkExtent3D parameter must: always match the width, height, and depth of the image subresource corresponding to the parameter, respectively.
	/// </para>
	/// <para>
    /// * latexmath:[$(Ax, Ay, Az)$] where latexmath:[$Ax$], latexmath:[$Ay$], and latexmath:[$Az$] are all integer powers of two. In this case the following restrictions apply to all image transfer operations:
	/// </para>
	/// <para>
    /// ** pname:x, pname:y, and pname:z of a slink:VkOffset3D parameter must: be integer multiples of latexmath:[$Ax$], latexmath:[$Ay$], and latexmath:[$Az$], respectively. ** pname:width of a slink:VkExtent3D parameter must: be an integer multiple of latexmath:[$Ax$], or else latexmath:[$(x + width)$] must: equal the width of the image subresource corresponding to the parameter. ** pname:height of a slink:VkExtent3D parameter must: be an integer multiple of latexmath:[$Ay$], or else latexmath:[$(y + height)$] must: equal the height of the image subresource corresponding to the parameter. ** pname:depth of a slink:VkExtent3D parameter must: be an integer multiple of latexmath:[$Az$], or else latexmath:[$(z + depth)$] must: equal the depth of the image subresource corresponding to the parameter. ** If the format of the image corresponding to the parameters is one of the block-compressed formats then for the purposes of the above calculations the granularity must: be scaled up by the compressed texel block dimensions.
	/// </para>
	/// <para>
    /// Queues supporting graphics and/or compute operations must: report latexmath:[$(1,1,1)$] in pname:minImageTransferGranularity, meaning that there are no additional restrictions on the granularity of image transfer operations for these queues. Other queues supporting image transfer operations are only required: to support whole mip level transfers, thus pname:minImageTransferGranularity for queues belonging to such queue families may: be latexmath:[$(0,0,0)$].
	/// </para>
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
	public partial struct QueueFamilyProperties
	{
	   /// <summary>
		/// <para>
		/// pname:queueFlags contains flags indicating the capabilities of the queues in this queue family.
		/// </para>
		/// </summary>
		public QueueFlags QueueFlags;

	   /// <summary>
		/// <para>
		/// pname:queueCount is the unsigned integer count of queues in this queue family.
		/// </para>
		/// </summary>
		public uint QueueCount;

	   /// <summary>
		/// <para>
		/// pname:timestampValidBits is the unsigned integer count of meaningful bits in the timestamps written via fname:vkCmdWriteTimestamp. The valid range for the count is 36..64 bits, or a value of 0, indicating no support for timestamps. Bits outside the valid range are guaranteed to be zeros.
		/// </para>
		/// </summary>
		public uint TimestampValidBits;

	   /// <summary>
		/// <para>
		/// pname:minImageTransferGranularity is the minimum granularity supported for image transfer operations on the queues in this queue family.
		/// </para>
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
	/// <para>
    /// Structure specifying a two-dimensional subregion
	/// </para>
	/// <para>
    /// Rectangles are used to describe a specified rectangular region of pixels within an image or framebuffer. Rectangles include both an offset and an extent of the same dimensionality, as described above. Two-dimensional rectangles are defined by the structure
	/// </para>
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
	public partial struct Rect2D
	{
	   /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		public Offset2D Offset;

	   /// <summary>
		/// <para>
		/// -
		/// </para>
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
	/// <para>
    /// Structure specifying sparse image format properties
	/// </para>
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
	public partial struct SparseImageFormatProperties
	{
	   /// <summary>
		/// <para>
		/// pname:aspectMask is a bitmask of elink:VkImageAspectFlagBits specifying which aspects of the image the properties apply to.
		/// </para>
		/// </summary>
		public ImageAspectFlags AspectMask;

	   /// <summary>
		/// <para>
		/// pname:imageGranularity is the width, height, and depth of the sparse image block in texels or compressed texel blocks.
		/// </para>
		/// </summary>
		public Extent3D ImageGranularity;

	   /// <summary>
		/// <para>
		/// pname:flags is a bitmask specifying additional information about the sparse resource. Bits which can: be set include: + -- // refBegin VkSparseImageFormatFlagBits - Bitmask specifying additional information about a sparse image resource include::../api/enums/VkSparseImageFormatFlagBits.txt[] --
		/// </para>
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
	/// <para>
    /// Structure specifying sparse image memory requirements
	/// </para>
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
	public partial struct SparseImageMemoryRequirements
	{
	   /// <summary>
		/// <para>
		/// pname:formatProperties.flags is a bitmask of elink:VkSparseImageFormatFlagBits:
		/// </para>
		/// </summary>
		public SparseImageFormatProperties FormatProperties;

	   /// <summary>
		/// <para>
		/// pname:imageMipTailFirstLod is the first mip level at which image subresources are included in the mip tail region.
		/// </para>
		/// </summary>
		public uint ImageMipTailFirstLod;

	   /// <summary>
		/// <para>
		/// pname:imageMipTailSize is the memory size (in bytes) of the mip tail region. If pname:formatProperties.flags contains ename:VK_SPARSE_IMAGE_FORMAT_SINGLE_MIPTAIL_BIT, this is the size of the whole mip tail, otherwise this is the size of the mip tail of a single array layer. This value is guaranteed to be a multiple of the sparse block size in bytes.
		/// </para>
		/// </summary>
		public DeviceSize ImageMipTailSize;

	   /// <summary>
		/// <para>
		/// pname:imageMipTailOffset is the opaque memory offset used with slink:VkSparseImageOpaqueMemoryBindInfo to bind the mip tail region(s).
		/// </para>
		/// </summary>
		public DeviceSize ImageMipTailOffset;

	   /// <summary>
		/// <para>
		/// pname:imageMipTailStride is the offset stride between each array-layer's mip tail, if pname:formatProperties.flags does not contain ename:VK_SPARSE_IMAGE_FORMAT_SINGLE_MIPTAIL_BIT (otherwise the value is undefined).
		/// </para>
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
	/// <para>
    /// Structure specifying a specialization map entry
	/// </para>
	/// <para>
    /// If a pname:constantID value is not a specialization constant ID used in the shader, that map entry does not affect the behavior of the pipeline.
	/// </para>
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
	public partial struct SpecializationMapEntry
	{
	   /// <summary>
		/// <para>
		/// pname:constantID is the ID of the specialization constant in SPIR-V.
		/// </para>
		/// </summary>
		public uint ConstantID;

	   /// <summary>
		/// <para>
		/// pname:offset is the byte offset of the specialization constant value within the supplied data buffer.
		/// </para>
		/// </summary>
		public uint Offset;

	   /// <summary>
		/// <para>
		/// pname:size is the byte size of the specialization constant value within the supplied data buffer.
		/// </para>
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
	/// <para>
    /// Structure specifying stencil operation state
	/// </para>
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
	public partial struct StencilOpState
	{
	   /// <summary>
		/// <para>
		/// pname:failOp is the action performed on samples that fail the stencil test.
		/// </para>
		/// </summary>
		public StencilOp FailOp;

	   /// <summary>
		/// <para>
		/// pname:passOp is the action performed on samples that pass both the depth and stencil tests.
		/// </para>
		/// </summary>
		public StencilOp PassOp;

	   /// <summary>
		/// <para>
		/// pname:depthFailOp is the action performed on samples that pass the stencil test and fail the depth test.
		/// </para>
		/// </summary>
		public StencilOp DepthFailOp;

	   /// <summary>
		/// <para>
		/// pname:compareOp is the comparison operator used in the stencil test.
		/// </para>
		/// </summary>
		public CompareOp CompareOp;

	   /// <summary>
		/// <para>
		/// pname:compareMask selects the bits of the unsigned integer stencil values participating in the stencil test.
		/// </para>
		/// </summary>
		public uint CompareMask;

	   /// <summary>
		/// <para>
		/// pname:writeMask selects the bits of the unsigned integer stencil values updated by the stencil test in the stencil framebuffer attachment.
		/// </para>
		/// </summary>
		public uint WriteMask;

	   /// <summary>
		/// <para>
		/// pname:reference is an integer reference value that is used in the unsigned stencil comparison.
		/// </para>
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
	/// <para>
    /// Structure specifying a subpass dependency
	/// </para>
	/// <para>
    /// Each subpass dependency defines an execution and memory dependency between two sets of commands, with the second set depending on the first set. When pname:srcSubpass does not equal pname:dstSubpass then the first set of commands is:
	/// </para>
	/// <para>
    /// * All commands in the subpass indicated by pname:srcSubpass, if pname:srcSubpass is not ename:VK_SUBPASS_EXTERNAL. * All commands before the render pass instance, if pname:srcSubpass is ename:VK_SUBPASS_EXTERNAL.
	/// </para>
	/// <para>
    /// While the corresponding second set of commands is:
	/// </para>
	/// <para>
    /// * All commands in the subpass indicated by pname:dstSubpass, if pname:dstSubpass is not ename:VK_SUBPASS_EXTERNAL. * All commands after the render pass instance, if pname:dstSubpass is ename:VK_SUBPASS_EXTERNAL.
	/// </para>
	/// <para>
    /// When pname:srcSubpass equals pname:dstSubpass then the first set consists of commands in the subpass before a call to flink:vkCmdPipelineBarrier and the second set consists of commands in the subpass following that same call as described in the &lt;&lt;synchronization-pipeline-barriers-subpass-self-dependencies, Subpass Self-dependency&gt;&gt; section.
	/// </para>
	/// <para>
    /// The pname:srcStageMask, pname:dstStageMask, pname:srcAccessMask, pname:dstAccessMask, and pname:dependencyFlags parameters of the dependency are interpreted the same way as for other dependencies, as described in &lt;&lt;synchronization, Synchronization and Cache Control&gt;&gt;.
	/// </para>
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
	public partial struct SubpassDependency
	{
	   /// <summary>
		/// <para>
		/// pname:srcSubpass and pname:dstSubpass are the subpass indices of the producer and consumer subpasses, respectively. pname:srcSubpass and pname:dstSubpass can: also have the special value ename:VK_SUBPASS_EXTERNAL. The source subpass must: always be a lower numbered subpass than the destination subpass (excluding external subpasses and &lt;&lt;synchronization-pipeline-barriers-subpass-self-dependencies, self-dependencies&gt;&gt;), so that the order of subpass descriptions is a valid execution ordering, avoiding cycles in the dependency graph.
		/// </para>
		/// </summary>
		public uint SourceSubpass;

	   /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		public uint DestinationSubpass;

	   /// <summary>
		/// <para>
		/// pname:srcStageMask, pname:dstStageMask, pname:srcAccessMask, pname:dstAccessMask, and pname:dependencyFlags describe an &lt;&lt;synchronization-execution-and-memory-dependencies,execution and memory dependency&gt;&gt; between subpasses. The bits that can: be included in pname:dependencyFlags are: + -- // refBegin VkDependencyFlagBits - Bitmask specifying dependencies between subpasses include::../api/enums/VkDependencyFlagBits.txt[] --
		/// </para>
		/// </summary>
		public PipelineStageFlags SourceStageMask;

	   /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		public PipelineStageFlags DestinationStageMask;

	   /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		public AccessFlags SourceAccessMask;

	   /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		public AccessFlags DestinationAccessMask;

	   /// <summary>
		/// <para>
		/// -
		/// </para>
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
	/// <para>
    /// Structure specifying subresource layout
	/// </para>
	/// <para>
    /// For images created with linear tiling, pname:rowPitch, pname:arrayPitch and pname:depthPitch describe the layout of the image subresource in linear memory. For uncompressed formats, pname:rowPitch is the number of bytes between texels with the same x coordinate in adjacent rows (y coordinates differ by one). pname:arrayPitch is the number of bytes between texels with the same x and y coordinate in adjacent array layers of the image (array layer values differ by one). pname:depthPitch is the number of bytes between texels with the same x and y coordinate in adjacent slices of a 3D image (z coordinates differ by one). Expressed as an addressing formula, the starting byte of a texel in the image subresource has address:
	/// </para>
	/// <para>
    /// [source,c] --------------------------------------------------- // (x,y,z,layer) are in texel coordinates address(x,y,z,layer) = layer*arrayPitch + z*depthPitch + y*rowPitch + x*texelSize + offset ---------------------------------------------------
	/// </para>
	/// <para>
    /// For compressed formats, the pname:rowPitch is the number of bytes between compressed texel blocks in adjacent rows. pname:arrayPitch is the number of bytes between compressed texel blocks in adjacent array layers. pname:depthPitch is the number of bytes between compressed texel blocks in adjacent slices of a 3D image.
	/// </para>
	/// <para>
    /// [source,c] --------------------------------------------------- // (x,y,z,layer) are in compressed texel block coordinates address(x,y,z,layer) = layer*arrayPitch + z*depthPitch + y*rowPitch + x*compressedTexelBlockByteSize + offset; ---------------------------------------------------
	/// </para>
	/// <para>
    /// pname:arrayPitch is undefined for images that were not created as arrays. pname:depthPitch is defined only for 3D images.
	/// </para>
	/// <para>
    /// For color formats, the pname:aspectMask member of sname:VkImageSubresource must: be ename:VK_IMAGE_ASPECT_COLOR_BIT. For depth/stencil formats, pname:aspectMask must: be either ename:VK_IMAGE_ASPECT_DEPTH_BIT or ename:VK_IMAGE_ASPECT_STENCIL_BIT. On implementations that store depth and stencil aspects separately, querying each of these image subresource layouts will return a different pname:offset and pname:size representing the region of memory used for that aspect. On implementations that store depth and stencil aspects interleaved, the same pname:offset and pname:size are returned and represent the interleaved memory allocation.
	/// </para>
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
	public partial struct SubresourceLayout
	{
	   /// <summary>
		/// <para>
		/// pname:offset is the byte offset from the start of the image where the image subresource begins.
		/// </para>
		/// </summary>
		public DeviceSize Offset;

	   /// <summary>
		/// <para>
		/// pname:size is the size in bytes of the image subresource. pname:size includes any extra memory that is required based on pname:rowPitch.
		/// </para>
		/// </summary>
		public DeviceSize Size;

	   /// <summary>
		/// <para>
		/// pname:rowPitch describes the number of bytes between each row of texels in an image.
		/// </para>
		/// </summary>
		public DeviceSize RowPitch;

	   /// <summary>
		/// <para>
		/// pname:arrayPitch describes the number of bytes between each array layer of an image.
		/// </para>
		/// </summary>
		public DeviceSize ArrayPitch;

	   /// <summary>
		/// <para>
		/// pname:depthPitch describes the number of bytes between each slice of 3D image.
		/// </para>
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
	/// <para>
    /// -
	/// </para>
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
	public partial struct SurfaceCapabilities
	{
	   /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		public uint MinImageCount;

	   /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		public uint MaxImageCount;

	   /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		public Extent2D CurrentExtent;

	   /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		public Extent2D MinImageExtent;

	   /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		public Extent2D MaxImageExtent;

	   /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		public uint MaxImageArrayLayers;

	   /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		public SurfaceTransformFlags SupportedTransforms;

	   /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		public SurfaceTransformFlags CurrentTransform;

	   /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		public CompositeAlphaFlags SupportedCompositeAlpha;

	   /// <summary>
		/// <para>
		/// -
		/// </para>
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
	/// <para>
    /// -
	/// </para>
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
	public partial struct SurfaceFormat
	{
	   /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		public Format Format;

	   /// <summary>
		/// <para>
		/// -
		/// </para>
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
	/// <para>
    /// Structure specifying vertex input attribute description
	/// </para>
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
	public partial struct VertexInputAttributeDescription
	{
	   /// <summary>
		/// <para>
		/// pname:location is the shader binding location number for this attribute.
		/// </para>
		/// </summary>
		public uint Location;

	   /// <summary>
		/// <para>
		/// pname:binding is the binding number which this attribute takes its data from.
		/// </para>
		/// </summary>
		public uint Binding;

	   /// <summary>
		/// <para>
		/// pname:format is the size and type of the vertex attribute data.
		/// </para>
		/// </summary>
		public Format Format;

	   /// <summary>
		/// <para>
		/// pname:offset is a byte offset of this attribute relative to the start of an element in the vertex input binding.
		/// </para>
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
	/// <para>
    /// Structure specifying vertex input binding description
	/// </para>
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
	public partial struct VertexInputBindingDescription
	{
	   /// <summary>
		/// <para>
		/// pname:binding is the binding number that this structure describes.
		/// </para>
		/// </summary>
		public uint Binding;

	   /// <summary>
		/// <para>
		/// pname:stride is the distance in bytes between two consecutive elements within the buffer.
		/// </para>
		/// </summary>
		public uint Stride;

	   /// <summary>
		/// <para>
		/// pname:inputRate specifies whether vertex attribute addressing is a function of the vertex index or of the instance index. Possible values include: + -- // refBegin VkVertexInputRate - specify rate at which vertex attributes are pulled from buffers include::../api/enums/VkVertexInputRate.txt[] --
		/// </para>
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
	/// <para>
    /// Structure specifying a viewport
	/// </para>
	/// <para>
    /// The framebuffer depth coordinate latexmath:[$z_f$] may: be represented using either a fixed-point or floating-point representation. However, a floating-point representation must: be used if the depth/stencil attachment has a floating-point depth component. If an latexmath:[$m$]-bit fixed-point representation is used, we assume that it represents each value latexmath:[$\frac{k}{2^m - 1}$], where latexmath:[$k \in \{ 0,1, \ldots, 2^m-1 \}$], as latexmath:[$k$] (e.g. 1.0 is represented in binary as a string of all ones).
	/// </para>
	/// <para>
    /// The viewport parameters shown in the above equations are found from these values as
	/// </para>
	/// <para>
    /// [latexmath] ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++ \begin{align*} o_x &amp; = x + \frac{width}{2} \\ o_y &amp; = y + \frac{height}{2} \\ o_z &amp; = minDepth \\ p_x &amp; = width \\ p_y &amp; = height \\ p_z &amp; = maxDepth - minDepth. \end{align*} ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
	/// </para>
	/// <para>
    /// The width and height of the &lt;&lt;features-limits-maxViewportDimensions, implementation-dependent maximum viewport dimensions&gt;&gt; must: be greater than or equal to the width and height of the largest image which can: be created and attached to a framebuffer.
	/// </para>
	/// <para>
    /// The floating-point viewport bounds are represented with an &lt;&lt;features-limits-viewportSubPixelBits,implementation-dependent precision&gt;&gt;.
	/// </para>
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
	public partial struct Viewport
	{
	   /// <summary>
		/// <para>
		/// pname:x and pname:y are the viewport's upper left corner latexmath:[$(x,y)$].
		/// </para>
		/// </summary>
		public float X;

	   /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		public float Y;

	   /// <summary>
		/// <para>
		/// pname:width and pname:height are the viewport's width and height, respectively.
		/// </para>
		/// </summary>
		public float Width;

	   /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		public float Height;

	   /// <summary>
		/// <para>
		/// pname:minDepth and pname:maxDepth are the depth range for the viewport. It is valid for pname:minDepth to be greater than or equal to pname:maxDepth.
		/// </para>
		/// </summary>
		public float MinDepth;

	   /// <summary>
		/// <para>
		/// -
		/// </para>
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