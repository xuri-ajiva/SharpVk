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
    /// Opaque handle to a instance object.
    /// </summary>
    public partial class Instance
        : IProcLookup, IDisposable
    {
        internal readonly SharpVk.Interop.Instance handle; 
        
        internal readonly CommandCache commandCache; 
        
        internal Instance(SharpVk.Interop.Instance handle)
        {
            this.handle = handle;
            this.commandCache = new CommandCache(this, "instance", null);
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Interop.Instance RawHandle => this.handle;
        
        /// <summary>
        /// Create a new Vulkan instance.
        /// </summary>
        /// <param name="flags">
        /// Reserved for future use.
        /// </param>
        /// <param name="applicationInfo">
        /// Null or an instance of ApplicationInfo. If not Null, this
        /// information helps implementations recognize behavior inherent to
        /// classes of applications. ApplicationInfo is defined in detail
        /// below.
        /// </param>
        /// <param name="enabledLayerNames">
        /// An array of enabledLayerCount strings containing the names of
        /// layers to enable for the created instance. See the Layers section
        /// for further details.
        /// </param>
        /// <param name="enabledExtensionNames">
        /// An array of enabledExtensionCount strings containing the names of
        /// extensions to enable.
        /// </param>
        /// <param name="allocator">
        /// An optional AllocationCallbacks instance that controls host memory
        /// allocation.
        /// </param>
        public static unsafe SharpVk.Instance Create(ArrayProxy<string>? enabledLayerNames, ArrayProxy<string>? enabledExtensionNames, SharpVk.InstanceCreateFlags? flags = default(SharpVk.InstanceCreateFlags?), SharpVk.ApplicationInfo? applicationInfo = default(SharpVk.ApplicationInfo?), SharpVk.AllocationCallbacks? allocator = default(SharpVk.AllocationCallbacks?))
        {
            try
            {
                SharpVk.Instance result = default(SharpVk.Instance);
                SharpVk.Interop.InstanceCreateInfo* marshalledCreateInfo = default(SharpVk.Interop.InstanceCreateInfo*);
                SharpVk.Interop.AllocationCallbacks* marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                SharpVk.Interop.Instance marshalledInstance = default(SharpVk.Interop.Instance);
                marshalledCreateInfo = (SharpVk.Interop.InstanceCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.InstanceCreateInfo>());
                marshalledCreateInfo->SType = StructureType.InstanceCreateInfo;
                marshalledCreateInfo->Next = null;
                if (flags != null)
                {
                    marshalledCreateInfo->Flags = flags.Value;
                }
                else
                {
                    marshalledCreateInfo->Flags = default(SharpVk.InstanceCreateFlags);
                }
                if (applicationInfo != null)
                {
                    marshalledCreateInfo->ApplicationInfo = (SharpVk.Interop.ApplicationInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.ApplicationInfo>());
                    applicationInfo.Value.MarshalTo(marshalledCreateInfo->ApplicationInfo);
                }
                else
                {
                    marshalledCreateInfo->ApplicationInfo = default(SharpVk.Interop.ApplicationInfo*);
                }
                marshalledCreateInfo->EnabledLayerCount = (uint)(Interop.HeapUtil.GetLength(enabledLayerNames));
                marshalledCreateInfo->EnabledLayerNames = Interop.HeapUtil.MarshalTo(enabledLayerNames);
                marshalledCreateInfo->EnabledExtensionCount = (uint)(Interop.HeapUtil.GetLength(enabledExtensionNames));
                marshalledCreateInfo->EnabledExtensionNames = Interop.HeapUtil.MarshalTo(enabledExtensionNames);
                if (allocator != null)
                {
                    marshalledAllocator = (SharpVk.Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<SharpVk.Interop.AllocationCallbacks>());
                    allocator.Value.MarshalTo(marshalledAllocator);
                }
                else
                {
                    marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                }
                Result methodResult = Interop.Commands.vkCreateInstance(marshalledCreateInfo, marshalledAllocator, &marshalledInstance);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = new SharpVk.Instance(marshalledInstance);
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Destroy an instance of Vulkan.
        /// </summary>
        /// <param name="allocator">
        /// An optional AllocationCallbacks instance that controls host memory
        /// allocation.
        /// </param>
        public unsafe void Destroy(SharpVk.AllocationCallbacks? allocator = default(SharpVk.AllocationCallbacks?))
        {
            try
            {
                SharpVk.Interop.AllocationCallbacks* marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                if (allocator != null)
                {
                    marshalledAllocator = (SharpVk.Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<SharpVk.Interop.AllocationCallbacks>());
                    allocator.Value.MarshalTo(marshalledAllocator);
                }
                else
                {
                    marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                }
                Interop.Commands.vkDestroyInstance(this.handle, marshalledAllocator);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Enumerates the physical devices accessible to a Vulkan instance.
        /// </summary>
        public unsafe SharpVk.PhysicalDevice[] EnumeratePhysicalDevices()
        {
            try
            {
                SharpVk.PhysicalDevice[] result = default(SharpVk.PhysicalDevice[]);
                uint physicalDeviceCount = default(uint);
                SharpVk.Interop.PhysicalDevice* marshalledPhysicalDevices = default(SharpVk.Interop.PhysicalDevice*);
                Result methodResult = Interop.Commands.vkEnumeratePhysicalDevices(this.handle, &physicalDeviceCount, marshalledPhysicalDevices);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                marshalledPhysicalDevices = (SharpVk.Interop.PhysicalDevice*)(Interop.HeapUtil.Allocate<SharpVk.Interop.PhysicalDevice>((uint)(physicalDeviceCount)));
                Interop.Commands.vkEnumeratePhysicalDevices(this.handle, &physicalDeviceCount, marshalledPhysicalDevices);
                if (marshalledPhysicalDevices != null)
                {
                    var fieldPointer = new SharpVk.PhysicalDevice[(uint)(physicalDeviceCount)];
                    for(int index = 0; index < (uint)(physicalDeviceCount); index++)
                    {
                        fieldPointer[index] = new SharpVk.PhysicalDevice(this, marshalledPhysicalDevices[index]);
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
        /// Return a function pointer for a command.
        /// </summary>
        public unsafe IntPtr GetProcedureAddress(string name)
        {
            try
            {
                IntPtr result = default(IntPtr);
                result = Interop.Commands.vkGetInstanceProcAddr(this.handle, Interop.HeapUtil.MarshalTo(name));
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Returns up to requested number of global extension properties.
        /// </summary>
        public static unsafe SharpVk.ExtensionProperties[] EnumerateExtensionProperties(string layerName)
        {
            try
            {
                SharpVk.ExtensionProperties[] result = default(SharpVk.ExtensionProperties[]);
                uint propertyCount = default(uint);
                SharpVk.Interop.ExtensionProperties* marshalledProperties = default(SharpVk.Interop.ExtensionProperties*);
                Result methodResult = Interop.Commands.vkEnumerateInstanceExtensionProperties(Interop.HeapUtil.MarshalTo(layerName), &propertyCount, marshalledProperties);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                marshalledProperties = (SharpVk.Interop.ExtensionProperties*)(Interop.HeapUtil.Allocate<SharpVk.Interop.ExtensionProperties>((uint)(propertyCount)));
                Interop.Commands.vkEnumerateInstanceExtensionProperties(Interop.HeapUtil.MarshalTo(layerName), &propertyCount, marshalledProperties);
                if (marshalledProperties != null)
                {
                    var fieldPointer = new SharpVk.ExtensionProperties[(uint)(propertyCount)];
                    for(int index = 0; index < (uint)(propertyCount); index++)
                    {
                        fieldPointer[index] = SharpVk.ExtensionProperties.MarshalFrom(&marshalledProperties[index]);
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
        /// Returns up to requested number of global layer properties.
        /// </summary>
        public static unsafe SharpVk.LayerProperties[] EnumerateLayerProperties()
        {
            try
            {
                SharpVk.LayerProperties[] result = default(SharpVk.LayerProperties[]);
                uint propertyCount = default(uint);
                SharpVk.Interop.LayerProperties* marshalledProperties = default(SharpVk.Interop.LayerProperties*);
                Result methodResult = Interop.Commands.vkEnumerateInstanceLayerProperties(&propertyCount, marshalledProperties);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                marshalledProperties = (SharpVk.Interop.LayerProperties*)(Interop.HeapUtil.Allocate<SharpVk.Interop.LayerProperties>((uint)(propertyCount)));
                Interop.Commands.vkEnumerateInstanceLayerProperties(&propertyCount, marshalledProperties);
                if (marshalledProperties != null)
                {
                    var fieldPointer = new SharpVk.LayerProperties[(uint)(propertyCount)];
                    for(int index = 0; index < (uint)(propertyCount); index++)
                    {
                        fieldPointer[index] = SharpVk.LayerProperties.MarshalFrom(&marshalledProperties[index]);
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
        public void Dispose()
        {
            this.Destroy();
        }
    }
}
