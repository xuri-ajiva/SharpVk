using System;

namespace SharpVk.Interop
{
    /// <summary>
    /// 
    /// </summary>
    public unsafe struct ImageSwapchainCreateInfo
    {
        /// <summary>
        /// 
        /// </summary>
        public ImageSwapchainCreateInfo(StructureType sType, void* next, Swapchain swapchain)
        {
            this.SType = sType;
            this.Next = next;
            this.Swapchain = swapchain;
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
    }
}
