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
