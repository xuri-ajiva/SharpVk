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
        public PhysicalDeviceIDProperties(StructureType sType, void* next, byte deviceUUID, byte driverUUID, byte deviceLUID, Bool32 deviceLUIDValid)
        {
            this.SType = sType;
            this.Next = next;
            this.DeviceUUID = deviceUUID;
            this.DriverUUID = driverUUID;
            this.DeviceLUID = deviceLUID;
            this.DeviceLUIDValid = deviceLUIDValid;
        }
        
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
