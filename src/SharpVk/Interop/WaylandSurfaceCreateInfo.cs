using System;

namespace SharpVk.Interop
{
    /// <summary>
    /// 
    /// </summary>
    public unsafe struct WaylandSurfaceCreateInfo
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
        public WaylandSurfaceCreateFlags Flags; 
        
        /// <summary>
        /// 
        /// </summary>
        public IntPtr Display; 
        
        /// <summary>
        /// 
        /// </summary>
        public IntPtr Surface; 
    }
}
