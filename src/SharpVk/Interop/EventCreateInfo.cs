using System;

namespace SharpVk.Interop
{
    /// <summary>
    /// 
    /// </summary>
    public unsafe struct EventCreateInfo
    {
        /// <summary>
        /// 
        /// </summary>
        public EventCreateInfo(StructureType sType, void* next, EventCreateFlags flags)
        {
            this.SType = sType;
            this.Next = next;
            this.Flags = flags;
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
        public EventCreateFlags Flags; 
    }
}
