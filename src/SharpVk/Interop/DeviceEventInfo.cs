using System;

namespace SharpVk.Interop
{
    /// <summary>
    /// 
    /// </summary>
    public unsafe struct DeviceEventInfo
    {
        /// <summary>
        /// 
        /// </summary>
        public DeviceEventInfo(StructureType sType, void* next, DeviceEventType deviceEvent)
        {
            this.SType = sType;
            this.Next = next;
            this.DeviceEvent = deviceEvent;
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
        public DeviceEventType DeviceEvent; 
    }
}
