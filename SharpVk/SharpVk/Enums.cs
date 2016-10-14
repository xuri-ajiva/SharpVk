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
    /// Bitmask specifying classes of memory access the will participate in a
    /// memory barrier dependency.
    /// </para>
    /// <para>
    /// Color attachment reads and writes are automatically (without memory or
    /// execution dependencies) coherent and ordered against themselves and
    /// each other for a given sample within a subpass of a render pass
    /// instance, executing in &lt;&lt;primrast-order,rasterization
    /// order&gt;&gt;. Similarly, depth/stencil attachment reads and writes are
    /// automatically coherent and ordered against themselves and each other in
    /// the same circumstances.
    /// </para>
    /// <para>
    /// Shader reads and/or writes through two variables (in the same or
    /// different shader invocations) decorated with code:Coherent and which
    /// use the same image view or buffer view are automatically coherent with
    /// each other, but require execution dependencies if a specific order is
    /// desired. Similarly, shader atomic operations are coherent with each
    /// other and with code:Coherent variables. Non-code:Coherent shader memory
    /// accesses require memory dependencies for writes to be available and
    /// reads to be visible.
    /// </para>
    /// <para>
    /// Certain memory access types are only supported on queues that support a
    /// particular set of operations. The following table lists, for each
    /// access flag, which queue capability flag must: be supported by the
    /// queue. When multiple flags are enumerated in the second column of the
    /// table it means that the access type is supported on the queue if it
    /// supports any of the listed capability flags. For further details on
    /// queue capabilities see
    /// &lt;&lt;devsandqueues-physical-device-enumeration,Physical Device
    /// Enumeration&gt;&gt; and &lt;&lt;devsandqueues-queues,Queues&gt;&gt;.
    /// </para>
    /// <para>
    /// .Supported access flags
    /// [width="100%",cols="67%,33%",options="header",align="center"] |====
    /// |Access flag | Required queue capability flag
    /// |ename:VK_ACCESS_INDIRECT_COMMAND_READ_BIT |
    /// ename:VK_QUEUE_GRAPHICS_BIT or ename:VK_QUEUE_COMPUTE_BIT
    /// |ename:VK_ACCESS_INDEX_READ_BIT | ename:VK_QUEUE_GRAPHICS_BIT
    /// |ename:VK_ACCESS_VERTEX_ATTRIBUTE_READ_BIT |
    /// ename:VK_QUEUE_GRAPHICS_BIT |ename:VK_ACCESS_UNIFORM_READ_BIT |
    /// ename:VK_QUEUE_GRAPHICS_BIT or ename:VK_QUEUE_COMPUTE_BIT
    /// |ename:VK_ACCESS_INPUT_ATTACHMENT_READ_BIT |
    /// ename:VK_QUEUE_GRAPHICS_BIT |ename:VK_ACCESS_SHADER_READ_BIT |
    /// ename:VK_QUEUE_GRAPHICS_BIT or ename:VK_QUEUE_COMPUTE_BIT
    /// |ename:VK_ACCESS_SHADER_WRITE_BIT | ename:VK_QUEUE_GRAPHICS_BIT or
    /// ename:VK_QUEUE_COMPUTE_BIT |ename:VK_ACCESS_COLOR_ATTACHMENT_READ_BIT |
    /// ename:VK_QUEUE_GRAPHICS_BIT |ename:VK_ACCESS_COLOR_ATTACHMENT_WRITE_BIT
    /// | ename:VK_QUEUE_GRAPHICS_BIT
    /// |ename:VK_ACCESS_DEPTH_STENCIL_ATTACHMENT_READ_BIT |
    /// ename:VK_QUEUE_GRAPHICS_BIT |ename:VK_ACCESS_DEPTH_STENCIL_ATTACHMENT_WRITE_BIT
    /// | ename:VK_QUEUE_GRAPHICS_BIT |ename:VK_ACCESS_TRANSFER_READ_BIT |
    /// ename:VK_QUEUE_GRAPHICS_BIT, ename:VK_QUEUE_COMPUTE_BIT or
    /// ename:VK_QUEUE_TRANSFER_BIT |ename:VK_ACCESS_TRANSFER_WRITE_BIT |
    /// ename:VK_QUEUE_GRAPHICS_BIT, ename:VK_QUEUE_COMPUTE_BIT or
    /// ename:VK_QUEUE_TRANSFER_BIT |ename:VK_ACCESS_HOST_READ_BIT | None
    /// |ename:VK_ACCESS_HOST_WRITE_BIT | None |ename:VK_ACCESS_MEMORY_READ_BIT
    /// | None |ename:VK_ACCESS_MEMORY_WRITE_BIT | None |====
    /// </para>
    /// </summary>
    [Flags]
    public enum AccessFlags
    {
        /// <summary>
        /// -
        /// </summary>
        None = 0, 
        
        /// <summary>
        /// ename:VK_ACCESS_INDIRECT_COMMAND_READ_BIT indicates that the access
        /// is an indirect command structure read as part of an indirect
        /// drawing command.
        /// </summary>
        IndirectCommandRead = 1 << 0, 
        
        /// <summary>
        /// ename:VK_ACCESS_INDEX_READ_BIT indicates that the access is an
        /// index buffer read.
        /// </summary>
        IndexRead = 1 << 1, 
        
        /// <summary>
        /// ename:VK_ACCESS_VERTEX_ATTRIBUTE_READ_BIT indicates that the access
        /// is a read via the vertex input bindings.
        /// </summary>
        VertexAttributeRead = 1 << 2, 
        
        /// <summary>
        /// ename:VK_ACCESS_UNIFORM_READ_BIT indicates that the access is a
        /// read via a uniform buffer or dynamic uniform buffer descriptor.
        /// </summary>
        UniformRead = 1 << 3, 
        
        /// <summary>
        /// ename:VK_ACCESS_INPUT_ATTACHMENT_READ_BIT indicates that the access
        /// is a read via an input attachment descriptor.
        /// </summary>
        InputAttachmentRead = 1 << 4, 
        
        /// <summary>
        /// ename:VK_ACCESS_SHADER_READ_BIT indicates that the access is a read
        /// from a shader via any other descriptor type.
        /// </summary>
        ShaderRead = 1 << 5, 
        
        /// <summary>
        /// ename:VK_ACCESS_SHADER_WRITE_BIT indicates that the access is a
        /// write or atomic from a shader via the same descriptor types as in
        /// ename:VK_ACCESS_SHADER_READ_BIT.
        /// </summary>
        ShaderWrite = 1 << 6, 
        
        /// <summary>
        /// ename:VK_ACCESS_COLOR_ATTACHMENT_READ_BIT indicates that the access
        /// is a read via a color attachment.
        /// </summary>
        ColorAttachmentRead = 1 << 7, 
        
        /// <summary>
        /// ename:VK_ACCESS_COLOR_ATTACHMENT_WRITE_BIT indicates that the
        /// access is a write via a color or resolve attachment.
        /// </summary>
        ColorAttachmentWrite = 1 << 8, 
        
        /// <summary>
        /// ename:VK_ACCESS_DEPTH_STENCIL_ATTACHMENT_READ_BIT indicates that
        /// the access is a read via a depth/stencil attachment.
        /// </summary>
        DepthStencilAttachmentRead = 1 << 9, 
        
        /// <summary>
        /// ename:VK_ACCESS_DEPTH_STENCIL_ATTACHMENT_WRITE_BIT indicates that
        /// the access is a write via a depth/stencil attachment.
        /// </summary>
        DepthStencilAttachmentWrite = 1 << 10, 
        
        /// <summary>
        /// ename:VK_ACCESS_TRANSFER_READ_BIT indicates that the access is a
        /// read from a transfer (copy, blit, resolve, etc.) operation. For the
        /// complete set of transfer operations, see
        /// &lt;&lt;synchronization-transfer,ename:VK_PIPELINE_STAGE_TRANSFER_BIT&gt;&gt;.
        /// </summary>
        TransferRead = 1 << 11, 
        
        /// <summary>
        /// ename:VK_ACCESS_TRANSFER_WRITE_BIT indicates that the access is a
        /// write from a transfer (copy, blit, resolve, etc.) operation. For
        /// the complete set of transfer operations, see
        /// &lt;&lt;synchronization-transfer,ename:VK_PIPELINE_STAGE_TRANSFER_BIT&gt;&gt;.
        /// </summary>
        TransferWrite = 1 << 12, 
        
        /// <summary>
        /// ename:VK_ACCESS_HOST_READ_BIT indicates that the access is a read
        /// via the host.
        /// </summary>
        HostRead = 1 << 13, 
        
        /// <summary>
        /// ename:VK_ACCESS_HOST_WRITE_BIT indicates that the access is a write
        /// via the host.
        /// </summary>
        HostWrite = 1 << 14, 
        
        /// <summary>
        /// ename:VK_ACCESS_MEMORY_READ_BIT indicates that the access is a read
        /// via a non-specific unit attached to the memory. This unit may: be
        /// external to the Vulkan device or otherwise not part of the core
        /// Vulkan pipeline. When included in pname:dstAccessMask, all writes
        /// using access types in pname:srcAccessMask performed by pipeline
        /// stages in pname:srcStageMask must: be visible in memory.
        /// </summary>
        MemoryRead = 1 << 15, 
        
        /// <summary>
        /// ename:VK_ACCESS_MEMORY_WRITE_BIT indicates that the access is a
        /// write via a non-specific unit attached to the memory. This unit
        /// may: be external to the Vulkan device or otherwise not part of the
        /// core Vulkan pipeline. When included in pname:srcAccessMask, all
        /// access types in pname:dstAccessMask from pipeline stages in
        /// pname:dstStageMask will observe the side effects of commands that
        /// executed before the barrier. When included in pname:dstAccessMask
        /// all writes using access types in pname:srcAccessMask performed by
        /// pipeline stages in pname:srcStageMask must: be visible in memory.
        /// </summary>
        MemoryWrite = 1 << 16, 
    }
    
    /// <summary>
    /// -
    /// </summary>
    [Flags]
    public enum AndroidSurfaceCreateFlags
    {
        /// <summary>
        /// -
        /// </summary>
        None = 0, 
    }
    
    /// <summary>
    /// Bitmask specifying additional properties of an attachment.
    /// </summary>
    [Flags]
    public enum AttachmentDescriptionFlags
    {
        /// <summary>
        /// -
        /// </summary>
        None = 0, 
        
        /// <summary>
        /// The attachment may alias physical memory of another attachment in
        /// the same render pass
        /// </summary>
        MayAlias = 1 << 0, 
    }
    
    /// <summary>
    /// <para>
    /// Bitmask specifying additional parameters of a buffer.
    /// </para>
    /// <para>
    /// See &lt;&lt;sparsememory-sparseresourcefeatures,Sparse Resource
    /// Features&gt;&gt; and &lt;&lt;features-features,Physical Device
    /// Features&gt;&gt; for details of the sparse memory features supported on
    /// a device.
    /// </para>
    /// <para>
    /// .Valid Usage **** * pname:size must: be greater than `0` * If
    /// pname:sharingMode is ename:VK_SHARING_MODE_CONCURRENT,
    /// pname:pQueueFamilyIndices must: be a pointer to an array of
    /// pname:queueFamilyIndexCount basetype:uint32_t values * If
    /// pname:sharingMode is ename:VK_SHARING_MODE_CONCURRENT,
    /// pname:queueFamilyIndexCount must: be greater than `1` * If the
    /// &lt;&lt;features-features-sparseBinding,sparse bindings&gt;&gt; feature
    /// is not enabled, pname:flags must: not contain
    /// ename:VK_BUFFER_CREATE_SPARSE_BINDING_BIT * If the
    /// &lt;&lt;features-features-sparseResidencyBuffer,sparse buffer
    /// residency&gt;&gt; feature is not enabled, pname:flags must: not contain
    /// ename:VK_BUFFER_CREATE_SPARSE_RESIDENCY_BIT * If the
    /// &lt;&lt;features-features-sparseResidencyAliased,sparse aliased
    /// residency&gt;&gt; feature is not enabled, pname:flags must: not contain
    /// ename:VK_BUFFER_CREATE_SPARSE_ALIASED_BIT * If pname:flags contains
    /// ename:VK_BUFFER_CREATE_SPARSE_RESIDENCY_BIT or
    /// ename:VK_BUFFER_CREATE_SPARSE_ALIASED_BIT, it must: also contain
    /// ename:VK_BUFFER_CREATE_SPARSE_BINDING_BIT ****
    /// </para>
    /// </summary>
    [Flags]
    public enum BufferCreateFlags
    {
        /// <summary>
        /// -
        /// </summary>
        None = 0, 
        
        /// <summary>
        /// ename:VK_BUFFER_CREATE_SPARSE_BINDING_BIT indicates that the buffer
        /// will be backed using sparse memory binding.
        /// </summary>
        SparseBinding = 1 << 0, 
        
        /// <summary>
        /// ename:VK_BUFFER_CREATE_SPARSE_RESIDENCY_BIT indicates that the
        /// buffer can: be partially backed using sparse memory binding.
        /// Buffers created with this flag must: also be created with the
        /// ename:VK_BUFFER_CREATE_SPARSE_BINDING_BIT flag.
        /// </summary>
        SparseResidency = 1 << 1, 
        
        /// <summary>
        /// ename:VK_BUFFER_CREATE_SPARSE_ALIASED_BIT indicates that the buffer
        /// will be backed using sparse memory binding with memory ranges that
        /// might also simultaneously be backing another buffer (or another
        /// portion of the same buffer). Buffers created with this flag must:
        /// also be created with the ename:VK_BUFFER_CREATE_SPARSE_BINDING_BIT
        /// flag.
        /// </summary>
        SparseAliased = 1 << 2, 
    }
    
    /// <summary>
    /// <para>
    /// Bitmask specifying allowed usage of a buffer.
    /// </para>
    /// <para>
    /// Any combination of bits can: be specified for pname:usage, but at least
    /// one of the bits must: be set in order to create a valid buffer.
    /// </para>
    /// <para>
    /// Bits which can: be set in pname:flags are:
    /// </para>
    /// </summary>
    [Flags]
    public enum BufferUsageFlags
    {
        /// <summary>
        /// -
        /// </summary>
        None = 0, 
        
        /// <summary>
        /// ename:VK_BUFFER_USAGE_TRANSFER_SRC_BIT indicates that the buffer
        /// can: be used as the source of a _transfer command_ (see the
        /// definition of
        /// &lt;&lt;synchronization-transfer,ename:VK_PIPELINE_STAGE_TRANSFER_BIT&gt;&gt;).
        /// </summary>
        TransferSource = 1 << 0, 
        
        /// <summary>
        /// ename:VK_BUFFER_USAGE_TRANSFER_DST_BIT indicates that the buffer
        /// can: be used as the destination of a transfer command.
        /// </summary>
        TransferDestination = 1 << 1, 
        
        /// <summary>
        /// ename:VK_BUFFER_USAGE_UNIFORM_TEXEL_BUFFER_BIT indicates that the
        /// buffer can: be used to create a sname:VkBufferView suitable for
        /// occupying a sname:VkDescriptorSet slot of type
        /// ename:VK_DESCRIPTOR_TYPE_UNIFORM_TEXEL_BUFFER.
        /// </summary>
        UniformTexelBuffer = 1 << 2, 
        
        /// <summary>
        /// ename:VK_BUFFER_USAGE_STORAGE_TEXEL_BUFFER_BIT indicates that the
        /// buffer can: be used to create a sname:VkBufferView suitable for
        /// occupying a sname:VkDescriptorSet slot of type
        /// ename:VK_DESCRIPTOR_TYPE_STORAGE_TEXEL_BUFFER.
        /// </summary>
        StorageTexelBuffer = 1 << 3, 
        
        /// <summary>
        /// ename:VK_BUFFER_USAGE_UNIFORM_BUFFER_BIT indicates that the buffer
        /// can: be used in a sname:VkDescriptorBufferInfo suitable for
        /// occupying a sname:VkDescriptorSet slot either of type
        /// ename:VK_DESCRIPTOR_TYPE_UNIFORM_BUFFER or
        /// ename:VK_DESCRIPTOR_TYPE_UNIFORM_BUFFER_DYNAMIC.
        /// </summary>
        UniformBuffer = 1 << 4, 
        
        /// <summary>
        /// ename:VK_BUFFER_USAGE_STORAGE_BUFFER_BIT indicates that the buffer
        /// can: be used in a sname:VkDescriptorBufferInfo suitable for
        /// occupying a sname:VkDescriptorSet slot either of type
        /// ename:VK_DESCRIPTOR_TYPE_STORAGE_BUFFER or
        /// ename:VK_DESCRIPTOR_TYPE_STORAGE_BUFFER_DYNAMIC.
        /// </summary>
        StorageBuffer = 1 << 5, 
        
        /// <summary>
        /// ename:VK_BUFFER_USAGE_INDEX_BUFFER_BIT indicates that the buffer is
        /// suitable for passing as the pname:buffer parameter to
        /// fname:vkCmdBindIndexBuffer.
        /// </summary>
        IndexBuffer = 1 << 6, 
        
        /// <summary>
        /// ename:VK_BUFFER_USAGE_VERTEX_BUFFER_BIT indicates that the buffer
        /// is suitable for passing as an element of the pname:pBuffers array
        /// to fname:vkCmdBindVertexBuffers.
        /// </summary>
        VertexBuffer = 1 << 7, 
        
        /// <summary>
        /// ename:VK_BUFFER_USAGE_INDIRECT_BUFFER_BIT indicates that the buffer
        /// is suitable for passing as the pname:buffer parameter to
        /// fname:vkCmdDrawIndirect, fname:vkCmdDrawIndexedIndirect, or
        /// fname:vkCmdDispatchIndirect.
        /// </summary>
        IndirectBuffer = 1 << 8, 
    }
    
    /// <summary>
    /// -
    /// </summary>
    [Flags]
    public enum BufferViewCreateFlags
    {
        /// <summary>
        /// -
        /// </summary>
        None = 0, 
    }
    
    /// <summary>
    /// <para>
    /// Bitmask controlling which components are written to the framebuffer.
    /// </para>
    /// <para>
    /// If ename:VK_COLOR_COMPONENT_R_BIT is set, then the [eq]#R# value is
    /// written to color attachment for the appropriate sample, otherwise the
    /// value in memory is unmodified. The ename:VK_COLOR_COMPONENT_G_BIT,
    /// ename:VK_COLOR_COMPONENT_B_BIT, and ename:VK_COLOR_COMPONENT_A_BIT bits
    /// similarly control writing of the [eq]#G, B,# and [eq]#A# values. The
    /// pname:colorWriteMask is applied regardless of whether blending is
    /// enabled.
    /// </para>
    /// </summary>
    [Flags]
    public enum ColorComponentFlags
    {
        /// <summary>
        /// -
        /// </summary>
        None = 0, 
        
        /// <summary>
        /// -
        /// </summary>
        R = 1 << 0, 
        
        /// <summary>
        /// -
        /// </summary>
        G = 1 << 1, 
        
        /// <summary>
        /// -
        /// </summary>
        B = 1 << 2, 
        
        /// <summary>
        /// -
        /// </summary>
        A = 1 << 3, 
    }
    
    /// <summary>
    /// <para>
    /// Bitmask controlling behavior of a command buffer reset.
    /// </para>
    /// <para>
    /// .Valid Usage **** * pname:commandBuffer must: not currently be pending
    /// execution * pname:commandBuffer must: have been allocated from a pool
    /// that was created with the
    /// ename:VK_COMMAND_POOL_CREATE_RESET_COMMAND_BUFFER_BIT ****
    /// </para>
    /// </summary>
    [Flags]
    public enum CommandBufferResetFlags
    {
        /// <summary>
        /// -
        /// </summary>
        None = 0, 
        
        /// <summary>
        /// Release resources owned by the buffer
        /// </summary>
        ReleaseResources = 1 << 0, 
    }
    
    /// <summary>
    /// <para>
    /// Bitmask specifying usage behavior for command buffer.
    /// </para>
    /// <para>
    /// .Valid Usage **** * If pname:flags contains
    /// ename:VK_COMMAND_BUFFER_USAGE_RENDER_PASS_CONTINUE_BIT, the
    /// pname:renderPass member of pname:pInheritanceInfo must: be a valid
    /// sname:VkRenderPass * If pname:flags contains
    /// ename:VK_COMMAND_BUFFER_USAGE_RENDER_PASS_CONTINUE_BIT, the
    /// pname:subpass member of pname:pInheritanceInfo must: be a valid subpass
    /// index within the pname:renderPass member of pname:pInheritanceInfo * If
    /// pname:flags contains
    /// ename:VK_COMMAND_BUFFER_USAGE_RENDER_PASS_CONTINUE_BIT, the
    /// pname:framebuffer member of pname:pInheritanceInfo must: be either
    /// dlink:VK_NULL_HANDLE, or a valid sname:VkFramebuffer that is compatible
    /// with the pname:renderPass member of pname:pInheritanceInfo ****
    /// </para>
    /// </summary>
    [Flags]
    public enum CommandBufferUsageFlags
    {
        /// <summary>
        /// -
        /// </summary>
        None = 0, 
        
        /// <summary>
        /// -
        /// </summary>
        OneTimeSubmit = 1 << 0, 
        
        /// <summary>
        /// -
        /// </summary>
        RenderPassContinue = 1 << 1, 
        
        /// <summary>
        /// Command buffer may be submitted/executed more than once
        /// simultaneously
        /// </summary>
        SimultaneousUse = 1 << 2, 
    }
    
    /// <summary>
    /// <para>
    /// Bitmask specifying usage behavior for a command pool.
    /// </para>
    /// <para>
    /// .Valid Usage **** * pname:queueFamilyIndex must: be the index of a
    /// queue family available in the calling command's pname:device parameter
    /// ****
    /// </para>
    /// </summary>
    [Flags]
    public enum CommandPoolCreateFlags
    {
        /// <summary>
        /// -
        /// </summary>
        None = 0, 
        
        /// <summary>
        /// Command buffers have a short lifetime
        /// </summary>
        Transient = 1 << 0, 
        
        /// <summary>
        /// Command buffers may release their memory individually
        /// </summary>
        ResetCommandBuffer = 1 << 1, 
    }
    
    /// <summary>
    /// <para>
    /// Bitmask controlling behavior of a command pool reset.
    /// </para>
    /// <para>
    /// Resetting a command pool recycles all of the resources from all of the
    /// command buffers allocated from the command pool back to the command
    /// pool. All command buffers that have been allocated from the command
    /// pool are put in the initial state.
    /// </para>
    /// <para>
    /// .Valid Usage **** * All sname:VkCommandBuffer objects allocated from
    /// pname:commandPool must: not currently be pending execution ****
    /// </para>
    /// </summary>
    [Flags]
    public enum CommandPoolResetFlags
    {
        /// <summary>
        /// -
        /// </summary>
        None = 0, 
        
        /// <summary>
        /// Release resources owned by the pool
        /// </summary>
        ReleaseResources = 1 << 0, 
    }
    
    /// <summary>
    /// Alpha compositing modes supported on a device.
    /// </summary>
    [Flags]
    public enum CompositeAlphaFlags
    {
        /// <summary>
        /// -
        /// </summary>
        None = 0, 
        
        /// <summary>
        /// ename:VK_COMPOSITE_ALPHA_OPAQUE_BIT_KHR: The alpha channel, if it
        /// exists, of the images is ignored in the compositing process.
        /// Instead, the image is treated as if it has a constant alpha of 1.0.
        /// </summary>
        Opaque = 1 << 0, 
        
        /// <summary>
        /// ename:VK_COMPOSITE_ALPHA_PRE_MULTIPLIED_BIT_KHR: The alpha channel,
        /// if it exists, of the images is respected in the compositing
        /// process. The non-alpha channels of the image are expected to
        /// already be multiplied by the alpha channel by the application.
        /// </summary>
        PreMultiplied = 1 << 1, 
        
        /// <summary>
        /// ename:VK_COMPOSITE_ALPHA_POST_MULTIPLIED_BIT_KHR: The alpha
        /// channel, if it exists, of the images is respected in the
        /// compositing process. The non-alpha channels of the image are not
        /// expected to already be multiplied by the alpha channel by the
        /// application; instead, the compositor will multiply the non-alpha
        /// channels of the image by the alpha channel during compositing.
        /// </summary>
        PostMultiplied = 1 << 2, 
        
        /// <summary>
        /// ename:VK_COMPOSITE_ALPHA_INHERIT_BIT_KHR: The way in which the
        /// presentation engine treats the alpha channel in the images is
        /// unknown to the Vulkan API. Instead, the application is responsible
        /// for setting the composite alpha blending mode using native window
        /// system commands. If the application does not set the blending mode
        /// using native window system commands, then a platform-specific
        /// default will be used.
        /// </summary>
        Inherit = 1 << 3, 
    }
    
    /// <summary>
    /// <para>
    /// Bitmask controlling triangle culling.
    /// </para>
    /// <para>
    /// If the pname:cullMode is set to ename:VK_CULL_MODE_NONE no triangles
    /// are discarded, if it is set to ename:VK_CULL_MODE_FRONT_BIT
    /// front-facing triangles are discarded, if it is set to
    /// ename:VK_CULL_MODE_BACK_BIT then back-facing triangles are discarded
    /// and if it is set to ename:VK_CULL_MODE_FRONT_AND_BACK then all
    /// triangles are discarded. Following culling, fragments are produced for
    /// any triangles which have not been discarded.
    /// </para>
    /// </summary>
    [Flags]
    public enum CullModeFlags
    {
        /// <summary>
        /// -
        /// </summary>
        None = 0, 
        
        /// <summary>
        /// -
        /// </summary>
        Front = 1 << 0, 
        
        /// <summary>
        /// -
        /// </summary>
        Back = 1 << 1, 
        
        /// <summary>
        /// -
        /// </summary>
        FrontAndBack = 0x00000003, 
    }
    
    /// <summary>
    /// <para>
    /// Bitmask specifying events which cause a debug report callback.
    /// </para>
    /// <para>
    /// * pname:pfnCallback is the application callback function to call. *
    /// pname:pUserData is user data to be passed to the callback. --
    /// </para>
    /// <para>
    /// For each sname:VkDebugReportCallbackEXT that is created the flags
    /// determine when that function is called. A callback will be made for
    /// issues that match any bit set in its flags. The callback will come
    /// directly from the component that detected the event, unless some other
    /// layer intercepts the calls for its own purposes (filter them in
    /// different way, log to system error log, etc.) An application may
    /// receive multiple callbacks if multiple sname:VkDebugReportCallbackEXT
    /// objects were created. A callback will always be executed in the same
    /// thread as the originating Vulkan call. A callback may be called from
    /// multiple threads simultaneously (if the application is making Vulkan
    /// calls from multiple threads).
    /// </para>
    /// </summary>
    [Flags]
    public enum DebugReportFlags
    {
        /// <summary>
        /// -
        /// </summary>
        None = 0, 
        
        /// <summary>
        /// ename:VK_DEBUG_REPORT_INFORMATION_BIT_EXT indicates an
        /// informational message such as resource details that may be handy
        /// when debugging an application.
        /// </summary>
        Information = 1 << 0, 
        
        /// <summary>
        /// ename:VK_DEBUG_REPORT_WARNING_BIT_EXT indicates an unexpected use.
        /// E.g. Not destroying objects prior to destroying the containing
        /// object or potential inconsistencies between descriptor set layout
        /// and the layout in the corresponding shader, etc.
        /// </summary>
        Warning = 1 << 1, 
        
        /// <summary>
        /// ename:VK_DEBUG_REPORT_PERFORMANCE_WARNING_BIT_EXT indicates a
        /// potentially non-optimal use of Vulkan. E.g. using
        /// flink:vkCmdClearColorImage when a RenderPass load_op would have
        /// worked.
        /// </summary>
        PerformanceWarning = 1 << 2, 
        
        /// <summary>
        /// ename:VK_DEBUG_REPORT_ERROR_BIT_EXT indicates an error that may
        /// cause undefined results, including an application crash.
        /// </summary>
        Error = 1 << 3, 
        
        /// <summary>
        /// ename:VK_DEBUG_REPORT_DEBUG_BIT_EXT indicates diagnostic
        /// information from the loader and layers.
        /// </summary>
        Debug = 1 << 4, 
    }
    
    /// <summary>
    /// <para>
    /// Bitmask specifying dependencies between subpasses.
    /// </para>
    /// <para>
    /// Each subpass dependency defines an execution and memory dependency
    /// between two sets of commands, with the second set depending on the
    /// first set. When pname:srcSubpass does not equal pname:dstSubpass then
    /// the first set of commands is:
    /// </para>
    /// <para>
    /// * All commands in the subpass indicated by pname:srcSubpass, if
    /// pname:srcSubpass is not ename:VK_SUBPASS_EXTERNAL. * All commands
    /// before the render pass instance, if pname:srcSubpass is
    /// ename:VK_SUBPASS_EXTERNAL.
    /// </para>
    /// <para>
    /// While the corresponding second set of commands is:
    /// </para>
    /// <para>
    /// * All commands in the subpass indicated by pname:dstSubpass, if
    /// pname:dstSubpass is not ename:VK_SUBPASS_EXTERNAL. * All commands after
    /// the render pass instance, if pname:dstSubpass is
    /// ename:VK_SUBPASS_EXTERNAL.
    /// </para>
    /// <para>
    /// When pname:srcSubpass equals pname:dstSubpass then the first set
    /// consists of commands in the subpass before a call to
    /// flink:vkCmdPipelineBarrier and the second set consists of commands in
    /// the subpass following that same call as described in the
    /// &lt;&lt;synchronization-pipeline-barriers-subpass-self-dependencies, Subpass
    /// Self-dependency&gt;&gt; section.
    /// </para>
    /// <para>
    /// The pname:srcStageMask, pname:dstStageMask, pname:srcAccessMask,
    /// pname:dstAccessMask, and pname:dependencyFlags parameters of the
    /// dependency are interpreted the same way as for other dependencies, as
    /// described in &lt;&lt;synchronization, Synchronization and Cache
    /// Control&gt;&gt;.
    /// </para>
    /// <para>
    /// .Valid Usage **** * If the
    /// &lt;&lt;features-features-geometryShader,geometry shaders&gt;&gt;
    /// feature is not enabled, pname:srcStageMask must: not contain
    /// ename:VK_PIPELINE_STAGE_GEOMETRY_SHADER_BIT * If the
    /// &lt;&lt;features-features-geometryShader,geometry shaders&gt;&gt;
    /// feature is not enabled, pname:dstStageMask must: not contain
    /// ename:VK_PIPELINE_STAGE_GEOMETRY_SHADER_BIT * If the
    /// &lt;&lt;features-features-tessellationShader,tessellation shaders&gt;&gt;
    /// feature is not enabled, pname:srcStageMask must: not contain
    /// ename:VK_PIPELINE_STAGE_TESSELLATION_CONTROL_SHADER_BIT or
    /// ename:VK_PIPELINE_STAGE_TESSELLATION_EVALUATION_SHADER_BIT * If the
    /// &lt;&lt;features-features-tessellationShader,tessellation shaders&gt;&gt;
    /// feature is not enabled, pname:dstStageMask must: not contain
    /// ename:VK_PIPELINE_STAGE_TESSELLATION_CONTROL_SHADER_BIT or
    /// ename:VK_PIPELINE_STAGE_TESSELLATION_EVALUATION_SHADER_BIT *
    /// pname:srcSubpass must: be less than or equal to pname:dstSubpass,
    /// unless one of them is ename:VK_SUBPASS_EXTERNAL, to avoid cyclic
    /// dependencies and ensure a valid execution order * pname:srcSubpass and
    /// pname:dstSubpass must: not both be equal to ename:VK_SUBPASS_EXTERNAL *
    /// If pname:srcSubpass is equal to pname:dstSubpass, pname:srcStageMask
    /// and pname:dstStageMask must: only contain one of
    /// ename:VK_PIPELINE_STAGE_TOP_OF_PIPE_BIT, ename:VK_PIPELINE_STAGE_DRAW_INDIRECT_BIT,
    /// ename:VK_PIPELINE_STAGE_VERTEX_INPUT_BIT,
    /// ename:VK_PIPELINE_STAGE_VERTEX_SHADER_BIT, ename:VK_PIPELINE_STAGE_TESSELLATION_CONTROL_SHADER_BIT,
    /// ename:VK_PIPELINE_STAGE_TESSELLATION_EVALUATION_SHADER_BIT,
    /// ename:VK_PIPELINE_STAGE_GEOMETRY_SHADER_BIT, ename:VK_PIPELINE_STAGE_FRAGMENT_SHADER_BIT,
    /// ename:VK_PIPELINE_STAGE_EARLY_FRAGMENT_TESTS_BIT,
    /// ename:VK_PIPELINE_STAGE_LATE_FRAGMENT_TESTS_BIT, ename:VK_PIPELINE_STAGE_COLOR_ATTACHMENT_OUTPUT_BIT,
    /// ename:VK_PIPELINE_STAGE_BOTTOM_OF_PIPE_BIT, or
    /// ename:VK_PIPELINE_STAGE_ALL_GRAPHICS_BIT * If pname:srcSubpass is equal
    /// to pname:dstSubpass, the highest bit value included in
    /// pname:srcStageMask must: be less than or equal to the lowest bit value
    /// in pname:dstStageMask ****
    /// </para>
    /// </summary>
    [Flags]
    public enum DependencyFlags
    {
        /// <summary>
        /// -
        /// </summary>
        None = 0, 
        
        /// <summary>
        /// Dependency is per pixel region 
        /// </summary>
        ByRegion = 1 << 0, 
    }
    
    /// <summary>
    /// <para>
    /// Bitmask specifying certain supported operations on a descriptor pool.
    /// </para>
    /// <para>
    /// If multiple sname:VkDescriptorPoolSize structures appear in the
    /// pname:pPoolSizes array then the pool will be created with enough
    /// storage for the total number of descriptors of each type.
    /// </para>
    /// <para>
    /// Fragmentation of a descriptor pool is possible and may: lead to
    /// descriptor set allocation failures. A failure due to fragmentation is
    /// defined as failing a descriptor set allocation despite the sum of all
    /// outstanding descriptor set allocations from the pool plus the requested
    /// allocation requiring no more than the total number of descriptors
    /// requested at pool creation. Implementations provide certain guarantees
    /// of when fragmentation must: not cause allocation failure, as described
    /// below.
    /// </para>
    /// <para>
    /// If a descriptor pool has not had any descriptor sets freed since it was
    /// created or most recently reset then fragmentation must: not cause an
    /// allocation failure (note that this is always the case for a pool
    /// created without the
    /// ename:VK_DESCRIPTOR_POOL_CREATE_FREE_DESCRIPTOR_SET_BIT bit set).
    /// Additionally, if all sets allocated from the pool since it was created
    /// or most recently reset use the same number of descriptors (of each
    /// type) and the requested allocation also uses that same number of
    /// descriptors (of each type), then fragmentation must: not cause an
    /// allocation failure.
    /// </para>
    /// <para>
    /// If an allocation failure occurs due to fragmentation, an application
    /// can: create an additional descriptor pool to perform further descriptor
    /// set allocations.
    /// </para>
    /// <para>
    /// .Valid Usage **** * pname:maxSets must: be greater than `0` ****
    /// </para>
    /// </summary>
    [Flags]
    public enum DescriptorPoolCreateFlags
    {
        /// <summary>
        /// -
        /// </summary>
        None = 0, 
        
        /// <summary>
        /// Descriptor sets may be freed individually
        /// </summary>
        FreeDescriptorSet = 1 << 0, 
    }
    
    /// <summary>
    /// -
    /// </summary>
    [Flags]
    public enum DescriptorPoolResetFlags
    {
        /// <summary>
        /// -
        /// </summary>
        None = 0, 
    }
    
    /// <summary>
    /// -
    /// </summary>
    [Flags]
    public enum DescriptorSetLayoutCreateFlags
    {
        /// <summary>
        /// -
        /// </summary>
        None = 0, 
    }
    
    /// <summary>
    /// -
    /// </summary>
    [Flags]
    public enum DeviceCreateFlags
    {
        /// <summary>
        /// -
        /// </summary>
        None = 0, 
    }
    
    /// <summary>
    /// -
    /// </summary>
    [Flags]
    public enum DeviceQueueCreateFlags
    {
        /// <summary>
        /// -
        /// </summary>
        None = 0, 
    }
    
    /// <summary>
    /// -
    /// </summary>
    [Flags]
    public enum DisplayModeCreateFlags
    {
        /// <summary>
        /// -
        /// </summary>
        None = 0, 
    }
    
    /// <summary>
    /// Alpha blending type.
    /// </summary>
    [Flags]
    public enum DisplayPlaneAlphaFlags
    {
        /// <summary>
        /// -
        /// </summary>
        None = 0, 
        
        /// <summary>
        /// ename:VK_DISPLAY_PLANE_ALPHA_OPAQUE_BIT_KHR: The source image will
        /// be treated as opaque.
        /// </summary>
        Opaque = 1 << 0, 
        
        /// <summary>
        /// ename:VK_DISPLAY_PLANE_ALPHA_GLOBAL_BIT_KHR: A global alpha value
        /// must: be specified that will be applied to all pixels in the source
        /// image.
        /// </summary>
        Global = 1 << 1, 
        
        /// <summary>
        /// ename:VK_DISPLAY_PLANE_ALPHA_PER_PIXEL_BIT_KHR: The alpha value
        /// will be determined by the alpha channel of the source image's
        /// pixels. If the source format contains no alpha values, no blending
        /// will be applied. The source alpha values are not premultiplied into
        /// the source image's other color channels.
        /// </summary>
        PerPixel = 1 << 2, 
        
        /// <summary>
        /// ename:VK_DISPLAY_PLANE_ALPHA_PER_PIXEL_PREMULTIPLIED_BIT_KHR: This
        /// is equivalent to ename:VK_DISPLAY_PLANE_ALPHA_PER_PIXEL_BIT_KHR
        /// except the source alpha values are assumed to be premultiplied into
        /// the source image's other color channels.
        /// </summary>
        PerPixelPremultiplied = 1 << 3, 
    }
    
    /// <summary>
    /// -
    /// </summary>
    [Flags]
    public enum DisplaySurfaceCreateFlags
    {
        /// <summary>
        /// -
        /// </summary>
        None = 0, 
    }
    
    /// <summary>
    /// -
    /// </summary>
    [Flags]
    public enum EventCreateFlags
    {
        /// <summary>
        /// -
        /// </summary>
        None = 0, 
    }
    
    /// <summary>
    /// Bitmask specifying external memory features.
    /// </summary>
    [Flags]
    public enum ExternalMemoryFeatureFlags
    {
        /// <summary>
        /// -
        /// </summary>
        None = 0, 
        
        /// <summary>
        /// ename:VK_EXTERNAL_MEMORY_FEATURE_DEDICATED_ONLY_BIT_NV: External
        /// memory of the specified type must: be created as a dedicated
        /// allocation when used in the manner specified.
        /// </summary>
        DedicatedOnly = 1 << 0, 
        
        /// <summary>
        /// ename:VK_EXTERNAL_MEMORY_FEATURE_EXPORTABLE_BIT_NV: The
        /// implementation supports exporting handles of the specified type.
        /// </summary>
        Exportable = 1 << 1, 
        
        /// <summary>
        /// ename:VK_EXTERNAL_MEMORY_FEATURE_IMPORTABLE_BIT_NV: The
        /// implementation supports importing handles of the specified type.
        /// </summary>
        Importable = 1 << 2, 
    }
    
    /// <summary>
    /// Bitmask specifying memory handle types.
    /// </summary>
    [Flags]
    public enum ExternalMemoryHandleTypeFlags
    {
        /// <summary>
        /// -
        /// </summary>
        None = 0, 
        
        /// <summary>
        /// -
        /// </summary>
        OpaqueWin32 = 1 << 0, 
        
        /// <summary>
        /// -
        /// </summary>
        OpaqueWin32Kmt = 1 << 1, 
        
        /// <summary>
        /// -
        /// </summary>
        D3D11Image = 1 << 2, 
        
        /// <summary>
        /// -
        /// </summary>
        D3D11ImageKmt = 1 << 3, 
    }
    
    /// <summary>
    /// Bitmask specifying initial state and behavior of a fence.
    /// </summary>
    [Flags]
    public enum FenceCreateFlags
    {
        /// <summary>
        /// -
        /// </summary>
        None = 0, 
        
        /// <summary>
        /// -
        /// </summary>
        Signaled = 1 << 0, 
    }
    
    /// <summary>
    /// <para>
    /// Bitmask specifying features supported by a buffer.
    /// </para>
    /// <para>
    /// The pname:linearTilingFeatures and pname:optimalTilingFeatures members
    /// of the sname:VkFormatProperties structure describe what features are
    /// supported by ename:VK_IMAGE_TILING_LINEAR and
    /// ename:VK_IMAGE_TILING_OPTIMAL images, respectively.
    /// </para>
    /// <para>
    /// The following bits may: be set in pname:linearTilingFeatures and
    /// pname:optimalTilingFeatures, indicating they are supported by images or
    /// image views created with the queried
    /// flink:vkGetPhysicalDeviceFormatProperties::pname:format:
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_FEATURE_SAMPLED_IMAGE_BIT:: sname:VkImageView can: be
    /// sampled from. See &lt;&lt;descriptorsets-sampledimage, sampled
    /// images&gt;&gt; section.
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_FEATURE_STORAGE_IMAGE_BIT:: sname:VkImageView can: be
    /// used as storage image. See &lt;&lt;descriptorsets-storageimage, storage
    /// images&gt;&gt; section.
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_FEATURE_STORAGE_IMAGE_ATOMIC_BIT:: sname:VkImageView
    /// can: be used as storage image that supports atomic operations.
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_FEATURE_COLOR_ATTACHMENT_BIT:: sname:VkImageView can:
    /// be used as a framebuffer color attachment and as an input attachment.
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_FEATURE_COLOR_ATTACHMENT_BLEND_BIT:: sname:VkImageView
    /// can: be used as a framebuffer color attachment that supports blending
    /// and as an input attachment.
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_FEATURE_DEPTH_STENCIL_ATTACHMENT_BIT::
    /// sname:VkImageView can: be used as a framebuffer depth/stencil
    /// attachment and as an input attachment.
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_FEATURE_BLIT_SRC_BIT:: sname:VkImage can: be used as
    /// pname:srcImage for the fname:vkCmdBlitImage command.
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_FEATURE_BLIT_DST_BIT:: sname:VkImage can: be used as
    /// pname:dstImage for the fname:vkCmdBlitImage command.
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_FEATURE_SAMPLED_IMAGE_FILTER_LINEAR_BIT:: If
    /// ename:VK_FORMAT_FEATURE_SAMPLED_IMAGE_BIT is also set,
    /// sname:VkImageView can: be used with a sampler that has either of
    /// pname:magFilter or pname:minFilter set to ename:VK_FILTER_LINEAR, or
    /// pname:mipmapMode set to ename:VK_SAMPLER_MIPMAP_MODE_LINEAR. If
    /// ename:VK_FORMAT_FEATURE_BLIT_SRC_BIT is also set, sname:VkImage can be
    /// used as the pname:srcImage to flink:vkCmdBlitImage with a pname:filter
    /// of ename:VK_FILTER_LINEAR. This bit must: only be exposed for formats
    /// that also support the ename:VK_FORMAT_FEATURE_SAMPLED_IMAGE_BIT or
    /// ename:VK_FORMAT_FEATURE_BLIT_SRC_BIT. + If the format being queried is
    /// a depth/stencil format, this bit only indicates that the depth aspect
    /// (not the stencil aspect) of an image of this format supports linear
    /// filtering, and that linear filtering of the depth aspect is supported
    /// whether depth compare is enabled in the sampler or not. If this bit is
    /// not present, linear filtering with depth compare disabled is
    /// unsupported and linear filtering with depth compare enabled is
    /// supported, but may: compute the filtered value in an
    /// implementation-dependent manner which differs from the normal rules of
    /// linear filtering. The resulting value must: be in the range [eq]#[0,1]#
    /// and should: be proportional to, or a weighted average of, the number of
    /// comparison passes or failures.
    /// </para>
    /// <para>
    /// ifdef::VK_IMG_filter_cubic[]
    /// include::VK_IMG_filter_cubic/filter_cubic_sampled_bit_description.txt[] endif::VK_IMG_filter_cubic[]
    /// </para>
    /// <para>
    /// The following features may: appear in pname:bufferFeatures, indicating
    /// they are supported by buffers or buffer views created with the queried
    /// flink:vkGetPhysicalDeviceFormatProperties::pname:format:
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_FEATURE_UNIFORM_TEXEL_BUFFER_BIT:: Format can: be used
    /// to create a sname:VkBufferView that can: be bound to a
    /// ename:VK_DESCRIPTOR_TYPE_UNIFORM_TEXEL_BUFFER descriptor.
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_FEATURE_STORAGE_TEXEL_BUFFER_BIT:: Format can: be used
    /// to create a sname:VkBufferView that can: be bound to a
    /// ename:VK_DESCRIPTOR_TYPE_STORAGE_TEXEL_BUFFER descriptor.
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_FEATURE_STORAGE_TEXEL_BUFFER_ATOMIC_BIT:: Atomic
    /// operations are supported on
    /// ename:VK_DESCRIPTOR_TYPE_STORAGE_TEXEL_BUFFER with this format.
    /// </para>
    /// <para>
    /// ename:VK_FORMAT_FEATURE_VERTEX_BUFFER_BIT:: Format can: be used as a
    /// vertex attribute format
    /// (sname:VkVertexInputAttributeDescription::pname:format).
    /// </para>
    /// <para>
    /// [NOTE] .Note ==== If no format feature flags are supported, then the
    /// only possible use would be image transfers - which alone are not
    /// useful. As such, if no format feature flags are supported, the format
    /// itself is not supported, and images of that format cannot be created.
    /// ====
    /// </para>
    /// <para>
    /// If pname:format is a block-compression format, then buffers must: not
    /// support any features for the format.
    /// </para>
    /// </summary>
    [Flags]
    public enum FormatFeatureFlags
    {
        /// <summary>
        /// -
        /// </summary>
        None = 0, 
        
        /// <summary>
        /// Format can be used for sampled images (SAMPLED_IMAGE and
        /// COMBINED_IMAGE_SAMPLER descriptor types)
        /// </summary>
        SampledImage = 1 << 0, 
        
        /// <summary>
        /// Format can be used for storage images (STORAGE_IMAGE descriptor
        /// type)
        /// </summary>
        StorageImage = 1 << 1, 
        
        /// <summary>
        /// Format supports atomic operations in case it is used for storage
        /// images
        /// </summary>
        StorageImageAtomic = 1 << 2, 
        
        /// <summary>
        /// Format can be used for uniform texel buffers (TBOs)
        /// </summary>
        UniformTexelBuffer = 1 << 3, 
        
        /// <summary>
        /// Format can be used for storage texel buffers (IBOs)
        /// </summary>
        StorageTexelBuffer = 1 << 4, 
        
        /// <summary>
        /// Format supports atomic operations in case it is used for storage
        /// texel buffers
        /// </summary>
        StorageTexelBufferAtomic = 1 << 5, 
        
        /// <summary>
        /// Format can be used for vertex buffers (VBOs)
        /// </summary>
        VertexBuffer = 1 << 6, 
        
        /// <summary>
        /// Format can be used for color attachment images
        /// </summary>
        ColorAttachment = 1 << 7, 
        
        /// <summary>
        /// Format supports blending in case it is used for color attachment
        /// images
        /// </summary>
        ColorAttachmentBlend = 1 << 8, 
        
        /// <summary>
        /// Format can be used for depth/stencil attachment images
        /// </summary>
        DepthStencilAttachment = 1 << 9, 
        
        /// <summary>
        /// Format can be used as the source image of blits with vkCmdBlitImage
        /// </summary>
        BlitSource = 1 << 10, 
        
        /// <summary>
        /// Format can be used as the destination image of blits with
        /// vkCmdBlitImage
        /// </summary>
        BlitDestination = 1 << 11, 
        
        /// <summary>
        /// Format can be filtered with VK_FILTER_LINEAR when being sampled
        /// </summary>
        SampledImageFilterLinear = 1 << 12, 
        
        /// <summary>
        /// -
        /// </summary>
        SampledImageFilterCubicBitImg = 13, 
    }
    
    /// <summary>
    /// -
    /// </summary>
    [Flags]
    public enum FramebufferCreateFlags
    {
        /// <summary>
        /// -
        /// </summary>
        None = 0, 
    }
    
    /// <summary>
    /// <para>
    /// Bitmask specifying which aspects of an image are included in a view.
    /// </para>
    /// <para>
    /// The mask must: be only ename:VK_IMAGE_ASPECT_COLOR_BIT,
    /// ename:VK_IMAGE_ASPECT_DEPTH_BIT or ename:VK_IMAGE_ASPECT_STENCIL_BIT if
    /// pname:format is a color, depth-only or stencil-only format,
    /// respectively. If using a depth/stencil format with both depth and
    /// stencil components, pname:aspectMask must: include at least one of
    /// ename:VK_IMAGE_ASPECT_DEPTH_BIT and ename:VK_IMAGE_ASPECT_STENCIL_BIT,
    /// and can: include both.
    /// </para>
    /// <para>
    /// When using an imageView of a depth/stencil image to populate a
    /// descriptor set (e.g. for sampling in the shader, or for use as an input
    /// attachment), the pname:aspectMask must: only include one bit and
    /// selects whether the imageView is used for depth reads (i.e. using a
    /// floating-point sampler or input attachment in the shader) or stencil
    /// reads (i.e. using an unsigned integer sampler or input attachment in
    /// the shader). When an imageView of a depth/stencil image is used as a
    /// depth/stencil framebuffer attachment, the pname:aspectMask is ignored
    /// and both depth and stencil image subresources are used.
    /// </para>
    /// <para>
    /// The pname:components member is of type slink:VkComponentMapping, and
    /// describes a remapping from components of the image to components of the
    /// vector returned by shader image instructions. This remapping must: be
    /// identity for storage image descriptors, input attachment descriptors,
    /// and framebuffer attachments.
    /// </para>
    /// <para>
    /// .Valid Usage **** * If pname:levelCount is not
    /// ename:VK_REMAINING_MIP_LEVELS, [eq]#(pname:baseMipLevel +
    /// pname:levelCount)# must: be less than or equal to the pname:mipLevels
    /// specified in slink:VkImageCreateInfo when the image was created * If
    /// pname:layerCount is not ename:VK_REMAINING_ARRAY_LAYERS,
    /// [eq]#(pname:baseArrayLayer + pname:layerCount)# must: be less than or
    /// equal to the pname:arrayLayers specified in slink:VkImageCreateInfo
    /// when the image was created ****
    /// </para>
    /// </summary>
    [Flags]
    public enum ImageAspectFlags
    {
        /// <summary>
        /// -
        /// </summary>
        None = 0, 
        
        /// <summary>
        /// -
        /// </summary>
        Color = 1 << 0, 
        
        /// <summary>
        /// -
        /// </summary>
        Depth = 1 << 1, 
        
        /// <summary>
        /// -
        /// </summary>
        Stencil = 1 << 2, 
        
        /// <summary>
        /// -
        /// </summary>
        Metadata = 1 << 3, 
    }
    
    /// <summary>
    /// <para>
    /// Bitmask specifying additional parameters of an image.
    /// </para>
    /// <para>
    /// If any of the bits ename:VK_IMAGE_CREATE_SPARSE_BINDING_BIT,
    /// ename:VK_IMAGE_CREATE_SPARSE_RESIDENCY_BIT, or
    /// ename:VK_IMAGE_CREATE_SPARSE_ALIASED_BIT are set,
    /// ename:VK_IMAGE_USAGE_TRANSIENT_ATTACHMENT_BIT must: not also be set.
    /// </para>
    /// <para>
    /// See &lt;&lt;sparsememory-sparseresourcefeatures,Sparse Resource
    /// Features&gt;&gt; and &lt;&lt;sparsememory-physicalfeatures,Sparse
    /// Physical Device Features&gt;&gt; for more details.
    /// </para>
    /// </summary>
    [Flags]
    public enum ImageCreateFlags
    {
        /// <summary>
        /// -
        /// </summary>
        None = 0, 
        
        /// <summary>
        /// ename:VK_IMAGE_CREATE_SPARSE_BINDING_BIT indicates that the image
        /// will be backed using sparse memory binding.
        /// </summary>
        SparseBinding = 1 << 0, 
        
        /// <summary>
        /// ename:VK_IMAGE_CREATE_SPARSE_RESIDENCY_BIT indicates that the image
        /// can: be partially backed using sparse memory binding. Images
        /// created with this flag must: also be created with the
        /// ename:VK_IMAGE_CREATE_SPARSE_BINDING_BIT flag.
        /// </summary>
        SparseResidency = 1 << 1, 
        
        /// <summary>
        /// ename:VK_IMAGE_CREATE_SPARSE_ALIASED_BIT indicates that the image
        /// will be backed using sparse memory binding with memory ranges that
        /// might also simultaneously be backing another image (or another
        /// portion of the same image). Images created with this flag must:
        /// also be created with the ename:VK_IMAGE_CREATE_SPARSE_BINDING_BIT
        /// flag
        /// </summary>
        SparseAliased = 1 << 2, 
        
        /// <summary>
        /// ename:VK_IMAGE_CREATE_MUTABLE_FORMAT_BIT indicates that the image
        /// can: be used to create a sname:VkImageView with a different format
        /// from the image.
        /// </summary>
        MutableFormat = 1 << 3, 
        
        /// <summary>
        /// ename:VK_IMAGE_CREATE_CUBE_COMPATIBLE_BIT indicates that the image
        /// can: be used to create a sname:VkImageView of type
        /// ename:VK_IMAGE_VIEW_TYPE_CUBE or
        /// ename:VK_IMAGE_VIEW_TYPE_CUBE_ARRAY.
        /// </summary>
        CubeCompatible = 1 << 4, 
    }
    
    /// <summary>
    /// Bitmask specifying intended usage of an image.
    /// </summary>
    [Flags]
    public enum ImageUsageFlags
    {
        /// <summary>
        /// -
        /// </summary>
        None = 0, 
        
        /// <summary>
        /// ename:VK_IMAGE_USAGE_TRANSFER_SRC_BIT indicates that the image can:
        /// be used as the source of a transfer command.
        /// </summary>
        TransferSource = 1 << 0, 
        
        /// <summary>
        /// ename:VK_IMAGE_USAGE_TRANSFER_DST_BIT indicates that the image can:
        /// be used as the destination of a transfer command.
        /// </summary>
        TransferDestination = 1 << 1, 
        
        /// <summary>
        /// ename:VK_IMAGE_USAGE_SAMPLED_BIT indicates that the image can: be
        /// used to create a sname:VkImageView suitable for occupying a
        /// sname:VkDescriptorSet slot either of type
        /// ename:VK_DESCRIPTOR_TYPE_SAMPLED_IMAGE or
        /// ename:VK_DESCRIPTOR_TYPE_COMBINED_IMAGE_SAMPLER, and be sampled by
        /// a shader.
        /// </summary>
        Sampled = 1 << 2, 
        
        /// <summary>
        /// ename:VK_IMAGE_USAGE_STORAGE_BIT indicates that the image can: be
        /// used to create a sname:VkImageView suitable for occupying a
        /// sname:VkDescriptorSet slot of type
        /// ename:VK_DESCRIPTOR_TYPE_STORAGE_IMAGE.
        /// </summary>
        Storage = 1 << 3, 
        
        /// <summary>
        /// ename:VK_IMAGE_USAGE_COLOR_ATTACHMENT_BIT indicates that the image
        /// can: be used to create a sname:VkImageView suitable for use as a
        /// color or resolve attachment in a sname:VkFramebuffer.
        /// </summary>
        ColorAttachment = 1 << 4, 
        
        /// <summary>
        /// ename:VK_IMAGE_USAGE_DEPTH_STENCIL_ATTACHMENT_BIT indicates that
        /// the image can: be used to create a sname:VkImageView suitable for
        /// use as a depth/stencil attachment in a sname:VkFramebuffer.
        /// </summary>
        DepthStencilAttachment = 1 << 5, 
        
        /// <summary>
        /// ename:VK_IMAGE_USAGE_TRANSIENT_ATTACHMENT_BIT indicates that the
        /// memory bound to this image will have been allocated with the
        /// ename:VK_MEMORY_PROPERTY_LAZILY_ALLOCATED_BIT (see
        /// &lt;&lt;memory&gt;&gt; for more detail). This bit can: be set for
        /// any image that can: be used to create a sname:VkImageView suitable
        /// for use as a color, resolve, depth/stencil, or input attachment.
        /// </summary>
        TransientAttachment = 1 << 6, 
        
        /// <summary>
        /// ename:VK_IMAGE_USAGE_INPUT_ATTACHMENT_BIT indicates that the image
        /// can: be used to create a sname:VkImageView suitable for occupying
        /// sname:VkDescriptorSet slot of type
        /// ename:VK_DESCRIPTOR_TYPE_INPUT_ATTACHMENT; be read from a shader as
        /// an input attachment; and be used as an input attachment in a
        /// framebuffer.
        /// </summary>
        InputAttachment = 1 << 7, 
    }
    
    /// <summary>
    /// -
    /// </summary>
    [Flags]
    public enum ImageViewCreateFlags
    {
        /// <summary>
        /// -
        /// </summary>
        None = 0, 
    }
    
    /// <summary>
    /// -
    /// </summary>
    [Flags]
    public enum InstanceCreateFlags
    {
        /// <summary>
        /// -
        /// </summary>
        None = 0, 
    }
    
    /// <summary>
    /// Bitmask specifying attribute flags for a heap.
    /// </summary>
    [Flags]
    public enum MemoryHeapFlags
    {
        /// <summary>
        /// -
        /// </summary>
        None = 0, 
        
        /// <summary>
        /// If set, heap represents device memory
        /// </summary>
        DeviceLocal = 1 << 0, 
    }
    
    /// <summary>
    /// -
    /// </summary>
    [Flags]
    public enum MemoryMapFlags
    {
        /// <summary>
        /// -
        /// </summary>
        None = 0, 
    }
    
    /// <summary>
    /// Bitmask specifying properties for a memory type.
    /// </summary>
    [Flags]
    public enum MemoryPropertyFlags
    {
        /// <summary>
        /// -
        /// </summary>
        None = 0, 
        
        /// <summary>
        /// If otherwise stated, then allocate memory on device
        /// </summary>
        DeviceLocal = 1 << 0, 
        
        /// <summary>
        /// Memory is mappable by host
        /// </summary>
        HostVisible = 1 << 1, 
        
        /// <summary>
        /// Memory will have i/o coherency. If not set, application may need to
        /// use vkFlushMappedMemoryRanges and vkInvalidateMappedMemoryRanges to
        /// flush/invalidate host cache
        /// </summary>
        HostCoherent = 1 << 2, 
        
        /// <summary>
        /// Memory will be cached by the host
        /// </summary>
        HostCached = 1 << 3, 
        
        /// <summary>
        /// Memory may be allocated by the driver when it is required
        /// </summary>
        LazilyAllocated = 1 << 4, 
    }
    
    /// <summary>
    /// -
    /// </summary>
    [Flags]
    public enum MirSurfaceCreateFlags
    {
        /// <summary>
        /// -
        /// </summary>
        None = 0, 
    }
    
    /// <summary>
    /// -
    /// </summary>
    [Flags]
    public enum PipelineCacheCreateFlags
    {
        /// <summary>
        /// -
        /// </summary>
        None = 0, 
    }
    
    /// <summary>
    /// -
    /// </summary>
    [Flags]
    public enum PipelineColorBlendStateCreateFlags
    {
        /// <summary>
        /// -
        /// </summary>
        None = 0, 
    }
    
    /// <summary>
    /// <para>
    /// Bitmask controlling how a pipeline is generated.
    /// </para>
    /// <para>
    /// It is valid to set both ename:VK_PIPELINE_CREATE_ALLOW_DERIVATIVES_BIT
    /// and ename:VK_PIPELINE_CREATE_DERIVATIVE_BIT. This allows a pipeline to
    /// be both a parent and possibly a child in a pipeline hierarchy. See
    /// &lt;&lt;pipelines-pipeline-derivatives,Pipeline Derivatives&gt;&gt; for
    /// more information.
    /// </para>
    /// <para>
    /// pname:pDynamicState points to a structure of type
    /// sname:VkPipelineDynamicStateCreateInfo.
    /// </para>
    /// <para>
    /// ifdef::VK_NV_glsl_shader[] If any shader stage fails to compile,
    /// ifdef::VK_EXT_debug_report[] the compile log will be reported back to
    /// the application, and endif::VK_EXT_debug_report[]
    /// ename:VK_ERROR_INVALID_SHADER_NV will be generated.
    /// endif::VK_NV_glsl_shader[]
    /// </para>
    /// <para>
    /// .Valid Usage **** * If pname:flags contains the
    /// ename:VK_PIPELINE_CREATE_DERIVATIVE_BIT flag, and
    /// pname:basePipelineIndex is not `-1`, pname:basePipelineHandle must: be
    /// dlink:VK_NULL_HANDLE * If pname:flags contains the
    /// ename:VK_PIPELINE_CREATE_DERIVATIVE_BIT flag, and
    /// pname:basePipelineIndex is not `-1`, it must: be a valid index into the
    /// calling command's pname:pCreateInfos parameter * If pname:flags
    /// contains the ename:VK_PIPELINE_CREATE_DERIVATIVE_BIT flag, and
    /// pname:basePipelineHandle is not dlink:VK_NULL_HANDLE,
    /// pname:basePipelineIndex must: be `-1` * If pname:flags contains the
    /// ename:VK_PIPELINE_CREATE_DERIVATIVE_BIT flag, and
    /// pname:basePipelineHandle is not dlink:VK_NULL_HANDLE,
    /// pname:basePipelineHandle must: be a valid sname:VkPipeline handle * If
    /// pname:flags contains the ename:VK_PIPELINE_CREATE_DERIVATIVE_BIT flag,
    /// and pname:basePipelineHandle is not dlink:VK_NULL_HANDLE, it must: be a
    /// valid handle to a graphics sname:VkPipeline * The pname:stage member of
    /// each element of pname:pStages must: be unique * The pname:stage member
    /// of one element of pname:pStages must: be
    /// ename:VK_SHADER_STAGE_VERTEX_BIT * The pname:stage member of any given
    /// element of pname:pStages must: not be ename:VK_SHADER_STAGE_COMPUTE_BIT
    /// * If pname:pStages includes a tessellation control shader stage, it
    /// must: include a tessellation evaluation shader stage * If pname:pStages
    /// includes a tessellation evaluation shader stage, it must: include a
    /// tessellation control shader stage * If pname:pStages includes a
    /// tessellation control shader stage and a tessellation evaluation shader
    /// stage, pname:pTessellationState must: not be `NULL` * If pname:pStages
    /// includes tessellation shader stages, the shader code of at least one
    /// stage must: contain an code:OpExecutionMode instruction that specifies
    /// the type of subdivision in the pipeline * If pname:pStages includes
    /// tessellation shader stages, and the shader code of both stages contain
    /// an code:OpExecutionMode instruction that specifies the type of
    /// subdivision in the pipeline, they must: both specify the same
    /// subdivision mode * If pname:pStages includes tessellation shader
    /// stages, the shader code of at least one stage must: contain an
    /// code:OpExecutionMode instruction that specifies the output patch size
    /// in the pipeline * If pname:pStages includes tessellation shader stages,
    /// and the shader code of both contain an code:OpExecutionMode instruction
    /// that specifies the out patch size in the pipeline, they must: both
    /// specify the same patch size * If pname:pStages includes tessellation
    /// shader stages, the pname:topology member of pname:pInputAssembly must:
    /// be ename:VK_PRIMITIVE_TOPOLOGY_PATCH_LIST * If the pname:topology
    /// member of pname:pInputAssembly is
    /// ename:VK_PRIMITIVE_TOPOLOGY_PATCH_LIST, pname:pStages must: include
    /// tessellation shader stages * If pname:pStages includes a geometry
    /// shader stage, and does not include any tessellation shader stages, its
    /// shader code must: contain an code:OpExecutionMode instruction that
    /// specifies an input primitive type that is
    /// &lt;&lt;shaders-geometry-execution, compatible&gt;&gt; with the
    /// primitive topology specified in pname:pInputAssembly * If pname:pStages
    /// includes a geometry shader stage, and also includes tessellation shader
    /// stages, its shader code must: contain an code:OpExecutionMode
    /// instruction that specifies an input primitive type that is
    /// &lt;&lt;shaders-geometry-execution, compatible&gt;&gt; with the
    /// primitive topology that is output by the tessellation stages * If
    /// pname:pStages includes a fragment shader stage and a geometry shader
    /// stage, and the fragment shader code reads from an input variable that
    /// is decorated with code:PrimitiveID, then the geometry shader code must:
    /// write to a matching output variable, decorated with code:PrimitiveID,
    /// in all execution paths * If pname:pStages includes a fragment shader
    /// stage, its shader code must: not read from any input attachment that is
    /// defined as ename:VK_ATTACHMENT_UNUSED in pname:subpass * The shader
    /// code for the entry points identified by pname:pStages, and the rest of
    /// the state identified by this structure must: adhere to the pipeline
    /// linking rules described in the &lt;&lt;interfaces,Shader
    /// Interfaces&gt;&gt; chapter * If pname:subpass uses a depth/stencil
    /// attachment in pname:renderpass that has a layout of
    /// ename:VK_IMAGE_LAYOUT_DEPTH_STENCIL_READ_ONLY_OPTIMAL in the
    /// sname:VkAttachmentReference defined by pname:subpass, and
    /// pname:pDepthStencilState is not `NULL`, the pname:depthWriteEnable
    /// member of pname:pDepthStencilState must: be ename:VK_FALSE * If
    /// pname:subpass uses a depth/stencil attachment in pname:renderpass that
    /// has a layout of ename:VK_IMAGE_LAYOUT_DEPTH_STENCIL_READ_ONLY_OPTIMAL
    /// in the sname:VkAttachmentReference defined by pname:subpass, and
    /// pname:pDepthStencilState is not `NULL`, the pname:failOp, pname:passOp
    /// and pname:depthFailOp members of each of the pname:front and pname:back
    /// members of pname:pDepthStencilState must: be ename:VK_STENCIL_OP_KEEP *
    /// If pname:pColorBlendState is not `NULL`, the pname:blendEnable member
    /// of each element of the pname:pAttachment member of
    /// pname:pColorBlendState must: be ename:VK_FALSE if the pname:format of
    /// the attachment referred to in pname:subpass of pname:renderPass does
    /// not support color blend operations, as specified by the
    /// ename:VK_FORMAT_FEATURE_COLOR_ATTACHMENT_BLEND_BIT flag in
    /// sname:VkFormatProperties::pname:linearTilingFeatures or
    /// sname:VkFormatProperties::pname:optimalTilingFeatures returned by
    /// fname:vkGetPhysicalDeviceFormatProperties * If pname:pColorBlendState
    /// is not `NULL`, The pname:attachmentCount member of
    /// pname:pColorBlendState must: be equal to the pname:colorAttachmentCount
    /// used to create pname:subpass * If no element of the
    /// pname:pDynamicStates member of pname:pDynamicState is
    /// ename:VK_DYNAMIC_STATE_VIEWPORT, the pname:pViewports member of
    /// pname:pViewportState must: be a pointer to an array of
    /// pname:pViewportState::pname:viewportCount sname:VkViewport structures *
    /// If no element of the pname:pDynamicStates member of pname:pDynamicState
    /// is ename:VK_DYNAMIC_STATE_SCISSOR, the pname:pScissors member of
    /// pname:pViewportState must: be a pointer to an array of
    /// pname:pViewportState::pname:scissorCount sname:VkRect2D structures * If
    /// the wide lines feature is not enabled, and no element of the
    /// pname:pDynamicStates member of pname:pDynamicState is
    /// ename:VK_DYNAMIC_STATE_LINE_WIDTH, the pname:lineWidth member of
    /// pname:pRasterizationState must: be `1.0` * If the
    /// pname:rasterizerDiscardEnable member of pname:pRasterizationState is
    /// ename:VK_FALSE, pname:pViewportState must: be a pointer to a valid
    /// sname:VkPipelineViewportStateCreateInfo structure * If the
    /// pname:rasterizerDiscardEnable member of pname:pRasterizationState is
    /// ename:VK_FALSE, pname:pMultisampleState must: be a pointer to a valid
    /// sname:VkPipelineMultisampleStateCreateInfo structure * If the
    /// pname:rasterizerDiscardEnable member of pname:pRasterizationState is
    /// ename:VK_FALSE, and pname:subpass uses a depth/stencil attachment,
    /// pname:pDepthStencilState must: be a pointer to a valid
    /// sname:VkPipelineDepthStencilStateCreateInfo structure * If the
    /// pname:rasterizerDiscardEnable member of pname:pRasterizationState is
    /// ename:VK_FALSE, and pname:subpass uses color attachments,
    /// pname:pColorBlendState must: be a pointer to a valid
    /// sname:VkPipelineColorBlendStateCreateInfo structure * If the depth bias
    /// clamping feature is not enabled, no element of the pname:pDynamicStates
    /// member of pname:pDynamicState is ename:VK_DYNAMIC_STATE_DEPTH_BIAS, and
    /// the pname:depthBiasEnable member of pname:pDepthStencil is
    /// ename:VK_TRUE, the pname:depthBiasClamp member of pname:pDepthStencil
    /// must: be `0.0` * If no element of the pname:pDynamicStates member of
    /// pname:pDynamicState is ename:VK_DYNAMIC_STATE_DEPTH_BOUNDS, and the
    /// pname:depthBoundsTestEnable member of pname:pDepthStencil is
    /// ename:VK_TRUE, the pname:minDepthBounds and pname:maxDepthBounds
    /// members of pname:pDepthStencil must: be between `0.0` and `1.0`,
    /// inclusive * pname:layout must: be
    /// &lt;&lt;descriptorsets-pipelinelayout-consistency,consistent&gt;&gt; with
    /// all shaders specified in pname:pStages * If pname:subpass uses color
    /// and/or depth/stencil attachments, then the pname:rasterizationSamples
    /// member of pname:pMultisampleState must: be the same as the sample count
    /// for those subpass attachments * If pname:subpass does not use any color
    /// and/or depth/stencil attachments, then the pname:rasterizationSamples
    /// member of pname:pMultisampleState must: follow the rules for a
    /// &lt;&lt;renderpass-noattachments, zero-attachment subpass&gt;&gt; *
    /// pname:subpass must: be a valid subpass within pname:renderpass ****
    /// </para>
    /// </summary>
    [Flags]
    public enum PipelineCreateFlags
    {
        /// <summary>
        /// -
        /// </summary>
        None = 0, 
        
        /// <summary>
        /// ename:VK_PIPELINE_CREATE_DISABLE_OPTIMIZATION_BIT specifies that
        /// the created pipeline will not be optimized. Using this flag may:
        /// reduce the time taken to create the pipeline.
        /// </summary>
        DisableOptimization = 1 << 0, 
        
        /// <summary>
        /// ename:VK_PIPELINE_CREATE_ALLOW_DERIVATIVES_BIT specifies that the
        /// pipeline to be created is allowed to be the parent of a pipeline
        /// that will be created in a subsequent call to
        /// flink:vkCreateGraphicsPipelines.
        /// </summary>
        AllowDerivatives = 1 << 1, 
        
        /// <summary>
        /// ename:VK_PIPELINE_CREATE_DERIVATIVE_BIT specifies that the pipeline
        /// to be created will be a child of a previously created parent
        /// pipeline.
        /// </summary>
        Derivative = 1 << 2, 
    }
    
    /// <summary>
    /// -
    /// </summary>
    [Flags]
    public enum PipelineDepthStencilStateCreateFlags
    {
        /// <summary>
        /// -
        /// </summary>
        None = 0, 
    }
    
    /// <summary>
    /// -
    /// </summary>
    [Flags]
    public enum PipelineDynamicStateCreateFlags
    {
        /// <summary>
        /// -
        /// </summary>
        None = 0, 
    }
    
    /// <summary>
    /// -
    /// </summary>
    [Flags]
    public enum PipelineInputAssemblyStateCreateFlags
    {
        /// <summary>
        /// -
        /// </summary>
        None = 0, 
    }
    
    /// <summary>
    /// -
    /// </summary>
    [Flags]
    public enum PipelineLayoutCreateFlags
    {
        /// <summary>
        /// -
        /// </summary>
        None = 0, 
    }
    
    /// <summary>
    /// -
    /// </summary>
    [Flags]
    public enum PipelineMultisampleStateCreateFlags
    {
        /// <summary>
        /// -
        /// </summary>
        None = 0, 
    }
    
    /// <summary>
    /// -
    /// </summary>
    [Flags]
    public enum PipelineRasterizationStateCreateFlags
    {
        /// <summary>
        /// -
        /// </summary>
        None = 0, 
    }
    
    /// <summary>
    /// -
    /// </summary>
    [Flags]
    public enum PipelineShaderStageCreateFlags
    {
        /// <summary>
        /// -
        /// </summary>
        None = 0, 
    }
    
    /// <summary>
    /// <para>
    /// Bitmask specifying pipeline stages.
    /// </para>
    /// <para>
    /// [NOTE] .Note ==== The ename:VK_PIPELINE_STAGE_ALL_COMMANDS_BIT and
    /// ename:VK_PIPELINE_STAGE_ALL_GRAPHICS_BIT differ from
    /// ename:VK_PIPELINE_STAGE_BOTTOM_OF_PIPE_BIT in that they correspond to
    /// all (or all graphics) stages, rather than to a specific stage at the
    /// end of the pipeline. An execution dependency with only
    /// ename:VK_PIPELINE_STAGE_BOTTOM_OF_PIPE_BIT in pname:dstStageMask will
    /// not delay subsequent commands, while including either of the other two
    /// bits will. Similarly, when defining a memory dependency, if the stage
    /// mask(s) refer to all stages, then the indicated access types from all
    /// stages will be made available and/or visible, but using only
    /// ename:VK_PIPELINE_STAGE_BOTTOM_OF_PIPE_BIT would not make any accesses
    /// available and/or visible because this stage does not access memory. The
    /// ename:VK_PIPELINE_STAGE_BOTTOM_OF_PIPE_BIT is useful for accomplishing
    /// memory barriers and layout transitions when the next accesses will be
    /// done in a different queue or by a presentation engine; in these cases
    /// subsequent commands in the same queue do not need to wait, but the
    /// barrier or transition must: complete before semaphores associated with
    /// the batch signal. ====
    /// </para>
    /// </summary>
    [Flags]
    public enum PipelineStageFlags
    {
        /// <summary>
        /// -
        /// </summary>
        None = 0, 
        
        /// <summary>
        /// ename:VK_PIPELINE_STAGE_TOP_OF_PIPE_BIT: Stage of the pipeline
        /// where commands are initially received by the queue.
        /// </summary>
        TopOfPipe = 1 << 0, 
        
        /// <summary>
        /// ename:VK_PIPELINE_STAGE_DRAW_INDIRECT_BIT: Stage of the pipeline
        /// where Draw/DispatchIndirect data structures are consumed.
        /// </summary>
        DrawIndirect = 1 << 1, 
        
        /// <summary>
        /// ename:VK_PIPELINE_STAGE_VERTEX_INPUT_BIT: Stage of the pipeline
        /// where vertex and index buffers are consumed.
        /// </summary>
        VertexInput = 1 << 2, 
        
        /// <summary>
        /// ename:VK_PIPELINE_STAGE_VERTEX_SHADER_BIT: Vertex shader stage.
        /// </summary>
        VertexShader = 1 << 3, 
        
        /// <summary>
        /// ename:VK_PIPELINE_STAGE_TESSELLATION_CONTROL_SHADER_BIT:
        /// Tessellation control shader stage.
        /// </summary>
        TessellationControlShader = 1 << 4, 
        
        /// <summary>
        /// ename:VK_PIPELINE_STAGE_TESSELLATION_EVALUATION_SHADER_BIT:
        /// Tessellation evaluation shader stage.
        /// </summary>
        TessellationEvaluationShader = 1 << 5, 
        
        /// <summary>
        /// ename:VK_PIPELINE_STAGE_GEOMETRY_SHADER_BIT: Geometry shader stage.
        /// </summary>
        GeometryShader = 1 << 6, 
        
        /// <summary>
        /// ename:VK_PIPELINE_STAGE_FRAGMENT_SHADER_BIT: Fragment shader stage.
        /// </summary>
        FragmentShader = 1 << 7, 
        
        /// <summary>
        /// ename:VK_PIPELINE_STAGE_EARLY_FRAGMENT_TESTS_BIT: Stage of the
        /// pipeline where early fragment tests (depth and stencil tests before
        /// fragment shading) are performed.
        /// </summary>
        EarlyFragmentTests = 1 << 8, 
        
        /// <summary>
        /// ename:VK_PIPELINE_STAGE_LATE_FRAGMENT_TESTS_BIT: Stage of the
        /// pipeline where late fragment tests (depth and stencil tests after
        /// fragment shading) are performed.
        /// </summary>
        LateFragmentTests = 1 << 9, 
        
        /// <summary>
        /// ename:VK_PIPELINE_STAGE_COLOR_ATTACHMENT_OUTPUT_BIT: Stage of the
        /// pipeline after blending where the final color values are output
        /// from the pipeline. This stage also includes resolve operations that
        /// occur at the end of a subpass. Note that this does not necessarily
        /// indicate that the values have been committed to memory.
        /// </summary>
        ColorAttachmentOutput = 1 << 10, 
        
        /// <summary>
        /// ename:VK_PIPELINE_STAGE_COMPUTE_SHADER_BIT: Execution of a compute
        /// shader.
        /// </summary>
        ComputeShader = 1 << 11, 
        
        /// <summary>
        /// ename:VK_PIPELINE_STAGE_TRANSFER_BIT: Execution of copy commands.
        /// This includes the operations resulting from all transfer commands.
        /// The set of transfer commands comprises fname:vkCmdCopyBuffer,
        /// fname:vkCmdCopyImage, fname:vkCmdBlitImage,
        /// fname:vkCmdCopyBufferToImage, fname:vkCmdCopyImageToBuffer,
        /// fname:vkCmdUpdateBuffer, fname:vkCmdFillBuffer,
        /// fname:vkCmdClearColorImage, fname:vkCmdClearDepthStencilImage,
        /// fname:vkCmdResolveImage, and fname:vkCmdCopyQueryPoolResults.
        /// </summary>
        Transfer = 1 << 12, 
        
        /// <summary>
        /// ename:VK_PIPELINE_STAGE_BOTTOM_OF_PIPE_BIT: Final stage in the
        /// pipeline where commands complete execution.
        /// </summary>
        BottomOfPipe = 1 << 13, 
        
        /// <summary>
        /// ename:VK_PIPELINE_STAGE_HOST_BIT: A pseudo-stage indicating
        /// execution on the host of reads/writes of device memory.
        /// </summary>
        Host = 1 << 14, 
        
        /// <summary>
        /// ename:VK_PIPELINE_STAGE_ALL_GRAPHICS_BIT: Execution of all graphics
        /// pipeline stages.
        /// </summary>
        AllGraphics = 1 << 15, 
        
        /// <summary>
        /// ename:VK_PIPELINE_STAGE_ALL_COMMANDS_BIT: Execution of all stages
        /// supported on the queue.
        /// </summary>
        AllCommands = 1 << 16, 
    }
    
    /// <summary>
    /// -
    /// </summary>
    [Flags]
    public enum PipelineTessellationStateCreateFlags
    {
        /// <summary>
        /// -
        /// </summary>
        None = 0, 
    }
    
    /// <summary>
    /// -
    /// </summary>
    [Flags]
    public enum PipelineVertexInputStateCreateFlags
    {
        /// <summary>
        /// -
        /// </summary>
        None = 0, 
    }
    
    /// <summary>
    /// -
    /// </summary>
    [Flags]
    public enum PipelineViewportStateCreateFlags
    {
        /// <summary>
        /// -
        /// </summary>
        None = 0, 
    }
    
    /// <summary>
    /// <para>
    /// Bitmask specifying constraints on a query.
    /// </para>
    /// <para>
    /// If the pname:queryType of the pool is ename:VK_QUERY_TYPE_OCCLUSION and
    /// pname:flags contains ename:VK_QUERY_CONTROL_PRECISE_BIT, an
    /// implementation must: return a result that matches the actual number of
    /// samples passed. This is described in more detail in
    /// &lt;&lt;queries-occlusion,Occlusion Queries&gt;&gt;.
    /// </para>
    /// <para>
    /// After beginning a query, that query is considered _active_ within the
    /// command buffer it was called in until that same query is ended. Queries
    /// active in a primary command buffer when secondary command buffers are
    /// executed are considered active for those secondary command buffers.
    /// </para>
    /// <para>
    /// .Valid Usage **** * The query identified by pname:queryPool and
    /// pname:query must: currently not be
    /// &lt;&lt;queries-operation-active,active&gt;&gt; * The query identified
    /// by pname:queryPool and pname:query must: be unavailable * If the
    /// &lt;&lt;features-features-occlusionQueryPrecise,precise occlusion
    /// queries&gt;&gt; feature is not enabled, or the pname:queryType used to
    /// create pname:queryPool was not ename:VK_QUERY_TYPE_OCCLUSION,
    /// pname:flags must: not contain ename:VK_QUERY_CONTROL_PRECISE_BIT *
    /// pname:queryPool must: have been created with a pname:queryType that
    /// differs from that of any other queries that have been made
    /// &lt;&lt;queries-operation-active,active&gt;&gt;, and are currently
    /// still active within pname:commandBuffer * pname:query must: be less
    /// than the number of queries in pname:queryPool * If the pname:queryType
    /// used to create pname:queryPool was ename:VK_QUERY_TYPE_OCCLUSION, the
    /// sname:VkCommandPool that pname:commandBuffer was allocated from must:
    /// support graphics operations * If the pname:queryType used to create
    /// pname:queryPool was ename:VK_QUERY_TYPE_PIPELINE_STATISTICS and any of
    /// the pname:pipelineStatistics indicate graphics operations, the
    /// sname:VkCommandPool that pname:commandBuffer was allocated from must:
    /// support graphics operations * If the pname:queryType used to create
    /// pname:queryPool was ename:VK_QUERY_TYPE_PIPELINE_STATISTICS and any of
    /// the pname:pipelineStatistics indicate compute operations, the
    /// sname:VkCommandPool that pname:commandBuffer was allocated from must:
    /// support compute operations ****
    /// </para>
    /// </summary>
    [Flags]
    public enum QueryControlFlags
    {
        /// <summary>
        /// -
        /// </summary>
        None = 0, 
        
        /// <summary>
        /// Require precise results to be collected by the query
        /// </summary>
        Precise = 1 << 0, 
    }
    
    /// <summary>
    /// <para>
    /// Bitmask specifying queried pipeline statistics.
    /// </para>
    /// <para>
    /// These bits have the following meanings:
    /// </para>
    /// <para>
    /// * If ename:VK_QUERY_PIPELINE_STATISTIC_INPUT_ASSEMBLY_VERTICES_BIT is
    /// set, queries managed by the pool will count the number of vertices
    /// processed by the &lt;&lt;drawing,input assembly&gt;&gt; stage. Vertices
    /// corresponding to incomplete primitives may: contribute to the count. *
    /// If ename:VK_QUERY_PIPELINE_STATISTIC_INPUT_ASSEMBLY_PRIMITIVES_BIT is
    /// set, queries managed by the pool will count the number of primitives
    /// processed by the &lt;&lt;drawing,input assembly&gt;&gt; stage. If
    /// primitive restart is enabled, restarting the primitive topology has no
    /// effect on the count. Incomplete primitives may: be counted. * If
    /// ename:VK_QUERY_PIPELINE_STATISTIC_VERTEX_SHADER_INVOCATIONS_BIT is set,
    /// queries managed by the pool will count the number of vertex shader
    /// invocations. This counter's value is incremented each time a vertex
    /// shader is &lt;&lt;shaders-vertex-execution,invoked&gt;&gt;. * If
    /// ename:VK_QUERY_PIPELINE_STATISTIC_GEOMETRY_SHADER_INVOCATIONS_BIT is
    /// set, queries managed by the pool will count the number of geometry
    /// shader invocations. This counter's value is incremented each time a
    /// geometry shader is &lt;&lt;shaders-geometry-execution,invoked&gt;&gt;.
    /// In the case of &lt;&lt;geometry-invocations,instanced geometry
    /// shaders&gt;&gt;, the geometry shader invocations count is incremented
    /// for each separate instanced invocation. * If
    /// ename:VK_QUERY_PIPELINE_STATISTIC_GEOMETRY_SHADER_PRIMITIVES_BIT is
    /// set, queries managed by the pool will count the number of primitives
    /// generated by geometry shader invocations. The counter's value is
    /// incremented each time the geometry shader emits a primitive. Restarting
    /// primitive topology using the SPIR-V instructions code:OpEndPrimitive or
    /// code:OpEndStreamPrimitive has no effect on the geometry shader output
    /// primitives count. * If
    /// ename:VK_QUERY_PIPELINE_STATISTIC_CLIPPING_INVOCATIONS_BIT is set,
    /// queries managed by the pool will count the number of primitives
    /// processed by the &lt;&lt;vertexpostproc-clipping,Primitive
    /// Clipping&gt;&gt; stage of the pipeline. The counter's value is
    /// incremented each time a primitive reaches the primitive clipping stage.
    /// * If ename:VK_QUERY_PIPELINE_STATISTIC_CLIPPING_PRIMITIVES_BIT is set,
    /// queries managed by the pool will count the number of primitives output
    /// by the &lt;&lt;vertexpostproc-clipping,Primitive Clipping&gt;&gt; stage
    /// of the pipeline. The counter's value is incremented each time a
    /// primitive passes the primitive clipping stage. The actual number of
    /// primitives output by the primitive clipping stage for a particular
    /// input primitive is implementation-dependent but must: satisfy the
    /// following conditions: ** If at least one vertex of the input primitive
    /// lies inside the clipping volume, the counter is incremented by one or
    /// more. ** Otherwise, the counter is incremented by zero or more. * If
    /// ename:VK_QUERY_PIPELINE_STATISTIC_FRAGMENT_SHADER_INVOCATIONS_BIT is
    /// set, queries managed by the pool will count the number of fragment
    /// shader invocations. The counter's value is incremented each time the
    /// fragment shader is &lt;&lt;shaders-fragment-execution,invoked&gt;&gt;.
    /// * If
    /// ename:VK_QUERY_PIPELINE_STATISTIC_TESSELLATION_CONTROL_SHADER_PATCHES_BIT is
    /// set, queries managed by the pool will count the number of patches
    /// processed by the tessellation control shader. The counter's value is
    /// incremented once for each patch for which a tessellation control shader
    /// is &lt;&lt;shaders-tessellation-control-execution,invoked&gt;&gt;. * If
    /// ename:VK_QUERY_PIPELINE_STATISTIC_TESSELLATION_EVALUATION_SHADER_INVOCATIONS_BIT is
    /// set, queries managed by the pool will count the number of invocations
    /// of the tessellation evaluation shader. The counter's value is
    /// incremented each time the tessellation evaluation shader is
    /// &lt;&lt;shaders-tessellation-evaluation-execution,invoked&gt;&gt;. * If
    /// ename:VK_QUERY_PIPELINE_STATISTIC_COMPUTE_SHADER_INVOCATIONS_BIT is
    /// set, queries managed by the pool will count the number of compute
    /// shader invocations. The counter's value is incremented every time the
    /// compute shader is invoked. Implementations may: skip the execution of
    /// certain compute shader invocations or execute additional compute shader
    /// invocations for implementation-dependent reasons as long as the results
    /// of rendering otherwise remain unchanged.
    /// </para>
    /// <para>
    /// These values are intended to measure relative statistics on one
    /// implementation. Various device architectures will count these values
    /// differently. Any or all counters may: be affected by the issues
    /// described in &lt;&lt;queries-operation-undefined,Query
    /// Operation&gt;&gt;.
    /// </para>
    /// <para>
    /// [NOTE] .Note ==== For example, tile-based rendering devices may: need
    /// to replay the scene multiple times, affecting some of the counts. ====
    /// </para>
    /// <para>
    /// If a pipeline has pname:rasterizerDiscardEnable enabled,
    /// implementations may: discard primitives after the final vertex
    /// processing stage. As a result, if pname:rasterizerDiscardEnable is
    /// enabled, the clipping input and output primitives counters may: not be
    /// incremented.
    /// </para>
    /// <para>
    /// When a pipeline statistics query finishes, the result for that query is
    /// marked as available. The application can: copy the result to a buffer
    /// (via fname:vkCmdCopyQueryPoolResults), or request it be put into host
    /// memory (via fname:vkGetQueryPoolResults).
    /// </para>
    /// </summary>
    [Flags]
    public enum QueryPipelineStatisticFlags
    {
        /// <summary>
        /// -
        /// </summary>
        None = 0, 
        
        /// <summary>
        /// Optional
        /// </summary>
        InputAssemblyVertices = 1 << 0, 
        
        /// <summary>
        /// Optional
        /// </summary>
        InputAssemblyPrimitives = 1 << 1, 
        
        /// <summary>
        /// Optional
        /// </summary>
        VertexShaderInvocations = 1 << 2, 
        
        /// <summary>
        /// Optional
        /// </summary>
        GeometryShaderInvocations = 1 << 3, 
        
        /// <summary>
        /// Optional
        /// </summary>
        GeometryShaderPrimitives = 1 << 4, 
        
        /// <summary>
        /// Optional
        /// </summary>
        ClippingInvocations = 1 << 5, 
        
        /// <summary>
        /// Optional
        /// </summary>
        ClippingPrimitives = 1 << 6, 
        
        /// <summary>
        /// Optional
        /// </summary>
        FragmentShaderInvocations = 1 << 7, 
        
        /// <summary>
        /// Optional
        /// </summary>
        TessellationControlShaderPatches = 1 << 8, 
        
        /// <summary>
        /// Optional
        /// </summary>
        TessellationEvaluationShaderInvocations = 1 << 9, 
        
        /// <summary>
        /// Optional
        /// </summary>
        ComputeShaderInvocations = 1 << 10, 
    }
    
    /// <summary>
    /// -
    /// </summary>
    [Flags]
    public enum QueryPoolCreateFlags
    {
        /// <summary>
        /// -
        /// </summary>
        None = 0, 
    }
    
    /// <summary>
    /// <para>
    /// Bitmask specifying how and when query results are returned.
    /// </para>
    /// <para>
    /// If no bits are set in pname:flags, and all requested queries are in the
    /// available state, results are written as an array of 32-bit unsigned
    /// integer values. The behavior when not all queries are available, is
    /// described &lt;&lt;queries-wait-bit-not-set, below&gt;&gt;.
    /// </para>
    /// <para>
    /// If ename:VK_QUERY_RESULT_64_BIT is not set and the result overflows a
    /// 32-bit value, the value may: either wrap or saturate. Similarly, if
    /// ename:VK_QUERY_RESULT_64_BIT is set and the result overflows a 64-bit
    /// value, the value may: either wrap or saturate.
    /// </para>
    /// <para>
    /// If ename:VK_QUERY_RESULT_WAIT_BIT is set, Vulkan will wait for each
    /// query to be in the available state before retrieving the numerical
    /// results for that query. In this case, fname:vkGetQueryPoolResults is
    /// guaranteed to succeed and return ename:VK_SUCCESS if the queries become
    /// available in a finite time (i.e. if they have been issued and not
    /// reset). If queries will never finish (e.g. due to being reset but not
    /// issued), then fname:vkGetQueryPoolResults may: not return in finite
    /// time.
    /// </para>
    /// <para>
    /// If ename:VK_QUERY_RESULT_WAIT_BIT and ename:VK_QUERY_RESULT_PARTIAL_BIT
    /// are both not set then no result values are written to pname:pData for
    /// queries that are in the unavailable state at the time of the call, and
    /// fname:vkGetQueryPoolResults returns ename:VK_NOT_READY. However,
    /// availability state is still written to pname:pData for those queries if
    /// ename:VK_QUERY_RESULT_WITH_AVAILABILITY_BIT is set.
    /// </para>
    /// <para>
    /// [NOTE] .Note ==== Applications must: take care to ensure that use of
    /// the ename:VK_QUERY_RESULT_WAIT_BIT bit has the desired effect.
    /// </para>
    /// <para>
    /// For example, if a query has been used previously and a command buffer
    /// records the commands fname:vkCmdResetQueryPool, fname:vkCmdBeginQuery,
    /// and fname:vkCmdEndQuery for that query, then the query will remain in
    /// the available state until the fname:vkCmdResetQueryPool command
    /// executes on a queue. Applications can: use fences or events to ensure
    /// that a query has already been reset before checking for its results or
    /// availability status. Otherwise, a stale value could be returned from a
    /// previous use of the query.
    /// </para>
    /// <para>
    /// The above also applies when ename:VK_QUERY_RESULT_WAIT_BIT is used in
    /// combination with ename:VK_QUERY_RESULT_WITH_AVAILABILITY_BIT. In this
    /// case, the returned availability status may: reflect the result of a
    /// previous use of the query unless the fname:vkCmdResetQueryPool command
    /// has been executed since the last use of the query. ====
    /// </para>
    /// <para>
    /// [NOTE] .Note ==== Applications can: double-buffer query pool usage,
    /// with a pool per frame, and reset queries at the end of the frame in
    /// which they are read. ====
    /// </para>
    /// <para>
    /// If ename:VK_QUERY_RESULT_PARTIAL_BIT is set,
    /// ename:VK_QUERY_RESULT_WAIT_BIT is not set, and the query's status is
    /// unavailable, an intermediate result value between zero and the final
    /// result value is written to pname:pData for that query.
    /// </para>
    /// <para>
    /// ename:VK_QUERY_RESULT_PARTIAL_BIT must: not be used if the pool's
    /// pname:queryType is ename:VK_QUERY_TYPE_TIMESTAMP.
    /// </para>
    /// <para>
    /// If ename:VK_QUERY_RESULT_WITH_AVAILABILITY_BIT is set, the final
    /// integer value written for each query is non-zero if the query's status
    /// was available or zero if the status was unavailable. When
    /// ename:VK_QUERY_RESULT_WITH_AVAILABILITY_BIT is used, implementations
    /// must: guarantee that if they return a non-zero availability value then
    /// the numerical results must: be valid, assuming the results are not
    /// reset by a subsequent command.
    /// </para>
    /// <para>
    /// [NOTE] .Note ==== Satisfying this guarantee may: require careful
    /// ordering by the application, e.g. to read the availability status
    /// before reading the results. ====
    /// </para>
    /// <para>
    /// .Valid Usage **** * pname:firstQuery must: be less than the number of
    /// queries in pname:queryPool * If ename:VK_QUERY_RESULT_64_BIT is not set
    /// in pname:flags then pname:pData and pname:stride must: be multiples of
    /// `4` * If ename:VK_QUERY_RESULT_64_BIT is set in pname:flags then
    /// pname:pData and pname:stride must: be multiples of `8` * The sum of
    /// pname:firstQuery and pname:queryCount must: be less than or equal to
    /// the number of queries in pname:queryPool * pname:dataSize must: be
    /// large enough to contain the result of each query, as described
    /// &lt;&lt;queries-operation-memorylayout,here&gt;&gt; * If the
    /// pname:queryType used to create pname:queryPool was
    /// ename:VK_QUERY_TYPE_TIMESTAMP, pname:flags must: not contain
    /// ename:VK_QUERY_RESULT_PARTIAL_BIT ****
    /// </para>
    /// </summary>
    [Flags]
    public enum QueryResultFlags
    {
        /// <summary>
        /// -
        /// </summary>
        None = 0, 
        
        /// <summary>
        /// Results of the queries are written to the destination buffer as
        /// 64-bit values
        /// </summary>
        QueryResult64 = 1 << 0, 
        
        /// <summary>
        /// Results of the queries are waited on before proceeding with the
        /// result copy
        /// </summary>
        Wait = 1 << 1, 
        
        /// <summary>
        /// Besides the results of the query, the availability of the results
        /// is also written
        /// </summary>
        WithAvailability = 1 << 2, 
        
        /// <summary>
        /// Copy the partial results of the query even if the final results are
        /// not available
        /// </summary>
        Partial = 1 << 3, 
    }
    
    /// <summary>
    /// <para>
    /// Bitmask specifying capabilities of queues in a queue family.
    /// </para>
    /// <para>
    /// If an implementation exposes any queue family that supports graphics
    /// operations, at least one queue family of at least one physical device
    /// exposed by the implementation must: support both graphics and compute
    /// operations.
    /// </para>
    /// <para>
    /// [NOTE] .Note ==== All commands that are allowed on a queue that
    /// supports transfer operations are also allowed on a queue that supports
    /// either graphics or compute operations thus if the capabilities of a
    /// queue family include ename:VK_QUEUE_GRAPHICS_BIT or
    /// ename:VK_QUEUE_COMPUTE_BIT then reporting the
    /// ename:VK_QUEUE_TRANSFER_BIT capability separately for that queue family
    /// is optional:. ====
    /// </para>
    /// <para>
    /// For further details see &lt;&lt;devsandqueues-queues,Queues&gt;&gt;.
    /// </para>
    /// <para>
    /// The value returned in pname:minImageTransferGranularity has a unit of
    /// compressed texel blocks for images having a block-compressed format,
    /// and a unit of texels otherwise.
    /// </para>
    /// <para>
    /// Possible values of pname:minImageTransferGranularity are:
    /// </para>
    /// <para>
    /// * [eq]#(0,0,0)# which indicates that only whole mip levels must: be
    /// transferred using the image transfer operations on the corresponding
    /// queues. In this case, the following restrictions apply to all offset
    /// and extent parameters of image transfer operations:
    /// </para>
    /// <para>
    /// ** The pname:x, pname:y, and pname:z members of a slink:VkOffset3D
    /// parameter must: always be zero. ** The pname:width, pname:height, and
    /// pname:depth members of a slink:VkExtent3D parameter must: always match
    /// the width, height, and depth of the image subresource corresponding to
    /// the parameter, respectively.
    /// </para>
    /// <para>
    /// * [eq]#(A~x~, A~y~, A~z~)# where [eq]#A~x~#, [eq]#A~y~#, and [eq]#A~z~#
    /// are all integer powers of two. In this case the following restrictions
    /// apply to all image transfer operations:
    /// </para>
    /// <para>
    /// ** pname:x, pname:y, and pname:z of a slink:VkOffset3D parameter must:
    /// be integer multiples of [eq]#A~x~#, [eq]#A~y~#, and [eq]#A~z~#,
    /// respectively. ** pname:width of a slink:VkExtent3D parameter must: be
    /// an integer multiple of [eq]#A~x~#, or else [eq]#pname:x + pname:width#
    /// must: equal the width of the image subresource corresponding to the
    /// parameter. ** pname:height of a slink:VkExtent3D parameter must: be an
    /// integer multiple of [eq]#A~y~#, or else [eq]#pname:y + pname:height#
    /// must: equal the height of the image subresource corresponding to the
    /// parameter. ** pname:depth of a slink:VkExtent3D parameter must: be an
    /// integer multiple of [eq]#A~z~#, or else [eq]#pname:z + pname:depth#
    /// must: equal the depth of the image subresource corresponding to the
    /// parameter. ** If the format of the image corresponding to the
    /// parameters is one of the block-compressed formats then for the purposes
    /// of the above calculations the granularity must: be scaled up by the
    /// compressed texel block dimensions.
    /// </para>
    /// <para>
    /// Queues supporting graphics and/or compute operations must: report
    /// [eq]#(1,1,1)# in pname:minImageTransferGranularity, meaning that there
    /// are no additional restrictions on the granularity of image transfer
    /// operations for these queues. Other queues supporting image transfer
    /// operations are only required: to support whole mip level transfers,
    /// thus pname:minImageTransferGranularity for queues belonging to such
    /// queue families may: be [eq]#(0,0,0)#.
    /// </para>
    /// </summary>
    [Flags]
    public enum QueueFlags
    {
        /// <summary>
        /// -
        /// </summary>
        None = 0, 
        
        /// <summary>
        /// if ename:VK_QUEUE_GRAPHICS_BIT is set, then the queues in this
        /// queue family support graphics operations.
        /// </summary>
        Graphics = 1 << 0, 
        
        /// <summary>
        /// if ename:VK_QUEUE_COMPUTE_BIT is set, then the queues in this queue
        /// family support compute operations.
        /// </summary>
        Compute = 1 << 1, 
        
        /// <summary>
        /// if ename:VK_QUEUE_TRANSFER_BIT is set, then the queues in this
        /// queue family support transfer operations.
        /// </summary>
        Transfer = 1 << 2, 
        
        /// <summary>
        /// if ename:VK_QUEUE_SPARSE_BINDING_BIT is set, then the queues in
        /// this queue family support sparse memory management operations (see
        /// &lt;&lt;sparsememory,Sparse Resources&gt;&gt;). If any of the
        /// sparse resource features are enabled, then at least one queue
        /// family must: support this bit.
        /// </summary>
        SparseBinding = 1 << 3, 
    }
    
    /// <summary>
    /// -
    /// </summary>
    [Flags]
    public enum RenderPassCreateFlags
    {
        /// <summary>
        /// -
        /// </summary>
        None = 0, 
    }
    
    /// <summary>
    /// Bitmask specifying sample counts supported for an image used for
    /// storage operations.
    /// </summary>
    [Flags]
    public enum SampleCountFlags
    {
        /// <summary>
        /// -
        /// </summary>
        None = 0, 
        
        /// <summary>
        /// Sample count 1 supported
        /// </summary>
        SampleCount1 = 1 << 0, 
        
        /// <summary>
        /// Sample count 2 supported
        /// </summary>
        SampleCount2 = 1 << 1, 
        
        /// <summary>
        /// Sample count 4 supported
        /// </summary>
        SampleCount4 = 1 << 2, 
        
        /// <summary>
        /// Sample count 8 supported
        /// </summary>
        SampleCount8 = 1 << 3, 
        
        /// <summary>
        /// Sample count 16 supported
        /// </summary>
        SampleCount16 = 1 << 4, 
        
        /// <summary>
        /// Sample count 32 supported
        /// </summary>
        SampleCount32 = 1 << 5, 
        
        /// <summary>
        /// Sample count 64 supported
        /// </summary>
        SampleCount64 = 1 << 6, 
    }
    
    /// <summary>
    /// -
    /// </summary>
    [Flags]
    public enum SamplerCreateFlags
    {
        /// <summary>
        /// -
        /// </summary>
        None = 0, 
    }
    
    /// <summary>
    /// -
    /// </summary>
    [Flags]
    public enum SemaphoreCreateFlags
    {
        /// <summary>
        /// -
        /// </summary>
        None = 0, 
    }
    
    /// <summary>
    /// -
    /// </summary>
    [Flags]
    public enum ShaderModuleCreateFlags
    {
        /// <summary>
        /// -
        /// </summary>
        None = 0, 
    }
    
    /// <summary>
    /// <para>
    /// Bitmask specifying a pipeline stage.
    /// </para>
    /// <para>
    /// .Valid Usage **** * If the
    /// &lt;&lt;features-features-geometryShader,geometry shaders&gt;&gt;
    /// feature is not enabled, pname:stage must: not be
    /// ename:VK_SHADER_STAGE_GEOMETRY_BIT * If the
    /// &lt;&lt;features-features-tessellationShader,tessellation shaders&gt;&gt;
    /// feature is not enabled, pname:stage must: not be
    /// ename:VK_SHADER_STAGE_TESSELLATION_CONTROL_BIT or
    /// ename:VK_SHADER_STAGE_TESSELLATION_EVALUATION_BIT * pname:stage must:
    /// not be ename:VK_SHADER_STAGE_ALL_GRAPHICS, or ename:VK_SHADER_STAGE_ALL
    /// * pname:pName must: be the name of an code:OpEntryPoint in pname:module
    /// with an execution model that matches pname:stage * If the identified
    /// entry point includes any variable in its interface that is declared
    /// with the code:ClipDistance code:BuiltIn decoration, that variable must:
    /// not have an array size greater than
    /// sname:VkPhysicalDeviceLimits::pname:maxClipDistances * If the
    /// identified entry point includes any variable in its interface that is
    /// declared with the code:CullDistance code:BuiltIn decoration, that
    /// variable must: not have an array size greater than
    /// sname:VkPhysicalDeviceLimits::pname:maxCullDistances * If the
    /// identified entry point includes any variables in its interface that are
    /// declared with the code:ClipDistance or code:CullDistance code:BuiltIn
    /// decoration, those variables must: not have array sizes which sum to
    /// more than
    /// sname:VkPhysicalDeviceLimits::pname:maxCombinedClipAndCullDistances *
    /// If the identified entry point includes any variable in its interface
    /// that is declared with the code:SampleMask code:BuiltIn decoration, that
    /// variable must: not have an array size greater than
    /// sname:VkPhysicalDeviceLimits::pname:maxSampleMaskWords * If pname:stage
    /// is ename:VK_SHADER_STAGE_VERTEX_BIT, the identified entry point must:
    /// not include any input variable in its interface that is decorated with
    /// code:CullDistance * If pname:stage is
    /// ename:VK_SHADER_STAGE_TESSELLATION_CONTROL_BIT or
    /// ename:VK_SHADER_STAGE_TESSELLATION_EVALUATION_BIT, and the identified
    /// entry point has an code:OpExecutionMode instruction that specifies a
    /// patch size with code:OutputVertices, the patch size must: be greater
    /// than `0` and less than or equal to
    /// sname:VkPhysicalDeviceLimits::pname:maxTessellationPatchSize * If
    /// pname:stage is ename:VK_SHADER_STAGE_GEOMETRY_BIT, the identified entry
    /// point must: have an code:OpExecutionMode instruction that specifies a
    /// maximum output vertex count that is greater than `0` and less than or
    /// equal to sname:VkPhysicalDeviceLimits::pname:maxGeometryOutputVertices
    /// * If pname:stage is ename:VK_SHADER_STAGE_GEOMETRY_BIT, the identified
    /// entry point must: have an code:OpExecutionMode instruction that
    /// specifies an invocation count that is greater than `0` and less than or
    /// equal to
    /// sname:VkPhysicalDeviceLimits::pname:maxGeometryShaderInvocations * If
    /// pname:stage is ename:VK_SHADER_STAGE_GEOMETRY_BIT, and the identified
    /// entry point writes to code:Layer for any primitive, it must: write the
    /// same value to code:Layer for all vertices of a given primitive * If
    /// pname:stage is ename:VK_SHADER_STAGE_GEOMETRY_BIT, and the identified
    /// entry point writes to code:ViewportIndex for any primitive, it must:
    /// write the same value to code:ViewportIndex for all vertices of a given
    /// primitive * If pname:stage is ename:VK_SHADER_STAGE_FRAGMENT_BIT, the
    /// identified entry point must: not include any output variables in its
    /// interface decorated with code:CullDistance * If pname:stage is
    /// ename:VK_SHADER_STAGE_FRAGMENT_BIT, and the identified entry point
    /// writes to code:FragDepth in any execution path, it must: write to
    /// code:FragDepth in all execution paths ****
    /// </para>
    /// </summary>
    [Flags]
    public enum ShaderStageFlags
    {
        /// <summary>
        /// -
        /// </summary>
        None = 0, 
        
        /// <summary>
        /// -
        /// </summary>
        Vertex = 1 << 0, 
        
        /// <summary>
        /// -
        /// </summary>
        TessellationControl = 1 << 1, 
        
        /// <summary>
        /// -
        /// </summary>
        TessellationEvaluation = 1 << 2, 
        
        /// <summary>
        /// -
        /// </summary>
        Geometry = 1 << 3, 
        
        /// <summary>
        /// -
        /// </summary>
        Fragment = 1 << 4, 
        
        /// <summary>
        /// -
        /// </summary>
        Compute = 1 << 5, 
        
        /// <summary>
        /// -
        /// </summary>
        AllGraphics = 0x0000001F, 
        
        /// <summary>
        /// -
        /// </summary>
        All = 0x7FFFFFFF, 
    }
    
    /// <summary>
    /// Bitmask specifying additional information about a sparse image
    /// resource.
    /// </summary>
    [Flags]
    public enum SparseImageFormatFlags
    {
        /// <summary>
        /// -
        /// </summary>
        None = 0, 
        
        /// <summary>
        /// Image uses a single mip tail region for all array layers
        /// </summary>
        SingleMiptail = 1 << 0, 
        
        /// <summary>
        /// Image requires mip level dimensions to be an integer multiple of
        /// the sparse image block dimensions for non-tail mip levels.
        /// </summary>
        AlignedMipSize = 1 << 1, 
        
        /// <summary>
        /// Image uses a non-standard sparse image block dimensions
        /// </summary>
        NonstandardBlockSize = 1 << 2, 
    }
    
    /// <summary>
    /// <para>
    /// Bitmask specifying usage of a sparse memory binding operation.
    /// </para>
    /// <para>
    /// The _binding range_ [eq]#[pname:resourceOffset, pname:resourceOffset
    /// {plus} pname:size)# has different constraints based on pname:flags. If
    /// pname:flags contains ename:VK_SPARSE_MEMORY_BIND_METADATA_BIT, the
    /// binding range must: be within the mip tail region of the metadata
    /// aspect. This metadata region is defined by:
    /// </para>
    /// <para>
    /// :: [eq]#metadataRegion = [base, base + pname:imageMipTailSize)# ::
    /// [eq]#base = pname:imageMipTailOffset + pname:imageMipTailStride {times}
    /// n#
    /// </para>
    /// <para>
    /// and pname:imageMipTailOffset, pname:imageMipTailSize, and
    /// pname:imageMipTailStride values are from the
    /// slink:VkSparseImageMemoryRequirements corresponding to the metadata
    /// aspect of the image, and [eq]#n# is a valid array layer index for the
    /// image,
    /// </para>
    /// <para>
    /// pname:imageMipTailStride is considered to be zero for aspects where
    /// sname:VkSparseImageMemoryRequirements::pname:formatProperties.flags contains
    /// ename:VK_SPARSE_IMAGE_FORMAT_SINGLE_MIPTAIL_BIT.
    /// </para>
    /// <para>
    /// If pname:flags does not contain
    /// ename:VK_SPARSE_MEMORY_BIND_METADATA_BIT, the binding range must: be
    /// within the range [eq]#[0,slink:VkMemoryRequirements::pname:size)#.
    /// </para>
    /// <para>
    /// .Valid Usage **** * If pname:memory is not dlink:VK_NULL_HANDLE,
    /// pname:memory and pname:memoryOffset must: match the memory requirements
    /// of the resource, as described in section
    /// &lt;&lt;resources-association&gt;&gt; * If pname:memory is not
    /// dlink:VK_NULL_HANDLE, pname:memory must: not have been created with a
    /// memory type that reports ename:VK_MEMORY_PROPERTY_LAZILY_ALLOCATED_BIT
    /// bit set * pname:size must: be greater than `0` * pname:resourceOffset
    /// must: be less than the size of the resource * pname:size must: be less
    /// than or equal to the size of the resource minus pname:resourceOffset *
    /// pname:memoryOffset must: be less than the size of pname:memory *
    /// pname:size must: be less than or equal to the size of pname:memory
    /// minus pname:memoryOffset ****
    /// </para>
    /// </summary>
    [Flags]
    public enum SparseMemoryBindFlags
    {
        /// <summary>
        /// -
        /// </summary>
        None = 0, 
        
        /// <summary>
        /// Operation binds resource metadata to memory
        /// </summary>
        Metadata = 1 << 0, 
    }
    
    /// <summary>
    /// <para>
    /// Bitmask specifying sets of stencil state for which to update the
    /// compare mask.
    /// </para>
    /// <para>
    /// .Valid Usage **** * The currently bound graphics pipeline must: have
    /// been created with the ename:VK_DYNAMIC_STATE_STENCIL_COMPARE_MASK
    /// dynamic state enabled ****
    /// </para>
    /// </summary>
    [Flags]
    public enum StencilFaceFlags
    {
        /// <summary>
        /// -
        /// </summary>
        None = 0, 
        
        /// <summary>
        /// Front face
        /// </summary>
        Front = 1 << 0, 
        
        /// <summary>
        /// Back face
        /// </summary>
        Back = 1 << 1, 
        
        /// <summary>
        /// Front and back faces
        /// </summary>
        FrontAndBack = 0x00000003, 
    }
    
    /// <summary>
    /// -
    /// </summary>
    [Flags]
    public enum SubpassDescriptionFlags
    {
        /// <summary>
        /// -
        /// </summary>
        None = 0, 
    }
    
    /// <summary>
    /// Presentation transforms supported on a device.
    /// </summary>
    [Flags]
    public enum SurfaceTransformFlags
    {
        /// <summary>
        /// -
        /// </summary>
        None = 0, 
        
        /// <summary>
        /// ename:VK_SURFACE_TRANSFORM_IDENTITY_BIT_KHR: The image content is
        /// presented without being transformed.
        /// </summary>
        Identity = 1 << 0, 
        
        /// <summary>
        /// ename:VK_SURFACE_TRANSFORM_ROTATE_90_BIT_KHR: The image content is
        /// rotated 90 degrees clockwise.
        /// </summary>
        Rotate90 = 1 << 1, 
        
        /// <summary>
        /// ename:VK_SURFACE_TRANSFORM_ROTATE_180_BIT_KHR: The image content is
        /// rotated 180 degrees clockwise.
        /// </summary>
        Rotate180 = 1 << 2, 
        
        /// <summary>
        /// ename:VK_SURFACE_TRANSFORM_ROTATE_270_BIT_KHR: The image content is
        /// rotated 270 degrees clockwise.
        /// </summary>
        Rotate270 = 1 << 3, 
        
        /// <summary>
        /// ename:VK_SURFACE_TRANSFORM_HORIZONTAL_MIRROR_BIT_KHR: The image
        /// content is mirrored horizontally.
        /// </summary>
        HorizontalMirror = 1 << 4, 
        
        /// <summary>
        /// ename:VK_SURFACE_TRANSFORM_HORIZONTAL_MIRROR_ROTATE_90_BIT_KHR: The
        /// image content is mirrored horizontally, then rotated 90 degrees
        /// clockwise.
        /// </summary>
        HorizontalMirrorRotate90 = 1 << 5, 
        
        /// <summary>
        /// ename:VK_SURFACE_TRANSFORM_HORIZONTAL_MIRROR_ROTATE_180_BIT_KHR:
        /// The image content is mirrored horizontally, then rotated 180
        /// degrees clockwise.
        /// </summary>
        HorizontalMirrorRotate180 = 1 << 6, 
        
        /// <summary>
        /// ename:VK_SURFACE_TRANSFORM_HORIZONTAL_MIRROR_ROTATE_270_BIT_KHR:
        /// The image content is mirrored horizontally, then rotated 270
        /// degrees clockwise.
        /// </summary>
        HorizontalMirrorRotate270 = 1 << 7, 
        
        /// <summary>
        /// ename:VK_SURFACE_TRANSFORM_INHERIT_BIT_KHR: The presentation
        /// transform is not specified, and is instead determined by
        /// platform-specific considerations and mechanisms outside Vulkan.
        /// </summary>
        Inherit = 1 << 8, 
    }
    
    /// <summary>
    /// -
    /// </summary>
    [Flags]
    public enum SwapchainCreateFlags
    {
        /// <summary>
        /// -
        /// </summary>
        None = 0, 
    }
    
    /// <summary>
    /// -
    /// </summary>
    [Flags]
    public enum WaylandSurfaceCreateFlags
    {
        /// <summary>
        /// -
        /// </summary>
        None = 0, 
    }
    
    /// <summary>
    /// -
    /// </summary>
    [Flags]
    public enum Win32SurfaceCreateFlags
    {
        /// <summary>
        /// -
        /// </summary>
        None = 0, 
    }
    
    /// <summary>
    /// -
    /// </summary>
    [Flags]
    public enum XcbSurfaceCreateFlags
    {
        /// <summary>
        /// -
        /// </summary>
        None = 0, 
    }
    
    /// <summary>
    /// -
    /// </summary>
    [Flags]
    public enum XlibSurfaceCreateFlags
    {
        /// <summary>
        /// -
        /// </summary>
        None = 0, 
    }
    
    /// <summary>
    /// Specify how contents of an attachment are treated at the beginning of a
    /// subpass.
    /// </summary>
    public enum AttachmentLoadOp
    {
        /// <summary>
        /// -
        /// </summary>
        Load = 0, 
        
        /// <summary>
        /// -
        /// </summary>
        Clear = 1, 
        
        /// <summary>
        /// -
        /// </summary>
        DontCare = 2, 
    }
    
    /// <summary>
    /// <para>
    /// Specify how contents of an attachment are treated at the end of a
    /// subpass.
    /// </para>
    /// <para>
    /// If the attachment uses a color format, then pname:loadOp and
    /// pname:storeOp are used, and pname:stencilLoadOp and
    /// pname:stencilStoreOp are ignored. If the format has depth and/or
    /// stencil components, pname:loadOp and pname:storeOp apply only to the
    /// depth data, while pname:stencilLoadOp and pname:stencilStoreOp define
    /// how the stencil data is handled.
    /// </para>
    /// <para>
    /// During a render pass instance, input/color attachments with color
    /// formats that have a component size of 8, 16, or 32 bits must: be
    /// represented in the attachment's format throughout the instance.
    /// Attachments with other floating- or fixed-point color formats, or with
    /// depth components may: be represented in a format with a precision
    /// higher than the attachment format, but must: be represented with the
    /// same range. When such a component is loaded via the pname:loadOp, it
    /// will be converted into an implementation-dependent format used by the
    /// render pass. Such components must: be converted from the render pass
    /// format, to the format of the attachment, before they are stored or
    /// resolved at the end of a render pass instance via pname:storeOp.
    /// Conversions occur as described in &lt;&lt;fundamentals-numerics,Numeric
    /// Representation and Computation&gt;&gt; and
    /// &lt;&lt;fundamentals-fixedconv, Fixed-Point Data Conversions&gt;&gt;.
    /// </para>
    /// <para>
    /// If pname:flags includes ename:VK_ATTACHMENT_DESCRIPTION_MAY_ALIAS_BIT,
    /// then the attachment is treated as if it shares physical memory with
    /// another attachment in the same render pass. This information limits the
    /// ability of the implementation to reorder certain operations (like
    /// layout transitions and the pname:loadOp) such that it is not improperly
    /// reordered against other uses of the same physical memory via a
    /// different attachment. This is described in more detail below.
    /// </para>
    /// <para>
    /// .Valid Usage **** * pname:finalLayout must: not be
    /// ename:VK_IMAGE_LAYOUT_UNDEFINED or ename:VK_IMAGE_LAYOUT_PREINITIALIZED
    /// ****
    /// </para>
    /// </summary>
    public enum AttachmentStoreOp
    {
        /// <summary>
        /// -
        /// </summary>
        Store = 0, 
        
        /// <summary>
        /// -
        /// </summary>
        DontCare = 1, 
    }
    
    /// <summary>
    /// <para>
    /// Framebuffer blending factors.
    /// </para>
    /// <para>
    /// The semantics of each enum value is described in the table below:
    /// </para>
    /// <para>
    /// .Blend Factors
    /// [width="100%",options="header",align="center",cols="59%,28%,13%"] |====
    /// |VkBlendFactor | RGB Blend Factors [eq]#(S~r~,S~g~,S~b~)# or
    /// [eq]#(D~r~,D~g~,D~b~)# | Alpha Blend Factor ([eq]#S~a~# or [eq]#D~a~#)
    /// |ename:VK_BLEND_FACTOR_ZERO | [eq]#(0,0,0)# | [eq]#0#
    /// |ename:VK_BLEND_FACTOR_ONE | [eq]#(1,1,1)# | [eq]#1#
    /// |ename:VK_BLEND_FACTOR_SRC_COLOR | [eq]#(R~s0~,G~s0~,B~s0~)# |
    /// [eq]#A~s0~# |ename:VK_BLEND_FACTOR_ONE_MINUS_SRC_COLOR |
    /// [eq]#(1-R~s0~,1-G~s0~,1-B~s0~)# | [eq]#1-A~s0~#
    /// |ename:VK_BLEND_FACTOR_DST_COLOR | [eq]#(R~d~,G~d~,B~d~)# | [eq]#A~d~#
    /// |ename:VK_BLEND_FACTOR_ONE_MINUS_DST_COLOR |
    /// [eq]#(1-R~d~,1-G~d~,1-B~d~)# | [eq]#1-A~d~#
    /// |ename:VK_BLEND_FACTOR_SRC_ALPHA | [eq]#(A~s0~,A~s0~,A~s0~)# |
    /// [eq]#A~s0~# |ename:VK_BLEND_FACTOR_ONE_MINUS_SRC_ALPHA |
    /// [eq]#(1-A~s0~,1-A~s0~,1-A~s0~)# | [eq]#1-A~s0~#
    /// |ename:VK_BLEND_FACTOR_DST_ALPHA | [eq]#(A~d~,A~d~,A~d~)# | [eq]#A~d~#
    /// |ename:VK_BLEND_FACTOR_ONE_MINUS_DST_ALPHA |
    /// [eq]#(1-A~d~,1-A~d~,1-A~d~)# | [eq]#1-A~d~#
    /// |ename:VK_BLEND_FACTOR_CONSTANT_COLOR | [eq]#(R~c~,G~c~,B~c~)# |
    /// [eq]#A~c~# |ename:VK_BLEND_FACTOR_ONE_MINUS_CONSTANT_COLOR |
    /// [eq]#(1-R~c~,1-G~c~,1-B~c~)# | [eq]#1-A~c~#
    /// |ename:VK_BLEND_FACTOR_CONSTANT_ALPHA | [eq]#(A~c~,A~c~,A~c~)# |
    /// [eq]#A~c~# |ename:VK_BLEND_FACTOR_ONE_MINUS_CONSTANT_ALPHA |
    /// [eq]#(1-A~c~,1-A~c~,1-A~c~)# | [eq]#1-A~c~#
    /// |ename:VK_BLEND_FACTOR_SRC_ALPHA_SATURATE | [eq]#(f,f,f)#; [eq]#f =
    /// min(A~s0~,1-A~d~)# | [eq]#1# |ename:VK_BLEND_FACTOR_SRC1_COLOR |
    /// [eq]#(R~s1~,G~s1~,B~s1~)# | [eq]#A~s1~#
    /// |ename:VK_BLEND_FACTOR_ONE_MINUS_SRC1_COLOR |
    /// [eq]#(1-R~s1~,1-G~s1~,1-B~s1~)# | [eq]#1-A~s1~#
    /// |ename:VK_BLEND_FACTOR_SRC1_ALPHA | [eq]#(A~s1~,A~s1~,A~s1~)# |
    /// [eq]#A~s1~# |ename:VK_BLEND_FACTOR_ONE_MINUS_SRC1_ALPHA |
    /// [eq]#(1-A~s1~,1-A~s1~,1-A~s1~)# | [eq]#1-A~s1~# |====
    /// </para>
    /// <para>
    /// In this table, the following conventions are used:
    /// </para>
    /// <para>
    /// * [eq]#R~s0~,G~s0~,B~s0~# and [eq]#A~s0~# represent the first source
    /// color R, G, B, and A components, respectively, for the fragment output
    /// location corresponding to the color attachment being blended. *
    /// [eq]#R~s1~,G~s1~,B~s1~# and [eq]#A~s1~# represent the second source
    /// color R, G, B, and A components, respectively, used in dual source
    /// blending modes, for the fragment output location corresponding to the
    /// color attachment being blended. * [eq]#R~d~,G~d~,B~d~# and [eq]#A~d~#
    /// represent the R, G, B, and A components of the destination color. That
    /// is, the color currently in the corresponding color attachment for this
    /// fragment/sample. * [eq]#R~c~,G~c~,B~c~# and [eq]#A~c~# represent the
    /// blend constant R, G, B, and A components, respectively.
    /// </para>
    /// </summary>
    public enum BlendFactor
    {
        /// <summary>
        /// -
        /// </summary>
        Zero = 0, 
        
        /// <summary>
        /// -
        /// </summary>
        One = 1, 
        
        /// <summary>
        /// -
        /// </summary>
        SourceColor = 2, 
        
        /// <summary>
        /// -
        /// </summary>
        OneMinusSourceColor = 3, 
        
        /// <summary>
        /// -
        /// </summary>
        DestinationColor = 4, 
        
        /// <summary>
        /// -
        /// </summary>
        OneMinusDestinationColor = 5, 
        
        /// <summary>
        /// -
        /// </summary>
        SourceAlpha = 6, 
        
        /// <summary>
        /// -
        /// </summary>
        OneMinusSourceAlpha = 7, 
        
        /// <summary>
        /// -
        /// </summary>
        DestinationAlpha = 8, 
        
        /// <summary>
        /// -
        /// </summary>
        OneMinusDestinationAlpha = 9, 
        
        /// <summary>
        /// -
        /// </summary>
        ConstantColor = 10, 
        
        /// <summary>
        /// -
        /// </summary>
        OneMinusConstantColor = 11, 
        
        /// <summary>
        /// -
        /// </summary>
        ConstantAlpha = 12, 
        
        /// <summary>
        /// -
        /// </summary>
        OneMinusConstantAlpha = 13, 
        
        /// <summary>
        /// -
        /// </summary>
        SourceAlphaSaturate = 14, 
        
        /// <summary>
        /// -
        /// </summary>
        Src1Color = 15, 
        
        /// <summary>
        /// -
        /// </summary>
        OneMinusSrc1Color = 16, 
        
        /// <summary>
        /// -
        /// </summary>
        Src1Alpha = 17, 
        
        /// <summary>
        /// -
        /// </summary>
        OneMinusSrc1Alpha = 18, 
    }
    
    /// <summary>
    /// <para>
    /// Framebuffer blending operations.
    /// </para>
    /// <para>
    /// &lt;&lt;&lt;
    /// </para>
    /// <para>
    /// The semantics of each enum value is described in the table below:
    /// </para>
    /// <para>
    /// .Blend Operations
    /// [width="100%",cols="45%,30%,25%",options="header",align="center"] |====
    /// |VkBlendOp | RGB Components | Alpha Component
    /// </para>
    /// <para>
    /// |ename:VK_BLEND_OP_ADD | [eq]#R = R~s0~ {times} S~r~ + R~d~ {times}
    /// D~r~# + [eq]#G = G~s0~ {times} S~g~ + G~d~ {times} D~g~# + [eq]#B =
    /// B~s0~ {times} S~b~ + B~d~ {times} D~b~# | [eq]#A = A~s0~ {times} S~a~ +
    /// A~d~ {times} D~a~#
    /// </para>
    /// <para>
    /// |ename:VK_BLEND_OP_SUBTRACT | [eq]#R = R~s0~ {times} S~r~ - R~d~
    /// {times} D~r~# + [eq]#G = G~s0~ {times} S~g~ - G~d~ {times} D~g~# +
    /// [eq]#B = B~s0~ {times} S~b~ - B~d~ {times} D~b~# | [eq]#A = A~s0~
    /// {times} S~a~ - A~d~ {times} D~a~#
    /// </para>
    /// <para>
    /// |ename:VK_BLEND_OP_REVERSE_SUBTRACT | [eq]#R = R~d~ {times} D~r~ -
    /// R~s0~ {times} S~r~# + [eq]#G = G~d~ {times} D~g~ - G~s0~ {times} S~g~#
    /// + [eq]#B = B~d~ {times} D~b~ - B~s0~ {times} S~b~# | [eq]#A = A~d~
    /// {times} D~a~ - A~s0~ {times} S~a~#
    /// </para>
    /// <para>
    /// |ename:VK_BLEND_OP_MIN | [eq]#R = min(R~s0~,R~d~)# + [eq]#G =
    /// min(G~s0~,G~d~)# + [eq]#B = min(B~s0~,B~d~)# | [eq]#A =
    /// min(A~s0~,A~d~)#
    /// </para>
    /// <para>
    /// |ename:VK_BLEND_OP_MAX | [eq]#R = max(R~s0~,R~d~)# + [eq]#G =
    /// max(G~s0~,G~d~)# + [eq]#B = max(B~s0~,B~d~)# | [eq]#A =
    /// max(A~s0~,A~d~)# |====
    /// </para>
    /// <para>
    /// In this table, the following conventions are used:
    /// </para>
    /// <para>
    /// * [eq]#R~s0~, G~s0~, B~s0~# and [eq]#A~s0~# represent the first source
    /// color R, G, B, and A components, respectively. * [eq]#R~d~, G~d~, B~d~#
    /// and [eq]#A~d~# represent the R, G, B, and A components of the
    /// destination color. That is, the color currently in the corresponding
    /// color attachment for this fragment/sample. * [eq]#S~r~, S~g~, S~b~# and
    /// [eq]#S~a~# represent the source blend factor R, G, B, and A components,
    /// respectively. * [eq]#D~r~, D~g~, D~b~# and [eq]#D~a~# represent the
    /// destination blend factor R, G, B, and A components, respectively.
    /// </para>
    /// <para>
    /// The blending operation produces a new set of values [eq]#R, G, B# and
    /// [eq]#A#, which are written to the framebuffer attachment. If blending
    /// is not enabled for this attachment, then [eq]#R, G, B# and [eq]#A# are
    /// assigned [eq]#R~s0~, G~s0~, B~s0~# and [eq]#A~s0~#, respectively.
    /// </para>
    /// <para>
    /// If the color attachment is fixed-point, the components of the source
    /// and destination values and blend factors are each clamped to
    /// [eq]#[0,1]# or [eq]#[-1,1]# respectively for an unsigned normalized or
    /// signed normalized color attachment prior to evaluating the blend
    /// operations. If the color attachment is floating-point, no clamping
    /// occurs.
    /// </para>
    /// </summary>
    public enum BlendOp
    {
        /// <summary>
        /// -
        /// </summary>
        Add = 0, 
        
        /// <summary>
        /// -
        /// </summary>
        Subtract = 1, 
        
        /// <summary>
        /// -
        /// </summary>
        ReverseSubtract = 2, 
        
        /// <summary>
        /// -
        /// </summary>
        Min = 3, 
        
        /// <summary>
        /// -
        /// </summary>
        Max = 4, 
    }
    
    /// <summary>
    /// <para>
    /// Specify border color used for texture lookups.
    /// </para>
    /// <para>
    /// [NOTE] .Mapping of OpenGL to Vulkan filter modes ==================
    /// pname:magFilter values of ename:VK_FILTER_NEAREST and
    /// ename:VK_FILTER_LINEAR directly correspond to code:GL_NEAREST and
    /// code:GL_LINEAR magnification filters. pname:minFilter and
    /// pname:mipmapMode combine to correspond to the similarly named OpenGL
    /// minification filter of code:GL_minFilter_MIPMAP_mipmapMode (e.g.
    /// pname:minFilter of ename:VK_FILTER_LINEAR and pname:mipmapMode of
    /// ename:VK_SAMPLER_MIPMAP_MODE_NEAREST correspond to
    /// code:GL_LINEAR_MIPMAP_NEAREST).
    /// </para>
    /// <para>
    /// There are no Vulkan filter modes that directly correspond to OpenGL
    /// minification filters of code:GL_LINEAR or code:GL_NEAREST, but they
    /// can: be emulated using ename:VK_SAMPLER_MIPMAP_MODE_NEAREST,
    /// pname:minLod = 0, and pname:maxLod = 0.25, and using pname:minFilter =
    /// ename:VK_FILTER_LINEAR or pname:minFilter = ename:VK_FILTER_NEAREST,
    /// respectively.
    /// </para>
    /// <para>
    /// Note that using a pname:maxLod of zero would cause
    /// &lt;&lt;textures-texel-filtering,magnification&gt;&gt; to always be
    /// performed, and the pname:magFilter to always be used. This is valid,
    /// just not an exact match for OpenGL behavior. Clamping the maximum LOD
    /// to 0.25 allows the [eq]#{lambda}# value to be non-zero and minification
    /// to be performed, while still always rounding down to the base level. If
    /// the pname:minFilter and pname:magFilter are equal, then using a
    /// pname:maxLod of zero also works. ==================
    /// </para>
    /// <para>
    /// pname:addressModeU, pname:addressModeV, and pname:addressModeW must:
    /// each have one of the following values:
    /// </para>
    /// </summary>
    public enum BorderColor
    {
        /// <summary>
        /// -
        /// </summary>
        FloatTransparentBlack = 0, 
        
        /// <summary>
        /// -
        /// </summary>
        IntTransparentBlack = 1, 
        
        /// <summary>
        /// -
        /// </summary>
        FloatOpaqueBlack = 2, 
        
        /// <summary>
        /// -
        /// </summary>
        IntOpaqueBlack = 3, 
        
        /// <summary>
        /// -
        /// </summary>
        FloatOpaqueWhite = 4, 
        
        /// <summary>
        /// -
        /// </summary>
        IntOpaqueWhite = 5, 
    }
    
    /// <summary>
    /// <para>
    /// Supported color space of the presentation engine.
    /// </para>
    /// <para>
    /// [NOTE] .Note ==== If pname:pSurfaceFormats includes just one entry,
    /// whose value for pname:format is ename:VK_FORMAT_UNDEFINED,
    /// pname:surface has no preferred format. In this case, the application
    /// can: use any valid ename:VkFormat value. ====
    /// </para>
    /// <para>
    /// [NOTE] .Note ==== In the initial release of the +VK_KHR_surface+ and
    /// +VK_KHR_swapchain+ extensions, the token
    /// ename:VK_COLORSPACE_SRGB_NONLINEAR_KHR was used. Starting in the May
    /// 13, 2016 updates to the extension branches, matching release 1.0.13 of
    /// the core API specification, ename:VK_COLOR_SPACE_SRGB_NONLINEAR_KHR is
    /// used instead for consistency with Vulkan naming rules. The older enum
    /// is still available for backwards compatibility. ====
    /// </para>
    /// </summary>
    public enum ColorSpace
    {
        /// <summary>
        /// ename:VK_COLOR_SPACE_SRGB_NONLINEAR_KHR: The presentation engine
        /// supports the sRGB color space.
        /// </summary>
        SrgbNonlinear = 0, 
    }
    
    /// <summary>
    /// <para>
    /// Structure specifying a command buffer level.
    /// </para>
    /// <para>
    /// .Valid Usage **** * pname:commandBufferCount must: be greater than `0`
    /// ****
    /// </para>
    /// </summary>
    public enum CommandBufferLevel
    {
        /// <summary>
        /// -
        /// </summary>
        Primary = 0, 
        
        /// <summary>
        /// -
        /// </summary>
        Secondary = 1, 
    }
    
    /// <summary>
    /// Stencil comparison function.
    /// </summary>
    public enum CompareOp
    {
        /// <summary>
        /// ename:VK_COMPARE_OP_NEVER: the test never passes.
        /// </summary>
        Never = 0, 
        
        /// <summary>
        /// ename:VK_COMPARE_OP_LESS: the test passes when [eq]#R &lt; S#.
        /// </summary>
        Less = 1, 
        
        /// <summary>
        /// ename:VK_COMPARE_OP_EQUAL: the test passes when [eq]#R = S#.
        /// </summary>
        Equal = 2, 
        
        /// <summary>
        /// ename:VK_COMPARE_OP_LESS_OR_EQUAL: the test passes when [eq]#R
        /// {leq} S#.
        /// </summary>
        LessOrEqual = 3, 
        
        /// <summary>
        /// ename:VK_COMPARE_OP_GREATER: the test passes when [eq]#R &gt; S#.
        /// </summary>
        Greater = 4, 
        
        /// <summary>
        /// ename:VK_COMPARE_OP_NOT_EQUAL: the test passes when [eq]#R {neq}
        /// S#.
        /// </summary>
        NotEqual = 5, 
        
        /// <summary>
        /// ename:VK_COMPARE_OP_GREATER_OR_EQUAL: the test passes when [eq]#R
        /// {geq} S#.
        /// </summary>
        GreaterOrEqual = 6, 
        
        /// <summary>
        /// ename:VK_COMPARE_OP_ALWAYS: the test always passes.
        /// </summary>
        Always = 7, 
    }
    
    /// <summary>
    /// <para>
    /// Specify how a component is swizzled.
    /// </para>
    /// <para>
    /// Setting the identity swizzle on a component is equivalent to setting
    /// the identity mapping on that component. That is:
    /// </para>
    /// <para>
    /// .Component Mappings Equivalent To ename:VK_COMPONENT_SWIZZLE_IDENTITY
    /// [options="header"] |==== | Component | Identity Mapping |
    /// pname:components.r | ename:VK_COMPONENT_SWIZZLE_R | pname:components.g
    /// | ename:VK_COMPONENT_SWIZZLE_G | pname:components.b |
    /// ename:VK_COMPONENT_SWIZZLE_B | pname:components.a |
    /// ename:VK_COMPONENT_SWIZZLE_A |====
    /// </para>
    /// </summary>
    public enum ComponentSwizzle
    {
        /// <summary>
        /// ename:VK_COMPONENT_SWIZZLE_IDENTITY: the component is set to the
        /// identity swizzle.
        /// </summary>
        Identity = 0, 
        
        /// <summary>
        /// ename:VK_COMPONENT_SWIZZLE_ZERO: the component is set to zero.
        /// </summary>
        Zero = 1, 
        
        /// <summary>
        /// ename:VK_COMPONENT_SWIZZLE_ONE: the component is set to either 1 or
        /// 1.0 depending on whether the type of the image view format is
        /// integer or floating-point respectively, as determined by the
        /// &lt;&lt;features-formats-definition,Format Definition&gt;&gt;
        /// section for each elink:VkFormat.
        /// </summary>
        One = 2, 
        
        /// <summary>
        /// ename:VK_COMPONENT_SWIZZLE_R: the component is set to the value of
        /// the R component of the image.
        /// </summary>
        R = 3, 
        
        /// <summary>
        /// ename:VK_COMPONENT_SWIZZLE_G: the component is set to the value of
        /// the G component of the image.
        /// </summary>
        G = 4, 
        
        /// <summary>
        /// ename:VK_COMPONENT_SWIZZLE_B: the component is set to the value of
        /// the B component of the image.
        /// </summary>
        B = 5, 
        
        /// <summary>
        /// ename:VK_COMPONENT_SWIZZLE_A: the component is set to the value of
        /// the A component of the image.
        /// </summary>
        A = 6, 
    }
    
    /// <summary>
    /// <para>
    /// Unknown VK_EXT_debug_report enumeration type.
    /// </para>
    /// <para>
    /// [NOTE] .Note ==== The +VK_EXT_debug_report+ extension defines the
    /// elink:VkDebugReportErrorEXT enumerant type, but does not currently
    /// explain what the enumeration is used for. It is included here for
    /// completeness. ====
    /// </para>
    /// </summary>
    public enum DebugReportError
    {
        /// <summary>
        /// -
        /// </summary>
        None = 0, 
        
        /// <summary>
        /// -
        /// </summary>
        CallbackRef = 1, 
    }
    
    /// <summary>
    /// <para>
    /// Specify the type of an object handle.
    /// </para>
    /// <para>
    /// === Command Buffer Markers
    /// </para>
    /// <para>
    /// Typical Vulkan applications will submit many command buffers in each
    /// frame, with each command buffer containing a large number of individual
    /// commands. Being able to logically annotate regions of command buffers
    /// that belong together as well as hierarchically subdivide the frame is
    /// important to a developer's ability to navigate the commands viewed
    /// holistically.
    /// </para>
    /// <para>
    /// The marker commands fname:vkCmdDebugMarkerBeginEXT and
    /// fname:vkCmdDebugMarkerEndEXT define regions of a series of commands
    /// that are grouped together, and they can be nested to create a
    /// hierarchy. The fname:vkCmdDebugMarkerInsertEXT command allows insertion
    /// of a single label within a command buffer.
    /// </para>
    /// </summary>
    public enum DebugReportObjectType
    {
        /// <summary>
        /// ename:VK_DEBUG_REPORT_OBJECT_TYPE_UNKNOWN_EXT is an unknown object.
        /// </summary>
        Unknown = 0, 
        
        /// <summary>
        /// ename:VK_DEBUG_REPORT_OBJECT_TYPE_INSTANCE_EXT is a
        /// sname:VkInstance.
        /// </summary>
        Instance = 1, 
        
        /// <summary>
        /// ename:VK_DEBUG_REPORT_OBJECT_TYPE_PHYSICAL_DEVICE_EXT is a
        /// sname:VkPhysicalDevice.
        /// </summary>
        PhysicalDevice = 2, 
        
        /// <summary>
        /// ename:VK_DEBUG_REPORT_OBJECT_TYPE_DEVICE_EXT is a sname:VkDevice.
        /// </summary>
        Device = 3, 
        
        /// <summary>
        /// ename:VK_DEBUG_REPORT_OBJECT_TYPE_QUEUE_EXT is a sname:VkQueue.
        /// </summary>
        Queue = 4, 
        
        /// <summary>
        /// ename:VK_DEBUG_REPORT_OBJECT_TYPE_SEMAPHORE_EXT is a
        /// sname:VkSemaphore.
        /// </summary>
        Semaphore = 5, 
        
        /// <summary>
        /// ename:VK_DEBUG_REPORT_OBJECT_TYPE_COMMAND_BUFFER_EXT is a
        /// sname:VkCommandBuffer.
        /// </summary>
        CommandBuffer = 6, 
        
        /// <summary>
        /// ename:VK_DEBUG_REPORT_OBJECT_TYPE_FENCE_EXT is a sname:VkFence.
        /// </summary>
        Fence = 7, 
        
        /// <summary>
        /// ename:VK_DEBUG_REPORT_OBJECT_TYPE_DEVICE_MEMORY_EXT is a
        /// sname:VkDeviceMemory.
        /// </summary>
        DeviceMemory = 8, 
        
        /// <summary>
        /// ename:VK_DEBUG_REPORT_OBJECT_TYPE_BUFFER_EXT is a sname:VkBuffer.
        /// </summary>
        Buffer = 9, 
        
        /// <summary>
        /// ename:VK_DEBUG_REPORT_OBJECT_TYPE_IMAGE_EXT is a sname:VkImage.
        /// </summary>
        Image = 10, 
        
        /// <summary>
        /// ename:VK_DEBUG_REPORT_OBJECT_TYPE_EVENT_EXT is a sname:VkEvent.
        /// </summary>
        Event = 11, 
        
        /// <summary>
        /// ename:VK_DEBUG_REPORT_OBJECT_TYPE_QUERY_POOL_EXT is a
        /// sname:VkQueryPool.
        /// </summary>
        QueryPool = 12, 
        
        /// <summary>
        /// ename:VK_DEBUG_REPORT_OBJECT_TYPE_BUFFER_VIEW_EXT is a
        /// sname:VkBufferView.
        /// </summary>
        BufferView = 13, 
        
        /// <summary>
        /// ename:VK_DEBUG_REPORT_OBJECT_TYPE_IMAGE_VIEW_EXT is a
        /// sname:VkImageView.
        /// </summary>
        ImageView = 14, 
        
        /// <summary>
        /// ename:VK_DEBUG_REPORT_OBJECT_TYPE_SHADER_MODULE_EXT is a
        /// sname:VkShaderModule.
        /// </summary>
        ShaderModule = 15, 
        
        /// <summary>
        /// ename:VK_DEBUG_REPORT_OBJECT_TYPE_PIPELINE_CACHE_EXT is a
        /// sname:VkPipelineCache.
        /// </summary>
        PipelineCache = 16, 
        
        /// <summary>
        /// ename:VK_DEBUG_REPORT_OBJECT_TYPE_PIPELINE_LAYOUT_EXT is a
        /// sname:VkPipelineLayout.
        /// </summary>
        PipelineLayout = 17, 
        
        /// <summary>
        /// ename:VK_DEBUG_REPORT_OBJECT_TYPE_RENDER_PASS_EXT is a
        /// sname:VkRenderPass.
        /// </summary>
        RenderPass = 18, 
        
        /// <summary>
        /// ename:VK_DEBUG_REPORT_OBJECT_TYPE_PIPELINE_EXT is a
        /// sname:VkPipeline.
        /// </summary>
        Pipeline = 19, 
        
        /// <summary>
        /// ename:VK_DEBUG_REPORT_OBJECT_TYPE_DESCRIPTOR_SET_LAYOUT_EXT is a
        /// sname:VkDescriptorSetLayout.
        /// </summary>
        DescriptorSetLayout = 20, 
        
        /// <summary>
        /// ename:VK_DEBUG_REPORT_OBJECT_TYPE_SAMPLER_EXT is a sname:VkSampler.
        /// </summary>
        Sampler = 21, 
        
        /// <summary>
        /// ename:VK_DEBUG_REPORT_OBJECT_TYPE_DESCRIPTOR_POOL_EXT is a
        /// sname:VkDescriptorPool.
        /// </summary>
        DescriptorPool = 22, 
        
        /// <summary>
        /// ename:VK_DEBUG_REPORT_OBJECT_TYPE_DESCRIPTOR_SET_EXT is a
        /// sname:VkDescriptorSet.
        /// </summary>
        DescriptorSet = 23, 
        
        /// <summary>
        /// ename:VK_DEBUG_REPORT_OBJECT_TYPE_FRAMEBUFFER_EXT is a
        /// sname:VkFramebuffer.
        /// </summary>
        Framebuffer = 24, 
        
        /// <summary>
        /// ename:VK_DEBUG_REPORT_OBJECT_TYPE_COMMAND_POOL_EXT is a
        /// sname:VkCommandPool.
        /// </summary>
        CommandPool = 25, 
        
        /// <summary>
        /// ename:VK_DEBUG_REPORT_OBJECT_TYPE_SURFACE_KHR_EXT is a
        /// sname:VkSurfaceKHR.
        /// </summary>
        SurfaceKhr = 26, 
        
        /// <summary>
        /// ename:VK_DEBUG_REPORT_OBJECT_TYPE_SWAPCHAIN_KHR_EXT is a
        /// sname:VkSwapchainKHR.
        /// </summary>
        SwapchainKhr = 27, 
        
        /// <summary>
        /// ename:VK_DEBUG_REPORT_OBJECT_TYPE_DEBUG_REPORT_EXT is a
        /// sname:VkDebugReportCallbackEXT.
        /// </summary>
        DebugReport = 28, 
    }
    
    /// <summary>
    /// <para>
    /// Specifies the type of a descriptor in a descriptor set.
    /// </para>
    /// <para>
    /// If pname:descriptorType is ename:VK_DESCRIPTOR_TYPE_UNIFORM_BUFFER,
    /// ename:VK_DESCRIPTOR_TYPE_STORAGE_BUFFER, ename:VK_DESCRIPTOR_TYPE_UNIFORM_BUFFER_DYNAMIC,
    /// or ename:VK_DESCRIPTOR_TYPE_STORAGE_BUFFER_DYNAMIC, the elements of the
    /// slink:VkWriteDescriptorSet::pname:pBufferInfo array of
    /// slink:VkDescriptorBufferInfo structures will be used to update the
    /// descriptors, and other arrays will be ignored.
    /// </para>
    /// <para>
    /// If pname:descriptorType is
    /// ename:VK_DESCRIPTOR_TYPE_UNIFORM_TEXEL_BUFFER or
    /// ename:VK_DESCRIPTOR_TYPE_STORAGE_TEXEL_BUFFER, the
    /// slink:VkWriteDescriptorSet::pname:pTexelBufferView array will be used
    /// to update the descriptors, and other arrays will be ignored.
    /// </para>
    /// <para>
    /// If pname:descriptorType is ename:VK_DESCRIPTOR_TYPE_SAMPLER,
    /// ename:VK_DESCRIPTOR_TYPE_COMBINED_IMAGE_SAMPLER, ename:VK_DESCRIPTOR_TYPE_SAMPLED_IMAGE,
    /// ename:VK_DESCRIPTOR_TYPE_STORAGE_IMAGE, or
    /// ename:VK_DESCRIPTOR_TYPE_INPUT_ATTACHMENT, the elements of the
    /// slink:VkWriteDescriptorSet::pname:pImageInfo array of
    /// slink:VkDescriptorImageInfo structures will be used to update the
    /// descriptors, and other arrays will be ignored.
    /// </para>
    /// </summary>
    public enum DescriptorType
    {
        /// <summary>
        /// -
        /// </summary>
        Sampler = 0, 
        
        /// <summary>
        /// -
        /// </summary>
        CombinedImageSampler = 1, 
        
        /// <summary>
        /// -
        /// </summary>
        SampledImage = 2, 
        
        /// <summary>
        /// -
        /// </summary>
        StorageImage = 3, 
        
        /// <summary>
        /// -
        /// </summary>
        UniformTexelBuffer = 4, 
        
        /// <summary>
        /// -
        /// </summary>
        StorageTexelBuffer = 5, 
        
        /// <summary>
        /// -
        /// </summary>
        UniformBuffer = 6, 
        
        /// <summary>
        /// -
        /// </summary>
        StorageBuffer = 7, 
        
        /// <summary>
        /// -
        /// </summary>
        UniformBufferDynamic = 8, 
        
        /// <summary>
        /// -
        /// </summary>
        StorageBufferDynamic = 9, 
        
        /// <summary>
        /// -
        /// </summary>
        InputAttachment = 10, 
    }
    
    /// <summary>
    /// Indicate which dynamic state is taken from dynamic state commands.
    /// </summary>
    public enum DynamicState
    {
        /// <summary>
        /// ename:VK_DYNAMIC_STATE_VIEWPORT indicates that the pname:pViewports
        /// state in sname:VkPipelineViewportStateCreateInfo will be ignored
        /// and must: be set dynamically with flink:vkCmdSetViewport before any
        /// draw commands. The number of viewports used by a pipeline is still
        /// specified by the pname:viewportCount member of
        /// sname:VkPipelineViewportStateCreateInfo.
        /// </summary>
        Viewport = 0, 
        
        /// <summary>
        /// ename:VK_DYNAMIC_STATE_SCISSOR indicates that the pname:pScissors
        /// state in sname:VkPipelineViewportStateCreateInfo will be ignored
        /// and must: be set dynamically with flink:vkCmdSetScissor before any
        /// draw commands. The number of scissor rectangles used by a pipeline
        /// is still specified by the pname:scissorCount member of
        /// sname:VkPipelineViewportStateCreateInfo.
        /// </summary>
        Scissor = 1, 
        
        /// <summary>
        /// ename:VK_DYNAMIC_STATE_LINE_WIDTH indicates that the
        /// pname:lineWidth state in
        /// sname:VkPipelineRasterizationStateCreateInfo will be ignored and
        /// must: be set dynamically with flink:vkCmdSetLineWidth before any
        /// draw commands that generate line primitives for the rasterizer.
        /// </summary>
        LineWidth = 2, 
        
        /// <summary>
        /// ename:VK_DYNAMIC_STATE_DEPTH_BIAS indicates that the
        /// pname:depthBiasConstantFactor, pname:depthBiasClamp and
        /// pname:depthBiasSlopeFactor states in
        /// sname:VkPipelineRasterizationStateCreateInfo will be ignored and
        /// must: be set dynamically with flink:vkCmdSetDepthBias before any
        /// draws are performed with pname:depthBiasEnable in
        /// sname:VkPipelineRasterizationStateCreateInfo set to ename:VK_TRUE.
        /// </summary>
        DepthBias = 3, 
        
        /// <summary>
        /// ename:VK_DYNAMIC_STATE_BLEND_CONSTANTS indicates that the
        /// pname:blendConstants state in
        /// sname:VkPipelineColorBlendStateCreateInfo will be ignored and must:
        /// be set dynamically with flink:vkCmdSetBlendConstants before any
        /// draws are performed with a pipeline state with
        /// sname:VkPipelineColorBlendAttachmentState member pname:blendEnable
        /// set to ename:VK_TRUE and any of the blend functions using a
        /// constant blend color.
        /// </summary>
        BlendConstants = 4, 
        
        /// <summary>
        /// ename:VK_DYNAMIC_STATE_DEPTH_BOUNDS indicates that the
        /// pname:minDepthBounds and pname:maxDepthBounds states of
        /// slink:VkPipelineDepthStencilStateCreateInfo will be ignored and
        /// must: be set dynamically with flink:vkCmdSetDepthBounds before any
        /// draws are performed with a pipeline state with
        /// sname:VkPipelineDepthStencilStateCreateInfo member
        /// pname:depthBoundsTestEnable set to ename:VK_TRUE.
        /// </summary>
        DepthBounds = 5, 
        
        /// <summary>
        /// ename:VK_DYNAMIC_STATE_STENCIL_COMPARE_MASK indicates that the
        /// pname:compareMask state in
        /// sname:VkPipelineDepthStencilStateCreateInfo for both pname:front
        /// and pname:back will be ignored and must: be set dynamically with
        /// flink:vkCmdSetStencilCompareMask before any draws are performed
        /// with a pipeline state with
        /// sname:VkPipelineDepthStencilStateCreateInfo member
        /// pname:stencilTestEnable set to ename:VK_TRUE
        /// </summary>
        StencilCompareMask = 6, 
        
        /// <summary>
        /// ename:VK_DYNAMIC_STATE_STENCIL_WRITE_MASK indicates that the
        /// pname:writeMask state in
        /// sname:VkPipelineDepthStencilStateCreateInfo for both pname:front
        /// and pname:back will be ignored and must: be set dynamically with
        /// flink:vkCmdSetStencilWriteMask before any draws are performed with
        /// a pipeline state with sname:VkPipelineDepthStencilStateCreateInfo
        /// member pname:stencilTestEnable set to ename:VK_TRUE
        /// </summary>
        StencilWriteMask = 7, 
        
        /// <summary>
        /// ename:VK_DYNAMIC_STATE_STENCIL_REFERENCE indicates that the
        /// pname:reference state in
        /// sname:VkPipelineDepthStencilStateCreateInfo for both pname:front
        /// and pname:back will be ignored and must: be set dynamically with
        /// flink:vkCmdSetStencilReference before any draws are performed with
        /// a pipeline state with sname:VkPipelineDepthStencilStateCreateInfo
        /// member pname:stencilTestEnable set to ename:VK_TRUE
        /// </summary>
        StencilReference = 8, 
    }
    
    /// <summary>
    /// Specify filters used for texture lookups.
    /// </summary>
    public enum Filter
    {
        /// <summary>
        /// -
        /// </summary>
        Nearest = 0, 
        
        /// <summary>
        /// -
        /// </summary>
        Linear = 1, 
        
        /// <summary>
        /// -
        /// </summary>
        CubicImg = 1000015000, 
    }
    
    /// <summary>
    /// Available image formats.
    /// </summary>
    public enum Format
    {
        /// <summary>
        /// ename:VK_FORMAT_UNDEFINED:: The format is not specified.
        /// </summary>
        Undefined = 0, 
        
        /// <summary>
        /// ename:VK_FORMAT_R4G4_UNORM_PACK8:: A two-component, 8-bit packed
        /// unsigned normalized format that has a 4-bit R component in bits
        /// 4..7, and a 4-bit G component in bits 0..3.
        /// </summary>
        R4G4UNormPack8 = 1, 
        
        /// <summary>
        /// ename:VK_FORMAT_R4G4B4A4_UNORM_PACK16:: A four-component, 16-bit
        /// packed unsigned normalized format that has a 4-bit R component in
        /// bits 12..15, a 4-bit G component in bits 8..11, a 4-bit B component
        /// in bits 4..7, and a 4-bit A component in bits 0..3.
        /// </summary>
        R4G4B4A4UNormPack16 = 2, 
        
        /// <summary>
        /// ename:VK_FORMAT_B4G4R4A4_UNORM_PACK16:: A four-component, 16-bit
        /// packed unsigned normalized format that has a 4-bit B component in
        /// bits 12..15, a 4-bit G component in bits 8..11, a 4-bit R component
        /// in bits 4..7, and a 4-bit A component in bits 0..3.
        /// </summary>
        B4G4R4A4UNormPack16 = 3, 
        
        /// <summary>
        /// ename:VK_FORMAT_R5G6B5_UNORM_PACK16:: A three-component, 16-bit
        /// packed unsigned normalized format that has a 5-bit R component in
        /// bits 11..15, a 6-bit G component in bits 5..10, and a 5-bit B
        /// component in bits 0..4.
        /// </summary>
        R5G6B5UNormPack16 = 4, 
        
        /// <summary>
        /// ename:VK_FORMAT_B5G6R5_UNORM_PACK16:: A three-component, 16-bit
        /// packed unsigned normalized format that has a 5-bit B component in
        /// bits 11..15, a 6-bit G component in bits 5..10, and a 5-bit R
        /// component in bits 0..4.
        /// </summary>
        B5G6R5UNormPack16 = 5, 
        
        /// <summary>
        /// ename:VK_FORMAT_R5G5B5A1_UNORM_PACK16:: A four-component, 16-bit
        /// packed unsigned normalized format that has a 5-bit R component in
        /// bits 11..15, a 5-bit G component in bits 6..10, a 5-bit B component
        /// in bits 1..5, and a 1-bit A component in bit 0.
        /// </summary>
        R5G5B5A1UNormPack16 = 6, 
        
        /// <summary>
        /// ename:VK_FORMAT_B5G5R5A1_UNORM_PACK16:: A four-component, 16-bit
        /// packed unsigned normalized format that has a 5-bit B component in
        /// bits 11..15, a 5-bit G component in bits 6..10, a 5-bit R component
        /// in bits 1..5, and a 1-bit A component in bit 0.
        /// </summary>
        B5G5R5A1UNormPack16 = 7, 
        
        /// <summary>
        /// ename:VK_FORMAT_A1R5G5B5_UNORM_PACK16:: A four-component, 16-bit
        /// packed unsigned normalized format that has a 1-bit A component in
        /// bit 15, a 5-bit R component in bits 10..14, a 5-bit G component in
        /// bits 5..9, and a 5-bit B component in bits 0..4.
        /// </summary>
        A1R5G5B5UNormPack16 = 8, 
        
        /// <summary>
        /// ename:VK_FORMAT_R8_UNORM:: A one-component, 8-bit unsigned
        /// normalized format that has a single 8-bit R component.
        /// </summary>
        R8UNorm = 9, 
        
        /// <summary>
        /// ename:VK_FORMAT_R8_SNORM:: A one-component, 8-bit signed normalized
        /// format that has a single 8-bit R component.
        /// </summary>
        R8SNorm = 10, 
        
        /// <summary>
        /// ename:VK_FORMAT_R8_USCALED:: A one-component, 8-bit unsigned scaled
        /// integer format that has a single 8-bit R component.
        /// </summary>
        R8UScaled = 11, 
        
        /// <summary>
        /// ename:VK_FORMAT_R8_SSCALED:: A one-component, 8-bit signed scaled
        /// integer format that has a single 8-bit R component.
        /// </summary>
        R8SScaled = 12, 
        
        /// <summary>
        /// ename:VK_FORMAT_R8_UINT:: A one-component, 8-bit unsigned integer
        /// format that has a single 8-bit R component.
        /// </summary>
        R8UInt = 13, 
        
        /// <summary>
        /// ename:VK_FORMAT_R8_SINT:: A one-component, 8-bit signed integer
        /// format that has a single 8-bit R component.
        /// </summary>
        R8SInt = 14, 
        
        /// <summary>
        /// ename:VK_FORMAT_R8_SRGB:: A one-component, 8-bit unsigned
        /// normalized format that has a single 8-bit R component stored with
        /// sRGB nonlinear encoding.
        /// </summary>
        R8Srgb = 15, 
        
        /// <summary>
        /// ename:VK_FORMAT_R8G8_UNORM:: A two-component, 16-bit unsigned
        /// normalized format that has an 8-bit R component in byte 0, and an
        /// 8-bit G component in byte 1.
        /// </summary>
        R8G8UNorm = 16, 
        
        /// <summary>
        /// ename:VK_FORMAT_R8G8_SNORM:: A two-component, 16-bit signed
        /// normalized format that has an 8-bit R component in byte 0, and an
        /// 8-bit G component in byte 1.
        /// </summary>
        R8G8SNorm = 17, 
        
        /// <summary>
        /// ename:VK_FORMAT_R8G8_USCALED:: A two-component, 16-bit unsigned
        /// scaled integer format that has an 8-bit R component in byte 0, and
        /// an 8-bit G component in byte 1.
        /// </summary>
        R8G8UScaled = 18, 
        
        /// <summary>
        /// ename:VK_FORMAT_R8G8_SSCALED:: A two-component, 16-bit signed
        /// scaled integer format that has an 8-bit R component in byte 0, and
        /// an 8-bit G component in byte 1.
        /// </summary>
        R8G8SScaled = 19, 
        
        /// <summary>
        /// ename:VK_FORMAT_R8G8_UINT:: A two-component, 16-bit unsigned
        /// integer format that has an 8-bit R component in byte 0, and an
        /// 8-bit G component in byte 1.
        /// </summary>
        R8G8UInt = 20, 
        
        /// <summary>
        /// ename:VK_FORMAT_R8G8_SINT:: A two-component, 16-bit signed integer
        /// format that has an 8-bit R component in byte 0, and an 8-bit G
        /// component in byte 1.
        /// </summary>
        R8G8SInt = 21, 
        
        /// <summary>
        /// ename:VK_FORMAT_R8G8_SRGB:: A two-component, 16-bit unsigned
        /// normalized format that has an 8-bit R component stored with sRGB
        /// nonlinear encoding in byte 0, and an 8-bit G component stored with
        /// sRGB nonlinear encoding in byte 1.
        /// </summary>
        R8G8Srgb = 22, 
        
        /// <summary>
        /// ename:VK_FORMAT_R8G8B8_UNORM:: A three-component, 24-bit unsigned
        /// normalized format that has an 8-bit R component in byte 0, an 8-bit
        /// G component in byte 1, and an 8-bit B component in byte 2.
        /// </summary>
        R8G8B8UNorm = 23, 
        
        /// <summary>
        /// ename:VK_FORMAT_R8G8B8_SNORM:: A three-component, 24-bit signed
        /// normalized format that has an 8-bit R component in byte 0, an 8-bit
        /// G component in byte 1, and an 8-bit B component in byte 2.
        /// </summary>
        R8G8B8SNorm = 24, 
        
        /// <summary>
        /// ename:VK_FORMAT_R8G8B8_USCALED:: A three-component, 24-bit unsigned
        /// scaled format that has an 8-bit R component in byte 0, an 8-bit G
        /// component in byte 1, and an 8-bit B component in byte 2.
        /// </summary>
        R8G8B8UScaled = 25, 
        
        /// <summary>
        /// ename:VK_FORMAT_R8G8B8_SSCALED:: A three-component, 24-bit signed
        /// scaled format that has an 8-bit R component in byte 0, an 8-bit G
        /// component in byte 1, and an 8-bit B component in byte 2.
        /// </summary>
        R8G8B8SScaled = 26, 
        
        /// <summary>
        /// ename:VK_FORMAT_R8G8B8_UINT:: A three-component, 24-bit unsigned
        /// integer format that has an 8-bit R component in byte 0, an 8-bit G
        /// component in byte 1, and an 8-bit B component in byte 2.
        /// </summary>
        R8G8B8UInt = 27, 
        
        /// <summary>
        /// ename:VK_FORMAT_R8G8B8_SINT:: A three-component, 24-bit signed
        /// integer format that has an 8-bit R component in byte 0, an 8-bit G
        /// component in byte 1, and an 8-bit B component in byte 2.
        /// </summary>
        R8G8B8SInt = 28, 
        
        /// <summary>
        /// ename:VK_FORMAT_R8G8B8_SRGB:: A three-component, 24-bit unsigned
        /// normalized format that has an 8-bit R component stored with sRGB
        /// nonlinear encoding in byte 0, an 8-bit G component stored with sRGB
        /// nonlinear encoding in byte 1, and an 8-bit B component stored with
        /// sRGB nonlinear encoding in byte 2.
        /// </summary>
        R8G8B8Srgb = 29, 
        
        /// <summary>
        /// ename:VK_FORMAT_B8G8R8_UNORM:: A three-component, 24-bit unsigned
        /// normalized format that has an 8-bit B component in byte 0, an 8-bit
        /// G component in byte 1, and an 8-bit R component in byte 2.
        /// </summary>
        B8G8R8UNorm = 30, 
        
        /// <summary>
        /// ename:VK_FORMAT_B8G8R8_SNORM:: A three-component, 24-bit signed
        /// normalized format that has an 8-bit B component in byte 0, an 8-bit
        /// G component in byte 1, and an 8-bit R component in byte 2.
        /// </summary>
        B8G8R8SNorm = 31, 
        
        /// <summary>
        /// ename:VK_FORMAT_B8G8R8_USCALED:: A three-component, 24-bit unsigned
        /// scaled format that has an 8-bit B component in byte 0, an 8-bit G
        /// component in byte 1, and an 8-bit R component in byte 2.
        /// </summary>
        B8G8R8UScaled = 32, 
        
        /// <summary>
        /// ename:VK_FORMAT_B8G8R8_SSCALED:: A three-component, 24-bit signed
        /// scaled format that has an 8-bit B component in byte 0, an 8-bit G
        /// component in byte 1, and an 8-bit R component in byte 2.
        /// </summary>
        B8G8R8SScaled = 33, 
        
        /// <summary>
        /// ename:VK_FORMAT_B8G8R8_UINT:: A three-component, 24-bit unsigned
        /// integer format that has an 8-bit B component in byte 0, an 8-bit G
        /// component in byte 1, and an 8-bit R component in byte 2.
        /// </summary>
        B8G8R8UInt = 34, 
        
        /// <summary>
        /// ename:VK_FORMAT_B8G8R8_SINT:: A three-component, 24-bit signed
        /// integer format that has an 8-bit B component in byte 0, an 8-bit G
        /// component in byte 1, and an 8-bit R component in byte 2.
        /// </summary>
        B8G8R8SInt = 35, 
        
        /// <summary>
        /// ename:VK_FORMAT_B8G8R8_SRGB:: A three-component, 24-bit unsigned
        /// normalized format that has an 8-bit B component stored with sRGB
        /// nonlinear encoding in byte 0, an 8-bit G component stored with sRGB
        /// nonlinear encoding in byte 1, and an 8-bit R component stored with
        /// sRGB nonlinear encoding in byte 2.
        /// </summary>
        B8G8R8Srgb = 36, 
        
        /// <summary>
        /// ename:VK_FORMAT_R8G8B8A8_UNORM:: A four-component, 32-bit unsigned
        /// normalized format that has an 8-bit R component in byte 0, an 8-bit
        /// G component in byte 1, an 8-bit B component in byte 2, and an 8-bit
        /// A component in byte 3.
        /// </summary>
        R8G8B8A8UNorm = 37, 
        
        /// <summary>
        /// ename:VK_FORMAT_R8G8B8A8_SNORM:: A four-component, 32-bit signed
        /// normalized format that has an 8-bit R component in byte 0, an 8-bit
        /// G component in byte 1, an 8-bit B component in byte 2, and an 8-bit
        /// A component in byte 3.
        /// </summary>
        R8G8B8A8SNorm = 38, 
        
        /// <summary>
        /// ename:VK_FORMAT_R8G8B8A8_USCALED:: A four-component, 32-bit
        /// unsigned scaled format that has an 8-bit R component in byte 0, an
        /// 8-bit G component in byte 1, an 8-bit B component in byte 2, and an
        /// 8-bit A component in byte 3.
        /// </summary>
        R8G8B8A8UScaled = 39, 
        
        /// <summary>
        /// ename:VK_FORMAT_R8G8B8A8_SSCALED:: A four-component, 32-bit signed
        /// scaled format that has an 8-bit R component in byte 0, an 8-bit G
        /// component in byte 1, an 8-bit B component in byte 2, and an 8-bit A
        /// component in byte 3.
        /// </summary>
        R8G8B8A8SScaled = 40, 
        
        /// <summary>
        /// ename:VK_FORMAT_R8G8B8A8_UINT:: A four-component, 32-bit unsigned
        /// integer format that has an 8-bit R component in byte 0, an 8-bit G
        /// component in byte 1, an 8-bit B component in byte 2, and an 8-bit A
        /// component in byte 3.
        /// </summary>
        R8G8B8A8UInt = 41, 
        
        /// <summary>
        /// ename:VK_FORMAT_R8G8B8A8_SINT:: A four-component, 32-bit signed
        /// integer format that has an 8-bit R component in byte 0, an 8-bit G
        /// component in byte 1, an 8-bit B component in byte 2, and an 8-bit A
        /// component in byte 3.
        /// </summary>
        R8G8B8A8SInt = 42, 
        
        /// <summary>
        /// ename:VK_FORMAT_R8G8B8A8_SRGB:: A four-component, 32-bit unsigned
        /// normalized format that has an 8-bit R component stored with sRGB
        /// nonlinear encoding in byte 0, an 8-bit G component stored with sRGB
        /// nonlinear encoding in byte 1, an 8-bit B component stored with sRGB
        /// nonlinear encoding in byte 2, and an 8-bit A component in byte 3.
        /// </summary>
        R8G8B8A8Srgb = 43, 
        
        /// <summary>
        /// ename:VK_FORMAT_B8G8R8A8_UNORM:: A four-component, 32-bit unsigned
        /// normalized format that has an 8-bit B component in byte 0, an 8-bit
        /// G component in byte 1, an 8-bit R component in byte 2, and an 8-bit
        /// A component in byte 3.
        /// </summary>
        B8G8R8A8UNorm = 44, 
        
        /// <summary>
        /// ename:VK_FORMAT_B8G8R8A8_SNORM:: A four-component, 32-bit signed
        /// normalized format that has an 8-bit B component in byte 0, an 8-bit
        /// G component in byte 1, an 8-bit R component in byte 2, and an 8-bit
        /// A component in byte 3.
        /// </summary>
        B8G8R8A8SNorm = 45, 
        
        /// <summary>
        /// ename:VK_FORMAT_B8G8R8A8_USCALED:: A four-component, 32-bit
        /// unsigned scaled format that has an 8-bit B component in byte 0, an
        /// 8-bit G component in byte 1, an 8-bit R component in byte 2, and an
        /// 8-bit A component in byte 3.
        /// </summary>
        B8G8R8A8UScaled = 46, 
        
        /// <summary>
        /// ename:VK_FORMAT_B8G8R8A8_SSCALED:: A four-component, 32-bit signed
        /// scaled format that has an 8-bit B component in byte 0, an 8-bit G
        /// component in byte 1, an 8-bit R component in byte 2, and an 8-bit A
        /// component in byte 3.
        /// </summary>
        B8G8R8A8SScaled = 47, 
        
        /// <summary>
        /// ename:VK_FORMAT_B8G8R8A8_UINT:: A four-component, 32-bit unsigned
        /// integer format that has an 8-bit B component in byte 0, an 8-bit G
        /// component in byte 1, an 8-bit R component in byte 2, and an 8-bit A
        /// component in byte 3.
        /// </summary>
        B8G8R8A8UInt = 48, 
        
        /// <summary>
        /// ename:VK_FORMAT_B8G8R8A8_SINT:: A four-component, 32-bit signed
        /// integer format that has an 8-bit B component in byte 0, an 8-bit G
        /// component in byte 1, an 8-bit R component in byte 2, and an 8-bit A
        /// component in byte 3.
        /// </summary>
        B8G8R8A8SInt = 49, 
        
        /// <summary>
        /// ename:VK_FORMAT_B8G8R8A8_SRGB:: A four-component, 32-bit unsigned
        /// normalized format that has an 8-bit B component stored with sRGB
        /// nonlinear encoding in byte 0, an 8-bit G component stored with sRGB
        /// nonlinear encoding in byte 1, an 8-bit R component stored with sRGB
        /// nonlinear encoding in byte 2, and an 8-bit A component in byte 3.
        /// </summary>
        B8G8R8A8Srgb = 50, 
        
        /// <summary>
        /// ename:VK_FORMAT_A8B8G8R8_UNORM_PACK32:: A four-component, 32-bit
        /// packed unsigned normalized format that has an 8-bit A component in
        /// bits 24..31, an 8-bit B component in bits 16..23, an 8-bit G
        /// component in bits 8..15, and an 8-bit R component in bits 0..7.
        /// </summary>
        A8B8G8R8UNormPack32 = 51, 
        
        /// <summary>
        /// ename:VK_FORMAT_A8B8G8R8_SNORM_PACK32:: A four-component, 32-bit
        /// packed signed normalized format that has an 8-bit A component in
        /// bits 24..31, an 8-bit B component in bits 16..23, an 8-bit G
        /// component in bits 8..15, and an 8-bit R component in bits 0..7.
        /// </summary>
        A8B8G8R8SNormPack32 = 52, 
        
        /// <summary>
        /// ename:VK_FORMAT_A8B8G8R8_USCALED_PACK32:: A four-component, 32-bit
        /// packed unsigned scaled integer format that has an 8-bit A component
        /// in bits 24..31, an 8-bit B component in bits 16..23, an 8-bit G
        /// component in bits 8..15, and an 8-bit R component in bits 0..7.
        /// </summary>
        A8B8G8R8UScaledPack32 = 53, 
        
        /// <summary>
        /// ename:VK_FORMAT_A8B8G8R8_SSCALED_PACK32:: A four-component, 32-bit
        /// packed signed scaled integer format that has an 8-bit A component
        /// in bits 24..31, an 8-bit B component in bits 16..23, an 8-bit G
        /// component in bits 8..15, and an 8-bit R component in bits 0..7.
        /// </summary>
        A8B8G8R8SScaledPack32 = 54, 
        
        /// <summary>
        /// ename:VK_FORMAT_A8B8G8R8_UINT_PACK32:: A four-component, 32-bit
        /// packed unsigned integer format that has an 8-bit A component in
        /// bits 24..31, an 8-bit B component in bits 16..23, an 8-bit G
        /// component in bits 8..15, and an 8-bit R component in bits 0..7.
        /// </summary>
        A8B8G8R8UIntPack32 = 55, 
        
        /// <summary>
        /// ename:VK_FORMAT_A8B8G8R8_SINT_PACK32:: A four-component, 32-bit
        /// packed signed integer format that has an 8-bit A component in bits
        /// 24..31, an 8-bit B component in bits 16..23, an 8-bit G component
        /// in bits 8..15, and an 8-bit R component in bits 0..7.
        /// </summary>
        A8B8G8R8SIntPack32 = 56, 
        
        /// <summary>
        /// ename:VK_FORMAT_A8B8G8R8_SRGB_PACK32:: A four-component, 32-bit
        /// packed unsigned normalized format that has an 8-bit A component in
        /// bits 24..31, an 8-bit B component stored with sRGB nonlinear
        /// encoding in bits 16..23, an 8-bit G component stored with sRGB
        /// nonlinear encoding in bits 8..15, and an 8-bit R component stored
        /// with sRGB nonlinear encoding in bits 0..7.
        /// </summary>
        A8B8G8R8SrgbPack32 = 57, 
        
        /// <summary>
        /// ename:VK_FORMAT_A2R10G10B10_UNORM_PACK32:: A four-component, 32-bit
        /// packed unsigned normalized format that has a 2-bit A component in
        /// bits 30..31, a 10-bit R component in bits 20..29, a 10-bit G
        /// component in bits 10..19, and a 10-bit B component in bits 0..9.
        /// </summary>
        A2R10G10B10UNormPack32 = 58, 
        
        /// <summary>
        /// ename:VK_FORMAT_A2R10G10B10_SNORM_PACK32:: A four-component, 32-bit
        /// packed signed normalized format that has a 2-bit A component in
        /// bits 30..31, a 10-bit R component in bits 20..29, a 10-bit G
        /// component in bits 10..19, and a 10-bit B component in bits 0..9.
        /// </summary>
        A2R10G10B10SNormPack32 = 59, 
        
        /// <summary>
        /// ename:VK_FORMAT_A2R10G10B10_USCALED_PACK32:: A four-component,
        /// 32-bit packed unsigned scaled integer format that has a 2-bit A
        /// component in bits 30..31, a 10-bit R component in bits 20..29, a
        /// 10-bit G component in bits 10..19, and a 10-bit B component in bits
        /// 0..9.
        /// </summary>
        A2R10G10B10UScaledPack32 = 60, 
        
        /// <summary>
        /// ename:VK_FORMAT_A2R10G10B10_SSCALED_PACK32:: A four-component,
        /// 32-bit packed signed scaled integer format that has a 2-bit A
        /// component in bits 30..31, a 10-bit R component in bits 20..29, a
        /// 10-bit G component in bits 10..19, and a 10-bit B component in bits
        /// 0..9.
        /// </summary>
        A2R10G10B10SScaledPack32 = 61, 
        
        /// <summary>
        /// ename:VK_FORMAT_A2R10G10B10_UINT_PACK32:: A four-component, 32-bit
        /// packed unsigned integer format that has a 2-bit A component in bits
        /// 30..31, a 10-bit R component in bits 20..29, a 10-bit G component
        /// in bits 10..19, and a 10-bit B component in bits 0..9.
        /// </summary>
        A2R10G10B10UIntPack32 = 62, 
        
        /// <summary>
        /// ename:VK_FORMAT_A2R10G10B10_SINT_PACK32:: A four-component, 32-bit
        /// packed signed integer format that has a 2-bit A component in bits
        /// 30..31, a 10-bit R component in bits 20..29, a 10-bit G component
        /// in bits 10..19, and a 10-bit B component in bits 0..9.
        /// </summary>
        A2R10G10B10SIntPack32 = 63, 
        
        /// <summary>
        /// ename:VK_FORMAT_A2B10G10R10_UNORM_PACK32:: A four-component, 32-bit
        /// packed unsigned normalized format that has a 2-bit A component in
        /// bits 30..31, a 10-bit B component in bits 20..29, a 10-bit G
        /// component in bits 10..19, and a 10-bit R component in bits 0..9.
        /// </summary>
        A2B10G10R10UNormPack32 = 64, 
        
        /// <summary>
        /// ename:VK_FORMAT_A2B10G10R10_SNORM_PACK32:: A four-component, 32-bit
        /// packed signed normalized format that has a 2-bit A component in
        /// bits 30..31, a 10-bit B component in bits 20..29, a 10-bit G
        /// component in bits 10..19, and a 10-bit R component in bits 0..9.
        /// </summary>
        A2B10G10R10SNormPack32 = 65, 
        
        /// <summary>
        /// ename:VK_FORMAT_A2B10G10R10_USCALED_PACK32:: A four-component,
        /// 32-bit packed unsigned scaled integer format that has a 2-bit A
        /// component in bits 30..31, a 10-bit B component in bits 20..29, a
        /// 10-bit G component in bits 10..19, and a 10-bit R component in bits
        /// 0..9.
        /// </summary>
        A2B10G10R10UScaledPack32 = 66, 
        
        /// <summary>
        /// ename:VK_FORMAT_A2B10G10R10_SSCALED_PACK32:: A four-component,
        /// 32-bit packed signed scaled integer format that has a 2-bit A
        /// component in bits 30..31, a 10-bit B component in bits 20..29, a
        /// 10-bit G component in bits 10..19, and a 10-bit R component in bits
        /// 0..9.
        /// </summary>
        A2B10G10R10SScaledPack32 = 67, 
        
        /// <summary>
        /// ename:VK_FORMAT_A2B10G10R10_UINT_PACK32:: A four-component, 32-bit
        /// packed unsigned integer format that has a 2-bit A component in bits
        /// 30..31, a 10-bit B component in bits 20..29, a 10-bit G component
        /// in bits 10..19, and a 10-bit R component in bits 0..9.
        /// </summary>
        A2B10G10R10UIntPack32 = 68, 
        
        /// <summary>
        /// ename:VK_FORMAT_A2B10G10R10_SINT_PACK32:: A four-component, 32-bit
        /// packed signed integer format that has a 2-bit A component in bits
        /// 30..31, a 10-bit B component in bits 20..29, a 10-bit G component
        /// in bits 10..19, and a 10-bit R component in bits 0..9.
        /// </summary>
        A2B10G10R10SIntPack32 = 69, 
        
        /// <summary>
        /// ename:VK_FORMAT_R16_UNORM:: A one-component, 16-bit unsigned
        /// normalized format that has a single 16-bit R component.
        /// </summary>
        R16UNorm = 70, 
        
        /// <summary>
        /// ename:VK_FORMAT_R16_SNORM:: A one-component, 16-bit signed
        /// normalized format that has a single 16-bit R component.
        /// </summary>
        R16SNorm = 71, 
        
        /// <summary>
        /// ename:VK_FORMAT_R16_USCALED:: A one-component, 16-bit unsigned
        /// scaled integer format that has a single 16-bit R component.
        /// </summary>
        R16UScaled = 72, 
        
        /// <summary>
        /// ename:VK_FORMAT_R16_SSCALED:: A one-component, 16-bit signed scaled
        /// integer format that has a single 16-bit R component.
        /// </summary>
        R16SScaled = 73, 
        
        /// <summary>
        /// ename:VK_FORMAT_R16_UINT:: A one-component, 16-bit unsigned integer
        /// format that has a single 16-bit R component.
        /// </summary>
        R16UInt = 74, 
        
        /// <summary>
        /// ename:VK_FORMAT_R16_SINT:: A one-component, 16-bit signed integer
        /// format that has a single 16-bit R component.
        /// </summary>
        R16SInt = 75, 
        
        /// <summary>
        /// ename:VK_FORMAT_R16_SFLOAT:: A one-component, 16-bit signed
        /// floating-point format that has a single 16-bit R component.
        /// </summary>
        R16SFloat = 76, 
        
        /// <summary>
        /// ename:VK_FORMAT_R16G16_UNORM:: A two-component, 32-bit unsigned
        /// normalized format that has a 16-bit R component in bytes 0..1, and
        /// a 16-bit G component in bytes 2..3.
        /// </summary>
        R16G16UNorm = 77, 
        
        /// <summary>
        /// ename:VK_FORMAT_R16G16_SNORM:: A two-component, 32-bit signed
        /// normalized format that has a 16-bit R component in bytes 0..1, and
        /// a 16-bit G component in bytes 2..3.
        /// </summary>
        R16G16SNorm = 78, 
        
        /// <summary>
        /// ename:VK_FORMAT_R16G16_USCALED:: A two-component, 32-bit unsigned
        /// scaled integer format that has a 16-bit R component in bytes 0..1,
        /// and a 16-bit G component in bytes 2..3.
        /// </summary>
        R16G16UScaled = 79, 
        
        /// <summary>
        /// ename:VK_FORMAT_R16G16_SSCALED:: A two-component, 32-bit signed
        /// scaled integer format that has a 16-bit R component in bytes 0..1,
        /// and a 16-bit G component in bytes 2..3.
        /// </summary>
        R16G16SScaled = 80, 
        
        /// <summary>
        /// ename:VK_FORMAT_R16G16_UINT:: A two-component, 32-bit unsigned
        /// integer format that has a 16-bit R component in bytes 0..1, and a
        /// 16-bit G component in bytes 2..3.
        /// </summary>
        R16G16UInt = 81, 
        
        /// <summary>
        /// ename:VK_FORMAT_R16G16_SINT:: A two-component, 32-bit signed
        /// integer format that has a 16-bit R component in bytes 0..1, and a
        /// 16-bit G component in bytes 2..3.
        /// </summary>
        R16G16SInt = 82, 
        
        /// <summary>
        /// ename:VK_FORMAT_R16G16_SFLOAT:: A two-component, 32-bit signed
        /// floating-point format that has a 16-bit R component in bytes 0..1,
        /// and a 16-bit G component in bytes 2..3.
        /// </summary>
        R16G16SFloat = 83, 
        
        /// <summary>
        /// ename:VK_FORMAT_R16G16B16_UNORM:: A three-component, 48-bit
        /// unsigned normalized format that has a 16-bit R component in bytes
        /// 0..1, a 16-bit G component in bytes 2..3, and a 16-bit B component
        /// in bytes 4..5.
        /// </summary>
        R16G16B16UNorm = 84, 
        
        /// <summary>
        /// ename:VK_FORMAT_R16G16B16_SNORM:: A three-component, 48-bit signed
        /// normalized format that has a 16-bit R component in bytes 0..1, a
        /// 16-bit G component in bytes 2..3, and a 16-bit B component in bytes
        /// 4..5.
        /// </summary>
        R16G16B16SNorm = 85, 
        
        /// <summary>
        /// ename:VK_FORMAT_R16G16B16_USCALED:: A three-component, 48-bit
        /// unsigned scaled integer format that has a 16-bit R component in
        /// bytes 0..1, a 16-bit G component in bytes 2..3, and a 16-bit B
        /// component in bytes 4..5.
        /// </summary>
        R16G16B16UScaled = 86, 
        
        /// <summary>
        /// ename:VK_FORMAT_R16G16B16_SSCALED:: A three-component, 48-bit
        /// signed scaled integer format that has a 16-bit R component in bytes
        /// 0..1, a 16-bit G component in bytes 2..3, and a 16-bit B component
        /// in bytes 4..5.
        /// </summary>
        R16G16B16SScaled = 87, 
        
        /// <summary>
        /// ename:VK_FORMAT_R16G16B16_UINT:: A three-component, 48-bit unsigned
        /// integer format that has a 16-bit R component in bytes 0..1, a
        /// 16-bit G component in bytes 2..3, and a 16-bit B component in bytes
        /// 4..5.
        /// </summary>
        R16G16B16UInt = 88, 
        
        /// <summary>
        /// ename:VK_FORMAT_R16G16B16_SINT:: A three-component, 48-bit signed
        /// integer format that has a 16-bit R component in bytes 0..1, a
        /// 16-bit G component in bytes 2..3, and a 16-bit B component in bytes
        /// 4..5.
        /// </summary>
        R16G16B16SInt = 89, 
        
        /// <summary>
        /// ename:VK_FORMAT_R16G16B16_SFLOAT:: A three-component, 48-bit signed
        /// floating-point format that has a 16-bit R component in bytes 0..1,
        /// a 16-bit G component in bytes 2..3, and a 16-bit B component in
        /// bytes 4..5.
        /// </summary>
        R16G16B16SFloat = 90, 
        
        /// <summary>
        /// ename:VK_FORMAT_R16G16B16A16_UNORM:: A four-component, 64-bit
        /// unsigned normalized format that has a 16-bit R component in bytes
        /// 0..1, a 16-bit G component in bytes 2..3, a 16-bit B component in
        /// bytes 4..5, and a 16-bit A component in bytes 6..7.
        /// </summary>
        R16G16B16A16UNorm = 91, 
        
        /// <summary>
        /// ename:VK_FORMAT_R16G16B16A16_SNORM:: A four-component, 64-bit
        /// signed normalized format that has a 16-bit R component in bytes
        /// 0..1, a 16-bit G component in bytes 2..3, a 16-bit B component in
        /// bytes 4..5, and a 16-bit A component in bytes 6..7.
        /// </summary>
        R16G16B16A16SNorm = 92, 
        
        /// <summary>
        /// ename:VK_FORMAT_R16G16B16A16_USCALED:: A four-component, 64-bit
        /// unsigned scaled integer format that has a 16-bit R component in
        /// bytes 0..1, a 16-bit G component in bytes 2..3, a 16-bit B
        /// component in bytes 4..5, and a 16-bit A component in bytes 6..7.
        /// </summary>
        R16G16B16A16UScaled = 93, 
        
        /// <summary>
        /// ename:VK_FORMAT_R16G16B16A16_SSCALED:: A four-component, 64-bit
        /// signed scaled integer format that has a 16-bit R component in bytes
        /// 0..1, a 16-bit G component in bytes 2..3, a 16-bit B component in
        /// bytes 4..5, and a 16-bit A component in bytes 6..7.
        /// </summary>
        R16G16B16A16SScaled = 94, 
        
        /// <summary>
        /// ename:VK_FORMAT_R16G16B16A16_UINT:: A four-component, 64-bit
        /// unsigned integer format that has a 16-bit R component in bytes
        /// 0..1, a 16-bit G component in bytes 2..3, a 16-bit B component in
        /// bytes 4..5, and a 16-bit A component in bytes 6..7.
        /// </summary>
        R16G16B16A16UInt = 95, 
        
        /// <summary>
        /// ename:VK_FORMAT_R16G16B16A16_SINT:: A four-component, 64-bit signed
        /// integer format that has a 16-bit R component in bytes 0..1, a
        /// 16-bit G component in bytes 2..3, a 16-bit B component in bytes
        /// 4..5, and a 16-bit A component in bytes 6..7.
        /// </summary>
        R16G16B16A16SInt = 96, 
        
        /// <summary>
        /// ename:VK_FORMAT_R16G16B16A16_SFLOAT:: A four-component, 64-bit
        /// signed floating-point format that has a 16-bit R component in bytes
        /// 0..1, a 16-bit G component in bytes 2..3, a 16-bit B component in
        /// bytes 4..5, and a 16-bit A component in bytes 6..7.
        /// </summary>
        R16G16B16A16SFloat = 97, 
        
        /// <summary>
        /// ename:VK_FORMAT_R32_UINT:: A one-component, 32-bit unsigned integer
        /// format that has a single 32-bit R component.
        /// </summary>
        R32UInt = 98, 
        
        /// <summary>
        /// ename:VK_FORMAT_R32_SINT:: A one-component, 32-bit signed integer
        /// format that has a single 32-bit R component.
        /// </summary>
        R32SInt = 99, 
        
        /// <summary>
        /// ename:VK_FORMAT_R32_SFLOAT:: A one-component, 32-bit signed
        /// floating-point format that has a single 32-bit R component.
        /// </summary>
        R32SFloat = 100, 
        
        /// <summary>
        /// ename:VK_FORMAT_R32G32_UINT:: A two-component, 64-bit unsigned
        /// integer format that has a 32-bit R component in bytes 0..3, and a
        /// 32-bit G component in bytes 4..7.
        /// </summary>
        R32G32UInt = 101, 
        
        /// <summary>
        /// ename:VK_FORMAT_R32G32_SINT:: A two-component, 64-bit signed
        /// integer format that has a 32-bit R component in bytes 0..3, and a
        /// 32-bit G component in bytes 4..7.
        /// </summary>
        R32G32SInt = 102, 
        
        /// <summary>
        /// ename:VK_FORMAT_R32G32_SFLOAT:: A two-component, 64-bit signed
        /// floating-point format that has a 32-bit R component in bytes 0..3,
        /// and a 32-bit G component in bytes 4..7.
        /// </summary>
        R32G32SFloat = 103, 
        
        /// <summary>
        /// ename:VK_FORMAT_R32G32B32_UINT:: A three-component, 96-bit unsigned
        /// integer format that has a 32-bit R component in bytes 0..3, a
        /// 32-bit G component in bytes 4..7, and a 32-bit B component in bytes
        /// 8..11.
        /// </summary>
        R32G32B32UInt = 104, 
        
        /// <summary>
        /// ename:VK_FORMAT_R32G32B32_SINT:: A three-component, 96-bit signed
        /// integer format that has a 32-bit R component in bytes 0..3, a
        /// 32-bit G component in bytes 4..7, and a 32-bit B component in bytes
        /// 8..11.
        /// </summary>
        R32G32B32SInt = 105, 
        
        /// <summary>
        /// ename:VK_FORMAT_R32G32B32_SFLOAT:: A three-component, 96-bit signed
        /// floating-point format that has a 32-bit R component in bytes 0..3,
        /// a 32-bit G component in bytes 4..7, and a 32-bit B component in
        /// bytes 8..11.
        /// </summary>
        R32G32B32SFloat = 106, 
        
        /// <summary>
        /// ename:VK_FORMAT_R32G32B32A32_UINT:: A four-component, 128-bit
        /// unsigned integer format that has a 32-bit R component in bytes
        /// 0..3, a 32-bit G component in bytes 4..7, a 32-bit B component in
        /// bytes 8..11, and a 32-bit A component in bytes 12..15.
        /// </summary>
        R32G32B32A32UInt = 107, 
        
        /// <summary>
        /// ename:VK_FORMAT_R32G32B32A32_SINT:: A four-component, 128-bit
        /// signed integer format that has a 32-bit R component in bytes 0..3,
        /// a 32-bit G component in bytes 4..7, a 32-bit B component in bytes
        /// 8..11, and a 32-bit A component in bytes 12..15.
        /// </summary>
        R32G32B32A32SInt = 108, 
        
        /// <summary>
        /// ename:VK_FORMAT_R32G32B32A32_SFLOAT:: A four-component, 128-bit
        /// signed floating-point format that has a 32-bit R component in bytes
        /// 0..3, a 32-bit G component in bytes 4..7, a 32-bit B component in
        /// bytes 8..11, and a 32-bit A component in bytes 12..15.
        /// </summary>
        R32G32B32A32SFloat = 109, 
        
        /// <summary>
        /// ename:VK_FORMAT_R64_UINT:: A one-component, 64-bit unsigned integer
        /// format that has a single 64-bit R component.
        /// </summary>
        R64UInt = 110, 
        
        /// <summary>
        /// ename:VK_FORMAT_R64_SINT:: A one-component, 64-bit signed integer
        /// format that has a single 64-bit R component.
        /// </summary>
        R64SInt = 111, 
        
        /// <summary>
        /// ename:VK_FORMAT_R64_SFLOAT:: A one-component, 64-bit signed
        /// floating-point format that has a single 64-bit R component.
        /// </summary>
        R64SFloat = 112, 
        
        /// <summary>
        /// ename:VK_FORMAT_R64G64_UINT:: A two-component, 128-bit unsigned
        /// integer format that has a 64-bit R component in bytes 0..7, and a
        /// 64-bit G component in bytes 8..15.
        /// </summary>
        R64G64UInt = 113, 
        
        /// <summary>
        /// ename:VK_FORMAT_R64G64_SINT:: A two-component, 128-bit signed
        /// integer format that has a 64-bit R component in bytes 0..7, and a
        /// 64-bit G component in bytes 8..15.
        /// </summary>
        R64G64SInt = 114, 
        
        /// <summary>
        /// ename:VK_FORMAT_R64G64_SFLOAT:: A two-component, 128-bit signed
        /// floating-point format that has a 64-bit R component in bytes 0..7,
        /// and a 64-bit G component in bytes 8..15.
        /// </summary>
        R64G64SFloat = 115, 
        
        /// <summary>
        /// ename:VK_FORMAT_R64G64B64_UINT:: A three-component, 192-bit
        /// unsigned integer format that has a 64-bit R component in bytes
        /// 0..7, a 64-bit G component in bytes 8..15, and a 64-bit B component
        /// in bytes 16..23.
        /// </summary>
        R64G64B64UInt = 116, 
        
        /// <summary>
        /// ename:VK_FORMAT_R64G64B64_SINT:: A three-component, 192-bit signed
        /// integer format that has a 64-bit R component in bytes 0..7, a
        /// 64-bit G component in bytes 8..15, and a 64-bit B component in
        /// bytes 16..23.
        /// </summary>
        R64G64B64SInt = 117, 
        
        /// <summary>
        /// ename:VK_FORMAT_R64G64B64_SFLOAT:: A three-component, 192-bit
        /// signed floating-point format that has a 64-bit R component in bytes
        /// 0..7, a 64-bit G component in bytes 8..15, and a 64-bit B component
        /// in bytes 16..23.
        /// </summary>
        R64G64B64SFloat = 118, 
        
        /// <summary>
        /// ename:VK_FORMAT_R64G64B64A64_UINT:: A four-component, 256-bit
        /// unsigned integer format that has a 64-bit R component in bytes
        /// 0..7, a 64-bit G component in bytes 8..15, a 64-bit B component in
        /// bytes 16..23, and a 64-bit A component in bytes 24..31.
        /// </summary>
        R64G64B64A64UInt = 119, 
        
        /// <summary>
        /// ename:VK_FORMAT_R64G64B64A64_SINT:: A four-component, 256-bit
        /// signed integer format that has a 64-bit R component in bytes 0..7,
        /// a 64-bit G component in bytes 8..15, a 64-bit B component in bytes
        /// 16..23, and a 64-bit A component in bytes 24..31.
        /// </summary>
        R64G64B64A64SInt = 120, 
        
        /// <summary>
        /// ename:VK_FORMAT_R64G64B64A64_SFLOAT:: A four-component, 256-bit
        /// signed floating-point format that has a 64-bit R component in bytes
        /// 0..7, a 64-bit G component in bytes 8..15, a 64-bit B component in
        /// bytes 16..23, and a 64-bit A component in bytes 24..31.
        /// </summary>
        R64G64B64A64SFloat = 121, 
        
        /// <summary>
        /// ename:VK_FORMAT_B10G11R11_UFLOAT_PACK32:: A three-component, 32-bit
        /// packed unsigned floating-point format that has a 10-bit B component
        /// in bits 22..31, an 11-bit G component in bits 11..21, an 11-bit R
        /// component in bits 0..10. See &lt;&lt;fundamentals-fp10&gt;&gt; and
        /// &lt;&lt;fundamentals-fp11&gt;&gt;.
        /// </summary>
        B10G11R11UfloatPack32 = 122, 
        
        /// <summary>
        /// ename:VK_FORMAT_E5B9G9R9_UFLOAT_PACK32:: A three-component, 32-bit
        /// packed unsigned floating-point format that has a 5-bit shared
        /// exponent in bits 27..31, a 9-bit B component mantissa in bits
        /// 18..26, a 9-bit G component mantissa in bits 9..17, and a 9-bit R
        /// component mantissa in bits 0..8.
        /// </summary>
        E5b9g9r9UfloatPack32 = 123, 
        
        /// <summary>
        /// ename:VK_FORMAT_D16_UNORM:: A one-component, 16-bit unsigned
        /// normalized format that has a single 16-bit depth component.
        /// </summary>
        D16UNorm = 124, 
        
        /// <summary>
        /// ename:VK_FORMAT_X8_D24_UNORM_PACK32:: A two-component, 32-bit
        /// format that has 24 unsigned normalized bits in the depth component
        /// and, optionally:, 8 bits that are unused.
        /// </summary>
        X8D24UNormPack32 = 125, 
        
        /// <summary>
        /// ename:VK_FORMAT_D32_SFLOAT:: A one-component, 32-bit signed
        /// floating-point format that has 32-bits in the depth component.
        /// </summary>
        D32SFloat = 126, 
        
        /// <summary>
        /// ename:VK_FORMAT_S8_UINT:: A one-component, 8-bit unsigned integer
        /// format that has 8-bits in the stencil component.
        /// </summary>
        S8UInt = 127, 
        
        /// <summary>
        /// ename:VK_FORMAT_D16_UNORM_S8_UINT:: A two-component, 24-bit format
        /// that has 16 unsigned normalized bits in the depth component and 8
        /// unsigned integer bits in the stencil component.
        /// </summary>
        D16UNormS8UInt = 128, 
        
        /// <summary>
        /// ename:VK_FORMAT_D24_UNORM_S8_UINT:: A two-component, 32-bit packed
        /// format that has 8 unsigned integer bits in the stencil component,
        /// and 24 unsigned normalized bits in the depth component.
        /// </summary>
        D24UNormS8UInt = 129, 
        
        /// <summary>
        /// ename:VK_FORMAT_D32_SFLOAT_S8_UINT:: A two-component format that
        /// has 32 signed float bits in the depth component and 8 unsigned
        /// integer bits in the stencil component. There are optionally:
        /// 24-bits that are unused.
        /// </summary>
        D32SFloatS8UInt = 130, 
        
        /// <summary>
        /// ename:VK_FORMAT_BC1_RGB_UNORM_BLOCK:: A three-component,
        /// block-compressed format where each 64-bit compressed texel block
        /// encodes a 4x4 rectangle of unsigned normalized RGB texel data. This
        /// format has no alpha and is considered opaque.
        /// </summary>
        Bc1RgbUNormBlock = 131, 
        
        /// <summary>
        /// ename:VK_FORMAT_BC1_RGB_SRGB_BLOCK:: A three-component,
        /// block-compressed format where each 64-bit compressed texel block
        /// encodes a 4x4 rectangle of unsigned normalized RGB texel data with
        /// sRGB nonlinear encoding. This format has no alpha and is considered
        /// opaque.
        /// </summary>
        Bc1RgbSrgbBlock = 132, 
        
        /// <summary>
        /// ename:VK_FORMAT_BC1_RGBA_UNORM_BLOCK:: A four-component,
        /// block-compressed format where each 64-bit compressed texel block
        /// encodes a 4x4 rectangle of unsigned normalized RGB texel data, and
        /// provides 1 bit of alpha.
        /// </summary>
        Bc1RgbaUNormBlock = 133, 
        
        /// <summary>
        /// ename:VK_FORMAT_BC1_RGBA_SRGB_BLOCK:: A four-component,
        /// block-compressed format where each 64-bit compressed texel block
        /// encodes a 4x4 rectangle of unsigned normalized RGB texel data with
        /// sRGB nonlinear encoding, and provides 1 bit of alpha.
        /// </summary>
        Bc1RgbaSrgbBlock = 134, 
        
        /// <summary>
        /// ename:VK_FORMAT_BC2_UNORM_BLOCK:: A four-component,
        /// block-compressed format where each 128-bit compressed texel block
        /// encodes a 4x4 rectangle of unsigned normalized RGBA texel data with
        /// the first 64 bits encoding alpha values followed by 64 bits
        /// encoding RGB values.
        /// </summary>
        Bc2UNormBlock = 135, 
        
        /// <summary>
        /// ename:VK_FORMAT_BC2_SRGB_BLOCK:: A four-component, block-compressed
        /// format where each 128-bit compressed texel block encodes a 4x4
        /// rectangle of unsigned normalized RGBA texel data with the first 64
        /// bits encoding alpha values followed by 64 bits encoding RGB values
        /// with sRGB nonlinear encoding.
        /// </summary>
        Bc2SrgbBlock = 136, 
        
        /// <summary>
        /// ename:VK_FORMAT_BC3_UNORM_BLOCK:: A four-component,
        /// block-compressed format where each 128-bit compressed texel block
        /// encodes a 4x4 rectangle of unsigned normalized RGBA texel data with
        /// the first 64 bits encoding alpha values followed by 64 bits
        /// encoding RGB values.
        /// </summary>
        Bc3UNormBlock = 137, 
        
        /// <summary>
        /// ename:VK_FORMAT_BC3_SRGB_BLOCK:: A four-component, block-compressed
        /// format where each 128-bit compressed texel block encodes a 4x4
        /// rectangle of unsigned normalized RGBA texel data with the first 64
        /// bits encoding alpha values followed by 64 bits encoding RGB values
        /// with sRGB nonlinear encoding.
        /// </summary>
        Bc3SrgbBlock = 138, 
        
        /// <summary>
        /// ename:VK_FORMAT_BC4_UNORM_BLOCK:: A one-component, block-compressed
        /// format where each 64-bit compressed texel block encodes a 4x4
        /// rectangle of unsigned normalized red texel data.
        /// </summary>
        Bc4UNormBlock = 139, 
        
        /// <summary>
        /// ename:VK_FORMAT_BC4_SNORM_BLOCK:: A one-component, block-compressed
        /// format where each 64-bit compressed texel block encodes a 4x4
        /// rectangle of signed normalized red texel data.
        /// </summary>
        Bc4SNormBlock = 140, 
        
        /// <summary>
        /// ename:VK_FORMAT_BC5_UNORM_BLOCK:: A two-component, block-compressed
        /// format where each 128-bit compressed texel block encodes a 4x4
        /// rectangle of unsigned normalized RG texel data with the first 64
        /// bits encoding red values followed by 64 bits encoding green values.
        /// </summary>
        Bc5UNormBlock = 141, 
        
        /// <summary>
        /// ename:VK_FORMAT_BC5_SNORM_BLOCK:: A two-component, block-compressed
        /// format where each 128-bit compressed texel block encodes a 4x4
        /// rectangle of signed normalized RG texel data with the first 64 bits
        /// encoding red values followed by 64 bits encoding green values.
        /// </summary>
        Bc5SNormBlock = 142, 
        
        /// <summary>
        /// ename:VK_FORMAT_BC6H_UFLOAT_BLOCK:: A three-component,
        /// block-compressed format where each 128-bit compressed texel block
        /// encodes a 4x4 rectangle of unsigned floating-point RGB texel data.
        /// </summary>
        Bc6hUfloatBlock = 143, 
        
        /// <summary>
        /// ename:VK_FORMAT_BC6H_SFLOAT_BLOCK:: A three-component,
        /// block-compressed format where each 128-bit compressed texel block
        /// encodes a 4x4 rectangle of signed floating-point RGB texel data.
        /// </summary>
        Bc6hSFloatBlock = 144, 
        
        /// <summary>
        /// ename:VK_FORMAT_BC7_UNORM_BLOCK:: A four-component,
        /// block-compressed format where each 128-bit compressed texel block
        /// encodes a 4x4 rectangle of unsigned normalized RGBA texel data.
        /// </summary>
        Bc7UNormBlock = 145, 
        
        /// <summary>
        /// ename:VK_FORMAT_BC7_SRGB_BLOCK:: A four-component, block-compressed
        /// format where each 128-bit compressed texel block encodes a 4x4
        /// rectangle of unsigned normalized RGBA texel data with sRGB
        /// nonlinear encoding applied to the RGB components.
        /// </summary>
        Bc7SrgbBlock = 146, 
        
        /// <summary>
        /// ename:VK_FORMAT_ETC2_R8G8B8_UNORM_BLOCK:: A three-component, ETC2
        /// compressed format where each 64-bit compressed texel block encodes
        /// a 4x4 rectangle of unsigned normalized RGB texel data. This format
        /// has no alpha and is considered opaque.
        /// </summary>
        Etc2R8G8B8UNormBlock = 147, 
        
        /// <summary>
        /// ename:VK_FORMAT_ETC2_R8G8B8_SRGB_BLOCK:: A three-component, ETC2
        /// compressed format where each 64-bit compressed texel block encodes
        /// a 4x4 rectangle of unsigned normalized RGB texel data with sRGB
        /// nonlinear encoding. This format has no alpha and is considered
        /// opaque.
        /// </summary>
        Etc2R8G8B8SrgbBlock = 148, 
        
        /// <summary>
        /// ename:VK_FORMAT_ETC2_R8G8B8A1_UNORM_BLOCK:: A four-component, ETC2
        /// compressed format where each 64-bit compressed texel block encodes
        /// a 4x4 rectangle of unsigned normalized RGB texel data, and provides
        /// 1 bit of alpha.
        /// </summary>
        Etc2R8G8B8A1UNormBlock = 149, 
        
        /// <summary>
        /// ename:VK_FORMAT_ETC2_R8G8B8A1_SRGB_BLOCK:: A four-component, ETC2
        /// compressed format where each 64-bit compressed texel block encodes
        /// a 4x4 rectangle of unsigned normalized RGB texel data with sRGB
        /// nonlinear encoding, and provides 1 bit of alpha.
        /// </summary>
        Etc2R8G8B8A1SrgbBlock = 150, 
        
        /// <summary>
        /// ename:VK_FORMAT_ETC2_R8G8B8A8_UNORM_BLOCK:: A four-component, ETC2
        /// compressed format where each 128-bit compressed texel block encodes
        /// a 4x4 rectangle of unsigned normalized RGBA texel data with the
        /// first 64 bits encoding alpha values followed by 64 bits encoding
        /// RGB values.
        /// </summary>
        Etc2R8G8B8A8UNormBlock = 151, 
        
        /// <summary>
        /// ename:VK_FORMAT_ETC2_R8G8B8A8_SRGB_BLOCK:: A four-component, ETC2
        /// compressed format where each 64-bit compressed texel block encodes
        /// a 4x4 rectangle of unsigned normalized RGBA texel data with the
        /// first 64 bits encoding alpha values followed by 64 bits encoding
        /// RGB values with sRGB nonlinear encoding applied.
        /// </summary>
        Etc2R8G8B8A8SrgbBlock = 152, 
        
        /// <summary>
        /// ename:VK_FORMAT_EAC_R11_UNORM_BLOCK:: A one-component, ETC2
        /// compressed format where each 64-bit compressed texel block encodes
        /// a 4x4 rectangle of unsigned normalized red texel data.
        /// </summary>
        EacR11UNormBlock = 153, 
        
        /// <summary>
        /// ename:VK_FORMAT_EAC_R11_SNORM_BLOCK:: A one-component, ETC2
        /// compressed format where each 64-bit compressed texel block encodes
        /// a 4x4 rectangle of signed normalized red texel data.
        /// </summary>
        EacR11SNormBlock = 154, 
        
        /// <summary>
        /// ename:VK_FORMAT_EAC_R11G11_UNORM_BLOCK:: A two-component, ETC2
        /// compressed format where each 128-bit compressed texel block encodes
        /// a 4x4 rectangle of unsigned normalized RG texel data with the first
        /// 64 bits encoding red values followed by 64 bits encoding green
        /// values.
        /// </summary>
        EacR11G11UNormBlock = 155, 
        
        /// <summary>
        /// ename:VK_FORMAT_EAC_R11G11_SNORM_BLOCK:: A two-component, ETC2
        /// compressed format where each 128-bit compressed texel block encodes
        /// a 4x4 rectangle of signed normalized RG texel data with the first
        /// 64 bits encoding red values followed by 64 bits encoding green
        /// values.
        /// </summary>
        EacR11G11SNormBlock = 156, 
        
        /// <summary>
        /// ename:VK_FORMAT_ASTC_4x4_UNORM_BLOCK:: A four-component, ASTC
        /// compressed format where each 128-bit compressed texel block encodes
        /// a 4x4 rectangle of unsigned normalized RGBA texel data.
        /// </summary>
        Astc4x4UNormBlock = 157, 
        
        /// <summary>
        /// ename:VK_FORMAT_ASTC_4x4_SRGB_BLOCK:: A four-component, ASTC
        /// compressed format where each 128-bit compressed texel block encodes
        /// a 4x4 rectangle of unsigned normalized RGBA texel data with sRGB
        /// nonlinear encoding applied to the RGB components.
        /// </summary>
        Astc4x4SrgbBlock = 158, 
        
        /// <summary>
        /// ename:VK_FORMAT_ASTC_5x4_UNORM_BLOCK:: A four-component, ASTC
        /// compressed format where each 128-bit compressed texel block encodes
        /// a 5x4 rectangle of unsigned normalized RGBA texel data.
        /// </summary>
        Astc5x4UNormBlock = 159, 
        
        /// <summary>
        /// ename:VK_FORMAT_ASTC_5x4_SRGB_BLOCK:: A four-component, ASTC
        /// compressed format where each 128-bit compressed texel block encodes
        /// a 5x4 rectangle of unsigned normalized RGBA texel data with sRGB
        /// nonlinear encoding applied to the RGB components.
        /// </summary>
        Astc5x4SrgbBlock = 160, 
        
        /// <summary>
        /// ename:VK_FORMAT_ASTC_5x5_UNORM_BLOCK:: A four-component, ASTC
        /// compressed format where each 128-bit compressed texel block encodes
        /// a 5x5 rectangle of unsigned normalized RGBA texel data.
        /// </summary>
        Astc5x5UNormBlock = 161, 
        
        /// <summary>
        /// ename:VK_FORMAT_ASTC_5x5_SRGB_BLOCK:: A four-component, ASTC
        /// compressed format where each 128-bit compressed texel block encodes
        /// a 5x5 rectangle of unsigned normalized RGBA texel data with sRGB
        /// nonlinear encoding applied to the RGB components.
        /// </summary>
        Astc5x5SrgbBlock = 162, 
        
        /// <summary>
        /// ename:VK_FORMAT_ASTC_6x5_UNORM_BLOCK:: A four-component, ASTC
        /// compressed format where each 128-bit compressed texel block encodes
        /// a 6x5 rectangle of unsigned normalized RGBA texel data.
        /// </summary>
        Astc6x5UNormBlock = 163, 
        
        /// <summary>
        /// ename:VK_FORMAT_ASTC_6x5_SRGB_BLOCK:: A four-component, ASTC
        /// compressed format where each 128-bit compressed texel block encodes
        /// a 6x5 rectangle of unsigned normalized RGBA texel data with sRGB
        /// nonlinear encoding applied to the RGB components.
        /// </summary>
        Astc6x5SrgbBlock = 164, 
        
        /// <summary>
        /// ename:VK_FORMAT_ASTC_6x6_UNORM_BLOCK:: A four-component, ASTC
        /// compressed format where each 128-bit compressed texel block encodes
        /// a 6x6 rectangle of unsigned normalized RGBA texel data.
        /// </summary>
        Astc6x6UNormBlock = 165, 
        
        /// <summary>
        /// ename:VK_FORMAT_ASTC_6x6_SRGB_BLOCK:: A four-component, ASTC
        /// compressed format where each 128-bit compressed texel block encodes
        /// a 6x6 rectangle of unsigned normalized RGBA texel data with sRGB
        /// nonlinear encoding applied to the RGB components.
        /// </summary>
        Astc6x6SrgbBlock = 166, 
        
        /// <summary>
        /// ename:VK_FORMAT_ASTC_8x5_UNORM_BLOCK:: A four-component, ASTC
        /// compressed format where each 128-bit compressed texel block encodes
        /// an 8x5 rectangle of unsigned normalized RGBA texel data.
        /// </summary>
        Astc8x5UNormBlock = 167, 
        
        /// <summary>
        /// ename:VK_FORMAT_ASTC_8x5_SRGB_BLOCK:: A four-component, ASTC
        /// compressed format where each 128-bit compressed texel block encodes
        /// an 8x5 rectangle of unsigned normalized RGBA texel data with sRGB
        /// nonlinear encoding applied to the RGB components.
        /// </summary>
        Astc8x5SrgbBlock = 168, 
        
        /// <summary>
        /// ename:VK_FORMAT_ASTC_8x6_UNORM_BLOCK:: A four-component, ASTC
        /// compressed format where each 128-bit compressed texel block encodes
        /// an 8x6 rectangle of unsigned normalized RGBA texel data.
        /// </summary>
        Astc8x6UNormBlock = 169, 
        
        /// <summary>
        /// ename:VK_FORMAT_ASTC_8x6_SRGB_BLOCK:: A four-component, ASTC
        /// compressed format where each 128-bit compressed texel block encodes
        /// an 8x6 rectangle of unsigned normalized RGBA texel data with sRGB
        /// nonlinear encoding applied to the RGB components.
        /// </summary>
        Astc8x6SrgbBlock = 170, 
        
        /// <summary>
        /// ename:VK_FORMAT_ASTC_8x8_UNORM_BLOCK:: A four-component, ASTC
        /// compressed format where each 128-bit compressed texel block encodes
        /// an 8x8 rectangle of unsigned normalized RGBA texel data.
        /// </summary>
        Astc8x8UNormBlock = 171, 
        
        /// <summary>
        /// ename:VK_FORMAT_ASTC_8x8_SRGB_BLOCK:: A four-component, ASTC
        /// compressed format where each 128-bit compressed texel block encodes
        /// an 8x8 rectangle of unsigned normalized RGBA texel data with sRGB
        /// nonlinear encoding applied to the RGB components.
        /// </summary>
        Astc8x8SrgbBlock = 172, 
        
        /// <summary>
        /// ename:VK_FORMAT_ASTC_10x5_UNORM_BLOCK:: A four-component, ASTC
        /// compressed format where each 128-bit compressed texel block encodes
        /// a 10x5 rectangle of unsigned normalized RGBA texel data.
        /// </summary>
        Astc10x5UNormBlock = 173, 
        
        /// <summary>
        /// ename:VK_FORMAT_ASTC_10x5_SRGB_BLOCK:: A four-component, ASTC
        /// compressed format where each 128-bit compressed texel block encodes
        /// a 10x5 rectangle of unsigned normalized RGBA texel data with sRGB
        /// nonlinear encoding applied to the RGB components.
        /// </summary>
        Astc10x5SrgbBlock = 174, 
        
        /// <summary>
        /// ename:VK_FORMAT_ASTC_10x6_UNORM_BLOCK:: A four-component, ASTC
        /// compressed format where each 128-bit compressed texel block encodes
        /// a 10x6 rectangle of unsigned normalized RGBA texel data.
        /// </summary>
        Astc10x6UNormBlock = 175, 
        
        /// <summary>
        /// ename:VK_FORMAT_ASTC_10x6_SRGB_BLOCK:: A four-component, ASTC
        /// compressed format where each 128-bit compressed texel block encodes
        /// a 10x6 rectangle of unsigned normalized RGBA texel data with sRGB
        /// nonlinear encoding applied to the RGB components.
        /// </summary>
        Astc10x6SrgbBlock = 176, 
        
        /// <summary>
        /// ename:VK_FORMAT_ASTC_10x8_UNORM_BLOCK:: A four-component, ASTC
        /// compressed format where each 128-bit compressed texel block encodes
        /// a 10x8 rectangle of unsigned normalized RGBA texel data.
        /// </summary>
        Astc10x8UNormBlock = 177, 
        
        /// <summary>
        /// ename:VK_FORMAT_ASTC_10x8_SRGB_BLOCK:: A four-component, ASTC
        /// compressed format where each 128-bit compressed texel block encodes
        /// a 10x8 rectangle of unsigned normalized RGBA texel data with sRGB
        /// nonlinear encoding applied to the RGB components.
        /// </summary>
        Astc10x8SrgbBlock = 178, 
        
        /// <summary>
        /// ename:VK_FORMAT_ASTC_10x10_UNORM_BLOCK:: A four-component, ASTC
        /// compressed format where each 128-bit compressed texel block encodes
        /// a 10x10 rectangle of unsigned normalized RGBA texel data.
        /// </summary>
        Astc10x10UNormBlock = 179, 
        
        /// <summary>
        /// ename:VK_FORMAT_ASTC_10x10_SRGB_BLOCK:: A four-component, ASTC
        /// compressed format where each 128-bit compressed texel block encodes
        /// a 10x10 rectangle of unsigned normalized RGBA texel data with sRGB
        /// nonlinear encoding applied to the RGB components.
        /// </summary>
        Astc10x10SrgbBlock = 180, 
        
        /// <summary>
        /// ename:VK_FORMAT_ASTC_12x10_UNORM_BLOCK:: A four-component, ASTC
        /// compressed format where each 128-bit compressed texel block encodes
        /// a 12x10 rectangle of unsigned normalized RGBA texel data.
        /// </summary>
        Astc12x10UNormBlock = 181, 
        
        /// <summary>
        /// ename:VK_FORMAT_ASTC_12x10_SRGB_BLOCK:: A four-component, ASTC
        /// compressed format where each 128-bit compressed texel block encodes
        /// a 12x10 rectangle of unsigned normalized RGBA texel data with sRGB
        /// nonlinear encoding applied to the RGB components.
        /// </summary>
        Astc12x10SrgbBlock = 182, 
        
        /// <summary>
        /// ename:VK_FORMAT_ASTC_12x12_UNORM_BLOCK:: A four-component, ASTC
        /// compressed format where each 128-bit compressed texel block encodes
        /// a 12x12 rectangle of unsigned normalized RGBA texel data.
        /// </summary>
        Astc12x12UNormBlock = 183, 
        
        /// <summary>
        /// ename:VK_FORMAT_ASTC_12x12_SRGB_BLOCK:: A four-component, ASTC
        /// compressed format where each 128-bit compressed texel block encodes
        /// a 12x12 rectangle of unsigned normalized RGBA texel data with sRGB
        /// nonlinear encoding applied to the RGB components.
        /// </summary>
        Astc12x12SrgbBlock = 184, 
        
        /// <summary>
        /// -
        /// </summary>
        Pvrtc12bppUNormBlockImg = 1000054000, 
        
        /// <summary>
        /// -
        /// </summary>
        Pvrtc14bppUNormBlockImg = 1000054001, 
        
        /// <summary>
        /// -
        /// </summary>
        Pvrtc22bppUNormBlockImg = 1000054002, 
        
        /// <summary>
        /// -
        /// </summary>
        Pvrtc24bppUNormBlockImg = 1000054003, 
        
        /// <summary>
        /// -
        /// </summary>
        Pvrtc12bppSrgbBlockImg = 1000054004, 
        
        /// <summary>
        /// -
        /// </summary>
        Pvrtc14bppSrgbBlockImg = 1000054005, 
        
        /// <summary>
        /// -
        /// </summary>
        Pvrtc22bppSrgbBlockImg = 1000054006, 
        
        /// <summary>
        /// -
        /// </summary>
        Pvrtc24bppSrgbBlockImg = 1000054007, 
    }
    
    /// <summary>
    /// <para>
    /// Interpret polygon front-facing orientation.
    /// </para>
    /// <para>
    /// The first step of polygon rasterization is to determine whether the
    /// triangle is _back-facing_ or _front-facing_. This determination is made
    /// based on the sign of the (clipped or unclipped) polygon's area computed
    /// in framebuffer coordinates. One way to compute this area is:
    /// </para>
    /// <para>
    /// [latexmath]
    /// ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++ \[
    /// a = -{1 \over 2}\sum_{i=0}^{n-1} x_f^i y_f^{i \oplus 1} - x_f^{i \oplus
    /// 1} y_f^i \]
    /// ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
    /// </para>
    /// <para>
    /// where latexmath:[$x_f^i$] and latexmath:[$y_f^i$] are the [eq]#x# and
    /// [eq]#y# framebuffer coordinates of the [eq]##i##th vertex of the
    /// [eq]#n#-vertex polygon (vertices are numbered starting at zero for the
    /// purposes of this computation) and [eq]#i {oplus} 1# is [eq]#(i + 1) mod
    /// n#.
    /// </para>
    /// <para>
    /// If pname:frontFace is set to ename:VK_FRONT_FACE_COUNTER_CLOCKWISE, a
    /// triangle with positive area is considered front-facing. If it is set to
    /// ename:VK_FRONT_FACE_CLOCKWISE, a triangle with negative area is
    /// considered front-facing. Any triangle which is not front-facing is
    /// back-facing, including zero-area triangles.
    /// </para>
    /// </summary>
    public enum FrontFace
    {
        /// <summary>
        /// -
        /// </summary>
        CounterClockwise = 0, 
        
        /// <summary>
        /// -
        /// </summary>
        Clockwise = 1, 
    }
    
    /// <summary>
    /// <para>
    /// Layout of image and image subresources.
    /// </para>
    /// <para>
    /// For each mechanism of accessing an image in the API, there is a
    /// parameter or structure member that controls the image layout used to
    /// access the image. For transfer commands, this is a parameter to the
    /// command (see &lt;&lt;clears&gt;&gt; and &lt;&lt;copies&gt;&gt;). For
    /// use as a framebuffer attachment, this is a member in the substructures
    /// of the sname:VkRenderPassCreateInfo (see &lt;&lt;renderpass,Render
    /// Pass&gt;&gt;). For use in a descriptor set, this is a member in the
    /// sname:VkDescriptorImageInfo structure (see
    /// &lt;&lt;descriptorsets-updates&gt;&gt;). At the time that any command
    /// buffer command accessing an image executes on any queue, the layouts of
    /// the image subresources that are accessed must: all match the layout
    /// specified via the API controlling those accesses.
    /// </para>
    /// <para>
    /// The image layout of each image subresource must: be well-defined at
    /// each point in the image subresource's lifetime. This means that when
    /// performing a layout transition on the image subresource, the old layout
    /// value must: either equal the current layout of the image subresource
    /// (at the time the transition executes), or else be
    /// ename:VK_IMAGE_LAYOUT_UNDEFINED (implying that the contents of the
    /// image subresource need not be preserved). The new layout used in a
    /// transition must: not be ename:VK_IMAGE_LAYOUT_UNDEFINED or
    /// ename:VK_IMAGE_LAYOUT_PREINITIALIZED.
    /// </para>
    /// </summary>
    public enum ImageLayout
    {
        /// <summary>
        /// ename:VK_IMAGE_LAYOUT_UNDEFINED: Supports no device access. This
        /// layout must: only be used as the pname:initialLayout member of
        /// sname:VkImageCreateInfo or sname:VkAttachmentDescription, or as the
        /// pname:oldLayout in an image transition. When transitioning out of
        /// this layout, the contents of the memory are not guaranteed to be
        /// preserved.
        /// </summary>
        Undefined = 0, 
        
        /// <summary>
        /// ename:VK_IMAGE_LAYOUT_GENERAL: Supports all types of device access.
        /// </summary>
        General = 1, 
        
        /// <summary>
        /// ename:VK_IMAGE_LAYOUT_COLOR_ATTACHMENT_OPTIMAL: must: only be used
        /// as a color or resolve attachment in a sname:VkFramebuffer. This
        /// layout is valid only for image subresources of images created with
        /// the ename:VK_IMAGE_USAGE_COLOR_ATTACHMENT_BIT usage bit enabled.
        /// </summary>
        ColorAttachmentOptimal = 2, 
        
        /// <summary>
        /// ename:VK_IMAGE_LAYOUT_DEPTH_STENCIL_ATTACHMENT_OPTIMAL: must: only
        /// be used as a depth/stencil attachment in a sname:VkFramebuffer.
        /// This layout is valid only for image subresources of images created
        /// with the ename:VK_IMAGE_USAGE_DEPTH_STENCIL_ATTACHMENT_BIT usage
        /// bit enabled.
        /// </summary>
        DepthStencilAttachmentOptimal = 3, 
        
        /// <summary>
        /// ename:VK_IMAGE_LAYOUT_DEPTH_STENCIL_READ_ONLY_OPTIMAL: must: only
        /// be used as a read-only depth/stencil attachment in a
        /// sname:VkFramebuffer and/or as a read-only image in a shader (which
        /// can: be read as a sampled image, combined image/sampler and/or
        /// input attachment). This layout is valid only for image subresources
        /// of images created with the
        /// ename:VK_IMAGE_USAGE_DEPTH_STENCIL_ATTACHMENT_BIT usage bit
        /// enabled. Only image subresources of images created with
        /// ename:VK_IMAGE_USAGE_SAMPLED_BIT can: be used as sampled image or
        /// combined image/sampler in a shader. Similarly, only image
        /// subresources of images created with
        /// ename:VK_IMAGE_USAGE_INPUT_ATTACHMENT_BIT can: be used as input
        /// attachments.
        /// </summary>
        DepthStencilReadOnlyOptimal = 4, 
        
        /// <summary>
        /// ename:VK_IMAGE_LAYOUT_SHADER_READ_ONLY_OPTIMAL: must: only be used
        /// as a read-only image in a shader (which can: be read as a sampled
        /// image, combined image/sampler and/or input attachment). This layout
        /// is valid only for image subresources of images created with the
        /// ename:VK_IMAGE_USAGE_SAMPLED_BIT or
        /// ename:VK_IMAGE_USAGE_INPUT_ATTACHMENT_BIT usage bit enabled.
        /// </summary>
        ShaderReadOnlyOptimal = 5, 
        
        /// <summary>
        /// ename:VK_IMAGE_LAYOUT_TRANSFER_SRC_OPTIMAL: must: only be used as a
        /// source image of a transfer command (see the definition of
        /// &lt;&lt;synchronization-transfer,ename:VK_PIPELINE_STAGE_TRANSFER_BIT&gt;&gt;). This
        /// layout is valid only for image subresources of images created with
        /// the ename:VK_IMAGE_USAGE_TRANSFER_SRC_BIT usage bit enabled.
        /// </summary>
        TransferSourceOptimal = 6, 
        
        /// <summary>
        /// ename:VK_IMAGE_LAYOUT_TRANSFER_DST_OPTIMAL: must: only be used as a
        /// destination image of a transfer command. This layout is valid only
        /// for image subresources of images created with the
        /// ename:VK_IMAGE_USAGE_TRANSFER_DST_BIT usage bit enabled.
        /// ifdef::VK_KHR_swapchain[]
        /// </summary>
        TransferDestinationOptimal = 7, 
        
        /// <summary>
        /// ename:VK_IMAGE_LAYOUT_PREINITIALIZED: Supports no device access.
        /// This layout must: only be used as the pname:initialLayout member of
        /// sname:VkImageCreateInfo or sname:VkAttachmentDescription, or as the
        /// pname:oldLayout in an image transition. When transitioning out of
        /// this layout, the contents of the memory are preserved. This layout
        /// is intended to be used as the initial layout for an image whose
        /// contents are written by the host, and hence the data can: be
        /// written to memory immediately, without first executing a layout
        /// transition. Currently, ename:VK_IMAGE_LAYOUT_PREINITIALIZED is only
        /// useful with ename:VK_IMAGE_TILING_LINEAR images because there is
        /// not a standard layout defined for ename:VK_IMAGE_TILING_OPTIMAL
        /// images.
        /// </summary>
        Preinitialized = 8, 
        
        /// <summary>
        /// ename:VK_IMAGE_LAYOUT_PRESENT_SRC_KHR: must: only be used for
        /// presenting a swapchain image for display. A swapchain's image must:
        /// be transitioned to this layout before calling
        /// flink:vkQueuePresentKHR, and must: be transitioned away from this
        /// layout after calling flink:vkAcquireNextImageKHR.
        /// endif::VK_KHR_swapchain[]
        /// </summary>
        PresentSource = 1000001002, 
    }
    
    /// <summary>
    /// <para>
    /// Specifies the tiling arrangement of data in an image.
    /// </para>
    /// <para>
    /// ename:VK_IMAGE_TILING_OPTIMAL specifies optimal tiling (texels are laid
    /// out in an implementation-dependent arrangement, for more optimal memory
    /// access), and ename:VK_IMAGE_TILING_LINEAR specifies linear tiling
    /// (texels are laid out in memory in row-major order, possibly with some
    /// padding on each row).
    /// </para>
    /// </summary>
    public enum ImageTiling
    {
        /// <summary>
        /// -
        /// </summary>
        Optimal = 0, 
        
        /// <summary>
        /// -
        /// </summary>
        Linear = 1, 
    }
    
    /// <summary>
    /// <para>
    /// Specifies the type of an image object.
    /// </para>
    /// <para>
    /// These values specify one-, two-, or three-dimensional images,
    /// respectively.
    /// </para>
    /// </summary>
    public enum ImageType
    {
        /// <summary>
        /// -
        /// </summary>
        Image1d = 0, 
        
        /// <summary>
        /// -
        /// </summary>
        Image2d = 1, 
        
        /// <summary>
        /// -
        /// </summary>
        Image3d = 2, 
    }
    
    /// <summary>
    /// <para>
    /// Image view types.
    /// </para>
    /// <para>
    /// The exact image view type is partially implicit, based on the image's
    /// type and sample count, as well as the view creation parameters as
    /// described in the &lt;&lt;resources-image-views-compatibility,table
    /// below&gt;&gt;. This table also shows which SPIR-V OpTypeImage Dim and
    /// Arrayed parameters correspond to each image view type.
    /// </para>
    /// </summary>
    public enum ImageViewType
    {
        /// <summary>
        /// -
        /// </summary>
        ImageView1d = 0, 
        
        /// <summary>
        /// -
        /// </summary>
        ImageView2d = 1, 
        
        /// <summary>
        /// -
        /// </summary>
        ImageView3d = 2, 
        
        /// <summary>
        /// -
        /// </summary>
        Cube = 3, 
        
        /// <summary>
        /// -
        /// </summary>
        ImageView1dArray = 4, 
        
        /// <summary>
        /// -
        /// </summary>
        ImageView2dArray = 5, 
        
        /// <summary>
        /// -
        /// </summary>
        CubeArray = 6, 
    }
    
    /// <summary>
    /// <para>
    /// Type of index buffer indices.
    /// </para>
    /// <para>
    /// .Valid Usage **** * pname:offset must: be less than the size of
    /// pname:buffer * The sum of pname:offset and the address of the range of
    /// sname:VkDeviceMemory object that is backing pname:buffer, must: be a
    /// multiple of the type indicated by pname:indexType * pname:buffer must:
    /// have been created with the ename:VK_BUFFER_USAGE_INDEX_BUFFER_BIT flag
    /// ****
    /// </para>
    /// </summary>
    public enum IndexType
    {
        /// <summary>
        /// -
        /// </summary>
        UInt16 = 0, 
        
        /// <summary>
        /// -
        /// </summary>
        UInt32 = 1, 
    }
    
    /// <summary>
    /// Allocation type.
    /// </summary>
    public enum InternalAllocationType
    {
        /// <summary>
        /// ename:VK_INTERNAL_ALLOCATION_TYPE_EXECUTABLE - The allocation is
        /// intended for execution by the host.
        /// </summary>
        Executable = 0, 
    }
    
    /// <summary>
    /// <para>
    /// Framebuffer logical operations.
    /// </para>
    /// <para>
    /// &lt;&lt;&lt;
    /// </para>
    /// <para>
    /// The logical operations supported by Vulkan are summarized in the
    /// following table in which
    /// </para>
    /// <para>
    /// * [eq]#{lnot}# is bitwise invert, * [eq]#{land}# is bitwise and, *
    /// [eq]#{lor}# is bitwise or, * [eq]#{oplus}# is bitwise exclusive or, *
    /// [eq]#s# is the fragment's [eq]#R~s0~, G~s0~, B~s0~# or [eq]#A~s0~#
    /// component value for the fragment output corresponding to the color
    /// attachment being updated, and * [eq]#d# is the color attachment's
    /// [eq]#R, G, B# or [eq]#A# component value:
    /// </para>
    /// <para>
    /// .Logical Operations [width="75%",options="header",align="center"] |====
    /// |Mode | Operation |ename:VK_LOGIC_OP_CLEAR | [eq]#0#
    /// |ename:VK_LOGIC_OP_AND | [eq]#s {land} d#
    /// |ename:VK_LOGIC_OP_AND_REVERSE | [eq]#s {land} {lnot} d#
    /// |ename:VK_LOGIC_OP_COPY | [eq]#s# |ename:VK_LOGIC_OP_AND_INVERTED |
    /// [eq]#{lnot} s {land} d# |ename:VK_LOGIC_OP_NO_OP | [eq]#d#
    /// |ename:VK_LOGIC_OP_XOR | [eq]#s {oplus} d# |ename:VK_LOGIC_OP_OR |
    /// [eq]#s {lor} d# |ename:VK_LOGIC_OP_NOR | [eq]#{lnot} (s {lor} d)#
    /// |ename:VK_LOGIC_OP_EQUIVALENT | [eq]#{lnot} (s {oplus} d)#
    /// |ename:VK_LOGIC_OP_INVERT | [eq]#{lnot} d#
    /// |ename:VK_LOGIC_OP_OR_REVERSE | [eq]#s {lor} {lnot} d#
    /// |ename:VK_LOGIC_OP_COPY_INVERTED | [eq]#{lnot} s#
    /// |ename:VK_LOGIC_OP_OR_INVERTED | [eq]#{lnot} s {lor} d#
    /// |ename:VK_LOGIC_OP_NAND | [eq]#{lnot} (s {land} d)#
    /// |ename:VK_LOGIC_OP_SET | all 1s |====
    /// </para>
    /// <para>
    /// The result of the logical operation is then written to the color
    /// attachment as controlled by the component write mask, described in
    /// &lt;&lt;framebuffer-blendoperations,Blend Operations&gt;&gt;.
    /// </para>
    /// </summary>
    public enum LogicOp
    {
        /// <summary>
        /// -
        /// </summary>
        Clear = 0, 
        
        /// <summary>
        /// -
        /// </summary>
        And = 1, 
        
        /// <summary>
        /// -
        /// </summary>
        AndReverse = 2, 
        
        /// <summary>
        /// -
        /// </summary>
        Copy = 3, 
        
        /// <summary>
        /// -
        /// </summary>
        AndInverted = 4, 
        
        /// <summary>
        /// -
        /// </summary>
        NoOp = 5, 
        
        /// <summary>
        /// -
        /// </summary>
        Xor = 6, 
        
        /// <summary>
        /// -
        /// </summary>
        Or = 7, 
        
        /// <summary>
        /// -
        /// </summary>
        Nor = 8, 
        
        /// <summary>
        /// -
        /// </summary>
        Equivalent = 9, 
        
        /// <summary>
        /// -
        /// </summary>
        Invert = 10, 
        
        /// <summary>
        /// -
        /// </summary>
        OrReverse = 11, 
        
        /// <summary>
        /// -
        /// </summary>
        CopyInverted = 12, 
        
        /// <summary>
        /// -
        /// </summary>
        OrInverted = 13, 
        
        /// <summary>
        /// -
        /// </summary>
        Nand = 14, 
        
        /// <summary>
        /// -
        /// </summary>
        Set = 15, 
    }
    
    /// <summary>
    /// <para>
    /// Supported physical device types.
    /// </para>
    /// <para>
    /// The physical device type is advertised for informational purposes only,
    /// and does not directly affect the operation of the system. However, the
    /// device type may: correlate with other advertised properties or
    /// capabilities of the system, such as how many memory heaps there are.
    /// </para>
    /// </summary>
    public enum PhysicalDeviceType
    {
        /// <summary>
        /// ename:VK_PHYSICAL_DEVICE_TYPE_OTHER The device does not match any
        /// other available types.
        /// </summary>
        Other = 0, 
        
        /// <summary>
        /// ename:VK_PHYSICAL_DEVICE_TYPE_INTEGRATED_GPU The device is
        /// typically one embedded in or tightly coupled with the host.
        /// </summary>
        IntegratedGpu = 1, 
        
        /// <summary>
        /// ename:VK_PHYSICAL_DEVICE_TYPE_DISCRETE_GPU The device is typically
        /// a separate processor connected to the host via an interlink.
        /// </summary>
        DiscreteGpu = 2, 
        
        /// <summary>
        /// ename:VK_PHYSICAL_DEVICE_TYPE_VIRTUAL_GPU The device is typically a
        /// virtual node in a virtualization environment.
        /// </summary>
        VirtualGpu = 3, 
        
        /// <summary>
        /// ename:VK_PHYSICAL_DEVICE_TYPE_CPU The device is typically running
        /// on the same processors as the host.
        /// </summary>
        Cpu = 4, 
    }
    
    /// <summary>
    /// <para>
    /// Specify the bind point of a pipeline object to a command buffer.
    /// </para>
    /// <para>
    /// Once bound, a pipeline binding affects subsequent graphics or compute
    /// commands in the command buffer until a different pipeline is bound to
    /// the bind point. The pipeline bound to
    /// ename:VK_PIPELINE_BIND_POINT_COMPUTE controls the behavior of
    /// flink:vkCmdDispatch and flink:vkCmdDispatchIndirect. The pipeline bound
    /// to ename:VK_PIPELINE_BIND_POINT_GRAPHICS controls the behavior of
    /// flink:vkCmdDraw, flink:vkCmdDrawIndexed, flink:vkCmdDrawIndirect, and
    /// flink:vkCmdDrawIndexedIndirect. No other commands are affected by the
    /// pipeline state.
    /// </para>
    /// <para>
    /// .Valid Usage **** * If pname:pipelineBindPoint is
    /// ename:VK_PIPELINE_BIND_POINT_COMPUTE, the sname:VkCommandPool that
    /// pname:commandBuffer was allocated from must: support compute operations
    /// * If pname:pipelineBindPoint is ename:VK_PIPELINE_BIND_POINT_GRAPHICS,
    /// the sname:VkCommandPool that pname:commandBuffer was allocated from
    /// must: support graphics operations * If pname:pipelineBindPoint is
    /// ename:VK_PIPELINE_BIND_POINT_COMPUTE, pname:pipeline must: be a compute
    /// pipeline * If pname:pipelineBindPoint is
    /// ename:VK_PIPELINE_BIND_POINT_GRAPHICS, pname:pipeline must: be a
    /// graphics pipeline * If the
    /// &lt;&lt;features-features-variableMultisampleRate,variable multisample
    /// rate&gt;&gt; feature is not supported, pname:pipeline is a graphics
    /// pipeline, the current subpass has no attachments, and this is not the
    /// first call to this function with a graphics pipeline after
    /// transitioning to the current subpass, then the sample count specified
    /// by this pipeline must: match that set in the previous pipeline ****
    /// </para>
    /// </summary>
    public enum PipelineBindPoint
    {
        /// <summary>
        /// -
        /// </summary>
        Graphics = 0, 
        
        /// <summary>
        /// -
        /// </summary>
        Compute = 1, 
    }
    
    /// <summary>
    /// <para>
    /// Encode pipeline cache version.
    /// </para>
    /// <para>
    /// A consumer of the pipeline cache should: use the cache version to
    /// interpret the remainder of the cache header.
    /// </para>
    /// </summary>
    public enum PipelineCacheHeaderVersion
    {
        /// <summary>
        /// -
        /// </summary>
        One = 1, 
    }
    
    /// <summary>
    /// <para>
    /// Control polygon rasterization mode.
    /// </para>
    /// <para>
    /// The pname:polygonMode selects which method of rasterization is used for
    /// polygons. If pname:polygonMode is ename:VK_POLYGON_MODE_POINT, then the
    /// vertices of polygons are treated, for rasterization purposes, as if
    /// they had been drawn as points. ename:VK_POLYGON_MODE_LINE causes
    /// polygon edges to be drawn as line segments. ename:VK_POLYGON_MODE_FILL
    /// causes polygons to render using the polygon rasterization rules in this
    /// section.
    /// </para>
    /// <para>
    /// Note that these modes affect only the final rasterization of polygons:
    /// in particular, a polygon's vertices are shaded and the polygon is
    /// clipped and possibly culled before these modes are applied.
    /// </para>
    /// </summary>
    public enum PolygonMode
    {
        /// <summary>
        /// -
        /// </summary>
        Fill = 0, 
        
        /// <summary>
        /// -
        /// </summary>
        Line = 1, 
        
        /// <summary>
        /// -
        /// </summary>
        Point = 2, 
    }
    
    /// <summary>
    /// <para>
    /// Presentation mode supported for a surface.
    /// </para>
    /// <para>
    /// [NOTE] .Note ==== For reference, the mode indicated by
    /// ename:VK_PRESENT_MODE_FIFO_KHR is equivalent to the behavior of
    /// {wgl|glX|egl}SwapBuffers with a swap interval of 1, while the mode
    /// indicated by ename:VK_PRESENT_MODE_FIFO_RELAXED_KHR is equivalent to
    /// the behavior of {wgl|glX}SwapBuffers with a swap interval of -1 (from
    /// the {WGL|GLX}_EXT_swap_control_tear extensions). ====
    /// </para>
    /// </summary>
    public enum PresentMode
    {
        /// <summary>
        /// ename:VK_PRESENT_MODE_IMMEDIATE_KHR: The presentation engine does
        /// not wait for a vertical blanking period to update the current
        /// image, meaning this mode may: result in visible tearing. No
        /// internal queuing of presentation requests is needed, as the
        /// requests are applied immediately.
        /// </summary>
        Immediate = 0, 
        
        /// <summary>
        /// ename:VK_PRESENT_MODE_MAILBOX_KHR: The presentation engine waits
        /// for the next vertical blanking period to update the current image.
        /// Tearing cannot: be observed. An internal single-entry queue is used
        /// to hold pending presentation requests. If the queue is full when a
        /// new presentation request is received, the new request replaces the
        /// existing entry, and any images associated with the prior entry
        /// become available for re-use by the application. One request is
        /// removed from the queue and processed during each vertical blanking
        /// period in which the queue is non-empty.
        /// </summary>
        Mailbox = 1, 
        
        /// <summary>
        /// ename:VK_PRESENT_MODE_FIFO_KHR: The presentation engine waits for
        /// the next vertical blanking period to update the current image.
        /// Tearing cannot: be observed. An internal queue is used to hold
        /// pending presentation requests. New requests are appended to the end
        /// of the queue, and one request is removed from the beginning of the
        /// queue and processed during each vertical blanking period in which
        /// the queue is non-empty. This is the only value of pname:presentMode
        /// that is required: to be supported.
        /// </summary>
        Fifo = 2, 
        
        /// <summary>
        /// ename:VK_PRESENT_MODE_FIFO_RELAXED_KHR: The presentation engine
        /// generally waits for the next vertical blanking period to update the
        /// current image. If a vertical blanking period has already passed
        /// since the last update of the current image then the presentation
        /// engine does not wait for another vertical blanking period for the
        /// update, meaning this mode may: result in visible tearing in this
        /// case. This mode is useful for reducing visual stutter with an
        /// application that will mostly present a new image before the next
        /// vertical blanking period, but may occasionally be late, and present
        /// a new image just after the next vertical blanking period. An
        /// internal queue is used to hold pending presentation requests. New
        /// requests are appended to the end of the queue, and one request is
        /// removed from the beginning of the queue and processed during or
        /// after each vertical blanking period in which the queue is
        /// non-empty.
        /// </summary>
        FifoRelaxed = 3, 
    }
    
    /// <summary>
    /// Supported primitive topologies.
    /// </summary>
    public enum PrimitiveTopology
    {
        /// <summary>
        /// -
        /// </summary>
        PointList = 0, 
        
        /// <summary>
        /// -
        /// </summary>
        LineList = 1, 
        
        /// <summary>
        /// -
        /// </summary>
        LineStrip = 2, 
        
        /// <summary>
        /// -
        /// </summary>
        TriangleList = 3, 
        
        /// <summary>
        /// -
        /// </summary>
        TriangleStrip = 4, 
        
        /// <summary>
        /// -
        /// </summary>
        TriangleFan = 5, 
        
        /// <summary>
        /// -
        /// </summary>
        LineListWithAdjacency = 6, 
        
        /// <summary>
        /// -
        /// </summary>
        LineStripWithAdjacency = 7, 
        
        /// <summary>
        /// -
        /// </summary>
        TriangleListWithAdjacency = 8, 
        
        /// <summary>
        /// -
        /// </summary>
        TriangleStripWithAdjacency = 9, 
        
        /// <summary>
        /// -
        /// </summary>
        PatchList = 10, 
    }
    
    /// <summary>
    /// <para>
    /// Specify the type of queries managed by a query pool.
    /// </para>
    /// <para>
    /// .Valid Usage **** * If the
    /// &lt;&lt;features-features-pipelineStatisticsQuery,pipeline statistics
    /// queries&gt;&gt; feature is not enabled, pname:queryType must: not be
    /// ename:VK_QUERY_TYPE_PIPELINE_STATISTICS * If pname:queryType is
    /// ename:VK_QUERY_TYPE_PIPELINE_STATISTICS, pname:pipelineStatistics must:
    /// be a valid combination of elink:VkQueryPipelineStatisticFlagBits values
    /// ****
    /// </para>
    /// </summary>
    public enum QueryType
    {
        /// <summary>
        /// -
        /// </summary>
        Occlusion = 0, 
        
        /// <summary>
        /// Optional
        /// </summary>
        PipelineStatistics = 1, 
        
        /// <summary>
        /// -
        /// </summary>
        Timestamp = 2, 
    }
    
    /// <summary>
    /// -
    /// </summary>
    public enum RasterizationOrder
    {
        /// <summary>
        /// -
        /// </summary>
        Strict = 0, 
        
        /// <summary>
        /// -
        /// </summary>
        Relaxed = 1, 
    }
    
    /// <summary>
    /// <para>
    /// Vulkan command return codes.
    /// </para>
    /// <para>
    /// While the core Vulkan API is not designed to capture incorrect usage,
    /// some circumstances still require return codes. Commands in Vulkan
    /// return their status via return codes that are in one of two categories:
    /// </para>
    /// <para>
    /// * Successful completion codes are returned when a command needs to
    /// communicate success or status information. All successful completion
    /// codes are non-negative values. * Run time error codes are returned when
    /// a command needs to communicate a failure that could only be detected at
    /// run time. All run time error codes are negative values.
    /// </para>
    /// <para>
    /// .Success Codes * ename:VK_SUCCESS Command successfully completed *
    /// ename:VK_NOT_READY A fence or query has not yet completed *
    /// ename:VK_TIMEOUT A wait operation has not completed in the specified
    /// time * ename:VK_EVENT_SET An event is signaled * ename:VK_EVENT_RESET
    /// An event is unsignaled * ename:VK_INCOMPLETE A return array was too
    /// small for the result ifdef::VK_KHR_swapchain[] *
    /// ename:VK_SUBOPTIMAL_KHR A swapchain no longer matches the surface
    /// properties exactly, but can: still be used to present to the surface
    /// successfully. endif::VK_KHR_swapchain[]
    /// </para>
    /// <para>
    /// .Error codes * ename:VK_ERROR_OUT_OF_HOST_MEMORY A host memory
    /// allocation has failed. * ename:VK_ERROR_OUT_OF_DEVICE_MEMORY A device
    /// memory allocation has failed. * ename:VK_ERROR_INITIALIZATION_FAILED
    /// Initialization of an object could not be completed for
    /// implementation-specific reasons. * ename:VK_ERROR_DEVICE_LOST The
    /// logical or physical device has been lost. See
    /// &lt;&lt;devsandqueues-lost-device,Lost Device&gt;&gt; *
    /// ename:VK_ERROR_MEMORY_MAP_FAILED Mapping of a memory object has failed.
    /// * ename:VK_ERROR_LAYER_NOT_PRESENT A requested layer is not present or
    /// could not be loaded. * ename:VK_ERROR_EXTENSION_NOT_PRESENT A requested
    /// extension is not supported. * ename:VK_ERROR_FEATURE_NOT_PRESENT A
    /// requested feature is not supported. *
    /// ename:VK_ERROR_INCOMPATIBLE_DRIVER The requested version of Vulkan is
    /// not supported by the driver or is otherwise incompatible for
    /// implementation-specific reasons. * ename:VK_ERROR_TOO_MANY_OBJECTS Too
    /// many objects of the type have already been created. *
    /// ename:VK_ERROR_FORMAT_NOT_SUPPORTED A requested format is not supported
    /// on this device. * ename:VK_ERROR_FRAGMENTED_POOL A requested pool
    /// allocation has failed due to fragmentation of the pool's memory.
    /// ifdef::VK_KHR_surface[] * ename:VK_ERROR_SURFACE_LOST_KHR A surface is
    /// no longer available. * ename:VK_ERROR_NATIVE_WINDOW_IN_USE_KHR The
    /// requested window is already in use by Vulkan or another API in a manner
    /// which prevents it from being used again. endif::VK_KHR_surface[]
    /// ifdef::VK_KHR_swapchain[] * ename:VK_ERROR_OUT_OF_DATE_KHR A surface
    /// has changed in such a way that it is no longer compatible with the
    /// swapchain, and further presentation requests using the swapchain will
    /// fail. Applications must: query the new surface properties and recreate
    /// their swapchain if they wish to continue presenting to the surface.
    /// endif::VK_KHR_swapchain[] ifdef::VK_KHR_display_swapchain[] *
    /// ename:VK_ERROR_INCOMPATIBLE_DISPLAY_KHR The display used by a swapchain
    /// does not use the same presentable image layout, or is incompatible in a
    /// way that prevents sharing an image. endif::VK_KHR_display_swapchain[]
    /// ifdef::VK_NV_glsl_shader[] * ename:VK_ERROR_INVALID_SHADER_NV One or
    /// more shaders failed to compile or link. More details are reported back
    /// to the application via +VK_EXT_debug_report+ if enabled.
    /// endif::VK_NV_glsl_shader[]
    /// </para>
    /// <para>
    /// If a command returns a run time error, it will leave any result
    /// pointers unmodified, unless other behavior is explicitly defined in the
    /// specification.
    /// </para>
    /// <para>
    /// Out of memory errors do not damage any currently existing Vulkan
    /// objects. Objects that have already been successfully created can: still
    /// be used by the application.
    /// </para>
    /// <para>
    /// Performance-critical commands generally do not have return codes. If a
    /// run time error occurs in such commands, the implementation will defer
    /// reporting the error until a specified point. For commands that record
    /// into command buffers (ftext:vkCmd*) run time errors are reported by
    /// fname:vkEndCommandBuffer.
    /// </para>
    /// </summary>
    public enum Result
    {
        /// <summary>
        /// Command completed successfully
        /// </summary>
        Success = 0, 
        
        /// <summary>
        /// A fence or query has not yet completed
        /// </summary>
        NotReady = 1, 
        
        /// <summary>
        /// A wait operation has not completed in the specified time
        /// </summary>
        Timeout = 2, 
        
        /// <summary>
        /// An event is signaled
        /// </summary>
        EventSet = 3, 
        
        /// <summary>
        /// An event is unsignaled
        /// </summary>
        EventReset = 4, 
        
        /// <summary>
        /// A return array was too small for the result
        /// </summary>
        Incomplete = 5, 
        
        /// <summary>
        /// A host memory allocation has failed
        /// </summary>
        ErrorOutOfHostMemory = -1, 
        
        /// <summary>
        /// A device memory allocation has failed
        /// </summary>
        ErrorOutOfDeviceMemory = -2, 
        
        /// <summary>
        /// Initialization of a object has failed
        /// </summary>
        ErrorInitializationFailed = -3, 
        
        /// <summary>
        /// The logical device has been lost. See
        /// &lt;&lt;devsandqueues-lost-device&gt;&gt;
        /// </summary>
        ErrorDeviceLost = -4, 
        
        /// <summary>
        /// Mapping of a memory object has failed
        /// </summary>
        ErrorMemoryMapFailed = -5, 
        
        /// <summary>
        /// Layer specified does not exist
        /// </summary>
        ErrorLayerNotPresent = -6, 
        
        /// <summary>
        /// Extension specified does not exist
        /// </summary>
        ErrorExtensionNotPresent = -7, 
        
        /// <summary>
        /// Requested feature is not available on this device
        /// </summary>
        ErrorFeatureNotPresent = -8, 
        
        /// <summary>
        /// Unable to find a Vulkan driver
        /// </summary>
        ErrorIncompatibleDriver = -9, 
        
        /// <summary>
        /// Too many objects of the type have already been created
        /// </summary>
        ErrorTooManyObjects = -10, 
        
        /// <summary>
        /// Requested format is not supported on this device
        /// </summary>
        ErrorFormatNotSupported = -11, 
        
        /// <summary>
        /// A requested pool allocation has failed due to fragmentation of the
        /// pool's memory
        /// </summary>
        ErrorFragmentedPool = -12, 
        
        /// <summary>
        /// -
        /// </summary>
        ErrorSurfaceLost = -1000000000, 
        
        /// <summary>
        /// -
        /// </summary>
        ErrorNativeWindowInUse = -1000000001, 
        
        /// <summary>
        /// -
        /// </summary>
        Suboptimal = 1000001003, 
        
        /// <summary>
        /// -
        /// </summary>
        ErrorOutOfDate = -1000001004, 
        
        /// <summary>
        /// -
        /// </summary>
        ErrorIncompatibleDisplay = -1000003001, 
        
        /// <summary>
        /// -
        /// </summary>
        ErrorValidationFailed = -1000011001, 
        
        /// <summary>
        /// -
        /// </summary>
        ErrorInvalidShader = -1000012000, 
    }
    
    /// <summary>
    /// <para>
    /// Specify behavior of sampling with texture coordinates outside an image.
    /// </para>
    /// <para>
    /// The maximum number of sampler objects which can: be simultaneously
    /// created on a device is implementation-dependent and specified by the
    /// &lt;&lt;features-limits-maxSamplerAllocationCount,pname:maxSamplerAllocationCount&gt;&gt; member
    /// of the sname:VkPhysicalDeviceLimits structure. If
    /// pname:maxSamplerAllocationCount is exceeded, fname:vkCreateSampler will
    /// return ename:VK_ERROR_TOO_MANY_OBJECTS.
    /// </para>
    /// <para>
    /// Since sname:VkSampler is a non-dispatchable handle type,
    /// implementations may: return the same handle for sampler state vectors
    /// that are identical. In such cases, all such objects would only count
    /// once against the pname:maxSamplerAllocationCount limit.
    /// </para>
    /// <para>
    /// .Valid Usage **** * The absolute value of pname:mipLodBias must: be
    /// less than or equal to
    /// sname:VkPhysicalDeviceLimits::pname:maxSamplerLodBias * If the
    /// &lt;&lt;features-features-samplerAnisotropy,anisotropic sampling&gt;&gt;
    /// feature is not enabled, pname:anisotropyEnable must: be ename:VK_FALSE
    /// * If pname:anisotropyEnable is ename:VK_TRUE, pname:maxAnisotropy must:
    /// be between `1.0` and
    /// sname:VkPhysicalDeviceLimits::pname:maxSamplerAnisotropy, inclusive *
    /// If pname:unnormalizedCoordinates is ename:VK_TRUE, pname:minFilter and
    /// pname:magFilter must: be equal * If pname:unnormalizedCoordinates is
    /// ename:VK_TRUE, pname:mipmapMode must: be
    /// ename:VK_SAMPLER_MIPMAP_MODE_NEAREST * If pname:unnormalizedCoordinates
    /// is ename:VK_TRUE, pname:minLod and pname:maxLod must: be zero * If
    /// pname:unnormalizedCoordinates is ename:VK_TRUE, pname:addressModeU and
    /// pname:addressModeV must: each be either
    /// ename:VK_SAMPLER_ADDRESS_MODE_CLAMP_TO_EDGE or
    /// ename:VK_SAMPLER_ADDRESS_MODE_CLAMP_TO_BORDER * If
    /// pname:unnormalizedCoordinates is ename:VK_TRUE, pname:anisotropyEnable
    /// must: be ename:VK_FALSE * If pname:unnormalizedCoordinates is
    /// ename:VK_TRUE, pname:compareEnable must: be ename:VK_FALSE * If any of
    /// pname:addressModeU, pname:addressModeV or pname:addressModeW are
    /// ename:VK_SAMPLER_ADDRESS_MODE_CLAMP_TO_BORDER, pname:borderColor must:
    /// be a valid elink:VkBorderColor value * If the
    /// +VK_KHR_sampler_mirror_clamp_to_edge+ extension is not enabled,
    /// pname:addressModeU, pname:addressModeV and pname:addressModeW must: not
    /// be ename:VK_SAMPLER_ADDRESS_MODE_MIRROR_CLAMP_TO_EDGE * If
    /// pname:compareEnable is ename:VK_TRUE, pname:compareOp must: be a valid
    /// elink:VkCompareOp value ifdef::VK_IMG_filter_cubic[] * If either
    /// pname:magFilter or pname:minFilter is ename:VK_FILTER_CUBIC_IMG,
    /// pname:anisotropyEnable must: be ename:VK_FALSE
    /// endif::VK_IMG_filter_cubic[] ****
    /// </para>
    /// </summary>
    public enum SamplerAddressMode
    {
        /// <summary>
        /// ename:VK_SAMPLER_ADDRESS_MODE_REPEAT indicates that the repeat wrap
        /// mode will be used.
        /// </summary>
        Repeat = 0, 
        
        /// <summary>
        /// ename:VK_SAMPLER_ADDRESS_MODE_MIRRORED_REPEAT indicates that the
        /// mirrored repeat wrap mode will be used.
        /// </summary>
        MirroredRepeat = 1, 
        
        /// <summary>
        /// ename:VK_SAMPLER_ADDRESS_MODE_CLAMP_TO_EDGE indicates that the
        /// clamp to edge wrap mode will be used.
        /// </summary>
        ClampToEdge = 2, 
        
        /// <summary>
        /// ename:VK_SAMPLER_ADDRESS_MODE_CLAMP_TO_BORDER indicates that the
        /// clamp to border wrap mode will be used.
        /// </summary>
        ClampToBorder = 3, 
        
        /// <summary>
        /// ename:VK_SAMPLER_ADDRESS_MODE_MIRROR_CLAMP_TO_EDGE indicates that
        /// the mirror clamp to edge wrap mode will be used. This is only valid
        /// if the +VK_KHR_mirror_clamp_to_edge+ extension is enabled.
        /// </summary>
        MirrorClampToEdge = 4, 
    }
    
    /// <summary>
    /// Specify mipmap mode used for texture lookups.
    /// </summary>
    public enum SamplerMipmapMode
    {
        /// <summary>
        /// Choose nearest mip level
        /// </summary>
        Nearest = 0, 
        
        /// <summary>
        /// Linear filter between mip levels
        /// </summary>
        Linear = 1, 
    }
    
    /// <summary>
    /// <para>
    /// Buffer and image sharing modes.
    /// </para>
    /// <para>
    /// [NOTE] .Note ==== ename:VK_SHARING_MODE_CONCURRENT may: result in lower
    /// performance access to the buffer or image than
    /// ename:VK_SHARING_MODE_EXCLUSIVE. ====
    /// </para>
    /// <para>
    /// Ranges of buffers and image subresources of image objects created using
    /// ename:VK_SHARING_MODE_EXCLUSIVE must: only be accessed by queues in the
    /// same queue family at any given time. In order for a different queue
    /// family to be able to interpret the memory contents of a range or image
    /// subresource, the application must: transfer exclusive ownership of the
    /// range or image subresource between the source and destination queue
    /// families with the following sequence of operations:
    /// </para>
    /// <para>
    /// . Release exclusive ownership from the source queue family to the
    /// destination queue family. . Use semaphores to ensure proper execution
    /// control for the ownership transfer. . Acquire exclusive ownership for
    /// the destination queue family from the source queue family.
    /// </para>
    /// <para>
    /// To release exclusive ownership of a range of a buffer or image
    /// subresource of an image object, the application must: execute a buffer
    /// or image memory barrier, respectively (see slink:VkBufferMemoryBarrier
    /// and slink:VkImageMemoryBarrier) on a queue from the source queue
    /// family. The pname:srcQueueFamilyIndex parameter of the barrier must: be
    /// set to the source queue family index, and the pname:dstQueueFamilyIndex
    /// parameter to the destination queue family index.
    /// </para>
    /// <para>
    /// To acquire exclusive ownership, the application must: execute the same
    /// buffer or image memory barrier (i.e. an identically defined instance of
    /// the slink:VkBufferMemoryBarrier or slink:VkImageMemoryBarrier structure
    /// that was used for the exclusive ownership release) on a queue from the
    /// destination queue family.
    /// </para>
    /// <para>
    /// Upon creation, resources using ename:VK_SHARING_MODE_EXCLUSIVE are not
    /// owned by any queue family. A buffer or image memory barrier is not
    /// required to acquire ownership when no queue family owns the resource -
    /// it is implicitly acquired upon first use within a queue. However,
    /// images still require a &lt;&lt;resources-image-layouts,layout
    /// transition&gt;&gt; from ename:VK_IMAGE_LAYOUT_UNDEFINED or
    /// ename:VK_IMAGE_LAYOUT_PREINITIALIZED before being used on the first
    /// queue. This layout transition can: either be accomplished by an image
    /// memory barrier or by use in a render pass instance.
    /// </para>
    /// <para>
    /// Once a queue family has used a range or image subresource of an
    /// ename:VK_SHARING_MODE_EXCLUSIVE resource, its contents are undefined to
    /// other queue families unless ownership is transferred. The contents may:
    /// also become undefined for other reasons, e.g. as a result of writes to
    /// an image subresource that aliases the same memory. A queue family can:
    /// take ownership of a range or image subresource without an ownership
    /// transfer in the same way as for a resource that was just created,
    /// however doing so means any contents written by other queue families or
    /// via incompatible aliases are undefined.
    /// </para>
    /// </summary>
    public enum SharingMode
    {
        /// <summary>
        /// ename:VK_SHARING_MODE_EXCLUSIVE specifies that access to any range
        /// or image subresource of the object will be exclusive to a single
        /// queue family at a time.
        /// </summary>
        Exclusive = 0, 
        
        /// <summary>
        /// ename:VK_SHARING_MODE_CONCURRENT specifies that concurrent access
        /// to any range or image subresource of the object from multiple queue
        /// families is supported.
        /// </summary>
        Concurrent = 1, 
    }
    
    /// <summary>
    /// <para>
    /// Stencil comparison function.
    /// </para>
    /// <para>
    /// For purposes of increment and decrement, the stencil bits are
    /// considered as an unsigned integer.
    /// </para>
    /// <para>
    /// If the stencil test fails, the sample's coverage bit is cleared in the
    /// fragment. If there is no stencil framebuffer attachment, stencil
    /// modification cannot: occur, and it is as if the stencil tests always
    /// pass.
    /// </para>
    /// <para>
    /// If the stencil test passes, the pname:writeMask member of the
    /// slink:VkStencilOpState structures controls how the updated stencil
    /// value is written to the stencil framebuffer attachment.
    /// </para>
    /// <para>
    /// The least significant [eq]#s# bits of pname:writeMask, where [eq]#s# is
    /// the number of bits in the stencil framebuffer attachment, specify an
    /// integer mask. Where a [eq]#1# appears in this mask, the corresponding
    /// bit in the stencil value in the depth/stencil attachment is written;
    /// where a [eq]#0# appears, the bit is not written. The pname:writeMask
    /// value uses either the front-facing or back-facing state based on the
    /// facing-ness of the fragment. Fragments generated by front-facing
    /// primitives use the front mask and fragments generated by back-facing
    /// primitives use the back mask.
    /// </para>
    /// </summary>
    public enum StencilOp
    {
        /// <summary>
        /// ename:VK_STENCIL_OP_KEEP keeps the current value.
        /// </summary>
        Keep = 0, 
        
        /// <summary>
        /// ename:VK_STENCIL_OP_ZERO sets the value to 0.
        /// </summary>
        Zero = 1, 
        
        /// <summary>
        /// ename:VK_STENCIL_OP_REPLACE sets the value to pname:reference.
        /// </summary>
        Replace = 2, 
        
        /// <summary>
        /// ename:VK_STENCIL_OP_INCREMENT_AND_CLAMP increments the current
        /// value and clamps to the maximum representable unsigned value.
        /// </summary>
        IncrementAndClamp = 3, 
        
        /// <summary>
        /// ename:VK_STENCIL_OP_DECREMENT_AND_CLAMP decrements the current
        /// value and clamps to 0.
        /// </summary>
        DecrementAndClamp = 4, 
        
        /// <summary>
        /// ename:VK_STENCIL_OP_INVERT bitwise-inverts the current value.
        /// </summary>
        Invert = 5, 
        
        /// <summary>
        /// ename:VK_STENCIL_OP_INCREMENT_AND_WRAP increments the current value
        /// and wraps to 0 when the maximum value would have been exceeded.
        /// </summary>
        IncrementAndWrap = 6, 
        
        /// <summary>
        /// ename:VK_STENCIL_OP_DECREMENT_AND_WRAP decrements the current value
        /// and wraps to the maximum possible value when the value would go
        /// below 0.
        /// </summary>
        DecrementAndWrap = 7, 
    }
    
    /// <summary>
    /// -
    /// </summary>
    public enum StructureType
    {
        /// <summary>
        /// -
        /// </summary>
        ApplicationInfo = 0, 
        
        /// <summary>
        /// -
        /// </summary>
        InstanceCreateInfo = 1, 
        
        /// <summary>
        /// -
        /// </summary>
        DeviceQueueCreateInfo = 2, 
        
        /// <summary>
        /// -
        /// </summary>
        DeviceCreateInfo = 3, 
        
        /// <summary>
        /// -
        /// </summary>
        SubmitInfo = 4, 
        
        /// <summary>
        /// -
        /// </summary>
        MemoryAllocateInfo = 5, 
        
        /// <summary>
        /// -
        /// </summary>
        MappedMemoryRange = 6, 
        
        /// <summary>
        /// -
        /// </summary>
        BindSparseInfo = 7, 
        
        /// <summary>
        /// -
        /// </summary>
        FenceCreateInfo = 8, 
        
        /// <summary>
        /// -
        /// </summary>
        SemaphoreCreateInfo = 9, 
        
        /// <summary>
        /// -
        /// </summary>
        EventCreateInfo = 10, 
        
        /// <summary>
        /// -
        /// </summary>
        QueryPoolCreateInfo = 11, 
        
        /// <summary>
        /// -
        /// </summary>
        BufferCreateInfo = 12, 
        
        /// <summary>
        /// -
        /// </summary>
        BufferViewCreateInfo = 13, 
        
        /// <summary>
        /// -
        /// </summary>
        ImageCreateInfo = 14, 
        
        /// <summary>
        /// -
        /// </summary>
        ImageViewCreateInfo = 15, 
        
        /// <summary>
        /// -
        /// </summary>
        ShaderModuleCreateInfo = 16, 
        
        /// <summary>
        /// -
        /// </summary>
        PipelineCacheCreateInfo = 17, 
        
        /// <summary>
        /// -
        /// </summary>
        PipelineShaderStageCreateInfo = 18, 
        
        /// <summary>
        /// -
        /// </summary>
        PipelineVertexInputStateCreateInfo = 19, 
        
        /// <summary>
        /// -
        /// </summary>
        PipelineInputAssemblyStateCreateInfo = 20, 
        
        /// <summary>
        /// -
        /// </summary>
        PipelineTessellationStateCreateInfo = 21, 
        
        /// <summary>
        /// -
        /// </summary>
        PipelineViewportStateCreateInfo = 22, 
        
        /// <summary>
        /// -
        /// </summary>
        PipelineRasterizationStateCreateInfo = 23, 
        
        /// <summary>
        /// -
        /// </summary>
        PipelineMultisampleStateCreateInfo = 24, 
        
        /// <summary>
        /// -
        /// </summary>
        PipelineDepthStencilStateCreateInfo = 25, 
        
        /// <summary>
        /// -
        /// </summary>
        PipelineColorBlendStateCreateInfo = 26, 
        
        /// <summary>
        /// -
        /// </summary>
        PipelineDynamicStateCreateInfo = 27, 
        
        /// <summary>
        /// -
        /// </summary>
        GraphicsPipelineCreateInfo = 28, 
        
        /// <summary>
        /// -
        /// </summary>
        ComputePipelineCreateInfo = 29, 
        
        /// <summary>
        /// -
        /// </summary>
        PipelineLayoutCreateInfo = 30, 
        
        /// <summary>
        /// -
        /// </summary>
        SamplerCreateInfo = 31, 
        
        /// <summary>
        /// -
        /// </summary>
        DescriptorSetLayoutCreateInfo = 32, 
        
        /// <summary>
        /// -
        /// </summary>
        DescriptorPoolCreateInfo = 33, 
        
        /// <summary>
        /// -
        /// </summary>
        DescriptorSetAllocateInfo = 34, 
        
        /// <summary>
        /// -
        /// </summary>
        WriteDescriptorSet = 35, 
        
        /// <summary>
        /// -
        /// </summary>
        CopyDescriptorSet = 36, 
        
        /// <summary>
        /// -
        /// </summary>
        FramebufferCreateInfo = 37, 
        
        /// <summary>
        /// -
        /// </summary>
        RenderPassCreateInfo = 38, 
        
        /// <summary>
        /// -
        /// </summary>
        CommandPoolCreateInfo = 39, 
        
        /// <summary>
        /// -
        /// </summary>
        CommandBufferAllocateInfo = 40, 
        
        /// <summary>
        /// -
        /// </summary>
        CommandBufferInheritanceInfo = 41, 
        
        /// <summary>
        /// -
        /// </summary>
        CommandBufferBeginInfo = 42, 
        
        /// <summary>
        /// -
        /// </summary>
        RenderPassBeginInfo = 43, 
        
        /// <summary>
        /// -
        /// </summary>
        BufferMemoryBarrier = 44, 
        
        /// <summary>
        /// -
        /// </summary>
        ImageMemoryBarrier = 45, 
        
        /// <summary>
        /// -
        /// </summary>
        MemoryBarrier = 46, 
        
        /// <summary>
        /// -
        /// </summary>
        LoaderInstanceCreateInfo = 47, 
        
        /// <summary>
        /// -
        /// </summary>
        LoaderDeviceCreateInfo = 48, 
        
        /// <summary>
        /// -
        /// </summary>
        SwapchainCreateInfo = 1000001000, 
        
        /// <summary>
        /// -
        /// </summary>
        PresentInfo = 1000001001, 
        
        /// <summary>
        /// -
        /// </summary>
        DisplayModeCreateInfo = 1000002000, 
        
        /// <summary>
        /// -
        /// </summary>
        DisplaySurfaceCreateInfo = 1000002001, 
        
        /// <summary>
        /// -
        /// </summary>
        DisplayPresentInfo = 1000003000, 
        
        /// <summary>
        /// -
        /// </summary>
        XlibSurfaceCreateInfo = 1000004000, 
        
        /// <summary>
        /// -
        /// </summary>
        XcbSurfaceCreateInfo = 1000005000, 
        
        /// <summary>
        /// -
        /// </summary>
        WaylandSurfaceCreateInfo = 1000006000, 
        
        /// <summary>
        /// -
        /// </summary>
        MirSurfaceCreateInfo = 1000007000, 
        
        /// <summary>
        /// -
        /// </summary>
        AndroidSurfaceCreateInfo = 1000008000, 
        
        /// <summary>
        /// -
        /// </summary>
        Win32SurfaceCreateInfo = 1000009000, 
        
        /// <summary>
        /// -
        /// </summary>
        DebugReportCallbackCreateInfo = 1000011000, 
        
        /// <summary>
        /// -
        /// </summary>
        PipelineRasterizationStateRasterizationOrder = 1000018000, 
        
        /// <summary>
        /// -
        /// </summary>
        DebugMarkerObjectNameInfo = 1000022000, 
        
        /// <summary>
        /// -
        /// </summary>
        DebugMarkerObjectTagInfo = 1000022001, 
        
        /// <summary>
        /// -
        /// </summary>
        DebugMarkerMarkerInfo = 1000022002, 
        
        /// <summary>
        /// -
        /// </summary>
        DedicatedAllocationImageCreateInfo = 1000026000, 
        
        /// <summary>
        /// -
        /// </summary>
        DedicatedAllocationBufferCreateInfo = 1000026001, 
        
        /// <summary>
        /// -
        /// </summary>
        DedicatedAllocationMemoryAllocateInfo = 1000026002, 
        
        /// <summary>
        /// -
        /// </summary>
        ExternalMemoryImageCreateInfo = 1000056000, 
        
        /// <summary>
        /// -
        /// </summary>
        ExportMemoryAllocateInfo = 1000056001, 
        
        /// <summary>
        /// -
        /// </summary>
        ImportMemoryWin32HandleInfo = 1000057000, 
        
        /// <summary>
        /// -
        /// </summary>
        ExportMemoryWin32HandleInfo = 1000057001, 
        
        /// <summary>
        /// -
        /// </summary>
        Win32KeyedMutexAcquireReleaseInfo = 1000058000, 
        
        /// <summary>
        /// -
        /// </summary>
        ValidationFlags = 1000061000, 
    }
    
    /// <summary>
    /// <para>
    /// Specify how commands in the first subpass of a render pass are
    /// provided.
    /// </para>
    /// <para>
    /// After beginning a render pass instance, the command buffer is ready to
    /// record the commands for the first subpass of that render pass.
    /// </para>
    /// <para>
    /// .Valid Usage **** * If any of the pname:initialLayout or
    /// pname:finalLayout member of the sname:VkAttachmentDescription
    /// structures or the pname:layout member of the
    /// sname:VkAttachmentReference structures specified when creating the
    /// render pass specified in the pname:renderPass member of
    /// pname:pRenderPassBegin is
    /// ename:VK_IMAGE_LAYOUT_COLOR_ATTACHMENT_OPTIMAL then the corresponding
    /// attachment image subresource of the framebuffer specified in the
    /// pname:framebuffer member of pname:pRenderPassBegin must: have been
    /// created with ename:VK_IMAGE_USAGE_COLOR_ATTACHMENT_BIT set * If any of
    /// the pname:initialLayout or pname:finalLayout member of the
    /// sname:VkAttachmentDescription structures or the pname:layout member of
    /// the sname:VkAttachmentReference structures specified when creating the
    /// render pass specified in the pname:renderPass member of
    /// pname:pRenderPassBegin is
    /// ename:VK_IMAGE_LAYOUT_DEPTH_STENCIL_ATTACHMENT_OPTIMAL or
    /// ename:VK_IMAGE_LAYOUT_DEPTH_STENCIL_READ_ONLY_OPTIMAL then the
    /// corresponding attachment image subresource of the framebuffer specified
    /// in the pname:framebuffer member of pname:pRenderPassBegin must: have
    /// been created with ename:VK_IMAGE_USAGE_DEPTH_STENCIL_ATTACHMENT_BIT set
    /// * If any of the pname:initialLayout or pname:finalLayout member of the
    /// sname:VkAttachmentDescription structures or the pname:layout member of
    /// the sname:VkAttachmentReference structures specified when creating the
    /// render pass specified in the pname:renderPass member of
    /// pname:pRenderPassBegin is
    /// ename:VK_IMAGE_LAYOUT_SHADER_READ_ONLY_OPTIMAL then the corresponding
    /// attachment image subresource of the framebuffer specified in the
    /// pname:framebuffer member of pname:pRenderPassBegin must: have been
    /// created with ename:VK_IMAGE_USAGE_SAMPLED_BIT or
    /// ename:VK_IMAGE_USAGE_INPUT_ATTACHMENT_BIT set * If any of the
    /// pname:initialLayout or pname:finalLayout member of the
    /// sname:VkAttachmentDescription structures or the pname:layout member of
    /// the sname:VkAttachmentReference structures specified when creating the
    /// render pass specified in the pname:renderPass member of
    /// pname:pRenderPassBegin is ename:VK_IMAGE_LAYOUT_TRANSFER_SRC_OPTIMAL
    /// then the corresponding attachment image subresource of the framebuffer
    /// specified in the pname:framebuffer member of pname:pRenderPassBegin
    /// must: have been created with ename:VK_IMAGE_USAGE_TRANSFER_SRC_BIT set
    /// * If any of the pname:initialLayout or pname:finalLayout member of the
    /// sname:VkAttachmentDescription structures or the pname:layout member of
    /// the sname:VkAttachmentReference structures specified when creating the
    /// render pass specified in the pname:renderPass member of
    /// pname:pRenderPassBegin is ename:VK_IMAGE_LAYOUT_TRANSFER_DST_OPTIMAL
    /// then the corresponding attachment image subresource of the framebuffer
    /// specified in the pname:framebuffer member of pname:pRenderPassBegin
    /// must: have been created with ename:VK_IMAGE_USAGE_TRANSFER_DST_BIT set
    /// * If any of the pname:initialLayout members of the
    /// sname:VkAttachmentDescription structures specified when creating the
    /// render pass specified in the pname:renderPass member of
    /// pname:pRenderPassBegin is not ename:VK_IMAGE_LAYOUT_UNDEFINED, then
    /// each such pname:initialLayout must: be equal to the current layout of
    /// the corresponding attachment image subresource of the framebuffer
    /// specified in the pname:framebuffer member of pname:pRenderPassBegin
    /// ****
    /// </para>
    /// </summary>
    public enum SubpassContents
    {
        /// <summary>
        /// -
        /// </summary>
        Inline = 0, 
        
        /// <summary>
        /// -
        /// </summary>
        SecondaryCommandBuffers = 1, 
    }
    
    /// <summary>
    /// <para>
    /// Allocation scope.
    /// </para>
    /// <para>
    /// Most Vulkan commands operate on a single object, or there is a sole
    /// object that is being created or manipulated. When an allocation uses an
    /// allocation scope of ename:VK_SYSTEM_ALLOCATION_SCOPE_OBJECT or
    /// ename:VK_SYSTEM_ALLOCATION_SCOPE_CACHE, the allocation is scoped to the
    /// object being created or manipulated.
    /// </para>
    /// <para>
    /// When an implementation requires host memory, it will make callbacks to
    /// the application using the most specific allocator and allocation scope
    /// available:
    /// </para>
    /// <para>
    /// * If an allocation is scoped to the duration of a command, the
    /// allocator will use the ename:VK_SYSTEM_ALLOCATION_SCOPE_COMMAND
    /// allocation scope. The most specific allocator available is used: if the
    /// object being created or manipulated has an allocator, that object's
    /// allocator will be used, else if the parent sname:VkDevice has an
    /// allocator it will be used, else if the parent sname:VkInstance has an
    /// allocator it will be used. Else, * If an allocation is associated with
    /// an object of type sname:VkPipelineCache, the allocator will use the
    /// ename:VK_SYSTEM_ALLOCATION_SCOPE_CACHE allocation scope. The most
    /// specific allocator available is used (pipeline cache, else device, else
    /// instance). Else, * If an allocation is scoped to the lifetime of an
    /// object, that object is being created or manipulated by the command, and
    /// that object's type is not sname:VkDevice or sname:VkInstance, the
    /// allocator will use an allocation scope of
    /// ename:VK_SYSTEM_ALLOCATION_SCOPE_OBJECT. The most specific allocator
    /// available is used (object, else device, else instance). Else, * If an
    /// allocation is scoped to the lifetime of a device, the allocator will
    /// use an allocation scope of ename VK_SYSTEM_ALLOCATION_SCOPE_DEVICE. The
    /// most specific allocator available is used (device, else instance).
    /// Else, * If the allocation is scoped to the lifetime of an instance and
    /// the instance has an allocator, its allocator will be used with an
    /// allocation scope of ename:VK_SYSTEM_ALLOCATION_SCOPE_INSTANCE. *
    /// Otherwise an implementation will allocate memory through an alternative
    /// mechanism that is unspecified.
    /// </para>
    /// </summary>
    public enum SystemAllocationScope
    {
        /// <summary>
        /// ename:VK_SYSTEM_ALLOCATION_SCOPE_COMMAND - The allocation is scoped
        /// to the duration of the Vulkan command.
        /// </summary>
        Command = 0, 
        
        /// <summary>
        /// ename:VK_SYSTEM_ALLOCATION_SCOPE_OBJECT - The allocation is scoped
        /// to the lifetime of the Vulkan object that is being created or used.
        /// </summary>
        Object = 1, 
        
        /// <summary>
        /// ename:VK_SYSTEM_ALLOCATION_SCOPE_CACHE - The allocation is scoped
        /// to the lifetime of a sname:VkPipelineCache object.
        /// </summary>
        Cache = 2, 
        
        /// <summary>
        /// ename:VK_SYSTEM_ALLOCATION_SCOPE_DEVICE - The allocation is scoped
        /// to the lifetime of the Vulkan device.
        /// </summary>
        Device = 3, 
        
        /// <summary>
        /// ename:VK_SYSTEM_ALLOCATION_SCOPE_INSTANCE - The allocation is
        /// scoped to the lifetime of the Vulkan instance.
        /// </summary>
        Instance = 4, 
    }
    
    /// <summary>
    /// Specify validation checks to disable.
    /// </summary>
    public enum ValidationCheck
    {
        /// <summary>
        /// -
        /// </summary>
        All = 0, 
    }
    
    /// <summary>
    /// <para>
    /// Specify rate at which vertex attributes are pulled from buffers.
    /// </para>
    /// <para>
    /// .Valid Usage **** * pname:binding must: be less than
    /// sname:VkPhysicalDeviceLimits::pname:maxVertexInputBindings *
    /// pname:stride must: be less than or equal to
    /// sname:VkPhysicalDeviceLimits::pname:maxVertexInputBindingStride ****
    /// </para>
    /// </summary>
    public enum VertexInputRate
    {
        /// <summary>
        /// -
        /// </summary>
        Vertex = 0, 
        
        /// <summary>
        /// -
        /// </summary>
        Instance = 1, 
    }
}
