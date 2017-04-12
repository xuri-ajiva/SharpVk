using System;

namespace SharpVk.Interop
{
    /// <summary>
    /// 
    /// </summary>
    public unsafe struct AcquireNextImageInfo
    {
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
        public Swapchain Swapchain; 
        
        /// <summary>
        /// 
        /// </summary>
        public ulong Timeout; 
        
        /// <summary>
        /// 
        /// </summary>
        public Semaphore Semaphore; 
        
        /// <summary>
        /// 
        /// </summary>
        public Fence Fence; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint DeviceMask; 
    }
}
