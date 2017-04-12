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
