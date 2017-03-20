using System;

namespace SharpVk
{
    /// <summary>
    /// 
    /// </summary>
    public struct Rect2D
    {
        /// <summary>
        /// 
        /// </summary>
        public Rect2D(Offset2D offset, Extent2D extent)
        {
            this.Offset = offset;
            this.Extent = extent;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public Offset2D Offset; 
        
        /// <summary>
        /// 
        /// </summary>
        public Extent2D Extent; 
    }
}
