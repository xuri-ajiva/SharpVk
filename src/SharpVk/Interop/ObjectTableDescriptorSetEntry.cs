using System;

namespace SharpVk.Interop
{
    /// <summary>
    /// 
    /// </summary>
    public unsafe struct ObjectTableDescriptorSetEntry
    {
        /// <summary>
        /// 
        /// </summary>
        public ObjectTableDescriptorSetEntry(ObjectEntryType type, ObjectEntryUsageFlags flags, PipelineLayout pipelineLayout, DescriptorSet descriptorSet)
        {
            this.Type = type;
            this.Flags = flags;
            this.PipelineLayout = pipelineLayout;
            this.DescriptorSet = descriptorSet;
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
        public DescriptorSet DescriptorSet; 
    }
}
