using System;

namespace SharpVk.Interop
{
    /// <summary>
    /// 
    /// </summary>
    public unsafe struct MemoryFileDescriptorProperties
    {
        /// <summary>
        /// 
        /// </summary>
        public MemoryFileDescriptorProperties(StructureType sType, void* next, uint memoryTypeBits)
        {
            this.SType = sType;
            this.Next = next;
            this.MemoryTypeBits = memoryTypeBits;
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
        public uint MemoryTypeBits; 
    }
}
