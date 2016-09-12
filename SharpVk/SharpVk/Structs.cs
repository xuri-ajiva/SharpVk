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
	[StructLayout(LayoutKind.Sequential)]
	public struct SECURITY_ATTRIBUTES
	{
		/// <summary>
		/// -
		/// </summary>
		public int nLength;

		/// <summary>
		/// -
		/// </summary>
		public IntPtr lpSecurityDescriptor;

		/// <summary>
		/// -
		/// </summary>
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
	
	/// <summary>
	/// -
	/// </summary>
	public struct Size
	{
		private UIntPtr value;
		
		/// <summary>
		/// -
		/// </summary>
		public static implicit operator Size(int value)
		{
			return new Size { value = (UIntPtr)value };
        }

        /// <summary>
        /// -
        /// </summary>
        public static implicit operator Size(uint value)
        {
            return new Size { value = (UIntPtr)value };
        }

        /// <summary>
        /// -
        /// </summary>
        public static implicit operator Size(ulong value)
		{
			return new Size { value = (UIntPtr)value };
        }
        
        /// <summary>
        /// -
        /// </summary>
        public static explicit operator uint(Size size)
        {
            return size.value.ToUInt32();
        }

        /// <summary>
        /// -
        /// </summary>
        public static explicit operator ulong(Size size)
		{
			return size.value.ToUInt64();
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
    /// Structure specifying an attachment description.
	/// </para>
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
	public partial struct AttachmentDescription
	{
	   /// <summary>
		/// <para>
		/// pname:flags is a bitmask describing additional properties of the attachment. Bits which can: be set include: + --
		/// </para>
		/// </summary>
		public AttachmentDescriptionFlags Flags;

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
		public SampleCountFlags Samples;

	   /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		public AttachmentLoadOp LoadOp;

	   /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		public AttachmentStoreOp StoreOp;

	   /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		public AttachmentLoadOp StencilLoadOp;

	   /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		public AttachmentStoreOp StencilStoreOp;

	   /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		public ImageLayout InitialLayout;

	   /// <summary>
		/// <para>
		/// -
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
    /// Structure specifying an attachment reference.
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
    /// Structure specifying a buffer copy operation.
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
    /// Structure specifying a buffer image copy operation.
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
    /// Structure specifying a clear attachment.
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
    /// Structure specifying a clear depth stencil value.
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
    /// Structure specifying a clear rectangle.
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
    /// Structure specifying a color component mapping.
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
    /// Structure specifying descriptor pool size.
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
    /// Structure specifying a dispatch indirect command.
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
    /// Structure describing display parameters associated with a display mode.
	/// </para>
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
	public partial struct DisplayModeParameters
	{
	   /// <summary>
		/// <para>
		/// pname:visibleRegion is the 2D extents of the visible region.
		/// </para>
		/// </summary>
		public Extent2D VisibleRegion;

	   /// <summary>
		/// <para>
		/// pname:refreshRate is a basetype:uint32_t that is the number of times the display is refreshed each second multiplied by 1000.
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
    /// Structure describing capabilities of a mode and plane combination.
	/// </para>
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
	public partial struct DisplayPlaneCapabilities
	{
	   /// <summary>
		/// <para>
		/// pname:supportedAlpha is a bitmask of elink:VkDisplayPlaneAlphaFlagBitsKHR describing the supported alpha blending modes.
		/// </para>
		/// </summary>
		public DisplayPlaneAlphaFlags SupportedAlpha;

	   /// <summary>
		/// <para>
		/// pname:minSrcPosition is the minimum source rectangle offset supported by this plane using the specified mode.
		/// </para>
		/// </summary>
		public Offset2D MinSourcePosition;

	   /// <summary>
		/// <para>
		/// pname:maxSrcPosition is the maximum source rectangle offset supported by this plane using the specified mode. The pname:x and pname:y components of pname:maxSrcPosition must: each be greater than or equal to the pname:x and pname:y components of pname:minSrcPosition, respectively.
		/// </para>
		/// </summary>
		public Offset2D MaxSourcePosition;

	   /// <summary>
		/// <para>
		/// pname:minSrcExtent is the minimum source rectangle size supported by this plane using the specified mode.
		/// </para>
		/// </summary>
		public Extent2D MinSourceExtent;

	   /// <summary>
		/// <para>
		/// pname:maxSrcExtent is the maximum source rectangle size supported by this plane using the specified mode.
		/// </para>
		/// </summary>
		public Extent2D MaxSourceExtent;

	   /// <summary>
		/// <para>
		/// pname:minDstPosition, pname:maxDstPosition, pname:minDstExtent, pname:maxDstExtent all have similar semantics to their corresponding "Src" equivalents, but apply to the output region within the mode rather than the input region within the source image. Unlike the "Src" offsets, pname:minDstPosition and pname:maxDstPosition may: contain negative values.
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
    /// Structure specifying a draw indexed indirect command.
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
    /// Structure specifying a draw indirect command.
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
    /// Structure specifying a two-dimensional extent.
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
    /// Structure specifying a three-dimensional extent.
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
    /// Structure specifying external image format properties.
	/// </para>
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
	public partial struct ExternalImageFormatProperties
	{
	   /// <summary>
		/// <para>
		/// pname:imageFormatProperties will be filled in as when calling flink:vkGetPhysicalDeviceImageFormatProperties, but the values returned may: vary depending on the external handle type requested.
		/// </para>
		/// </summary>
		public ImageFormatProperties ImageFormatProperties;

	   /// <summary>
		/// <para>
		/// pname:externalMemoryFeatures is a bitmask of elink:VkExternalMemoryFeatureFlagBitsNV indicating properties of the external memory handle type (flink:vkGetPhysicalDeviceExternalImageFormatPropertiesNV::pname:externalHandleType) being queried, or 0 if the external memory handle type is 0.
		/// </para>
		/// </summary>
		public ExternalMemoryFeatureFlags ExternalMemoryFeatures;

	   /// <summary>
		/// <para>
		/// pname:exportFromImportedHandleTypes is a bitmask of elink:VkExternalMemoryHandleTypeFlagBitsNV containing a bit set for every external handle type that may: be used to create memory from which the handles of the type specified in flink:vkGetPhysicalDeviceExternalImageFormatPropertiesNV::pname:externalHandleType can: be exported, or 0 if the external memory handle type is 0.
		/// </para>
		/// </summary>
		public ExternalMemoryHandleTypeFlags ExportFromImportedHandleTypes;

	   /// <summary>
		/// <para>
		/// pname:compatibleHandleTypes is a bitmask of elink:VkExternalMemoryHandleTypeFlagBitsNV containing a bit set for every external handle type that may: be specified simultaneously with the handle type specified by flink:vkGetPhysicalDeviceExternalImageFormatPropertiesNV::pname:externalHandleType when calling flink:vkAllocateMemory, or 0 if the external memory handle type is 0. pname:compatibleHandleTypes will always contain flink:vkGetPhysicalDeviceExternalImageFormatPropertiesNV::pname:externalHandleType
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
    /// Structure specifying image format properties.
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
    /// Structure specifying an image copy operation.
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
    /// Structure specifying a image format properties.
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
    /// Structure specifying an image resolve operation.
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
    /// Structure specifying a image subresource.
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
    /// Structure specifying a image subresource layers.
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
    /// Structure specifying a image subresource range.
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
    /// Structure specifying a memory heap.
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
		/// pname:flags is a bitmask of attribute flags for the heap. The bits specified in pname:flags are: + --
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
    /// Structure specifying memory requirements.
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
    /// Structure specifying memory type.
	/// </para>
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
	public partial struct MemoryType
	{
	   /// <summary>
		/// <para>
		/// pname:propertyFlags is a bitmask of properties for this memory type. The bits specified in pname:propertyFlags are: + --
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
    /// Structure specifying a two-dimensional offset.
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
    /// Structure specifying a three-dimensional offset.
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
    /// Structure specifying physical device sparse memory properties.
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
    /// Structure specifying a pipeline color blend attachment state.
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
    /// Structure specifying a push constant range.
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
    /// Structure specifying a two-dimensional subregion.
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
    /// Structure specifying sparse image format properties.
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
		/// pname:flags is a bitmask specifying additional information about the sparse resource. Bits which can: be set include: + --
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
    /// Structure specifying sparse image memory requirements.
	/// </para>
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
	public partial struct SparseImageMemoryRequirements
	{
	   /// <summary>
		/// <para>
		/// -
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
    /// Structure specifying a specialization map entry.
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
		public Size Size;

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
    /// Structure specifying stencil operation state.
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
    /// Structure specifying a subpass dependency.
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
		/// pname:srcStageMask, pname:dstStageMask, pname:srcAccessMask, pname:dstAccessMask, and pname:dependencyFlags describe an &lt;&lt;synchronization-execution-and-memory-dependencies,execution and memory dependency&gt;&gt; between subpasses. The bits that can: be included in pname:dependencyFlags are: + --
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
    /// Structure specifying subresource layout.
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
    /// Structure describing capabilities of a surface.
	/// </para>
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
	public partial struct SurfaceCapabilities
	{
	   /// <summary>
		/// <para>
		/// pname:minImageCount is the minimum number of images the specified device supports for a swapchain created for the surface.
		/// </para>
		/// </summary>
		public uint MinImageCount;

	   /// <summary>
		/// <para>
		/// pname:maxImageCount is the maximum number of images the specified device supports for a swapchain created for the surface.  A value of `0` means that there is no limit on the number of images, though there may: be limits related to the total amount of memory used by swapchain images.
		/// </para>
		/// </summary>
		public uint MaxImageCount;

	   /// <summary>
		/// <para>
		/// pname:currentExtent is the current width and height of the surface, or the special value latexmath:[$(0xFFFFFFFF, 0xFFFFFFFF)$] indicating that the surface size will be determined by the extent of a swapchain targeting the surface.
		/// </para>
		/// </summary>
		public Extent2D CurrentExtent;

	   /// <summary>
		/// <para>
		/// pname:minImageExtent contains the smallest valid swapchain extent for the surface on the specified device.
		/// </para>
		/// </summary>
		public Extent2D MinImageExtent;

	   /// <summary>
		/// <para>
		/// pname:maxImageExtent contains the largest valid swapchain extent for the surface on the specified device.
		/// </para>
		/// </summary>
		public Extent2D MaxImageExtent;

	   /// <summary>
		/// <para>
		/// pname:maxImageArrayLayers is the maximum number of layers swapchain images can: have for a swapchain created for this device and surface.
		/// </para>
		/// </summary>
		public uint MaxImageArrayLayers;

	   /// <summary>
		/// <para>
		/// pname:supportedTransforms is a bitmask of elink:VkSurfaceTransformFlagBitsKHR, describing the presentation transforms supported for the surface on the specified device.
		/// </para>
		/// </summary>
		public SurfaceTransformFlags SupportedTransforms;

	   /// <summary>
		/// <para>
		/// pname:currentTransform is a bitmask of elink:VkSurfaceTransformFlagBitsKHR, describing the surface's current transform relative to the presentation engine's natural orientation.
		/// </para>
		/// </summary>
		public SurfaceTransformFlags CurrentTransform;

	   /// <summary>
		/// <para>
		/// pname:supportedCompositeAlpha is a bitmask of elink:VkCompositeAlphaFlagBitsKHR, representing the alpha compositing modes supported by the presentation engine for the surface on the specified device.  Opaque composition can: be achieved in any alpha compositing mode by either using a swapchain image format that has no alpha component, or by ensuring that all pixels in the swapchain images have an alpha value of 1.0.
		/// </para>
		/// </summary>
		public CompositeAlphaFlags SupportedCompositeAlpha;

	   /// <summary>
		/// <para>
		/// pname:supportedUsageFlags is a bitmask of elink:VkImageUsageFlagBits representing the ways the application can: use the presentable images of a swapchain created for the surface on the specified device. ename:VK_IMAGE_USAGE_COLOR_ATTACHMENT_BIT must: be included in the set but implementations may: support additional usages.
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
    /// Structure describing a supported swapchain format-color space pair.
	/// </para>
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
	public partial struct SurfaceFormat
	{
	   /// <summary>
		/// <para>
		/// pname:format is a ename:VkFormat that is compatible with the specified surface.
		/// </para>
		/// </summary>
		public Format Format;

	   /// <summary>
		/// <para>
		/// pname:colorSpace is a presentation ename:VkColorSpaceKHR that is compatible with the surface.
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
    /// Structure specifying vertex input attribute description.
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
    /// Structure specifying vertex input binding description.
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
		/// pname:inputRate specifies whether vertex attribute addressing is a function of the vertex index or of the instance index. Possible values include: + --
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
    /// Structure specifying a viewport.
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