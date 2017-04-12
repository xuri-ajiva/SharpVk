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
