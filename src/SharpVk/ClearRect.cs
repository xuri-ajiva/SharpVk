using System;

namespace SharpVk
{
    /// <summary>
    /// 
    /// </summary>
    public struct ClearRect
    {
        /// <summary>
        /// 
        /// </summary>
        public ClearRect(Rect2D rect, uint baseArrayLayer, uint layerCount)
        {
            this.Rect = rect;
            this.BaseArrayLayer = baseArrayLayer;
            this.LayerCount = layerCount;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public Rect2D Rect; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint BaseArrayLayer; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint LayerCount; 
    }
}
