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
        public ComputePipelineCreateInfo(StructureType sType, void* next, PipelineCreateFlags flags, PipelineShaderStageCreateInfo stage, PipelineLayout layout, Pipeline basePipelineHandle, int basePipelineIndex)
        {
            this.SType = sType;
            this.Next = next;
            this.Flags = flags;
            this.Stage = stage;
            this.Layout = layout;
            this.BasePipelineHandle = basePipelineHandle;
            this.BasePipelineIndex = basePipelineIndex;
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
