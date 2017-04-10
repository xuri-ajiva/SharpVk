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
        public ImageMemoryBarrier(StructureType sType, void* next, AccessFlags sourceAccessMask, AccessFlags destinationAccessMask, ImageLayout oldLayout, ImageLayout newLayout, uint sourceQueueFamilyIndex, uint destinationQueueFamilyIndex, Image image, ImageSubresourceRange subresourceRange)
        {
            this.SType = sType;
            this.Next = next;
            this.SourceAccessMask = sourceAccessMask;
            this.DestinationAccessMask = destinationAccessMask;
            this.OldLayout = oldLayout;
            this.NewLayout = newLayout;
            this.SourceQueueFamilyIndex = sourceQueueFamilyIndex;
            this.DestinationQueueFamilyIndex = destinationQueueFamilyIndex;
            this.Image = image;
            this.SubresourceRange = subresourceRange;
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
