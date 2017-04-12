using System;

namespace SharpVk.Interop
{
    /// <summary>
    /// 
    /// </summary>
    public unsafe struct CommandBufferAllocateInfo
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
        public CommandPool CommandPool; 
        
        /// <summary>
        /// 
        /// </summary>
        public CommandBufferLevel Level; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint CommandBufferCount; 
    }
}
