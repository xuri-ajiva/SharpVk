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

namespace SharpVk.NVidia.Experimental
{
    /// <summary>
    /// 
    /// </summary>
    public static class DeviceExtensions
    {
        /// <summary>
        /// 
        /// </summary>
        public static unsafe SharpVk.NVidia.Experimental.IndirectCommandsLayout CreateIndirectCommandsLayout(this SharpVk.Device extendedHandle, SharpVk.NVidia.Experimental.IndirectCommandsLayoutCreateInfo createInfo, SharpVk.AllocationCallbacks? allocator = default(SharpVk.AllocationCallbacks?))
        {
            try
            {
                SharpVk.NVidia.Experimental.IndirectCommandsLayout result = default(SharpVk.NVidia.Experimental.IndirectCommandsLayout);
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.NVidia.Experimental.IndirectCommandsLayoutCreateInfo* marshalledCreateInfo = default(SharpVk.Interop.NVidia.Experimental.IndirectCommandsLayoutCreateInfo*);
                SharpVk.Interop.AllocationCallbacks* marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                SharpVk.Interop.NVidia.Experimental.IndirectCommandsLayout marshalledIndirectCommandsLayout = default(SharpVk.Interop.NVidia.Experimental.IndirectCommandsLayout);
                commandCache = extendedHandle.commandCache;
                marshalledCreateInfo = (SharpVk.Interop.NVidia.Experimental.IndirectCommandsLayoutCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.NVidia.Experimental.IndirectCommandsLayoutCreateInfo>());
                createInfo.MarshalTo(marshalledCreateInfo);
                if (allocator != null)
                {
                    marshalledAllocator = (SharpVk.Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<SharpVk.Interop.AllocationCallbacks>());
                    allocator.Value.MarshalTo(marshalledAllocator);
                }
                else
                {
                    marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                }
                SharpVk.Interop.NVidia.Experimental.VkDeviceCreateIndirectCommandsLayoutDelegate commandDelegate = commandCache.GetCommandDelegate<SharpVk.Interop.NVidia.Experimental.VkDeviceCreateIndirectCommandsLayoutDelegate>("vkCreateIndirectCommandsLayoutNVX", "instance");
                Result methodResult = commandDelegate(extendedHandle.handle, marshalledCreateInfo, marshalledAllocator, &marshalledIndirectCommandsLayout);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = new SharpVk.NVidia.Experimental.IndirectCommandsLayout(extendedHandle, marshalledIndirectCommandsLayout);
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        public static unsafe SharpVk.NVidia.Experimental.ObjectTable CreateObjectTable(this SharpVk.Device extendedHandle, SharpVk.NVidia.Experimental.ObjectTableCreateInfo createInfo, SharpVk.AllocationCallbacks? allocator = default(SharpVk.AllocationCallbacks?))
        {
            try
            {
                SharpVk.NVidia.Experimental.ObjectTable result = default(SharpVk.NVidia.Experimental.ObjectTable);
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.NVidia.Experimental.ObjectTableCreateInfo* marshalledCreateInfo = default(SharpVk.Interop.NVidia.Experimental.ObjectTableCreateInfo*);
                SharpVk.Interop.AllocationCallbacks* marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                SharpVk.Interop.NVidia.Experimental.ObjectTable marshalledObjectTable = default(SharpVk.Interop.NVidia.Experimental.ObjectTable);
                commandCache = extendedHandle.commandCache;
                marshalledCreateInfo = (SharpVk.Interop.NVidia.Experimental.ObjectTableCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.NVidia.Experimental.ObjectTableCreateInfo>());
                createInfo.MarshalTo(marshalledCreateInfo);
                if (allocator != null)
                {
                    marshalledAllocator = (SharpVk.Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<SharpVk.Interop.AllocationCallbacks>());
                    allocator.Value.MarshalTo(marshalledAllocator);
                }
                else
                {
                    marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                }
                SharpVk.Interop.NVidia.Experimental.VkDeviceCreateObjectTableDelegate commandDelegate = commandCache.GetCommandDelegate<SharpVk.Interop.NVidia.Experimental.VkDeviceCreateObjectTableDelegate>("vkCreateObjectTableNVX", "instance");
                Result methodResult = commandDelegate(extendedHandle.handle, marshalledCreateInfo, marshalledAllocator, &marshalledObjectTable);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = new SharpVk.NVidia.Experimental.ObjectTable(extendedHandle, marshalledObjectTable);
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
    }
}
