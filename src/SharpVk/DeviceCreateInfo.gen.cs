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
using System.Runtime.InteropServices;

namespace SharpVk
{
    /// <summary>
    /// Structure specifying parameters of a newly created device.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct DeviceCreateInfo
    {
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.DeviceCreateFlags? Flags
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.DeviceQueueCreateInfo[] QueueCreateInfos
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public string[] EnabledLayerNames
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public string[] EnabledExtensionNames
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.PhysicalDeviceFeatures? EnabledFeatures
        {
            get;
            set;
        }
        
        internal unsafe void MarshalTo(SharpVk.Interop.DeviceCreateInfo* pointer)
        {
            pointer->SType = StructureType.DeviceCreateInfo;
            pointer->Next = null;
            if (this.Flags != null)
            {
                pointer->Flags = this.Flags.Value;
            }
            else
            {
                pointer->Flags = default(SharpVk.DeviceCreateFlags);
            }
            pointer->QueueCreateInfoCount = (uint)(this.QueueCreateInfos?.Length ?? 0);
            if (this.QueueCreateInfos != null)
            {
                var fieldPointer = (SharpVk.Interop.DeviceQueueCreateInfo*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.DeviceQueueCreateInfo>(this.QueueCreateInfos.Length).ToPointer());
                for(int index = 0; index < (uint)(this.QueueCreateInfos.Length); index++)
                {
                    this.QueueCreateInfos[index].MarshalTo(&fieldPointer[index]);
                }
                pointer->QueueCreateInfos = fieldPointer;
            }
            else
            {
                pointer->QueueCreateInfos = null;
            }
            pointer->EnabledLayerCount = (uint)(this.EnabledLayerNames?.Length ?? 0);
            if (this.EnabledLayerNames != null)
            {
                pointer->EnabledLayerNames = Interop.HeapUtil.MarshalTo(this.EnabledLayerNames);
            }
            else
            {
            }
            pointer->EnabledExtensionCount = (uint)(this.EnabledExtensionNames?.Length ?? 0);
            if (this.EnabledExtensionNames != null)
            {
                pointer->EnabledExtensionNames = Interop.HeapUtil.MarshalTo(this.EnabledExtensionNames);
            }
            else
            {
            }
            if (this.EnabledFeatures != null)
            {
                pointer->EnabledFeatures = (SharpVk.Interop.PhysicalDeviceFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.PhysicalDeviceFeatures>());
                this.EnabledFeatures.Value.MarshalTo(pointer->EnabledFeatures);
            }
            else
            {
                pointer->EnabledFeatures = default(SharpVk.Interop.PhysicalDeviceFeatures*);
            }
        }
    }
}
