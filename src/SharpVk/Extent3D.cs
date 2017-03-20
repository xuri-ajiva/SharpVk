using System;

namespace SharpVk
{
    /// <summary>
    /// 
    /// </summary>
    public struct Extent3D
    {
        /// <summary>
        /// 
        /// </summary>
        public Extent3D(uint width, uint height, uint depth)
        {
            this.Width = width;
            this.Height = height;
            this.Depth = depth;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint Width; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint Height; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint Depth; 
    }
}
