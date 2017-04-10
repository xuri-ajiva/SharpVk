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
        public PipelineViewportWScalingStateCreateInfo(StructureType sType, void* next, Bool32 viewportWScalingEnable, uint viewportCount, ViewportWScaling* viewportWScalings)
        {
            this.SType = sType;
            this.Next = next;
            this.ViewportWScalingEnable = viewportWScalingEnable;
            this.ViewportCount = viewportCount;
            this.ViewportWScalings = viewportWScalings;
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
