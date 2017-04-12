using System;

namespace SharpVk.Interop
{
    /// <summary>
    /// 
    /// </summary>
    public unsafe struct PipelineRasterizationStateCreateInfo
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
        public PipelineRasterizationStateCreateFlags Flags; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 DepthClampEnable; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 RasterizerDiscardEnable; 
        
        /// <summary>
        /// 
        /// </summary>
        public PolygonMode PolygonMode; 
        
        /// <summary>
        /// 
        /// </summary>
        public CullModeFlags CullMode; 
        
        /// <summary>
        /// 
        /// </summary>
        public FrontFace FrontFace; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 DepthBiasEnable; 
        
        /// <summary>
        /// 
        /// </summary>
        public float DepthBiasConstantFactor; 
        
        /// <summary>
        /// 
        /// </summary>
        public float DepthBiasClamp; 
        
        /// <summary>
        /// 
        /// </summary>
        public float DepthBiasSlopeFactor; 
        
        /// <summary>
        /// 
        /// </summary>
        public float LineWidth; 
    }
}
