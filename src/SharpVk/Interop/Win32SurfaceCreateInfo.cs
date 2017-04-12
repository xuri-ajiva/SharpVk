using System;

namespace SharpVk.Interop
{
    /// <summary>
    /// 
    /// </summary>
    public unsafe struct Win32SurfaceCreateInfo
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
        public Win32SurfaceCreateFlags Flags; 
        
        /// <summary>
        /// 
        /// </summary>
        public IntPtr Hinstance; 
        
        /// <summary>
        /// 
        /// </summary>
        public IntPtr Hwnd; 
    }
}
