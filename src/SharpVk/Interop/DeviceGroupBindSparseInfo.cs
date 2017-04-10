using System;

namespace SharpVk.Interop
{
    /// <summary>
    /// 
    /// </summary>
    public unsafe struct DeviceGroupBindSparseInfo
    {
        /// <summary>
        /// 
        /// </summary>
        public DeviceGroupBindSparseInfo(StructureType sType, void* next, uint resourceDeviceIndex, uint memoryDeviceIndex)
        {
            this.SType = sType;
            this.Next = next;
            this.ResourceDeviceIndex = resourceDeviceIndex;
            this.MemoryDeviceIndex = memoryDeviceIndex;
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
        public uint ResourceDeviceIndex; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint MemoryDeviceIndex; 
    }
}
