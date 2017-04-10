using System;

namespace SharpVk.Interop
{
    /// <summary>
    /// 
    /// </summary>
    public unsafe struct IOSSurfaceCreateInfo
    {
        /// <summary>
        /// 
        /// </summary>
        public IOSSurfaceCreateInfo(StructureType sType, void* next, IOSSurfaceCreateFlags flags, void* view)
        {
            this.SType = sType;
            this.Next = next;
            this.Flags = flags;
            this.View = view;
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
        public IOSSurfaceCreateFlags Flags; 
        
        /// <summary>
        /// 
        /// </summary>
        public void* View; 
    }
}
