using System;

namespace SharpVk.Interop
{
    /// <summary>
    /// 
    /// </summary>
    public unsafe struct PhysicalDeviceIDProperties
    {
        /// <summary>
        /// 
        /// </summary>
        public StructureType SType; 
        
        /// <summary>
        /// 
        /// </summary>
        public void* Next; 
        
        /// <summary>
        /// 
        /// </summary>
        public byte DeviceUUID; 
        
        /// <summary>
        /// 
        /// </summary>
        public byte DriverUUID; 
        
        /// <summary>
        /// 
        /// </summary>
        public byte DeviceLUID; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 DeviceLUIDValid; 
    }
}
