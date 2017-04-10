using System;

namespace SharpVk.Interop
{
    /// <summary>
    /// 
    /// </summary>
    public unsafe struct DedicatedAllocationMemoryAllocateInfo
    {
        /// <summary>
        /// 
        /// </summary>
        public DedicatedAllocationMemoryAllocateInfo(StructureType sType, void* next, Image image, Buffer buffer)
        {
            this.SType = sType;
            this.Next = next;
            this.Image = image;
            this.Buffer = buffer;
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
        public Image Image; 
        
        /// <summary>
        /// 
        /// </summary>
        public Buffer Buffer; 
    }
}
