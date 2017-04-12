using System;

namespace SharpVk.Interop
{
    /// <summary>
    /// 
    /// </summary>
    public unsafe struct ComputePipelineCreateInfo
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
        public PipelineCreateFlags Flags; 
        
        /// <summary>
        /// 
        /// </summary>
        public PipelineShaderStageCreateInfo Stage; 
        
        /// <summary>
        /// 
        /// </summary>
        public PipelineLayout Layout; 
        
        /// <summary>
        /// 
        /// </summary>
        public Pipeline BasePipelineHandle; 
        
        /// <summary>
        /// 
        /// </summary>
        public int BasePipelineIndex; 
    }
}
