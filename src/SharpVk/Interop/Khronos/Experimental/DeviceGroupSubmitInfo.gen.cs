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
    public unsafe partial struct DeviceGroupSubmitInfo
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
        /// The number of elements in the pWaitSemaphoreDeviceIndices array.
        /// </summary>
        public uint WaitSemaphoreCount; 
        
        /// <summary>
        /// An array of device indices indicating which physical device
        /// executes the semaphore wait operation in the corresponding element
        /// of SubmitInfo::pWaitSemaphores.
        /// </summary>
        public uint* WaitSemaphoreDeviceIndices; 
        
        /// <summary>
        /// The number of elements in the pCommandBufferDeviceMasks array.
        /// </summary>
        public uint CommandBufferCount; 
        
        /// <summary>
        /// An array of device masks indicating which physical devices execute
        /// the command buffer in the corresponding element of
        /// SubmitInfo::pCommandBuffers. A physical device executes the command
        /// buffer if the corresponding bit is set in the mask.
        /// </summary>
        public uint* CommandBufferDeviceMasks; 
        
        /// <summary>
        /// The number of elements in the pSignalSemaphoreDeviceIndices array.
        /// </summary>
        public uint SignalSemaphoreCount; 
        
        /// <summary>
        /// An array of device indices indicating which physical device
        /// executes the semaphore signal operation in the corresponding
        /// element of SubmitInfo::pSignalSemaphores.
        /// </summary>
        public uint* SignalSemaphoreDeviceIndices; 
    }
}
