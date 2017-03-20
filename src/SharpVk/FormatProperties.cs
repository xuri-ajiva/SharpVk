using System;

namespace SharpVk
{
    /// <summary>
    /// 
    /// </summary>
    public struct FormatProperties
    {
        /// <summary>
        /// 
        /// </summary>
        public FormatProperties(FormatFeatureFlags linearTilingFeatures, FormatFeatureFlags optimalTilingFeatures, FormatFeatureFlags bufferFeatures)
        {
            this.LinearTilingFeatures = linearTilingFeatures;
            this.OptimalTilingFeatures = optimalTilingFeatures;
            this.BufferFeatures = bufferFeatures;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public FormatFeatureFlags LinearTilingFeatures; 
        
        /// <summary>
        /// 
        /// </summary>
        public FormatFeatureFlags OptimalTilingFeatures; 
        
        /// <summary>
        /// 
        /// </summary>
        public FormatFeatureFlags BufferFeatures; 
    }
}
