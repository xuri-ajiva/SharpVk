using System;

namespace SharpVk
{
    /// <summary>
    /// 
    /// </summary>
    public struct ImageSubresource
    {
        /// <summary>
        /// 
        /// </summary>
        public ImageSubresource(ImageAspectFlags aspectMask, uint mipLevel, uint arrayLayer)
        {
            this.AspectMask = aspectMask;
            this.MipLevel = mipLevel;
            this.ArrayLayer = arrayLayer;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public ImageAspectFlags AspectMask; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint MipLevel; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint ArrayLayer; 
    }
}
