using System;

namespace SharpVk.Interop
{
    /// <summary>
    /// 
    /// </summary>
    public unsafe struct MemoryBarrier
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
        public AccessFlags SourceAccessMask; 
        
        /// <summary>
        /// 
        /// </summary>
        public AccessFlags DestinationAccessMask; 
    }
}
