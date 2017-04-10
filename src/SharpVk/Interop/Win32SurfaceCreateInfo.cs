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
        public Win32SurfaceCreateInfo(StructureType sType, void* next, Win32SurfaceCreateFlags flags, IntPtr hinstance, IntPtr hwnd)
        {
            this.SType = sType;
            this.Next = next;
            this.Flags = flags;
            this.Hinstance = hinstance;
            this.Hwnd = hwnd;
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
