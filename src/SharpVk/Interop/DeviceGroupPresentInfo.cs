using System;

namespace SharpVk.Interop
{
    /// <summary>
    /// 
    /// </summary>
    public unsafe struct DeviceGroupPresentInfo
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
        public uint SwapchainCount; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint* DeviceMasks; 
        
        /// <summary>
        /// 
        /// </summary>
        public DeviceGroupPresentModeFlags Mode; 
    }
}
