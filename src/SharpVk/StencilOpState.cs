using System;

namespace SharpVk
{
    /// <summary>
    /// 
    /// </summary>
    public struct StencilOpState
    {
        /// <summary>
        /// 
        /// </summary>
        public StencilOpState(StencilOp failOp, StencilOp passOp, StencilOp depthFailOp, CompareOp compareOp, uint compareMask, uint writeMask, uint reference)
        {
            this.FailOp = failOp;
            this.PassOp = passOp;
            this.DepthFailOp = depthFailOp;
            this.CompareOp = compareOp;
            this.CompareMask = compareMask;
            this.WriteMask = writeMask;
            this.Reference = reference;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public StencilOp FailOp; 
        
        /// <summary>
        /// 
        /// </summary>
        public StencilOp PassOp; 
        
        /// <summary>
        /// 
        /// </summary>
        public StencilOp DepthFailOp; 
        
        /// <summary>
        /// 
        /// </summary>
        public CompareOp CompareOp; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint CompareMask; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint WriteMask; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint Reference; 
    }
}
