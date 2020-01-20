// The MIT License (MIT)
// 
// Copyright (c) Andrew Armstrong/FacticiusVir 2020
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

namespace SharpVk
{
    /// <summary>
    /// 
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct PhysicalDeviceVulkan11Properties
    {
        /// <summary>
        /// 
        /// </summary>
        public Guid DeviceUUID
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public Guid DriverUUID
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public Guid DeviceLUID
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint DeviceNodeMask
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool DeviceLUIDValid
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint SubgroupSize
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.ShaderStageFlags SubgroupSupportedStages
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.SubgroupFeatureFlags SubgroupSupportedOperations
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool SubgroupQuadOperationsInAllStages
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.PointClippingBehavior PointClippingBehavior
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxMultiviewViewCount
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxMultiviewInstanceIndex
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool ProtectedNoFault
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxPerSetDescriptors
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public ulong MaxMemoryAllocationSize
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal unsafe void MarshalTo(SharpVk.Interop.PhysicalDeviceVulkan11Properties* pointer)
        {
            pointer->Next = null;
            Interop.HeapUtil.MarshalTo(this.DeviceUUID, Constants.UuidSize, pointer->DeviceUUID);
            Interop.HeapUtil.MarshalTo(this.DriverUUID, Constants.UuidSize, pointer->DriverUUID);
            Interop.HeapUtil.MarshalTo(this.DeviceLUID, Constants.LuidSize, pointer->DeviceLUID);
            pointer->DeviceNodeMask = this.DeviceNodeMask;
            pointer->DeviceLUIDValid = this.DeviceLUIDValid;
            pointer->SubgroupSize = this.SubgroupSize;
            pointer->SubgroupSupportedStages = this.SubgroupSupportedStages;
            pointer->SubgroupSupportedOperations = this.SubgroupSupportedOperations;
            pointer->SubgroupQuadOperationsInAllStages = this.SubgroupQuadOperationsInAllStages;
            pointer->PointClippingBehavior = this.PointClippingBehavior;
            pointer->MaxMultiviewViewCount = this.MaxMultiviewViewCount;
            pointer->MaxMultiviewInstanceIndex = this.MaxMultiviewInstanceIndex;
            pointer->ProtectedNoFault = this.ProtectedNoFault;
            pointer->MaxPerSetDescriptors = this.MaxPerSetDescriptors;
            pointer->MaxMemoryAllocationSize = this.MaxMemoryAllocationSize;
        }
    }
}
