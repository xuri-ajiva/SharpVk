using System;

namespace SharpVk
{
    /// <summary>
    /// 
    /// </summary>
    public struct ImageSubresourceRange
    {
        /// <summary>
        /// 
        /// </summary>
        public ImageSubresourceRange(ImageAspectFlags aspectMask, uint baseMipLevel, uint levelCount, uint baseArrayLayer, uint layerCount)
        {
            this.AspectMask = aspectMask;
            this.BaseMipLevel = baseMipLevel;
            this.LevelCount = levelCount;
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
        public uint BaseMipLevel; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint LevelCount; 
        
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
