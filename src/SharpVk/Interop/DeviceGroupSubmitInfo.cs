using System;

namespace SharpVk.Interop
{
    /// <summary>
    /// 
    /// </summary>
    public unsafe struct DeviceGroupSubmitInfo
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
        public uint WaitSemaphoreCount; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint* WaitSemaphoreDeviceIndices; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint CommandBufferCount; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint* CommandBufferDeviceMasks; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint SignalSemaphoreCount; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint* SignalSemaphoreDeviceIndices; 
    }
}
