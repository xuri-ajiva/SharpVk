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

namespace SharpVk.Khronos.Experimental
{
    /// <summary>
    /// 
    /// </summary>
    public static class InstanceExtensions
    {
        /// <summary>
        /// 
        /// </summary>
        public static unsafe SharpVk.Khronos.Experimental.PhysicalDeviceGroupProperties[] EnumeratePhysicalDeviceGroups(this SharpVk.Instance extendedHandle)
        {
            try
            {
                SharpVk.Khronos.Experimental.PhysicalDeviceGroupProperties[] result = default(SharpVk.Khronos.Experimental.PhysicalDeviceGroupProperties[]);
                uint physicalDeviceGroupCount = default(uint);
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Khronos.Experimental.PhysicalDeviceGroupProperties* marshalledPhysicalDeviceGroupProperties = default(SharpVk.Interop.Khronos.Experimental.PhysicalDeviceGroupProperties*);
                commandCache = extendedHandle.commandCache;
                SharpVk.Interop.Khronos.Experimental.VkInstanceEnumeratePhysicalDeviceGroupsDelegate commandDelegate = commandCache.GetCommandDelegate<SharpVk.Interop.Khronos.Experimental.VkInstanceEnumeratePhysicalDeviceGroupsDelegate>("vkEnumeratePhysicalDeviceGroupsKHX", "instance");
                Result methodResult = commandDelegate(extendedHandle.handle, &physicalDeviceGroupCount, marshalledPhysicalDeviceGroupProperties);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                marshalledPhysicalDeviceGroupProperties = (SharpVk.Interop.Khronos.Experimental.PhysicalDeviceGroupProperties*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.Experimental.PhysicalDeviceGroupProperties>((uint)(physicalDeviceGroupCount)));
                commandDelegate(extendedHandle.handle, &physicalDeviceGroupCount, marshalledPhysicalDeviceGroupProperties);
                if (marshalledPhysicalDeviceGroupProperties != null)
                {
                    var fieldPointer = new SharpVk.Khronos.Experimental.PhysicalDeviceGroupProperties[(uint)(physicalDeviceGroupCount)];
                    for(int index = 0; index < (uint)(physicalDeviceGroupCount); index++)
                    {
                        fieldPointer[index] = SharpVk.Khronos.Experimental.PhysicalDeviceGroupProperties.MarshalFrom(&marshalledPhysicalDeviceGroupProperties[index]);
                    }
                    result = fieldPointer;
                }
                else
                {
                    result = null;
                }
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
    }
}
