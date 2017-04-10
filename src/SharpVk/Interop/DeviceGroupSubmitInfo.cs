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
        public DeviceGroupSubmitInfo(StructureType sType, void* next, uint waitSemaphoreCount, uint* waitSemaphoreDeviceIndices, uint commandBufferCount, uint* commandBufferDeviceMasks, uint signalSemaphoreCount, uint* signalSemaphoreDeviceIndices)
        {
            this.SType = sType;
            this.Next = next;
            this.WaitSemaphoreCount = waitSemaphoreCount;
            this.WaitSemaphoreDeviceIndices = waitSemaphoreDeviceIndices;
            this.CommandBufferCount = commandBufferCount;
            this.CommandBufferDeviceMasks = commandBufferDeviceMasks;
            this.SignalSemaphoreCount = signalSemaphoreCount;
            this.SignalSemaphoreDeviceIndices = signalSemaphoreDeviceIndices;
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
