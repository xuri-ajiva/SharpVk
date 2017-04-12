using System;

namespace SharpVk.Interop
{
    /// <summary>
    /// 
    /// </summary>
    public unsafe struct SparseImageMemoryBind
    {
        /// <summary>
        /// 
        /// </summary>
        public ImageSubresource Subresource; 
        
        /// <summary>
        /// 
        /// </summary>
        public Offset3D Offset; 
        
        /// <summary>
        /// 
        /// </summary>
        public Extent3D Extent; 
        
        /// <summary>
        /// 
        /// </summary>
        public DeviceMemory Memory; 
        
        /// <summary>
        /// 
        /// </summary>
        public DeviceSize MemoryOffset; 
        
        /// <summary>
        /// 
        /// </summary>
        public SparseMemoryBindFlags Flags; 
    }
}
