using System;

namespace SharpVk
{
    /// <summary>
    /// 
    /// </summary>
    public struct ObjectTableEntry
    {
        /// <summary>
        /// 
        /// </summary>
        public ObjectTableEntry(ObjectEntryType type, ObjectEntryUsageFlags flags)
        {
            this.Type = type;
            this.Flags = flags;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public ObjectEntryType Type; 
        
        /// <summary>
        /// 
        /// </summary>
        public ObjectEntryUsageFlags Flags; 
    }
}
