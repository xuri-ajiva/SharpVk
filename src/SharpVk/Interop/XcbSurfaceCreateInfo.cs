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
