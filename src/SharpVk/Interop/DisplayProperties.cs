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
