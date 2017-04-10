using System;

namespace SharpVk
{
    /// <summary>
    /// 
    /// </summary>
    public struct RectLayer
    {
        /// <summary>
        /// 
        /// </summary>
        public RectLayer(Offset2D offset, Extent2D extent, uint layer)
        {
            this.Offset = offset;
            this.Extent = extent;
            this.Layer = layer;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public Offset2D Offset; 
        
        /// <summary>
        /// 
        /// </summary>
        public Extent2D Extent; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint Layer; 
    }
}
