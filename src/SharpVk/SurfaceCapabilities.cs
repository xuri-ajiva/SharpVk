using System;

namespace SharpVk
{
    /// <summary>
    /// 
    /// </summary>
    public struct SurfaceCapabilities
    {
        /// <summary>
        /// 
        /// </summary>
        public SurfaceCapabilities(uint minImageCount, uint maxImageCount, Extent2D currentExtent, Extent2D minImageExtent, Extent2D maxImageExtent, uint maxImageArrayLayers, SurfaceTransformFlags supportedTransforms, SurfaceTransformFlags currentTransform, CompositeAlphaFlags supportedCompositeAlpha, ImageUsageFlags supportedUsageFlags)
        {
            this.MinImageCount = minImageCount;
            this.MaxImageCount = maxImageCount;
            this.CurrentExtent = currentExtent;
            this.MinImageExtent = minImageExtent;
            this.MaxImageExtent = maxImageExtent;
            this.MaxImageArrayLayers = maxImageArrayLayers;
            this.SupportedTransforms = supportedTransforms;
            this.CurrentTransform = currentTransform;
            this.SupportedCompositeAlpha = supportedCompositeAlpha;
            this.SupportedUsageFlags = supportedUsageFlags;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MinImageCount; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxImageCount; 
        
        /// <summary>
        /// 
        /// </summary>
        public Extent2D CurrentExtent; 
        
        /// <summary>
        /// 
        /// </summary>
        public Extent2D MinImageExtent; 
        
        /// <summary>
        /// 
        /// </summary>
        public Extent2D MaxImageExtent; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxImageArrayLayers; 
        
        /// <summary>
        /// 
        /// </summary>
        public SurfaceTransformFlags SupportedTransforms; 
        
        /// <summary>
        /// 
        /// </summary>
        public SurfaceTransformFlags CurrentTransform; 
        
        /// <summary>
        /// 
        /// </summary>
        public CompositeAlphaFlags SupportedCompositeAlpha; 
        
        /// <summary>
        /// 
        /// </summary>
        public ImageUsageFlags SupportedUsageFlags; 
    }
}
