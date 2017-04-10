using System;

namespace SharpVk.Interop
{
    /// <summary>
    /// 
    /// </summary>
    public unsafe struct FenceCreateInfo
    {
        /// <summary>
        /// 
        /// </summary>
        public FenceCreateInfo(StructureType sType, void* next, FenceCreateFlags flags)
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
        public FenceCreateFlags Flags; 
    }
}
