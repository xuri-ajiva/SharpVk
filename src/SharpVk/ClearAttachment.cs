using System;

namespace SharpVk
{
    /// <summary>
    /// 
    /// </summary>
    public struct ClearAttachment
    {
        /// <summary>
        /// 
        /// </summary>
        public ClearAttachment(ImageAspectFlags aspectMask, uint colorAttachment, ClearValue clearValue)
        {
            this.AspectMask = aspectMask;
            this.ColorAttachment = colorAttachment;
            this.ClearValue = clearValue;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public ImageAspectFlags AspectMask; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint ColorAttachment; 
        
        /// <summary>
        /// 
        /// </summary>
        public ClearValue ClearValue; 
    }
}
