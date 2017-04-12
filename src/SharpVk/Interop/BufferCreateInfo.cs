using System;

namespace SharpVk.Interop
{
    /// <summary>
    /// 
    /// </summary>
    public unsafe struct BufferCreateInfo
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
        public DeviceSize Size; 
        
        /// <summary>
        /// 
        /// </summary>
        public BufferUsageFlags Usage; 
        
        /// <summary>
        /// 
        /// </summary>
        public SharingMode SharingMode; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint QueueFamilyIndexCount; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint* QueueFamilyIndices; 
    }
}
