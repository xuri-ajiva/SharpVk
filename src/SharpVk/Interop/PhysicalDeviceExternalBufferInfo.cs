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
        public PhysicalDeviceExternalBufferInfo(StructureType sType, void* next, BufferCreateFlags flags, BufferUsageFlags usage, ExternalMemoryHandleTypeFlags handleType)
        {
            this.SType = sType;
            this.Next = next;
            this.Flags = flags;
            this.Usage = usage;
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
