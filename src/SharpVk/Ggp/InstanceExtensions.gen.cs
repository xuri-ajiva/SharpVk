// The MIT License (MIT)
// 
// Copyright (c) Andrew Armstrong/FacticiusVir 2020
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

namespace SharpVk.Ggp
{
    /// <summary>
    /// 
    /// </summary>
    public static class InstanceExtensions
    {
        /// <summary>
        /// Create a Surface object for a Google Games Platform stream
        /// </summary>
        /// <param name="extendedHandle">
        /// The Instance handle to extend.
        /// </param>
        /// <param name="allocator">
        /// The allocator used for host memory allocated for the surface object
        /// when there is no more specific allocator available.
        /// </param>
        public static unsafe SharpVk.Khronos.Surface CreateStreamDescriptorSurface(this SharpVk.Instance extendedHandle, uint streamDescriptor, SharpVk.Ggp.StreamDescriptorSurfaceCreateFlags? flags = default(SharpVk.Ggp.StreamDescriptorSurfaceCreateFlags?), SharpVk.AllocationCallbacks? allocator = default(SharpVk.AllocationCallbacks?))
        {
            try
            {
                SharpVk.Khronos.Surface result = default(SharpVk.Khronos.Surface);
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Ggp.StreamDescriptorSurfaceCreateInfo* marshalledCreateInfo = default(SharpVk.Interop.Ggp.StreamDescriptorSurfaceCreateInfo*);
                void* vkStreamDescriptorSurfaceCreateInfoGGPNextPointer = default(void*);
                SharpVk.Interop.AllocationCallbacks* marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                SharpVk.Interop.Khronos.Surface marshalledSurface = default(SharpVk.Interop.Khronos.Surface);
                commandCache = extendedHandle.commandCache;
                marshalledCreateInfo = (SharpVk.Interop.Ggp.StreamDescriptorSurfaceCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Ggp.StreamDescriptorSurfaceCreateInfo>());
                marshalledCreateInfo->SType = StructureType.StreamDescriptorSurfaceCreateInfo;
                marshalledCreateInfo->Next = vkStreamDescriptorSurfaceCreateInfoGGPNextPointer;
                if (flags != null)
                {
                    marshalledCreateInfo->Flags = flags.Value;
                }
                else
                {
                    marshalledCreateInfo->Flags = default(SharpVk.Ggp.StreamDescriptorSurfaceCreateFlags);
                }
                marshalledCreateInfo->StreamDescriptor = streamDescriptor;
                if (allocator != null)
                {
                    marshalledAllocator = (SharpVk.Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<SharpVk.Interop.AllocationCallbacks>());
                    allocator.Value.MarshalTo(marshalledAllocator);
                }
                else
                {
                    marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                }
                SharpVk.Interop.Ggp.VkInstanceCreateStreamDescriptorSurfaceDelegate commandDelegate = commandCache.Cache.vkCreateStreamDescriptorSurfaceGGP;
                Result methodResult = commandDelegate(extendedHandle.handle, marshalledCreateInfo, marshalledAllocator, &marshalledSurface);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = new SharpVk.Khronos.Surface(extendedHandle, marshalledSurface);
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
    }
}
