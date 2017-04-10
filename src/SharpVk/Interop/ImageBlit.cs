using System;

namespace SharpVk.Interop
{
    /// <summary>
    /// 
    /// </summary>
    public unsafe struct ImageBlit
    {
        /// <summary>
        /// 
        /// </summary>
        public ImageBlit(ImageSubresourceLayers sourceSubresource, Offset3D sourceOffsets, ImageSubresourceLayers destinationSubresource, Offset3D destinationOffsets)
        {
            this.SourceSubresource = sourceSubresource;
            this.SourceOffsets = sourceOffsets;
            this.DestinationSubresource = destinationSubresource;
            this.DestinationOffsets = destinationOffsets;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public ImageSubresourceLayers SourceSubresource; 
        
        /// <summary>
        /// 
        /// </summary>
        public Offset3D SourceOffsets; 
        
        /// <summary>
        /// 
        /// </summary>
        public ImageSubresourceLayers DestinationSubresource; 
        
        /// <summary>
        /// 
        /// </summary>
        public Offset3D DestinationOffsets; 
    }
}
