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
