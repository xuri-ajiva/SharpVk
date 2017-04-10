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
        public DeviceGroupPresentInfo(StructureType sType, void* next, uint swapchainCount, uint* deviceMasks, DeviceGroupPresentModeFlags mode)
        {
            this.SType = sType;
            this.Next = next;
            this.SwapchainCount = swapchainCount;
            this.DeviceMasks = deviceMasks;
            this.Mode = mode;
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
