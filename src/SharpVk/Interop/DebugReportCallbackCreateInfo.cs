using System;

namespace SharpVk.Interop
{
    /// <summary>
    /// 
    /// </summary>
    public unsafe struct DebugReportCallbackCreateInfo
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
        public DebugReportFlags Flags; 
        
        /// <summary>
        /// 
        /// </summary>
        public IntPtr Callback; 
        
        /// <summary>
        /// 
        /// </summary>
        public void* UserData; 
    }
}
