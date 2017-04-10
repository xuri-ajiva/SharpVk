using System;

namespace SharpVk.Interop
{
    /// <summary>
    /// 
    /// </summary>
    public unsafe struct FramebufferCreateInfo
    {
        /// <summary>
        /// 
        /// </summary>
        public FramebufferCreateInfo(StructureType sType, void* next, FramebufferCreateFlags flags, RenderPass renderPass, uint attachmentCount, ImageView* attachments, uint width, uint height, uint layers)
        {
            this.SType = sType;
            this.Next = next;
            this.Flags = flags;
            this.RenderPass = renderPass;
            this.AttachmentCount = attachmentCount;
            this.Attachments = attachments;
            this.Width = width;
            this.Height = height;
            this.Layers = layers;
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
        public FramebufferCreateFlags Flags; 
        
        /// <summary>
        /// 
        /// </summary>
        public RenderPass RenderPass; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint AttachmentCount; 
        
        /// <summary>
        /// 
        /// </summary>
        public ImageView* Attachments; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint Width; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint Height; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint Layers; 
    }
}
