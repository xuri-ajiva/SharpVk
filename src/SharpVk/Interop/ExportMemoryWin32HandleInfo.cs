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
        public ExportMemoryWin32HandleInfo(StructureType sType, void* next, SECURITY_ATTRIBUTES* attributes, uint dwAccess, IntPtr name)
        {
            this.SType = sType;
            this.Next = next;
            this.Attributes = attributes;
            this.DwAccess = dwAccess;
            this.Name = name;
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
