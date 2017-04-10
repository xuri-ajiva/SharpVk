using System;

namespace SharpVk.Interop
{
    /// <summary>
    /// 
    /// </summary>
    public unsafe struct MirSurfaceCreateInfo
    {
        /// <summary>
        /// 
        /// </summary>
        public MirSurfaceCreateInfo(StructureType sType, void* next, MirSurfaceCreateFlags flags, IntPtr* connection, IntPtr* mirSurface)
        {
            this.SType = sType;
            this.Next = next;
            this.Flags = flags;
            this.Connection = connection;
            this.MirSurface = mirSurface;
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
        public MirSurfaceCreateFlags Flags; 
        
        /// <summary>
        /// 
        /// </summary>
        public IntPtr* Connection; 
        
        /// <summary>
        /// 
        /// </summary>
        public IntPtr* MirSurface; 
    }
}
