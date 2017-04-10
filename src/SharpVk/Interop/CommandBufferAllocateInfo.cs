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
        public CommandBufferAllocateInfo(StructureType sType, void* next, CommandPool commandPool, CommandBufferLevel level, uint commandBufferCount)
        {
            this.SType = sType;
            this.Next = next;
            this.CommandPool = commandPool;
            this.Level = level;
            this.CommandBufferCount = commandBufferCount;
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
