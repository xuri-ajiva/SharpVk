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

namespace SharpVk.Interop
{
    /// <summary>
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct PhysicalDeviceVulkan11Properties
    {
        /// <summary>
        /// </summary>
        public StructureType SType; 
        
        /// <summary>
        /// </summary>
        public void* Next; 
        
        /// <summary>
        /// </summary>
        public fixed byte DeviceUUID[Constants.UuidSize]; 
        
        /// <summary>
        /// </summary>
        public fixed byte DriverUUID[Constants.UuidSize]; 
        
        /// <summary>
        /// </summary>
        public fixed byte DeviceLUID[Constants.LuidSize]; 
        
        /// <summary>
        /// </summary>
        public uint DeviceNodeMask; 
        
        /// <summary>
        /// </summary>
        public Bool32 DeviceLUIDValid; 
        
        /// <summary>
        /// </summary>
        public uint SubgroupSize; 
        
        /// <summary>
        /// </summary>
        public ShaderStageFlags SubgroupSupportedStages; 
        
        /// <summary>
        /// </summary>
        public SubgroupFeatureFlags SubgroupSupportedOperations; 
        
        /// <summary>
        /// </summary>
        public Bool32 SubgroupQuadOperationsInAllStages; 
        
        /// <summary>
        /// </summary>
        public PointClippingBehavior PointClippingBehavior; 
        
        /// <summary>
        /// </summary>
        public uint MaxMultiviewViewCount; 
        
        /// <summary>
        /// </summary>
        public uint MaxMultiviewInstanceIndex; 
        
        /// <summary>
        /// </summary>
        public Bool32 ProtectedNoFault; 
        
        /// <summary>
        /// </summary>
        public uint MaxPerSetDescriptors; 
        
        /// <summary>
        /// </summary>
        public ulong MaxMemoryAllocationSize; 
    }
}
