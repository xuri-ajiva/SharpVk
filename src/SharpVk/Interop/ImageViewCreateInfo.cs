using System;

namespace SharpVk.Interop
{
    /// <summary>
    /// 
    /// </summary>
    public unsafe struct ImageViewCreateInfo
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
        public ImageViewCreateFlags Flags; 
        
        /// <summary>
        /// 
        /// </summary>
        public Image Image; 
        
        /// <summary>
        /// 
        /// </summary>
        public ImageViewType ViewType; 
        
        /// <summary>
        /// 
        /// </summary>
        public Format Format; 
        
        /// <summary>
        /// 
        /// </summary>
        public ComponentMapping Components; 
        
        /// <summary>
        /// 
        /// </summary>
        public ImageSubresourceRange SubresourceRange; 
    }
}
