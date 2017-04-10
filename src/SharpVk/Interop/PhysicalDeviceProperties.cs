using System;

namespace SharpVk.Interop
{
    /// <summary>
    /// 
    /// </summary>
    public unsafe struct PhysicalDeviceProperties
    {
        /// <summary>
        /// 
        /// </summary>
        public PhysicalDeviceProperties(uint apiVersion, uint driverVersion, uint vendorID, uint deviceID, PhysicalDeviceType deviceType, char deviceName, byte pipelineCacheUUID, PhysicalDeviceLimits limits, PhysicalDeviceSparseProperties sparseProperties)
        {
            this.ApiVersion = apiVersion;
            this.DriverVersion = driverVersion;
            this.VendorID = vendorID;
            this.DeviceID = deviceID;
            this.DeviceType = deviceType;
            this.DeviceName = deviceName;
            this.PipelineCacheUUID = pipelineCacheUUID;
            this.Limits = limits;
            this.SparseProperties = sparseProperties;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint ApiVersion; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint DriverVersion; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint VendorID; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint DeviceID; 
        
        /// <summary>
        /// 
        /// </summary>
        public PhysicalDeviceType DeviceType; 
        
        /// <summary>
        /// 
        /// </summary>
        public char DeviceName; 
        
        /// <summary>
        /// 
        /// </summary>
        public byte PipelineCacheUUID; 
        
        /// <summary>
        /// 
        /// </summary>
        public PhysicalDeviceLimits Limits; 
        
        /// <summary>
        /// 
        /// </summary>
        public PhysicalDeviceSparseProperties SparseProperties; 
    }
}
