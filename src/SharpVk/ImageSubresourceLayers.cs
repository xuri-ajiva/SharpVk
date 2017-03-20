using System;

namespace SharpVk
{
    /// <summary>
    /// 
    /// </summary>
    public struct ImageSubresourceLayers
    {
        /// <summary>
        /// 
        /// </summary>
        public ImageSubresourceLayers(ImageAspectFlags aspectMask, uint mipLevel, uint baseArrayLayer, uint layerCount)
        {
            this.AspectMask = aspectMask;
            this.MipLevel = mipLevel;
            this.BaseArrayLayer = baseArrayLayer;
            this.LayerCount = layerCount;
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
        public uint BaseArrayLayer; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint LayerCount; 
    }
}
