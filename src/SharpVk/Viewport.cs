using System;

namespace SharpVk
{
    /// <summary>
    /// 
    /// </summary>
    public struct Viewport
    {
        /// <summary>
        /// 
        /// </summary>
        public Viewport(float x, float y, float width, float height, float minDepth, float maxDepth)
        {
            this.X = x;
            this.Y = y;
            this.Width = width;
            this.Height = height;
            this.MinDepth = minDepth;
            this.MaxDepth = maxDepth;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public float X; 
        
        /// <summary>
        /// 
        /// </summary>
        public float Y; 
        
        /// <summary>
        /// 
        /// </summary>
        public float Width; 
        
        /// <summary>
        /// 
        /// </summary>
        public float Height; 
        
        /// <summary>
        /// 
        /// </summary>
        public float MinDepth; 
        
        /// <summary>
        /// 
        /// </summary>
        public float MaxDepth; 
    }
}
