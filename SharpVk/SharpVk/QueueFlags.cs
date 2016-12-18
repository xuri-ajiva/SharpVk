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
}
