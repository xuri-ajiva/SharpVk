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
        public AcquireNextImageInfo(StructureType sType, void* next, Swapchain swapchain, ulong timeout, Semaphore semaphore, Fence fence, uint deviceMask)
        {
            this.SType = sType;
            this.Next = next;
            this.Swapchain = swapchain;
            this.Timeout = timeout;
            this.Semaphore = semaphore;
            this.Fence = fence;
            this.DeviceMask = deviceMask;
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
