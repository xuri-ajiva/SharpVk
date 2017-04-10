using System;

namespace SharpVk.Interop
{
    /// <summary>
    /// 
    /// </summary>
    public unsafe struct PhysicalDeviceGroupProperties
    {
        /// <summary>
        /// 
        /// </summary>
        public PhysicalDeviceGroupProperties(StructureType sType, void* next, uint physicalDeviceCount, PhysicalDevice physicalDevices, Bool32 subsetAllocation)
        {
            this.SType = sType;
            this.Next = next;
            this.PhysicalDeviceCount = physicalDeviceCount;
            this.PhysicalDevices = physicalDevices;
            this.SubsetAllocation = subsetAllocation;
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
        public PhysicalDevice PhysicalDevices; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 SubsetAllocation; 
    }
}
