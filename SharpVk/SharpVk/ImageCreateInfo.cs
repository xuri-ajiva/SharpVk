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
    /// Structure specifying the parameters of a newly created image object.
    /// </para>
    /// <para>
    /// Valid limits for the image pname:extent, pname:mipLevels,
    /// pname:arrayLayers and pname:samples members are queried with the
    /// flink:vkGetPhysicalDeviceImageFormatProperties command.
    /// </para>
    /// <para>
    /// Images created with pname:tiling equal to ename:VK_IMAGE_TILING_LINEAR
    /// have further restrictions on their limits and capabilities compared to
    /// images created with pname:tiling equal to
    /// ename:VK_IMAGE_TILING_OPTIMAL. Creation of images with tiling
    /// ename:VK_IMAGE_TILING_LINEAR may: not be supported unless other
    /// parameters meet all of the constraints:
    /// </para>
    /// <para>
    /// * pname:imageType is ename:VK_IMAGE_TYPE_2D * pname:format is not a
    /// depth/stencil format * pname:mipLevels is 1 * pname:arrayLayers is 1 *
    /// pname:samples is ename:VK_SAMPLE_COUNT_1_BIT * pname:usage only
    /// includes ename:VK_IMAGE_USAGE_TRANSFER_SRC_BIT and/or
    /// ename:VK_IMAGE_USAGE_TRANSFER_DST_BIT
    /// </para>
    /// <para>
    /// Implementations may: support additional limits and capabilities beyond
    /// those listed above. To determine the specific capabilities of an
    /// implementation, query the valid pname:usage bits by calling
    /// flink:vkGetPhysicalDeviceFormatProperties and the valid limits for
    /// pname:mipLevels and pname:arrayLayers by calling
    /// flink:vkGetPhysicalDeviceImageFormatProperties.
    /// </para>
    /// <para>
    /// .Valid Usage **** * If pname:sharingMode is
    /// ename:VK_SHARING_MODE_CONCURRENT, pname:pQueueFamilyIndices must: be a
    /// pointer to an array of pname:queueFamilyIndexCount basetype:uint32_t
    /// values * If pname:sharingMode is ename:VK_SHARING_MODE_CONCURRENT,
    /// pname:queueFamilyIndexCount must: be greater than `1` * pname:format
    /// must: not be ename:VK_FORMAT_UNDEFINED * The pname:width, pname:height,
    /// and pname:depth members of pname:extent must: all be greater than `0` *
    /// pname:mipLevels must: be greater than `0` * pname:arrayLayers must: be
    /// greater than `0` * If pname:flags contains
    /// ename:VK_IMAGE_CREATE_CUBE_COMPATIBLE_BIT, pname:imageType must be
    /// ename:VK_IMAGE_TYPE_2D * If pname:imageType is ename:VK_IMAGE_TYPE_1D,
    /// pname:extent.width must: be less than or equal to
    /// sname:VkPhysicalDeviceLimits::pname:maxImageDimension1D, or
    /// sname:VkImageFormatProperties::pname:maxExtent.width (as returned by
    /// fname:vkGetPhysicalDeviceImageFormatProperties with pname:format,
    /// pname:type, pname:tiling, pname:usage, and pname:flags equal to those
    /// in this structure) - whichever is higher * If pname:imageType is
    /// ename:VK_IMAGE_TYPE_2D and pname:flags does not contain
    /// ename:VK_IMAGE_CREATE_CUBE_COMPATIBLE_BIT, pname:extent.width and
    /// pname:extent.height must: be less than or equal to
    /// sname:VkPhysicalDeviceLimits::pname:maxImageDimension2D, or
    /// sname:VkImageFormatProperties::pname:maxExtent.width/height (as
    /// returned by fname:vkGetPhysicalDeviceImageFormatProperties with
    /// pname:format, pname:type, pname:tiling, pname:usage, and pname:flags
    /// equal to those in this structure) - whichever is higher * If
    /// pname:imageType is ename:VK_IMAGE_TYPE_2D and pname:flags contains
    /// ename:VK_IMAGE_CREATE_CUBE_COMPATIBLE_BIT, pname:extent.width and
    /// pname:extent.height must: be less than or equal to
    /// sname:VkPhysicalDeviceLimits::pname:maxImageDimensionCube, or
    /// sname:VkImageFormatProperties::pname:maxExtent.width/height (as
    /// returned by fname:vkGetPhysicalDeviceImageFormatProperties with
    /// pname:format, pname:type, pname:tiling, pname:usage, and pname:flags
    /// equal to those in this structure) - whichever is higher * If
    /// pname:imageType is ename:VK_IMAGE_TYPE_2D and pname:flags contains
    /// ename:VK_IMAGE_CREATE_CUBE_COMPATIBLE_BIT, pname:extent.width and
    /// pname:extent.height must: be equal and pname:arrayLayers must: be
    /// greater than or equal to 6 * If pname:imageType is
    /// ename:VK_IMAGE_TYPE_3D, pname:extent.width, pname:extent.height and
    /// pname:extent.depth must: be less than or equal to
    /// sname:VkPhysicalDeviceLimits::pname:maxImageDimension3D, or
    /// sname:VkImageFormatProperties::pname:maxExtent.width/height/depth (as
    /// returned by fname:vkGetPhysicalDeviceImageFormatProperties with
    /// pname:format, pname:type, pname:tiling, pname:usage, and pname:flags
    /// equal to those in this structure) - whichever is higher * If
    /// pname:imageType is ename:VK_IMAGE_TYPE_1D, both pname:extent.height and
    /// pname:extent.depth must: be `1` * If pname:imageType is
    /// ename:VK_IMAGE_TYPE_2D, pname:extent.depth must: be `1` *
    /// pname:mipLevels must: be less than or equal to
    /// [eq]#{lfloor}log~2~(max(pname:extent.width, pname:extent.height,
    /// pname:extent.depth)){rfloor} + 1#. * If any of pname:extent.width,
    /// pname:extent.height, or pname:extent.depth are greater than the
    /// equivalently named members of
    /// sname:VkPhysicalDeviceLimits::pname:maxImageDimension3D, pname:mipLevels
    /// must: be less than or equal to
    /// sname:VkImageFormatProperties::pname:maxMipLevels (as returned by
    /// fname:vkGetPhysicalDeviceImageFormatProperties with pname:format,
    /// pname:type, pname:tiling, pname:usage, and pname:flags equal to those
    /// in this structure) * pname:arrayLayers must: be less than or equal to
    /// sname:VkImageFormatProperties::pname:maxArrayLayers (as returned by
    /// fname:vkGetPhysicalDeviceImageFormatProperties with pname:format,
    /// pname:type, pname:tiling, pname:usage, and pname:flags equal to those
    /// in this structure) * If pname:imageType is ename:VK_IMAGE_TYPE_3D,
    /// pname:arrayLayers must: be `1`. * If pname:samples is not
    /// ename:VK_SAMPLE_COUNT_1_BIT, pname:imageType must: be
    /// ename:VK_IMAGE_TYPE_2D, pname:flags must: not contain
    /// ename:VK_IMAGE_CREATE_CUBE_COMPATIBLE_BIT, pname:tiling must: be
    /// ename:VK_IMAGE_TILING_OPTIMAL, and pname:mipLevels must: be equal to
    /// `1` * If pname:usage includes
    /// ename:VK_IMAGE_USAGE_TRANSIENT_ATTACHMENT_BIT, then bits other than
    /// ename:VK_IMAGE_USAGE_COLOR_ATTACHMENT_BIT, ename:VK_IMAGE_USAGE_DEPTH_STENCIL_ATTACHMENT_BIT,
    /// and ename:VK_IMAGE_USAGE_INPUT_ATTACHMENT_BIT must: not be set * If
    /// pname:usage includes ename:VK_IMAGE_USAGE_COLOR_ATTACHMENT_BIT,
    /// ename:VK_IMAGE_USAGE_DEPTH_STENCIL_ATTACHMENT_BIT, ename:VK_IMAGE_USAGE_TRANSIENT_ATTACHMENT_BIT,
    /// or ename:VK_IMAGE_USAGE_INPUT_ATTACHMENT_BIT, pname:extent.width must:
    /// be less than or equal to
    /// sname:VkPhysicalDeviceLimits::pname:maxFramebufferWidth * If
    /// pname:usage includes ename:VK_IMAGE_USAGE_COLOR_ATTACHMENT_BIT,
    /// ename:VK_IMAGE_USAGE_DEPTH_STENCIL_ATTACHMENT_BIT, ename:VK_IMAGE_USAGE_TRANSIENT_ATTACHMENT_BIT,
    /// or ename:VK_IMAGE_USAGE_INPUT_ATTACHMENT_BIT, pname:extent.height must:
    /// be less than or equal to
    /// sname:VkPhysicalDeviceLimits::pname:maxFramebufferHeight *
    /// pname:samples must: be a bit value that is set in
    /// sname:VkImageFormatProperties::pname:sampleCounts returned by
    /// fname:vkGetPhysicalDeviceImageFormatProperties with pname:format,
    /// pname:type, pname:tiling, pname:usage, and pname:flags equal to those
    /// in this structure * If the
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
    /// ename:VK_FORMAT_BC7_SRGB_BLOCK * If the
    /// &lt;&lt;features-features-shaderStorageImageMultisample,multisampled storage
    /// images&gt;&gt; feature is not enabled, and pname:usage contains
    /// ename:VK_IMAGE_USAGE_STORAGE_BIT, pname:samples must: be
    /// ename:VK_SAMPLE_COUNT_1_BIT * If the
    /// &lt;&lt;features-features-sparseBinding,sparse bindings&gt;&gt; feature
    /// is not enabled, pname:flags must: not contain
    /// ename:VK_IMAGE_CREATE_SPARSE_BINDING_BIT * If the
    /// &lt;&lt;features-features-sparseResidencyImage2D,sparse residency for
    /// 2D images&gt;&gt; feature is not enabled, and pname:imageType is
    /// ename:VK_IMAGE_TYPE_2D, pname:flags must: not contain
    /// ename:VK_IMAGE_CREATE_SPARSE_RESIDENCY_BIT * If the
    /// &lt;&lt;features-features-sparseResidencyImage3D,sparse residency for
    /// 3D images&gt;&gt; feature is not enabled, and pname:imageType is
    /// ename:VK_IMAGE_TYPE_3D, pname:flags must: not contain
    /// ename:VK_IMAGE_CREATE_SPARSE_RESIDENCY_BIT * If the
    /// &lt;&lt;features-features-sparseResidency2Samples,sparse residency for
    /// images with 2 samples&gt;&gt; feature is not enabled, pname:imageType
    /// is ename:VK_IMAGE_TYPE_2D, and pname:samples is
    /// ename:VK_SAMPLE_COUNT_2_BIT, pname:flags must: not contain
    /// ename:VK_IMAGE_CREATE_SPARSE_RESIDENCY_BIT * If the
    /// &lt;&lt;features-features-sparseResidency4Samples,sparse residency for
    /// images with 4 samples&gt;&gt; feature is not enabled, pname:imageType
    /// is ename:VK_IMAGE_TYPE_2D, and pname:samples is
    /// ename:VK_SAMPLE_COUNT_4_BIT, pname:flags must: not contain
    /// ename:VK_IMAGE_CREATE_SPARSE_RESIDENCY_BIT * If the
    /// &lt;&lt;features-features-sparseResidency8Samples,sparse residency for
    /// images with 8 samples&gt;&gt; feature is not enabled, pname:imageType
    /// is ename:VK_IMAGE_TYPE_2D, and pname:samples is
    /// ename:VK_SAMPLE_COUNT_8_BIT, pname:flags must: not contain
    /// ename:VK_IMAGE_CREATE_SPARSE_RESIDENCY_BIT * If the
    /// &lt;&lt;features-features-sparseResidency16Samples,sparse residency for
    /// images with 16 samples&gt;&gt; feature is not enabled, pname:imageType
    /// is ename:VK_IMAGE_TYPE_2D, and pname:samples is
    /// ename:VK_SAMPLE_COUNT_16_BIT, pname:flags must: not contain
    /// ename:VK_IMAGE_CREATE_SPARSE_RESIDENCY_BIT * If pname:tiling is
    /// ename:VK_IMAGE_TILING_LINEAR, pname:format must: be a format that has
    /// at least one supported feature bit present in the value of
    /// sname:VkFormatProperties::pname:linearTilingFeatures returned by
    /// fname:vkGetPhysicalDeviceFormatProperties with the same value of
    /// pname:format * If pname:tiling is ename:VK_IMAGE_TILING_LINEAR, and
    /// sname:VkFormatProperties::pname:linearTilingFeatures (as returned by
    /// fname:vkGetPhysicalDeviceFormatProperties with the same value of
    /// pname:format) does not include
    /// ename:VK_FORMAT_FEATURE_SAMPLED_IMAGE_BIT, pname:usage must: not
    /// contain ename:VK_IMAGE_USAGE_SAMPLED_BIT * If pname:tiling is
    /// ename:VK_IMAGE_TILING_LINEAR, and
    /// sname:VkFormatProperties::pname:linearTilingFeatures (as returned by
    /// fname:vkGetPhysicalDeviceFormatProperties with the same value of
    /// pname:format) does not include
    /// ename:VK_FORMAT_FEATURE_STORAGE_IMAGE_BIT, pname:usage must: not
    /// contain ename:VK_IMAGE_USAGE_STORAGE_BIT * If pname:tiling is
    /// ename:VK_IMAGE_TILING_LINEAR, and
    /// sname:VkFormatProperties::pname:linearTilingFeatures (as returned by
    /// fname:vkGetPhysicalDeviceFormatProperties with the same value of
    /// pname:format) does not include
    /// ename:VK_FORMAT_FEATURE_COLOR_ATTACHMENT_BIT, pname:usage must: not
    /// contain ename:VK_IMAGE_USAGE_COLOR_ATTACHMENT_BIT * If pname:tiling is
    /// ename:VK_IMAGE_TILING_LINEAR, and
    /// sname:VkFormatProperties::pname:linearTilingFeatures (as returned by
    /// fname:vkGetPhysicalDeviceFormatProperties with the same value of
    /// pname:format) does not include
    /// ename:VK_FORMAT_FEATURE_DEPTH_STENCIL_ATTACHMENT_BIT, pname:usage must:
    /// not contain ename:VK_IMAGE_USAGE_DEPTH_STENCIL_ATTACHMENT_BIT * If
    /// pname:tiling is ename:VK_IMAGE_TILING_OPTIMAL, pname:format must: be a
    /// format that has at least one supported feature bit present in the value
    /// of sname:VkFormatProperties::pname:optimalTilingFeatures returned by
    /// fname:vkGetPhysicalDeviceFormatProperties with the same value of
    /// pname:format * If pname:tiling is ename:VK_IMAGE_TILING_OPTIMAL, and
    /// sname:VkFormatProperties::pname:optimalTilingFeatures (as returned by
    /// fname:vkGetPhysicalDeviceFormatProperties with the same value of
    /// pname:format) does not include
    /// ename:VK_FORMAT_FEATURE_SAMPLED_IMAGE_BIT, pname:usage must: not
    /// contain ename:VK_IMAGE_USAGE_SAMPLED_BIT * If pname:tiling is
    /// ename:VK_IMAGE_TILING_OPTIMAL, and
    /// sname:VkFormatProperties::pname:optimalTilingFeatures (as returned by
    /// fname:vkGetPhysicalDeviceFormatProperties with the same value of
    /// pname:format) does not include
    /// ename:VK_FORMAT_FEATURE_STORAGE_IMAGE_BIT, pname:usage must: not
    /// contain ename:VK_IMAGE_USAGE_STORAGE_BIT * If pname:tiling is
    /// ename:VK_IMAGE_TILING_OPTIMAL, and
    /// sname:VkFormatProperties::pname:optimalTilingFeatures (as returned by
    /// fname:vkGetPhysicalDeviceFormatProperties with the same value of
    /// pname:format) does not include
    /// ename:VK_FORMAT_FEATURE_COLOR_ATTACHMENT_BIT, pname:usage must: not
    /// contain ename:VK_IMAGE_USAGE_COLOR_ATTACHMENT_BIT * If pname:tiling is
    /// ename:VK_IMAGE_TILING_OPTIMAL, and
    /// sname:VkFormatProperties::pname:optimalTilingFeatures (as returned by
    /// fname:vkGetPhysicalDeviceFormatProperties with the same value of
    /// pname:format) does not include
    /// ename:VK_FORMAT_FEATURE_DEPTH_STENCIL_ATTACHMENT_BIT, pname:usage must:
    /// not contain ename:VK_IMAGE_USAGE_DEPTH_STENCIL_ATTACHMENT_BIT * If
    /// pname:flags contains ename:VK_IMAGE_CREATE_SPARSE_RESIDENCY_BIT or
    /// ename:VK_IMAGE_CREATE_SPARSE_ALIASED_BIT, it must: also contain
    /// ename:VK_IMAGE_CREATE_SPARSE_BINDING_BIT ****
    /// </para>
    /// </summary>
    public struct ImageCreateInfo
    {
        /// <summary>
        /// pname:flags is a bitmask describing additional parameters of the
        /// image. See elink:VkImageCreateFlagBits below for a description of
        /// the supported bits.
        /// </summary>
        public ImageCreateFlags Flags
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:imageType is a elink:VkImageType specifying the basic
        /// dimensionality of the image, as described below. Layers in array
        /// textures do not count as a dimension for the purposes of the image
        /// type.
        /// </summary>
        public ImageType ImageType
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:format is a elink:VkFormat describing the format and type of
        /// the data elements that will be contained in the image.
        /// </summary>
        public Format Format
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:extent is a slink:VkExtent3D describing the number of data
        /// elements in each dimension of the base level.
        /// </summary>
        public Extent3D Extent
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:mipLevels describes the number of levels of detail available
        /// for minified sampling of the image.
        /// </summary>
        public uint MipLevels
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:arrayLayers is the number of layers in the image.
        /// </summary>
        public uint ArrayLayers
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:samples is the number of sub-data element samples in the
        /// image as defined in elink:VkSampleCountFlagBits. See
        /// &lt;&lt;primsrast-multisampling,Multisampling&gt;&gt;.
        /// </summary>
        public SampleCountFlags Samples
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:tiling is a elink:VkImageTiling specifying the tiling
        /// arrangement of the data elements in memory, as described below.
        /// </summary>
        public ImageTiling Tiling
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:usage is a bitmask describing the intended usage of the
        /// image. See elink:VkImageUsageFlagBits below for a description of
        /// the supported bits.
        /// </summary>
        public ImageUsageFlags Usage
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:sharingMode is the sharing mode of the image when it will be
        /// accessed by multiple queue families, and must: be one of the values
        /// described for elink:VkSharingMode in the
        /// &lt;&lt;resources-sharing,Resource Sharing&gt;&gt; section below.
        /// </summary>
        public SharingMode SharingMode
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:pQueueFamilyIndices is a list of queue families that will
        /// access this image (ignored if pname:sharingMode is not
        /// ename:VK_SHARING_MODE_CONCURRENT).
        /// </summary>
        public uint[] QueueFamilyIndices
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:initialLayout selects the initial elink:VkImageLayout state
        /// of all image subresources of the image. See
        /// &lt;&lt;resources-image-layouts,Image Layouts&gt;&gt;.
        /// pname:initialLayout must: be ename:VK_IMAGE_LAYOUT_UNDEFINED or
        /// ename:VK_IMAGE_LAYOUT_PREINITIALIZED.
        /// </summary>
        public ImageLayout InitialLayout
        {
            get;
            set;
        }
        
        internal unsafe Interop.ImageCreateInfo Pack()
        {
            Interop.ImageCreateInfo result = default(Interop.ImageCreateInfo);
            result.SType = StructureType.ImageCreateInfo;
            result.QueueFamilyIndices = this.QueueFamilyIndices == null ? null : Interop.HeapUtil.MarshalTo(this.QueueFamilyIndices);
            result.QueueFamilyIndexCount = (uint)(this.QueueFamilyIndices?.Length ?? 0);
            result.Flags = this.Flags;
            result.ImageType = this.ImageType;
            result.Format = this.Format;
            result.Extent = this.Extent;
            result.MipLevels = this.MipLevels;
            result.ArrayLayers = this.ArrayLayers;
            result.Samples = this.Samples;
            result.Tiling = this.Tiling;
            result.Usage = this.Usage;
            result.SharingMode = this.SharingMode;
            result.InitialLayout = this.InitialLayout;
            return result;
        }
        
        internal unsafe Interop.ImageCreateInfo* MarshalTo()
        {
            return (Interop.ImageCreateInfo*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
        }
    }
}
