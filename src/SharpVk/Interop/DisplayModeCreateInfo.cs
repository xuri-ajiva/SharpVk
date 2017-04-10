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
        public DisplayModeCreateInfo(StructureType sType, void* next, DisplayModeCreateFlags flags, DisplayModeParameters parameters)
        {
            this.SType = sType;
            this.Next = next;
            this.Flags = flags;
            this.Parameters = parameters;
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
        public DisplayModeCreateFlags Flags; 
        
        /// <summary>
        /// 
        /// </summary>
        public DisplayModeParameters Parameters; 
    }
}
