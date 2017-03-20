using System;

namespace SharpVk
{
    /// <summary>
    /// 
    /// </summary>
    public struct ViewportSwizzle
    {
        /// <summary>
        /// 
        /// </summary>
        public ViewportSwizzle(ViewportCoordinateSwizzle x, ViewportCoordinateSwizzle y, ViewportCoordinateSwizzle z, ViewportCoordinateSwizzle w)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
            this.W = w;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public ViewportCoordinateSwizzle X; 
        
        /// <summary>
        /// 
        /// </summary>
        public ViewportCoordinateSwizzle Y; 
        
        /// <summary>
        /// 
        /// </summary>
        public ViewportCoordinateSwizzle Z; 
        
        /// <summary>
        /// 
        /// </summary>
        public ViewportCoordinateSwizzle W; 
    }
}
