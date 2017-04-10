using System;

namespace SharpVk.Interop
{
    /// <summary>
    /// 
    /// </summary>
    public unsafe struct PhysicalDeviceMemoryProperties2
    {
        /// <summary>
        /// 
        /// </summary>
        public PhysicalDeviceMemoryProperties2(StructureType sType, void* next, PhysicalDeviceMemoryProperties memoryProperties)
        {
            this.SType = sType;
            this.Next = next;
            this.MemoryProperties = memoryProperties;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public StructureType SType; 
        
        /// <summary>
        /// 
        /// </summary>
        public void* Next; 
        
        /// <summary>
        /// 
        /// </summary>
        public PhysicalDeviceMemoryProperties MemoryProperties; 
    }
}
