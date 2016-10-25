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
}
