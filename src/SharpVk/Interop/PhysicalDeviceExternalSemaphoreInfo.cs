using System;

namespace SharpVk.Interop
{
    /// <summary>
    /// 
    /// </summary>
    public unsafe struct PhysicalDeviceExternalSemaphoreInfo
    {
        /// <summary>
        /// 
        /// </summary>
        public PhysicalDeviceExternalSemaphoreInfo(StructureType sType, void* next, ExternalSemaphoreHandleTypeFlags handleType)
        {
            this.SType = sType;
            this.Next = next;
            this.HandleType = handleType;
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
        public ExternalSemaphoreHandleTypeFlags HandleType; 
    }
}
