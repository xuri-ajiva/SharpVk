using System;

namespace SharpVk.Interop
{
    /// <summary>
    /// 
    /// </summary>
    public unsafe struct ViSurfaceCreateInfo
    {
        /// <summary>
        /// 
        /// </summary>
        public ViSurfaceCreateInfo(StructureType sType, void* next, ViSurfaceCreateFlags flags, void* window)
        {
            this.SType = sType;
            this.Next = next;
            this.Flags = flags;
            this.Window = window;
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
        public ViSurfaceCreateFlags Flags; 
        
        /// <summary>
        /// 
        /// </summary>
        public void* Window; 
    }
}
