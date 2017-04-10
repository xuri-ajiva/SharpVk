using System;

namespace SharpVk.Interop
{
    /// <summary>
    /// 
    /// </summary>
    public unsafe struct DeviceGroupCommandBufferBeginInfo
    {
        /// <summary>
        /// 
        /// </summary>
        public DeviceGroupCommandBufferBeginInfo(StructureType sType, void* next, uint deviceMask)
        {
            this.SType = sType;
            this.Next = next;
            this.DeviceMask = deviceMask;
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
        public uint DeviceMask; 
    }
}
