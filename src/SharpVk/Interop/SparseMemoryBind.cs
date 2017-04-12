using System;

namespace SharpVk.Interop
{
    /// <summary>
    /// 
    /// </summary>
    public unsafe struct SparseMemoryBind
    {
        /// <summary>
        /// 
        /// </summary>
        public DeviceSize ResourceOffset; 
        
        /// <summary>
        /// 
        /// </summary>
        public DeviceSize Size; 
        
        /// <summary>
        /// 
        /// </summary>
        public DeviceMemory Memory; 
        
        /// <summary>
        /// 
        /// </summary>
        public DeviceSize MemoryOffset; 
        
        /// <summary>
        /// 
        /// </summary>
        public SparseMemoryBindFlags Flags; 
    }
}
