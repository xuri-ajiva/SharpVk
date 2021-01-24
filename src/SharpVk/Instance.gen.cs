// The MIT License (MIT)
// 
// Copyright (c) Andrew Armstrong/FacticiusVir & xuri 2021
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
        internal readonly SharpVk.Interop.Instance Handle; 
        
        internal readonly CommandCache commandCache; 
        
        internal Instance(CommandCache commandCache, SharpVk.Interop.Instance handle)
        {
            Handle = handle;
            this.commandCache = new CommandCache(this, "instance", commandCache);
            this.commandCache.Initialise();
        }
        
        /// <summary>
        /// The raw handle for this instance.
        /// </summary>
        public SharpVk.Interop.Instance RawHandle => Handle;
        
        /// <summary>
        /// Create a new Vulkan instance.
        /// </summary>
        /// <param name="commandCache">
        /// </param>
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
        /// <param name="debugReportCallbackCreateInfoExt">
        /// Extension struct
        /// </param>
        /// <param name="validationFlagsExt">
        /// Extension struct
        /// </param>
        /// <param name="validationFeaturesExt">
        /// Extension struct
        /// </param>
        /// <param name="debugUtilsMessengerCreateInfoExt">
        /// Extension struct
        /// </param>
        /// <param name="allocator">
        /// An optional AllocationCallbacks instance that controls host memory
        /// allocation.
        /// </param>
        public static unsafe Instance Create(CommandCache commandCache, ArrayProxy<string>? enabledLayerNames, ArrayProxy<string>? enabledExtensionNames, InstanceCreateFlags? flags = default, ApplicationInfo? applicationInfo = default, Multivendor.DebugReportCallbackCreateInfo? debugReportCallbackCreateInfoExt = null, Multivendor.ValidationFlags? validationFlagsExt = null, Multivendor.ValidationFeatures? validationFeaturesExt = null, Multivendor.DebugUtilsMessengerCreateInfo? debugUtilsMessengerCreateInfoExt = null, AllocationCallbacks? allocator = default)
        {
            try
            {
                Instance result = default;
                SharpVk.Interop.InstanceCreateInfo* marshalledCreateInfo = default;
                void* vkInstanceCreateInfoNextPointer = default;
                SharpVk.Interop.AllocationCallbacks* marshalledAllocator = default;
                SharpVk.Interop.Instance marshalledInstance = default;
                if (debugReportCallbackCreateInfoExt != null)
                {
                    SharpVk.Interop.Multivendor.DebugReportCallbackCreateInfo* extensionPointer = default;
                    extensionPointer = (SharpVk.Interop.Multivendor.DebugReportCallbackCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.DebugReportCallbackCreateInfo>());
                    debugReportCallbackCreateInfoExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkInstanceCreateInfoNextPointer;
                    vkInstanceCreateInfoNextPointer = extensionPointer;
                }
                if (validationFlagsExt != null)
                {
                    SharpVk.Interop.Multivendor.ValidationFlags* extensionPointer = default;
                    extensionPointer = (SharpVk.Interop.Multivendor.ValidationFlags*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.ValidationFlags>());
                    validationFlagsExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkInstanceCreateInfoNextPointer;
                    vkInstanceCreateInfoNextPointer = extensionPointer;
                }
                if (validationFeaturesExt != null)
                {
                    SharpVk.Interop.Multivendor.ValidationFeatures* extensionPointer = default;
                    extensionPointer = (SharpVk.Interop.Multivendor.ValidationFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.ValidationFeatures>());
                    validationFeaturesExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkInstanceCreateInfoNextPointer;
                    vkInstanceCreateInfoNextPointer = extensionPointer;
                }
                if (debugUtilsMessengerCreateInfoExt != null)
                {
                    SharpVk.Interop.Multivendor.DebugUtilsMessengerCreateInfo* extensionPointer = default;
                    extensionPointer = (SharpVk.Interop.Multivendor.DebugUtilsMessengerCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.DebugUtilsMessengerCreateInfo>());
                    debugUtilsMessengerCreateInfoExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkInstanceCreateInfoNextPointer;
                    vkInstanceCreateInfoNextPointer = extensionPointer;
                }
                marshalledCreateInfo = (SharpVk.Interop.InstanceCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.InstanceCreateInfo>());
                marshalledCreateInfo->SType = StructureType.InstanceCreateInfo;
                marshalledCreateInfo->Next = vkInstanceCreateInfoNextPointer;
                if (flags != null)
                {
                    marshalledCreateInfo->Flags = flags.Value;
                }
                else
                {
                    marshalledCreateInfo->Flags = default;
                }
                if (applicationInfo != null)
                {
                    marshalledCreateInfo->ApplicationInfo = (SharpVk.Interop.ApplicationInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.ApplicationInfo>());
                    applicationInfo.Value.MarshalTo(marshalledCreateInfo->ApplicationInfo);
                }
                else
                {
                    marshalledCreateInfo->ApplicationInfo = default;
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
                    marshalledAllocator = default;
                }
                Interop.VkInstanceCreateDelegate commandDelegate = commandCache.Cache.vkCreateInstance;
                Result methodResult = commandDelegate(marshalledCreateInfo, marshalledAllocator, &marshalledInstance);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = new Instance(commandCache, marshalledInstance);
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
        public unsafe void Destroy(AllocationCallbacks? allocator = default)
        {
            try
            {
                SharpVk.Interop.AllocationCallbacks* marshalledAllocator = default;
                if (allocator != null)
                {
                    marshalledAllocator = (SharpVk.Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<SharpVk.Interop.AllocationCallbacks>());
                    allocator.Value.MarshalTo(marshalledAllocator);
                }
                else
                {
                    marshalledAllocator = default;
                }
                Interop.VkInstanceDestroyDelegate commandDelegate = commandCache.Cache.vkDestroyInstance;
                commandDelegate(Handle, marshalledAllocator);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Enumerates the physical devices accessible to a Vulkan instance.
        /// </summary>
        public unsafe PhysicalDevice[] EnumeratePhysicalDevices()
        {
            try
            {
                PhysicalDevice[] result = default;
                uint marshalledPhysicalDeviceCount = default;
                SharpVk.Interop.PhysicalDevice* marshalledPhysicalDevices = default;
                Interop.VkInstanceEnumeratePhysicalDevicesDelegate commandDelegate = commandCache.Cache.vkEnumeratePhysicalDevices;
                Result methodResult = commandDelegate(Handle, &marshalledPhysicalDeviceCount, marshalledPhysicalDevices);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                marshalledPhysicalDevices = (SharpVk.Interop.PhysicalDevice*)(Interop.HeapUtil.Allocate<SharpVk.Interop.PhysicalDevice>((uint)(marshalledPhysicalDeviceCount)));
                commandDelegate(Handle, &marshalledPhysicalDeviceCount, marshalledPhysicalDevices);
                if (marshalledPhysicalDevices != null)
                {
                    var fieldPointer = new PhysicalDevice[(uint)(marshalledPhysicalDeviceCount)];
                    for(int index = 0; index < (uint)(marshalledPhysicalDeviceCount); index++)
                    {
                        fieldPointer[index] = new PhysicalDevice(this, marshalledPhysicalDevices[index]);
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
        /// <param name="name">
        /// </param>
        public unsafe IntPtr GetProcedureAddress(string name)
        {
            try
            {
                IntPtr result = default;
                Interop.VkInstanceGetProcedureAddressDelegate commandDelegate = commandCache.Cache.vkGetInstanceProcAddr;
                result = commandDelegate(Handle, Interop.HeapUtil.MarshalTo(name));
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
        /// <param name="commandCache">
        /// </param>
        /// <param name="layerName">
        /// </param>
        public static unsafe ExtensionProperties[] EnumerateExtensionProperties(CommandCache commandCache, string layerName)
        {
            try
            {
                ExtensionProperties[] result = default;
                uint marshalledPropertyCount = default;
                SharpVk.Interop.ExtensionProperties* marshalledProperties = default;
                Interop.VkInstanceEnumerateExtensionPropertiesDelegate commandDelegate = commandCache.Cache.vkEnumerateInstanceExtensionProperties;
                Result methodResult = commandDelegate(Interop.HeapUtil.MarshalTo(layerName), &marshalledPropertyCount, marshalledProperties);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                marshalledProperties = (SharpVk.Interop.ExtensionProperties*)(Interop.HeapUtil.Allocate<SharpVk.Interop.ExtensionProperties>((uint)(marshalledPropertyCount)));
                commandDelegate(Interop.HeapUtil.MarshalTo(layerName), &marshalledPropertyCount, marshalledProperties);
                if (marshalledProperties != null)
                {
                    var fieldPointer = new ExtensionProperties[(uint)(marshalledPropertyCount)];
                    for(int index = 0; index < (uint)(marshalledPropertyCount); index++)
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
        
        /// <summary>
        /// Returns up to requested number of global layer properties.
        /// </summary>
        /// <param name="commandCache">
        /// </param>
        public static unsafe LayerProperties[] EnumerateLayerProperties(CommandCache commandCache)
        {
            try
            {
                LayerProperties[] result = default;
                uint marshalledPropertyCount = default;
                SharpVk.Interop.LayerProperties* marshalledProperties = default;
                Interop.VkInstanceEnumerateLayerPropertiesDelegate commandDelegate = commandCache.Cache.vkEnumerateInstanceLayerProperties;
                Result methodResult = commandDelegate(&marshalledPropertyCount, marshalledProperties);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                marshalledProperties = (SharpVk.Interop.LayerProperties*)(Interop.HeapUtil.Allocate<SharpVk.Interop.LayerProperties>((uint)(marshalledPropertyCount)));
                commandDelegate(&marshalledPropertyCount, marshalledProperties);
                if (marshalledProperties != null)
                {
                    var fieldPointer = new LayerProperties[(uint)(marshalledPropertyCount)];
                    for(int index = 0; index < (uint)(marshalledPropertyCount); index++)
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
        /// </summary>
        /// <param name="commandCache">
        /// </param>
        public static unsafe Version EnumerateVersion(CommandCache commandCache)
        {
            try
            {
                Version result = default;
                uint marshalledApiVersion = default;
                Interop.VkInstanceEnumerateVersionDelegate commandDelegate = commandCache.Cache.vkEnumerateInstanceVersion;
                Result methodResult = commandDelegate(&marshalledApiVersion);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = (Version)(marshalledApiVersion);
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// </summary>
        public unsafe PhysicalDeviceGroupProperties[] EnumeratePhysicalDeviceGroups()
        {
            try
            {
                PhysicalDeviceGroupProperties[] result = default;
                uint marshalledPhysicalDeviceGroupCount = default;
                SharpVk.Interop.PhysicalDeviceGroupProperties* marshalledPhysicalDeviceGroupProperties = default;
                Interop.VkInstanceEnumeratePhysicalDeviceGroupsDelegate commandDelegate = commandCache.Cache.vkEnumeratePhysicalDeviceGroups;
                Result methodResult = commandDelegate(Handle, &marshalledPhysicalDeviceGroupCount, marshalledPhysicalDeviceGroupProperties);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                marshalledPhysicalDeviceGroupProperties = (SharpVk.Interop.PhysicalDeviceGroupProperties*)(Interop.HeapUtil.Allocate<SharpVk.Interop.PhysicalDeviceGroupProperties>((uint)(marshalledPhysicalDeviceGroupCount)));
                commandDelegate(Handle, &marshalledPhysicalDeviceGroupCount, marshalledPhysicalDeviceGroupProperties);
                if (marshalledPhysicalDeviceGroupProperties != null)
                {
                    var fieldPointer = new PhysicalDeviceGroupProperties[(uint)(marshalledPhysicalDeviceGroupCount)];
                    for(int index = 0; index < (uint)(marshalledPhysicalDeviceGroupCount); index++)
                    {
                        fieldPointer[index] = PhysicalDeviceGroupProperties.MarshalFrom(&marshalledPhysicalDeviceGroupProperties[index]);
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
        /// Destroys the handles and releases any unmanaged resources
        /// associated with it.
        /// </summary>
        public void Dispose()
        {
            Destroy();
        }
    }
}
