using System;

namespace SharpVk
{
    /// <summary>
    /// 
    /// </summary>
    public struct AttachmentReference
    {
        /// <summary>
        /// 
        /// </summary>
        public AttachmentReference(uint attachment, ImageLayout layout)
        {
            this.Attachment = attachment;
            this.Layout = layout;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint Attachment; 
        
        /// <summary>
        /// 
        /// </summary>
        public ImageLayout Layout; 
    }
}
