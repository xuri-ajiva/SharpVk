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
    /// Allocation scope.
    /// </para>
    /// <para>
    /// Most Vulkan commands operate on a single object, or there is a sole
    /// object that is being created or manipulated. When an allocation uses an
    /// allocation scope of ename:VK_SYSTEM_ALLOCATION_SCOPE_OBJECT or
    /// ename:VK_SYSTEM_ALLOCATION_SCOPE_CACHE, the allocation is scoped to the
    /// object being created or manipulated.
    /// </para>
    /// <para>
    /// When an implementation requires host memory, it will make callbacks to
    /// the application using the most specific allocator and allocation scope
    /// available:
    /// </para>
    /// </summary>
    public enum SystemAllocationScope
    {
        /// <summary>
        /// ename:VK_SYSTEM_ALLOCATION_SCOPE_COMMAND - The allocation is scoped
        /// to the duration of the Vulkan command.
        /// </summary>
        Command = 0, 
        
        /// <summary>
        /// ename:VK_SYSTEM_ALLOCATION_SCOPE_OBJECT - The allocation is scoped
        /// to the lifetime of the Vulkan object that is being created or used.
        /// </summary>
        Object = 1, 
        
        /// <summary>
        /// ename:VK_SYSTEM_ALLOCATION_SCOPE_CACHE - The allocation is scoped
        /// to the lifetime of a sname:VkPipelineCache object.
        /// </summary>
        Cache = 2, 
        
        /// <summary>
        /// ename:VK_SYSTEM_ALLOCATION_SCOPE_DEVICE - The allocation is scoped
        /// to the lifetime of the Vulkan device.
        /// </summary>
        Device = 3, 
        
        /// <summary>
        /// ename:VK_SYSTEM_ALLOCATION_SCOPE_INSTANCE - The allocation is
        /// scoped to the lifetime of the Vulkan instance.
        /// </summary>
        Instance = 4, 
    }
}
