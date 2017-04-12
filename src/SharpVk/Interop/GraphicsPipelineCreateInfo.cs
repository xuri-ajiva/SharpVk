using System;

namespace SharpVk.Interop
{
    /// <summary>
    /// 
    /// </summary>
    public unsafe struct GraphicsPipelineCreateInfo
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
        public uint StageCount; 
        
        /// <summary>
        /// 
        /// </summary>
        public PipelineShaderStageCreateInfo* Stages; 
        
        /// <summary>
        /// 
        /// </summary>
        public PipelineVertexInputStateCreateInfo* VertexInputState; 
        
        /// <summary>
        /// 
        /// </summary>
        public PipelineInputAssemblyStateCreateInfo* InputAssemblyState; 
        
        /// <summary>
        /// 
        /// </summary>
        public PipelineTessellationStateCreateInfo* TessellationState; 
        
        /// <summary>
        /// 
        /// </summary>
        public PipelineViewportStateCreateInfo* ViewportState; 
        
        /// <summary>
        /// 
        /// </summary>
        public PipelineRasterizationStateCreateInfo* RasterizationState; 
        
        /// <summary>
        /// 
        /// </summary>
        public PipelineMultisampleStateCreateInfo* MultisampleState; 
        
        /// <summary>
        /// 
        /// </summary>
        public PipelineDepthStencilStateCreateInfo* DepthStencilState; 
        
        /// <summary>
        /// 
        /// </summary>
        public PipelineColorBlendStateCreateInfo* ColorBlendState; 
        
        /// <summary>
        /// 
        /// </summary>
        public PipelineDynamicStateCreateInfo* DynamicState; 
        
        /// <summary>
        /// 
        /// </summary>
        public PipelineLayout Layout; 
        
        /// <summary>
        /// 
        /// </summary>
        public RenderPass RenderPass; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint Subpass; 
        
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
