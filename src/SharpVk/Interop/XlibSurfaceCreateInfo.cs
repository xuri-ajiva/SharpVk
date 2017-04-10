using System;

namespace SharpVk.Interop
{
    /// <summary>
    /// 
    /// </summary>
    public unsafe struct XlibSurfaceCreateInfo
    {
        /// <summary>
        /// 
        /// </summary>
        public XlibSurfaceCreateInfo(StructureType sType, void* next, XlibSurfaceCreateFlags flags, IntPtr* dpy, IntPtr window)
        {
            this.SType = sType;
            this.Next = next;
            this.Flags = flags;
            this.Dpy = dpy;
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
        public XlibSurfaceCreateFlags Flags; 
        
        /// <summary>
        /// 
        /// </summary>
        public IntPtr* Dpy; 
        
        /// <summary>
        /// 
        /// </summary>
        public IntPtr Window; 
    }
}
