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
        public GraphicsPipelineCreateInfo(StructureType sType, void* next, PipelineCreateFlags flags, uint stageCount, PipelineShaderStageCreateInfo* stages, PipelineVertexInputStateCreateInfo* vertexInputState, PipelineInputAssemblyStateCreateInfo* inputAssemblyState, PipelineTessellationStateCreateInfo* tessellationState, PipelineViewportStateCreateInfo* viewportState, PipelineRasterizationStateCreateInfo* rasterizationState, PipelineMultisampleStateCreateInfo* multisampleState, PipelineDepthStencilStateCreateInfo* depthStencilState, PipelineColorBlendStateCreateInfo* colorBlendState, PipelineDynamicStateCreateInfo* dynamicState, PipelineLayout layout, RenderPass renderPass, uint subpass, Pipeline basePipelineHandle, int basePipelineIndex)
        {
            this.SType = sType;
            this.Next = next;
            this.Flags = flags;
            this.StageCount = stageCount;
            this.Stages = stages;
            this.VertexInputState = vertexInputState;
            this.InputAssemblyState = inputAssemblyState;
            this.TessellationState = tessellationState;
            this.ViewportState = viewportState;
            this.RasterizationState = rasterizationState;
            this.MultisampleState = multisampleState;
            this.DepthStencilState = depthStencilState;
            this.ColorBlendState = colorBlendState;
            this.DynamicState = dynamicState;
            this.Layout = layout;
            this.RenderPass = renderPass;
            this.Subpass = subpass;
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
