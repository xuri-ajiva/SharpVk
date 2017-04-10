using System;

namespace SharpVk.Interop
{
    /// <summary>
    /// 
    /// </summary>
    public unsafe struct BindImageMemorySwapchainInfo
    {
        /// <summary>
        /// 
        /// </summary>
        public BindImageMemorySwapchainInfo(StructureType sType, void* next, Swapchain swapchain, uint imageIndex)
        {
            this.SType = sType;
            this.Next = next;
            this.Swapchain = swapchain;
            this.ImageIndex = imageIndex;
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
        public uint ImageIndex; 
    }
}
