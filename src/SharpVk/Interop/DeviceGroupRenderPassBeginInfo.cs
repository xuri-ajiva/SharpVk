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
        public DeviceGroupRenderPassBeginInfo(StructureType sType, void* next, uint deviceMask, uint deviceRenderAreaCount, Rect2D* deviceRenderAreas)
        {
            this.SType = sType;
            this.Next = next;
            this.DeviceMask = deviceMask;
            this.DeviceRenderAreaCount = deviceRenderAreaCount;
            this.DeviceRenderAreas = deviceRenderAreas;
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
