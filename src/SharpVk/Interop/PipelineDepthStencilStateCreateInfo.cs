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
