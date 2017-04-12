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
