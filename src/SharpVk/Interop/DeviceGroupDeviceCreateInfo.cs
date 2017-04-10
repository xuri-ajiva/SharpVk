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
        public DeviceGroupDeviceCreateInfo(StructureType sType, void* next, uint physicalDeviceCount, PhysicalDevice* physicalDevices)
        {
            this.SType = sType;
            this.Next = next;
            this.PhysicalDeviceCount = physicalDeviceCount;
            this.PhysicalDevices = physicalDevices;
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
        public uint PhysicalDeviceCount; 
        
        /// <summary>
        /// 
        /// </summary>
        public PhysicalDevice* PhysicalDevices; 
    }
}
