using System;

namespace SharpVk
{
    /// <summary>
    /// 
    /// </summary>
    public struct PipelineColorBlendAttachmentState
    {
        /// <summary>
        /// 
        /// </summary>
        public PipelineColorBlendAttachmentState(Bool32 blendEnable, BlendFactor sourceColorBlendFactor, BlendFactor destinationColorBlendFactor, BlendOp colorBlendOp, BlendFactor sourceAlphaBlendFactor, BlendFactor destinationAlphaBlendFactor, BlendOp alphaBlendOp, ColorComponentFlags colorWriteMask)
        {
            this.BlendEnable = blendEnable;
            this.SourceColorBlendFactor = sourceColorBlendFactor;
            this.DestinationColorBlendFactor = destinationColorBlendFactor;
            this.ColorBlendOp = colorBlendOp;
            this.SourceAlphaBlendFactor = sourceAlphaBlendFactor;
            this.DestinationAlphaBlendFactor = destinationAlphaBlendFactor;
            this.AlphaBlendOp = alphaBlendOp;
            this.ColorWriteMask = colorWriteMask;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 BlendEnable; 
        
        /// <summary>
        /// 
        /// </summary>
        public BlendFactor SourceColorBlendFactor; 
        
        /// <summary>
        /// 
        /// </summary>
        public BlendFactor DestinationColorBlendFactor; 
        
        /// <summary>
        /// 
        /// </summary>
        public BlendOp ColorBlendOp; 
        
        /// <summary>
        /// 
        /// </summary>
        public BlendFactor SourceAlphaBlendFactor; 
        
        /// <summary>
        /// 
        /// </summary>
        public BlendFactor DestinationAlphaBlendFactor; 
        
        /// <summary>
        /// 
        /// </summary>
        public BlendOp AlphaBlendOp; 
        
        /// <summary>
        /// 
        /// </summary>
        public ColorComponentFlags ColorWriteMask; 
    }
}
