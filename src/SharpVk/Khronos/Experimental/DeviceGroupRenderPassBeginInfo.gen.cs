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
    /// Set the initial device mask and render areas for a render pass
    /// instance.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct DeviceGroupRenderPassBeginInfo
    {
        /// <summary>
        /// The device mask for the render pass instance.
        /// </summary>
        public uint DeviceMask
        {
            get;
            set;
        }
        
        /// <summary>
        /// An array of structures of type Rect2D defining the render area for
        /// each physical device.
        /// </summary>
        public SharpVk.Rect2D[] DeviceRenderAreas
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        internal unsafe void MarshalTo(SharpVk.Interop.Khronos.Experimental.DeviceGroupRenderPassBeginInfo* pointer)
        {
            pointer->SType = StructureType.DeviceGroupRenderPassBeginInfoKhx;
            pointer->Next = null;
            pointer->DeviceMask = this.DeviceMask;
            pointer->DeviceRenderAreaCount = (uint)(Interop.HeapUtil.GetLength(this.DeviceRenderAreas));
            if (this.DeviceRenderAreas != null)
            {
                var fieldPointer = (SharpVk.Rect2D*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Rect2D>(this.DeviceRenderAreas.Length).ToPointer());
                for(int index = 0; index < (uint)(this.DeviceRenderAreas.Length); index++)
                {
                    fieldPointer[index] = this.DeviceRenderAreas[index];
                }
                pointer->DeviceRenderAreas = fieldPointer;
            }
            else
            {
                pointer->DeviceRenderAreas = null;
            }
        }
    }
}
