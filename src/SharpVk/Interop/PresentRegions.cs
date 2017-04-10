using System;

namespace SharpVk.Interop
{
    /// <summary>
    /// 
    /// </summary>
    public unsafe struct PresentRegions
    {
        /// <summary>
        /// 
        /// </summary>
        public PresentRegions(StructureType sType, void* next, uint swapchainCount, PresentRegion* regions)
        {
            this.SType = sType;
            this.Next = next;
            this.SwapchainCount = swapchainCount;
            this.Regions = regions;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public StructureType SType; 
        
        /// <summary>
        /// 
        /// </summary>
        public void* Next; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint SwapchainCount; 
        
        /// <summary>
        /// 
        /// </summary>
        public PresentRegion* Regions; 
    }
}
