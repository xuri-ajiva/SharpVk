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
    /// <para>
    /// Structure describing the fine-grained features that can be supported by
    /// an implementation.
    /// </para>
    /// <para>
    /// The pname:pNext chain of this structure is used to extend the structure
    /// with features defined by extensions. This structure can: be used in
    /// flink:vkGetPhysicalDeviceFeatures2KHR or can: be in the pname:pNext
    /// chain of a slink:VkDeviceCreateInfo structure, in which case it
    /// controls which features are enabled in the device in lieu of
    /// pname:pEnabledFeatures.
    /// </para>
    /// </summary>
    public struct PhysicalDeviceFeatures2
    {
        /// <summary>
        /// pname:features is a structure of type
        /// slink:VkPhysicalDeviceFeatures describing the fine-grained features
        /// of the Vulkan 1.0 API.
        /// </summary>
        public PhysicalDeviceFeatures Features
        {
            get;
            set;
        }
        
        internal static unsafe PhysicalDeviceFeatures2 MarshalFrom(Interop.PhysicalDeviceFeatures2* value)
        {
            PhysicalDeviceFeatures2 result = new PhysicalDeviceFeatures2();
            result.Features = value->Features;
            return result;
        }
    }
}
