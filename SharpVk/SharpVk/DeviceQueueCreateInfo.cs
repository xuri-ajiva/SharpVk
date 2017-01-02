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
    /// Structure specifying parameters of a newly created device queue.
    /// </summary>
    public struct DeviceQueueCreateInfo
    {
        /// <summary>
        /// pname:flags is reserved for future use.
        /// </summary>
        public DeviceQueueCreateFlags Flags
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:queueFamilyIndex is an unsigned integer indicating the index
        /// of the queue family to create on this device. This index
        /// corresponds to the index of an element of the
        /// pname:pQueueFamilyProperties array that was returned by
        /// fname:vkGetPhysicalDeviceQueueFamilyProperties.
        /// </summary>
        public uint QueueFamilyIndex
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:pQueuePriorities is an array of pname:queueCount normalized
        /// floating point values, specifying priorities of work that will be
        /// submitted to each created queue. See
        /// &lt;&lt;devsandqueues-priority,Queue Priority&gt;&gt; for more
        /// information.
        /// </summary>
        public float[] QueuePriorities
        {
            get;
            set;
        }
        
        internal unsafe Interop.DeviceQueueCreateInfo* MarshalTo()
        {
            var result = (Interop.DeviceQueueCreateInfo*)Interop.HeapUtil.AllocateAndClear<Interop.DeviceQueueCreateInfo>().ToPointer();
            this.MarshalTo(result);
            return result;
        }
        
        internal unsafe void MarshalTo(Interop.DeviceQueueCreateInfo* pointer)
        {
            pointer->SType = StructureType.DeviceQueueCreateInfo;
            pointer->QueuePriorities = this.QueuePriorities == null ? null : Interop.HeapUtil.MarshalTo(this.QueuePriorities);
            pointer->QueueCount = (uint)(this.QueuePriorities?.Length ?? 0);
            pointer->Flags = this.Flags;
            pointer->QueueFamilyIndex = this.QueueFamilyIndex;
        }
    }
}
