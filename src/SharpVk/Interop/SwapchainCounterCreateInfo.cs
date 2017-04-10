using System;

namespace SharpVk.Interop
{
    /// <summary>
    /// 
    /// </summary>
    public unsafe struct SwapchainCounterCreateInfo
    {
        /// <summary>
        /// 
        /// </summary>
        public SwapchainCounterCreateInfo(StructureType sType, void* next, SurfaceCounterFlags surfaceCounters)
        {
            this.SType = sType;
            this.Next = next;
            this.SurfaceCounters = surfaceCounters;
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
        public SurfaceCounterFlags SurfaceCounters; 
    }
}
