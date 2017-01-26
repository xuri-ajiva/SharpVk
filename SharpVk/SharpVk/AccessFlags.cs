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
    /// <para>
    /// Bitmask specifying memory access types that will participate in a
    /// memory dependency.
    /// </para>
    /// <para>
    /// Certain access types are only performed by a subset of pipeline stages.
    /// Any synchronization command that takes both stage masks and access
    /// masks uses both to define the
    /// &lt;&lt;synchronization-dependencies-access-scopes, access
    /// scopes&gt;&gt; - only the specified access types performed by the
    /// specified stages are included in the access scope. An application must:
    /// not specify an access flag in a synchronization command if it does not
    /// include a pipeline stage in the corresponding stage mask that is able
    /// to perform accesses of that type. The following table lists, for each
    /// access flag, which pipeline stages can: perform that type of access.
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
        /// ename:VK_ACCESS_INDIRECT_COMMAND_READ_BIT: Read access to an
        /// indirect command structure read as part of an indirect drawing or
        /// dispatch command.
        /// </summary>
        IndirectCommandRead = 1 << 0, 
        
        /// <summary>
        /// ename:VK_ACCESS_INDEX_READ_BIT: Read access to an index buffer as
        /// part of an indexed drawing command, bound by
        /// flink:vkCmdBindIndexBuffer.
        /// </summary>
        IndexRead = 1 << 1, 
        
        /// <summary>
        /// ename:VK_ACCESS_VERTEX_ATTRIBUTE_READ_BIT: Read access to a vertex
        /// buffer as part of a drawing command, bound by
        /// flink:vkCmdBindVertexBuffers.
        /// </summary>
        VertexAttributeRead = 1 << 2, 
        
        /// <summary>
        /// ename:VK_ACCESS_UNIFORM_READ_BIT: Read access to a
        /// &lt;&lt;descriptorsets-uniformbuffer, uniform buffer&gt;&gt;.
        /// </summary>
        UniformRead = 1 << 3, 
        
        /// <summary>
        /// ename:VK_ACCESS_INPUT_ATTACHMENT_READ_BIT: Read access to an
        /// &lt;&lt;renderpass, input attachment&gt;&gt; within a renderpass
        /// during fragment shading.
        /// </summary>
        InputAttachmentRead = 1 << 4, 
        
        /// <summary>
        /// ename:VK_ACCESS_SHADER_READ_BIT: Read access to a
        /// &lt;&lt;descriptorsets-storagebuffer, storage buffer&gt;&gt;,
        /// &lt;&lt;descriptorsets-uniformtexelbuffer, uniform texel
        /// buffer&gt;&gt;, &lt;&lt;descriptorsets-storagetexelbuffer, storage
        /// texel buffer&gt;&gt;, &lt;&lt;descriptorsets-sampledimage, sampled
        /// image&gt;&gt;, or &lt;&lt;descriptorsets-storageimage, storage
        /// image&gt;&gt;.
        /// </summary>
        ShaderRead = 1 << 5, 
        
        /// <summary>
        /// ename:VK_ACCESS_SHADER_WRITE_BIT: Write access to a
        /// &lt;&lt;descriptorsets-storagebuffer, storage buffer&gt;&gt;,
        /// &lt;&lt;descriptorsets-storagetexelbuffer, storage texel
        /// buffer&gt;&gt;, or &lt;&lt;descriptorsets-storageimage, storage
        /// image&gt;&gt;.
        /// </summary>
        ShaderWrite = 1 << 6, 
        
        /// <summary>
        /// ename:VK_ACCESS_COLOR_ATTACHMENT_READ_BIT: Read access to a
        /// &lt;&lt;renderpass, color attachment&gt;&gt;, such as via
        /// &lt;&lt;framebuffer-blending, blending&gt;&gt;,
        /// &lt;&lt;framebuffer-logicop, logic operations&gt;&gt;, or via
        /// certain &lt;&lt;renderpass-load-store-ops, subpass load
        /// operations&gt;&gt;.
        /// </summary>
        ColorAttachmentRead = 1 << 7, 
        
        /// <summary>
        /// ename:VK_ACCESS_COLOR_ATTACHMENT_WRITE_BIT: Write access to a
        /// &lt;&lt;renderpass, color or resolve attachment&gt;&gt; during a
        /// &lt;&lt;renderpass, render pass&gt;&gt; or via certain
        /// &lt;&lt;renderpass-load-store-ops, subpass load and store
        /// operations&gt;&gt;.
        /// </summary>
        ColorAttachmentWrite = 1 << 8, 
        
        /// <summary>
        /// ename:VK_ACCESS_DEPTH_STENCIL_ATTACHMENT_READ_BIT: Read access to a
        /// &lt;&lt;renderpass, depth/stencil attachment&gt;&gt;, via
        /// &lt;&lt;fragops-ds-state, depth or stencil operations&gt;&gt; or
        /// via certain &lt;&lt;renderpass-load-store-ops, subpass load
        /// operations&gt;&gt;.
        /// </summary>
        DepthStencilAttachmentRead = 1 << 9, 
        
        /// <summary>
        /// ename:VK_ACCESS_DEPTH_STENCIL_ATTACHMENT_WRITE_BIT: Write access to
        /// a &lt;&lt;renderpass, depth/stencil attachment&gt;&gt;, via
        /// &lt;&lt;fragops-ds-state, depth or stencil operations&gt;&gt; or
        /// via certain &lt;&lt;renderpass-load-store-ops, subpass load and
        /// store operations&gt;&gt;.
        /// </summary>
        DepthStencilAttachmentWrite = 1 << 10, 
        
        /// <summary>
        /// ename:VK_ACCESS_TRANSFER_READ_BIT: Read access to an image or
        /// buffer in a &lt;&lt;copies, copy&gt;&gt; operation.
        /// </summary>
        TransferRead = 1 << 11, 
        
        /// <summary>
        /// ename:VK_ACCESS_TRANSFER_WRITE_BIT: Write access to an image or
        /// buffer in a &lt;&lt;clears, clear&gt;&gt; or &lt;&lt;copies,
        /// copy&gt;&gt; operation.
        /// </summary>
        TransferWrite = 1 << 12, 
        
        /// <summary>
        /// ename:VK_ACCESS_HOST_READ_BIT: Read access by a host operation.
        /// Accesses of this type are not performed through a resource, but
        /// directly on memory.
        /// </summary>
        HostRead = 1 << 13, 
        
        /// <summary>
        /// ename:VK_ACCESS_HOST_WRITE_BIT: Write access by a host operation.
        /// Accesses of this type are not performed through a resource, but
        /// directly on memory.
        /// </summary>
        HostWrite = 1 << 14, 
        
        /// <summary>
        /// ename:VK_ACCESS_MEMORY_READ_BIT: Read access via non-specific
        /// entities. These entities include the Vulkan device and host, but
        /// may: also include entities external to the Vulkan device or
        /// otherwise not part of the core Vulkan pipeline. When included in a
        /// destination access mask, makes all available writes visible to all
        /// future read accesses on entities known to the Vulkan device.
        /// </summary>
        MemoryRead = 1 << 15, 
        
        /// <summary>
        /// ename:VK_ACCESS_MEMORY_WRITE_BIT: Write access via non-specific
        /// entities. These entities include the Vulkan device and host, but
        /// may: also include entities external to the Vulkan device or
        /// otherwise not part of the core Vulkan pipeline. When included in a
        /// source access mask, all writes that are performed by entities known
        /// to the Vulkan device are made available. When included in a
        /// destination access mask, makes all available writes visible to all
        /// future write accesses on entities known to the Vulkan device.
        /// ifdef::VK_NVX_device_generated_commands[]
        /// </summary>
        MemoryWrite = 1 << 16, 
        
        /// <summary>
        /// ename:VK_ACCESS_COMMAND_PROCESS_READ_BIT_NVX: Reads from
        /// sname:VkBuffer inputs to flink:vkCmdProcessCommandsNVX.
        /// </summary>
        CommandProcessRead = 1 << 17, 
        
        /// <summary>
        /// ename:VK_ACCESS_COMMAND_PROCESS_WRITE_BIT_NVX: Writes to the target
        /// command buffer in flink:vkCmdProcessCommandsNVX.
        /// endif::VK_NVX_device_generated_commands[]
        /// </summary>
        CommandProcessWrite = 1 << 18, 
    }
}
