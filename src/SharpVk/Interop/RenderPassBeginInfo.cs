using System;

namespace SharpVk.Interop
{
    /// <summary>
    /// 
    /// </summary>
    public unsafe struct RenderPassBeginInfo
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
        public Framebuffer Framebuffer; 
        
        /// <summary>
        /// 
        /// </summary>
        public Rect2D RenderArea; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint ClearValueCount; 
        
        /// <summary>
        /// 
        /// </summary>
        public ClearValue* ClearValues; 
    }
}
