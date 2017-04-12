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
