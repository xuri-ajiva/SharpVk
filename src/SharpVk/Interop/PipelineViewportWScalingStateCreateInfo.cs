using System;

namespace SharpVk.Interop
{
    /// <summary>
    /// 
    /// </summary>
    public unsafe struct PipelineViewportWScalingStateCreateInfo
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
        public Bool32 ViewportWScalingEnable; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint ViewportCount; 
        
        /// <summary>
        /// 
        /// </summary>
        public ViewportWScaling* ViewportWScalings; 
    }
}
