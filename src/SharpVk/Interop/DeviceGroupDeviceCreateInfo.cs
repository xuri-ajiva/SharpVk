using System;

namespace SharpVk.Interop
{
    /// <summary>
    /// 
    /// </summary>
    public unsafe struct DeviceGroupDeviceCreateInfo
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
        public uint PhysicalDeviceCount; 
        
        /// <summary>
        /// 
        /// </summary>
        public PhysicalDevice* PhysicalDevices; 
    }
}
