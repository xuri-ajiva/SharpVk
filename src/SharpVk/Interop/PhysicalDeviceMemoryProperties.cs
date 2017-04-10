using System;

namespace SharpVk.Interop
{
    /// <summary>
    /// 
    /// </summary>
    public unsafe struct PhysicalDeviceMemoryProperties
    {
        /// <summary>
        /// 
        /// </summary>
        public PhysicalDeviceMemoryProperties(uint memoryTypeCount, MemoryType memoryTypes, uint memoryHeapCount, MemoryHeap memoryHeaps)
        {
            this.MemoryTypeCount = memoryTypeCount;
            this.MemoryTypes = memoryTypes;
            this.MemoryHeapCount = memoryHeapCount;
            this.MemoryHeaps = memoryHeaps;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MemoryTypeCount; 
        
        /// <summary>
        /// 
        /// </summary>
        public MemoryType MemoryTypes; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint MemoryHeapCount; 
        
        /// <summary>
        /// 
        /// </summary>
        public MemoryHeap MemoryHeaps; 
    }
}
