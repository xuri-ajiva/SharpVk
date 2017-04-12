using System;

namespace SharpVk.Interop
{
    /// <summary>
    /// 
    /// </summary>
    public unsafe struct ImportMemoryWin32HandleInfo
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
        public ExternalMemoryHandleTypeFlags HandleType; 
        
        /// <summary>
        /// 
        /// </summary>
        public IntPtr Handle; 
    }
}
