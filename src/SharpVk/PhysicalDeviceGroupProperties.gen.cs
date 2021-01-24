// The MIT License (MIT)
// 
// Copyright (c) Andrew Armstrong/FacticiusVir & xuri 2021
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

using System.Runtime.InteropServices;

namespace SharpVk
{
    /// <summary>
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct PhysicalDeviceGroupProperties
    {
        /// <summary>
        /// </summary>
        public PhysicalDevice[] PhysicalDevices
        {
            get;
            set;
        }
        
        /// <summary>
        /// </summary>
        public bool SubsetAllocation
        {
            get;
            set;
        }
        
        /// <summary>
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal static unsafe PhysicalDeviceGroupProperties MarshalFrom(SharpVk.Interop.PhysicalDeviceGroupProperties* pointer)
        {
            PhysicalDeviceGroupProperties result = default;
            if (pointer->PhysicalDeviceCount != 0)
            {
                var fieldPointer = new PhysicalDevice[(uint)(pointer->PhysicalDeviceCount)];
                for(int index = 0; index < (uint)(pointer->PhysicalDeviceCount); index++)
                {
                    fieldPointer[index] = new PhysicalDevice(default, (&(pointer->PhysicalDevices_0))[index]);
                }
                result.PhysicalDevices = fieldPointer;
            }
            else
            {
                result.PhysicalDevices = null;
            }
            result.SubsetAllocation = pointer->SubsetAllocation;
            return result;
        }
    }
}
