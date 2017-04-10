using System;

namespace SharpVk.Interop
{
    /// <summary>
    /// 
    /// </summary>
    public unsafe struct ObjectTableVertexBufferEntry
    {
        /// <summary>
        /// 
        /// </summary>
        public ObjectTableVertexBufferEntry(ObjectEntryType type, ObjectEntryUsageFlags flags, Buffer buffer)
        {
            this.Type = type;
            this.Flags = flags;
            this.Buffer = buffer;
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
    }
}
