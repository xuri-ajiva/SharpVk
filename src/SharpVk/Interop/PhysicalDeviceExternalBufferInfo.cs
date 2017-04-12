using System;

namespace SharpVk.Interop
{
    /// <summary>
    /// 
    /// </summary>
    public unsafe struct PhysicalDeviceExternalBufferInfo
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
        public BufferCreateFlags Flags; 
        
        /// <summary>
        /// 
        /// </summary>
        public BufferUsageFlags Usage; 
        
        /// <summary>
        /// 
        /// </summary>
        public ExternalMemoryHandleTypeFlags HandleType; 
    }
}
