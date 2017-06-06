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
    /// 
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct DeviceCreateInfo
    {
        /// <summary>
        /// 
        /// </summary>
        public DeviceCreateFlags Flags
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public DeviceQueueCreateInfo[] QueueCreateInfos
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
        public PhysicalDeviceFeatures? EnabledFeatures
        {
            get;
            set;
        }
        
        internal unsafe void MarshalTo(Interop.DeviceCreateInfo* pointer)
        {
            pointer->SType = StructureType.DeviceCreateInfo;
            pointer->Next = null;
            pointer->Flags = this.Flags;
            pointer->QueueCreateInfoCount = (uint)(this.QueueCreateInfos?.Length ?? 0);
            if (this.QueueCreateInfos != null)
            {
                var fieldPointer = (Interop.DeviceQueueCreateInfo*)(Interop.HeapUtil.AllocateAndClear<Interop.DeviceQueueCreateInfo>(this.QueueCreateInfos.Length).ToPointer());
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
            pointer->EnabledExtensionCount = (uint)(this.EnabledExtensionNames?.Length ?? 0);
            if (this.EnabledFeatures != null)
            {
                pointer->EnabledFeatures = (PhysicalDeviceFeatures*)(Interop.HeapUtil.Allocate<PhysicalDeviceFeatures>());
                *pointer->EnabledFeatures = this.EnabledFeatures.Value;
            }
        }
    }
}
