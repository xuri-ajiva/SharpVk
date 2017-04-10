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
        public CommandBufferBeginInfo(StructureType sType, void* next, CommandBufferUsageFlags flags, CommandBufferInheritanceInfo* inheritanceInfo)
        {
            this.SType = sType;
            this.Next = next;
            this.Flags = flags;
            this.InheritanceInfo = inheritanceInfo;
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
        public CommandBufferUsageFlags Flags; 
        
        /// <summary>
        /// 
        /// </summary>
        public CommandBufferInheritanceInfo* InheritanceInfo; 
    }
}
