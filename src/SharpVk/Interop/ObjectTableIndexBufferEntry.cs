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
        public ObjectTableIndexBufferEntry(ObjectEntryType type, ObjectEntryUsageFlags flags, Buffer buffer, IndexType indexType)
        {
            this.Type = type;
            this.Flags = flags;
            this.Buffer = buffer;
            this.IndexType = indexType;
        }
        
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
