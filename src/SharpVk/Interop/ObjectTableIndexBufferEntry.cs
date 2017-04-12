using System;

namespace SharpVk.Interop
{
    /// <summary>
    /// 
    /// </summary>
    public unsafe struct ObjectTableIndexBufferEntry
    {
        /// <summary>
        /// 
        /// </summary>
        public ObjectEntryType Type; 
        
        /// <summary>
        /// 
        /// </summary>
        public ObjectEntryUsageFlags Flags; 
        
        /// <summary>
        /// 
        /// </summary>
        public Buffer Buffer; 
        
        /// <summary>
        /// 
        /// </summary>
        public IndexType IndexType; 
    }
}
