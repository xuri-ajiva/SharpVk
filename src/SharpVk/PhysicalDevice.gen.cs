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
        
        internal unsafe void GetProperties()
        {
        }
        
        internal unsafe void GetQueueFamilyProperties()
        {
            uint queueFamilyPropertyCount;
        }
        
        internal unsafe void GetMemoryProperties()
        {
        }
        
        internal unsafe void GetFeatures()
        {
        }
        
        internal unsafe void GetFormatProperties(Format format)
        {
            Format marshalledFormat;
            marshalledFormat = format;
        }
        
        internal unsafe void GetImageFormatProperties(Format format, ImageType type, ImageTiling tiling, ImageUsageFlags usage, ImageCreateFlags flags)
        {
            Format marshalledFormat;
            marshalledFormat = format;
            ImageType marshalledType;
            marshalledType = type;
            ImageTiling marshalledTiling;
            marshalledTiling = tiling;
            ImageUsageFlags marshalledUsage;
            marshalledUsage = usage;
            ImageCreateFlags marshalledFlags;
            marshalledFlags = flags;
        }
        
        internal unsafe void CreateDevice(DeviceCreateInfo createInfo, AllocationCallbacks allocator)
        {
            Interop.DeviceCreateInfo* marshalledCreateInfo;
            marshalledCreateInfo = (Interop.DeviceCreateInfo*)(Interop.HeapUtil.Allocate<Interop.DeviceCreateInfo>());
            createInfo.MarshalTo(marshalledCreateInfo);
            Interop.AllocationCallbacks* marshalledAllocator;
            marshalledAllocator = (Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<Interop.AllocationCallbacks>());
            allocator.MarshalTo(marshalledAllocator);
        }
        
        internal unsafe void EnumerateDeviceLayerProperties()
        {
            uint propertyCount;
        }
        
        internal unsafe void EnumerateDeviceExtensionProperties(string layerName)
        {
            uint propertyCount;
            byte* marshalledLayerName;
            marshalledLayerName = Interop.HeapUtil.MarshalTo(layerName);
        }
        
        internal unsafe void GetSparseImageFormatProperties(Format format, ImageType type, SampleCountFlags samples, ImageUsageFlags usage, ImageTiling tiling)
        {
            uint propertyCount;
            Format marshalledFormat;
            marshalledFormat = format;
            ImageType marshalledType;
            marshalledType = type;
            SampleCountFlags marshalledSamples;
            marshalledSamples = samples;
            ImageUsageFlags marshalledUsage;
            marshalledUsage = usage;
            ImageTiling marshalledTiling;
            marshalledTiling = tiling;
        }
    }
}
