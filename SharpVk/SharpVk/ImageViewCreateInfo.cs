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

namespace SharpVk
{
    /// <summary>
    /// <para>
    /// Structure specifying parameters of a newly created image view.
    /// </para>
    /// <para>
    /// If pname:image was created with the
    /// ename:VK_IMAGE_CREATE_MUTABLE_FORMAT_BIT flag, pname:format can: be
    /// different from the image's format, but if they are not equal they must:
    /// be _compatible_. Image format compatibility is defined in the
    /// &lt;&lt;features-formats-compatibility-classes,Format Compatibility
    /// Classes&gt;&gt; section.
    /// </para>
    /// <para>
    /// .Image and image view parameter compatibility requirements
    /// [cols="15%h,35%,50%",options="header"] |==== | Dim, Arrayed, MS | Image
    /// parameters | View parameters | | pname:imageType = ci.pname:imageType +
    /// pname:width = ci.pname:extent.width + pname:height =
    /// ci.pname:extent.height + pname:depth = ci.pname:extent.depth +
    /// pname:arrayLayers = ci.pname:arrayLayers + pname:samples =
    /// ci.pname:samples + where ci is the slink:VkImageCreateInfo used to
    /// create pname:image. | pname:baseArrayLayer and pname:layerCount are
    /// members of the pname:subresourceRange member. | 1D, 0, 0 |
    /// pname:imageType = ename:VK_IMAGE_TYPE_1D + pname:width {geq} 1 +
    /// pname:height = 1 + pname:depth = 1 + pname:arrayLayers {geq} 1 +
    /// pname:samples = 1 | pname:viewType = ename:VK_VIEW_TYPE_1D +
    /// pname:baseArrayLayer {geq} 0 + pname:layerCount = 1 | 1D, 1, 0 |
    /// pname:imageType = ename:VK_IMAGE_TYPE_1D + pname:width {geq} 1 +
    /// pname:height = 1 + pname:depth = 1 + pname:arrayLayers {geq} 1 +
    /// pname:samples = 1 | pname:viewType = ename:VK_VIEW_TYPE_1D_ARRAY +
    /// pname:baseArrayLayer {geq} 0 + pname:layerCount {geq} 1 | 2D, 0, 0 |
    /// pname:imageType = ename:VK_IMAGE_TYPE_2D + pname:width {geq} 1 +
    /// pname:height {geq} 1 + pname:depth = 1 + pname:arrayLayers {geq} 1 +
    /// pname:samples = 1 | pname:viewType = ename:VK_VIEW_TYPE_2D +
    /// pname:baseArrayLayer {geq} 0 + pname:layerCount = 1 | 2D, 1, 0 |
    /// pname:imageType = ename:VK_IMAGE_TYPE_2D + pname:width {geq} 1 +
    /// pname:height {geq} 1 + pname:depth = 1 + pname:arrayLayers {geq} 1 +
    /// pname:samples = 1 | pname:viewType = ename:VK_VIEW_TYPE_2D_ARRAY +
    /// pname:baseArrayLayer {geq} 0 + pname:layerCount {geq} 1 | 2D, 0, 1 |
    /// pname:imageType = ename:VK_IMAGE_TYPE_2D + pname:width {geq} 1 +
    /// pname:height {geq} 1 + pname:depth = 1 + pname:arrayLayers {geq} 1 +
    /// pname:samples &gt; 1 | pname:viewType = ename:VK_VIEW_TYPE_2D +
    /// pname:baseArrayLayer {geq} 0 + pname:layerCount = 1 | 2D, 1, 1 |
    /// pname:imageType = ename:VK_IMAGE_TYPE_2D + pname:width {geq} 1 +
    /// pname:height {geq} 1 + pname:depth = 1 + pname:arrayLayers {geq} 1 +
    /// pname:samples &gt; 1 | pname:viewType = ename:VK_VIEW_TYPE_2D_ARRAY +
    /// pname:baseArrayLayer {geq} 0 + pname:layerCount {geq} 1 | CUBE, 0, 0 |
    /// pname:imageType = ename:VK_IMAGE_TYPE_2D + pname:width {geq} 1 +
    /// pname:height = pname:width + pname:depth = 1 + pname:arrayLayers {geq}
    /// 6 + pname:samples = 1 + pname:flags includes
    /// ename:VK_IMAGE_CREATE_CUBE_COMPATIBLE_BIT | pname:viewType =
    /// ename:VK_VIEW_TYPE_CUBE + pname:baseArrayLayer {geq} 0 +
    /// pname:layerCount = 6 | CUBE, 1, 0 | pname:imageType =
    /// ename:VK_IMAGE_TYPE_2D + pname:width {geq} 1 + pname:height = width +
    /// pname:depth = 1 + _N_ {geq} 1 + pname:arrayLayers {geq} 6 {times} _N_ +
    /// pname:samples = 1 + pname:flags includes
    /// ename:VK_IMAGE_CREATE_CUBE_COMPATIBLE_BIT | pname:viewType =
    /// ename:VK_VIEW_TYPE_CUBE_ARRAY + pname:baseArrayLayer {geq} 0 +
    /// pname:layerCount = 6 {times} _N_, _N_ {geq} 1 | 3D, 0, 0 |
    /// pname:imageType = ename:VK_IMAGE_TYPE_3D + pname:width {geq} 1 +
    /// pname:height {geq} 1 + pname:depth {geq} 1 + pname:arrayLayers = 1 +
    /// pname:samples = 1 | pname:viewType = ename:VK_VIEW_TYPE_3D +
    /// pname:baseArrayLayer = 0 + pname:layerCount = 1 |====
    /// </para>
    /// <para>
    /// .Valid Usage **** * If pname:image was not created with
    /// ename:VK_IMAGE_CREATE_CUBE_COMPATIBLE_BIT then pname:viewType must: not
    /// be ename:VK_IMAGE_VIEW_TYPE_CUBE or ename:VK_IMAGE_VIEW_TYPE_CUBE_ARRAY
    /// * If the &lt;&lt;features-features-imageCubeArray,image cubemap
    /// arrays&gt;&gt; feature is not enabled, pname:viewType must: not be
    /// ename:VK_IMAGE_VIEW_TYPE_CUBE_ARRAY * If the
    /// &lt;&lt;features-features-textureCompressionETC2,ETC2 texture
    /// compression&gt;&gt; feature is not enabled, pname:format must: not be
    /// ename:VK_FORMAT_ETC2_R8G8B8_UNORM_BLOCK, ename:VK_FORMAT_ETC2_R8G8B8_SRGB_BLOCK,
    /// ename:VK_FORMAT_ETC2_R8G8B8A1_UNORM_BLOCK,
    /// ename:VK_FORMAT_ETC2_R8G8B8A1_SRGB_BLOCK, ename:VK_FORMAT_ETC2_R8G8B8A8_UNORM_BLOCK,
    /// ename:VK_FORMAT_ETC2_R8G8B8A8_SRGB_BLOCK,
    /// ename:VK_FORMAT_EAC_R11_UNORM_BLOCK, ename:VK_FORMAT_EAC_R11_SNORM_BLOCK,
    /// ename:VK_FORMAT_EAC_R11G11_UNORM_BLOCK, or
    /// ename:VK_FORMAT_EAC_R11G11_SNORM_BLOCK * If the
    /// &lt;&lt;features-features-textureCompressionASTC_LDR,ASTC LDR texture
    /// compression&gt;&gt; feature is not enabled, pname:format must: not be
    /// ename:VK_FORMAT_ASTC_4x4_UNORM_BLOCK, ename:VK_FORMAT_ASTC_4x4_SRGB_BLOCK,
    /// ename:VK_FORMAT_ASTC_5x4_UNORM_BLOCK,
    /// ename:VK_FORMAT_ASTC_5x4_SRGB_BLOCK, ename:VK_FORMAT_ASTC_5x5_UNORM_BLOCK,
    /// ename:VK_FORMAT_ASTC_5x5_SRGB_BLOCK,
    /// ename:VK_FORMAT_ASTC_6x5_UNORM_BLOCK, ename:VK_FORMAT_ASTC_6x5_SRGB_BLOCK,
    /// ename:VK_FORMAT_ASTC_6x6_UNORM_BLOCK,
    /// ename:VK_FORMAT_ASTC_6x6_SRGB_BLOCK, ename:VK_FORMAT_ASTC_8x5_UNORM_BLOCK,
    /// ename:VK_FORMAT_ASTC_8x5_SRGB_BLOCK,
    /// ename:VK_FORMAT_ASTC_8x6_UNORM_BLOCK, ename:VK_FORMAT_ASTC_8x6_SRGB_BLOCK,
    /// ename:VK_FORMAT_ASTC_8x8_UNORM_BLOCK,
    /// ename:VK_FORMAT_ASTC_8x8_SRGB_BLOCK, ename:VK_FORMAT_ASTC_10x5_UNORM_BLOCK,
    /// ename:VK_FORMAT_ASTC_10x5_SRGB_BLOCK,
    /// ename:VK_FORMAT_ASTC_10x6_UNORM_BLOCK, ename:VK_FORMAT_ASTC_10x6_SRGB_BLOCK,
    /// ename:VK_FORMAT_ASTC_10x8_UNORM_BLOCK,
    /// ename:VK_FORMAT_ASTC_10x8_SRGB_BLOCK, ename:VK_FORMAT_ASTC_10x10_UNORM_BLOCK,
    /// ename:VK_FORMAT_ASTC_10x10_SRGB_BLOCK,
    /// ename:VK_FORMAT_ASTC_12x10_UNORM_BLOCK, ename:VK_FORMAT_ASTC_12x10_SRGB_BLOCK,
    /// ename:VK_FORMAT_ASTC_12x12_UNORM_BLOCK, or
    /// ename:VK_FORMAT_ASTC_12x12_SRGB_BLOCK * If the
    /// &lt;&lt;features-features-textureCompressionBC,BC texture
    /// compression&gt;&gt; feature is not enabled, pname:format must: not be
    /// ename:VK_FORMAT_BC1_RGB_UNORM_BLOCK, ename:VK_FORMAT_BC1_RGB_SRGB_BLOCK,
    /// ename:VK_FORMAT_BC1_RGBA_UNORM_BLOCK,
    /// ename:VK_FORMAT_BC1_RGBA_SRGB_BLOCK, ename:VK_FORMAT_BC2_UNORM_BLOCK,
    /// ename:VK_FORMAT_BC2_SRGB_BLOCK, ename:VK_FORMAT_BC3_UNORM_BLOCK,
    /// ename:VK_FORMAT_BC3_SRGB_BLOCK, ename:VK_FORMAT_BC4_UNORM_BLOCK,
    /// ename:VK_FORMAT_BC4_SNORM_BLOCK, ename:VK_FORMAT_BC5_UNORM_BLOCK,
    /// ename:VK_FORMAT_BC5_SNORM_BLOCK, ename:VK_FORMAT_BC6H_UFLOAT_BLOCK,
    /// ename:VK_FORMAT_BC6H_SFLOAT_BLOCK, ename:VK_FORMAT_BC7_UNORM_BLOCK, or
    /// ename:VK_FORMAT_BC7_SRGB_BLOCK * If pname:image was created with
    /// ename:VK_IMAGE_TILING_LINEAR, pname:format must: be format that has at
    /// least one supported feature bit present in the value of
    /// sname:VkFormatProperties::pname:linearTilingFeatures returned by
    /// fname:vkGetPhysicalDeviceFormatProperties with the same value of
    /// pname:format * If pname:image was created with
    /// ename:VK_IMAGE_TILING_LINEAR and pname:usage containing
    /// ename:VK_IMAGE_USAGE_SAMPLED_BIT, pname:format must: be supported for
    /// sampled images, as specified by the
    /// ename:VK_FORMAT_FEATURE_SAMPLED_IMAGE_BIT flag in
    /// sname:VkFormatProperties::pname:linearTilingFeatures returned by
    /// fname:vkGetPhysicalDeviceFormatProperties with the same value of
    /// pname:format * If pname:image was created with
    /// ename:VK_IMAGE_TILING_LINEAR and pname:usage containing
    /// ename:VK_IMAGE_USAGE_STORAGE_BIT, pname:format must: be supported for
    /// storage images, as specified by the
    /// ename:VK_FORMAT_FEATURE_STORAGE_IMAGE_BIT flag in
    /// sname:VkFormatProperties::pname:linearTilingFeatures returned by
    /// fname:vkGetPhysicalDeviceFormatProperties with the same value of
    /// pname:format * If pname:image was created with
    /// ename:VK_IMAGE_TILING_LINEAR and pname:usage containing
    /// ename:VK_IMAGE_USAGE_COLOR_ATTACHMENT_BIT, pname:format must: be
    /// supported for color attachments, as specified by the
    /// ename:VK_FORMAT_FEATURE_COLOR_ATTACHMENT_BIT flag in
    /// sname:VkFormatProperties::pname:linearTilingFeatures returned by
    /// fname:vkGetPhysicalDeviceFormatProperties with the same value of
    /// pname:format * If pname:image was created with
    /// ename:VK_IMAGE_TILING_LINEAR and pname:usage containing
    /// ename:VK_IMAGE_USAGE_DEPTH_STENCIL_ATTACHMENT_BIT, pname:format must:
    /// be supported for depth/stencil attachments, as specified by the
    /// ename:VK_FORMAT_FEATURE_DEPTH_STENCIL_ATTACHMENT_BIT flag in
    /// sname:VkFormatProperties::pname:linearTilingFeatures returned by
    /// fname:vkGetPhysicalDeviceFormatProperties with the same value of
    /// pname:format * If pname:image was created with
    /// ename:VK_IMAGE_TILING_OPTIMAL, pname:format must: be format that has at
    /// least one supported feature bit present in the value of
    /// sname:VkFormatProperties::pname:optimalTilingFeatures returned by
    /// fname:vkGetPhysicalDeviceFormatProperties with the same value of
    /// pname:format * If pname:image was created with
    /// ename:VK_IMAGE_TILING_OPTIMAL and pname:usage containing
    /// ename:VK_IMAGE_USAGE_SAMPLED_BIT, pname:format must: be supported for
    /// sampled images, as specified by the
    /// ename:VK_FORMAT_FEATURE_SAMPLED_IMAGE_BIT flag in
    /// sname:VkFormatProperties::pname:optimalTilingFeatures returned by
    /// fname:vkGetPhysicalDeviceFormatProperties with the same value of
    /// pname:format * If pname:image was created with
    /// ename:VK_IMAGE_TILING_OPTIMAL and pname:usage containing
    /// ename:VK_IMAGE_USAGE_STORAGE_BIT, pname:format must: be supported for
    /// storage images, as specified by the
    /// ename:VK_FORMAT_FEATURE_STORAGE_IMAGE_BIT flag in
    /// sname:VkFormatProperties::pname:optimalTilingFeatures returned by
    /// fname:vkGetPhysicalDeviceFormatProperties with the same value of
    /// pname:format * If pname:image was created with
    /// ename:VK_IMAGE_TILING_OPTIMAL and pname:usage containing
    /// ename:VK_IMAGE_USAGE_COLOR_ATTACHMENT_BIT, pname:format must: be
    /// supported for color attachments, as specified by the
    /// ename:VK_FORMAT_FEATURE_COLOR_ATTACHMENT_BIT flag in
    /// sname:VkFormatProperties::pname:optimalTilingFeatures returned by
    /// fname:vkGetPhysicalDeviceFormatProperties with the same value of
    /// pname:format * If pname:image was created with
    /// ename:VK_IMAGE_TILING_OPTIMAL and pname:usage containing
    /// ename:VK_IMAGE_USAGE_DEPTH_STENCIL_ATTACHMENT_BIT, pname:format must:
    /// be supported for depth/stencil attachments, as specified by the
    /// ename:VK_FORMAT_FEATURE_DEPTH_STENCIL_ATTACHMENT_BIT flag in
    /// sname:VkFormatProperties::pname:optimalTilingFeatures returned by
    /// fname:vkGetPhysicalDeviceFormatProperties with the same value of
    /// pname:format * pname:subresourceRange must: be a valid image
    /// subresource range for pname:image (see
    /// &lt;&lt;resources-image-views&gt;&gt;) * If pname:image was created
    /// with the ename:VK_IMAGE_CREATE_MUTABLE_FORMAT_BIT flag, pname:format
    /// must: be compatible with the pname:format used to create pname:image,
    /// as defined in &lt;&lt;features-formats-compatibility-classes,Format
    /// Compatibility Classes&gt;&gt; * If pname:image was not created with the
    /// ename:VK_IMAGE_CREATE_MUTABLE_FORMAT_BIT flag, pname:format must: be
    /// identical to the pname:format used to create pname:image *
    /// pname:subResourceRange and pname:viewType must: be compatible with the
    /// image, as described in the
    /// &lt;&lt;resources-image-views-compatibility,compatibility table&gt;&gt;
    /// ****
    /// </para>
    /// </summary>
    public struct ImageViewCreateInfo
    {
        /// <summary>
        /// pname:flags is reserved for future use.
        /// </summary>
        public ImageViewCreateFlags Flags
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:image is a sname:VkImage on which the view will be created.
        /// </summary>
        public Image Image
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:viewType is the type of the image view.
        /// </summary>
        public ImageViewType ViewType
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:format is a elink:VkFormat describing the format and type
        /// used to interpret data elements in the image.
        /// </summary>
        public Format Format
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:components specifies a remapping of color components (or of
        /// depth or stencil components after they have been converted into
        /// color components). See slink:VkComponentMapping.
        /// </summary>
        public ComponentMapping Components
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:subresourceRange is a slink:VkImageSubresourceRange selecting
        /// the set of mipmap levels and array layers to be accessible to the
        /// view.
        /// </summary>
        public ImageSubresourceRange SubresourceRange
        {
            get;
            set;
        }
        
        internal unsafe Interop.ImageViewCreateInfo Pack()
        {
            Interop.ImageViewCreateInfo result = default(Interop.ImageViewCreateInfo);
            result.SType = StructureType.ImageViewCreateInfo;
            result.Image = this.Image?.Pack() ?? Interop.Image.Null;
            result.Flags = this.Flags;
            result.ViewType = this.ViewType;
            result.Format = this.Format;
            result.Components = this.Components;
            result.SubresourceRange = this.SubresourceRange;
            return result;
        }
        
        internal unsafe Interop.ImageViewCreateInfo* MarshalTo()
        {
            return (Interop.ImageViewCreateInfo*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
        }
    }
}
