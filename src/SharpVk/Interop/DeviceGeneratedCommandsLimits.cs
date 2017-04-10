using System;

namespace SharpVk.Interop
{
    /// <summary>
    /// 
    /// </summary>
    public unsafe struct DeviceGeneratedCommandsLimits
    {
        /// <summary>
        /// 
        /// </summary>
        public DeviceGeneratedCommandsLimits(StructureType sType, void* next, uint maxIndirectCommandsLayoutTokenCount, uint maxObjectEntryCounts, uint minSequenceCountBufferOffsetAlignment, uint minSequenceIndexBufferOffsetAlignment, uint minCommandsTokenBufferOffsetAlignment)
        {
            this.SType = sType;
            this.Next = next;
            this.MaxIndirectCommandsLayoutTokenCount = maxIndirectCommandsLayoutTokenCount;
            this.MaxObjectEntryCounts = maxObjectEntryCounts;
            this.MinSequenceCountBufferOffsetAlignment = minSequenceCountBufferOffsetAlignment;
            this.MinSequenceIndexBufferOffsetAlignment = minSequenceIndexBufferOffsetAlignment;
            this.MinCommandsTokenBufferOffsetAlignment = minCommandsTokenBufferOffsetAlignment;
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
        public uint MaxIndirectCommandsLayoutTokenCount; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxObjectEntryCounts; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint MinSequenceCountBufferOffsetAlignment; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint MinSequenceIndexBufferOffsetAlignment; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint MinCommandsTokenBufferOffsetAlignment; 
    }
}
