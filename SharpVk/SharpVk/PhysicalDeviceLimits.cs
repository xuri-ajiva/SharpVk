// The MIT License (MIT)
// 
// Copyright (c) Andrew Armstrong/FacticiusVir 2017
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
    /// Structure reporting implementation-dependent physical device limits.
    /// </summary>
    public struct PhysicalDeviceLimits
    {
        /// <summary>
        /// pname:maxImageDimension1D is the maximum dimension (pname:width) of
        /// an image created with an pname:imageType of ename:VK_IMAGE_TYPE_1D.
        /// </summary>
        public uint MaxImageDimension1D
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:maxImageDimension2D is the maximum dimension (pname:width or
        /// pname:height) of an image created with an pname:imageType of
        /// ename:VK_IMAGE_TYPE_2D and without
        /// ename:VK_IMAGE_CREATE_CUBE_COMPATIBLE_BIT set in pname:flags.
        /// </summary>
        public uint MaxImageDimension2D
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:maxImageDimension3D is the maximum dimension (pname:width,
        /// pname:height, or pname:depth) of an image created with an
        /// pname:imageType of ename:VK_IMAGE_TYPE_3D.
        /// </summary>
        public uint MaxImageDimension3D
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:maxImageDimensionCube is the maximum dimension (pname:width
        /// or pname:height) of an image created with an pname:imageType of
        /// ename:VK_IMAGE_TYPE_2D and with
        /// ename:VK_IMAGE_CREATE_CUBE_COMPATIBLE_BIT set in pname:flags.
        /// </summary>
        public uint MaxImageDimensionCube
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:maxImageArrayLayers is the maximum number of layers
        /// (pname:arrayLayers) for an image.
        /// </summary>
        public uint MaxImageArrayLayers
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:maxTexelBufferElements is the maximum number of addressable
        /// texels for a buffer view created on a buffer which was created with
        /// the ename:VK_BUFFER_USAGE_UNIFORM_TEXEL_BUFFER_BIT or
        /// ename:VK_BUFFER_USAGE_STORAGE_TEXEL_BUFFER_BIT set in the
        /// pname:usage member of the sname:VkBufferCreateInfo structure.
        /// </summary>
        public uint MaxTexelBufferElements
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:maxUniformBufferRange is the maximum value that can: be
        /// specified in the pname:range member of any
        /// slink:VkDescriptorBufferInfo structures passed to a call to
        /// flink:vkUpdateDescriptorSets for descriptors of type
        /// ename:VK_DESCRIPTOR_TYPE_UNIFORM_BUFFER or
        /// ename:VK_DESCRIPTOR_TYPE_UNIFORM_BUFFER_DYNAMIC.
        /// </summary>
        public uint MaxUniformBufferRange
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:maxStorageBufferRange is the maximum value that can: be
        /// specified in the pname:range member of any
        /// slink:VkDescriptorBufferInfo structures passed to a call to
        /// flink:vkUpdateDescriptorSets for descriptors of type
        /// ename:VK_DESCRIPTOR_TYPE_STORAGE_BUFFER or
        /// ename:VK_DESCRIPTOR_TYPE_STORAGE_BUFFER_DYNAMIC.
        /// </summary>
        public uint MaxStorageBufferRange
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:maxPushConstantsSize is the maximum size, in bytes, of the
        /// pool of push constant memory. For each of the push constant ranges
        /// indicated by the pname:pPushConstantRanges member of the
        /// sname:VkPipelineLayoutCreateInfo structure, pname:offset +
        /// pname:size must: be less than or equal to this limit.
        /// </summary>
        public uint MaxPushConstantsSize
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:maxMemoryAllocationCount is the maximum number of device
        /// memory allocations, as created by flink:vkAllocateMemory, which
        /// can: simultaneously exist.
        /// </summary>
        public uint MaxMemoryAllocationCount
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:maxSamplerAllocationCount is the maximum number of sampler
        /// objects, as created by flink:vkCreateSampler, which can:
        /// simultaneously exist on a device.
        /// </summary>
        public uint MaxSamplerAllocationCount
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:bufferImageGranularity is the granularity, in bytes, at which
        /// buffer or linear image resources, and optimal image resources can:
        /// be bound to adjacent offsets in the same sname:VkDeviceMemory
        /// object without aliasing. See
        /// &lt;&lt;resources-bufferimagegranularity,Buffer-Image Granularity&gt;&gt;
        /// for more details.
        /// </summary>
        public ulong BufferImageGranularity
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:sparseAddressSpaceSize is the total amount of address space
        /// available, in bytes, for sparse memory resources. This is an upper
        /// bound on the sum of the size of all sparse resources, regardless of
        /// whether any memory is bound to them.
        /// </summary>
        public ulong SparseAddressSpaceSize
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:maxBoundDescriptorSets is the maximum number of descriptor
        /// sets that can: be simultaneously used by a pipeline. All
        /// code:DescriptorSet decorations in shader modules must: have a value
        /// less than pname:maxBoundDescriptorSets. See
        /// &lt;&lt;descriptorsets-sets&gt;&gt;.
        /// </summary>
        public uint MaxBoundDescriptorSets
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:maxPerStageDescriptorSamplers is the maximum number of
        /// samplers that can: be accessible to a single shader stage in a
        /// pipeline layout. Descriptors with a type of
        /// ename:VK_DESCRIPTOR_TYPE_SAMPLER or
        /// ename:VK_DESCRIPTOR_TYPE_COMBINED_IMAGE_SAMPLER count against this
        /// limit. A descriptor is accessible to a shader stage when the
        /// pname:stageFlags member of the sname:VkDescriptorSetLayoutBinding
        /// structure has the bit for that shader stage set. See
        /// &lt;&lt;descriptorsets-sampler&gt;&gt; and
        /// &lt;&lt;descriptorsets-combinedimagesampler&gt;&gt;.
        /// </summary>
        public uint MaxPerStageDescriptorSamplers
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:maxPerStageDescriptorUniformBuffers is the maximum number of
        /// uniform buffers that can: be accessible to a single shader stage in
        /// a pipeline layout. Descriptors with a type of
        /// ename:VK_DESCRIPTOR_TYPE_UNIFORM_BUFFER or
        /// ename:VK_DESCRIPTOR_TYPE_UNIFORM_BUFFER_DYNAMIC count against this
        /// limit. A descriptor is accessible to a shader stage when the
        /// pname:stageFlags member of the sname:VkDescriptorSetLayoutBinding
        /// structure has the bit for that shader stage set. See
        /// &lt;&lt;descriptorsets-uniformbuffer&gt;&gt; and
        /// &lt;&lt;descriptorsets-uniformbufferdynamic&gt;&gt;.
        /// </summary>
        public uint MaxPerStageDescriptorUniformBuffers
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:maxPerStageDescriptorStorageBuffers is the maximum number of
        /// storage buffers that can: be accessible to a single shader stage in
        /// a pipeline layout. Descriptors with a type of
        /// ename:VK_DESCRIPTOR_TYPE_STORAGE_BUFFER or
        /// ename:VK_DESCRIPTOR_TYPE_STORAGE_BUFFER_DYNAMIC count against this
        /// limit. A descriptor is accessible to a pipeline shader stage when
        /// the pname:stageFlags member of the
        /// sname:VkDescriptorSetLayoutBinding structure has the bit for that
        /// shader stage set. See &lt;&lt;descriptorsets-storagebuffer&gt;&gt;
        /// and &lt;&lt;descriptorsets-storagebufferdynamic&gt;&gt;.
        /// </summary>
        public uint MaxPerStageDescriptorStorageBuffers
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:maxPerStageDescriptorSampledImages is the maximum number of
        /// sampled images that can: be accessible to a single shader stage in
        /// a pipeline layout. Descriptors with a type of
        /// ename:VK_DESCRIPTOR_TYPE_COMBINED_IMAGE_SAMPLER, ename:VK_DESCRIPTOR_TYPE_SAMPLED_IMAGE,
        /// or ename:VK_DESCRIPTOR_TYPE_UNIFORM_TEXEL_BUFFER count against this
        /// limit. A descriptor is accessible to a pipeline shader stage when
        /// the pname:stageFlags member of the
        /// sname:VkDescriptorSetLayoutBinding structure has the bit for that
        /// shader stage set. See
        /// &lt;&lt;descriptorsets-combinedimagesampler&gt;&gt;, &lt;&lt;descriptorsets-sampledimage&gt;&gt;,
        /// and &lt;&lt;descriptorsets-uniformtexelbuffer&gt;&gt;.
        /// </summary>
        public uint MaxPerStageDescriptorSampledImages
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:maxPerStageDescriptorStorageImages is the maximum number of
        /// storage images that can: be accessible to a single shader stage in
        /// a pipeline layout. Descriptors with a type of
        /// ename:VK_DESCRIPTOR_TYPE_STORAGE_IMAGE, or
        /// ename:VK_DESCRIPTOR_TYPE_STORAGE_TEXEL_BUFFER count against this
        /// limit. A descriptor is accessible to a pipeline shader stage when
        /// the pname:stageFlags member of the
        /// sname:VkDescriptorSetLayoutBinding structure has the bit for that
        /// shader stage set. See &lt;&lt;descriptorsets-storageimage&gt;&gt;,
        /// and &lt;&lt;descriptorsets-storagetexelbuffer&gt;&gt;.
        /// </summary>
        public uint MaxPerStageDescriptorStorageImages
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:maxPerStageDescriptorInputAttachments is the maximum number
        /// of input attachments that can: be accessible to a single shader
        /// stage in a pipeline layout. Descriptors with a type of
        /// ename:VK_DESCRIPTOR_TYPE_INPUT_ATTACHMENT count against this limit.
        /// A descriptor is accessible to a pipeline shader stage when the
        /// pname:stageFlags member of the sname:VkDescriptorSetLayoutBinding
        /// structure has the bit for that shader stage set. These are only
        /// supported for the fragment stage. See
        /// &lt;&lt;descriptorsets-inputattachment&gt;&gt;.
        /// </summary>
        public uint MaxPerStageDescriptorInputAttachments
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:maxPerStageResources is the maximum number of resources that
        /// can: be accessible to a single shader stage in a pipeline layout.
        /// Descriptors with a type of
        /// ename:VK_DESCRIPTOR_TYPE_COMBINED_IMAGE_SAMPLER, ename:VK_DESCRIPTOR_TYPE_SAMPLED_IMAGE,
        /// ename:VK_DESCRIPTOR_TYPE_STORAGE_IMAGE,
        /// ename:VK_DESCRIPTOR_TYPE_UNIFORM_TEXEL_BUFFER, ename:VK_DESCRIPTOR_TYPE_STORAGE_TEXEL_BUFFER,
        /// ename:VK_DESCRIPTOR_TYPE_UNIFORM_BUFFER,
        /// ename:VK_DESCRIPTOR_TYPE_STORAGE_BUFFER, ename:VK_DESCRIPTOR_TYPE_UNIFORM_BUFFER_DYNAMIC,
        /// ename:VK_DESCRIPTOR_TYPE_STORAGE_BUFFER_DYNAMIC, or
        /// ename:VK_DESCRIPTOR_TYPE_INPUT_ATTACHMENT count against this limit.
        /// For the fragment shader stage the framebuffer color attachments
        /// also count against this limit.
        /// </summary>
        public uint MaxPerStageResources
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:maxDescriptorSetSamplers is the maximum number of samplers
        /// that can: be included in descriptor bindings in a pipeline layout
        /// across all pipeline shader stages and descriptor set numbers.
        /// Descriptors with a type of ename:VK_DESCRIPTOR_TYPE_SAMPLER or
        /// ename:VK_DESCRIPTOR_TYPE_COMBINED_IMAGE_SAMPLER count against this
        /// limit. See &lt;&lt;descriptorsets-sampler&gt;&gt; and
        /// &lt;&lt;descriptorsets-combinedimagesampler&gt;&gt;.
        /// </summary>
        public uint MaxDescriptorSetSamplers
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:maxDescriptorSetUniformBuffers is the maximum number of
        /// uniform buffers that can: be included in descriptor bindings in a
        /// pipeline layout across all pipeline shader stages and descriptor
        /// set numbers. Descriptors with a type of
        /// ename:VK_DESCRIPTOR_TYPE_UNIFORM_BUFFER or
        /// ename:VK_DESCRIPTOR_TYPE_UNIFORM_BUFFER_DYNAMIC count against this
        /// limit. See &lt;&lt;descriptorsets-uniformbuffer&gt;&gt; and
        /// &lt;&lt;descriptorsets-uniformbufferdynamic&gt;&gt;.
        /// </summary>
        public uint MaxDescriptorSetUniformBuffers
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:maxDescriptorSetUniformBuffersDynamic is the maximum number
        /// of dynamic uniform buffers that can: be included in descriptor
        /// bindings in a pipeline layout across all pipeline shader stages and
        /// descriptor set numbers. Descriptors with a type of
        /// ename:VK_DESCRIPTOR_TYPE_UNIFORM_BUFFER_DYNAMIC count against this
        /// limit. See &lt;&lt;descriptorsets-uniformbufferdynamic&gt;&gt;.
        /// </summary>
        public uint MaxDescriptorSetUniformBuffersDynamic
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:maxDescriptorSetStorageBuffers is the maximum number of
        /// storage buffers that can: be included in descriptor bindings in a
        /// pipeline layout across all pipeline shader stages and descriptor
        /// set numbers. Descriptors with a type of
        /// ename:VK_DESCRIPTOR_TYPE_STORAGE_BUFFER or
        /// ename:VK_DESCRIPTOR_TYPE_STORAGE_BUFFER_DYNAMIC count against this
        /// limit. See &lt;&lt;descriptorsets-storagebuffer&gt;&gt; and
        /// &lt;&lt;descriptorsets-storagebufferdynamic&gt;&gt;.
        /// </summary>
        public uint MaxDescriptorSetStorageBuffers
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:maxDescriptorSetStorageBuffersDynamic is the maximum number
        /// of dynamic storage buffers that can: be included in descriptor
        /// bindings in a pipeline layout across all pipeline shader stages and
        /// descriptor set numbers. Descriptors with a type of
        /// ename:VK_DESCRIPTOR_TYPE_STORAGE_BUFFER_DYNAMIC count against this
        /// limit. See &lt;&lt;descriptorsets-storagebufferdynamic&gt;&gt;.
        /// </summary>
        public uint MaxDescriptorSetStorageBuffersDynamic
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:maxDescriptorSetSampledImages is the maximum number of
        /// sampled images that can: be included in descriptor bindings in a
        /// pipeline layout across all pipeline shader stages and descriptor
        /// set numbers. Descriptors with a type of
        /// ename:VK_DESCRIPTOR_TYPE_COMBINED_IMAGE_SAMPLER, ename:VK_DESCRIPTOR_TYPE_SAMPLED_IMAGE,
        /// or ename:VK_DESCRIPTOR_TYPE_UNIFORM_TEXEL_BUFFER count against this
        /// limit. See &lt;&lt;descriptorsets-combinedimagesampler&gt;&gt;,
        /// &lt;&lt;descriptorsets-sampledimage&gt;&gt;, and
        /// &lt;&lt;descriptorsets-uniformtexelbuffer&gt;&gt;.
        /// </summary>
        public uint MaxDescriptorSetSampledImages
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:maxDescriptorSetStorageImages is the maximum number of
        /// storage images that can: be included in descriptor bindings in a
        /// pipeline layout across all pipeline shader stages and descriptor
        /// set numbers. Descriptors with a type of
        /// ename:VK_DESCRIPTOR_TYPE_STORAGE_IMAGE, or
        /// ename:VK_DESCRIPTOR_TYPE_STORAGE_TEXEL_BUFFER count against this
        /// limit. See &lt;&lt;descriptorsets-storageimage&gt;&gt;, and
        /// &lt;&lt;descriptorsets-storagetexelbuffer&gt;&gt;.
        /// </summary>
        public uint MaxDescriptorSetStorageImages
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:maxDescriptorSetInputAttachments is the maximum number of
        /// input attachments that can: be included in descriptor bindings in a
        /// pipeline layout across all pipeline shader stages and descriptor
        /// set numbers. Descriptors with a type of
        /// ename:VK_DESCRIPTOR_TYPE_INPUT_ATTACHMENT count against this limit.
        /// See &lt;&lt;descriptorsets-inputattachment&gt;&gt;.
        /// </summary>
        public uint MaxDescriptorSetInputAttachments
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:maxVertexInputAttributes is the maximum number of vertex
        /// input attributes that can: be specified for a graphics pipeline.
        /// These are described in the array of
        /// sname:VkVertexInputAttributeDescription structures that are
        /// provided at graphics pipeline creation time via the
        /// pname:pVertexAttributeDescriptions member of the
        /// sname:VkPipelineVertexInputStateCreateInfo structure. See
        /// &lt;&lt;fxvertex-attrib&gt;&gt; and &lt;&lt;fxvertex-input&gt;&gt;.
        /// </summary>
        public uint MaxVertexInputAttributes
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:maxVertexInputBindings is the maximum number of vertex
        /// buffers that can: be specified for providing vertex attributes to a
        /// graphics pipeline. These are described in the array of
        /// sname:VkVertexInputBindingDescription structures that are provided
        /// at graphics pipeline creation time via the
        /// pname:pVertexBindingDescriptions member of the
        /// sname:VkPipelineVertexInputStateCreateInfo structure. The
        /// pname:binding member of sname:VkVertexInputBindingDescription must:
        /// be less than this limit. See &lt;&lt;fxvertex-input&gt;&gt;.
        /// </summary>
        public uint MaxVertexInputBindings
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:maxVertexInputAttributeOffset is the maximum vertex input
        /// attribute offset that can: be added to the vertex input binding
        /// stride. The pname:offset member of the
        /// sname:VkVertexInputAttributeDescription structure must: be less
        /// than or equal to this limit. See &lt;&lt;fxvertex-input&gt;&gt;.
        /// </summary>
        public uint MaxVertexInputAttributeOffset
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:maxVertexInputBindingStride is the maximum vertex input
        /// binding stride that can: be specified in a vertex input binding.
        /// The pname:stride member of the
        /// sname:VkVertexInputBindingDescription structure must: be less than
        /// or equal to this limit. See &lt;&lt;fxvertex-input&gt;&gt;.
        /// </summary>
        public uint MaxVertexInputBindingStride
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:maxVertexOutputComponents is the maximum number of components
        /// of output variables which can: be output by a vertex shader. See
        /// &lt;&lt;shaders-vertex&gt;&gt;.
        /// </summary>
        public uint MaxVertexOutputComponents
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:maxTessellationGenerationLevel is the maximum tessellation
        /// generation level supported by the fixed-function tessellation
        /// primitive generator. See &lt;&lt;tessellation&gt;&gt;.
        /// </summary>
        public uint MaxTessellationGenerationLevel
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:maxTessellationPatchSize is the maximum patch size, in
        /// vertices, of patches that can: be processed by the tessellation
        /// control shader and tessellation primitive generator. The
        /// pname:patchControlPoints member of the
        /// sname:VkPipelineTessellationStateCreateInfo structure specified at
        /// pipeline creation time and the value provided in the
        /// code:OutputVertices execution mode of shader modules must: be less
        /// than or equal to this limit. See &lt;&lt;tessellation&gt;&gt;.
        /// </summary>
        public uint MaxTessellationPatchSize
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:maxTessellationControlPerVertexInputComponents is the maximum
        /// number of components of input variables which can: be provided as
        /// per-vertex inputs to the tessellation control shader stage.
        /// </summary>
        public uint MaxTessellationControlPerVertexInputComponents
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:maxTessellationControlPerVertexOutputComponents is the
        /// maximum number of components of per-vertex output variables which
        /// can: be output from the tessellation control shader stage.
        /// </summary>
        public uint MaxTessellationControlPerVertexOutputComponents
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:maxTessellationControlPerPatchOutputComponents is the maximum
        /// number of components of per-patch output variables which can: be
        /// output from the tessellation control shader stage.
        /// </summary>
        public uint MaxTessellationControlPerPatchOutputComponents
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:maxTessellationControlTotalOutputComponents is the maximum
        /// total number of components of per-vertex and per-patch output
        /// variables which can: be output from the tessellation control shader
        /// stage.
        /// </summary>
        public uint MaxTessellationControlTotalOutputComponents
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:maxTessellationEvaluationInputComponents is the maximum
        /// number of components of input variables which can: be provided as
        /// per-vertex inputs to the tessellation evaluation shader stage.
        /// </summary>
        public uint MaxTessellationEvaluationInputComponents
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:maxTessellationEvaluationOutputComponents is the maximum
        /// number of components of per-vertex output variables which can: be
        /// output from the tessellation evaluation shader stage.
        /// </summary>
        public uint MaxTessellationEvaluationOutputComponents
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:maxGeometryShaderInvocations is the maximum invocation count
        /// supported for instanced geometry shaders. The value provided in the
        /// code:Invocations execution mode of shader modules must: be less
        /// than or equal to this limit. See &lt;&lt;geometry&gt;&gt;.
        /// </summary>
        public uint MaxGeometryShaderInvocations
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:maxGeometryInputComponents is the maximum number of
        /// components of input variables which can: be provided as inputs to
        /// the geometry shader stage.
        /// </summary>
        public uint MaxGeometryInputComponents
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:maxGeometryOutputComponents is the maximum number of
        /// components of output variables which can: be output from the
        /// geometry shader stage.
        /// </summary>
        public uint MaxGeometryOutputComponents
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:maxGeometryOutputVertices is the maximum number of vertices
        /// which can: be emitted by any geometry shader.
        /// </summary>
        public uint MaxGeometryOutputVertices
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:maxGeometryTotalOutputComponents is the maximum total number
        /// of components of output, across all emitted vertices, which can: be
        /// output from the geometry shader stage.
        /// </summary>
        public uint MaxGeometryTotalOutputComponents
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:maxFragmentInputComponents is the maximum number of
        /// components of input variables which can: be provided as inputs to
        /// the fragment shader stage.
        /// </summary>
        public uint MaxFragmentInputComponents
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:maxFragmentOutputAttachments is the maximum number of output
        /// attachments which can: be written to by the fragment shader stage.
        /// </summary>
        public uint MaxFragmentOutputAttachments
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:maxFragmentDualSrcAttachments is the maximum number of output
        /// attachments which can: be written to by the fragment shader stage
        /// when blending is enabled and one of the dual source blend modes is
        /// in use. See &lt;&lt;framebuffer-dsb&gt;&gt; and
        /// &lt;&lt;features-features-dualSrcBlend,dualSrcBlend&gt;&gt;.
        /// </summary>
        public uint MaxFragmentDualSourceAttachments
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:maxFragmentCombinedOutputResources is the total number of
        /// storage buffers, storage images, and output buffers which can: be
        /// used in the fragment shader stage.
        /// </summary>
        public uint MaxFragmentCombinedOutputResources
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:maxComputeSharedMemorySize is the maximum total storage size,
        /// in bytes, of all variables declared with the code:WorkgroupLocal
        /// storage class in shader modules (or with the code:shared storage
        /// qualifier in GLSL) in the compute shader stage.
        /// </summary>
        public uint MaxComputeSharedMemorySize
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:maxComputeWorkGroupCount[3] is the maximum number of local
        /// workgroups that can: be dispatched by a single dispatch command.
        /// These three values represent the maximum number of local workgroups
        /// for the X, Y, and Z dimensions, respectively. The pname:x, pname:y,
        /// and pname:z parameters to the flink:vkCmdDispatch command, or
        /// members of the slink:VkDispatchIndirectCommand structure must: be
        /// less than or equal to the corresponding limit. See
        /// &lt;&lt;dispatch&gt;&gt;.
        /// </summary>
        public uint[] MaxComputeWorkGroupCount
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:maxComputeWorkGroupInvocations is the maximum total number of
        /// compute shader invocations in a single local workgroup. The product
        /// of the X, Y, and Z sizes as specified by the code:LocalSize
        /// execution mode in shader modules and by the object decorated by the
        /// code:WorkgroupSize decoration must: be less than or equal to this
        /// limit.
        /// </summary>
        public uint MaxComputeWorkGroupInvocations
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:maxComputeWorkGroupSize[3] is the maximum size of a local
        /// compute workgroup, per dimension. These three values represent the
        /// maximum local workgroup size in the X, Y, and Z dimensions,
        /// respectively. The pname:x, pname:y, and pname:z sizes specified by
        /// the code:LocalSize execution mode and by the object decorated by
        /// the code:WorkgroupSize decoration in shader modules must: be less
        /// than or equal to the corresponding limit.
        /// </summary>
        public uint[] MaxComputeWorkGroupSize
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:subPixelPrecisionBits is the number of bits of subpixel
        /// precision in framebuffer coordinates [eq]#x~f~# and [eq]#y~f~#. See
        /// &lt;&lt;primsrast&gt;&gt;.
        /// </summary>
        public uint SubPixelPrecisionBits
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:subTexelPrecisionBits is the number of bits of precision in
        /// the division along an axis of an image used for minification and
        /// magnification filters. [eq]#2^pname:subTexelPrecisionBits^# is the
        /// actual number of divisions along each axis of the image
        /// represented. The filtering hardware will snap to these locations
        /// when computing the filtered results.
        /// </summary>
        public uint SubTexelPrecisionBits
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:mipmapPrecisionBits is the number of bits of division that
        /// the LOD calculation for mipmap fetching get snapped to when
        /// determining the contribution from each mip level to the mip
        /// filtered results. [eq]#2^pname:mipmapPrecisionBits^# is the actual
        /// number of divisions. + -- [NOTE] .Note ==== For example, if this
        /// value is 2 bits then when linearly filtering between two levels,
        /// each level could: contribute: 0%, 33%, 66%, or 100% (this is just
        /// an example and the amount of contribution should: be covered by
        /// different equations in the spec). ==== -- +
        /// </summary>
        public uint MipmapPrecisionBits
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:maxDrawIndexedIndexValue is the maximum index value that can:
        /// be used for indexed draw calls when using 32-bit indices. This
        /// excludes the primitive restart index value of 0xFFFFFFFF. See
        /// &lt;&lt;features-features-fullDrawIndexUint32,fullDrawIndexUint32&gt;&gt;.
        /// </summary>
        public uint MaxDrawIndexedIndexValue
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:maxDrawIndirectCount is the maximum draw count that is
        /// supported for indirect draw calls. See
        /// &lt;&lt;features-features-multiDrawIndirect,multiDrawIndirect&gt;&gt;.
        /// </summary>
        public uint MaxDrawIndirectCount
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:maxSamplerLodBias is the maximum absolute sampler level of
        /// detail bias. The sum of the pname:mipLodBias member of the
        /// sname:VkSamplerCreateInfo structure and the code:Bias operand of
        /// image sampling operations in shader modules (or 0 if no code:Bias
        /// operand is provided to an image sampling operation) are clamped to
        /// the range
        /// [eq]#[-pname:maxSamplerLodBias,+pname:maxSamplerLodBias]#. See
        /// &lt;&lt;samplers-mipLodBias&gt;&gt;.
        /// </summary>
        public float MaxSamplerLodBias
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:maxSamplerAnisotropy is the maximum degree of sampler
        /// anisotropy. The maximum degree of anisotropic filtering used for an
        /// image sampling operation is the minimum of the pname:maxAnisotropy
        /// member of the sname:VkSamplerCreateInfo structure and this limit.
        /// See &lt;&lt;samplers-maxAnisotropy&gt;&gt;.
        /// </summary>
        public float MaxSamplerAnisotropy
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:maxViewports is the maximum number of active viewports. The
        /// pname:viewportCount member of the
        /// sname:VkPipelineViewportStateCreateInfo structure that is provided
        /// at pipeline creation must: be less than or equal to this limit.
        /// </summary>
        public uint MaxViewports
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:maxViewportDimensions[2] are the maximum viewport dimensions
        /// in the X (width) and Y (height) dimensions, respectively. The
        /// maximum viewport dimensions must: be greater than or equal to the
        /// largest image which can: be created and used as a framebuffer
        /// attachment. See &lt;&lt;vertexpostproc-viewport,Controlling the
        /// Viewport&gt;&gt;.
        /// </summary>
        public uint[] MaxViewportDimensions
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:viewportBoundsRange[2] is the [eq]#[minimum, maximum]# range
        /// that the corners of a viewport must: be contained in. This range
        /// must: be at least [eq]#[-2 {times} pname:size, 2 {times} pname:size
        /// - 1]#, where [eq]#pname:size = max(pname:maxViewportDimensions[0],
        /// pname:maxViewportDimensions[1])#. See
        /// &lt;&lt;vertexpostproc-viewport,Controlling the Viewport&gt;&gt;. +
        /// -- [NOTE] .Note ==== The intent of the pname:viewportBoundsRange
        /// limit is to allow a maximum sized viewport to be arbitrarily
        /// shifted relative to the output target as long as at least some
        /// portion intersects. This would give a bounds limit of
        /// [eq]#[-pname:size + 1, 2 {times} pname:size - 1]# which would allow
        /// all possible non-empty-set intersections of the output target and
        /// the viewport. Since these numbers are typically powers of two,
        /// picking the signed number range using the smallest possible number
        /// of bits ends up with the specified range. ==== --
        /// </summary>
        public float[] ViewportBoundsRange
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:viewportSubPixelBits is the number of bits of subpixel
        /// precision for viewport bounds. The subpixel precision that
        /// floating-point viewport bounds are interpreted at is given by this
        /// limit.
        /// </summary>
        public uint ViewportSubPixelBits
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:minMemoryMapAlignment is the minimum required: alignment, in
        /// bytes, of host visible memory allocations within the host address
        /// space. When mapping a memory allocation with flink:vkMapMemory,
        /// subtracting pname:offset bytes from the returned pointer will
        /// always produce an integer multiple of this limit. See
        /// &lt;&lt;memory-device-hostaccess&gt;&gt;.
        /// </summary>
        public Size MinMemoryMapAlignment
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:minTexelBufferOffsetAlignment is the minimum required:
        /// alignment, in bytes, for the pname:offset member of the
        /// sname:VkBufferViewCreateInfo structure for texel buffers. When a
        /// buffer view is created for a buffer which was created with
        /// ename:VK_BUFFER_USAGE_UNIFORM_TEXEL_BUFFER_BIT or
        /// ename:VK_BUFFER_USAGE_STORAGE_TEXEL_BUFFER_BIT set in the
        /// pname:usage member of the sname:VkBufferCreateInfo structure, the
        /// pname:offset must: be an integer multiple of this limit.
        /// </summary>
        public ulong MinTexelBufferOffsetAlignment
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:minUniformBufferOffsetAlignment is the minimum required:
        /// alignment, in bytes, for the pname:offset member of the
        /// sname:VkDescriptorBufferInfo structure for uniform buffers. When a
        /// descriptor of type ename:VK_DESCRIPTOR_TYPE_UNIFORM_BUFFER or
        /// ename:VK_DESCRIPTOR_TYPE_UNIFORM_BUFFER_DYNAMIC is updated, the
        /// pname:offset must: be an integer multiple of this limit. Similarly,
        /// dynamic offsets for uniform buffers must: be multiples of this
        /// limit.
        /// </summary>
        public ulong MinUniformBufferOffsetAlignment
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:minStorageBufferOffsetAlignment is the minimum required:
        /// alignment, in bytes, for the pname:offset member of the
        /// sname:VkDescriptorBufferInfo structure for storage buffers. When a
        /// descriptor of type ename:VK_DESCRIPTOR_TYPE_STORAGE_BUFFER or
        /// ename:VK_DESCRIPTOR_TYPE_STORAGE_BUFFER_DYNAMIC is updated, the
        /// pname:offset must: be an integer multiple of this limit. Similarly,
        /// dynamic offsets for storage buffers must: be multiples of this
        /// limit.
        /// </summary>
        public ulong MinStorageBufferOffsetAlignment
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:minTexelOffset is the minimum offset value for the
        /// code:ConstOffset image operand of any of the code:OpImageSample* or
        /// code:OpImageFetch* image instructions.
        /// </summary>
        public int MinTexelOffset
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:maxTexelOffset is the maximum offset value for the
        /// code:ConstOffset image operand of any of the code:OpImageSample* or
        /// code:OpImageFetch* image instructions.
        /// </summary>
        public uint MaxTexelOffset
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:minTexelGatherOffset is the minimum offset value for the
        /// code:Offset or code:ConstOffsets image operands of any of the
        /// code:OpImage*code:Gather image instructions.
        /// </summary>
        public int MinTexelGatherOffset
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:maxTexelGatherOffset is the maximum offset value for the
        /// code:Offset or code:ConstOffsets image operands of any of the
        /// code:OpImage*code:Gather image instructions.
        /// </summary>
        public uint MaxTexelGatherOffset
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:minInterpolationOffset is the minimum negative offset value
        /// for the code:offset operand of the code:InterpolateAtOffset
        /// extended instruction.
        /// </summary>
        public float MinInterpolationOffset
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:maxInterpolationOffset is the maximum positive offset value
        /// for the code:offset operand of the code:InterpolateAtOffset
        /// extended instruction.
        /// </summary>
        public float MaxInterpolationOffset
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:subPixelInterpolationOffsetBits is the number of subpixel
        /// fractional bits that the code:x and code:y offsets to the
        /// code:InterpolateAtOffset extended instruction may: be rounded to as
        /// fixed-point values.
        /// </summary>
        public uint SubPixelInterpolationOffsetBits
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:maxFramebufferWidth is the maximum width for a framebuffer.
        /// The pname:width member of the sname:VkFramebufferCreateInfo
        /// structure must: be less than or equal to this limit.
        /// </summary>
        public uint MaxFramebufferWidth
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:maxFramebufferHeight is the maximum height for a framebuffer.
        /// The pname:height member of the sname:VkFramebufferCreateInfo
        /// structure must: be less than or equal to this limit.
        /// </summary>
        public uint MaxFramebufferHeight
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:maxFramebufferLayers is the maximum layer count for a layered
        /// framebuffer. The pname:layers member of the
        /// sname:VkFramebufferCreateInfo structure must: be less than or equal
        /// to this limit.
        /// </summary>
        public uint MaxFramebufferLayers
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:framebufferColorSampleCounts is a bitmask^1^ of
        /// elink:VkSampleCountFlagBits bits indicating the color sample counts
        /// that are supported for all framebuffer color attachments.
        /// </summary>
        public SampleCountFlags FramebufferColorSampleCounts
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:framebufferDepthSampleCounts is a bitmask^1^ of
        /// elink:VkSampleCountFlagBits bits indicating the supported depth
        /// sample counts for all framebuffer depth/stencil attachments, when
        /// the format includes a depth component.
        /// </summary>
        public SampleCountFlags FramebufferDepthSampleCounts
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:framebufferStencilSampleCounts is a bitmask^1^ of
        /// elink:VkSampleCountFlagBits bits indicating the supported stencil
        /// sample counts for all framebuffer depth/stencil attachments, when
        /// the format includes a stencil component.
        /// </summary>
        public SampleCountFlags FramebufferStencilSampleCounts
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:framebufferNoAttachmentsSampleCounts is a bitmask^1^ of
        /// elink:VkSampleCountFlagBits bits indicating the supported sample
        /// counts for a framebuffer with no attachments.
        /// </summary>
        public SampleCountFlags FramebufferNoAttachmentsSampleCounts
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:maxColorAttachments is the maximum number of color
        /// attachments that can: be used by a subpass in a render pass. The
        /// pname:colorAttachmentCount member of the sname:VkSubpassDescription
        /// structure must: be less than or equal to this limit.
        /// </summary>
        public uint MaxColorAttachments
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:sampledImageColorSampleCounts is a bitmask^1^ of
        /// elink:VkSampleCountFlagBits bits indicating the sample counts
        /// supported for all 2D images created with
        /// ename:VK_IMAGE_TILING_OPTIMAL, pname:usage containing
        /// ename:VK_IMAGE_USAGE_SAMPLED_BIT, and a non-integer color format.
        /// </summary>
        public SampleCountFlags SampledImageColorSampleCounts
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:sampledImageIntegerSampleCounts is a bitmask^1^ of
        /// elink:VkSampleCountFlagBits bits indicating the sample counts
        /// supported for all 2D images created with
        /// ename:VK_IMAGE_TILING_OPTIMAL, pname:usage containing
        /// ename:VK_IMAGE_USAGE_SAMPLED_BIT, and an integer color format.
        /// </summary>
        public SampleCountFlags SampledImageIntegerSampleCounts
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:sampledImageDepthSampleCounts is a bitmask^1^ of
        /// elink:VkSampleCountFlagBits bits indicating the sample counts
        /// supported for all 2D images created with
        /// ename:VK_IMAGE_TILING_OPTIMAL, pname:usage containing
        /// ename:VK_IMAGE_USAGE_SAMPLED_BIT, and a depth format.
        /// </summary>
        public SampleCountFlags SampledImageDepthSampleCounts
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:sampledImageStencilSampleCounts is a bitmask^1^ of
        /// elink:VkSampleCountFlagBits bits indicating the sample supported
        /// for all 2D images created with ename:VK_IMAGE_TILING_OPTIMAL,
        /// pname:usage containing ename:VK_IMAGE_USAGE_SAMPLED_BIT, and a
        /// stencil format.
        /// </summary>
        public SampleCountFlags SampledImageStencilSampleCounts
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:storageImageSampleCounts is a bitmask^1^ of
        /// elink:VkSampleCountFlagBits bits indicating the sample counts
        /// supported for all 2D images created with
        /// ename:VK_IMAGE_TILING_OPTIMAL, and pname:usage containing
        /// ename:VK_IMAGE_USAGE_STORAGE_BIT.
        /// </summary>
        public SampleCountFlags StorageImageSampleCounts
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:maxSampleMaskWords is the maximum number of array elements of
        /// a variable decorated with the code:SampleMask built-in decoration.
        /// </summary>
        public uint MaxSampleMaskWords
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:timestampComputeAndGraphics indicates support for timestamps
        /// on all graphics and compute queues. If this limit is set to
        /// ename:VK_TRUE, all queues that advertise the
        /// ename:VK_QUEUE_GRAPHICS_BIT or ename:VK_QUEUE_COMPUTE_BIT in the
        /// sname:VkQueueFamilyProperties::pname:queueFlags support
        /// sname:VkQueueFamilyProperties::pname:timestampValidBits of at least
        /// 36. See &lt;&lt;queries-timestamps, Timestamp Queries&gt;&gt;.
        /// </summary>
        public Bool32 TimestampComputeAndGraphics
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:timestampPeriod is the number of nanoseconds required: for a
        /// timestamp query to be incremented by 1. See
        /// &lt;&lt;queries-timestamps, Timestamp Queries&gt;&gt;.
        /// </summary>
        public float TimestampPeriod
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:maxClipDistances is the maximum number of clip distances that
        /// can: be used in a single shader stage. The size of any array
        /// declared with the code:ClipDistance built-in decoration in a shader
        /// module must: be less than or equal to this limit.
        /// </summary>
        public uint MaxClipDistances
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:maxCullDistances is the maximum number of cull distances that
        /// can: be used in a single shader stage. The size of any array
        /// declared with the code:CullDistance built-in decoration in a shader
        /// module must: be less than or equal to this limit.
        /// </summary>
        public uint MaxCullDistances
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:maxCombinedClipAndCullDistances is the maximum combined
        /// number of clip and cull distances that can: be used in a single
        /// shader stage. The sum of the sizes of any pair of arrays declared
        /// with the code:ClipDistance and code:CullDistance built-in
        /// decoration used by a single shader stage in a shader module must:
        /// be less than or equal to this limit.
        /// </summary>
        public uint MaxCombinedClipAndCullDistances
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:discreteQueuePriorities is the number of discrete priorities
        /// that can: be assigned to a queue based on the value of each member
        /// of sname:VkDeviceQueueCreateInfo::pname:pQueuePriorities. This
        /// must: be at least 2, and levels must: be spread evenly over the
        /// range, with at least one level at 1.0, and another at 0.0. See
        /// &lt;&lt;devsandqueues-priority&gt;&gt;.
        /// </summary>
        public uint DiscreteQueuePriorities
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:pointSizeRange[2] is the range
        /// [eq]#[pname:minimum,pname:maximum]# of supported sizes for points.
        /// Values written to variables decorated with the code:PointSize
        /// built-in decoration are clamped to this range.
        /// </summary>
        public float[] PointSizeRange
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:lineWidthRange[2] is the range
        /// [eq]#[pname:minimum,pname:maximum]# of supported widths for lines.
        /// Values specified by the pname:lineWidth member of the
        /// sname:VkPipelineRasterizationStateCreateInfo or the pname:lineWidth
        /// parameter to fname:vkCmdSetLineWidth are clamped to this range.
        /// </summary>
        public float[] LineWidthRange
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:pointSizeGranularity is the granularity of supported point
        /// sizes. Not all point sizes in the range defined by
        /// pname:pointSizeRange are supported. This limit specifies the
        /// granularity (or increment) between successive supported point
        /// sizes.
        /// </summary>
        public float PointSizeGranularity
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:lineWidthGranularity is the granularity of supported line
        /// widths. Not all line widths in the range defined by
        /// pname:lineWidthRange are supported. This limit specifies the
        /// granularity (or increment) between successive supported line
        /// widths.
        /// </summary>
        public float LineWidthGranularity
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:strictLines indicates whether lines are rasterized according
        /// to the preferred method of rasterization. If set to ename:VK_FALSE,
        /// lines may: be rasterized under a relaxed set of rules. If set to
        /// ename:VK_TRUE, lines are rasterized as per the strict definition.
        /// See &lt;&lt;primsrast-lines-basic,Basic Line Segment
        /// Rasterization&gt;&gt;.
        /// </summary>
        public Bool32 StrictLines
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:standardSampleLocations indicates whether rasterization uses
        /// the standard sample locations as documented in
        /// &lt;&lt;primsrast-multisampling,Multisampling&gt;&gt;. If set to
        /// ename:VK_TRUE, the implementation uses the documented sample
        /// locations. If set to ename:VK_FALSE, the implementation may: use
        /// different sample locations.
        /// </summary>
        public Bool32 StandardSampleLocations
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:optimalBufferCopyOffsetAlignment is the optimal buffer offset
        /// alignment in bytes for fname:vkCmdCopyBufferToImage and
        /// fname:vkCmdCopyImageToBuffer. The per texel alignment requirements
        /// are still enforced, this is just an additional alignment
        /// recommendation for optimal performance and power.
        /// </summary>
        public ulong OptimalBufferCopyOffsetAlignment
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:optimalBufferCopyRowPitchAlignment is the optimal buffer row
        /// pitch alignment in bytes for fname:vkCmdCopyBufferToImage and
        /// fname:vkCmdCopyImageToBuffer. Row pitch is the number of bytes
        /// between texels with the same X coordinate in adjacent rows (Y
        /// coordinates differ by one). The per texel alignment requirements
        /// are still enforced, this is just an additional alignment
        /// recommendation for optimal performance and power.
        /// </summary>
        public ulong OptimalBufferCopyRowPitchAlignment
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:nonCoherentAtomSize is the size and alignment in bytes that
        /// bounds concurrent access to &lt;&lt;memory-device-hostaccess,
        /// host-mapped device memory&gt;&gt;.
        /// </summary>
        public ulong NonCoherentAtomSize
        {
            get;
            set;
        }
        
        internal static unsafe PhysicalDeviceLimits MarshalFrom(Interop.PhysicalDeviceLimits* value)
        {
            PhysicalDeviceLimits result = new PhysicalDeviceLimits();
            result.MaxComputeWorkGroupCount = Interop.HeapUtil.MarshalFrom(value->MaxComputeWorkGroupCount, 3);
            result.MaxComputeWorkGroupSize = Interop.HeapUtil.MarshalFrom(value->MaxComputeWorkGroupSize, 3);
            result.MaxViewportDimensions = Interop.HeapUtil.MarshalFrom(value->MaxViewportDimensions, 2);
            result.ViewportBoundsRange = Interop.HeapUtil.MarshalFrom(value->ViewportBoundsRange, 2);
            result.PointSizeRange = Interop.HeapUtil.MarshalFrom(value->PointSizeRange, 2);
            result.LineWidthRange = Interop.HeapUtil.MarshalFrom(value->LineWidthRange, 2);
            result.MaxImageDimension1D = value->MaxImageDimension1D;
            result.MaxImageDimension2D = value->MaxImageDimension2D;
            result.MaxImageDimension3D = value->MaxImageDimension3D;
            result.MaxImageDimensionCube = value->MaxImageDimensionCube;
            result.MaxImageArrayLayers = value->MaxImageArrayLayers;
            result.MaxTexelBufferElements = value->MaxTexelBufferElements;
            result.MaxUniformBufferRange = value->MaxUniformBufferRange;
            result.MaxStorageBufferRange = value->MaxStorageBufferRange;
            result.MaxPushConstantsSize = value->MaxPushConstantsSize;
            result.MaxMemoryAllocationCount = value->MaxMemoryAllocationCount;
            result.MaxSamplerAllocationCount = value->MaxSamplerAllocationCount;
            result.BufferImageGranularity = value->BufferImageGranularity;
            result.SparseAddressSpaceSize = value->SparseAddressSpaceSize;
            result.MaxBoundDescriptorSets = value->MaxBoundDescriptorSets;
            result.MaxPerStageDescriptorSamplers = value->MaxPerStageDescriptorSamplers;
            result.MaxPerStageDescriptorUniformBuffers = value->MaxPerStageDescriptorUniformBuffers;
            result.MaxPerStageDescriptorStorageBuffers = value->MaxPerStageDescriptorStorageBuffers;
            result.MaxPerStageDescriptorSampledImages = value->MaxPerStageDescriptorSampledImages;
            result.MaxPerStageDescriptorStorageImages = value->MaxPerStageDescriptorStorageImages;
            result.MaxPerStageDescriptorInputAttachments = value->MaxPerStageDescriptorInputAttachments;
            result.MaxPerStageResources = value->MaxPerStageResources;
            result.MaxDescriptorSetSamplers = value->MaxDescriptorSetSamplers;
            result.MaxDescriptorSetUniformBuffers = value->MaxDescriptorSetUniformBuffers;
            result.MaxDescriptorSetUniformBuffersDynamic = value->MaxDescriptorSetUniformBuffersDynamic;
            result.MaxDescriptorSetStorageBuffers = value->MaxDescriptorSetStorageBuffers;
            result.MaxDescriptorSetStorageBuffersDynamic = value->MaxDescriptorSetStorageBuffersDynamic;
            result.MaxDescriptorSetSampledImages = value->MaxDescriptorSetSampledImages;
            result.MaxDescriptorSetStorageImages = value->MaxDescriptorSetStorageImages;
            result.MaxDescriptorSetInputAttachments = value->MaxDescriptorSetInputAttachments;
            result.MaxVertexInputAttributes = value->MaxVertexInputAttributes;
            result.MaxVertexInputBindings = value->MaxVertexInputBindings;
            result.MaxVertexInputAttributeOffset = value->MaxVertexInputAttributeOffset;
            result.MaxVertexInputBindingStride = value->MaxVertexInputBindingStride;
            result.MaxVertexOutputComponents = value->MaxVertexOutputComponents;
            result.MaxTessellationGenerationLevel = value->MaxTessellationGenerationLevel;
            result.MaxTessellationPatchSize = value->MaxTessellationPatchSize;
            result.MaxTessellationControlPerVertexInputComponents = value->MaxTessellationControlPerVertexInputComponents;
            result.MaxTessellationControlPerVertexOutputComponents = value->MaxTessellationControlPerVertexOutputComponents;
            result.MaxTessellationControlPerPatchOutputComponents = value->MaxTessellationControlPerPatchOutputComponents;
            result.MaxTessellationControlTotalOutputComponents = value->MaxTessellationControlTotalOutputComponents;
            result.MaxTessellationEvaluationInputComponents = value->MaxTessellationEvaluationInputComponents;
            result.MaxTessellationEvaluationOutputComponents = value->MaxTessellationEvaluationOutputComponents;
            result.MaxGeometryShaderInvocations = value->MaxGeometryShaderInvocations;
            result.MaxGeometryInputComponents = value->MaxGeometryInputComponents;
            result.MaxGeometryOutputComponents = value->MaxGeometryOutputComponents;
            result.MaxGeometryOutputVertices = value->MaxGeometryOutputVertices;
            result.MaxGeometryTotalOutputComponents = value->MaxGeometryTotalOutputComponents;
            result.MaxFragmentInputComponents = value->MaxFragmentInputComponents;
            result.MaxFragmentOutputAttachments = value->MaxFragmentOutputAttachments;
            result.MaxFragmentDualSourceAttachments = value->MaxFragmentDualSourceAttachments;
            result.MaxFragmentCombinedOutputResources = value->MaxFragmentCombinedOutputResources;
            result.MaxComputeSharedMemorySize = value->MaxComputeSharedMemorySize;
            result.MaxComputeWorkGroupInvocations = value->MaxComputeWorkGroupInvocations;
            result.SubPixelPrecisionBits = value->SubPixelPrecisionBits;
            result.SubTexelPrecisionBits = value->SubTexelPrecisionBits;
            result.MipmapPrecisionBits = value->MipmapPrecisionBits;
            result.MaxDrawIndexedIndexValue = value->MaxDrawIndexedIndexValue;
            result.MaxDrawIndirectCount = value->MaxDrawIndirectCount;
            result.MaxSamplerLodBias = value->MaxSamplerLodBias;
            result.MaxSamplerAnisotropy = value->MaxSamplerAnisotropy;
            result.MaxViewports = value->MaxViewports;
            result.ViewportSubPixelBits = value->ViewportSubPixelBits;
            result.MinMemoryMapAlignment = value->MinMemoryMapAlignment;
            result.MinTexelBufferOffsetAlignment = value->MinTexelBufferOffsetAlignment;
            result.MinUniformBufferOffsetAlignment = value->MinUniformBufferOffsetAlignment;
            result.MinStorageBufferOffsetAlignment = value->MinStorageBufferOffsetAlignment;
            result.MinTexelOffset = value->MinTexelOffset;
            result.MaxTexelOffset = value->MaxTexelOffset;
            result.MinTexelGatherOffset = value->MinTexelGatherOffset;
            result.MaxTexelGatherOffset = value->MaxTexelGatherOffset;
            result.MinInterpolationOffset = value->MinInterpolationOffset;
            result.MaxInterpolationOffset = value->MaxInterpolationOffset;
            result.SubPixelInterpolationOffsetBits = value->SubPixelInterpolationOffsetBits;
            result.MaxFramebufferWidth = value->MaxFramebufferWidth;
            result.MaxFramebufferHeight = value->MaxFramebufferHeight;
            result.MaxFramebufferLayers = value->MaxFramebufferLayers;
            result.FramebufferColorSampleCounts = value->FramebufferColorSampleCounts;
            result.FramebufferDepthSampleCounts = value->FramebufferDepthSampleCounts;
            result.FramebufferStencilSampleCounts = value->FramebufferStencilSampleCounts;
            result.FramebufferNoAttachmentsSampleCounts = value->FramebufferNoAttachmentsSampleCounts;
            result.MaxColorAttachments = value->MaxColorAttachments;
            result.SampledImageColorSampleCounts = value->SampledImageColorSampleCounts;
            result.SampledImageIntegerSampleCounts = value->SampledImageIntegerSampleCounts;
            result.SampledImageDepthSampleCounts = value->SampledImageDepthSampleCounts;
            result.SampledImageStencilSampleCounts = value->SampledImageStencilSampleCounts;
            result.StorageImageSampleCounts = value->StorageImageSampleCounts;
            result.MaxSampleMaskWords = value->MaxSampleMaskWords;
            result.TimestampComputeAndGraphics = value->TimestampComputeAndGraphics;
            result.TimestampPeriod = value->TimestampPeriod;
            result.MaxClipDistances = value->MaxClipDistances;
            result.MaxCullDistances = value->MaxCullDistances;
            result.MaxCombinedClipAndCullDistances = value->MaxCombinedClipAndCullDistances;
            result.DiscreteQueuePriorities = value->DiscreteQueuePriorities;
            result.PointSizeGranularity = value->PointSizeGranularity;
            result.LineWidthGranularity = value->LineWidthGranularity;
            result.StrictLines = value->StrictLines;
            result.StandardSampleLocations = value->StandardSampleLocations;
            result.OptimalBufferCopyOffsetAlignment = value->OptimalBufferCopyOffsetAlignment;
            result.OptimalBufferCopyRowPitchAlignment = value->OptimalBufferCopyRowPitchAlignment;
            result.NonCoherentAtomSize = value->NonCoherentAtomSize;
            return result;
        }
    }
}
