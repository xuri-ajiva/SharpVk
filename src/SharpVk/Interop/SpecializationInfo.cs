using System;

namespace SharpVk.Interop
{
    /// <summary>
    /// 
    /// </summary>
    public unsafe struct SpecializationInfo
    {
        /// <summary>
        /// 
        /// </summary>
        public uint MapEntryCount; 
        
        /// <summary>
        /// 
        /// </summary>
        public SpecializationMapEntry* MapEntries; 
        
        /// <summary>
        /// 
        /// </summary>
        public HostSize DataSize; 
        
        /// <summary>
        /// 
        /// </summary>
        public void* Data; 
    }
}
