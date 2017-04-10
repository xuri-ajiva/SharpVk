using System;

namespace SharpVk.Interop
{
    /// <summary>
    /// 
    /// </summary>
    public unsafe struct XcbSurfaceCreateInfo
    {
        /// <summary>
        /// 
        /// </summary>
        public XcbSurfaceCreateInfo(StructureType sType, void* next, XcbSurfaceCreateFlags flags, IntPtr* connection, IntPtr window)
        {
            this.SType = sType;
            this.Next = next;
            this.Flags = flags;
            this.Connection = connection;
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
        public XcbSurfaceCreateFlags Flags; 
        
        /// <summary>
        /// 
        /// </summary>
        public IntPtr* Connection; 
        
        /// <summary>
        /// 
        /// </summary>
        public IntPtr Window; 
    }
}
