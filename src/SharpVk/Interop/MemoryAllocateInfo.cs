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
