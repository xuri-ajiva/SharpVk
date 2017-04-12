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
