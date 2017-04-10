using System;

namespace SharpVk.Interop
{
    /// <summary>
    /// 
    /// </summary>
    public unsafe struct DeviceGroupPresentCapabilities
    {
        /// <summary>
        /// 
        /// </summary>
        public DeviceGroupPresentCapabilities(StructureType sType, void* next, uint presentMask, DeviceGroupPresentModeFlags modes)
        {
            this.SType = sType;
            this.Next = next;
            this.PresentMask = presentMask;
            this.Modes = modes;
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
        public uint PresentMask; 
        
        /// <summary>
        /// 
        /// </summary>
        public DeviceGroupPresentModeFlags Modes; 
    }
}
