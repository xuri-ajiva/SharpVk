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
