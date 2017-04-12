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
