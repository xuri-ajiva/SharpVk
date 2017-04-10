using System;

namespace SharpVk.Interop
{
    /// <summary>
    /// 
    /// </summary>
    public unsafe struct MacOSSurfaceCreateInfo
    {
        /// <summary>
        /// 
        /// </summary>
        public MacOSSurfaceCreateInfo(StructureType sType, void* next, MacOSSurfaceCreateFlags flags, void* view)
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
        public MacOSSurfaceCreateFlags Flags; 
        
        /// <summary>
        /// 
        /// </summary>
        public void* View; 
    }
}
