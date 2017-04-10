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
        public PipelineRasterizationStateCreateInfo(StructureType sType, void* next, PipelineRasterizationStateCreateFlags flags, Bool32 depthClampEnable, Bool32 rasterizerDiscardEnable, PolygonMode polygonMode, CullModeFlags cullMode, FrontFace frontFace, Bool32 depthBiasEnable, float depthBiasConstantFactor, float depthBiasClamp, float depthBiasSlopeFactor, float lineWidth)
        {
            this.SType = sType;
            this.Next = next;
            this.Flags = flags;
            this.DepthClampEnable = depthClampEnable;
            this.RasterizerDiscardEnable = rasterizerDiscardEnable;
            this.PolygonMode = polygonMode;
            this.CullMode = cullMode;
            this.FrontFace = frontFace;
            this.DepthBiasEnable = depthBiasEnable;
            this.DepthBiasConstantFactor = depthBiasConstantFactor;
            this.DepthBiasClamp = depthBiasClamp;
            this.DepthBiasSlopeFactor = depthBiasSlopeFactor;
            this.LineWidth = lineWidth;
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
