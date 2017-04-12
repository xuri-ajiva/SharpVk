using System;

namespace SharpVk.Interop
{
    /// <summary>
    /// 
    /// </summary>
    public unsafe struct DedicatedAllocationMemoryAllocateInfo
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
        public Image Image; 
        
        /// <summary>
        /// 
        /// </summary>
        public Buffer Buffer; 
    }
}
