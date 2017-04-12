using System;

namespace SharpVk.Interop
{
    /// <summary>
    /// 
    /// </summary>
    public unsafe struct DisplayModeCreateInfo
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
        public DisplayModeCreateFlags Flags; 
        
        /// <summary>
        /// 
        /// </summary>
        public DisplayModeParameters Parameters; 
    }
}
