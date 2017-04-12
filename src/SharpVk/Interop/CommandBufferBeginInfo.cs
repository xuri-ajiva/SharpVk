using System;

namespace SharpVk.Interop
{
    /// <summary>
    /// 
    /// </summary>
    public unsafe struct CommandBufferBeginInfo
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
        public CommandBufferUsageFlags Flags; 
        
        /// <summary>
        /// 
        /// </summary>
        public CommandBufferInheritanceInfo* InheritanceInfo; 
    }
}
