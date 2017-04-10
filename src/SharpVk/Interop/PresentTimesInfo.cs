using System;

namespace SharpVk.Interop
{
    /// <summary>
    /// 
    /// </summary>
    public unsafe struct PresentTimesInfo
    {
        /// <summary>
        /// 
        /// </summary>
        public PresentTimesInfo(StructureType sType, void* next, uint swapchainCount, PresentTime* times)
        {
            this.SType = sType;
            this.Next = next;
            this.SwapchainCount = swapchainCount;
            this.Times = times;
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
        public PresentTime* Times; 
    }
}
