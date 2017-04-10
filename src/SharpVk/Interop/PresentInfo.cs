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
        public PresentInfo(StructureType sType, void* next, uint waitSemaphoreCount, Semaphore* waitSemaphores, uint swapchainCount, Swapchain* swapchains, uint* imageIndices, Result* results)
        {
            this.SType = sType;
            this.Next = next;
            this.WaitSemaphoreCount = waitSemaphoreCount;
            this.WaitSemaphores = waitSemaphores;
            this.SwapchainCount = swapchainCount;
            this.Swapchains = swapchains;
            this.ImageIndices = imageIndices;
            this.Results = results;
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
