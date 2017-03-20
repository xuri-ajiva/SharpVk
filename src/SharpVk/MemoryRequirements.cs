using System;

namespace SharpVk
{
    /// <summary>
    /// 
    /// </summary>
    public struct MemoryRequirements
    {
        /// <summary>
        /// 
        /// </summary>
        public MemoryRequirements(DeviceSize size, DeviceSize alignment, uint memoryTypeBits)
        {
            this.Size = size;
            this.Alignment = alignment;
            this.MemoryTypeBits = memoryTypeBits;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public DeviceSize Size; 
        
        /// <summary>
        /// 
        /// </summary>
        public DeviceSize Alignment; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint MemoryTypeBits; 
    }
}
