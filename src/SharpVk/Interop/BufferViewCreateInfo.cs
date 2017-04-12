using System;

namespace SharpVk.Interop
{
    /// <summary>
    /// 
    /// </summary>
    public unsafe struct BufferViewCreateInfo
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
        public BufferViewCreateFlags Flags; 
        
        /// <summary>
        /// 
        /// </summary>
        public Buffer Buffer; 
        
        /// <summary>
        /// 
        /// </summary>
        public Format Format; 
        
        /// <summary>
        /// 
        /// </summary>
        public DeviceSize Offset; 
        
        /// <summary>
        /// 
        /// </summary>
        public DeviceSize Range; 
    }
}
