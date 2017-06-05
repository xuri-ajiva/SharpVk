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
    /// 
    /// </summary>
    public partial class Instance
    {
        internal readonly SharpVk.Interop.Instance handle; 
        
        internal Instance(SharpVk.Interop.Instance handle)
        {
            this.handle = handle;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public static unsafe Instance Create(InstanceCreateInfo createInfo, AllocationCallbacks? allocator = null)
        {
            try
            {
                Instance result = default(Instance);
                Interop.InstanceCreateInfo* marshalledCreateInfo = default(Interop.InstanceCreateInfo*);
                Interop.AllocationCallbacks* marshalledAllocator = default(Interop.AllocationCallbacks*);
                Interop.Instance marshalledInstance = default(Interop.Instance);
                marshalledCreateInfo = (Interop.InstanceCreateInfo*)(Interop.HeapUtil.Allocate<Interop.InstanceCreateInfo>());
                createInfo.MarshalTo(marshalledCreateInfo);
                if (allocator != null)
                {
                    marshalledAllocator = (Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<Interop.AllocationCallbacks>());
                    allocator.Value.MarshalTo(marshalledAllocator);
                }
                Result methodResult = Interop.Commands.vkCreateInstance(marshalledCreateInfo, marshalledAllocator, &marshalledInstance);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = new Instance(marshalledInstance);
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
        public unsafe void Destroy(AllocationCallbacks? allocator = null)
        {
            try
            {
                Interop.AllocationCallbacks* marshalledAllocator = default(Interop.AllocationCallbacks*);
                if (allocator != null)
                {
                    marshalledAllocator = (Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<Interop.AllocationCallbacks>());
                    allocator.Value.MarshalTo(marshalledAllocator);
                }
                Interop.Commands.vkDestroyInstance(this.handle, marshalledAllocator);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        public unsafe PhysicalDevice[] EnumeratePhysicalDevices()
        {
            try
            {
                PhysicalDevice[] result = default(PhysicalDevice[]);
                uint physicalDeviceCount = default(uint);
                Interop.PhysicalDevice* marshalledPhysicalDevices = default(Interop.PhysicalDevice*);
                Result methodResult = Interop.Commands.vkEnumeratePhysicalDevices(this.handle, &physicalDeviceCount, marshalledPhysicalDevices);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                marshalledPhysicalDevices = (Interop.PhysicalDevice*)(Interop.HeapUtil.Allocate<Interop.PhysicalDevice>((uint)(physicalDeviceCount)));
                Interop.Commands.vkEnumeratePhysicalDevices(this.handle, &physicalDeviceCount, marshalledPhysicalDevices);
                if (marshalledPhysicalDevices != null)
                {
                    var fieldPointer = new PhysicalDevice[(uint)(physicalDeviceCount)];
                    for(int index = 0; index < (uint)(physicalDeviceCount); index++)
                    {
                        fieldPointer[index] = new PhysicalDevice(this.handle, marshalledPhysicalDevices[index]);
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
        
        /// <summary>
        /// 
        /// </summary>
        public unsafe void GetProcedureAddress(string name)
        {
            try
            {
                Interop.Commands.vkGetInstanceProcAddr(this.handle, Interop.HeapUtil.MarshalTo(name));
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        public static unsafe LayerProperties[] EnumerateLayerProperties()
        {
            try
            {
                LayerProperties[] result = default(LayerProperties[]);
                uint propertyCount = default(uint);
                Interop.LayerProperties* marshalledProperties = default(Interop.LayerProperties*);
                Result methodResult = Interop.Commands.vkEnumerateInstanceLayerProperties(&propertyCount, marshalledProperties);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                marshalledProperties = (Interop.LayerProperties*)(Interop.HeapUtil.Allocate<Interop.LayerProperties>((uint)(propertyCount)));
                Interop.Commands.vkEnumerateInstanceLayerProperties(&propertyCount, marshalledProperties);
                if (marshalledProperties != null)
                {
                    var fieldPointer = new LayerProperties[(uint)(propertyCount)];
                    for(int index = 0; index < (uint)(propertyCount); index++)
                    {
                        fieldPointer[index] = LayerProperties.MarshalFrom(&marshalledProperties[index]);
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
        
        /// <summary>
        /// 
        /// </summary>
        public static unsafe ExtensionProperties[] EnumerateExtensionProperties(string layerName)
        {
            try
            {
                ExtensionProperties[] result = default(ExtensionProperties[]);
                uint propertyCount = default(uint);
                Interop.ExtensionProperties* marshalledProperties = default(Interop.ExtensionProperties*);
                Result methodResult = Interop.Commands.vkEnumerateInstanceExtensionProperties(Interop.HeapUtil.MarshalTo(layerName), &propertyCount, marshalledProperties);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                marshalledProperties = (Interop.ExtensionProperties*)(Interop.HeapUtil.Allocate<Interop.ExtensionProperties>((uint)(propertyCount)));
                Interop.Commands.vkEnumerateInstanceExtensionProperties(Interop.HeapUtil.MarshalTo(layerName), &propertyCount, marshalledProperties);
                if (marshalledProperties != null)
                {
                    var fieldPointer = new ExtensionProperties[(uint)(propertyCount)];
                    for(int index = 0; index < (uint)(propertyCount); index++)
                    {
                        fieldPointer[index] = ExtensionProperties.MarshalFrom(&marshalledProperties[index]);
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
