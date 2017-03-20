using System;

namespace SharpVk
{
    /// <summary>
    /// 
    /// </summary>
    public struct MemoryType
    {
        /// <summary>
        /// 
        /// </summary>
        public MemoryType(MemoryPropertyFlags propertyFlags, uint heapIndex)
        {
            this.PropertyFlags = propertyFlags;
            this.HeapIndex = heapIndex;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public MemoryPropertyFlags PropertyFlags; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint HeapIndex; 
    }
}
