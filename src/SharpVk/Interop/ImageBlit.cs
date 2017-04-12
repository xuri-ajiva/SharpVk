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
