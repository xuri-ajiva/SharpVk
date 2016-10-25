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
    /// subresource, the application must: transfer exclusive ownership of the
    /// range or image subresource between the source and destination queue
    /// families with the following sequence of operations:
    /// </para>
    /// <para>
    /// . Release exclusive ownership from the source queue family to the
    /// destination queue family. . Use semaphores to ensure proper execution
    /// control for the ownership transfer. . Acquire exclusive ownership for
    /// the destination queue family from the source queue family.
    /// </para>
    /// <para>
    /// To release exclusive ownership of a range of a buffer or image
    /// subresource of an image object, the application must: execute a buffer
    /// or image memory barrier, respectively (see slink:VkBufferMemoryBarrier
    /// and slink:VkImageMemoryBarrier) on a queue from the source queue
    /// family. The pname:srcQueueFamilyIndex parameter of the barrier must: be
    /// set to the source queue family index, and the pname:dstQueueFamilyIndex
    /// parameter to the destination queue family index.
    /// </para>
    /// <para>
    /// To acquire exclusive ownership, the application must: execute the same
    /// buffer or image memory barrier (i.e. an identically defined instance of
    /// the slink:VkBufferMemoryBarrier or slink:VkImageMemoryBarrier structure
    /// that was used for the exclusive ownership release) on a queue from the
    /// destination queue family.
    /// </para>
    /// <para>
    /// Upon creation, resources using ename:VK_SHARING_MODE_EXCLUSIVE are not
    /// owned by any queue family. A buffer or image memory barrier is not
    /// required to acquire ownership when no queue family owns the resource -
    /// it is implicitly acquired upon first use within a queue. However,
    /// images still require a &lt;&lt;resources-image-layouts,layout
    /// transition&gt;&gt; from ename:VK_IMAGE_LAYOUT_UNDEFINED or
    /// ename:VK_IMAGE_LAYOUT_PREINITIALIZED before being used on the first
    /// queue. This layout transition can: either be accomplished by an image
    /// memory barrier or by use in a render pass instance.
    /// </para>
    /// <para>
    /// Once a queue family has used a range or image subresource of an
    /// ename:VK_SHARING_MODE_EXCLUSIVE resource, its contents are undefined to
    /// other queue families unless ownership is transferred. The contents may:
    /// also become undefined for other reasons, e.g. as a result of writes to
    /// an image subresource that aliases the same memory. A queue family can:
    /// take ownership of a range or image subresource without an ownership
    /// transfer in the same way as for a resource that was just created,
    /// however doing so means any contents written by other queue families or
    /// via incompatible aliases are undefined.
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
