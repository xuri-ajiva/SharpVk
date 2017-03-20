using System;

namespace SharpVk
{
    /// <summary>
    /// 
    /// </summary>
    public struct SparseImageMemoryRequirements
    {
        /// <summary>
        /// 
        /// </summary>
        public SparseImageMemoryRequirements(SparseImageFormatProperties formatProperties, uint imageMipTailFirstLod, DeviceSize imageMipTailSize, DeviceSize imageMipTailOffset, DeviceSize imageMipTailStride)
        {
            this.FormatProperties = formatProperties;
            this.ImageMipTailFirstLod = imageMipTailFirstLod;
            this.ImageMipTailSize = imageMipTailSize;
            this.ImageMipTailOffset = imageMipTailOffset;
            this.ImageMipTailStride = imageMipTailStride;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SparseImageFormatProperties FormatProperties; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint ImageMipTailFirstLod; 
        
        /// <summary>
        /// 
        /// </summary>
        public DeviceSize ImageMipTailSize; 
        
        /// <summary>
        /// 
        /// </summary>
        public DeviceSize ImageMipTailOffset; 
        
        /// <summary>
        /// 
        /// </summary>
        public DeviceSize ImageMipTailStride; 
    }
}
