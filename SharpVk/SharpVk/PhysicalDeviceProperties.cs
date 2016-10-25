// The MIT License (MIT)
// 
// Copyright (c) Andrew Armstrong/FacticiusVir 2016
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
    /// The pname:vendorID and pname:deviceID fields are provided to allow
    /// applications to adapt to device characteristics that are not adequately
    /// exposed by other Vulkan queries. These may: include performance
    /// profiles, hardware errata, or other characteristics. In PCI-based
    /// implementations, the low sixteen bits of pname:vendorID and
    /// pname:deviceID must: contain (respectively) the PCI vendor and device
    /// IDs associated with the hardware device, and the remaining bits must:
    /// be set to zero. In non-PCI implementations, the choice of what values
    /// to return may: be dictated by operating system or platform policies. It
    /// is otherwise at the discretion of the implementer, subject to the
    /// following constraints and guidelines:
    /// </para>
    /// <para>
    /// * For purposes of physical device identification, the _vendor_ of a
    /// physical device is the entity responsible for the most salient
    /// characteristics of the hardware represented by the physical device
    /// handle. In the case of a discrete GPU, this should: be the GPU chipset
    /// vendor. In the case of a GPU or other accelerator integrated into a
    /// system-on-chip (SoC), this should: be the supplier of the silicon IP
    /// used to create the GPU or other accelerator. * If the vendor of the
    /// physical device has a valid PCI vendor ID issued by
    /// https://pcisig.com/[PCI-SIG], that ID should: be used to construct
    /// pname:vendorID as described above for PCI-based implementations.
    /// Implementations that do not return a PCI vendor ID in pname:vendorID
    /// must: return a valid Khronos vendor ID, obtained as described in the
    /// &lt;&lt;vulkan-styleguide,Vulkan Documentation and Extensions&gt;&gt;
    /// document in the section ``Registering a Vendor ID with Khronos''.
    /// Khronos vendor IDs are allocated starting at 0x10000, to distinguish
    /// them from the PCI vendor ID namespace. * The vendor of the physical
    /// device is responsible for selecting pname:deviceID. The value selected
    /// should: uniquely identify both the device version and any major
    /// configuration options (for example, core count in the case of multicore
    /// devices). The same device ID should: be used for all physical
    /// implementations of that device version and configuration. For example,
    /// all uses of a specific silicon IP GPU version and configuration should:
    /// use the same device ID, even if those uses occur in different SoCs.
    /// </para>
    /// </summary>
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
        public PhysicalDeviceType DeviceType
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
        public PhysicalDeviceLimits Limits
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
        public PhysicalDeviceSparseProperties SparseProperties
        {
            get;
            set;
        }
        
        internal static unsafe PhysicalDeviceProperties MarshalFrom(Interop.PhysicalDeviceProperties* value)
        {
            PhysicalDeviceProperties result = new PhysicalDeviceProperties();
            result.ApiVersion = value->ApiVersion;
            result.DriverVersion = value->DriverVersion;
            result.DeviceName = System.Text.Encoding.UTF8.GetString(Interop.HeapUtil.MarshalFrom(value->DeviceName, (int)Constants.MaxPhysicalDeviceNameSize, true));
            result.PipelineCacheUUID = new Guid(Interop.HeapUtil.MarshalFrom(value->PipelineCacheUUID, (int)Constants.UuidSize));
            result.Limits = PhysicalDeviceLimits.MarshalFrom(&value->Limits);
            result.VendorID = value->VendorID;
            result.DeviceID = value->DeviceID;
            result.DeviceType = value->DeviceType;
            result.SparseProperties = value->SparseProperties;
            return result;
        }
    }
}
