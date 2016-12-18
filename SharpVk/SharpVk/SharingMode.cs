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
    /// Buffer and image sharing modes.
    /// </para>
    /// <para>
    /// [NOTE] .Note ==== ename:VK_SHARING_MODE_CONCURRENT may: result in lower
    /// performance access to the buffer or image than
    /// ename:VK_SHARING_MODE_EXCLUSIVE. ====
    /// </para>
    /// <para>
    /// Ranges of buffers and image subresources of image objects created using
    /// ename:VK_SHARING_MODE_EXCLUSIVE must: only be accessed by queues in the
    /// same queue family at any given time. In order for a different queue
    /// family to be able to interpret the memory contents of a range or image
    /// subresource, the application must: perform a
    /// &lt;&lt;synchronization-queue-transfers,queue family ownership
    /// transfer&gt;&gt;.
    /// </para>
    /// <para>
    /// Upon creation, resources using ename:VK_SHARING_MODE_EXCLUSIVE are not
    /// owned by any queue family. A buffer or image memory barrier is not
    /// required to acquire _ownership_ when no queue family owns the resource
    /// - it is implicitly acquired upon first use within a queue.
    /// </para>
    /// <para>
    /// .Note [NOTE] ==== Images still require a
    /// &lt;&lt;resources-image-layouts, layout transition&gt;&gt; from
    /// ename:VK_IMAGE_LAYOUT_UNDEFINED or ename:VK_IMAGE_LAYOUT_PREINITIALIZED
    /// before being used on the first queue. ====
    /// </para>
    /// <para>
    /// A queue family can: take ownership of an image subresource or buffer
    /// range of a resource created with ename:VK_SHARING_MODE_EXCLUSIVE,
    /// without an ownership transfer, in the same way as for a resource that
    /// was just created; however, taking ownership in this way has the effect
    /// that the contents of the image subresource or buffer range are
    /// undefined.
    /// </para>
    /// <para>
    /// Ranges of buffers and image subresources of image objects created using
    /// ename:VK_SHARING_MODE_CONCURRENT must: only be accessed by queues from
    /// the queue families specified through the pname:queueFamilyIndexCount
    /// and pname:pQueueFamilyIndices members of the corresponding create info
    /// structures.
    /// </para>
    /// </summary>
    public enum SharingMode
    {
        /// <summary>
        /// ename:VK_SHARING_MODE_EXCLUSIVE specifies that access to any range
        /// or image subresource of the object will be exclusive to a single
        /// queue family at a time.
        /// </summary>
        Exclusive = 0, 
        
        /// <summary>
        /// ename:VK_SHARING_MODE_CONCURRENT specifies that concurrent access
        /// to any range or image subresource of the object from multiple queue
        /// families is supported.
        /// </summary>
        Concurrent = 1, 
    }
}
