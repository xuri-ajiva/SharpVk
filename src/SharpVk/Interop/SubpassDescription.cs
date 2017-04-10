using System;

namespace SharpVk.Interop
{
    /// <summary>
    /// 
    /// </summary>
    public unsafe struct SubpassDescription
    {
        /// <summary>
        /// 
        /// </summary>
        public SubpassDescription(SubpassDescriptionFlags flags, PipelineBindPoint pipelineBindPoint, uint inputAttachmentCount, AttachmentReference* inputAttachments, uint colorAttachmentCount, AttachmentReference* colorAttachments, AttachmentReference* resolveAttachments, AttachmentReference* depthStencilAttachment, uint preserveAttachmentCount, uint* preserveAttachments)
        {
            this.Flags = flags;
            this.PipelineBindPoint = pipelineBindPoint;
            this.InputAttachmentCount = inputAttachmentCount;
            this.InputAttachments = inputAttachments;
            this.ColorAttachmentCount = colorAttachmentCount;
            this.ColorAttachments = colorAttachments;
            this.ResolveAttachments = resolveAttachments;
            this.DepthStencilAttachment = depthStencilAttachment;
            this.PreserveAttachmentCount = preserveAttachmentCount;
            this.PreserveAttachments = preserveAttachments;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SubpassDescriptionFlags Flags; 
        
        /// <summary>
        /// 
        /// </summary>
        public PipelineBindPoint PipelineBindPoint; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint InputAttachmentCount; 
        
        /// <summary>
        /// 
        /// </summary>
        public AttachmentReference* InputAttachments; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint ColorAttachmentCount; 
        
        /// <summary>
        /// 
        /// </summary>
        public AttachmentReference* ColorAttachments; 
        
        /// <summary>
        /// 
        /// </summary>
        public AttachmentReference* ResolveAttachments; 
        
        /// <summary>
        /// 
        /// </summary>
        public AttachmentReference* DepthStencilAttachment; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint PreserveAttachmentCount; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint* PreserveAttachments; 
    }
}
