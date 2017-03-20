using System;

namespace SharpVk
{
    /// <summary>
    /// 
    /// </summary>
    public struct Rect3D
    {
        /// <summary>
        /// 
        /// </summary>
        public Rect3D(Offset3D offset, Extent3D extent)
        {
            this.Offset = offset;
            this.Extent = extent;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public Offset3D Offset; 
        
        /// <summary>
        /// 
        /// </summary>
        public Extent3D Extent; 
    }
}
