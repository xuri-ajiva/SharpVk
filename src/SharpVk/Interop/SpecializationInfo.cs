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
        public SpecializationInfo(uint mapEntryCount, SpecializationMapEntry* mapEntries, HostSize dataSize, void* data)
        {
            this.MapEntryCount = mapEntryCount;
            this.MapEntries = mapEntries;
            this.DataSize = dataSize;
            this.Data = data;
        }
        
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
