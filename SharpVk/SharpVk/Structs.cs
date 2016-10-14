// The MIT License (MIT)
// 
// Copyright (c) Andrew Armstrong/FacticiusVir 2016
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.

// This file was automatically generated and should not be edited directly.

using System;
using System.Runtime.InteropServices;
using System.Text;

namespace SharpVk
{
    /// <summary>
    /// Structure specifying an attachment description.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct AttachmentDescription
    {
        /// <summary>
        /// pname:flags is a bitmask describing additional properties of the
        /// attachment. Bits which can: be set include: + --
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
        /// 
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
    /// <para>
    /// .Valid Usage **** * pname:layout must: not be
    /// ename:VK_IMAGE_LAYOUT_UNDEFINED or ename:VK_IMAGE_LAYOUT_PREINITIALIZED
    /// ****
    /// </para>
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct AttachmentReference
    {
        /// <summary>
        /// pname:attachment is the index of the attachment of the render pass,
        /// and corresponds to the index of the corresponding element in the
        /// pname:pAttachments array of the sname:VkRenderPassCreateInfo
        /// structure. If any color or depth/stencil attachments are
        /// ename:VK_ATTACHMENT_UNUSED, then no writes occur for those
        /// attachments.
        /// </summary>
        public uint Attachment; 
        
        /// <summary>
        /// pname:layout is a elink:VkImageLayout value specifying the layout
        /// the attachment uses during the subpass. The implementation will
        /// automatically perform layout transitions as needed between
        /// subpasses to make each subpass use the requested layouts.
        /// </summary>
        public ImageLayout Layout; 
        
        /// <summary>
        /// 
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
    /// Structure specifying a buffer copy operation.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct BufferCopy
    {
        /// <summary>
        /// pname:srcOffset is the starting offset in bytes from the start of
        /// pname:srcBuffer.
        /// </summary>
        public DeviceSize SourceOffset; 
        
        /// <summary>
        /// pname:dstOffset is the starting offset in bytes from the start of
        /// pname:dstBuffer.
        /// </summary>
        public DeviceSize DestinationOffset; 
        
        /// <summary>
        /// pname:size is the number of bytes to copy.
        /// </summary>
        public DeviceSize Size; 
        
        /// <summary>
        /// 
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
    /// <para>
    /// When copying to or from a depth or stencil aspect, the data in buffer
    /// memory uses a layout that is a (mostly) tightly packed representation
    /// of the depth or stencil data. Specifically:
    /// </para>
    /// <para>
    /// * data copied to or from the stencil aspect of any depth/stencil format
    /// is tightly packed with one ename:VK_FORMAT_S8_UINT value per texel. *
    /// data copied to or from the depth aspect of a ename:VK_FORMAT_D16_UNORM
    /// or ename:VK_FORMAT_D16_UNORM_S8_UINT format is tightly packed with one
    /// ename:VK_FORMAT_D16_UNORM value per texel. * data copied to or from the
    /// depth aspect of a ename:VK_FORMAT_D32_SFLOAT or
    /// ename:VK_FORMAT_D32_SFLOAT_S8_UINT format is tightly packed with one
    /// ename:VK_FORMAT_D32_SFLOAT value per texel. * data copied to or from
    /// the depth aspect of a ename:VK_FORMAT_X8_D24_UNORM_PACK32 or
    /// ename:VK_FORMAT_D24_UNORM_S8_UINT format is packed with one 32-bit word
    /// per texel with the D24 value in the LSBs of the word, and undefined
    /// values in the eight MSBs.
    /// </para>
    /// <para>
    /// [NOTE] .Note ==== To copy both the depth and stencil aspects of a
    /// depth/stencil format, two entries in pname:pRegions can: be used, where
    /// one specifies the depth aspect in pname:imageSubresource, and the other
    /// specifies the stencil aspect. ====
    /// </para>
    /// <para>
    /// Because depth or stencil aspect buffer to image copies may: require
    /// format conversions on some implementations, they are not supported on
    /// queues that do not support graphics. When copying to a depth aspect,
    /// the data in buffer memory must: be in the the range [eq]#[0,1]# or
    /// undefined results occur.
    /// </para>
    /// <para>
    /// Copies are done layer by layer starting with image layer
    /// pname:baseArrayLayer member of pname:imageSubresource. pname:layerCount
    /// layers are copied from the source image or to the destination image.
    /// </para>
    /// <para>
    /// .Valid Usage **** * pname:bufferOffset must: be a multiple of the
    /// calling command's sname:VkImage parameter's format's element size *
    /// pname:bufferOffset must: be a multiple of `4` * pname:bufferRowLength
    /// must: be `0`, or greater than or equal to the pname:width member of
    /// pname:imageExtent * pname:bufferImageHeight must: be `0`, or greater
    /// than or equal to the pname:height member of pname:imageExtent *
    /// pname:imageOffset.x and (pname:imageExtent.width + pname:imageOffset.x)
    /// must: both be greater than or equal to `0` and less than or equal to
    /// the image subresource width * pname:imageOffset.y and
    /// (imageExtent.height + pname:imageOffset.y) must: both be greater than
    /// or equal to `0` and less than or equal to the image subresource height
    /// ** If the calling command's pname:srcImage
    /// (flink:vkCmdCopyImageToBuffer) or pname:dstImage
    /// (flink:vkCmdCopyBufferToImage) is of type ename:VK_IMAGE_TYPE_1D, then
    /// pname:imageOffset.y must: be `0` and pname:imageExtent.height must: be
    /// `1`. * pname:imageOffset.z and (imageExtent.depth +
    /// pname:imageOffset.z) must: both be greater than or equal to `0` and
    /// less than or equal to the image subresource depth ** If the calling
    /// command's pname:srcImage (flink:vkCmdCopyImageToBuffer) or
    /// pname:dstImage (flink:vkCmdCopyBufferToImage) is of type
    /// ename:VK_IMAGE_TYPE_1D or ename:VK_IMAGE_TYPE_2D, then
    /// pname:imageOffset.z must: be `0` and pname:imageExtent.depth must: be
    /// `1`. * If the calling command's sname:VkImage parameter is a compressed
    /// format image: ** pname:bufferRowLength must: be a multiple of the
    /// compressed texel block width ** pname:bufferImageHeight must: be a
    /// multiple of the compressed texel block height ** all members of
    /// pname:imageOffset must: be a multiple of the corresponding dimensions
    /// of the compressed texel block ** pname:bufferOffset must: be a multiple
    /// of the compressed texel block size in bytes ** pname:imageExtent.width
    /// must: be a multiple of the compressed texel block width or
    /// (pname:imageExtent.width + pname:imageOffset.x) must: equal the image
    /// subresource width ** pname:imageExtent.height must: be a multiple of
    /// the compressed texel block height or (pname:imageExtent.height +
    /// pname:imageOffset.y) must: equal the image subresource height **
    /// pname:imageExtent.depth must: be a multiple of the compressed texel
    /// block depth or (pname:imageExtent.depth + pname:imageOffset.z) must:
    /// equal the image subresource depth * pname:bufferOffset,
    /// pname:bufferRowLength, pname:bufferImageHeight and all members of
    /// pname:imageOffset and pname:imageExtent must: respect the image
    /// transfer granularity requirements of the queue family that it will be
    /// submitted against, as described in
    /// &lt;&lt;devsandqueues-physical-device-enumeration,Physical Device
    /// Enumeration&gt;&gt; * The pname:aspectMask member of
    /// pname:imageSubresource must: specify aspects present in the calling
    /// command's sname:VkImage parameter * The pname:aspectMask member of
    /// pname:imageSubresource must: only have a single bit set * If the
    /// calling command's sname:VkImage parameter is of elink:VkImageType
    /// ename:VK_IMAGE_TYPE_3D, the pname:baseArrayLayer and pname:layerCount
    /// members of pname:imageSubresource must: be `0` and `1`, respectively *
    /// When copying to the depth aspect of an image subresource, the data in
    /// the source buffer must: be in the range [eq]#[0,1]# ****
    /// </para>
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct BufferImageCopy
    {
        /// <summary>
        /// pname:bufferOffset is the offset in bytes from the start of the
        /// buffer object where the image data is copied from or to.
        /// </summary>
        public DeviceSize BufferOffset; 
        
        /// <summary>
        /// pname:bufferRowLength and pname:bufferImageHeight specify the data
        /// in buffer memory as a subregion of a larger two- or
        /// three-dimensional image, and control the addressing calculations of
        /// data in buffer memory. If either of these values is zero, that
        /// aspect of the buffer memory is considered to be tightly packed
        /// according to the pname:imageExtent.
        /// </summary>
        public uint BufferRowLength; 
        
        /// <summary>
        /// -
        /// </summary>
        public uint BufferImageHeight; 
        
        /// <summary>
        /// pname:imageSubresource is a slink:VkImageSubresourceLayers used to
        /// specify the specific image subresources of the image used for the
        /// source or destination image data.
        /// </summary>
        public ImageSubresourceLayers ImageSubresource; 
        
        /// <summary>
        /// pname:imageOffset selects the initial x, y, z offsets in texels of
        /// the sub-region of the source or destination image data.
        /// </summary>
        public Offset3D ImageOffset; 
        
        /// <summary>
        /// pname:imageExtent is the size in texels of the image to copy in
        /// pname:width, pname:height and pname:depth.
        /// </summary>
        public Extent3D ImageExtent; 
        
        /// <summary>
        /// 
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
    /// <para>
    /// No memory barriers are needed between fname:vkCmdClearAttachments and
    /// preceding or subsequent draw or attachment clear commands in the same
    /// subpass.
    /// </para>
    /// <para>
    /// The fname:vkCmdClearAttachments command is not affected by the bound
    /// pipeline state.
    /// </para>
    /// <para>
    /// Attachments can: also be cleared at the beginning of a render pass
    /// instance by setting pname:loadOp (or pname:stencilLoadOp) of
    /// slink:VkAttachmentDescription to ename:VK_ATTACHMENT_LOAD_OP_CLEAR, as
    /// described for flink:vkCreateRenderPass.
    /// </para>
    /// <para>
    /// .Valid Usage **** * If pname:aspectMask includes
    /// ename:VK_IMAGE_ASPECT_COLOR_BIT, it must: not include
    /// ename:VK_IMAGE_ASPECT_DEPTH_BIT or ename:VK_IMAGE_ASPECT_STENCIL_BIT *
    /// pname:aspectMask must: not include ename:VK_IMAGE_ASPECT_METADATA_BIT
    /// ****
    /// </para>
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct ClearAttachment
    {
        /// <summary>
        /// pname:aspectMask is a mask selecting the color, depth and/or
        /// stencil aspects of the attachment to be cleared. pname:aspectMask
        /// can: include ename:VK_IMAGE_ASPECT_COLOR_BIT for color attachments,
        /// ename:VK_IMAGE_ASPECT_DEPTH_BIT for depth/stencil attachments with
        /// a depth component, and ename:VK_IMAGE_ASPECT_STENCIL_BIT for
        /// depth/stencil attachments with a stencil component. If the
        /// subpass's depth/stencil attachment is ename:VK_ATTACHMENT_UNUSED,
        /// then the clear has no effect.
        /// </summary>
        public ImageAspectFlags AspectMask; 
        
        /// <summary>
        /// pname:colorAttachment is only meaningful if
        /// ename:VK_IMAGE_ASPECT_COLOR_BIT is set in pname:aspectMask, in
        /// which case it is an index to the pname:pColorAttachments array in
        /// the slink:VkSubpassDescription structure of the current subpass
        /// which selects the color attachment to clear. If
        /// pname:colorAttachment is ename:VK_ATTACHMENT_UNUSED then the clear
        /// has no effect.
        /// </summary>
        public uint ColorAttachment; 
        
        /// <summary>
        /// pname:clearValue is the color or depth/stencil value to clear the
        /// attachment to, as described in &lt;&lt;clears-values,Clear
        /// Values&gt;&gt; below.
        /// </summary>
        public ClearValue ClearValue; 
        
        /// <summary>
        /// 
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
    /// <para>
    /// .Valid Usage **** * pname:depth must: be between `0.0` and `1.0`,
    /// inclusive ****
    /// </para>
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct ClearDepthStencilValue
    {
        /// <summary>
        /// pname:depth is the clear value for the depth aspect of the
        /// depth/stencil attachment. It is a floating-point value which is
        /// automatically converted to the attachment's format.
        /// </summary>
        public float Depth; 
        
        /// <summary>
        /// pname:stencil is the clear value for the stencil aspect of the
        /// depth/stencil attachment. It is a 32-bit integer value which is
        /// converted to the attachment's format by taking the appropriate
        /// number of LSBs.
        /// </summary>
        public uint Stencil; 
        
        /// <summary>
        /// 
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
    /// <para>
    /// The layers [eq]#[pname:baseArrayLayer, pname:baseArrayLayer {plus}
    /// pname:layerCount)# counting from the base layer of the attachment image
    /// view are cleared.
    /// </para>
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct ClearRect
    {
        /// <summary>
        /// pname:rect is the two-dimensional region to be cleared.
        /// </summary>
        public Rect2D Rect; 
        
        /// <summary>
        /// pname:baseArrayLayer is the first layer to be cleared.
        /// </summary>
        public uint BaseArrayLayer; 
        
        /// <summary>
        /// pname:layerCount is the number of layers to clear.
        /// </summary>
        public uint LayerCount; 
        
        /// <summary>
        /// 
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
    /// <para>
    /// Each of pname:r, pname:g, pname:b, and pname:a is one of the values:
    /// </para>
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct ComponentMapping
    {
        /// <summary>
        /// pname:r determines the component value placed in the R component of
        /// the output vector.
        /// </summary>
        public ComponentSwizzle R; 
        
        /// <summary>
        /// pname:g determines the component value placed in the G component of
        /// the output vector.
        /// </summary>
        public ComponentSwizzle G; 
        
        /// <summary>
        /// pname:b determines the component value placed in the B component of
        /// the output vector.
        /// </summary>
        public ComponentSwizzle B; 
        
        /// <summary>
        /// pname:a determines the component value placed in the A component of
        /// the output vector.
        /// </summary>
        public ComponentSwizzle A; 
        
        /// <summary>
        /// 
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
    /// <para>
    /// .Valid Usage **** * pname:descriptorCount must: be greater than `0`
    /// ****
    /// </para>
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct DescriptorPoolSize
    {
        /// <summary>
        /// pname:type is the type of descriptor.
        /// </summary>
        public DescriptorType Type; 
        
        /// <summary>
        /// pname:descriptorCount is the number of descriptors of that type to
        /// allocate.
        /// </summary>
        public uint DescriptorCount; 
        
        /// <summary>
        /// 
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
    /// <para>
    /// The members of sname:VkDispatchIndirectCommand structure have the same
    /// meaning as the similarly named parameters of flink:vkCmdDispatch.
    /// </para>
    /// <para>
    /// .Valid Usage **** * pname:x must: be less than or equal to
    /// sname:VkPhysicalDeviceLimits::pname:maxComputeWorkGroupCount[0] *
    /// pname:y must: be less than or equal to
    /// sname:VkPhysicalDeviceLimits::pname:maxComputeWorkGroupCount[1] *
    /// pname:z must: be less than or equal to
    /// sname:VkPhysicalDeviceLimits::pname:maxComputeWorkGroupCount[2] ****
    /// </para>
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct DispatchIndirectCommand
    {
        /// <summary>
        /// pname:x is the number of local workgroups to dispatch in the X
        /// dimension.
        /// </summary>
        public uint X; 
        
        /// <summary>
        /// pname:y is the number of local workgroups to dispatch in the Y
        /// dimension.
        /// </summary>
        public uint Y; 
        
        /// <summary>
        /// pname:z is the number of local workgroups to dispatch in the Z
        /// dimension.
        /// </summary>
        public uint Z; 
        
        /// <summary>
        /// 
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
    /// <para>
    /// [NOTE] .Note ==== For example, a 60Hz display mode would report a
    /// pname:refreshRate of 60,000. ====
    /// </para>
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct DisplayModeParameters
    {
        /// <summary>
        /// pname:visibleRegion is the 2D extents of the visible region.
        /// </summary>
        public Extent2D VisibleRegion; 
        
        /// <summary>
        /// pname:refreshRate is a code:uint32_t that is the number of times
        /// the display is refreshed each second multiplied by 1000.
        /// </summary>
        public uint RefreshRate; 
        
        /// <summary>
        /// 
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
    /// <para>
    /// The minimum and maximum position and extent fields describe the
    /// hardware limits, if any, as they apply to the specified display mode
    /// and plane. Vendors may: support displaying a subset of a swapchain's
    /// presentable images on the specified display plane. This is expressed by
    /// returning pname:minSrcPosition, pname:maxSrcPosition,
    /// pname:minSrcExtent, and pname:maxSrcExtent values that indicate a range
    /// of possible positions and sizes may: be used to specify the region
    /// within the presentable images that source pixels will be read from when
    /// creating a swapchain on the specified display mode and plane.
    /// </para>
    /// <para>
    /// Vendors may: also support mapping the presentable images' content to a
    /// subset or superset of the visible region in the specified display mode.
    /// This is expressed by returning pname:minDstPosition,
    /// pname:maxDstPosition, pname:minDstExtent and pname:maxDstExtent values
    /// that indicate a range of possible positions and sizes may: be used to
    /// describe the region within the display mode that the source pixels will
    /// be mapped to.
    /// </para>
    /// <para>
    /// Other vendors may: support only a 1-1 mapping between pixels in the
    /// presentable images and the display mode. This may: be indicated by
    /// returning [eq]#(0,0)# for pname:minSrcPosition, pname:maxSrcPosition,
    /// pname:minDstPosition, and pname:maxDstPosition, and (display mode
    /// width, display mode height) for pname:minSrcExtent, pname:maxSrcExtent,
    /// pname:minDstExtent, and pname:maxDstExtent.
    /// </para>
    /// <para>
    /// These values indicate the limits of the hardware's individual fields.
    /// Not all combinations of values within the offset and extent ranges
    /// returned in sname:VkDisplayPlaneCapabilitiesKHR are guaranteed to be
    /// supported. Vendors may: still fail presentation requests that specify
    /// unsupported combinations.
    /// </para>
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct DisplayPlaneCapabilities
    {
        /// <summary>
        /// pname:supportedAlpha is a bitmask of
        /// elink:VkDisplayPlaneAlphaFlagBitsKHR describing the supported alpha
        /// blending modes.
        /// </summary>
        public DisplayPlaneAlphaFlags SupportedAlpha; 
        
        /// <summary>
        /// pname:minSrcPosition is the minimum source rectangle offset
        /// supported by this plane using the specified mode.
        /// </summary>
        public Offset2D MinSourcePosition; 
        
        /// <summary>
        /// pname:maxSrcPosition is the maximum source rectangle offset
        /// supported by this plane using the specified mode. The pname:x and
        /// pname:y components of pname:maxSrcPosition must: each be greater
        /// than or equal to the pname:x and pname:y components of
        /// pname:minSrcPosition, respectively.
        /// </summary>
        public Offset2D MaxSourcePosition; 
        
        /// <summary>
        /// pname:minSrcExtent is the minimum source rectangle size supported
        /// by this plane using the specified mode.
        /// </summary>
        public Extent2D MinSourceExtent; 
        
        /// <summary>
        /// pname:maxSrcExtent is the maximum source rectangle size supported
        /// by this plane using the specified mode.
        /// </summary>
        public Extent2D MaxSourceExtent; 
        
        /// <summary>
        /// pname:minDstPosition, pname:maxDstPosition, pname:minDstExtent,
        /// pname:maxDstExtent all have similar semantics to their
        /// corresponding "Src" equivalents, but apply to the output region
        /// within the mode rather than the input region within the source
        /// image. Unlike the "Src" offsets, pname:minDstPosition and
        /// pname:maxDstPosition may: contain negative values.
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
        /// 
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
    /// <para>
    /// The members of sname:VkDrawIndexedIndirectCommand have the same meaning
    /// as the similarly named parameters of flink:vkCmdDrawIndexed.
    /// </para>
    /// <para>
    /// .Valid Usage **** * For a given vertex buffer binding, any attribute
    /// data fetched must: be entirely contained within the corresponding
    /// vertex buffer binding, as described in &lt;&lt;fxvertex-input&gt;&gt; *
    /// (pname:indexSize * (pname:firstIndex + pname:indexCount) +
    /// pname:offset) must: be less than or equal to the size of the currently
    /// bound index buffer, with pname:indexSize being based on the type
    /// specified by pname:indexType, where the index buffer, pname:indexType,
    /// and pname:offset are specified via fname:vkCmdBindIndexBuffer * If the
    /// &lt;&lt;features-features-drawIndirectFirstInstance,drawIndirectFirstInstance&gt;&gt; feature
    /// is not enabled, pname:firstInstance must: be code:0 ****
    /// </para>
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct DrawIndexedIndirectCommand
    {
        /// <summary>
        /// pname:indexCount is the number of vertices to draw.
        /// </summary>
        public uint IndexCount; 
        
        /// <summary>
        /// pname:instanceCount is the number of instances to draw.
        /// </summary>
        public uint InstanceCount; 
        
        /// <summary>
        /// pname:firstIndex is the base index within the index buffer.
        /// </summary>
        public uint FirstIndex; 
        
        /// <summary>
        /// pname:vertexOffset is the value added to the vertex index before
        /// indexing into the vertex buffer.
        /// </summary>
        public int VertexOffset; 
        
        /// <summary>
        /// pname:firstInstance is the instance ID of the first instance to
        /// draw.
        /// </summary>
        public uint FirstInstance; 
        
        /// <summary>
        /// 
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
    /// <para>
    /// The members of sname:VkDrawIndirectCommand have the same meaning as the
    /// similarly named parameters of flink:vkCmdDraw.
    /// </para>
    /// <para>
    /// .Valid Usage **** * For a given vertex buffer binding, any attribute
    /// data fetched must: be entirely contained within the corresponding
    /// vertex buffer binding, as described in &lt;&lt;fxvertex-input&gt;&gt; *
    /// If the
    /// &lt;&lt;features-features-drawIndirectFirstInstance,drawIndirectFirstInstance&gt;&gt; feature
    /// is not enabled, pname:firstInstance must: be code:0 ****
    /// </para>
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct DrawIndirectCommand
    {
        /// <summary>
        /// pname:vertexCount is the number of vertices to draw.
        /// </summary>
        public uint VertexCount; 
        
        /// <summary>
        /// pname:instanceCount is the number of instances to draw.
        /// </summary>
        public uint InstanceCount; 
        
        /// <summary>
        /// pname:firstVertex is the index of the first vertex to draw.
        /// </summary>
        public uint FirstVertex; 
        
        /// <summary>
        /// pname:firstInstance is the instance ID of the first instance to
        /// draw.
        /// </summary>
        public uint FirstInstance; 
        
        /// <summary>
        /// 
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
    /// Structure specifying a two-dimensional extent.
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
        /// 
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
    /// Structure specifying a three-dimensional extent.
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
        /// 
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
    /// Structure specifying external image format properties.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct ExternalImageFormatProperties
    {
        /// <summary>
        /// pname:imageFormatProperties will be filled in as when calling
        /// flink:vkGetPhysicalDeviceImageFormatProperties, but the values
        /// returned may: vary depending on the external handle type requested.
        /// </summary>
        public ImageFormatProperties ImageFormatProperties; 
        
        /// <summary>
        /// pname:externalMemoryFeatures is a bitmask of
        /// elink:VkExternalMemoryFeatureFlagBitsNV indicating properties of
        /// the external memory handle type
        /// (flink:vkGetPhysicalDeviceExternalImageFormatPropertiesNV::pname:externalHandleType) being
        /// queried, or 0 if the external memory handle type is 0.
        /// </summary>
        public ExternalMemoryFeatureFlags ExternalMemoryFeatures; 
        
        /// <summary>
        /// pname:exportFromImportedHandleTypes is a bitmask of
        /// elink:VkExternalMemoryHandleTypeFlagBitsNV containing a bit set for
        /// every external handle type that may: be used to create memory from
        /// which the handles of the type specified in
        /// flink:vkGetPhysicalDeviceExternalImageFormatPropertiesNV::pname:externalHandleType can:
        /// be exported, or 0 if the external memory handle type is 0.
        /// </summary>
        public ExternalMemoryHandleTypeFlags ExportFromImportedHandleTypes; 
        
        /// <summary>
        /// pname:compatibleHandleTypes is a bitmask of
        /// elink:VkExternalMemoryHandleTypeFlagBitsNV containing a bit set for
        /// every external handle type that may: be specified simultaneously
        /// with the handle type specified by
        /// flink:vkGetPhysicalDeviceExternalImageFormatPropertiesNV::pname:externalHandleType when
        /// calling flink:vkAllocateMemory, or 0 if the external memory handle
        /// type is 0. pname:compatibleHandleTypes will always contain
        /// flink:vkGetPhysicalDeviceExternalImageFormatPropertiesNV::pname:externalHandleType
        /// </summary>
        public ExternalMemoryHandleTypeFlags CompatibleHandleTypes; 
        
        /// <summary>
        /// 
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
    /// <para>
    /// Supported features are described as a set of
    /// elink:VkFormatFeatureFlagBits:
    /// </para>
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct FormatProperties
    {
        /// <summary>
        /// pname:linearTilingFeatures describes the features supported by
        /// ename:VK_IMAGE_TILING_LINEAR.
        /// </summary>
        public FormatFeatureFlags LinearTilingFeatures; 
        
        /// <summary>
        /// pname:optimalTilingFeatures describes the features supported by
        /// ename:VK_IMAGE_TILING_OPTIMAL.
        /// </summary>
        public FormatFeatureFlags OptimalTilingFeatures; 
        
        /// <summary>
        /// pname:bufferFeatures describes the features supported by buffers.
        /// </summary>
        public FormatFeatureFlags BufferFeatures; 
        
        /// <summary>
        /// 
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
    /// <para>
    /// .Valid Usage **** * The pname:aspectMask member of pname:srcSubresource
    /// and pname:dstSubresource must: match * The pname:layerCount member of
    /// pname:srcSubresource and pname:dstSubresource must: match * If either
    /// of the calling command's pname:srcImage or pname:dstImage parameters
    /// are of elink:VkImageType ename:VK_IMAGE_TYPE_3D, the
    /// pname:baseArrayLayer and pname:layerCount members of both
    /// pname:srcSubresource and pname:dstSubresource must: be `0` and `1`,
    /// respectively * The pname:aspectMask member of pname:srcSubresource
    /// must: specify aspects present in the calling command's pname:srcImage *
    /// The pname:aspectMask member of pname:dstSubresource must: specify
    /// aspects present in the calling command's pname:dstImage *
    /// pname:srcOffset.x and (pname:extent.width + pname:srcOffset.x) must:
    /// both be greater than or equal to `0` and less than or equal to the
    /// source image subresource width * pname:srcOffset.y and
    /// (pname:extent.height + pname:srcOffset.y) must: both be greater than or
    /// equal to `0` and less than or equal to the source image subresource
    /// height ** If the calling command's pname:srcImage is of type
    /// ename:VK_IMAGE_TYPE_1D, then pname:srcOffset.y must: be `0` and
    /// pname:extent.height must: be `1`. * pname:srcOffset.z and
    /// (pname:extent.depth + pname:srcOffset.z) must: both be greater than or
    /// equal to `0` and less than or equal to the source image subresource
    /// depth ** If the calling command's pname:srcImage is of type
    /// ename:VK_IMAGE_TYPE_1D or ename:VK_IMAGE_TYPE_2D, then
    /// pname:srcOffset.z must: be `0` and pname:extent.depth must: be `1`. *
    /// pname:dstOffset.x and (pname:extent.width + pname:dstOffset.x) must:
    /// both be greater than or equal to `0` and less than or equal to the
    /// destination image subresource width * pname:dstOffset.y and
    /// (pname:extent.height + pname:dstOffset.y) must: both be greater than or
    /// equal to `0` and less than or equal to the destination image
    /// subresource height ** If the calling command's pname:dstImage is of
    /// type ename:VK_IMAGE_TYPE_1D, then pname:dstOffset.y must: be `0` and
    /// pname:extent.height must: be `1`. * pname:dstOffset.z and
    /// (pname:extent.depth + pname:dstOffset.z) must: both be greater than or
    /// equal to `0` and less than or equal to the destination image
    /// subresource depth ** If the calling command's pname:dstImage is of type
    /// ename:VK_IMAGE_TYPE_1D or ename:VK_IMAGE_TYPE_2D, then
    /// pname:dstOffset.z must: be `0` and pname:extent.depth must: be `1`. *
    /// If the calling command's pname:srcImage is a compressed format image:
    /// ** all members of pname:srcOffset must: be a multiple of the
    /// corresponding dimensions of the compressed texel block **
    /// pname:extent.width must: be a multiple of the compressed texel block
    /// width or (pname:extent.width + pname:srcOffset.x) must: equal the
    /// source image subresource width ** pname:extent.height must: be a
    /// multiple of the compressed texel block height or (pname:extent.height +
    /// pname:srcOffset.y) must: equal the source image subresource height **
    /// pname:extent.depth must: be a multiple of the compressed texel block
    /// depth or (pname:extent.depth + pname:srcOffset.z) must: equal the
    /// source image subresource depth * If the calling command's
    /// pname:dstImage is a compressed format image: ** all members of
    /// pname:dstOffset must: be a multiple of the corresponding dimensions of
    /// the compressed texel block ** pname:extent.width must: be a multiple of
    /// the compressed texel block width or (pname:extent.width +
    /// pname:dstOffset.x) must: equal the destination image subresource width
    /// ** pname:extent.height must: be a multiple of the compressed texel
    /// block height or (pname:extent.height + pname:dstOffset.y) must: equal
    /// the destination image subresource height ** pname:extent.depth must: be
    /// a multiple of the compressed texel block depth or (pname:extent.depth +
    /// pname:dstOffset.z) must: equal the destination image subresource depth
    /// * pname:srcOffset, pname:dstOffset, and pname:extent must: respect the
    /// image transfer granularity requirements of the queue family that it
    /// will be submitted against, as described in
    /// &lt;&lt;devsandqueues-physical-device-enumeration,Physical Device
    /// Enumeration&gt;&gt; ****
    /// </para>
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct ImageCopy
    {
        /// <summary>
        /// pname:srcSubresource and pname:dstSubresource are
        /// slink:VkImageSubresourceLayers structures specifying the image
        /// subresources of the images used for the source and destination
        /// image data, respectively.
        /// </summary>
        public ImageSubresourceLayers SourceSubresource; 
        
        /// <summary>
        /// pname:srcOffset and pname:dstOffset select the initial x, y, and z
        /// offsets in texels of the sub-regions of the source and destination
        /// image data.
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
        /// pname:extent is the size in texels of the source image to copy in
        /// pname:width, pname:height and pname:depth.
        /// </summary>
        public Extent3D Extent; 
        
        /// <summary>
        /// 
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
    /// <para>
    /// [NOTE] .Note ==== There is no mechanism to query the size of an image
    /// before creating it, to compare that size against pname:maxResourceSize.
    /// If an application attempts to create an image that exceeds this limit,
    /// the creation will fail or the image will be invalid. While the
    /// advertised limit must: be at least 2^31^, it may: not be possible to
    /// create an image that approaches that size, particularly for
    /// ename:VK_IMAGE_TYPE_1D. ====
    /// </para>
    /// <para>
    /// If the combination of parameters to
    /// fname:vkGetPhysicalDeviceImageFormatProperties is not supported by the
    /// implementation for use in flink:vkCreateImage, then all members of
    /// sname:VkImageFormatProperties will be filled with zero.
    /// </para>
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct ImageFormatProperties
    {
        /// <summary>
        /// pname:maxExtent are the maximum image dimensions. See the
        /// &lt;&lt;features-extentperimagetype,Allowed Extent Values&gt;&gt;
        /// section below for how these values are constrained by pname:type.
        /// </summary>
        public Extent3D MaxExtent; 
        
        /// <summary>
        /// pname:maxMipLevels is the maximum number of mipmap levels.
        /// pname:maxMipLevels must: either be equal to 1 (valid only if
        /// pname:tiling is ename:VK_IMAGE_TILING_LINEAR) or be equal to
        /// [eq]#{lceil}log~2~(max(pname:width, pname:height,
        /// pname:depth)){rceil} {plus} 1#. [eq]#pname:width#,
        /// [eq]#pname:height#, and [eq]#pname:depth# are taken from the
        /// corresponding members of pname:maxExtent.
        /// </summary>
        public uint MaxMipLevels; 
        
        /// <summary>
        /// pname:maxArrayLayers is the maximum number of array layers.
        /// pname:maxArrayLayers must: either be equal to 1 or be greater than
        /// or equal to the pname:maxImageArrayLayers member of
        /// slink:VkPhysicalDeviceLimits. A value of 1 is valid only if
        /// pname:tiling is ename:VK_IMAGE_TILING_LINEAR or if pname:type is
        /// ename:VK_IMAGE_TYPE_3D.
        /// </summary>
        public uint MaxArrayLayers; 
        
        /// <summary>
        /// pname:sampleCounts is a bitmask of elink:VkSampleCountFlagBits
        /// specifying all the supported sample counts for this image as
        /// described &lt;&lt;features-supported-sample-counts, below&gt;&gt;.
        /// </summary>
        public SampleCountFlags SampleCounts; 
        
        /// <summary>
        /// pname:maxResourceSize is an upper bound on the total image size in
        /// bytes, inclusive of all image subresources. Implementations may:
        /// have an address space limit on total size of a resource, which is
        /// advertised by this property. pname:maxResourceSize must: be at
        /// least 2^31^.
        /// </summary>
        public DeviceSize MaxResourceSize; 
        
        /// <summary>
        /// 
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
    /// <para>
    /// .Valid Usage **** * The pname:aspectMask member of pname:srcSubresource
    /// and pname:dstSubresource must: only contain
    /// ename:VK_IMAGE_ASPECT_COLOR_BIT * The pname:layerCount member of
    /// pname:srcSubresource and pname:dstSubresource must: match * If either
    /// of the calling command's pname:srcImage or pname:dstImage parameters
    /// are of elink:VkImageType ename:VK_IMAGE_TYPE_3D, the
    /// pname:baseArrayLayer and pname:layerCount members of both
    /// pname:srcSubresource and pname:dstSubresource must: be `0` and `1`,
    /// respectively * pname:srcOffset.x and (pname:extent.width +
    /// pname:srcOffset.x) must: both be greater than or equal to `0` and less
    /// than or equal to the source image subresource width * pname:srcOffset.y
    /// and (pname:extent.height + pname:srcOffset.y) must: both be greater
    /// than or equal to `0` and less than or equal to the source image
    /// subresource height ** If the calling command's pname:srcImage is of
    /// type ename:VK_IMAGE_TYPE_1D, then pname:srcOffset.y must: be `0` and
    /// pname:extent.height must: be `1`. * pname:srcOffset.z and
    /// (pname:extent.depth + pname:srcOffset.z) must: both be greater than or
    /// equal to `0` and less than or equal to the source image subresource
    /// depth ** If the calling command's pname:srcImage is of type
    /// ename:VK_IMAGE_TYPE_1D or ename:VK_IMAGE_TYPE_2D, then
    /// pname:srcOffset.z must: be `0` and pname:extent.depth must: be `1`. *
    /// pname:dstOffset.x and (pname:extent.width + pname:dstOffset.x) must:
    /// both be greater than or equal to `0` and less than or equal to the
    /// destination image subresource width * pname:dstOffset.y and
    /// (pname:extent.height + pname:dstOffset.y) must: both be greater than or
    /// equal to `0` and less than or equal to the destination image
    /// subresource height ** If the calling command's pname:dstImage is of
    /// type ename:VK_IMAGE_TYPE_1D, then pname:dstOffset.y must: be `0` and
    /// pname:extent.height must: be `1`. * pname:dstOffset.z and
    /// (pname:extent.depth + pname:dstOffset.z) must: both be greater than or
    /// equal to `0` and less than or equal to the destination image
    /// subresource depth ** If the calling command's pname:dstImage is of type
    /// ename:VK_IMAGE_TYPE_1D or ename:VK_IMAGE_TYPE_2D, then
    /// pname:dstOffset.z must: be `0` and pname:extent.depth must: be `1`.
    /// ****
    /// </para>
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct ImageResolve
    {
        /// <summary>
        /// pname:srcSubresource and pname:dstSubresource are
        /// slink:VkImageSubresourceLayers structures specifying the image
        /// subresources of the images used for the source and destination
        /// image data, respectively. Resolve of depth/stencil images is not
        /// supported.
        /// </summary>
        public ImageSubresourceLayers SourceSubresource; 
        
        /// <summary>
        /// pname:srcOffset and pname:dstOffset select the initial x, y, and z
        /// offsets in texels of the sub-regions of the source and destination
        /// image data.
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
        /// pname:extent is the size in texels of the source image to resolve
        /// in pname:width, pname:height and pname:depth.
        /// </summary>
        public Extent3D Extent; 
        
        /// <summary>
        /// 
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
    /// <para>
    /// .Valid Usage **** * pname:mipLevel must: be less than the
    /// pname:mipLevels specified in slink:VkImageCreateInfo when the image was
    /// created * pname:arrayLayer must: be less than the pname:arrayLayers
    /// specified in slink:VkImageCreateInfo when the image was created ****
    /// </para>
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct ImageSubresource
    {
        /// <summary>
        /// pname:aspectMask is a elink:VkImageAspectFlags selecting the image
        /// _aspect_.
        /// </summary>
        public ImageAspectFlags AspectMask; 
        
        /// <summary>
        /// pname:mipLevel selects the mipmap level.
        /// </summary>
        public uint MipLevel; 
        
        /// <summary>
        /// pname:arrayLayer selects the array layer.
        /// </summary>
        public uint ArrayLayer; 
        
        /// <summary>
        /// 
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
    /// <para>
    /// .Valid Usage **** * If pname:aspectMask contains
    /// ename:VK_IMAGE_ASPECT_COLOR_BIT, it must: not contain either of
    /// ename:VK_IMAGE_ASPECT_DEPTH_BIT or ename:VK_IMAGE_ASPECT_STENCIL_BIT *
    /// pname:aspectMask must: not contain ename:VK_IMAGE_ASPECT_METADATA_BIT *
    /// pname:mipLevel must: be less than the pname:mipLevels specified in
    /// slink:VkImageCreateInfo when the image was created *
    /// [eq]#(pname:baseArrayLayer + pname:layerCount)# must: be less than or
    /// equal to the pname:arrayLayers specified in slink:VkImageCreateInfo
    /// when the image was created ****
    /// </para>
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct ImageSubresourceLayers
    {
        /// <summary>
        /// pname:aspectMask is a combination of elink:VkImageAspectFlagBits,
        /// selecting the color, depth and/or stencil aspects to be copied.
        /// </summary>
        public ImageAspectFlags AspectMask; 
        
        /// <summary>
        /// pname:mipLevel is the mipmap level to copy from.
        /// </summary>
        public uint MipLevel; 
        
        /// <summary>
        /// pname:baseArrayLayer and pname:layerCount are the starting layer
        /// and number of layers to copy.
        /// </summary>
        public uint BaseArrayLayer; 
        
        /// <summary>
        /// -
        /// </summary>
        public uint LayerCount; 
        
        /// <summary>
        /// 
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
    /// <para>
    /// The number of mipmap levels and array layers must: be a subset of the
    /// image subresources in the image. If an application wants to use all mip
    /// levels or layers in an image after the pname:baseMipLevel or
    /// pname:baseArrayLayer, it can: set pname:levelCount and pname:layerCount
    /// to the special values ename:VK_REMAINING_MIP_LEVELS and
    /// ename:VK_REMAINING_ARRAY_LAYERS without knowing the exact number of mip
    /// levels or layers.
    /// </para>
    /// <para>
    /// For cube and cube array image views, the layers of the image view
    /// starting at pname:baseArrayLayer correspond to faces in the order +X,
    /// -X, +Y, -Y, +Z, -Z. For cube arrays, each set of six sequential layers
    /// is a single cube, so the number of cube maps in a cube map array view
    /// is _pname:layerCount / 6_, and image array layer _pname:baseArrayLayer
    /// + i_ is face index _i mod 6_ of cube _i / 6_. If the number of layers
    /// in the view, whether set explicitly in pname:layerCount or implied by
    /// ename:VK_REMAINING_ARRAY_LAYERS, is not a multiple of 6, behavior when
    /// indexing the last cube is undefined.
    /// </para>
    /// <para>
    /// pname:aspectMask is a bitmask indicating the format being used. Bits
    /// which may: be set include:
    /// </para>
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct ImageSubresourceRange
    {
        /// <summary>
        /// pname:aspectMask is a bitmask indicating which aspect(s) of the
        /// image are included in the view. See elink:VkImageAspectFlagBits.
        /// </summary>
        public ImageAspectFlags AspectMask; 
        
        /// <summary>
        /// pname:baseMipLevel is the first mipmap level accessible to the
        /// view.
        /// </summary>
        public uint BaseMipLevel; 
        
        /// <summary>
        /// pname:levelCount is the number of mipmap levels (starting from
        /// pname:baseMipLevel) accessible to the view.
        /// </summary>
        public uint LevelCount; 
        
        /// <summary>
        /// pname:baseArrayLayer is the first array layer accessible to the
        /// view.
        /// </summary>
        public uint BaseArrayLayer; 
        
        /// <summary>
        /// pname:layerCount is the number of array layers (starting from
        /// pname:baseArrayLayer) accessible to the view.
        /// </summary>
        public uint LayerCount; 
        
        /// <summary>
        /// 
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
    /// Structure specifying a memory heap.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct MemoryHeap
    {
        /// <summary>
        /// pname:size is the total memory size in bytes in the heap.
        /// </summary>
        public DeviceSize Size; 
        
        /// <summary>
        /// pname:flags is a bitmask of attribute flags for the heap. The bits
        /// specified in pname:flags are: + --
        /// </summary>
        public MemoryHeapFlags Flags; 
        
        /// <summary>
        /// 
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
    /// Structure specifying memory requirements.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct MemoryRequirements
    {
        /// <summary>
        /// pname:size is the size, in bytes, of the memory allocation
        /// required: for the resource.
        /// </summary>
        public DeviceSize Size; 
        
        /// <summary>
        /// pname:alignment is the alignment, in bytes, of the offset within
        /// the allocation required: for the resource.
        /// </summary>
        public DeviceSize Alignment; 
        
        /// <summary>
        /// pname:memoryTypeBits is a bitmask and contains one bit set for
        /// every supported memory type for the resource. Bit `i` is set if and
        /// only if the memory type `i` in the
        /// sname:VkPhysicalDeviceMemoryProperties structure for the physical
        /// device is supported for the resource.
        /// </summary>
        public uint MemoryTypeBits; 
        
        /// <summary>
        /// 
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
    /// Structure specifying memory type.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct MemoryType
    {
        /// <summary>
        /// pname:propertyFlags is a bitmask of properties for this memory
        /// type. The bits specified in pname:propertyFlags are: + --
        /// </summary>
        public MemoryPropertyFlags PropertyFlags; 
        
        /// <summary>
        /// pname:heapIndex describes which memory heap this memory type
        /// corresponds to, and must: be less than pname:memoryHeapCount from
        /// the sname:VkPhysicalDeviceMemoryProperties structure.
        /// </summary>
        public uint HeapIndex; 
        
        /// <summary>
        /// 
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
    /// Structure specifying a two-dimensional offset.
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
        /// 
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
    /// Structure specifying a three-dimensional offset.
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
        /// 
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
    /// Structure describing the fine-grained features that can be supported by
    /// an implementation.
    /// </para>
    /// <para>
    /// The members of the sname:VkPhysicalDeviceFeatures structure describe
    /// the following features:
    /// </para>
    /// <para>
    /// * pname:robustBufferAccess indicates that accesses to buffers are
    /// bounds-checked against the range of the buffer descriptor (as
    /// determined by sname:VkDescriptorBufferInfo::pname:range,
    /// sname:VkBufferViewCreateInfo::pname:range, or the size of the buffer).
    /// Out of bounds accesses must: not cause application termination, and the
    /// effects of shader loads, stores, and atomics must: conform to an
    /// implementation-dependent behavior as described below. ** A buffer
    /// access is considered to be out of bounds if any of the following are
    /// true: *** The pointer was formed by code:OpImageTexelPointer and the
    /// coordinate is less than zero or greater than or equal to the number of
    /// whole elements in the bound range. *** The pointer was not formed by
    /// code:OpImageTexelPointer and the object pointed to is not wholly
    /// contained within the bound range. + -- [NOTE] .Note ==== If a SPIR-V
    /// code:OpLoad instruction loads a structure and the tail end of the
    /// structure is out of bounds, then all members of the structure are
    /// considered out of bounds even if the members at the end are not
    /// statically used. ==== -- + *** If any buffer access in a given SPIR-V
    /// block is determined to be out of bounds, then any other access of the
    /// same type (load, store, or atomic) in the same SPIR-V block that
    /// accesses an address less than 16 bytes away from the out of bounds
    /// address may: also be considered out of bounds. ** Out-of-bounds buffer
    /// loads will return any of the following values: *** Values from anywhere
    /// within the memory range(s) bound to the buffer (possibly including
    /// bytes of memory past the end of the buffer, up to the end of the bound
    /// range). *** Zero values, or [eq]#(0,0,0,x)# vectors for vector reads
    /// where x is a valid value represented in the type of the vector
    /// components and may: be any of: **** 0, 1, or the maximum representable
    /// positive integer value, for signed or unsigned integer components ****
    /// 0.0 or 1.0, for floating-point components ** Out-of-bounds writes may:
    /// modify values within the memory range(s) bound to the buffer, but must:
    /// not modify any other memory. ** Out-of-bounds atomics may: modify
    /// values within the memory range(s) bound to the buffer, but must: not
    /// modify any other memory, and return an undefined value. ** Vertex input
    /// attributes are considered out of bounds if the address of the attribute
    /// plus the size of the attribute is greater than the size of the bound
    /// buffer. Further, if any vertex input attribute using a specific vertex
    /// input binding is out of bounds, then all vertex input attributes using
    /// that vertex input binding for that vertex shader invocation are
    /// considered out of bounds. *** If a vertex input attribute is out of
    /// bounds, it will be assigned one of the following values: **** Values
    /// from anywhere within the memory range(s) bound to the buffer, converted
    /// according to the format of the attribute. **** Zero values, format
    /// converted according to the format of the attribute. **** Zero values,
    /// or [eq]#(0,0,0,x)# vectors, as described above. ** If
    /// pname:robustBufferAccess is not enabled, out of bounds accesses may:
    /// corrupt any memory within the process and cause undefined behavior up
    /// to and including application termination. * pname:fullDrawIndexUint32
    /// indicates the full 32-bit range of indices is supported for indexed
    /// draw calls when using a elink:VkIndexType of
    /// ename:VK_INDEX_TYPE_UINT32. pname:maxDrawIndexedIndexValue is the
    /// maximum index value that may: be used (aside from the primitive restart
    /// index, which is always 2^32^-1 when the elink:VkIndexType is
    /// ename:VK_INDEX_TYPE_UINT32). If this feature is supported,
    /// pname:maxDrawIndexedIndexValue must: be 2^32^-1; otherwise it must: be
    /// no smaller than 2^24^-1. See
    /// &lt;&lt;features-limits-maxDrawIndexedIndexValue,maxDrawIndexedIndexValue&gt;&gt;. *
    /// pname:imageCubeArray indicates whether image views with a
    /// elink:VkImageViewType of ename:VK_IMAGE_VIEW_TYPE_CUBE_ARRAY can: be
    /// created, and that the corresponding code:SampledCubeArray and
    /// code:ImageCubeArray SPIR-V capabilities can: be used in shader code. *
    /// pname:independentBlend indicates whether the
    /// sname:VkPipelineColorBlendAttachmentState settings are controlled
    /// independently per-attachment. If this feature is not enabled, the
    /// sname:VkPipelineColorBlendAttachmentState settings for all color
    /// attachments must: be identical. Otherwise, a different
    /// sname:VkPipelineColorBlendAttachmentState can: be provided for each
    /// bound color attachment. * pname:geometryShader indicates whether
    /// geometry shaders are supported. If this feature is not enabled, the
    /// ename:VK_SHADER_STAGE_GEOMETRY_BIT and
    /// ename:VK_PIPELINE_STAGE_GEOMETRY_SHADER_BIT enum values must: not be
    /// used. This also indicates whether shader modules can: declare the
    /// code:Geometry capability. * pname:tessellationShader indicates whether
    /// tessellation control and evaluation shaders are supported. If this
    /// feature is not enabled, the
    /// ename:VK_SHADER_STAGE_TESSELLATION_CONTROL_BIT, ename:VK_SHADER_STAGE_TESSELLATION_EVALUATION_BIT,
    /// ename:VK_PIPELINE_STAGE_TESSELLATION_CONTROL_SHADER_BIT,
    /// ename:VK_PIPELINE_STAGE_TESSELLATION_EVALUATION_SHADER_BIT, and
    /// ename:VK_STRUCTURE_TYPE_PIPELINE_TESSELLATION_STATE_CREATE_INFO enum
    /// values must: not be used. This also indicates whether shader modules
    /// can: declare the code:Tessellation capability. *
    /// pname:sampleRateShading indicates whether per-sample shading and
    /// multisample interpolation are supported. If this feature is not
    /// enabled, the pname:sampleShadingEnable member of the
    /// sname:VkPipelineMultisampleStateCreateInfo structure must: be set to
    /// ename:VK_FALSE and the pname:minSampleShading member is ignored. This
    /// also indicates whether shader modules can: declare the
    /// code:SampleRateShading capability. * pname:dualSrcBlend indicates
    /// whether blend operations which take two sources are supported. If this
    /// feature is not enabled, the ename:VK_BLEND_FACTOR_SRC1_COLOR,
    /// ename:VK_BLEND_FACTOR_ONE_MINUS_SRC1_COLOR, ename:VK_BLEND_FACTOR_SRC1_ALPHA,
    /// and ename:VK_BLEND_FACTOR_ONE_MINUS_SRC1_ALPHA enum values must: not be
    /// used as source or destination blending factors. See
    /// &lt;&lt;framebuffer-dsb&gt;&gt;. * pname:logicOp indicates whether
    /// logic operations are supported. If this feature is not enabled, the
    /// pname:logicOpEnable member of the
    /// sname:VkPipelineColorBlendStateCreateInfo structure must: be set to
    /// ename:VK_FALSE, and the pname:logicOp member is ignored. *
    /// pname:multiDrawIndirect indicates whether multiple draw indirect is
    /// supported. If this feature is not enabled, the pname:drawCount
    /// parameter to the fname:vkCmdDrawIndirect and
    /// fname:vkCmdDrawIndexedIndirect commands must: be 0 or 1. The
    /// pname:maxDrawIndirectCount member of the sname:VkPhysicalDeviceLimits
    /// structure must: also be 1 if this feature is not supported. See
    /// &lt;&lt;features-limits-maxDrawIndirectCount,maxDrawIndirectCount&gt;&gt;. *
    /// pname:drawIndirectFirstInstance indicates whether indirect draw calls
    /// support the pname:firstInstance parameter. If this feature is not
    /// enabled, the pname:firstInstance member of all
    /// sname:VkDrawIndirectCommand and sname:VkDrawIndexedIndirectCommand
    /// structures that are provided to the fname:vkCmdDrawIndirect and
    /// fname:vkCmdDrawIndexedIndirect commands must: be 0. * pname:depthClamp
    /// indicates whether depth clamping is supported. If this feature is not
    /// enabled, the pname:depthClampEnable member of the
    /// sname:VkPipelineRasterizationStateCreateInfo structure must: be set to
    /// ename:VK_FALSE. Otherwise, setting pname:depthClampEnable to
    /// ename:VK_TRUE will enable depth clamping. * pname:depthBiasClamp
    /// indicates whether depth bias clamping is supported. If this feature is
    /// not enabled, the pname:depthBiasClamp member of the
    /// sname:VkPipelineRasterizationStateCreateInfo structure must: be set to
    /// 0.0 unless the ename:VK_DYNAMIC_STATE_DEPTH_BIAS dynamic state is
    /// enabled, and the pname:depthBiasClamp parameter to
    /// fname:vkCmdSetDepthBias must: be set to 0.0. * pname:fillModeNonSolid
    /// indicates whether point and wireframe fill modes are supported. If this
    /// feature is not enabled, the ename:VK_POLYGON_MODE_POINT and
    /// ename:VK_POLYGON_MODE_LINE enum values must: not be used. *
    /// pname:depthBounds indicates whether depth bounds tests are supported.
    /// If this feature is not enabled, the pname:depthBoundsTestEnable member
    /// of the sname:VkPipelineDepthStencilStateCreateInfo structure must: be
    /// set to ename:VK_FALSE. When pname:depthBoundsTestEnable is set to
    /// ename:VK_FALSE, the pname:minDepthBounds and pname:maxDepthBounds
    /// members of the sname:VkPipelineDepthStencilStateCreateInfo structure
    /// are ignored. * pname:wideLines indicates whether lines with width other
    /// than 1.0 are supported. If this feature is not enabled, the
    /// pname:lineWidth member of the
    /// sname:VkPipelineRasterizationStateCreateInfo structure must: be set to
    /// 1.0 unless the ename:VK_DYNAMIC_STATE_LINE_WIDTH dynamic state is
    /// enabled, and the pname:lineWidth parameter to fname:vkCmdSetLineWidth
    /// must: be set to 1.0. When this feature is supported, the range and
    /// granularity of supported line widths are indicated by the
    /// pname:lineWidthRange and pname:lineWidthGranularity members of the
    /// sname:VkPhysicalDeviceLimits structure, respectively. *
    /// pname:largePoints indicates whether points with size greater than 1.0
    /// are supported. If this feature is not enabled, only a point size of 1.0
    /// written by a shader is supported. The range and granularity of
    /// supported point sizes are indicated by the pname:pointSizeRange and
    /// pname:pointSizeGranularity members of the sname:VkPhysicalDeviceLimits
    /// structure, respectively. * pname:alphaToOne indicates whether the
    /// implementation is able to replace the alpha value of the color fragment
    /// output from the fragment shader with the maximum representable alpha
    /// value for fixed-point colors or 1.0 for floating-point colors. If this
    /// feature is not enabled, then the pname:alphaToOneEnable member of the
    /// sname:VkPipelineMultisampleStateCreateInfo structure must: be set to
    /// ename:VK_FALSE. Otherwise setting pname:alphaToOneEnable to
    /// ename:VK_TRUE will enable alpha-to-one behavior. * pname:multiViewport
    /// indicates whether more than one viewport is supported. If this feature
    /// is not enabled, the pname:viewportCount and pname:scissorCount members
    /// of the sname:VkPipelineViewportStateCreateInfo structure must: be set
    /// to 1. Similarly, the pname:viewportCount parameter to the
    /// fname:vkCmdSetViewport command and the pname:scissorCount parameter to
    /// the fname:vkCmdSetScissor command must: be 1, and the
    /// pname:firstViewport parameter to the fname:vkCmdSetViewport command and
    /// the pname:firstScissor parameter to the fname:vkCmdSetScissor command
    /// must: be 0. * pname:samplerAnisotropy indicates whether anisotropic
    /// filtering is supported. If this feature is not enabled, the
    /// pname:maxAnisotropy member of the sname:VkSamplerCreateInfo structure
    /// must: be 1.0. * pname:textureCompressionETC2 indicates whether the ETC2
    /// and EAC compressed texture formats are supported. If this feature is
    /// not enabled, the following formats must: not be used to create images:
    /// + -- * ename:VK_FORMAT_ETC2_R8G8B8_UNORM_BLOCK *
    /// ename:VK_FORMAT_ETC2_R8G8B8_SRGB_BLOCK *
    /// ename:VK_FORMAT_ETC2_R8G8B8A1_UNORM_BLOCK *
    /// ename:VK_FORMAT_ETC2_R8G8B8A1_SRGB_BLOCK *
    /// ename:VK_FORMAT_ETC2_R8G8B8A8_UNORM_BLOCK *
    /// ename:VK_FORMAT_ETC2_R8G8B8A8_SRGB_BLOCK *
    /// ename:VK_FORMAT_EAC_R11_UNORM_BLOCK *
    /// ename:VK_FORMAT_EAC_R11_SNORM_BLOCK *
    /// ename:VK_FORMAT_EAC_R11G11_UNORM_BLOCK *
    /// ename:VK_FORMAT_EAC_R11G11_SNORM_BLOCK -- +
    /// flink:vkGetPhysicalDeviceFormatProperties is used to check for the
    /// supported properties of individual formats. + *
    /// [[features-features-textureCompressionASTC_LDR]] pname:textureCompressionASTC_LDR
    /// indicates whether the ASTC LDR compressed texture formats are
    /// supported. If this feature is not enabled, the following formats must:
    /// not be used to create images: + -- *
    /// ename:VK_FORMAT_ASTC_4x4_UNORM_BLOCK *
    /// ename:VK_FORMAT_ASTC_4x4_SRGB_BLOCK *
    /// ename:VK_FORMAT_ASTC_5x4_UNORM_BLOCK *
    /// ename:VK_FORMAT_ASTC_5x4_SRGB_BLOCK *
    /// ename:VK_FORMAT_ASTC_5x5_UNORM_BLOCK *
    /// ename:VK_FORMAT_ASTC_5x5_SRGB_BLOCK *
    /// ename:VK_FORMAT_ASTC_6x5_UNORM_BLOCK *
    /// ename:VK_FORMAT_ASTC_6x5_SRGB_BLOCK *
    /// ename:VK_FORMAT_ASTC_6x6_UNORM_BLOCK *
    /// ename:VK_FORMAT_ASTC_6x6_SRGB_BLOCK *
    /// ename:VK_FORMAT_ASTC_8x5_UNORM_BLOCK *
    /// ename:VK_FORMAT_ASTC_8x5_SRGB_BLOCK *
    /// ename:VK_FORMAT_ASTC_8x6_UNORM_BLOCK *
    /// ename:VK_FORMAT_ASTC_8x6_SRGB_BLOCK *
    /// ename:VK_FORMAT_ASTC_8x8_UNORM_BLOCK *
    /// ename:VK_FORMAT_ASTC_8x8_SRGB_BLOCK *
    /// ename:VK_FORMAT_ASTC_10x5_UNORM_BLOCK *
    /// ename:VK_FORMAT_ASTC_10x5_SRGB_BLOCK *
    /// ename:VK_FORMAT_ASTC_10x6_UNORM_BLOCK *
    /// ename:VK_FORMAT_ASTC_10x6_SRGB_BLOCK *
    /// ename:VK_FORMAT_ASTC_10x8_UNORM_BLOCK *
    /// ename:VK_FORMAT_ASTC_10x8_SRGB_BLOCK *
    /// ename:VK_FORMAT_ASTC_10x10_UNORM_BLOCK *
    /// ename:VK_FORMAT_ASTC_10x10_SRGB_BLOCK *
    /// ename:VK_FORMAT_ASTC_12x10_UNORM_BLOCK *
    /// ename:VK_FORMAT_ASTC_12x10_SRGB_BLOCK *
    /// ename:VK_FORMAT_ASTC_12x12_UNORM_BLOCK *
    /// ename:VK_FORMAT_ASTC_12x12_SRGB_BLOCK -- +
    /// flink:vkGetPhysicalDeviceFormatProperties is used to check for the
    /// supported properties of individual formats. + *
    /// pname:textureCompressionBC indicates whether the BC compressed texture
    /// formats are supported. If this feature is not enabled, the following
    /// formats must: not be used to create images: + -- *
    /// ename:VK_FORMAT_BC1_RGB_UNORM_BLOCK *
    /// ename:VK_FORMAT_BC1_RGB_SRGB_BLOCK *
    /// ename:VK_FORMAT_BC1_RGBA_UNORM_BLOCK *
    /// ename:VK_FORMAT_BC1_RGBA_SRGB_BLOCK * ename:VK_FORMAT_BC2_UNORM_BLOCK *
    /// ename:VK_FORMAT_BC2_SRGB_BLOCK * ename:VK_FORMAT_BC3_UNORM_BLOCK *
    /// ename:VK_FORMAT_BC3_SRGB_BLOCK * ename:VK_FORMAT_BC4_UNORM_BLOCK *
    /// ename:VK_FORMAT_BC4_SNORM_BLOCK * ename:VK_FORMAT_BC5_UNORM_BLOCK *
    /// ename:VK_FORMAT_BC5_SNORM_BLOCK * ename:VK_FORMAT_BC6H_UFLOAT_BLOCK *
    /// ename:VK_FORMAT_BC6H_SFLOAT_BLOCK * ename:VK_FORMAT_BC7_UNORM_BLOCK *
    /// ename:VK_FORMAT_BC7_SRGB_BLOCK -- +
    /// flink:vkGetPhysicalDeviceFormatProperties is used to check for the
    /// supported properties of individual formats. + *
    /// pname:occlusionQueryPrecise indicates whether occlusion queries
    /// returning actual sample counts are supported. Occlusion queries are
    /// created in a sname:VkQueryPool by specifying the pname:queryType of
    /// ename:VK_QUERY_TYPE_OCCLUSION in the sname:VkQueryPoolCreateInfo
    /// structure which is passed to fname:vkCreateQueryPool. If this feature
    /// is enabled, queries of this type can: enable
    /// ename:VK_QUERY_CONTROL_PRECISE_BIT in the pname:flags parameter to
    /// fname:vkCmdBeginQuery. If this feature is not supported, the
    /// implementation supports only boolean occlusion queries. When any
    /// samples are passed, boolean queries will return a non-zero result
    /// value, otherwise a result value of zero is returned. When this feature
    /// is enabled and ename:VK_QUERY_CONTROL_PRECISE_BIT is set, occlusion
    /// queries will report the actual number of samples passed. *
    /// pname:pipelineStatisticsQuery indicates whether the pipeline statistics
    /// queries are supported. If this feature is not enabled, queries of type
    /// ename:VK_QUERY_TYPE_PIPELINE_STATISTICS cannot: be created, and none of
    /// the elink:VkQueryPipelineStatisticFlagBits bits can: be set in the
    /// pname:pipelineStatistics member of the sname:VkQueryPoolCreateInfo
    /// structure. * pname:vertexPipelineStoresAndAtomics indicates whether
    /// storage buffers and images support stores and atomic operations in the
    /// vertex, tessellation, and geometry shader stages. If this feature is
    /// not enabled, all storage image, storage texel buffers, and storage
    /// buffer variables used by these stages in shader modules must: be
    /// decorated with the code:NonWriteable decoration (or the code:readonly
    /// memory qualifier in GLSL). * pname:fragmentStoresAndAtomics indicates
    /// whether storage buffers and images support stores and atomic operations
    /// in the fragment shader stage. If this feature is not enabled, all
    /// storage image, storage texel buffers, and storage buffer variables used
    /// by the fragment stage in shader modules must: be decorated with the
    /// code:NonWriteable decoration (or the code:readonly memory qualifier in
    /// GLSL). * pname:shaderTessellationAndGeometryPointSize indicates whether
    /// the code:PointSize built-in decoration is available in the tessellation
    /// control, tessellation evaluation, and geometry shader stages. If this
    /// feature is not enabled, members decorated with the code:PointSize
    /// built-in decoration must: not be read from or written to and all points
    /// written from a tessellation or geometry shader will have a size of 1.0.
    /// This also indicates whether shader modules can: declare the
    /// code:TessellationPointSize capability for tessellation control and
    /// evaluation shaders, or if the shader modules can: declare the
    /// code:GeometryPointSize capability for geometry shaders. An
    /// implementation supporting this feature must: also support one or both
    /// of the
    /// &lt;&lt;features-features-tessellationShader,pname:tessellationShader&gt;&gt; or
    /// &lt;&lt;features-features-geometryShader,pname:geometryShader&gt;&gt;
    /// features. * pname:shaderImageGatherExtended indicates whether the
    /// extended set of image gather instructions are available in shader code.
    /// If this feature is not enabled, the code:OpImage*code:Gather
    /// instructions do not support the code:Offset and code:ConstOffsets
    /// operands. This also indicates whether shader modules can: declare the
    /// code:ImageGatherExtended capability. *
    /// pname:shaderStorageImageExtendedFormats indicates whether the extended
    /// storage image formats are available in shader code. If this feature is
    /// not enabled, the formats requiring the code:StorageImageExtendedFormats
    /// capability are not supported for storage images. This also indicates
    /// whether shader modules can: declare the
    /// code:StorageImageExtendedFormats capability. *
    /// pname:shaderStorageImageMultisample indicates whether multisampled
    /// storage images are supported. If this feature is not enabled, images
    /// that are created with a pname:usage that includes
    /// ename:VK_IMAGE_USAGE_STORAGE_BIT must: be created with pname:samples
    /// equal to ename:VK_SAMPLE_COUNT_1_BIT. This also indicates whether
    /// shader modules can: declare the code:StorageImageMultisample
    /// capability. * pname:shaderStorageImageReadWithoutFormat indicates
    /// whether storage images require a format qualifier to be specified when
    /// reading from storage images. If this feature is not enabled, the
    /// code:OpImageRead instruction must: not have an code:OpTypeImage of
    /// code:Unknown. This also indicates whether shader modules can: declare
    /// the code:StorageImageReadWithoutFormat capability. *
    /// pname:shaderStorageImageWriteWithoutFormat indicates whether storage
    /// images require a format qualifier to be specified when writing to
    /// storage images. If this feature is not enabled, the code:OpImageWrite
    /// instruction must: not have an code:OpTypeImage of code:Unknown. This
    /// also indicates whether shader modules can: declare the
    /// code:StorageImageWriteWithoutFormat capability. *
    /// pname:shaderUniformBufferArrayDynamicIndexing indicates whether arrays
    /// of uniform buffers can: be indexed by _dynamically uniform_ integer
    /// expressions in shader code. If this feature is not enabled, resources
    /// with a descriptor type of ename:VK_DESCRIPTOR_TYPE_UNIFORM_BUFFER or
    /// ename:VK_DESCRIPTOR_TYPE_UNIFORM_BUFFER_DYNAMIC must: be indexed only
    /// by constant integral expressions when aggregated into arrays in shader
    /// code. This also indicates whether shader modules can: declare the
    /// code:UniformBufferArrayDynamicIndexing capability. *
    /// pname:shaderSampledImageArrayDynamicIndexing indicates whether arrays
    /// of samplers or sampled images can: be indexed by dynamically uniform
    /// integer expressions in shader code. If this feature is not enabled,
    /// resources with a descriptor type of ename:VK_DESCRIPTOR_TYPE_SAMPLER,
    /// ename:VK_DESCRIPTOR_TYPE_COMBINED_IMAGE_SAMPLER, or
    /// ename:VK_DESCRIPTOR_TYPE_SAMPLED_IMAGE must: be indexed only by
    /// constant integral expressions when aggregated into arrays in shader
    /// code. This also indicates whether shader modules can: declare the
    /// code:SampledImageArrayDynamicIndexing capability. *
    /// pname:shaderStorageBufferArrayDynamicIndexing indicates whether arrays
    /// of storage buffers can: be indexed by dynamically uniform integer
    /// expressions in shader code. If this feature is not enabled, resources
    /// with a descriptor type of ename:VK_DESCRIPTOR_TYPE_STORAGE_BUFFER or
    /// ename:VK_DESCRIPTOR_TYPE_STORAGE_BUFFER_DYNAMIC must: be indexed only
    /// by constant integral expressions when aggregated into arrays in shader
    /// code. This also indicates whether shader modules can: declare the
    /// code:StorageBufferArrayDynamicIndexing capability. *
    /// pname:shaderStorageImageArrayDynamicIndexing indicates whether arrays
    /// of storage images can: be indexed by dynamically uniform integer
    /// expressions in shader code. If this feature is not enabled, resources
    /// with a descriptor type of ename:VK_DESCRIPTOR_TYPE_STORAGE_IMAGE must:
    /// be indexed only by constant integral expressions when aggregated into
    /// arrays in shader code. This also indicates whether shader modules can:
    /// declare the code:StorageImageArrayDynamicIndexing capability. *
    /// pname:shaderClipDistance indicates whether clip distances are supported
    /// in shader code. If this feature is not enabled, any members decorated
    /// with the code:ClipDistance built-in decoration must: not be read from
    /// or written to in shader modules. This also indicates whether shader
    /// modules can: declare the code:ClipDistance capability. *
    /// pname:shaderCullDistance indicates whether cull distances are supported
    /// in shader code. If this feature is not enabled, any members decorated
    /// with the code:CullDistance built-in decoration must: not be read from
    /// or written to in shader modules. This also indicates whether shader
    /// modules can: declare the code:CullDistance capability. *
    /// pname:shaderFloat64 indicates whether 64-bit floats (doubles) are
    /// supported in shader code. If this feature is not enabled, 64-bit
    /// floating-point types must: not be used in shader code. This also
    /// indicates whether shader modules can: declare the code:Float64
    /// capability. * pname:shaderInt64 indicates whether 64-bit integers
    /// (signed and unsigned) are supported in shader code. If this feature is
    /// not enabled, 64-bit integer types must: not be used in shader code.
    /// This also indicates whether shader modules can: declare the code:Int64
    /// capability. * pname:shaderInt16 indicates whether 16-bit integers
    /// (signed and unsigned) are supported in shader code. If this feature is
    /// not enabled, 16-bit integer types must: not be used in shader code.
    /// This also indicates whether shader modules can: declare the code:Int16
    /// capability. * pname:shaderResourceResidency indicates whether image
    /// operations that return resource residency information are supported in
    /// shader code. If this feature is not enabled, the code:OpImageSparse*
    /// instructions must: not be used in shader code. This also indicates
    /// whether shader modules can: declare the code:SparseResidency
    /// capability. The feature requires at least one of the
    /// ptext:sparseResidency* features to be supported. *
    /// pname:shaderResourceMinLod indicates whether image operations that
    /// specify the minimum resource level-of-detail (LOD) are supported in
    /// shader code. If this feature is not enabled, the code:MinLod image
    /// operand must: not be used in shader code. This also indicates whether
    /// shader modules can: declare the code:MinLod capability. *
    /// pname:sparseBinding indicates whether resource memory can: be managed
    /// at opaque sparse block level instead of at the object level. If this
    /// feature is not enabled, resource memory must: be bound only on a
    /// per-object basis using the fname:vkBindBufferMemory and
    /// fname:vkBindImageMemory commands. In this case, buffers and images
    /// must: not be created with ename:VK_BUFFER_CREATE_SPARSE_BINDING_BIT and
    /// ename:VK_IMAGE_CREATE_SPARSE_BINDING_BIT set in the pname:flags member
    /// of the sname:VkBufferCreateInfo and sname:VkImageCreateInfo structures,
    /// respectively. Otherwise resource memory can: be managed as described in
    /// &lt;&lt;sparsememory-sparseresourcefeatures,Sparse Resource
    /// Features&gt;&gt;. * pname:sparseResidencyBuffer indicates whether the
    /// device can: access partially resident buffers. If this feature is not
    /// enabled, buffers must: not be created with
    /// ename:VK_BUFFER_CREATE_SPARSE_RESIDENCY_BIT set in the pname:flags
    /// member of the sname:VkBufferCreateInfo structure. *
    /// pname:sparseResidencyImage2D indicates whether the device can: access
    /// partially resident 2D images with 1 sample per pixel. If this feature
    /// is not enabled, images with an pname:imageType of
    /// ename:VK_IMAGE_TYPE_2D and pname:samples set to
    /// ename:VK_SAMPLE_COUNT_1_BIT must: not be created with
    /// ename:VK_IMAGE_CREATE_SPARSE_RESIDENCY_BIT set in the pname:flags
    /// member of the sname:VkImageCreateInfo structure. *
    /// pname:sparseResidencyImage3D indicates whether the device can: access
    /// partially resident 3D images. If this feature is not enabled, images
    /// with an pname:imageType of ename:VK_IMAGE_TYPE_3D must: not be created
    /// with ename:VK_IMAGE_CREATE_SPARSE_RESIDENCY_BIT set in the pname:flags
    /// member of the sname:VkImageCreateInfo structure. *
    /// pname:sparseResidency2Samples indicates whether the physical device
    /// can: access partially resident 2D images with 2 samples per pixel. If
    /// this feature is not enabled, images with an pname:imageType of
    /// ename:VK_IMAGE_TYPE_2D and pname:samples set to
    /// ename:VK_SAMPLE_COUNT_2_BIT must: not be created with
    /// ename:VK_IMAGE_CREATE_SPARSE_RESIDENCY_BIT set in the pname:flags
    /// member of the sname:VkImageCreateInfo structure. *
    /// pname:sparseResidency4Samples indicates whether the physical device
    /// can: access partially resident 2D images with 4 samples per pixel. If
    /// this feature is not enabled, images with an pname:imageType of
    /// ename:VK_IMAGE_TYPE_2D and pname:samples set to
    /// ename:VK_SAMPLE_COUNT_4_BIT must: not be created with
    /// ename:VK_IMAGE_CREATE_SPARSE_RESIDENCY_BIT set in the pname:flags
    /// member of the sname:VkImageCreateInfo structure. *
    /// pname:sparseResidency8Samples indicates whether the physical device
    /// can: access partially resident 2D images with 8 samples per pixel. If
    /// this feature is not enabled, images with an pname:imageType of
    /// ename:VK_IMAGE_TYPE_2D and pname:samples set to
    /// ename:VK_SAMPLE_COUNT_8_BIT must: not be created with
    /// ename:VK_IMAGE_CREATE_SPARSE_RESIDENCY_BIT set in the pname:flags
    /// member of the sname:VkImageCreateInfo structure. *
    /// pname:sparseResidency16Samples indicates whether the physical device
    /// can: access partially resident 2D images with 16 samples per pixel. If
    /// this feature is not enabled, images with an pname:imageType of
    /// ename:VK_IMAGE_TYPE_2D and pname:samples set to
    /// ename:VK_SAMPLE_COUNT_16_BIT must: not be created with
    /// ename:VK_IMAGE_CREATE_SPARSE_RESIDENCY_BIT set in the pname:flags
    /// member of the sname:VkImageCreateInfo structure. *
    /// pname:sparseResidencyAliased indicates whether the physical device can:
    /// correctly access data aliased into multiple locations. If this feature
    /// is not enabled, the ename:VK_BUFFER_CREATE_SPARSE_ALIASED_BIT and
    /// ename:VK_IMAGE_CREATE_SPARSE_ALIASED_BIT enum values must: not be used
    /// in pname:flags members of the sname:VkBufferCreateInfo and
    /// sname:VkImageCreateInfo structures, respectively. *
    /// pname:variableMultisampleRate indicates whether all pipelines that will
    /// be bound to a command buffer during a subpass with no attachments must:
    /// have the same value for
    /// sname:VkPipelineMultisampleStateCreateInfo::pname:rasterizationSamples. If
    /// set to ename:VK_TRUE, the implementation supports variable multisample
    /// rates in a subpass with no attachments. If set to ename:VK_FALSE, then
    /// all pipelines bound in such a subpass must: have the same multisample
    /// rate. This has no effect in situations where a subpass uses any
    /// attachments. * pname:inheritedQueries indicates whether a secondary
    /// command buffer may: be executed while a query is active.
    /// </para>
    /// <para>
    /// .Valid Usage **** * If any member of this structure is ename:VK_FALSE,
    /// as returned by flink:vkGetPhysicalDeviceFeatures, then it must: be
    /// ename:VK_FALSE when passed as part of the sname:VkDeviceCreateInfo
    /// struct when creating a device ****
    /// </para>
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
        public Bool32 FullDrawIndexUInt32; 
        
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
        /// 
        /// </summary>
        public override string ToString()
        {
            var builder = new StringBuilder();
            builder.AppendLine("PhysicalDeviceFeatures");
            builder.AppendLine("{");
            builder.AppendLine($"RobustBufferAccess: {this.RobustBufferAccess}");
            builder.AppendLine($"FullDrawIndexUInt32: {this.FullDrawIndexUInt32}");
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
    /// Structure specifying physical device sparse memory properties.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct PhysicalDeviceSparseProperties
    {
        /// <summary>
        /// pname:residencyStandard2DBlockShape is ename:VK_TRUE if the
        /// physical device will access all single-sample 2D sparse resources
        /// using the standard sparse image block shapes (based on image
        /// format), as described in the
        /// &lt;&lt;sparsememory-sparseblockshapessingle,Standard Sparse Image
        /// Block Shapes (Single Sample)&gt;&gt; table. If this property is not
        /// supported the value returned in the pname:imageGranularity member
        /// of the sname:VkSparseImageFormatProperties structure for
        /// single-sample 2D images is not required: to match the standard
        /// sparse image block dimensions listed in the table.
        /// </summary>
        public Bool32 ResidencyStandard2DBlockShape; 
        
        /// <summary>
        /// pname:residencyStandard2DMultisampleBlockShape is ename:VK_TRUE if
        /// the physical device will access all multisample 2D sparse resources
        /// using the standard sparse image block shapes (based on image
        /// format), as described in the
        /// &lt;&lt;sparsememory-sparseblockshapesmsaa,Standard Sparse Image
        /// Block Shapes (MSAA)&gt;&gt; table. If this property is not
        /// supported, the value returned in the pname:imageGranularity member
        /// of the sname:VkSparseImageFormatProperties structure for
        /// multisample 2D images is not required: to match the standard sparse
        /// image block dimensions listed in the table.
        /// </summary>
        public Bool32 ResidencyStandard2DMultisampleBlockShape; 
        
        /// <summary>
        /// pname:residencyStandard3DBlockShape is ename:VK_TRUE if the
        /// physical device will access all 3D sparse resources using the
        /// standard sparse image block shapes (based on image format), as
        /// described in the
        /// &lt;&lt;sparsememory-sparseblockshapessingle,Standard Sparse Image
        /// Block Shapes (Single Sample)&gt;&gt; table. If this property is not
        /// supported, the value returned in the pname:imageGranularity member
        /// of the sname:VkSparseImageFormatProperties structure for 3D images
        /// is not required: to match the standard sparse image block
        /// dimensions listed in the table.
        /// </summary>
        public Bool32 ResidencyStandard3DBlockShape; 
        
        /// <summary>
        /// pname:residencyAlignedMipSize is ename:VK_TRUE if images with mip
        /// level dimensions that are not integer multiples of the
        /// corresponding dimensions of the sparse image block may: be placed
        /// in the mip tail. If this property is not reported, only mip levels
        /// with dimensions smaller than the pname:imageGranularity member of
        /// the sname:VkSparseImageFormatProperties structure will be placed in
        /// the mip tail. If this property is reported the implementation is
        /// allowed to return ename:VK_SPARSE_IMAGE_FORMAT_ALIGNED_MIP_SIZE_BIT
        /// in the pname:flags member of sname:VkSparseImageFormatProperties,
        /// indicating that mip level dimensions that are not integer multiples
        /// of the corresponding dimensions of the sparse image block will be
        /// placed in the mip tail.
        /// </summary>
        public Bool32 ResidencyAlignedMipSize; 
        
        /// <summary>
        /// pname:residencyNonResidentStrict specifies whether the physical
        /// device can: consistently access non-resident regions of a resource.
        /// If this property is ename:VK_TRUE, access to non-resident regions
        /// of resources will be guaranteed to return values as if the resource
        /// were populated with 0; writes to non-resident regions will be
        /// discarded.
        /// </summary>
        public Bool32 ResidencyNonResidentStrict; 
        
        /// <summary>
        /// 
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
    /// <para>
    /// .Valid Usage **** * If the &lt;&lt;features-features-dualSrcBlend,dual
    /// source blending&gt;&gt; feature is not enabled,
    /// pname:srcColorBlendFactor must: not be
    /// ename:VK_BLEND_FACTOR_SRC1_COLOR, ename:VK_BLEND_FACTOR_ONE_MINUS_SRC1_COLOR,
    /// ename:VK_BLEND_FACTOR_SRC1_ALPHA, or
    /// ename:VK_BLEND_FACTOR_ONE_MINUS_SRC1_ALPHA * If the
    /// &lt;&lt;features-features-dualSrcBlend,dual source blending&gt;&gt;
    /// feature is not enabled, pname:dstColorBlendFactor must: not be
    /// ename:VK_BLEND_FACTOR_SRC1_COLOR, ename:VK_BLEND_FACTOR_ONE_MINUS_SRC1_COLOR,
    /// ename:VK_BLEND_FACTOR_SRC1_ALPHA, or
    /// ename:VK_BLEND_FACTOR_ONE_MINUS_SRC1_ALPHA * If the
    /// &lt;&lt;features-features-dualSrcBlend,dual source blending&gt;&gt;
    /// feature is not enabled, pname:srcAlphaBlendFactor must: not be
    /// ename:VK_BLEND_FACTOR_SRC1_COLOR, ename:VK_BLEND_FACTOR_ONE_MINUS_SRC1_COLOR,
    /// ename:VK_BLEND_FACTOR_SRC1_ALPHA, or
    /// ename:VK_BLEND_FACTOR_ONE_MINUS_SRC1_ALPHA * If the
    /// &lt;&lt;features-features-dualSrcBlend,dual source blending&gt;&gt;
    /// feature is not enabled, pname:dstAlphaBlendFactor must: not be
    /// ename:VK_BLEND_FACTOR_SRC1_COLOR, ename:VK_BLEND_FACTOR_ONE_MINUS_SRC1_COLOR,
    /// ename:VK_BLEND_FACTOR_SRC1_ALPHA, or
    /// ename:VK_BLEND_FACTOR_ONE_MINUS_SRC1_ALPHA ****
    /// </para>
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct PipelineColorBlendAttachmentState
    {
        /// <summary>
        /// pname:blendEnable controls whether blending is enabled for the
        /// corresponding color attachment. If blending is not enabled, the
        /// source fragment's color for that attachment is passed through
        /// unmodified.
        /// </summary>
        public Bool32 BlendEnable; 
        
        /// <summary>
        /// pname:srcColorBlendFactor selects which blend factor is used to
        /// determine the source factors [eq]#(S~r~,S~g~,S~b~)#.
        /// </summary>
        public BlendFactor SourceColorBlendFactor; 
        
        /// <summary>
        /// pname:dstColorBlendFactor selects which blend factor is used to
        /// determine the destination factors [eq]#(D~r~,D~g~,D~b~)#.
        /// </summary>
        public BlendFactor DestinationColorBlendFactor; 
        
        /// <summary>
        /// pname:colorBlendOp selects which blend operation is used to
        /// calculate the RGB values to write to the color attachment.
        /// </summary>
        public BlendOp ColorBlendOp; 
        
        /// <summary>
        /// pname:srcAlphaBlendFactor selects which blend factor is used to
        /// determine the source factor [eq]#S~a~#.
        /// </summary>
        public BlendFactor SourceAlphaBlendFactor; 
        
        /// <summary>
        /// pname:dstAlphaBlendFactor selects which blend factor is used to
        /// determine the destination factor [eq]#D~a~#.
        /// </summary>
        public BlendFactor DestinationAlphaBlendFactor; 
        
        /// <summary>
        /// pname:alphaBlendOp selects which blend operation is use to
        /// calculate the alpha values to write to the color attachment.
        /// </summary>
        public BlendOp AlphaBlendOp; 
        
        /// <summary>
        /// pname:colorWriteMask is a bitmask selecting which of the R, G, B,
        /// and/or A components are enabled for writing, as described later in
        /// this chapter.
        /// </summary>
        public ColorComponentFlags ColorWriteMask; 
        
        /// <summary>
        /// 
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
    /// <para>
    /// .Valid Usage **** * pname:offset must: be less than
    /// sname:VkPhysicalDeviceLimits::pname:maxPushConstantsSize * pname:size
    /// must: be greater than `0` * pname:size must: be a multiple of `4` *
    /// pname:size must: be less than or equal to
    /// sname:VkPhysicalDeviceLimits::pname:maxPushConstantsSize minus
    /// pname:offset ****
    /// </para>
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct PushConstantRange
    {
        /// <summary>
        /// pname:stageFlags is a set of stage flags describing the shader
        /// stages that will access a range of push constants. If a particular
        /// stage is not included in the range, then accessing members of that
        /// range of push constants from the corresponding shader stage will
        /// result in undefined data being read.
        /// </summary>
        public ShaderStageFlags StageFlags; 
        
        /// <summary>
        /// pname:offset and pname:size are the start offset and size,
        /// respectively, consumed by the range. Both pname:offset and
        /// pname:size are in units of bytes and must: be a multiple of 4. The
        /// layout of the push constant variables is specified in the shader.
        /// </summary>
        public uint Offset; 
        
        /// <summary>
        /// -
        /// </summary>
        public uint Size; 
        
        /// <summary>
        /// 
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
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct QueueFamilyProperties
    {
        /// <summary>
        /// pname:queueFlags contains flags indicating the capabilities of the
        /// queues in this queue family.
        /// </summary>
        public QueueFlags QueueFlags; 
        
        /// <summary>
        /// pname:queueCount is the unsigned integer count of queues in this
        /// queue family.
        /// </summary>
        public uint QueueCount; 
        
        /// <summary>
        /// pname:timestampValidBits is the unsigned integer count of
        /// meaningful bits in the timestamps written via
        /// fname:vkCmdWriteTimestamp. The valid range for the count is 36..64
        /// bits, or a value of 0, indicating no support for timestamps. Bits
        /// outside the valid range are guaranteed to be zeros.
        /// </summary>
        public uint TimestampValidBits; 
        
        /// <summary>
        /// pname:minImageTransferGranularity is the minimum granularity
        /// supported for image transfer operations on the queues in this queue
        /// family.
        /// </summary>
        public Extent3D MinImageTransferGranularity; 
        
        /// <summary>
        /// 
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
    /// Structure specifying a two-dimensional subregion.
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
        /// 
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
    /// Structure specifying sparse image format properties.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct SparseImageFormatProperties
    {
        /// <summary>
        /// pname:aspectMask is a bitmask of elink:VkImageAspectFlagBits
        /// specifying which aspects of the image the properties apply to.
        /// </summary>
        public ImageAspectFlags AspectMask; 
        
        /// <summary>
        /// pname:imageGranularity is the width, height, and depth of the
        /// sparse image block in texels or compressed texel blocks.
        /// </summary>
        public Extent3D ImageGranularity; 
        
        /// <summary>
        /// pname:flags is a bitmask specifying additional information about
        /// the sparse resource. Bits which can: be set include: + --
        /// </summary>
        public SparseImageFormatFlags Flags; 
        
        /// <summary>
        /// 
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
    /// Structure specifying sparse image memory requirements.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct SparseImageMemoryRequirements
    {
        /// <summary>
        /// -
        /// </summary>
        public SparseImageFormatProperties FormatProperties; 
        
        /// <summary>
        /// pname:imageMipTailFirstLod is the first mip level at which image
        /// subresources are included in the mip tail region.
        /// </summary>
        public uint ImageMipTailFirstLod; 
        
        /// <summary>
        /// pname:imageMipTailSize is the memory size (in bytes) of the mip
        /// tail region. If pname:formatProperties.flags contains
        /// ename:VK_SPARSE_IMAGE_FORMAT_SINGLE_MIPTAIL_BIT, this is the size
        /// of the whole mip tail, otherwise this is the size of the mip tail
        /// of a single array layer. This value is guaranteed to be a multiple
        /// of the sparse block size in bytes.
        /// </summary>
        public DeviceSize ImageMipTailSize; 
        
        /// <summary>
        /// pname:imageMipTailOffset is the opaque memory offset used with
        /// slink:VkSparseImageOpaqueMemoryBindInfo to bind the mip tail
        /// region(s).
        /// </summary>
        public DeviceSize ImageMipTailOffset; 
        
        /// <summary>
        /// pname:imageMipTailStride is the offset stride between each
        /// array-layer's mip tail, if pname:formatProperties.flags does not
        /// contain ename:VK_SPARSE_IMAGE_FORMAT_SINGLE_MIPTAIL_BIT (otherwise
        /// the value is undefined).
        /// </summary>
        public DeviceSize ImageMipTailStride; 
        
        /// <summary>
        /// 
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
    /// <para>
    /// If a pname:constantID value is not a specialization constant ID used in
    /// the shader, that map entry does not affect the behavior of the
    /// pipeline.
    /// </para>
    /// <para>
    /// .Valid Usage **** * For a pname:constantID specialization constant
    /// declared in a shader, pname:size must: match the byte size of the
    /// pname:constantID. If the specialization constant is of type
    /// code:boolean, pname:size must: be the byte size of basetype:VkBool32
    /// ****
    /// </para>
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct SpecializationMapEntry
    {
        /// <summary>
        /// pname:constantID is the ID of the specialization constant in
        /// SPIR-V.
        /// </summary>
        public uint ConstantID; 
        
        /// <summary>
        /// pname:offset is the byte offset of the specialization constant
        /// value within the supplied data buffer.
        /// </summary>
        public uint Offset; 
        
        /// <summary>
        /// pname:size is the byte size of the specialization constant value
        /// within the supplied data buffer.
        /// </summary>
        public Size Size; 
        
        /// <summary>
        /// 
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
    /// Structure specifying stencil operation state.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct StencilOpState
    {
        /// <summary>
        /// pname:failOp is the action performed on samples that fail the
        /// stencil test.
        /// </summary>
        public StencilOp FailOp; 
        
        /// <summary>
        /// pname:passOp is the action performed on samples that pass both the
        /// depth and stencil tests.
        /// </summary>
        public StencilOp PassOp; 
        
        /// <summary>
        /// pname:depthFailOp is the action performed on samples that pass the
        /// stencil test and fail the depth test.
        /// </summary>
        public StencilOp DepthFailOp; 
        
        /// <summary>
        /// pname:compareOp is the comparison operator used in the stencil
        /// test.
        /// </summary>
        public CompareOp CompareOp; 
        
        /// <summary>
        /// pname:compareMask selects the bits of the unsigned integer stencil
        /// values participating in the stencil test.
        /// </summary>
        public uint CompareMask; 
        
        /// <summary>
        /// pname:writeMask selects the bits of the unsigned integer stencil
        /// values updated by the stencil test in the stencil framebuffer
        /// attachment.
        /// </summary>
        public uint WriteMask; 
        
        /// <summary>
        /// pname:reference is an integer reference value that is used in the
        /// unsigned stencil comparison.
        /// </summary>
        public uint Reference; 
        
        /// <summary>
        /// 
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
    /// Structure specifying a subpass dependency.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct SubpassDependency
    {
        /// <summary>
        /// pname:srcSubpass and pname:dstSubpass are the subpass indices of
        /// the producer and consumer subpasses, respectively. pname:srcSubpass
        /// and pname:dstSubpass can: also have the special value
        /// ename:VK_SUBPASS_EXTERNAL. The source subpass must: always be a
        /// lower numbered subpass than the destination subpass (excluding
        /// external subpasses and
        /// &lt;&lt;synchronization-pipeline-barriers-subpass-self-dependencies, self-dependencies&gt;&gt;),
        /// so that the order of subpass descriptions is a valid execution
        /// ordering, avoiding cycles in the dependency graph.
        /// </summary>
        public uint SourceSubpass; 
        
        /// <summary>
        /// -
        /// </summary>
        public uint DestinationSubpass; 
        
        /// <summary>
        /// pname:srcStageMask, pname:dstStageMask, pname:srcAccessMask,
        /// pname:dstAccessMask, and pname:dependencyFlags describe an
        /// &lt;&lt;synchronization-execution-and-memory-dependencies,execution and
        /// memory dependency&gt;&gt; between subpasses. The bits that can: be
        /// included in pname:dependencyFlags are: + --
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
        /// 
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
    /// <para>
    /// For images created with linear tiling, pname:rowPitch, pname:arrayPitch
    /// and pname:depthPitch describe the layout of the image subresource in
    /// linear memory. For uncompressed formats, pname:rowPitch is the number
    /// of bytes between texels with the same x coordinate in adjacent rows (y
    /// coordinates differ by one). pname:arrayPitch is the number of bytes
    /// between texels with the same x and y coordinate in adjacent array
    /// layers of the image (array layer values differ by one).
    /// pname:depthPitch is the number of bytes between texels with the same x
    /// and y coordinate in adjacent slices of a 3D image (z coordinates differ
    /// by one). Expressed as an addressing formula, the starting byte of a
    /// texel in the image subresource has address:
    /// </para>
    /// <para>
    /// [source,c] --------------------------------------------------- //
    /// (x,y,z,layer) are in texel coordinates address(x,y,z,layer) =
    /// layer*arrayPitch + z*depthPitch + y*rowPitch + x*elementSize + offset
    /// ---------------------------------------------------
    /// </para>
    /// <para>
    /// For compressed formats, the pname:rowPitch is the number of bytes
    /// between compressed texel blocks in adjacent rows. pname:arrayPitch is
    /// the number of bytes between compressed texel blocks in adjacent array
    /// layers. pname:depthPitch is the number of bytes between compressed
    /// texel blocks in adjacent slices of a 3D image.
    /// </para>
    /// <para>
    /// [source,c] --------------------------------------------------- //
    /// (x,y,z,layer) are in compressed texel block coordinates
    /// address(x,y,z,layer) = layer*arrayPitch + z*depthPitch + y*rowPitch +
    /// x*compressedTexelBlockByteSize + offset;
    /// ---------------------------------------------------
    /// </para>
    /// <para>
    /// pname:arrayPitch is undefined for images that were not created as
    /// arrays. pname:depthPitch is defined only for 3D images.
    /// </para>
    /// <para>
    /// For color formats, the pname:aspectMask member of
    /// sname:VkImageSubresource must: be ename:VK_IMAGE_ASPECT_COLOR_BIT. For
    /// depth/stencil formats, pname:aspectMask must: be either
    /// ename:VK_IMAGE_ASPECT_DEPTH_BIT or ename:VK_IMAGE_ASPECT_STENCIL_BIT.
    /// On implementations that store depth and stencil aspects separately,
    /// querying each of these image subresource layouts will return a
    /// different pname:offset and pname:size representing the region of memory
    /// used for that aspect. On implementations that store depth and stencil
    /// aspects interleaved, the same pname:offset and pname:size are returned
    /// and represent the interleaved memory allocation.
    /// </para>
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct SubresourceLayout
    {
        /// <summary>
        /// pname:offset is the byte offset from the start of the image where
        /// the image subresource begins.
        /// </summary>
        public DeviceSize Offset; 
        
        /// <summary>
        /// pname:size is the size in bytes of the image subresource.
        /// pname:size includes any extra memory that is required based on
        /// pname:rowPitch.
        /// </summary>
        public DeviceSize Size; 
        
        /// <summary>
        /// pname:rowPitch describes the number of bytes between each row of
        /// texels in an image.
        /// </summary>
        public DeviceSize RowPitch; 
        
        /// <summary>
        /// pname:arrayPitch describes the number of bytes between each array
        /// layer of an image.
        /// </summary>
        public DeviceSize ArrayPitch; 
        
        /// <summary>
        /// pname:depthPitch describes the number of bytes between each slice
        /// of 3D image.
        /// </summary>
        public DeviceSize DepthPitch; 
        
        /// <summary>
        /// 
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
    /// <para>
    /// [NOTE] .Note ==== Formulas such as [eq]#min(N, pname:maxImageCount)#
    /// are not correct, since pname:maxImageCount may: be zero. ====
    /// </para>
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct SurfaceCapabilities
    {
        /// <summary>
        /// pname:minImageCount is the minimum number of images the specified
        /// device supports for a swapchain created for the surface.
        /// </summary>
        public uint MinImageCount; 
        
        /// <summary>
        /// pname:maxImageCount is the maximum number of images the specified
        /// device supports for a swapchain created for the surface. A value of
        /// 0 means that there is no limit on the number of images, though
        /// there may: be limits related to the total amount of memory used by
        /// swapchain images.
        /// </summary>
        public uint MaxImageCount; 
        
        /// <summary>
        /// pname:currentExtent is the current width and height of the surface,
        /// or the special value [eq]#(0xFFFFFFFF, 0xFFFFFFFF)# indicating that
        /// the surface size will be determined by the extent of a swapchain
        /// targeting the surface.
        /// </summary>
        public Extent2D CurrentExtent; 
        
        /// <summary>
        /// pname:minImageExtent contains the smallest valid swapchain extent
        /// for the surface on the specified device.
        /// </summary>
        public Extent2D MinImageExtent; 
        
        /// <summary>
        /// pname:maxImageExtent contains the largest valid swapchain extent
        /// for the surface on the specified device.
        /// </summary>
        public Extent2D MaxImageExtent; 
        
        /// <summary>
        /// pname:maxImageArrayLayers is the maximum number of layers swapchain
        /// images can: have for a swapchain created for this device and
        /// surface.
        /// </summary>
        public uint MaxImageArrayLayers; 
        
        /// <summary>
        /// pname:supportedTransforms is a bitmask of
        /// elink:VkSurfaceTransformFlagBitsKHR, describing the presentation
        /// transforms supported for the surface on the specified device.
        /// </summary>
        public SurfaceTransformFlags SupportedTransforms; 
        
        /// <summary>
        /// pname:currentTransform is a bitmask of
        /// elink:VkSurfaceTransformFlagBitsKHR, describing the surface's
        /// current transform relative to the presentation engine's natural
        /// orientation.
        /// </summary>
        public SurfaceTransformFlags CurrentTransform; 
        
        /// <summary>
        /// pname:supportedCompositeAlpha is a bitmask of
        /// elink:VkCompositeAlphaFlagBitsKHR, representing the alpha
        /// compositing modes supported by the presentation engine for the
        /// surface on the specified device. Opaque composition can: be
        /// achieved in any alpha compositing mode by either using a swapchain
        /// image format that has no alpha component, or by ensuring that all
        /// pixels in the swapchain images have an alpha value of 1.0.
        /// </summary>
        public CompositeAlphaFlags SupportedCompositeAlpha; 
        
        /// <summary>
        /// pname:supportedUsageFlags is a bitmask of
        /// elink:VkImageUsageFlagBits representing the ways the application
        /// can: use the presentable images of a swapchain created for the
        /// surface on the specified device.
        /// ename:VK_IMAGE_USAGE_COLOR_ATTACHMENT_BIT must: be included in the
        /// set but implementations may: support additional usages.
        /// </summary>
        public ImageUsageFlags SupportedUsageFlags; 
        
        /// <summary>
        /// 
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
    /// Structure describing a supported swapchain format-color space pair.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct SurfaceFormat
    {
        /// <summary>
        /// pname:format is a ename:VkFormat that is compatible with the
        /// specified surface.
        /// </summary>
        public Format Format; 
        
        /// <summary>
        /// pname:colorSpace is a presentation ename:VkColorSpaceKHR that is
        /// compatible with the surface.
        /// </summary>
        public ColorSpace ColorSpace; 
        
        /// <summary>
        /// 
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
    /// <para>
    /// .Valid Usage **** * pname:location must: be less than
    /// sname:VkPhysicalDeviceLimits::pname:maxVertexInputAttributes *
    /// pname:binding must: be less than
    /// sname:VkPhysicalDeviceLimits::pname:maxVertexInputBindings *
    /// pname:offset must: be less than or equal to
    /// sname:VkPhysicalDeviceLimits::pname:maxVertexInputAttributeOffset *
    /// pname:format must: be allowed as a vertex buffer format, as specified
    /// by the ename:VK_FORMAT_FEATURE_VERTEX_BUFFER_BIT flag in
    /// sname:VkFormatProperties::pname:bufferFeatures returned by
    /// fname:vkGetPhysicalDeviceFormatProperties ****
    /// </para>
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct VertexInputAttributeDescription
    {
        /// <summary>
        /// pname:location is the shader binding location number for this
        /// attribute.
        /// </summary>
        public uint Location; 
        
        /// <summary>
        /// pname:binding is the binding number which this attribute takes its
        /// data from.
        /// </summary>
        public uint Binding; 
        
        /// <summary>
        /// pname:format is the size and type of the vertex attribute data.
        /// </summary>
        public Format Format; 
        
        /// <summary>
        /// pname:offset is a byte offset of this attribute relative to the
        /// start of an element in the vertex input binding.
        /// </summary>
        public uint Offset; 
        
        /// <summary>
        /// 
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
    /// Structure specifying vertex input binding description.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct VertexInputBindingDescription
    {
        /// <summary>
        /// pname:binding is the binding number that this structure describes.
        /// </summary>
        public uint Binding; 
        
        /// <summary>
        /// pname:stride is the distance in bytes between two consecutive
        /// elements within the buffer.
        /// </summary>
        public uint Stride; 
        
        /// <summary>
        /// pname:inputRate specifies whether vertex attribute addressing is a
        /// function of the vertex index or of the instance index. Possible
        /// values include: + --
        /// </summary>
        public VertexInputRate InputRate; 
        
        /// <summary>
        /// 
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
    /// <para>
    /// The framebuffer depth coordinate [eq]#pname:z~f~# may: be represented
    /// using either a fixed-point or floating-point representation. However, a
    /// floating-point representation must: be used if the depth/stencil
    /// attachment has a floating-point depth component. If an [eq]#m#-bit
    /// fixed-point representation is used, we assume that it represents each
    /// value latexmath:[$\frac{k}{2^m - 1}$], where [eq]#k {elem} { 0, 1, ...,
    /// 2^m^-1 }#, as [eq]#k# (e.g. 1.0 is represented in binary as a string of
    /// all ones).
    /// </para>
    /// <para>
    /// The viewport parameters shown in the above equations are found from
    /// these values as
    /// </para>
    /// <para>
    /// :: [eq]#o~x~ = pname:x + pname:width / 2# :: [eq]#o~y~ = pname:y +
    /// pname:height / 2# :: [eq]#o~z~ = pname:minDepth# :: [eq]#p~x~ =
    /// pname:width# :: [eq]#p~y~ = pname:height# :: [eq]#p~z~ = pname:maxDepth
    /// - pname:minDepth#.
    /// </para>
    /// <para>
    /// The width and height of the
    /// &lt;&lt;features-limits-maxViewportDimensions, implementation-dependent
    /// maximum viewport dimensions&gt;&gt; must: be greater than or equal to
    /// the width and height of the largest image which can: be created and
    /// attached to a framebuffer.
    /// </para>
    /// <para>
    /// The floating-point viewport bounds are represented with an
    /// &lt;&lt;features-limits-viewportSubPixelBits,implementation-dependent precision&gt;&gt;.
    /// </para>
    /// <para>
    /// .Valid Usage **** * pname:width must: be greater than `0.0` and less
    /// than or equal to
    /// sname:VkPhysicalDeviceLimits::pname:maxViewportDimensions[0] *
    /// pname:height must: be greater than `0.0` and less than or equal to
    /// sname:VkPhysicalDeviceLimits::pname:maxViewportDimensions[1] ifdef::VK_AMD_negative_viewport_height[]
    /// * If the VK_AMD_negative_viewport_height extension is enabled,
    /// pname:height can: also be negative.
    /// endif::VK_AMD_negative_viewport_height[] * pname:x and pname:y must:
    /// each be between pname:viewportBoundsRange[0] and
    /// pname:viewportBoundsRange[1], inclusive * pname:x + pname:width must:
    /// be less than or equal to pname:viewportBoundsRange[1] * pname:y +
    /// pname:height must: be less than or equal to
    /// pname:viewportBoundsRange[1] * pname:minDepth must: be between `0.0`
    /// and `1.0`, inclusive * pname:maxDepth must: be between `0.0` and `1.0`,
    /// inclusive ****
    /// </para>
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct Viewport
    {
        /// <summary>
        /// pname:x and pname:y are the viewport's upper left corner
        /// [eq]#(x,y)#.
        /// </summary>
        public float X; 
        
        /// <summary>
        /// -
        /// </summary>
        public float Y; 
        
        /// <summary>
        /// pname:width and pname:height are the viewport's width and height,
        /// respectively.
        /// </summary>
        public float Width; 
        
        /// <summary>
        /// -
        /// </summary>
        public float Height; 
        
        /// <summary>
        /// pname:minDepth and pname:maxDepth are the depth range for the
        /// viewport. It is valid for pname:minDepth to be greater than or
        /// equal to pname:maxDepth.
        /// </summary>
        public float MinDepth; 
        
        /// <summary>
        /// -
        /// </summary>
        public float MaxDepth; 
        
        /// <summary>
        /// 
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
