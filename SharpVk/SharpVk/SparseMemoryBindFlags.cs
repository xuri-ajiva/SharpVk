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
}
