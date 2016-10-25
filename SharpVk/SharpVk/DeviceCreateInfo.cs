// The MIT License (MIT)
// 
// Copyright (c) Andrew Armstrong/FacticiusVir 2016
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
    /// <para>
    /// Structure specifying parameters of a newly created device.
    /// </para>
    /// <para>
    /// .Valid Usage **** * The pname:queueFamilyIndex member of any given
    /// element of pname:pQueueCreateInfos must: be unique within
    /// pname:pQueueCreateInfos ****
    /// </para>
    /// </summary>
    public struct DeviceCreateInfo
    {
        /// <summary>
        /// pname:flags is reserved for future use.
        /// </summary>
        public DeviceCreateFlags Flags
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:pQueueCreateInfos is a pointer to an array of
        /// slink:VkDeviceQueueCreateInfo structures describing the queues that
        /// are requested to be created along with the logical device. Refer to
        /// the &lt;&lt;devsandqueues-queue-creation,Queue Creation&gt;&gt;
        /// section below for further details.
        /// </summary>
        public DeviceQueueCreateInfo[] QueueCreateInfos
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:ppEnabledLayerNames is deprecated and ignored. See
        /// &lt;&lt;extended-functionality-device-layer-deprecation,Device Layer
        /// Deprecation&gt;&gt;.
        /// </summary>
        public string[] EnabledLayerNames
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:ppEnabledExtensionNames is a pointer to an array of
        /// pname:enabledExtensionCount null-terminated UTF-8 strings
        /// containing the names of extensions to enable for the created
        /// device. See the
        /// &lt;&lt;extended-functionality-extensions,Extensions&gt;&gt; section
        /// for further details.
        /// </summary>
        public string[] EnabledExtensionNames
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:pEnabledFeatures is `NULL` or a pointer to a
        /// slink:VkPhysicalDeviceFeatures structure that contains boolean
        /// indicators of all the features to be enabled. Refer to the
        /// &lt;&lt;features-features,Features&gt;&gt; section for further
        /// details.
        /// </summary>
        public PhysicalDeviceFeatures EnabledFeatures
        {
            get;
            set;
        }
        
        internal unsafe Interop.DeviceCreateInfo Pack()
        {
            Interop.DeviceCreateInfo result = default(Interop.DeviceCreateInfo);
            result.SType = StructureType.DeviceCreateInfo;
            
            //QueueCreateInfos
            if (this.QueueCreateInfos != null)
            {
                int size = System.Runtime.InteropServices.Marshal.SizeOf<Interop.DeviceQueueCreateInfo>();
                IntPtr pointer = Interop.HeapUtil.Allocate<Interop.DeviceQueueCreateInfo>(this.QueueCreateInfos.Length);
                for (int index = 0; index < this.QueueCreateInfos.Length; index++)
                {
                    System.Runtime.InteropServices.Marshal.StructureToPtr(this.QueueCreateInfos[index].Pack(), pointer + (size * index), false);
                }
                result.QueueCreateInfos = (Interop.DeviceQueueCreateInfo*)pointer.ToPointer();
            }
            else
            {
                result.QueueCreateInfos = null;
            }
            result.EnabledLayerNames = this.EnabledLayerNames == null ? null : Interop.HeapUtil.MarshalTo(this.EnabledLayerNames);
            result.EnabledExtensionNames = this.EnabledExtensionNames == null ? null : Interop.HeapUtil.MarshalTo(this.EnabledExtensionNames);
            result.EnabledFeatures = (PhysicalDeviceFeatures*)Interop.HeapUtil.AllocateAndMarshal(this.EnabledFeatures);
            result.QueueCreateInfoCount = (uint)(this.QueueCreateInfos?.Length ?? 0);
            result.EnabledLayerCount = (uint)(this.EnabledLayerNames?.Length ?? 0);
            result.EnabledExtensionCount = (uint)(this.EnabledExtensionNames?.Length ?? 0);
            result.Flags = this.Flags;
            return result;
        }
        
        internal unsafe Interop.DeviceCreateInfo* MarshalTo()
        {
            return (Interop.DeviceCreateInfo*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
        }
    }
}
