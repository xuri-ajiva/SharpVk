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
        public SwapchainCreateInfo(StructureType sType, void* next, SwapchainCreateFlags flags, Surface surface, uint minImageCount, Format imageFormat, ColorSpace imageColorSpace, Extent2D imageExtent, uint imageArrayLayers, ImageUsageFlags imageUsage, SharingMode imageSharingMode, uint queueFamilyIndexCount, uint* queueFamilyIndices, SurfaceTransformFlags preTransform, CompositeAlphaFlags compositeAlpha, PresentMode presentMode, Bool32 clipped, Swapchain oldSwapchain)
        {
            this.SType = sType;
            this.Next = next;
            this.Flags = flags;
            this.Surface = surface;
            this.MinImageCount = minImageCount;
            this.ImageFormat = imageFormat;
            this.ImageColorSpace = imageColorSpace;
            this.ImageExtent = imageExtent;
            this.ImageArrayLayers = imageArrayLayers;
            this.ImageUsage = imageUsage;
            this.ImageSharingMode = imageSharingMode;
            this.QueueFamilyIndexCount = queueFamilyIndexCount;
            this.QueueFamilyIndices = queueFamilyIndices;
            this.PreTransform = preTransform;
            this.CompositeAlpha = compositeAlpha;
            this.PresentMode = presentMode;
            this.Clipped = clipped;
            this.OldSwapchain = oldSwapchain;
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
