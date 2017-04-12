using System;

namespace SharpVk.Interop
{
    /// <summary>
    /// 
    /// </summary>
    public unsafe struct PresentRegion
    {
        /// <summary>
        /// 
        /// </summary>
        public uint RectangleCount; 
        
        /// <summary>
        /// 
        /// </summary>
        public RectLayer* Rectangles; 
    }
}
