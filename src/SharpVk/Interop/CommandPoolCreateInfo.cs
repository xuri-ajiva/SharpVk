using System;

namespace SharpVk.Interop
{
    /// <summary>
    /// 
    /// </summary>
    public unsafe struct CommandPoolCreateInfo
    {
        /// <summary>
        /// 
        /// </summary>
        public CommandPoolCreateInfo(StructureType sType, void* next, CommandPoolCreateFlags flags, uint queueFamilyIndex)
        {
            this.SType = sType;
            this.Next = next;
            this.Flags = flags;
            this.QueueFamilyIndex = queueFamilyIndex;
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
        public CommandPoolCreateFlags Flags; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint QueueFamilyIndex; 
    }
}
