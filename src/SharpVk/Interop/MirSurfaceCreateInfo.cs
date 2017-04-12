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
