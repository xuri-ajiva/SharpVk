using System;

namespace SharpVk.Interop
{
    /// <summary>
    /// 
    /// </summary>
    public unsafe struct SurfaceCapabilities2
    {
        /// <summary>
        /// 
        /// </summary>
        public SurfaceCapabilities2(StructureType sType, void* next, uint minImageCount, uint maxImageCount, Extent2D currentExtent, Extent2D minImageExtent, Extent2D maxImageExtent, uint maxImageArrayLayers, SurfaceTransformFlags supportedTransforms, SurfaceTransformFlags currentTransform, CompositeAlphaFlags supportedCompositeAlpha, ImageUsageFlags supportedUsageFlags, SurfaceCounterFlags supportedSurfaceCounters)
        {
            this.SType = sType;
            this.Next = next;
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
            this.SupportedSurfaceCounters = supportedSurfaceCounters;
        }
        
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
        
        /// <summary>
        /// 
        /// </summary>
        public SurfaceCounterFlags SupportedSurfaceCounters; 
    }
}
