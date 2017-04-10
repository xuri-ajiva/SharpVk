using System;

namespace SharpVk.Interop
{
    /// <summary>
    /// 
    /// </summary>
    public unsafe struct SparseMemoryBind
    {
        /// <summary>
        /// 
        /// </summary>
        public SparseMemoryBind(DeviceSize resourceOffset, DeviceSize size, DeviceMemory memory, DeviceSize memoryOffset, SparseMemoryBindFlags flags)
        {
            this.ResourceOffset = resourceOffset;
            this.Size = size;
            this.Memory = memory;
            this.MemoryOffset = memoryOffset;
            this.Flags = flags;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public DeviceSize ResourceOffset; 
        
        /// <summary>
        /// 
        /// </summary>
        public DeviceSize Size; 
        
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
