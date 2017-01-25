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
    /// Structure specifying the parameters of an image memory barrier.
    /// </para>
    /// <para>
    /// The first &lt;&lt;synchronization-dependencies-access-scopes, access
    /// scope&gt;&gt; is limited to access to memory through the specified
    /// image subresource range, via access types in the
    /// &lt;&lt;synchronization-access-masks, source access mask&gt;&gt;
    /// specified by pname:srcAccessMask. If pname:srcAccessMask includes
    /// ename:VK_ACCESS_HOST_WRITE_BIT, memory writes performed by that access
    /// type are also made visible, as that access type is not performed
    /// through a resource.
    /// </para>
    /// <para>
    /// The second &lt;&lt;synchronization-dependencies-access-scopes, access
    /// scope&gt;&gt; is limited to access to memory through the specified
    /// image subresource range, via access types in the
    /// &lt;&lt;synchronization-access-masks, destination access mask&gt;&gt;
    /// specified by pname:dstAccessMask. If pname:dstAccessMask includes
    /// ename:VK_ACCESS_HOST_WRITE_BIT or ename:VK_ACCESS_HOST_READ_BIT,
    /// available memory writes are also made visible to accesses of those
    /// types, as those access types are not performed through a resource.
    /// </para>
    /// <para>
    /// If pname:srcQueueFamilyIndex is not equal to pname:dstQueueFamilyIndex,
    /// and pname:srcQueueFamilyIndex is equal to the current queue family,
    /// then the memory barrier defines a
    /// &lt;&lt;synchronization-queue-transfers-release, queue family release
    /// operation&gt;&gt; for the specified image subresource range, and the
    /// second access scope includes no access, as if pname:dstAccessMask was
    /// `0`.
    /// </para>
    /// <para>
    /// If pname:dstQueueFamilyIndex is not equal to pname:srcQueueFamilyIndex,
    /// and pname:dstQueueFamilyIndex is equal to the current queue family,
    /// then the memory barrier defines a
    /// &lt;&lt;synchronization-queue-transfers-acquire, queue family acquire
    /// operation&gt;&gt; for the specified image subresource range, and the
    /// first access scope includes no access, as if pname:srcAccessMask was
    /// `0`.
    /// </para>
    /// </summary>
    public struct ImageMemoryBarrier
    {
        /// <summary>
        /// pname:srcAccessMask defines a &lt;&lt;synchronization-access-masks,
        /// source access mask&gt;&gt;.
        /// </summary>
        public AccessFlags SourceAccessMask
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:dstAccessMask defines a &lt;&lt;synchronization-access-masks,
        /// destination access mask&gt;&gt;.
        /// </summary>
        public AccessFlags DestinationAccessMask
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:oldLayout is the old layout in an
        /// &lt;&lt;synchronization-image-layout-transitions, image layout
        /// transition&gt;&gt;.
        /// </summary>
        public ImageLayout OldLayout
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:newLayout is the new layout in an
        /// &lt;&lt;synchronization-image-layout-transitions, image layout
        /// transition&gt;&gt;.
        /// </summary>
        public ImageLayout NewLayout
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:srcQueueFamilyIndex is the source queue family for a
        /// &lt;&lt;synchronization-queue-transfers, queue family ownership
        /// transfer&gt;&gt;.
        /// </summary>
        public uint SourceQueueFamilyIndex
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:dstQueueFamilyIndex is the destination queue family for a
        /// &lt;&lt;synchronization-queue-transfers, queue family ownership
        /// transfer&gt;&gt;.
        /// </summary>
        public uint DestinationQueueFamilyIndex
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:image is a handle to the image affected by this barrier.
        /// </summary>
        public Image Image
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:subresourceRange describes the &lt;&lt;resources-image-views,
        /// image subresource range&gt;&gt; within pname:image that is affected
        /// by this barrier.
        /// </summary>
        public ImageSubresourceRange SubresourceRange
        {
            get;
            set;
        }
        
        internal unsafe Interop.ImageMemoryBarrier* MarshalTo()
        {
            var result = (Interop.ImageMemoryBarrier*)Interop.HeapUtil.AllocateAndClear<Interop.ImageMemoryBarrier>().ToPointer();
            this.MarshalTo(result);
            return result;
        }
        
        internal unsafe void MarshalTo(Interop.ImageMemoryBarrier* pointer)
        {
            pointer->SType = StructureType.ImageMemoryBarrier;
            pointer->Next = null;
            this.Image?.MarshalTo(&pointer->Image);
            pointer->SourceAccessMask = this.SourceAccessMask;
            pointer->DestinationAccessMask = this.DestinationAccessMask;
            pointer->OldLayout = this.OldLayout;
            pointer->NewLayout = this.NewLayout;
            pointer->SourceQueueFamilyIndex = this.SourceQueueFamilyIndex;
            pointer->DestinationQueueFamilyIndex = this.DestinationQueueFamilyIndex;
            pointer->SubresourceRange = this.SubresourceRange;
        }
    }
}
