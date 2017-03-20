using System;

namespace SharpVk
{
    /// <summary>
    /// 
    /// </summary>
    public struct MemoryHeap
    {
        /// <summary>
        /// 
        /// </summary>
        public MemoryHeap(DeviceSize size, MemoryHeapFlags flags)
        {
            this.Size = size;
            this.Flags = flags;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public DeviceSize Size; 
        
        /// <summary>
        /// 
        /// </summary>
        public MemoryHeapFlags Flags; 
    }
}
