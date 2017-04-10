using System;

namespace SharpVk.Interop
{
    /// <summary>
    /// 
    /// </summary>
    public unsafe struct MappedMemoryRange
    {
        /// <summary>
        /// 
        /// </summary>
        public MappedMemoryRange(StructureType sType, void* next, DeviceMemory memory, DeviceSize offset, DeviceSize size)
        {
            this.SType = sType;
            this.Next = next;
            this.Memory = memory;
            this.Offset = offset;
            this.Size = size;
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
        public DeviceMemory Memory; 
        
        /// <summary>
        /// 
        /// </summary>
        public DeviceSize Offset; 
        
        /// <summary>
        /// 
        /// </summary>
        public DeviceSize Size; 
    }
}
