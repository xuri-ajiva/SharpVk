using System;

namespace SharpVk.Interop
{
    /// <summary>
    /// 
    /// </summary>
    public unsafe struct MemoryAllocateInfo
    {
        /// <summary>
        /// 
        /// </summary>
        public MemoryAllocateInfo(StructureType sType, void* next, DeviceSize allocationSize, uint memoryTypeIndex)
        {
            this.SType = sType;
            this.Next = next;
            this.AllocationSize = allocationSize;
            this.MemoryTypeIndex = memoryTypeIndex;
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
        public DeviceSize AllocationSize; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint MemoryTypeIndex; 
    }
}
