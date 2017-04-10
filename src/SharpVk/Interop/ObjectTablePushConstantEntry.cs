using System;

namespace SharpVk.Interop
{
    /// <summary>
    /// 
    /// </summary>
    public unsafe struct ObjectTablePushConstantEntry
    {
        /// <summary>
        /// 
        /// </summary>
        public ObjectTablePushConstantEntry(ObjectEntryType type, ObjectEntryUsageFlags flags, PipelineLayout pipelineLayout, ShaderStageFlags stageFlags)
        {
            this.Type = type;
            this.Flags = flags;
            this.PipelineLayout = pipelineLayout;
            this.StageFlags = stageFlags;
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
        public PipelineLayout PipelineLayout; 
        
        /// <summary>
        /// 
        /// </summary>
        public ShaderStageFlags StageFlags; 
    }
}
