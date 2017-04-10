using System;

namespace SharpVk.Interop
{
    /// <summary>
    /// 
    /// </summary>
    public unsafe struct BindBufferMemoryInfo
    {
        /// <summary>
        /// 
        /// </summary>
        public BindBufferMemoryInfo(StructureType sType, void* next, Buffer buffer, DeviceMemory memory, DeviceSize memoryOffset, uint deviceIndexCount, uint* deviceIndices)
        {
            this.SType = sType;
            this.Next = next;
            this.Buffer = buffer;
            this.Memory = memory;
            this.MemoryOffset = memoryOffset;
            this.DeviceIndexCount = deviceIndexCount;
            this.DeviceIndices = deviceIndices;
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
        public Buffer Buffer; 
        
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
        public uint DeviceIndexCount; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint* DeviceIndices; 
    }
}
