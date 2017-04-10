using System;

namespace SharpVk.Interop
{
    /// <summary>
    /// 
    /// </summary>
    public unsafe struct DisplayProperties
    {
        /// <summary>
        /// 
        /// </summary>
        public DisplayProperties(Display display, char* displayName, Extent2D physicalDimensions, Extent2D physicalResolution, SurfaceTransformFlags supportedTransforms, Bool32 planeReorderPossible, Bool32 persistentContent)
        {
            this.Display = display;
            this.DisplayName = displayName;
            this.PhysicalDimensions = physicalDimensions;
            this.PhysicalResolution = physicalResolution;
            this.SupportedTransforms = supportedTransforms;
            this.PlaneReorderPossible = planeReorderPossible;
            this.PersistentContent = persistentContent;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public Display Display; 
        
        /// <summary>
        /// 
        /// </summary>
        public char* DisplayName; 
        
        /// <summary>
        /// 
        /// </summary>
        public Extent2D PhysicalDimensions; 
        
        /// <summary>
        /// 
        /// </summary>
        public Extent2D PhysicalResolution; 
        
        /// <summary>
        /// 
        /// </summary>
        public SurfaceTransformFlags SupportedTransforms; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 PlaneReorderPossible; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 PersistentContent; 
    }
}
