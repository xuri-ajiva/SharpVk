using System;

namespace SharpVk.Interop
{
    /// <summary>
    /// 
    /// </summary>
    public unsafe struct IOSSurfaceCreateInfo
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
        public IOSSurfaceCreateFlags Flags; 
        
        /// <summary>
        /// 
        /// </summary>
        public void* View; 
    }
}
