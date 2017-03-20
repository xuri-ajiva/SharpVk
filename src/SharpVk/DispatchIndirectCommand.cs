using System;

namespace SharpVk
{
    /// <summary>
    /// 
    /// </summary>
    public struct DispatchIndirectCommand
    {
        /// <summary>
        /// 
        /// </summary>
        public DispatchIndirectCommand(uint x, uint y, uint z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint X; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint Y; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint Z; 
    }
}
