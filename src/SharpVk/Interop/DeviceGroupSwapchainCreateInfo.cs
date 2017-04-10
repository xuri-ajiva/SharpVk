using System;

namespace SharpVk.Interop
{
    /// <summary>
    /// 
    /// </summary>
    public unsafe struct DeviceGroupSwapchainCreateInfo
    {
        /// <summary>
        /// 
        /// </summary>
        public DeviceGroupSwapchainCreateInfo(StructureType sType, void* next, DeviceGroupPresentModeFlags modes)
        {
            this.SType = sType;
            this.Next = next;
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
        public DeviceGroupPresentModeFlags Modes; 
    }
}
