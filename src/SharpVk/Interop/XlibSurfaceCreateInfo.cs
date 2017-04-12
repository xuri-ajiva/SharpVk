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
