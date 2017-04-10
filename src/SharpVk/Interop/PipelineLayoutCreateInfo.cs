using System;

namespace SharpVk.Interop
{
    /// <summary>
    /// 
    /// </summary>
    public unsafe struct PipelineLayoutCreateInfo
    {
        /// <summary>
        /// 
        /// </summary>
        public PipelineLayoutCreateInfo(StructureType sType, void* next, PipelineLayoutCreateFlags flags, uint setLayoutCount, DescriptorSetLayout* setLayouts, uint pushConstantRangeCount, PushConstantRange* pushConstantRanges)
        {
            this.SType = sType;
            this.Next = next;
            this.Flags = flags;
            this.SetLayoutCount = setLayoutCount;
            this.SetLayouts = setLayouts;
            this.PushConstantRangeCount = pushConstantRangeCount;
            this.PushConstantRanges = pushConstantRanges;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public StructureType SType; 
        
        /// <summary>
        /// 
        /// </summary>
        public void* Next; 
        
        /// <summary>
        /// 
        /// </summary>
        public PipelineLayoutCreateFlags Flags; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint SetLayoutCount; 
        
        /// <summary>
        /// 
        /// </summary>
        public DescriptorSetLayout* SetLayouts; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint PushConstantRangeCount; 
        
        /// <summary>
        /// 
        /// </summary>
        public PushConstantRange* PushConstantRanges; 
    }
}
