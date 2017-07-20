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

namespace SharpVk.Khronos.Experimental
{
    /// <summary>
    /// Structure indicating which instances are bound.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct DeviceGroupBindSparseInfo
    {
        /// <summary>
        /// A device index indicating which instance of the resource is bound.
        /// </summary>
        public uint ResourceDeviceIndex
        {
            get;
            set;
        }
        
        /// <summary>
        /// A device index indicating which instance of the memory the resource
        /// instance is bound to.
        /// </summary>
        public uint MemoryDeviceIndex
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        internal unsafe void MarshalTo(SharpVk.Interop.Khronos.Experimental.DeviceGroupBindSparseInfo* pointer)
        {
            pointer->SType = StructureType.DeviceGroupBindSparseInfoKhx;
            pointer->Next = null;
            pointer->ResourceDeviceIndex = this.ResourceDeviceIndex;
            pointer->MemoryDeviceIndex = this.MemoryDeviceIndex;
        }
    }
}
