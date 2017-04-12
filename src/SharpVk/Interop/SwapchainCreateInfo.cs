using System;

namespace SharpVk.Interop
{
    /// <summary>
    /// 
    /// </summary>
    public unsafe struct SwapchainCreateInfo
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
        public SwapchainCreateFlags Flags; 
        
        /// <summary>
        /// 
        /// </summary>
        public Surface Surface; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint MinImageCount; 
        
        /// <summary>
        /// 
        /// </summary>
        public Format ImageFormat; 
        
        /// <summary>
        /// 
        /// </summary>
        public ColorSpace ImageColorSpace; 
        
        /// <summary>
        /// 
        /// </summary>
        public Extent2D ImageExtent; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint ImageArrayLayers; 
        
        /// <summary>
        /// 
        /// </summary>
        public ImageUsageFlags ImageUsage; 
        
        /// <summary>
        /// 
        /// </summary>
        public SharingMode ImageSharingMode; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint QueueFamilyIndexCount; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint* QueueFamilyIndices; 
        
        /// <summary>
        /// 
        /// </summary>
        public SurfaceTransformFlags PreTransform; 
        
        /// <summary>
        /// 
        /// </summary>
        public CompositeAlphaFlags CompositeAlpha; 
        
        /// <summary>
        /// 
        /// </summary>
        public PresentMode PresentMode; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 Clipped; 
        
        /// <summary>
        /// 
        /// </summary>
        public Swapchain OldSwapchain; 
    }
}
