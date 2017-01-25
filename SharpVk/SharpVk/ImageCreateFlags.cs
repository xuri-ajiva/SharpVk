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
        /// ename:VK_IMAGE_VIEW_TYPE_CUBE_ARRAY. ifdef::VK_KHR_maintenance1[]
        /// </summary>
        CubeCompatible = 1 << 4, 
        
        /// <summary>
        /// ename:VK_IMAGE_CREATE_2D_ARRAY_COMPATIBLE_BIT_KHR indicates that
        /// the image can: be used to create a sname:VkImageView of type
        /// ename:VK_IMAGE_VIEW_TYPE_2D or ename:VK_IMAGE_VIEW_TYPE_2D_ARRAY.
        /// endif::VK_KHR_maintenance1[]
        /// </summary>
        ImageCreate2dArrayCompatibleBit = 5, 
    }
}
