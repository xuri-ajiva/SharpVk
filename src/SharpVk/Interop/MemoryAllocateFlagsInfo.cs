using System;

namespace SharpVk.Interop
{
    /// <summary>
    /// 
    /// </summary>
    public unsafe struct MemoryAllocateFlagsInfo
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
        public MemoryAllocateFlags Flags; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint DeviceMask; 
    }
}
