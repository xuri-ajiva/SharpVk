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
