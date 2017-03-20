using System;

namespace SharpVk
{
    /// <summary>
    /// 
    /// </summary>
    public struct ViewportWScaling
    {
        /// <summary>
        /// 
        /// </summary>
        public ViewportWScaling(float xcoeff, float ycoeff)
        {
            this.Xcoeff = xcoeff;
            this.Ycoeff = ycoeff;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public float Xcoeff; 
        
        /// <summary>
        /// 
        /// </summary>
        public float Ycoeff; 
    }
}
