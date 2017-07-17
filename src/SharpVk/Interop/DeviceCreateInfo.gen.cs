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

namespace SharpVk.Interop
{
    /// <summary>
    /// 
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct DeviceCreateInfo
    {
        /// <summary>
        /// pname:sType is the type of this structure.
        /// </summary>
        public SharpVk.StructureType SType; 
        
        /// <summary>
        /// pname:pNext is `NULL` or a pointer to an extension-specific
        /// structure.
        /// </summary>
        public void* Next; 
        
        /// <summary>
        /// pname:flags is reserved for future use.
        /// </summary>
        public SharpVk.DeviceCreateFlags Flags; 
        
        /// <summary>
        /// pname:queueCreateInfoCount is the unsigned integer size of the
        /// pname:pQueueCreateInfos array. Refer to the
        /// &lt;&lt;devsandqueues-queue-creation,Queue Creation&gt;&gt; section
        /// below for further details.
        /// </summary>
        public uint QueueCreateInfoCount; 
        
        /// <summary>
        /// pname:pQueueCreateInfos is a pointer to an array of
        /// slink:VkDeviceQueueCreateInfo structures describing the queues that
        /// are requested to be created along with the logical device. Refer to
        /// the &lt;&lt;devsandqueues-queue-creation,Queue Creation&gt;&gt;
        /// section below for further details.
        /// </summary>
        public SharpVk.Interop.DeviceQueueCreateInfo* QueueCreateInfos; 
        
        /// <summary>
        /// pname:enabledLayerCount is deprecated and ignored.
        /// </summary>
        public uint EnabledLayerCount; 
        
        /// <summary>
        /// pname:ppEnabledLayerNames is deprecated and ignored. See
        /// &lt;&lt;extended-functionality-device-layer-deprecation,Device Layer
        /// Deprecation&gt;&gt;.
        /// </summary>
        public byte** EnabledLayerNames; 
        
        /// <summary>
        /// pname:enabledExtensionCount is the number of device extensions to
        /// enable.
        /// </summary>
        public uint EnabledExtensionCount; 
        
        /// <summary>
        /// pname:ppEnabledExtensionNames is a pointer to an array of
        /// pname:enabledExtensionCount null-terminated UTF-8 strings
        /// containing the names of extensions to enable for the created
        /// device. See the
        /// &lt;&lt;extended-functionality-extensions,Extensions&gt;&gt; section
        /// for further details.
        /// </summary>
        public byte** EnabledExtensionNames; 
        
        /// <summary>
        /// pname:pEnabledFeatures is `NULL` or a pointer to a
        /// slink:VkPhysicalDeviceFeatures structure that contains boolean
        /// indicators of all the features to be enabled. Refer to the
        /// &lt;&lt;features-features,Features&gt;&gt; section for further
        /// details.
        /// </summary>
        public SharpVk.Interop.PhysicalDeviceFeatures* EnabledFeatures; 
    }
}
