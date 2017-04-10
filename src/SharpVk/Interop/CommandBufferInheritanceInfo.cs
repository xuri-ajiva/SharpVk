using System;

namespace SharpVk.Interop
{
    /// <summary>
    /// 
    /// </summary>
    public unsafe struct CommandBufferInheritanceInfo
    {
        /// <summary>
        /// 
        /// </summary>
        public CommandBufferInheritanceInfo(StructureType sType, void* next, RenderPass renderPass, uint subpass, Framebuffer framebuffer, Bool32 occlusionQueryEnable, QueryControlFlags queryFlags, QueryPipelineStatisticFlags pipelineStatistics)
        {
            this.SType = sType;
            this.Next = next;
            this.RenderPass = renderPass;
            this.Subpass = subpass;
            this.Framebuffer = framebuffer;
            this.OcclusionQueryEnable = occlusionQueryEnable;
            this.QueryFlags = queryFlags;
            this.PipelineStatistics = pipelineStatistics;
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
        public RenderPass RenderPass; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint Subpass; 
        
        /// <summary>
        /// 
        /// </summary>
        public Framebuffer Framebuffer; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 OcclusionQueryEnable; 
        
        /// <summary>
        /// 
        /// </summary>
        public QueryControlFlags QueryFlags; 
        
        /// <summary>
        /// 
        /// </summary>
        public QueryPipelineStatisticFlags PipelineStatistics; 
    }
}
