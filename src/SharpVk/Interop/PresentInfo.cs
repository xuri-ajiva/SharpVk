using System;

namespace SharpVk.Interop
{
    /// <summary>
    /// 
    /// </summary>
    public unsafe struct PresentInfo
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
        public uint WaitSemaphoreCount; 
        
        /// <summary>
        /// 
        /// </summary>
        public Semaphore* WaitSemaphores; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint SwapchainCount; 
        
        /// <summary>
        /// 
        /// </summary>
        public Swapchain* Swapchains; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint* ImageIndices; 
        
        /// <summary>
        /// 
        /// </summary>
        public Result* Results; 
    }
}
