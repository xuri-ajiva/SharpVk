using System;

namespace SharpVk.Interop
{
    /// <summary>
    /// 
    /// </summary>
    public unsafe struct ImageMemoryBarrier
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
        public AccessFlags SourceAccessMask; 
        
        /// <summary>
        /// 
        /// </summary>
        public AccessFlags DestinationAccessMask; 
        
        /// <summary>
        /// 
        /// </summary>
        public ImageLayout OldLayout; 
        
        /// <summary>
        /// 
        /// </summary>
        public ImageLayout NewLayout; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint SourceQueueFamilyIndex; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint DestinationQueueFamilyIndex; 
        
        /// <summary>
        /// 
        /// </summary>
        public Image Image; 
        
        /// <summary>
        /// 
        /// </summary>
        public ImageSubresourceRange SubresourceRange; 
    }
}
