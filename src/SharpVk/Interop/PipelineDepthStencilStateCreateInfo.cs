using System;

namespace SharpVk.Interop
{
    /// <summary>
    /// 
    /// </summary>
    public unsafe struct PipelineDepthStencilStateCreateInfo
    {
        /// <summary>
        /// 
        /// </summary>
        public PipelineDepthStencilStateCreateInfo(StructureType sType, void* next, PipelineDepthStencilStateCreateFlags flags, Bool32 depthTestEnable, Bool32 depthWriteEnable, CompareOp depthCompareOp, Bool32 depthBoundsTestEnable, Bool32 stencilTestEnable, StencilOpState front, StencilOpState back, float minDepthBounds, float maxDepthBounds)
        {
            this.SType = sType;
            this.Next = next;
            this.Flags = flags;
            this.DepthTestEnable = depthTestEnable;
            this.DepthWriteEnable = depthWriteEnable;
            this.DepthCompareOp = depthCompareOp;
            this.DepthBoundsTestEnable = depthBoundsTestEnable;
            this.StencilTestEnable = stencilTestEnable;
            this.Front = front;
            this.Back = back;
            this.MinDepthBounds = minDepthBounds;
            this.MaxDepthBounds = maxDepthBounds;
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
        public PipelineDepthStencilStateCreateFlags Flags; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 DepthTestEnable; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 DepthWriteEnable; 
        
        /// <summary>
        /// 
        /// </summary>
        public CompareOp DepthCompareOp; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 DepthBoundsTestEnable; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 StencilTestEnable; 
        
        /// <summary>
        /// 
        /// </summary>
        public StencilOpState Front; 
        
        /// <summary>
        /// 
        /// </summary>
        public StencilOpState Back; 
        
        /// <summary>
        /// 
        /// </summary>
        public float MinDepthBounds; 
        
        /// <summary>
        /// 
        /// </summary>
        public float MaxDepthBounds; 
    }
}
