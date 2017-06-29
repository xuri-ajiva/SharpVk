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
    public partial class PhysicalDevice
    {
        internal readonly SharpVk.Interop.PhysicalDevice handle; 
        
        internal readonly CommandCache commandCache; 
        
        private readonly SharpVk.Interop.Instance parent; 
        
        internal PhysicalDevice(SharpVk.Interop.Instance parent, SharpVk.Interop.PhysicalDevice handle, CommandCache commandCache)
        {
            this.handle = handle;
            this.parent = parent;
            this.commandCache = commandCache;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public unsafe SharpVk.PhysicalDeviceProperties GetProperties()
        {
            try
            {
                SharpVk.PhysicalDeviceProperties result = default(SharpVk.PhysicalDeviceProperties);
                SharpVk.Interop.PhysicalDeviceProperties marshalledProperties = default(SharpVk.Interop.PhysicalDeviceProperties);
                Interop.Commands.vkGetPhysicalDeviceProperties(this.handle, &marshalledProperties);
                result = SharpVk.PhysicalDeviceProperties.MarshalFrom(&marshalledProperties);
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
        public unsafe SharpVk.QueueFamilyProperties[] GetQueueFamilyProperties()
        {
            try
            {
                SharpVk.QueueFamilyProperties[] result = default(SharpVk.QueueFamilyProperties[]);
                uint queueFamilyPropertyCount = default(uint);
                SharpVk.QueueFamilyProperties* marshalledQueueFamilyProperties = default(SharpVk.QueueFamilyProperties*);
                Interop.Commands.vkGetPhysicalDeviceQueueFamilyProperties(this.handle, &queueFamilyPropertyCount, marshalledQueueFamilyProperties);
                marshalledQueueFamilyProperties = (SharpVk.QueueFamilyProperties*)(Interop.HeapUtil.Allocate<SharpVk.QueueFamilyProperties>((uint)(queueFamilyPropertyCount)));
                Interop.Commands.vkGetPhysicalDeviceQueueFamilyProperties(this.handle, &queueFamilyPropertyCount, marshalledQueueFamilyProperties);
                if (marshalledQueueFamilyProperties != null)
                {
                    var fieldPointer = new SharpVk.QueueFamilyProperties[(uint)(queueFamilyPropertyCount)];
                    for(int index = 0; index < (uint)(queueFamilyPropertyCount); index++)
                    {
                        fieldPointer[index] = marshalledQueueFamilyProperties[index];
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
        public unsafe SharpVk.PhysicalDeviceMemoryProperties GetMemoryProperties()
        {
            try
            {
                SharpVk.PhysicalDeviceMemoryProperties result = default(SharpVk.PhysicalDeviceMemoryProperties);
                SharpVk.Interop.PhysicalDeviceMemoryProperties marshalledMemoryProperties = default(SharpVk.Interop.PhysicalDeviceMemoryProperties);
                Interop.Commands.vkGetPhysicalDeviceMemoryProperties(this.handle, &marshalledMemoryProperties);
                result = SharpVk.PhysicalDeviceMemoryProperties.MarshalFrom(&marshalledMemoryProperties);
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
        public unsafe SharpVk.PhysicalDeviceFeatures GetFeatures()
        {
            try
            {
                SharpVk.PhysicalDeviceFeatures result = default(SharpVk.PhysicalDeviceFeatures);
                SharpVk.PhysicalDeviceFeatures marshalledFeatures = default(SharpVk.PhysicalDeviceFeatures);
                Interop.Commands.vkGetPhysicalDeviceFeatures(this.handle, &marshalledFeatures);
                result = marshalledFeatures;
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
        public unsafe SharpVk.FormatProperties GetFormatProperties(SharpVk.Format format)
        {
            try
            {
                SharpVk.FormatProperties result = default(SharpVk.FormatProperties);
                SharpVk.FormatProperties marshalledFormatProperties = default(SharpVk.FormatProperties);
                Interop.Commands.vkGetPhysicalDeviceFormatProperties(this.handle, format, &marshalledFormatProperties);
                result = marshalledFormatProperties;
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
        public unsafe SharpVk.ImageFormatProperties GetImageFormatProperties(SharpVk.Format format, SharpVk.ImageType type, SharpVk.ImageTiling tiling, SharpVk.ImageUsageFlags usage, SharpVk.ImageCreateFlags? flags = default(SharpVk.ImageCreateFlags?))
        {
            try
            {
                SharpVk.ImageFormatProperties result = default(SharpVk.ImageFormatProperties);
                SharpVk.ImageCreateFlags marshalledFlags = default(SharpVk.ImageCreateFlags);
                SharpVk.ImageFormatProperties marshalledImageFormatProperties = default(SharpVk.ImageFormatProperties);
                if (flags != null)
                {
                    marshalledFlags = flags.Value;
                }
                else
                {
                    marshalledFlags = default(SharpVk.ImageCreateFlags);
                }
                Result methodResult = Interop.Commands.vkGetPhysicalDeviceImageFormatProperties(this.handle, format, type, tiling, usage, marshalledFlags, &marshalledImageFormatProperties);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = marshalledImageFormatProperties;
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
        public unsafe SharpVk.Device CreateDevice(SharpVk.DeviceQueueCreateInfo[] queueCreateInfos, string[] enabledLayerNames, string[] enabledExtensionNames, SharpVk.DeviceCreateFlags? flags = default(SharpVk.DeviceCreateFlags?), SharpVk.PhysicalDeviceFeatures? enabledFeatures = default(SharpVk.PhysicalDeviceFeatures?), SharpVk.AllocationCallbacks? allocator = default(SharpVk.AllocationCallbacks?))
        {
            try
            {
                SharpVk.Device result = default(SharpVk.Device);
                SharpVk.Interop.DeviceCreateInfo* marshalledCreateInfo = default(SharpVk.Interop.DeviceCreateInfo*);
                SharpVk.Interop.AllocationCallbacks* marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                SharpVk.Interop.Device marshalledDevice = default(SharpVk.Interop.Device);
                marshalledCreateInfo = (SharpVk.Interop.DeviceCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.DeviceCreateInfo>());
                marshalledCreateInfo->SType = StructureType.DeviceCreateInfo;
                marshalledCreateInfo->Next = null;
                if (flags != null)
                {
                    marshalledCreateInfo->Flags = flags.Value;
                }
                else
                {
                    marshalledCreateInfo->Flags = default(SharpVk.DeviceCreateFlags);
                }
                marshalledCreateInfo->QueueCreateInfoCount = (uint)(queueCreateInfos?.Length ?? 0);
                if (queueCreateInfos != null)
                {
                    var fieldPointer = (SharpVk.Interop.DeviceQueueCreateInfo*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.DeviceQueueCreateInfo>(queueCreateInfos.Length).ToPointer());
                    for(int index = 0; index < (uint)(queueCreateInfos.Length); index++)
                    {
                        queueCreateInfos[index].MarshalTo(&fieldPointer[index]);
                    }
                    marshalledCreateInfo->QueueCreateInfos = fieldPointer;
                }
                else
                {
                    marshalledCreateInfo->QueueCreateInfos = null;
                }
                marshalledCreateInfo->EnabledLayerCount = (uint)(enabledLayerNames?.Length ?? 0);
                marshalledCreateInfo->EnabledExtensionCount = (uint)(enabledExtensionNames?.Length ?? 0);
                if (enabledFeatures != null)
                {
                    marshalledCreateInfo->EnabledFeatures = (SharpVk.PhysicalDeviceFeatures*)(Interop.HeapUtil.Allocate<SharpVk.PhysicalDeviceFeatures>());
                    *marshalledCreateInfo->EnabledFeatures = enabledFeatures.Value;
                }
                else
                {
                    marshalledCreateInfo->EnabledFeatures = default(SharpVk.PhysicalDeviceFeatures*);
                }
                if (allocator != null)
                {
                    marshalledAllocator = (SharpVk.Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<SharpVk.Interop.AllocationCallbacks>());
                    allocator.Value.MarshalTo(marshalledAllocator);
                }
                else
                {
                    marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                }
                Result methodResult = Interop.Commands.vkCreateDevice(this.handle, marshalledCreateInfo, marshalledAllocator, &marshalledDevice);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = new SharpVk.Device(this.handle, marshalledDevice, null);
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
        public unsafe SharpVk.LayerProperties[] EnumerateDeviceLayerProperties()
        {
            try
            {
                SharpVk.LayerProperties[] result = default(SharpVk.LayerProperties[]);
                uint propertyCount = default(uint);
                SharpVk.Interop.LayerProperties* marshalledProperties = default(SharpVk.Interop.LayerProperties*);
                Result methodResult = Interop.Commands.vkEnumerateDeviceLayerProperties(this.handle, &propertyCount, marshalledProperties);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                marshalledProperties = (SharpVk.Interop.LayerProperties*)(Interop.HeapUtil.Allocate<SharpVk.Interop.LayerProperties>((uint)(propertyCount)));
                Interop.Commands.vkEnumerateDeviceLayerProperties(this.handle, &propertyCount, marshalledProperties);
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
        public unsafe SharpVk.ExtensionProperties[] EnumerateDeviceExtensionProperties(string layerName)
        {
            try
            {
                SharpVk.ExtensionProperties[] result = default(SharpVk.ExtensionProperties[]);
                uint propertyCount = default(uint);
                SharpVk.Interop.ExtensionProperties* marshalledProperties = default(SharpVk.Interop.ExtensionProperties*);
                Result methodResult = Interop.Commands.vkEnumerateDeviceExtensionProperties(this.handle, Interop.HeapUtil.MarshalTo(layerName), &propertyCount, marshalledProperties);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                marshalledProperties = (SharpVk.Interop.ExtensionProperties*)(Interop.HeapUtil.Allocate<SharpVk.Interop.ExtensionProperties>((uint)(propertyCount)));
                Interop.Commands.vkEnumerateDeviceExtensionProperties(this.handle, Interop.HeapUtil.MarshalTo(layerName), &propertyCount, marshalledProperties);
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
        /// 
        /// </summary>
        public unsafe SharpVk.SparseImageFormatProperties[] GetSparseImageFormatProperties(SharpVk.Format format, SharpVk.ImageType type, SharpVk.SampleCountFlags samples, SharpVk.ImageUsageFlags usage, SharpVk.ImageTiling tiling)
        {
            try
            {
                SharpVk.SparseImageFormatProperties[] result = default(SharpVk.SparseImageFormatProperties[]);
                uint propertyCount = default(uint);
                SharpVk.SparseImageFormatProperties* marshalledProperties = default(SharpVk.SparseImageFormatProperties*);
                Interop.Commands.vkGetPhysicalDeviceSparseImageFormatProperties(this.handle, format, type, samples, usage, tiling, &propertyCount, marshalledProperties);
                marshalledProperties = (SharpVk.SparseImageFormatProperties*)(Interop.HeapUtil.Allocate<SharpVk.SparseImageFormatProperties>((uint)(propertyCount)));
                Interop.Commands.vkGetPhysicalDeviceSparseImageFormatProperties(this.handle, format, type, samples, usage, tiling, &propertyCount, marshalledProperties);
                if (marshalledProperties != null)
                {
                    var fieldPointer = new SharpVk.SparseImageFormatProperties[(uint)(propertyCount)];
                    for(int index = 0; index < (uint)(propertyCount); index++)
                    {
                        fieldPointer[index] = marshalledProperties[index];
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
