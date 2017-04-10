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
        public RenderPassBeginInfo(StructureType sType, void* next, RenderPass renderPass, Framebuffer framebuffer, Rect2D renderArea, uint clearValueCount, ClearValue* clearValues)
        {
            this.SType = sType;
            this.Next = next;
            this.RenderPass = renderPass;
            this.Framebuffer = framebuffer;
            this.RenderArea = renderArea;
            this.ClearValueCount = clearValueCount;
            this.ClearValues = clearValues;
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
