using System;

namespace SharpVk
{
    /// <summary>
    /// 
    /// </summary>
    public struct Extent2D
    {
        /// <summary>
        /// 
        /// </summary>
        public Extent2D(uint width, uint height)
        {
            this.Width = width;
            this.Height = height;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint Width; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint Height; 
    }
}
