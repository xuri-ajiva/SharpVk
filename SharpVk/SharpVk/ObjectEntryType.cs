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
    /// Enum specifying object table entry type.
    /// </para>
    /// <para>
    /// * ename:VK_OBJECT_ENTRY_DESCRIPTOR_SET_NVX indicates a
    /// sname:VkDescriptorSet resource entry that is registered via
    /// sname:VkObjectTableDescriptorSetEntryNVX. *
    /// ename:VK_OBJECT_ENTRY_PIPELINE_NVX indicates a sname:VkPipeline
    /// resource entry that is registered via
    /// sname:VkObjectTablePipelineEntryNVX. *
    /// ename:VK_OBJECT_ENTRY_INDEX_BUFFER_NVX indicates a sname:VkBuffer
    /// resource entry that is registered via
    /// sname:VkObjectTableIndexBufferEntryNVX. *
    /// ename:VK_OBJECT_ENTRY_VERTEX_BUFFER_NVX indicates a sname:VkBuffer
    /// resource entry that is registered via
    /// sname:VkObjectTableVertexBufferEntryNVX. *
    /// ename:VK_OBJECT_ENTRY_PUSH_CONSTANT_NVX indicates the resource entry is
    /// registered via sname:VkObjectTablePushConstantEntryNVX.
    /// </para>
    /// </summary>
    public enum ObjectEntryType
    {
        /// <summary>
        /// -
        /// </summary>
        DescriptorSet = 0, 
        
        /// <summary>
        /// -
        /// </summary>
        Pipeline = 1, 
        
        /// <summary>
        /// -
        /// </summary>
        IndexBuffer = 2, 
        
        /// <summary>
        /// -
        /// </summary>
        VertexBuffer = 3, 
        
        /// <summary>
        /// -
        /// </summary>
        PushConstant = 4, 
    }
}
