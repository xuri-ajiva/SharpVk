using System;

namespace SharpVk.Interop
{
    /// <summary>
    /// 
    /// </summary>
    public unsafe struct DeviceGroupRenderPassBeginInfo
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
        public uint DeviceMask; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint DeviceRenderAreaCount; 
        
        /// <summary>
        /// 
        /// </summary>
        public Rect2D* DeviceRenderAreas; 
    }
}
