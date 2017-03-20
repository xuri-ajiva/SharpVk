using System;

namespace SharpVk
{
    /// <summary>
    /// 
    /// </summary>
    public struct SparseImageFormatProperties
    {
        /// <summary>
        /// 
        /// </summary>
        public SparseImageFormatProperties(ImageAspectFlags aspectMask, Extent3D imageGranularity, SparseImageFormatFlags flags)
        {
            this.AspectMask = aspectMask;
            this.ImageGranularity = imageGranularity;
            this.Flags = flags;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public ImageAspectFlags AspectMask; 
        
        /// <summary>
        /// 
        /// </summary>
        public Extent3D ImageGranularity; 
        
        /// <summary>
        /// 
        /// </summary>
        public SparseImageFormatFlags Flags; 
    }
}
