using System;

namespace SharpVk
{
    /// <summary>
    /// 
    /// </summary>
    public struct DisplayModeParameters
    {
        /// <summary>
        /// 
        /// </summary>
        public DisplayModeParameters(Extent2D visibleRegion, uint refreshRate)
        {
            this.VisibleRegion = visibleRegion;
            this.RefreshRate = refreshRate;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public Extent2D VisibleRegion; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint RefreshRate; 
    }
}
