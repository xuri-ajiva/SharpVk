using System;

namespace SharpVk.Interop
{
    /// <summary>
    /// 
    /// </summary>
    public unsafe struct DisplaySurfaceCreateInfo
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
        public DisplaySurfaceCreateFlags Flags; 
        
        /// <summary>
        /// 
        /// </summary>
        public DisplayMode DisplayMode; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint PlaneIndex; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint PlaneStackIndex; 
        
        /// <summary>
        /// 
        /// </summary>
        public SurfaceTransformFlags Transform; 
        
        /// <summary>
        /// 
        /// </summary>
        public float GlobalAlpha; 
        
        /// <summary>
        /// 
        /// </summary>
        public DisplayPlaneAlphaFlags AlphaMode; 
        
        /// <summary>
        /// 
        /// </summary>
        public Extent2D ImageExtent; 
    }
}
