using System;

namespace SharpVk.Interop
{
    /// <summary>
    /// 
    /// </summary>
    public unsafe struct AndroidSurfaceCreateInfo
    {
        /// <summary>
        /// 
        /// </summary>
        public AndroidSurfaceCreateInfo(StructureType sType, void* next, AndroidSurfaceCreateFlags flags, IntPtr* window)
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
        public AndroidSurfaceCreateFlags Flags; 
        
        /// <summary>
        /// 
        /// </summary>
        public IntPtr* Window; 
    }
}
