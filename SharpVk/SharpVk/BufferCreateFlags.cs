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
}
