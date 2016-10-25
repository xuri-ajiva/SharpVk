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
}
