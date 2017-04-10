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
        public DebugReportCallbackCreateInfo(StructureType sType, void* next, DebugReportFlags flags, IntPtr pfnCallback, void* userData)
        {
            this.SType = sType;
            this.Next = next;
            this.Flags = flags;
            this.PfnCallback = pfnCallback;
            this.UserData = userData;
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
        public DebugReportFlags Flags; 
        
        /// <summary>
        /// 
        /// </summary>
        public IntPtr PfnCallback; 
        
        /// <summary>
        /// 
        /// </summary>
        public void* UserData; 
    }
}
