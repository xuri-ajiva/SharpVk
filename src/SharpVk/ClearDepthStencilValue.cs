using System;

namespace SharpVk
{
    /// <summary>
    /// 
    /// </summary>
    public struct ClearDepthStencilValue
    {
        /// <summary>
        /// 
        /// </summary>
        public ClearDepthStencilValue(float depth, uint stencil)
        {
            this.Depth = depth;
            this.Stencil = stencil;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public float Depth; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint Stencil; 
    }
}
