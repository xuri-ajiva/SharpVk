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
        
        internal PhysicalDevice(SharpVk.Interop.PhysicalDevice handle)
        {
            this.handle = handle;
        }
        
        internal unsafe PhysicalDeviceProperties GetProperties()
        {
            try
            {
                PhysicalDeviceProperties result = default(PhysicalDeviceProperties);
                Interop.PhysicalDeviceProperties* marshalledProperties = default(Interop.PhysicalDeviceProperties*);
                result = PhysicalDeviceProperties.MarshalFrom(marshalledProperties);
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        internal unsafe QueueFamilyProperties[] GetQueueFamilyProperties()
        {
            try
            {
                QueueFamilyProperties[] result = default(QueueFamilyProperties[]);
                uint queueFamilyPropertyCount = default(uint);
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        internal unsafe PhysicalDeviceMemoryProperties GetMemoryProperties()
        {
            try
            {
                PhysicalDeviceMemoryProperties result = default(PhysicalDeviceMemoryProperties);
                Interop.PhysicalDeviceMemoryProperties* marshalledMemoryProperties = default(Interop.PhysicalDeviceMemoryProperties*);
                result = PhysicalDeviceMemoryProperties.MarshalFrom(marshalledMemoryProperties);
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        internal unsafe PhysicalDeviceFeatures GetFeatures()
        {
            try
            {
                PhysicalDeviceFeatures result = default(PhysicalDeviceFeatures);
                PhysicalDeviceFeatures* marshalledFeatures = default(PhysicalDeviceFeatures*);
                result = *marshalledFeatures;
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        internal unsafe FormatProperties GetFormatProperties(Format format)
        {
            try
            {
                FormatProperties result = default(FormatProperties);
                Format marshalledFormat = default(Format);
                FormatProperties* marshalledFormatProperties = default(FormatProperties*);
                marshalledFormat = format;
                result = *marshalledFormatProperties;
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        internal unsafe ImageFormatProperties GetImageFormatProperties(Format format, ImageType type, ImageTiling tiling, ImageUsageFlags usage, ImageCreateFlags flags)
        {
            try
            {
                ImageFormatProperties result = default(ImageFormatProperties);
                Format marshalledFormat = default(Format);
                ImageType marshalledType = default(ImageType);
                ImageTiling marshalledTiling = default(ImageTiling);
                ImageUsageFlags marshalledUsage = default(ImageUsageFlags);
                ImageCreateFlags marshalledFlags = default(ImageCreateFlags);
                ImageFormatProperties* marshalledImageFormatProperties = default(ImageFormatProperties*);
                marshalledFormat = format;
                marshalledType = type;
                marshalledTiling = tiling;
                marshalledUsage = usage;
                marshalledFlags = flags;
                result = *marshalledImageFormatProperties;
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        internal unsafe Device CreateDevice(DeviceCreateInfo createInfo, AllocationCallbacks allocator)
        {
            try
            {
                Device result = default(Device);
                Interop.DeviceCreateInfo* marshalledCreateInfo = default(Interop.DeviceCreateInfo*);
                Interop.AllocationCallbacks* marshalledAllocator = default(Interop.AllocationCallbacks*);
                Interop.Device* marshalledDevice = default(Interop.Device*);
                marshalledCreateInfo = (Interop.DeviceCreateInfo*)(Interop.HeapUtil.Allocate<Interop.DeviceCreateInfo>());
                createInfo.MarshalTo(marshalledCreateInfo);
                marshalledAllocator = (Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<Interop.AllocationCallbacks>());
                allocator.MarshalTo(marshalledAllocator);
                result = new Device(*marshalledDevice);
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        internal unsafe LayerProperties[] EnumerateDeviceLayerProperties()
        {
            try
            {
                LayerProperties[] result = default(LayerProperties[]);
                uint propertyCount = default(uint);
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        internal unsafe ExtensionProperties[] EnumerateDeviceExtensionProperties(string layerName)
        {
            try
            {
                ExtensionProperties[] result = default(ExtensionProperties[]);
                uint propertyCount = default(uint);
                byte* marshalledLayerName = default(byte*);
                marshalledLayerName = Interop.HeapUtil.MarshalTo(layerName);
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        internal unsafe SparseImageFormatProperties[] GetSparseImageFormatProperties(Format format, ImageType type, SampleCountFlags samples, ImageUsageFlags usage, ImageTiling tiling)
        {
            try
            {
                SparseImageFormatProperties[] result = default(SparseImageFormatProperties[]);
                uint propertyCount = default(uint);
                Format marshalledFormat = default(Format);
                ImageType marshalledType = default(ImageType);
                SampleCountFlags marshalledSamples = default(SampleCountFlags);
                ImageUsageFlags marshalledUsage = default(ImageUsageFlags);
                ImageTiling marshalledTiling = default(ImageTiling);
                marshalledFormat = format;
                marshalledType = type;
                marshalledSamples = samples;
                marshalledUsage = usage;
                marshalledTiling = tiling;
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
    }
}
