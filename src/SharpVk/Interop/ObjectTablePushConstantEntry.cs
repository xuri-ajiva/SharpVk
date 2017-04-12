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
