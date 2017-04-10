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
        public ImageViewCreateInfo(StructureType sType, void* next, ImageViewCreateFlags flags, Image image, ImageViewType viewType, Format format, ComponentMapping components, ImageSubresourceRange subresourceRange)
        {
            this.SType = sType;
            this.Next = next;
            this.Flags = flags;
            this.Image = image;
            this.ViewType = viewType;
            this.Format = format;
            this.Components = components;
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
