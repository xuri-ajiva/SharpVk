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
        public BufferCreateInfo(StructureType sType, void* next, BufferCreateFlags flags, DeviceSize size, BufferUsageFlags usage, SharingMode sharingMode, uint queueFamilyIndexCount, uint* queueFamilyIndices)
        {
            this.SType = sType;
            this.Next = next;
            this.Flags = flags;
            this.Size = size;
            this.Usage = usage;
            this.SharingMode = sharingMode;
            this.QueueFamilyIndexCount = queueFamilyIndexCount;
            this.QueueFamilyIndices = queueFamilyIndices;
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
