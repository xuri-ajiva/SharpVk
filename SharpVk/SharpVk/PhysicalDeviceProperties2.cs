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
    /// Structure specifying physical device properties.
    /// </para>
    /// <para>
    /// The pname:pNext chain of this structure is used to extend the structure
    /// with properties defined by extensions.
    /// </para>
    /// </summary>
    public struct PhysicalDeviceProperties2
    {
        /// <summary>
        /// pname:properties is a structure of type
        /// slink:VkPhysicalDeviceProperties describing the properties of the
        /// physical device. This structure is written with the same values as
        /// if it were written by flink:vkGetPhysicalDeviceProperties.
        /// </summary>
        public PhysicalDeviceProperties Properties
        {
            get;
            set;
        }
        
        internal static unsafe PhysicalDeviceProperties2 MarshalFrom(Interop.PhysicalDeviceProperties2* value)
        {
            PhysicalDeviceProperties2 result = new PhysicalDeviceProperties2();
            result.Properties = PhysicalDeviceProperties.MarshalFrom(&value->Properties);
            return result;
        }
    }
}
