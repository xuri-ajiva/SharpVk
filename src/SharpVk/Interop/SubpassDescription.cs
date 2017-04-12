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
