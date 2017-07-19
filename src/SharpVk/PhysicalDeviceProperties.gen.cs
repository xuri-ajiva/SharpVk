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

namespace SharpVk
{
    /// <summary>
    /// Structure specifying physical device properties.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct PhysicalDeviceProperties
    {
        /// <summary>
        /// pname:apiVersion is the version of Vulkan supported by the device,
        /// encoded as described in the &lt;&lt;fundamentals-versionnum,API
        /// Version Numbers and Semantics&gt;&gt; section.
        /// </summary>
        public Version ApiVersion
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:driverVersion is the vendor-specified version of the driver.
        /// </summary>
        public Version DriverVersion
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:vendorID is a unique identifier for the _vendor_ (see below)
        /// of the physical device.
        /// </summary>
        public uint VendorID
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:deviceID is a unique identifier for the physical device among
        /// devices available from the vendor.
        /// </summary>
        public uint DeviceID
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:deviceType is a elink:VkPhysicalDeviceType specifying the
        /// type of device.
        /// </summary>
        public SharpVk.PhysicalDeviceType DeviceType
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:deviceName is a null-terminated UTF-8 string containing the
        /// name of the device.
        /// </summary>
        public string DeviceName
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:pipelineCacheUUID is an array of size ename:VK_UUID_SIZE,
        /// containing 8-bit values that represent a universally unique
        /// identifier for the device.
        /// </summary>
        public Guid PipelineCacheUUID
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:limits is the slink:VkPhysicalDeviceLimits structure which
        /// specifies device-specific limits of the physical device. See
        /// &lt;&lt;features-limits,Limits&gt;&gt; for details.
        /// </summary>
        public SharpVk.PhysicalDeviceLimits Limits
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:sparseProperties is the
        /// slink:VkPhysicalDeviceSparseProperties structure which specifies
        /// various sparse related properties of the physical device. See
        /// &lt;&lt;sparsememory-physicalprops,Sparse Properties&gt;&gt; for
        /// details.
        /// </summary>
        public SharpVk.PhysicalDeviceSparseProperties SparseProperties
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        internal static unsafe PhysicalDeviceProperties MarshalFrom(SharpVk.Interop.PhysicalDeviceProperties* pointer)
        {
            PhysicalDeviceProperties result = default(PhysicalDeviceProperties);
            result.ApiVersion = (Version)(pointer->ApiVersion);
            result.DriverVersion = (Version)(pointer->DriverVersion);
            result.VendorID = pointer->VendorID;
            result.DeviceID = pointer->DeviceID;
            result.DeviceType = pointer->DeviceType;
            result.DeviceName = Interop.HeapUtil.MarshalStringFrom(pointer->DeviceName, Constants.MaxPhysicalDeviceNameSize, true);
            result.PipelineCacheUUID = new Guid(Interop.HeapUtil.MarshalFrom(pointer->PipelineCacheUUID, Constants.UuidSize));
            result.Limits = SharpVk.PhysicalDeviceLimits.MarshalFrom(&pointer->Limits);
            result.SparseProperties = SharpVk.PhysicalDeviceSparseProperties.MarshalFrom(&pointer->SparseProperties);
            return result;
        }
    }
}
