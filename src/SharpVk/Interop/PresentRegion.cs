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
        public PresentRegion(uint rectangleCount, RectLayer* rectangles)
        {
            this.RectangleCount = rectangleCount;
            this.Rectangles = rectangles;
        }
        
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
