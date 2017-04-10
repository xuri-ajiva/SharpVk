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
        public WaylandSurfaceCreateInfo(StructureType sType, void* next, WaylandSurfaceCreateFlags flags, IntPtr display, IntPtr surface)
        {
            this.SType = sType;
            this.Next = next;
            this.Flags = flags;
            this.Display = display;
            this.Surface = surface;
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
