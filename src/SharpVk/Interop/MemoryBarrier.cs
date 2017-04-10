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
        public MemoryBarrier(StructureType sType, void* next, AccessFlags sourceAccessMask, AccessFlags destinationAccessMask)
        {
            this.SType = sType;
            this.Next = next;
            this.SourceAccessMask = sourceAccessMask;
            this.DestinationAccessMask = destinationAccessMask;
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
        public AccessFlags SourceAccessMask; 
        
        /// <summary>
        /// 
        /// </summary>
        public AccessFlags DestinationAccessMask; 
    }
}
