using System;

namespace SharpVk
{
    /// <summary>
    /// 
    /// </summary>
    public struct ImageResolve
    {
        /// <summary>
        /// 
        /// </summary>
        public ImageResolve(ImageSubresourceLayers sourceSubresource, Offset3D sourceOffset, ImageSubresourceLayers destinationSubresource, Offset3D destinationOffset, Extent3D extent)
        {
            this.SourceSubresource = sourceSubresource;
            this.SourceOffset = sourceOffset;
            this.DestinationSubresource = destinationSubresource;
            this.DestinationOffset = destinationOffset;
            this.Extent = extent;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public ImageSubresourceLayers SourceSubresource; 
        
        /// <summary>
        /// 
        /// </summary>
        public Offset3D SourceOffset; 
        
        /// <summary>
        /// 
        /// </summary>
        public ImageSubresourceLayers DestinationSubresource; 
        
        /// <summary>
        /// 
        /// </summary>
        public Offset3D DestinationOffset; 
        
        /// <summary>
        /// 
        /// </summary>
        public Extent3D Extent; 
    }
}
