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
        
        private readonly SharpVk.Interop.Instance parent; 
        
        internal PhysicalDevice(SharpVk.Interop.Instance parent, SharpVk.Interop.PhysicalDevice handle)
        {
            this.handle = handle;
            this.parent = parent;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public unsafe PhysicalDeviceProperties GetProperties()
        {
            try
            {
                PhysicalDeviceProperties result = default(PhysicalDeviceProperties);
                Interop.PhysicalDeviceProperties marshalledProperties = default(Interop.PhysicalDeviceProperties);
                Interop.Commands.vkGetPhysicalDeviceProperties(this.handle, &marshalledProperties);
                result = PhysicalDeviceProperties.MarshalFrom(&marshalledProperties);
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
        public unsafe QueueFamilyProperties[] GetQueueFamilyProperties()
        {
            try
            {
                QueueFamilyProperties[] result = default(QueueFamilyProperties[]);
                uint queueFamilyPropertyCount = default(uint);
                QueueFamilyProperties* marshalledQueueFamilyProperties = default(QueueFamilyProperties*);
                Interop.Commands.vkGetPhysicalDeviceQueueFamilyProperties(this.handle, &queueFamilyPropertyCount, marshalledQueueFamilyProperties);
                marshalledQueueFamilyProperties = (QueueFamilyProperties*)(Interop.HeapUtil.Allocate<QueueFamilyProperties>((uint)(queueFamilyPropertyCount)));
                Interop.Commands.vkGetPhysicalDeviceQueueFamilyProperties(this.handle, &queueFamilyPropertyCount, marshalledQueueFamilyProperties);
                if (marshalledQueueFamilyProperties != null)
                {
                    var fieldPointer = new QueueFamilyProperties[(uint)(queueFamilyPropertyCount)];
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
        public unsafe PhysicalDeviceMemoryProperties GetMemoryProperties()
        {
            try
            {
                PhysicalDeviceMemoryProperties result = default(PhysicalDeviceMemoryProperties);
                Interop.PhysicalDeviceMemoryProperties marshalledMemoryProperties = default(Interop.PhysicalDeviceMemoryProperties);
                Interop.Commands.vkGetPhysicalDeviceMemoryProperties(this.handle, &marshalledMemoryProperties);
                result = PhysicalDeviceMemoryProperties.MarshalFrom(&marshalledMemoryProperties);
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
        public unsafe PhysicalDeviceFeatures GetFeatures()
        {
            try
            {
                PhysicalDeviceFeatures result = default(PhysicalDeviceFeatures);
                PhysicalDeviceFeatures marshalledFeatures = default(PhysicalDeviceFeatures);
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
        public unsafe FormatProperties GetFormatProperties(Format format)
        {
            try
            {
                FormatProperties result = default(FormatProperties);
                FormatProperties marshalledFormatProperties = default(FormatProperties);
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
        public unsafe ImageFormatProperties GetImageFormatProperties(Format format, ImageType type, ImageTiling tiling, ImageUsageFlags usage, ImageCreateFlags flags)
        {
            try
            {
                ImageFormatProperties result = default(ImageFormatProperties);
                ImageFormatProperties marshalledImageFormatProperties = default(ImageFormatProperties);
                Result methodResult = Interop.Commands.vkGetPhysicalDeviceImageFormatProperties(this.handle, format, type, tiling, usage, flags, &marshalledImageFormatProperties);
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
        public unsafe Device CreateDevice(DeviceCreateInfo createInfo, AllocationCallbacks? allocator = null)
        {
            try
            {
                Device result = default(Device);
                Interop.DeviceCreateInfo* marshalledCreateInfo = default(Interop.DeviceCreateInfo*);
                Interop.AllocationCallbacks* marshalledAllocator = default(Interop.AllocationCallbacks*);
                Interop.Device marshalledDevice = default(Interop.Device);
                marshalledCreateInfo = (Interop.DeviceCreateInfo*)(Interop.HeapUtil.Allocate<Interop.DeviceCreateInfo>());
                createInfo.MarshalTo(marshalledCreateInfo);
                if (allocator != null)
                {
                    marshalledAllocator = (Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<Interop.AllocationCallbacks>());
                    allocator.Value.MarshalTo(marshalledAllocator);
                }
                Result methodResult = Interop.Commands.vkCreateDevice(this.handle, marshalledCreateInfo, marshalledAllocator, &marshalledDevice);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = new Device(this.handle, marshalledDevice);
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
        public unsafe LayerProperties[] EnumerateDeviceLayerProperties()
        {
            try
            {
                LayerProperties[] result = default(LayerProperties[]);
                uint propertyCount = default(uint);
                Interop.LayerProperties* marshalledProperties = default(Interop.LayerProperties*);
                Result methodResult = Interop.Commands.vkEnumerateDeviceLayerProperties(this.handle, &propertyCount, marshalledProperties);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                marshalledProperties = (Interop.LayerProperties*)(Interop.HeapUtil.Allocate<Interop.LayerProperties>((uint)(propertyCount)));
                Interop.Commands.vkEnumerateDeviceLayerProperties(this.handle, &propertyCount, marshalledProperties);
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
        public unsafe ExtensionProperties[] EnumerateDeviceExtensionProperties(string layerName)
        {
            try
            {
                ExtensionProperties[] result = default(ExtensionProperties[]);
                uint propertyCount = default(uint);
                Interop.ExtensionProperties* marshalledProperties = default(Interop.ExtensionProperties*);
                Result methodResult = Interop.Commands.vkEnumerateDeviceExtensionProperties(this.handle, Interop.HeapUtil.MarshalTo(layerName), &propertyCount, marshalledProperties);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                marshalledProperties = (Interop.ExtensionProperties*)(Interop.HeapUtil.Allocate<Interop.ExtensionProperties>((uint)(propertyCount)));
                Interop.Commands.vkEnumerateDeviceExtensionProperties(this.handle, Interop.HeapUtil.MarshalTo(layerName), &propertyCount, marshalledProperties);
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
        
        /// <summary>
        /// 
        /// </summary>
        public unsafe SparseImageFormatProperties[] GetSparseImageFormatProperties(Format format, ImageType type, SampleCountFlags samples, ImageUsageFlags usage, ImageTiling tiling)
        {
            try
            {
                SparseImageFormatProperties[] result = default(SparseImageFormatProperties[]);
                uint propertyCount = default(uint);
                SparseImageFormatProperties* marshalledProperties = default(SparseImageFormatProperties*);
                Interop.Commands.vkGetPhysicalDeviceSparseImageFormatProperties(this.handle, format, type, samples, usage, tiling, &propertyCount, marshalledProperties);
                marshalledProperties = (SparseImageFormatProperties*)(Interop.HeapUtil.Allocate<SparseImageFormatProperties>((uint)(propertyCount)));
                Interop.Commands.vkGetPhysicalDeviceSparseImageFormatProperties(this.handle, format, type, samples, usage, tiling, &propertyCount, marshalledProperties);
                if (marshalledProperties != null)
                {
                    var fieldPointer = new SparseImageFormatProperties[(uint)(propertyCount)];
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
