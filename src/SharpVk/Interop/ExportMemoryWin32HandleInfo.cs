using System;

namespace SharpVk.Interop
{
    /// <summary>
    /// 
    /// </summary>
    public unsafe struct ExportMemoryWin32HandleInfo
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
        public SECURITY_ATTRIBUTES* Attributes; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint DwAccess; 
        
        /// <summary>
        /// 
        /// </summary>
        public IntPtr Name; 
    }
}
