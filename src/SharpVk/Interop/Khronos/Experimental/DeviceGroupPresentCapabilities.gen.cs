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

namespace SharpVk.Interop.Khronos.Experimental
{
    /// <summary>
    /// 
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct DeviceGroupPresentCapabilities
    {
        /// <summary>
        /// The type of this structure.
        /// </summary>
        public SharpVk.StructureType SType; 
        
        /// <summary>
        /// Null or an extension-specific structure.
        /// </summary>
        public void* Next; 
        
        /// <summary>
        /// An array of masks, where the mask at element [eq]#i# is non-zero if
        /// physical device [eq]#i# has a presentation engine, and where bit
        /// [eq]#j# is set in element [eq]#i# if physical device [eq]#i# can
        /// present swapchain images from physical device [eq]#j#. If element
        /// [eq]#i# is non-zero, then bit [eq]#i# must be set.
        /// </summary>
        public fixed uint PresentMask[Constants.MaxDeviceGroupSize]; 
        
        /// <summary>
        /// A bitmask indicating which device group presentation modes are
        /// supported. The bits returned in modes are: + --
        /// </summary>
        public SharpVk.Khronos.Experimental.DeviceGroupPresentModeFlags Modes; 
    }
}
