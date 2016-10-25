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
    /// <para>
    /// * If an allocation is scoped to the duration of a command, the
    /// allocator will use the ename:VK_SYSTEM_ALLOCATION_SCOPE_COMMAND
    /// allocation scope. The most specific allocator available is used: if the
    /// object being created or manipulated has an allocator, that object's
    /// allocator will be used, else if the parent sname:VkDevice has an
    /// allocator it will be used, else if the parent sname:VkInstance has an
    /// allocator it will be used. Else, * If an allocation is associated with
    /// an object of type sname:VkPipelineCache, the allocator will use the
    /// ename:VK_SYSTEM_ALLOCATION_SCOPE_CACHE allocation scope. The most
    /// specific allocator available is used (pipeline cache, else device, else
    /// instance). Else, * If an allocation is scoped to the lifetime of an
    /// object, that object is being created or manipulated by the command, and
    /// that object's type is not sname:VkDevice or sname:VkInstance, the
    /// allocator will use an allocation scope of
    /// ename:VK_SYSTEM_ALLOCATION_SCOPE_OBJECT. The most specific allocator
    /// available is used (object, else device, else instance). Else, * If an
    /// allocation is scoped to the lifetime of a device, the allocator will
    /// use an allocation scope of ename VK_SYSTEM_ALLOCATION_SCOPE_DEVICE. The
    /// most specific allocator available is used (device, else instance).
    /// Else, * If the allocation is scoped to the lifetime of an instance and
    /// the instance has an allocator, its allocator will be used with an
    /// allocation scope of ename:VK_SYSTEM_ALLOCATION_SCOPE_INSTANCE. *
    /// Otherwise an implementation will allocate memory through an alternative
    /// mechanism that is unspecified.
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
