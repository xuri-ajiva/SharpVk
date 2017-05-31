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
        
        internal static unsafe Instance Create(InstanceCreateInfo createInfo, AllocationCallbacks allocator)
        {
            try
            {
                Instance result = default(Instance);
                Interop.InstanceCreateInfo* marshalledCreateInfo = default(Interop.InstanceCreateInfo*);
                Interop.AllocationCallbacks* marshalledAllocator = default(Interop.AllocationCallbacks*);
                Interop.Instance* marshalledInstance = default(Interop.Instance*);
                marshalledCreateInfo = (Interop.InstanceCreateInfo*)(Interop.HeapUtil.Allocate<Interop.InstanceCreateInfo>());
                createInfo.MarshalTo(marshalledCreateInfo);
                marshalledAllocator = (Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<Interop.AllocationCallbacks>());
                allocator.MarshalTo(marshalledAllocator);
                result = new Instance(*marshalledInstance);
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        internal unsafe void Destroy(AllocationCallbacks allocator)
        {
            try
            {
                Interop.AllocationCallbacks* marshalledAllocator = default(Interop.AllocationCallbacks*);
                marshalledAllocator = (Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<Interop.AllocationCallbacks>());
                allocator.MarshalTo(marshalledAllocator);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        internal unsafe PhysicalDevice[] EnumeratePhysicalDevices()
        {
            try
            {
                PhysicalDevice[] result = default(PhysicalDevice[]);
                uint physicalDeviceCount = default(uint);
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        internal unsafe void GetProcedureAddress(string name)
        {
            try
            {
                byte* marshalledName = default(byte*);
                marshalledName = Interop.HeapUtil.MarshalTo(name);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        internal static unsafe LayerProperties[] EnumerateLayerProperties()
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
        
        internal static unsafe ExtensionProperties[] EnumerateExtensionProperties(string layerName)
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
    }
}
