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
        public ObjectTablePipelineEntry(ObjectEntryType type, ObjectEntryUsageFlags flags, Pipeline pipeline)
        {
            this.Type = type;
            this.Flags = flags;
            this.Pipeline = pipeline;
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
        public Pipeline Pipeline; 
    }
}
