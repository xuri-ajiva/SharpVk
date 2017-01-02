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
    /// Bitmask specifying certain supported operations on a descriptor pool.
    /// </para>
    /// <para>
    /// If multiple sname:VkDescriptorPoolSize structures appear in the
    /// pname:pPoolSizes array then the pool will be created with enough
    /// storage for the total number of descriptors of each type.
    /// </para>
    /// <para>
    /// Fragmentation of a descriptor pool is possible and may: lead to
    /// descriptor set allocation failures. A failure due to fragmentation is
    /// defined as failing a descriptor set allocation despite the sum of all
    /// outstanding descriptor set allocations from the pool plus the requested
    /// allocation requiring no more than the total number of descriptors
    /// requested at pool creation. Implementations provide certain guarantees
    /// of when fragmentation must: not cause allocation failure, as described
    /// below.
    /// </para>
    /// <para>
    /// If a descriptor pool has not had any descriptor sets freed since it was
    /// created or most recently reset then fragmentation must: not cause an
    /// allocation failure (note that this is always the case for a pool
    /// created without the
    /// ename:VK_DESCRIPTOR_POOL_CREATE_FREE_DESCRIPTOR_SET_BIT bit set).
    /// Additionally, if all sets allocated from the pool since it was created
    /// or most recently reset use the same number of descriptors (of each
    /// type) and the requested allocation also uses that same number of
    /// descriptors (of each type), then fragmentation must: not cause an
    /// allocation failure.
    /// </para>
    /// <para>
    /// If an allocation failure occurs due to fragmentation, an application
    /// can: create an additional descriptor pool to perform further descriptor
    /// set allocations.
    /// </para>
    /// </summary>
    [Flags]
    public enum DescriptorPoolCreateFlags
    {
        /// <summary>
        /// -
        /// </summary>
        None = 0, 
        
        /// <summary>
        /// Descriptor sets may be freed individually
        /// </summary>
        FreeDescriptorSet = 1 << 0, 
    }
}
