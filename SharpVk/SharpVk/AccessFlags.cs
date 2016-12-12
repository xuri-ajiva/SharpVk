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
        
        /// <summary>
        /// -
        /// </summary>
        CommandProcessReadBitNvx = 17, 
        
        /// <summary>
        /// -
        /// </summary>
        CommandProcessWriteBitNvx = 18, 
    }
}
