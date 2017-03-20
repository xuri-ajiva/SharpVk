using System;

namespace SharpVk
{
    /// <summary>
    /// 
    /// </summary>
    public struct BufferImageCopy
    {
        /// <summary>
        /// 
        /// </summary>
        public BufferImageCopy(DeviceSize bufferOffset, uint bufferRowLength, uint bufferImageHeight, ImageSubresourceLayers imageSubresource, Offset3D imageOffset, Extent3D imageExtent)
        {
            this.BufferOffset = bufferOffset;
            this.BufferRowLength = bufferRowLength;
            this.BufferImageHeight = bufferImageHeight;
            this.ImageSubresource = imageSubresource;
            this.ImageOffset = imageOffset;
            this.ImageExtent = imageExtent;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public DeviceSize BufferOffset; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint BufferRowLength; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint BufferImageHeight; 
        
        /// <summary>
        /// 
        /// </summary>
        public ImageSubresourceLayers ImageSubresource; 
        
        /// <summary>
        /// 
        /// </summary>
        public Offset3D ImageOffset; 
        
        /// <summary>
        /// 
        /// </summary>
        public Extent3D ImageExtent; 
    }
}
