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
        public SparseImageMemoryBind(ImageSubresource subresource, Offset3D offset, Extent3D extent, DeviceMemory memory, DeviceSize memoryOffset, SparseMemoryBindFlags flags)
        {
            this.Subresource = subresource;
            this.Offset = offset;
            this.Extent = extent;
            this.Memory = memory;
            this.MemoryOffset = memoryOffset;
            this.Flags = flags;
        }
        
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
