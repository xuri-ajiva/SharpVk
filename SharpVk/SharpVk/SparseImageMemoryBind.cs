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
    /// Structure specifying sparse image memory bind.
    /// </para>
    /// <para>
    /// .Valid Usage **** * If the
    /// &lt;&lt;features-features-sparseResidencyAliased,sparse aliased
    /// residency&gt;&gt; feature is not enabled, and if any other resources
    /// are bound to ranges of pname:memory, the range of pname:memory being
    /// bound must: not overlap with those bound ranges * pname:memory and
    /// pname:memoryOffset must: match the memory requirements of the calling
    /// command's pname:image, as described in section
    /// &lt;&lt;resources-association&gt;&gt; * pname:subresource must: be a
    /// valid image subresource for pname:image (see
    /// &lt;&lt;resources-image-views&gt;&gt;) * pname:offset.x must: be a
    /// multiple of the sparse image block width
    /// (sname:VkSparseImageFormatProperties::pname:imageGranularity.width) of
    /// the image * pname:extent.width must: either be a multiple of the sparse
    /// image block width of the image, or else pname:extent.width +
    /// pname:offset.x must: equal the width of the image subresource *
    /// pname:offset.y must: be a multiple of the sparse image block height
    /// (sname:VkSparseImageFormatProperties::pname:imageGranularity.height) of
    /// the image * pname:extent.height must: either be a multiple of the
    /// sparse image block height of the image, or else pname:extent.height +
    /// pname:offset.y must: equal the height of the image subresource *
    /// pname:offset.z must: be a multiple of the sparse image block depth
    /// (sname:VkSparseImageFormatProperties::pname:imageGranularity.depth) of
    /// the image * pname:extent.depth must: either be a multiple of the sparse
    /// image block depth of the image, or else pname:extent.depth +
    /// pname:offset.z must: equal the depth of the image subresource ****
    /// </para>
    /// </summary>
    public struct SparseImageMemoryBind
    {
        /// <summary>
        /// pname:subresource is the aspectMask and region of interest in the
        /// image.
        /// </summary>
        public ImageSubresource Subresource
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:offset are the coordinates of the first texel within the
        /// image subresource to bind.
        /// </summary>
        public Offset3D Offset
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:extent is the size in texels of the region within the image
        /// subresource to bind. The extent must: be a multiple of the sparse
        /// image block dimensions, except when binding sparse image blocks
        /// along the edge of an image subresource it can: instead be such that
        /// any coordinate of [eq]#pname:offset + pname:extent# equals the
        /// corresponding dimensions of the image subresource.
        /// </summary>
        public Extent3D Extent
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:memory is the sname:VkDeviceMemory object that the sparse
        /// image blocks of the image are bound to. If pname:memory is
        /// dlink:VK_NULL_HANDLE, the sparse image blocks are unbound.
        /// </summary>
        public DeviceMemory Memory
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:memoryOffset is an offset into sname:VkDeviceMemory object.
        /// If pname:memory is dlink:VK_NULL_HANDLE, this value is ignored.
        /// </summary>
        public ulong MemoryOffset
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:flags are sparse memory binding flags.
        /// </summary>
        public SparseMemoryBindFlags Flags
        {
            get;
            set;
        }
        
        internal unsafe Interop.SparseImageMemoryBind Pack()
        {
            Interop.SparseImageMemoryBind result = default(Interop.SparseImageMemoryBind);
            result.Memory = this.Memory?.Pack() ?? Interop.DeviceMemory.Null;
            result.Subresource = this.Subresource;
            result.Offset = this.Offset;
            result.Extent = this.Extent;
            result.MemoryOffset = this.MemoryOffset;
            result.Flags = this.Flags;
            return result;
        }
        
        internal unsafe Interop.SparseImageMemoryBind* MarshalTo()
        {
            return (Interop.SparseImageMemoryBind*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
        }
    }
}
