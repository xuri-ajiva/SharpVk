using System;

namespace SharpVk.Interop
{
    /// <summary>
    /// 
    /// </summary>
    public unsafe struct SemaphoreCreateInfo
    {
        /// <summary>
        /// 
        /// </summary>
        public SemaphoreCreateInfo(StructureType sType, void* next, SemaphoreCreateFlags flags)
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
        public SemaphoreCreateFlags Flags; 
    }
}
