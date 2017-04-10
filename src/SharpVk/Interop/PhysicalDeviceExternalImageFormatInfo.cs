using System;

namespace SharpVk.Interop
{
    /// <summary>
    /// 
    /// </summary>
    public unsafe struct PhysicalDeviceExternalImageFormatInfo
    {
        /// <summary>
        /// 
        /// </summary>
        public PhysicalDeviceExternalImageFormatInfo(StructureType sType, void* next, ExternalMemoryHandleTypeFlags handleType)
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
        public ExternalMemoryHandleTypeFlags HandleType; 
    }
}
