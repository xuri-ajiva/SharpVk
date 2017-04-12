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
