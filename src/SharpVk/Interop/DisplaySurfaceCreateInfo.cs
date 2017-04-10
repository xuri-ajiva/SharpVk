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
        public DisplaySurfaceCreateInfo(StructureType sType, void* next, DisplaySurfaceCreateFlags flags, DisplayMode displayMode, uint planeIndex, uint planeStackIndex, SurfaceTransformFlags transform, float globalAlpha, DisplayPlaneAlphaFlags alphaMode, Extent2D imageExtent)
        {
            this.SType = sType;
            this.Next = next;
            this.Flags = flags;
            this.DisplayMode = displayMode;
            this.PlaneIndex = planeIndex;
            this.PlaneStackIndex = planeStackIndex;
            this.Transform = transform;
            this.GlobalAlpha = globalAlpha;
            this.AlphaMode = alphaMode;
            this.ImageExtent = imageExtent;
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
