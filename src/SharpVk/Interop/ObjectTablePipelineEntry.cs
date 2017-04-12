using System;

namespace SharpVk.Interop
{
    /// <summary>
    /// 
    /// </summary>
    public unsafe struct ObjectTablePipelineEntry
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
        public Pipeline Pipeline; 
    }
}
